Public Class SSR1300

    Private Sub MenuForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SSR1000.MenuBtn.Enabled = True
    End Sub

    Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Top = SSR1000.Top + 86
        Me.Left = SSR1000.Left + SSR1000.Width - Me.Width - 11
    End Sub

    Private Sub JoinBtn_Click(sender As Object, e As EventArgs) Handles JoinBtn.Click

        SSR1310.Show(SSR1000)
        Me.Visible = False

    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click

        SSR1320.Show(SSR1000)
        Me.Visible = False

    End Sub

    Private Sub CalcBtn_Click(sender As Object, e As EventArgs) Handles CalcBtn.Click

        SSR1330.Show(SSR1000)
        Me.Visible = False
    End Sub

End Class