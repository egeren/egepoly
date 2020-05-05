namespace egepoly
{
    partial class introForm
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
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.egecodePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.egecodePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // fadeOut
            // 
            this.fadeOut.Enabled = true;
            this.fadeOut.Interval = 10;
            this.fadeOut.Tick += new System.EventHandler(this.fadeOut_Tick);
            // 
            // egecodePicture
            // 
            this.egecodePicture.BackgroundImage = global::egepoly.Properties.Resources.egecode;
            this.egecodePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.egecodePicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.egecodePicture.Location = new System.Drawing.Point(0, 0);
            this.egecodePicture.Name = "egecodePicture";
            this.egecodePicture.Size = new System.Drawing.Size(800, 450);
            this.egecodePicture.TabIndex = 0;
            this.egecodePicture.TabStop = false;
            // 
            // introForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.egecodePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "introForm";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.egecodePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.PictureBox egecodePicture;
    }
}