<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListProduct
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
        Dim NombreDeProductoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListProduct))
        Dim PrecioVentaLabel As System.Windows.Forms.Label
        Dim CantidadxCajaLabel As System.Windows.Forms.Label
        Dim GananciaPorCajaLabel As System.Windows.Forms.Label
        Dim IdHojillaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GFacHojillaData = New PrAplicacionFinal.GFacHojillaData()
        Me.MercaderiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MercaderiaTableAdapter = New PrAplicacionFinal.GFacHojillaDataTableAdapters.MercaderiaTableAdapter()
        Me.TableAdapterManager = New PrAplicacionFinal.GFacHojillaDataTableAdapters.TableAdapterManager()
        Me.txtNombreDeProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.txtCantidadxCaja = New System.Windows.Forms.TextBox()
        Me.txtGananciaPorCaja = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.txtIdHojilla = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbtNombres = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        NombreDeProductoLabel = New System.Windows.Forms.Label()
        PrecioVentaLabel = New System.Windows.Forms.Label()
        CantidadxCajaLabel = New System.Windows.Forms.Label()
        GananciaPorCajaLabel = New System.Windows.Forms.Label()
        IdHojillaLabel = New System.Windows.Forms.Label()
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MercaderiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreDeProductoLabel
        '
        resources.ApplyResources(NombreDeProductoLabel, "NombreDeProductoLabel")
        NombreDeProductoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        NombreDeProductoLabel.Name = "NombreDeProductoLabel"
        '
        'PrecioVentaLabel
        '
        resources.ApplyResources(PrecioVentaLabel, "PrecioVentaLabel")
        PrecioVentaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        PrecioVentaLabel.Name = "PrecioVentaLabel"
        '
        'CantidadxCajaLabel
        '
        resources.ApplyResources(CantidadxCajaLabel, "CantidadxCajaLabel")
        CantidadxCajaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CantidadxCajaLabel.Name = "CantidadxCajaLabel"
        '
        'GananciaPorCajaLabel
        '
        resources.ApplyResources(GananciaPorCajaLabel, "GananciaPorCajaLabel")
        GananciaPorCajaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        GananciaPorCajaLabel.Name = "GananciaPorCajaLabel"
        '
        'IdHojillaLabel
        '
        resources.ApplyResources(IdHojillaLabel, "IdHojillaLabel")
        IdHojillaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        IdHojillaLabel.Name = "IdHojillaLabel"
        '
        'GFacHojillaData
        '
        Me.GFacHojillaData.DataSetName = "GFacHojillaData"
        Me.GFacHojillaData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MercaderiaBindingSource
        '
        Me.MercaderiaBindingSource.DataMember = "Mercaderia"
        Me.MercaderiaBindingSource.DataSource = Me.GFacHojillaData
        '
        'MercaderiaTableAdapter
        '
        Me.MercaderiaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.EntregasTableAdapter = Nothing
        Me.TableAdapterManager.MercaderiaTableAdapter = Me.MercaderiaTableAdapter
        Me.TableAdapterManager.UpdateOrder = PrAplicacionFinal.GFacHojillaDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        Me.TableAdapterManager.VendedorTableAdapter = Nothing
        Me.TableAdapterManager.VentasTableAdapter = Nothing
        '
        'txtNombreDeProducto
        '
        Me.txtNombreDeProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtNombreDeProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "NombreDeProducto", True))
        resources.ApplyResources(Me.txtNombreDeProducto, "txtNombreDeProducto")
        Me.txtNombreDeProducto.ForeColor = System.Drawing.SystemColors.Info
        Me.txtNombreDeProducto.Name = "txtNombreDeProducto"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtPrecioVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "PrecioVenta", True))
        resources.ApplyResources(Me.txtPrecioVenta, "txtPrecioVenta")
        Me.txtPrecioVenta.ForeColor = System.Drawing.SystemColors.Menu
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        '
        'txtCantidadxCaja
        '
        Me.txtCantidadxCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtCantidadxCaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "CantidadxCaja", True))
        resources.ApplyResources(Me.txtCantidadxCaja, "txtCantidadxCaja")
        Me.txtCantidadxCaja.ForeColor = System.Drawing.SystemColors.Menu
        Me.txtCantidadxCaja.Name = "txtCantidadxCaja"
        '
        'txtGananciaPorCaja
        '
        Me.txtGananciaPorCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtGananciaPorCaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "GananciaPorCaja", True))
        resources.ApplyResources(Me.txtGananciaPorCaja, "txtGananciaPorCaja")
        Me.txtGananciaPorCaja.ForeColor = System.Drawing.SystemColors.Menu
        Me.txtGananciaPorCaja.Name = "txtGananciaPorCaja"
        '
        'btnMostrar
        '
        Me.btnMostrar.FlatAppearance.BorderSize = 0
        Me.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        resources.ApplyResources(Me.btnMostrar, "btnMostrar")
        Me.btnMostrar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        resources.ApplyResources(Me.btnAgregar, "btnAgregar")
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        resources.ApplyResources(Me.btnEditar, "btnEditar")
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        resources.ApplyResources(Me.btnBorrar, "btnBorrar")
        Me.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'txtIdHojilla
        '
        Me.txtIdHojilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.txtIdHojilla.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "IdHojilla", True))
        resources.ApplyResources(Me.txtIdHojilla, "txtIdHojilla")
        Me.txtIdHojilla.Name = "txtIdHojilla"
        Me.txtIdHojilla.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnEditar)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.btnMostrar)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnBorrar)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        resources.ApplyResources(Me.btnSalir, "btnSalir")
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        resources.ApplyResources(Me.DataGridView1, "DataGridView1")
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        resources.ApplyResources(Me.txtNombres, "txtNombres")
        Me.txtNombres.ForeColor = System.Drawing.SystemColors.Info
        Me.txtNombres.Name = "txtNombres"
        '
        'rbtNombres
        '
        resources.ApplyResources(Me.rbtNombres, "rbtNombres")
        Me.rbtNombres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.rbtNombres.Name = "rbtNombres"
        Me.rbtNombres.TabStop = True
        Me.rbtNombres.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Name = "Label1"
        '
        'frmListProduct
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbtNombres)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(IdHojillaLabel)
        Me.Controls.Add(Me.txtIdHojilla)
        Me.Controls.Add(NombreDeProductoLabel)
        Me.Controls.Add(Me.txtNombreDeProducto)
        Me.Controls.Add(PrecioVentaLabel)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(CantidadxCajaLabel)
        Me.Controls.Add(Me.txtCantidadxCaja)
        Me.Controls.Add(GananciaPorCajaLabel)
        Me.Controls.Add(Me.txtGananciaPorCaja)
        Me.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmListProduct"
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MercaderiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GFacHojillaData As GFacHojillaData
    Friend WithEvents MercaderiaBindingSource As BindingSource
    Friend WithEvents MercaderiaTableAdapter As GFacHojillaDataTableAdapters.MercaderiaTableAdapter
    Friend WithEvents TableAdapterManager As GFacHojillaDataTableAdapters.TableAdapterManager
    Friend WithEvents txtNombreDeProducto As TextBox
    Friend WithEvents txtPrecioVenta As TextBox
    Friend WithEvents txtCantidadxCaja As TextBox
    Friend WithEvents txtGananciaPorCaja As TextBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents txtIdHojilla As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents txtNombres As TextBox
    Friend WithEvents rbtNombres As RadioButton
    Friend WithEvents Label1 As Label
End Class
