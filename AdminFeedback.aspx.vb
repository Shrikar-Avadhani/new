﻿Public Class AdminFeedback
    Inherits System.Web.UI.Page
    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Name.Value = Session("AdminName")
    End Sub

    Public Sub Submit()
        Dim d As Date
        d = Now()
        cc.connect()
        cc.cmd.CommandText = "INSERT INTO tblFeedback VALUES ('" + Name.Value + "', '" + Feedback.Value + "', '" + d + "')"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()

        If (MsgBox("Your feedback has been recorded")) Then
            Response.Redirect("AdminHome.aspx")
        End If
    End Sub

End Class