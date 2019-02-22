<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UltraGridForm
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
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Student", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sID")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("name")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FK_Student_StuCour_sel")
        Dim UltraGridBand2 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("FK_Student_StuCour_sel", 0)
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("sID")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("cID")
        Me.main_UltraGrid = New Infragistics.Win.UltraWinGrid.UltraGrid()
        Me.ds_school = New TestVB_form.School()
        Me.addRow_Button = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.UserControl11 = New TestVB_form.Test_UserControl()
        CType(Me.main_UltraGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds_school, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'main_UltraGrid
        '
        Me.main_UltraGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.main_UltraGrid.DataSource = Me.ds_school
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3})
        UltraGridColumn4.Header.VisiblePosition = 0
        UltraGridColumn5.Header.VisiblePosition = 1
        UltraGridBand2.Columns.AddRange(New Object() {UltraGridColumn4, UltraGridColumn5})
        Me.main_UltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.main_UltraGrid.DisplayLayout.BandsSerializer.Add(UltraGridBand2)
        Me.main_UltraGrid.Location = New System.Drawing.Point(13, 67)
        Me.main_UltraGrid.Name = "main_UltraGrid"
        Me.main_UltraGrid.Size = New System.Drawing.Size(452, 356)
        Me.main_UltraGrid.TabIndex = 0
        Me.main_UltraGrid.Text = "myDataGrid"
        '
        'ds_school
        '
        Me.ds_school.DataSetName = "School"
        Me.ds_school.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'addRow_Button
        '
        Me.addRow_Button.Location = New System.Drawing.Point(22, 25)
        Me.addRow_Button.Name = "addRow_Button"
        Me.addRow_Button.Size = New System.Drawing.Size(75, 23)
        Me.addRow_Button.TabIndex = 1
        Me.addRow_Button.Text = "Add row"
        Me.addRow_Button.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(114, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 20)
        Me.TextBox1.TabIndex = 2
        '
        'UserControl11
        '
        Me.UserControl11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserControl11.Location = New System.Drawing.Point(13, 468)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(452, 76)
        Me.UserControl11.TabIndex = 4
        '
        'UltraGridForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 563)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.addRow_Button)
        Me.Controls.Add(Me.main_UltraGrid)
        Me.Name = "UltraGridForm"
        Me.Text = "My Test Form"
        CType(Me.main_UltraGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds_school, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents main_UltraGrid As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents addRow_Button As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents UserControl11 As Test_UserControl
    Friend WithEvents ds_school As School
End Class
