Public Class Form1

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub tarama()
        WebBrowser1.Navigate(TextBox1.Text & ListBox2.SelectedItem)
        If WebBrowser1.DocumentText.Contains("input") Then
            ListBox2.SelectedIndex += -1
            ListBox1.Items.Add(TextBox1.Text & ListBox2.SelectedItem)


        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        Try
            ListBox2.SelectedIndex += 1
            tarama()
        Catch ex As Exception
            Timer1.Stop()

        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListBox2.Items.Add(TextBox1.Text)
    End Sub

    Private Sub Button3_Click_1(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Clipboard.Clear()
        If TextBox1.Text = "" Then
            MsgBox("No Text To Copie", MsgBoxStyle.Critical, "Information")
            Exit Sub
        End If
        Dim s1 As String = String.Empty

        While ListBox1.SelectedItems.Count > 0

            s1 &= ListBox1.SelectedItem & Environment.NewLine
            ListBox1.SetSelected(ListBox1.SelectedIndex, False)

        End While
        If Not s1 = "" Then
            Clipboard.SetText(s1)
        End If
        MsgBox("Copied", MsgBoxStyle.Information, "Puf_Umar")
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        ListBox1.ClearSelected()


    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        About.Show()
    End Sub
End Class
