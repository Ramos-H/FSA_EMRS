<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page_Register
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
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_subPageContainer = New System.Windows.Forms.Panel()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.tblpnl_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblpnl_main
        '
        Me.tblpnl_main.ColumnCount = 2
        Me.tblpnl_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblpnl_main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblpnl_main.Controls.Add(Me.btn_cancel, 0, 2)
        Me.tblpnl_main.Controls.Add(Me.Label1, 0, 0)
        Me.tblpnl_main.Controls.Add(Me.pnl_subPageContainer, 0, 1)
        Me.tblpnl_main.Controls.Add(Me.btn_ok, 1, 2)
        Me.tblpnl_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblpnl_main.Location = New System.Drawing.Point(0, 0)
        Me.tblpnl_main.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tblpnl_main.Name = "tblpnl_main"
        Me.tblpnl_main.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.tblpnl_main.RowCount = 3
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.33813!))
        Me.tblpnl_main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.733813!))
        Me.tblpnl_main.Size = New System.Drawing.Size(1365, 709)
        Me.tblpnl_main.TabIndex = 0
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_cancel.BackColor = System.Drawing.Color.Red
        Me.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_cancel.ForeColor = System.Drawing.Color.White
        Me.btn_cancel.Location = New System.Drawing.Point(267, 647)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(160, 46)
        Me.btn_cancel.TabIndex = 3
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.tblpnl_main.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 28.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(17, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Register"
        '
        'pnl_subPageContainer
        '
        Me.pnl_subPageContainer.AutoScroll = True
        Me.tblpnl_main.SetColumnSpan(Me.pnl_subPageContainer, 2)
        Me.pnl_subPageContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_subPageContainer.Location = New System.Drawing.Point(17, 118)
        Me.pnl_subPageContainer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnl_subPageContainer.Name = "pnl_subPageContainer"
        Me.pnl_subPageContainer.Padding = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.pnl_subPageContainer.Size = New System.Drawing.Size(1331, 521)
        Me.pnl_subPageContainer.TabIndex = 1
        '
        'btn_ok
        '
        Me.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_ok.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ok.ForeColor = System.Drawing.Color.White
        Me.btn_ok.Location = New System.Drawing.Point(937, 647)
        Me.btn_ok.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(160, 46)
        Me.btn_ok.TabIndex = 2
        Me.btn_ok.Text = "Next"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'Page_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Controls.Add(Me.tblpnl_main)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Page_Register"
        Me.Size = New System.Drawing.Size(1365, 709)
        Me.tblpnl_main.ResumeLayout(False)
        Me.tblpnl_main.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tblpnl_main As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents pnl_subPageContainer As System.Windows.Forms.Panel

End Class
