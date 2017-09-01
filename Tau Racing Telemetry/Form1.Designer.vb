<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.gear = New System.Windows.Forms.Label()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.speed = New System.Windows.Forms.Label()
		Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
		Me.Label1 = New System.Windows.Forms.Label()
		Me.rpm = New System.Windows.Forms.Label()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(28, 27)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(145, 137)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'gear
		'
		Me.gear.AutoSize = True
		Me.gear.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
		Me.gear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gear.ForeColor = System.Drawing.Color.White
		Me.gear.Location = New System.Drawing.Point(89, 86)
		Me.gear.Name = "gear"
		Me.gear.Size = New System.Drawing.Size(23, 25)
		Me.gear.TabIndex = 1
		Me.gear.Text = "0"
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 500
		'
		'speed
		'
		Me.speed.AutoSize = True
		Me.speed.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
		Me.speed.Font = New System.Drawing.Font("Impact", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.speed.ForeColor = System.Drawing.Color.SteelBlue
		Me.speed.Location = New System.Drawing.Point(85, 126)
		Me.speed.Name = "speed"
		Me.speed.Size = New System.Drawing.Size(34, 25)
		Me.speed.TabIndex = 2
		Me.speed.Text = "00"
		Me.speed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Timer2
		'
		Me.Timer2.Enabled = True
		Me.Timer2.Interval = 250
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Impact", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(90, 114)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(21, 13)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "rpm"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'rpm
		'
		Me.rpm.AutoSize = True
		Me.rpm.BackColor = System.Drawing.Color.FromArgb(CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(85, Byte), Integer))
		Me.rpm.Font = New System.Drawing.Font("Impact", 6.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.rpm.ForeColor = System.Drawing.Color.White
		Me.rpm.Location = New System.Drawing.Point(87, 106)
		Me.rpm.Name = "rpm"
		Me.rpm.Size = New System.Drawing.Size(27, 13)
		Me.rpm.TabIndex = 4
		Me.rpm.Text = "0000"
		Me.rpm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.ClientSize = New System.Drawing.Size(206, 200)
		Me.Controls.Add(Me.rpm)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.speed)
		Me.Controls.Add(Me.gear)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "Form1"
		Me.Text = "Form1"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents gear As Label
	Friend WithEvents Timer1 As Timer
	Friend WithEvents speed As Label
	Friend WithEvents Timer2 As Timer
	Friend WithEvents Label1 As Label
	Friend WithEvents rpm As Label
End Class
