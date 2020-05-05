Imports System.Data
Imports System.Data.SqlClient

Public Class frmEstadisticas
    Private dv As New DataView
    Dim conex As New SqlConnection("Data Source=DESKTOP-81AD8RM;Initial Catalog=GFacHojilla;Integrated Security=SSPI;")

    Private Sub MostrarDatosTabla()
        Try

            Dim da As New SqlDataAdapter("Select * From Entregas", conex)
            Dim ds As New DataSet
            Dim cmdCuenta As New SqlCommand("Select Count(CantCajas) From Entregas", conex)
            Dim cmdSuma As New SqlCommand("Select Sum(ImporteTotal) From Entregas", conex)
            Dim cmdMenor As New SqlCommand("Select Min(ImporteTotal) From Entregas", conex)
            Dim cmdMayor As New SqlCommand("Select Max(ImporteTotal) From Entregas", conex)
            Dim cmdPromedio As New SqlCommand("Select AVG(ImporteTotal) From Entregas", conex)

            conex.Open()
            Dim Cuenta As Object = cmdCuenta.ExecuteScalar()
            Dim Suma As Object = cmdSuma.ExecuteScalar()
            Dim Menor As Object = cmdMenor.ExecuteScalar()
            Dim Mayor As Object = cmdMayor.ExecuteScalar()
            Dim Promedio As Object = cmdPromedio.ExecuteScalar()
            lblCantidad.Text = Cuenta
            lblSuma.Text = " $" & Suma
            lblMenor.Text = " $" & Menor
            lblMayor.Text = " $" & Mayor
            lblPromedio.Text = " $" & Promedio


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frmEstadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatosTabla()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class