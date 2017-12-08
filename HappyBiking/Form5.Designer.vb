<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.GoBack = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Level = New System.Windows.Forms.Label()
        Me.Length = New System.Windows.Forms.Label()
        Me.Route = New System.Windows.Forms.Label()
        Me.Suggestion = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Source = New System.Windows.Forms.Label()
        CType(Me.GoBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GoBack
        '
        Me.GoBack.Image = Global.HappyBiking.My.Resources.Resources.GoBack
        Me.GoBack.Location = New System.Drawing.Point(-1, 1)
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(198, 65)
        Me.GoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GoBack.TabIndex = 8
        Me.GoBack.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("新細明體", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(385, 60)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "熱門路線推薦"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("新細明體", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(288, 32)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "台北市自行車步道:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"新店溪河濱腳踏車道", "貴子坑溪河濱腳踏車道", "景美溪河濱腳踏車道", "南港六張犁自行車道", "社子島環島與二重疏洪道自行車道", "北投溫泉自行車道", "關渡自然公園自行車道", "基隆河親水自行車道", "延平河濱公園自行車道", "木柵貓空自行車道"})
        Me.ComboBox1.Location = New System.Drawing.Point(297, 98)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(289, 26)
        Me.ComboBox1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(15, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 28)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "難易度:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(15, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 28)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "全長:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(15, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 28)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "路線:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(15, 389)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 28)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "建議："
        '
        'Level
        '
        Me.Level.AutoSize = True
        Me.Level.BackColor = System.Drawing.Color.Transparent
        Me.Level.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Level.Location = New System.Drawing.Point(112, 171)
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(77, 28)
        Me.Level.TabIndex = 16
        Me.Level.Text = "Level"
        '
        'Length
        '
        Me.Length.AutoSize = True
        Me.Length.BackColor = System.Drawing.Color.Transparent
        Me.Length.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Length.Location = New System.Drawing.Point(112, 230)
        Me.Length.Name = "Length"
        Me.Length.Size = New System.Drawing.Size(92, 28)
        Me.Length.TabIndex = 17
        Me.Length.Text = "Length"
        '
        'Route
        '
        Me.Route.BackColor = System.Drawing.Color.Transparent
        Me.Route.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Route.Location = New System.Drawing.Point(112, 284)
        Me.Route.Name = "Route"
        Me.Route.Size = New System.Drawing.Size(476, 105)
        Me.Route.TabIndex = 18
        Me.Route.Text = "Route"
        '
        'Suggestion
        '
        Me.Suggestion.BackColor = System.Drawing.Color.Transparent
        Me.Suggestion.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Suggestion.Location = New System.Drawing.Point(112, 389)
        Me.Suggestion.Name = "Suggestion"
        Me.Suggestion.Size = New System.Drawing.Size(476, 146)
        Me.Suggestion.TabIndex = 19
        Me.Suggestion.Text = "Suggestion"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("新細明體", 14.0!)
        Me.LinkLabel1.Location = New System.Drawing.Point(148, 541)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(413, 28)
        Me.LinkLabel1.TabIndex = 20
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "台北自行車步道-四方通行單車網"
        '
        'Source
        '
        Me.Source.AutoSize = True
        Me.Source.BackColor = System.Drawing.Color.Transparent
        Me.Source.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Source.Location = New System.Drawing.Point(15, 541)
        Me.Source.Name = "Source"
        Me.Source.Size = New System.Drawing.Size(136, 28)
        Me.Source.TabIndex = 21
        Me.Source.Text = "資料來源:"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HappyBiking.My.Resources.Resources.taipei_map
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(607, 589)
        Me.Controls.Add(Me.Source)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Suggestion)
        Me.Controls.Add(Me.Route)
        Me.Controls.Add(Me.Length)
        Me.Controls.Add(Me.Level)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GoBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "熱門路線推薦"
        CType(Me.GoBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GoBack As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Level As Label
    Friend WithEvents Length As Label
    Friend WithEvents Route As Label
    Friend WithEvents Suggestion As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Source As Label
End Class
