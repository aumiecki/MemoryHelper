﻿Public Class Form1

    'declar global variables
    Dim strFilePathName As String = "D:\Documents\Source\Repository\MemoryHelper\MemoryHelper\MyFile.txt" 'path of a file location
    Dim intCurrentRecord As Integer 'record counter

    ' define structure of an array
    Structure MemoryRecord
        Dim blnDeleted As Boolean
        Dim dDate As Date
        Dim strTitle As String
        Dim strMemo As String
    End Structure

    'declare an array
    Dim dataTable(-1) As MemoryRecord

    ''' <summary>
    ''' loads firm
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">loads form</param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emptyRecords()
    End Sub

    '*** Helper Procedures ***

    ''' <summary>
    ''' procedure to all for edit of the record
    ''' </summary>
    Private Sub allowEditRecord()
        Me.tbxTitle.Enabled = True
        Me.tbxMemo.Enabled = True
        Me.dtpDate.Enabled = True
        Me.cbxDeleted.Enabled = False
    End Sub

    ''' <summary>
    ''' procedure to protect record from being edited
    ''' </summary>
    Private Sub protectRecord()
        Me.tbxTitle.Enabled = False
        Me.tbxMemo.Enabled = False
        Me.dtpDate.Enabled = False
        Me.cbxDeleted.Enabled = False
    End Sub

    ''' <summary>
    ''' prodedure to clear all data fields
    ''' </summary>
    Private Sub clearDisplay()
        Me.tbxTitle.Text = String.Empty
        Me.tbxMemo.Text = String.Empty
        Me.dtpDate.Value = Today.Date
        Me.cbxDeleted.Checked = False
    End Sub

    ''' <summary>
    ''' displays current record's position on the tool strip status bar
    ''' </summary>
    Private Sub updatePosition()
        Me.lblToolStripStatus.Text = "Current Record = " & (intCurrentRecord + 1).ToString & " of " & dataTable.Length.ToString
    End Sub

    '*** Worker Procedures ***

    ''' <summary>
    ''' declares a new record
    ''' </summary>
    Private Sub newRecord()
        saveRecord()
        clearDisplay()
        ReDim Preserve dataTable(dataTable.Length)
        intCurrentRecord = dataTable.GetUpperBound(0)
        allowEditRecord()
        updatePosition()
    End Sub

    ''' <summary>
    ''' deletes record
    ''' </summary>
    Private Sub deleteRecord()
        dataTable(intCurrentRecord).blnDeleted = True
        cbxDeleted.Checked = True
        protectRecord()
    End Sub

    ''' <summary>
    ''' saves record
    ''' </summary>
    Private Sub saveRecord()
        If intCurrentRecord >= 0 Then
            dataTable(intCurrentRecord).strTitle = Me.tbxTitle.Text
            dataTable(intCurrentRecord).strMemo = Me.tbxMemo.Text
            dataTable(intCurrentRecord).dDate = Me.dtpDate.Value
            dataTable(intCurrentRecord).blnDeleted = Me.cbxDeleted.Checked
            protectRecord()
        End If
    End Sub

    ''' <summary>
    ''' empties data from record
    ''' </summary>
    Private Sub emptyRecords()
        clearDisplay()
        protectRecord()
        intCurrentRecord = -1
        ReDim dataTable(-1)
    End Sub

    '*** ToolStrip Event Handlers ***

    ''' <summary>
    ''' add button 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">add button </param>
    Private Sub tsbAdd_Click(sender As Object, e As EventArgs) Handles tsbAdd.Click
        newRecord()
    End Sub

    ''' <summary>
    ''' edit button 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">edit button</param>
    Private Sub tsbEdit_Click(sender As Object, e As EventArgs) Handles tsbEdit.Click
        allowEditRecord()
    End Sub

    ''' <summary>
    ''' delete button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">delete button</param>
    Private Sub tsbDelete_Click(sender As Object, e As EventArgs) Handles tsbDelete.Click
        deleteRecord()
    End Sub
    '*** Navigation Buttons ***

    ''' <summary>
    ''' diplays data of current record
    ''' </summary>
    ''' <param name="index"></param>
    Private Sub showRecord(ByVal index As Integer)
        saveRecord()
        If index >= 0 And index <= dataTable.GetUpperBound(0) Then
            Me.tbxTitle.Text = dataTable(index).strTitle
            Me.tbxMemo.Text = dataTable(index).strMemo
            Me.dtpDate.Value = dataTable(index).dDate
            Me.cbxDeleted.Checked = dataTable(index).blnDeleted
            intCurrentRecord = index
            updatePosition()
        End If
    End Sub

    ''' <summary>
    ''' navigate to first record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">navigate to first record</param>
    Private Sub tsbFirst_Click(sender As Object, e As EventArgs) Handles tsbFirst.Click
        showRecord(0)
    End Sub

    ''' <summary>
    ''' navigate to last record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">navigate to last record</param>
    Private Sub tsbLast_Click(sender As Object, e As EventArgs) Handles tsbLast.Click
        showRecord(dataTable.Length - 1)
    End Sub

    ''' <summary>
    ''' navigate to next record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">navigate to next record</param>
    Private Sub tsbNext_Click(sender As Object, e As EventArgs) Handles tsbNext.Click
        showRecord(intCurrentRecord + 1)
    End Sub

    ''' <summary>
    ''' navigate to previous record
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">navigate to previous record</param>
    Private Sub tsbPrev_Click(sender As Object, e As EventArgs) Handles tsbPrev.Click
        showRecord(intCurrentRecord - 1)
    End Sub

    ''' <summary>
    ''' finds data in array and navigates to the record
    ''' </summary>
    ''' <param name="strSearchTerm">find data</param>
    ''' <returns></returns>
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

    ''' <summary>
    ''' search button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">search button</param>
    Private Sub tsbSearch_Click(sender As Object, e As EventArgs) Handles tsbSearch.Click
        Dim strSearchTerm As String = InputBox("Search Term:", "Find Record")
        Dim index As Integer = FindRecord(strSearchTerm)

        If index >= 0 Then
            showRecord(index)
        Else
            MsgBox("Record Not Found", MsgBoxStyle.Critical)
        End If
    End Sub

    ''' <summary>
    ''' saves data to a file
    ''' </summary>
    ''' <param name="dataSource"></param>
    ''' <param name="table">save to a file</param>
    ''' <returns></returns>
    Private Function saveTable(ByVal dataSource As String, ByVal table() As MemoryRecord) As Boolean
        Dim outputStream As System.IO.StreamWriter = Nothing
        Dim blnSuccessful As Boolean = True

        Try
            outputStream = New System.IO.StreamWriter(dataSource, False)
            For Each item As MemoryRecord In table
                If item.blnDeleted = False Then
                    outputStream.WriteLine(item.dDate)
                    outputStream.WriteLine(item.strTitle)
                    outputStream.WriteLine(item.strMemo)
                End If
            Next
        Catch ex As Exception
            blnSuccessful = False
        Finally
            outputStream.Close()
        End Try

        Return blnSuccessful
    End Function

    ''' <summary>
    ''' save button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">save button</param>
    Private Sub tsmSave_Click(sender As Object, e As EventArgs) Handles tsmSave.Click
        saveRecord()

        If saveTable(strFilePathName, dataTable) = False Then
            MsgBox("Error Writing Data to File",
            MsgBoxStyle.Critical)
        End If
    End Sub

    ''' <summary>
    ''' opens file window dialog to get files
    ''' </summary>
    ''' <returns></returns>
    Private Function getFile() As String
        Dim findFileDialog As New OpenFileDialog
        Dim result As DialogResult

        With findFileDialog
            .Title = "Locate Memory Helper Data File"
            .InitialDirectory = System.IO.Directory.GetCurrentDirectory
            .FileName = ""
            .Filter = "TextFiles (*.txt)|*.txt"
            result = .ShowDialog
        End With

        If result <> DialogResult.Cancel Then
            Return findFileDialog.FileName
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' populates data from file to the array
    ''' </summary>
    ''' <param name="dataSource"></param>
    ''' <param name="table">populates data from file</param>
    ''' <returns></returns>
    Private Function fillTable(ByVal dataSource As String,
        ByRef table() As MemoryRecord) As Integer

        Dim newRecord As MemoryRecord
        Dim inputStream As System.IO.StreamReader = Nothing

        Try
            inputStream = New System.IO.StreamReader(dataSource)
            Do Until inputStream.EndOfStream
                newRecord.dDate = Convert.ToDateTime(inputStream.ReadLine())
                newRecord.strTitle = inputStream.ReadLine()
                newRecord.strMemo = inputStream.ReadLine()
                newRecord.blnDeleted = False
                ReDim Preserve table(table.Length)
                table(table.Length - 1) = newRecord
            Loop
        Catch ex As Exception
            MsgBox("Error Reading File", MsgBoxStyle.Critical)
        Finally
            inputStream.Close()
        End Try

        Return table.Length
    End Function

    ''' <summary>
    ''' open button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">open button</param>
    Private Sub tsmOpen_Click(sender As Object, e As EventArgs) Handles tsmOpen.Click
        emptyRecords()
        strFilePathName = getFile()
        fillTable(strFilePathName, dataTable)
        showRecord(0)
        Me.ToolStrip.Enabled = True
        Me.Text = "Memory Helper (" & strFilePathName & ")"
    End Sub

    ''' <summary>
    ''' creates new file
    ''' </summary>
    ''' <returns>creates new file</returns>
    Private Function newFile() As String
        Dim newFileDialog As New SaveFileDialog()

        With newFileDialog
            .Filter = "txt files (*.txt)|*.txt"
            .FilterIndex = 1
            .RestoreDirectory = True
            .DefaultExt = "txt"
        End With

        If newFileDialog.ShowDialog() = DialogResult.OK Then
            Return newFileDialog.FileName
        Else
            Return ""
        End If
    End Function

    ''' <summary>
    ''' new button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">new button</param>
    Private Sub tsmNew_Click(sender As Object, e As EventArgs) Handles tsmNew.Click
        strFilePathName = newFile()
        If strFilePathName <> "" Then
            emptyRecords()
            updatePosition()
            Me.ToolStrip.Enabled = True
            Me.Text = "Memory Helper (" _
                    & strFilePathName & ")"
        Else
            MsgBox("A file was not created",
            MsgBoxStyle.Critical)
        End If
    End Sub

    ''' <summary>
    ''' exit button
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e">exit button</param>
    Private Sub tsmExit_Click(sender As Object, e As EventArgs) Handles tsmExit.Click
        Me.Close()
    End Sub
End Class
