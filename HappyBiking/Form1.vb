Public Class Form1      '主系統
    Private Sub AboutUbike_Click(sender As Object, e As EventArgs) Handles AboutUbike.Click
        Me.Hide()       '隱藏主系統
        Form2.Show()    '顯示子系統[關於YouBike]
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()       '隱藏主系統
        Form3.Show()    '顯示子系統[YouBike的租賃站點]
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Hide()       '隱藏主系統
        Form4.Show()    '顯示子系統[YouBike費率計算]
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()       '隱藏主系統
        Form5.Show()    '顯示子系統[熱門路線推薦]
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        MessageBox.Show("BETA測試版 " + vbCrLf + "updated:12/9/2017" + vbCrLf + "----------------------------------" + vbCrLf + "更新日誌:" + vbCrLf + "目前各功能僅提供[台北市]的選項" + vbCrLf + "----------------------------------" + vbCrLf + "功能列表:" + vbCrLf + "1.關於YouBike" + vbCrLf + "2.YouBike的租賃站點" + vbCrLf + "3.YouBike費率計算" + vbCrLf + "4.熱門路線推薦", "版本資訊", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        MessageBox.Show("開發人員名單:" + vbCrLf + "404416157  嚴嘉浩" + vbCrLf + "404411265  薛仲皓", "關於我們", MessageBoxButtons.OK, MessageBoxIcon.Question)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
