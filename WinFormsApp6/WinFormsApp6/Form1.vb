Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        txtAve.Text = (Val(txtPrelim.Text) + Val(txtMterm.Text) + Val(txtPfinal.Text) + Val(txtFinal.Text)) / 4

        txtFullname.Text = txtName.Text

        txtFullCourse.Text = txtCourse.Text

        If txtAve.Text >= 75 Then
            txtRema.Text = "Passed"
        Else
            txtRema.Text = "Failed"
        End If
    End Sub
End Class
