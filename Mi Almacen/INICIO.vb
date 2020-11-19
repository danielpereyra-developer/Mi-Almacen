Imports FontAwesome.Sharp
Public Class INICIO
    Private actualbtn As IconButton
    Private actualsubbtn As IconButton
    Private borde As New Panel

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        borde.Size = New Size(7, 40)
        asidep.Controls.Add(borde)
    End Sub
    Private Sub INICIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()

    End Sub

    Private Sub activobtn(senderbtn As Object, customcolor As Color)
        If senderbtn IsNot Nothing Then
            desactivarbtn()
            actualbtn = CType(senderbtn, IconButton)
            actualbtn.BackColor = Color.FromArgb(37, 36, 81)
            actualbtn.ForeColor = customcolor
            actualbtn.IconColor = customcolor
            actualbtn.TextAlign = ContentAlignment.MiddleCenter
            actualbtn.ImageAlign = ContentAlignment.MiddleRight
            actualbtn.TextImageRelation = TextImageRelation.TextBeforeImage

            borde.BackColor = customcolor
            borde.Location = New Point(0, actualbtn.Location.Y)
            borde.Visible = True
            borde.BringToFront()

            iconpestaña.IconChar = actualbtn.IconChar
            iconpestaña.IconColor = customcolor
            pestañalb.Text = actualbtn.Text
            pestañalb.ForeColor = customcolor
        End If
    End Sub

    Private Sub activosubbtn(senderbtn As Object, customcolor As Color)
        If senderbtn IsNot Nothing Then
            desactivarsubbtn()
            actualsubbtn = CType(senderbtn, IconButton)
            actualsubbtn.BackColor = Color.FromArgb(60, 30, 68)
            actualsubbtn.ForeColor = customcolor
            actualsubbtn.IconColor = customcolor
            actualsubbtn.TextAlign = ContentAlignment.MiddleCenter
            actualsubbtn.ImageAlign = ContentAlignment.MiddleRight
            actualsubbtn.TextImageRelation = TextImageRelation.TextBeforeImage

            iconpestaña.IconChar = actualsubbtn.IconChar
            iconpestaña.IconColor = customcolor
            pestañalb.Text = actualsubbtn.Text
            pestañalb.ForeColor = customcolor
        End If
    End Sub
    Private Sub desactivarsubbtn()
        If actualsubbtn IsNot Nothing Then
            actualsubbtn.BackColor = Color.FromArgb(60, 30, 68)
            actualsubbtn.ForeColor = Color.White
            actualsubbtn.IconColor = Color.White
            actualsubbtn.TextAlign = ContentAlignment.MiddleLeft
            actualsubbtn.ImageAlign = ContentAlignment.MiddleLeft
            actualsubbtn.TextImageRelation = TextImageRelation.ImageBeforeText

            iconpestaña.IconChar = IconChar.Home
            iconpestaña.IconColor = Color.Orange
            pestañalb.Text = "INICIO"
            pestañalb.ForeColor = Color.Orange
        End If
    End Sub
    Private Sub desactivarbtn()
        If actualbtn IsNot Nothing Then
            actualbtn.BackColor = Color.FromArgb(31, 30, 68)
            actualbtn.ForeColor = Color.White
            actualbtn.IconColor = Color.White
            actualbtn.TextAlign = ContentAlignment.MiddleLeft
            actualbtn.ImageAlign = ContentAlignment.MiddleLeft
            actualbtn.TextImageRelation = TextImageRelation.ImageBeforeText

            borde.Visible = False

            iconpestaña.IconChar = IconChar.Home
            iconpestaña.IconColor = Color.Orange
            pestañalb.Text = "INICIO"
            pestañalb.ForeColor = Color.Orange
        End If
    End Sub

    Private Sub OcultarSubMenu()
        sub1.Visible = False
        sub2.Visible = False
        sub3.Visible = False
        sub5.Visible = False
    End Sub
    Private Sub MostrarSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            OcultarSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        MostrarSubMenu(sub1)
        activobtn(sender, Color.FromArgb(102, 255, 102))
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        MostrarSubMenu(sub2)
        activobtn(sender, Color.FromArgb(255, 102, 102))
    End Sub

    Private Sub IconButton9_Click(sender As Object, e As EventArgs) Handles IconButton9.Click
        MostrarSubMenu(sub3)
        activobtn(sender, Color.FromArgb(102, 102, 255))
    End Sub

    Private Sub IconButton13_Click(sender As Object, e As EventArgs) Handles IconButton13.Click
        OcultarSubMenu()
        activobtn(sender, Color.FromArgb(255, 255, 102))
    End Sub

    Private Sub IconButton17_Click(sender As Object, e As EventArgs) Handles IconButton17.Click
        MostrarSubMenu(sub5)
        activobtn(sender, Color.FromArgb(255, 102, 255))
    End Sub

    Private Sub IconButton21_Click(sender As Object, e As EventArgs) Handles IconButton21.Click
        OcultarSubMenu()
        activobtn(sender, Color.FromArgb(102, 255, 255))
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        activosubbtn(sender, Color.FromArgb(178, 255, 102))
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        activosubbtn(sender, Color.FromArgb(178, 255, 102))
    End Sub

    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        activosubbtn(sender, Color.FromArgb(255, 153, 153))
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        activosubbtn(sender, Color.FromArgb(255, 153, 153))
    End Sub

    Private Sub IconButton12_Click(sender As Object, e As EventArgs) Handles IconButton12.Click
        activosubbtn(sender, Color.FromArgb(102, 178, 255))
    End Sub

    Private Sub IconButton11_Click(sender As Object, e As EventArgs) Handles IconButton11.Click
        activosubbtn(sender, Color.FromArgb(102, 178, 255))
    End Sub

    Private Sub IconButton10_Click(sender As Object, e As EventArgs) Handles IconButton10.Click
        activosubbtn(sender, Color.FromArgb(102, 178, 255))
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        activosubbtn(sender, Color.FromArgb(102, 178, 255))
    End Sub

    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        desactivarbtn()
        OcultarSubMenu()
    End Sub
End Class