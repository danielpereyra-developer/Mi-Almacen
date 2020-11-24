Imports itextsharp.text.pdf
Imports itextsharp.text
Imports System.IO
Imports System.Data.SqlClient

Module Reportes

    Dim pdfWrite As PdfWriter
    Sub pdfInventario(ByVal sfdr As SaveFileDialog)
        sfdr.ShowDialog()
        Dim ruta As String = sfdr.FileName
        Dim pdfdoc As New Document(itextsharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
        pdfWrite = PdfWriter.GetInstance(pdfdoc, New FileStream(ruta, FileMode.Create))

        Dim FontB As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, itextsharp.text.Font.NORMAL))
        Dim FontB8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, itextsharp.text.Font.BOLD))
        Dim FontB12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, itextsharp.text.Font.BOLD))
        Dim pcolum As New Font(itextsharp.text.Font.FontFamily.HELVETICA, 9, itextsharp.text.Font.BOLD, BaseColor.BLACK)
        Dim pfila As New Font(itextsharp.text.Font.FontFamily.HELVETICA, 9, itextsharp.text.Font.BOLD, BaseColor.BLACK)
        Dim Cvacio As PdfPCell = New PdfPCell(New Phrase("  "))
        Cvacio.Border = 0

        pdfdoc.Open()

        Dim tabla1 As PdfPTable = New PdfPTable(4)
        Dim col1 As New PdfPCell
        Dim col2 As New PdfPCell
        Dim col3 As New PdfPCell
        Dim col4 As New PdfPCell
        Dim col5 As New PdfPCell
        Dim col6 As New PdfPCell
        'Dim ILine As Integer
        'Dim IFila As Integer

        tabla1.WidthPercentage = 95

        Dim whidths As Single() = New Single() {4.0F, 7.0F, 1.0F, 4.0F}
        tabla1.SetWidths(whidths)

#Region "Encabezado"

        Dim imgurl As String = Application.StartupPath & "\Imagenes\Logo_header_desktop.png"
        Dim img As itextsharp.text.Image
        img = itextsharp.text.Image.GetInstance(imgurl)
        img.ScaleToFit(110.0F, 140.0F)
        img.SpacingBefore = 20.0F
        img.SpacingAfter = 10.0F
        img.SetAbsolutePosition(35, 780)
        pdfdoc.Add(img)

        tabla1.AddCell(Cvacio)
        col2 = New PdfPCell(New Phrase("SODIMAC S.A.", FontB8))
        col2.Border = 0
        tabla1.AddCell(col2)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)

        col2 = New PdfPCell(New Phrase("Av. José De Lama S/N Cruce con Av. Las Dalias, Sullana 20103", FontB))
        col2.Border = 0
        tabla1.AddCell(col2)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)

        col2 = New PdfPCell(New Phrase("SULLANA", FontB))
        col2.Border = 0
        tabla1.AddCell(col2)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)

        col2 = New PdfPCell(New Phrase("(01) 2030420", FontB))
        col2.Border = 0
        tabla1.AddCell(col2)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)

        Dim imgurl2 As String = Application.StartupPath & "\Imagenes\009-checklist.png"
        Dim img2 As itextsharp.text.Image
        img2 = itextsharp.text.Image.GetInstance(imgurl2)
        img2.ScaleToFit(60.0F, 90.0F)
        img2.SpacingBefore = 20.0F
        img2.SpacingAfter = 10.0F
        img2.SetAbsolutePosition(460, 750)
        pdfdoc.Add(img2)

        pdfdoc.Add(tabla1)

#End Region

