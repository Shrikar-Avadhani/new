Public Class Status
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Sub Show()
        Session("MobNo") = MobileNo.Value
        Response.Redirect("Status.aspx")
    End Sub

    Protected Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class