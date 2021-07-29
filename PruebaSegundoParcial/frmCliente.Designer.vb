<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCliente
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
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnGenerar = New System.Windows.Forms.Button()
        Me.DgvCliente = New System.Windows.Forms.DataGridView()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoPa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoMa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeguroSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(649, 454)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(108, 40)
        Me.BtnSalir.TabIndex = 4
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Location = New System.Drawing.Point(12, 431)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(108, 40)
        Me.BtnAtras.TabIndex = 5
        Me.BtnAtras.Text = "Atras"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DgvCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 360)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'BtnGenerar
        '
        Me.BtnGenerar.Location = New System.Drawing.Point(640, 9)
        Me.BtnGenerar.Name = "BtnGenerar"
        Me.BtnGenerar.Size = New System.Drawing.Size(108, 40)
        Me.BtnGenerar.TabIndex = 5
        Me.BtnGenerar.Text = "Generar"
        Me.BtnGenerar.UseVisualStyleBackColor = True
        '
        'DgvCliente
        '
        Me.DgvCliente.AllowUserToAddRows = False
        Me.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sexo, Me.ApellidoPa, Me.ApellidoMa, Me.SeguroSocial, Me.Sueldo})
        Me.DgvCliente.Location = New System.Drawing.Point(84, 17)
        Me.DgvCliente.Name = "DgvCliente"
        Me.DgvCliente.Size = New System.Drawing.Size(544, 343)
        Me.DgvCliente.TabIndex = 4
        '
        'Sexo
        '
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        '
        'ApellidoPa
        '
        Me.ApellidoPa.HeaderText = "Apellido Paterno"
        Me.ApellidoPa.Name = "ApellidoPa"
        '
        'ApellidoMa
        '
        Me.ApellidoMa.HeaderText = "Apellido Materno"
        Me.ApellidoMa.Name = "ApellidoMa"
        '
        'SeguroSocial
        '
        Me.SeguroSocial.HeaderText = "Seguro Social"
        Me.SeguroSocial.Name = "SeguroSocial"
        '
        'Sueldo
        '
        Me.Sueldo.HeaderText = "Sueldo"
        Me.Sueldo.Name = "Sueldo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(363, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Registo para el cliente"
        '
        'frmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PruebaSegundoParcial.My.Resources.Resources.WhatsApp_Image_2021_06_24_at_09_35_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(760, 506)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnGenerar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnSalir)
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.Name = "frmCliente"
        Me.Text = "Cliente"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnAtras As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnGenerar As Button
    Friend WithEvents DgvCliente As DataGridView
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPa As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMa As DataGridViewTextBoxColumn
    Friend WithEvents SeguroSocial As DataGridViewTextBoxColumn
    Friend WithEvents Sueldo As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
