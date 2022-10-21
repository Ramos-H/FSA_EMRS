Public Class Page_Index

    'If the user clicks the index exit button
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit() 'Close the application
    End Sub

    'If the user clicks the login button
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        frm_MainWindow.ShowPage(Pages.Login)
    End Sub

    'If the user clicks the register button
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        frm_MainWindow.ShowPage(Pages.Register)
    End Sub
End Class
