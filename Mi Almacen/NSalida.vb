Imports System.Data.SqlClient

Public Class NSalida
    Dim nsal As Integer
    Public id As String
    Public client As String
    Private Sub NSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        con.Close()
        Dim sqlce As String = "SELECT COUNT(*) FROM SALIDA"
        Dim cmd2 As New SqlCommand(sqlce, con)
        Dim rs As SqlDataReader


        con.Open()
        rs = cmd2.ExecuteReader
        rs.Read()
        nsal = CInt(rs(0))
        con.Close()

        fechasaltxt.Text = DateTime.Now.ToString("d")
        ususttxt.Text = Login.user

    End Sub

    Private Sub ingsalbtn_Click(sender As Object, e As EventArgs) Handles ingsalbtn.Click
        Select Case (Len(Str(nsal)) - 1)
            Case 1 : idsaltxt.Text = "S" + "000" + Trim(Str(Int(nsal + 1)))
            Case 2 : idsaltxt.Text = "S" + "00" + Trim(Str(Int(nsal + 1)))
            Case 3 : idsaltxt.Text = "S" + "0" + Trim(Str(Int(nsal + 1)))
            Case 4 : idsaltxt.Text = "S " + Trim(Str(Int(nsal + 1)))
        End Select
        id = idsaltxt.Text
        client = clientetxt.Text

        INICIO.AbrirHijo(Salida)
        Me.Hide()
    End Sub

    Private Sub cancbtn_Click(sender As Object, e As EventArgs) Handles cancbtn.Click
        Me.Close()
    End Sub
End Class