
Imports System.Data.SqlClient
Imports FontAwesome.Sharp
Public Class INICIO
    Private actualbtn As IconButton
    Private actualsubbtn As IconButton
    Private borde As New Panel
    Private actualhijo As Form
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        borde.Size = New Size(7, 40)
        asidep.Controls.Add(borde)

        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
        Me.FormBorderStyle = FormBorderStyle.None

    End Sub
    Private Sub INICIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OcultarSubMenu()
        If Login.tpus = "JA" Then
            tpusuariopb.Image = Image.FromFile("C:\Users\Usuario\source\repos\Mi Almacen\Mi Almacen\Imagenes\006-deliveryman.png")
        ElseIf Login.tpus = "TB" Then
            tpusuariopb.Image = Image.FromFile("C:\Users\Usuario\source\repos\Mi Almacen\Mi Almacen\Imagenes\004-worker.png")
        ElseIf Login.tpus = "AD" Then
            tpusuariopb.Image = Image.FromFile("C:\Users\Usuario\source\repos\Mi Almacen\Mi Almacen\Imagenes\009-employee.png")
        End If
        usuariolb.Text = Login.user
        horalb.Text = Now.ToString("hh:mm:ss tt")
        fechalb.Text = DateTime.Now.ToString("D")
        reloj.Enabled = True
        reloj.Interval = 1000
    End Sub

#Region "Metodos"
    Private Sub activobtn(senderbtn As Object, customcolor As Color)
        If senderbtn IsNot Nothing Then
            If actualhijo IsNot Nothing Then
                actualhijo.Close()
            End If
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

    End Sub
    Private Sub MostrarSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            OcultarSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub

    Public Sub AbrirHijo(formhijo As Form)
        If actualhijo IsNot Nothing Then
            actualhijo.Close()
        End If
        actualhijo = formhijo
        formhijo.TopLevel = False
        formhijo.FormBorderStyle = FormBorderStyle.None
        formhijo.Dock = DockStyle.Fill
        escritoriop.Controls.Add(formhijo)
        escritoriop.Tag = formhijo
        formhijo.BringToFront()
        formhijo.Show()
        pestañalb.Text = formhijo.Text
    End Sub

#End Region

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
        AbrirHijo(New Inventario)
    End Sub

    Private Sub IconButton17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IconButton21_Click(sender As Object, e As EventArgs) Handles IconButton21.Click
        OcultarSubMenu()
        activobtn(sender, Color.FromArgb(102, 255, 255))
        Dim sqlupd As String = "UPDATE LOGEO SET FECHA_SALIDA=@fsal WHERE LOGEO.ID_USUARIO='" + Login.codus + "'"
        Dim cmd As New SqlCommand(sqlupd, con)
        cmd.Parameters.Add("@fsal", SqlDbType.DateTime).Value = Now

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        MsgBox("Hasta Luego")
        End
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        activosubbtn(sender, Color.FromArgb(178, 255, 102))
        AbrirHijo(New USUARIOS)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        activosubbtn(sender, Color.FromArgb(178, 255, 102))
    End Sub
    'Nuevo Proveedor
    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        activosubbtn(sender, Color.FromArgb(255, 153, 153))
        AbrirHijo(New Proveedores)
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        activosubbtn(sender, Color.FromArgb(255, 153, 153))
    End Sub
    'Nueva entrada
    Private Sub IconButton12_Click(sender As Object, e As EventArgs) Handles IconButton12.Click
        activosubbtn(sender, Color.FromArgb(102, 178, 255))
        NEntrada.Show()
    End Sub

    Private Sub IconButton11_Click(sender As Object, e As EventArgs) Handles IconButton11.Click
        activosubbtn(sender, Color.FromArgb(102, 178, 255))
        NSalida.Show()
    End Sub

    Private Sub IconButton10_Click(sender As Object, e As EventArgs) Handles IconButton10.Click
        activosubbtn(sender, Color.FromArgb(102, 178, 255))
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        activosubbtn(sender, Color.FromArgb(102, 178, 255))
    End Sub

    Private Sub headerp_MouseDown(sender As Object, e As MouseEventArgs) Handles headerp.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub


    Private Sub logo_Click(sender As Object, e As EventArgs) Handles logo.Click
        If actualhijo IsNot Nothing Then
            actualhijo.Close()
        End If
        desactivarbtn()
        desactivarsubbtn()
        OcultarSubMenu()
    End Sub

    Private Sub headerp_MouseUp(sender As Object, e As MouseEventArgs) Handles headerp.MouseUp
        Arrastre = False
    End Sub

    Private Sub maxbtn_Click(sender As Object, e As EventArgs) Handles maxbtn.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub minbtn_Click(sender As Object, e As EventArgs) Handles minbtn.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub reloj_Tick(sender As Object, e As EventArgs) Handles reloj.Tick
        horalb.Text = Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub maxbtn_MouseHover(sender As Object, e As EventArgs) Handles maxbtn.MouseHover
        maxbtn.BackColor = Color.FromArgb(51, 153, 255)
    End Sub

    Private Sub headerp_MouseMove(sender As Object, e As MouseEventArgs) Handles headerp.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - ex, MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub maxbtn_MouseLeave(sender As Object, e As EventArgs) Handles maxbtn.MouseLeave
        maxbtn.BackColor = Color.FromArgb(26, 25, 62)
    End Sub

    Private Sub minbtn_MouseHover(sender As Object, e As EventArgs) Handles minbtn.MouseHover
        minbtn.BackColor = Color.FromArgb(51, 153, 255)
    End Sub

    Private Sub minbtn_MouseLeave(sender As Object, e As EventArgs) Handles minbtn.MouseLeave
        minbtn.BackColor = Color.FromArgb(26, 25, 62)
    End Sub
End Class
