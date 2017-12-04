namespace sic_simulator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejecutarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pausarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasoAPasoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapaDeMemoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programaObjetoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_X = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_L = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_SW = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_PC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_COP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_INST = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_PNAME = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_PSIZE = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_ADDR = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_XFLAG = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_CODE = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_step = new System.Windows.Forms.ToolStripButton();
            this.btn_run = new System.Windows.Forms.ToolStripButton();
            this.btn_pause = new System.Windows.Forms.ToolStripButton();
            this.btn_stop = new System.Windows.Forms.ToolStripButton();
            this.btn_reset = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timerExec = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ejecutarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(291, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarProgramaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cargarProgramaToolStripMenuItem
            // 
            this.cargarProgramaToolStripMenuItem.Name = "cargarProgramaToolStripMenuItem";
            this.cargarProgramaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cargarProgramaToolStripMenuItem.Text = "Cargar programa";
            this.cargarProgramaToolStripMenuItem.Click += new System.EventHandler(this.cargarProgramaToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ejecutarToolStripMenuItem
            // 
            this.ejecutarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem,
            this.pausarToolStripMenuItem,
            this.pasoAPasoToolStripMenuItem,
            this.detenerToolStripMenuItem,
            this.reiniciarToolStripMenuItem});
            this.ejecutarToolStripMenuItem.Name = "ejecutarToolStripMenuItem";
            this.ejecutarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.ejecutarToolStripMenuItem.Text = "Ejecución";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // pausarToolStripMenuItem
            // 
            this.pausarToolStripMenuItem.Name = "pausarToolStripMenuItem";
            this.pausarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.pausarToolStripMenuItem.Text = "Pausar";
            // 
            // pasoAPasoToolStripMenuItem
            // 
            this.pasoAPasoToolStripMenuItem.Name = "pasoAPasoToolStripMenuItem";
            this.pasoAPasoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.pasoAPasoToolStripMenuItem.Text = "Paso a paso";
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapaDeMemoriaToolStripMenuItem,
            this.programaObjetoToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // mapaDeMemoriaToolStripMenuItem
            // 
            this.mapaDeMemoriaToolStripMenuItem.Name = "mapaDeMemoriaToolStripMenuItem";
            this.mapaDeMemoriaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.mapaDeMemoriaToolStripMenuItem.Text = "Mapa de memoria";
            this.mapaDeMemoriaToolStripMenuItem.Click += new System.EventHandler(this.mapaDeMemoriaToolStripMenuItem_Click);
            // 
            // programaObjetoToolStripMenuItem
            // 
            this.programaObjetoToolStripMenuItem.Name = "programaObjetoToolStripMenuItem";
            this.programaObjetoToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.programaObjetoToolStripMenuItem.Text = "Programa objeto";
            this.programaObjetoToolStripMenuItem.Click += new System.EventHandler(this.programaObjetoToolStripMenuItem_Click);
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(33, 51);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.ReadOnly = true;
            this.textBox_A.Size = new System.Drawing.Size(69, 20);
            this.textBox_A.TabIndex = 1;
            this.textBox_A.Text = "FFFFFF";
            this.textBox_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // textBox_X
            // 
            this.textBox_X.Location = new System.Drawing.Point(33, 77);
            this.textBox_X.Name = "textBox_X";
            this.textBox_X.ReadOnly = true;
            this.textBox_X.Size = new System.Drawing.Size(69, 20);
            this.textBox_X.TabIndex = 3;
            this.textBox_X.Text = "FFFFF";
            this.textBox_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "L";
            // 
            // textBox_L
            // 
            this.textBox_L.Location = new System.Drawing.Point(33, 103);
            this.textBox_L.Name = "textBox_L";
            this.textBox_L.ReadOnly = true;
            this.textBox_L.Size = new System.Drawing.Size(69, 20);
            this.textBox_L.TabIndex = 5;
            this.textBox_L.Text = "FFFFF";
            this.textBox_L.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SW";
            // 
            // textBox_SW
            // 
            this.textBox_SW.Location = new System.Drawing.Point(33, 129);
            this.textBox_SW.Name = "textBox_SW";
            this.textBox_SW.ReadOnly = true;
            this.textBox_SW.Size = new System.Drawing.Size(69, 20);
            this.textBox_SW.TabIndex = 7;
            this.textBox_SW.Text = "FFFFF";
            this.textBox_SW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "PC";
            // 
            // textBox_PC
            // 
            this.textBox_PC.Location = new System.Drawing.Point(33, 25);
            this.textBox_PC.Name = "textBox_PC";
            this.textBox_PC.ReadOnly = true;
            this.textBox_PC.Size = new System.Drawing.Size(69, 20);
            this.textBox_PC.TabIndex = 9;
            this.textBox_PC.Text = "FFFFFF";
            this.textBox_PC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Instrucción (HEX)";
            // 
            // textBox_COP
            // 
            this.textBox_COP.Location = new System.Drawing.Point(16, 38);
            this.textBox_COP.Name = "textBox_COP";
            this.textBox_COP.ReadOnly = true;
            this.textBox_COP.Size = new System.Drawing.Size(107, 20);
            this.textBox_COP.TabIndex = 11;
            this.textBox_COP.Text = "FFFFFF";
            this.textBox_COP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Instrucción (ASM)";
            // 
            // textBox_INST
            // 
            this.textBox_INST.Location = new System.Drawing.Point(16, 136);
            this.textBox_INST.Name = "textBox_INST";
            this.textBox_INST.ReadOnly = true;
            this.textBox_INST.Size = new System.Drawing.Size(107, 20);
            this.textBox_INST.TabIndex = 13;
            this.textBox_INST.Text = "FFFFFF";
            this.textBox_INST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nombre del Programa:";
            // 
            // textBox_PNAME
            // 
            this.textBox_PNAME.Location = new System.Drawing.Point(124, 22);
            this.textBox_PNAME.Name = "textBox_PNAME";
            this.textBox_PNAME.ReadOnly = true;
            this.textBox_PNAME.Size = new System.Drawing.Size(135, 20);
            this.textBox_PNAME.TabIndex = 15;
            this.textBox_PNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tamaño del Programa:";
            // 
            // textBox_PSIZE
            // 
            this.textBox_PSIZE.Location = new System.Drawing.Point(124, 48);
            this.textBox_PSIZE.Name = "textBox_PSIZE";
            this.textBox_PSIZE.ReadOnly = true;
            this.textBox_PSIZE.Size = new System.Drawing.Size(135, 20);
            this.textBox_PSIZE.TabIndex = 17;
            this.textBox_PSIZE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox_PNAME);
            this.groupBox1.Controls.Add(this.textBox_PSIZE);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 75);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_A);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_X);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_L);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_PC);
            this.groupBox2.Controls.Add(this.textBox_SW);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(118, 169);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registros";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_ADDR);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.textBox_XFLAG);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox_CODE);
            this.groupBox3.Controls.Add(this.textBox_COP);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox_INST);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(136, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 169);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Instruccion";
            // 
            // textBox_ADDR
            // 
            this.textBox_ADDR.Location = new System.Drawing.Point(81, 88);
            this.textBox_ADDR.Name = "textBox_ADDR";
            this.textBox_ADDR.ReadOnly = true;
            this.textBox_ADDR.Size = new System.Drawing.Size(39, 20);
            this.textBox_ADDR.TabIndex = 20;
            this.textBox_ADDR.Text = "FFF";
            this.textBox_ADDR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "ADDR";
            // 
            // textBox_XFLAG
            // 
            this.textBox_XFLAG.Location = new System.Drawing.Point(51, 88);
            this.textBox_XFLAG.Name = "textBox_XFLAG";
            this.textBox_XFLAG.ReadOnly = true;
            this.textBox_XFLAG.Size = new System.Drawing.Size(21, 20);
            this.textBox_XFLAG.TabIndex = 18;
            this.textBox_XFLAG.Text = "0";
            this.textBox_XFLAG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "COP";
            // 
            // textBox_CODE
            // 
            this.textBox_CODE.Location = new System.Drawing.Point(20, 88);
            this.textBox_CODE.Name = "textBox_CODE";
            this.textBox_CODE.ReadOnly = true;
            this.textBox_CODE.Size = new System.Drawing.Size(21, 20);
            this.textBox_CODE.TabIndex = 15;
            this.textBox_CODE.Text = "FF";
            this.textBox_CODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_step,
            this.btn_run,
            this.btn_pause,
            this.btn_stop,
            this.btn_reset,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(291, 39);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_step
            // 
            this.btn_step.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_step.Image = ((System.Drawing.Image)(resources.GetObject("btn_step.Image")));
            this.btn_step.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_step.Name = "btn_step";
            this.btn_step.Size = new System.Drawing.Size(36, 36);
            this.btn_step.ToolTipText = "Ejecutar instruccion";
            this.btn_step.Click += new System.EventHandler(this.btn_step_Click);
            // 
            // btn_run
            // 
            this.btn_run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_run.Image = ((System.Drawing.Image)(resources.GetObject("btn_run.Image")));
            this.btn_run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(36, 36);
            this.btn_run.ToolTipText = "Ejecutar programa";
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_pause.Image = ((System.Drawing.Image)(resources.GetObject("btn_pause.Image")));
            this.btn_pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(36, 36);
            this.btn_pause.Text = "toolStripButton4";
            this.btn_pause.ToolTipText = "Pausar ejecución";
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_stop.Image = ((System.Drawing.Image)(resources.GetObject("btn_stop.Image")));
            this.btn_stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(36, 36);
            this.btn_stop.Text = "toolStripButton5";
            this.btn_stop.ToolTipText = "Detener ejecución";
            // 
            // btn_reset
            // 
            this.btn_reset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_reset.Image = ((System.Drawing.Image)(resources.GetObject("btn_reset.Image")));
            this.btn_reset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(36, 36);
            this.btn_reset.Text = "toolStripButton2";
            this.btn_reset.ToolTipText = "Reiniciar programa";
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton6.Size = new System.Drawing.Size(36, 36);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timerExec
            // 
            this.timerExec.Tick += new System.EventHandler(this.timerExec_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 314);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(307, 353);
            this.MinimumSize = new System.Drawing.Size(307, 353);
            this.Name = "Form1";
            this.Text = "Simulador SIC Estandar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejecutarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pausarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasoAPasoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapaDeMemoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programaObjetoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_X;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_L;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_SW;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_PC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_COP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_INST;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_PNAME;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_PSIZE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_step;
        private System.Windows.Forms.ToolStripButton btn_reset;
        private System.Windows.Forms.ToolStripButton btn_run;
        private System.Windows.Forms.ToolStripButton btn_pause;
        private System.Windows.Forms.ToolStripButton btn_stop;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox_ADDR;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_XFLAG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_CODE;
        private System.Windows.Forms.Timer timerExec;
    }
}

