namespace egepoly
{
    partial class menuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuForm));
            this.outsideLayout = new System.Windows.Forms.TableLayoutPanel();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.oyunaBaslaBtn = new System.Windows.Forms.PictureBox();
            this.nasilOynanirBtn = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.creditLabel = new System.Windows.Forms.Label();
            this.cikisBtn = new System.Windows.Forms.PictureBox();
            this.media = new AxWMPLib.AxWindowsMediaPlayer();
            this.outsideLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oyunaBaslaBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasilOynanirBtn)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.media)).BeginInit();
            this.SuspendLayout();
            // 
            // outsideLayout
            // 
            this.outsideLayout.BackColor = System.Drawing.Color.Transparent;
            this.outsideLayout.ColumnCount = 1;
            this.outsideLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.outsideLayout.Controls.Add(this.logoPicture, 0, 1);
            this.outsideLayout.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.outsideLayout.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.outsideLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outsideLayout.Location = new System.Drawing.Point(0, 0);
            this.outsideLayout.Name = "outsideLayout";
            this.outsideLayout.RowCount = 4;
            this.outsideLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.29927F));
            this.outsideLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.6837F));
            this.outsideLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.19951F));
            this.outsideLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.30414F));
            this.outsideLayout.Size = new System.Drawing.Size(784, 411);
            this.outsideLayout.TabIndex = 0;
            // 
            // logoPicture
            // 
            this.logoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPicture.Image = global::egepoly.Properties.Resources.logo;
            this.logoPicture.Location = new System.Drawing.Point(3, 32);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(778, 115);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.71722F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.8509F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.30334F));
            this.tableLayoutPanel1.Controls.Add(this.oyunaBaslaBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nasilOynanirBtn, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 153);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.20134F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.51807F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 150);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // oyunaBaslaBtn
            // 
            this.oyunaBaslaBtn.BackgroundImage = global::egepoly.Properties.Resources.button_oyuna_basla__1_;
            this.oyunaBaslaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.oyunaBaslaBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oyunaBaslaBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oyunaBaslaBtn.Location = new System.Drawing.Point(312, 47);
            this.oyunaBaslaBtn.Name = "oyunaBaslaBtn";
            this.oyunaBaslaBtn.Size = new System.Drawing.Size(164, 37);
            this.oyunaBaslaBtn.TabIndex = 0;
            this.oyunaBaslaBtn.TabStop = false;
            this.oyunaBaslaBtn.Click += new System.EventHandler(this.oyunaBaslaBtn_Click);
            // 
            // nasilOynanirBtn
            // 
            this.nasilOynanirBtn.BackgroundImage = global::egepoly.Properties.Resources.button_nasil_oynanir__2_;
            this.nasilOynanirBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.nasilOynanirBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nasilOynanirBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nasilOynanirBtn.Location = new System.Drawing.Point(312, 109);
            this.nasilOynanirBtn.Name = "nasilOynanirBtn";
            this.nasilOynanirBtn.Size = new System.Drawing.Size(164, 38);
            this.nasilOynanirBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nasilOynanirBtn.TabIndex = 1;
            this.nasilOynanirBtn.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.181F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.56555F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.354755F));
            this.tableLayoutPanel2.Controls.Add(this.creditLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cikisBtn, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.media, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 309);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.50505F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.49495F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(778, 99);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.creditLabel.Font = new System.Drawing.Font("Futura Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.creditLabel.Location = new System.Drawing.Point(3, 85);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(158, 14);
            this.creditLabel.TabIndex = 0;
            this.creditLabel.Text = "Created by Ege Eren";
            this.creditLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackgroundImage = global::egepoly.Properties.Resources.xButton;
            this.cikisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cikisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cikisBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cikisBtn.Location = new System.Drawing.Point(715, 53);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(60, 43);
            this.cikisBtn.TabIndex = 1;
            this.cikisBtn.TabStop = false;
            this.cikisBtn.Click += new System.EventHandler(this.cikisBtn_Click);
            // 
            // media
            // 
            this.media.Enabled = true;
            this.media.Location = new System.Drawing.Point(167, 53);
            this.media.Name = "media";
            this.media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("media.OcxState")));
            this.media.Size = new System.Drawing.Size(75, 23);
            this.media.TabIndex = 2;
            this.media.Visible = false;
            // 
            // menuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::egepoly.Properties.Resources.menuBackground2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.ControlBox = false;
            this.Controls.Add(this.outsideLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "menuForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.menuForm_Load);
            this.outsideLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oyunaBaslaBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nasilOynanirBtn)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cikisBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.media)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel outsideLayout;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox oyunaBaslaBtn;
        private System.Windows.Forms.PictureBox nasilOynanirBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.PictureBox cikisBtn;
        private AxWMPLib.AxWindowsMediaPlayer media;
    }
}

