Imports System.Net.Mail
Imports System.Net
Public Class AdminAssignDetails
    Inherits System.Web.UI.Page

    Dim cc As New connectionClass
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MobileNo.Value = Session("AssignMobNo")
    End Sub

    Public Sub Assign()
        cc.connect()
        cc.cmd.CommandText = "SELECT Name, Email FROM tblNewConnection WHERE Mobile_No = '" + MobileNo.Value + "'"
        cc.cmd.Connection = cc.cnn
        cc.dr = cc.cmd.ExecuteReader()

        If cc.dr.HasRows Then
            cc.dr.Read()
            Dim mm As New MailMessage()
            mm.From = New MailAddress("udupieb@gmail.com")
            mm.To.Add(cc.dr.Item(1))
            mm.Subject = "Connection Details Assigned"
            mm.Body = "Hello " & cc.dr.Item(0) & vbLf & " We have assigned you your new connection details. You can check it in the status tab by entering your registered mobile no. , also make sure that you sign up to avail the various online services available."

            Dim smtp As New SmtpClient("smtp.gmail.com")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New System.Net.NetworkCredential("udupieb@gmail.com", "iapiktlufgoykpzi")
            smtp.Send(mm)
            MsgBox("mail sent")
            cc.dr.Close()
            cc.cnn.Close()
        End If

        Dim y As String
        y = "Yes"
        cc.connect()
        cc.cmd.CommandText = "INSERT INTO tblConnectionDetail VALUES (" + MobileNo.Value + ", " + CustNo.Value + ", '" + RRno.Value + "', " + LocCode.Value + ", '" + MtrCode.Value + "', '" + SubDivi.Value + "')"
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()
        cc.cmd.CommandText = "UPDATE tblNewConnection SET Assign = '" + y + "' WHERE Mobile_No = " + MobileNo.Value + " "
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()
        cc.cnn.Close()
        If (MsgBox("Record Inserted Successfully")) Then
            Response.Redirect("AdminHome.aspx")
        End If
    End Sub

End Class