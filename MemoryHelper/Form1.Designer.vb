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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tbxTitle = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.tbxMemo = New System.Windows.Forms.TextBox()
        Me.cbxDeleted = New System.Windows.Forms.CheckBox()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblToolStripStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.tsbFirst = New System.Windows.Forms.ToolStripButton()
        Me.tsbPrev = New System.Windows.Forms.ToolStripButton()
        Me.tsbNext = New System.Windows.Forms.ToolStripButton()
        Me.tsbLast = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSearch = New System.Windows.Forms.ToolStripButton()
        Me.tsbEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbAdd = New System.Windows.Forms.ToolStripButton()
        Me.tsbDelete = New System.Windows.Forms.ToolStripButton()
        Me.testTmp = New System.Windows.Forms.Button()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(13, 105)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(30, 13)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Title:"
        '
        'tbxTitle
        '
        Me.tbxTitle.Location = New System.Drawing.Point(69, 97)
        Me.tbxTitle.Name = "tbxTitle"
        Me.tbxTitle.Size = New System.Drawing.Size(208, 20)
        Me.tbxTitle.TabIndex = 3
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(16, 139)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 4
        Me.lblDate.Text = "Date:"
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(69, 139)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(208, 20)
        Me.dtpDate.TabIndex = 5
        '
        'tbxMemo
        '
        Me.tbxMemo.Location = New System.Drawing.Point(19, 220)
        Me.tbxMemo.Multiline = True
        Me.tbxMemo.Name = "tbxMemo"
        Me.tbxMemo.Size = New System.Drawing.Size(495, 148)
        Me.tbxMemo.TabIndex = 6
        '
        'cbxDeleted
        '
        Me.cbxDeleted.AutoSize = True
        Me.cbxDeleted.Location = New System.Drawing.Point(451, 100)
        Me.cbxDeleted.Name = "cbxDeleted"
        Me.cbxDeleted.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbxDeleted.Size = New System.Drawing.Size(63, 17)
        Me.cbxDeleted.TabIndex = 9
        Me.cbxDeleted.Text = "Deleted"
        Me.cbxDeleted.UseVisualStyleBackColor = True
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmOpen, Me.tsmNew, Me.tsmSave, Me.tsmExit})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'tsmOpen
        '
        Me.tsmOpen.Name = "tsmOpen"
        Me.tsmOpen.Size = New System.Drawing.Size(152, 22)
        Me.tsmOpen.Text = "Open"
        '
        'tsmNew
        '
        Me.tsmNew.Name = "tsmNew"
        Me.tsmNew.Size = New System.Drawing.Size(152, 22)
        Me.tsmNew.Text = "New"
        '
        'tsmSave
        '
        Me.tsmSave.Name = "tsmSave"
        Me.tsmSave.Size = New System.Drawing.Size(152, 22)
        Me.tsmSave.Text = "Save"
        '
        'tsmExit
        '
        Me.tsmExit.Name = "tsmExit"
        Me.tsmExit.Size = New System.Drawing.Size(152, 22)
        Me.tsmExit.Text = "Exit"
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(591, 24)
        Me.MenuStrip.TabIndex = 10
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblToolStripStatus})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 396)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(591, 22)
        Me.StatusStrip.TabIndex = 11
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'lblToolStripStatus
        '
        Me.lblToolStripStatus.Name = "lblToolStripStatus"
        Me.lblToolStripStatus.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbFirst, Me.tsbPrev, Me.tsbNext, Me.tsbLast, Me.ToolStripSeparator1, Me.tsbSearch, Me.tsbEdit, Me.tsbAdd, Me.tsbDelete})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(591, 38)
        Me.ToolStrip.TabIndex = 12
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'tsbFirst
        '
        Me.tsbFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbFirst.Image = CType(resources.GetObject("tsbFirst.Image"), System.Drawing.Image)
        Me.tsbFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbFirst.Name = "tsbFirst"
        Me.tsbFirst.Size = New System.Drawing.Size(23, 35)
        Me.tsbFirst.Text = "First Record"
        '
        'tsbPrev
        '
        Me.tsbPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbPrev.Image = CType(resources.GetObject("tsbPrev.Image"), System.Drawing.Image)
        Me.tsbPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbPrev.Name = "tsbPrev"
        Me.tsbPrev.Size = New System.Drawing.Size(23, 35)
        Me.tsbPrev.Text = "Previous Record"
        '
        'tsbNext
        '
        Me.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbNext.Image = CType(resources.GetObject("tsbNext.Image"), System.Drawing.Image)
        Me.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNext.Name = "tsbNext"
        Me.tsbNext.Size = New System.Drawing.Size(23, 35)
        Me.tsbNext.Text = "Next Record"
        '
        'tsbLast
        '
        Me.tsbLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLast.Image = CType(resources.GetObject("tsbLast.Image"), System.Drawing.Image)
        Me.tsbLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLast.Name = "tsbLast"
        Me.tsbLast.Size = New System.Drawing.Size(23, 35)
        Me.tsbLast.Text = "Last Record"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'tsbSearch
        '
        Me.tsbSearch.Image = CType(resources.GetObject("tsbSearch.Image"), System.Drawing.Image)
        Me.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSearch.Name = "tsbSearch"
        Me.tsbSearch.Size = New System.Drawing.Size(45, 35)
        Me.tsbSearch.Text = "search"
        Me.tsbSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbEdit
        '
        Me.tsbEdit.Image = CType(resources.GetObject("tsbEdit.Image"), System.Drawing.Image)
        Me.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEdit.Name = "tsbEdit"
        Me.tsbEdit.Size = New System.Drawing.Size(31, 35)
        Me.tsbEdit.Text = "edit"
        Me.tsbEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbAdd
        '
        Me.tsbAdd.Image = CType(resources.GetObject("tsbAdd.Image"), System.Drawing.Image)
        Me.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAdd.Name = "tsbAdd"
        Me.tsbAdd.Size = New System.Drawing.Size(31, 35)
        Me.tsbAdd.Text = "add"
        Me.tsbAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbDelete
        '
        Me.tsbDelete.Image = CType(resources.GetObject("tsbDelete.Image"), System.Drawing.Image)
        Me.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbDelete.Name = "tsbDelete"
        Me.tsbDelete.Size = New System.Drawing.Size(43, 35)
        Me.tsbDelete.Text = "delete"
        Me.tsbDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'testTmp
        '
        Me.testTmp.Location = New System.Drawing.Point(439, 134)
        Me.testTmp.Name = "testTmp"
        Me.testTmp.Size = New System.Drawing.Size(75, 23)
        Me.testTmp.TabIndex = 13
        Me.testTmp.Text = "Test"
        Me.testTmp.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(591, 418)
        Me.Controls.Add(Me.testTmp)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.cbxDeleted)
        Me.Controls.Add(Me.tbxMemo)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.tbxTitle)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form1"
        Me.Text = "Memory Helper"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents tbxTitle As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents tbxMemo As TextBox
    Friend WithEvents cbxDeleted As CheckBox
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents tsmOpen As ToolStripMenuItem
    Friend WithEvents tsmNew As ToolStripMenuItem
    Friend WithEvents tsmSave As ToolStripMenuItem
    Friend WithEvents tsmExit As ToolStripMenuItem
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents tsbFirst As ToolStripButton
    Friend WithEvents tsbPrev As ToolStripButton
    Friend WithEvents tsbNext As ToolStripButton
    Friend WithEvents tsbLast As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSearch As ToolStripButton
    Friend WithEvents tsbEdit As ToolStripButton
    Friend WithEvents tsbAdd As ToolStripButton
    Friend WithEvents tsbDelete As ToolStripButton
    Friend WithEvents testTmp As Button
    Friend WithEvents lblToolStripStatus As ToolStripStatusLabel
End Class
