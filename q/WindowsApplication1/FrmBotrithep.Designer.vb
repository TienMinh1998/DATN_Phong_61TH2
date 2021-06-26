<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBotrithep
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvKetqua = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vitri = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnbotri = New System.Windows.Forms.Button()
        Me.lbKetqua = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAsbt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbdk2 = New System.Windows.Forms.ComboBox()
        Me.cbst2 = New System.Windows.Forms.ComboBox()
        Me.cbdk1 = New System.Windows.Forms.ComboBox()
        Me.cbst1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAs = New System.Windows.Forms.TextBox()
        Me.lbAs = New System.Windows.Forms.Label()
        Me.btnvatlieu = New System.Windows.Forms.Button()
        Me.btnnoiluc = New System.Windows.Forms.Button()
        Me.btnbanve = New System.Windows.Forms.Button()
        CType(Me.dgvKetqua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvKetqua
        '
        Me.dgvKetqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKetqua.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.vitri, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvKetqua.Location = New System.Drawing.Point(21, 10)
        Me.dgvKetqua.Name = "dgvKetqua"
        Me.dgvKetqua.Size = New System.Drawing.Size(444, 174)
        Me.dgvKetqua.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tên dầm"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 75
        '
        'vitri
        '
        Me.vitri.HeaderText = "Vị Trí"
        Me.vitri.Name = "vitri"
        Me.vitri.Width = 75
        '
        'Column2
        '
        Me.Column2.HeaderText = "As(cm2)"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 75
        '
        'Column3
        '
        Me.Column3.HeaderText = "μ%"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 75
        '
        'Column4
        '
        Me.Column4.HeaderText = "Thép dọc"
        Me.Column4.Name = "Column4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnbotri)
        Me.GroupBox1.Controls.Add(Me.lbKetqua)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtAsbt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cbdk2)
        Me.GroupBox1.Controls.Add(Me.cbst2)
        Me.GroupBox1.Controls.Add(Me.cbdk1)
        Me.GroupBox1.Controls.Add(Me.cbst1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAs)
        Me.GroupBox1.Controls.Add(Me.lbAs)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 235)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bố Trí Thép"
        '
        'btnbotri
        '
        Me.btnbotri.Location = New System.Drawing.Point(309, 139)
        Me.btnbotri.Name = "btnbotri"
        Me.btnbotri.Size = New System.Drawing.Size(96, 57)
        Me.btnbotri.TabIndex = 21
        Me.btnbotri.Text = "Bố Trí"
        Me.btnbotri.UseVisualStyleBackColor = True
        '
        'lbKetqua
        '
        Me.lbKetqua.AutoSize = True
        Me.lbKetqua.ForeColor = System.Drawing.Color.Red
        Me.lbKetqua.Location = New System.Drawing.Point(46, 196)
        Me.lbKetqua.Name = "lbKetqua"
        Me.lbKetqua.Size = New System.Drawing.Size(79, 13)
        Me.lbKetqua.TabIndex = 20
        Me.lbKetqua.Text = "Chưa thỏa mãn"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(123, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "cm2"
        '
        'txtAsbt
        '
        Me.txtAsbt.Location = New System.Drawing.Point(59, 157)
        Me.txtAsbt.Name = "txtAsbt"
        Me.txtAsbt.Size = New System.Drawing.Size(58, 20)
        Me.txtAsbt.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Asbt="
        '
        'cbdk2
        '
        Me.cbdk2.FormattingEnabled = True
        Me.cbdk2.Items.AddRange(New Object() {"", "14", "16", "18", "20", "22", "25", "28", "30", "32", "36", "40"})
        Me.cbdk2.Location = New System.Drawing.Point(170, 117)
        Me.cbdk2.Name = "cbdk2"
        Me.cbdk2.Size = New System.Drawing.Size(67, 21)
        Me.cbdk2.TabIndex = 16
        '
        'cbst2
        '
        Me.cbst2.FormattingEnabled = True
        Me.cbst2.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbst2.Location = New System.Drawing.Point(83, 117)
        Me.cbst2.Name = "cbst2"
        Me.cbst2.Size = New System.Drawing.Size(67, 21)
        Me.cbst2.TabIndex = 15
        '
        'cbdk1
        '
        Me.cbdk1.FormattingEnabled = True
        Me.cbdk1.Items.AddRange(New Object() {"", "14", "16", "18", "20", "22", "25", "28", "30", "32", "36", "40"})
        Me.cbdk1.Location = New System.Drawing.Point(170, 87)
        Me.cbdk1.Name = "cbdk1"
        Me.cbdk1.Size = New System.Drawing.Size(67, 21)
        Me.cbdk1.TabIndex = 14
        '
        'cbst1
        '
        Me.cbst1.FormattingEnabled = True
        Me.cbst1.Items.AddRange(New Object() {"", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.cbst1.Location = New System.Drawing.Point(83, 87)
        Me.cbst1.Name = "cbst1"
        Me.cbst1.Size = New System.Drawing.Size(67, 21)
        Me.cbst1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Đường Kính"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Loại 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Loại 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(93, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Số Thanh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "cm2"
        '
        'txtAs
        '
        Me.txtAs.Location = New System.Drawing.Point(59, 31)
        Me.txtAs.Name = "txtAs"
        Me.txtAs.Size = New System.Drawing.Size(58, 20)
        Me.txtAs.TabIndex = 6
        '
        'lbAs
        '
        Me.lbAs.AutoSize = True
        Me.lbAs.Location = New System.Drawing.Point(26, 34)
        Me.lbAs.Name = "lbAs"
        Me.lbAs.Size = New System.Drawing.Size(25, 13)
        Me.lbAs.TabIndex = 5
        Me.lbAs.Text = "As="
        '
        'btnvatlieu
        '
        Me.btnvatlieu.Location = New System.Drawing.Point(535, 165)
        Me.btnvatlieu.Name = "btnvatlieu"
        Me.btnvatlieu.Size = New System.Drawing.Size(96, 57)
        Me.btnvatlieu.TabIndex = 22
        Me.btnvatlieu.Text = "Vật liệu"
        Me.btnvatlieu.UseVisualStyleBackColor = True
        '
        'btnnoiluc
        '
        Me.btnnoiluc.Location = New System.Drawing.Point(535, 256)
        Me.btnnoiluc.Name = "btnnoiluc"
        Me.btnnoiluc.Size = New System.Drawing.Size(96, 57)
        Me.btnnoiluc.TabIndex = 23
        Me.btnnoiluc.Text = "Nội Lực"
        Me.btnnoiluc.UseVisualStyleBackColor = True
        '
        'btnbanve
        '
        Me.btnbanve.Location = New System.Drawing.Point(535, 350)
        Me.btnbanve.Name = "btnbanve"
        Me.btnbanve.Size = New System.Drawing.Size(96, 57)
        Me.btnbanve.TabIndex = 24
        Me.btnbanve.Text = "Bản Vẽ"
        Me.btnbanve.UseVisualStyleBackColor = True
        '
        'FrmBotrithep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 447)
        Me.Controls.Add(Me.btnbanve)
        Me.Controls.Add(Me.btnnoiluc)
        Me.Controls.Add(Me.btnvatlieu)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvKetqua)
        Me.Name = "FrmBotrithep"
        Me.Text = "Bố Trí Thép"
        CType(Me.dgvKetqua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvKetqua As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbdk1 As ComboBox
    Friend WithEvents cbst1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAs As TextBox
    Friend WithEvents lbAs As Label
    Friend WithEvents btnbotri As Button
    Friend WithEvents lbKetqua As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtAsbt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbdk2 As ComboBox
    Friend WithEvents cbst2 As ComboBox
    Friend WithEvents btnvatlieu As Button
    Friend WithEvents btnnoiluc As Button
    Friend WithEvents btnbanve As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents vitri As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
