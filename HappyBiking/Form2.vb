Public Class Form2
    Dim pre_next_page As Integer = 1    '預設頁數第一頁為1
    Dim topic1 As String = "緣起"
    Dim content1 As String = "臺北市政府交通局為推廣民眾騎乘自行車作為短程接駁交通工具，期藉由市區自行車道路網搭配自行車租賃站服務，鼓勵民眾使用低污染、低耗能的公共自行車作為短程接駁運具，減少及移轉私人機動車輛之持有及使用，以達改善都市道路交通擁擠、環境污染及能源損耗目的。 " + vbCrLf + vbCrLf + "台北市政府與台灣捷安特攜手啟動了台北市公共自行車租賃系統服務計畫，簡稱為「YouBike微笑單車」。"
    Dim topic2 As String = "公共自行車理念"
    Dim content2 As String = "YouBike微笑單車使用電子無人自動化管理系統，提供自行車甲" + vbCrLf + vbCrLf + "租乙還的租賃服務，盼以自行車做為大眾運輸系統最後一哩的接" + vbCrLf + vbCrLf + "駁工具，藉此鼓勵更多民眾樂意使用大眾運輸系統，同時達到環" + vbCrLf + vbCrLf + "保與節能的目的，打造全新的台北通勤文化。"
    Dim topic3 As String = "公共自行車願景"
    Dim content3 As String = "提升之環保綠都和國際化的正面形象" + vbCrLf + vbCrLf + "為台北帶來全新的觀光價值" + vbCrLf + vbCrLf + "居住生活品質改善與市民滿意度提升" + vbCrLf + vbCrLf + "減少汽機車之使用，改善空氣品質與交通環境" + vbCrLf + vbCrLf + "帶動自行車風潮，增加騎乘人口" + vbCrLf + vbCrLf + "台北成為台灣自行車騎乘的首善之區"
    Dim topic4 As String = "大事記"
    Dim content4 As String = "2016-08-23   YouBike總騎乘次數突破一億人次" + vbCrLf + vbCrLf + "2015-03-16   YouBike使用次數突破4000萬人次" + vbCrLf + vbCrLf + "2014-10-22   YouBike使用次數突破3000萬人次" + vbCrLf + vbCrLf + "2014-07-19   YouBike 完成163站 5350台車" + vbCrLf + vbCrLf + "2014-05-23   YouBike使用次數突破2000萬人次"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Topic.Text = topic1         '第一頁的主題
        Content.Text = content1     '第一頁的內文
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles GoBack.Click
        Form1.Show()                '返回主系統
        Me.Close()                  '關閉此子系統
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PreviousPage.Click
        If pre_next_page <> 1 Then              '頁數不為第一頁時，減1(回上一頁)
            pre_next_page = pre_next_page - 1
            If pre_next_page = 1 Then           '返回第一頁
                Topic.Text = topic1
                Content.Text = content1
            ElseIf pre_next_page = 2 Then       '返回第二頁
                Topic.Text = topic2
                Content.Text = content2
            ElseIf pre_next_page = 3 Then       '返回第三頁
                Topic.Text = topic3
                Content.Text = content3
            End If

        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles NextPage.Click
        If pre_next_page <> 4 Then              '頁數不為第四頁(最後一頁)時，加1(到下一頁)
            pre_next_page = pre_next_page + 1
            If pre_next_page = 2 Then           '跳到第二頁
                Topic.Text = topic2
                Content.Text = content2
            ElseIf pre_next_page = 3 Then       '跳到第三頁
                Topic.Text = topic3
                Content.Text = content3
            ElseIf pre_next_page = 4 Then       '跳到第四頁
                Topic.Text = topic4
                Content.Text = content4
            End If

        End If
    End Sub

End Class