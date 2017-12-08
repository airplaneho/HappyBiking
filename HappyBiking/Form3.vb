Public Class Form3
    Dim CheckedOrNot As Integer() = New Integer(11) {}
    Dim Area1() As String = {"大安區	捷運國父紀念館站(2號出口)", "大安區	捷運科技大樓站", "大安區	信義建國路口", "大安區	金山愛國路口", "大安區	基隆長興路口", "大安區	辛亥新生路口", "大安區	捷運六張犁站", "大安區	臺大資訊大樓", "大安區	捷運東門站(4號出口)", "大安區	臺灣師範大學(圖書館)", "大安區	捷運公館站(2號出口)", "大安區	捷運忠孝新生站(3號出口)", "大安區	龍門廣場", "大安區	臺北市立圖書館(總館)", "大安區	新生和平路口", "大安區	台灣科技大學", "大安區	仁愛醫院", "大安區	捷運信義安和站(4號出口)", "大安區	捷運台電大樓站(2號出口)", "大安區	捷運大安森林公園站", "大安區	信義敦化路口", "大安區	捷運大安站", "大安區	捷運忠孝復興站(2號出口)", "大安區	敦化基隆路口", "大安區	成功國宅", "大安區	羅斯福新生南路口", "大安區	捷運麟光站2號出口", "大安區	建國和平路口", "大安區	瑠公公園", "大安區	仁愛延吉街口", "大安區	臥龍樂業街口", "大安區	喬治工商", "大安區	忠孝東路三段217巷口", "大安區	大安運動中心", "大安區	敦親公園", "大安區	金華公園", "大安區	捷運古亭站(6號出口)", "大安區	仁愛安和路口", "大安區	捷運信義安和站(1號出口)", "大安區	敦化南路二段103巷口", "大安區	復興南路二段128巷口", "大安區	建國濟南路口", "大安區	和平金山路口", "大安區	復興南路一段340巷口", "大安區	嘉興公園", "大安區	和平龍泉街口", "大安區	和平敦化路口"}
    Dim Area2() As String = {"中山區	榮星花園", "中山區	捷運行天宮站(1號出口)", "中山區	捷運行天宮站(3號出口)", "中山區	建國農安街口", "中山區	建國長春路口", "中山區	八德市場", "中山區	林森公園", "中山區	中山行政中心", "中山區	新生長安路口", "中山區	新生長春路口", "中山區	市立美術館", "中山區	林安泰古厝", "中山區	捷運劍南路站(2號出口)", "中山區	龍江南京路口", "中山區	捷運中山國小站(4號出口)	", "中山區	捷運松江南京站(7號出口)", "中山區	興安華城", "中山區	劍潭社區", "中山區	捷運大直站(3號出口)", "中山區	市民林森路口", "中山區	樂群二敬業四路口", "中山區	北安大直街口", "中山區	培英公園", "中山區	撫順公園", "中山區	南京建國路口", "中山區	復興市民路口", "中山區	捷運中山國中站", "中山區	南京遼寧街口", "中山區	伊通長安路口", "中山區	松江公園", "中山區	第二果菜批發市場", "中山區	新生公園", "中山區	朱崙商場", "中山區	林森長春路口", "中山區	國立臺北大學(臺北校區)", "中山區	民族林森路口", "中山區	永盛公園(民生東路一段23巷)", "中山區	新興公園", "中山區	一江公園", "中山區	樂群二明水路口", "中山區	民族玉門街口", "中山區	捷運中山站(2號出口)", "中山區	民權建國路口", "中山區	民生建國路口", "中山區	錦州吉林路口", "中山區	南京新生路口"}
    Dim Area3() As String = {"松山區	饒河夜市", "松山區	民生光復路口", "松山區	臺北市藝文推廣處", "松山區	民生敦化路口", "松山區	中崙高中", "松山區	民權運動公園", "松山區	臺北田徑場", "松山區	民生活動中心", "松山區	民權復興路口", "松山區	三民公園", "松山區	新東公園", "松山區	捷運南京三民站(1號出口)", "松山區	捷運小巨蛋站(5號出口)", "松山區	捷運南京復興站(5號出口)", "松山區	內政部營建署", "松山區	市民東興路口", "松山區	光復南路22巷口", "松山區	健康新城", "松山區	捷運松山站(3號出口)", "松山區	敦北公園", "松山區	西松高中", "松山區	三軍總醫院(松山分院)", "松山區	敦化長春路口", "松山區	民有一號公園", "松山區	捷運南京三民站(3號出口)", "松山區	復盛公園", "松山區	南京光復路口", "松山區	民生立體停車場", "松山區	健安新城", "松山區	中崙福成宮", "松山區	塔悠疏散門", "松山區	松基公園", "松山區	南京東興路口", "松山區	新東街51巷口"}
    Dim Area4() As String = {"南港區	東新國小", "南港區	捷運昆陽站(1號出口)", "南港區	捷運南港展覽館站(5號出口)", "南港區	南港世貿公園", "南港區	玉成公園", "南港區	中研公園", "南港區	凌雲市場", "南港區	捷運南港軟體園區站(2號出口)", "南港區	南港國小", "南港區	南港車站(忠孝東路)", "南港區	南港公園", "南港區	舊莊區民活動中心", "南港區	東陽公園", "南港區	向陽南港路口", "南港區	八德中坡路口", "南港區	南港高工", "南港區	南港車站(興華路)", "南港區	合心廣場", "南港區	成德國中", "南港區	忠孝東路六段185巷口", "南港區	福山公園", "南港區	南港路二段178巷口"}
    Dim Area5() As String = {"中正區	仁愛林森路口", "中正區	捷運善導寺站(1號出口)", "中正區	南昌公園", "中正區	國家圖書館", "中正區	捷運臺大醫院(4號出口)", "中正區	信義連雲街口", "中正區	捷運西門站(3號出口)", "中正區	和平重慶路口", "中正區	金山市民路口", "中正區	華山文創園區", "中正區	臺北市客家文化主題公園", "中正區	捷運小南門站(1號出口)", "中正區	臺北轉運站", "中正區	羅斯福寧波東街口", "中正區	河堤國小", "中正區	植物園", "中正區	捷運古亭站(2號出口)", "中正區	臺北市立大學", "中正區	信義杭州路口(中華電信總公司)", "中正區	中山堂", "中正區	螢橋國小", "中正區	濟南紹興路口", "中正區	牯嶺公園", "中正區	自來水園區", "中正區	捷運忠孝新生站(2號出口)	", "中正區	光華商場", "中正區	莒光大埔街口", "中正區	重慶南海路口", "中正區	中正運動中心", "中正區	博愛寶慶路口", "中正區	中山青島路口", "中正區	紀州庵", "中正區	南門國中", "中正區	聯合醫院和平院區"}
    Dim Area6() As String = {"萬華區	青年公園3號出口", "萬華區	國興青年路口", "萬華區	華江高中", "萬華區	復華花園新城", "萬華區	老松國小", "萬華區	開封西寧路口", "萬華區	東園國小", "萬華區	萬大興寧街口", "萬華區	峨嵋停車場", "萬華區	西園艋舺路口", "萬華區	捷運龍山寺站(1號出口)", "萬華區	華西公園", "萬華區	古亭國中", "萬華區	龍山國小", "萬華區	大理高中", "萬華區	中華桂林路口", "萬華區	錦德公園", "萬華區	西本願寺廣場", "萬華區	長沙公園", "萬華區	萬華國中", "萬華區	雙園國中", "萬華區	新和國小"}
    Dim Area7() As String = {"文山區	師範大學公館校區", "文山區	興豐公園", "文山區	捷運景美站", "文山區	羅斯福景隆街口", "文山區	台北花木批發市場", "文山區	文山行政中心", "文山區	捷運木柵站", "文山區	捷運動物園站(2號出口)", "文山區	國立政治大學", "文山區	考試院", "文山區	臺北市立景美女中", "文山區	文山運動中心", "文山區	木柵光輝路口", "文山區	捷運辛亥站", "文山區	捷運萬芳社區站", "文山區	文山第二行政中心", "文山區	木柵公園", "文山區	永安藝文館-表演36房", "文山區	忠順區民活動中心", "文山區	萬和二號公園", "文山區	捷運萬隆站(1號出口)", "文山區	景文中學", "文山區	世新大學", "文山區	一壽橋", "文山區	和興路26巷口", "文山區	景華街128巷口", "文山區	景仁公園"}
    Dim Area8() As String = {"大同區	酒泉延平路口", "大同區	捷運圓山站(2號出口)", "大同區	捷運民權西路站(3號出口)", "大同區	捷運雙連站(2號出口)", "大同區	臺北孔廟", "大同區	永樂市場", "大同區	捷運大橋頭站(2號出口)", "大同區	樹德公園", "大同區	蔣渭水紀念公園", "大同區	捷運中山站(4號出口)", "大同區	圓環站", "大同區	捷運北門站(3號出口)", "大同區	大稻埕公園", "大同區	市民太原路口", "大同區	聯合醫院中興院區", "大同區	太原五原路口", "大同區	迪化休閒運動公園", "大同區	承德路三段8巷口", "大同區	重慶國中", "大同區	重慶酒泉街口", "大同區	民權迪化街口", "大同區	重慶民族路口"}
    Dim Area9() As String = {"士林區	捷運劍潭站(2號出口)", "士林區	蘭雅公園", "士林區	福林公園", "士林區	天母運動公園", "士林區	蘭興公園", "士林區	捷運芝山站(2號出口)", "士林區	捷運士林站(2號出口)", "士林區	士林運動中心", "士林區	百齡國小", "士林區	中正基河路口", "士林區	臺北市立天文館", "士林區	葫蘆國小", "士林區	延平國宅", "士林區	社子國小", "士林區	臺北市立大學(天母校區)", "士林區	福安國中", "士林區	蘭雅國小", "士林區	社正公園", "士林區	中山天母路口", "士林區	社子公園", "士林區	國立故宮博物院", "士林區	華齡公園", "士林區	芝山抽水站", "士林區	中山中正路口", "士林區	至善臨溪路口", "士林區	雨農國小", "士林區	芝山國小", "士林區	士林新天地", "士林區	華聲公園", "士林區	市立圖書館葫蘆堵分館", "士林區	捷運芝山站(1號出口)", "士林區	陽明高中", "士林區	臺灣戲曲中心", "士林區	銘傳大學", "士林區	劍潭海外青年活動中心", "士林區	聯合醫院陽明院區"}
    Dim Area10() As String = {"內湖區	文湖國小", "內湖區	捷運港墘站(2號出口)", "內湖區	東湖國中", "內湖區	捷運文德站(2號出口)", "內湖區	洲子二號公園", "內湖區	瑞光港墘路口", "內湖區	東湖國小", "內湖區	麗山國小", "內湖區	捷運東湖站", "內湖區	捷運西湖站(1號出口)", "內湖區	福華商場", "內湖區	金瑞公園(金龍路)", "內湖區	捷運大湖公園站(2號出口)", "內湖區	捷運葫洲站(1號出口)", "內湖區	新湖國小", "內湖區	星雲金湖街口", "內湖區	基河一期國宅", "內湖區	臺北花市", "內湖區	麗山高中", "內湖區	湖光國宅", "內湖區	瑞湖陽光街口", "內湖區	新明路321巷口", "內湖區	民權瑞光路口", "內湖區	洲子一號公園", "內湖區	三軍總醫院", "內湖區	扶輪親恩公園", "內湖區	明美公園", "內湖區	德明財經科技大學", "內湖區	安泰街83巷", "內湖區	碧山公園", "內湖區	成功金龍路口", "內湖區	南京東路六段368巷", "內湖區	彩虹橋", "內湖區	臺北市網球中心", "內湖區	新明成功路口", "內湖區	碧湖公園", "內湖區	麗湖國小", "內湖區	陽光街321巷口", "內湖區	民權東路六段15巷", "內湖區	內溝溪生態展示館"}
    Dim Area11() As String = {"北投區	捷運新北投站", "北投區	捷運北投站", "北投區	大業大同街口", "北投區	振華公園", "北投區	捷運石牌站(2號出口)", "北投區	國立臺北護理健康大學", "北投區	國防大學", "北投區	捷運明德站", "北投區	北投運動中心", "北投區	大豐公園", "北投區	捷運奇岩站", "北投區	捷運唭哩岸站(2號出口)", "北投區	捷運關渡站", "北投區	捷運復興崗站", "北投區	清江國小", "北投區	捷運忠義站", "北投區	永欣綠地", "北投區	關渡自然公園", "北投區	關渡宮", "北投區	立功立德路口", "北投區	秀山區民活動中心", "北投區	中央北路四段30巷口", "北投區	中央北路四段540巷口", "北投區	文林建民路口", "北投區	振興醫院", "北投區	陽明大學", "北投區	豐年公園", "北投區	稻香重三路口"}

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Inquiry.Click
        CheckedOrNot(0) = 0 '表示[信義區]未被勾選
        CheckedOrNot(1) = 0 '表示[大安區]未被勾選
        CheckedOrNot(2) = 0 '表示[中山區]未被勾選
        CheckedOrNot(3) = 0 '表示[松山區]未被勾選
        CheckedOrNot(4) = 0 '表示[南港區]未被勾選
        CheckedOrNot(5) = 0 '表示[中正區]未被勾選
        CheckedOrNot(6) = 0 '表示[萬華區]未被勾選
        CheckedOrNot(7) = 0 '表示[文山區]未被勾選
        CheckedOrNot(8) = 0 '表示[大同區]未被勾選
        CheckedOrNot(9) = 0 '表示[士林區]未被勾選
        CheckedOrNot(10) = 0 '表示[內湖區]未被勾選
        CheckedOrNot(11) = 0 '表示[北投區]未被勾選
        If Xinyi.Checked = True Then
            CheckedOrNot(0) = 1 '表示[信義區]已被勾選
        End If
        If Daan.Checked = True Then
            CheckedOrNot(1) = 1 '表示[大安區]已被勾選
        End If
        If Zhongshan.Checked = True Then
            CheckedOrNot(2) = 1 '表示[中山區]已被勾選
        End If
        If Songshan.Checked = True Then
            CheckedOrNot(3) = 1 '表示[松山區]已被勾選
        End If
        If Nangang.Checked = True Then
            CheckedOrNot(4) = 1 '表示[南港區]已被勾選
        End If
        If Zhongzheng.Checked = True Then
            CheckedOrNot(5) = 1 '表示[中正區]已被勾選
        End If
        If Wanhua.Checked = True Then
            CheckedOrNot(6) = 1 '表示[萬華區]已被勾選
        End If
        If Wenshan.Checked = True Then
            CheckedOrNot(7) = 1 '表示[文山區]已被勾選
        End If
        If Datong.Checked = True Then
            CheckedOrNot(8) = 1 '表示[大同區]已被勾選
        End If
        If Shilin.Checked = True Then
            CheckedOrNot(9) = 1 '表示[士林區]已被勾選
        End If
        If Neihu.Checked = True Then
            CheckedOrNot(10) = 1 '表示[內湖區]已被勾選
        End If
        If Beitou.Checked = True Then
            CheckedOrNot(11) = 1 '表示[北投區]已被勾選
        End If
        ListBox1.Items.Clear()
        ListBox1.Items.Add("區域別 租賃站點查詢")

        If CheckedOrNot(0) = 1 Then
            ListBox1.Items.Add("信義區	捷運市政府站(3號出口)")
            ListBox1.Items.Add("信義區	台北市政府")
            ListBox1.Items.Add("信義區	市民廣場")
            ListBox1.Items.Add("信義區	興雅國中")
            ListBox1.Items.Add("信義區	世貿二館")
            ListBox1.Items.Add("信義區	信義廣場(台北101)")
            ListBox1.Items.Add("信義區	世貿三館")
            ListBox1.Items.Add("信義區	松德站")
            ListBox1.Items.Add("信義區	台北市災害應變中心")
            ListBox1.Items.Add("信義區	三張犁")
            ListBox1.Items.Add("信義區	臺北醫學大學")
            ListBox1.Items.Add("信義區	福德公園")
            ListBox1.Items.Add("信義區	松山家商")
            ListBox1.Items.Add("信義區	象山公園")
            ListBox1.Items.Add("信義區	松山車站")
            ListBox1.Items.Add("信義區	永吉松信路口")
            ListBox1.Items.Add("信義區	五常公園")
            ListBox1.Items.Add("信義區	捷運後山埤站(1號出口)")
            ListBox1.Items.Add("信義區	捷運台北101/世貿站")
            ListBox1.Items.Add("信義區	基隆光復路口")
            ListBox1.Items.Add("信義區	捷運象山站")
            ListBox1.Items.Add("信義區	吳興公車總站")
            ListBox1.Items.Add("信義區	仁愛逸仙路口")
            ListBox1.Items.Add("信義區	捷運永春站(2號出口)")
            ListBox1.Items.Add("信義區	松德公園")
            ListBox1.Items.Add("信義區	松山高中")
            ListBox1.Items.Add("信義區	泰和公園")
            ListBox1.Items.Add("信義區	林口公園")
            ListBox1.Items.Add("信義區	三興公園")
            ListBox1.Items.Add("信義區	富台公園")
            ListBox1.Items.Add("信義區	信義基隆路口")
            ListBox1.Items.Add("信義區	基隆路一段101巷口")
            ListBox1.Items.Add("信義區	松友公園")
            ListBox1.Items.Add("信義區	春光公園")
            ListBox1.Items.Add("信義區	吳興街260巷")
            ListBox1.Items.Add("信義區	福德國小")
            ListBox1.Items.Add("信義區	松德虎林街口")
            ListBox1.Items.Add("信義區	安強公園")
            'ListBox1.Items.Add("")
        End If

        If CheckedOrNot(1) = 1 Then
            ListBox1.Items.AddRange(Area1)
        End If

        If CheckedOrNot(2) = 1 Then
            ListBox1.Items.AddRange(Area2)
        End If

        If CheckedOrNot(3) = 1 Then
            ListBox1.Items.AddRange(Area3)
        End If

        If CheckedOrNot(4) = 1 Then
            ListBox1.Items.AddRange(Area4)
        End If

        If CheckedOrNot(5) = 1 Then
            ListBox1.Items.AddRange(Area5)
        End If

        If CheckedOrNot(6) = 1 Then
            ListBox1.Items.AddRange(Area6)
        End If

        If CheckedOrNot(7) = 1 Then
            ListBox1.Items.AddRange(Area7)
        End If

        If CheckedOrNot(8) = 1 Then
            ListBox1.Items.AddRange(Area8)
        End If

        If CheckedOrNot(9) = 1 Then
            ListBox1.Items.AddRange(Area9)
        End If

        If CheckedOrNot(10) = 1 Then
            ListBox1.Items.AddRange(Area10)
        End If

        If CheckedOrNot(11) = 1 Then
            ListBox1.Items.AddRange(Area11)
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles TaipeiCity.Enter

    End Sub

    Private Sub GoBack_Click(sender As Object, e As EventArgs) Handles GoBack.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles AllClick.Click
        '勾選全部項目
        Xinyi.CheckState = CheckState.Checked
        Daan.CheckState = CheckState.Checked
        Zhongshan.CheckState = CheckState.Checked
        Songshan.CheckState = CheckState.Checked
        Nangang.CheckState = CheckState.Checked
        Zhongzheng.CheckState = CheckState.Checked
        Wanhua.CheckState = CheckState.Checked
        Wenshan.CheckState = CheckState.Checked
        Datong.CheckState = CheckState.Checked
        Shilin.CheckState = CheckState.Checked
        Neihu.CheckState = CheckState.Checked
        Beitou.CheckState = CheckState.Checked
    End Sub

    Private Sub CancelAll_Click(sender As Object, e As EventArgs) Handles CancelAll.Click
        '取消勾選全部項目
        Xinyi.CheckState = CheckState.Unchecked
        Daan.CheckState = CheckState.Unchecked
        Zhongshan.CheckState = CheckState.Unchecked
        Songshan.CheckState = CheckState.Unchecked
        Nangang.CheckState = CheckState.Unchecked
        Zhongzheng.CheckState = CheckState.Unchecked
        Wanhua.CheckState = CheckState.Unchecked
        Wenshan.CheckState = CheckState.Unchecked
        Datong.CheckState = CheckState.Unchecked
        Shilin.CheckState = CheckState.Unchecked
        Neihu.CheckState = CheckState.Unchecked
        Beitou.CheckState = CheckState.Unchecked
    End Sub
End Class