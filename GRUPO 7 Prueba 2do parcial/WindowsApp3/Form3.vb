Imports CLASES1
Public Class Form3
    Private Sub REGISTRAR1_Click(sender As Object, e As EventArgs) Handles REGISTRAR1.Click
        Dim empleado1 As EMPLEADO = New EMPLEADO()
        empleado1.tipocontrato = CB1.Text

        empleado1.calcularsueldo(750)

        DGVEMPLEADO.Rows.Insert(0, empleado1.tipocontrato, empleado1.sueldo)
    End Sub
End Class