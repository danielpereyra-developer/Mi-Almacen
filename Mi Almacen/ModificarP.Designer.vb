<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarP
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
        Me.Button5 = New System.Windows.Forms.Button()
        Me.puptxt = New System.Windows.Forms.TextBox()
        Me.exptxt = New System.Windows.Forms.TextBox()
        Me.cantmtxt = New System.Windows.Forms.TextBox()
        Me.ubiccb = New System.Windows.Forms.ComboBox()
        Me.subcatpcb = New System.Windows.Forms.ComboBox()
        Me.catpcb = New System.Windows.Forms.ComboBox()
        Me.modeloptxt = New System.Windows.Forms.TextBox()
        Me.marcaptxt = New System.Windows.Forms.TextBox()
        Me.nomptxt = New System.Windows.Forms.TextBox()
        Me.exabtn = New System.Windows.Forms.Button()
        Me.imagenpb = New System.Windows.Forms.PictureBox()
        Me.codtxt = New System.Windows.Forms.TextBox()
        Me.Archivos = New System.Windows.Forms.OpenFileDialog()
        CType(Me.imagenpb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(657, 398)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 36
        Me.Button5.Text = "EDITAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'puptxt
        '
        Me.puptxt.Location = New System.Drawing.Point(388, 368)
        Me.puptxt.Name = "puptxt"
        Me.puptxt.Size = New System.Drawing.Size(148, 20)
        Me.puptxt.TabIndex = 35
        '
        'exptxt
        '
        Me.exptxt.Location = New System.Drawing.Point(575, 314)
        Me.exptxt.Name = "exptxt"
        Me.exptxt.Size = New System.Drawing.Size(148, 20)
        Me.exptxt.TabIndex = 34
        '
        'cantmtxt
        '
        Me.cantmtxt.Location = New System.Drawing.Point(388, 314)
        Me.cantmtxt.Name = "cantmtxt"
        Me.cantmtxt.Size = New System.Drawing.Size(148, 20)
        Me.cantmtxt.TabIndex = 33
        '
        'ubiccb
        '
        Me.ubiccb.FormattingEnabled = True
        Me.ubiccb.Location = New System.Drawing.Point(388, 241)
        Me.ubiccb.Name = "ubiccb"
        Me.ubiccb.Size = New System.Drawing.Size(344, 21)
        Me.ubiccb.TabIndex = 32
        '
        'subcatpcb
        '
        Me.subcatpcb.FormattingEnabled = True
        Me.subcatpcb.Location = New System.Drawing.Point(575, 188)
        Me.subcatpcb.Name = "subcatpcb"
        Me.subcatpcb.Size = New System.Drawing.Size(148, 21)
        Me.subcatpcb.TabIndex = 29
        '
        'catpcb
        '
        Me.catpcb.FormattingEnabled = True
        Me.catpcb.Location = New System.Drawing.Point(388, 188)
        Me.catpcb.Name = "catpcb"
        Me.catpcb.Size = New System.Drawing.Size(148, 21)
        Me.catpcb.TabIndex = 28
        '
        'modeloptxt
        '
        Me.modeloptxt.Location = New System.Drawing.Point(575, 129)
        Me.modeloptxt.Name = "modeloptxt"
        Me.modeloptxt.Size = New System.Drawing.Size(148, 20)
        Me.modeloptxt.TabIndex = 27
        '
        'marcaptxt
        '
        Me.marcaptxt.Location = New System.Drawing.Point(388, 129)
        Me.marcaptxt.Name = "marcaptxt"
        Me.marcaptxt.Size = New System.Drawing.Size(148, 20)
        Me.marcaptxt.TabIndex = 26
        '
        'nomptxt
        '
        Me.nomptxt.Location = New System.Drawing.Point(575, 77)
        Me.nomptxt.Name = "nomptxt"
        Me.nomptxt.Size = New System.Drawing.Size(148, 20)
        Me.nomptxt.TabIndex = 25
        '
        'exabtn
        '
        Me.exabtn.Location = New System.Drawing.Point(265, 74)
        Me.exabtn.Name = "exabtn"
        Me.exabtn.Size = New System.Drawing.Size(75, 23)
        Me.exabtn.TabIndex = 24
        Me.exabtn.Text = "EXAMINAR"
        Me.exabtn.UseVisualStyleBackColor = True
        '
        'imagenpb
        '
        Me.imagenpb.Location = New System.Drawing.Point(63, 129)
        Me.imagenpb.Name = "imagenpb"
        Me.imagenpb.Size = New System.Drawing.Size(277, 231)
        Me.imagenpb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imagenpb.TabIndex = 23
        Me.imagenpb.TabStop = False
        '
        'codtxt
        '
        Me.codtxt.Enabled = False
        Me.codtxt.Location = New System.Drawing.Point(388, 77)
        Me.codtxt.Name = "codtxt"
        Me.codtxt.Size = New System.Drawing.Size(148, 20)
        Me.codtxt.TabIndex = 21
        '
        'Archivos
        '
        Me.Archivos.FileName = "OpenFileDialog1"
        '
        'ModificarP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.puptxt)
        Me.Controls.Add(Me.exptxt)
        Me.Controls.Add(Me.cantmtxt)
        Me.Controls.Add(Me.ubiccb)
        Me.Controls.Add(Me.subcatpcb)
        Me.Controls.Add(Me.catpcb)
        Me.Controls.Add(Me.modeloptxt)
        Me.Controls.Add(Me.marcaptxt)
        Me.Controls.Add(Me.nomptxt)
        Me.Controls.Add(Me.exabtn)
        Me.Controls.Add(Me.imagenpb)
        Me.Controls.Add(Me.codtxt)
        Me.Name = "ModificarP"
        Me.Text = "ModificarP"
        CType(Me.imagenpb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents puptxt As TextBox
    Friend WithEvents exptxt As TextBox
    Friend WithEvents cantmtxt As TextBox
    Friend WithEvents ubiccb As ComboBox
    Friend WithEvents subcatpcb As ComboBox
    Friend WithEvents catpcb As ComboBox
    Friend WithEvents modeloptxt As TextBox
    Friend WithEvents marcaptxt As TextBox
    Friend WithEvents nomptxt As TextBox
    Friend WithEvents exabtn As Button
    Friend WithEvents imagenpb As PictureBox
    Friend WithEvents codtxt As TextBox
    Friend WithEvents Archivos As OpenFileDialog
End Class