#Region "DATOS"

        Dim CLinea As PdfPCell = New PdfPCell(New Phrase("  "))
        CLinea.Colspan = 4
        CLinea.Border = 2

        Dim tabla2 As PdfPTable = New PdfPTable(4)
        Dim whidths2 As Single() = New Single() {2.0F, 8.0F, 3.0F, 2.0F}
        tabla2.WidthPercentage = 95
        tabla2.SetWidths(whidths2)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(CLinea)
        col1 = New PdfPCell(New Phrase("Usuario", FontB8))
        col1.Border = 0
        tabla2.AddCell(col1)
        col2 = New PdfPCell(New Phrase(Login.user, FontB8))
        col2.Border = 0
        tabla2.AddCell(col2)
        col3 = New PdfPCell(New Phrase("Fecha de Reporte", FontB8))
        col3.Border = 0
        tabla2.AddCell(col3)
        col4 = New PdfPCell(New Phrase(Now, FontB8))
        col4.Border = 0
        tabla2.AddCell(col4)

        tabla2.AddCell(CLinea)

        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)

        pdfdoc.Add(tabla2)

#End Region


#Region "Inventario"
        Dim tablaD As New PdfPTable(6)
        tablaD.TotalWidth = 550.0F
        tablaD.LockedWidth = True
        tablaD.HorizontalAlignment = Element.ALIGN_CENTER
        tablaD.HeaderRows = 1

        Dim widths3 As Single() = New Single() {0.8F, 3.0F, 0.8F, 0.8F, 0.5F, 0.5F}
        tablaD.SetWidths(widths3)

        Dim pdfcell As PdfPCell = Nothing

        pdfcell = New PdfPCell(New Paragraph("ID", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("NOMBRE", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("MARCA", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("MODELO", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
        pdfcell.MinimumHeight = 18
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)


        pdfcell = New PdfPCell(New Paragraph("EXIST.", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("P.U", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        Dim dt As DataTable = getDataTable()

        For i = 0 To dt.Rows.Count - 1
            For j = 0 To dt.Columns.Count - 1
                pdfcell = New PdfPCell(New Paragraph(dt.Rows(i)(j).ToString, pfila))
                pdfcell.MinimumHeight = 18
                pdfcell.PaddingLeft = 5.0F
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                tablaD.AddCell(pdfcell)
            Next
        Next

        pdfdoc.Add(tablaD)

#End Region

        pdfdoc.Close()

        Process.Start(ruta)

    End Sub

    Private Function getDataTable()
        Dim dtable As New DataTable("dt")
        Dim sqlvac As String = "SELECT ID_PRODUCTO,NOM_PRODUCTO,MARCA_PRODUCTO,MODELO_PRODUCTO,EX_PRODUCTO,PU_PRODUCTO FROM PRODUCTOS"

        Dim cmd5 As New SqlCommand(sqlvac, con)

        Dim CantReg As Integer
        Dim sql2 As String = "SELECT COUNT(*) FROM PRODUCTOS"
        Dim cmd As New SqlCommand(sql2, con)
        Dim rs As SqlDataReader

        con.Open()
        rs = cmd.ExecuteReader
        rs.Read()
        CantReg = CInt(rs(0))
        con.Close()

        Try
            Dim da As New SqlDataAdapter(cmd5)
            Dim ds As New DataSet

            da.Fill(ds, "PRODUCTOS")

            Dim dcolum1 As New DataColumn("ID", GetType(String))
            Dim dcolum2 As New DataColumn("NOMBRE", GetType(String))
            Dim dcolum3 As New DataColumn("MARCA", GetType(String))
            Dim dcolum4 As New DataColumn("MODELO", GetType(String))
            Dim dcolum5 As New DataColumn("EXISTENCIAS", GetType(String))
            Dim dcolum6 As New DataColumn("P. UNITARIO", GetType(String))


            dtable.Columns.Add(dcolum1)
            dtable.Columns.Add(dcolum2)
            dtable.Columns.Add(dcolum3)
            dtable.Columns.Add(dcolum4)
            dtable.Columns.Add(dcolum5)
            dtable.Columns.Add(dcolum6)


            Dim row As DataRow
            For i = 0 To CantReg - 1
                row = dtable.NewRow
                row(dcolum1) = ds.Tables("PRODUCTOS").Rows(i)("ID_PRODUCTO").ToString()
                row(dcolum2) = ds.Tables("PRODUCTOS").Rows(i)("NOM_PRODUCTO").ToString()
                row(dcolum3) = ds.Tables("PRODUCTOS").Rows(i)("MARCA_PRODUCTO").ToString()
                row(dcolum4) = ds.Tables("PRODUCTOS").Rows(i)("MODELO_PRODUCTO").ToString()
                row(dcolum5) = ds.Tables("PRODUCTOS").Rows(i)("EX_PRODUCTO").ToString()
                row(dcolum6) = ds.Tables("PRODUCTOS").Rows(i)("PU_PRODUCTO").ToString()

                dtable.Rows.Add(row)
            Next

            dtable.AcceptChanges()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dtable
    End Function

    Sub pdfEntrada(ByVal sfdr As SaveFileDialog, ByVal qr As Byte())
        sfdr.ShowDialog()
        Dim ruta As String = sfdr.FileName
        Dim pdfdoc As New Document(itextsharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
        pdfWrite = PdfWriter.GetInstance(pdfdoc, New FileStream(ruta, FileMode.Create))

        Dim FontB As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, itextsharp.text.Font.NORMAL))
        Dim FontB8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, itextsharp.text.Font.BOLD))
        Dim FontB12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, itextsharp.text.Font.BOLD))
        Dim pcolum As New Font(itextsharp.text.Font.FontFamily.HELVETICA, 9, itextsharp.text.Font.BOLD, BaseColor.BLACK)
        Dim pfila As New Font(itextsharp.text.Font.FontFamily.HELVETICA, 9, itextsharp.text.Font.BOLD, BaseColor.BLACK)
        Dim Cvacio As PdfPCell = New PdfPCell(New Phrase("  "))
        Cvacio.Border = 0

        pdfdoc.Open()

        Dim tabla1 As PdfPTable = New PdfPTable(4)
        Dim col1 As New PdfPCell
        Dim col2 As New PdfPCell
        Dim col3 As New PdfPCell
        Dim col4 As New PdfPCell
        Dim col5 As New PdfPCell
        Dim col6 As New PdfPCell
        Dim col7 As New PdfPCell
        'Dim ILine As Integer
        'Dim IFila As Integer

        tabla1.WidthPercentage = 95

        Dim whidths As Single() = New Single() {4.0F, 7.0F, 1.0F, 4.0F}
        tabla1.SetWidths(whidths)

#Region "Encabezado"

        Dim imgurl As String = Application.StartupPath & "\Imagenes\Logo_header_desktop.png"
        Dim img As itextsharp.text.Image
        img = itextsharp.text.Image.GetInstance(imgurl)
        img.ScaleToFit(110.0F, 140.0F)
        img.SpacingBefore = 20.0F
        img.SpacingAfter = 10.0F
        img.SetAbsolutePosition(35, 780)
        pdfdoc.Add(img)

        tabla1.AddCell(Cvacio)
        col2 = New PdfPCell(New Phrase("SODIMAC S.A.", FontB8))
        col2.Border = 0
        tabla1.AddCell(col2)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)

        col2 = New PdfPCell(New Phrase("Av. José De Lama S/N Cruce con Av. Las Dalias, Sullana 20103", FontB))
        col2.Border = 0
        tabla1.AddCell(col2)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)

        col2 = New PdfPCell(New Phrase("SULLANA", FontB))
        col2.Border = 0
        tabla1.AddCell(col2)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)

        col2 = New PdfPCell(New Phrase("(01) 2030420", FontB))
        col2.Border = 0
        tabla1.AddCell(col2)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)


        Dim img2 As itextsharp.text.Image
        img2 = itextsharp.text.Image.GetInstance(qr)
        img2.ScaleToFit(60.0F, 90.0F)
        img2.SpacingBefore = 20.0F
        img2.SpacingAfter = 10.0F
        img2.SetAbsolutePosition(460, 750)
        pdfdoc.Add(img2)

        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        col4 = New PdfPCell(New Phrase("N° " + Entrada.identxt.Text, FontB))
        tabla1.AddCell(col4)

        pdfdoc.Add(tabla1)

