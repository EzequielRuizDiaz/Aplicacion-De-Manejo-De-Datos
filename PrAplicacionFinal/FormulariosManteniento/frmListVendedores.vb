Imports System.Data
Imports System.Data.SqlClient
Public Class frmListVendedores
    Private dv As New DataView
    Private Sub VendedorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VendedorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaData)

    End Sub
    Private Sub MostrarDatosRegistro()
        'Muestro en las cajas de Texto los datos del Registro Activo en la Tabla
        txtIdVendedor.Text = DataGridView1.SelectedCells.Item(0).Value
        txtNombews.Text = DataGridView1.SelectedCells.Item(1).Value
        txtApellidos.Text = DataGridView1.SelectedCells.Item(2).Value
        txtDireccion.Text = DataGridView1.SelectedCells.Item(3).Value
        txtTelefono.Text = DataGridView1.SelectedCells.Item(4).Value
        txtCedula.Text = DataGridView1.SelectedCells.Item(5).Value

    End Sub
    Private Sub frmListVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaData.Vendedor' Puede moverla o quitarla según sea necesario.
        Me.VendedorTableAdapter.Fill(Me.GFacHojillaData.Vendedor)

    End Sub

    Private Sub AgregarVendedor()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmAgregarVendedor As frmAgregarVendedor = New frmAgregarVendedor()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmAgregarVendedor.Show()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarVendedor()
    End Sub

    Private Sub btnMuestrAlt_Click(sender As Object, e As EventArgs) Handles btnMuestrAlt.Click
        Try
            'Declarando variables (Cadena de Conexión, Adaptador de Datos y DataSet)
            Dim conex As New SqlConnection(("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;"))
            'Consulta a la Tabla de la B.D.
            Dim da As New SqlDataAdapter("Select * From Vendedor", conex)
            Dim ds As New DataSet
            'Cargamos la Tabla de Datos dentro del DataGridView
            da.Fill(ds)
            dv.Table = ds.Tables(0)
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Try
            'Declaración de Variables. Cadena de conexión a la Base de Datos
            Dim conex As New SqlConnection(("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;"))
            Dim cmd As New SqlCommand("ModificarVendedores", conex) 'Nombre del Procedimiento
            'Llamando al Procedimiento Almacenado
            cmd.CommandType = CommandType.StoredProcedure
            'Pasamos los Parámetros necesarios al Procedimiento

            cmd.Parameters.Add("@IdVendedor", SqlDbType.VarChar).Value = Val(txtIdVendedor.Text)
            cmd.Parameters.Add("@Nombres", SqlDbType.VarChar).Value = txtNombews.Text
            cmd.Parameters.Add("@Apellidos", SqlDbType.VarChar).Value = txtApellidos.Text
            cmd.Parameters.Add("@Telefono", SqlDbType.VarChar).Value = Val(txtTelefono.Text)
            cmd.Parameters.Add("@Direccion", SqlDbType.VarChar).Value = txtDireccion.Text
            cmd.Parameters.Add("@Cedula", SqlDbType.VarChar).Value = txtCedula.Text
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
        Respuesta = MessageBox.Show("¿Está seguro(a) que desea Eliminar este Vendedor?",
 "Registro de Alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        'Si responde SI, lo borramos
        If (Respuesta = DialogResult.Yes) Then




            Try
                'Declaración de Variables. Cadena de conexión a la Base de Datos
                Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")

                Dim cmd As New SqlCommand("BorrarVende", conex)
                'Llamado al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure
                'Pasamos el Parámetro necesario al Procedimiento

                cmd.Parameters.Add("@Original_IdVendedor", SqlDbType.VarChar).Value = Val(DataGridView1.Text)
                txtCedula.Clear() : txtNombres.Clear() : txtApellidos.Clear() : txtDireccion.Clear() : txtTelefono.Clear()
                'Abrimos la Conexión
                conex.Open()
                'Ejecutamos la Consulta
                cmd.ExecuteNonQuery()
                Me.VendedorTableAdapter.Fill(Me.GFacHojillaData.Vendedor)
                'Cerramos la Conexión
                conex.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Mensaje en caso de Error

            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtIdVendedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub rbtNombres_CheckedChanged(sender As Object, e As EventArgs) Handles rbtNombres.CheckedChanged
        txtNombres.Enabled = True
    End Sub

    Private Sub txtNombres_TextChanged(sender As Object, e As EventArgs) Handles txtNombres.TextChanged
        If (rbtNombres.Enabled = True) Then
            'Hacer la Búsqueda por Nombres y mostrarlo en el DataGridView según coincidan
            dv.RowFilter = String.Format("Nombre like '{0}%'", txtNombres.Text)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        MostrarDatosRegistro()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtNombews_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombews.KeyPress
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
End Class