namespace PMTracNghiem
{
    partial class frmExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExam));
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dtp_Ngaythi = new System.Windows.Forms.DateTimePicker();
            this.txt_MND = new System.Windows.Forms.TextBox();
            this.txt_MKT = new System.Windows.Forms.TextBox();
            this.rdb_Minhhoa = new System.Windows.Forms.RadioButton();
            this.rdb_Chinhthuc = new System.Windows.Forms.RadioButton();
            this.cbb_MH = new System.Windows.Forms.ComboBox();
            this.cbb_CT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            resources.ApplyResources(this.btn_Huy, "btn_Huy");
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_OK
            // 
            resources.ApplyResources(this.btn_OK, "btn_OK");
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dtp_Ngaythi);
            this.groupControl1.Controls.Add(this.txt_MND);
            this.groupControl1.Controls.Add(this.txt_MKT);
            this.groupControl1.Controls.Add(this.rdb_Minhhoa);
            this.groupControl1.Controls.Add(this.rdb_Chinhthuc);
            this.groupControl1.Controls.Add(this.cbb_MH);
            this.groupControl1.Controls.Add(this.cbb_CT);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupControl1, "groupControl1");
            this.groupControl1.Name = "groupControl1";
            // 
            // dtp_Ngaythi
            // 
            resources.ApplyResources(this.dtp_Ngaythi, "dtp_Ngaythi");
            this.dtp_Ngaythi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Ngaythi.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtp_Ngaythi.Name = "dtp_Ngaythi";
            this.dtp_Ngaythi.Value = new System.DateTime(2018, 1, 17, 0, 0, 0, 0);
            // 
            // txt_MND
            // 
            resources.ApplyResources(this.txt_MND, "txt_MND");
            this.txt_MND.Name = "txt_MND";
            // 
            // txt_MKT
            // 
            resources.ApplyResources(this.txt_MKT, "txt_MKT");
            this.txt_MKT.Name = "txt_MKT";
            // 
            // rdb_Minhhoa
            // 
            resources.ApplyResources(this.rdb_Minhhoa, "rdb_Minhhoa");
            this.rdb_Minhhoa.Name = "rdb_Minhhoa";
            this.rdb_Minhhoa.TabStop = true;
            this.rdb_Minhhoa.UseVisualStyleBackColor = true;
            this.rdb_Minhhoa.CheckedChanged += new System.EventHandler(this.rdb_Minhhoa_CheckedChanged);
            // 
            // rdb_Chinhthuc
            // 
            resources.ApplyResources(this.rdb_Chinhthuc, "rdb_Chinhthuc");
            this.rdb_Chinhthuc.Name = "rdb_Chinhthuc";
            this.rdb_Chinhthuc.TabStop = true;
            this.rdb_Chinhthuc.UseVisualStyleBackColor = true;
            this.rdb_Chinhthuc.CheckedChanged += new System.EventHandler(this.rdb_Chinhthuc_CheckedChanged);
            // 
            // cbb_MH
            // 
            resources.ApplyResources(this.cbb_MH, "cbb_MH");
            this.cbb_MH.FormattingEnabled = true;
            this.cbb_MH.Name = "cbb_MH";
            // 
            // cbb_CT
            // 
            resources.ApplyResources(this.cbb_CT, "cbb_CT");
            this.cbb_CT.FormattingEnabled = true;
            this.cbb_CT.Name = "cbb_CT";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // frmExam
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExam";
            this.Load += new System.EventHandler(this.frmExam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_OK;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_MND;
        private System.Windows.Forms.TextBox txt_MKT;
        private System.Windows.Forms.RadioButton rdb_Minhhoa;
        private System.Windows.Forms.RadioButton rdb_Chinhthuc;
        private System.Windows.Forms.ComboBox cbb_CT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_MH;
        private System.Windows.Forms.DateTimePicker dtp_Ngaythi;
    }
}