#End Region

#Region "DATOS"

        Dim CLinea As PdfPCell = New PdfPCell(New Phrase("  "))
        CLinea.Colspan = 4
        CLinea.Border = 2

        Dim tabla2 As PdfPTable = New PdfPTable(4)
        Dim whidths2 As Single() = New Single() {2.0F, 8.0F, 3.0F, 2.0F}
        tabla2.WidthPercentage = 95
        tabla2.SetWidths(whidths2)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(CLinea)
        col1 = New PdfPCell(New Phrase("Usuario: ", FontB8))
        col1.Border = 0
        tabla2.AddCell(col1)
        col2 = New PdfPCell(New Phrase(Login.user, FontB8))
        col2.Border = 0
        tabla2.AddCell(col2)
        col3 = New PdfPCell(New Phrase("Fecha de Reporte: ", FontB8))
        col3.Border = 0
        tabla2.AddCell(col3)
        col4 = New PdfPCell(New Phrase(Now, FontB8))
        col4.Border = 0
        tabla2.AddCell(col4)
        col1 = New PdfPCell(New Phrase("Proveedor: ", FontB8))
        col1.Border = 0
        tabla2.AddCell(col1)
        col2 = New PdfPCell(New Phrase(Entrada.provtxt.Text, FontB8))
        col2.Border = 0
        tabla2.AddCell(col2)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(CLinea)

        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)

        pdfdoc.Add(tabla2)

