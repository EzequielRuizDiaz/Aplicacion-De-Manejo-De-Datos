<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MercaderiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClintesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntregasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadísticasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MercaderíaMásVendidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnMercaderia = New System.Windows.Forms.Button()
        Me.btnEntregas = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnVendedor = New System.Windows.Forms.Button()
        Me.btnVendedores = New System.Windows.Forms.Button()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblReloj = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSistema = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblTAcceso = New System.Windows.Forms.Label()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.btnUsu = New System.Windows.Forms.PictureBox()
        Me.btnVentas = New System.Windows.Forms.PictureBox()
        Me.btnEstadisticas = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuVertical.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraTitulo.SuspendLayout()
        CType(Me.btnUsu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEstadisticas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.GestionDeVentasToolStripMenuItem, Me.EstadísticasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.Checked = True
        Me.MantenimientoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MercaderiaToolStripMenuItem, Me.VendedoresToolStripMenuItem, Me.ClintesToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MantenimientoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'MercaderiaToolStripMenuItem
        '
        Me.MercaderiaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.MercaderiaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MercaderiaToolStripMenuItem.Name = "MercaderiaToolStripMenuItem"
        Me.MercaderiaToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MercaderiaToolStripMenuItem.Text = "Mercaderia"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.VendedoresToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'ClintesToolStripMenuItem
        '
        Me.ClintesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClintesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ClintesToolStripMenuItem.Name = "ClintesToolStripMenuItem"
        Me.ClintesToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ClintesToolStripMenuItem.Text = "Clientes"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.UsuariosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'GestionDeVentasToolStripMenuItem
        '
        Me.GestionDeVentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EntregasToolStripMenuItem, Me.FacturasToolStripMenuItem})
        Me.GestionDeVentasToolStripMenuItem.Name = "GestionDeVentasToolStripMenuItem"
        Me.GestionDeVentasToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.GestionDeVentasToolStripMenuItem.Text = "Gestion De Ventas"
        '
        'EntregasToolStripMenuItem
        '
        Me.EntregasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.EntregasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EntregasToolStripMenuItem.Name = "EntregasToolStripMenuItem"
        Me.EntregasToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.EntregasToolStripMenuItem.Text = "Entregas"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.FacturasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'EstadísticasToolStripMenuItem
        '
        Me.EstadísticasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MercaderíaMásVendidaToolStripMenuItem})
        Me.EstadísticasToolStripMenuItem.Name = "EstadísticasToolStripMenuItem"
        Me.EstadísticasToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EstadísticasToolStripMenuItem.Text = "Estadísticas"
        '
        'MercaderíaMásVendidaToolStripMenuItem
        '
        Me.MercaderíaMásVendidaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.MercaderíaMásVendidaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MercaderíaMásVendidaToolStripMenuItem.Name = "MercaderíaMásVendidaToolStripMenuItem"
        Me.MercaderíaMásVendidaToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.MercaderíaMásVendidaToolStripMenuItem.Text = "Estadistica Exacta"
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.btnSalir)
        Me.MenuVertical.Controls.Add(Me.btnMercaderia)
        Me.MenuVertical.Controls.Add(Me.btnEntregas)
        Me.MenuVertical.Controls.Add(Me.btnUsuarios)
        Me.MenuVertical.Controls.Add(Me.btnCliente)
        Me.MenuVertical.Controls.Add(Me.PictureBox2)
        Me.MenuVertical.Controls.Add(Me.btnVendedor)
        Me.MenuVertical.Controls.Add(Me.btnVendedores)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 52)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(167, 493)
        Me.MenuVertical.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(0, 430)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(167, 64)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnMercaderia
        '
        Me.btnMercaderia.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMercaderia.FlatAppearance.BorderSize = 0
        Me.btnMercaderia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnMercaderia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMercaderia.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMercaderia.ForeColor = System.Drawing.Color.White
        Me.btnMercaderia.Location = New System.Drawing.Point(3, 99)
        Me.btnMercaderia.Name = "btnMercaderia"
        Me.btnMercaderia.Size = New System.Drawing.Size(164, 56)
        Me.btnMercaderia.TabIndex = 1
        Me.btnMercaderia.Text = "Mercaderia"
        Me.btnMercaderia.UseVisualStyleBackColor = False
        '
        'btnEntregas
        '
        Me.btnEntregas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEntregas.FlatAppearance.BorderSize = 0
        Me.btnEntregas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEntregas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntregas.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntregas.ForeColor = System.Drawing.Color.White
        Me.btnEntregas.Location = New System.Drawing.Point(0, 360)
        Me.btnEntregas.Name = "btnEntregas"
        Me.btnEntregas.Size = New System.Drawing.Size(167, 60)
        Me.btnEntregas.TabIndex = 1
        Me.btnEntregas.Text = "Entregas"
        Me.btnEntregas.UseVisualStyleBackColor = False
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Location = New System.Drawing.Point(3, 294)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(164, 60)
        Me.btnUsuarios.TabIndex = 1
        Me.btnUsuarios.Text = "Usuarios"
        Me.btnUsuarios.UseVisualStyleBackColor = False
        '
        'btnCliente
        '
        Me.btnCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCliente.FlatAppearance.BorderSize = 0
        Me.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.ForeColor = System.Drawing.Color.White
        Me.btnCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnCliente.Location = New System.Drawing.Point(0, 228)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(167, 60)
        Me.btnCliente.TabIndex = 1
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PrAplicacionFinal.My.Resources.Resources.kisspng_rolling_paper_ocb_rolling_machine_smoking_arabic_gum_5b11d2e1972c26_3861559015278947536192
        Me.PictureBox2.Location = New System.Drawing.Point(-38, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(249, 111)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'btnVendedor
        '
        Me.btnVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnVendedor.FlatAppearance.BorderSize = 0
        Me.btnVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVendedor.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendedor.ForeColor = System.Drawing.Color.White
        Me.btnVendedor.Location = New System.Drawing.Point(0, 166)
        Me.btnVendedor.Name = "btnVendedor"
        Me.btnVendedor.Size = New System.Drawing.Size(167, 56)
        Me.btnVendedor.TabIndex = 1
        Me.btnVendedor.Text = "Vendedores"
        Me.btnVendedor.UseVisualStyleBackColor = False
        '
        'btnVendedores
        '
        Me.btnVendedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnVendedores.FlatAppearance.BorderSize = 0
        Me.btnVendedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVendedores.ForeColor = System.Drawing.Color.White
        Me.btnVendedores.Location = New System.Drawing.Point(3, 181)
        Me.btnVendedores.Name = "btnVendedores"
        Me.btnVendedores.Size = New System.Drawing.Size(217, 32)
        Me.btnVendedores.TabIndex = 1
        Me.btnVendedores.Text = "Vendedores"
        Me.btnVendedores.UseVisualStyleBackColor = False
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.PanelContenedor.Controls.Add(Me.PictureBox3)
        Me.PanelContenedor.Controls.Add(Me.lblFecha)
        Me.PanelContenedor.Controls.Add(Me.lblReloj)
        Me.PanelContenedor.Controls.Add(Me.Label2)
        Me.PanelContenedor.Controls.Add(Me.Label4)
        Me.PanelContenedor.Controls.Add(Me.Label3)
        Me.PanelContenedor.Controls.Add(Me.Label1)
        Me.PanelContenedor.Controls.Add(Me.lblSistema)
        Me.PanelContenedor.Controls.Add(Me.lblUsuario)
        Me.PanelContenedor.Controls.Add(Me.lblNombre)
        Me.PanelContenedor.Controls.Add(Me.lblTAcceso)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(167, 52)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(633, 493)
        Me.PanelContenedor.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.PrAplicacionFinal.My.Resources.Resources.pngwave__3_
        Me.PictureBox3.Location = New System.Drawing.Point(0, 51)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(633, 324)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblFecha.Location = New System.Drawing.Point(505, 28)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(57, 20)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Label4"
        '
        'lblReloj
        '
        Me.lblReloj.AutoSize = True
        Me.lblReloj.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblReloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReloj.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblReloj.Location = New System.Drawing.Point(432, 27)
        Me.lblReloj.Name = "lblReloj"
        Me.lblReloj.Size = New System.Drawing.Size(57, 20)
        Me.lblReloj.TabIndex = 3
        Me.lblReloj.Text = "Label4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(76, 420)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(458, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Hora y Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(6, 454)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sistema Operativo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(21, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre Del Equipo:"
        '
        'lblSistema
        '
        Me.lblSistema.AutoSize = True
        Me.lblSistema.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblSistema.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSistema.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSistema.Location = New System.Drawing.Point(141, 454)
        Me.lblSistema.Name = "lblSistema"
        Me.lblSistema.Size = New System.Drawing.Size(51, 18)
        Me.lblSistema.TabIndex = 1
        Me.lblSistema.Text = "Label1"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblUsuario.Location = New System.Drawing.Point(141, 420)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(49, 16)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Label1"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblNombre.Location = New System.Drawing.Point(169, 30)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(51, 18)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Label1"
        '
        'lblTAcceso
        '
        Me.lblTAcceso.AutoSize = True
        Me.lblTAcceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblTAcceso.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTAcceso.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTAcceso.Location = New System.Drawing.Point(223, 378)
        Me.lblTAcceso.Name = "lblTAcceso"
        Me.lblTAcceso.Size = New System.Drawing.Size(148, 24)
        Me.lblTAcceso.TabIndex = 0
        Me.lblTAcceso.Text = "Nivel de Acceso"
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.btnUsu)
        Me.BarraTitulo.Controls.Add(Me.btnVentas)
        Me.BarraTitulo.Controls.Add(Me.btnEstadisticas)
        Me.BarraTitulo.Controls.Add(Me.btnCerrar)
        Me.BarraTitulo.Controls.Add(Me.PictureBox1)
        Me.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 24)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(800, 28)
        Me.BarraTitulo.TabIndex = 1
        '
        'btnUsu
        '
        Me.btnUsu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnUsu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUsu.Image = Global.PrAplicacionFinal.My.Resources.Resources.pngkey_com_face_silhouette_png_4483798__2_
        Me.btnUsu.Location = New System.Drawing.Point(37, 2)
        Me.btnUsu.Name = "btnUsu"
        Me.btnUsu.Size = New System.Drawing.Size(33, 24)
        Me.btnUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnUsu.TabIndex = 3
        Me.btnUsu.TabStop = False
        '
        'btnVentas
        '
        Me.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVentas.Image = Global.PrAplicacionFinal.My.Resources.Resources.pngocean_com__4_
        Me.btnVentas.Location = New System.Drawing.Point(141, 2)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(34, 24)
        Me.btnVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnVentas.TabIndex = 2
        Me.btnVentas.TabStop = False
        '
        'btnEstadisticas
        '
        Me.btnEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEstadisticas.Image = Global.PrAplicacionFinal.My.Resources.Resources.kisspng_clip_art_statistics_computer_icons_vector_graphics_chongqing_telecom_svg_png_icon_free_download_287_5c6aa6e434efe71
        Me.btnEstadisticas.Location = New System.Drawing.Point(246, 3)
        Me.btnEstadisticas.Name = "btnEstadisticas"
        Me.btnEstadisticas.Size = New System.Drawing.Size(24, 24)
        Me.btnEstadisticas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEstadisticas.TabIndex = 1
        Me.btnEstadisticas.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = Global.PrAplicacionFinal.My.Resources.Resources.kisspng_computer_icons_close_icon_5b26727d16c9d2_6648898815292463330934
        Me.btnCerrar.Location = New System.Drawing.Point(774, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(23, 23)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.PrAplicacionFinal.My.Resources.Resources.icons8_minimizar_la_ventana_50
        Me.PictureBox1.Location = New System.Drawing.Point(745, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.PictureBox.Cursor = System.Windows.Forms.Cursors.NoMove2D
        Me.PictureBox.Image = Global.PrAplicacionFinal.My.Resources.Resources._1723075
        Me.PictureBox.Location = New System.Drawing.Point(439, 6)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(22, 18)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox.TabIndex = 3
        Me.PictureBox.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 545)
        Me.Controls.Add(Me.PictureBox)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.BarraTitulo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuVertical.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraTitulo.ResumeLayout(False)
        CType(Me.btnUsu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEstadisticas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MercaderiaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClintesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntregasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadísticasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MercaderíaMásVendidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuVertical As Panel
    Friend WithEvents btnMercaderia As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEntregas As Button
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnVendedor As Button
    Friend WithEvents btnVendedores As Button
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents lblTAcceso As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblSistema As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblReloj As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnEstadisticas As PictureBox
    Friend WithEvents btnVentas As PictureBox
    Friend WithEvents btnUsu As PictureBox
End Class
