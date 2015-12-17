Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        TimeLabel.Text = TimeOfDay
        dateLabel.Text = DateAndTime.DateString
        Sleep1.Text = Date.Now.AddHours(9).ToString("hh:mm:ss tt")
        Sleep2.Text = Date.Now.AddHours(7.5).ToString("hh:mm:ss tt")
        Sleep3.Text = Date.Now.AddHours(6).ToString("hh:mm:ss tt")
        Sleep4.Text = Date.Now.AddHours(4.5).ToString("hh:mm:ss tt")
    End Sub

#Region "This is for the right click context menu"

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub OnTopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnTopToolStripMenuItem.Click
        If Me.TopMost Then
            Me.TopMost = False
        Else
            Me.TopMost = True
        End If
    End Sub

#End Region

#Region "This is made to move around the Form"

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TimeLabel.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TimeLabel.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TimeLabel.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub

#End Region

#Region "Handling Sleepy Button Clicks"

    Private Sub Button1_MouseDown(sender As Object, e As EventArgs) Handles Button1.MouseDown
        Size = New Size(432, 234)
        Sleep1.Location = New Point(Sleep1.Location.X, Sleep1.Location.Y + 85)
        Sleep2.Location = New Point(Sleep2.Location.X, Sleep2.Location.Y + 85)
        Sleep3.Location = New Point(Sleep3.Location.X, Sleep3.Location.Y + 85)
        Sleep4.Location = New Point(Sleep4.Location.X, Sleep4.Location.Y + 85)
        Hour1.Location = New Point(Hour1.Location.X, Hour1.Location.Y + 85)
        Hour2.Location = New Point(Hour2.Location.X, Hour2.Location.Y + 85)
        Hour3.Location = New Point(Hour3.Location.X, Hour3.Location.Y + 85)
        Hour4.Location = New Point(Hour4.Location.X, Hour4.Location.Y + 85)
        Sleep1.Visible = True
        Sleep2.Visible = True
        Sleep3.Visible = True
        Sleep4.Visible = True
        Hour1.Visible = True
        Hour2.Visible = True
        Hour3.Visible = True
        Hour4.Visible = True
    End Sub
    Private Sub Button1_MouseUp(sender As Object, e As EventArgs) Handles Button1.MouseUp
        Size = New Size(432, 134)
        Sleep1.Location = New Point(Sleep1.Location.X, Sleep1.Location.Y - 85)
        Sleep2.Location = New Point(Sleep2.Location.X, Sleep2.Location.Y - 85)
        Sleep3.Location = New Point(Sleep3.Location.X, Sleep3.Location.Y - 85)
        Sleep4.Location = New Point(Sleep4.Location.X, Sleep4.Location.Y - 85)
        Hour1.Location = New Point(Hour1.Location.X, Hour1.Location.Y - 85)
        Hour2.Location = New Point(Hour2.Location.X, Hour2.Location.Y - 85)
        Hour3.Location = New Point(Hour3.Location.X, Hour3.Location.Y - 85)
        Hour4.Location = New Point(Hour4.Location.X, Hour4.Location.Y - 85)
        Sleep1.Visible = False
        Sleep2.Visible = False
        Sleep3.Visible = False
        Sleep4.Visible = False
        Hour1.Visible = False
        Hour2.Visible = False
        Hour3.Visible = False
        Hour4.Visible = False
    End Sub

#End Region


End Class
