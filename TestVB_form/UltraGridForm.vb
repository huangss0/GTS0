Public Class UltraGridForm

    'Private dt1, dt2 As DataTable
    'Private ds As DataSet = New DataSet()

    Private Sub addRow_Button_Click(sender As Object, e As EventArgs) Handles addRow_Button.Click

        Dim stu_dt = Me.ds_school.Tables("Student")
        Dim stu_row = stu_dt.Rows.Add()
        stu_row("name") = "stu" + stu_dt.Rows.Count.ToString()

        Dim stuCour_dt = Me.ds_school.Tables("StuCour_sel")
        Dim cour_dt = Me.ds_school.Tables("Course")

        For Each cour_row In cour_dt.Rows
            Dim row1 = stuCour_dt.Rows.Add()
            row1("sID") = stu_row("sID")
            row1("cID") = cour_row("cID")
        Next

        If Not Me.DoSomething(stu_dt.Rows.Count) Then
            Me.Close()
        End If

    End Sub

    Private Function DoSomething(i As Integer) As Boolean
        If i > 20 Then Return False

        If Me.TextBox1.Text.Length < 1 Then
            Me.TextBox1.Text = "hello " & Me.TextBox1.Text
        ElseIf Me.TextBox1.Text.StartsWith("hello", StringComparison.OrdinalIgnoreCase) Then
            Me.TextBox1.Text = "Welcome Steven"
        End If

        Return True
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim prof_dt = Me.ds_school.Tables("Professor")
        Dim row = prof_dt.Rows.Add()
        row("name") = "prof1"

        Dim cour_dt = Me.ds_school.Tables("Course")
        Dim row1 = cour_dt.Rows.Add()
        row1("name") = "cour1"
        Dim row2 = cour_dt.Rows.Add()
        row2("name") = "cour2"

        'Me.main_UltraGrid.DataSource = Me.School1

    End Sub

    Private Sub main_UltraGrid_InitializeLayout(sender As Object, e As Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs) Handles main_UltraGrid.InitializeLayout
        e.Layout.Bands(0).Columns(0).CellAppearance.BackColor = Color.Yellow

        e.Layout.Bands(0).Columns(1).ButtonDisplayStyle = Infragistics.Win.UltraWinGrid.ButtonDisplayStyle.Always
        e.Layout.Bands(0).Columns(1).Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button

        For Each bd As Infragistics.Win.UltraWinGrid.UltraGridBand In e.Layout.Bands
            For Each cl As Infragistics.Win.UltraWinGrid.UltraGridColumn In bd.Columns
                cl.CellActivation = Infragistics.Win.UltraWinGrid.Activation.ActivateOnly
            Next
        Next

    End Sub

    Private Sub main_UltraGrid_ClickCellButton(sender As Object, e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles main_UltraGrid.ClickCellButton
        'MessageBox.Show("Cell click")
        e.Cell.Row.Refresh(Infragistics.Win.UltraWinGrid.RefreshRow.ReloadData)
        e.Cell.Row.Expanded = Not e.Cell.Row.Expanded
    End Sub
End Class
