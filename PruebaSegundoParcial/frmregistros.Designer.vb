<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmregistros
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCliente = New System.Windows.Forms.Button()
        Me.BtnEmpleado = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRUEBA SEGUNDO PARCIAL"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnEmpleado)
        Me.GroupBox1.Controls.Add(Me.BtnCliente)
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Location = New System.Drawing.Point(75, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(342, 242)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "JERARQUIA"
        '
        'BtnCliente
        '
        Me.BtnCliente.Location = New System.Drawing.Point(98, 37)
        Me.BtnCliente.Name = "BtnCliente"
        Me.BtnCliente.Size = New System.Drawing.Size(146, 67)
        Me.BtnCliente.TabIndex = 0
        Me.BtnCliente.Text = "CLIENTE"
        Me.BtnCliente.UseVisualStyleBackColor = True
        '
        'BtnEmpleado
        '
        Me.BtnEmpleado.Location = New System.Drawing.Point(98, 155)
        Me.BtnEmpleado.Name = "BtnEmpleado"
        Me.BtnEmpleado.Size = New System.Drawing.Size(146, 67)
        Me.BtnEmpleado.TabIndex = 1
        Me.BtnEmpleado.Text = "EMPLEADO"
        Me.BtnEmpleado.UseVisualStyleBackColor = True
        '
        'frmregistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BackgroundImage = Global.PruebaSegundoParcial.My.Resources.Resources.WhatsApp_Image_2021_06_24_at_09_35_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(429, 402)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.Name = "frmregistros"
        Me.Text = "frmregistros"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnEmpleado As Button
    Friend WithEvents BtnCliente As Button
End Class
