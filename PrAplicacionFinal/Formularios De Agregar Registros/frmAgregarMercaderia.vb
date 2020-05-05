Imports System.Data
Imports System.Data.SqlClient
Public Class frmAgregarMercaderia
    Private Sub MercaderiaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MercaderiaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaData)

    End Sub

    Private Sub frmAgregarMercaderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaData.Mercaderia' Puede moverla o quitarla según sea necesario.
        Me.MercaderiaTableAdapter.Fill(Me.GFacHojillaData.Mercaderia)

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If txtCantidadxCaja.Text = "" Or txtNombreDeProducto.Text = "" Or
txtGananciaPorCaja.Text = "" Or txtPrecioVenta.Text = "" Then
            'Mensaje de Error
            MessageBox.Show("Los datos del Alumno no están completos. Revise", "FALTAN
DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                'Declaración de Variables. Cadena de conexión a la Base de Datos
                Dim conex As New SqlConnection(("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;"))
                Dim cmd As New SqlCommand("AgregarMerca", conex) 'Nombre del Procedimiento

                'Llamando al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure
                'Pasamos los Parámetros necesarios al Procedimiento
                cmd.Parameters.Add("@PrecioVenta", SqlDbType.VarChar).Value = Val(txtPrecioVenta.Text)
                cmd.Parameters.Add("@NombreDeProducto", SqlDbType.VarChar).Value = txtNombreDeProducto.Text
                cmd.Parameters.Add("@CantidadxCaja", SqlDbType.VarChar).Value = Val(txtCantidadxCaja.Text)
                cmd.Parameters.Add("@GananciaPorCaja", SqlDbType.VarChar).Value = Val(txtGananciaPorCaja.Text)
                'Limpiamos las Cajas de Textos después de Insertar
                txtCantidadxCaja.Clear() : txtNombreDeProducto.Clear() : txtPrecioVenta.Clear() : txtGananciaPorCaja.Clear()
                'Abrimos la Conexión
                conex.Open()
                'Ejecutamos la Consulta
                cmd.ExecuteNonQuery()
                MessageBox.Show("Agregado Correctamente", "FALTAN
DATOS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Cerramos la Conexión
                conex.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Mensaje en caso de Error
            End Try
        End If






    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCantidadxCaja.Clear() : txtNombreDeProducto.Clear() : txtPrecioVenta.Clear() : txtGananciaPorCaja.Clear()
    End Sub

    Private Sub txtNombreDeProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreDeProducto.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then       'Solo CTRL
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then    'Solo Espacio en Blanco
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then   'Solo Signos de Puntuación
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class