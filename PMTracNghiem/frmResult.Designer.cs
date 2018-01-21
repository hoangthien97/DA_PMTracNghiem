namespace PMTracNghiem
{
    partial class frmResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResult));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dtg = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencauhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddapan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.traloi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ketqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnxuat = new System.Windows.Forms.Button();
            this.btnfinish = new System.Windows.Forms.Button();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.ForeColor = ((System.Drawing.Color)(resources.GetObject("labelControl1.Appearance.ForeColor")));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.simpleButton4);
            this.groupBox1.Controls.Add(this.simpleButton3);
            this.groupBox1.Controls.Add(this.simpleButton2);
            this.groupBox1.Controls.Add(this.simpleButton1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton4.Appearance.Font")));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = global::PMTracNghiem.Properties.Resources.cuoi;
            resources.ApplyResources(this.simpleButton4, "simpleButton4");
            this.simpleButton4.Name = "simpleButton4";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton3.Appearance.Font")));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ImageOptions.Image = global::PMTracNghiem.Properties.Resources.toi;
            resources.ApplyResources(this.simpleButton3, "simpleButton3");
            this.simpleButton3.Name = "simpleButton3";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton2.Appearance.Font")));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::PMTracNghiem.Properties.Resources.lui;
            resources.ApplyResources(this.simpleButton2, "simpleButton2");
            this.simpleButton2.Name = "simpleButton2";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("simpleButton1.Appearance.Font")));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = global::PMTracNghiem.Properties.Resources.dau;
            resources.ApplyResources(this.simpleButton1, "simpleButton1");
            this.simpleButton1.Name = "simpleButton1";
            // 
            // dtg
            // 
            this.dtg.AllowUserToAddRows = false;
            this.dtg.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.dtg, "dtg");
            this.dtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.tencauhoi,
            this.iddapan,
            this.traloi,
            this.ketqua});
            this.dtg.Name = "dtg";
            this.dtg.ReadOnly = true;
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            resources.ApplyResources(this.STT, "STT");
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // tencauhoi
            // 
            this.tencauhoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tencauhoi.DataPropertyName = "QTCH";
            resources.ApplyResources(this.tencauhoi, "tencauhoi");
            this.tencauhoi.Name = "tencauhoi";
            this.tencauhoi.ReadOnly = true;
            // 
            // iddapan
            // 
            this.iddapan.DataPropertyName = "QDAD";
            resources.ApplyResources(this.iddapan, "iddapan");
            this.iddapan.Name = "iddapan";
            this.iddapan.ReadOnly = true;
            // 
            // traloi
            // 
            this.traloi.DataPropertyName = "MDAND";
            resources.ApplyResources(this.traloi, "traloi");
            this.traloi.Name = "traloi";
            this.traloi.ReadOnly = true;
            // 
            // ketqua
            // 
            this.ketqua.DataPropertyName = "DANHGIA";
            resources.ApplyResources(this.ketqua, "ketqua");
            this.ketqua.Name = "ketqua";
            this.ketqua.ReadOnly = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.txtUName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnxuat);
            this.groupBox2.Controls.Add(this.btnfinish);
            this.groupBox2.Controls.Add(this.txtdiem);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.TabStop = false;
            // 
            // txtLName
            // 
            resources.ApplyResources(this.txtLName, "txtLName");
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.TabStop = false;
            // 
            // txtUName
            // 
            resources.ApplyResources(this.txtUName, "txtUName");
            this.txtUName.Name = "txtUName";
            this.txtUName.ReadOnly = true;
            this.txtUName.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Name = "label4";
            // 
            // btnxuat
            // 
            resources.ApplyResources(this.btnxuat, "btnxuat");
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.UseVisualStyleBackColor = true;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnfinish
            // 
            resources.ApplyResources(this.btnfinish, "btnfinish");
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.UseVisualStyleBackColor = true;
            this.btnfinish.Click += new System.EventHandler(this.btnfinish_Click);
            // 
            // txtdiem
            // 
            resources.ApplyResources(this.txtdiem, "txtdiem");
            this.txtdiem.ForeColor = System.Drawing.Color.Red;
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.ReadOnly = true;
            this.txtdiem.TextChanged += new System.EventHandler(this.txtdiem_TextChanged);
            // 
            // frmResult
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.dtg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.Name = "frmResult";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView dtg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencauhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddapan;
        private System.Windows.Forms.DataGridViewTextBoxColumn traloi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ketqua;
    }
}