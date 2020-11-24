Imports System.Data.SqlClient

Public Class USUARIOS
    Dim idus As String
    Dim nomimg As String

    Private Sub USUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnomtxt.ForeColor = Color.Gray
        pnomtxt.Text = "Primer Nombre"
        apetxt.ForeColor = Color.Gray
        apetxt.Text = "Apellidos"
        dnitxt.ForeColor = Color.Gray
        dnitxt.Text = "DNI"
        edadtxt.ForeColor = Color.Gray
        edadtxt.Text = "EDAD"
        nomustxt.ForeColor = Color.Gray
        nomustxt.Text = "Nombre de Usuario"
        passustxt.ForeColor = Color.Gray
        passustxt.Text = "Contraseña"

    End Sub

    Private Sub pnomtxt_GotFocus(sender As Object, e As EventArgs) Handles pnomtxt.GotFocus
        If pnomtxt.Text = "Primer Nombre" Then
            pnomtxt.ForeColor = Color.Black
            pnomtxt.Text = ""
        End If
    End Sub

    Private Sub pnomtxt_LostFocus(sender As Object, e As EventArgs) Handles pnomtxt.LostFocus
        If pnomtxt.Text = Nothing Then
            pnomtxt.ForeColor = Color.Gray
            pnomtxt.Text = "Primer Nombre"
        End If
    End Sub

    Private Sub apetxt_GotFocus(sender As Object, e As EventArgs) Handles apetxt.GotFocus
        If apetxt.Text = "Apellidos" Then
            apetxt.ForeColor = Color.Black
            apetxt.Text = ""
        End If
    End Sub

    Private Sub apetxt_LostFocus(sender As Object, e As EventArgs) Handles apetxt.LostFocus
        If apetxt.Text = Nothing Then
            apetxt.ForeColor = Color.Gray
            apetxt.Text = "Apellidos"
        End If
    End Sub

    Private Sub dnitxt_GotFocus(sender As Object, e As EventArgs) Handles dnitxt.GotFocus
        If dnitxt.Text = "DNI" Then
            dnitxt.ForeColor = Color.Black
            dnitxt.Text = ""
        End If
    End Sub

    Private Sub dnitxt_LostFocus(sender As Object, e As EventArgs) Handles dnitxt.LostFocus
        If dnitxt.Text = Nothing Then
            dnitxt.ForeColor = Color.Gray
            dnitxt.Text = "DNI"
        End If
    End Sub

    Private Sub edadtxt_GotFocus(sender As Object, e As EventArgs) Handles edadtxt.GotFocus
        If edadtxt.Text = "EDAD" Then
            edadtxt.ForeColor = Color.Black
            edadtxt.Text = ""
        End If
    End Sub

    Private Sub edadtxt_LostFocus(sender As Object, e As EventArgs) Handles edadtxt.LostFocus
        If edadtxt.Text = Nothing Then
            edadtxt.ForeColor = Color.Gray
            edadtxt.Text = "EDAD"
        End If
    End Sub

    Private Sub nomustxt_GotFocus(sender As Object, e As EventArgs) Handles nomustxt.GotFocus
        If nomustxt.Text = "Nombre de Usuario" Then
            nomustxt.ForeColor = Color.Black
            nomustxt.Text = ""
        End If
    End Sub

    Private Sub nomustxt_LostFocus(sender As Object, e As EventArgs) Handles nomustxt.LostFocus
        If nomustxt.Text = Nothing Then
            nomustxt.ForeColor = Color.Gray
            nomustxt.Text = "Nombre de Usuario"
        End If
    End Sub

    Private Sub passustxt_GotFocus(sender As Object, e As EventArgs) Handles passustxt.GotFocus
        If passustxt.Text = "Contraseña" Then
            passustxt.ForeColor = Color.Black
            passustxt.Text = ""
        End If
    End Sub

    Private Sub passustxt_LostFocus(sender As Object, e As EventArgs) Handles passustxt.LostFocus
        If passustxt.Text = Nothing Then
            passustxt.ForeColor = Color.Gray
            passustxt.Text = "Contraseña"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If nomustxt.Text <> "" And nomustxt.Text <> "Nombre de Usuario" Then
            Dim pas As String
            pas = Encriptar(nomustxt.Text)
            passustxt.Text = Mid(pas, 1, pas.Length - 2)
        Else
            MsgBox("Genere el nombre de usuario")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If pnomtxt.Text <> "" And apetxt.Text <> "" And celtxt.Text <> "" And dnitxt.Text <> "" And edadtxt.Text <> "" And tccb.Text <> "" Then

            If tccb.SelectedIndex = 0 Then
                idus = "JA" & Mid(dnitxt.Text, 6, 3) & edadtxt.Text
            ElseIf tccb.SelectedIndex = 1 Then
                idus = "TB" & Mid(dnitxt.Text, 6, 3) & edadtxt.Text
            End If

            nomustxt.Text = pnomtxt.Text & Mid(apetxt.Text, 1, 1) & Mid(dnitxt.Text, 7, 2) & edadtxt.Text

        Else
            MsgBox("LLene todos los datos anteriores")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Archivos.ShowDialog()
        nomimg = Archivos.FileName
        If nomimg <> "" Then
            imgpb.Image = Image.FromFile(nomimg)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If pnomtxt.Text <> "" And apetxt.Text <> "" And celtxt.Text <> "" And dnitxt.Text <> "" And edadtxt.Text <> "" And tccb.Text <> "" And nomustxt.Text <> "" And passustxt.Text <> "" And imgpb.Image IsNot Nothing Then

            Dim sqlinsr As String = "INSERT INTO USUARIOS VALUES('" + idus + "','" + pnomtxt.Text + "','" + apetxt.Text + "','" + celtxt.Text + "','" + dnitxt.Text + "','" + edadtxt.Text + "','" + tccb.Text + "','" + nomustxt.Text + "','" + passustxt.Text + "',@imagen)"
            Dim cmd As New SqlCommand(sqlinsr, con)
            cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = ImagenAByte(imgpb.Image)
            Try
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("Registro Guardado Exitosamente")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()

        Else
            MsgBox("Llene todos los campos para registrar el usuario")
        End If


    End Sub
End Class