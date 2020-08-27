namespace library
{
    partial class ViewStudentInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.viewStudentDetail = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDepart = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEnrollNo = new System.Windows.Forms.TextBox();
            this.txtSemes = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lbContact = new System.Windows.Forms.Label();
            this.lbDepart = new System.Windows.Forms.Label();
            this.lbSemes = new System.Windows.Forms.Label();
            this.lbEnrollNo = new System.Windows.Forms.Label();
            this.lbSname = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.viewStudentDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(318, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Students Info";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::library.Properties.Resources.icons8_student_male_50px2;
            this.pictureBox1.Location = new System.Drawing.Point(253, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(726, 273);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnRefresh.Location = new System.Drawing.Point(505, 75);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 30);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(303, 79);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 21);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(162, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enrollment No.";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 61);
            this.panel1.TabIndex = 5;
            // 
            // viewStudentDetail
            // 
            this.viewStudentDetail.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.viewStudentDetail.Controls.Add(this.label3);
            this.viewStudentDetail.Controls.Add(this.btnCancel);
            this.viewStudentDetail.Controls.Add(this.btnDelete);
            this.viewStudentDetail.Controls.Add(this.btnUpdate);
            this.viewStudentDetail.Controls.Add(this.txtEmail);
            this.viewStudentDetail.Controls.Add(this.txtDepart);
            this.viewStudentDetail.Controls.Add(this.txtContact);
            this.viewStudentDetail.Controls.Add(this.txtEnrollNo);
            this.viewStudentDetail.Controls.Add(this.txtSemes);
            this.viewStudentDetail.Controls.Add(this.lbEmail);
            this.viewStudentDetail.Controls.Add(this.txtSname);
            this.viewStudentDetail.Controls.Add(this.lbContact);
            this.viewStudentDetail.Controls.Add(this.lbDepart);
            this.viewStudentDetail.Controls.Add(this.lbSemes);
            this.viewStudentDetail.Controls.Add(this.lbEnrollNo);
            this.viewStudentDetail.Controls.Add(this.lbSname);
            this.viewStudentDetail.Location = new System.Drawing.Point(12, 409);
            this.viewStudentDetail.Name = "viewStudentDetail";
            this.viewStudentDetail.Size = new System.Drawing.Size(726, 290);
            this.viewStudentDetail.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "(Only Number)";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(579, 218);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(482, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(384, 218);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("굴림", 10F);
            this.txtEmail.Location = new System.Drawing.Point(511, 164);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 23);
            this.txtEmail.TabIndex = 1;
            // 
            // txtDepart
            // 
            this.txtDepart.Font = new System.Drawing.Font("굴림", 10F);
            this.txtDepart.Location = new System.Drawing.Point(162, 164);
            this.txtDepart.Name = "txtDepart";
            this.txtDepart.Size = new System.Drawing.Size(178, 23);
            this.txtDepart.TabIndex = 1;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("굴림", 10F);
            this.txtContact.Location = new System.Drawing.Point(511, 102);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(181, 23);
            this.txtContact.TabIndex = 1;
            // 
            // txtEnrollNo
            // 
            this.txtEnrollNo.Font = new System.Drawing.Font("굴림", 10F);
            this.txtEnrollNo.Location = new System.Drawing.Point(162, 102);
            this.txtEnrollNo.Name = "txtEnrollNo";
            this.txtEnrollNo.Size = new System.Drawing.Size(178, 23);
            this.txtEnrollNo.TabIndex = 1;
            // 
            // txtSemes
            // 
            this.txtSemes.Font = new System.Drawing.Font("굴림", 10F);
            this.txtSemes.Location = new System.Drawing.Point(511, 37);
            this.txtSemes.Name = "txtSemes";
            this.txtSemes.Size = new System.Drawing.Size(181, 23);
            this.txtSemes.TabIndex = 1;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbEmail.Location = new System.Drawing.Point(372, 173);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(45, 13);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // txtSname
            // 
            this.txtSname.Font = new System.Drawing.Font("굴림", 10F);
            this.txtSname.Location = new System.Drawing.Point(162, 37);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(178, 23);
            this.txtSname.TabIndex = 1;
            // 
            // lbContact
            // 
            this.lbContact.AutoSize = true;
            this.lbContact.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbContact.Location = new System.Drawing.Point(372, 111);
            this.lbContact.Name = "lbContact";
            this.lbContact.Size = new System.Drawing.Size(61, 13);
            this.lbContact.TabIndex = 0;
            this.lbContact.Text = "Contact";
            // 
            // lbDepart
            // 
            this.lbDepart.AutoSize = true;
            this.lbDepart.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDepart.Location = new System.Drawing.Point(50, 167);
            this.lbDepart.Name = "lbDepart";
            this.lbDepart.Size = new System.Drawing.Size(88, 13);
            this.lbDepart.TabIndex = 0;
            this.lbDepart.Text = "Department";
            // 
            // lbSemes
            // 
            this.lbSemes.AutoSize = true;
            this.lbSemes.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSemes.Location = new System.Drawing.Point(372, 43);
            this.lbSemes.Name = "lbSemes";
            this.lbSemes.Size = new System.Drawing.Size(134, 13);
            this.lbSemes.TabIndex = 0;
            this.lbSemes.Text = "Student Semester";
            // 
            // lbEnrollNo
            // 
            this.lbEnrollNo.AutoSize = true;
            this.lbEnrollNo.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbEnrollNo.Location = new System.Drawing.Point(50, 105);
            this.lbEnrollNo.Name = "lbEnrollNo";
            this.lbEnrollNo.Size = new System.Drawing.Size(106, 13);
            this.lbEnrollNo.TabIndex = 0;
            this.lbEnrollNo.Text = "Enrollment No";
            // 
            // lbSname
            // 
            this.lbSname.AutoSize = true;
            this.lbSname.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSname.Location = new System.Drawing.Point(50, 46);
            this.lbSname.Name = "lbSname";
            this.lbSname.Size = new System.Drawing.Size(106, 13);
            this.lbSname.TabIndex = 0;
            this.lbSname.Text = "Student Name";
            // 
            // ViewStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(750, 457);
            this.Controls.Add(this.viewStudentDetail);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewStudentInfo";
            this.Load += new System.EventHandler(this.ViewStudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.viewStudentDetail.ResumeLayout(false);
            this.viewStudentDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel viewStudentDetail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDepart;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEnrollNo;
        private System.Windows.Forms.TextBox txtSemes;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lbContact;
        private System.Windows.Forms.Label lbDepart;
        private System.Windows.Forms.Label lbSemes;
        private System.Windows.Forms.Label lbEnrollNo;
        private System.Windows.Forms.Label lbSname;
        private System.Windows.Forms.Label label3;
    }
}