Imports System
Imports System.Security.Cryptography
Imports System.Text


Public Class users
    Dim user As String
    Dim pass As String



    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Call loaddata()

        Text_user.Text = Nothing
        text_pass.Text = Nothing

    End Sub








    Private Sub Window_Activated(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        If Text_user.Text = "" Or text_pass.Text = "" Then
            MessageBox.Show("You cannot leave any of the fields blank", " Blank Entry", MessageBoxButton.OK, MessageBoxImage.Error)
            With text_pass
                .Focus()
                .SelectAll()
            End With


        Else

            user = Text_user.Text
            pass = text_pass.Text

            Dim [source] As String = pass
            Using md5Hash As MD5 = MD5.Create()

                Dim hash As String = GetMd5Hash(md5Hash, source)

                MsgBox(hash)
                Dim db As New Database1DataSetTableAdapters.UserTableAdapter
                Dim data = db.InsertQuery(Text_user.Text, hash)
                Call loaddata()
            End Using



      
        End If


    End Sub




    Function loaddata()
        Try
            Dim db As New Database1DataSetTableAdapters.UserTableAdapter
            datagrid.DataContext = db.GetData
        Catch ex As Exception

        End Try
        

    End Function


    Shared Function GetMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String

        ' Convert the input string to a byte array and compute the hash.
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))

        ' Create a new Stringbuilder to collect the bytes
        ' and create a string.
        Dim sBuilder As New StringBuilder()

        ' Loop through each byte of the hashed data 
        ' and format each one as a hexadecimal string.
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i

        ' Return the hexadecimal string.
        Return sBuilder.ToString()

    End Function 'GetMd5Hash


 



End Class
