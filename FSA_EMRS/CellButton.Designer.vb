<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CellButton
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
        Me.btn_name = New System.Windows.Forms.Button()
        Me.chkbx_selected = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'btn_name
        '
        Me.btn_name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_name.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.btn_name.FlatAppearance.BorderSize = 0
        Me.btn_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_name.Font = New System.Drawing.Font("Century Gothic", 8.0!)
        Me.btn_name.ForeColor = System.Drawing.Color.White
        Me.btn_name.Location = New System.Drawing.Point(28, 0)
        Me.btn_name.Name = "btn_name"
        Me.btn_name.Size = New System.Drawing.Size(75, 23)
        Me.btn_name.TabIndex = 0
        Me.btn_name.Text = "Unknown"
        Me.btn_name.UseVisualStyleBackColor = False
        '
        'chkbx_selected
        '
        Me.chkbx_selected.AutoSize = True
        Me.chkbx_selected.Location = New System.Drawing.Point(5, 5)
        Me.chkbx_selected.Margin = New System.Windows.Forms.Padding(5)
        Me.chkbx_selected.Name = "chkbx_selected"
        Me.chkbx_selected.Size = New System.Drawing.Size(15, 14)
        Me.chkbx_selected.TabIndex = 1
        Me.chkbx_selected.UseVisualStyleBackColor = True
        '
        'CellButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(115, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Controls.Add(Me.chkbx_selected)
        Me.Controls.Add(Me.btn_name)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.Name = "CellButton"
        Me.Size = New System.Drawing.Size(105, 24)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_name As System.Windows.Forms.Button
    Friend WithEvents chkbx_selected As System.Windows.Forms.CheckBox

End Class
