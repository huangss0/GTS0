<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RibbonForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RibbonForm))
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.RibbonButton3 = New System.Windows.Forms.RibbonButton()
        Me.RibbonOrbMenuItem1 = New System.Windows.Forms.RibbonOrbMenuItem()
        Me.RibbonButton7 = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton8 = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.RibbonButton2 = New System.Windows.Forms.RibbonButton()
        Me.RibbonButton4 = New System.Windows.Forms.RibbonButton()
        Me.RibbonTab2 = New System.Windows.Forms.RibbonTab()
        Me.SuspendLayout()
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.ContentButtonsMinWidth = 90
        Me.Ribbon1.OrbDropDown.ContentRecentItemsMinWidth = 0
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonButton3)
        Me.Ribbon1.OrbDropDown.MenuItems.Add(Me.RibbonOrbMenuItem1)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(350, 160)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbImage = Nothing
        Me.Ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010
        Me.Ribbon1.OrbText = "Files"
        '
        '
        '
        Me.Ribbon1.QuickAcessToolbar.Items.Add(Me.RibbonButton1)
        Me.Ribbon1.QuickAcessToolbar.Text = "Sv"
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(402, 143)
        Me.Ribbon1.TabIndex = 0
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.Tabs.Add(Me.RibbonTab2)
        Me.Ribbon1.TabsMargin = New System.Windows.Forms.Padding(12, 26, 20, 0)
        Me.Ribbon1.Text = "Ribbon1"
        Me.Ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue
        '
        'RibbonButton3
        '
        Me.RibbonButton3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonButton3.Image = CType(resources.GetObject("RibbonButton3.Image"), System.Drawing.Image)
        Me.RibbonButton3.SmallImage = CType(resources.GetObject("RibbonButton3.SmallImage"), System.Drawing.Image)
        Me.RibbonButton3.Text = "open RB3"
        '
        'RibbonOrbMenuItem1
        '
        Me.RibbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left
        Me.RibbonOrbMenuItem1.DropDownItems.Add(Me.RibbonButton7)
        Me.RibbonOrbMenuItem1.DropDownItems.Add(Me.RibbonButton8)
        Me.RibbonOrbMenuItem1.Image = CType(resources.GetObject("RibbonOrbMenuItem1.Image"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.SmallImage = CType(resources.GetObject("RibbonOrbMenuItem1.SmallImage"), System.Drawing.Image)
        Me.RibbonOrbMenuItem1.Style = System.Windows.Forms.RibbonButtonStyle.DropDown
        Me.RibbonOrbMenuItem1.Text = "RibbonOrbMenuItem1"
        '
        'RibbonButton7
        '
        Me.RibbonButton7.Image = CType(resources.GetObject("RibbonButton7.Image"), System.Drawing.Image)
        Me.RibbonButton7.SmallImage = CType(resources.GetObject("RibbonButton7.SmallImage"), System.Drawing.Image)
        Me.RibbonButton7.Text = "btn9"
        '
        'RibbonButton8
        '
        Me.RibbonButton8.Image = CType(resources.GetObject("RibbonButton8.Image"), System.Drawing.Image)
        Me.RibbonButton8.SmallImage = CType(resources.GetObject("RibbonButton8.SmallImage"), System.Drawing.Image)
        Me.RibbonButton8.Text = "btn7"
        '
        'RibbonButton1
        '
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Text = "RibbonButton1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel1)
        Me.RibbonTab1.Text = "RibbonTab1"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.RibbonButton2)
        Me.RibbonPanel1.Items.Add(Me.RibbonButton4)
        Me.RibbonPanel1.Text = "RibbonPanel1"
        '
        'RibbonButton2
        '
        Me.RibbonButton2.DropDownResizable = True
        Me.RibbonButton2.Image = CType(resources.GetObject("RibbonButton2.Image"), System.Drawing.Image)
        Me.RibbonButton2.SmallImage = CType(resources.GetObject("RibbonButton2.SmallImage"), System.Drawing.Image)
        Me.RibbonButton2.Text = "RB2"
        '
        'RibbonButton4
        '
        Me.RibbonButton4.Image = CType(resources.GetObject("RibbonButton4.Image"), System.Drawing.Image)
        Me.RibbonButton4.SmallImage = CType(resources.GetObject("RibbonButton4.SmallImage"), System.Drawing.Image)
        Me.RibbonButton4.Text = "RB4"
        '
        'RibbonTab2
        '
        Me.RibbonTab2.Text = "RibbonTab2"
        '
        'RibbonForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 266)
        Me.Controls.Add(Me.Ribbon1)
        Me.Name = "RibbonForm"
        Me.Text = "RibbonForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ribbon1 As Ribbon
    Friend WithEvents RibbonButton1 As RibbonButton
    Friend WithEvents RibbonTab1 As RibbonTab
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents RibbonButton2 As RibbonButton
    Friend WithEvents RibbonButton4 As RibbonButton
    Friend WithEvents RibbonTab2 As RibbonTab
    Friend WithEvents RibbonButton3 As RibbonButton
    Friend WithEvents RibbonOrbMenuItem1 As RibbonOrbMenuItem
    Friend WithEvents RibbonButton7 As RibbonButton
    Friend WithEvents RibbonButton8 As RibbonButton
End Class
