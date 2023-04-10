' Name: Translator Project
' Purpose: Displays Translations
' Programmer: Celste Delgado on 4/10/23
Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub radMother_CheckedChanged(sender As Object, e As EventArgs) Handles radMother.CheckedChanged, radBrother.CheckedChanged,
            radFather.CheckedChanged, radSister.CheckedChanged
        lblTranslate.Text = ""
    End Sub

    Private Sub btnTranslate_Click(sender As Object, e As EventArgs) Handles btnTranslate.Click
        If radMother.Checked = True And cbL.SelectedIndex = 0 Then
            lblTranslate.Text = "mère"
        ElseIf radFather.Checked = True And cbL.SelectedIndex = 0 Then
            lblTranslate.Text = "père"
        ElseIf radBrother.Checked = True And cbL.SelectedIndex = 0 Then
            lblTranslate.Text = "frère"
        ElseIf radSister.Checked = True And cbL.SelectedIndex = 0 Then
            lblTranslate.Text = "sœur"
        ElseIf radMother.Checked = True And cbL.SelectedIndex = 1 Then
            lblTranslate.Text = "madre"
        ElseIf radFather.Checked = True And cbL.SelectedIndex = 1 Then
            lblTranslate.Text = "padre"
        ElseIf radBrother.Checked = True And cbL.SelectedIndex = 1 Then
            lblTranslate.Text = "fratello"
        ElseIf radSister.Checked = True And cbL.SelectedIndex = 1 Then
            lblTranslate.Text = "sorella"
        ElseIf radMother.Checked = True And cbL.SelectedIndex = 2 Then
            lblTranslate.Text = "Madre"
        ElseIf radFather.Checked = True And cbL.SelectedIndex = 2 Then
            lblTranslate.Text = "Padre"
        ElseIf radBrother.Checked = True And cbL.SelectedIndex = 2 Then
            lblTranslate.Text = "Hermoso"
        ElseIf radSister.Checked = True And cbL.SelectedIndex = 2 Then
            lblTranslate.Text = "Mermosa"
        End If
    End Sub

    Private Sub cbL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbL.SelectedIndexChanged
        lblTranslate.Text = ""
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
