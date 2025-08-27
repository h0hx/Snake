<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SnakeForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SnakeForm1))
        LabelTitle = New Label()
        ExitButton = New Button()
        AccountBox = New TextBox()
        SearchButton = New Button()
        DisplayNameBox = New TextBox()
        SuspendLayout()
        ' 
        ' LabelTitle
        ' 
        LabelTitle.AutoSize = True
        LabelTitle.Font = New Font("MS Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabelTitle.ForeColor = Color.Maroon
        LabelTitle.Location = New Point(12, 9)
        LabelTitle.Name = "LabelTitle"
        LabelTitle.Size = New Size(47, 16)
        LabelTitle.TabIndex = 0
        LabelTitle.Text = "Snake"
        ' 
        ' ExitButton
        ' 
        ExitButton.FlatStyle = FlatStyle.Flat
        ExitButton.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ExitButton.ForeColor = Color.DarkRed
        ExitButton.Location = New Point(488, 8)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(47, 26)
        ExitButton.TabIndex = 1
        ExitButton.Text = "Exit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' AccountBox
        ' 
        AccountBox.BackColor = Color.Black
        AccountBox.BorderStyle = BorderStyle.FixedSingle
        AccountBox.ForeColor = Color.Maroon
        AccountBox.Location = New Point(12, 40)
        AccountBox.Multiline = True
        AccountBox.Name = "AccountBox"
        AccountBox.Size = New Size(523, 23)
        AccountBox.TabIndex = 2
        AccountBox.Text = "Account:"
        ' 
        ' SearchButton
        ' 
        SearchButton.BackColor = Color.Black
        SearchButton.FlatStyle = FlatStyle.Flat
        SearchButton.Font = New Font("MS Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SearchButton.ForeColor = Color.Silver
        SearchButton.Location = New Point(12, 69)
        SearchButton.Name = "SearchButton"
        SearchButton.Size = New Size(523, 27)
        SearchButton.TabIndex = 4
        SearchButton.Text = "Search User"
        SearchButton.UseVisualStyleBackColor = False
        ' 
        ' DisplayNameBox
        ' 
        DisplayNameBox.BackColor = Color.Black
        DisplayNameBox.BorderStyle = BorderStyle.FixedSingle
        DisplayNameBox.ForeColor = Color.White
        DisplayNameBox.Location = New Point(12, 102)
        DisplayNameBox.Multiline = True
        DisplayNameBox.Name = "DisplayNameBox"
        DisplayNameBox.ReadOnly = True
        DisplayNameBox.Size = New Size(523, 239)
        DisplayNameBox.TabIndex = 5
        ' 
        ' SnakeForm1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(547, 353)
        Controls.Add(DisplayNameBox)
        Controls.Add(SearchButton)
        Controls.Add(AccountBox)
        Controls.Add(ExitButton)
        Controls.Add(LabelTitle)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "SnakeForm1"
        Text = "Snake"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelTitle As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents AccountBox As TextBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents DisplayNameBox As TextBox

End Class
