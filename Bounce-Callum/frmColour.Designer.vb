﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmColour
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
        Me.tbrRed = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbrGreen = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbrBlue = New System.Windows.Forms.TrackBar()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.optBall = New System.Windows.Forms.RadioButton()
        Me.optBG = New System.Windows.Forms.RadioButton()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.tbrRed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbrBlue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbrRed
        '
        Me.tbrRed.LargeChange = 16
        Me.tbrRed.Location = New System.Drawing.Point(58, 65)
        Me.tbrRed.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbrRed.Maximum = 255
        Me.tbrRed.Name = "tbrRed"
        Me.tbrRed.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrRed.Size = New System.Drawing.Size(90, 617)
        Me.tbrRed.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Red"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Green"
        '
        'tbrGreen
        '
        Me.tbrGreen.LargeChange = 16
        Me.tbrGreen.Location = New System.Drawing.Point(180, 65)
        Me.tbrGreen.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbrGreen.Maximum = 255
        Me.tbrGreen.Name = "tbrGreen"
        Me.tbrGreen.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrGreen.Size = New System.Drawing.Size(90, 617)
        Me.tbrGreen.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(306, 29)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Blue"
        '
        'tbrBlue
        '
        Me.tbrBlue.LargeChange = 16
        Me.tbrBlue.Location = New System.Drawing.Point(306, 65)
        Me.tbrBlue.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.tbrBlue.Maximum = 255
        Me.tbrBlue.Name = "tbrBlue"
        Me.tbrBlue.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tbrBlue.Size = New System.Drawing.Size(90, 617)
        Me.tbrBlue.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(398, 40)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(320, 308)
        Me.Panel1.TabIndex = 6
        '
        'optBall
        '
        Me.optBall.AutoSize = True
        Me.optBall.Checked = True
        Me.optBall.Location = New System.Drawing.Point(410, 396)
        Me.optBall.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.optBall.Name = "optBall"
        Me.optBall.Size = New System.Drawing.Size(79, 29)
        Me.optBall.TabIndex = 7
        Me.optBall.TabStop = True
        Me.optBall.Text = "Ball"
        Me.optBall.UseVisualStyleBackColor = True
        '
        'optBG
        '
        Me.optBG.AutoSize = True
        Me.optBG.Location = New System.Drawing.Point(408, 440)
        Me.optBG.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.optBG.Name = "optBG"
        Me.optBG.Size = New System.Drawing.Size(158, 29)
        Me.optBG.TabIndex = 8
        Me.optBG.TabStop = True
        Me.optBG.Text = "Background"
        Me.optBG.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(410, 510)
        Me.btnOK.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(212, 54)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(408, 592)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(212, 54)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 65)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "255"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 650)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "0"
        '
        'frmColour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 692)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.optBG)
        Me.Controls.Add(Me.optBall)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbrBlue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbrGreen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbrRed)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmColour"
        Me.Text = "Colour"
        CType(Me.tbrRed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbrBlue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbrRed As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbrGreen As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents tbrBlue As TrackBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents optBall As RadioButton
    Friend WithEvents optBG As RadioButton
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
