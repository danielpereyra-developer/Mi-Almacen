Imports System.Data.SqlClient

Public Class ModificarP
    Dim nomimg As String
    Dim cat() As String
    Dim subcat() As String
    Dim nc, nsc As Integer
    Private Sub ModificarP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LLenarCombosCat()
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
        Else
            Dim sqlupd As String = "UPDATE PRODUCTOS SET NOM_PRODUCTO='" + nomptxt.Text + "',MARCA_PRODUCTO='" + marcaptxt.Text + "',MODELO_PRODUCTO='" + modeloptxt.Text + "',ID_CATEGORIA='" + cat(catpcb.SelectedIndex + 1) + "',ID_SUB_CATEGORIA='" + subcat(subcatpcb.SelectedIndex + 1) + "',UBICACION_PRODUCTO='" + ubiccb.Text + "',CM_PRODUCTO='" + cantmtxt.Text + "',EX_PRODUCTO='" + exptxt.Text + "',PU_PRODUCTO='" + puptxt.Text + "',IMAGEN_PRODUCTO=@imagen WHERE PRODUCTOS.ID_PRODUCTO='" + codtxt.Text + "'"
            Dim cmd As New SqlCommand(sqlupd, con)

            cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = ImagenAByte(imagenpb.Image)
            Try
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro Actualizado Exitosamente")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()
        End If
        Me.Hide()
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