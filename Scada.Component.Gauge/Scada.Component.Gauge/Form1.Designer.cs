namespace Scada.Component.Gauge
{
    partial class Form1
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
            this.PnlDevices = new System.Windows.Forms.Panel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.TxtTime = new System.Windows.Forms.NumericUpDown();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtCount = new System.Windows.Forms.NumericUpDown();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCount)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlDevices
            // 
            this.PnlDevices.AutoScroll = true;
            this.PnlDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlDevices.Location = new System.Drawing.Point(0, 69);
            this.PnlDevices.Margin = new System.Windows.Forms.Padding(4);
            this.PnlDevices.Name = "PnlDevices";
            this.PnlDevices.Size = new System.Drawing.Size(800, 381);
            this.PnlDevices.TabIndex = 1;
            this.PnlDevices.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlDevices_Paint);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.TxtTime);
            this.Panel1.Controls.Add(this.BtnStop);
            this.Panel1.Controls.Add(this.BtnStart);
            this.Panel1.Controls.Add(this.label2);
            this.Panel1.Controls.Add(this.label1);
            this.Panel1.Controls.Add(this.TxtCount);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(800, 69);
            this.Panel1.TabIndex = 2;
            // 
            // TxtTime
            // 
            this.TxtTime.Location = new System.Drawing.Point(213, 26);
            this.TxtTime.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTime.Name = "TxtTime";
            this.TxtTime.Size = new System.Drawing.Size(160, 22);
            this.TxtTime.TabIndex = 3;
            // 
            // BtnStop
            // 
            this.BtnStop.Location = new System.Drawing.Point(501, 6);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(112, 48);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop Simulation";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(381, 6);
            this.BtnStart.Margin = new System.Windows.Forms.Padding(4);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(112, 48);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "Start Simulation";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kaç Saniye?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaç tank ile simule edilsin ?";
            // 
            // TxtCount
            // 
            this.TxtCount.Location = new System.Drawing.Point(20, 26);
            this.TxtCount.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.Size = new System.Drawing.Size(100, 22);
            this.TxtCount.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlDevices);
            this.Controls.Add(this.Panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlDevices;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.NumericUpDown TxtTime;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown TxtCount;
    }
}

