Public Class AdminHome
    Inherits System.Web.UI.Page
    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim n As String
        n = "No"
        cc.connect()
        cc.cmd.CommandText = "SELECT Mobile_No FROM tblNewConnection WHERE Assign='" + n + "' COLLATE Latin1_General_CS_AS"
        cc.cmd.Connection = cc.cnn
        cc.dr = cc.cmd.ExecuteReader()

        If cc.dr.HasRows Then
            cc.dr.Read()
            Session("AssignMobNo") = cc.dr.Item(0)
            Session("Notify") = 0
            cc.dr.Close()
            cc.cnn.Close()
            If IsPostBack Then

            End If
            Select Case MsgBox("You have connections to assign, would you like to assign them now??", MsgBoxStyle.YesNo, "Assign Connection")
                Case MsgBoxResult.Yes
                    Response.Redirect("AdminAssignDetails.aspx")
            End Select
        End If
        cc.dr.Close()
        cc.cnn.Close()
    End Sub

End Class