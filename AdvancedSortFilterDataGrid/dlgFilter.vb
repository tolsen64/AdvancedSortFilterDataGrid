Imports System.Windows.Forms
Imports Microsoft.VisualBasic

Public Class dlgFilter

    Public Enum FilterType
        FilterTypeDate
        FilterTypeNumeric
        FilterTypeString
    End Enum

    Public ReadOnly Property Filter As String
        Get
            Dim s As String = ""
            Select Case cb1.SelectedItem
                Case "Equals"
                    If _FilterType = FilterType.FilterTypeString Then
                        s = "([" & _colName & "]='" & txt1.Text.Replace("'", "''") & "'"
                    ElseIf _FilterType = FilterType.FilterTypeNumeric Then
                        s = "([" & _colName & "]=" & txt1.Text
                    ElseIf _FilterType = FilterType.FilterTypeDate Then
                        s = "([" & _colName & "]='" & GetDbDate(date1) & "'"
                    End If
                Case "Does Not Equal"
                    If _FilterType = FilterType.FilterTypeString Then
                        s = "([" & _colName & "]<>'" & txt1.Text.Replace("'", "''") & "'"
                    ElseIf _FilterType = FilterType.FilterTypeNumeric Then
                        s = "([" & _colName & "]<>" & txt1.Text
                    ElseIf _FilterType = FilterType.FilterTypeDate Then
                        s = "([" & _colName & "]<>'" & GetDbDate(date1) & "'"
                    End If
                Case "Greater Than" : s = "([" & _colName & "]>" & If(_FilterType = FilterType.FilterTypeNumeric, txt1.Text, "'" & GetDbDate(date1) & "'")
                Case "Greater Than Or Equal To" : s = "([" & _colName & "]>=" & If(_FilterType = FilterType.FilterTypeNumeric, txt1.Text, "'" & GetDbDate(date1) & "'")
                Case "Less Than" : s = "([" & _colName & "]<" & If(_FilterType = FilterType.FilterTypeNumeric, txt1.Text, "'" & GetDbDate(date1) & "'")
                Case "Less Than Or Equal To" : s = "([" & _colName & "]<=" & If(_FilterType = FilterType.FilterTypeNumeric, txt1.Text, "'" & GetDbDate(date1) & "'")
                Case "Begins With" : s = "([" & _colName & "] LIKE '" & txt1.Text.Replace("'", "''") & "%'"
                Case "Ends With" : s = "([" & _colName & "] LIKE '%" & txt1.Text.Replace("'", "''") & "'"
                Case "Contains" : s = "([" & _colName & "] LIKE '%" & txt1.Text.Replace("'", "''") & "%'"
                Case "Does Not Contain" : s = "([" & _colName & "] NOT LIKE '%" & txt1.Text.Replace("'", "''") & "%'"
            End Select

            If cb2.SelectedItem <> "" Then
                If rdoAnd.Checked Then s &= ") AND "
                If rdoOr.Checked Then s &= ") OR "

                Select Case cb2.SelectedItem
                    Case "Equals"
                        If _FilterType = FilterType.FilterTypeString Then
                            s &= "([" & _colName & "]='" & txt2.Text.Replace("'", "''") & "'"
                        ElseIf _FilterType = FilterType.FilterTypeNumeric Then
                            s &= "([" & _colName & "]=" & txt2.Text
                        ElseIf _FilterType = FilterType.FilterTypeDate Then
                            s &= "([" & _colName & "]='" & GetDbDate(date2) & "'"
                        End If
                    Case "Does Not Equal"
                        If _FilterType = FilterType.FilterTypeString Then
                            s &= "([" & _colName & "]<>'" & txt2.Text.Replace("'", "''") & "'"
                        ElseIf _FilterType = FilterType.FilterTypeNumeric Then
                            s &= "([" & _colName & "]<>" & txt2.Text
                        ElseIf _FilterType = FilterType.FilterTypeDate Then
                            s &= "([" & _colName & "]<>'" & GetDbDate(date2) & "'"
                        End If
                    Case "Greater Than" : s &= "([" & _colName & "]>" & If(_FilterType = FilterType.FilterTypeNumeric, txt2.Text, "'" & GetDbDate(date2) & "'")
                    Case "Greater Than Or Equal To" : s &= "([" & _colName & "]>=" & If(_FilterType = FilterType.FilterTypeNumeric, txt2.Text, "'" & GetDbDate(date2) & "'")
                    Case "Less Than" : s &= "([" & _colName & "]<" & If(_FilterType = FilterType.FilterTypeNumeric, txt2.Text, "'" & GetDbDate(date2) & "'")
                    Case "Less Than Or Equal To" : s &= "([" & _colName & "]<=" & If(_FilterType = FilterType.FilterTypeNumeric, txt2.Text, "'" & GetDbDate(date2) & "'")
                    Case "Begins With" : s &= "([" & _colName & "] LIKE '" & txt2.Text.Replace("'", "''") & "%'"
                    Case "Ends With" : s &= "([" & _colName & "] LIKE '%" & txt2.Text.Replace("'", "''") & "'"
                    Case "Contains" : s &= "([" & _colName & "] LIKE '%" & txt2.Text.Replace("'", "''") & "%'"
                    Case "Does Not Contain" : s &= "([" & _colName & "] NOT LIKE '%" & txt2.Text.Replace("'", "''") & "%'"
                End Select
            End If

            'MsgBox(s & ")")
            Return s & ")"
        End Get
    End Property

    Private _colName As String
    Private _FilterType As FilterType

    Private DateFilterTypes As String() = {"", "Equals", "Does Not Equal", "Greater Than", "Greater Than Or Equal To", "Less Than", "Less Than Or Equal To"}
    Private NumericFilterTypes As String() = {"", "Equals", "Does Not Equal", "Greater Than", "Greater Than Or Equal To", "Less Than", "Less Than Or Equal To"}
    Private StringFilterTypes As String() = {"", "Equals", "Does Not Equal", "Begins With", "Ends With", "Contains", "Does Not Contain"}

    Public Sub New(colName As String, FilterType As FilterType, FilterChoice As String)
        InitializeComponent()

        _colName = colName
        _FilterType = FilterType

        grpCol.Text = _colName

        If FilterType = dlgFilter.FilterType.FilterTypeDate Then
            For Each s As String In DateFilterTypes
                cb1.Items.Add(s)
                cb2.Items.Add(s)
            Next
            txt1.Visible = False
            txt2.Visible = False
            date1.Visible = True
            date2.Visible = True
        ElseIf FilterType = dlgFilter.FilterType.FilterTypeNumeric Then
            For Each s As String In NumericFilterTypes
                cb1.Items.Add(s)
                cb2.Items.Add(s)
            Next
            txt1.Visible = True
            txt2.Visible = True
            date1.Visible = False
            date2.Visible = False
        Else
            For Each s As String In StringFilterTypes
                cb1.Items.Add(s)
                cb2.Items.Add(s)
            Next
            txt1.Visible = True
            txt2.Visible = True
            date1.Visible = False
            date2.Visible = False
        End If

        Select Case FilterChoice
            Case "Equals..." : cb1.SelectedItem = FilterChoice.Replace("...", "")
            Case "Does Not Equal..." : cb1.SelectedItem = FilterChoice.Replace("...", "")
            Case "Greater Than..." : cb1.SelectedItem = FilterChoice.Replace("...", "")
            Case "Greater Than Or Equal To..." : cb1.SelectedItem = FilterChoice.Replace("...", "")
            Case "Less Than..." : cb1.SelectedItem = FilterChoice.Replace("...", "")
            Case "Less Than Or Equal To..." : cb1.SelectedItem = FilterChoice.Replace("...", "")
            Case "Between..." : cb1.SelectedItem = "Greater Than Or Equal To" : rdoAnd.Checked = True : cb2.SelectedItem = "Less Than Or Equal To"
            Case "Begins With..." : cb1.SelectedItem = FilterChoice.Replace("...", "")
            Case "Ends With..." : cb1.SelectedItem = FilterChoice.Replace("...", "")
            Case "Contains..." : cb1.SelectedItem = FilterChoice.Replace("...", "")
            Case "Does Not Contain..." : cb1.SelectedItem = FilterChoice.Replace("...", "")
        End Select

        rdoAnd.Checked = True
    End Sub

    Private Sub dlgFilter_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If _FilterType = FilterType.FilterTypeDate Then
            date1.Focus()
        Else
            txt1.Focus()
        End If
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub txt1Andtxt2_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged, txt2.TextChanged
        If _FilterType = FilterType.FilterTypeNumeric Then
            Dim txt As TextBox = DirectCast(sender, TextBox)
            If txt.Text.Length > 0 AndAlso Not IsNumeric(txt.Text) Then
                MsgBox("Only numeric values allowed.", MsgBoxStyle.Exclamation)
                txt.Text = GetNums(txt.Text)
                txt.Select(txt.Text.Length, 0)
            End If
        End If
    End Sub

    Private Function GetNums(strIn As String) As String
        Dim nums As String = ""
        For Each c As Char In strIn
            If IsNumeric(c) Then nums &= c
        Next
        Return nums
    End Function

    Private Function GetDbDate(dt As DateTimePicker) As String
        Return dt.Value.Year.ToString & "-" & Strings.Right("0" & dt.Value.Month.ToString, 2) & "-" & Strings.Right("0" & dt.Value.Day.ToString, 2)
    End Function

End Class
