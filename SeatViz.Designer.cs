namespace SeatViz
{
    partial class SeatViz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeatViz));
            this.btFitNow = new System.Windows.Forms.Button();
            this.btHistory = new System.Windows.Forms.Button();
            this.btOptions = new System.Windows.Forms.Button();
            this.btHelp = new System.Windows.Forms.Button();
            this.tlpEntranceButtons = new System.Windows.Forms.TableLayoutPanel();
            this.tlpEntranceButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btFitNow
            // 
            this.btFitNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btFitNow.BackColor = System.Drawing.Color.MistyRose;
            this.btFitNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFitNow.Location = new System.Drawing.Point(336, 103);
            this.btFitNow.Name = "btFitNow";
            this.btFitNow.Size = new System.Drawing.Size(336, 234);
            this.btFitNow.TabIndex = 0;
            this.btFitNow.Text = "Fit Now!";
            this.btFitNow.UseVisualStyleBackColor = false;
            this.btFitNow.Click += new System.EventHandler(this.btFitNow_Click);
            // 
            // btHistory
            // 
            this.btHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btHistory.BackColor = System.Drawing.Color.Gainsboro;
            this.btHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistory.Location = new System.Drawing.Point(678, 103);
            this.btHistory.Name = "btHistory";
            this.btHistory.Size = new System.Drawing.Size(336, 234);
            this.btHistory.TabIndex = 1;
            this.btHistory.Text = "History";
            this.btHistory.UseVisualStyleBackColor = false;
            this.btHistory.Click += new System.EventHandler(this.btHistory_Click);
            // 
            // btOptions
            // 
            this.btOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btOptions.BackColor = System.Drawing.Color.PaleGreen;
            this.btOptions.Enabled = false;
            this.btOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOptions.Location = new System.Drawing.Point(336, 343);
            this.btOptions.Name = "btOptions";
            this.btOptions.Size = new System.Drawing.Size(336, 234);
            this.btOptions.TabIndex = 2;
            this.btOptions.Text = "Options\r\n[Premium Feature]";
            this.btOptions.UseVisualStyleBackColor = false;
            this.btOptions.Visible = false;
            // 
            // btHelp
            // 
            this.btHelp.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHelp.Location = new System.Drawing.Point(678, 343);
            this.btHelp.Name = "btHelp";
            this.btHelp.Size = new System.Drawing.Size(336, 234);
            this.btHelp.TabIndex = 3;
            this.btHelp.Text = "Help";
            this.btHelp.UseVisualStyleBackColor = false;
            this.btHelp.Click += new System.EventHandler(this.btHelp_Click);
            // 
            // tlpEntranceButtons
            // 
            this.tlpEntranceButtons.AutoSize = true;
            this.tlpEntranceButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpEntranceButtons.ColumnCount = 2;
            this.tlpEntranceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntranceButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntranceButtons.Controls.Add(this.btHelp, 1, 1);
            this.tlpEntranceButtons.Controls.Add(this.btOptions, 0, 1);
            this.tlpEntranceButtons.Controls.Add(this.btHistory, 1, 0);
            this.tlpEntranceButtons.Controls.Add(this.btFitNow, 0, 0);
            this.tlpEntranceButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpEntranceButtons.Location = new System.Drawing.Point(0, 0);
            this.tlpEntranceButtons.Name = "tlpEntranceButtons";
            this.tlpEntranceButtons.RowCount = 2;
            this.tlpEntranceButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntranceButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpEntranceButtons.Size = new System.Drawing.Size(1350, 681);
            this.tlpEntranceButtons.TabIndex = 4;
            // 
            // SeatViz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1350, 681);
            this.Controls.Add(this.tlpEntranceButtons);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeatViz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeatViz [Basic]";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tlpEntranceButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btFitNow;
        private System.Windows.Forms.Button btHistory;
        private System.Windows.Forms.Button btOptions;
        private System.Windows.Forms.Button btHelp;
        private System.Windows.Forms.TableLayoutPanel tlpEntranceButtons;
    }
}

