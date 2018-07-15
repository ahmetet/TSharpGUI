<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ayar
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KaydetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DerleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÇalıştırToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem, Me.DerleToolStripMenuItem, Me.ÇalıştırToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(692, 43)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AçToolStripMenuItem, Me.KaydetToolStripMenuItem, Me.ToolStripSeparator1})
        Me.DosyaToolStripMenuItem.ForeColor = System.Drawing.Color.Blue
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(96, 39)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'AçToolStripMenuItem
        '
        Me.AçToolStripMenuItem.Name = "AçToolStripMenuItem"
        Me.AçToolStripMenuItem.Size = New System.Drawing.Size(181, 40)
        Me.AçToolStripMenuItem.Text = "Aç"
        '
        'KaydetToolStripMenuItem
        '
        Me.KaydetToolStripMenuItem.Name = "KaydetToolStripMenuItem"
        Me.KaydetToolStripMenuItem.Size = New System.Drawing.Size(181, 40)
        Me.KaydetToolStripMenuItem.Text = "Kaydet"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'DerleToolStripMenuItem
        '
        Me.DerleToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.DerleToolStripMenuItem.Name = "DerleToolStripMenuItem"
        Me.DerleToolStripMenuItem.Size = New System.Drawing.Size(86, 39)
        Me.DerleToolStripMenuItem.Text = "Derle"
        '
        'ÇalıştırToolStripMenuItem
        '
        Me.ÇalıştırToolStripMenuItem.ForeColor = System.Drawing.Color.Red
        Me.ÇalıştırToolStripMenuItem.Name = "ÇalıştırToolStripMenuItem"
        Me.ÇalıştırToolStripMenuItem.Size = New System.Drawing.Size(101, 39)
        Me.ÇalıştırToolStripMenuItem.Text = "Çalıştır"
        '
        'Ayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(692, 57)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Ayar"
        Me.ShowIcon = False
        Me.Text = "T# Gelişmiş"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DosyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DerleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÇalıştırToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AçToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaydetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
