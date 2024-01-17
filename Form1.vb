Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'ListBox1.Items.Add("Redmi")
        Dim myitem
        myitem = InputBox("Enter your favourite phone")
        ListBox1.Items.Add(myitem)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myitem2
        myitem2 = InputBox("Enter the name of the phone to remove")
        ListBox1.Items.Remove(myitem2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Remove(ListBox1.SelectedItems)
    End Sub
End Class
