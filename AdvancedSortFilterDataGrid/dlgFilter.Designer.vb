<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgFilter
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpCol = New System.Windows.Forms.GroupBox()
        Me.cb1 = New System.Windows.Forms.ComboBox()
        Me.cb2 = New System.Windows.Forms.ComboBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.date1 = New System.Windows.Forms.DateTimePicker()
        Me.date2 = New System.Windows.Forms.DateTimePicker()
        Me.rdoAnd = New System.Windows.Forms.RadioButton()
        Me.rdoOr = New System.Windows.Forms.RadioButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.grpCol.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(232, 138)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Show rows where:"
        '
        'grpCol
        '
        Me.grpCol.Controls.Add(Me.rdoOr)
        Me.grpCol.Controls.Add(Me.rdoAnd)
        Me.grpCol.Controls.Add(Me.date2)
        Me.grpCol.Controls.Add(Me.date1)
        Me.grpCol.Controls.Add(Me.txt2)
        Me.grpCol.Controls.Add(Me.txt1)
        Me.grpCol.Controls.Add(Me.cb2)
        Me.grpCol.Controls.Add(Me.cb1)
        Me.grpCol.Location = New System.Drawing.Point(12, 25)
        Me.grpCol.Name = "grpCol"
        Me.grpCol.Size = New System.Drawing.Size(366, 103)
        Me.grpCol.TabIndex = 2
        Me.grpCol.TabStop = False
        Me.grpCol.Text = "gbColName"
        '
        'cb1
        '
        Me.cb1.FormattingEnabled = True
        Me.cb1.Location = New System.Drawing.Point(6, 19)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(174, 21)
        Me.cb1.TabIndex = 0
        Me.cb1.DropDownStyle = Forms.ComboBoxStyle.DropDownList
        '
        'cb2
        '
        Me.cb2.FormattingEnabled = True
        Me.cb2.Location = New System.Drawing.Point(6, 69)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(174, 21)
        Me.cb2.TabIndex = 1
        Me.cb2.DropDownStyle = Forms.ComboBoxStyle.DropDownList
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(186, 19)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(174, 20)
        Me.txt1.TabIndex = 2
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(186, 69)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(174, 20)
        Me.txt2.TabIndex = 3
        '
        'date1
        '
        Me.date1.Location = New System.Drawing.Point(186, 19)
        Me.date1.Name = "date1"
        Me.date1.Size = New System.Drawing.Size(174, 20)
        Me.date1.TabIndex = 4
        Me.date1.Format = Forms.DateTimePickerFormat.Short
        Me.date1.Visible = False
        '
        'date2
        '
        Me.date2.Location = New System.Drawing.Point(186, 69)
        Me.date2.Name = "date2"
        Me.date2.Size = New System.Drawing.Size(174, 20)
        Me.date2.TabIndex = 5
        Me.date2.Format = Forms.DateTimePickerFormat.Short
        Me.date2.Visible = False
        '
        'rdoAnd
        '
        Me.rdoAnd.AutoSize = True
        Me.rdoAnd.Location = New System.Drawing.Point(47, 46)
        Me.rdoAnd.Name = "rdoAnd"
        Me.rdoAnd.Size = New System.Drawing.Size(44, 17)
        Me.rdoAnd.TabIndex = 6
        Me.rdoAnd.TabStop = True
        Me.rdoAnd.Text = "And"
        Me.rdoAnd.UseVisualStyleBackColor = True
        '
        'rdoOr
        '
        Me.rdoOr.AutoSize = True
        Me.rdoOr.Location = New System.Drawing.Point(97, 46)
        Me.rdoOr.Name = "rdoOr"
        Me.rdoOr.Size = New System.Drawing.Size(36, 17)
        Me.rdoOr.TabIndex = 7
        Me.rdoOr.TabStop = True
        Me.rdoOr.Text = "Or"
        Me.rdoOr.UseVisualStyleBackColor = True
        '
        'dlgFilter
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(390, 179)
        Me.Controls.Add(Me.grpCol)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgFilter"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Custom Auto Filter"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.grpCol.ResumeLayout(False)
        Me.grpCol.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpCol As System.Windows.Forms.GroupBox
    Friend WithEvents rdoOr As System.Windows.Forms.RadioButton
    Friend WithEvents rdoAnd As System.Windows.Forms.RadioButton
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents date1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents date2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cb2 As System.Windows.Forms.ComboBox
    Friend WithEvents cb1 As System.Windows.Forms.ComboBox

End Class
