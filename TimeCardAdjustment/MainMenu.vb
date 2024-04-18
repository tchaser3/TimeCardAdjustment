'Title:         Time Card Adjustment Main Menu
'Date:          5-13-15
'Author:        Terry Holmes

'Description:   This application is so that a manager can change a time card or run reports

Option Strict On

Public Class MainMenu

    'Setting global variables
    Dim TheModuleUnderDevelopment As New ModuleUnderDevelopment

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'This will load up the last transaction
        Logon.mstrLastTransactionSummary = "LOADED TIME CARD ADJUSTMENT MAIN MENU"

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'This will close the application
        CloseProgram.ShowDialog()

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        About.ShowDialog()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        LastTransaction.Show()
        TheModuleUnderDevelopment.UnderDevelopment()
    End Sub

    Private Sub btnAdjustTime_Click(sender As Object, e As EventArgs) Handles btnAdjustTime.Click
        LastTransaction.Show()
        TheModuleUnderDevelopment.UnderDevelopment()
    End Sub
End Class