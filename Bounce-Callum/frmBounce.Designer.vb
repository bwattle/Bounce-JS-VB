﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBounce
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColourToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelMain = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StartBounce = New System.Windows.Forms.Button()
        Me.StopBounce = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ScoreAmount = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(668, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(668, 24)
        Me.MenuStrip2.TabIndex = 1
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SizeToolStripMenuItem, Me.SpeedToolStripMenuItem, Me.ColourToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.SizeToolStripMenuItem.Text = "Size"
        '
        'SpeedToolStripMenuItem
        '
        Me.SpeedToolStripMenuItem.Name = "SpeedToolStripMenuItem"
        Me.SpeedToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.SpeedToolStripMenuItem.Text = "Speed"
        '
        'ColourToolStripMenuItem
        '
        Me.ColourToolStripMenuItem.Name = "ColourToolStripMenuItem"
        Me.ColourToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ColourToolStripMenuItem.Text = "Colour"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'panelMain
        '
        Me.panelMain.Location = New System.Drawing.Point(12, 31)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Size = New System.Drawing.Size(640, 480)
        Me.panelMain.TabIndex = 8
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'StartBounce
        '
        Me.StartBounce.Location = New System.Drawing.Point(153, 2)
        Me.StartBounce.Name = "StartBounce"
        Me.StartBounce.Size = New System.Drawing.Size(75, 23)
        Me.StartBounce.TabIndex = 9
        Me.StartBounce.Text = "Start"
        Me.StartBounce.UseVisualStyleBackColor = True
        '
        'StopBounce
        '
        Me.StopBounce.Location = New System.Drawing.Point(243, 2)
        Me.StopBounce.Name = "StopBounce"
        Me.StopBounce.Size = New System.Drawing.Size(75, 23)
        Me.StopBounce.TabIndex = 10
        Me.StopBounce.Text = "Stop"
        Me.StopBounce.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(532, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Score:"
        '
        'ScoreAmount
        '
        Me.ScoreAmount.AutoSize = True
        Me.ScoreAmount.Location = New System.Drawing.Point(577, 10)
        Me.ScoreAmount.Name = "ScoreAmount"
        Me.ScoreAmount.Size = New System.Drawing.Size(0, 13)
        Me.ScoreAmount.TabIndex = 12
        '
        'frmBounce
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 524)
        Me.Controls.Add(Me.ScoreAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StopBounce)
        Me.Controls.Add(Me.StartBounce)
        Me.Controls.Add(Me.panelMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBounce"
        Me.Text = "Ball Bounce"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpeedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColourToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelMain As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StartBounce As Button
    Friend WithEvents StopBounce As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ScoreAmount As Label
End Class
