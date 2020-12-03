Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        move(PictureBox3Wall, 5, 0)
        move(PictureBox2Wall, -5, 0)
        move(bullet1, 0, 0)
        move(bullet, 0, 0)
        move(PictureBox5Wall, 0, 5)
        Dim R As New Random
        Dim X As Integer
        Dim Score As Integer
        X = R.Next(-100, 100)
        MoveTo(PictureBox2Wall, X, 0)
    End Sub

    Sub move(p As PictureBox, x As Integer, y As Integer)
        p.Location = New Point(p.Location.X + x, p.Location.Y + y)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.E
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
                Me.Refresh()
            Case Keys.Q
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
                Me.Refresh()
            Case Keys.Up, Keys.W
                MoveTo(PictureBox1, 0, -5)
            Case Keys.Down, Keys.S
                MoveTo(PictureBox1, 0, 5)
            Case Keys.Right, Keys.D
                MoveTo(PictureBox1, 5, 0)
            Case Keys.Left, Keys.A
                MoveTo(PictureBox1, -5, 0)
            Case Keys.Z
                bullet1.Location = PictureBox1.Location
                bullet1.Visible = True
                Timer2.Enabled = True
            Case Keys.X
                bullet.Location = PictureBox1.Location
                bullet.Visible = True
                Timer2.Enabled = True
            Case Keys.C
                Bullet2.Location = PictureBox1.Location
                Bullet2.Visible = True
                Timer2.Enabled = True
            Case Keys.V
                Bullet3.Location = PictureBox1.Location
                Bullet3.Visible = True
                Timer2.Enabled = True
            Case Keys.B
                Bullet4.Location = PictureBox1.Location
                Bullet4.Visible = True
                Timer2.Enabled = True
            Case Keys.N
                Bullet5.Location = PictureBox1.Location
                Bullet5.Visible = True
                Timer2.Enabled = True
            Case Keys.M
                Bullet6.Location = PictureBox1.Location
                Bullet6.Visible = True
                Timer2.Enabled = True
            Case Keys.R
                Application.Restart()
        End Select
    End Sub


    Public Sub chase(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > PictureBox1.Location.X Then
            x = -5
        Else
            x = 5
        End If
        MoveTo(p, x, 0)
        If p.Location.Y < PictureBox1.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub



    Function Collision(p As PictureBox, t As String)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If p.Bounds.IntersectsWith(obj.Bounds) And (obj.Name.ToUpper.EndsWith(t.ToUpper) Or obj.Name.ToUpper.StartsWith(t.ToUpper)) Then
                col = True
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t

    Function Collision(p As PictureBox, t As String, Optional ByRef other As Object = vbNull)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If obj.Visible AndAlso p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
                other = obj
            End If
        Next
        Return col
    End Function
    'Return true or false if moving to the new location is clear of objects ending with t
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    'Moves and object (won't move onto objects containing  "wall" and shows green if object ends with "win"
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        If IsClear(p, distx, disty, "WALL") Then
            p.Location += New Point(distx, disty)
        End If

        If p.Name = "PictureBox1" And Collision(p, "WIN") Then
            Me.BackColor = Color.Black

            Return
            Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MoveTo(bullet1, 0, -30)
        MoveTo(bullet, 0, -30)
        MoveTo(Bullet2, 0, -30)
        MoveTo(Bullet3, 0, -30)
        MoveTo(Bullet4, 0, -30)
        MoveTo(Bullet5, 0, -30)
        MoveTo(Bullet6, 0, -30)

    End Sub
    Sub follow(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(PictureBox1.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub
    Dim xdir As Integer
    Dim ydir As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim score As Integer
    End Sub
End Class