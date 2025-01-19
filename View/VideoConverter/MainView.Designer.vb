
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainView))

        Me.dgvFileList = New DataGridView()
        Me.mnuMain = New MenuStrip()
        Me.mnuFile = New ToolStripMenuItem()
        Me.mnuFileExit = New ToolStripMenuItem()
        Me.mnuRun = New ToolStripMenuItem()
        Me.mnuRunCount = New ToolStripMenuItem()

        Me.dlgOpenFile = New OpenFileDialog()
        Me.wfcEncodeConfig = New WinFormsControl.EncodeConfig()
        Me.wfcOperation = New WinFormsControl.OperationPanel()
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        ' mnuMain
        '
        resources.ApplyResources(Me.mnuMain, "mnuMain")
        Me.mnuMain.Items.AddRange(New ToolStripItem() {mnuFile, mnuRun})
        Me.mnuMain.Name = "mnuMain"
        '
        ' mnuFile
        '
        resources.ApplyResources(Me.mnuFile, "mnuFile")
        Me.mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuFileExit})
        Me.mnuFile.Name = "mnuFilem"
        '
        ' mnuFileExit
        '
        resources.ApplyResources(Me.mnuFileExit, "mnuFileExit")
        Me.mnuFileExit.Name = "mnuFileExit"
        '
        ' mnuRun
        '
        resources.ApplyResources(Me.mnuRun, "mnuRun")
        Me.mnuRun.DropDownItems.AddRange(New ToolStripItem() {mnuRunCount})
        Me.mnuRun.Name = "mnuRun"
        '
        ' mnuRunCount
        '
        resources.ApplyResources(Me.mnuRunCount, "mnuRunCount")
        Me.mnuRunCount.Name = "mnuRunCount"

        '
        ' dlgOpenFile
        '
        Me.dlgOpenFile.FileName = "dlgOpenFile"
        resources.ApplyResources(Me.dlgOpenFile, "dlgOpenFile")

        '
        ' wfcEncodeConfig
        '
        resources.ApplyResources(Me.wfcEncodeConfig, "wfcEncodeConfig")
        Me.wfcEncodeConfig.Name = "wfcEncodeConfig"

        '
        ' wfcOperation
        '
        resources.ApplyResources(Me.wfcOperation, "wfcOperation")
        Me.wfcEncodeConfig.Name = "wfcOperation"

        '
        ' dgvFileList
        '
        resources.ApplyResources(Me.dgvFileList, "dgvFileList")
        Me.dgvFileList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFileList.Name = "dgvFileList"
        Me.dgvFileList.RowTemplate.Height = 25

        '
        ' MainView
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = AutoScaleMode.None
        Me.Controls.Add(Me.wfcEncodeConfig)
        Me.Controls.Add(Me.wfcOperation)
        Me.Controls.Add(Me.dgvFileList)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "MainView"
        CType(Me.dgvFileList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvFileList As DataGridView
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuRun As ToolStripMenuItem
    Friend WithEvents mnuRunCount As ToolStripMenuItem
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents wfcEncodeConfig As WinFormsControl.EncodeConfig
    Friend WithEvents wfcOperation As WinFormsControl.OperationPanel

End Class
