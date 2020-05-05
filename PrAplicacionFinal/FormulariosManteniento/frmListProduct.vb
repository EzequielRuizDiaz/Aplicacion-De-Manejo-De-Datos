Imports System.Data
Imports System.Data.SqlClient
Public Class frmListProduct

    Private dv As New DataView
    Private Sub MercaderiaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MercaderiaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaData)

    End Sub
    Private Sub MostrarDatosRegistro()
        'Muestro en las cajas de Texto los datos del Registro Activo en la Tabla
        txtIdHojilla.Text = DataGridView1.SelectedCells.Item(0).Value
        txtNombreDeProducto.Text = DataGridView1.SelectedCells.Item(1).Value
        txtPrecioVenta.Text = DataGridView1.SelectedCells.Item(2).Value
        txtCantidadxCaja.Text = DataGridView1.SelectedCells.Item(3).Value
        txtGananciaPorCaja.Text = DataGridView1.SelectedCells.Item(4).Value

    End Sub
    Private Sub frmListProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtCantidadxCaja.Clear() : txtNombreDeProducto.Clear() : txtPrecioVenta.Clear() : txtGananciaPorCaja.Clear() 'TODO: esta línea de código carga datos en la tabla 'GFacHojillaData.Mercaderia' Puede moverla o quitarla según sea necesario.
        Me.MercaderiaTableAdapter.Fill(Me.GFacHojillaData.Mercaderia)

    End Sub

    Private Sub AgregarMercaderia()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmAgregarMercaderia As frmAgregarMercaderia = New frmAgregarMercaderia()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmAgregarMercaderia.Show()

    End Sub




    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        Try
            'Declarando variables (Cadena de Conexión, Adaptador de Datos y DataSet)
            Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")
            'Consulta a la Tabla de la B.D.
            Dim da As New SqlDataAdapter("Select * From Mercaderia", conex)
            Dim ds As New DataSet
            'Cargamos la Tabla de Datos dentro del DataGridView

            da.Fill(ds)
            dv.Table = ds.Tables(0)
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarMercaderia()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            'Declaración de Variables. Cadena de conexión a la Base de Datos
            Dim conex As New SqlConnection(("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;"))
            Dim cmd As New SqlCommand("ModificarMerca", conex) 'Nombre del Procedimiento
            'Llamando al Procedimiento Almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Pasamos los Parámetros necesarios al Procedimiento

            cmd.Parameters.Add("@IdHojilla", SqlDbType.VarChar).Value = Val(txtIdHojilla.Text)
            cmd.Parameters.Add("@NombreDeProducto", SqlDbType.VarChar).Value = txtNombreDeProducto.Text
            cmd.Parameters.Add("@PrecioVenta", SqlDbType.VarChar).Value = Val(txtPrecioVenta.Text)

            cmd.Parameters.Add("@CantidadxCaja", SqlDbType.VarChar).Value = Val(txtCantidadxCaja.Text)
            cmd.Parameters.Add("@GananciaPorCaja", SqlDbType.VarChar).Value = Val(txtGananciaPorCaja.Text)
            'Abrimos la Conexión
            conex.Open()
            'Ejecutamos la Consulta
            cmd.ExecuteNonQuery()
            'Cerramos la Conexión
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'Mensaje en caso de Error
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click, btnSalir.Click
        Dim Respuesta As Integer
        'Pedir Confirmación al usuario para Borrar definitivo
        Respuesta = MessageBox.Show("¿Está seguro(a) que desea Eliminar este  Producto?",
 "Registro de Alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        'Si responde SI, lo borramos
        If (Respuesta = DialogResult.Yes) Then

            'Verificar que las cajas de texto NO ESTEN VACIAS
            If txtIdHojilla.Text = "" Then
                'Mensaje de Error
                MessageBox.Show("Error. Revise", "FALTAN

DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Try
                    'Declaración de Variables. Cadena de conexión a la Base de Datos
                    Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")

                    Dim cmd As New SqlCommand("BorrarMerca", conex)
                    'Llamado al Procedimiento Almacenado
                    cmd.CommandType = CommandType.StoredProcedure
                    'Pasamos el Parámetro necesario al Procedimiento

                    cmd.Parameters.Add("@Original_IdHojilla", SqlDbType.VarChar).Value = Val(txtIdHojilla.Text)
                    txtCantidadxCaja.Clear() : txtNombreDeProducto.Clear() : txtPrecioVenta.Clear() : txtGananciaPorCaja.Clear()
                    'Abrimos la Conexión
                    conex.Open()
                    'Ejecutamos la Consulta
                    cmd.ExecuteNonQuery()
                    Me.MercaderiaTableAdapter.Fill(Me.GFacHojillaData.Mercaderia)
                    'Cerramos la Conexión
                    conex.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message) 'Mensaje en caso de Error

                End Try
            End If
        End If
    End Sub

    Private Sub rbtNombres_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNombres.CheckedChanged
        txtNombres.Enabled = True
    End Sub

    Private Sub txtNombres_TextChanged(sender As Object, e As EventArgs) Handles txtNombres.TextChanged
        If (rbtNombres.Enabled = True) Then
            'Hacer la Búsqueda por Nombres y mostrarlo en el DataGridView según coincidan
            dv.RowFilter = String.Format("NombreDeProducto like '{0}%'", txtNombres.Text)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        MostrarDatosRegistro()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtNombreDeProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreDeProducto.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Por favor, solo escriba Letras, Signos de Puntuación y Espacio", "ERROR EN DATOS")
        End If
    End Sub

    Private Sub txtPrecioVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecioVenta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then       'Solo CTRL
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then    'Solo Espacio en Blanco
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then   'Solo Signos de Puntuación
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Por favor, solo Teclee Números, Signos de Puntuación y Espacio", "ERROR EN DATOS")
        End If
    End Sub

    Private Sub txtCantidadxCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidadxCaja.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then       'Solo CTRL
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then    'Solo Espacio en Blanco
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then   'Solo Signos de Puntuación
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Por favor, solo Teclee Números, Signos de Puntuación y Espacio", "ERROR EN DATOS")
        End If
    End Sub

    Private Sub txtGananciaPorCaja_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGananciaPorCaja.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then       'Solo CTRL
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then    'Solo Espacio en Blanco
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then   'Solo Signos de Puntuación
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Por favor, solo Teclee Números, Signos de Puntuación y Espacio", "ERROR EN DATOS")
        End If
    End Sub
End Class