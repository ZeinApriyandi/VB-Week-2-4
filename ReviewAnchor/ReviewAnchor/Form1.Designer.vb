<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class review_anchor
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
        Me.g_box1 = New System.Windows.Forms.GroupBox()
        Me.g_box2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtp_jam = New System.Windows.Forms.DateTimePicker()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'g_box1
        '
        Me.g_box1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.g_box1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.g_box1.Location = New System.Drawing.Point(12, 12)
        Me.g_box1.Name = "g_box1"
        Me.g_box1.Size = New System.Drawing.Size(200, 126)
        Me.g_box1.TabIndex = 0
        Me.g_box1.TabStop = False
        '
        'g_box2
        '
        Me.g_box2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.g_box2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.g_box2.Location = New System.Drawing.Point(229, 12)
        Me.g_box2.Name = "g_box2"
        Me.g_box2.Size = New System.Drawing.Size(277, 126)
        Me.g_box2.TabIndex = 1
        Me.g_box2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Location = New System.Drawing.Point(229, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(261, 114)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'dtp_jam
        '
        Me.dtp_jam.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dtp_jam.Location = New System.Drawing.Point(12, 248)
        Me.dtp_jam.Name = "dtp_jam"
        Me.dtp_jam.Size = New System.Drawing.Size(200, 20)
        Me.dtp_jam.TabIndex = 3
        '
        'btn1
        '
        Me.btn1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn1.Location = New System.Drawing.Point(515, 21)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Button1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'review_anchor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 290)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.dtp_jam)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.g_box2)
        Me.Controls.Add(Me.g_box1)
        Me.Name = "review_anchor"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents g_box1 As System.Windows.Forms.GroupBox
    Friend WithEvents g_box2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_jam As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn1 As System.Windows.Forms.Button

End Class
