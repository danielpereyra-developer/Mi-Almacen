Imports System.Data.SqlClient

Public Class SUBCATEGORIA
    Dim cantscat As Integer
    Dim cat() As String
    Dim nc As Integer
    Private Sub SUBCATEGORIA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        con.Close()
        Dim sql2 As String = "SELECT COUNT(*) FROM SUBCATEGORIA"
        Dim cmd As New SqlCommand(sql2, con)
        Dim rs As SqlDataReader

        con.Open()
        rs = cmd.ExecuteReader
        rs.Read()
        cantscat = CInt(rs(0))
        con.Close()

        Select Case (Len(Str(cantscat)) - 1)
            Case 1 : codscattxt.Text = "SCAT000" + Trim(Str(Int(cantscat + 1)))
            Case 2 : codscattxt.Text = "SCAT00" + Trim(Str(Int(cantscat + 1)))
            Case 3 : codscattxt.Text = "SCAT0" + Trim(Str(Int(cantscat + 1)))
            Case 4 : codscattxt.Text = "SCAT" + Trim(Str(Int(cantscat + 1)))
        End Select

        Dim sqlc As String = "SELECT * FROM CATEGORIA"
        Dim cmdc As New SqlCommand(sqlc, con)

        Dim sqlcc As String = "SELECT COUNT(*) FROM CATEGORIA"
        Dim cmd2 As New SqlCommand(sqlcc, con)
        Dim rs2 As SqlDataReader
        Dim ncat, i As Integer

        con.Open()
        rs2 = cmd2.ExecuteReader
        rs2.Read()
        ncat = CInt(rs2(0))
        con.Close()

        Try
            Dim da As New SqlDataAdapter(cmdc)
            Dim ds As New DataSet
            da.Fill(ds, "CATEGORIA")

            For i = 0 To ncat - 1
                nc = nc + 1
                ReDim Preserve cat(0 To nc)
                cat(nc) = ds.Tables("CATEGORIA").Rows(i)("ID_CATEGORIA").ToString()

                catrcb.Items.Add(ds.Tables("CATEGORIA").Rows(i)("NOM_CATEGORIA").ToString())
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlinsr As String = "INSERT INTO SUBCATEGORIA VALUES('" + codscattxt.Text + "','" + cat(catrcb.SelectedIndex + 1) + "','" + nomscattxt.Text + "')"
        Dim cmd As New SqlCommand(sqlinsr, con)
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Registro Guardado Exitosamente")
            cantscat = cantscat + 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

        Producto.LLenarCombosCat()
        Me.Hide()
    End Sub
End Class