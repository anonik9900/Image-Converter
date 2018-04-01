Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = "PNG"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                PictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ComboBox1.SelectedItem = "JPEG" Then
            Try
                SaveFileDialog1.Filter = "JPEG |*.jpeg"
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    PictureBox1.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                End If
            Catch ex As Exception
            End Try
        End If
        If ComboBox1.SelectedItem = "PNG" Then
            Try
                SaveFileDialog1.Filter = "PNG |*.png"
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    PictureBox1.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png)
                End If
            Catch ex As Exception
            End Try
        End If
        If ComboBox1.SelectedItem = "GIF" Then
            Try
                SaveFileDialog1.Filter = "GIF |*.gif"
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    PictureBox1.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Gif)
                End If
            Catch ex As Exception
            End Try
        End If

        If ComboBox1.SelectedItem = "BMP" Then
            Try
                SaveFileDialog1.Filter = "BMP |*.bmp"
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    PictureBox1.Image.Save(SaveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        System.Diagnostics.Process.Start("http://imageconverter.altervista.org/")
    End Sub
End Class
