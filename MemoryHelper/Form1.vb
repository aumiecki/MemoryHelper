Public Class Form1

    Dim strFilePathName As String = ""
    Dim intCurrentRecord As Integer

    Structure MemoryRecord
        Dim blnDeleted As Boolean
        Dim dDate As Date
        Dim strTitle As String
        Dim strMemo As String
    End Structure

    Dim dataTable(-1) As MemoryRecord

    'Private Sub testTmp_Click(sender As Object, e As EventArgs) Handles testTmp.Click
    '    'Temp Event handler used to test
    '    clearDisplay()
    'End Sub

    '*** Helper Procedures ***

    Private Sub allowEditRecord()
        Me.tbxTitle.Enabled = True
        Me.tbxMemo.Enabled = True
        Me.dtpDate.Enabled = True
        Me.cbxDeleted.Enabled = False
    End Sub

    Private Sub protectRecord()
        Me.tbxTitle.Enabled = False
        Me.tbxMemo.Enabled = False
        Me.dtpDate.Enabled = False
        Me.cbxDeleted.Enabled = False
    End Sub

    Private Sub clearDisplay()
        Me.tbxTitle.Text = String.Empty
        Me.tbxMemo.Text = String.Empty
        Me.dtpDate.Value = Today.Date
        Me.cbxDeleted.Checked = False
    End Sub

    Private Sub updatePosition()
        Me.StatusStrip.Text = "Current Record = " & (intCurrentRecord + 1).ToString & " of " & dataTable.Length.ToString
    End Sub
    '*** Worker Procedures ***

    Private Sub newRecord()
        saveRecord()
        clearDisplay()
        ReDim Preserve dataTable(dataTable.Length)
        intCurrentRecord = dataTable.GetUpperBound(0)
        allowEditRecord()
        updatePosition()
    End Sub

    Private Sub deleteRecord()
        dataTable(intCurrentRecord).blnDeleted = True
        cbxDeleted.Checked = True
        protectRecord()
    End Sub

    Private Sub saveRecord()
        If intCurrentRecord >= 0 Then
            dataTable(intCurrentRecord).strTitle = Me.tbxTitle.Text
            dataTable(intCurrentRecord).strMemo = Me.tbxMemo.Text
            dataTable(intCurrentRecord).dDate = Me.dtpDate.Value
            dataTable(intCurrentRecord).blnDeleted = Me.cbxDeleted.Checked
            protectRecord()
        End If
    End Sub

    Private Sub emptyRecords()
        clearDisplay()
        protectRecord()
        intCurrentRecord = -1
        ReDim dataTable(-1)
    End Sub
    '*** ToolStrip Event Handlers ***

    Private Sub tsbAdd_Click(sender As Object, e As EventArgs) Handles tsbAdd.Click
        newRecord()
    End Sub

    Private Sub tsbEdit_Click(sender As Object, e As EventArgs) Handles tsbEdit.Click
        allowEditRecord()
    End Sub

    Private Sub tsbDelete_Click(sender As Object, e As EventArgs) Handles tsbDelete.Click
        deleteRecord()
    End Sub
    '*** Navigation Buttons ***

    Private Sub showRecord(ByVal index As Integer)
        saveRecord()
        If index >= 0 And index <= dataTable.GetUpperBound(0) Then
            Me.tbxTitle.Text = dataTable(index).strTitle
            Me.tbxMemo.Text = dataTable(index).strMemo
            Me.dtpDate.Value = dataTable(index).dDate
            Me.cbxDeleted.Checked = dataTable(index).blnDeleted
            intCurrentRecord = index
        End If
    End Sub

    Private Sub tsbFirst_Click(sender As Object, e As EventArgs) Handles tsbFirst.Click
        showRecord(0)
    End Sub

    Private Sub tsbLast_Click(sender As Object, e As EventArgs) Handles tsbLast.Click
        showRecord(dataTable.Length - 1)
    End Sub

    Private Sub tsbNext_Click(sender As Object, e As EventArgs) Handles tsbNext.Click
        showRecord(intCurrentRecord + 1)
    End Sub

    Private Sub tsbPrev_Click(sender As Object, e As EventArgs) Handles tsbPrev.Click
        showRecord(intCurrentRecord - 1)
    End Sub

    Private Function FindRecord(ByVal strSearchTerm As String) As Integer
        Dim returnValue As Integer = -1
        Dim currentElement As Integer = 0

        For Each item As MemoryRecord In dataTable
            If item.strMemo.Contains(strSearchTerm) Or item.strTitle.Contains(strSearchTerm) Then
                returnValue = currentElement
                Exit For
            End If
            currentElement += 1
        Next item

        Return returnValue
    End Function

    Private Sub tsbSearch_Click(sender As Object, e As EventArgs) Handles tsbSearch.Click
        Dim strSearchTerm As String = InputBox("Search Term:", "Find Record")
        Dim index As Integer = FindRecord(strSearchTerm)

        If index >= 0 Then
            showRecord(index)
        Else
            MsgBox("Record Not Found", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
