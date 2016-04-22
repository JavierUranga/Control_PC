namespace ReadSerial
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Prueba = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Receive = new System.Windows.Forms.Button();
            this.btn_CameraConfig = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_ReadHeader = new System.Windows.Forms.Button();
            this.btn_ReadStarPair = new System.Windows.Forms.Button();
            this.Num = new System.Windows.Forms.NumericUpDown();
            this.hEADERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hEADERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_ReadStarID = new System.Windows.Forms.Button();
            this.btn_ReadUvector = new System.Windows.Forms.Button();
            this.btn_SendHeader = new System.Windows.Forms.Button();
            this.btn_SendStarPairs = new System.Windows.Forms.Button();
            this.btn_SendStarIDs = new System.Windows.Forms.Button();
            this.btn_SendUvectors = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hEADERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hEADERBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TIMESCAN)).BeginInit();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(613, 720);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(653, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(853, 591);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Prueba
            // 
            this.btn_Prueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Prueba.Location = new System.Drawing.Point(1560, 279);
            this.btn_Prueba.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Prueba.Name = "btn_Prueba";
            this.btn_Prueba.Size = new System.Drawing.Size(268, 64);
            this.btn_Prueba.TabIndex = 2;
            this.btn_Prueba.Text = "Prueba...";
            this.btn_Prueba.UseVisualStyleBackColor = true;
            this.btn_Prueba.Visible = false;
            this.btn_Prueba.Click += new System.EventHandler(this.btn_Prueba_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(1553, 43);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(268, 57);
            this.btn_Send.TabIndex = 4;
            this.btn_Send.Text = "Capture Image";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Receive
            // 
            this.btn_Receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Receive.Location = new System.Drawing.Point(1553, 119);
            this.btn_Receive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Receive.Name = "btn_Receive";
            this.btn_Receive.Size = new System.Drawing.Size(268, 57);
            this.btn_Receive.TabIndex = 5;
            this.btn_Receive.Text = "Read Image";
            this.btn_Receive.UseVisualStyleBackColor = true;
            this.btn_Receive.Click += new System.EventHandler(this.btn_Receive_Click);
            // 
            // btn_CameraConfig
            // 
            this.btn_CameraConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CameraConfig.Location = new System.Drawing.Point(1553, 198);
            this.btn_CameraConfig.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CameraConfig.Name = "btn_CameraConfig";
            this.btn_CameraConfig.Size = new System.Drawing.Size(268, 60);
            this.btn_CameraConfig.TabIndex = 6;
            this.btn_CameraConfig.Text = "Get Camera Config";
            this.btn_CameraConfig.UseVisualStyleBackColor = true;
            this.btn_CameraConfig.Click += new System.EventHandler(this.btn_CameraConfig_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.Location = new System.Drawing.Point(0, 770);
            this.btn_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(616, 44);
            this.btn_Clear.TabIndex = 7;
            this.btn_Clear.Text = "CLEAR";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_ReadHeader
            // 
            this.btn_ReadHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReadHeader.Location = new System.Drawing.Point(15, 39);
            this.btn_ReadHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ReadHeader.Name = "btn_ReadHeader";
            this.btn_ReadHeader.Size = new System.Drawing.Size(184, 47);
            this.btn_ReadHeader.TabIndex = 9;
            this.btn_ReadHeader.Text = "Read Header";
            this.btn_ReadHeader.UseVisualStyleBackColor = true;
            this.btn_ReadHeader.Click += new System.EventHandler(this.btn_ReadHeader_Click);
            // 
            // btn_ReadStarPair
            // 
            this.btn_ReadStarPair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReadStarPair.Location = new System.Drawing.Point(229, 39);
            this.btn_ReadStarPair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ReadStarPair.Name = "btn_ReadStarPair";
            this.btn_ReadStarPair.Size = new System.Drawing.Size(203, 47);
            this.btn_ReadStarPair.TabIndex = 12;
            this.btn_ReadStarPair.Text = "Read Star Pair";
            this.btn_ReadStarPair.UseVisualStyleBackColor = true;
            this.btn_ReadStarPair.Click += new System.EventHandler(this.btn_ReadStarPair_Click);
            // 
            // Num
            // 
            this.Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num.Location = new System.Drawing.Point(897, 48);
            this.Num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(84, 30);
            this.Num.TabIndex = 13;
            // 
            // btn_ReadStarID
            // 
            this.btn_ReadStarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReadStarID.Location = new System.Drawing.Point(471, 39);
            this.btn_ReadStarID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ReadStarID.Name = "btn_ReadStarID";
            this.btn_ReadStarID.Size = new System.Drawing.Size(184, 47);
            this.btn_ReadStarID.TabIndex = 12;
            this.btn_ReadStarID.Text = "Read Star ID";
            this.btn_ReadStarID.UseVisualStyleBackColor = true;
            this.btn_ReadStarID.Click += new System.EventHandler(this.btn_ReadStarID_Click);
            // 
            // btn_ReadUvector
            // 
            this.btn_ReadUvector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReadUvector.Location = new System.Drawing.Point(683, 39);
            this.btn_ReadUvector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ReadUvector.Name = "btn_ReadUvector";
            this.btn_ReadUvector.Size = new System.Drawing.Size(184, 47);
            this.btn_ReadUvector.TabIndex = 12;
            this.btn_ReadUvector.Text = "Read Uvector";
            this.btn_ReadUvector.UseVisualStyleBackColor = true;
            this.btn_ReadUvector.Click += new System.EventHandler(this.btn_ReadUvector_Click);
            // 
            // btn_SendHeader
            // 
            this.btn_SendHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendHeader.Location = new System.Drawing.Point(15, 34);
            this.btn_SendHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SendHeader.Name = "btn_SendHeader";
            this.btn_SendHeader.Size = new System.Drawing.Size(184, 43);
            this.btn_SendHeader.TabIndex = 17;
            this.btn_SendHeader.Text = "Send Header";
            this.btn_SendHeader.UseVisualStyleBackColor = true;
            this.btn_SendHeader.Click += new System.EventHandler(this.btn_SendHeader_Click);
            // 
            // btn_SendStarPairs
            // 
            this.btn_SendStarPairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendStarPairs.Location = new System.Drawing.Point(229, 34);
            this.btn_SendStarPairs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SendStarPairs.Name = "btn_SendStarPairs";
            this.btn_SendStarPairs.Size = new System.Drawing.Size(203, 43);
            this.btn_SendStarPairs.TabIndex = 18;
            this.btn_SendStarPairs.Text = "Send Star Pairs";
            this.btn_SendStarPairs.UseVisualStyleBackColor = true;
            this.btn_SendStarPairs.Click += new System.EventHandler(this.btn_SendStarPairs_Click);
            // 
            // btn_SendStarIDs
            // 
            this.btn_SendStarIDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendStarIDs.Location = new System.Drawing.Point(471, 34);
            this.btn_SendStarIDs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SendStarIDs.Name = "btn_SendStarIDs";
            this.btn_SendStarIDs.Size = new System.Drawing.Size(184, 43);
            this.btn_SendStarIDs.TabIndex = 19;
            this.btn_SendStarIDs.Text = "Send Star IDs";
            this.btn_SendStarIDs.UseVisualStyleBackColor = true;
            this.btn_SendStarIDs.Click += new System.EventHandler(this.btn_SendStarIDs_Click);
            // 
            // btn_SendUvectors
            // 
            this.btn_SendUvectors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SendUvectors.Location = new System.Drawing.Point(683, 34);
            this.btn_SendUvectors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SendUvectors.Name = "btn_SendUvectors";
            this.btn_SendUvectors.Size = new System.Drawing.Size(184, 43);
            this.btn_SendUvectors.TabIndex = 20;
            this.btn_SendUvectors.Text = "Send Uvectors";
            this.btn_SendUvectors.UseVisualStyleBackColor = true;
            this.btn_SendUvectors.Click += new System.EventHandler(this.btn_SendUvectors_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_ReadHeader);
            this.groupBox1.Controls.Add(this.btn_ReadStarID);
            this.groupBox1.Controls.Add(this.btn_ReadStarPair);
            this.groupBox1.Controls.Add(this.btn_ReadUvector);
            this.groupBox1.Controls.Add(this.Num);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(653, 747);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1013, 112);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reading";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(892, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Index";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SendHeader);
            this.groupBox2.Controls.Add(this.btn_SendStarPairs);
            this.groupBox2.Controls.Add(this.btn_SendUvectors);
            this.groupBox2.Controls.Add(this.btn_SendStarIDs);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(653, 641);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(892, 98);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Writing";
            // 
            // Manual
            // 
            this.Manual.AutoSize = true;
            this.Manual.Checked = true;
            this.Manual.Location = new System.Drawing.Point(19, 33);
            this.Manual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Manual.Name = "Manual";
            this.Manual.Size = new System.Drawing.Size(138, 33);
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
            this.groupBox3.Location = new System.Drawing.Point(1549, 364);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(279, 119);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MODE";
            // 
            // StarTracker
            // 
            this.StarTracker.AutoSize = true;
            this.StarTracker.Location = new System.Drawing.Point(19, 75);
            this.StarTracker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StarTracker.Name = "StarTracker";
            this.StarTracker.Size = new System.Drawing.Size(184, 33);
            this.StarTracker.TabIndex = 24;
            this.StarTracker.Text = "AUTOMATIC";
            this.StarTracker.UseVisualStyleBackColor = true;
            // 
            // btn_ReadSD
            // 
            this.btn_ReadSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReadSD.Location = new System.Drawing.Point(1679, 770);
            this.btn_ReadSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ReadSD.Name = "btn_ReadSD";
            this.btn_ReadSD.Size = new System.Drawing.Size(171, 63);
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
            this.groupBox4.Location = new System.Drawing.Point(1553, 491);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(275, 164);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RESOLUTION";
            // 
            // QQVGA
            // 
            this.QQVGA.AutoSize = true;
            this.QQVGA.Location = new System.Drawing.Point(15, 122);
            this.QQVGA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QQVGA.Name = "QQVGA";
            this.QQVGA.Size = new System.Drawing.Size(125, 33);
            this.QQVGA.TabIndex = 25;
            this.QQVGA.Text = "QQVGA";
            this.QQVGA.UseVisualStyleBackColor = true;
            this.QQVGA.CheckedChanged += new System.EventHandler(this.QQVGA_CheckedChanged);
            // 
            // QVGA
            // 
            this.QVGA.AutoSize = true;
            this.QVGA.Location = new System.Drawing.Point(15, 76);
            this.QVGA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QVGA.Name = "QVGA";
            this.QVGA.Size = new System.Drawing.Size(105, 33);
            this.QVGA.TabIndex = 24;
            this.QVGA.Text = "QVGA";
            this.QVGA.UseVisualStyleBackColor = true;
            this.QVGA.CheckedChanged += new System.EventHandler(this.QVGA_CheckedChanged);
            // 
            // VGA
            // 
            this.VGA.AutoSize = true;
            this.VGA.Checked = true;
            this.VGA.Location = new System.Drawing.Point(15, 34);
            this.VGA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VGA.Name = "VGA";
            this.VGA.Size = new System.Drawing.Size(85, 33);
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
            this.label2.Location = new System.Drawing.Point(1563, 658);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Time Scan (mins)";
            // 
            // TIMESCAN
            // 
            this.TIMESCAN.Enabled = false;
            this.TIMESCAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TIMESCAN.Location = new System.Drawing.Point(1621, 689);
            this.TIMESCAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TIMESCAN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TIMESCAN.Name = "TIMESCAN";
            this.TIMESCAN.Size = new System.Drawing.Size(84, 30);
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
            this.MainMenu.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(1865, 28);
            this.MainMenu.TabIndex = 28;
            this.MainMenu.Text = "menuStrip1";
            // 
            // menuConfig
            // 
            this.menuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuConfig_Camera,
            this.menuConfig_Acquistion});
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(112, 24);
            this.menuConfig.Text = "&Configuration";
            // 
            // menuConfig_Camera
            // 
            this.menuConfig_Camera.Name = "menuConfig_Camera";
            this.menuConfig_Camera.Size = new System.Drawing.Size(152, 24);
            this.menuConfig_Camera.Text = "C&amera";
            this.menuConfig_Camera.Click += new System.EventHandler(this.menuConfig_Camera_Click);
            // 
            // menuConfig_Acquistion
            // 
            this.menuConfig_Acquistion.Name = "menuConfig_Acquistion";
            this.menuConfig_Acquistion.Size = new System.Drawing.Size(152, 24);
            this.menuConfig_Acquistion.Text = "&Acquisition";
            this.menuConfig_Acquistion.Click += new System.EventHandler(this.menuConfig_Acquistion_Click);
            // 
            // menu_Help
            // 
            this.menu_Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAbout});
            this.menu_Help.Name = "menu_Help";
            this.menu_Help.Size = new System.Drawing.Size(53, 24);
            this.menu_Help.Text = "&Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(128, 24);
            this.menuAbout.Text = "&About...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1771, 691);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 38);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1865, 873);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TIMESCAN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btn_ReadSD);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CUBESAT CONTROL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hEADERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hEADERBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Prueba;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Receive;
        private System.Windows.Forms.Button btn_CameraConfig;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_ReadHeader;
        private System.Windows.Forms.Button btn_ReadStarPair;
        private System.Windows.Forms.NumericUpDown Num;
        private System.Windows.Forms.BindingSource hEADERBindingSource;
        private System.Windows.Forms.BindingSource hEADERBindingSource1;
        private System.Windows.Forms.Button btn_ReadStarID;
        private System.Windows.Forms.Button btn_ReadUvector;
        private System.Windows.Forms.Button btn_SendHeader;
        private System.Windows.Forms.Button btn_SendStarPairs;
        private System.Windows.Forms.Button btn_SendStarIDs;
        private System.Windows.Forms.Button btn_SendUvectors;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
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
    }
}

