Public Class INICIO
    Private Sub INICIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()
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
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        MostrarSubMenu(sub2)
    End Sub

    Private Sub IconButton9_Click(sender As Object, e As EventArgs) Handles IconButton9.Click
        MostrarSubMenu(sub3)
    End Sub

    Private Sub IconButton13_Click(sender As Object, e As EventArgs) Handles IconButton13.Click

    End Sub

    Private Sub IconButton17_Click(sender As Object, e As EventArgs) Handles IconButton17.Click
        MostrarSubMenu(sub5)
    End Sub

    Private Sub IconButton21_Click(sender As Object, e As EventArgs) Handles IconButton21.Click
        OcultarSubMenu()
    End Sub
End Class