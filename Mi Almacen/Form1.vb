Imports System.Net.NetworkInformation
Imports System.Data.SqlClient

Public Class Login
    Public user As String
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




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

            If passtxt.Text = paswtemp And usertxt.Text = nomuser Then
                Dim sqlinsr As String = "INSERT INTO LOGEO(ID_USUARIO,FECHA_INGRESO,FECHA_SALIDA) VALUES('" + codustemp + "',@fing,null)"
                Dim cmd2 As New SqlCommand(sqlinsr, con)
                cmd2.Parameters.Add("@fing", SqlDbType.DateTime).Value = Now

                'con.Open()
                cmd2.ExecuteNonQuery()
                desconectar()

                Principal.userlb.Text = nomuser
                Principal.Show()
                Me.Hide()

            Else
                MsgBox("La contraseña es incorrecta")
                passtxt.Clear()
            End If

        Catch ex As Exception
            MsgBox("El usuario es incorrecto")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
