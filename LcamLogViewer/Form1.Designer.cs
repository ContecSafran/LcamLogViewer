
namespace LcamLogViewer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveFilterFileBtn = new System.Windows.Forms.Button();
            this.SaveFilterFileTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteFilterFileBtn = new System.Windows.Forms.Button();
            this.CurrentColumnList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.SearchColumnBtn = new System.Windows.Forms.Button();
            this.SearchColumnFilter = new System.Windows.Forms.TextBox();
            this.ColumnList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.removeColumn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.FilterList = new System.Windows.Forms.ListBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.LogViewer = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CsvSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogViewer)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(966, 425);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(966, 450);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.LogViewer, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(966, 425);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.tableLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.CurrentColumnList, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.ColumnList, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.FilterList, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.RefreshButton, 0, 9);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 425);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel7.Controls.Add(this.SaveFilterFileBtn, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.SaveFilterFileTxt, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.DeleteFilterFileBtn, 3, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(500, 21);
            this.tableLayoutPanel7.TabIndex = 16;
            // 
            // SaveFilterFileBtn
            // 
            this.SaveFilterFileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveFilterFileBtn.Location = new System.Drawing.Point(300, 0);
            this.SaveFilterFileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SaveFilterFileBtn.Name = "SaveFilterFileBtn";
            this.SaveFilterFileBtn.Size = new System.Drawing.Size(100, 21);
            this.SaveFilterFileBtn.TabIndex = 13;
            this.SaveFilterFileBtn.Text = "필터 파일 저장";
            this.SaveFilterFileBtn.UseVisualStyleBackColor = true;
            this.SaveFilterFileBtn.Click += new System.EventHandler(this.SaveFilterFileBtn_Click);
            // 
            // SaveFilterFileTxt
            // 
            this.SaveFilterFileTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveFilterFileTxt.Location = new System.Drawing.Point(150, 0);
            this.SaveFilterFileTxt.Margin = new System.Windows.Forms.Padding(0);
            this.SaveFilterFileTxt.Name = "SaveFilterFileTxt";
            this.SaveFilterFileTxt.Size = new System.Drawing.Size(150, 21);
            this.SaveFilterFileTxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "필터 리스트";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeleteFilterFileBtn
            // 
            this.DeleteFilterFileBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteFilterFileBtn.Location = new System.Drawing.Point(400, 0);
            this.DeleteFilterFileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.DeleteFilterFileBtn.Name = "DeleteFilterFileBtn";
            this.DeleteFilterFileBtn.Size = new System.Drawing.Size(100, 21);
            this.DeleteFilterFileBtn.TabIndex = 10;
            this.DeleteFilterFileBtn.Text = "필터 파일 삭제";
            this.DeleteFilterFileBtn.UseVisualStyleBackColor = true;
            this.DeleteFilterFileBtn.Click += new System.EventHandler(this.DeleteFilterFileBtn_Click);
            // 
            // CurrentColumnList
            // 
            this.CurrentColumnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentColumnList.FormattingEnabled = true;
            this.CurrentColumnList.ItemHeight = 12;
            this.CurrentColumnList.Location = new System.Drawing.Point(3, 308);
            this.CurrentColumnList.Name = "CurrentColumnList";
            this.CurrentColumnList.Size = new System.Drawing.Size(494, 88);
            this.CurrentColumnList.TabIndex = 14;
            this.CurrentColumnList.DoubleClick += new System.EventHandler(this.CurrentColumnList_DoubleClick);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.SearchColumnBtn, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.SearchColumnFilter, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 284);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(500, 21);
            this.tableLayoutPanel5.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "전체 열 목록";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchColumnBtn
            // 
            this.SearchColumnBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchColumnBtn.Location = new System.Drawing.Point(430, 0);
            this.SearchColumnBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SearchColumnBtn.Name = "SearchColumnBtn";
            this.SearchColumnBtn.Size = new System.Drawing.Size(70, 21);
            this.SearchColumnBtn.TabIndex = 10;
            this.SearchColumnBtn.Text = "추가";
            this.SearchColumnBtn.UseVisualStyleBackColor = true;
            this.SearchColumnBtn.Click += new System.EventHandler(this.SearchColumnBtn_Click);
            // 
            // SearchColumnFilter
            // 
            this.SearchColumnFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchColumnFilter.Location = new System.Drawing.Point(100, 0);
            this.SearchColumnFilter.Margin = new System.Windows.Forms.Padding(0);
            this.SearchColumnFilter.Name = "SearchColumnFilter";
            this.SearchColumnFilter.Size = new System.Drawing.Size(330, 21);
            this.SearchColumnFilter.TabIndex = 11;
            this.SearchColumnFilter.TextChanged += new System.EventHandler(this.SearchColumnFilter_TextChanged);
            // 
            // ColumnList
            // 
            this.ColumnList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnList.FormattingEnabled = true;
            this.ColumnList.ItemHeight = 12;
            this.ColumnList.Location = new System.Drawing.Point(3, 192);
            this.ColumnList.Name = "ColumnList";
            this.ColumnList.Size = new System.Drawing.Size(494, 89);
            this.ColumnList.TabIndex = 12;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.29167F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.70833F));
            this.tableLayoutPanel6.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.removeColumn, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 168);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(500, 21);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "선택된 열 목록";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeColumn
            // 
            this.removeColumn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeColumn.Location = new System.Drawing.Point(286, 0);
            this.removeColumn.Margin = new System.Windows.Forms.Padding(0);
            this.removeColumn.Name = "removeColumn";
            this.removeColumn.Size = new System.Drawing.Size(214, 21);
            this.removeColumn.TabIndex = 10;
            this.removeColumn.Text = "Column 삭제";
            this.removeColumn.UseVisualStyleBackColor = true;
            this.removeColumn.Click += new System.EventHandler(this.removeColumn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.81818F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.18182F));
            this.tableLayoutPanel3.Controls.Add(this.EndTime, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.EndTimeLabel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 21);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(500, 21);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // EndTime
            // 
            this.EndTime.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.EndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTime.Location = new System.Drawing.Point(112, 3);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(385, 21);
            this.EndTime.TabIndex = 6;
            this.EndTime.ValueChanged += new System.EventHandler(this.EndTime_ValueChanged);
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndTimeLabel.Location = new System.Drawing.Point(2, 2);
            this.EndTimeLabel.Margin = new System.Windows.Forms.Padding(2);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Size = new System.Drawing.Size(105, 17);
            this.EndTimeLabel.TabIndex = 5;
            this.EndTimeLabel.Text = "End";
            this.EndTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.81818F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.18182F));
            this.tableLayoutPanel4.Controls.Add(this.StartTime, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.StartTimeLabel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(500, 21);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // StartTime
            // 
            this.StartTime.CustomFormat = "yyyy/MM/dd hh:mm:ss";
            this.StartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTime.Location = new System.Drawing.Point(112, 3);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(385, 21);
            this.StartTime.TabIndex = 6;
            this.StartTime.ValueChanged += new System.EventHandler(this.StartTime_ValueChanged);
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartTimeLabel.Location = new System.Drawing.Point(2, 2);
            this.StartTimeLabel.Margin = new System.Windows.Forms.Padding(2);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(105, 17);
            this.StartTimeLabel.TabIndex = 5;
            this.StartTimeLabel.Text = "Start";
            this.StartTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FilterList
            // 
            this.FilterList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterList.FormattingEnabled = true;
            this.FilterList.ItemHeight = 12;
            this.FilterList.Location = new System.Drawing.Point(0, 73);
            this.FilterList.Margin = new System.Windows.Forms.Padding(0);
            this.FilterList.Name = "FilterList";
            this.FilterList.Size = new System.Drawing.Size(500, 95);
            this.FilterList.TabIndex = 7;
            this.FilterList.SelectedIndexChanged += new System.EventHandler(this.FilterList_SelectedIndexChanged);
            this.FilterList.DoubleClick += new System.EventHandler(this.FilterList_DoubleClick);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RefreshButton.Location = new System.Drawing.Point(0, 399);
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(500, 26);
            this.RefreshButton.TabIndex = 17;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // LogViewer
            // 
            this.LogViewer.AllowDrop = true;
            this.LogViewer.AllowUserToAddRows = false;
            this.LogViewer.AllowUserToDeleteRows = false;
            this.LogViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogViewer.Location = new System.Drawing.Point(503, 3);
            this.LogViewer.Name = "LogViewer";
            this.LogViewer.ReadOnly = true;
            this.LogViewer.RowTemplate.Height = 23;
            this.LogViewer.Size = new System.Drawing.Size(460, 419);
            this.LogViewer.TabIndex = 3;
            this.LogViewer.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.LogViewer.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewButton,
            this.toolStripSeparator1,
            this.CsvSaveButton});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // NewButton
            // 
            this.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(35, 22);
            this.NewButton.Text = "New";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // CsvSaveButton
            // 
            this.CsvSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CsvSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("CsvSaveButton.Image")));
            this.CsvSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CsvSaveButton.Name = "CsvSaveButton";
            this.CsvSaveButton.Size = new System.Drawing.Size(58, 22);
            this.CsvSaveButton.Text = "Csv 저장";
            this.CsvSaveButton.Click += new System.EventHandler(this.CsvSaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogViewer)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView LogViewer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox CurrentColumnList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SearchColumnBtn;
        private System.Windows.Forms.ListBox ColumnList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.ListBox FilterList;
        private System.Windows.Forms.TextBox SearchColumnFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button SaveFilterFileBtn;
        private System.Windows.Forms.TextBox SaveFilterFileTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteFilterFileBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ToolStripButton CsvSaveButton;
    }
}

