Imports System.Globalization

Class ColumnNameToToolTipConverter
    Implements IValueConverter

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.Convert
        If TypeOf value Is String Then
            Select Case value.ToString
                Case "LastUpdated" : Return "The date the SO was last updated."
                Case "Created" : Return "The date the SO was created."
                Case "Age" : Return "The age of the SO in days."
                Case "Due" : Return "The date the SO must be completed and closed."
                Case "Closed" : Return "The date the SO was closed or canceled."
                Case "Case" : Return "The case from which the SO was created."
                Case "CaseCreated" : Return "The date the case was created."
                Case "CaseDue" : Return "The date the case must be completed and closed."
                Case "CaseAge" : Return "The age of the case in days."
                Case "DisDate" : Return "The district due date, aka plan complete date."
                Case "PriDate" : Return "The primary task date."
                Case "SchedDate" : Return "Same as MinSchedDate."
                Case "Start" : Return "The date the project becomes active."
                Case "MinSchedDate" : Return "The earliest date a secondary task is scheduled."
                Case "MaxSchedDate" : Return "The latest date a secondary task is scheduled."
                Case "Rmt" : Return "All work completed remotely."
                Case Else : Return Nothing
            End Select
        Else
            Return Nothing
        End If
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
        Throw New NotImplementedException()
    End Function
End Class