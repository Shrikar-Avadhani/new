﻿Public Class Home
    Inherits System.Web.UI.Page
    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cc.connect()
        cc.cmd.CommandText = "SELECT * FROM tblNews"
        cc.cmd.Connection = cc.cnn
        cc.dr = cc.cmd.ExecuteReader()
        If cc.dr.HasRows Then
            While cc.dr.Read()
                News.InnerText = News.InnerText + " " + cc.dr.Item(0) + " : " + cc.dr.Item(1) + ";"

            End While

        End If

    End Sub

End Class