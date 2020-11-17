Imports System.Data.SqlClient

Public Class Categoria
    Dim cantcat As Integer
    Private Sub Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        con.Close()
        Dim sql2 As String = "SELECT COUNT(*) FROM CATEGORIA"
        Dim cmd As New SqlCommand(sql2, con)
        Dim rs As SqlDataReader

        con.Open()
        rs = cmd.ExecuteReader
        rs.Read()
        cantcat = CInt(rs(0))
        con.Close()

        Select Case (Len(Str(cantcat)) - 1)
            Case 1 : codcattxt.Text = "CAT0000" + Trim(Str(Int(cantcat + 1)))
            Case 2 : codcattxt.Text = "CAT000" + Trim(Str(Int(cantcat + 1)))
            Case 3 : codcattxt.Text = "CAT00" + Trim(Str(Int(cantcat + 1)))
            Case 4 : codcattxt.Text = "CAT0" + Trim(Str(Int(cantcat + 1)))
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlinsr As String = "INSERT INTO CATEGORIA VALUES('" + codcattxt.Text + "','" + nomcattxt.Text + "')"
        Dim cmd As New SqlCommand(sqlinsr, con)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Registro Guardado Exitosamente")
            cantcat = cantcat + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        Producto.LLenarCombosCat()

        Me.Hide()

    End Sub
End Class