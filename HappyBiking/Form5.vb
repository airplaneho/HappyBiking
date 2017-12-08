Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedItem = ComboBox1.Items(0)     '預設值為第1個步道:新店溪河濱腳踏車道
    End Sub

    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Form1.Show()        '顯示主系統
        Me.Close()          '關閉該子系統
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim Choose As String
        Choose = ComboBox1.SelectedItem

        If Choose = "新店溪河濱腳踏車道" Then
            Level.Text = "中級"
            Length.Text = "16 公里"
            Route.Text = "延平河濱公園→中正河濱公園→馬場町紀念公園→華中河濱公園→華江河濱公園→華江雁鴨公園"
            Suggestion.Text = "路況屬於平坦路段、騎乘時舒適度適中，沿途可以看到許多人文景觀與自然生態，適合一般大眾在此騎車及紓解壓力。"
        ElseIf Choose = "貴子坑溪河濱腳踏車道" Then
            Level.Text = "初級"
            Length.Text = "5 公里"
            Route.Text = "貴子坑溪→焚化爐→河雙21號公園"
            Suggestion.Text = "路況屬於平坦路段、騎乘時舒適度佳，沿途可以一覽鄉間田野美景，適合一般大眾在此騎車及紓解壓力。"
        ElseIf Choose = "景美溪河濱腳踏車道" Then
            Level.Text = "初級"
            Length.Text = "5.27 公里"
            Route.Text = "木柵公園租借處→景美溪左岸道南河濱公園→道南橋→景美溪右岸道南河濱公園→捷運木柵線高架橋"
            Suggestion.Text = "路況屬於平坦路段、騎乘時舒適度佳，沿途景觀相當豐富，大片翠綠的草地及清澈的溪流河水，適合一般大眾在此騎車及紓解壓力。"
        ElseIf Choose = "南港六張犁自行車道" Then
            Level.Text = "進階"
            Length.Text = "12 公里"
            Route.Text = "南港研究院路→胡適公園→六張犁公墓→六張犁捷運站"
            Suggestion.Text = "路況屬於山坡路段、騎乘時舒適度普通，由於此路段坡度較陡，較適合體力佳及熟悉山地騎乘、變速技巧者。"
        ElseIf Choose = "社子島環島與二重疏洪道自行車道" Then
            Level.Text = "中級"
            Length.Text = "33 公里"
            Route.Text = "社子島環島→二重疏洪道"
            Suggestion.Text = "路況屬於平坦路段、騎乘時舒適度普通，沿途可以看見基隆河與淡水河交匯波滔景像及遠眺大屯山、觀音山的景致，但因為路程較遠，較適合體力較好者。"
        ElseIf Choose = "北投溫泉自行車道" Then
            Level.Text = "進階"
            Length.Text = "20 公里"
            Route.Text = "大同公司→照明淨寺→中和禪寺→地熱谷→北投文物館→新北投公園→大同公司"
            Suggestion.Text = "路況屬於山坡路段、騎乘時舒適度普通，沿途可體驗櫻花盛景及享受泡溫泉的樂趣，因坡度較陡、較適合熟悉山地騎乘、變速技巧者。"
        ElseIf Choose = "關渡自然公園自行車道" Then
            Level.Text = "初級"
            Length.Text = "12 公里"
            Route.Text = "關渡宮→關渡自然公園→貴子坑溪段→貴子坑親山步道口折返。"
            Suggestion.Text = "路況多屬平坦路段、騎乘時舒適度佳，沿途視野相當不錯，除了可以看到淡水河，還可以看到自然公園內的水鳥保護區，適合一般大眾攜家帶眷在此騎車及紓解壓力。"
        ElseIf Choose = "基隆河親水自行車道" Then
            Level.Text = "中級"
            Length.Text = "22 公里"
            Route.Text = "南岸的南港高工或北岸的內湖垃圾焚化廠→成功橋→成美橋→麥帥二橋→民權大橋→大直橋→南岸的圓山或北岸的劍潭"
            Suggestion.Text = "路況屬於平坦路段、騎乘時舒適度普通，沿途大片綠草交織的優美景色映入眼簾，但因為路程較遠、較適合體力較好者。"
        ElseIf Choose = "延平河濱公園自行車道" Then
            Level.Text = "初級"
            Length.Text = "1.43 公里"
            Route.Text = "(淡水河右岸)大稻埕碼頭→社子南岸入口處"
            Suggestion.Text = "路況屬於平坦路段、騎乘時舒適度適中，在上頭騎乘需注意外環快速道路的車輛，此路段適合一般大眾在此騎車及紓解壓力。"
        ElseIf Choose = "木柵貓空自行車道" Then
            Level.Text = "進階"
            Length.Text = "12 公里"
            Route.Text = "政大→草湳遊樂區→樟湖木柵觀光茶園→政大"
            Suggestion.Text = "路況屬於山坡路段、騎乘時舒適度普通，沿途可以瀏覽景美溪自然美景及茶園，因坡度較陡、較適合熟悉山地騎乘、變速技巧者。	請自備自行車前往。"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://bike.easytravel.com.tw/footpath-page.aspx")      '用預設瀏覽器打開此網頁
    End Sub
End Class