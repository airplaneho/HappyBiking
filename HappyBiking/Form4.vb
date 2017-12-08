Public Class Form4
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles borrow_h.SelectedIndexChanged
        borrow_h.Text = borrow_h.SelectedItem
        Dim return_h_choose As String
        return_h_choose = return_h.SelectedItem
        Dim r_h, starthour As Integer
        starthour = CInt(Val(borrow_h.Text))
        return_h.Items.Clear()
        For r_h = starthour To 23
            return_h.Items.Add(r_h.ToString)
        Next
        return_h.Text = return_h_choose
    End Sub

    Private Sub borrow_m_SelectedIndexChanged(sender As Object, e As EventArgs) Handles borrow_m.SelectedIndexChanged
        borrow_m.Text = borrow_m.SelectedItem
        Dim return_m_choose As String
        return_m_choose = return_m.SelectedItem
        If return_h.Text = borrow_h.Text Then
            Dim r_m, startmin As Integer
            startmin = CInt(Val(borrow_m.Text))
            return_m.Items.Clear()
            For r_m = startmin To 59
                return_m.Items.Add(r_m.ToString)
            Next
            return_m.Text = return_m_choose
        Else
            return_m.Items.Clear()
            For i = 0 To 59
                return_m.Items.Add(i)
            Next
            return_m.Text = return_m_choose
        End If
    End Sub

    Private Sub return_h_SelectedIndexChanged(sender As Object, e As EventArgs) Handles return_h.SelectedIndexChanged
        return_h.Text = return_h.SelectedItem
        Dim return_m_choose As String
        return_m_choose = return_m.SelectedItem
        If return_h.Text = borrow_h.Text Then
            Dim r_m, startmin As Integer
            startmin = CInt(Val(borrow_m.Text))
            return_m.Items.Clear()
            For r_m = startmin To 59
                return_m.Items.Add(r_m.ToString)
            Next
            return_m.Text = return_m_choose
        Else
            return_m.Items.Clear()
            For i = 0 To 59
                return_m.Items.Add(i)
            Next
            return_m.Text = return_m_choose
        End If
    End Sub

    Private Sub return_m_SelectedIndexChanged(sender As Object, e As EventArgs) Handles return_m.SelectedIndexChanged
        return_m.Text = return_m.SelectedItem
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim start_h, start_m, end_h, end_m, hour, min, totaltime, pay As Integer
        start_h = CInt(Val(borrow_h.Text))
        start_m = CInt(Val(borrow_m.Text))
        end_h = CInt(Val(return_h.Text))
        end_m = CInt(Val(return_m.Text))
        hour = end_h - start_h
        min = end_m - start_m
        totaltime = 60 * hour + min
        hour = totaltime \ 60
        min = totaltime Mod 60
        total_hour.Text = hour
        total_min.Text = min
        If totaltime <= 240 Then '4小時內每30分鐘10元
            If totaltime Mod 30 = 0 Then
                pay = totaltime / 30 * 10
            Else
                pay = (totaltime \ 30 + 1) * 10
            End If
            cost.Text = pay
        ElseIf totaltime > 240 And totaltime <= 480 Then '4小時～8小時內每30分鐘20元
            If totaltime Mod 30 = 0 Then
                pay = 240 / 30 * 10 + (totaltime - 240) / 30 * 20
            Else
                pay = 240 / 30 * 10 + ((totaltime - 240) \ 30 + 1) * 20
            End If
            cost.Text = pay
        ElseIf totaltime > 480 Then '超過8小時以上每30分鐘40元
            If totaltime Mod 30 = 0 Then
                pay = 240 / 30 * 10 + 240 / 30 * 20 + (totaltime - 480) / 30 * 40
            Else
                pay = 240 / 30 * 10 + 240 / 30 * 20 + ((totaltime - 480) \ 30 + 1) * 40
            End If
            cost.Text = pay
        End If
    End Sub

    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Form1.Show()    '顯示主系統
        Me.Close()      '關閉該子系統
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://taipei.youbike.com.tw/cht/f43.php")  '用預設瀏覽器打開此網頁
    End Sub

End Class