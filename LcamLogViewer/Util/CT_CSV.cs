using LcamLogViewer.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Contec_MCS.Util
{
    public class CT_CSV
    {
        public CT_CSV()
        {
        }
        public static void Load_CSVDataTimeSetting(DataGridView LogViewer, string FilePath, Encoding OpenEncoding, LcamLog lcamLog)
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            DataGridViewTextBoxColumn dataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataGridViewCellStyle1.Format = "yyyy-MM-dd hh:mm:ss";
            dataGridViewCellStyle1.NullValue = null;
            LogViewer.Columns.Add(dataGridViewTextBoxColumn);
            dataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTextBoxColumn.HeaderText = "time";
            dataGridViewTextBoxColumn.Name = "time";
            dataGridViewTextBoxColumn.ReadOnly = true;

            dataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            CultureInfo koKR = new CultureInfo("ko-KR");
            List<string> columns = new List<string>();
            CsvFileReader reader = new CsvFileReader(FilePath, OpenEncoding, EmptyLineBehavior.NoColumns);
            reader.ReadRow(columns);
            while (reader.ReadRow(columns))
            {
                DateTime dateValue;

                if (!DateTime.TryParseExact(columns[0], "yyyy-MM-dd hh:mm:ss", koKR, DateTimeStyles.None, out dateValue))
                {
                    MessageBox.Show("시간 변환이 정상적으로 이뤄지지 않았습니다.");
                    break;
                }
                bool isAddValue = false;
                if (lcamLog.startTime == DateTime.MinValue)
                {
                    isAddValue = true;
                }
                else 
                {
                    int startValue = DateTime.Compare(lcamLog.startTime, dateValue); //-1 or 0
                    int endValue = DateTime.Compare(lcamLog.endTime, dateValue); // 0 or 1
                    isAddValue = ((startValue == -1 || startValue == 0) && (endValue == 1 || startValue == 0));
                }
                if(isAddValue)
                {
                    int lastIndex = LogViewer.Rows.Add();
                    LogViewer.Rows[lastIndex].Cells[0].Value = dateValue;
                    lcamLog.timeList.Add(dateValue);
                }
            }

            reader.Dispose();
        }
        public static bool containLogTime(string FilePath, Encoding OpenEncoding, LcamLog lcamLog)
        {
            CultureInfo koKR = new CultureInfo("ko-KR");
            List<string> columns = new List<string>();
            CsvFileReader reader = new CsvFileReader(FilePath, OpenEncoding, EmptyLineBehavior.NoColumns);
            reader.ReadRow(columns);
            while (reader.ReadRow(columns))
            {
                DateTime dateValue;

                if (!DateTime.TryParseExact(columns[0], "yyyy-MM-dd hh:mm:ss", koKR, DateTimeStyles.None, out dateValue))
                {
                    MessageBox.Show("시간 변환이 정상적으로 이뤄지지 않았습니다.");
                    break;
                }

                if (lcamLog.timeList.Contains(dateValue)){
                    reader.Dispose();
                    return true;
                }
            }

            reader.Dispose();
            return false;
        }
        public static void Load_CSVData(DataGridView LogViewer, string FilePath, Encoding OpenEncoding, LcamLog lcamLog)
        {
            CultureInfo koKR = new CultureInfo("ko-KR");
            if (LogViewer.Columns.Count == 0)
            {
                Load_CSVDataTimeSetting(LogViewer, FilePath, OpenEncoding, lcamLog);
            }
            else
            {
                if(!containLogTime(FilePath, OpenEncoding, lcamLog))
                {
                    MessageBox.Show("동일 시간대 파일이 아닙니다.");
                    return;
                }
            }
            CsvFileReader reader = new CsvFileReader(FilePath, OpenEncoding, EmptyLineBehavior.NoColumns);
            int startColumnIndex = LogViewer.Columns.Count;
            try
            {
                List<string> columns = new List<string>();
                List<int> dataColumnIndex = new List<int>();
                if (reader.ReadRow(columns))
                {
                    for (int i = 1; i < columns.Count; i++)
                    {
                        int index = lcamLog.columnFilter.FindIndex(x => x.Equals(columns[i]));
                        if (index >= 0)
                        {

                            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                            column.HeaderText = columns[i];
                            column.Name = columns[i];
                            column.ReadOnly = true;
                            LogViewer.Columns.Add(column);
                            dataColumnIndex.Add(i);
                        }
                        if (!lcamLog.currentColumn.Contains(columns[i]))
                        {
                            lcamLog.currentColumn.Add(columns[i]);
                        }
                    }
                    columns.Clear();
                    while (reader.ReadRow(columns))
                    {
                        int addIndex = startColumnIndex;
                        for (int i = 1; i < columns.Count; i++)
                        {
                            if (dataColumnIndex.Contains(i))
                            {

                                DateTime dateValue;

                                if (!DateTime.TryParseExact(columns[0], "yyyy-MM-dd hh:mm:ss", koKR, DateTimeStyles.None, out dateValue))
                                {
                                    MessageBox.Show("시간 변환이 정상적으로 이뤄지지 않았습니다.");
                                    break;
                                }

                                int lastIndex = lcamLog.timeList.IndexOf(dateValue);
                                if (lastIndex != -1)
                                {
                                    LogViewer.Rows[lastIndex].Cells[addIndex].Value = columns[i];
                                }
                                addIndex++;
                            }
                        }

                    }
                    reader.Dispose();
                }
            }
            catch (Exception exception)
            {
                Exception ex = exception;
                reader.Dispose();
                Console.WriteLine(string.Format("Error reading from {0}.\r\n\r\n{1}", FilePath, ex.Message));
            }
            LogViewer.Columns[0].Width = 150;
        }

        public static bool Save_CSVData(DataGridView LogViewer)
        {
            string FilePath = DateTime.Now.ToUniversalTime().ToString("yyyyMMddhhmmss") + ".csv";
            bool flag;
            CsvFileWriter writer = new CsvFileWriter(FilePath, Encoding.UTF8, true);
            try
            {
                List<string> columns = new List<string>();
                foreach(DataGridViewColumn dataGridViewColumn in LogViewer.Columns)
                {
                    columns.Add(dataGridViewColumn.HeaderText);
                }
                writer.WriteRow(columns);
                columns.Clear();
                foreach (DataGridViewRow dataGridViewRow in LogViewer.Rows)
                {
                    DataGridViewCellCollection dataGridViewCellCollection = dataGridViewRow.Cells;
                    for (int i = 0; i < (int)dataGridViewRow.Cells.Count; i++)
                    {
                        object TargetItem = dataGridViewCellCollection[i].Value;
                        if (TargetItem != null)
                        {
                            columns.Add(TargetItem.ToString());
                        }
                        else
                        {
                            columns.Add("");
                        }
                    }
                    writer.WriteRow(columns);
                    columns.Clear();
                }
                writer.Dispose();
                flag = true;
            }
            catch (Exception exception)
            {
                Exception ex = exception;
                writer.Dispose();
                Console.WriteLine(string.Format("Error writing to {0}.\r\n\r\n{1}", FilePath, ex.Message));
                flag = false;
            }
            return flag;
        }

        public static bool Save_CSVData(DataTable InputData, string FilePath, bool Append, Encoding SaveEncoding)
        {
            bool flag;
            CsvFileWriter writer = new CsvFileWriter(FilePath, SaveEncoding, Append);
            try
            {
                List<string> columns = new List<string>();
                foreach (DataColumn TargetColumn in InputData.Columns)
                {
                    columns.Add(TargetColumn.ColumnName);
                }
                writer.WriteRow(columns);
                columns.Clear();
                foreach (DataRow row in InputData.Rows)
                {
                    object[] itemArray = row.ItemArray;
                    for (int i = 0; i < (int)itemArray.Length; i++)
                    {
                        object TargetItem = itemArray[i];
                        if (TargetItem != null)
                        {
                            columns.Add(TargetItem.ToString());
                        }
                        else
                        {
                            columns.Add("");
                        }
                    }
                    writer.WriteRow(columns);
                    columns.Clear();
                }
                writer.Dispose();
                flag = true;
            }
            catch (Exception exception)
            {
                Exception ex = exception;
                writer.Dispose();
                Console.WriteLine(string.Format("Error writing to {0}.\r\n\r\n{1}", FilePath, ex.Message));
                flag = false;
            }
            return flag;
        }
    }
}
