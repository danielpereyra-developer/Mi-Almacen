Imports System.Data.SqlClient
Imports itextsharp.text
Public Class Entrada
    Public dtable As New DataTable("dt")
    Public dcolum1 As New DataColumn("Codigo", GetType(String))
    Public dcolum2 As New DataColumn("Producto", GetType(String))
    Public dcolum3 As New DataColumn("Marca", GetType(String))
    Public dcolum4 As New DataColumn("Modelo", GetType(String))
    Public dcolum5 As New DataColumn("P.Unitario", GetType(String))
    Public dcolum6 As New DataColumn("Cantidad", GetType(String))
    Public dcolum7 As New DataColumn("Total", GetType(String))

    Dim cont As String

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

        dtable.Rows.Clear()

        detalledgv.DataSource = dtable

        subttxt.Text = "0"
        igvtxt.Text = "0"
        totaltxt.Text = "0"

    End Sub

    Public Sub refrescardetalle()
        detalledgv.DataSource = dtable
    End Sub

    Private Sub quitbtn_Click(sender As Object, e As EventArgs) Handles quitbtn.Click
        Dim auxsubt As Double
        auxsubt = CDbl(subttxt.Text) - CDbl(dtable.Rows(detalledgv.CurrentRow.Index)(6).ToString)
        dtable.Rows.Remove(dtable.Rows.Item(detalledgv.CurrentRow.Index))

        refrescardetalle()
        actualizarcostos(auxsubt)
    End Sub

    Private Sub prodbtn_Click(sender As Object, e As EventArgs) Handles prodbtn.Click
        BProducto.subtotal = CDbl(subttxt.Text)
        BProducto.Show()
    End Sub

    Private Sub grabbtn_Click(sender As Object, e As EventArgs) Handles grabbtn.Click
        If dtable.Rows.Count > 0 Then
            con.Open()
            Dim transaccion As SqlTransaction = con.BeginTransaction
            Dim bulk As New SqlBulkCopy(con, SqlBulkCopyOptions.Default, transaccion)
            Try
                bulk.DestinationTableName = "DETALLE_ENTRADA"
                bulk.WriteToServer(dtable)
                transaccion.Commit()
                con.Close()
            Catch ex As Exception
                transaccion.Rollback()
                con.Close()
            End Try


            cont = identxt.Text + "," + fechtxt.Text
            Dim sqlins As String = "INSERT INTO ENTRADA VALUES('" + identxt.Text + "',@fecha,'" + Login.codus + "','" + NEntrada.idprov + "','" + subttxt.Text + "','" + igvtxt.Text + "','" + totaltxt.Text + "',@QR)"
            Dim cmd As New SqlCommand(sqlins, con)
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = Now
            cmd.Parameters.Add("@QR", SqlDbType.Image).Value = ImagenAByte(generarqr(cont))

            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            MsgBox("Registro exitoso")

            dtable.Rows.Clear()
            actualizarcostos(0)
        Else
            MsgBox("Seleccione los productos que van a ingresar")
        End If

    End Sub



    Public Sub actualizarcostos(subt As Double)
        Dim igv As Double
        Dim total As Double
        igv = subt * 18 / 100
        total = subt + igv

        subttxt.Text = CStr(subt)
        igvtxt.Text = CStr(igv)
        totaltxt.Text = CStr(total)
    End Sub

    Private Sub impbtn_Click(sender As Object, e As EventArgs) Handles impbtn.Click
        pdfEntrada(sfd, dtable, ImagenAByte(generarqr(cont)))
    End Sub
End Class