<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCliente
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
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim RutLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Me.GFacHojillaData = New PrAplicacionFinal.GFacHojillaData()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New PrAplicacionFinal.GFacHojillaDataTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New PrAplicacionFinal.GFacHojillaDataTableAdapters.TableAdapterManager()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtRut = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtIdCliente = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        IdClienteLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        RutLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(12, 165)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(54, 13)
        IdClienteLabel.TabIndex = 1
        IdClienteLabel.Text = "Id Cliente:"
        IdClienteLabel.Visible = False
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        NombreLabel.Location = New System.Drawing.Point(30, 25)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(55, 15)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "Nombre:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        DireccionLabel.Location = New System.Drawing.Point(30, 51)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(62, 15)
        DireccionLabel.TabIndex = 5
        DireccionLabel.Text = "Direccion:"
        '
        'RutLabel
        '
        RutLabel.AutoSize = True
        RutLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        RutLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RutLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        RutLabel.Location = New System.Drawing.Point(30, 77)
        RutLabel.Name = "RutLabel"
        RutLabel.Size = New System.Drawing.Size(29, 15)
        RutLabel.TabIndex = 7
        RutLabel.Text = "Rut:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        TelefonoLabel.Location = New System.Drawing.Point(30, 103)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(58, 15)
        TelefonoLabel.TabIndex = 9
        TelefonoLabel.Text = "Telefono:"
        '
        'GFacHojillaData
        '
        Me.GFacHojillaData.DataSetName = "GFacHojillaData"
        Me.GFacHojillaData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.GFacHojillaData
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
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Nombre", True))
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtNombre.Location = New System.Drawing.Point(91, 22)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 21)
        Me.txtNombre.TabIndex = 4
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtDireccion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Direccion", True))
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtDireccion.Location = New System.Drawing.Point(91, 48)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 21)
        Me.txtDireccion.TabIndex = 6
        '
        'txtRut
        '
        Me.txtRut.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtRut.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Rut", True))
        Me.txtRut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtRut.Location = New System.Drawing.Point(91, 74)
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(100, 21)
        Me.txtRut.TabIndex = 8
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtTelefono.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Telefono", True))
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.txtTelefono.Location = New System.Drawing.Point(91, 100)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 21)
        Me.txtTelefono.TabIndex = 10
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Location = New System.Drawing.Point(42, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 40)
        Me.btnAgregar.TabIndex = 11
        Me.btnAgregar.Text = "Aceptar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnLimpiar.Location = New System.Drawing.Point(91, 126)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(100, 23)
        Me.btnLimpiar.TabIndex = 12
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(158, 16)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 40)
        Me.btnSalir.TabIndex = 13
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtIdCliente
        '
        Me.txtIdCliente.AutoSize = True
        Me.txtIdCliente.Location = New System.Drawing.Point(73, 169)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(16, 13)
        Me.txtIdCliente.TabIndex = 14
        Me.txtIdCliente.Text = "..."
        Me.txtIdCliente.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 162)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(270, 68)
        Me.Panel1.TabIndex = 15
        '
        'frmAgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(270, 230)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtIdCliente)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(IdClienteLabel)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(DireccionLabel)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(RutLabel)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(TelefonoLabel)
        Me.Controls.Add(Me.txtTelefono)
        Me.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MaximizeBox = False
        Me.Name = "frmAgregarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarCliente"
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GFacHojillaData As GFacHojillaData
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As GFacHojillaDataTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As GFacHojillaDataTableAdapters.TableAdapterManager
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents txtIdCliente As Label
    Friend WithEvents Panel1 As Panel
End Class
