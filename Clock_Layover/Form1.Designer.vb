<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OnTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dateLabel = New System.Windows.Forms.Label()
        Me.Sleep1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Sleep2 = New System.Windows.Forms.Label()
        Me.Sleep3 = New System.Windows.Forms.Label()
        Me.Sleep4 = New System.Windows.Forms.Label()
        Me.Hour1 = New System.Windows.Forms.Label()
        Me.Hour2 = New System.Windows.Forms.Label()
        Me.Hour3 = New System.Windows.Forms.Label()
        Me.Hour4 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Agency FB", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.Location = New System.Drawing.Point(15, 9)
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(187, 116)
        Me.TimeLabel.TabIndex = 0
        Me.TimeLabel.Text = "Time"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnTopToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(114, 48)
        '
        'OnTopToolStripMenuItem
        '
        Me.OnTopToolStripMenuItem.Name = "OnTopToolStripMenuItem"
        Me.OnTopToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.OnTopToolStripMenuItem.Text = "On Top"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.Location = New System.Drawing.Point(185, 105)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(28, 20)
        Me.dateLabel.TabIndex = 2
        Me.dateLabel.Text = "Date"
        '
        'Sleep1
        '
        Me.Sleep1.AutoSize = True
        Me.Sleep1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sleep1.Location = New System.Drawing.Point(11, 100)
        Me.Sleep1.Name = "Sleep1"
        Me.Sleep1.Size = New System.Drawing.Size(48, 25)
        Me.Sleep1.TabIndex = 3
        Me.Sleep1.Text = "Sleep1"
        Me.Sleep1.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(180, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Sleep"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Sleep2
        '
        Me.Sleep2.AutoSize = True
        Me.Sleep2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sleep2.Location = New System.Drawing.Point(125, 100)
        Me.Sleep2.Name = "Sleep2"
        Me.Sleep2.Size = New System.Drawing.Size(54, 25)
        Me.Sleep2.TabIndex = 5
        Me.Sleep2.Text = "Sleep2"
        Me.Sleep2.Visible = False
        '
        'Sleep3
        '
        Me.Sleep3.AutoSize = True
        Me.Sleep3.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sleep3.Location = New System.Drawing.Point(232, 100)
        Me.Sleep3.Name = "Sleep3"
        Me.Sleep3.Size = New System.Drawing.Size(54, 25)
        Me.Sleep3.TabIndex = 6
        Me.Sleep3.Text = "Sleep3"
        Me.Sleep3.Visible = False
        '
        'Sleep4
        '
        Me.Sleep4.AutoSize = True
        Me.Sleep4.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sleep4.Location = New System.Drawing.Point(335, 100)
        Me.Sleep4.Name = "Sleep4"
        Me.Sleep4.Size = New System.Drawing.Size(53, 25)
        Me.Sleep4.TabIndex = 7
        Me.Sleep4.Text = "Sleep4"
        Me.Sleep4.Visible = False
        '
        'Hour1
        '
        Me.Hour1.AutoSize = True
        Me.Hour1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hour1.Location = New System.Drawing.Point(29, 75)
        Me.Hour1.Name = "Hour1"
        Me.Hour1.Size = New System.Drawing.Size(21, 25)
        Me.Hour1.TabIndex = 8
        Me.Hour1.Text = "9"
        Me.Hour1.Visible = False
        '
        'Hour2
        '
        Me.Hour2.AutoSize = True
        Me.Hour2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hour2.Location = New System.Drawing.Point(137, 75)
        Me.Hour2.Name = "Hour2"
        Me.Hour2.Size = New System.Drawing.Size(32, 25)
        Me.Hour2.TabIndex = 9
        Me.Hour2.Text = "7.5"
        Me.Hour2.Visible = False
        '
        'Hour3
        '
        Me.Hour3.AutoSize = True
        Me.Hour3.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hour3.Location = New System.Drawing.Point(247, 75)
        Me.Hour3.Name = "Hour3"
        Me.Hour3.Size = New System.Drawing.Size(21, 25)
        Me.Hour3.TabIndex = 10
        Me.Hour3.Text = "6"
        Me.Hour3.Visible = False
        '
        'Hour4
        '
        Me.Hour4.AutoSize = True
        Me.Hour4.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hour4.Location = New System.Drawing.Point(344, 75)
        Me.Hour4.Name = "Hour4"
        Me.Hour4.Size = New System.Drawing.Size(33, 25)
        Me.Hour4.TabIndex = 11
        Me.Hour4.Text = "4.5"
        Me.Hour4.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 42.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(432, 134)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Hour4)
        Me.Controls.Add(Me.Hour3)
        Me.Controls.Add(Me.Hour2)
        Me.Controls.Add(Me.Hour1)
        Me.Controls.Add(Me.Sleep4)
        Me.Controls.Add(Me.Sleep3)
        Me.Controls.Add(Me.Sleep2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.Sleep1)
        Me.Controls.Add(Me.TimeLabel)
        Me.Font = New System.Drawing.Font("Agency FB", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(6, 10, 6, 10)
        Me.Name = "Form1"
        Me.Opacity = 0.5R
        Me.ShowInTaskbar = False
        Me.Text = "Clock"
        Me.TopMost = True
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimeLabel As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnTopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dateLabel As Label
    Friend WithEvents Sleep1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Sleep2 As Label
    Friend WithEvents Sleep3 As Label
    Friend WithEvents Sleep4 As Label
    Friend WithEvents Hour1 As Label
    Friend WithEvents Hour2 As Label
    Friend WithEvents Hour3 As Label
    Friend WithEvents Hour4 As Label
End Class
