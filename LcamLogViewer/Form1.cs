using Contec_MCS.Util;
using LcamLogViewer.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LcamLogViewer
{
    public partial class Form1 : Form
    {
        LcamLog lcamLog = new LcamLog();
        public Form1()
        {
            InitializeComponent();
            lcamLog.columnFilter = new List<string>();
            lcamLog.currentColumn = new List<string>();
            lcamLog.fileList = new List<string>();
            lcamLog.timeList = new List<DateTime>();
            LoadFilterFiles(true);
            //ColumnList.Items.AddRange(lcamLog.columnFilter.ToArray());
            //string inputFile = @"C:\Users\User\Documents\Visual Studio 2019\Projects\LcamLogViewer\safran_hdr_backup_20220112_02.csv";
            //ReadLogFile(inputFile);
            //new
            //toCsv
            //time update
        }
        public void ReadLogFile(string filePath)
        {
            if (lcamLog.fileList.Contains(filePath))
            {
                return;
            }
            CT_CSV.Load_CSVData(LogViewer, filePath, Encoding.UTF8, lcamLog);

            StartTime.Value = lcamLog.timeList.Min();
            EndTime.Value = lcamLog.timeList.Max();
            CurrentColumnList.Items.Clear();
            CurrentColumnList.Items.AddRange(lcamLog.currentColumn.ToArray());
            lcamLog.fileList.Add(filePath);
        }
        public void RefreshLogFile()
        {

            lcamLog.timeList.Clear();
            LogViewer.Rows.Clear();
            LogViewer.Columns.Clear();
            LogViewer.DataSource = null;
            LogViewer.Refresh();
            for (int i =0; i < lcamLog.fileList.Count; i++)
            {
                string filename = lcamLog.fileList[i];
                CT_CSV.Load_CSVData(LogViewer, filename, Encoding.UTF8, lcamLog);
            }

            StartTime.Value = lcamLog.timeList.Min();
            EndTime.Value = lcamLog.timeList.Max();
            CurrentColumnList.Items.Clear();
            CurrentColumnList.Items.AddRange(lcamLog.currentColumn.ToArray());
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            // Drag & Drop이 완료되면, 파일 경로를 확인하여 표시
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files.Length > 0 && File.Exists(files[0]))
            {
                string filePath = files[0];

                ReadLogFile(filePath);
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SearchColumn.
        }
        string checkFilterDirectory()
        {
            string directory = Directory.GetParent(Application.ExecutablePath) + "\\Filter";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            return directory;
        }
        void SaveFilterFile(string newFileName)
        {
            if(lcamLog.columnFilter.Count == 0)
            {
                return;
            }
            string directory = checkFilterDirectory();
            File.WriteAllLines(directory + "\\" + newFileName + ".txt", lcamLog.columnFilter.ToArray());
        }
        void LoadFilterFiles(bool reSelect = false)
        {
            string directory = checkFilterDirectory();

            string[] files = Directory.GetFiles(directory, "*.txt");
            FilterList.Items.Clear();
            for (int i =0; i < files.Length; i++)
            {
                FileInfo fi = new FileInfo(files[i]);
                FilterList.Items.Add(fi.Name.Replace(".txt", ""));
            }
            if (reSelect)
            {
                FilterList.SelectedIndex = 0;
                LoadFilterFile(checkFilterDirectory() + "\\" + FilterList.SelectedItem.ToString() + ".txt");
            }
        }

        void LoadFilterFile(string filename)
        {
            if (!File.Exists(filename))
            {
                MessageBox.Show(filename + " 파일이 정상적이지 않습니다.");
            }

            lcamLog.columnFilter.Clear();
            lcamLog.columnFilter = File.ReadAllLines(filename).ToList();
            ColumnList.Items.Clear();
            ColumnList.Items.AddRange(lcamLog.columnFilter.ToArray());
        }
        public void addColumnFilter()
        {
            if(CurrentColumnList.SelectedItem == null)
            {
                return;
            }
            string newFilterColumn = CurrentColumnList.SelectedItem.ToString();
            if (!lcamLog.columnFilter.Contains(newFilterColumn))
            {
                lcamLog.columnFilter.Add(newFilterColumn);
                ColumnList.Items.Clear();
                ColumnList.Items.AddRange(lcamLog.columnFilter.ToArray());
            }
        }
        private void SearchColumnBtn_Click(object sender, EventArgs e)
        {
            addColumnFilter();
        }

        private void CurrentColumnList_DoubleClick(object sender, EventArgs e)
        {
            addColumnFilter();
        }

        private void SearchColumnFilter_TextChanged(object sender, EventArgs e)
        {
            CurrentColumnList.Items.Clear();
            List<string> search = lcamLog.currentColumn.FindAll(x => x.ToLowerInvariant().Contains(SearchColumnFilter.Text.ToLowerInvariant()));
            CurrentColumnList.Items.AddRange(search.ToArray());
        }

        private void removeColumn_Click(object sender, EventArgs e)
        {

            if (ColumnList.SelectedItem == null)
            {
                return;
            }

            string removeFilterColumn = ColumnList.SelectedItem.ToString();
            if (lcamLog.columnFilter.Contains(removeFilterColumn))
            {
                lcamLog.columnFilter.Remove(removeFilterColumn);
                ColumnList.Items.Clear();
                ColumnList.Items.AddRange(lcamLog.columnFilter.ToArray());
            }
        }

        private void SaveFilterFileBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(SaveFilterFileTxt.Text))
            {
                MessageBox.Show("파일명이 입력되지 않았습니다.");
            }
            SaveFilterFile(SaveFilterFileTxt.Text);
            LoadFilterFiles();
        }

        private void FilterList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FilterList.SelectedItem != null)
            {
                SaveFilterFileTxt.Text = FilterList.SelectedItem.ToString();
            }
        }

        private void FilterList_DoubleClick(object sender, EventArgs e)
        {
            if (FilterList.SelectedItem != null)
            {
                LoadFilterFile(checkFilterDirectory() + "\\" + FilterList.SelectedItem.ToString() + ".txt");
            }
        }

        private void DeleteFilterFileBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(SaveFilterFileTxt.Text))
            {
                MessageBox.Show("파일명이 입력되지 않았습니다.");
            }
            string directory = checkFilterDirectory();
            string removeFile = directory + "\\" + SaveFilterFileTxt.Text + ".txt";
            if (!File.Exists(removeFile))
            {
                MessageBox.Show(removeFile + " 파일이 존재하지 않습니다.");
            }
            File.Delete(removeFile);
            LoadFilterFiles();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            lcamLog.timeList.Clear();
            lcamLog.startTime = DateTime.MinValue;
            lcamLog.endTime = DateTime.MinValue;
            lcamLog.fileList.Clear();
            lcamLog.currentColumn.Clear();
            CurrentColumnList.Items.Clear();
            LogViewer.Rows.Clear();
            LogViewer.Columns.Clear();
            LogViewer.DataSource = null;
            LogViewer.Refresh();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshLogFile();
        }

        private void StartTime_ValueChanged(object sender, EventArgs e)
        {
            lcamLog.startTime = StartTime.Value;
        }

        private void EndTime_ValueChanged(object sender, EventArgs e)
        {
            lcamLog.endTime = EndTime.Value;
        }

        private void CsvSaveButton_Click(object sender, EventArgs e)
        {
            CT_CSV.Save_CSVData(LogViewer);
        }
    }
}
