<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Topic = New System.Windows.Forms.Label()
        Me.Content = New System.Windows.Forms.Label()
        Me.NextPage = New System.Windows.Forms.PictureBox()
        Me.PreviousPage = New System.Windows.Forms.PictureBox()
        Me.GoBack = New System.Windows.Forms.PictureBox()
        CType(Me.NextPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreviousPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GoBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Topic
        '
        Me.Topic.AutoSize = True
        Me.Topic.BackColor = System.Drawing.Color.Transparent
        Me.Topic.Font = New System.Drawing.Font("新細明體", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Topic.ForeColor = System.Drawing.Color.Blue
        Me.Topic.Location = New System.Drawing.Point(20, 173)
        Me.Topic.Name = "Topic"
        Me.Topic.Size = New System.Drawing.Size(132, 48)
        Me.Topic.TabIndex = 1
        Me.Topic.Text = "Topic"
        '
        'Content
        '
        Me.Content.BackColor = System.Drawing.Color.Transparent
        Me.Content.Font = New System.Drawing.Font("新細明體", 15.0!)
        Me.Content.ForeColor = System.Drawing.Color.Blue
        Me.Content.Location = New System.Drawing.Point(23, 241)
        Me.Content.Name = "Content"
        Me.Content.Size = New System.Drawing.Size(857, 275)
        Me.Content.TabIndex = 2
        Me.Content.Text = "Content"
        '
        'NextPage
        '
        Me.NextPage.Image = Global.HappyBiking.My.Resources.Resources._Next
        Me.NextPage.Location = New System.Drawing.Point(705, 109)
        Me.NextPage.Name = "NextPage"
        Me.NextPage.Size = New System.Drawing.Size(191, 81)
        Me.NextPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NextPage.TabIndex = 5
        Me.NextPage.TabStop = False
        '
        'PreviousPage
        '
        Me.PreviousPage.Image = Global.HappyBiking.My.Resources.Resources.Previous
        Me.PreviousPage.Location = New System.Drawing.Point(548, 12)
        Me.PreviousPage.Name = "PreviousPage"
        Me.PreviousPage.Size = New System.Drawing.Size(191, 81)
        Me.PreviousPage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PreviousPage.TabIndex = 6
        Me.PreviousPage.TabStop = False
        '
        'GoBack
        '
        Me.GoBack.Image = Global.HappyBiking.My.Resources.Resources.GoBack
        Me.GoBack.Location = New System.Drawing.Point(28, 12)
        Me.GoBack.Name = "GoBack"
        Me.GoBack.Size = New System.Drawing.Size(191, 81)
        Me.GoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GoBack.TabIndex = 7
        Me.GoBack.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.HappyBiking.My.Resources.Resources.aboutYoubike_bg31
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(909, 534)
        Me.Controls.Add(Me.GoBack)
        Me.Controls.Add(Me.PreviousPage)
        Me.Controls.Add(Me.NextPage)
        Me.Controls.Add(Me.Content)
        Me.Controls.Add(Me.Topic)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "關於YouBike"
        CType(Me.NextPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreviousPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GoBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Topic As Label
    Friend WithEvents Content As Label
    Friend WithEvents NextPage As PictureBox
    Friend WithEvents PreviousPage As PictureBox
    Friend WithEvents GoBack As PictureBox
End Class
