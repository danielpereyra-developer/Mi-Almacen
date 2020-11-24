Imports System.Data.SqlClient

Public Class BProducto
    Public subtotal As Double
    Public ent As Boolean = False
    Private Sub BProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar()
        con.Close()
        MostrarProducto(filtxt.Text)
        If prodlb.Items.Count > 0 Then
            prodlb.SelectedIndex = 0
        End If

        filtxt.ForeColor = Color.Gray
        filtxt.Text = "Buscar por Nombre de Producto"
        canttxt.Select()
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
        If canttxt.Text <> "" And puprotxt.Text <> "" Or canttxt.Text = "0" Then
            If ent = False Then
                If CInt(canttxt.Text) >= CInt(exprotxt.Text) Then
                    MsgBox("La cantidad no puede igualar o exceder al numero de existencias")
                    canttxt.Text = ""
                Else
                    totaltxt.Text = Convert.ToString(CDbl(puprotxt.Text) * CDbl(canttxt.Text))
                End If
            Else
                totaltxt.Text = Convert.ToString(CDbl(puprotxt.Text) * CDbl(canttxt.Text))
            End If
        Else
            totaltxt.Text = "0.00"
        End If
    End Sub

    Private Sub filtxt_TextChanged(sender As Object, e As EventArgs) Handles filtxt.TextChanged
        If filtxt.Text <> "Buscar por Nombre de Producto" Then
            MostrarProducto(filtxt.Text)
        Else
            MostrarProducto("")
        End If
        If prodlb.Items.Count > 0 Then
            prodlb.SelectedIndex = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        gendetalle(ent)

    End Sub

    Public Sub gendetalle(ban As Boolean)
        If ban = True Then

            Dim row As DataRow

            row = Entrada.dtable.NewRow

            row(Entrada.dcolum1) = codprotxt.Text
            row(Entrada.dcolum2) = nomprotxt.Text
            row(Entrada.dcolum3) = marcaprotxt.Text
            row(Entrada.dcolum4) = modeloprotxt.Text
            row(Entrada.dcolum5) = puprotxt.Text
            row(Entrada.dcolum6) = canttxt.Text
            row(Entrada.dcolum7) = totaltxt.Text

            Entrada.dtable.Rows.Add(row)
            Entrada.dtable.AcceptChanges()
            Entrada.refrescardetalle()

            subtotal = subtotal + CDbl(totaltxt.Text)

            Entrada.actualizarcostos(subtotal)

            If MessageBox.Show("¿Desea Añadir mas Productos?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Me.Close()
            Else
                MostrarProducto("")
                filtxt.ForeColor = Color.Gray
                filtxt.Text = "Buscar por Nombre de Producto"
                If prodlb.Items.Count > 0 Then
                    prodlb.SelectedIndex = 0
                End If
            End If
        Else

            Dim row As DataRow

            row = Salida.dtable.NewRow

            row(Salida.dcolum1) = codprotxt.Text
            row(Salida.dcolum2) = nomprotxt.Text
            row(Salida.dcolum3) = marcaprotxt.Text
            row(Salida.dcolum4) = modeloprotxt.Text
            row(Salida.dcolum5) = puprotxt.Text
            row(Salida.dcolum6) = canttxt.Text
            row(Salida.dcolum7) = totaltxt.Text

            Salida.dtable.Rows.Add(row)
            Salida.dtable.AcceptChanges()
            Salida.refrescardetalle()

            subtotal = subtotal + CDbl(totaltxt.Text)

            Salida.actualizarcostos(subtotal)

            If MessageBox.Show("¿Desea Añadir mas Productos?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                Me.Close()
            Else
                MostrarProducto("")
                filtxt.ForeColor = Color.Gray
                filtxt.Text = "Buscar por Nombre de Producto"
                If prodlb.Items.Count > 0 Then
                    prodlb.SelectedIndex = 0
                End If
            End If


        End If
    End Sub

    Private Sub filtxt_GotFocus(sender As Object, e As EventArgs) Handles filtxt.GotFocus
        If filtxt.Text = "Buscar por Nombre de Producto" Then
            filtxt.ForeColor = Color.Black
            filtxt.Text = ""
        End If
    End Sub

    Private Sub filtxt_LostFocus(sender As Object, e As EventArgs) Handles filtxt.LostFocus
        If filtxt.Text = Nothing Then
            filtxt.ForeColor = Color.Gray
            filtxt.Text = "Buscar por Nombre de Producto"
        End If
    End Sub
End Class