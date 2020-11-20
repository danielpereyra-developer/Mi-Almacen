Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D

Imports itextsharp.text.pdf
Imports itextsharp.text.pdf.BarcodeCodabar
Imports System.Text
Imports System.Security.Cryptography
Imports QRCoder

Module Metodos
    Public con As New SqlConnection
    Public comand As New SqlCommand

    Sub conectar()
        Try
            con.ConnectionString = "Data Source=sql5097.site4now.net;Initial Catalog=DB_A699B6_SisAlPV;Persist Security Info=True;User Id=DB_A699B6_SisAlPV_admin;Password=sisalmacen01"
            con.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub desconectar()
        con.Close()
    End Sub


    Public Function generarqr(contenido As String) As Image
        Dim qrgen As New QRCodeGenerator
        Dim qrdatos As QRCodeData = qrgen.CreateQrCode(contenido, QRCoder.QRCodeGenerator.ECCLevel.H)
        Dim qrcod As New QRCode(qrdatos)

        Dim qrimg As Bitmap = qrcod.GetGraphic(5, Color.Black, Color.White, True)

        generarqr = Base64ToImage(BitmapToBase64(qrimg))
    End Function

    Public Function ImagenAByte(ByVal img As Image) As Byte()
        Dim ms As New IO.MemoryStream()
        img.Save(ms, img.RawFormat)
        ImagenAByte = ms.GetBuffer
    End Function
    Public Function ByteAImagen(ByVal by As Byte()) As Image
        Dim ms As New IO.MemoryStream(by)
        Dim img As Image = Image.FromStream(ms)
        ByteAImagen = img
    End Function
    Public Function Encriptar(ByVal texto As String) As String
        Dim ue As New UnicodeEncoding()
        Dim bytetexto() As Byte = ue.GetBytes(texto)
        Dim md5 As New MD5CryptoServiceProvider()
        Dim bytehash() As Byte = md5.ComputeHash(bytetexto)
        Return Convert.ToBase64String(bytehash)
    End Function

    Public Function codigo128(ByVal cod As String, Optional ByVal vertext As Boolean = False, Optional ByVal heigth As Single = 0)
        Dim barcode As New BarcodeCodabar

        If heigth <> 0 Then
            barcode.BarHeight = heigth
        End If
        barcode.Code = cod
        barcode.GenerateChecksum = True
        barcode.CodeType = Barcode128.CODE128
        Try

            Dim bm As New Bitmap(barcode.CreateDrawingImage(Color.Black, Color.White))

            If vertext = False Then
                Return bm
            Else
                Dim bmt As Image
                bmt = New Bitmap(bm.Width, bm.Height + 15)
                Dim g As Graphics = Graphics.FromImage(bmt)
                g.FillRectangle(New SolidBrush(Color.White), 0, 0, bm.Width, bm.Height + 15)

                Dim pintartexto As New Font("Arial", 8)
                Dim brocha As New SolidBrush(Color.Black)

                Dim stringsize As New SizeF
                stringsize = g.MeasureString(cod, pintartexto)
                Dim centrox As Single = (bm.Width - stringsize.Width) / 2
                Dim x As Single = centrox
                Dim y As Single = bm.Height

                Dim drawf As New StringFormat
                drawf.FormatFlags = StringFormatFlags.NoWrap
                g.DrawImage(bm, 0, 0)

                Dim ncod As String = cod.Substring(1, cod.Length - 2)
                g.DrawString(cod, pintartexto, brocha, x, y, drawf)


                Return bmt

            End If
        Catch ex As Exception
            Throw New Exception("Error al generar el codigo")
        End Try
    End Function

    Public Function BitmapToBase64(ByVal image As System.Drawing.Bitmap) As String
        Dim base64 As String
        Dim memory As New System.IO.MemoryStream()
        image.Save(memory, Imaging.ImageFormat.Bmp)
        base64 = System.Convert.ToBase64String(memory.ToArray)
        memory.Close()
        memory = Nothing
        Return base64
    End Function

    Function Base64ToImage(ByVal base64string As String) As System.Drawing.Image
        'Setup image and get data stream together
        Dim img As System.Drawing.Image
        Dim MS As System.IO.MemoryStream = New System.IO.MemoryStream
        Dim b64 As String = base64string.Replace(" ", "+")
        Dim b() As Byte

        'Converts the base64 encoded msg to image data
        b = Convert.FromBase64String(b64)
        MS = New System.IO.MemoryStream(b)

        'creates image
        img = System.Drawing.Image.FromStream(MS)

        Return img
    End Function


End Module
