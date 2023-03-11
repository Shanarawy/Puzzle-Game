Public Class Form1

    Dim count As Integer
    Public Sub chechbut(ByRef btn1 As Button, ByRef btn2 As Button)
        If btn2.Text = Nothing Then
            btn2.Text = btn1.Text
            btn1.Text = Nothing
            btn2.BackgroundImage = btn1.BackgroundImage
            btn1.BackgroundImage = Nothing
        End If

    End Sub
    Public Sub endgame()
        If Button1.Text = "1" And Button2.Text = "2" And Button3.Text = "3" And Button4.Text = "4" And Button5.Text = "5" And Button6.Text = "6" And Button7.Text = "7" And Button8.Text = "8" And Button9.Text = "9" And Button10.Text = "10" And Button11.Text = "11" And Button12.Text = "12" And Button13.Text = "13" And Button14.Text = "14" And Button15.Text = "15" Then
            MsgBox(" لقد فزت  " & "  عدد الحركات" & count, MsgBoxStyle.Information, "تهانينا")
        End If
        count = count + 1

    End Sub
    '=======ترتيب الخانات عشوائياً=======
    Sub Reset()
        Dim a(15), i, j, RN As Integer
        Dim flag As Boolean

        flag = False
        i = 1
        a(j) = 1

        Do While i <= 15
            Randomize()
            RN = CInt(Int((15 * Rnd()) + 1))

            For j = 1 To i
                If (a(j) = RN) Then
                    flag = True
                    Exit For
                End If
            Next

            If flag = True Then
                flag = False
            Else
                a(i) = RN
                i = i + 1
            End If
        Loop

        Button1.Text = a(1)
        Button2.Text = a(2)
        Button3.Text = a(3)
        Button4.Text = a(4)
        Button5.Text = a(5)

        Button6.Text = a(6)
        Button7.Text = a(7)
        Button8.Text = a(8)
        Button9.Text = a(9)
        Button10.Text = a(10)

        Button11.Text = a(11)
        Button12.Text = a(12)
        Button13.Text = a(13)
        Button14.Text = a(14)
        Button15.Text = a(15)
        Button16.Text = ""
        Button1.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(1))
        Button2.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(2))
        Button3.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(3))
        Button4.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(4))
        Button5.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(5))
        Button6.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(6))
        Button7.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(7))
        Button8.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(8))
        Button9.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(9))
        Button10.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(10))
        Button11.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(11))
        Button12.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(12))
        Button13.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(13))
        Button14.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(14))
        Button15.BackgroundImage = My.Resources.ResourceManager.GetObject("tiger_" & a(15))

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '====ترتيب الخانات عشوائيا عند بدأ اللعبة=====
        Reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        chechbut(Button1, Button2)
        chechbut(Button1, Button5)
        endgame()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        chechbut(Button2, Button3)
        chechbut(Button2, Button1)
        chechbut(Button2, Button6)
        endgame()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        chechbut(Button3, Button4)
        chechbut(Button3, Button2)
        chechbut(Button3, Button7)
        endgame()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        chechbut(Button4, Button3)
        chechbut(Button4, Button8)
        endgame()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        chechbut(Button5, Button1)
        chechbut(Button5, Button6)
        chechbut(Button5, Button9)
        endgame()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        chechbut(Button6, Button2)
        chechbut(Button6, Button5)
        chechbut(Button6, Button7)
        chechbut(Button6, Button10)
        endgame()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        chechbut(Button7, Button3)
        chechbut(Button7, Button8)
        chechbut(Button7, Button6)
        chechbut(Button7, Button11)
        endgame()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        chechbut(Button8, Button4)
        chechbut(Button8, Button7)
        chechbut(Button8, Button12)
        endgame()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        chechbut(Button9, Button5)
        chechbut(Button9, Button13)
        chechbut(Button9, Button10)
        endgame()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        chechbut(Button10, Button6)
        chechbut(Button10, Button9)
        chechbut(Button10, Button11)
        chechbut(Button10, Button14)
        endgame()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        chechbut(Button11, Button7)
        chechbut(Button11, Button10)
        chechbut(Button11, Button12)
        chechbut(Button11, Button15)
        endgame()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        chechbut(Button12, Button8)
        chechbut(Button12, Button16)
        chechbut(Button12, Button11)
        endgame()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        chechbut(Button13, Button9)
        chechbut(Button13, Button14)
        endgame()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        chechbut(Button14, Button10)
        chechbut(Button14, Button15)
        chechbut(Button14, Button13)
        endgame()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        chechbut(Button15, Button11)
        chechbut(Button15, Button16)
        chechbut(Button15, Button14)
        endgame()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        chechbut(Button16, Button12)
        chechbut(Button16, Button15)
        endgame()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button17_Click_1(sender As Object, e As EventArgs) Handles Button17.Click

    End Sub

    Private Sub Button17_MouseDown(sender As Object, e As MouseEventArgs) Handles Button17.MouseDown
        PictureBox1.Visible = True
        PictureBox1.Image = My.Resources.tiger
    End Sub

    Private Sub Button17_MouseUp(sender As Object, e As MouseEventArgs) Handles Button17.MouseUp
        PictureBox1.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        End
    End Sub
End Class
