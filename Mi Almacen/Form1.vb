Imports System.Net.NetworkInformation
Imports System.Data.SqlClient

Public Class Login
    Public user As String
    Public tpus As String
    Private borderbottom1 As New Panel
    Private borderbottom2 As New Panel

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        borderbottom1.Size = New Size(170, 3)
        loginp.Controls.Add(borderbottom1)
        borderbottom2.Size = New Size(170, 3)
        loginp.Controls.Add(borderbottom2)

        Me.FormBorderStyle = FormBorderStyle.None
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Probar la conexion
        If My.Computer.Network.IsAvailable() Then
            Try
                If My.Computer.Network.Ping("www.google.es", 1000) Then
                    'MsgBox("Conectado.")
                Else
                    MsgBox("No se encuentra una conexion a internet.")
                End If

            Catch ex As PingException
                MsgBox("No se encuentra una conexion a internet.")
            End Try
        Else
            MsgBox("No se encuentra una conexion a internet")
        End If

        'Establece conexion con la BD
        conectar()
        desconectar()

        usertxt.ForeColor = Color.Gray
        usertxt.Text = "Nombre de Usuario"
        addborder(usertxt, borderbottom1)
        passtxt.ForeColor = Color.Gray
        passtxt.PasswordChar = Nothing
        passtxt.Text = "Contraseña"
        addborder(passtxt, borderbottom2)


    End Sub
    Private Sub addborder(caja As TextBox, borde As Panel)
        borde.BackColor = Color.Black
        borde.Location = New Point(caja.Location.X, caja.Location.Y + 20)
        borde.Visible = True
        borde.BringToFront()
    End Sub

    Private Sub usertxt_GotFocus(sender As Object, e As EventArgs) Handles usertxt.GotFocus
        If usertxt.Text = "Nombre de Usuario" Then
            usertxt.ForeColor = Color.White
            usertxt.Text = ""
        End If
    End Sub

    Private Sub usertxt_LostFocus(sender As Object, e As EventArgs) Handles usertxt.LostFocus
        If usertxt.Text = Nothing Then
            usertxt.ForeColor = Color.Gray
            usertxt.Text = "Nombre de Usuario"
        End If
    End Sub

    Private Sub passtxt_GotFocus(sender As Object, e As EventArgs) Handles passtxt.GotFocus
        If passtxt.Text = "Contraseña" Then
            passtxt.ForeColor = Color.White
            passtxt.Text = ""
            passtxt.PasswordChar = "*"
        End If
    End Sub


    Private Sub passtxt_LostFocus(sender As Object, e As EventArgs) Handles passtxt.LostFocus
        If passtxt.Text = Nothing Then
            passtxt.ForeColor = Color.Gray
            passtxt.PasswordChar = Nothing
            passtxt.Text = "Contraseña"
        End If
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Application.Exit()
    End Sub

    Private Sub minbtn_Click(sender As Object, e As EventArgs) Handles minbtn.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub closebtn_MouseHover(sender As Object, e As EventArgs) Handles closebtn.MouseHover
        closebtn.BackColor = Color.Red
    End Sub

    Private Sub closebtn_MouseLeave(sender As Object, e As EventArgs) Handles closebtn.MouseLeave
        closebtn.BackColor = Color.Orange
    End Sub

    Private Sub minbtn_MouseHover(sender As Object, e As EventArgs) Handles minbtn.MouseHover
        minbtn.BackColor = Color.FromArgb(51, 153, 255)
    End Sub

    Private Sub minbtn_MouseLeave(sender As Object, e As EventArgs) Handles minbtn.MouseLeave
        minbtn.BackColor = Color.Orange
    End Sub

    Private Sub ingbtn_Click(sender As Object, e As EventArgs) Handles ingbtn.Click
        If usertxt.Text = "" Or passtxt.Text = "" Then
            MsgBox("Ingrese los datos")
        Else
            Dim sql2 As String = "SELECT COUNT(*) FROM PRODUCTOS"
            Dim cmd2 As New SqlCommand(sql2, con)
            Dim rs As SqlDataReader
            Dim cantus As Integer

            con.Open()
            rs = cmd2.ExecuteReader
            rs.Read()
            cantus = CInt(rs(0))
            con.Close()

            If cantus <= 0 Then
                MsgBox("El usuario no existe. Intente de nuevo")
            Else
                Dim codustemp As String
                Dim paswtemp As String
                Dim nomuser As String

                Dim sql As String = "SELECT * FROM USUARIOS WHERE USUARIOS.NOMBRE='" + usertxt.Text + "'"
                Dim cmd As New SqlCommand(sql, con)
                Try
                    Dim da As New SqlDataAdapter(cmd)
                    Dim ds As New DataSet
                    da.Fill(ds, "USUARIOS")

                    codustemp = ds.Tables("USUARIOS").Rows(0)("ID_USUARIO").ToString()
                    nomuser = ds.Tables("USUARIOS").Rows(0)("NOMBRE").ToString()
                    paswtemp = ds.Tables("USUARIOS").Rows(0)("PASSWORD").ToString()
                    user = nomuser
                    tpus = Mid(codustemp, 1, 2)
                    MsgBox(tpus)

                    If passtxt.Text = paswtemp Then
                        Dim sqlinsr As String = "INSERT INTO LOGEO(ID_USUARIO,FECHA_INGRESO,FECHA_SALIDA) VALUES('" + codustemp + "',@fing,null)"
                        Dim cmd3 As New SqlCommand(sqlinsr, con)
                        cmd3.Parameters.Add("@fing", SqlDbType.DateTime).Value = Now

                        con.Open()
                        cmd3.ExecuteNonQuery()
                        con.Close()

                        INICIO.Show()
                        Me.Hide()

                    Else
                        MsgBox("La contraseña es incorrecta")
                        passtxt.Clear()
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If

    End Sub
End Class
