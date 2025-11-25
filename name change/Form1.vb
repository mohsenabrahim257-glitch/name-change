Public Class Form1
    Dim a As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "ابراهيم"
        TextBox2.Text = " محسن"
        TextBox3.Text = " مرعي"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox2.Text
        Dim i As String
        i = a.Substring(0, 5)
        TextBox4.Text = i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = "ابراهيم محسن مرعي"
        Dim z As String
        z = a.Remove(0, 1)
        TextBox4.Text = z
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = "ابراهيم محسن مرعي"
        Dim r As String
        r = a.Insert(0, "جسار ")
        TextBox4.Text = r
    End Sub
End Class