namespace ProyectoFinal
{
    partial class frmOpciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpciones));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Producción");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Distribución");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Area de Porducción", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Coordinador de Ventas");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Lider de Ventas");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Ventas", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Publicidad");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Area de Comerzalización", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Contabilidad");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Logistica");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Coordinador de Bodegas");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Transportadores");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Auxiliar de Bodega");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Auxiliador de Transporte");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Area de Finanzas", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14});
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Coordinador Recursos Humanos");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Asistente Administrativo");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Recursos Humanos", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Auxiliar de Administración");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Atención al Cliente");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Administración", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Gerente de Ventas");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Gerente de Calidad");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Gerente de Operaciones");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Gerencia", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblRango = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFecha = new System.Windows.Forms.Button();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorrarServicios = new System.Windows.Forms.Button();
            this.lblServicios = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtServicios = new System.Windows.Forms.TextBox();
            this.lstServicios = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnBorrarDUP = new System.Windows.Forms.Button();
            this.dupProductos = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tstOperaciones = new System.Windows.Forms.ToolStrip();
            this.tstbSuma = new System.Windows.Forms.ToolStripButton();
            this.tstbResta = new System.Windows.Forms.ToolStripButton();
            this.tstbMultiplicacion = new System.Windows.Forms.ToolStripButton();
            this.tstbDivision = new System.Windows.Forms.ToolStripButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.cmnuTxt = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aleatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtA = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarFuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarColorDeLasFuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dividirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtElemento = new System.Windows.Forms.TextBox();
            this.txtNodo = new System.Windows.Forms.TextBox();
            this.btnLimpiarArbol = new System.Windows.Forms.Button();
            this.btnAdicionarNodo = new System.Windows.Forms.Button();
            this.btnAdicionarElemento = new System.Windows.Forms.Button();
            this.btnEliminarNodo = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblSaveDialog = new System.Windows.Forms.Label();
            this.btnSaveDialog = new System.Windows.Forms.Button();
            this.lblOpenDialog = new System.Windows.Forms.Label();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEmpleados10 = new System.Windows.Forms.RadioButton();
            this.rbEmpleados9 = new System.Windows.Forms.RadioButton();
            this.rbEmpleados8 = new System.Windows.Forms.RadioButton();
            this.rbEmpleados7 = new System.Windows.Forms.RadioButton();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.btnAgregarCargos = new System.Windows.Forms.Button();
            this.rbEmpleados6 = new System.Windows.Forms.RadioButton();
            this.rbEmpleados5 = new System.Windows.Forms.RadioButton();
            this.rbEmpleados4 = new System.Windows.Forms.RadioButton();
            this.rbEmpleados3 = new System.Windows.Forms.RadioButton();
            this.rbEmpleados2 = new System.Windows.Forms.RadioButton();
            this.rbEmpleados1 = new System.Windows.Forms.RadioButton();
            this.lstvEmpleados = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnCambioImagen = new System.Windows.Forms.Button();
            this.lblFoto = new System.Windows.Forms.Label();
            this.imglFotos = new System.Windows.Forms.ImageList(this.components);
            this.lblRuta = new System.Windows.Forms.Label();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnTocar = new System.Windows.Forms.Button();
            this.btnSistema = new System.Windows.Forms.Button();
            this.btnTono = new System.Windows.Forms.Button();
            this.btnBeep = new System.Windows.Forms.Button();
            this.txtDura = new System.Windows.Forms.TextBox();
            this.txtFreq = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCerrarNotepad = new System.Windows.Forms.Button();
            this.btnAbrirNotepad = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.prcNotedPad = new System.Diagnostics.Process();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esconderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tstOperaciones.SuspendLayout();
            this.cmnuTxt.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 630);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.panel4);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.lblRango);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.btnFecha);
            this.tabPage1.Controls.Add(this.lblFinal);
            this.tabPage1.Controls.Add(this.lblInicio);
            this.tabPage1.Controls.Add(this.monthCalendar1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tstOperaciones);
            this.tabPage1.Controls.Add(this.lblResultado);
            this.tabPage1.Controls.Add(this.txtB);
            this.tabPage1.Controls.Add(this.txtA);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pagina #1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel4.Location = new System.Drawing.Point(625, -2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 255);
            this.panel4.TabIndex = 43;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel3.Location = new System.Drawing.Point(285, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 255);
            this.panel3.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(0, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1035, 1);
            this.panel2.TabIndex = 41;
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRango.Location = new System.Drawing.Point(144, 549);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(34, 24);
            this.lblRango.TabIndex = 15;
            this.lblRango.Text = "----";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(144, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Final:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(144, 479);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Inicio:";
            // 
            // btnFecha
            // 
            this.btnFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFecha.Location = new System.Drawing.Point(144, 434);
            this.btnFecha.Name = "btnFecha";
            this.btnFecha.Size = new System.Drawing.Size(189, 30);
            this.btnFecha.TabIndex = 12;
            this.btnFecha.Text = "Seleccionar Fechas";
            this.btnFecha.UseVisualStyleBackColor = true;
            this.btnFecha.Click += new System.EventHandler(this.btnFecha_Click);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFinal.Location = new System.Drawing.Point(207, 514);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(40, 24);
            this.lblFinal.TabIndex = 11;
            this.lblFinal.Text = "-----";
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInicio.Location = new System.Drawing.Point(207, 479);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(40, 24);
            this.lblInicio.TabIndex = 10;
            this.lblInicio.Text = "-----";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthCalendar1.Location = new System.Drawing.Point(132, 265);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBorrarServicios);
            this.panel1.Controls.Add(this.lblServicios);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.txtServicios);
            this.panel1.Controls.Add(this.lstServicios);
            this.panel1.Location = new System.Drawing.Point(643, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 172);
            this.panel1.TabIndex = 8;
            // 
            // btnBorrarServicios
            // 
            this.btnBorrarServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrarServicios.Location = new System.Drawing.Point(254, 53);
            this.btnBorrarServicios.Name = "btnBorrarServicios";
            this.btnBorrarServicios.Size = new System.Drawing.Size(99, 30);
            this.btnBorrarServicios.TabIndex = 4;
            this.btnBorrarServicios.Text = "Borrar";
            this.btnBorrarServicios.UseVisualStyleBackColor = true;
            this.btnBorrarServicios.Click += new System.EventHandler(this.btnBorrarServicios_Click);
            // 
            // lblServicios
            // 
            this.lblServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblServicios.Location = new System.Drawing.Point(16, 140);
            this.lblServicios.Name = "lblServicios";
            this.lblServicios.Size = new System.Drawing.Size(316, 22);
            this.lblServicios.TabIndex = 3;
            this.lblServicios.Text = "Servicio Seleccionado";
            this.lblServicios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.Location = new System.Drawing.Point(149, 53);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 30);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtServicios
            // 
            this.txtServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServicios.Location = new System.Drawing.Point(149, 15);
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.Size = new System.Drawing.Size(204, 26);
            this.txtServicios.TabIndex = 1;
            this.txtServicios.TextChanged += new System.EventHandler(this.txtServicios_TextChanged);
            this.txtServicios.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServicios_KeyPress);
            // 
            // lstServicios
            // 
            this.lstServicios.FormattingEnabled = true;
            this.lstServicios.ItemHeight = 16;
            this.lstServicios.Location = new System.Drawing.Point(13, 15);
            this.lstServicios.Name = "lstServicios";
            this.lstServicios.Size = new System.Drawing.Size(120, 116);
            this.lstServicios.TabIndex = 0;
            this.lstServicios.SelectedIndexChanged += new System.EventHandler(this.lstServicios_SelectedIndexChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(301, 65);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblMensaje);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdicionar);
            this.splitContainer1.Panel1.Controls.Add(this.txtProducto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnBorrarDUP);
            this.splitContainer1.Panel2.Controls.Add(this.dupProductos);
            this.splitContainer1.Size = new System.Drawing.Size(311, 137);
            this.splitContainer1.SplitterDistance = 89;
            this.splitContainer1.TabIndex = 7;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // lblMensaje
            // 
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(10, 57);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(288, 22);
            this.lblMensaje.TabIndex = 2;
            this.lblMensaje.Text = "Producto Seleccionado";
            this.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.Location = new System.Drawing.Point(199, 16);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(99, 30);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProducto.Location = new System.Drawing.Point(10, 18);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(180, 26);
            this.txtProducto.TabIndex = 0;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            this.txtProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProducto_KeyPress);
            // 
            // btnBorrarDUP
            // 
            this.btnBorrarDUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarDUP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrarDUP.Location = new System.Drawing.Point(198, 6);
            this.btnBorrarDUP.Name = "btnBorrarDUP";
            this.btnBorrarDUP.Size = new System.Drawing.Size(99, 30);
            this.btnBorrarDUP.TabIndex = 2;
            this.btnBorrarDUP.Text = "Borrar";
            this.btnBorrarDUP.UseVisualStyleBackColor = true;
            this.btnBorrarDUP.Click += new System.EventHandler(this.btnBorrarDUP_Click);
            // 
            // dupProductos
            // 
            this.dupProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dupProductos.Location = new System.Drawing.Point(10, 9);
            this.dupProductos.Name = "dupProductos";
            this.dupProductos.Size = new System.Drawing.Size(128, 26);
            this.dupProductos.TabIndex = 0;
            this.dupProductos.Text = "Productos";
            this.dupProductos.SelectedItemChanged += new System.EventHandler(this.dupProductos_SelectedItemChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(7, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "X: ";
            // 
            // tstOperaciones
            // 
            this.tstOperaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstbSuma,
            this.tstbResta,
            this.tstbMultiplicacion,
            this.tstbDivision});
            this.tstOperaciones.Location = new System.Drawing.Point(3, 29);
            this.tstOperaciones.Name = "tstOperaciones";
            this.tstOperaciones.Size = new System.Drawing.Size(1026, 33);
            this.tstOperaciones.TabIndex = 4;
            this.tstOperaciones.Text = "toolStrip1";
            // 
            // tstbSuma
            // 
            this.tstbSuma.AutoSize = false;
            this.tstbSuma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbSuma.Image = ((System.Drawing.Image)(resources.GetObject("tstbSuma.Image")));
            this.tstbSuma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbSuma.Name = "tstbSuma";
            this.tstbSuma.Size = new System.Drawing.Size(30, 30);
            this.tstbSuma.Text = "Suma";
            this.tstbSuma.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // tstbResta
            // 
            this.tstbResta.AutoSize = false;
            this.tstbResta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbResta.Image = ((System.Drawing.Image)(resources.GetObject("tstbResta.Image")));
            this.tstbResta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbResta.Name = "tstbResta";
            this.tstbResta.Size = new System.Drawing.Size(30, 30);
            this.tstbResta.Text = "Resta";
            this.tstbResta.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // tstbMultiplicacion
            // 
            this.tstbMultiplicacion.AutoSize = false;
            this.tstbMultiplicacion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbMultiplicacion.Image = ((System.Drawing.Image)(resources.GetObject("tstbMultiplicacion.Image")));
            this.tstbMultiplicacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbMultiplicacion.Name = "tstbMultiplicacion";
            this.tstbMultiplicacion.Size = new System.Drawing.Size(30, 30);
            this.tstbMultiplicacion.Text = "Multiplicar";
            this.tstbMultiplicacion.Click += new System.EventHandler(this.multiplicarToolStripMenuItem_Click);
            // 
            // tstbDivision
            // 
            this.tstbDivision.AutoSize = false;
            this.tstbDivision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstbDivision.Image = ((System.Drawing.Image)(resources.GetObject("tstbDivision.Image")));
            this.tstbDivision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstbDivision.Name = "tstbDivision";
            this.tstbDivision.Size = new System.Drawing.Size(30, 30);
            this.tstbDivision.Text = "Division";
            this.tstbDivision.Click += new System.EventHandler(this.dividirToolStripMenuItem_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultado.Location = new System.Drawing.Point(165, 134);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(94, 24);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Resultado";
            // 
            // txtB
            // 
            this.txtB.ContextMenuStrip = this.cmnuTxt;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtB.Location = new System.Drawing.Point(39, 157);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(120, 26);
            this.txtB.TabIndex = 2;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtB_KeyPress);
            // 
            // cmnuTxt
            // 
            this.cmnuTxt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarToolStripMenuItem,
            this.aleatorioToolStripMenuItem});
            this.cmnuTxt.Name = "cmnuTxt";
            this.cmnuTxt.Size = new System.Drawing.Size(123, 48);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.borrarToolStripMenuItem.Text = "Borrar";
            this.borrarToolStripMenuItem.Click += new System.EventHandler(this.borrarToolStripMenuItem_Click);
            // 
            // aleatorioToolStripMenuItem
            // 
            this.aleatorioToolStripMenuItem.Name = "aleatorioToolStripMenuItem";
            this.aleatorioToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aleatorioToolStripMenuItem.Text = "Aleatorio";
            this.aleatorioToolStripMenuItem.Click += new System.EventHandler(this.aleatorioToolStripMenuItem_Click);
            // 
            // txtA
            // 
            this.txtA.ContextMenuStrip = this.cmnuTxt;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtA.Location = new System.Drawing.Point(39, 110);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(120, 26);
            this.txtA.TabIndex = 1;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.operacionesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.cambiarFuentesToolStripMenuItem,
            this.cambiarColorDeLasFuentesToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // cambiarFuentesToolStripMenuItem
            // 
            this.cambiarFuentesToolStripMenuItem.Name = "cambiarFuentesToolStripMenuItem";
            this.cambiarFuentesToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.cambiarFuentesToolStripMenuItem.Text = "Cambiar Fuentes";
            this.cambiarFuentesToolStripMenuItem.Click += new System.EventHandler(this.cambiarFuentesToolStripMenuItem_Click);
            // 
            // cambiarColorDeLasFuentesToolStripMenuItem
            // 
            this.cambiarColorDeLasFuentesToolStripMenuItem.Name = "cambiarColorDeLasFuentesToolStripMenuItem";
            this.cambiarColorDeLasFuentesToolStripMenuItem.Size = new System.Drawing.Size(301, 22);
            this.cambiarColorDeLasFuentesToolStripMenuItem.Text = "Cambiar Color de las Fuentes";
            this.cambiarColorDeLasFuentesToolStripMenuItem.Click += new System.EventHandler(this.cambiarColorDeLasFuentesToolStripMenuItem_Click);
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicarToolStripMenuItem,
            this.dividirToolStripMenuItem,
            this.toolStripSeparator1,
            this.habilitarToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.restaToolStripMenuItem.Text = "Resta";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // multiplicarToolStripMenuItem
            // 
            this.multiplicarToolStripMenuItem.Name = "multiplicarToolStripMenuItem";
            this.multiplicarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.multiplicarToolStripMenuItem.Text = "Multiplicar";
            this.multiplicarToolStripMenuItem.Click += new System.EventHandler(this.multiplicarToolStripMenuItem_Click);
            // 
            // dividirToolStripMenuItem
            // 
            this.dividirToolStripMenuItem.Name = "dividirToolStripMenuItem";
            this.dividirToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.dividirToolStripMenuItem.Text = "Dividir";
            this.dividirToolStripMenuItem.Click += new System.EventHandler(this.dividirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Checked = true;
            this.habilitarToolStripMenuItem.CheckOnClick = true;
            this.habilitarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.habilitarToolStripMenuItem.Text = "Habilitar";
            this.habilitarToolStripMenuItem.Click += new System.EventHandler(this.habilitarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de....";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtElemento);
            this.tabPage2.Controls.Add(this.txtNodo);
            this.tabPage2.Controls.Add(this.btnLimpiarArbol);
            this.tabPage2.Controls.Add(this.btnAdicionarNodo);
            this.tabPage2.Controls.Add(this.btnAdicionarElemento);
            this.tabPage2.Controls.Add(this.btnEliminarNodo);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Controls.Add(this.lblSaveDialog);
            this.tabPage2.Controls.Add(this.btnSaveDialog);
            this.tabPage2.Controls.Add(this.lblOpenDialog);
            this.tabPage2.Controls.Add(this.btnOpenDialog);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.lstvEmpleados);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 604);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pagina #2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel6.Location = new System.Drawing.Point(429, 398);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(305, 1);
            this.panel6.TabIndex = 43;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel5.Location = new System.Drawing.Point(734, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 700);
            this.panel5.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(739, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Elemento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(769, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nodo:";
            // 
            // txtElemento
            // 
            this.txtElemento.ContextMenuStrip = this.cmnuTxt;
            this.txtElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtElemento.Location = new System.Drawing.Point(837, 440);
            this.txtElemento.Name = "txtElemento";
            this.txtElemento.Size = new System.Drawing.Size(187, 26);
            this.txtElemento.TabIndex = 13;
            this.txtElemento.TextChanged += new System.EventHandler(this.txtElemento_TextChanged);
            // 
            // txtNodo
            // 
            this.txtNodo.ContextMenuStrip = this.cmnuTxt;
            this.txtNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNodo.Location = new System.Drawing.Point(837, 400);
            this.txtNodo.Name = "txtNodo";
            this.txtNodo.Size = new System.Drawing.Size(187, 26);
            this.txtNodo.TabIndex = 12;
            this.txtNodo.TextChanged += new System.EventHandler(this.txtNodo_TextChanged);
            // 
            // btnLimpiarArbol
            // 
            this.btnLimpiarArbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarArbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLimpiarArbol.Location = new System.Drawing.Point(741, 555);
            this.btnLimpiarArbol.Name = "btnLimpiarArbol";
            this.btnLimpiarArbol.Size = new System.Drawing.Size(141, 30);
            this.btnLimpiarArbol.TabIndex = 9;
            this.btnLimpiarArbol.Text = "Limpiar Arbol";
            this.btnLimpiarArbol.UseVisualStyleBackColor = true;
            this.btnLimpiarArbol.Click += new System.EventHandler(this.btnLimpiarArbol_Click);
            // 
            // btnAdicionarNodo
            // 
            this.btnAdicionarNodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarNodo.Location = new System.Drawing.Point(741, 490);
            this.btnAdicionarNodo.Name = "btnAdicionarNodo";
            this.btnAdicionarNodo.Size = new System.Drawing.Size(141, 30);
            this.btnAdicionarNodo.TabIndex = 10;
            this.btnAdicionarNodo.Text = "Adicionar Nodo";
            this.btnAdicionarNodo.UseVisualStyleBackColor = true;
            this.btnAdicionarNodo.Click += new System.EventHandler(this.btnAdicionarNodo_Click);
            // 
            // btnAdicionarElemento
            // 
            this.btnAdicionarElemento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarElemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarElemento.Location = new System.Drawing.Point(888, 478);
            this.btnAdicionarElemento.Name = "btnAdicionarElemento";
            this.btnAdicionarElemento.Size = new System.Drawing.Size(136, 55);
            this.btnAdicionarElemento.TabIndex = 8;
            this.btnAdicionarElemento.Text = "Adicionar Elemento";
            this.btnAdicionarElemento.UseVisualStyleBackColor = true;
            this.btnAdicionarElemento.Click += new System.EventHandler(this.btnAdicionarElemento_Click);
            // 
            // btnEliminarNodo
            // 
            this.btnEliminarNodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarNodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminarNodo.Location = new System.Drawing.Point(888, 547);
            this.btnEliminarNodo.Name = "btnEliminarNodo";
            this.btnEliminarNodo.Size = new System.Drawing.Size(136, 37);
            this.btnEliminarNodo.TabIndex = 11;
            this.btnEliminarNodo.Text = "Eliminar Nodo";
            this.btnEliminarNodo.UseVisualStyleBackColor = true;
            this.btnEliminarNodo.Click += new System.EventHandler(this.btnEliminarNodo_Click);
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView1.ItemHeight = 25;
            this.treeView1.Location = new System.Drawing.Point(741, 19);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo4";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode1.Text = "Producción";
            treeNode2.Name = "Nodo5";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode2.Text = "Distribución";
            treeNode3.ForeColor = System.Drawing.Color.MediumBlue;
            treeNode3.Name = "Nodo0";
            treeNode3.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode3.Text = "Area de Porducción";
            treeNode4.Name = "Nodo16";
            treeNode4.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode4.Text = "Coordinador de Ventas";
            treeNode5.Name = "Nodo17";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode5.Text = "Lider de Ventas";
            treeNode6.Name = "Nodo6";
            treeNode6.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode6.Text = "Ventas";
            treeNode7.Name = "Nodo7";
            treeNode7.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode7.Text = "Publicidad";
            treeNode8.ForeColor = System.Drawing.Color.MediumBlue;
            treeNode8.Name = "Nodo1";
            treeNode8.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode8.Text = "Area de Comerzalización";
            treeNode9.Name = "Nodo8";
            treeNode9.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode9.Text = "Contabilidad";
            treeNode10.Name = "Nodo11";
            treeNode10.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode10.Text = "Logistica";
            treeNode11.Name = "Nodo12";
            treeNode11.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode11.Text = "Coordinador de Bodegas";
            treeNode12.Name = "Nodo13";
            treeNode12.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode12.Text = "Transportadores";
            treeNode13.Name = "Nodo14";
            treeNode13.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode13.Text = "Auxiliar de Bodega";
            treeNode14.Name = "Nodo15";
            treeNode14.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode14.Text = "Auxiliador de Transporte";
            treeNode15.ForeColor = System.Drawing.Color.MediumBlue;
            treeNode15.Name = "Nodo2";
            treeNode15.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode15.Text = "Area de Finanzas";
            treeNode16.Name = "Nodo9";
            treeNode16.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode16.Text = "Coordinador Recursos Humanos";
            treeNode17.Name = "Nodo10";
            treeNode17.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode17.Text = "Asistente Administrativo";
            treeNode18.ForeColor = System.Drawing.Color.MediumBlue;
            treeNode18.Name = "Nodo3";
            treeNode18.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode18.Text = "Recursos Humanos";
            treeNode19.Name = "Nodo19";
            treeNode19.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode19.Text = "Auxiliar de Administración";
            treeNode20.Name = "Nodo20";
            treeNode20.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode20.Text = "Atención al Cliente";
            treeNode21.ForeColor = System.Drawing.Color.MediumBlue;
            treeNode21.Name = "Nodo18";
            treeNode21.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode21.Text = "Administración";
            treeNode22.Name = "Nodo22";
            treeNode22.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode22.Text = "Gerente de Ventas";
            treeNode23.Name = "Nodo23";
            treeNode23.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode23.Text = "Gerente de Calidad";
            treeNode24.Name = "Nodo24";
            treeNode24.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode24.Text = "Gerente de Operaciones";
            treeNode25.ForeColor = System.Drawing.Color.MediumBlue;
            treeNode25.Name = "Nodo21";
            treeNode25.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            treeNode25.Text = "Gerencia";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode8,
            treeNode15,
            treeNode18,
            treeNode21,
            treeNode25});
            this.treeView1.Size = new System.Drawing.Size(283, 357);
            this.treeView1.TabIndex = 7;
            // 
            // lblSaveDialog
            // 
            this.lblSaveDialog.AutoSize = true;
            this.lblSaveDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaveDialog.Location = new System.Drawing.Point(436, 570);
            this.lblSaveDialog.Name = "lblSaveDialog";
            this.lblSaveDialog.Size = new System.Drawing.Size(60, 15);
            this.lblSaveDialog.TabIndex = 6;
            this.lblSaveDialog.Text = "Directorio";
            // 
            // btnSaveDialog
            // 
            this.btnSaveDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveDialog.Location = new System.Drawing.Point(481, 504);
            this.btnSaveDialog.Name = "btnSaveDialog";
            this.btnSaveDialog.Size = new System.Drawing.Size(166, 54);
            this.btnSaveDialog.TabIndex = 5;
            this.btnSaveDialog.Text = "Salvar Directorio de un Archivo";
            this.btnSaveDialog.UseVisualStyleBackColor = true;
            this.btnSaveDialog.Click += new System.EventHandler(this.btnSaveDialog_Click);
            // 
            // lblOpenDialog
            // 
            this.lblOpenDialog.AutoSize = true;
            this.lblOpenDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpenDialog.Location = new System.Drawing.Point(436, 465);
            this.lblOpenDialog.Name = "lblOpenDialog";
            this.lblOpenDialog.Size = new System.Drawing.Size(60, 15);
            this.lblOpenDialog.TabIndex = 4;
            this.lblOpenDialog.Text = "Directorio";
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOpenDialog.Location = new System.Drawing.Point(491, 408);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(166, 54);
            this.btnOpenDialog.TabIndex = 2;
            this.btnOpenDialog.Text = "Abrir Directorio de un Archivo";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEmpleados10);
            this.groupBox1.Controls.Add(this.rbEmpleados9);
            this.groupBox1.Controls.Add(this.rbEmpleados8);
            this.groupBox1.Controls.Add(this.rbEmpleados7);
            this.groupBox1.Controls.Add(this.txtCargo);
            this.groupBox1.Controls.Add(this.btnAgregarCargos);
            this.groupBox1.Controls.Add(this.rbEmpleados6);
            this.groupBox1.Controls.Add(this.rbEmpleados5);
            this.groupBox1.Controls.Add(this.rbEmpleados4);
            this.groupBox1.Controls.Add(this.rbEmpleados3);
            this.groupBox1.Controls.Add(this.rbEmpleados2);
            this.groupBox1.Controls.Add(this.rbEmpleados1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(443, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 365);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cargos";
            // 
            // rbEmpleados10
            // 
            this.rbEmpleados10.AutoSize = true;
            this.rbEmpleados10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEmpleados10.Location = new System.Drawing.Point(12, 246);
            this.rbEmpleados10.Name = "rbEmpleados10";
            this.rbEmpleados10.Size = new System.Drawing.Size(82, 20);
            this.rbEmpleados10.TabIndex = 11;
            this.rbEmpleados10.Text = "Ayudante";
            this.rbEmpleados10.UseVisualStyleBackColor = true;
            // 
            // rbEmpleados9
            // 
            this.rbEmpleados9.AutoSize = true;
            this.rbEmpleados9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEmpleados9.Location = new System.Drawing.Point(12, 220);
            this.rbEmpleados9.Name = "rbEmpleados9";
            this.rbEmpleados9.Size = new System.Drawing.Size(155, 20);
            this.rbEmpleados9.TabIndex = 10;
            this.rbEmpleados9.Text = "Personal de Limpieza";
            this.rbEmpleados9.UseVisualStyleBackColor = true;
            // 
            // rbEmpleados8
            // 
            this.rbEmpleados8.AutoSize = true;
            this.rbEmpleados8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEmpleados8.Location = new System.Drawing.Point(12, 197);
            this.rbEmpleados8.Name = "rbEmpleados8";
            this.rbEmpleados8.Size = new System.Drawing.Size(83, 20);
            this.rbEmpleados8.TabIndex = 9;
            this.rbEmpleados8.Text = "Operador";
            this.rbEmpleados8.UseVisualStyleBackColor = true;
            // 
            // rbEmpleados7
            // 
            this.rbEmpleados7.AutoSize = true;
            this.rbEmpleados7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEmpleados7.Location = new System.Drawing.Point(12, 172);
            this.rbEmpleados7.Name = "rbEmpleados7";
            this.rbEmpleados7.Size = new System.Drawing.Size(80, 20);
            this.rbEmpleados7.TabIndex = 8;
            this.rbEmpleados7.Text = "Asistente";
            this.rbEmpleados7.UseVisualStyleBackColor = true;
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCargo.Location = new System.Drawing.Point(12, 283);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(244, 26);
            this.txtCargo.TabIndex = 7;
            this.txtCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCargo_KeyPress);
            // 
            // btnAgregarCargos
            // 
            this.btnAgregarCargos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCargos.Location = new System.Drawing.Point(86, 315);
            this.btnAgregarCargos.Name = "btnAgregarCargos";
            this.btnAgregarCargos.Size = new System.Drawing.Size(101, 33);
            this.btnAgregarCargos.TabIndex = 6;
            this.btnAgregarCargos.Text = "Agregar";
            this.btnAgregarCargos.UseVisualStyleBackColor = true;
            this.btnAgregarCargos.Click += new System.EventHandler(this.btnAgregarCargos_Click);
            // 
            // rbEmpleados6
            // 
            this.rbEmpleados6.AutoSize = true;
            this.rbEmpleados6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEmpleados6.Location = new System.Drawing.Point(12, 148);
            this.rbEmpleados6.Name = "rbEmpleados6";
            this.rbEmpleados6.Size = new System.Drawing.Size(90, 20);
            this.rbEmpleados6.TabIndex = 5;
            this.rbEmpleados6.Text = "Supervisor";
            this.rbEmpleados6.UseVisualStyleBackColor = true;
            // 
            // rbEmpleados5
            // 
            this.rbEmpleados5.AutoSize = true;
            this.rbEmpleados5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEmpleados5.Location = new System.Drawing.Point(12, 123);
            this.rbEmpleados5.Name = "rbEmpleados5";
            this.rbEmpleados5.Size = new System.Drawing.Size(67, 20);
            this.rbEmpleados5.TabIndex = 4;
            this.rbEmpleados5.Text = "Auditor";
            this.rbEmpleados5.UseVisualStyleBackColor = true;
            // 
            // rbEmpleados4
            // 
            this.rbEmpleados4.AutoSize = true;
            this.rbEmpleados4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEmpleados4.Location = new System.Drawing.Point(12, 98);
            this.rbEmpleados4.Name = "rbEmpleados4";
            this.rbEmpleados4.Size = new System.Drawing.Size(192, 20);
            this.rbEmpleados4.TabIndex = 3;
            this.rbEmpleados4.Text = "Jefe de Recursos Humanos";
            this.rbEmpleados4.UseVisualStyleBackColor = true;
            // 
            // rbEmpleados3
            // 
            this.rbEmpleados3.AutoSize = true;
            this.rbEmpleados3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEmpleados3.Location = new System.Drawing.Point(12, 73);
            this.rbEmpleados3.Name = "rbEmpleados3";
            this.rbEmpleados3.Size = new System.Drawing.Size(108, 20);
            this.rbEmpleados3.TabIndex = 2;
            this.rbEmpleados3.Text = "Administrador";
            this.rbEmpleados3.UseVisualStyleBackColor = true;
            // 
            // rbEmpleados2
            // 
            this.rbEmpleados2.AutoSize = true;
            this.rbEmpleados2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEmpleados2.Location = new System.Drawing.Point(12, 48);
            this.rbEmpleados2.Name = "rbEmpleados2";
            this.rbEmpleados2.Size = new System.Drawing.Size(124, 20);
            this.rbEmpleados2.TabIndex = 1;
            this.rbEmpleados2.Text = "Gerente General";
            this.rbEmpleados2.UseVisualStyleBackColor = true;
            // 
            // rbEmpleados1
            // 
            this.rbEmpleados1.AutoSize = true;
            this.rbEmpleados1.Checked = true;
            this.rbEmpleados1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbEmpleados1.Location = new System.Drawing.Point(12, 23);
            this.rbEmpleados1.Name = "rbEmpleados1";
            this.rbEmpleados1.Size = new System.Drawing.Size(53, 20);
            this.rbEmpleados1.TabIndex = 0;
            this.rbEmpleados1.TabStop = true;
            this.rbEmpleados1.Text = "CEO";
            this.rbEmpleados1.UseVisualStyleBackColor = true;
            // 
            // lstvEmpleados
            // 
            this.lstvEmpleados.Location = new System.Drawing.Point(20, 19);
            this.lstvEmpleados.Name = "lstvEmpleados";
            this.lstvEmpleados.Size = new System.Drawing.Size(409, 570);
            this.lstvEmpleados.TabIndex = 0;
            this.lstvEmpleados.UseCompatibleStateImageBehavior = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.panel8);
            this.tabPage3.Controls.Add(this.panel7);
            this.tabPage3.Controls.Add(this.btnCambioImagen);
            this.tabPage3.Controls.Add(this.lblFoto);
            this.tabPage3.Controls.Add(this.lblRuta);
            this.tabPage3.Controls.Add(this.btnCargar);
            this.tabPage3.Controls.Add(this.btnTocar);
            this.tabPage3.Controls.Add(this.btnSistema);
            this.tabPage3.Controls.Add(this.btnTono);
            this.tabPage3.Controls.Add(this.btnBeep);
            this.tabPage3.Controls.Add(this.txtDura);
            this.tabPage3.Controls.Add(this.txtFreq);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnCerrarNotepad);
            this.tabPage3.Controls.Add(this.btnAbrirNotepad);
            this.tabPage3.Controls.Add(this.lblEstado);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1034, 604);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pagina #3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel8.Location = new System.Drawing.Point(776, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 725);
            this.panel8.TabIndex = 44;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel7.Location = new System.Drawing.Point(291, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1, 625);
            this.panel7.TabIndex = 43;
            // 
            // btnCambioImagen
            // 
            this.btnCambioImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambioImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCambioImagen.Location = new System.Drawing.Point(831, 192);
            this.btnCambioImagen.Name = "btnCambioImagen";
            this.btnCambioImagen.Size = new System.Drawing.Size(151, 30);
            this.btnCambioImagen.TabIndex = 30;
            this.btnCambioImagen.Text = "Cambiar Imagen";
            this.btnCambioImagen.UseVisualStyleBackColor = true;
            this.btnCambioImagen.Click += new System.EventHandler(this.btnCambioImagen_Click);
            // 
            // lblFoto
            // 
            this.lblFoto.ImageIndex = 0;
            this.lblFoto.ImageList = this.imglFotos;
            this.lblFoto.Location = new System.Drawing.Point(855, 66);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(100, 100);
            this.lblFoto.TabIndex = 29;
            // 
            // imglFotos
            // 
            this.imglFotos.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imglFotos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglFotos.ImageStream")));
            this.imglFotos.TransparentColor = System.Drawing.Color.Transparent;
            this.imglFotos.Images.SetKeyName(0, "57fed751f3b2e.jpeg");
            this.imglFotos.Images.SetKeyName(1, "465446_1234418.jpg");
            this.imglFotos.Images.SetKeyName(2, "1414507335_175641_1414507465_noticia_normal.jpg");
            this.imglFotos.Images.SetKeyName(3, "Dell2-640x360.jpg");
            this.imglFotos.Images.SetKeyName(4, "images (1).jpeg");
            this.imglFotos.Images.SetKeyName(5, "images.jpeg");
            this.imglFotos.Images.SetKeyName(6, "pexels-pixabay-269077.jpg");
            this.imglFotos.Images.SetKeyName(7, "shutterstock_552493561.jpg");
            this.imglFotos.Images.SetKeyName(8, "Steel-Logo-Mockup-3D-Sign-Building-Graphics-9992076-1.jpg");
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRuta.Location = new System.Drawing.Point(356, 233);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(39, 20);
            this.lblRuta.TabIndex = 28;
            this.lblRuta.Text = "------";
            // 
            // btnCargar
            // 
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCargar.Location = new System.Drawing.Point(356, 192);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(105, 30);
            this.btnCargar.TabIndex = 27;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnTocar
            // 
            this.btnTocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTocar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTocar.Location = new System.Drawing.Point(625, 200);
            this.btnTocar.Name = "btnTocar";
            this.btnTocar.Size = new System.Drawing.Size(105, 30);
            this.btnTocar.TabIndex = 26;
            this.btnTocar.Text = "Tocar";
            this.btnTocar.UseVisualStyleBackColor = true;
            this.btnTocar.Click += new System.EventHandler(this.btnTocar_Click);
            // 
            // btnSistema
            // 
            this.btnSistema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSistema.Location = new System.Drawing.Point(625, 138);
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Size = new System.Drawing.Size(105, 30);
            this.btnSistema.TabIndex = 25;
            this.btnSistema.Text = "Sistema";
            this.btnSistema.UseVisualStyleBackColor = true;
            this.btnSistema.Click += new System.EventHandler(this.btnSistema_Click);
            // 
            // btnTono
            // 
            this.btnTono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTono.Location = new System.Drawing.Point(625, 101);
            this.btnTono.Name = "btnTono";
            this.btnTono.Size = new System.Drawing.Size(105, 30);
            this.btnTono.TabIndex = 24;
            this.btnTono.Text = "Tono";
            this.btnTono.UseVisualStyleBackColor = true;
            this.btnTono.Click += new System.EventHandler(this.btnTono_Click);
            // 
            // btnBeep
            // 
            this.btnBeep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBeep.Location = new System.Drawing.Point(625, 64);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(105, 30);
            this.btnBeep.TabIndex = 23;
            this.btnBeep.Text = "Beep";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // txtDura
            // 
            this.txtDura.ContextMenuStrip = this.cmnuTxt;
            this.txtDura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDura.Location = new System.Drawing.Point(420, 127);
            this.txtDura.Name = "txtDura";
            this.txtDura.Size = new System.Drawing.Size(148, 26);
            this.txtDura.TabIndex = 22;
            this.txtDura.Text = "200";
            // 
            // txtFreq
            // 
            this.txtFreq.ContextMenuStrip = this.cmnuTxt;
            this.txtFreq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFreq.Location = new System.Drawing.Point(420, 88);
            this.txtFreq.Name = "txtFreq";
            this.txtFreq.Size = new System.Drawing.Size(148, 26);
            this.txtFreq.TabIndex = 21;
            this.txtFreq.Text = "3000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(325, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Frequencia:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(341, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Duración:";
            // 
            // btnCerrarNotepad
            // 
            this.btnCerrarNotepad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCerrarNotepad.Location = new System.Drawing.Point(123, 147);
            this.btnCerrarNotepad.Name = "btnCerrarNotepad";
            this.btnCerrarNotepad.Size = new System.Drawing.Size(145, 30);
            this.btnCerrarNotepad.TabIndex = 18;
            this.btnCerrarNotepad.Text = "Cerrar Notepad";
            this.btnCerrarNotepad.UseVisualStyleBackColor = true;
            this.btnCerrarNotepad.Click += new System.EventHandler(this.btnCerrarNotepad_Click);
            // 
            // btnAbrirNotepad
            // 
            this.btnAbrirNotepad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirNotepad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirNotepad.Location = new System.Drawing.Point(123, 101);
            this.btnAbrirNotepad.Name = "btnAbrirNotepad";
            this.btnAbrirNotepad.Size = new System.Drawing.Size(145, 30);
            this.btnAbrirNotepad.TabIndex = 17;
            this.btnAbrirNotepad.Text = "Abrir Notepad";
            this.btnAbrirNotepad.UseVisualStyleBackColor = true;
            this.btnAbrirNotepad.Click += new System.EventHandler(this.btnAbrirNotepad_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstado.Location = new System.Drawing.Point(17, 133);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(80, 18);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Esperando";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // prcNotedPad
            // 
            this.prcNotedPad.StartInfo.Domain = "";
            this.prcNotedPad.StartInfo.FileName = "notepad.exe";
            this.prcNotedPad.StartInfo.LoadUserProfile = false;
            this.prcNotedPad.StartInfo.Password = null;
            this.prcNotedPad.StartInfo.StandardErrorEncoding = null;
            this.prcNotedPad.StartInfo.StandardInputEncoding = null;
            this.prcNotedPad.StartInfo.StandardOutputEncoding = null;
            this.prcNotedPad.StartInfo.UserName = "";
            this.prcNotedPad.StartInfo.WorkingDirectory = "C:\\Windows\\System32";
            this.prcNotedPad.SynchronizingObject = this;
            this.prcNotedPad.Exited += new System.EventHandler(this.prcNotedPad_Exited);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem,
            this.esconderToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 48);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // esconderToolStripMenuItem
            // 
            this.esconderToolStripMenuItem.Name = "esconderToolStripMenuItem";
            this.esconderToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.esconderToolStripMenuItem.Text = "Esconder";
            this.esconderToolStripMenuItem.Click += new System.EventHandler(this.esconderToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Abre Aplicaciones";
            this.notifyIcon1.Visible = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "Wav|*.wav";
            // 
            // frmOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1048, 549);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmOpciones";
            this.Text = "Opciones";
            this.Load += new System.EventHandler(this.frmOpciones_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tstOperaciones.ResumeLayout(false);
            this.tstOperaciones.PerformLayout();
            this.cmnuTxt.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lblResultado;
        private TextBox txtB;
        private TextBox txtA;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem operacionesToolStripMenuItem;
        private ToolStripMenuItem sumaToolStripMenuItem;
        private ToolStripMenuItem restaToolStripMenuItem;
        private ToolStripMenuItem multiplicarToolStripMenuItem;
        private ToolStripMenuItem dividirToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private TabPage tabPage3;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem habilitarToolStripMenuItem;
        private ContextMenuStrip cmnuTxt;
        private ToolStripMenuItem borrarToolStripMenuItem;
        private ToolStripMenuItem aleatorioToolStripMenuItem;
        private ToolStrip tstOperaciones;
        private ToolStripButton tstbSuma;
        private ToolStripButton tstbResta;
        private ToolStripButton tstbMultiplicacion;
        private ToolStripButton tstbDivision;
        private Label label2;
        private Label label1;
        private SplitContainer splitContainer1;
        private DomainUpDown dupProductos;
        private Button btnAdicionar;
        private TextBox txtProducto;
        private Label lblMensaje;
        private Button btnBorrarDUP;
        private Panel panel1;
        private Button btnAgregar;
        private TextBox txtServicios;
        private ListBox lstServicios;
        private Label lblServicios;
        private Button btnBorrarServicios;
        private ListView lstvEmpleados;
        private GroupBox groupBox1;
        private RadioButton rbEmpleados6;
        private RadioButton rbEmpleados5;
        private RadioButton rbEmpleados4;
        private RadioButton rbEmpleados3;
        private RadioButton rbEmpleados2;
        private RadioButton rbEmpleados1;
        private Button btnAgregarCargos;
        private TextBox txtCargo;
        private RadioButton rbEmpleados8;
        private RadioButton rbEmpleados7;
        private RadioButton rbEmpleados10;
        private RadioButton rbEmpleados9;
        private ToolStripMenuItem cambiarFuentesToolStripMenuItem;
        private ToolStripMenuItem cambiarColorDeLasFuentesToolStripMenuItem;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private MonthCalendar monthCalendar1;
        private Button btnFecha;
        private Label lblFinal;
        private Label lblInicio;
        private Label label3;
        private Label label4;
        private Label lblRango;
        private Label lblOpenDialog;
        private Button btnOpenDialog;
        private OpenFileDialog openFileDialog1;
        private Label lblSaveDialog;
        private Button btnSaveDialog;
        private SaveFileDialog saveFileDialog1;
        private TreeView treeView1;
        private TextBox txtNodo;
        private Button btnLimpiarArbol;
        private Button btnAdicionarNodo;
        private Button btnAdicionarElemento;
        private Button btnEliminarNodo;
        private TextBox txtElemento;
        private Label label6;
        private Label label5;
        private Button btnCerrarNotepad;
        private Button btnAbrirNotepad;
        private Label lblEstado;
        private System.Diagnostics.Process prcNotedPad;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mostrarToolStripMenuItem;
        private ToolStripMenuItem esconderToolStripMenuItem;
        private NotifyIcon notifyIcon1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label lblRuta;
        private Button btnCargar;
        private Button btnTocar;
        private Button btnSistema;
        private Button btnTono;
        private Button btnBeep;
        private TextBox txtDura;
        private TextBox txtFreq;
        private Label label8;
        private Label label7;
        private OpenFileDialog openFileDialog2;
        private Button btnCambioImagen;
        private Label lblFoto;
        private ImageList imglFotos;
        private Panel panel7;
        private Panel panel8;
    }
}