Public Class Form1
	Dim transparent As Boolean = True
	Dim image As Boolean = True

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.TransparencyKey = BackColor


		SetStyle(ControlStyles.OptimizedDoubleBuffer, True)

	End Sub

	'Declare the variables
	Dim drag As Boolean = False
	Dim mousex As Integer
	Dim mousey As Integer

	Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, PictureBox1.MouseDown
		drag = True 'Sets the variable drag to true.
		mousex = System.Windows.Forms.Cursor.Position.X - Me.Left 'Sets variable mousex
		mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top 'Sets variable mousey

	End Sub

	Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove, PictureBox1.MouseMove
		'If drag is set to true then move the form accordingly.
		If drag Then
			Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
			Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
		End If
	End Sub

	Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, PictureBox1.MouseUp
		drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

		Dim rnd As New Random()
		Dim randomNumber As Integer = rnd.Next(0, 7)

		gear.Text = randomNumber.ToString
	End Sub

	Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

		PictureBox1.Refresh()

		Dim rnd As New Random()
		Dim randomSpeed As Integer = rnd.Next(0, 90)
		Dim randomRpm As Integer = rnd.Next(0, 10000)
		Dim randomTps As Integer = rnd.Next(0, 100)
		Dim randomBps As Integer = rnd.Next(0, 100)

		speed.Text = randomSpeed.ToString
		rpm.Text = randomRpm.ToString

		Dim g As Drawing.Graphics = PictureBox1.CreateGraphics
		'Dim brush As New SolidBrush(Color.SteelBlue)


		'g.FillPie(brush, 0, 0, 100, 100, 0, randomSpeed)

		Dim SpeedPie = New Rectangle(20, 20, 103, 103) '145,137/ 105,97

		Using gpath As New Drawing2D.GraphicsPath
			gpath.AddArc(SpeedPie, 120.0!, System.Convert.ToSingle(randomSpeed / 90 * 300))
			gpath.Widen(New Pen(Color.Empty, 8))
			g.FillPath(Brushes.SteelBlue, gpath)
		End Using

		Dim ThrottlePie = New Rectangle(33, 33, 80, 80) '92,83// 80,80

		Using gpath As New Drawing2D.GraphicsPath
			gpath.AddArc(ThrottlePie, 135.0!, System.Convert.ToSingle(randomTps / 100 * 173))
			gpath.Widen(New Pen(Color.Empty, 8))
			g.FillPath(New SolidBrush(Color.FromArgb(128, 0, 255, 0)), gpath)
		End Using

		Dim BreakPie = New Rectangle(30, 33, 80, 80) '92,83// 80,80


		Using gpath As New Drawing2D.GraphicsPath
			'gpath.AddArc(ThrottlePie, System.Convert.ToSingle(randomBps / 100 * 173), 10.0!)
			gpath.AddArc(BreakPie, 45, -System.Convert.ToSingle(randomBps / 100 * 95))
			gpath.Widen(New Pen(Color.Empty, 11))
			g.FillPath(New SolidBrush(Color.FromArgb(128, 255, 0, 0)), gpath)
		End Using

	End Sub

	Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
		If e.KeyCode = Keys.P Then
			If transparent = True Then
				Me.TransparencyKey = Color.Empty
				Me.BackColor = Color.Magenta
				transparent = False

			Else
				Me.BackColor = SystemColors.AppWorkspace
				Me.TransparencyKey = BackColor
				transparent = True
			End If
		End If

		If e.KeyCode = Keys.X Then
			Close()
		End If

		If e.KeyCode = Keys.I Then
			If image = True Then
				PictureBox1.Image = Nothing
				image = False
			Else
				PictureBox1.Image = My.Resources.gauge
				image = True
			End If

		End If
	End Sub
End Class
