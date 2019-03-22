Imports System.Transactions
Imports OGA.BI
Imports OGA.DA
Imports OGA.DA.Base

Public Class UtilityBL

    Public Sub Update企業情報()
        Dim result As (dbresult As DBResult, list As List(Of ターゲット))
        Using da As New TargetDA
            result = da.Selectターゲット()
            If result.dbresult.ReturnCd <> DBResult.ReturnCds._NORMAL Then
                Return
            End If
        End Using
        Dim ut As New Utility.FinanceUtil
        Dim list As New List(Of 企業情報)
        Dim listAdd As New List(Of 企業情報)
        For Each r In result.list
            list = ut.Get企業情報(r.証券コード)
            If list.Count > 0 Then
                listAdd.Add(list(0))
            End If
        Next
        Using scope As TransactionScope =
                    New TransactionScope(scopeOption:=TransactionScopeOption.Required, scopeTimeout:=New TimeSpan(0, 30, 0))
            Using da As New UtilityDA
                Dim dbresult = da.Update企業情報(listAdd)
                If dbresult.ReturnCd = DBResult.ReturnCds._NORMAL Then
                    scope.Complete()
                End If
            End Using
        End Using
    End Sub

    Public Function Update株価(prices As List(Of 株価)) As Boolean
        Using scope As TransactionScope =
                    New TransactionScope(scopeOption:=TransactionScopeOption.Required, scopeTimeout:=New TimeSpan(0, 30, 0))
            Using da As New UtilityDA
                Dim dbresult = da.Update株価(prices)
                If dbresult.ReturnCd = DBResult.ReturnCds._NORMAL Then
                    scope.Complete()
                Else
                    Return False
                End If
            End Using
        End Using
        Return True
    End Function


    Public Sub Update企業情報(証券コード As Decimal)
        Dim ut As New Utility.FinanceUtil
        Dim list As New List(Of 企業情報)
        Dim listAdd As New List(Of 企業情報)
        list = ut.Get企業情報(証券コード)
        If list.Count > 0 Then
            listAdd.Add(list(0))
        End If
        Using scope As TransactionScope =
                    New TransactionScope(scopeOption:=TransactionScopeOption.Required, scopeTimeout:=New TimeSpan(0, 30, 0))
            Using da As New UtilityDA
                Dim dbresult = da.Update企業情報(listAdd)
                If dbresult.ReturnCd = DBResult.ReturnCds._NORMAL Then
                    scope.Complete()
                End If
            End Using
        End Using
    End Sub

    Public Sub Delete情報(証券コード As Decimal)
        Dim ut As New Utility.FinanceUtil
        Using scope As TransactionScope =
                    New TransactionScope(scopeOption:=TransactionScopeOption.Required, scopeTimeout:=New TimeSpan(0, 30, 0))
            Using da As New UtilityDA
                Dim dbresult = da.Delete情報(証券コード)
                If dbresult.ReturnCd = DBResult.ReturnCds._NORMAL Then
                    scope.Complete()
                End If
            End Using
        End Using
    End Sub

End Class
