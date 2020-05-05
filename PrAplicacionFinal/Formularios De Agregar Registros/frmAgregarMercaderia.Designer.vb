<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarMercaderia
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
        Dim NombreDeProductoLabel As System.Windows.Forms.Label
        Dim PrecioVentaLabel As System.Windows.Forms.Label
        Dim CantidadxCajaLabel As System.Windows.Forms.Label
        Dim GananciaPorCajaLabel As System.Windows.Forms.Label
        Me.GFacHojillaData = New PrAplicacionFinal.GFacHojillaData()
        Me.MercaderiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MercaderiaTableAdapter = New PrAplicacionFinal.GFacHojillaDataTableAdapters.MercaderiaTableAdapter()
        Me.TableAdapterManager = New PrAplicacionFinal.GFacHojillaDataTableAdapters.TableAdapterManager()
        Me.txtNombreDeProducto = New System.Windows.Forms.TextBox()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.txtCantidadxCaja = New System.Windows.Forms.TextBox()
        Me.txtGananciaPorCaja = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        NombreDeProductoLabel = New System.Windows.Forms.Label()
        PrecioVentaLabel = New System.Windows.Forms.Label()
        CantidadxCajaLabel = New System.Windows.Forms.Label()
        GananciaPorCajaLabel = New System.Windows.Forms.Label()
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MercaderiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NombreDeProductoLabel
        '
        NombreDeProductoLabel.AutoSize = True
        NombreDeProductoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreDeProductoLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        NombreDeProductoLabel.Location = New System.Drawing.Point(59, 23)
        NombreDeProductoLabel.Name = "NombreDeProductoLabel"
        NombreDeProductoLabel.Size = New System.Drawing.Size(59, 15)
        NombreDeProductoLabel.TabIndex = 3
        NombreDeProductoLabel.Text = "Producto:"
        '
        'PrecioVentaLabel
        '
        PrecioVentaLabel.AutoSize = True
        PrecioVentaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PrecioVentaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        PrecioVentaLabel.Location = New System.Drawing.Point(38, 53)
        PrecioVentaLabel.Name = "PrecioVentaLabel"
        PrecioVentaLabel.Size = New System.Drawing.Size(79, 15)
        PrecioVentaLabel.TabIndex = 5
        PrecioVentaLabel.Text = "Precio Venta:"
        '
        'CantidadxCajaLabel
        '
        CantidadxCajaLabel.AutoSize = True
        CantidadxCajaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CantidadxCajaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        CantidadxCajaLabel.Location = New System.Drawing.Point(26, 83)
        CantidadxCajaLabel.Name = "CantidadxCajaLabel"
        CantidadxCajaLabel.Size = New System.Drawing.Size(96, 15)
        CantidadxCajaLabel.TabIndex = 7
        CantidadxCajaLabel.Text = "Cantidad x Caja:"
        '
        'GananciaPorCajaLabel
        '
        GananciaPorCajaLabel.AutoSize = True
        GananciaPorCajaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GananciaPorCajaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace
        GananciaPorCajaLabel.Location = New System.Drawing.Point(12, 113)
        GananciaPorCajaLabel.Name = "GananciaPorCajaLabel"
        GananciaPorCajaLabel.Size = New System.Drawing.Size(110, 15)
        GananciaPorCajaLabel.TabIndex = 9
        GananciaPorCajaLabel.Text = "Ganancia por caja:"
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
        Me.txtNombreDeProducto.ForeColor = System.Drawing.SystemColors.Info
        Me.txtNombreDeProducto.Location = New System.Drawing.Point(128, 20)
        Me.txtNombreDeProducto.Name = "txtNombreDeProducto"
        Me.txtNombreDeProducto.Size = New System.Drawing.Size(116, 21)
        Me.txtNombreDeProducto.TabIndex = 4
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtPrecioVenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "PrecioVenta", True))
        Me.txtPrecioVenta.ForeColor = System.Drawing.SystemColors.Info
        Me.txtPrecioVenta.Location = New System.Drawing.Point(128, 50)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(116, 21)
        Me.txtPrecioVenta.TabIndex = 6
        '
        'txtCantidadxCaja
        '
        Me.txtCantidadxCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtCantidadxCaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "CantidadxCaja", True))
        Me.txtCantidadxCaja.ForeColor = System.Drawing.SystemColors.Info
        Me.txtCantidadxCaja.Location = New System.Drawing.Point(128, 80)
        Me.txtCantidadxCaja.Name = "txtCantidadxCaja"
        Me.txtCantidadxCaja.Size = New System.Drawing.Size(116, 21)
        Me.txtCantidadxCaja.TabIndex = 8
        '
        'txtGananciaPorCaja
        '
        Me.txtGananciaPorCaja.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtGananciaPorCaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MercaderiaBindingSource, "GananciaPorCaja", True))
        Me.txtGananciaPorCaja.ForeColor = System.Drawing.SystemColors.Info
        Me.txtGananciaPorCaja.Location = New System.Drawing.Point(128, 110)
        Me.txtGananciaPorCaja.Name = "txtGananciaPorCaja"
        Me.txtGananciaPorCaja.Size = New System.Drawing.Size(116, 21)
        Me.txtGananciaPorCaja.TabIndex = 10
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnAceptar.Location = New System.Drawing.Point(90, 14)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(87, 37)
        Me.btnAceptar.TabIndex = 11
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSalir.Location = New System.Drawing.Point(208, 14)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(87, 37)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpiar.Location = New System.Drawing.Point(128, 140)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(117, 27)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Panel1.Location = New System.Drawing.Point(-8, 175)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(353, 87)
        Me.Panel1.TabIndex = 14
        '
        'frmAgregarMercaderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(344, 253)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(NombreDeProductoLabel)
        Me.Controls.Add(Me.txtNombreDeProducto)
        Me.Controls.Add(PrecioVentaLabel)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(CantidadxCajaLabel)
        Me.Controls.Add(Me.txtCantidadxCaja)
        Me.Controls.Add(GananciaPorCajaLabel)
        Me.Controls.Add(Me.txtGananciaPorCaja)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.Name = "frmAgregarMercaderia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAgregarMercaderia"
        CType(Me.GFacHojillaData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MercaderiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
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
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Panel1 As Panel
End Class
