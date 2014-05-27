<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.comboboxExtensions = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelExtension = New System.Windows.Forms.Label()
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.buttonExit = New System.Windows.Forms.Button()
        Me.labelCopyright = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comboboxExtensions
        '
        Me.comboboxExtensions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.comboboxExtensions.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboboxExtensions.FormattingEnabled = True
        Me.comboboxExtensions.Items.AddRange(New Object() {"torrent", "txt", "pdf", "avi", "flv", "mp3", "mp4", "mpeg", "jpg", "png", "ico"})
        Me.comboboxExtensions.Location = New System.Drawing.Point(239, 33)
        Me.comboboxExtensions.Name = "comboboxExtensions"
        Me.comboboxExtensions.Size = New System.Drawing.Size(132, 24)
        Me.comboboxExtensions.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(41, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose Extension :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(271, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 57)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(239, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "example . "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 38)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Type of files that will be " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "deleted permanently:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelExtension
        '
        Me.labelExtension.AutoSize = True
        Me.labelExtension.BackColor = System.Drawing.Color.Transparent
        Me.labelExtension.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelExtension.ForeColor = System.Drawing.Color.White
        Me.labelExtension.Location = New System.Drawing.Point(307, 171)
        Me.labelExtension.Name = "labelExtension"
        Me.labelExtension.Size = New System.Drawing.Size(72, 19)
        Me.labelExtension.TabIndex = 5
        Me.labelExtension.Text = "extension"
        '
        'buttonDelete
        '
        Me.buttonDelete.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonDelete.Location = New System.Drawing.Point(408, 64)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(88, 40)
        Me.buttonDelete.TabIndex = 6
        Me.buttonDelete.Text = "Delete"
        Me.buttonDelete.UseVisualStyleBackColor = True
        '
        'buttonExit
        '
        Me.buttonExit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonExit.Location = New System.Drawing.Point(408, 129)
        Me.buttonExit.Name = "buttonExit"
        Me.buttonExit.Size = New System.Drawing.Size(88, 40)
        Me.buttonExit.TabIndex = 7
        Me.buttonExit.Text = "&Exit"
        Me.buttonExit.UseVisualStyleBackColor = True
        '
        'labelCopyright
        '
        Me.labelCopyright.AutoSize = True
        Me.labelCopyright.BackColor = System.Drawing.Color.Transparent
        Me.labelCopyright.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCopyright.ForeColor = System.Drawing.Color.White
        Me.labelCopyright.Location = New System.Drawing.Point(334, 226)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(179, 16)
        Me.labelCopyright.TabIndex = 8
        Me.labelCopyright.Text = "© 2012, 2014 Shubhang Rathore"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(522, 250)
        Me.Controls.Add(Me.labelCopyright)
        Me.Controls.Add(Me.buttonExit)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.labelExtension)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboboxExtensions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expunger"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents comboboxExtensions As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents labelExtension As System.Windows.Forms.Label
    Friend WithEvents buttonDelete As System.Windows.Forms.Button
    Friend WithEvents buttonExit As System.Windows.Forms.Button
    Friend WithEvents labelCopyright As System.Windows.Forms.Label

End Class
