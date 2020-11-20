Imports System.Data.SqlClient

Public Class Entrada
    Public dtable As New DataTable("dt")
    Public dcolum1 As New DataColumn("Codigo", GetType(String))
    Public dcolum2 As New DataColumn("Producto", GetType(String))
    Public dcolum3 As New DataColumn("Marca", GetType(String))
    Public dcolum4 As New DataColumn("Modelo", GetType(String))
    Public dcolum5 As New DataColumn("P.Unitario", GetType(String))
    Public dcolum6 As New DataColumn("Cantidad", GetType(String))
    Public dcolum7 As New DataColumn("Total", GetType(String))
    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        identxt.Text = NEntrada.id
        fechtxt.Text = DateTime.Now.ToString("d")
        nomustxt.Text = Login.user
        provtxt.Text = NEntrada.prov

        dtable.Columns.Add(dcolum1)
        dtable.Columns.Add(dcolum2)
        dtable.Columns.Add(dcolum3)
        dtable.Columns.Add(dcolum4)
        dtable.Columns.Add(dcolum5)
        dtable.Columns.Add(dcolum6)
        dtable.Columns.Add(dcolum7)

        detalledgv.DataSource = dtable

    End Sub

    Public Sub refrescardetalle()
        detalledgv.DataSource = dtable
    End Sub

    Private Sub quitbtn_Click(sender As Object, e As EventArgs) Handles quitbtn.Click
        dtable.Rows.Remove(dtable.Rows.Item(detalledgv.CurrentRow.Index))
        refrescardetalle()
    End Sub

    Private Sub prodbtn_Click(sender As Object, e As EventArgs) Handles prodbtn.Click
        BProducto.Show()
    End Sub

    Private Sub grabbtn_Click(sender As Object, e As EventArgs) Handles grabbtn.Click

    End Sub
End Class