#End Region

#Region "Detalle"
        Dim tablaD As New PdfPTable(7)
        tablaD.TotalWidth = 550.0F
        tablaD.LockedWidth = True
        tablaD.HorizontalAlignment = Element.ALIGN_CENTER
        tablaD.HeaderRows = 1

        Dim widths3 As Single() = New Single() {0.8F, 3.0F, 0.8F, 0.8F, 0.5F, 0.5F, 0.5F}
        tablaD.SetWidths(widths3)

        Dim pdfcell As PdfPCell = Nothing

        pdfcell = New PdfPCell(New Paragraph("CODIGO", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("PRODUCTO", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("MARCA", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("MODELO", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
        pdfcell.MinimumHeight = 18
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)


        pdfcell = New PdfPCell(New Paragraph("P.U", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("CANT.", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("TOTAL", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        Dim dt As DataTable = getDataTableEntrada()

        For i = 0 To dt.Rows.Count - 1
            For j = 0 To dt.Columns.Count - 1
                pdfcell = New PdfPCell(New Paragraph(dt.Rows(i)(j).ToString, pfila))
                pdfcell.MinimumHeight = 18
                pdfcell.PaddingLeft = 5.0F
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                tablaD.AddCell(pdfcell)
            Next
        Next

        pdfdoc.Add(tablaD)

#End Region

#Region "Totales"

        Dim tabla3 As PdfPTable = New PdfPTable(5)
        Dim whidths3 As Single() = New Single() {2.0F, 8.0F, 3.0F, 2.0F, 2.0F}
        tabla3.WidthPercentage = 95
        tabla3.SetWidths(whidths3)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)

        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        col4 = New PdfPCell(New Phrase("SubTotal: ", FontB8))
        col4.Border = 0
        tabla3.AddCell(col4)
        col5 = New PdfPCell(New Phrase(Entrada.subttxt.Text, FontB8))
        col5.Border = 0
        tabla3.AddCell(col5)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        col4 = New PdfPCell(New Phrase("IGV: ", FontB8))
        col4.Border = 0
        tabla3.AddCell(col4)
        col5 = New PdfPCell(New Phrase(Entrada.igvtxt.Text, FontB8))
        col5.Border = 0
        tabla3.AddCell(col5)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        col4 = New PdfPCell(New Phrase("Total: ", FontB8))
        col4.Border = 0
        tabla3.AddCell(col4)
        col5 = New PdfPCell(New Phrase(Entrada.totaltxt.Text, FontB8))
        col5.Border = 0
        tabla3.AddCell(col5)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        pdfdoc.Add(tabla3)

#End Region

        pdfdoc.Close()

        Process.Start(ruta)

    End Sub

    Private Function getDataTableEntrada()
        Dim dtable As New DataTable("dt")
        Dim sqlvac As String = "SELECT DETALLE_ENTRADA.ID_PRODUCTO,PRODUCTOS.NOM_PRODUCTO, PRODUCTOS.MARCA_PRODUCTO, PRODUCTOS.MODELO_PRODUCTO, PRODUCTOS.PU_PRODUCTO,DETALLE_ENTRADA.CANTIDAD,DETALLE_ENTRADA.TOTAL FROM DETALLE_ENTRADA
        INNER Join PRODUCTOS ON DETALLE_ENTRADA.ID_PRODUCTO=PRODUCTOS.ID_PRODUCTO WHERE DETALLE_ENTRADA.ID_ENTRADA='" + Entrada.identxt.Text + "'"

        Dim cmd5 As New SqlCommand(sqlvac, con)

        Dim CantReg As Integer
        Dim sql2 As String = "SELECT COUNT(*) FROM DETALLE_ENTRADA WHERE DETALLE_ENTRADA.ID_ENTRADA='" + Entrada.identxt.Text + "'"
        Dim cmd As New SqlCommand(sql2, con)
        Dim rs As SqlDataReader

        con.Open()
        rs = cmd.ExecuteReader
        rs.Read()
        CantReg = CInt(rs(0))
        con.Close()

        Try
            Dim da As New SqlDataAdapter(cmd5)

            da.Fill(dtable)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dtable
    End Function

    Sub pdfSalida(ByVal sfdr As SaveFileDialog, ByVal qr As Byte())
        sfdr.ShowDialog()
        Dim ruta As String = sfdr.FileName
        Dim pdfdoc As New Document(itextsharp.text.PageSize.A4, 15.0F, 15.0F, 30.0F, 30.0F)
        pdfWrite = PdfWriter.GetInstance(pdfdoc, New FileStream(ruta, FileMode.Create))

        Dim FontB As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, itextsharp.text.Font.NORMAL))
        Dim FontB8 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 8, itextsharp.text.Font.BOLD))
        Dim FontB12 As New Font(FontFactory.GetFont(FontFactory.HELVETICA, 12, itextsharp.text.Font.BOLD))
        Dim pcolum As New Font(itextsharp.text.Font.FontFamily.HELVETICA, 9, itextsharp.text.Font.BOLD, BaseColor.BLACK)
        Dim pfila As New Font(itextsharp.text.Font.FontFamily.HELVETICA, 9, itextsharp.text.Font.BOLD, BaseColor.BLACK)
        Dim Cvacio As PdfPCell = New PdfPCell(New Phrase("  "))
        Cvacio.Border = 0

        pdfdoc.Open()

        Dim tabla1 As PdfPTable = New PdfPTable(4)
        Dim col1 As New PdfPCell
        Dim col2 As New PdfPCell
        Dim col3 As New PdfPCell
        Dim col4 As New PdfPCell
        Dim col5 As New PdfPCell
        Dim col6 As New PdfPCell
        Dim col7 As New PdfPCell
        'Dim ILine As Integer
        'Dim IFila As Integer

        tabla1.WidthPercentage = 95

        Dim whidths As Single() = New Single() {4.0F, 7.0F, 1.0F, 4.0F}
        tabla1.SetWidths(whidths)

#Region "Encabezado"

        Dim imgurl As String = Application.StartupPath & "\Imagenes\Logo_header_desktop.png"
        Dim img As itextsharp.text.Image
        img = itextsharp.text.Image.GetInstance(imgurl)
        img.ScaleToFit(110.0F, 140.0F)
        img.SpacingBefore = 20.0F
        img.SpacingAfter = 10.0F
        img.SetAbsolutePosition(35, 780)
        pdfdoc.Add(img)

        tabla1.AddCell(Cvacio)
        col2 = New PdfPCell(New Phrase("SODIMAC S.A.", FontB8))
        col2.Border = 0
        tabla1.AddCell(col2)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)

        col2 = New PdfPCell(New Phrase("Av. José De Lama S/N Cruce con Av. Las Dalias, Sullana 20103", FontB))
        col2.Border = 0
        tabla1.AddCell(col2)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)

        col2 = New PdfPCell(New Phrase("SULLANA", FontB))
        col2.Border = 0
        tabla1.AddCell(col2)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)

        col2 = New PdfPCell(New Phrase("(01) 2030420", FontB))
        col2.Border = 0
        tabla1.AddCell(col2)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)


        Dim img2 As itextsharp.text.Image
        img2 = itextsharp.text.Image.GetInstance(qr)
        img2.ScaleToFit(60.0F, 90.0F)
        img2.SpacingBefore = 20.0F
        img2.SpacingAfter = 10.0F
        img2.SetAbsolutePosition(460, 750)
        pdfdoc.Add(img2)

        tabla1.AddCell(Cvacio)
        tabla1.AddCell(Cvacio)
        col4 = New PdfPCell(New Phrase("N° " + Salida.idsaltxt.Text, FontB))
        tabla1.AddCell(col4)

        pdfdoc.Add(tabla1)

