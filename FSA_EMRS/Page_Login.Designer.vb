<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page_Login
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
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.tblpnl_main = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbx_usrnm = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbx_psswrd = New System.Windows.Forms.TextBox()
        Me.lnklbl_help = New System.Windows.Forms.LinkLabel()
        Me.tblpnl_main.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_cancel.BackColor = System.Drawing.Color.Red
        Me.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(663, 523)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(200, 40)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_login
        '
        Me.btn_login.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(161, 523)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(200, 40)
        Me.btn_login.TabIndex = 1
        Me.btn_login.Text = "Log In"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'tblpnl_main
        '
        Me.tblpnl_main.ColumnCount = 2
        Me.tblpnl_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblpnl_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblpnl_main.Controls.Add(Me.btn_login, 0, 5)
        Me.tblpnl_main.Controls.Add(Me.btn_cancel, 1, 5)
        Me.tblpnl_main.Controls.Add(Me.FlowLayoutPanel1, 0, 1)
        Me.tblpnl_main.Controls.Add(Me.FlowLayoutPanel2, 0, 2)
        Me.tblpnl_main.Controls.Add(Me.lnklbl_help, 0, 3)
        Me.tblpnl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblpnl_main.Location = New System.Drawing.Point(0, 0)
        Me.tblpnl_main.Name = "tblpnl_main"
        Me.tblpnl_main.Padding = New System.Windows.Forms.Padding(10)
        Me.tblpnl_main.RowCount = 6
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.32258!))
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.451613!))
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.32258!))
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblpnl_main.Size = New System.Drawing.Size(1024, 576)
        Me.tblpnl_main.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel1.AutoSize = True
        Me.tblpnl_main.SetColumnSpan(Me.FlowLayoutPanel1, 2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtbx_usrnm)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(272, 203)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(479, 43)
        Me.FlowLayoutPanel1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Username"
        '
        'txtbx_usrnm
        '
        Me.txtbx_usrnm.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtbx_usrnm.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_usrnm.ForeColor = System.Drawing.Color.Black
        Me.txtbx_usrnm.Location = New System.Drawing.Point(142, 3)
        Me.txtbx_usrnm.Name = "txtbx_usrnm"
        Me.txtbx_usrnm.Size = New System.Drawing.Size(334, 37)
        Me.txtbx_usrnm.TabIndex = 3
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel2.AutoSize = True
        Me.tblpnl_main.SetColumnSpan(Me.FlowLayoutPanel2, 2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel2.Controls.Add(Me.txtbx_psswrd)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(274, 252)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(475, 43)
        Me.FlowLayoutPanel2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 30)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'txtbx_psswrd
        '
        Me.txtbx_psswrd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtbx_psswrd.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbx_psswrd.ForeColor = System.Drawing.Color.Black
        Me.txtbx_psswrd.Location = New System.Drawing.Point(131, 3)
        Me.txtbx_psswrd.Name = "txtbx_psswrd"
        Me.txtbx_psswrd.Size = New System.Drawing.Size(341, 37)
        Me.txtbx_psswrd.TabIndex = 7
        Me.txtbx_psswrd.UseSystemPasswordChar = True
        '
        'lnklbl_help
        '
        Me.lnklbl_help.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lnklbl_help.AutoSize = True
        Me.tblpnl_main.SetColumnSpan(Me.lnklbl_help, 2)
        Me.lnklbl_help.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnklbl_help.LinkColor = System.Drawing.Color.PaleGreen
        Me.lnklbl_help.Location = New System.Drawing.Point(457, 298)
        Me.lnklbl_help.Name = "lnklbl_help"
        Me.lnklbl_help.Size = New System.Drawing.Size(109, 24)
        Me.lnklbl_help.TabIndex = 9
        Me.lnklbl_help.TabStop = True
        Me.lnklbl_help.Text = "Need help?"
        '
        'Page_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Controls.Add(Me.tblpnl_main)
        Me.DoubleBuffered = True
        Me.Name = "Page_Login"
        Me.Size = New System.Drawing.Size(1024, 576)
        Me.tblpnl_main.ResumeLayout(False)
        Me.tblpnl_main.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents tblpnl_main As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txtbx_usrnm As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbx_psswrd As System.Windows.Forms.TextBox
    Friend WithEvents lnklbl_help As System.Windows.Forms.LinkLabel

End Class
