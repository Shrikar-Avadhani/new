Public Class AdminDelete
    Inherits System.Web.UI.Page
    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub Del()
        cc.connect()
        cc.cmd.CommandText = "INSERT INTO tblDelAdmin SELECT Name, Mobile_No, Email, Address, Username, Aadhar FROM tblAdmin WHERE (Username = '" + Username.Value + "')"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()

        cc.cmd.CommandText = "DELETE FROM tblAdmin WHERE (Username = '" + Username.Value + "')"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()

        MsgBox("Record deleted Successfully")
        Response.Redirect("AdminDelete.aspx")
    End Sub

End Class