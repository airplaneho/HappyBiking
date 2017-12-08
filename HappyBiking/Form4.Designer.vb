<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.borrow_h = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.borrow_m = New System.Windows.Forms.ComboBox()
        Me.return_h = New System.Windows.Forms.ComboBox()
        Me.return_m = New System.Windows.Forms.ComboBox()
        Me.total_hour = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.total_min = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cost = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GoBack = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Source = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.GoBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "租車時間:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(238, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "點"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(376, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "分"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "還車時間:"
        '
        'borrow_h
        '
        Me.borrow_h.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.borrow_h.FormattingEnabled = True
        Me.borrow_h.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.borrow_h.Location = New System.Drawing.Point(147, 88)
        Me.borrow_h.Name = "borrow_h"
        Me.borrow_h.Size = New System.Drawing.Size(85, 26)
        Me.borrow_h.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(238, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 28)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "點"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(376, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 28)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "分"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(16, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 28)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "總共時間:"
        '
        'borrow_m
        '
        Me.borrow_m.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.borrow_m.FormattingEnabled = True
        Me.borrow_m.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.borrow_m.Location = New System.Drawing.Point(285, 88)
        Me.borrow_m.Name = "borrow_m"
        Me.borrow_m.Size = New System.Drawing.Size(85, 26)
        Me.borrow_m.TabIndex = 13
        '
        'return_h
        '
        Me.return_h.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.return_h.FormattingEnabled = True
        Me.return_h.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.return_h.Location = New System.Drawing.Point(147, 148)
        Me.return_h.Name = "return_h"
        Me.return_h.Size = New System.Drawing.Size(85, 26)
        Me.return_h.TabIndex = 14
        '
        'return_m
        '
        Me.return_m.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.return_m.FormattingEnabled = True
        Me.return_m.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.return_m.Location = New System.Drawing.Point(285, 151)
        Me.return_m.Name = "return_m"
        Me.return_m.Size = New System.Drawing.Size(85, 26)
        Me.return_m.TabIndex = 15
        '
        'total_hour
        '
        Me.total_hour.AutoSize = True
        Me.total_hour.BackColor = System.Drawing.Color.Transparent
        Me.total_hour.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.total_hour.Location = New System.Drawing.Point(158, 334)
        Me.total_hour.Name = "total_hour"
        Me.total_hour.Size = New System.Drawing.Size(26, 28)
        Me.total_hour.TabIndex = 16
        Me.total_hour.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(210, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 28)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "小時"
        '
        'total_min
        '
        Me.total_min.AutoSize = True
        Me.total_min.BackColor = System.Drawing.Color.Transparent
        Me.total_min.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.total_min.Location = New System.Drawing.Point(280, 334)
        Me.total_min.Name = "total_min"
        Me.total_min.Size = New System.Drawing.Size(26, 28)
        Me.total_min.TabIndex = 18
        Me.total_min.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(312, 334)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 28)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "分鐘"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(16, 390)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(136, 28)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "所需費用:"
        '
        'cost
        '
        Me.cost.AutoSize = True
        Me.cost.BackColor = System.Drawing.Color.Transparent
        Me.cost.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.cost.Location = New System.Drawing.Point(158, 390)
        Me.cost.Name = "cost"
        Me.cost.Size = New System.Drawing.Size(26, 28)
        Me.cost.TabIndex = 21
        Me.cost.Text = "0"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.MediumBlue
        Me.Label8.Font = New System.Drawing.Font("新細明體", 16.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(-1, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(264, 60)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "YouBike費率計算"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(222, 390)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 28)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "NTD"
        '
        'GoBack
        '
        Me.GoBack.Image = Global.HappyBiking.My.Resources.Resources.GoBack
        Me.GoBack.Location = New System.Drawing.Point(269, 9)
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(189, 60)
        Me.GoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GoBack.TabIndex = 25
        Me.GoBack.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1391, 536)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(17, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 46)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "計算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Source
        '
        Me.Source.AutoSize = True
        Me.Source.BackColor = System.Drawing.Color.Transparent
        Me.Source.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Source.Location = New System.Drawing.Point(16, 448)
        Me.Source.Name = "Source"
        Me.Source.Size = New System.Drawing.Size(136, 28)
        Me.Source.TabIndex = 29
        Me.Source.Text = "更多資訊:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("新細明體", 14.0!)
        Me.LinkLabel1.Location = New System.Drawing.Point(149, 448)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(312, 28)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "費率說明-YouBike台北市"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HappyBiking.My.Resources.Resources.TIM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(458, 520)
        Me.Controls.Add(Me.Source)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GoBack)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cost)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.total_min)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.total_hour)
        Me.Controls.Add(Me.return_m)
        Me.Controls.Add(Me.return_h)
        Me.Controls.Add(Me.borrow_m)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.borrow_h)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YouBike費率計算"
        CType(Me.GoBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents borrow_h As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents borrow_m As ComboBox
    Friend WithEvents return_h As ComboBox
    Friend WithEvents return_m As ComboBox
    Friend WithEvents total_hour As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents total_min As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cost As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GoBack As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Source As Label
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
