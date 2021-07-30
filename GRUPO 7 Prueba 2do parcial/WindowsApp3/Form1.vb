Imports CLASES1

Public Class Form1
    Private Sub REGISTRAR_Click(sender As Object, e As EventArgs) Handles REGISTRAR.Click
        Dim cliente As CLIENTE = New CLIENTE()
        cliente.APELLIDOM = TM.Text
        cliente.APELLIDOP = TP.Text
        cliente.SeguroS = TXTSEG.Text
        cliente.Sexo = C1.Text
        cliente.codigo = CD1.Text


        DGVCLIENTES.Rows.Insert(0, cliente.Sexo, cliente.APELLIDOM, cliente.APELLIDOP, cliente.SeguroS, cliente.codigo)
    End Sub
End Class
