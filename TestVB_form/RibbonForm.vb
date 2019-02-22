Public Class RibbonForm
    Private Sub RibbonButton2_Click(sender As Object, e As EventArgs) Handles RibbonButton2.Click
        MessageBox.Show(Me.ComputeLevenstheinDistance("data", "atae"))
    End Sub

    Private Function ComputeLevenstheinDistance(s1 As String, s2 As String) As Integer

        Dim n As Integer = s1.Length
        Dim m As Integer = s2.Length
        Dim d As Integer(,) = New Integer(n, m) {}

        ' Step 1
        If n = 0 Then Return m
        If m = 0 Then Return n

        ' Step 2
        For i As Integer = 0 To n
            d(i, 0) = i
        Next

        For j As Integer = 0 To m
            d(0, j) = j
        Next

        ' Step 3
        For i As Integer = 1 To n
            'Step 4
            For j As Integer = 1 To m
                ' Step 5
                Dim cost As Integer = If((s2(j - 1) = s1(i - 1)), 0, 1)

                ' Step 6
                d(i, j) = Math.Min(Math.Min(d(i - 1, j) + 1, d(i, j - 1) + 1), d(i - 1, j - 1) + cost)
            Next
        Next
        ' Step 7

        For i As Integer = 0 To n
            For j As Integer = 0 To m
                Console.Write(d(i, j).ToString() + " ")
            Next

            Console.WriteLine()
        Next


        Return d(n, m)
    End Function

End Class