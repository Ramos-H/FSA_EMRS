<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DropdownPanel
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_togglePrivate = New System.Windows.Forms.Button()
        Me.txtbx_subject = New System.Windows.Forms.TextBox()
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.btn_subject = New System.Windows.Forms.Button()
        Me.rtxtbx_text = New System.Windows.Forms.RichTextBox()
        Me.ctxtstrp_selectedText = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Italic = New System.Windows.Forms.ToolStripMenuItem()
        Me.Bold = New System.Windows.Forms.ToolStripMenuItem()
        Me.Underline = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectText = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutSelection = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopySelection = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteText = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.FontSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncreaseFontSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecreaseFontSize = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.ctxtstrp_selectedText.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.btn_togglePrivate)
        Me.Panel1.Controls.Add(Me.txtbx_subject)
        Me.Panel1.Controls.Add(Me.btn_remove)
        Me.Panel1.Controls.Add(Me.btn_subject)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(7, 6)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.MinimumSize = New System.Drawing.Size(1077, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1077, 41)
        Me.Panel1.TabIndex = 0
        '
        'btn_togglePrivate
        '
        Me.btn_togglePrivate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_togglePrivate.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btn_togglePrivate.BackgroundImage = Global.FSA_EMRS.My.Resources.Resources.PassShowImg
        Me.btn_togglePrivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_togglePrivate.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_togglePrivate.FlatAppearance.BorderSize = 0
        Me.btn_togglePrivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_togglePrivate.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_togglePrivate.ForeColor = System.Drawing.Color.White
        Me.btn_togglePrivate.Location = New System.Drawing.Point(999, 0)
        Me.btn_togglePrivate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_togglePrivate.MaximumSize = New System.Drawing.Size(44, 41)
        Me.btn_togglePrivate.Name = "btn_togglePrivate"
        Me.btn_togglePrivate.Size = New System.Drawing.Size(44, 41)
        Me.btn_togglePrivate.TabIndex = 2
        Me.btn_togglePrivate.UseVisualStyleBackColor = False
        Me.btn_togglePrivate.Visible = False
        '
        'txtbx_subject
        '
        Me.txtbx_subject.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.txtbx_subject.Location = New System.Drawing.Point(4, 4)
        Me.txtbx_subject.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbx_subject.Name = "txtbx_subject"
        Me.txtbx_subject.Size = New System.Drawing.Size(593, 32)
        Me.txtbx_subject.TabIndex = 1
        Me.txtbx_subject.Visible = False
        '
        'btn_remove
        '
        Me.btn_remove.AutoSize = True
        Me.btn_remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_remove.BackColor = System.Drawing.Color.Red
        Me.btn_remove.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_remove.FlatAppearance.BorderSize = 0
        Me.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_remove.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_remove.ForeColor = System.Drawing.Color.White
        Me.btn_remove.Location = New System.Drawing.Point(1043, 0)
        Me.btn_remove.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_remove.MaximumSize = New System.Drawing.Size(40, 41)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(34, 41)
        Me.btn_remove.TabIndex = 0
        Me.btn_remove.Text = "X"
        Me.btn_remove.UseVisualStyleBackColor = False
        Me.btn_remove.Visible = False
        '
        'btn_subject
        '
        Me.btn_subject.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.btn_subject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_subject.FlatAppearance.BorderSize = 0
        Me.btn_subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_subject.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_subject.ForeColor = System.Drawing.Color.White
        Me.btn_subject.Location = New System.Drawing.Point(0, 0)
        Me.btn_subject.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_subject.MinimumSize = New System.Drawing.Size(1077, 41)
        Me.btn_subject.Name = "btn_subject"
        Me.btn_subject.Size = New System.Drawing.Size(1077, 41)
        Me.btn_subject.TabIndex = 0
        Me.btn_subject.Text = "Expand"
        Me.btn_subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_subject.UseVisualStyleBackColor = False
        '
        'rtxtbx_text
        '
        Me.rtxtbx_text.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtxtbx_text.ContextMenuStrip = Me.ctxtstrp_selectedText
        Me.rtxtbx_text.Dock = System.Windows.Forms.DockStyle.Top
        Me.rtxtbx_text.Font = New System.Drawing.Font("Century Gothic", 12.0!)
        Me.rtxtbx_text.Location = New System.Drawing.Point(7, 47)
        Me.rtxtbx_text.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rtxtbx_text.Name = "rtxtbx_text"
        Me.rtxtbx_text.ReadOnly = True
        Me.rtxtbx_text.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.rtxtbx_text.Size = New System.Drawing.Size(1077, 31)
        Me.rtxtbx_text.TabIndex = 1
        Me.rtxtbx_text.Text = ""
        '
        'ctxtstrp_selectedText
        '
        Me.ctxtstrp_selectedText.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.ctxtstrp_selectedText.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ctxtstrp_selectedText.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Italic, Me.Bold, Me.Underline, Me.ToolStripSeparator1, Me.SelectText, Me.ToolStripSeparator2, Me.CutSelection, Me.CopySelection, Me.PasteText, Me.ToolStripSeparator3, Me.ClearAll, Me.ToolStripSeparator4, Me.FontSize})
        Me.ctxtstrp_selectedText.Name = "ContextMenuStrip1"
        Me.ctxtstrp_selectedText.Size = New System.Drawing.Size(203, 244)
        '
        'Italic
        '
        Me.Italic.CheckOnClick = True
        Me.Italic.Name = "Italic"
        Me.Italic.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.Italic.Size = New System.Drawing.Size(202, 24)
        Me.Italic.Text = "Italic"
        '
        'Bold
        '
        Me.Bold.CheckOnClick = True
        Me.Bold.Name = "Bold"
        Me.Bold.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.Bold.Size = New System.Drawing.Size(202, 24)
        Me.Bold.Text = "Bold"
        '
        'Underline
        '
        Me.Underline.CheckOnClick = True
        Me.Underline.Name = "Underline"
        Me.Underline.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.Underline.Size = New System.Drawing.Size(202, 24)
        Me.Underline.Text = "Underline"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(199, 6)
        '
        'SelectText
        '
        Me.SelectText.Name = "SelectText"
        Me.SelectText.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectText.Size = New System.Drawing.Size(202, 24)
        Me.SelectText.Text = "Select All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(199, 6)
        '
        'CutSelection
        '
        Me.CutSelection.Name = "CutSelection"
        Me.CutSelection.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutSelection.Size = New System.Drawing.Size(202, 24)
        Me.CutSelection.Text = "Cut"
        '
        'CopySelection
        '
        Me.CopySelection.Name = "CopySelection"
        Me.CopySelection.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopySelection.Size = New System.Drawing.Size(202, 24)
        Me.CopySelection.Text = "Copy"
        '
        'PasteText
        '
        Me.PasteText.Name = "PasteText"
        Me.PasteText.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteText.Size = New System.Drawing.Size(202, 24)
        Me.PasteText.Text = "Paste"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(199, 6)
        '
        'ClearAll
        '
        Me.ClearAll.Name = "ClearAll"
        Me.ClearAll.Size = New System.Drawing.Size(202, 24)
        Me.ClearAll.Text = "Clear"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(199, 6)
        '
        'FontSize
        '
        Me.FontSize.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IncreaseFontSize, Me.DecreaseFontSize})
        Me.FontSize.Name = "FontSize"
        Me.FontSize.Size = New System.Drawing.Size(202, 24)
        Me.FontSize.Text = "Font Size"
        '
        'IncreaseFontSize
        '
        Me.IncreaseFontSize.Name = "IncreaseFontSize"
        Me.IncreaseFontSize.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D9), System.Windows.Forms.Keys)
        Me.IncreaseFontSize.Size = New System.Drawing.Size(215, 26)
        Me.IncreaseFontSize.Text = "Increase"
        '
        'DecreaseFontSize
        '
        Me.DecreaseFontSize.Name = "DecreaseFontSize"
        Me.DecreaseFontSize.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D0), System.Windows.Forms.Keys)
        Me.DecreaseFontSize.Size = New System.Drawing.Size(215, 26)
        Me.DecreaseFontSize.Text = "Decrease"
        '
        'DropdownPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.Controls.Add(Me.rtxtbx_text)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(1091, 41)
        Me.Name = "DropdownPanel"
        Me.Padding = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Size = New System.Drawing.Size(1091, 84)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ctxtstrp_selectedText.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents btn_subject As System.Windows.Forms.Button
    Friend WithEvents rtxtbx_text As System.Windows.Forms.RichTextBox
    Friend WithEvents txtbx_subject As System.Windows.Forms.TextBox
    Friend WithEvents ctxtstrp_selectedText As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Italic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Bold As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Underline As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IncreaseFontSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecreaseFontSize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SelectText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutSelection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopySelection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteText As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_togglePrivate As System.Windows.Forms.Button

End Class
