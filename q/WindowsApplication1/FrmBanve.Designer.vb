<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBanve
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBanve))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txth = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtb = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbtendam = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtthepdoc1 = New System.Windows.Forms.TextBox()
        Me.txtthepdai1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnve = New System.Windows.Forms.Button()
        Me.btnbotrithep = New System.Windows.Forms.Button()
        Me.txtvitri1 = New System.Windows.Forms.TextBox()
        Me.lbvitri = New System.Windows.Forms.Label()
        Me.txtvitri2 = New System.Windows.Forms.TextBox()
        Me.txtthepdai2 = New System.Windows.Forms.TextBox()
        Me.txtthepdoc2 = New System.Windows.Forms.TextBox()
        Me.txtvitri3 = New System.Windows.Forms.TextBox()
        Me.txtthepdai3 = New System.Windows.Forms.TextBox()
        Me.txtthepdoc3 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.khungve = New AxVDProLib5.AxVDPro()
        Me.btn_xuatbanve = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.khungve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(226, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(21, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "(m)"
        Me.Label7.UseWaitCursor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(225, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "(m)"
        Me.Label6.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "(m)"
        Me.Label5.UseWaitCursor = True
        '
        'txth
        '
        Me.txth.Location = New System.Drawing.Point(149, 77)
        Me.txth.Name = "txth"
        Me.txth.Size = New System.Drawing.Size(71, 20)
        Me.txth.TabIndex = 18
        Me.txth.Text = "0.7"
        Me.txth.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Chiều cao tiết diện : "
        Me.Label4.UseWaitCursor = True
        '
        'txtb
        '
        Me.txtb.Location = New System.Drawing.Point(149, 49)
        Me.txtb.Name = "txtb"
        Me.txtb.Size = New System.Drawing.Size(71, 20)
        Me.txtb.TabIndex = 16
        Me.txtb.Text = "0.3"
        Me.txtb.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Chiều Rộng Tiết Diện:"
        Me.Label3.UseWaitCursor = True
        '
        'txtL
        '
        Me.txtL.Location = New System.Drawing.Point(149, 17)
        Me.txtL.Name = "txtL"
        Me.txtL.Size = New System.Drawing.Size(71, 20)
        Me.txtL.TabIndex = 14
        Me.txtL.Text = "8.5"
        Me.txtL.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Chiều Dài Nhịp :"
        Me.Label2.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Chọn Dầm Cần Vẽ : "
        Me.Label1.UseWaitCursor = True
        '
        'cbtendam
        '
        Me.cbtendam.FormattingEnabled = True
        Me.cbtendam.Location = New System.Drawing.Point(135, 18)
        Me.cbtendam.Name = "cbtendam"
        Me.cbtendam.Size = New System.Drawing.Size(123, 21)
        Me.cbtendam.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Thép dọc"
        Me.Label8.UseWaitCursor = True
        '
        'txtthepdoc1
        '
        Me.txtthepdoc1.Location = New System.Drawing.Point(55, 238)
        Me.txtthepdoc1.Name = "txtthepdoc1"
        Me.txtthepdoc1.Size = New System.Drawing.Size(62, 20)
        Me.txtthepdoc1.TabIndex = 24
        Me.txtthepdoc1.Text = "5Ø25 + 5Ø28"
        Me.txtthepdoc1.UseWaitCursor = True
        '
        'txtthepdai1
        '
        Me.txtthepdai1.Location = New System.Drawing.Point(55, 282)
        Me.txtthepdai1.Name = "txtthepdai1"
        Me.txtthepdai1.Size = New System.Drawing.Size(62, 20)
        Me.txtthepdai1.TabIndex = 26
        Me.txtthepdai1.Text = "14Ø8a100"
        Me.txtthepdai1.UseWaitCursor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1, 289)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Thép đai"
        Me.Label9.UseWaitCursor = True
        '
        'btnve
        '
        Me.btnve.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnve.ForeColor = System.Drawing.SystemColors.Control
        Me.btnve.Location = New System.Drawing.Point(96, 329)
        Me.btnve.Name = "btnve"
        Me.btnve.Size = New System.Drawing.Size(78, 41)
        Me.btnve.TabIndex = 27
        Me.btnve.Text = "Vẽ"
        Me.btnve.UseVisualStyleBackColor = False
        '
        'btnbotrithep
        '
        Me.btnbotrithep.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnbotrithep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbotrithep.ForeColor = System.Drawing.SystemColors.Control
        Me.btnbotrithep.Location = New System.Drawing.Point(6, 329)
        Me.btnbotrithep.Name = "btnbotrithep"
        Me.btnbotrithep.Size = New System.Drawing.Size(84, 41)
        Me.btnbotrithep.TabIndex = 28
        Me.btnbotrithep.Text = "Bố Trí Thép"
        Me.btnbotrithep.UseVisualStyleBackColor = False
        '
        'txtvitri1
        '
        Me.txtvitri1.Location = New System.Drawing.Point(55, 196)
        Me.txtvitri1.Name = "txtvitri1"
        Me.txtvitri1.Size = New System.Drawing.Size(62, 20)
        Me.txtvitri1.TabIndex = 31
        Me.txtvitri1.Text = "Gối A"
        Me.txtvitri1.UseWaitCursor = True
        '
        'lbvitri
        '
        Me.lbvitri.AutoSize = True
        Me.lbvitri.Location = New System.Drawing.Point(1, 199)
        Me.lbvitri.Name = "lbvitri"
        Me.lbvitri.Size = New System.Drawing.Size(29, 13)
        Me.lbvitri.TabIndex = 30
        Me.lbvitri.Text = "Vị trí"
        Me.lbvitri.UseWaitCursor = True
        '
        'txtvitri2
        '
        Me.txtvitri2.Location = New System.Drawing.Point(123, 196)
        Me.txtvitri2.Name = "txtvitri2"
        Me.txtvitri2.Size = New System.Drawing.Size(64, 20)
        Me.txtvitri2.TabIndex = 34
        Me.txtvitri2.Text = "Nhịp AB"
        Me.txtvitri2.UseWaitCursor = True
        '
        'txtthepdai2
        '
        Me.txtthepdai2.Location = New System.Drawing.Point(123, 282)
        Me.txtthepdai2.Name = "txtthepdai2"
        Me.txtthepdai2.Size = New System.Drawing.Size(64, 20)
        Me.txtthepdai2.TabIndex = 33
        Me.txtthepdai2.Text = "14Ø8a200"
        Me.txtthepdai2.UseWaitCursor = True
        '
        'txtthepdoc2
        '
        Me.txtthepdoc2.Location = New System.Drawing.Point(123, 238)
        Me.txtthepdoc2.Name = "txtthepdoc2"
        Me.txtthepdoc2.Size = New System.Drawing.Size(64, 20)
        Me.txtthepdoc2.TabIndex = 32
        Me.txtthepdoc2.Text = "4Ø22 + 6Ø28"
        Me.txtthepdoc2.UseWaitCursor = True
        '
        'txtvitri3
        '
        Me.txtvitri3.Location = New System.Drawing.Point(193, 196)
        Me.txtvitri3.Name = "txtvitri3"
        Me.txtvitri3.Size = New System.Drawing.Size(74, 20)
        Me.txtvitri3.TabIndex = 37
        Me.txtvitri3.Text = "Nhịp AB"
        Me.txtvitri3.UseWaitCursor = True
        '
        'txtthepdai3
        '
        Me.txtthepdai3.Location = New System.Drawing.Point(193, 282)
        Me.txtthepdai3.Name = "txtthepdai3"
        Me.txtthepdai3.Size = New System.Drawing.Size(74, 20)
        Me.txtthepdai3.TabIndex = 36
        Me.txtthepdai3.Text = "14Ø8a100"
        Me.txtthepdai3.UseWaitCursor = True
        '
        'txtthepdoc3
        '
        Me.txtthepdoc3.Location = New System.Drawing.Point(193, 238)
        Me.txtthepdoc3.Name = "txtthepdoc3"
        Me.txtthepdoc3.Size = New System.Drawing.Size(74, 20)
        Me.txtthepdoc3.TabIndex = 35
        Me.txtthepdoc3.Text = "5Ø20 + 6Ø28"
        Me.txtthepdoc3.UseWaitCursor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(986, 426)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txtvitri3)
        Me.GroupBox2.Controls.Add(Me.txtthepdai3)
        Me.GroupBox2.Controls.Add(Me.txtthepdoc3)
        Me.GroupBox2.Controls.Add(Me.txtvitri2)
        Me.GroupBox2.Controls.Add(Me.txtthepdai2)
        Me.GroupBox2.Controls.Add(Me.txtthepdoc2)
        Me.GroupBox2.Controls.Add(Me.txtvitri1)
        Me.GroupBox2.Controls.Add(Me.lbvitri)
        Me.GroupBox2.Controls.Add(Me.btnbotrithep)
        Me.GroupBox2.Controls.Add(Me.btn_xuatbanve)
        Me.GroupBox2.Controls.Add(Me.btnve)
        Me.GroupBox2.Controls.Add(Me.txtthepdai1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtthepdoc1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cbtendam)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 415)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txth)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtb)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtL)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 44)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(271, 111)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        '
        'khungve
        '
        Me.khungve.Enabled = True
        Me.khungve.Location = New System.Drawing.Point(301, 31)
        Me.khungve.Name = "khungve"
        Me.khungve.OcxState = CType(resources.GetObject("khungve.OcxState"), System.Windows.Forms.AxHost.State)
        Me.khungve.Size = New System.Drawing.Size(689, 401)
        Me.khungve.TabIndex = 29
        '
        'btn_xuatbanve
        '
        Me.btn_xuatbanve.BackColor = System.Drawing.SystemColors.Highlight
        Me.btn_xuatbanve.Enabled = False
        Me.btn_xuatbanve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_xuatbanve.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_xuatbanve.Location = New System.Drawing.Point(180, 329)
        Me.btn_xuatbanve.Name = "btn_xuatbanve"
        Me.btn_xuatbanve.Size = New System.Drawing.Size(97, 41)
        Me.btn_xuatbanve.TabIndex = 27
        Me.btn_xuatbanve.Text = "Xuất bản vẽ"
        Me.btn_xuatbanve.UseVisualStyleBackColor = False
        '
        'FrmBanve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 450)
        Me.Controls.Add(Me.khungve)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmBanve"
        Me.Text = "Bản vẽ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.khungve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txth As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtb As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtL As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbtendam As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtthepdoc1 As TextBox
    Friend WithEvents txtthepdai1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnve As Button
    Friend WithEvents btnbotrithep As Button
    Friend WithEvents txtvitri1 As TextBox
    Friend WithEvents lbvitri As Label
    Friend WithEvents txtvitri2 As TextBox
    Friend WithEvents txtthepdai2 As TextBox
    Friend WithEvents txtthepdoc2 As TextBox
    Friend WithEvents txtvitri3 As TextBox
    Friend WithEvents txtthepdai3 As TextBox
    Friend WithEvents txtthepdoc3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents khungve As AxVDProLib5.AxVDPro
    Friend WithEvents btn_xuatbanve As Button
End Class
