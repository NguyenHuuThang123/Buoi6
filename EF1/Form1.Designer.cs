namespace EF1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgStudent = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFaculty);
            this.groupBox1.Controls.Add(this.txtAverageScore);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtStudentID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(115, 177);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(211, 24);
            this.cmbFaculty.TabIndex = 7;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(115, 232);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(211, 22);
            this.txtAverageScore.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 109);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(115, 51);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(211, 22);
            this.txtStudentID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm TB";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khoa";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số SV";
            // 
            // dvgStudent
            // 
            this.dvgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dvgStudent.Location = new System.Drawing.Point(427, 92);
            this.dvgStudent.Name = "dvgStudent";
            this.dvgStudent.RowHeadersWidth = 51;
            this.dvgStudent.RowTemplate.Height = 24;
            this.dvgStudent.Size = new System.Drawing.Size(540, 385);
            this.dvgStudent.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(114, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(214, 454);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(320, 454);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // column1
            // 
            this.column1.HeaderText = "StudentID";
            this.column1.MinimumWidth = 6;
            this.column1.Name = "column1";
            this.column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FullName";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FacultyName";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "AverageScore";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(331, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(322, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quản lý thông tin Sinh viên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 538);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dvgStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvgStudent;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label5;
    }
}

