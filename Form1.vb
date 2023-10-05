Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim MyPhrase As String
        MyPhrase = InputBox("Enter Your Phrase")
        TextBox1.Text = MyPhrase
        TextBox1.Text = Mid(MyPhrase, 2, 6)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = Color.Beige
    End Sub
End Class
