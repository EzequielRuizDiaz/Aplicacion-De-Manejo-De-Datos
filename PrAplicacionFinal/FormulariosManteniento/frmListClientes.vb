Imports System.Data
Imports System.Data.SqlClient
Public Class frmListClientes
    Private dv As New DataView
    Private Sub AgregarCliente()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmAgregarCliente As frmAgregarCliente = New frmAgregarCliente()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmAgregarCliente.Show()
    End Sub
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaData)

    End Sub
    Private Sub MostrarDatosRegistro()
        'Muestro en las cajas de Texto los datos del Registro Activo en la Tabla
        txtIdCliente.Text = DataGridView1.SelectedCells.Item(0).Value
        txtNombre.Text = DataGridView1.SelectedCells.Item(1).Value
        txtDireccion.Text = DataGridView1.SelectedCells.Item(2).Value
        txtTelefono.Text = DataGridView1.SelectedCells.Item(3).Value
        txtRut.Text = DataGridView1.SelectedCells.Item(4).Value

    End Sub
    Private Sub frmListClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaData.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.GFacHojillaData.Clientes)

    End Sub


    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            'Declarando variables (Cadena de Conexión, Adaptador de Datos y DataSet)
            Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")
            'Consulta a la Tabla de la B.D.
            Dim da As New SqlDataAdapter("Select * From Clientes", conex)
            Dim ds As New DataSet
            'Cargamos la Tabla de Datos dentro del DataGridView

            da.Fill(ds)
            dv.Table = ds.Tables(0)
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub rbtNombres_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNombres.CheckedChanged
        'Activamos y Desactivamos los controles correspondientes según el tipo de búsqueda
        If (rbtNombres.Enabled = True) Then
            'Desactivamos la caja de texto de la busqueda por Nombres
            txtCedula.Enabled = False
            txtCedula.Clear()
            lblCedula.Enabled = False

            'Activamos los controles del Nombre
            txtNombres.Enabled = True
            lblNombre.Enabled = True
        End If
    End Sub

    Private Sub rbtCedula_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCedula.CheckedChanged
        If (rbtCedula.Enabled = True) Then
            'Desactivamos la caja de texto de la busqueda por Nombres
            txtNombres.Enabled = False
            txtNombres.Clear()
            lblNombre.Enabled = False

            'Activamos los controles de la Cédula
            txtCedula.Enabled = True
            lblCedula.Enabled = True
        End If
    End Sub

    Private Sub txtNombres_TextChanged(sender As Object, e As EventArgs) Handles txtNombres.TextChanged
        'BUSCAR POR NOMBRES
        If (rbtNombres.Enabled = True) Then
            'Hacer la Búsqueda por Nombres y mostrarlo en el DataGridView según coincidan
            dv.RowFilter = String.Format("Nombre like '{0}%'", txtNombres.Text)
        End If
    End Sub

    Private Sub txtCedula_TextChanged(sender As Object, e As EventArgs) Handles txtCedula.TextChanged
        'BUSCAR POR CEDULA
        If (rbtCedula.Enabled = True) Then
            'Hacer la Búsqueda por Cedula y mostrarlo en el DataGridView según coincidan
            dv.RowFilter = String.Format("Dirección like '{0}%'", txtCedula.Text)
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarCliente()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            'Declaración de Variables. Cadena de conexión a la Base de Datos
            Dim conex As New SqlConnection(("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;"))
            Dim cmd As New SqlCommand("ModificarClientee", conex) 'Nombre del Procedimiento
            'Llamando al Procedimiento Almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Pasamos los Parámetros necesarios al Procedimiento
            cmd.Parameters.Add("@IdCliente", SqlDbType.VarChar).Value = Val(txtIdCliente.Text)
            cmd.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = txtNombre.Text
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = txtDireccion.Text
            cmd.Parameters.Add("@Rut", SqlDbType.VarChar).Value = Val(txtRut.Text)
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = txtTelefono.Text

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

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Dim Respuesta As Integer
        'Pedir Confirmación al usuario para Borrar definitivo
        Respuesta = MessageBox.Show("¿Está seguro(a) que desea Eliminar este cliente?",
 "Registro de Alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        'Si responde SI, lo borramos
        If (Respuesta = DialogResult.Yes) Then

            'Verificar que las cajas de texto NO ESTEN VACIAS
            If txtIdCliente.Text = "" Then
                'Mensaje de Error
                MessageBox.Show("Error. Revise", "FALTAN

DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Try
                    'Declaración de Variables. Cadena de conexión a la Base de Datos
                    Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")

                    Dim cmd As New SqlCommand("BorrarClientee", conex)
                    'Llamado al Procedimiento Almacenado
                    cmd.CommandType = CommandType.StoredProcedure
                    'Pasamos el Parámetro necesario al Procedimiento

                    cmd.Parameters.Add("@Original_IdCliente", SqlDbType.VarChar).Value = Val(txtIdCliente.Text)

                    'Abrimos la Conexión
                    conex.Open()
                    'Ejecutamos la Consulta
                    cmd.ExecuteNonQuery()
                    Me.ClientesTableAdapter.Fill(Me.GFacHojillaData.Clientes)
                    'Cerramos la Conexión
                    conex.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message) 'Mensaje en caso de Error

                End Try
            End If
        End If
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        MostrarDatosRegistro()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
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

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
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

    Private Sub txtRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRut.KeyPress
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