Public Class AdminProfile
    Inherits System.Web.UI.Page
    Dim cc As New connectionClass

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If IsPostBack Then
            cc.connect()
            cc.cmd.CommandText = "UPDATE tblAdmin SET Name = '" + Name.Value + "', Mobile_No = '" + Mobile.Value + "', Email = '" + Email.Value + "', Address = '" + Address.Value + "', Username = '" + Username.Value + "', Password = '" + Password.Value + "' WHERE Username = '" + Session("AdminName") + "' "
            cc.cmd.Connection = cc.cnn
            cc.cmd.ExecuteNonQuery()
            cc.cnn.Close()
        End If

        cc.connect()
        cc.cmd.CommandText = "SELECT * FROM tblAdmin WHERE Username='" + Session("AdminName") + "' COLLATE Latin1_General_CS_AS"
        cc.cmd.Connection = cc.cnn
        cc.dr = cc.cmd.ExecuteReader()

        If cc.dr.HasRows Then
            cc.dr.Read()
            Name.Value = cc.dr.Item(0)
            Mobile.Value = cc.dr.Item(1)
            Email.Value = cc.dr.Item(2)
            Address.Value = cc.dr.Item(3)
            Username.Value = cc.dr.Item(4)
            Password.Value = cc.dr.Item(5)
            Aadhar.Value = cc.dr.Item(6)
        End If
        cc.dr.Close()
        cc.cnn.Close()



        Name.Disabled = True
        Mobile.Disabled = True
        Address.Disabled = True
        Email.Disabled = True
        Aadhar.Disabled = True
        Username.Disabled = True
        Password.Disabled = True

    End Sub

    Public Sub EditN()
        Name.Disabled = False
        'cc.connect()
        'cc.cmd.CommandText = "SELECT Password FROM tblAdmin WHERE Username='" + Session("AdminName") + "' COLLATE Latin1_General_CS_AS"
        'cc.cmd.Connection = cc.cnn
        'cc.dr = cc.cmd.ExecuteReader()
        'cc.cnn.Close()
    End Sub
    Public Sub EditM()
        Mobile.Disabled = False
        'cc.connect()
        'cc.cmd.CommandText = "SELECT Password FROM tblAdmin WHERE Username='" + Session("AdminName") + "' COLLATE Latin1_General_CS_AS"
        'cc.cmd.Connection = cc.cnn
        'cc.dr = cc.cmd.ExecuteReader()
        'cc.cnn.Close()
    End Sub

    Public Sub EditA()
        Address.Disabled = False
        'cc.connect()
        'cc.cmd.CommandText = "SELECT Password FROM tblAdmin WHERE Username='" + Session("AdminName") + "' COLLATE Latin1_General_CS_AS"
        'cc.cmd.Connection = cc.cnn
        'cc.dr = cc.cmd.ExecuteReader()
        'cc.cnn.Close()
    End Sub

    Public Sub EditE()
        Email.Disabled = False
        'cc.connect()
        'cc.cmd.CommandText = "SELECT Password FROM tblAdmin WHERE Username='" + Session("AdminName") + "' COLLATE Latin1_General_CS_AS"
        'cc.cmd.Connection = cc.cnn
        'cc.dr = cc.cmd.ExecuteReader()
        'cc.cnn.Close()
    End Sub

    Public Sub EditU()
        Username.Disabled = False
        'cc.connect()
        'cc.cmd.CommandText = "SELECT Password FROM tblAdmin WHERE Username='" + Session("AdminName") + "' COLLATE Latin1_General_CS_AS"
        'cc.cmd.Connection = cc.cnn
        'cc.dr = cc.cmd.ExecuteReader()
        'cc.cnn.Close()
    End Sub

    Public Sub EditP()
        Password.Disabled = False
        cc.connect()
        cc.cmd.CommandText = "SELECT Password FROM tblAdmin WHERE Username='" + Session("AdminName") + "' COLLATE Latin1_General_CS_AS"
        cc.cmd.Connection = cc.cnn
        cc.dr = cc.cmd.ExecuteReader()

        If cc.dr.HasRows Then
            cc.dr.Read()
            Password.Value = cc.dr.Item(0)
        End If
        cc.dr.Close()
        cc.cnn.Close()
    End Sub

    Public Sub Update()
        cc.connect()
        cc.cmd.CommandText = "UPDATE tblAdmin SET Name = '" + Name.Value + "', Mobile_No = '" + Mobile.Value + "', Email = '" + Email.Value + "', Address = '" + Address.Value + "', Username = '" + Username.Value + "', Password = '" + Password.Value + "' WHERE Username = '" + Session("AdminName") + "' "
        cc.cmd.Connection = cc.cnn
        cc.cmd.ExecuteNonQuery()
        cc.cnn.Close()
        MsgBox("Updated")
    End Sub
End Class