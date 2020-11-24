<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NSalida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NSalida))
        Me.cliente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cancbtn = New System.Windows.Forms.Button()
        Me.ingsalbtn = New System.Windows.Forms.Button()
        Me.ususttxt = New System.Windows.Forms.TextBox()
        Me.fechasaltxt = New System.Windows.Forms.TextBox()
        Me.idsaltxt = New System.Windows.Forms.TextBox()
        Me.clientetxt = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cliente
        '
        Me.cliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cliente.AutoSize = True
        Me.cliente.Location = New System.Drawing.Point(72, 267)
        Me.cliente.Name = "cliente"
        Me.cliente.Size = New System.Drawing.Size(39, 13)
        Me.cliente.TabIndex = 23
        Me.cliente.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Usuario en Turno"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(280, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "FECHA"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(280, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "ID"
        '
        'cancbtn
        '
        Me.cancbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cancbtn.Location = New System.Drawing.Point(183, 316)
        Me.cancbtn.Name = "cancbtn"
        Me.cancbtn.Size = New System.Drawing.Size(75, 23)
        Me.cancbtn.TabIndex = 17
        Me.cancbtn.Text = "CANCELAR"
        Me.cancbtn.UseVisualStyleBackColor = True
        '
        'ingsalbtn
        '
        Me.ingsalbtn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ingsalbtn.Location = New System.Drawing.Point(317, 316)
        Me.ingsalbtn.Name = "ingsalbtn"
        Me.ingsalbtn.Size = New System.Drawing.Size(75, 23)
        Me.ingsalbtn.TabIndex = 16
        Me.ingsalbtn.Text = "INGRESAR"
        Me.ingsalbtn.UseVisualStyleBackColor = True
        '
        'ususttxt
        '
        Me.ususttxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ususttxt.Location = New System.Drawing.Point(171, 226)
        Me.ususttxt.Name = "ususttxt"
        Me.ususttxt.Size = New System.Drawing.Size(272, 20)
        Me.ususttxt.TabIndex = 15
        '
        'fechasaltxt
        '
        Me.fechasaltxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.fechasaltxt.Location = New System.Drawing.Point(343, 118)
        Me.fechasaltxt.Name = "fechasaltxt"
        Me.fechasaltxt.Size = New System.Drawing.Size(100, 20)
        Me.fechasaltxt.TabIndex = 14
        '
        'idsaltxt
        '
        Me.idsaltxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.idsaltxt.Location = New System.Drawing.Point(343, 85)
        Me.idsaltxt.Name = "idsaltxt"
        Me.idsaltxt.Size = New System.Drawing.Size(100, 20)
        Me.idsaltxt.TabIndex = 13
        '
        'clientetxt
        '
        Me.clientetxt.Location = New System.Drawing.Point(171, 264)
        Me.clientetxt.Name = "clientetxt"
        Me.clientetxt.Size = New System.Drawing.Size(272, 20)
        Me.clientetxt.TabIndex = 24
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.Mi_Almacen.My.Resources.Resources._009_checklist
        Me.PictureBox1.Location = New System.Drawing.Point(75, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 157)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'NSalida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(561, 396)
        Me.Controls.Add(Me.clientetxt)
        Me.Controls.Add(Me.cliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cancbtn)
        Me.Controls.Add(Me.ingsalbtn)
        Me.Controls.Add(Me.ususttxt)
        Me.Controls.Add(Me.fechasaltxt)
        Me.Controls.Add(Me.idsaltxt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "NSalida"
        Me.Text = "Nueva Salida"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cliente As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cancbtn As Button
    Friend WithEvents ingsalbtn As Button
    Friend WithEvents ususttxt As TextBox
    Friend WithEvents fechasaltxt As TextBox
    Friend WithEvents idsaltxt As TextBox
    Friend WithEvents clientetxt As TextBox
End Class
