<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel1 As System.Windows.Forms.Label
        Dim RutLabel1 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GFacHojillaData = New PrAplicacionFinal.GFacHojillaData()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.rbtCedula = New System.Windows.Forms.RadioButton()
        Me.rbtNombres = New System.Windows.Forms.RadioButton()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.ClientesTableAdapter = New PrAplicacionFinal.GFacHojillaDataTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New PrAplicacionFinal.GFacHojillaDataTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        IdClienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel1 = New System.Windows.Forms.Label()
        RutLabel1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.ForeColor = System.Drawing.SystemColors.Info
        IdClienteLabel.Location = New System.Drawing.Point(169, 14)
        IdClienteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(20, 15)
        IdClienteLabel.TabIndex = 0
        IdClienteLabel.Text = "Id:"
        IdClienteLabel.Visible = False
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.ForeColor = System.Drawing.SystemColors.Info
        NombreLabel.Location = New System.Drawing.Point(12, 25)
        NombreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(55, 15)
        NombreLabel.TabIndex = 2
        NombreLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.ForeColor = System.Drawing.SystemColors.Info
        DireccionLabel.Location = New System.Drawing.Point(211, 25)
        DireccionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(62, 15)
        DireccionLabel.TabIndex = 4
        DireccionLabel.Text = "Direccion:"
        '
        'TelefonoLabel1
        '
        TelefonoLabel1.AutoSize = True
        TelefonoLabel1.ForeColor = System.Drawing.SystemColors.Info
        TelefonoLabel1.Location = New System.Drawing.Point(12, 54)
        TelefonoLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonoLabel1.Name = "TelefonoLabel1"
        TelefonoLabel1.Size = New System.Drawing.Size(58, 15)
        TelefonoLabel1.TabIndex = 9
        TelefonoLabel1.Text = "Telefono:"
        '
        'RutLabel1
        '
        RutLabel1.AutoSize = True
        RutLabel1.ForeColor = System.Drawing.SystemColors.Info
        RutLabel1.Location = New System.Drawing.Point(239, 54)
        RutLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RutLabel1.Name = "RutLabel1"
        RutLabel1.Size = New System.Drawing.Size(29, 15)
        RutLabel1.TabIndex = 0
        RutLabel1.Text = "Rut:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(179, 199)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(409, 245)
        Me.DataGridView1.TabIndex = 2
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.GFacHojillaData
        '
        'GFacHojillaData
        '
        Me.GFacHojillaData.DataSetName = "GFacHojillaData"
        Me.GFacHojillaData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(RutLabel1)
        Me.GroupBox1.Controls.Add(Me.txtRut)
        Me.GroupBox1.Controls.Add(TelefonoLabel1)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(NombreLabel)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Location = New System.Drawing.Point(179, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(409, 86)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Editar Datos:"
        '
        'txtRut
        '
        Me.txtRut.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtRut.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Rut", True))
        Me.txtRut.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtRut.Location = New System.Drawing.Point(276, 51)
        Me.txtRut.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(92, 21)
        Me.txtRut.TabIndex = 1
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Telefono", True))
        Me.txtTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtTelefono.Location = New System.Drawing.Point(69, 51)
        Me.txtTelefono.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(116, 21)
        Me.txtTelefono.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre", True))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtNombre.Location = New System.Drawing.Point(69, 22)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(116, 21)
        Me.txtNombre.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Direccion", True))
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtDireccion.Location = New System.Drawing.Point(276, 22)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(112, 21)
        Me.txtDireccion.TabIndex = 5
        '
        'txtIdCliente
        '
        Me.txtIdCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "IdCliente", True))
        Me.txtIdCliente.Location = New System.Drawing.Point(179, 17)
        Me.txtIdCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(11, 21)
        Me.txtIdCliente.TabIndex = 1
        Me.txtIdCliente.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCedula)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.lblCedula)
        Me.GroupBox2.Controls.Add(Me.lblNombre)
        Me.GroupBox2.Controls.Add(Me.rbtCedula)
        Me.GroupBox2.Controls.Add(Me.rbtNombres)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(179, 101)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(409, 84)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Por:"
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtCedula.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtCedula.Location = New System.Drawing.Point(257, 49)
        Me.txtCedula.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(144, 21)
        Me.txtCedula.TabIndex = 5
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtNombres.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtNombres.Location = New System.Drawing.Point(257, 16)
        Me.txtNombres.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(144, 21)
        Me.txtNombres.TabIndex = 4
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.ForeColor = System.Drawing.SystemColors.Info
        Me.lblCedula.Location = New System.Drawing.Point(137, 49)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(117, 15)
        Me.lblCedula.TabIndex = 3
        Me.lblCedula.Text = "Escriba la direccion:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.Info
        Me.lblNombre.Location = New System.Drawing.Point(137, 19)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(110, 15)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Escriba el nombre:"
        '
        'rbtCedula
        '
        Me.rbtCedula.AutoSize = True
        Me.rbtCedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtCedula.ForeColor = System.Drawing.SystemColors.Info
        Me.rbtCedula.Location = New System.Drawing.Point(30, 47)
        Me.rbtCedula.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtCedula.Name = "rbtCedula"
        Me.rbtCedula.Size = New System.Drawing.Size(107, 20)
        Me.rbtCedula.TabIndex = 1
        Me.rbtCedula.TabStop = True
        Me.rbtCedula.Text = "Por Direccion"
        Me.rbtCedula.UseVisualStyleBackColor = True
        '
        'rbtNombres
        '
        Me.rbtNombres.AutoSize = True
        Me.rbtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNombres.ForeColor = System.Drawing.SystemColors.Info
        Me.rbtNombres.Location = New System.Drawing.Point(30, 19)
        Me.rbtNombres.Margin = New System.Windows.Forms.Padding(4)
        Me.rbtNombres.Name = "rbtNombres"
        Me.rbtNombres.Size = New System.Drawing.Size(99, 20)
        Me.rbtNombres.TabIndex = 0
        Me.rbtNombres.TabStop = True
        Me.rbtNombres.Text = "Por Nombre"
        Me.rbtNombres.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.FlatAppearance.BorderSize = 0
        Me.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMostrar.Location = New System.Drawing.Point(-4, 0)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(154, 86)
        Me.btnMostrar.TabIndex = 4
        Me.btnMostrar.Text = "Mostrar/Actualizar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.Location = New System.Drawing.Point(0, 94)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(150, 91)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Location = New System.Drawing.Point(0, 293)
        Me.btnEditar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(150, 89)
        Me.btnEditar.TabIndex = 6
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Location = New System.Drawing.Point(0, 390)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(146, 89)
        Me.btnSalir.TabIndex = 7
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorrar.Location = New System.Drawing.Point(0, 193)
        Me.btnBorrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(150, 92)
        Me.btnBorrar.TabIndex = 8
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.EntregasTableAdapter = Nothing
        Me.TableAdapterManager.MercaderiaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrAplicacionFinal.GFacHojillaDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMostrar)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnBorrar)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(150, 479)
        Me.Panel1.TabIndex = 9
        '
        'frmListClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(635, 479)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(IdClienteLabel)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmListClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListClientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GFacHojillaData As GFacHojillaData
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As GFacHojillaDataTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As GFacHojillaDataTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents rbtCedula As RadioButton
    Friend WithEvents rbtNombres As RadioButton
    Friend WithEvents Panel1 As Panel
End Class
