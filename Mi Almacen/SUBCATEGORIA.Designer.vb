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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.nomscattxt = New System.Windows.Forms.TextBox()
        Me.codscattxt = New System.Windows.Forms.TextBox()
        Me.catrcb = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(520, 286)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "AGREGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'nomscattxt
        '
        Me.nomscattxt.Location = New System.Drawing.Point(209, 227)
        Me.nomscattxt.Name = "nomscattxt"
        Me.nomscattxt.Size = New System.Drawing.Size(376, 20)
        Me.nomscattxt.TabIndex = 4
        '
        'codscattxt
        '
        Me.codscattxt.Location = New System.Drawing.Point(209, 141)
        Me.codscattxt.Name = "codscattxt"
        Me.codscattxt.Size = New System.Drawing.Size(100, 20)
        Me.codscattxt.TabIndex = 3
        '
        'catrcb
        '
        Me.catrcb.FormattingEnabled = True
        Me.catrcb.Location = New System.Drawing.Point(209, 181)
        Me.catrcb.Name = "catrcb"
        Me.catrcb.Size = New System.Drawing.Size(198, 21)
        Me.catrcb.TabIndex = 6
        '
        'SUBCATEGORIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.catrcb)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nomscattxt)
        Me.Controls.Add(Me.codscattxt)
        Me.Name = "SUBCATEGORIA"
        Me.Text = "NUEVA SUBCATEGORIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents nomscattxt As TextBox
    Friend WithEvents codscattxt As TextBox
    Friend WithEvents catrcb As ComboBox
End Class