#End Region

#Region "DATOS"

        Dim CLinea As PdfPCell = New PdfPCell(New Phrase("  "))
        CLinea.Colspan = 4
        CLinea.Border = 2

        Dim tabla2 As PdfPTable = New PdfPTable(4)
        Dim whidths2 As Single() = New Single() {2.0F, 8.0F, 3.0F, 2.0F}
        tabla2.WidthPercentage = 95
        tabla2.SetWidths(whidths2)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(CLinea)
        col1 = New PdfPCell(New Phrase("Usuario: ", FontB8))
        col1.Border = 0
        tabla2.AddCell(col1)
        col2 = New PdfPCell(New Phrase(Login.user, FontB8))
        col2.Border = 0
        tabla2.AddCell(col2)
        col3 = New PdfPCell(New Phrase("Fecha de Reporte: ", FontB8))
        col3.Border = 0
        tabla2.AddCell(col3)
        col4 = New PdfPCell(New Phrase(Now, FontB8))
        col4.Border = 0
        tabla2.AddCell(col4)
        col1 = New PdfPCell(New Phrase("Cliente: ", FontB8))
        col1.Border = 0
        tabla2.AddCell(col1)
        col2 = New PdfPCell(New Phrase(Salida.clientetxt.Text, FontB8))
        col2.Border = 0
        tabla2.AddCell(col2)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(CLinea)

        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)
        tabla2.AddCell(Cvacio)

        pdfdoc.Add(tabla2)

