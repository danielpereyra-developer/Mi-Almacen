<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NEntrada
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
        Me.identtxt = New System.Windows.Forms.TextBox()
        Me.fechaenttxt = New System.Windows.Forms.TextBox()
        Me.ususttxt = New System.Windows.Forms.TextBox()
        Me.ingentbtn = New System.Windows.Forms.Button()
        Me.cancbtn = New System.Windows.Forms.Button()
        Me.provcb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.provtxt = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'identtxt
        '
        Me.identtxt.Location = New System.Drawing.Point(342, 81)
        Me.identtxt.Name = "identtxt"
        Me.identtxt.Size = New System.Drawing.Size(100, 20)
        Me.identtxt.TabIndex = 1
        '
        'fechaenttxt
        '
        Me.fechaenttxt.Location = New System.Drawing.Point(342, 114)
        Me.fechaenttxt.Name = "fechaenttxt"
        Me.fechaenttxt.Size = New System.Drawing.Size(100, 20)
        Me.fechaenttxt.TabIndex = 2
        '
        'ususttxt
        '
        Me.ususttxt.Location = New System.Drawing.Point(170, 222)
        Me.ususttxt.Name = "ususttxt"
        Me.ususttxt.Size = New System.Drawing.Size(272, 20)
        Me.ususttxt.TabIndex = 3
        '
        'ingentbtn
        '
        Me.ingentbtn.Location = New System.Drawing.Point(316, 312)
        Me.ingentbtn.Name = "ingentbtn"
        Me.ingentbtn.Size = New System.Drawing.Size(75, 23)
        Me.ingentbtn.TabIndex = 5
        Me.ingentbtn.Text = "INGRESAR"
        Me.ingentbtn.UseVisualStyleBackColor = True
        '
        'cancbtn
        '
        Me.cancbtn.Location = New System.Drawing.Point(182, 312)
        Me.cancbtn.Name = "cancbtn"
        Me.cancbtn.Size = New System.Drawing.Size(75, 23)
        Me.cancbtn.TabIndex = 6
        Me.cancbtn.Text = "CANCELAR"
        Me.cancbtn.UseVisualStyleBackColor = True
        '
        'provcb
        '
        Me.provcb.FormattingEnabled = True
        Me.provcb.Location = New System.Drawing.Point(170, 260)
        Me.provcb.Name = "provcb"
        Me.provcb.Size = New System.Drawing.Size(272, 21)
        Me.provcb.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(279, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(279, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "FECHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Usuario en Turno"
        '
        'provtxt
        '
        Me.provtxt.AutoSize = True
        Me.provtxt.Location = New System.Drawing.Point(71, 263)
        Me.provtxt.Name = "provtxt"
        Me.provtxt.Size = New System.Drawing.Size(56, 13)
        Me.provtxt.TabIndex = 12
        Me.provtxt.Text = "Proveedor"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Mi_Almacen.My.Resources.Resources._009_checklist
        Me.PictureBox1.Location = New System.Drawing.Point(74, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'NEntrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 396)
        Me.Controls.Add(Me.provtxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.provcb)
        Me.Controls.Add(Me.cancbtn)
        Me.Controls.Add(Me.ingentbtn)
        Me.Controls.Add(Me.ususttxt)
        Me.Controls.Add(Me.fechaenttxt)
        Me.Controls.Add(Me.identtxt)
        Me.Name = "NEntrada"
        Me.Text = "ENTRADA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents identtxt As TextBox
    Friend WithEvents fechaenttxt As TextBox
    Friend WithEvents ususttxt As TextBox
    Friend WithEvents ingentbtn As Button
    Friend WithEvents cancbtn As Button
    Friend WithEvents provcb As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents provtxt As Label
End Class
