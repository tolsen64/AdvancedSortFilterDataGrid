Public Class ColumnFilterChangedEventArgs
    Inherits EventArgs

    Public Sub New(ColumnName As String, RowFilter As String)
        Me.ColumnName = ColumnName
        Me.RowFilter = RowFilter
    End Sub

    Private m_ColumnName As String = ""
    Public Property ColumnName As String
        Get
            Return m_ColumnName
        End Get
        Private Set(value As String)
            m_ColumnName = value
        End Set
    End Property

    Private m_RowFilter As String = ""
    Public Property RowFilter As String
        Get
            Return m_RowFilter
        End Get
        Private Set(value As String)
            m_RowFilter = value
        End Set
    End Property

End Class
