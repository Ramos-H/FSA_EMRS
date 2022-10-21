<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page_Index
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_register = New System.Windows.Forms.Button()
        Me.tblpnl_main.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tblpnl_main
        '
        Me.tblpnl_main.BackColor = System.Drawing.Color.Transparent
        Me.tblpnl_main.ColumnCount = 3
        Me.tblpnl_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblpnl_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblpnl_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblpnl_main.Controls.Add(Me.PictureBox1, 1, 1)
        Me.tblpnl_main.Controls.Add(Me.Label1, 0, 0)
        Me.tblpnl_main.Controls.Add(Me.btn_login, 0, 2)
        Me.tblpnl_main.Controls.Add(Me.btn_exit, 1, 2)
        Me.tblpnl_main.Controls.Add(Me.btn_register, 2, 2)
        Me.tblpnl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblpnl_main.Location = New System.Drawing.Point(0, 0)
        Me.tblpnl_main.Name = "tblpnl_main"
        Me.tblpnl_main.Padding = New System.Windows.Forms.Padding(10)
        Me.tblpnl_main.RowCount = 3
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblpnl_main.Size = New System.Drawing.Size(1024, 576)
        Me.tblpnl_main.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackgroundImage = Global.FSA_EMRS.My.Resources.Resources.fsalogowhitetransparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(387, 163)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(250, 250)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.tblpnl_main.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(976, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome to the Fr. Simpliciano Academy, Inc. Medical Record Database"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_login.Location = New System.Drawing.Point(35, 523)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(200, 40)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "Log In"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_exit.BackColor = System.Drawing.Color.Red
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_exit.ForeColor = System.Drawing.Color.White
        Me.btn_exit.Location = New System.Drawing.Point(412, 523)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(200, 40)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_register
        '
        Me.btn_register.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btn_register.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btn_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_register.FlatAppearance.BorderSize = 0
        Me.btn_register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btn_register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_register.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_register.ForeColor = System.Drawing.Color.White
        Me.btn_register.Location = New System.Drawing.Point(788, 523)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(200, 40)
        Me.btn_register.TabIndex = 2
        Me.btn_register.Text = "Register"
        Me.btn_register.UseVisualStyleBackColor = False
        '
        'Page_Index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tblpnl_main)
        Me.DoubleBuffered = True
        Me.Name = "Page_Index"
        Me.Size = New System.Drawing.Size(1024, 576)
        Me.tblpnl_main.ResumeLayout(False)
        Me.tblpnl_main.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblpnl_main As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_register As System.Windows.Forms.Button

End Class
