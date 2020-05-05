
Imports System.Data
Imports System.Data.SqlClient
Public Class frmEntregas
    Private dv As New DataView
    Dim IdCliente, IdVendedor, IdProducto As Integer

    Private Sub MostrarDatosTabla()

        Try
            'Declarando variables (Cadena de Conexión, Adaptador de Datos y DataSet)
            Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")
            'Consulta a la Tabla de la B.D.
            Dim da As New SqlDataAdapter("Select * From Entregas", conex)
            Dim ds As New DataSet
            'Cargamos la Tabla de Datos dentro del DataGridView

            da.Fill(ds)
            dv.Table = ds.Tables(0)
            DataGridView1.DataSource = dv
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub EntregasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EntregasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaData)

    End Sub
    Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")

    Private Sub cboNombreVendedor_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboNombreVendedor.SelectedValueChanged
        IdVendedor = Val(cboNombreVendedor.SelectedValue.ToString)
    End Sub

    Private Sub cboProducto_SelectedValueChanged(sender As Object, e As EventArgs)
        IdProducto = Val(cboProducto.SelectedValue.ToString)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        MostrarDatosTabla()
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

                Dim cmd As New SqlCommand("BorrarEntrega", conex)
                'Llamado al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure
                'Pasamos el Parámetro necesario al Procedimiento

                cmd.Parameters.Add("@Original_IdEntrega", SqlDbType.VarChar).Value = Val(txtIdEntrega.Text)

                'Abrimos la Conexión
                conex.Open()
                'Ejecutamos la Consulta
                cmd.ExecuteNonQuery()
                Me.EntregasTableAdapter.Fill(Me.GFacHojillaData.Entregas)
                'Cerramos la Conexión
                conex.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message) 'Mensaje en caso de Error

            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtCantCajas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantCajas.KeyPress
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

    Private Sub txtImporteTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporteTotal.KeyPress
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

    Private Sub frmListProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            '=== Hacemos lo mismo para la Lista Dias ===
            Dim ConsultaVendedores As String = "Select * From Vendedor"
            Dim AdapDias As SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(ConsultaVendedores, conex)
            Dim DatosVendedores As DataSet = New DataSet

            'Cargamos la Tabla con todos los Datos de la Consulta
            AdapDias.Fill(DatosVendedores)

            'Indicamos al ComboBox cual es la Fuente de Datos a mostrar
            cboNombreVendedor.DataSource = DatosVendedores.Tables(0)
            cboNombreVendedor.DisplayMember = "Nombre"
            cboNombreVendedor.ValueMember = "IdVendedor"

            '=== Hacemos lo mismo para la Lista Horario ===
            Dim ConsultaMercaderia As String = "Select * From Mercaderia"
            Dim AdapHorario As SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter(ConsultaMercaderia, conex)
            Dim DatosMercaderia As DataSet = New DataSet

            'Cargamos la Tabla con todos los Datos de la Consulta
            AdapHorario.Fill(DatosMercaderia)

            'Indicamos al ComboBox cual es la Fuente de Datos a mostrar
            cboProducto.DataSource = DatosMercaderia.Tables(0)
            cboProducto.DisplayMember = "NombreDeProducto"
            cboProducto.ValueMember = "IdHojilla"





        Catch ex As Exception
            MsgBox("No se realizó la conexión. " + ex.Message)

        End Try
        MostrarDatosTabla()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtCantCajas.Text = "" Or
txtImporteTotal.Text = "" Or txtCantCajas.Text = "" Then
            'Mensaje de Error
            MessageBox.Show("Los datos de la Entrega no están completos. Revise", "FALTAN
DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try

                Dim FechaVenta As Date = Convert.ToDateTime(dtpFecha.Value.ToShortDateString)





                'Declaración de Variables. Cadena de conexión a la Base de Datos
                Dim conex As New SqlConnection(("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;"))
                Dim cmd As New SqlCommand("AgregarEntregaso", conex) 'Nombre del Procedimiento

                'Llamando al Procedimiento Almacenado
                cmd.CommandType = CommandType.StoredProcedure
                'Pasamos los Parámetros necesarios al Procedimiento



                cmd.Parameters.Add("@IdVendedor", SqlDbType.VarChar).Value = IdVendedor
                cmd.Parameters.Add("@IdHojilla", SqlDbType.VarChar).Value = IdProducto
                cmd.Parameters.Add("@Fecha", SqlDbType.VarChar).Value = FechaVenta
                cmd.Parameters.Add("@CantCajas", SqlDbType.VarChar).Value = Val(txtCantCajas.Text)
                cmd.Parameters.Add("@Nombre_De_Producto", SqlDbType.VarChar).Value = cboProducto.Text
                cmd.Parameters.Add("@NombreDeVendedor", SqlDbType.VarChar).Value = cboNombreVendedor.Text
                cmd.Parameters.Add("@ImporteTotal", SqlDbType.VarChar).Value = Val(txtImporteTotal.Text)

                'Limpiamos las Cajas de Textos después de Insertar
                'txtCantCajas.Clear() : txtNombCliente.Clear() : txtImporteTotal.Clear()
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


End Class