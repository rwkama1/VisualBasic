Public Class FrmBuscarBuq
    Private Sub FrmBuscarBuq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarEventoTextBox()
    End Sub


    Private Sub textBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso (e.KeyChar <> "."c) Then
            e.Handled = True
        End If

        If (e.KeyChar = "."c) AndAlso ((TryCast(sender, TextBox)).Text.IndexOf("."c) > -1) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CargarEventoTextBox()
        AddHandler TextBox1.KeyPress, AddressOf textBox_KeyPress
        AddHandler TextBox2.KeyPress, AddressOf textBox_KeyPress
    End Sub


    Private Sub TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox2.Validating
        Dim matprim As Integer = Convert.ToInt32(TextBox1.Text)
        Dim mano As Integer = Convert.ToInt32(TextBox2.Text)
        Dim buq As CBuq = PCBuque.buscarBuq(matprim, mano)
        If buq IsNot Nothing Then
            grpBuque.Visible = True
            lblBuq.Visible = True
            lblBuq.Text = buq.Nombre1
        Else
            grpBuque.Visible = False
            lblBuq.Visible = False
            MessageBox.Show("No se encontro ningun buque ")
        End If


    End Sub
End Class
