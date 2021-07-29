Imports Clases2
Public Class frmCliente

    Private Sub BtnGenerar_Click(sender As Object, e As EventArgs) Handles BtnGenerar.Click

        Dim empleadoP As Empleados = New Empleados()
        empleadoP.ApellidoPaterno = frmEmpleado.TxtApellidoPaterno.Text
        empleadoP.ApellidoMaterno = frmEmpleado.TxtApellidoMaterno.Text
        empleadoP.Sexo = frmEmpleado.CboSexo.Text
        empleadoP.NumeroSeguroSocial = frmEmpleado.TxtSeguroSocial.Text
        empleadoP.TipoContrato = frmEmpleado.CboContrato.Text

        empleadoP.calcularSueldo(400)

        DgvCliente.Rows.Insert(0, empleadoP.Sexo, empleadoP.ApellidoPaterno, empleadoP.ApellidoMaterno, empleadoP.NumeroSeguroSocial, empleadoP.Sueldo)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnSalir.Click
        End

    End Sub

    Private Sub BtnAtras_Click(sender As Object, e As EventArgs) Handles BtnAtras.Click
        Me.Hide()
        frmregistros.Show()
    End Sub
End Class