<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SUBCATEGORIA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SUBCATEGORIA))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nomscattxt = New System.Windows.Forms.TextBox()
        Me.codscattxt = New System.Windows.Forms.TextBox()
        Me.catrcb = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(187, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "AGREGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nomscattxt
        '
        Me.nomscattxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nomscattxt.Location = New System.Drawing.Point(203, 165)
        Me.nomscattxt.Name = "nomscattxt"
        Me.nomscattxt.Size = New System.Drawing.Size(190, 20)
        Me.nomscattxt.TabIndex = 4
        '
        'codscattxt
        '
        Me.codscattxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.codscattxt.Location = New System.Drawing.Point(161, 79)
        Me.codscattxt.Name = "codscattxt"
        Me.codscattxt.Size = New System.Drawing.Size(100, 20)
        Me.codscattxt.TabIndex = 3
        '
        'catrcb
        '
        Me.catrcb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.catrcb.FormattingEnabled = True
        Me.catrcb.Location = New System.Drawing.Point(161, 119)
        Me.catrcb.Name = "catrcb"
        Me.catrcb.Size = New System.Drawing.Size(198, 21)
        Me.catrcb.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(72, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Categoria"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(72, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Nombre de Subcategoria"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "* Ingrese Nueva Subcategoria"
        '
        'SUBCATEGORIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 298)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.catrcb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nomscattxt)
        Me.Controls.Add(Me.codscattxt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SUBCATEGORIA"
        Me.Text = "NUEVA SUBCATEGORIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents nomscattxt As TextBox
    Friend WithEvents codscattxt As TextBox
    Friend WithEvents catrcb As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
