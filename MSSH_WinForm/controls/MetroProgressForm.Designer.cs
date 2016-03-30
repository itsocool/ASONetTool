namespace MSSH_WinForm.controls
{
    partial class MetroProgressForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroProgressForm));
            this.mProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.msmChild = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.msmChild)).BeginInit();
            this.SuspendLayout();
            // 
            // mProgressBar
            // 
            this.mProgressBar.Location = new System.Drawing.Point(23, 87);
            this.mProgressBar.Name = "mProgressBar";
            this.mProgressBar.Size = new System.Drawing.Size(540, 23);
            this.mProgressBar.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(23, 113);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(540, 23);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // msmChild
            // 
            this.msmChild.Owner = this;
            // 
            // MetroProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 186);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MetroProgressForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "처리중...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MetroProgressForm_FormClosing);
            this.Load += new System.EventHandler(this.MetroProgressForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        public MetroFramework.Controls.MetroProgressBar mProgressBar;
        private MetroFramework.Components.MetroStyleManager msmChild;
    }
}