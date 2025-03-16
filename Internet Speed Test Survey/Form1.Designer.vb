<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInternetSpeed
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnEnterSpeed = New System.Windows.Forms.Button()
        Me.lstSpeed = New System.Windows.Forms.ListBox()
        Me.lblAverageSpeed = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Internet_Speed_Test_Survey.My.Resources.Resources.myix3
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(445, 463)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(453, 50)
        Me.lblHeading.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(371, 31)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Internet Speed Test Survey"
        '
        'btnEnterSpeed
        '
        Me.btnEnterSpeed.BackColor = System.Drawing.Color.DarkKhaki
        Me.btnEnterSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterSpeed.Location = New System.Drawing.Point(501, 137)
        Me.btnEnterSpeed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEnterSpeed.Name = "btnEnterSpeed"
        Me.btnEnterSpeed.Size = New System.Drawing.Size(229, 47)
        Me.btnEnterSpeed.TabIndex = 2
        Me.btnEnterSpeed.Text = "Enter Internet Speed"
        Me.btnEnterSpeed.UseVisualStyleBackColor = False
        '
        'lstSpeed
        '
        Me.lstSpeed.FormattingEnabled = True
        Me.lstSpeed.ItemHeight = 25
        Me.lstSpeed.Location = New System.Drawing.Point(828, 137)
        Me.lstSpeed.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstSpeed.Name = "lstSpeed"
        Me.lstSpeed.Size = New System.Drawing.Size(127, 204)
        Me.lstSpeed.TabIndex = 3
        '
        'lblAverageSpeed
        '
        Me.lblAverageSpeed.AutoSize = True
        Me.lblAverageSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageSpeed.Location = New System.Drawing.Point(479, 386)
        Me.lblAverageSpeed.Name = "lblAverageSpeed"
        Me.lblAverageSpeed.Size = New System.Drawing.Size(435, 25)
        Me.lblAverageSpeed.TabIndex = 4
        Me.lblAverageSpeed.Text = "Average Internet Speed: XXXX.XX Mbps"
        Me.lblAverageSpeed.Visible = False
        '
        'frmInternetSpeed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(994, 463)
        Me.Controls.Add(Me.lblAverageSpeed)
        Me.Controls.Add(Me.lstSpeed)
        Me.Controls.Add(Me.btnEnterSpeed)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmInternetSpeed"
        Me.Text = "Internet Speed Test Survey for Home Users"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnEnterSpeed As Button
    Friend WithEvents lstSpeed As ListBox
    Friend WithEvents lblAverageSpeed As Label
End Class
