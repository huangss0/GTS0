<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.gridButton = New System.Windows.Forms.Button()
        Me.ribbon_Button = New System.Windows.Forms.Button()
        Me.zip_Button = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.zip_TextBox = New System.Windows.Forms.TextBox()
        Me.test_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'gridButton
        '
        Me.gridButton.Location = New System.Drawing.Point(12, 12)
        Me.gridButton.Name = "gridButton"
        Me.gridButton.Size = New System.Drawing.Size(154, 23)
        Me.gridButton.TabIndex = 0
        Me.gridButton.Text = "UltraGrid and UserControl"
        Me.gridButton.UseVisualStyleBackColor = True
        '
        'ribbon_Button
        '
        Me.ribbon_Button.Location = New System.Drawing.Point(172, 12)
        Me.ribbon_Button.Name = "ribbon_Button"
        Me.ribbon_Button.Size = New System.Drawing.Size(75, 23)
        Me.ribbon_Button.TabIndex = 1
        Me.ribbon_Button.Text = "Ribbon35"
        Me.ribbon_Button.UseVisualStyleBackColor = True
        '
        'zip_Button
        '
        Me.zip_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zip_Button.Location = New System.Drawing.Point(263, 49)
        Me.zip_Button.Name = "zip_Button"
        Me.zip_Button.Size = New System.Drawing.Size(75, 23)
        Me.zip_Button.TabIndex = 2
        Me.zip_Button.Text = "ZipFile"
        Me.zip_Button.UseVisualStyleBackColor = True
        '
        'zip_TextBox
        '
        Me.zip_TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.zip_TextBox.Location = New System.Drawing.Point(12, 51)
        Me.zip_TextBox.Name = "zip_TextBox"
        Me.zip_TextBox.Size = New System.Drawing.Size(245, 20)
        Me.zip_TextBox.TabIndex = 3
        Me.zip_TextBox.Text = "C:\Users\SHuang\Desktop\result.xlsx"
        '
        'test_Button
        '
        Me.test_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.test_Button.Location = New System.Drawing.Point(263, 116)
        Me.test_Button.Name = "test_Button"
        Me.test_Button.Size = New System.Drawing.Size(75, 23)
        Me.test_Button.TabIndex = 4
        Me.test_Button.Text = "Test Button"
        Me.test_Button.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 151)
        Me.Controls.Add(Me.test_Button)
        Me.Controls.Add(Me.zip_TextBox)
        Me.Controls.Add(Me.zip_Button)
        Me.Controls.Add(Me.ribbon_Button)
        Me.Controls.Add(Me.gridButton)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gridButton As Button
    Friend WithEvents ribbon_Button As Button
    Friend WithEvents zip_Button As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents zip_TextBox As TextBox
    Friend WithEvents test_Button As Button
End Class
