namespace MicroControl.FORMS
{
    partial class frmAqusitionConfig
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
            this.numbox_Time_Interval = new System.Windows.Forms.NumericUpDown();
            this.lbl_Time_Interval = new System.Windows.Forms.Label();
            this.btn_Return = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_Time_Scan = new System.Windows.Forms.Label();
            this.numbox_Time_Scan = new System.Windows.Forms.NumericUpDown();
            this.lbl_Config = new System.Windows.Forms.Label();
            this.lbl_AcqConfig = new System.Windows.Forms.Label();
            this.lbl_Reso = new System.Windows.Forms.Label();
            this.lbl_Gai = new System.Windows.Forms.Label();
            this.lbl_Resolution = new System.Windows.Forms.Label();
            this.lbl_Gain = new System.Windows.Forms.Label();
            this.lbl_Exposure = new System.Windows.Forms.Label();
            this.lbl_Exposure_Time = new System.Windows.Forms.Label();
            this.btn_SaveCameraConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_Time_Interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_Time_Scan)).BeginInit();
            this.SuspendLayout();
            // 
            // numbox_Time_Interval
            // 
            this.numbox_Time_Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbox_Time_Interval.Location = new System.Drawing.Point(286, 205);
            this.numbox_Time_Interval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numbox_Time_Interval.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numbox_Time_Interval.Name = "numbox_Time_Interval";
            this.numbox_Time_Interval.Size = new System.Drawing.Size(81, 29);
            this.numbox_Time_Interval.TabIndex = 0;
            this.numbox_Time_Interval.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // lbl_Time_Interval
            // 
            this.lbl_Time_Interval.AutoSize = true;
            this.lbl_Time_Interval.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time_Interval.Location = new System.Drawing.Point(246, 178);
            this.lbl_Time_Interval.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Time_Interval.Name = "lbl_Time_Interval";
            this.lbl_Time_Interval.Size = new System.Drawing.Size(183, 24);
            this.lbl_Time_Interval.TabIndex = 1;
            this.lbl_Time_Interval.Text = "Time Interval (sec)";
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(273, 398);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(109, 58);
            this.btn_Return.TabIndex = 3;
            this.btn_Return.Text = "RETURN";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(483, 398);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(109, 58);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_Time_Scan
            // 
            this.lbl_Time_Scan.AutoSize = true;
            this.lbl_Time_Scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time_Scan.Location = new System.Drawing.Point(456, 178);
            this.lbl_Time_Scan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Time_Scan.Name = "lbl_Time_Scan";
            this.lbl_Time_Scan.Size = new System.Drawing.Size(164, 24);
            this.lbl_Time_Scan.TabIndex = 5;
            this.lbl_Time_Scan.Text = "Time Scan (min)";
            // 
            // numbox_Time_Scan
            // 
            this.numbox_Time_Scan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbox_Time_Scan.Location = new System.Drawing.Point(483, 205);
            this.numbox_Time_Scan.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numbox_Time_Scan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numbox_Time_Scan.Name = "numbox_Time_Scan";
            this.numbox_Time_Scan.Size = new System.Drawing.Size(81, 29);
            this.numbox_Time_Scan.TabIndex = 6;
            this.numbox_Time_Scan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_Config
            // 
            this.lbl_Config.BackColor = System.Drawing.Color.Snow;
            this.lbl_Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Config.Location = new System.Drawing.Point(212, 9);
            this.lbl_Config.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Config.Name = "lbl_Config";
            this.lbl_Config.Size = new System.Drawing.Size(695, 24);
            this.lbl_Config.TabIndex = 8;
            this.lbl_Config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_AcqConfig
            // 
            this.lbl_AcqConfig.AutoSize = true;
            this.lbl_AcqConfig.BackColor = System.Drawing.Color.Snow;
            this.lbl_AcqConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AcqConfig.Location = new System.Drawing.Point(2, 9);
            this.lbl_AcqConfig.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_AcqConfig.Name = "lbl_AcqConfig";
            this.lbl_AcqConfig.Size = new System.Drawing.Size(218, 24);
            this.lbl_AcqConfig.TabIndex = 7;
            this.lbl_AcqConfig.Text = "Camera Configuration:";
            // 
            // lbl_Reso
            // 
            this.lbl_Reso.AutoSize = true;
            this.lbl_Reso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Reso.Location = new System.Drawing.Point(11, 81);
            this.lbl_Reso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Reso.Name = "lbl_Reso";
            this.lbl_Reso.Size = new System.Drawing.Size(115, 24);
            this.lbl_Reso.TabIndex = 9;
            this.lbl_Reso.Text = "Resolution:";
            // 
            // lbl_Gai
            // 
            this.lbl_Gai.AutoSize = true;
            this.lbl_Gai.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gai.Location = new System.Drawing.Point(300, 81);
            this.lbl_Gai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Gai.Name = "lbl_Gai";
            this.lbl_Gai.Size = new System.Drawing.Size(59, 24);
            this.lbl_Gai.TabIndex = 10;
            this.lbl_Gai.Text = "Gain:";
            // 
            // lbl_Resolution
            // 
            this.lbl_Resolution.BackColor = System.Drawing.Color.Silver;
            this.lbl_Resolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resolution.Location = new System.Drawing.Point(130, 81);
            this.lbl_Resolution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Resolution.Name = "lbl_Resolution";
            this.lbl_Resolution.Size = new System.Drawing.Size(142, 24);
            this.lbl_Resolution.TabIndex = 11;
            this.lbl_Resolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Gain
            // 
            this.lbl_Gain.BackColor = System.Drawing.Color.Silver;
            this.lbl_Gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gain.Location = new System.Drawing.Point(363, 81);
            this.lbl_Gain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Gain.Name = "lbl_Gain";
            this.lbl_Gain.Size = new System.Drawing.Size(156, 24);
            this.lbl_Gain.TabIndex = 12;
            this.lbl_Gain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Exposure
            // 
            this.lbl_Exposure.AutoSize = true;
            this.lbl_Exposure.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exposure.Location = new System.Drawing.Point(532, 81);
            this.lbl_Exposure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Exposure.Name = "lbl_Exposure";
            this.lbl_Exposure.Size = new System.Drawing.Size(159, 24);
            this.lbl_Exposure.TabIndex = 13;
            this.lbl_Exposure.Text = "Exposure Time:";
            // 
            // lbl_Exposure_Time
            // 
            this.lbl_Exposure_Time.BackColor = System.Drawing.Color.Silver;
            this.lbl_Exposure_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exposure_Time.Location = new System.Drawing.Point(695, 81);
            this.lbl_Exposure_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Exposure_Time.Name = "lbl_Exposure_Time";
            this.lbl_Exposure_Time.Size = new System.Drawing.Size(163, 24);
            this.lbl_Exposure_Time.TabIndex = 14;
            this.lbl_Exposure_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_SaveCameraConfig
            // 
            this.btn_SaveCameraConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveCameraConfig.Location = new System.Drawing.Point(694, 398);
            this.btn_SaveCameraConfig.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SaveCameraConfig.Name = "btn_SaveCameraConfig";
            this.btn_SaveCameraConfig.Size = new System.Drawing.Size(164, 58);
            this.btn_SaveCameraConfig.TabIndex = 15;
            this.btn_SaveCameraConfig.Text = "Save Camera Configuration";
            this.btn_SaveCameraConfig.UseVisualStyleBackColor = true;
            this.btn_SaveCameraConfig.Click += new System.EventHandler(this.btn_SaveCameraConfig_Click);
            // 
            // frmAqusitionConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(911, 504);
            this.Controls.Add(this.btn_SaveCameraConfig);
            this.Controls.Add(this.lbl_Exposure_Time);
            this.Controls.Add(this.lbl_Exposure);
            this.Controls.Add(this.lbl_Gain);
            this.Controls.Add(this.lbl_Resolution);
            this.Controls.Add(this.lbl_Gai);
            this.Controls.Add(this.lbl_Reso);
            this.Controls.Add(this.lbl_Config);
            this.Controls.Add(this.lbl_AcqConfig);
            this.Controls.Add(this.numbox_Time_Scan);
            this.Controls.Add(this.lbl_Time_Scan);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.lbl_Time_Interval);
            this.Controls.Add(this.numbox_Time_Interval);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmAqusitionConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAcquisitionConfig";
            ((System.ComponentModel.ISupportInitialize)(this.numbox_Time_Interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbox_Time_Scan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numbox_Time_Interval;
        private System.Windows.Forms.Label lbl_Time_Interval;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_Time_Scan;
        private System.Windows.Forms.NumericUpDown numbox_Time_Scan;
        private System.Windows.Forms.Label lbl_Config;
        private System.Windows.Forms.Label lbl_AcqConfig;
        private System.Windows.Forms.Label lbl_Reso;
        private System.Windows.Forms.Label lbl_Gai;
        private System.Windows.Forms.Label lbl_Resolution;
        private System.Windows.Forms.Label lbl_Gain;
        private System.Windows.Forms.Label lbl_Exposure;
        private System.Windows.Forms.Label lbl_Exposure_Time;
        private System.Windows.Forms.Button btn_SaveCameraConfig;
    }
}