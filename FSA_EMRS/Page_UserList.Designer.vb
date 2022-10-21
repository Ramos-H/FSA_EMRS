<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page_UserList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.tblpnl_main = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.txtbx_searchBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userPic = New System.Windows.Forms.Panel()
        Me.pnl_ListContainer = New System.Windows.Forms.Panel()
        Me.tblpnl_main.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblpnl_main
        '
        Me.tblpnl_main.ColumnCount = 2
        Me.tblpnl_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblpnl_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblpnl_main.Controls.Add(Me.Panel3, 1, 0)
        Me.tblpnl_main.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.tblpnl_main.Controls.Add(Me.pnl_ListContainer, 1, 1)
        Me.tblpnl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblpnl_main.Location = New System.Drawing.Point(0, 0)
        Me.tblpnl_main.Name = "tblpnl_main"
        Me.tblpnl_main.RowCount = 2
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.tblpnl_main.Size = New System.Drawing.Size(1024, 576)
        Me.tblpnl_main.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.btn_delete)
        Me.Panel3.Controls.Add(Me.btn_select)
        Me.Panel3.Controls.Add(Me.btn_search)
        Me.Panel3.Controls.Add(Me.txtbx_searchBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(220, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(801, 109)
        Me.Panel3.TabIndex = 2
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.AutoSize = True
        Me.btn_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_delete.BackColor = System.Drawing.Color.Red
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.Location = New System.Drawing.Point(120, 75)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(80, 31)
        Me.btn_delete.TabIndex = 8
        Me.btn_delete.Text = "DELETE"
        Me.btn_delete.UseVisualStyleBackColor = False
        Me.btn_delete.Visible = False
        '
        'btn_select
        '
        Me.btn_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_select.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btn_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_select.FlatAppearance.BorderSize = 0
        Me.btn_select.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btn_select.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btn_select.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_select.ForeColor = System.Drawing.Color.White
        Me.btn_select.Location = New System.Drawing.Point(3, 77)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(111, 29)
        Me.btn_select.TabIndex = 5
        Me.btn_select.Text = "Select All"
        Me.btn_select.UseVisualStyleBackColor = False
        '
        'btn_search
        '
        Me.btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_search.Location = New System.Drawing.Point(723, 83)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 23)
        Me.btn_search.TabIndex = 1
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'txtbx_searchBox
        '
        Me.txtbx_searchBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbx_searchBox.Location = New System.Drawing.Point(531, 85)
        Me.txtbx_searchBox.Name = "txtbx_searchBox"
        Me.txtbx_searchBox.Size = New System.Drawing.Size(186, 20)
        Me.txtbx_searchBox.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Maroon
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_name, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.userPic, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.tblpnl_main.SetRowSpan(Me.TableLayoutPanel1, 2)
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.11032!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.88968!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(211, 570)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_name
        '
        Me.lbl_name.AutoEllipsis = True
        Me.lbl_name.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_name.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(3, 232)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(205, 21)
        Me.lbl_name.TabIndex = 3
        Me.lbl_name.Text = "Unknown"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 336)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel1.Size = New System.Drawing.Size(205, 231)
        Me.Panel1.TabIndex = 1
        '
        'btn_logout
        '
        Me.btn_logout.AutoSize = True
        Me.btn_logout.BackColor = System.Drawing.Color.Red
        Me.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_logout.FlatAppearance.BorderSize = 0
        Me.btn_logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_logout.ForeColor = System.Drawing.Color.White
        Me.btn_logout.Location = New System.Drawing.Point(3, 195)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(199, 33)
        Me.btn_logout.TabIndex = 7
        Me.btn_logout.Text = "Log-out"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(14, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Currently logged in:"
        '
        'userPic
        '
        Me.userPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.userPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.userPic.Location = New System.Drawing.Point(3, 3)
        Me.userPic.Name = "userPic"
        Me.userPic.Size = New System.Drawing.Size(205, 205)
        Me.userPic.TabIndex = 4
        '
        'pnl_ListContainer
        '
        Me.pnl_ListContainer.AutoScroll = True
        Me.pnl_ListContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnl_ListContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_ListContainer.Location = New System.Drawing.Point(220, 118)
        Me.pnl_ListContainer.Name = "pnl_ListContainer"
        Me.pnl_ListContainer.Size = New System.Drawing.Size(801, 455)
        Me.pnl_ListContainer.TabIndex = 1
        '
        'Page_UserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.Controls.Add(Me.tblpnl_main)
        Me.DoubleBuffered = True
        Me.Name = "Page_UserList"
        Me.Size = New System.Drawing.Size(1024, 576)
        Me.tblpnl_main.ResumeLayout(False)
        Me.tblpnl_main.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblpnl_main As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents pnl_ListContainer As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents txtbx_searchBox As System.Windows.Forms.TextBox
    Friend WithEvents userPic As System.Windows.Forms.Panel
    Friend WithEvents btn_select As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button

End Class
