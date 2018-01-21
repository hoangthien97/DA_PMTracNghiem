namespace PMTracNghiem
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_oldpass = new System.Windows.Forms.TextBox();
            this.txt_newpass = new System.Windows.Forms.TextBox();
            this.txt_renewpass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_PassOk = new DevExpress.XtraEditors.SimpleButton();
            this.btn_PassExit = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txt_oldpass
            // 
            resources.ApplyResources(this.txt_oldpass, "txt_oldpass");
            this.txt_oldpass.Name = "txt_oldpass";
            // 
            // txt_newpass
            // 
            resources.ApplyResources(this.txt_newpass, "txt_newpass");
            this.txt_newpass.Name = "txt_newpass";
            // 
            // txt_renewpass
            // 
            resources.ApplyResources(this.txt_renewpass, "txt_renewpass");
            this.txt_renewpass.Name = "txt_renewpass";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Name = "label4";
            // 
            // btn_PassOk
            // 
            resources.ApplyResources(this.btn_PassOk, "btn_PassOk");
            this.btn_PassOk.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_PassOk.Appearance.Font")));
            this.btn_PassOk.Appearance.FontSizeDelta = ((int)(resources.GetObject("btn_PassOk.Appearance.FontSizeDelta")));
            this.btn_PassOk.Appearance.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("btn_PassOk.Appearance.FontStyleDelta")));
            this.btn_PassOk.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("btn_PassOk.Appearance.GradientMode")));
            this.btn_PassOk.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btn_PassOk.Appearance.Image")));
            this.btn_PassOk.Appearance.Options.UseFont = true;
            this.btn_PassOk.Name = "btn_PassOk";
            // 
            // btn_PassExit
            // 
            resources.ApplyResources(this.btn_PassExit, "btn_PassExit");
            this.btn_PassExit.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_PassExit.Appearance.Font")));
            this.btn_PassExit.Appearance.FontSizeDelta = ((int)(resources.GetObject("btn_PassExit.Appearance.FontSizeDelta")));
            this.btn_PassExit.Appearance.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("btn_PassExit.Appearance.FontStyleDelta")));
            this.btn_PassExit.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("btn_PassExit.Appearance.GradientMode")));
            this.btn_PassExit.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btn_PassExit.Appearance.Image")));
            this.btn_PassExit.Appearance.Options.UseFont = true;
            this.btn_PassExit.Name = "btn_PassExit";
            this.btn_PassExit.Click += new System.EventHandler(this.btn_PassExit_Click);
            // 
            // frmChangePass
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_PassExit);
            this.Controls.Add(this.btn_PassOk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_renewpass);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.txt_oldpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_oldpass;
        private System.Windows.Forms.TextBox txt_newpass;
        private System.Windows.Forms.TextBox txt_renewpass;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btn_PassOk;
        private DevExpress.XtraEditors.SimpleButton btn_PassExit;
    }
}