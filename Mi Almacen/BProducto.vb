Imports System.Data.SqlClient

Public Class BProducto
    Private Sub BProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        con.Close()
        MostrarProducto(filtxt.Text)
        If prodlb.Items.Count > 0 Then
            prodlb.SelectedIndex = 0
        End If
    End Sub
    Public Sub MostrarProducto(ByVal filtro As String)
        Dim sql As String
        Dim sql2 As String
        If filtro = "" Then
            sql = "SELECT * FROM PRODUCTOS"
            sql2 = "SELECT COUNT(*) FROM PRODUCTOS"
        Else
            sql = "SELECT * FROM PRODUCTOS WHERE PRODUCTOS.NOM_PRODUCTO LIKE '" + filtro + "%'"
            sql2 = "SELECT COUNT(*) FROM PRODUCTOS WHERE PRODUCTOS.NOM_PRODUCTO LIKE '" + filtro + "%'"
        End If


        con.Open()
        Dim producto As String

        Dim cmd As New SqlCommand(sql, con)


        Dim cmd2 As New SqlCommand(sql2, con)
        Dim rs As SqlDataReader
        Dim npro, i As Integer

        rs = cmd2.ExecuteReader
        rs.Read()
        npro = CInt(rs(0))
        desconectar()
        If npro > 0 Then
            Try
                prodlb.Items.Clear()
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "PRODUCTOS")

                For i = 0 To npro - 1
                    producto = ds.Tables("PRODUCTOS").Rows(i)("NOM_PRODUCTO").ToString()
                    prodlb.Items.Add(producto)
                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No hay coincidencias")
        End If

    End Sub

    Private Sub prodlb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prodlb.SelectedIndexChanged
        If prodlb.SelectedIndex = -1 Then
            MsgBox("Seleccione el producto que desea mostrar de la lista")
            Exit Sub
        ElseIf prodlb.SelectedIndex > -1 Then

            Dim sql As String = "SELECT * FROM PRODUCTOS WHERE PRODUCTOS.NOM_PRODUCTO='" + prodlb.SelectedItem.ToString + "'"
            Dim cmd As New SqlCommand(sql, con)

            Try
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "PRODUCTOS")

                codprotxt.Text = ds.Tables("PRODUCTOS").Rows(0)("ID_PRODUCTO").ToString()
                nomprotxt.Text = ds.Tables("PRODUCTOS").Rows(0)("NOM_PRODUCTO").ToString()
                marcaprotxt.Text = ds.Tables("PRODUCTOS").Rows(0)("MARCA_PRODUCTO").ToString()
                modeloprotxt.Text = ds.Tables("PRODUCTOS").Rows(0)("MODELO_PRODUCTO").ToString()

                exprotxt.Text = ds.Tables("PRODUCTOS").Rows(0)("EX_PRODUCTO").ToString()
                puprotxt.Text = ds.Tables("PRODUCTOS").Rows(0)("PU_PRODUCTO").ToString()
                imgpropb.Image = ByteAImagen(ds.Tables("PRODUCTOS").Rows(0)("IMAGEN_PRODUCTO"))


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub canttxt_TextChanged(sender As Object, e As EventArgs) Handles canttxt.TextChanged
        If canttxt.Text <> "" And puprotxt.Text <> "" Then
            totaltxt.Text = Convert.ToString(CDbl(puprotxt.Text) * CDbl(canttxt.Text))
        Else
            totaltxt.Text = "0.00"
        End If
    End Sub

    Private Sub filtxt_TextChanged(sender As Object, e As EventArgs) Handles filtxt.TextChanged
        MostrarProducto(filtxt.Text)
        If prodlb.Items.Count > 0 Then
            prodlb.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sqlins As String = "INSERT INTO DETALLE_ENTRADA VALUES('" + Entrada.identxt.Text + "','" + codprotxt.Text + "','" + canttxt.Text + "','" + totaltxt.Text + "')"
        Dim cmd As New SqlCommand(sqlins, con)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

        Dim sql As String = "SELECT DETALLE_ENTRADA.ID_PRODUCTO,PRODUCTOS.NOM_PRODUCTO, PRODUCTOS.MARCA_PRODUCTO, PRODUCTOS.MODELO_PRODUCTO, PRODUCTOS.PU_PRODUCTO,DETALLE_ENTRADA.CANTIDAD,DETALLE_ENTRADA.TOTAL FROM DETALLE_ENTRADA
														INNER JOIN PRODUCTOS ON DETALLE_ENTRADA.ID_PRODUCTO=PRODUCTOS.ID_PRODUCTO WHERE DETALLE_ENTRADA.ID_ENTRADA='" + Entrada.identxt.Text + "'"
        Dim cmd2 As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd2)
            Dim dt As New DataTable
            da.Fill(dt)

            Entrada.detalledgv.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class