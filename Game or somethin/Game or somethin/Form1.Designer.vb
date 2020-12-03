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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox5Wall = New System.Windows.Forms.PictureBox()
        Me.bullet1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2Wall = New System.Windows.Forms.PictureBox()
        Me.PictureBox3Wall = New System.Windows.Forms.PictureBox()
        Me.win = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.bullet = New System.Windows.Forms.PictureBox()
        Me.Bullet2 = New System.Windows.Forms.PictureBox()
        Me.Bullet3 = New System.Windows.Forms.PictureBox()
        Me.Bullet4 = New System.Windows.Forms.PictureBox()
        Me.Bullet5 = New System.Windows.Forms.PictureBox()
        Me.Bullet6 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bullet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3Wall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.win, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Bullet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox5Wall
        '
        Me.PictureBox5Wall.Image = Global.Game_or_somethin.My.Resources.Resources.pixel_alien_bullet__1_
        Me.PictureBox5Wall.Location = New System.Drawing.Point(36, 31)
        Me.PictureBox5Wall.Name = "PictureBox5Wall"
        Me.PictureBox5Wall.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox5Wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5Wall.TabIndex = 4
        Me.PictureBox5Wall.TabStop = False
        '
        'bullet1
        '
        Me.bullet1.Image = Global.Game_or_somethin.My.Resources.Resources.pixel_alien_bullet__2___1_
        Me.bullet1.Location = New System.Drawing.Point(497, 356)
        Me.bullet1.Name = "bullet1"
        Me.bullet1.Size = New System.Drawing.Size(29, 60)
        Me.bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bullet1.TabIndex = 3
        Me.bullet1.TabStop = False
        Me.bullet1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Game_or_somethin.My.Resources.Resources._2d_pixel_spaceship__1_
        Me.PictureBox1.Location = New System.Drawing.Point(490, 422)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2Wall
        '
        Me.PictureBox2Wall.BackColor = System.Drawing.Color.White
        Me.PictureBox2Wall.Image = Global.Game_or_somethin.My.Resources.Resources._2d_pixel_space_alien2
        Me.PictureBox2Wall.Location = New System.Drawing.Point(756, 133)
        Me.PictureBox2Wall.Name = "PictureBox2Wall"
        Me.PictureBox2Wall.Size = New System.Drawing.Size(111, 90)
        Me.PictureBox2Wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2Wall.TabIndex = 1
        Me.PictureBox2Wall.TabStop = False
        '
        'PictureBox3Wall
        '
        Me.PictureBox3Wall.Image = Global.Game_or_somethin.My.Resources.Resources._2d_pixel_picklerick__1_
        Me.PictureBox3Wall.Location = New System.Drawing.Point(344, 2)
        Me.PictureBox3Wall.Name = "PictureBox3Wall"
        Me.PictureBox3Wall.Size = New System.Drawing.Size(116, 128)
        Me.PictureBox3Wall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3Wall.TabIndex = 0
        Me.PictureBox3Wall.TabStop = False
        '
        'win
        '
        Me.win.Location = New System.Drawing.Point(213, 303)
        Me.win.Name = "win"
        Me.win.Size = New System.Drawing.Size(100, 50)
        Me.win.TabIndex = 5
        Me.win.TabStop = False
        '
        'Timer2
        '
        '
        'bullet
        '
        Me.bullet.Image = Global.Game_or_somethin.My.Resources.Resources.pixel_alien_bullet__2___1_
        Me.bullet.Location = New System.Drawing.Point(497, 356)
        Me.bullet.Name = "bullet"
        Me.bullet.Size = New System.Drawing.Size(29, 60)
        Me.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bullet.TabIndex = 6
        Me.bullet.TabStop = False
        Me.bullet.Visible = False
        '
        'Bullet2
        '
        Me.Bullet2.Image = Global.Game_or_somethin.My.Resources.Resources.pixel_alien_bullet__2___1_
        Me.Bullet2.Location = New System.Drawing.Point(497, 356)
        Me.Bullet2.Name = "Bullet2"
        Me.Bullet2.Size = New System.Drawing.Size(29, 60)
        Me.Bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet2.TabIndex = 10
        Me.Bullet2.TabStop = False
        Me.Bullet2.Visible = False
        '
        'Bullet3
        '
        Me.Bullet3.Image = Global.Game_or_somethin.My.Resources.Resources.pixel_alien_bullet__2___1_
        Me.Bullet3.Location = New System.Drawing.Point(497, 356)
        Me.Bullet3.Name = "Bullet3"
        Me.Bullet3.Size = New System.Drawing.Size(29, 60)
        Me.Bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet3.TabIndex = 11
        Me.Bullet3.TabStop = False
        Me.Bullet3.Visible = False
        '
        'Bullet4
        '
        Me.Bullet4.Image = Global.Game_or_somethin.My.Resources.Resources.pixel_alien_bullet__2___1_
        Me.Bullet4.Location = New System.Drawing.Point(497, 356)
        Me.Bullet4.Name = "Bullet4"
        Me.Bullet4.Size = New System.Drawing.Size(29, 60)
        Me.Bullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet4.TabIndex = 12
        Me.Bullet4.TabStop = False
        Me.Bullet4.Visible = False
        '
        'Bullet5
        '
        Me.Bullet5.Image = Global.Game_or_somethin.My.Resources.Resources.pixel_alien_bullet__2___1_
        Me.Bullet5.Location = New System.Drawing.Point(497, 356)
        Me.Bullet5.Name = "Bullet5"
        Me.Bullet5.Size = New System.Drawing.Size(29, 60)
        Me.Bullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet5.TabIndex = 13
        Me.Bullet5.TabStop = False
        Me.Bullet5.Visible = False
        '
        'Bullet6
        '
        Me.Bullet6.Image = Global.Game_or_somethin.My.Resources.Resources.pixel_alien_bullet__2___1_
        Me.Bullet6.Location = New System.Drawing.Point(497, 356)
        Me.Bullet6.Name = "Bullet6"
        Me.Bullet6.Size = New System.Drawing.Size(29, 60)
        Me.Bullet6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Bullet6.TabIndex = 14
        Me.Bullet6.TabStop = False
        Me.Bullet6.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Game_or_somethin.My.Resources.Resources.pixel_space
        Me.ClientSize = New System.Drawing.Size(1028, 547)
        Me.Controls.Add(Me.Bullet6)
        Me.Controls.Add(Me.Bullet5)
        Me.Controls.Add(Me.Bullet4)
        Me.Controls.Add(Me.Bullet3)
        Me.Controls.Add(Me.Bullet2)
        Me.Controls.Add(Me.bullet)
        Me.Controls.Add(Me.win)
        Me.Controls.Add(Me.PictureBox5Wall)
        Me.Controls.Add(Me.bullet1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2Wall)
        Me.Controls.Add(Me.PictureBox3Wall)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox5Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bullet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3Wall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.win, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bullet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Bullet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox3Wall As PictureBox
    Friend WithEvents PictureBox2Wall As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bullet1 As PictureBox
    Friend WithEvents PictureBox5Wall As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents win As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents bullet As PictureBox
    Friend WithEvents Bullet2 As PictureBox
    Friend WithEvents Bullet3 As PictureBox
    Friend WithEvents Bullet4 As PictureBox
    Friend WithEvents Bullet5 As PictureBox
    Friend WithEvents Bullet6 As PictureBox
End Class
