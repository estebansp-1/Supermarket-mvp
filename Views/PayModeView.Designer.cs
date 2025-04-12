namespace Supermarket_mvp.Views
{
    partial class PayModeView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgPayMode = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPagePayModeDetail = new TabPage();
            BtnCancel = new Button();
            BtnSave = new Button();
            label5 = new Label();
            TxtPayModeObservation = new TextBox();
            label4 = new Label();
            TxtPayModeName = new TextBox();
            TxtPayModeId = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 29);
            label1.MaximumSize = new Size(500, 500);
            label1.Name = "label1";
            label1.Size = new Size(210, 57);
            label1.TabIndex = 0;
            label1.Text = "PAY MODE";
            label1.UseCompatibleTextRendering = true;
            label1.UseWaitCursor = true;
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.InitialImage = Properties.Resources.buy;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 116);
            panel1.TabIndex = 2;
            panel1.UseWaitCursor = true;
            panel1.Paint += panel1_Paint;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 116);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 334);
            tabControl1.TabIndex = 3;
            tabControl1.UseWaitCursor = true;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(792, 306);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            tabPagePayModeList.UseWaitCursor = true;
            tabPagePayModeList.Click += tabPagePayModeList_Click;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(586, 251);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(167, 47);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.UseWaitCursor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(586, 192);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(167, 47);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            BtnDelete.UseWaitCursor = true;
            BtnDelete.Click += button1_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(586, 134);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(167, 46);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            BtnEdit.UseWaitCursor = true;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(586, 74);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(167, 51);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            BtnNew.UseWaitCursor = true;
            // 
            // DgPayMode
            // 
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(27, 74);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.Size = new Size(524, 224);
            DgPayMode.TabIndex = 3;
            DgPayMode.UseWaitCursor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(509, 24);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(40, 40);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            BtnSearch.UseWaitCursor = true;
            BtnSearch.Click += BtnSearch_Click;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(25, 36);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(478, 23);
            TxtSearch.TabIndex = 1;
            TxtSearch.UseWaitCursor = true;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 14);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Pay Mode";
            label2.UseWaitCursor = true;
            label2.Click += label2_Click;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Controls.Add(label5);
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(792, 306);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            tabPagePayModeDetail.UseWaitCursor = true;
            tabPagePayModeDetail.Click += tabPagePayModeDetail_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(146, 251);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 44);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.UseWaitCursor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(44, 250);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 44);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.UseWaitCursor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 146);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 5;
            label5.Text = "Pay Mode Observation";
            label5.UseWaitCursor = true;
            label5.Click += label5_Click;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.Location = new Point(30, 163);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.ScrollBars = ScrollBars.Horizontal;
            TxtPayModeObservation.Size = new Size(365, 75);
            TxtPayModeObservation.TabIndex = 4;
            TxtPayModeObservation.UseWaitCursor = true;
            TxtPayModeObservation.TextChanged += TxtPayModeObservation_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 81);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 3;
            label4.Text = "Pay Mode Name";
            label4.UseWaitCursor = true;
            label4.Click += label4_Click;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(30, 98);
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(365, 23);
            TxtPayModeName.TabIndex = 2;
            TxtPayModeName.UseWaitCursor = true;
            TxtPayModeName.TextChanged += TxtPayModeName_TextChanged;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.Location = new Point(30, 38);
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(170, 23);
            TxtPayModeId.TabIndex = 1;
            TxtPayModeId.UseWaitCursor = true;
            TxtPayModeId.TextChanged += TxtPayModeId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 20);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 0;
            label3.Text = "Pay Mode Id";
            label3.UseWaitCursor = true;
            label3.Click += label3_Click;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "PayModeView";
            Text = "Pay Mode Management";
            UseWaitCursor = true;
            Load += PayModeView_Load;
            DockChanged += PayModeView_DockChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private Label label2;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private DataGridView DgPayMode;
        private Button BtnNew;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnClose;
        private Label label3;
        private TextBox TxtPayModeId;
        private Label label4;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeObservation;
        private Label label5;
        private Button BtnCancel;
        private Button BtnSave;
    }
}