namespace PMTracNghiem
{
    partial class frmQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvQuest = new System.Windows.Forms.DataGridView();
            this.Chek = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_QuesDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_QuesUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btn_QuesAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btn_QuesSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbQues = new System.Windows.Forms.RichTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuest)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.txtdad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvQuest);
            this.groupBox1.Controls.Add(this.btn_QuesDelete);
            this.groupBox1.Controls.Add(this.btn_QuesUpdate);
            this.groupBox1.Controls.Add(this.btn_QuesAdd);
            this.groupBox1.Controls.Add(this.btn_QuesSave);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // txtdad
            // 
            resources.ApplyResources(this.txtdad, "txtdad");
            this.txtdad.Name = "txtdad";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtmch
            // 
            resources.ApplyResources(this.txtmch, "txtmch");
            this.txtmch.Name = "txtmch";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dgvQuest
            // 
            resources.ApplyResources(this.dgvQuest, "dgvQuest");
            this.dgvQuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chek,
            this.STT,
            this.QTCH,
            this.QDAD});
            this.dgvQuest.Name = "dgvQuest";
            // 
            // Chek
            // 
            resources.ApplyResources(this.Chek, "Chek");
            this.Chek.Name = "Chek";
            // 
            // STT
            // 
            this.STT.DataPropertyName = "QMCH";
            resources.ApplyResources(this.STT, "STT");
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // QTCH
            // 
            this.QTCH.DataPropertyName = "QTCH";
            resources.ApplyResources(this.QTCH, "QTCH");
            this.QTCH.Name = "QTCH";
            this.QTCH.ReadOnly = true;
            // 
            // QDAD
            // 
            this.QDAD.DataPropertyName = "QDAD";
            resources.ApplyResources(this.QDAD, "QDAD");
            this.QDAD.Name = "QDAD";
            // 
            // btn_QuesDelete
            // 
            resources.ApplyResources(this.btn_QuesDelete, "btn_QuesDelete");
            this.btn_QuesDelete.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_QuesDelete.Appearance.Font")));
            this.btn_QuesDelete.Appearance.FontSizeDelta = ((int)(resources.GetObject("btn_QuesDelete.Appearance.FontSizeDelta")));
            this.btn_QuesDelete.Appearance.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("btn_QuesDelete.Appearance.FontStyleDelta")));
            this.btn_QuesDelete.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("btn_QuesDelete.Appearance.GradientMode")));
            this.btn_QuesDelete.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuesDelete.Appearance.Image")));
            this.btn_QuesDelete.Appearance.Options.UseFont = true;
            this.btn_QuesDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuesDelete.ImageOptions.Image")));
            this.btn_QuesDelete.Name = "btn_QuesDelete";
            this.btn_QuesDelete.Click += new System.EventHandler(this.btn_QuesDelete_Click);
            // 
            // btn_QuesUpdate
            // 
            resources.ApplyResources(this.btn_QuesUpdate, "btn_QuesUpdate");
            this.btn_QuesUpdate.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_QuesUpdate.Appearance.Font")));
            this.btn_QuesUpdate.Appearance.FontSizeDelta = ((int)(resources.GetObject("btn_QuesUpdate.Appearance.FontSizeDelta")));
            this.btn_QuesUpdate.Appearance.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("btn_QuesUpdate.Appearance.FontStyleDelta")));
            this.btn_QuesUpdate.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("btn_QuesUpdate.Appearance.GradientMode")));
            this.btn_QuesUpdate.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuesUpdate.Appearance.Image")));
            this.btn_QuesUpdate.Appearance.Options.UseFont = true;
            this.btn_QuesUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuesUpdate.ImageOptions.Image")));
            this.btn_QuesUpdate.Name = "btn_QuesUpdate";
            this.btn_QuesUpdate.Click += new System.EventHandler(this.btn_QuesUpdate_Click);
            // 
            // btn_QuesAdd
            // 
            resources.ApplyResources(this.btn_QuesAdd, "btn_QuesAdd");
            this.btn_QuesAdd.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_QuesAdd.Appearance.Font")));
            this.btn_QuesAdd.Appearance.FontSizeDelta = ((int)(resources.GetObject("btn_QuesAdd.Appearance.FontSizeDelta")));
            this.btn_QuesAdd.Appearance.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("btn_QuesAdd.Appearance.FontStyleDelta")));
            this.btn_QuesAdd.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("btn_QuesAdd.Appearance.GradientMode")));
            this.btn_QuesAdd.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuesAdd.Appearance.Image")));
            this.btn_QuesAdd.Appearance.Options.UseFont = true;
            this.btn_QuesAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuesAdd.ImageOptions.Image")));
            this.btn_QuesAdd.Name = "btn_QuesAdd";
            this.btn_QuesAdd.Click += new System.EventHandler(this.btn_QuesAdd_Click);
            // 
            // btn_QuesSave
            // 
            resources.ApplyResources(this.btn_QuesSave, "btn_QuesSave");
            this.btn_QuesSave.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btn_QuesSave.Appearance.Font")));
            this.btn_QuesSave.Appearance.FontSizeDelta = ((int)(resources.GetObject("btn_QuesSave.Appearance.FontSizeDelta")));
            this.btn_QuesSave.Appearance.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("btn_QuesSave.Appearance.FontStyleDelta")));
            this.btn_QuesSave.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("btn_QuesSave.Appearance.GradientMode")));
            this.btn_QuesSave.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuesSave.Appearance.Image")));
            this.btn_QuesSave.Appearance.Options.UseFont = true;
            this.btn_QuesSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QuesSave.ImageOptions.Image")));
            this.btn_QuesSave.Name = "btn_QuesSave";
            this.btn_QuesSave.Click += new System.EventHandler(this.btn_QuesSave_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.rtbQues);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // rtbQues
            // 
            resources.ApplyResources(this.rtbQues, "rtbQues");
            this.rtbQues.Name = "rtbQues";
            // 
            // labelControl1
            // 
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            this.labelControl1.Appearance.FontSizeDelta = ((int)(resources.GetObject("labelControl1.Appearance.FontSizeDelta")));
            this.labelControl1.Appearance.FontStyleDelta = ((System.Drawing.FontStyle)(resources.GetObject("labelControl1.Appearance.FontStyleDelta")));
            this.labelControl1.Appearance.GradientMode = ((System.Drawing.Drawing2D.LinearGradientMode)(resources.GetObject("labelControl1.Appearance.GradientMode")));
            this.labelControl1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.Appearance.Image")));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Name = "labelControl1";
            // 
            // frmQuestion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuestion";
            this.Load += new System.EventHandler(this.frmQuestion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuest)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_QuesDelete;
        private DevExpress.XtraEditors.SimpleButton btn_QuesUpdate;
        private DevExpress.XtraEditors.SimpleButton btn_QuesAdd;
        private DevExpress.XtraEditors.SimpleButton btn_QuesSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvQuest;
        private System.Windows.Forms.TextBox txtmch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbQues;
        private System.Windows.Forms.TextBox txtdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chek;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn QDAD;
    }
}