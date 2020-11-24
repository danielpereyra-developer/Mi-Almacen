Imports System.Data.SqlClient

Public Class LUsuarios

    Private Sub LUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarUsuarios("")
        userlb.SelectedIndex = 0
    End Sub

    Public Sub MostrarUsuarios(ByVal filtro As String)
        con.Open()
        Dim usuario As String
        Dim sql As String
        Dim sql2 As String
        If filtro = "" Then
            sql = "SELECT * FROM USUARIOS"
            sql2 = "SELECT COUNT(*) FROM USUARIOS"
        Else
            sql = "SELECT * FROM PRODUCTOS WHERE USUARIOS.NOMBRE LIKE '" + filtro + "%'"
            sql2 = "SELECT COUNT(*) FROM PRODUCTOS WHERE USUARIOS.NOMBRE LIKE '" + filtro + "%'"
        End If

        Dim cmd As New SqlCommand(sql, con)

        Dim cmd2 As New SqlCommand(sql2, con)
        Dim rs As SqlDataReader
        Dim npro, i As Integer

        rs = cmd2.ExecuteReader
        rs.Read()
        npro = CInt(rs(0))
        desconectar()

        Try
            userlb.Items.Clear()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "USUARIOS")

            For i = 0 To npro - 1
                usuario = ds.Tables("USUARIOS").Rows(i)("NOMBRE").ToString()
                userlb.Items.Add(usuario)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub userlb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userlb.SelectedIndexChanged
        If userlb.SelectedIndex = -1 Then
            MsgBox("Seleccione el usuario que desea mostrar de la lista")
            Exit Sub
        ElseIf userlb.SelectedIndex > -1 Then

            Dim sql As String = "SELECT * FROM USUARIOS WHERE USUARIOS.NOMBRE='" + userlb.SelectedItem.ToString + "'"
            Dim cmd As New SqlCommand(sql, con)

            Try
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "USUARIOS")

                cargtxt.Text = ds.Tables("USUARIOS").Rows(0)("CARGO").ToString()
                nomtxt.Text = ds.Tables("USUARIOS").Rows(0)("PNOM_USUARIO").ToString()
                apetxt.Text = ds.Tables("USUARIOS").Rows(0)("APELLIDOS_US").ToString()
                teltxt.Text = ds.Tables("USUARIOS").Rows(0)("TELEFONO").ToString()

                dnitxt.Text = ds.Tables("USUARIOS").Rows(0)("DNI_USUARIO").ToString()
                edadtxt.Text = ds.Tables("USUARIOS").Rows(0)("EDAD").ToString()
                ustxt.Text = ds.Tables("USUARIOS").Rows(0)("NOMBRE").ToString()
                imguspb.Image = ByteAImagen(ds.Tables("USUARIOS").Rows(0)("FOTO"))

            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub filtxt_TextChanged(sender As Object, e As EventArgs) Handles filtxt.TextChanged
        MostrarUsuarios(filtxt.Text)
    End Sub
End Class