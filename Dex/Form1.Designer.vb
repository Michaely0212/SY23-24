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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Field1 = New System.Windows.Forms.TextBox()
        Me.Field2 = New System.Windows.Forms.TextBox()
        Me.Field3 = New System.Windows.Forms.TextBox()
        Me.Field5 = New System.Windows.Forms.TextBox()
        Me.Field4 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.firstbutton = New System.Windows.Forms.Button()
        Me.prevbutton = New System.Windows.Forms.Button()
        Me.nextbutton = New System.Windows.Forms.Button()
        Me.lastbutton = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.PreviousToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.FileToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(46, 24)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(123, 26)
        Me.FileToolStripMenuItem.Text = "Save"
        '
        'PreviousToolStripMenuItem
        '
        Me.PreviousToolStripMenuItem.Name = "PreviousToolStripMenuItem"
        Me.PreviousToolStripMenuItem.Size = New System.Drawing.Size(27, 24)
        Me.PreviousToolStripMenuItem.Text = " "
        '
        'Field1
        '
        Me.Field1.Location = New System.Drawing.Point(0, 83)
        Me.Field1.Name = "Field1"
        Me.Field1.Size = New System.Drawing.Size(125, 27)
        Me.Field1.TabIndex = 1
        '
        'Field2
        '
        Me.Field2.Location = New System.Drawing.Point(0, 146)
        Me.Field2.Name = "Field2"
        Me.Field2.Size = New System.Drawing.Size(125, 27)
        Me.Field2.TabIndex = 2
        '
        'Field3
        '
        Me.Field3.Location = New System.Drawing.Point(0, 213)
        Me.Field3.Name = "Field3"
        Me.Field3.Size = New System.Drawing.Size(125, 27)
        Me.Field3.TabIndex = 3
        '
        'Field5
        '
        Me.Field5.Location = New System.Drawing.Point(0, 338)
        Me.Field5.Name = "Field5"
        Me.Field5.Size = New System.Drawing.Size(125, 27)
        Me.Field5.TabIndex = 4
        '
        'Field4
        '
        Me.Field4.Location = New System.Drawing.Point(0, 279)
        Me.Field4.Name = "Field4"
        Me.Field4.Size = New System.Drawing.Size(125, 27)
        Me.Field4.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(473, 155)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(172, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'firstbutton
        '
        Me.firstbutton.Location = New System.Drawing.Point(170, 409)
        Me.firstbutton.Name = "firstbutton"
        Me.firstbutton.Size = New System.Drawing.Size(94, 29)
        Me.firstbutton.TabIndex = 7
        Me.firstbutton.Text = "First"
        Me.firstbutton.UseVisualStyleBackColor = True
        '
        'prevbutton
        '
        Me.prevbutton.Location = New System.Drawing.Point(270, 409)
        Me.prevbutton.Name = "prevbutton"
        Me.prevbutton.Size = New System.Drawing.Size(94, 29)
        Me.prevbutton.TabIndex = 8
        Me.prevbutton.Text = "Previous"
        Me.prevbutton.UseVisualStyleBackColor = True
        '
        'nextbutton
        '
        Me.nextbutton.Location = New System.Drawing.Point(370, 409)
        Me.nextbutton.Name = "nextbutton"
        Me.nextbutton.Size = New System.Drawing.Size(94, 29)
        Me.nextbutton.TabIndex = 9
        Me.nextbutton.Text = "Next"
        Me.nextbutton.UseVisualStyleBackColor = True
        '
        'lastbutton
        '
        Me.lastbutton.Location = New System.Drawing.Point(470, 409)
        Me.lastbutton.Name = "lastbutton"
        Me.lastbutton.Size = New System.Drawing.Size(94, 29)
        Me.lastbutton.TabIndex = 10
        Me.lastbutton.Text = "Last"
        Me.lastbutton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lastbutton)
        Me.Controls.Add(Me.nextbutton)
        Me.Controls.Add(Me.prevbutton)
        Me.Controls.Add(Me.firstbutton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Field4)
        Me.Controls.Add(Me.Field5)
        Me.Controls.Add(Me.Field3)
        Me.Controls.Add(Me.Field2)
        Me.Controls.Add(Me.Field1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Field1 As TextBox
    Friend WithEvents Field2 As TextBox
    Friend WithEvents Field3 As TextBox
    Friend WithEvents Field5 As TextBox
    Friend WithEvents Field4 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PreviousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents firstbutton As Button
    Friend WithEvents prevbutton As Button
    Friend WithEvents nextbutton As Button
    Friend WithEvents lastbutton As Button
End Class
