Imports System.Data.SqlClient

Public Class NEntrada
    Dim pro() As String
    Dim np As Integer
    Private Sub NEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        con.Close()
        Dim sqlce As String = "SELECT COUNT(*) FROM CATEGORIA"
        Dim cmd2 As New SqlCommand(sqlce, con)
        Dim rs As SqlDataReader
        Dim nent As Integer

        con.Open()
        rs = cmd2.ExecuteReader
        rs.Read()
        nent = CInt(rs(0))
        con.Close()

        identtxt.Text = CStr(nent + 1)
        fechaenttxt.Text = DateTime.Now.ToString("d")
        ususttxt.Text = Login.user

        Dim sqlc As String = "SELECT * FROM PROVEEDOR"
        Dim cmd As New SqlCommand(sqlc, con)

        Dim sqlcc As String = "SELECT COUNT(*) FROM PROVEEDOR"
        Dim cmd3 As New SqlCommand(sqlcc, con)
        Dim rs2 As SqlDataReader
        Dim npr As Integer

        con.Open()
        rs2 = cmd2.ExecuteReader
        rs2.Read()
        npr = CInt(rs(0))
        con.Close()

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "PROVEEDOR")

            For i = 0 To npr - 1
                np = np + 1
                ReDim Preserve pro(0 To np)
                pro(np) = ds.Tables("PROVEEDOR").Rows(i)("ID_PROVEEDOR").ToString()
                provcb.Items.Add(ds.Tables("PROVEEDOR").Rows(i)("NOM_EMPRESA").ToString())
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class