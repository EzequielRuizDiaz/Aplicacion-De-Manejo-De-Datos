
Imports System.Data
Imports System.Data.SqlClient

Public Class frmUsuarios



    Private dv As New DataView
    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.GFacHojillaData)

    End Sub

    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'GFacHojillaData.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.GFacHojillaData.Usuarios)

    End Sub

    Private Sub btnAplicar_Click(sender As Object, e As EventArgs) Handles btnAplicar.Click
        '===== Verificar Operación a Realizar ======
        'Si es la Opción LISTADO
        If rbtListado.Checked = True Then
            'Oculto el GroupBbox Datos del Usuario
            gbxDatosUsuario.Visible = False


            'Deshabilito el GroupBox OPERACIONES
            gbxOperaciones.Enabled = False

            'Llamar al Procedimiento que muestra los Datos en el DataGridView
            MostrarTablaDatos()
        End If

        'Si es la Opción AGREGAR 
        If rbtAgregar.Checked = True Then


            'Llamar al Procedimiento que muestra los Datos en el DataGridView
            MostrarTablaDatos()

            'Garantizar que las Cajas de Textos y Controles estén vacías
            txtID.Clear() : txtNombres.Clear() : txtApellidos.Clear()
            txtNombUsuario.Clear() : txtPassword.Clear() : cboTAcceso.Text = ""

            'Activo el Botón GUARDAR
            btnGuardar.Enabled = True
        End If

        'Si es la Opción MODIFICAR
        If rbtModificar.Checked = True Then

            MostrarTablaDatos()

            'Llamar al Procedimiento que muestra los Datos en las Cajas de Texto
            CargarDatos()

            'Mostrar el Texto del DataGridView
            lblTexto.Visible = True
        End If

        'Si es la Opción ELIMINAR
        If rbtEliminar.Checked = True Then


            'Llamar al Procedimiento que muestra los Datos en el DataGridView
            MostrarTablaDatos()

            'Mostrar el Texto del DataGridView
            lblTexto.Visible = True

            'Ocultar el Botón GUARDAR
            btnGuardar.Visible = False

            'Mostrar y Mover el Botón ELIMINAR
            btnEliminar.Visible = True
            btnEliminar.Location = New Point(25, 120)
        End If
    End Sub

    Private Sub CargarDatos()
        Dim TAcceso As String
        'Mostrar los datos en las Cajas de Texto según la fila seleccionada en el DataGridView
        txtID.Text = dgvUsuarios.SelectedCells.Item(0).Value
        txtNombres.Text = dgvUsuarios.SelectedCells.Item(1).Value
        txtApellidos.Text = dgvUsuarios.SelectedCells.Item(2).Value
        txtNombUsuario.Text = dgvUsuarios.SelectedCells.Item(3).Value
        txtPassword.Text = dgvUsuarios.SelectedCells.Item(4).Value
        TAcceso = dgvUsuarios.SelectedCells.Item(5).Value

        'Muestro el Tipo de Acceso que tiene el Usuario según la Lista Desplegable
        If TAcceso = "adm" Then
            cboTAcceso.Text = "Administrador"
        Else
            cboTAcceso.Text = "Usuario"
        End If
    End Sub

    Private Sub PreparaVentana()
        'Muestro el GroupBbox Datos del Usuario
        gbxDatosUsuario.Visible = True

        btnOperacion.Location = New Point(27, 564)
        btnTerminar.Location = New Point(484, 564)

        'Deshabilito el GroupBox OPERACIONES
        gbxOperaciones.Enabled = False
    End Sub

    Private Sub MostrarTablaDatos()
        Try
            'Declarando variables (Cadena de Conexión, Adaptador de Datos y DataSet)
            Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")
            Dim da As New SqlDataAdapter("Select * From Usuarios", conex)   'Consulta a la Tabla de la B.D.
            Dim ds As New DataSet


            Dim cmd As New SqlCommand("Select Count(*) From Usuarios", conex)

            'Abrimos la Conexión
            conex.Open()

            'Declaramos variable Objeto que guarde el resultado de la Ejecución de la Consulta
            Dim Valor As Object = cmd.ExecuteScalar()

            'Asignamos el Valor obtenido del TOTAL de registros de la Tabla
            txtTotalUsuarios.Text = Valor

            'Cerramos la Conexión
            conex.Close()

            'Cargamos la Tabla de Datos dentro del DataGridView
            da.Fill(ds)
            dv.Table = ds.Tables(0)
            dgvUsuarios.DataSource = dv

            'Oculto la Primera Columna (ID)
            dgvUsuarios.Columns(0).Visible = False

            'Cambiar el Texto del Encabezamiento de las Columnas 4 y 5
            dgvUsuarios.Columns(4).HeaderText = "Password"
            dgvUsuarios.Columns(5).HeaderText = "Tipo de Acceso"

            'TAMBIEN PODEMOS CONTAR la cantidad de Filas Mostradas en el DataGridView
            'txtTotalUsuarios.Text = dgvUsuarios.RowCount

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnOperacion_Click(sender As Object, e As EventArgs) Handles btnOperacion.Click


        'Habilito el GroupBox OPERACIONES
        gbxOperaciones.Enabled = True

        'Mostrar el Botón GUARDAR
        btnGuardar.Visible = True

        'Ocultar el Texto del DataGridView
        lblTexto.Visible = False

        'Garantizar que las Cajas de Textos y Controles estén vacías
        txtID.Clear() : txtNombres.Clear() : txtApellidos.Clear()
        txtNombUsuario.Clear() : txtPassword.Clear() : cboTAcceso.Text = ""
    End Sub

    Private Sub btnMuestraOculta_Click(sender As Object, e As EventArgs) Handles btnMuestraOculta.Click
        'Verificar el estado del Botón (TEXT)
        If btnMuestraOculta.Text = "Mostrar" Then
            'Cambio el Texto del Botón
            btnMuestraOculta.Text = "Ocultar"

            'Muestro el Texto de la Contraseña
            txtPassword.UseSystemPasswordChar = False
        Else
            'Cambio el Texto del Botón
            btnMuestraOculta.Text = "Mostrar"

            'Oculto el Texto de la Contraseña
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        '==== Si la Opción de Operación es AGREGAR ======
        If rbtAgregar.Checked = True Then
            'Garantizar que se llenen todos los datos
            If (txtNombres.Text = "" Or txtApellidos.Text = "" Or txtNombUsuario.Text = "" Or txtPassword.Text = "" Or cboTAcceso.Text = "") Then
                'Muestro Mensaje de Error
                MessageBox.Show("Los datos del USUARIO no están completos. Revise", "FALTAN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)

                'Pongo el cursor en la Primera caja de texto
                txtNombres.Focus()
            Else
                Try
                    'Declaración de Variables. Cadena de conexión a la Base de Datos
                    Dim TAcceso As String
                    Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")
                    Dim cmd As New SqlCommand("AgregarUsuarioo", conex)

                    'Llamado al Procedimiento Almacenado 
                    cmd.CommandType = CommandType.StoredProcedure

                    'Verifico el Tipo de Acceso que tendrá el Usuario según la Lista Desplegable
                    If cboTAcceso.Text = "Administrador" Then
                        TAcceso = "adm"
                    Else
                        TAcceso = "usu"
                    End If

                    'Pasamos los Parámetros necesarios al Procedimiento
                    '===== OJO NO SE PONE EL ID PORQUE ES UN CAMPO AUTOINCREMENTADO =====
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombres.Text
                    cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = txtApellidos.Text
                    cmd.Parameters.Add("@NombreDeUsuario", SqlDbType.VarChar).Value = txtNombUsuario.Text
                    cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = txtPassword.Text
                    cmd.Parameters.Add("@TipoDeAccseso", SqlDbType.VarChar).Value = TAcceso

                    'Ocultar el Botón GUARDAR
                    btnGuardar.Visible = False

                    'Abrimos la Conexión
                    conex.Open()

                    'Ejecutamos la Consulta
                    cmd.ExecuteNonQuery()

                    'Cerramos la Conexión
                    conex.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
        '==== Si la Opción de Operación es MODIFICAR ======
        If rbtModificar.Checked = True Then
            'Garantizar que se llenen todos los datos
            If (txtNombres.Text = "" Or txtApellidos.Text = "" Or txtNombUsuario.Text = "" Or txtPassword.Text = "" Or cboTAcceso.Text = "") Then
                'Muestro Mensaje de Error
                MessageBox.Show("Los datos del USUARIO no están completos. Revise", "FALTAN DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error)

                'Pongo el cursor en la Primera caja de texto
                txtNombres.Focus()
            Else
                Try
                    'Declaración de Variables. Cadena de conexión a la Base de Datos
                    Dim TAcceso As String
                    Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")
                    Dim cmd As New SqlCommand("ModificarUsuario", conex)

                    'Llamado al Procedimiento Almacenado 
                    cmd.CommandType = CommandType.StoredProcedure

                    'Verifico el Tipo de Acceso que tendrá el Usuario según la Lista Desplegable
                    If cboTAcceso.Text = "Administrador" Then
                        TAcceso = "adm"
                    Else
                        TAcceso = "usu"
                    End If

                    'Pasamos los Parámetros necesarios al Procedimiento
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Val(txtID.Text)
                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = txtNombres.Text
                    cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = txtApellidos.Text
                    cmd.Parameters.Add("@NombreDeUsuario", SqlDbType.VarChar).Value = txtNombUsuario.Text
                    cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = txtPassword.Text
                    cmd.Parameters.Add("@TipoDeAccseso", SqlDbType.VarChar).Value = TAcceso

                    'Oculto el Botón GUARDAR
                    btnGuardar.Visible = False

                    'Abrimos la Conexión
                    conex.Open()

                    'Ejecutamos la Consulta
                    cmd.ExecuteNonQuery()

                    'Cerramos la Conexión
                    conex.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        MostrarTablaDatos()
    End Sub

    Private Sub dgvUsuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellClick
        'Muestro los Datos en las cajas de Texto cuando se haga Clic sobre cualquier CELDA
        CargarDatos()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim Identificador As Integer

        'Verifico que no se borre el Primer Usuario (ADMINISTRADOR del Sistema)
        Identificador = Val(txtID.Text)     'Tomo el valor del ID que se quiere borrar

        If Identificador = 1 Then
            MessageBox.Show("No es posible ELIMINAR este usuario ya que es el ADMINISTRADOR del Sistema", "Usuario Protegido", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                'Declaración de Variables. Cadena de conexión a la Base de Datos
                Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")
                Dim cmd As New SqlCommand("BorrarUsuarioo", conex)

                'Llamado al Procedimiento Almacenado 
                cmd.CommandType = CommandType.StoredProcedure

                'Pasamos los Parámetros necesarios al Procedimiento
                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = Val(txtID.Text)

                'Oculto el Botón ELIMINAR
                btnEliminar.Visible = False

                'Garantizar que las Cajas de Textos y Controles estén vacías
                txtID.Clear() : txtNombres.Clear() : txtApellidos.Clear()
                txtNombUsuario.Clear() : txtPassword.Clear() : cboTAcceso.Text = ""

                'Abrimos la Conexión
                conex.Open()

                'Ejecutamos la Consulta
                cmd.ExecuteNonQuery()

                'Cerramos la Conexión
                conex.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub rbtAgregar_CheckedChanged(sender As Object, e As EventArgs) Handles rbtAgregar.CheckedChanged

    End Sub

    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        Me.Close()
    End Sub

    Private Sub txtNombUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombUsuario.KeyPress
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
End Class