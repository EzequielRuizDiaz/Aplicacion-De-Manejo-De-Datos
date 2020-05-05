<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEntregas
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
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CantCajasLabel As System.Windows.Forms.Label
        Dim NombreDeVendedorLabel As System.Windows.Forms.Label
        Dim ImporteTotalLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.EntregasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GFacHojillaData = New PrAplicacionFinal.GFacHojillaData()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_De_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtCantCajas = New System.Windows.Forms.TextBox()
        Me.txtImporteTotal = New System.Windows.Forms.TextBox()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.txtIdEntrega = New System.Windows.Forms.TextBox()
        Me.cboNombreVendedor = New System.Windows.Forms.ComboBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.EntregasTableAdapter = New PrAplicacionFinal.GFacHojillaDataTableAdapters.EntregasTableAdapter()
        Me.TableAdapterManager = New PrAplicacionFinal.GFacHojillaDataTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        FechaLabel = New System.Windows.Forms.Label()
        CantCajasLabel = New System.Windows.Forms.Label()
        NombreDeVendedorLabel = New System.Windows.Forms.Label()
        ImporteTotalLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.EntregasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(473, 76)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(44, 15)
        FechaLabel.TabIndex = 8
        FechaLabel.Text = "Fecha:"
        '
        'CantCajasLabel
        '
        CantCajasLabel.AutoSize = True
        CantCajasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CantCajasLabel.Location = New System.Drawing.Point(187, 59)
        CantCajasLabel.Name = "CantCajasLabel"
        CantCajasLabel.Size = New System.Drawing.Size(69, 15)
        CantCajasLabel.TabIndex = 10
        CantCajasLabel.Text = "Cant Cajas:"
        '
        'NombreDeVendedorLabel
        '
        NombreDeVendedorLabel.AutoSize = True
        NombreDeVendedorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreDeVendedorLabel.Location = New System.Drawing.Point(463, 19)
        NombreDeVendedorLabel.Name = "NombreDeVendedorLabel"
        NombreDeVendedorLabel.Size = New System.Drawing.Size(63, 15)
        NombreDeVendedorLabel.TabIndex = 14
        NombreDeVendedorLabel.Text = "Vendedor:"
        '
        'ImporteTotalLabel
        '
        ImporteTotalLabel.AutoSize = True
        ImporteTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImporteTotalLabel.Location = New System.Drawing.Point(174, 99)
        ImporteTotalLabel.Name = "ImporteTotalLabel"
        ImporteTotalLabel.Size = New System.Drawing.Size(82, 15)
        ImporteTotalLabel.TabIndex = 16
        ImporteTotalLabel.Text = "Importe Total:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(200, 21)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(56, 15)
        Label2.TabIndex = 14
        Label2.Text = "Producto"
        '
        'EntregasBindingSource
        '
        Me.EntregasBindingSource.DataMember = "Entregas"
        Me.EntregasBindingSource.DataSource = Me.GFacHojillaData
        '
        'GFacHojillaData
        '
        Me.GFacHojillaData.DataSetName = "GFacHojillaData"
        Me.GFacHojillaData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7, Me.Nombre_De_Producto, Me.DataGridViewTextBoxColumn8})
        Me.DataGridView1.DataSource = Me.EntregasBindingSource
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(137, 132)
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
        Me.DataGridView1.Size = New System.Drawing.Size(491, 239)
        Me.DataGridView1.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdEntrega"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdEntrega"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdVendedor"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdVendedor"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdHojilla"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdHojilla"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 60
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CantCajas"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CantCajas"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 78
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Nombre_De_Producto"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NombreDeVendedor"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 127
        '
        'Nombre_De_Producto
        '
        Me.Nombre_De_Producto.DataPropertyName = "Nombre_De_Producto"
        Me.Nombre_De_Producto.HeaderText = "Nombre_De_Producto"
        Me.Nombre_De_Producto.Name = "Nombre_De_Producto"
        Me.Nombre_De_Producto.ReadOnly = True
        Me.Nombre_De_Producto.Width = 136
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ImporteTotal"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ImporteTotal"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 89
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dtpFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EntregasBindingSource, "Fecha", True))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(436, 94)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecha.TabIndex = 9
        '
        'txtCantCajas
        '
        Me.txtCantCajas.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtCantCajas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntregasBindingSource, "CantCajas", True))
        Me.txtCantCajas.ForeColor = System.Drawing.SystemColors.Control
        Me.txtCantCajas.Location = New System.Drawing.Point(262, 59)
        Me.txtCantCajas.Name = "txtCantCajas"
        Me.txtCantCajas.Size = New System.Drawing.Size(60, 20)
        Me.txtCantCajas.TabIndex = 11
        '
        'txtImporteTotal
        '
        Me.txtImporteTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtImporteTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EntregasBindingSource, "ImporteTotal", True))
        Me.txtImporteTotal.ForeColor = System.Drawing.SystemColors.Control
        Me.txtImporteTotal.Location = New System.Drawing.Point(262, 97)
        Me.txtImporteTotal.Name = "txtImporteTotal"
        Me.txtImporteTotal.Size = New System.Drawing.Size(60, 20)
        Me.txtImporteTotal.TabIndex = 17
        '
        'cboProducto
        '
        Me.cboProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.cboProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProducto.ForeColor = System.Drawing.SystemColors.Info
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(262, 20)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(121, 21)
        Me.cboProducto.TabIndex = 20
        '
        'txtIdEntrega
        '
        Me.txtIdEntrega.Location = New System.Drawing.Point(632, 62)
        Me.txtIdEntrega.Name = "txtIdEntrega"
        Me.txtIdEntrega.ReadOnly = True
        Me.txtIdEntrega.Size = New System.Drawing.Size(10, 20)
        Me.txtIdEntrega.TabIndex = 19
        Me.txtIdEntrega.Visible = False
        '
        'cboNombreVendedor
        '
        Me.cboNombreVendedor.AllowDrop = True
        Me.cboNombreVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.cboNombreVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboNombreVendedor.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.cboNombreVendedor.FormattingEnabled = True
        Me.cboNombreVendedor.Location = New System.Drawing.Point(436, 42)
        Me.cboNombreVendedor.Name = "cboNombreVendedor"
        Me.cboNombreVendedor.Size = New System.Drawing.Size(121, 21)
        Me.cboNombreVendedor.TabIndex = 18
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.Location = New System.Drawing.Point(0, 88)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(114, 76)
        Me.btnAgregar.TabIndex = 19
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBorrar.Location = New System.Drawing.Point(0, 255)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(114, 65)
        Me.btnBorrar.TabIndex = 20
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEditar.Location = New System.Drawing.Point(0, 170)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(114, 79)
        Me.btnEditar.TabIndex = 21
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.FlatAppearance.BorderSize = 0
        Me.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMostrar.Location = New System.Drawing.Point(2, -1)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(112, 78)
        Me.btnMostrar.TabIndex = 22
        Me.btnMostrar.Text = "Mostrar\Actualizar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Location = New System.Drawing.Point(0, 326)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(114, 71)
        Me.btnSalir.TabIndex = 23
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'EntregasTableAdapter
        '
        Me.EntregasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EntregasTableAdapter = Me.EntregasTableAdapter
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
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnBorrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(114, 400)
        Me.Panel1.TabIndex = 24
        '
        'frmEntregas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(653, 400)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.txtImporteTotal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(ImporteTotalLabel)
        Me.Controls.Add(Me.cboNombreVendedor)
        Me.Controls.Add(CantCajasLabel)
        Me.Controls.Add(Me.txtIdEntrega)
        Me.Controls.Add(Me.txtCantCajas)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(NombreDeVendedorLabel)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.MaximizeBox = False
        Me.Name = "frmEntregas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListProduct"
        CType(Me.EntregasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GFacHojillaData As GFacHojillaData
    Friend WithEvents EntregasBindingSource As BindingSource
    Friend WithEvents EntregasTableAdapter As GFacHojillaDataTableAdapters.EntregasTableAdapter
    Friend WithEvents TableAdapterManager As GFacHojillaDataTableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents txtCantCajas As TextBox
    Friend WithEvents txtImporteTotal As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents cboNombreVendedor As ComboBox
    Friend WithEvents txtIdEntrega As TextBox
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_De_Producto As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents cboProducto As ComboBox
    Friend WithEvents Panel1 As Panel
End Class
