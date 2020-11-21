Imports System.Data.SqlClient

Public Class NEntrada
    Dim pro() As String
    Dim np As Integer
    Dim nent As Integer
    Public id As String
    Public prov As String
    Public idprov As String
    Private Sub NEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        con.Close()
        Dim sqlce As String = "SELECT COUNT(*) FROM ENTRADA"
        Dim cmd2 As New SqlCommand(sqlce, con)
        Dim rs As SqlDataReader


        con.Open()
        rs = cmd2.ExecuteReader
        rs.Read()
        nent = CInt(rs(0))
        con.Close()

        fechaenttxt.Text = DateTime.Now.ToString("d")
        ususttxt.Text = Login.user

        Dim sqlc As String = "SELECT * FROM PROVEEDOR"
        Dim cmd As New SqlCommand(sqlc, con)

        Dim sqlcc As String = "SELECT COUNT(*) FROM PROVEEDOR"
        Dim cmd3 As New SqlCommand(sqlcc, con)
        Dim rs2 As SqlDataReader
        Dim npr As Integer

        con.Open()
        rs2 = cmd3.ExecuteReader
        rs2.Read()
        npr = CInt(rs2(0))
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

    Private Sub ingentbtn_Click(sender As Object, e As EventArgs) Handles ingentbtn.Click
        Select Case (Len(Str(nent)) - 1)
            Case 1 : identtxt.Text = "E" + "000" + Trim(Str(Int(nent + 1)))
            Case 2 : identtxt.Text = "E" + "00" + Trim(Str(Int(nent + 1)))
            Case 3 : identtxt.Text = "E" + "0" + Trim(Str(Int(nent + 1)))
            Case 4 : identtxt.Text = "E" + Trim(Str(Int(nent + 1)))
        End Select
        id = identtxt.Text
        prov = provcb.Text
        idprov = pro(provcb.SelectedIndex + 1)
        INICIO.AbrirHijo(Entrada)
        Me.Hide()

    End Sub
End Class