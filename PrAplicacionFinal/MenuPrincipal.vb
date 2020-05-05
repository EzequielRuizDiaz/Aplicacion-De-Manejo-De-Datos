Public Class MenuPrincipal
    Private CoordenadaX, CoordenadaY As Integer
    Private ARRASTRAR As Boolean

    Private Sub PictureBox_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ARRASTRAR = True
            CoordenadaX = e.X
            CoordenadaY = e.Y
        End If
    End Sub


    Private Sub VendedoresList()
        Dim frmListVendedores As frmListVendedores = New frmListVendedores()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmListVendedores.Show()

    End Sub
    Private Sub UsuarioList()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmUsuarios As frmUsuarios = New frmUsuarios()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmUsuarios.Show()
    End Sub


    Private Sub ClientesList()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmListClientes As frmListClientes = New frmListClientes()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmListClientes.Show()
    End Sub

    Private Sub Facturas()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmFacturas As frmFacturas = New frmFacturas()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmFacturas.Show()
    End Sub

    Private Sub Entragas()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmEntregas As frmListProduct = New frmListProduct()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmEntregas.Show()
    End Sub

    Private Sub ListaProductos()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmListProduct As frmEntregas = New frmEntregas()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmListProduct.Show()

    End Sub

    Private Sub estadistica()
        'Declarando un objeto de tipo formulario para instanciar a la clase
        Dim frmEstadisticas As frmEstadisticas = New frmEstadisticas()
        'Indicamos ahora que este objeto formulario es hijo del formulario principal (me), con el que estamos trabajando
        frmEstadisticas.Show()

    End Sub

    Private Sub MercaderiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MercaderiaToolStripMenuItem.Click
        Entragas()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        frmUsuarios.Show()
    End Sub

    Private Sub VendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendedoresToolStripMenuItem.Click
        VendedoresList()
    End Sub


    Private Sub EntregasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntregasToolStripMenuItem.Click
        ListaProductos()
    End Sub

    Private Sub FacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturasToolStripMenuItem.Click
        Facturas()
    End Sub

    Private Sub MercaderíaMásVendidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MercaderíaMásVendidaToolStripMenuItem.Click
        estadistica()
    End Sub


    Private Sub ClintesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClintesToolStripMenuItem.Click
        ClientesList()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub





    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnMercaderia_Click(sender As Object, e As EventArgs) Handles btnMercaderia.Click
        Entragas()
    End Sub

    Private Sub btnVendedor_Click(sender As Object, e As EventArgs) Handles btnVendedor.Click
        VendedoresList()
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        ClientesList()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        frmUsuarios.Show()
    End Sub



    Private Sub PictureBox_MouseMove_1(sender As Object, e As MouseEventArgs) Handles PictureBox.MouseMove
        If ARRASTRAR Then
            Me.Location = New Point((Me.Left + e.X) - CoordenadaX, (Me.Top + e.Y) - CoordenadaY)
        End If
    End Sub

    Private Sub PictureBox_MouseDown_1(sender As Object, e As MouseEventArgs) Handles PictureBox.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            ARRASTRAR = True
            CoordenadaX = e.X
            CoordenadaY = e.Y
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombre.Text = My.Computer.Name
        lblUsuario.Text = My.User.Name
        lblSistema.Text = My.Computer.Info.OSFullName + " Version: " + My.Computer.Info.OSVersion

        Dim FechaActual As Date = Date.Now

        lblFecha.Text = FechaActual.ToShortDateString

        lblReloj.Text = TimeOfDay
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblReloj.Text = TimeOfDay
    End Sub

    Private Sub btnEstadisticas_Click(sender As Object, e As EventArgs) Handles btnEstadisticas.Click
        estadistica()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        ListaProductos()
    End Sub

    Private Sub btnUsu_Click(sender As Object, e As EventArgs) Handles btnUsu.Click
        frmUsuarios.Show()
    End Sub

    Private Sub PanelContenedor_Paint(sender As Object, e As PaintEventArgs) Handles PanelContenedor.Paint

    End Sub

    Private Sub btnEntregas_Click(sender As Object, e As EventArgs) Handles btnEntregas.Click
        ListaProductos()
    End Sub
End Class
