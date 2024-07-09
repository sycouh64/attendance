namespace GSProject.Forms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            txbxPassword = new TextBox();
            txbxStudentNumber = new TextBox();
            btnLogin = new Button();
            dgvAttendances = new DataGridView();
            dgvAttendancesColumnNumber = new DataGridViewTextBoxColumn();
            dgvAttendancesColumnStudentNumber = new DataGridViewTextBoxColumn();
            dgvAttendancesColumnName = new DataGridViewTextBoxColumn();
            dgvAttendancesColumnTime = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendances).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(870, 608);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(dgvAttendances, 0, 0);
            tableLayoutPanel2.Location = new Point(40, 40);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.Size = new Size(790, 528);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(btnLogin, 1, 0);
            tableLayoutPanel3.Location = new Point(0, 448);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(790, 80);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label1, 0, 0);
            tableLayoutPanel4.Controls.Add(label2, 0, 1);
            tableLayoutPanel4.Controls.Add(txbxPassword, 1, 1);
            tableLayoutPanel4.Controls.Add(txbxStudentNumber, 1, 0);
            tableLayoutPanel4.Location = new Point(1, 1);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(667, 78);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(4, 1);
            label1.Name = "label1";
            label1.Size = new Size(94, 37);
            label1.TabIndex = 0;
            label1.Text = "학번";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.ImageAlign = ContentAlignment.MiddleRight;
            label2.Location = new Point(4, 39);
            label2.Name = "label2";
            label2.Size = new Size(94, 38);
            label2.TabIndex = 0;
            label2.Text = "비밀번호";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txbxPassword
            // 
            txbxPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbxPassword.Location = new Point(105, 44);
            txbxPassword.Name = "txbxPassword";
            txbxPassword.Size = new Size(558, 27);
            txbxPassword.TabIndex = 1;
            txbxPassword.UseSystemPasswordChar = true;
            // 
            // txbxStudentNumber
            // 
            txbxStudentNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txbxStudentNumber.Location = new Point(105, 6);
            txbxStudentNumber.Name = "txbxStudentNumber";
            txbxStudentNumber.Size = new Size(558, 27);
            txbxStudentNumber.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Location = new Point(672, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(114, 72);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "출석";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += BtnLogin_Click;
            // 
            // dgvAttendances
            // 
            dgvAttendances.AllowUserToAddRows = false;
            dgvAttendances.AllowUserToDeleteRows = false;
            dgvAttendances.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAttendances.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendances.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendances.Columns.AddRange(new DataGridViewColumn[] { dgvAttendancesColumnNumber, dgvAttendancesColumnStudentNumber, dgvAttendancesColumnName, dgvAttendancesColumnTime });
            dgvAttendances.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvAttendances.Location = new Point(0, 0);
            dgvAttendances.Margin = new Padding(0);
            dgvAttendances.MultiSelect = false;
            dgvAttendances.Name = "dgvAttendances";
            dgvAttendances.ReadOnly = true;
            dgvAttendances.RowHeadersVisible = false;
            dgvAttendances.RowHeadersWidth = 51;
            dgvAttendances.RowTemplate.Height = 29;
            dgvAttendances.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendances.Size = new Size(790, 448);
            dgvAttendances.TabIndex = 1;
            dgvAttendances.CellContentClick += dgvAttendances_CellContentClick;
            // 
            // dgvAttendancesColumnNumber
            // 
            dgvAttendancesColumnNumber.FillWeight = 10F;
            dgvAttendancesColumnNumber.HeaderText = "번호";
            dgvAttendancesColumnNumber.MinimumWidth = 6;
            dgvAttendancesColumnNumber.Name = "dgvAttendancesColumnNumber";
            dgvAttendancesColumnNumber.ReadOnly = true;
            dgvAttendancesColumnNumber.Resizable = DataGridViewTriState.False;
            // 
            // dgvAttendancesColumnStudentNumber
            // 
            dgvAttendancesColumnStudentNumber.FillWeight = 20F;
            dgvAttendancesColumnStudentNumber.HeaderText = "학번";
            dgvAttendancesColumnStudentNumber.MinimumWidth = 6;
            dgvAttendancesColumnStudentNumber.Name = "dgvAttendancesColumnStudentNumber";
            dgvAttendancesColumnStudentNumber.ReadOnly = true;
            dgvAttendancesColumnStudentNumber.Resizable = DataGridViewTriState.False;
            // 
            // dgvAttendancesColumnName
            // 
            dgvAttendancesColumnName.FillWeight = 20F;
            dgvAttendancesColumnName.HeaderText = "이름";
            dgvAttendancesColumnName.MinimumWidth = 6;
            dgvAttendancesColumnName.Name = "dgvAttendancesColumnName";
            dgvAttendancesColumnName.ReadOnly = true;
            dgvAttendancesColumnName.Resizable = DataGridViewTriState.False;
            // 
            // dgvAttendancesColumnTime
            // 
            dgvAttendancesColumnTime.FillWeight = 50F;
            dgvAttendancesColumnTime.HeaderText = "시간";
            dgvAttendancesColumnTime.MinimumWidth = 6;
            dgvAttendancesColumnTime.Name = "dgvAttendancesColumnTime";
            dgvAttendancesColumnTime.ReadOnly = true;
            dgvAttendancesColumnTime.Resizable = DataGridViewTriState.False;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 608);
            Controls.Add(tableLayoutPanel1);
            Name = "Main";
            Text = "GS 출석체크";
            Load += Main_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendances).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label1;
        private Button btnLogin;
        private Label label2;
        private TextBox txbxStudentNumber;
        private TextBox txbxPassword;
        private DataGridView dgvAttendances;
        private DataGridViewTextBoxColumn dgvAttendancesColumnNumber;
        private DataGridViewTextBoxColumn dgvAttendancesColumnStudentNumber;
        private DataGridViewTextBoxColumn dgvAttendancesColumnName;
        private DataGridViewTextBoxColumn dgvAttendancesColumnTime;
    }
}