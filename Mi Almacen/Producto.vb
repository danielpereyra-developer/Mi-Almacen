Imports System.Data.SqlClient

Public Class Producto
    Dim nomimg As String
    Dim cat() As String
    Dim subcat() As String
    Dim nc, nsc As Integer
    Dim cantp As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If catpcb.Text = "" And subcatpcb.Text = "" Then
            MsgBox("Seleccione la catehoria y sub categoria para generar el codigo")
        Else

            codtxt.Text = StrReverse(Mid(cat(catpcb.SelectedIndex + 1), cat(catpcb.SelectedIndex + 1).Length - 1, 2)) & StrReverse(Mid(subcat(subcatpcb.SelectedIndex + 1), subcat(subcatpcb.SelectedIndex + 1).Length - 1, 2))

            Dim sql2 As String = "SELECT COUNT(*) FROM PRODUCTOS"
            Dim cmd As New SqlCommand(sql2, con)
            Dim rs As SqlDataReader

            con.Open()
            rs = cmd.ExecuteReader
            rs.Read()
            cantp = CInt(rs(0))
            con.Close()

            Select Case (Len(Str(cantp)) - 1)
                Case 1 : codtxt.Text = codtxt.Text + "000" + Trim(Str(Int(cantp + 1)))
                Case 2 : codtxt.Text = codtxt.Text + "00" + Trim(Str(Int(cantp + 1)))
                Case 3 : codtxt.Text = codtxt.Text + "0" + Trim(Str(Int(cantp + 1)))
                Case 4 : codtxt.Text = codtxt.Text + Trim(Str(Int(cantp + 1)))
            End Select

            Try
                Dim alto As Single = 0
                Dim base As String
                alto = Convert.ToSingle(codbarpb.Height)
                Dim bm As Bitmap = Nothing
                bm = codigo128("A" & codtxt.Text & "D", False, alto)
                base = BitmapToBase64(bm)
                If Not IsNothing(bm) Then
                    codbarpb.Image = Base64ToImage(base)
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If

    End Sub

    Private Sub exabtn_Click(sender As Object, e As EventArgs) Handles exabtn.Click
        Archivos.ShowDialog()
        nomimg = Archivos.FileName
        If nomimg <> "" Then
            imagenpb.Image = Image.FromFile(nomimg)
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If codtxt.Text = "" Or nomptxt.Text = "" Or catpcb.Text = "" Or subcatpcb.Text = "" Or ubiccb.Text = "" Or cantmtxt.Text = "" Or exptxt.Text = "" Or puptxt.Text = "" Then
            MsgBox("LLene Todos los datos")
        ElseIf imagenpb.Image Is Nothing Then
            MsgBox("Ingrese una Imagen")
        ElseIf imagenpb.Image Is Nothing Then
            MsgBox("Ingrese una Imagen")
        Else

            Dim sqlinsr As String = "INSERT INTO PRODUCTOS VALUES('" + codtxt.Text + "','" + nomptxt.Text + "','" + marcaptxt.Text + "','" + modeloptxt.Text + "','" + cat(catpcb.SelectedIndex + 1) + "','" + subcat(subcatpcb.SelectedIndex + 1) + "','" + ubiccb.Text + "','" + cantmtxt.Text + "','" + exptxt.Text + "','" + puptxt.Text + "',@imagen,@codbar)"
            Dim cmd As New SqlCommand(sqlinsr, con)
            cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = ImagenAByte(imagenpb.Image)
            cmd.Parameters.Add("@codbar", SqlDbType.Image).Value = ImagenAByte(codbarpb.Image)
            Try
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro Guardado Exitosamente")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End If

        Inventario.MostrarProductos()
        Me.Hide()
    End Sub

    Private Sub catpcb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles catpcb.SelectedIndexChanged

        LlenarComboSubCat()

        ubiccb.Items.Add("Sector" + Mid(catpcb.Text, 1, 1) + " --->  Estante 1")
        ubiccb.Items.Add("Sector" + Mid(catpcb.Text, 1, 1) + " --->  Estante 2")
        ubiccb.Items.Add("Sector" + Mid(catpcb.Text, 1, 1) + " --->  Estante 3")
        ubiccb.Items.Add("Sector" + Mid(catpcb.Text, 1, 1) + " --->  Estante 4")
        ubiccb.Items.Add("Sector" + Mid(catpcb.Text, 1, 1) + " --->  Estante 5")
        ubiccb.Items.Add("Sector" + Mid(catpcb.Text, 1, 1) + " --->  Estante 6")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Categoria.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        SUBCATEGORIA.Show()
    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LLenarCombosCat()
    End Sub
    Public Sub LLenarCombosCat()
        conectar()
        'combo categoria
        Dim sqlc As String = "SELECT * FROM CATEGORIA"
        Dim cmd As New SqlCommand(sqlc, con)

        Dim sqlcc As String = "SELECT COUNT(*) FROM CATEGORIA"
        Dim cmd2 As New SqlCommand(sqlcc, con)
        Dim rs As SqlDataReader
        Dim ncat, i As Integer


        rs = cmd2.ExecuteReader
        rs.Read()
        ncat = CInt(rs(0))
        con.Close()

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "CATEGORIA")

            For i = 0 To ncat - 1
                nc = nc + 1
                ReDim Preserve cat(0 To nc)
                cat(nc) = ds.Tables("CATEGORIA").Rows(i)("ID_CATEGORIA").ToString()

                catpcb.Items.Add(ds.Tables("CATEGORIA").Rows(i)("NOM_CATEGORIA").ToString())
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub LlenarComboSubCat()
        If catpcb.SelectedIndex > -1 Then
            Dim sqlsc As String = "SELECT * FROM SUBCATEGORIA WHERE SUBCATEGORIA.ID_CATEGORIA='" + cat(catpcb.SelectedIndex + 1) + "'"
            Dim cmdsc As New SqlCommand(sqlsc, con)

            Dim sqlcsc As String = "SELECT COUNT(*) FROM SUBCATEGORIA WHERE SUBCATEGORIA.ID_CATEGORIA='" + cat(catpcb.SelectedIndex + 1) + "'"
            Dim cmdsc2 As New SqlCommand(sqlcsc, con)
            Dim rs2 As SqlDataReader
            Dim nscat, j As Integer
            j = 0
            con.Open()
            rs2 = cmdsc2.ExecuteReader
            rs2.Read()
            nscat = CInt(rs2(0))
            con.Close()
            subcatpcb.Items.Clear()

            Try
                Dim da As New SqlDataAdapter(cmdsc)
                Dim ds As New DataSet
                da.Fill(ds, "SUBCATEGORIA")

                For j = 0 To nscat - 1
                    nsc = nsc + 1
                    ReDim Preserve subcat(0 To nsc)
                    subcat(nsc) = ds.Tables("SUBCATEGORIA").Rows(j)("ID_SUB_CATEGORIA").ToString()
                    subcatpcb.Items.Add(ds.Tables("SUBCATEGORIA").Rows(j)("NOM_SUB_CATEGORIA").ToString())
                Next

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class