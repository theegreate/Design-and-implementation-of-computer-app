Public Class Form1

    Private Sub btnLoadObjectDemo_Load(sender As Object, e As EventArgs)
        ' Set tooltips
        ToolTip1.SetToolTip(btnLoadObjectDemo, "Load and display the Object Demonstrations form.")
        ToolTip1.SetToolTip(btnExit, "Terminate the application.")
    End Sub

    Private Sub btnLoadObjectDemo_Click(sender As Object, e As EventArgs) Handles btnLoadObjectDemo.Click
        ' Assuming ObjectDemoForm is the name of the form you want to show
        Dim objDemoForm As New Form2()
        objDemoForm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub MainForm_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ' Maximize the form and change background color to RED
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub

End Class
