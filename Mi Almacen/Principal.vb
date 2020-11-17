Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userlb.Text = Login.user
        horalb.Text = Now.ToString("hh:mm:ss tt")
        fechalb.Text = DateTime.Now.ToString("D")
        reloj.Enabled = True
        reloj.Interval = 1000
    End Sub

    Private Sub reloj_Tick(sender As Object, e As EventArgs) Handles reloj.Tick
        horalb.Text = Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Inventario.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class