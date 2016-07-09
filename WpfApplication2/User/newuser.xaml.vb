Imports MaterialDesignThemes.Wpf.HintAssist
Public Class newuser

    Private Sub btn_close_Click(sender As Object, e As RoutedEventArgs) Handles btn_close.Click
        Me.Close()




    End Sub

    Private Sub DatePicker_GotFocus(sender As Object, e As RoutedEventArgs)
        DOB.IsDropDownOpen = True
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As RoutedEventArgs) Handles btn_submit.Click







End Class
