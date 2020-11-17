<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Categoria
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
        Me.codcattxt = New System.Windows.Forms.TextBox()
        Me.nomcattxt = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'codcattxt
        '
        Me.codcattxt.Location = New System.Drawing.Point(173, 140)
        Me.codcattxt.Name = "codcattxt"
        Me.codcattxt.Size = New System.Drawing.Size(100, 20)
        Me.codcattxt.TabIndex = 0
        '
        'nomcattxt
        '
        Me.nomcattxt.Location = New System.Drawing.Point(169, 197)
        Me.nomcattxt.Name = "nomcattxt"
        Me.nomcattxt.Size = New System.Drawing.Size(376, 20)
        Me.nomcattxt.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(484, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "AGREGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nomcattxt)
        Me.Controls.Add(Me.codcattxt)
        Me.Name = "Categoria"
        Me.Text = "NUEVA CATEGORIA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents codcattxt As TextBox
    Friend WithEvents nomcattxt As TextBox
    Friend WithEvents Button1 As Button
End Class
