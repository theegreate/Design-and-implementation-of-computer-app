<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btnExit = New Button()
        btnLoadPicture = New Button()
        picdisplay = New PictureBox()
        lblDisplayTest = New Label()
        txtSampleText = New TextBox()
        CheckedListBox1 = New CheckedListBox()
        BindingSource1 = New BindingSource(components)
        ContextMenuStrip1 = New ContextMenuStrip(components)
        ComboBoxFont = New ComboBox()
        LblFontStyle = New Label()
        LblFontColor = New Label()
        rbgreen = New RadioButton()
        rbblue = New RadioButton()
        rbred = New RadioButton()
        CheckBoxBold = New CheckBox()
        CheckBoxitalic = New CheckBox()
        CheckBoxBoldItalic = New CheckBox()
        CType(picdisplay, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(563, 365)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnLoadPicture
        ' 
        btnLoadPicture.Location = New Point(54, 365)
        btnLoadPicture.Name = "btnLoadPicture"
        btnLoadPicture.Size = New Size(112, 34)
        btnLoadPicture.TabIndex = 2
        btnLoadPicture.Text = "LoadPicture"
        btnLoadPicture.UseVisualStyleBackColor = True
        ' 
        ' picdisplay
        ' 
        picdisplay.Location = New Point(39, 235)
        picdisplay.Name = "picdisplay"
        picdisplay.Size = New Size(150, 75)
        picdisplay.TabIndex = 3
        picdisplay.TabStop = False
        ' 
        ' lblDisplayTest
        ' 
        lblDisplayTest.AutoSize = True
        lblDisplayTest.Location = New Point(39, 18)
        lblDisplayTest.Name = "lblDisplayTest"
        lblDisplayTest.Size = New Size(100, 25)
        lblDisplayTest.TabIndex = 4
        lblDisplayTest.Text = "DisplayTest"
        ' 
        ' txtSampleText
        ' 
        txtSampleText.BorderStyle = BorderStyle.None
        txtSampleText.Location = New Point(39, 55)
        txtSampleText.Name = "txtSampleText"
        txtSampleText.Size = New Size(150, 24)
        txtSampleText.TabIndex = 5
        txtSampleText.Text = "SampleText"
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(178, 79)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(11, 4)
        CheckedListBox1.TabIndex = 12
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.ImageScalingSize = New Size(24, 24)
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' ComboBoxFont
        ' 
        ComboBoxFont.FormattingEnabled = True
        ComboBoxFont.Items.AddRange(New Object() {"Garamond", "Magneto ", "Tahoma"})
        ComboBoxFont.Location = New Point(455, 46)
        ComboBoxFont.Name = "ComboBoxFont"
        ComboBoxFont.Size = New Size(182, 33)
        ComboBoxFont.TabIndex = 19
        ComboBoxFont.Text = "Font "
        ' 
        ' LblFontStyle
        ' 
        LblFontStyle.AutoSize = True
        LblFontStyle.Location = New Point(380, 129)
        LblFontStyle.Name = "LblFontStyle"
        LblFontStyle.Size = New Size(90, 25)
        LblFontStyle.TabIndex = 20
        LblFontStyle.Text = "Font Style"
        ' 
        ' LblFontColor
        ' 
        LblFontColor.AutoSize = True
        LblFontColor.Location = New Point(567, 129)
        LblFontColor.Name = "LblFontColor"
        LblFontColor.Size = New Size(96, 25)
        LblFontColor.TabIndex = 21
        LblFontColor.Text = "Font Color"
        ' 
        ' rbgreen
        ' 
        rbgreen.AutoSize = True
        rbgreen.Location = New Point(567, 157)
        rbgreen.Name = "rbgreen"
        rbgreen.Size = New Size(82, 29)
        rbgreen.TabIndex = 22
        rbgreen.TabStop = True
        rbgreen.Text = "green"
        rbgreen.UseVisualStyleBackColor = True
        ' 
        ' rbblue
        ' 
        rbblue.AutoSize = True
        rbblue.Location = New Point(567, 184)
        rbblue.Name = "rbblue"
        rbblue.Size = New Size(71, 29)
        rbblue.TabIndex = 23
        rbblue.TabStop = True
        rbblue.Text = "blue"
        rbblue.UseVisualStyleBackColor = True
        ' 
        ' rbred
        ' 
        rbred.AutoSize = True
        rbred.Location = New Point(567, 216)
        rbred.Name = "rbred"
        rbred.Size = New Size(63, 29)
        rbred.TabIndex = 24
        rbred.TabStop = True
        rbred.Text = "red"
        rbred.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxBold
        ' 
        CheckBoxBold.AutoSize = True
        CheckBoxBold.Location = New Point(362, 158)
        CheckBoxBold.Name = "CheckBoxBold"
        CheckBoxBold.Size = New Size(75, 29)
        CheckBoxBold.TabIndex = 25
        CheckBoxBold.Text = "bold"
        CheckBoxBold.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxitalic
        ' 
        CheckBoxitalic.AutoSize = True
        CheckBoxitalic.Location = New Point(362, 185)
        CheckBoxitalic.Name = "CheckBoxitalic"
        CheckBoxitalic.Size = New Size(73, 29)
        CheckBoxitalic.TabIndex = 26
        CheckBoxitalic.Text = "italic"
        CheckBoxitalic.UseVisualStyleBackColor = True
        ' 
        ' CheckBoxBoldItalic
        ' 
        CheckBoxBoldItalic.AutoSize = True
        CheckBoxBoldItalic.Location = New Point(362, 217)
        CheckBoxBoldItalic.Name = "CheckBoxBoldItalic"
        CheckBoxBoldItalic.Size = New Size(115, 29)
        CheckBoxBoldItalic.TabIndex = 27
        CheckBoxBoldItalic.Text = "Bold Italic"
        CheckBoxBoldItalic.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(CheckBoxBoldItalic)
        Controls.Add(CheckBoxitalic)
        Controls.Add(CheckBoxBold)
        Controls.Add(rbred)
        Controls.Add(rbblue)
        Controls.Add(rbgreen)
        Controls.Add(LblFontColor)
        Controls.Add(LblFontStyle)
        Controls.Add(ComboBoxFont)
        Controls.Add(CheckedListBox1)
        Controls.Add(txtSampleText)
        Controls.Add(lblDisplayTest)
        Controls.Add(picdisplay)
        Controls.Add(btnLoadPicture)
        Controls.Add(btnExit)
        Name = "Form2"
        Text = "ObjectDemonstrations"
        CType(picdisplay, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents btnLoadPicture As Button
    Friend WithEvents picdisplay As PictureBox
    Friend WithEvents lblDisplayTest As Label
    Friend WithEvents txtSampleText As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ComboBoxFont As ComboBox
    Friend WithEvents LblFontStyle As Label
    Friend WithEvents LblFontColor As Label
    Friend WithEvents rbgreen As RadioButton
    Friend WithEvents rbblue As RadioButton
    Friend WithEvents rbred As RadioButton
    Friend WithEvents CheckBoxBold As CheckBox
    Friend WithEvents CheckBoxitalic As CheckBox
    Friend WithEvents CheckBoxBoldItalic As CheckBox
End Class
