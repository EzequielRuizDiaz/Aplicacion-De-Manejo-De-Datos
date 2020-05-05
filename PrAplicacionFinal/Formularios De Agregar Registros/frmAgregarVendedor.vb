Imports System.Data
Imports System.Data.SqlClient
Public Class frmAgregarVendedor
    Private dv As New DataView
    Private Sub VendedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VendedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaData)

    End Sub

    Private Sub frmAgregarVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaData.Vendedor' Puede moverla o quitarla según sea necesario.
        Me.VendedorTableAdapter.Fill(Me.GFacHojillaData.Vendedor)

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtCedula.Clear() : txtNombres.Clear() : txtApellidos.Clear() : txtDireccion.Clear() : txtTelefono.Clear()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtCedula.Text = "" Or txtNombres.Text = "" Or txtApellidos.Text = "" Or
       txtDireccion.Text = "" Or txtTelefono.Text = "" Then
            'Mensaje de Error
            MessageBox.Show("Los datos del Vendedor no están completos. Revise", "FALTAN
DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                'Declaración de Variables. Cadena de conexión a la Base de Datos
                Dim conex As New SqlConnection(("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;"))
                Dim cmd As New SqlCommand("AgregarVendedor", conex) 'Nombre del Procedimiento
                'Llamando al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure
                'Pasamos los Parámetros necesarios al Procedimiento
                cmd.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = txtCedula.Text
                cmd.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = txtNombres.Text
                cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = txtApellidos.Text

                cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = txtTelefono.Text
                cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = txtDireccion.Text
                'Limpiamos las Cajas de Textos después de Insertar
                txtCedula.Clear() : txtNombres.Clear() : txtApellidos.Clear() : txtDireccion.Clear() : txtTelefono.Clear()
                'Abrimos la Conexión
                conex.Open()
                'Ejecutamos la Consulta
                cmd.ExecuteNonQuery()

                'Cerramos la Conexión
                conex.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Mensaje en caso de Error
            End Try
        End If
    End Sub

    Private Sub txtNombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombres.KeyPress
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

    Private Sub txtApellidos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellidos.KeyPress
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

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsPunctuation(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MessageBox.Show("Por favor, solo Teclee Números, Signos de Puntuación y Espacio", "ERROR EN DATOS")
        End If
    End Sub

    Private Sub txtCedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCedula.KeyPress
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