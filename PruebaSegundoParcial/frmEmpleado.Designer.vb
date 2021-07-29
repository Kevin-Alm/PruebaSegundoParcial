<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleado
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
        Me.DgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CboContrato = New System.Windows.Forms.ComboBox()
        Me.TxtSeguroSocial = New System.Windows.Forms.TextBox()
        Me.TxtApellidoMaterno = New System.Windows.Forms.TextBox()
        Me.TxtApellidoPaterno = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoPa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoMa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SeguroSocial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnAtras = New System.Windows.Forms.Button()
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvEmpleados
        '
        Me.DgvEmpleados.AllowUserToAddRows = False
        Me.DgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Sexo, Me.ApellidoPa, Me.ApellidoMa, Me.SeguroSocial, Me.Sueldo})
        Me.DgvEmpleados.Location = New System.Drawing.Point(844, 26)
        Me.DgvEmpleados.Name = "DgvEmpleados"
        Me.DgvEmpleados.Size = New System.Drawing.Size(544, 343)
        Me.DgvEmpleados.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BtnLimpiar)
        Me.GroupBox1.Controls.Add(Me.CboSexo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.CboContrato)
        Me.GroupBox1.Controls.Add(Me.TxtSeguroSocial)
        Me.GroupBox1.Controls.Add(Me.TxtApellidoMaterno)
        Me.GroupBox1.Controls.Add(Me.TxtApellidoPaterno)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(203, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(635, 313)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(535, 258)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 38)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Registrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CboContrato
        '
        Me.CboContrato.FormattingEnabled = True
        Me.CboContrato.Items.AddRange(New Object() {"T", "F"})
        Me.CboContrato.Location = New System.Drawing.Point(189, 238)
        Me.CboContrato.Name = "CboContrato"
        Me.CboContrato.Size = New System.Drawing.Size(121, 21)
        Me.CboContrato.TabIndex = 8
        Me.CboContrato.Text = "T"
        '
        'TxtSeguroSocial
        '
        Me.TxtSeguroSocial.Location = New System.Drawing.Point(91, 171)
        Me.TxtSeguroSocial.Name = "TxtSeguroSocial"
        Me.TxtSeguroSocial.Size = New System.Drawing.Size(254, 20)
        Me.TxtSeguroSocial.TabIndex = 7
        '
        'TxtApellidoMaterno
        '
        Me.TxtApellidoMaterno.Location = New System.Drawing.Point(336, 105)
        Me.TxtApellidoMaterno.Name = "TxtApellidoMaterno"
        Me.TxtApellidoMaterno.Size = New System.Drawing.Size(254, 20)
        Me.TxtApellidoMaterno.TabIndex = 6
        '
        'TxtApellidoPaterno
        '
        Me.TxtApellidoPaterno.Location = New System.Drawing.Point(76, 105)
        Me.TxtApellidoPaterno.Name = "TxtApellidoPaterno"
        Me.TxtApellidoPaterno.Size = New System.Drawing.Size(254, 20)
        Me.TxtApellidoPaterno.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contrato :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Seguro social :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sexo :"
        '
        'CboSexo
        '
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Items.AddRange(New Object() {"Masculino", "Femenino "})
        Me.CboSexo.Location = New System.Drawing.Point(91, 41)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(121, 21)
        Me.CboSexo.TabIndex = 11
        Me.CboSexo.Text = "Masculino"
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
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(375, 258)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(94, 38)
        Me.BtnLimpiar.TabIndex = 12
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Location = New System.Drawing.Point(1278, 401)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(110, 47)
        Me.BtnSalir.TabIndex = 10
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnAtras
        '
        Me.BtnAtras.Location = New System.Drawing.Point(18, 401)
        Me.BtnAtras.Name = "BtnAtras"
        Me.BtnAtras.Size = New System.Drawing.Size(110, 47)
        Me.BtnAtras.TabIndex = 11
        Me.BtnAtras.Text = "Atras"
        Me.BtnAtras.UseVisualStyleBackColor = True
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PruebaSegundoParcial.My.Resources.Resources.WhatsApp_Image_2021_06_24_at_09_35_14
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1400, 460)
        Me.Controls.Add(Me.BtnAtras)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.DgvEmpleados)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.DarkGreen
        Me.Name = "frmEmpleado"
        Me.Text = "Registro de Datos "
        CType(Me.DgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvEmpleados As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents CboContrato As ComboBox
    Friend WithEvents TxtSeguroSocial As TextBox
    Friend WithEvents TxtApellidoMaterno As TextBox
    Friend WithEvents TxtApellidoPaterno As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Sexo As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoPa As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoMa As DataGridViewTextBoxColumn
    Friend WithEvents SeguroSocial As DataGridViewTextBoxColumn
    Friend WithEvents Sueldo As DataGridViewTextBoxColumn
    Friend WithEvents CboSexo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnAtras As Button
End Class
