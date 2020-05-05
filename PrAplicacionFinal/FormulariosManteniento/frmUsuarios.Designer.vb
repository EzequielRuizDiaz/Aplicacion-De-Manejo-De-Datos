<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuarios
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
        Dim IdUsuarioLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim NombreDeUsuarioLabel As System.Windows.Forms.Label
        Dim ContraseñaLabel As System.Windows.Forms.Label
        Dim TipoDeAccsesoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbxOperaciones = New System.Windows.Forms.GroupBox()
        Me.btnAplicar = New System.Windows.Forms.Button()
        Me.rbtModificar = New System.Windows.Forms.RadioButton()
        Me.rbtEliminar = New System.Windows.Forms.RadioButton()
        Me.rbtAgregar = New System.Windows.Forms.RadioButton()
        Me.rbtListado = New System.Windows.Forms.RadioButton()
        Me.btnOperacion = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.gbxDatosUsuario = New System.Windows.Forms.GroupBox()
        Me.cboTAcceso = New System.Windows.Forms.ComboBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GFacHojillaData = New PrAplicacionFinal.GFacHojillaData()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombUsuario = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnMuestraOculta = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblTexto = New System.Windows.Forms.Label()
        Me.txtTotalUsuarios = New System.Windows.Forms.TextBox()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.UsuariosTableAdapter = New PrAplicacionFinal.GFacHojillaDataTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New PrAplicacionFinal.GFacHojillaDataTableAdapters.TableAdapterManager()
        IdUsuarioLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        NombreDeUsuarioLabel = New System.Windows.Forms.Label()
        ContraseñaLabel = New System.Windows.Forms.Label()
        TipoDeAccsesoLabel = New System.Windows.Forms.Label()
        Me.gbxOperaciones.SuspendLayout()
        Me.gbxDatosUsuario.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdUsuarioLabel
        '
        IdUsuarioLabel.AutoSize = True
        IdUsuarioLabel.Location = New System.Drawing.Point(516, 46)
        IdUsuarioLabel.Name = "IdUsuarioLabel"
        IdUsuarioLabel.Size = New System.Drawing.Size(58, 13)
        IdUsuarioLabel.TabIndex = 3
        IdUsuarioLabel.Text = "Id Usuario:"
        IdUsuarioLabel.Visible = False
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        NombreLabel.Location = New System.Drawing.Point(71, 70)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(55, 15)
        NombreLabel.TabIndex = 5
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ApellidoLabel.Location = New System.Drawing.Point(71, 96)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(54, 15)
        ApellidoLabel.TabIndex = 7
        ApellidoLabel.Text = "Apellido:"
        '
        'NombreDeUsuarioLabel
        '
        NombreDeUsuarioLabel.AutoSize = True
        NombreDeUsuarioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreDeUsuarioLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        NombreDeUsuarioLabel.Location = New System.Drawing.Point(6, 16)
        NombreDeUsuarioLabel.Name = "NombreDeUsuarioLabel"
        NombreDeUsuarioLabel.Size = New System.Drawing.Size(120, 15)
        NombreDeUsuarioLabel.TabIndex = 9
        NombreDeUsuarioLabel.Text = "Nombre De Usuario:"
        '
        'ContraseñaLabel
        '
        ContraseñaLabel.AutoSize = True
        ContraseñaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ContraseñaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ContraseñaLabel.Location = New System.Drawing.Point(53, 43)
        ContraseñaLabel.Name = "ContraseñaLabel"
        ContraseñaLabel.Size = New System.Drawing.Size(73, 15)
        ContraseñaLabel.TabIndex = 11
        ContraseñaLabel.Text = "Contraseña:"
        '
        'TipoDeAccsesoLabel
        '
        TipoDeAccsesoLabel.AutoSize = True
        TipoDeAccsesoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoDeAccsesoLabel.ForeColor = System.Drawing.Color.White
        TipoDeAccsesoLabel.Location = New System.Drawing.Point(321, 18)
        TipoDeAccsesoLabel.Name = "TipoDeAccsesoLabel"
        TipoDeAccsesoLabel.Size = New System.Drawing.Size(122, 18)
        TipoDeAccsesoLabel.TabIndex = 13
        TipoDeAccsesoLabel.Text = "Tipo De Accseso"
        '
        'gbxOperaciones
        '
        Me.gbxOperaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.gbxOperaciones.Controls.Add(Me.btnAplicar)
        Me.gbxOperaciones.Controls.Add(Me.rbtModificar)
        Me.gbxOperaciones.Controls.Add(Me.rbtEliminar)
        Me.gbxOperaciones.Controls.Add(Me.rbtAgregar)
        Me.gbxOperaciones.Controls.Add(Me.rbtListado)
        Me.gbxOperaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxOperaciones.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbxOperaciones.Location = New System.Drawing.Point(40, 12)
        Me.gbxOperaciones.Name = "gbxOperaciones"
        Me.gbxOperaciones.Size = New System.Drawing.Size(483, 106)
        Me.gbxOperaciones.TabIndex = 0
        Me.gbxOperaciones.TabStop = False
        Me.gbxOperaciones.Text = "Eliga una opcion:"
        '
        'btnAplicar
        '
        Me.btnAplicar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnAplicar.FlatAppearance.BorderSize = 0
        Me.btnAplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAplicar.Location = New System.Drawing.Point(196, 41)
        Me.btnAplicar.Name = "btnAplicar"
        Me.btnAplicar.Size = New System.Drawing.Size(88, 41)
        Me.btnAplicar.TabIndex = 1
        Me.btnAplicar.Text = "Aplicar"
        Me.btnAplicar.UseVisualStyleBackColor = False
        '
        'rbtModificar
        '
        Me.rbtModificar.AutoSize = True
        Me.rbtModificar.Location = New System.Drawing.Point(303, 19)
        Me.rbtModificar.Name = "rbtModificar"
        Me.rbtModificar.Size = New System.Drawing.Size(174, 19)
        Me.rbtModificar.TabIndex = 0
        Me.rbtModificar.TabStop = True
        Me.rbtModificar.Text = "Modificar Datos de Usuario"
        Me.rbtModificar.UseVisualStyleBackColor = True
        '
        'rbtEliminar
        '
        Me.rbtEliminar.AutoSize = True
        Me.rbtEliminar.Location = New System.Drawing.Point(303, 63)
        Me.rbtEliminar.Name = "rbtEliminar"
        Me.rbtEliminar.Size = New System.Drawing.Size(134, 19)
        Me.rbtEliminar.TabIndex = 0
        Me.rbtEliminar.TabStop = True
        Me.rbtEliminar.Text = "Eliminar un Usuario"
        Me.rbtEliminar.UseVisualStyleBackColor = True
        '
        'rbtAgregar
        '
        Me.rbtAgregar.AutoSize = True
        Me.rbtAgregar.Location = New System.Drawing.Point(21, 63)
        Me.rbtAgregar.Name = "rbtAgregar"
        Me.rbtAgregar.Size = New System.Drawing.Size(152, 19)
        Me.rbtAgregar.TabIndex = 0
        Me.rbtAgregar.TabStop = True
        Me.rbtAgregar.Text = "Agregar Nuevo Usuario"
        Me.rbtAgregar.UseVisualStyleBackColor = True
        '
        'rbtListado
        '
        Me.rbtListado.AutoSize = True
        Me.rbtListado.Location = New System.Drawing.Point(21, 19)
        Me.rbtListado.Name = "rbtListado"
        Me.rbtListado.Size = New System.Drawing.Size(165, 19)
        Me.rbtListado.TabIndex = 0
        Me.rbtListado.TabStop = True
        Me.rbtListado.Text = "Mostrar Lista de Usuarios"
        Me.rbtListado.UseVisualStyleBackColor = True
        '
        'btnOperacion
        '
        Me.btnOperacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnOperacion.FlatAppearance.BorderSize = 0
        Me.btnOperacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOperacion.Location = New System.Drawing.Point(40, 448)
        Me.btnOperacion.Name = "btnOperacion"
        Me.btnOperacion.Size = New System.Drawing.Size(75, 47)
        Me.btnOperacion.TabIndex = 1
        Me.btnOperacion.Text = "Otra Operación"
        Me.btnOperacion.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(246, 96)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 35)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Agregar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEliminar.Location = New System.Drawing.Point(408, 96)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 35)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnActualizar.Location = New System.Drawing.Point(327, 96)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 35)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnTerminar
        '
        Me.btnTerminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnTerminar.FlatAppearance.BorderSize = 0
        Me.btnTerminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnTerminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTerminar.Location = New System.Drawing.Point(460, 448)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(75, 47)
        Me.btnTerminar.TabIndex = 1
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.UseVisualStyleBackColor = False
        '
        'gbxDatosUsuario
        '
        Me.gbxDatosUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.gbxDatosUsuario.Controls.Add(Me.cboTAcceso)
        Me.gbxDatosUsuario.Controls.Add(NombreLabel)
        Me.gbxDatosUsuario.Controls.Add(Me.txtNombres)
        Me.gbxDatosUsuario.Controls.Add(ApellidoLabel)
        Me.gbxDatosUsuario.Controls.Add(Me.txtApellidos)
        Me.gbxDatosUsuario.Controls.Add(NombreDeUsuarioLabel)
        Me.gbxDatosUsuario.Controls.Add(Me.txtNombUsuario)
        Me.gbxDatosUsuario.Controls.Add(ContraseñaLabel)
        Me.gbxDatosUsuario.Controls.Add(Me.txtPassword)
        Me.gbxDatosUsuario.Controls.Add(Me.btnActualizar)
        Me.gbxDatosUsuario.Controls.Add(Me.btnEliminar)
        Me.gbxDatosUsuario.Controls.Add(TipoDeAccsesoLabel)
        Me.gbxDatosUsuario.Controls.Add(Me.btnGuardar)
        Me.gbxDatosUsuario.Controls.Add(Me.btnMuestraOculta)
        Me.gbxDatosUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbxDatosUsuario.Location = New System.Drawing.Point(40, 300)
        Me.gbxDatosUsuario.Name = "gbxDatosUsuario"
        Me.gbxDatosUsuario.Size = New System.Drawing.Size(495, 142)
        Me.gbxDatosUsuario.TabIndex = 2
        Me.gbxDatosUsuario.TabStop = False
        Me.gbxDatosUsuario.Text = "Ingresar:"
        '
        'cboTAcceso
        '
        Me.cboTAcceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.cboTAcceso.ForeColor = System.Drawing.SystemColors.Info
        Me.cboTAcceso.FormattingEnabled = True
        Me.cboTAcceso.Items.AddRange(New Object() {"Administrador", "Usuario"})
        Me.cboTAcceso.Location = New System.Drawing.Point(333, 45)
        Me.cboTAcceso.Name = "cboTAcceso"
        Me.cboTAcceso.Size = New System.Drawing.Size(93, 21)
        Me.cboTAcceso.TabIndex = 15
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtNombres.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Nombre", True))
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.ForeColor = System.Drawing.SystemColors.Info
        Me.txtNombres.Location = New System.Drawing.Point(135, 69)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(100, 21)
        Me.txtNombres.TabIndex = 6
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.GFacHojillaData
        '
        'GFacHojillaData
        '
        Me.GFacHojillaData.DataSetName = "GFacHojillaData"
        Me.GFacHojillaData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtApellidos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Apellido", True))
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.ForeColor = System.Drawing.SystemColors.Info
        Me.txtApellidos.Location = New System.Drawing.Point(135, 95)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(100, 21)
        Me.txtApellidos.TabIndex = 8
        '
        'txtNombUsuario
        '
        Me.txtNombUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtNombUsuario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "NombreDeUsuario", True))
        Me.txtNombUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombUsuario.ForeColor = System.Drawing.SystemColors.Info
        Me.txtNombUsuario.Location = New System.Drawing.Point(135, 15)
        Me.txtNombUsuario.Name = "txtNombUsuario"
        Me.txtNombUsuario.Size = New System.Drawing.Size(100, 21)
        Me.txtNombUsuario.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "Contraseña", True))
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.Info
        Me.txtPassword.Location = New System.Drawing.Point(135, 42)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(100, 21)
        Me.txtPassword.TabIndex = 12
        '
        'btnMuestraOculta
        '
        Me.btnMuestraOculta.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnMuestraOculta.FlatAppearance.BorderSize = 0
        Me.btnMuestraOculta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnMuestraOculta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMuestraOculta.ForeColor = System.Drawing.Color.White
        Me.btnMuestraOculta.Location = New System.Drawing.Point(241, 43)
        Me.btnMuestraOculta.Name = "btnMuestraOculta"
        Me.btnMuestraOculta.Size = New System.Drawing.Size(52, 23)
        Me.btnMuestraOculta.TabIndex = 1
        Me.btnMuestraOculta.Text = "Mostrar"
        Me.btnMuestraOculta.UseVisualStyleBackColor = False
        '
        'txtID
        '
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsuariosBindingSource, "IdUsuario", True))
        Me.txtID.Location = New System.Drawing.Point(541, 62)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(10, 20)
        Me.txtID.TabIndex = 4
        Me.txtID.Visible = False
        '
        'lblTexto
        '
        Me.lblTexto.AutoSize = True
        Me.lblTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexto.Location = New System.Drawing.Point(201, 466)
        Me.lblTexto.Name = "lblTexto"
        Me.lblTexto.Size = New System.Drawing.Size(123, 16)
        Me.lblTexto.TabIndex = 4
        Me.lblTexto.Text = "Total  De Usuarios:"
        '
        'txtTotalUsuarios
        '
        Me.txtTotalUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtTotalUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalUsuarios.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtTotalUsuarios.Location = New System.Drawing.Point(330, 463)
        Me.txtTotalUsuarios.Name = "txtTotalUsuarios"
        Me.txtTotalUsuarios.Size = New System.Drawing.Size(28, 22)
        Me.txtTotalUsuarios.TabIndex = 5
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.EnableHeadersVisualStyles = False
        Me.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dgvUsuarios.Location = New System.Drawing.Point(88, 124)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.dgvUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Size = New System.Drawing.Size(389, 170)
        Me.dgvUsuarios.TabIndex = 7
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EntregasTableAdapter = Nothing
        Me.TableAdapterManager.MercaderiaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrAplicacionFinal.GFacHojillaDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Me.UsuariosTableAdapter
        Me.TableAdapterManager.VendedorTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(565, 520)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(IdUsuarioLabel)
        Me.Controls.Add(Me.txtTotalUsuarios)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblTexto)
        Me.Controls.Add(Me.gbxDatosUsuario)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.btnOperacion)
        Me.Controls.Add(Me.gbxOperaciones)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MaximizeBox = False
        Me.Name = "frmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUsuarios"
        Me.gbxOperaciones.ResumeLayout(False)
        Me.gbxOperaciones.PerformLayout()
        Me.gbxDatosUsuario.ResumeLayout(False)
        Me.gbxDatosUsuario.PerformLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbxOperaciones As GroupBox
    Friend WithEvents btnAplicar As Button
    Friend WithEvents rbtModificar As RadioButton
    Friend WithEvents rbtEliminar As RadioButton
    Friend WithEvents rbtAgregar As RadioButton
    Friend WithEvents rbtListado As RadioButton
    Friend WithEvents btnOperacion As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnTerminar As Button
    Friend WithEvents gbxDatosUsuario As GroupBox
    Friend WithEvents GFacHojillaData As GFacHojillaData
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As GFacHojillaDataTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As GFacHojillaDataTableAdapters.TableAdapterManager
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombUsuario As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnMuestraOculta As Button
    Friend WithEvents lblTexto As Label
    Friend WithEvents cboTAcceso As ComboBox
    Friend WithEvents txtTotalUsuarios As TextBox
    Friend WithEvents dgvUsuarios As DataGridView
End Class
