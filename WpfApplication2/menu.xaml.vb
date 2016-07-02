Public Class menu

    Private Sub loginform_btn_Click(sender As Object, e As RoutedEventArgs) Handles loginform_btn.Click



    End Sub

    Private Sub userform_btn_Click(sender As Object, e As RoutedEventArgs) Handles userform_btn.Click
        Dim userform As New users
        userform.Show()
    End Sub

    Private Sub welcomeform_btn_Click(sender As Object, e As RoutedEventArgs) Handles welcomeform_btn.Click
        Dim welcomeform As New welcome
        welcomeform.Show()

    End Sub

    Private Sub loginform_btn1_Click(sender As Object, e As RoutedEventArgs) Handles loginform_btn1.Click
        Dim login As New MainWindow
        login.Show()
    End Sub
End Class
