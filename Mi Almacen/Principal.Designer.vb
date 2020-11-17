<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.userlb = New System.Windows.Forms.Label()
        Me.horalb = New System.Windows.Forms.Label()
        Me.fechalb = New System.Windows.Forms.Label()
        Me.reloj = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "ENTRADAS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(196, 188)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "SALIDAS"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(314, 188)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 44)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "REPORTE ENTRADAS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(426, 188)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 44)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "REPORTE SALIDAS"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(543, 188)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(88, 44)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "INVENTARIO"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'userlb
        '
        Me.userlb.AutoSize = True
        Me.userlb.Location = New System.Drawing.Point(110, 82)
        Me.userlb.Name = "userlb"
        Me.userlb.Size = New System.Drawing.Size(21, 13)
        Me.userlb.TabIndex = 5
        Me.userlb.Text = "lllllll"
        '
        'horalb
        '
        Me.horalb.AutoSize = True
        Me.horalb.Location = New System.Drawing.Point(74, 299)
        Me.horalb.Name = "horalb"
        Me.horalb.Size = New System.Drawing.Size(39, 13)
        Me.horalb.TabIndex = 6
        Me.horalb.Text = "Label1"
        '
        'fechalb
        '
        Me.fechalb.AutoSize = True
        Me.fechalb.Location = New System.Drawing.Point(74, 341)
        Me.fechalb.Name = "fechalb"
        Me.fechalb.Size = New System.Drawing.Size(39, 13)
        Me.fechalb.TabIndex = 7
        Me.fechalb.Text = "Label1"
        '
        'reloj
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(716, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 450)
        Me.Controls.Add(Me.fechalb)
        Me.Controls.Add(Me.horalb)
        Me.Controls.Add(Me.userlb)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents userlb As Label
    Friend WithEvents horalb As Label
    Friend WithEvents fechalb As Label
    Friend WithEvents reloj As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
