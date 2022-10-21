<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubPage_Register2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubPage_Register2))
        Me.tblpnl_main = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_userPic = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbx_usrName = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbx_pass = New System.Windows.Forms.TextBox()
        Me.btn_showPass = New System.Windows.Forms.Button()
        Me.imglst_eyes = New System.Windows.Forms.ImageList(Me.components)
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbx_confirmPass = New System.Windows.Forms.TextBox()
        Me.btn_showConfirmPass = New System.Windows.Forms.Button()
        Me.tblpnl_main.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel7.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel5.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblpnl_main
        '
        Me.tblpnl_main.AutoSize = True
        Me.tblpnl_main.ColumnCount = 1
        Me.tblpnl_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tblpnl_main.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.tblpnl_main.Controls.Add(Me.FlowLayoutPanel7, 0, 1)
        Me.tblpnl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblpnl_main.Location = New System.Drawing.Point(0, 0)
        Me.tblpnl_main.Name = "tblpnl_main"
        Me.tblpnl_main.RowCount = 2
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tblpnl_main.Size = New System.Drawing.Size(998, 443)
        Me.tblpnl_main.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_userPic, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(374, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(250, 300)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(59, 254)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 42)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "A 1x1 picture is recommended."
        '
        'btn_userPic
        '
        Me.btn_userPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_userPic.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_userPic.FlatAppearance.BorderSize = 0
        Me.btn_userPic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_userPic.Location = New System.Drawing.Point(3, 3)
        Me.btn_userPic.Name = "btn_userPic"
        Me.btn_userPic.Size = New System.Drawing.Size(244, 244)
        Me.btn_userPic.TabIndex = 0
        Me.btn_userPic.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FlowLayoutPanel7.AutoSize = True
        Me.FlowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel7.Controls.Add(Me.FlowLayoutPanel1)
        Me.FlowLayoutPanel7.Controls.Add(Me.FlowLayoutPanel4)
        Me.FlowLayoutPanel7.Controls.Add(Me.FlowLayoutPanel5)
        Me.FlowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(297, 309)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(404, 131)
        Me.FlowLayoutPanel7.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.Label1)
        Me.FlowLayoutPanel1.Controls.Add(Me.txtbx_usrName)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(352, 33)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txtbx_usrName
        '
        Me.txtbx_usrName.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtbx_usrName.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtbx_usrName.Location = New System.Drawing.Point(97, 3)
        Me.txtbx_usrName.Name = "txtbx_usrName"
        Me.txtbx_usrName.Size = New System.Drawing.Size(252, 27)
        Me.txtbx_usrName.TabIndex = 1
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.AutoSize = True
        Me.FlowLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel4.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel4.Controls.Add(Me.btn_showPass)
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(3, 42)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(398, 40)
        Me.FlowLayoutPanel4.TabIndex = 3
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel2.Controls.Add(Me.txtbx_pass)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(352, 33)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Password"
        '
        'txtbx_pass
        '
        Me.txtbx_pass.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtbx_pass.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtbx_pass.Location = New System.Drawing.Point(91, 3)
        Me.txtbx_pass.Name = "txtbx_pass"
        Me.txtbx_pass.Size = New System.Drawing.Size(258, 27)
        Me.txtbx_pass.TabIndex = 1
        Me.txtbx_pass.UseSystemPasswordChar = True
        '
        'btn_showPass
        '
        Me.btn_showPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_showPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_showPass.FlatAppearance.BorderSize = 0
        Me.btn_showPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_showPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_showPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_showPass.ImageIndex = 0
        Me.btn_showPass.ImageList = Me.imglst_eyes
        Me.btn_showPass.Location = New System.Drawing.Point(361, 3)
        Me.btn_showPass.Name = "btn_showPass"
        Me.btn_showPass.Size = New System.Drawing.Size(34, 34)
        Me.btn_showPass.TabIndex = 0
        Me.btn_showPass.TabStop = False
        Me.btn_showPass.UseVisualStyleBackColor = True
        '
        'imglst_eyes
        '
        Me.imglst_eyes.ImageStream = CType(resources.GetObject("imglst_eyes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglst_eyes.TransparentColor = System.Drawing.Color.Transparent
        Me.imglst_eyes.Images.SetKeyName(0, "PassHideImg.png")
        Me.imglst_eyes.Images.SetKeyName(1, "PassShowImg.png")
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.AutoSize = True
        Me.FlowLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel5.Controls.Add(Me.FlowLayoutPanel3)
        Me.FlowLayoutPanel5.Controls.Add(Me.btn_showConfirmPass)
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(3, 88)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(398, 40)
        Me.FlowLayoutPanel5.TabIndex = 4
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel3.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel3.Controls.Add(Me.txtbx_confirmPass)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(352, 33)
        Me.FlowLayoutPanel3.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 21)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Confirm Password"
        '
        'txtbx_confirmPass
        '
        Me.txtbx_confirmPass.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtbx_confirmPass.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtbx_confirmPass.Location = New System.Drawing.Point(156, 3)
        Me.txtbx_confirmPass.Name = "txtbx_confirmPass"
        Me.txtbx_confirmPass.Size = New System.Drawing.Size(193, 27)
        Me.txtbx_confirmPass.TabIndex = 1
        Me.txtbx_confirmPass.UseSystemPasswordChar = True
        '
        'btn_showConfirmPass
        '
        Me.btn_showConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_showConfirmPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_showConfirmPass.FlatAppearance.BorderSize = 0
        Me.btn_showConfirmPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_showConfirmPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_showConfirmPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_showConfirmPass.ImageIndex = 0
        Me.btn_showConfirmPass.ImageList = Me.imglst_eyes
        Me.btn_showConfirmPass.Location = New System.Drawing.Point(361, 3)
        Me.btn_showConfirmPass.Name = "btn_showConfirmPass"
        Me.btn_showConfirmPass.Size = New System.Drawing.Size(34, 34)
        Me.btn_showConfirmPass.TabIndex = 0
        Me.btn_showConfirmPass.TabStop = False
        Me.btn_showConfirmPass.UseVisualStyleBackColor = True
        '
        'SubPage_Register2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tblpnl_main)
        Me.Name = "SubPage_Register2"
        Me.Size = New System.Drawing.Size(998, 443)
        Me.tblpnl_main.ResumeLayout(False)
        Me.tblpnl_main.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel7.ResumeLayout(False)
        Me.FlowLayoutPanel7.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel4.ResumeLayout(False)
        Me.FlowLayoutPanel4.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel5.ResumeLayout(False)
        Me.FlowLayoutPanel5.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tblpnl_main As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtbx_usrName As System.Windows.Forms.TextBox
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbx_pass As System.Windows.Forms.TextBox
    Friend WithEvents btn_showPass As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbx_confirmPass As System.Windows.Forms.TextBox
    Friend WithEvents btn_showConfirmPass As System.Windows.Forms.Button
    Friend WithEvents btn_userPic As System.Windows.Forms.Button
    Friend WithEvents imglst_eyes As System.Windows.Forms.ImageList
    Friend WithEvents FlowLayoutPanel4 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel7 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel5 As System.Windows.Forms.FlowLayoutPanel

End Class
