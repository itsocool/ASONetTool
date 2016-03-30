namespace MSSH_WinForm.controls
{
    partial class MetroLoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetroLoadingForm));
            this.msmChild = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mProgressBar = new MetroFramework.Controls.MetroProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.msmChild)).BeginInit();
            this.SuspendLayout();
            // 
            // msmChild
            // 
            this.msmChild.Owner = null;
            // 
            // mProgressBar
            // 
            this.mProgressBar.Location = new System.Drawing.Point(23, 82);
            this.mProgressBar.Name = "mProgressBar";
            this.mProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.mProgressBar.Size = new System.Drawing.Size(540, 23);
            this.mProgressBar.TabIndex = 1;
            // 
            // MetroLoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 186);
            this.Controls.Add(this.mProgressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MetroLoadingForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "처리중...";
            this.Load += new System.EventHandler(this.MetroLoadingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager msmChild;
        public MetroFramework.Controls.MetroProgressBar mProgressBar;
    }
}