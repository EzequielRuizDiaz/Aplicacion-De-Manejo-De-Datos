Imports System.Data
Imports System.Data.SqlClient
Public Class frmAcceso
    Public Acceso As String = ""
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            'Declarando variables
            Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")
            Dim cmd As New SqlCommand("ValidarUsuario", conex)

            Dim conn As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")
            Dim cmd1 As New SqlCommand("Select * From Usuarios Where NombreDeUsuario = '" + txtPassword.Text + "'And Contraseña ='" + txtUsuario.Text + "'", conn)
            Dim dr1 As SqlDataReader

            'Abrimos la Conexión
            conn.Open()

            dr1 = cmd1.ExecuteReader
            'Si se ejecutó la Lectura en la Tabla
            If (dr1.Read()) Then
                'Guardo el contenido del Campo TAcceso (Tipo de Acceso de la Tabla Usuarios)
                Acceso = dr1("TipoDeAccseso").ToString()
            End If
            conn.Close()    'Cerramos la Conexión

            'Declaramos Variables para el Formulario del Menú Principal
            Dim Usua As Usuarios = New Usuarios
            Dim dr As SqlDataReader
            Dim frm As MenuPrincipal = New MenuPrincipal

            'Llamando al Procedimiento Almacenado
            cmd.CommandType = CommandType.StoredProcedure

            'Asignamos los valores escritos en las cajas de texto a las variables de la Clase
            Usua.cUsuario = txtUsuario.Text
            Usua.cContrasena = txtPassword.Text

            'Pasamos los Parámetros necesarios al Procedimiento
            cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = Usua.cUsuario
            cmd.Parameters.Add("Password", SqlDbType.VarChar).Value = Usua.cContrasena

            'Abrimos la Conexión
            conex.Open()

            'Ejecutamos la Consulta
            cmd.ExecuteNonQuery()

            'Cargar Registros cuando se ejecute la consulta
            dr = cmd.ExecuteReader

            'Verificar si DR tiene registros o no
            If dr.HasRows = True Then
                'Existe el Usuario y Contraseña, entonces Cerramos el formulario y abrimos el siguiente
                Me.Hide()                               'Ocultar el Formulario Actual
                frm.lblTAcceso.Text = Acceso            'Asignar el Tipo de Usuario a la Etiqueta
                frm.lblTAcceso.Visible = False          'Ocultar la Etiqueta
                frm.Show()
            Else
                'Mostrar mensaje
                MessageBox.Show("Nombre de Usuario y/o Contraseña, NO VÁLIDOS. Rectifique", "Credenciales de Usuario")
                'Limpiamos las Cajas de Texto
                txtUsuario.Clear() : txtUsuario.Focus()
                txtPassword.Clear()
            End If
            'Cerramos la Conexión
            conex.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblReloj.Text = TimeOfDay
    End Sub

    Private Sub frmAcceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim FechaActual As Date = Date.Now
        '
        lblFecha.Text = FechaActual.ToShortDateString


        lblReloj.Text = TimeOfDay
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub lblReloj_Click(sender As Object, e As EventArgs) Handles lblReloj.Click

    End Sub
End Class




