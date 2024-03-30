
Public Class Form2
    Private Sub CheckedListBoxFontStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFont.SelectedIndexChanged
        Dim fontSize As Single = txtSampleText.Font.Size
        txtSampleText.Font = New Font(ComboBoxFont.SelectedItem.ToString(), fontSize)
    End Sub

    Private Sub rbgreen_Click(sender As Object, e As EventArgs) Handles rbgreen.Click
        txtSampleText.ForeColor = Color.Green
    End Sub

    Private Sub rbblue_Click(sender As Object, e As EventArgs) Handles rbblue.Click
        txtSampleText.ForeColor = Color.Blue
    End Sub

    Private Sub rbred_Click(sender As Object, e As EventArgs) Handles rbred.Click
        txtSampleText.ForeColor = Color.Red
    End Sub
    Private Sub btnLoadPicture_Click(sender As Object, e As EventArgs) Handles btnLoadPicture.Click
        picdisplay.ImageLocation = "C:\Users\Admin\Downloads\picture-a-captivating-scene-of-a-tranquil-lake-at-sunset-ai-generative-photo.jpg"
    End Sub

    Private Sub FontStyleChanged(sender As Object, e As EventArgs) Handles CheckBoxitalic.CheckedChanged, CheckBoxBold.CheckedChanged, CheckBoxBoldItalic.CheckedChanged
        Dim fontStyle As FontStyle = FontStyle.Regular

        ' Apply italic style if the italic checkbox is checked.
        If CheckBoxitalic.Checked Then fontStyle = fontStyle Or FontStyle.Italic

        ' Apply bold style if the bold checkbox is checked.
        If CheckBoxBold.Checked Then fontStyle = fontStyle Or FontStyle.Bold

        ' This section is redundant if CheckBoxBoldItalic is meant to be a quick select for both bold and italic.
        ' If CheckBoxBoldItalic.Checked Then fontStyle = FontStyle.Bold Or FontStyle.Italic

        ' Set the new font style.
        txtSampleText.Font = New Font(txtSampleText.Font.FontFamily, txtSampleText.Font.Size, fontStyle)
    End Sub

End Class