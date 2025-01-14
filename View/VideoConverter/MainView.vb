Public Class MainView

Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles _
            mnuFileExit.Click
''--------------------------------------------------------------------
''    メニュー「ファイル」－「終了」
''--------------------------------------------------------------------
    Application.Exit()
End Sub

Private Sub mnuRunCount_Click(sender As Object, e As EventArgs) Handles _
            mnuRunCount.Click
''--------------------------------------------------------------------
''    テスト用のダミー
''--------------------------------------------------------------------
Dim value As WinFormsControl.OperationPanel.EOrientation

    value = Me.wfcOperation.Orientation
    if (value <> WinFormsControl.OperationPanel.EOrientation.Vertical) Then
        value = WinFormsControl.OperationPanel.EOrientation.Vertical
    Else
        value = WinFormsControl.OperationPanel.EOrientation.Horizontal
    End If
    Me.wfcOperation.Orientation = value
End Sub

End Class
