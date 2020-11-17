Imports System.Data.SqlClient

Public Class Proveedores
    Dim nomimg As String
    Private Sub nomptxt_GotFocus(sender As Object, e As EventArgs) Handles nomptxt.GotFocus
        If nomptxt.Text = "Nombre de la Empresa Proveedora" Then
            nomptxt.ForeColor = Color.Black
            nomptxt.Text = ""
        End If
    End Sub

    Private Sub nomptxt_LostFocus(sender As Object, e As EventArgs) Handles nomptxt.LostFocus
        If nomptxt.Text = Nothing Then
            nomptxt.ForeColor = Color.Gray
            nomptxt.Text = "Nombre de la Empresa Proveedora"
        End If
    End Sub

    Private Sub rucptxt_GotFocus(sender As Object, e As EventArgs) Handles rucptxt.GotFocus
        If rucptxt.Text = "RUC" Then
            rucptxt.ForeColor = Color.Black
            rucptxt.Text = ""
        End If
    End Sub

    Private Sub rucptxt_LostFocus(sender As Object, e As EventArgs) Handles rucptxt.LostFocus
        If rucptxt.Text = Nothing Then
            rucptxt.ForeColor = Color.Gray
            rucptxt.Text = "RUC"
        End If
    End Sub

    Private Sub dirptxt_GotFocus(sender As Object, e As EventArgs) Handles dirptxt.GotFocus
        If dirptxt.Text = "Direccion de la Empresa Proveedora" Then
            dirptxt.ForeColor = Color.Black
            dirptxt.Text = ""
        End If
    End Sub

    Private Sub dirptxt_LostFocus(sender As Object, e As EventArgs) Handles dirptxt.LostFocus
        If dirptxt.Text = Nothing Then
            dirptxt.ForeColor = Color.Gray
            dirptxt.Text = "Direccion de la Empresa Proveedora"
        End If
    End Sub

    Private Sub telptxt_GotFocus(sender As Object, e As EventArgs) Handles telptxt.GotFocus
        If telptxt.Text = "Telefono de la Empresa" Then
            telptxt.ForeColor = Color.Black
            telptxt.Text = ""
        End If
    End Sub

    Private Sub telptxt_LostFocus(sender As Object, e As EventArgs) Handles telptxt.LostFocus
        If telptxt.Text = Nothing Then
            telptxt.ForeColor = Color.Gray
            telptxt.Text = "Telefono de la Empresa"
        End If
    End Sub

    Private Sub peptxt_GotFocus(sender As Object, e As EventArgs) Handles peptxt.GotFocus
        If peptxt.Text = "Nombre de la Persona Encargada" Then
            peptxt.ForeColor = Color.Black
            peptxt.Text = ""
        End If
    End Sub

    Private Sub peptxt_LostFocus(sender As Object, e As EventArgs) Handles peptxt.LostFocus
        If peptxt.Text = Nothing Then
            peptxt.ForeColor = Color.Gray
            peptxt.Text = "Nombre de la Persona Encargada"
        End If
    End Sub

    Private Sub telpeptxt_GotFocus(sender As Object, e As EventArgs) Handles telpeptxt.GotFocus
        If telpeptxt.Text = "Telefono de la Persona Encargada" Then
            telpeptxt.ForeColor = Color.Black
            telpeptxt.Text = ""
        End If
    End Sub

    Private Sub telpeptxt_LostFocus(sender As Object, e As EventArgs) Handles telpeptxt.LostFocus
        If telpeptxt.Text = Nothing Then
            telpeptxt.ForeColor = Color.Gray
            telpeptxt.Text = "Telefono de la Persona Encargada"
        End If
    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nomptxt.ForeColor = Color.Gray
        nomptxt.Text = "Nombre de la Empresa Proveedora"
        rucptxt.ForeColor = Color.Gray
        rucptxt.Text = "RUC"
        dirptxt.ForeColor = Color.Gray
        dirptxt.Text = "Direccion de la Empresa Proveedora"
        telptxt.ForeColor = Color.Gray
        telptxt.Text = "Telefono de la Empresa"
        peptxt.ForeColor = Color.Gray
        peptxt.Text = "Nombre de la Persona Encargada"
        telpeptxt.ForeColor = Color.Gray
        telpeptxt.Text = "Telefono de la Persona Encargada"



    End Sub

    Private Sub regbtn_MouseHover(sender As Object, e As EventArgs) Handles regbtn.MouseHover
        regbtn.BackColor = Color.Green
    End Sub

    Private Sub regbtn_MouseLeave(sender As Object, e As EventArgs) Handles regbtn.MouseLeave
        regbtn.BackColor = Color.White

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Archivos.ShowDialog()
        nomimg = Archivos.FileName
        If nomimg <> "" Then
            imgpb.Image = Image.FromFile(nomimg)
        End If
    End Sub

    Private Sub regbtn_Click(sender As Object, e As EventArgs) Handles regbtn.Click
        If nomptxt.Text <> "" And rucptxt.Text <> "" And dirptxt.Text <> "" And telptxt.Text <> "" And peptxt.Text <> "" And telpeptxt.Text <> "" And imgpb.Image IsNot Nothing Then

            Dim sqlinsr As String = "INSERT INTO PROVEEDOR VALUES('" + idus + "','" + pnomtxt.Text + "','" + apetxt.Text + "','" + celtxt.Text + "','" + dnitxt.Text + "','" + edadtxt.Text + "','" + tccb.Text + "','" + nomustxt.Text + "','" + passustxt.Text + "',@imagen)"
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