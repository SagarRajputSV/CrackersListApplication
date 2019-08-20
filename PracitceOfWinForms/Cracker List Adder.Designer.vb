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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.AddTab = New System.Windows.Forms.TabPage()
        Me.TxtCrackerName = New System.Windows.Forms.TextBox()
        Me.ListTab = New System.Windows.Forms.TabPage()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.AddTab.SuspendLayout()
        Me.ListTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.AddTab)
        Me.TabControl1.Controls.Add(Me.ListTab)
        Me.TabControl1.Location = New System.Drawing.Point(1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(787, 402)
        Me.TabControl1.TabIndex = 5
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(486, 66)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(81, 32)
        Me.BtnAdd.TabIndex = 2
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(492, 271)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(103, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter The Cracker Name"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(263, 146)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(200, 148)
        Me.ListBox1.TabIndex = 0
        '
        'AddTab
        '
        Me.AddTab.BackgroundImage = Global.PracitceOfWinForms.My.Resources.Resources.BackgroundImage
        Me.AddTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddTab.Controls.Add(Me.TxtCrackerName)
        Me.AddTab.Controls.Add(Me.ListBox1)
        Me.AddTab.Controls.Add(Me.Label1)
        Me.AddTab.Controls.Add(Me.BtnSave)
        Me.AddTab.Controls.Add(Me.BtnAdd)
        Me.AddTab.Location = New System.Drawing.Point(4, 22)
        Me.AddTab.Name = "AddTab"
        Me.AddTab.Padding = New System.Windows.Forms.Padding(3)
        Me.AddTab.Size = New System.Drawing.Size(779, 376)
        Me.AddTab.TabIndex = 0
        Me.AddTab.Text = "Add To List"
        Me.AddTab.UseVisualStyleBackColor = True
        '
        'TxtCrackerName
        '
        Me.TxtCrackerName.Location = New System.Drawing.Point(294, 71)
        Me.TxtCrackerName.Name = "TxtCrackerName"
        Me.TxtCrackerName.Size = New System.Drawing.Size(186, 20)
        Me.TxtCrackerName.TabIndex = 5
        '
        'ListTab
        '
        Me.ListTab.BackgroundImage = Global.PracitceOfWinForms.My.Resources.Resources.BackgroundImage
        Me.ListTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ListTab.Controls.Add(Me.BtnRefresh)
        Me.ListTab.Controls.Add(Me.ListBox2)
        Me.ListTab.Location = New System.Drawing.Point(4, 22)
        Me.ListTab.Name = "ListTab"
        Me.ListTab.Size = New System.Drawing.Size(779, 376)
        Me.ListTab.TabIndex = 1
        Me.ListTab.Text = "List"
        Me.ListTab.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(144, 38)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(302, 303)
        Me.ListBox2.TabIndex = 0
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Location = New System.Drawing.Point(475, 318)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.BtnRefresh.TabIndex = 1
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 403)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Practice"
        Me.TabControl1.ResumeLayout(False)
        Me.AddTab.ResumeLayout(False)
        Me.AddTab.PerformLayout()
        Me.ListTab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents AddTab As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtCrackerName As TextBox
    Friend WithEvents ListTab As TabPage
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents ListBox2 As ListBox
End Class
