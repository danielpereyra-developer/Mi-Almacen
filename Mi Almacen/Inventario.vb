Imports System.Data.SqlClient

Public Class Inventario
    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        con.Close()
        MostrarProductos()
        If productoslb.Items.Count > 0 Then
            productoslb.SelectedIndex = 0
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        INICIO.AbrirHijo(New Producto)
    End Sub
    Public Sub MostrarProductos()
        con.Open()
        Dim producto As String
        Dim sql As String = "SELECT * FROM PRODUCTOS"
        Dim cmd As New SqlCommand(sql, con)

        Dim sql2 As String = "SELECT COUNT(*) FROM PRODUCTOS"
        Dim cmd2 As New SqlCommand(sql2, con)
        Dim rs As SqlDataReader
        Dim npro, i As Integer

        rs = cmd2.ExecuteReader
        rs.Read()
        npro = CInt(rs(0))
        desconectar()

        Try
            productoslb.Items.Clear()
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "PRODUCTOS")

            For i = 0 To npro - 1
                producto = ds.Tables("PRODUCTOS").Rows(i)("NOM_PRODUCTO").ToString()
                productoslb.Items.Add(producto)
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MostrarProductos()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con.Open()
        Dim producto As String
        Dim sql As String = "SELECT * FROM PRODUCTOS WHERE PRODUCTOS.EX_PRODUCTO<=10"
        Dim cmd As New SqlCommand(sql, con)

        Dim sql2 As String = "SELECT COUNT(*) FROM PRODUCTOS WHERE PRODUCTOS.EX_PRODUCTO<=10"
        Dim cmd2 As New SqlCommand(sql2, con)
        Dim rs As SqlDataReader
        Dim npro, i As Integer

        rs = cmd2.ExecuteReader
        rs.Read()
        npro = CInt(rs(0))
        desconectar()

        If npro > 0 Then
            Try
                productoslb.Items.Clear()
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "PRODUCTOS")

                For i = 0 To npro - 1
                    producto = ds.Tables("PRODUCTOS").Rows(i)("NOM_PRODUCTO").ToString()
                    productoslb.Items.Add(producto)
                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No hay productos proximos ha agotarse")
            MostrarProductos()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Open()
        Dim producto As String
        Dim sql As String = "SELECT * FROM PRODUCTOS WHERE PRODUCTOS.NOM_PRODUCTO LIKE '" + nomptxt.Text + "%'"
        Dim cmd As New SqlCommand(sql, con)

        Dim sql2 As String = "SELECT COUNT(*) FROM PRODUCTOS WHERE PRODUCTOS.NOM_PRODUCTO LIKE '" + nomptxt.Text + "%'"
        Dim cmd2 As New SqlCommand(sql2, con)
        Dim rs As SqlDataReader
        Dim npro, i As Integer

        rs = cmd2.ExecuteReader
        rs.Read()
        npro = CInt(rs(0))
        desconectar()

        If npro > 0 Then
            Try
                productoslb.Items.Clear()
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "PRODUCTOS")

                For i = 0 To npro - 1
                    producto = ds.Tables("PRODUCTOS").Rows(i)("NOM_PRODUCTO").ToString()
                    productoslb.Items.Add(producto)
                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("No se ha encontrado el producto")
            MostrarProductos()
        End If
    End Sub

    Private Sub productoslb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles productoslb.SelectedIndexChanged
        If productoslb.SelectedIndex = -1 Then
            MsgBox("Seleccione el producto que desea mostrar de la lista")
            Exit Sub
        ElseIf productoslb.SelectedIndex > -1 Then
            Dim cat, scat As String
            Dim sql As String = "SELECT * FROM PRODUCTOS WHERE PRODUCTOS.NOM_PRODUCTO='" + productoslb.SelectedItem.ToString + "'"
            Dim cmd As New SqlCommand(sql, con)

            Try
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "PRODUCTOS")

                codprtxt.Text = ds.Tables("PRODUCTOS").Rows(0)("ID_PRODUCTO").ToString()
                nomprtxt.Text = ds.Tables("PRODUCTOS").Rows(0)("NOM_PRODUCTO").ToString()
                marcaprtxt.Text = ds.Tables("PRODUCTOS").Rows(0)("MARCA_PRODUCTO").ToString()
                modeloprtxt.Text = ds.Tables("PRODUCTOS").Rows(0)("MODELO_PRODUCTO").ToString()

                cat = ds.Tables("PRODUCTOS").Rows(0)("ID_CATEGORIA").ToString()
                scat = ds.Tables("PRODUCTOS").Rows(0)("ID_SUB_CATEGORIA").ToString()

                Dim sql2 As String = "SELECT * FROM CATEGORIA WHERE CATEGORIA.ID_CATEGORIA='" + cat + "'"
                Dim cmd2 As New SqlCommand(sql2, con)
                Dim da2 As New SqlDataAdapter(cmd2)
                Dim ds2 As New DataSet
                da2.Fill(ds2, "CATEGORIA")
                catprtxt.Text = ds2.Tables("CATEGORIA").Rows(0)("NOM_CATEGORIA").ToString()

                Dim sql3 As String = "SELECT * FROM SUBCATEGORIA WHERE SUBCATEGORIA.ID_SUB_CATEGORIA='" + scat + "'"
                Dim cmd3 As New SqlCommand(sql3, con)
                Dim da3 As New SqlDataAdapter(cmd3)
                Dim ds3 As New DataSet
                da3.Fill(ds3, "SUBCATEGORIA")
                scatprtxt.Text = ds3.Tables("SUBCATEGORIA").Rows(0)("NOM_SUB_CATEGORIA").ToString()

                ubicprtxt.Text = ds.Tables("PRODUCTOS").Rows(0)("UBICACION_PRODUCTO").ToString()
                cmprtxt.Text = ds.Tables("PRODUCTOS").Rows(0)("CM_PRODUCTO").ToString()
                exprtxt.Text = ds.Tables("PRODUCTOS").Rows(0)("EX_PRODUCTO").ToString()
                puprtxt.Text = ds.Tables("PRODUCTOS").Rows(0)("PU_PRODUCTO").ToString()
                imgprpb.Image = ByteAImagen(ds.Tables("PRODUCTOS").Rows(0)("IMAGEN_PRODUCTO"))


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If productoslb.SelectedIndex = -1 Then
            MsgBox("Seleccione la nota que desea modificar de la lista")
            Exit Sub
        ElseIf productoslb.SelectedIndex > -1 Then
            ModificarP.codtxt.Text = codprtxt.Text
            ModificarP.nomptxt.Text = nomprtxt.Text
            ModificarP.marcaptxt.Text = marcaprtxt.Text
            ModificarP.modeloptxt.Text = modeloprtxt.Text
            ModificarP.ubiccb.Text = ubicprtxt.Text
            ModificarP.cantmtxt.Text = cmprtxt.Text
            ModificarP.exptxt.Text = exprtxt.Text
            ModificarP.puptxt.Text = puprtxt.Text
            ModificarP.imagenpb.Image = imgprpb.Image
            ModificarP.Show()
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If MessageBox.Show("¿Desea Eliminar este Producto?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim sqldel As String = "DELETE FROM PRODUCTOS WHERE PRODUCTOS.NOM_PRODUCTO='" + productoslb.SelectedItem.ToString + "'"
            Dim cmd As New SqlCommand(sqldel, con)
            Try
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("El Producto se ha Eliminado con Exito")
                MostrarProductos()
                productoslb.SelectedIndex = 0
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End If
        MostrarProductos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'MsgBox(dgv.Columns.Count)

        pdfInventario(sfd)


    End Sub


End Class