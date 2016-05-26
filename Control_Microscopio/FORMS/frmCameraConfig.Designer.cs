namespace MicroControl.FORMS
{
    partial class frmCameraConfig
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCameraConfig));
            this.lbl_Resolution = new System.Windows.Forms.Label();
            this.cbox_Resolution = new System.Windows.Forms.ComboBox();
            this.btn_Return = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Config = new System.Windows.Forms.Label();
            this.btn_LoadCameraConfig = new System.Windows.Forms.Button();
            this.cbox_Gain = new System.Windows.Forms.ComboBox();
            this.lbl_Gain = new System.Windows.Forms.Label();
            this.cbox_Exposure_Time = new System.Windows.Forms.ComboBox();
            this.lbl_Exposure_Time = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Resolution
            // 
            this.lbl_Resolution.AutoSize = true;
            this.lbl_Resolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Resolution.Location = new System.Drawing.Point(528, 216);
            this.lbl_Resolution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Resolution.Name = "lbl_Resolution";
            this.lbl_Resolution.Size = new System.Drawing.Size(115, 24);
            this.lbl_Resolution.TabIndex = 0;
            this.lbl_Resolution.Text = "Resolution:";
            // 
            // cbox_Resolution
            // 
            this.cbox_Resolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Resolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Resolution.FormattingEnabled = true;
            this.cbox_Resolution.Location = new System.Drawing.Point(647, 216);
            this.cbox_Resolution.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_Resolution.Name = "cbox_Resolution";
            this.cbox_Resolution.Size = new System.Drawing.Size(222, 28);
            this.cbox_Resolution.TabIndex = 1;
            // 
            // btn_Return
            // 
            this.btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.Location = new System.Drawing.Point(647, 448);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(109, 58);
            this.btn_Return.TabIndex = 2;
            this.btn_Return.Text = "RETURN";
            this.btn_Return.UseVisualStyleBackColor = true;
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Snow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Camera Configuration:";
            // 
            // lbl_Config
            // 
            this.lbl_Config.BackColor = System.Drawing.Color.Snow;
            this.lbl_Config.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Config.Location = new System.Drawing.Point(219, 7);
            this.lbl_Config.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Config.Name = "lbl_Config";
            this.lbl_Config.Size = new System.Drawing.Size(695, 24);
            this.lbl_Config.TabIndex = 6;
            this.lbl_Config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_LoadCameraConfig
            // 
            this.btn_LoadCameraConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadCameraConfig.Location = new System.Drawing.Point(50, 440);
            this.btn_LoadCameraConfig.Margin = new System.Windows.Forms.Padding(2);
            this.btn_LoadCameraConfig.Name = "btn_LoadCameraConfig";
            this.btn_LoadCameraConfig.Size = new System.Drawing.Size(164, 58);
            this.btn_LoadCameraConfig.TabIndex = 7;
            this.btn_LoadCameraConfig.Text = "Load Camera Configuration";
            this.btn_LoadCameraConfig.UseVisualStyleBackColor = true;
            this.btn_LoadCameraConfig.Click += new System.EventHandler(this.btn_LoadCameraConfig_Click);
            // 
            // cbox_Gain
            // 
            this.cbox_Gain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Gain.FormattingEnabled = true;
            this.cbox_Gain.Location = new System.Drawing.Point(647, 276);
            this.cbox_Gain.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_Gain.Name = "cbox_Gain";
            this.cbox_Gain.Size = new System.Drawing.Size(222, 28);
            this.cbox_Gain.TabIndex = 9;
            // 
            // lbl_Gain
            // 
            this.lbl_Gain.AutoSize = true;
            this.lbl_Gain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gain.Location = new System.Drawing.Point(584, 276);
            this.lbl_Gain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Gain.Name = "lbl_Gain";
            this.lbl_Gain.Size = new System.Drawing.Size(59, 24);
            this.lbl_Gain.TabIndex = 8;
            this.lbl_Gain.Text = "Gain:";
            // 
            // cbox_Exposure_Time
            // 
            this.cbox_Exposure_Time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_Exposure_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_Exposure_Time.FormattingEnabled = true;
            this.cbox_Exposure_Time.Location = new System.Drawing.Point(647, 336);
            this.cbox_Exposure_Time.Margin = new System.Windows.Forms.Padding(2);
            this.cbox_Exposure_Time.Name = "cbox_Exposure_Time";
            this.cbox_Exposure_Time.Size = new System.Drawing.Size(222, 28);
            this.cbox_Exposure_Time.TabIndex = 11;
            // 
            // lbl_Exposure_Time
            // 
            this.lbl_Exposure_Time.AutoSize = true;
            this.lbl_Exposure_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Exposure_Time.Location = new System.Drawing.Point(484, 340);
            this.lbl_Exposure_Time.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Exposure_Time.Name = "lbl_Exposure_Time";
            this.lbl_Exposure_Time.Size = new System.Drawing.Size(159, 24);
            this.lbl_Exposure_Time.TabIndex = 10;
            this.lbl_Exposure_Time.Text = "Exposure Time:";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(784, 448);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(109, 58);
            this.btn_Cancel.TabIndex = 3;
            this.btn_Cancel.Text = "CANCEL";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frmCameraConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(930, 544);
            this.Controls.Add(this.cbox_Exposure_Time);
            this.Controls.Add(this.lbl_Exposure_Time);
            this.Controls.Add(this.cbox_Gain);
            this.Controls.Add(this.lbl_Gain);
            this.Controls.Add(this.btn_LoadCameraConfig);
            this.Controls.Add(this.lbl_Config);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.cbox_Resolution);
            this.Controls.Add(this.lbl_Resolution);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmCameraConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCameraConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Resolution;
        private System.Windows.Forms.ComboBox cbox_Resolution;
        private System.Windows.Forms.Button btn_Return;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Config;
        private System.Windows.Forms.Button btn_LoadCameraConfig;
        private System.Windows.Forms.ComboBox cbox_Gain;
        private System.Windows.Forms.Label lbl_Gain;
        private System.Windows.Forms.ComboBox cbox_Exposure_Time;
        private System.Windows.Forms.Label lbl_Exposure_Time;
        private System.Windows.Forms.Button btn_Cancel;
    }
}