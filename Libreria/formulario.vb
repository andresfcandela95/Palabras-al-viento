Public Class PEDIDO

    Private Sub formulario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        TextBox1.Text = DateTime.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        inicio.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class