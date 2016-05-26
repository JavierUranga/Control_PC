namespace MicroControl
{
    partial class frmPrincipal
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
          this.components = new System.ComponentModel.Container();
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
          this.textBox1 = new System.Windows.Forms.TextBox();
          this.pictureBox1 = new System.Windows.Forms.PictureBox();
          this.btn_Prueba = new System.Windows.Forms.Button();
          this.btn_Send = new System.Windows.Forms.Button();
          this.btn_Receive = new System.Windows.Forms.Button();
          this.btn_CameraConfig = new System.Windows.Forms.Button();
          this.btn_Clear = new System.Windows.Forms.Button();
          this.hEADERBindingSource = new System.Windows.Forms.BindingSource(this.components);
          this.hEADERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
          this.Manual = new System.Windows.Forms.RadioButton();
          this.groupBox3 = new System.Windows.Forms.GroupBox();
          this.StarTracker = new System.Windows.Forms.RadioButton();
          this.btn_ReadSD = new System.Windows.Forms.Button();
          this.groupBox4 = new System.Windows.Forms.GroupBox();
          this.QQVGA = new System.Windows.Forms.RadioButton();
          this.QVGA = new System.Windows.Forms.RadioButton();
          this.VGA = new System.Windows.Forms.RadioButton();
          this.label2 = new System.Windows.Forms.Label();
          this.TIMESCAN = new System.Windows.Forms.NumericUpDown();
          this.MainMenu = new System.Windows.Forms.MenuStrip();
          this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
          this.menuConfig_Camera = new System.Windows.Forms.ToolStripMenuItem();
          this.menuConfig_Acquistion = new System.Windows.Forms.ToolStripMenuItem();
          this.menu_Help = new System.Windows.Forms.ToolStripMenuItem();
          this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
          this.button1 = new System.Windows.Forms.Button();
          this.button2 = new System.Windows.Forms.Button();
          this.button3 = new System.Windows.Forms.Button();
          ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.hEADERBindingSource)).BeginInit();
          ((System.ComponentModel.ISupportInitialize)(this.hEADERBindingSource1)).BeginInit();
          this.groupBox3.SuspendLayout();
          this.groupBox4.SuspendLayout();
          ((System.ComponentModel.ISupportInitialize)(this.TIMESCAN)).BeginInit();
          this.MainMenu.SuspendLayout();
          this.SuspendLayout();
          // 
          // textBox1
          // 
          this.textBox1.Location = new System.Drawing.Point(10, 26);
          this.textBox1.Multiline = true;
          this.textBox1.Name = "textBox1";
          this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
          this.textBox1.Size = new System.Drawing.Size(461, 586);
          this.textBox1.TabIndex = 0;
          // 
          // pictureBox1
          // 
          this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
          this.pictureBox1.Location = new System.Drawing.Point(490, 26);
          this.pictureBox1.Name = "pictureBox1";
          this.pictureBox1.Size = new System.Drawing.Size(640, 480);
          this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
          this.pictureBox1.TabIndex = 1;
          this.pictureBox1.TabStop = false;
          // 
          // btn_Prueba
          // 
          this.btn_Prueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btn_Prueba.Location = new System.Drawing.Point(1170, 227);
          this.btn_Prueba.Name = "btn_Prueba";
          this.btn_Prueba.Size = new System.Drawing.Size(201, 52);
          this.btn_Prueba.TabIndex = 2;
          this.btn_Prueba.Text = "Prueba...";
          this.btn_Prueba.UseVisualStyleBackColor = true;
          this.btn_Prueba.Visible = false;
          this.btn_Prueba.Click += new System.EventHandler(this.btn_Prueba_Click);
          // 
          // btn_Send
          // 
          this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btn_Send.Location = new System.Drawing.Point(1165, 35);
          this.btn_Send.Name = "btn_Send";
          this.btn_Send.Size = new System.Drawing.Size(201, 46);
          this.btn_Send.TabIndex = 4;
          this.btn_Send.Text = "Capture Image";
          this.btn_Send.UseVisualStyleBackColor = true;
          this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
          // 
          // btn_Receive
          // 
          this.btn_Receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btn_Receive.Location = new System.Drawing.Point(1165, 97);
          this.btn_Receive.Name = "btn_Receive";
          this.btn_Receive.Size = new System.Drawing.Size(201, 46);
          this.btn_Receive.TabIndex = 5;
          this.btn_Receive.Text = "Read Image";
          this.btn_Receive.UseVisualStyleBackColor = true;
          this.btn_Receive.Click += new System.EventHandler(this.btn_Receive_Click);
          // 
          // btn_CameraConfig
          // 
          this.btn_CameraConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btn_CameraConfig.Location = new System.Drawing.Point(1165, 161);
          this.btn_CameraConfig.Name = "btn_CameraConfig";
          this.btn_CameraConfig.Size = new System.Drawing.Size(201, 49);
          this.btn_CameraConfig.TabIndex = 6;
          this.btn_CameraConfig.Text = "Get Camera Config";
          this.btn_CameraConfig.UseVisualStyleBackColor = true;
          this.btn_CameraConfig.Click += new System.EventHandler(this.btn_CameraConfig_Click);
          // 
          // btn_Clear
          // 
          this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btn_Clear.Location = new System.Drawing.Point(0, 626);
          this.btn_Clear.Name = "btn_Clear";
          this.btn_Clear.Size = new System.Drawing.Size(462, 36);
          this.btn_Clear.TabIndex = 7;
          this.btn_Clear.Text = "CLEAR";
          this.btn_Clear.UseVisualStyleBackColor = true;
          this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
          // 
          // Manual
          // 
          this.Manual.AutoSize = true;
          this.Manual.Checked = true;
          this.Manual.Location = new System.Drawing.Point(14, 27);
          this.Manual.Name = "Manual";
          this.Manual.Size = new System.Drawing.Size(113, 28);
          this.Manual.TabIndex = 23;
          this.Manual.TabStop = true;
          this.Manual.Text = "MANUAL";
          this.Manual.UseVisualStyleBackColor = true;
          this.Manual.CheckedChanged += new System.EventHandler(this.Manual_CheckedChanged);
          // 
          // groupBox3
          // 
          this.groupBox3.Controls.Add(this.StarTracker);
          this.groupBox3.Controls.Add(this.Manual);
          this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.groupBox3.Location = new System.Drawing.Point(1162, 296);
          this.groupBox3.Name = "groupBox3";
          this.groupBox3.Size = new System.Drawing.Size(209, 97);
          this.groupBox3.TabIndex = 24;
          this.groupBox3.TabStop = false;
          this.groupBox3.Text = "MODE";
          // 
          // StarTracker
          // 
          this.StarTracker.AutoSize = true;
          this.StarTracker.Location = new System.Drawing.Point(14, 61);
          this.StarTracker.Name = "StarTracker";
          this.StarTracker.Size = new System.Drawing.Size(148, 28);
          this.StarTracker.TabIndex = 24;
          this.StarTracker.Text = "AUTOMATIC";
          this.StarTracker.UseVisualStyleBackColor = true;
          // 
          // btn_ReadSD
          // 
          this.btn_ReadSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btn_ReadSD.Location = new System.Drawing.Point(1259, 626);
          this.btn_ReadSD.Name = "btn_ReadSD";
          this.btn_ReadSD.Size = new System.Drawing.Size(128, 51);
          this.btn_ReadSD.TabIndex = 25;
          this.btn_ReadSD.Text = "Save in SD";
          this.btn_ReadSD.UseVisualStyleBackColor = true;
          this.btn_ReadSD.Click += new System.EventHandler(this.btn_ReadSD_Click);
          // 
          // groupBox4
          // 
          this.groupBox4.Controls.Add(this.QQVGA);
          this.groupBox4.Controls.Add(this.QVGA);
          this.groupBox4.Controls.Add(this.VGA);
          this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.groupBox4.Location = new System.Drawing.Point(1165, 399);
          this.groupBox4.Name = "groupBox4";
          this.groupBox4.Size = new System.Drawing.Size(206, 133);
          this.groupBox4.TabIndex = 25;
          this.groupBox4.TabStop = false;
          this.groupBox4.Text = "RESOLUTION";
          // 
          // QQVGA
          // 
          this.QQVGA.AutoSize = true;
          this.QQVGA.Location = new System.Drawing.Point(11, 99);
          this.QQVGA.Name = "QQVGA";
          this.QQVGA.Size = new System.Drawing.Size(103, 28);
          this.QQVGA.TabIndex = 25;
          this.QQVGA.Text = "QQVGA";
          this.QQVGA.UseVisualStyleBackColor = true;
          this.QQVGA.CheckedChanged += new System.EventHandler(this.QQVGA_CheckedChanged);
          // 
          // QVGA
          // 
          this.QVGA.AutoSize = true;
          this.QVGA.Location = new System.Drawing.Point(11, 62);
          this.QVGA.Name = "QVGA";
          this.QVGA.Size = new System.Drawing.Size(87, 28);
          this.QVGA.TabIndex = 24;
          this.QVGA.Text = "QVGA";
          this.QVGA.UseVisualStyleBackColor = true;
          this.QVGA.CheckedChanged += new System.EventHandler(this.QVGA_CheckedChanged);
          // 
          // VGA
          // 
          this.VGA.AutoSize = true;
          this.VGA.Checked = true;
          this.VGA.Location = new System.Drawing.Point(11, 28);
          this.VGA.Name = "VGA";
          this.VGA.Size = new System.Drawing.Size(71, 28);
          this.VGA.TabIndex = 23;
          this.VGA.TabStop = true;
          this.VGA.Text = "VGA";
          this.VGA.UseVisualStyleBackColor = true;
          this.VGA.CheckedChanged += new System.EventHandler(this.VGA_CheckedChanged);
          // 
          // label2
          // 
          this.label2.AutoSize = true;
          this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label2.Location = new System.Drawing.Point(1172, 535);
          this.label2.Name = "label2";
          this.label2.Size = new System.Drawing.Size(147, 20);
          this.label2.TabIndex = 26;
          this.label2.Text = "Time Scan (mins)";
          // 
          // TIMESCAN
          // 
          this.TIMESCAN.Enabled = false;
          this.TIMESCAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.TIMESCAN.Location = new System.Drawing.Point(1216, 560);
          this.TIMESCAN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
          this.TIMESCAN.Name = "TIMESCAN";
          this.TIMESCAN.Size = new System.Drawing.Size(63, 26);
          this.TIMESCAN.TabIndex = 27;
          this.TIMESCAN.ValueChanged += new System.EventHandler(this.TIMESCAN_ValueChanged);
          // 
          // MainMenu
          // 
          this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfig,
            this.menu_Help});
          this.MainMenu.Location = new System.Drawing.Point(0, 0);
          this.MainMenu.Name = "MainMenu";
          this.MainMenu.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
          this.MainMenu.Size = new System.Drawing.Size(1399, 24);
          this.MainMenu.TabIndex = 28;
          this.MainMenu.Text = "menuStrip1";
          // 
          // menuConfig
          // 
          this.menuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfig_Camera,
            this.menuConfig_Acquistion});
          this.menuConfig.Name = "menuConfig";
          this.menuConfig.Size = new System.Drawing.Size(93, 20);
          this.menuConfig.Text = "&Configuration";
          // 
          // menuConfig_Camera
          // 
          this.menuConfig_Camera.Name = "menuConfig_Camera";
          this.menuConfig_Camera.Size = new System.Drawing.Size(134, 22);
          this.menuConfig_Camera.Text = "C&amera";
          this.menuConfig_Camera.Click += new System.EventHandler(this.menuConfig_Camera_Click);
          // 
          // menuConfig_Acquistion
          // 
          this.menuConfig_Acquistion.Name = "menuConfig_Acquistion";
          this.menuConfig_Acquistion.Size = new System.Drawing.Size(134, 22);
          this.menuConfig_Acquistion.Text = "&Acquisition";
          this.menuConfig_Acquistion.Click += new System.EventHandler(this.menuConfig_Acquistion_Click);
          // 
          // menu_Help
          // 
          this.menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
          this.menu_Help.Name = "menu_Help";
          this.menu_Help.Size = new System.Drawing.Size(44, 20);
          this.menu_Help.Text = "&Help";
          // 
          // menuAbout
          // 
          this.menuAbout.Name = "menuAbout";
          this.menuAbout.Size = new System.Drawing.Size(116, 22);
          this.menuAbout.Text = "&About...";
          // 
          // button1
          // 
          this.button1.Location = new System.Drawing.Point(1328, 561);
          this.button1.Margin = new System.Windows.Forms.Padding(2);
          this.button1.Name = "button1";
          this.button1.Size = new System.Drawing.Size(42, 31);
          this.button1.TabIndex = 29;
          this.button1.Text = "button1";
          this.button1.UseVisualStyleBackColor = true;
          this.button1.Click += new System.EventHandler(this.button1_Click);
          // 
          // button2
          // 
          this.button2.Location = new System.Drawing.Point(806, 568);
          this.button2.Name = "button2";
          this.button2.Size = new System.Drawing.Size(58, 32);
          this.button2.TabIndex = 30;
          this.button2.Text = "button2";
          this.button2.UseVisualStyleBackColor = true;
          this.button2.Click += new System.EventHandler(this.button2_Click);
          // 
          // button3
          // 
          this.button3.Location = new System.Drawing.Point(806, 616);
          this.button3.Name = "button3";
          this.button3.Size = new System.Drawing.Size(58, 32);
          this.button3.TabIndex = 31;
          this.button3.Text = "button3";
          this.button3.UseVisualStyleBackColor = true;
          this.button3.Click += new System.EventHandler(this.button3_Click);
          // 
          // frmPrincipal
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.ClientSize = new System.Drawing.Size(1399, 709);
          this.Controls.Add(this.button3);
          this.Controls.Add(this.button2);
          this.Controls.Add(this.button1);
          this.Controls.Add(this.TIMESCAN);
          this.Controls.Add(this.label2);
          this.Controls.Add(this.groupBox4);
          this.Controls.Add(this.btn_ReadSD);
          this.Controls.Add(this.groupBox3);
          this.Controls.Add(this.btn_Clear);
          this.Controls.Add(this.btn_CameraConfig);
          this.Controls.Add(this.btn_Receive);
          this.Controls.Add(this.btn_Send);
          this.Controls.Add(this.btn_Prueba);
          this.Controls.Add(this.pictureBox1);
          this.Controls.Add(this.textBox1);
          this.Controls.Add(this.MainMenu);
          this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
          this.MainMenuStrip = this.MainMenu;
          this.MaximizeBox = false;
          this.Name = "frmPrincipal";
          this.Text = "CUBESAT CONTROL";
          this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
          this.Load += new System.EventHandler(this.frmPrincipal_Load);
          ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.hEADERBindingSource)).EndInit();
          ((System.ComponentModel.ISupportInitialize)(this.hEADERBindingSource1)).EndInit();
          this.groupBox3.ResumeLayout(false);
          this.groupBox3.PerformLayout();
          this.groupBox4.ResumeLayout(false);
          this.groupBox4.PerformLayout();
          ((System.ComponentModel.ISupportInitialize)(this.TIMESCAN)).EndInit();
          this.MainMenu.ResumeLayout(false);
          this.MainMenu.PerformLayout();
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Prueba;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Receive;
        private System.Windows.Forms.Button btn_CameraConfig;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.BindingSource hEADERBindingSource;
        private System.Windows.Forms.BindingSource hEADERBindingSource1;
        private System.Windows.Forms.RadioButton Manual;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton StarTracker;
        private System.Windows.Forms.Button btn_ReadSD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton QQVGA;
        private System.Windows.Forms.RadioButton QVGA;
        private System.Windows.Forms.RadioButton VGA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown TIMESCAN;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuConfig_Camera;
        private System.Windows.Forms.ToolStripMenuItem menu_Help;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuConfig_Acquistion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox1;
    }
}

