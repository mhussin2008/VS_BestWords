

Public Class Form1
    Public pageNumber As Integer
    Public maxPage As Integer
    Public minPage As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim x As AxWMPLib.AxWindowsMediaPlayer


        AxWindowsMediaPlayer1.Ctlcontrols.stop()



        AxWindowsMediaPlayer1.URL = "D:\VB_Projects\QuranBestWords\QuranBestWords\mp3_original\1-split\1_silence_01.mp3"

        AxWindowsMediaPlayer1.Ctlcontrols.stop()












    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Image = Image.FromFile("D:\VB_Projects\QuranBestWords\QuranBestWords\images\32.png")



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pageNumber = 32
        maxPage = 41
        minPage = 32
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim ScreenW, ScreenH, FormW, FormH As Double
        ScreenW = SystemInformation.PrimaryMonitorSize.Width
        ScreenH = SystemInformation.PrimaryMonitorSize.Height
        Debug.WriteLine(ScreenW)
        Debug.WriteLine(ScreenH)

        Me.Height = SystemInformation.PrimaryMonitorSize.Height
        Me.SetDesktopLocation((ScreenW - Me.Width) / 2, 0)
        PictureBox1.Width = Me.Width - 200
        PictureBox1.Height = Me.Height - 100






    End Sub

    Private Sub BtnIncrease_Click(sender As Object, e As EventArgs) Handles BtnIncrease.Click
        If pageNumber >= maxPage Then
            Exit Sub
        End If

        pageNumber = pageNumber + 1

        getPage()

    End Sub

    Private Sub getPage()
        PictureBox1.Image = Image.FromFile("D:\VB_Projects\QuranBestWords\QuranBestWords\images\" + pageNumber.ToString + ".png")
        '  Throw New NotImplementedException()
    End Sub

    Private Sub BtnDecrease_Click(sender As Object, e As EventArgs) Handles BtnDecrease.Click
        If pageNumber <= minPage Then
            Exit Sub
        End If
        pageNumber = pageNumber - 1
        getPage()
    End Sub
End Class