#End Region

#Region "Detalle"
        Dim tablaD As New PdfPTable(7)
        tablaD.TotalWidth = 550.0F
        tablaD.LockedWidth = True
        tablaD.HorizontalAlignment = Element.ALIGN_CENTER
        tablaD.HeaderRows = 1

        Dim widths3 As Single() = New Single() {0.8F, 3.0F, 0.8F, 0.8F, 0.5F, 0.5F, 0.5F}
        tablaD.SetWidths(widths3)

        Dim pdfcell As PdfPCell = Nothing

        pdfcell = New PdfPCell(New Paragraph("CODIGO", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("PRODUCTO", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("MARCA", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("MODELO", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_CENTER
        pdfcell.MinimumHeight = 18
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)


        pdfcell = New PdfPCell(New Paragraph("P.U", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("CANT.", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        pdfcell = New PdfPCell(New Paragraph("TOTAL", pcolum))
        pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
        pdfcell.MinimumHeight = 12
        pdfcell.PaddingLeft = 5.0F
        pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
        tablaD.AddCell(pdfcell)

        Dim dt As DataTable = getDataTableSalida()

        For i = 0 To dt.Rows.Count - 1
            For j = 0 To dt.Columns.Count - 1
                pdfcell = New PdfPCell(New Paragraph(dt.Rows(i)(j).ToString, pfila))
                pdfcell.MinimumHeight = 18
                pdfcell.PaddingLeft = 5.0F
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                tablaD.AddCell(pdfcell)
            Next
        Next

        pdfdoc.Add(tablaD)

#End Region

#Region "Totales"

        Dim tabla3 As PdfPTable = New PdfPTable(5)
        Dim whidths3 As Single() = New Single() {2.0F, 8.0F, 3.0F, 2.0F, 2.0F}
        tabla3.WidthPercentage = 95
        tabla3.SetWidths(whidths3)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)

        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        col4 = New PdfPCell(New Phrase("SubTotal: ", FontB8))
        col4.Border = 0
        tabla3.AddCell(col4)
        col5 = New PdfPCell(New Phrase(Salida.subttxt.Text, FontB8))
        col5.Border = 0
        tabla3.AddCell(col5)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        col4 = New PdfPCell(New Phrase("IGV: ", FontB8))
        col4.Border = 0
        tabla3.AddCell(col4)
        col5 = New PdfPCell(New Phrase(Salida.igvtxt.Text, FontB8))
        col5.Border = 0
        tabla3.AddCell(col5)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        col4 = New PdfPCell(New Phrase("Total: ", FontB8))
        col4.Border = 0
        tabla3.AddCell(col4)
        col5 = New PdfPCell(New Phrase(Salida.totaltxt.Text, FontB8))
        col5.Border = 0
        tabla3.AddCell(col5)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        tabla3.AddCell(Cvacio)
        pdfdoc.Add(tabla3)

#End Region

        pdfdoc.Close()

        Process.Start(ruta)

    End Sub

    Private Function getDataTableSalida()
        Dim dtable As New DataTable("dt")
        Dim sqlvac As String = "SELECT DETALLE_SALIDA.ID_PRODUCTO,PRODUCTOS.NOM_PRODUCTO, PRODUCTOS.MARCA_PRODUCTO, PRODUCTOS.MODELO_PRODUCTO, PRODUCTOS.PU_PRODUCTO,DETALLE_SALIDA.CANTIDAD,DETALLE_SALIDA.TOTAL FROM DETALLE_SALIDA
        INNER JOIN PRODUCTOS ON DETALLE_SALIDA.ID_PRODUCTO=PRODUCTOS.ID_PRODUCTO WHERE DETALLE_SALIDA.ID_SALIDA='" + Salida.idsaltxt.Text + "'"

        Dim cmd5 As New SqlCommand(sqlvac, con)

        Dim CantReg As Integer
        Dim sql2 As String = "SELECT COUNT(*) FROM DETALLE_SALIDA WHERE DETALLE_SALIDA.ID_SALIDA='" + Salida.idsaltxt.Text + "'"
        Dim cmd As New SqlCommand(sql2, con)
        Dim rs As SqlDataReader

        con.Open()
        rs = cmd.ExecuteReader
        rs.Read()
        CantReg = CInt(rs(0))
        con.Close()

        Try
            Dim da As New SqlDataAdapter(cmd5)

            da.Fill(dtable)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return dtable
    End Function


End Module
