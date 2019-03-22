Imports System.Transactions
Imports OGA.BI
Imports OGA.DA

Public Class TargetBL
    Inherits BL.Base.BLBase

    Public Function CreateTable() As Boolean
        Using scope As TransactionScope =
                    New TransactionScope(scopeOption:=TransactionScopeOption.Required, scopeTimeout:=New TimeSpan(0, 30, 0))
            Dim da As New TargetDA
            If da.CreateTable() Then
                scope.Complete()
                Return True
            End If
        End Using
        Return False
    End Function

    Public Function Getターゲット() As List(Of ターゲット)
        Using da As New TargetDA
            Return da.Selectターゲット().Item2
        End Using
    End Function

    Public Function Insertターゲット(targets As List(Of ターゲット)) As Boolean
        Using scope As TransactionScope =
                    New TransactionScope(scopeOption:=TransactionScopeOption.Required, scopeTimeout:=New TimeSpan(0, 30, 0))
            Dim da As New TargetDA
            If da.Deleteターゲット(targets).ReturnCd <> OGA.DA.Base.DBResult.ReturnCds._NORMAL Then
                Return False
            End If
            If da.Insertターゲット(targets).ReturnCd <> OGA.DA.Base.DBResult.ReturnCds._NORMAL Then
                Return False
            End If
            scope.Complete()
        End Using
        Return True
    End Function

End Class
