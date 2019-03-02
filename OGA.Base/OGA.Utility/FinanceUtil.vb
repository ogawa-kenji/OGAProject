Imports OGA.BI

Public Class FinanceUtil
    Private PROFILE As String = "http://stocks.finance.yahoo.co.jp/stocks/profile/?code={0}"
    Private HISTORY As String = "http://info.finance.yahoo.co.jp/history/?code={0}&sy={1}&sm={2}&sd={3}&ey={4}&em={5}&ed={6}&tm=d"

    Public Function Get企業情報(証券コード As Decimal) As List(Of 企業情報)
        Dim result As New List(Of 企業情報)
        Dim info As New 企業情報
        Dim url As String = String.Format(PROFILE, 証券コード)
        Dim xdoc As XDocument
        Dim hu As New HtmlUtil
        Try
            xdoc = hu.ParseHtml(hu.GetHtml(url))
        Catch ex As Exception
            xdoc = hu.ParseHtml(hu.GetHtml(url))
        End Try
        Dim ns = xdoc.Root.Name.Namespace
        Dim q = From d In xdoc.Descendants(ns + "tr")
        Dim stockCd As Decimal
        If Decimal.TryParse((From c In xdoc.Descendants(ns + "dt") Select c).FirstOrDefault.Value, stockCd) = False Then
            Return result
        End If
        info.証券コード = stockCd
        info.企業名 = (From c In xdoc.Descendants(ns + "h1") Select c).FirstOrDefault.Value
        For Each r In q
            For Each elm In r.Elements()
                If elm.Name = "th" Then
                    Dim value As String = elm.Parent.Elements("td").ElementAt(0).Value
                    Select Case elm.Value
                        Case "特色"
                            info.特色 = value
                        Case "連結事業"
                            info.連結事業 = value
                        Case "本社所在地"
                            info.本社所在地 = value
                        Case "業種分類"
                            info.業種分類 = value
                        Case "設立年月日"
                            If String.IsNullOrEmpty(value.Replace("-", "")) Then
                                info.設立年月日 = Nothing
                            Else
                                info.設立年月日 = Convert.ToDateTime(value)
                            End If
                        Case "市場名"
                            info.市場名 = value
                        Case "上場年月日"
                            If String.IsNullOrEmpty(value.Replace("-", "")) Then
                                info.上場年月日 = Nothing
                            Else
                                info.上場年月日 = Convert.ToDateTime(value)
                            End If
                        Case "決算"
                            If String.IsNullOrEmpty(value) Then
                                info.決算 = Nothing
                            Else
                                info.決算 = Convert.ToDecimal(value.Substring(0, 2).Replace("月", ""))
                            End If
                        Case "単元株数"
                            If String.IsNullOrEmpty(value.Replace("単元株制度なし", "")) Then
                                info.単元株数 = Nothing
                            Else
                                info.単元株数 = Convert.ToDecimal(value.Replace("単元株制度なし", "").Replace("株", ""))
                            End If
                        Case "従業員数（単独）"
                            If String.IsNullOrEmpty(value.Replace("人", "").Replace("-", "")) Then
                                info.従業員数_単独 = Nothing
                            Else
                                info.従業員数_単独 = Convert.ToDecimal(value.Replace("人", "").Replace("-", ""))
                            End If
                        Case "従業員数（連結）"
                            If String.IsNullOrEmpty(value.Replace("人", "").Replace("-", "")) Then
                                info.従業員数_連結 = Nothing
                            Else
                                info.従業員数_連結 = Convert.ToDecimal(value.Replace("人", "").Replace("-", ""))
                            End If
                        Case "平均年収"
                            value = elm.Parent.Elements("td").ElementAt(1).Value
                            If String.IsNullOrEmpty(value.Replace("千円", "").Replace("-", "")) Then
                                info.平均年収 = Nothing
                            Else
                                info.平均年収 = Convert.ToDecimal(value.Replace("千円", "").Replace("-", "")) * 1000
                            End If
                    End Select
                End If
            Next
        Next
        If info.証券コード <> 0 Then
            result.Add(info)
        End If
        Return result
    End Function

    Public Function Get株価(証券コード As Decimal, 開始日 As DateTime, 終了日 As DateTime) As List(Of 株価)
        Dim result As New List(Of 株価)
        Dim url As String = String.Format(HISTORY, 証券コード, 開始日.Year, 開始日.Month, 開始日.Day,
                                                               終了日.Year, 終了日.Month, 終了日.Day)
        '' 再帰呼び出しで株価を設定
        Set株価(url, result)
        Return result
    End Function

    Public Sub Set株価(url As String, list As List(Of 株価))
        Dim info As New 株価
        Dim xdoc As XDocument
        Dim hu As New HtmlUtil
        Try
            xdoc = hu.ParseHtml(hu.GetHtml(url))
        Catch ex As Exception
            xdoc = hu.ParseHtml(hu.GetHtml(url))
        End Try

        Dim ns = xdoc.Root.Name.Namespace

        Dim nextUrl As String = ""
        Dim q = From d In xdoc.Descendants(ns + "ul")
                Where d.Attribute("class") = "ymuiPagingBottom clearFix"
                Select d

        For Each r In q.Descendants("a")
            If r.Value = "次へ" Then
                nextUrl = r.Attribute("href").Value
            End If
        Next

        Dim stockCd As Decimal = (From c In xdoc.Descendants(ns + "dt") Select c).FirstOrDefault.Value
        Dim company As String = (From c In xdoc.Descendants(ns + "h1") Select c).FirstOrDefault.Value
        Dim prices = From d In xdoc.Descendants(ns + "table")
                     Where d.Attribute("class") = "boardFin yjSt marB6"
                     Select d.Descendants(ns + "tr")

        For Each price In prices
            For Each r In price
                If r.Elements() Is Nothing Then
                    Continue For
                End If
                If r.Elements().First().Value = "日付" Then
                    Continue For
                End If
                If Decimal.TryParse(r.Elements().ElementAt(1).Value, Nothing) = False Then
                    Continue For
                End If
                info = New 株価
                info.証券コード = stockCd
                info.企業名 = company
                info.日付 = Convert.ToDateTime(r.Elements().ElementAt(0).Value)
                info.始値 = Convert.ToDecimal(r.Elements().ElementAt(1).Value)
                info.高値 = Convert.ToDecimal(r.Elements().ElementAt(2).Value)
                info.安値 = Convert.ToDecimal(r.Elements().ElementAt(3).Value)
                info.終値 = Convert.ToDecimal(r.Elements().ElementAt(4).Value)
                info.出来高 = Convert.ToDecimal(r.Elements().ElementAt(5).Value)
                info.調整後終値 = Convert.ToDecimal(r.Elements().ElementAt(6).Value)
                list.Add(info)
            Next
        Next

        If nextUrl = "" Then
            Return
        Else
            Set株価(nextUrl, list)
        End If
    End Sub

End Class
