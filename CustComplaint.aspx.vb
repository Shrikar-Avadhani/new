﻿Public Class CustComplaint
    Inherits System.Web.UI.Page
    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub Submit()
        Dim d As Date
        d = Now()
        cc.connect()
        cc.cmd.CommandText = "INSERT INTO tblComplaint (Complaint, Complaint_Date, Cust_Name) VALUES ('" + Complaint.Value + "', '" + d + "', '" + Session("CustName") + "')"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()


        If (MsgBox("Your complaint has been registered")) Then
            Response.Redirect("CustomerHome.aspx")
        End If
    End Sub
End Class