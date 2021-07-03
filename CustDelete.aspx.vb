Public Class CustDelete
    Inherits System.Web.UI.Page
    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub Del()
        cc.connect()
        cc.cmd.CommandText = "INSERT INTO tblDelCust SELECT Name, Address, Email, Mobile_No, Aadhar_No, RR_No, Customer_No, Sub_Division, Location_Code, Meter_Code, Username FROM tblSignUp WHERE (Username = '" + Username.Value + "')"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()

        cc.cmd.CommandText = "DELETE FROM tblSignUp WHERE (Username = '" + Username.Value + "')"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()
        cc.cnn.Close()
        MsgBox("Record deleted Successfully")
        Response.Redirect("CustDelete.aspx")
    End Sub

End Class