Public Class GenerateBill1
    Inherits System.Web.UI.Page
    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub Updated()
        Dim y As String
        y = "Yes"
        cc.connect()
        cc.cmd.CommandText = "UPDATE tblBill SET Bill = '" + y + "'  WHERE (Customer_No = '" + Session("GenBill") + "')"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()
        cc.cmd.CommandText = "UPDATE tblSignUp SET Bill = '" + y + "'  WHERE (Customer_No = '" + Session("GenBill") + "')"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()
        cc.cnn.Close()
    End Sub
End Class