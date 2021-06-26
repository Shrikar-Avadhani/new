Public Class AdminNews
    Inherits System.Web.UI.Page
    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Name.Value = Session("AdminName")
    End Sub

    Public Sub Submit()
        Dim d As Date
        d = Now()
        cc.connect()
        cc.cmd.CommandText = "INSERT INTO tblNews VALUES ('" + NTitle.Value + "', '" + News.Value + "', '" + Session("AdminName") + "', '" + d + "')"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()

        If (MsgBox("The news feed has been updated")) Then
            Response.Redirect("AdminHome.aspx")
        End If
    End Sub

End Class