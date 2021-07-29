Imports Clases2

Public Class frmEmpleado
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empleadoP As Empleados = New Empleados()
        empleadoP.ApellidoPaterno = TxtApellidoPaterno.Text
        empleadoP.ApellidoMaterno = TxtApellidoMaterno.Text
        empleadoP.Sexo = CboSexo.Text
        empleadoP.NumeroSeguroSocial = TxtSeguroSocial.Text
        empleadoP.TipoContrato = CboContrato.Text

        empleadoP.calcularSueldo(400)

        DgvEmpleados.Rows.Insert(0, empleadoP.Sexo, empleadoP.ApellidoPaterno, empleadoP.ApellidoMaterno, empleadoP.NumeroSeguroSocial, empleadoP.Sueldo)
    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TxtApellidoMaterno.Clear()
        TxtApellidoPaterno.Clear()
        TxtSeguroSocial.Clear()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End
    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Hide()
        frmregistros.Show()
    End Sub
End Class