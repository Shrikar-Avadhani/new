Public Class AdminComplaints
    Inherits System.Web.UI.Page
    Dim cc As New connectionClass

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub Submit()
        Dim d As Date
        d = Now()
        cc.connect()
        cc.cmd.CommandText = "UPDATE tblComplaint SET Admin_Name = '" + Session("AdminName") + "', Reply = '" + Complaint_Reply.Value + "', Reply_date = '" + d + "'  WHERE Cust_Name = '" + Cust_Name.Value + "' AND Complaint_Date = '" + C_Date.Value + "'"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()
        cc.cnn.Close()

        If (MsgBox("Your complaint has been recorded")) Then
            Response.Redirect("AdminHome.aspx")
        End If
    End Sub

End Class