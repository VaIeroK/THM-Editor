namespace ThmEditor
{
    partial class ThmEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThmEditor));
            this.OpenFileThmDialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextBoxDetail = new System.Windows.Forms.TextBox();
            this.TextBoxBump = new System.Windows.Forms.TextBox();
            this.TextBoxNMap = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.SaveAsFileThmDialog = new System.Windows.Forms.SaveFileDialog();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.OpenFileDDSDialog = new System.Windows.Forms.OpenFileDialog();
            this.MenuPanel = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importDDSParamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateTHMForTextureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonLoadDetail = new System.Windows.Forms.Button();
            this.ButtonLoadBump = new System.Windows.Forms.Button();
            this.ButtonLoadNMap = new System.Windows.Forms.Button();
            this.OpenFileDDSMapDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LabelStatusFileText = new System.Windows.Forms.ToolStripStatusLabel();
            this.LabelStatusFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.OpenFileGenerateTHMDialog = new System.Windows.Forms.OpenFileDialog();
            this.MenuPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileThmDialog
            // 
            this.OpenFileThmDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenTHM);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Image",
            "Cube Map",
            "Bump Map",
            "Normal Map",
            "Terrain"});
            this.comboBox1.Location = new System.Drawing.Point(96, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(225, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ChangeTextureType);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texture type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texture format";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "DXT1",
            "ADXT1",
            "DXT3",
            "DXT5",
            "4444",
            "1555",
            "565",
            "RGB",
            "RGBA",
            "NVHS",
            "NVHU",
            "A8",
            "L8",
            "A8L8",
            "BC4",
            "BC5",
            "BC6",
            "BC7"});
            this.comboBox2.Location = new System.Drawing.Point(96, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(225, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bump mode";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "None",
            "Use",
            "Use Parallax"});
            this.comboBox3.Location = new System.Drawing.Point(96, 81);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(225, 21);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Detail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bump";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Normal map";
            // 
            // TextBoxDetail
            // 
            this.TextBoxDetail.Location = new System.Drawing.Point(73, 259);
            this.TextBoxDetail.Name = "TextBoxDetail";
            this.TextBoxDetail.Size = new System.Drawing.Size(271, 20);
            this.TextBoxDetail.TabIndex = 11;
            this.TextBoxDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // TextBoxBump
            // 
            this.TextBoxBump.Location = new System.Drawing.Point(73, 286);
            this.TextBoxBump.Name = "TextBoxBump";
            this.TextBoxBump.Size = new System.Drawing.Size(271, 20);
            this.TextBoxBump.TabIndex = 12;
            this.TextBoxBump.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // TextBoxNMap
            // 
            this.TextBoxNMap.Location = new System.Drawing.Point(73, 312);
            this.TextBoxNMap.Name = "TextBoxNMap";
            this.TextBoxNMap.Size = new System.Drawing.Size(271, 20);
            this.TextBoxNMap.TabIndex = 13;
            this.TextBoxNMap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Border color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(91, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fade color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Fade amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "MIP filter";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Texture width";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(91, 217);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Texture height";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(14, 185);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(74, 20);
            this.textBox4.TabIndex = 20;
            this.textBox4.Tag = "Uint";
            this.textBox4.TextChanged += new System.EventHandler(this.TextBoxFilter);
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(174, 185);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(74, 20);
            this.textBox5.TabIndex = 21;
            this.textBox5.Tag = "Uint";
            this.textBox5.TextChanged += new System.EventHandler(this.TextBoxFilter);
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(94, 185);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(74, 20);
            this.textBox6.TabIndex = 22;
            this.textBox6.Tag = "Uint";
            this.textBox6.TextChanged += new System.EventHandler(this.TextBoxFilter);
            this.textBox6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(14, 233);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(74, 20);
            this.textBox8.TabIndex = 24;
            this.textBox8.Tag = "Uint";
            this.textBox8.TextChanged += new System.EventHandler(this.TextBoxFilter);
            this.textBox8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(94, 233);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(74, 20);
            this.textBox9.TabIndex = 25;
            this.textBox9.Tag = "Uint";
            this.textBox9.TextChanged += new System.EventHandler(this.TextBoxFilter);
            this.textBox9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // SaveAsFileThmDialog
            // 
            this.SaveAsFileThmDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveAsTHM);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(172, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Fade delay";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(174, 233);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(74, 20);
            this.textBox10.TabIndex = 28;
            this.textBox10.Tag = "Uint";
            this.textBox10.TextChanged += new System.EventHandler(this.TextBoxFilter);
            this.textBox10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(254, 185);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(74, 20);
            this.textBox11.TabIndex = 29;
            this.textBox11.Tag = "Float";
            this.textBox11.TextChanged += new System.EventHandler(this.TextBoxFilter);
            this.textBox11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(254, 233);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(74, 20);
            this.textBox12.TabIndex = 30;
            this.textBox12.Tag = "Float";
            this.textBox12.TextChanged += new System.EventHandler(this.TextBoxFilter);
            this.textBox12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(251, 169);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Material weight";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(251, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Bump height";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Box",
            "Cubic",
            "Point",
            "Triangle",
            "Quadratic",
            "Advanced",
            "Catrom",
            "Mitchell",
            "Gaussian",
            "Sinc",
            "Bessel",
            "Hanning",
            "Hamming",
            "Blackman",
            "Kaiser"});
            this.comboBox4.Location = new System.Drawing.Point(96, 108);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(225, 21);
            this.comboBox4.TabIndex = 33;
            this.comboBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(334, 39);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 103);
            this.button5.TabIndex = 36;
            this.button5.Text = "Edit flags";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            this.button5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // OpenFileDDSDialog
            // 
            this.OpenFileDDSDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.ImportDDS);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(425, 24);
            this.MenuPanel.TabIndex = 38;
            this.MenuPanel.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.OpenDialogTHM);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveTHM);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsDialogTHM);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importDDSParamsToolStripMenuItem,
            this.generateTHMForTextureToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // importDDSParamsToolStripMenuItem
            // 
            this.importDDSParamsToolStripMenuItem.Name = "importDDSParamsToolStripMenuItem";
            this.importDDSParamsToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.importDDSParamsToolStripMenuItem.Text = "Import DDS Params";
            this.importDDSParamsToolStripMenuItem.Click += new System.EventHandler(this.ImportDDSDialog);
            // 
            // generateTHMForTextureToolStripMenuItem
            // 
            this.generateTHMForTextureToolStripMenuItem.Name = "generateTHMForTextureToolStripMenuItem";
            this.generateTHMForTextureToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.generateTHMForTextureToolStripMenuItem.Text = "Generate THM for texture";
            this.generateTHMForTextureToolStripMenuItem.Click += new System.EventHandler(this.generateTHMForTextureToolStripMenuItem_Click);
            // 
            // ButtonLoadDetail
            // 
            this.ButtonLoadDetail.Location = new System.Drawing.Point(350, 259);
            this.ButtonLoadDetail.Name = "ButtonLoadDetail";
            this.ButtonLoadDetail.Size = new System.Drawing.Size(63, 20);
            this.ButtonLoadDetail.TabIndex = 39;
            this.ButtonLoadDetail.Tag = "Detail";
            this.ButtonLoadDetail.Text = "Load";
            this.ButtonLoadDetail.UseVisualStyleBackColor = true;
            this.ButtonLoadDetail.Click += new System.EventHandler(this.LoadTextureMap);
            this.ButtonLoadDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // ButtonLoadBump
            // 
            this.ButtonLoadBump.Location = new System.Drawing.Point(350, 286);
            this.ButtonLoadBump.Name = "ButtonLoadBump";
            this.ButtonLoadBump.Size = new System.Drawing.Size(63, 20);
            this.ButtonLoadBump.TabIndex = 40;
            this.ButtonLoadBump.Tag = "Bump";
            this.ButtonLoadBump.Text = "Load";
            this.ButtonLoadBump.UseVisualStyleBackColor = true;
            this.ButtonLoadBump.Click += new System.EventHandler(this.LoadTextureMap);
            this.ButtonLoadBump.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // ButtonLoadNMap
            // 
            this.ButtonLoadNMap.Location = new System.Drawing.Point(350, 312);
            this.ButtonLoadNMap.Name = "ButtonLoadNMap";
            this.ButtonLoadNMap.Size = new System.Drawing.Size(63, 20);
            this.ButtonLoadNMap.TabIndex = 41;
            this.ButtonLoadNMap.Tag = "NMap";
            this.ButtonLoadNMap.Text = "Load";
            this.ButtonLoadNMap.UseVisualStyleBackColor = true;
            this.ButtonLoadNMap.Click += new System.EventHandler(this.LoadTextureMap);
            this.ButtonLoadNMap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // OpenFileDDSMapDialog
            // 
            this.OpenFileDDSMapDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.LoadDDSMap);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelStatusFileText,
            this.LabelStatusFile});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(425, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 48;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LabelStatusFileText
            // 
            this.LabelStatusFileText.Name = "LabelStatusFileText";
            this.LabelStatusFileText.Size = new System.Drawing.Size(28, 17);
            this.LabelStatusFileText.Text = "File:";
            // 
            // LabelStatusFile
            // 
            this.LabelStatusFile.Name = "LabelStatusFile";
            this.LabelStatusFile.Size = new System.Drawing.Size(12, 17);
            this.LabelStatusFile.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 20);
            this.textBox1.TabIndex = 49;
            this.textBox1.Tag = "Float";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBoxFilter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxKeyDown);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(331, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 50;
            this.label19.Text = "Detail scale";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "OrenNayar Blin",
            "Phong",
            "Phong Metal",
            "Metal OrenNayar"});
            this.comboBox7.Location = new System.Drawing.Point(96, 135);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(225, 21);
            this.comboBox7.TabIndex = 51;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 138);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "Material";
            // 
            // OpenFileGenerateTHMDialog
            // 
            this.OpenFileGenerateTHMDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.GenerateTHM);
            // 
            // ThmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 361);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ButtonLoadNMap);
            this.Controls.Add(this.ButtonLoadBump);
            this.Controls.Add(this.ButtonLoadDetail);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextBoxNMap);
            this.Controls.Add(this.TextBoxBump);
            this.Controls.Add(this.TextBoxDetail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.MenuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPanel;
            this.Name = "ThmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THM Editor";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog OpenFileThmDialog;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextBoxDetail;
        private System.Windows.Forms.TextBox TextBoxBump;
        private System.Windows.Forms.TextBox TextBoxNMap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog OpenFileDDSDialog;
        private System.Windows.Forms.MenuStrip MenuPanel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveAsFileThmDialog;
        private System.Windows.Forms.ToolStripMenuItem importDDSParamsToolStripMenuItem;
        private System.Windows.Forms.Button ButtonLoadDetail;
        private System.Windows.Forms.Button ButtonLoadBump;
        private System.Windows.Forms.Button ButtonLoadNMap;
        private System.Windows.Forms.OpenFileDialog OpenFileDDSMapDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LabelStatusFileText;
        private System.Windows.Forms.ToolStripStatusLabel LabelStatusFile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ToolStripMenuItem generateTHMForTextureToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFileGenerateTHMDialog;
    }
}