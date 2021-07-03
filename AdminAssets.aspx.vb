Public Class AdminAssets
    Inherits System.Web.UI.Page

    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub Add()
        cc.connect()
        cc.cmd.CommandText = "INSERT INTO tblAssets VALUES ('" + Assets.Value + "', " + Total.Value + ", " + In_Use.Value + ", " + Active.Value + ", " + InActive.Value + ", '" + Username.Value + "')"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()
        cc.cnn.Close()
        Response.Redirect("AdminAssets.aspx")
    End Sub

End Class