<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListVendedores
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
        Dim IdVendedorLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CedulaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GFacHojillaData = New PrAplicacionFinal.GFacHojillaData()
        Me.VendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VendedorTableAdapter = New PrAplicacionFinal.GFacHojillaDataTableAdapters.VendedorTableAdapter()
        Me.TableAdapterManager = New PrAplicacionFinal.GFacHojillaDataTableAdapters.TableAdapterManager()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtIdVendedor = New System.Windows.Forms.TextBox()
        Me.txtNombews = New System.Windows.Forms.TextBox()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.btnMuestrAlt = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rbtNombres = New System.Windows.Forms.RadioButton()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        IdVendedorLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CedulaLabel = New System.Windows.Forms.Label()
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdVendedorLabel
        '
        IdVendedorLabel.AutoSize = True
        IdVendedorLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        IdVendedorLabel.Location = New System.Drawing.Point(569, 60)
        IdVendedorLabel.Name = "IdVendedorLabel"
        IdVendedorLabel.Size = New System.Drawing.Size(76, 15)
        IdVendedorLabel.TabIndex = 2
        IdVendedorLabel.Text = "Id Vendedor:"
        IdVendedorLabel.Visible = False
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        NombreLabel.Location = New System.Drawing.Point(174, 50)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(55, 15)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        ApellidoLabel.Location = New System.Drawing.Point(175, 77)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(54, 15)
        ApellidoLabel.TabIndex = 6
        ApellidoLabel.Text = "Apellido:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DireccionLabel.Location = New System.Drawing.Point(167, 111)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(62, 15)
        DireccionLabel.TabIndex = 8
        DireccionLabel.Text = "Direccion:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        TelefonoLabel.Location = New System.Drawing.Point(359, 76)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(58, 15)
        TelefonoLabel.TabIndex = 10
        TelefonoLabel.Text = "Telefono:"
        '
        'CedulaLabel
        '
        CedulaLabel.AutoSize = True
        CedulaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CedulaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CedulaLabel.Location = New System.Drawing.Point(368, 46)
        CedulaLabel.Name = "CedulaLabel"
        CedulaLabel.Size = New System.Drawing.Size(49, 15)
        CedulaLabel.TabIndex = 12
        CedulaLabel.Text = "Cedula:"
        '
        'GFacHojillaData
        '
        Me.GFacHojillaData.DataSetName = "GFacHojillaData"
        Me.GFacHojillaData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VendedorBindingSource
        '
        Me.VendedorBindingSource.DataMember = "Vendedor"
        Me.VendedorBindingSource.DataSource = Me.GFacHojillaData
        '
        'VendedorTableAdapter
        '
        Me.VendedorTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EntregasTableAdapter = Nothing
        Me.TableAdapterManager.MercaderiaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrAplicacionFinal.GFacHojillaDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Me.VendedorTableAdapter
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(170, 139)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(475, 273)
        Me.DataGridView1.TabIndex = 1
        '
        'txtIdVendedor
        '
        Me.txtIdVendedor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "IdVendedor", True))
        Me.txtIdVendedor.Location = New System.Drawing.Point(651, 60)
        Me.txtIdVendedor.Name = "txtIdVendedor"
        Me.txtIdVendedor.Size = New System.Drawing.Size(11, 21)
        Me.txtIdVendedor.TabIndex = 3
        Me.txtIdVendedor.Visible = False
        '
        'txtNombews
        '
        Me.txtNombews.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtNombews.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "Nombre", True))
        Me.txtNombews.ForeColor = System.Drawing.SystemColors.Menu
        Me.txtNombews.Location = New System.Drawing.Point(235, 50)
        Me.txtNombews.Name = "txtNombews"
        Me.txtNombews.Size = New System.Drawing.Size(116, 21)
        Me.txtNombews.TabIndex = 5
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtApellidos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "Apellido", True))
        Me.txtApellidos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtApellidos.Location = New System.Drawing.Point(235, 77)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(116, 21)
        Me.txtApellidos.TabIndex = 7
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "Direccion", True))
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.Menu
        Me.txtDireccion.Location = New System.Drawing.Point(235, 108)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(116, 21)
        Me.txtDireccion.TabIndex = 9
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "Telefono", True))
        Me.txtTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtTelefono.Location = New System.Drawing.Point(423, 77)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(116, 21)
        Me.txtTelefono.TabIndex = 11
        '
        'txtCedula
        '
        Me.txtCedula.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtCedula.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VendedorBindingSource, "Cedula", True))
        Me.txtCedula.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtCedula.Location = New System.Drawing.Point(423, 50)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(116, 21)
        Me.txtCedula.TabIndex = 13
        '
        'btnMuestrAlt
        '
        Me.btnMuestrAlt.FlatAppearance.BorderSize = 0
        Me.btnMuestrAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnMuestrAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMuestrAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMuestrAlt.Location = New System.Drawing.Point(0, 0)
        Me.btnMuestrAlt.Name = "btnMuestrAlt"
        Me.btnMuestrAlt.Size = New System.Drawing.Size(141, 89)
        Me.btnMuestrAlt.TabIndex = 14
        Me.btnMuestrAlt.Text = "MostrarActualizar"
        Me.btnMuestrAlt.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.Location = New System.Drawing.Point(0, 87)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(141, 85)
        Me.btnAgregar.TabIndex = 15
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Location = New System.Drawing.Point(-2, 178)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(141, 74)
        Me.btnEditar.TabIndex = 16
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(-3, 267)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(139, 90)
        Me.btnBorrar.TabIndex = 17
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(0, 363)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(139, 89)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMuestrAlt)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnBorrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(139, 443)
        Me.Panel1.TabIndex = 19
        '
        'rbtNombres
        '
        Me.rbtNombres.AutoSize = True
        Me.rbtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtNombres.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.rbtNombres.Location = New System.Drawing.Point(360, 107)
        Me.rbtNombres.Name = "rbtNombres"
        Me.rbtNombres.Size = New System.Drawing.Size(161, 22)
        Me.rbtNombres.TabIndex = 20
        Me.rbtNombres.TabStop = True
        Me.rbtNombres.Text = "Buscar por Nombre:"
        Me.rbtNombres.UseVisualStyleBackColor = True
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtNombres.ForeColor = System.Drawing.SystemColors.Menu
        Me.txtNombres.Location = New System.Drawing.Point(527, 111)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(118, 21)
        Me.txtNombres.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 18)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Editar Datos:"
        '
        'frmListVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(675, 443)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.rbtNombres)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(IdVendedorLabel)
        Me.Controls.Add(Me.txtIdVendedor)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.txtNombews)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.txtApellidos)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(CedulaLabel)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MaximizeBox = False
        Me.Name = "frmListVendedores"
        Me.Text = "frmListVendedores"
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GFacHojillaData As GFacHojillaData
    Friend WithEvents VendedorBindingSource As BindingSource
    Friend WithEvents VendedorTableAdapter As GFacHojillaDataTableAdapters.VendedorTableAdapter
    Friend WithEvents TableAdapterManager As GFacHojillaDataTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtIdVendedor As TextBox
    Friend WithEvents txtNombews As TextBox
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents btnMuestrAlt As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbtNombres As RadioButton
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents Label1 As Label
End Class
