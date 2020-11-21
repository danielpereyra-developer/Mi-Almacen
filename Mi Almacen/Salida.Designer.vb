<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salida
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.impbtn = New System.Windows.Forms.Button()
        Me.grabbtn = New System.Windows.Forms.Button()
        Me.totaltxt = New System.Windows.Forms.TextBox()
        Me.igvtxt = New System.Windows.Forms.TextBox()
        Me.subttxt = New System.Windows.Forms.TextBox()
        Me.quitbtn = New System.Windows.Forms.Button()
        Me.prodbtn = New System.Windows.Forms.Button()
        Me.detalledgv = New System.Windows.Forms.DataGridView()
        Me.clientetxt = New System.Windows.Forms.TextBox()
        Me.nomustxt = New System.Windows.Forms.TextBox()
        Me.fechtxt = New System.Windows.Forms.TextBox()
        Me.idsaltxt = New System.Windows.Forms.TextBox()
        Me.logopb = New System.Windows.Forms.PictureBox()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        CType(Me.detalledgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logopb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(384, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Cliente"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(449, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(620, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(620, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "ID"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(552, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "TOTAL"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(569, 390)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "IGV"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(532, 364)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "SUBTOTAL"
        '
        'impbtn
        '
        Me.impbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.impbtn.Location = New System.Drawing.Point(366, 465)
        Me.impbtn.Name = "impbtn"
        Me.impbtn.Size = New System.Drawing.Size(156, 36)
        Me.impbtn.TabIndex = 32
        Me.impbtn.Text = "IMPRIMIR PDF"
        Me.impbtn.UseVisualStyleBackColor = True
        '
        'grabbtn
        '
        Me.grabbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grabbtn.Location = New System.Drawing.Point(586, 465)
        Me.grabbtn.Name = "grabbtn"
        Me.grabbtn.Size = New System.Drawing.Size(156, 36)
        Me.grabbtn.TabIndex = 31
        Me.grabbtn.Text = "GRABAR"
        Me.grabbtn.UseVisualStyleBackColor = True
        '
        'totaltxt
        '
        Me.totaltxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.totaltxt.Location = New System.Drawing.Point(600, 413)
        Me.totaltxt.Name = "totaltxt"
        Me.totaltxt.Size = New System.Drawing.Size(142, 20)
        Me.totaltxt.TabIndex = 30
        '
        'igvtxt
        '
        Me.igvtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.igvtxt.Location = New System.Drawing.Point(600, 387)
        Me.igvtxt.Name = "igvtxt"
        Me.igvtxt.Size = New System.Drawing.Size(142, 20)
        Me.igvtxt.TabIndex = 29
        '
        'subttxt
        '
        Me.subttxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.subttxt.Location = New System.Drawing.Point(600, 361)
        Me.subttxt.Name = "subttxt"
        Me.subttxt.Size = New System.Drawing.Size(142, 20)
        Me.subttxt.TabIndex = 28
        '
        'quitbtn
        '
        Me.quitbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.quitbtn.Location = New System.Drawing.Point(691, 155)
        Me.quitbtn.Name = "quitbtn"
        Me.quitbtn.Size = New System.Drawing.Size(75, 35)
        Me.quitbtn.TabIndex = 27
        Me.quitbtn.Text = "ELIMINAR"
        Me.quitbtn.UseVisualStyleBackColor = True
        '
        'prodbtn
        '
        Me.prodbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.prodbtn.Location = New System.Drawing.Point(600, 155)
        Me.prodbtn.Name = "prodbtn"
        Me.prodbtn.Size = New System.Drawing.Size(85, 35)
        Me.prodbtn.TabIndex = 26
        Me.prodbtn.Text = "PRODUCTOS"
        Me.prodbtn.UseVisualStyleBackColor = True
        '
        'detalledgv
        '
        Me.detalledgv.AllowUserToAddRows = False
        Me.detalledgv.AllowUserToDeleteRows = False
        Me.detalledgv.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.detalledgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.detalledgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.detalledgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.detalledgv.Location = New System.Drawing.Point(52, 196)
        Me.detalledgv.Name = "detalledgv"
        Me.detalledgv.ReadOnly = True
        Me.detalledgv.RowHeadersVisible = False
        Me.detalledgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.detalledgv.Size = New System.Drawing.Size(714, 159)
        Me.detalledgv.TabIndex = 25
        '
        'clientetxt
        '
        Me.clientetxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.clientetxt.Location = New System.Drawing.Point(452, 117)
        Me.clientetxt.Name = "clientetxt"
        Me.clientetxt.Size = New System.Drawing.Size(308, 20)
        Me.clientetxt.TabIndex = 24
        '
        'nomustxt
        '
        Me.nomustxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nomustxt.Location = New System.Drawing.Point(535, 91)
        Me.nomustxt.Name = "nomustxt"
        Me.nomustxt.Size = New System.Drawing.Size(225, 20)
        Me.nomustxt.TabIndex = 23
        '
        'fechtxt
        '
        Me.fechtxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fechtxt.Location = New System.Drawing.Point(660, 52)
        Me.fechtxt.Name = "fechtxt"
        Me.fechtxt.Size = New System.Drawing.Size(100, 20)
        Me.fechtxt.TabIndex = 22
        '
        'idsaltxt
        '
        Me.idsaltxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.idsaltxt.Location = New System.Drawing.Point(660, 25)
        Me.idsaltxt.Name = "idsaltxt"
        Me.idsaltxt.Size = New System.Drawing.Size(100, 20)
        Me.idsaltxt.TabIndex = 21
        '
        'logopb
        '
        Me.logopb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.logopb.Image = Global.Mi_Almacen.My.Resources.Resources._027_distribution
        Me.logopb.Location = New System.Drawing.Point(106, 25)
        Me.logopb.Name = "logopb"
        Me.logopb.Size = New System.Drawing.Size(218, 144)
        Me.logopb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logopb.TabIndex = 20
        Me.logopb.TabStop = False
        '
        'sfd
        '
        Me.sfd.Filter = "PDF|*.pdf"
        '
        'Salida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 527)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.impbtn)
        Me.Controls.Add(Me.grabbtn)
        Me.Controls.Add(Me.totaltxt)
        Me.Controls.Add(Me.igvtxt)
        Me.Controls.Add(Me.subttxt)
        Me.Controls.Add(Me.quitbtn)
        Me.Controls.Add(Me.prodbtn)
        Me.Controls.Add(Me.detalledgv)
        Me.Controls.Add(Me.clientetxt)
        Me.Controls.Add(Me.nomustxt)
        Me.Controls.Add(Me.fechtxt)
        Me.Controls.Add(Me.idsaltxt)
        Me.Controls.Add(Me.logopb)
        Me.Name = "Salida"
        Me.Text = "Salida"
        CType(Me.detalledgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logopb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents impbtn As Button
    Friend WithEvents grabbtn As Button
    Friend WithEvents totaltxt As TextBox
    Friend WithEvents igvtxt As TextBox
    Friend WithEvents subttxt As TextBox
    Friend WithEvents quitbtn As Button
    Friend WithEvents prodbtn As Button
    Friend WithEvents detalledgv As DataGridView
    Friend WithEvents clientetxt As TextBox
    Friend WithEvents nomustxt As TextBox
    Friend WithEvents fechtxt As TextBox
    Friend WithEvents idsaltxt As TextBox
    Friend WithEvents logopb As PictureBox
    Friend WithEvents sfd As SaveFileDialog
End Class
