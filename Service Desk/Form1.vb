Imports System.DirectoryServices
Imports System.Net

Public Class frmLodgement

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim RegKey As Microsoft.Win32.RegistryKey

        Cursor.Current = Cursors.WaitCursor

        Me.Refresh()

        txtUserFullname.Text = My.User.Name.ToString
        txtUsername.Text = Environment.GetEnvironmentVariable("USERNAME").ToString

        GetUserInfo()

        txtUserDomain.Text = Environment.GetEnvironmentVariable("USERDOMAIN").ToString
        txtComputername.Text = Environment.GetEnvironmentVariable("COMPUTERNAME").ToString

        GetComputerInfo()

        RegKey = My.Computer.Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\Tcpip\Parameters")
        txtComputerDomain.Text = RegKey.GetValue("NV Domain")
        txtOS.Text = My.Computer.Info.OSFullName.ToString

        GetIPAddress()

        txtLogonServer.Text = Replace(Environment.GetEnvironmentVariable("LOGONSERVER").ToString, "\\", "")

        GetSiteInfo()

        Console.WriteLine("Screens: " & Screen.AllScreens.Length)

        Cursor.Current = Cursors.Default
    End Sub

    Private Sub GetUserInfo()
        Dim strGivenName As String
        Dim strSurname As String

        ' get the root namespace
        Dim objRootDSE As New DirectoryEntry("LDAP://RootDSE")
        Dim objsearchRoot As DirectoryEntry = New DirectoryEntry("LDAP://" & objRootDSE.Properties("defaultNamingContext")(0).ToString()) ', Nothing, Nothing, AuthenticationTypes.Secure)

        Dim dsUser As DirectorySearcher = New DirectorySearcher(String.Format("(&(&(objectcategory=user)(objectclass=person))(sAMAccountName={0}))", txtUsername.Text))

        dsUser.PropertiesToLoad.Add("memberOf")
        dsUser.PropertiesToLoad.Add("telephoneNumber")
        dsUser.PropertiesToLoad.Add("mobile")
        dsUser.PropertiesToLoad.Add("company")

        Dim srcUser As SearchResultCollection = dsUser.FindAll()
        On Error Resume Next
        Me.Refresh()
        Dim de As DirectoryEntry = srcUser(0).GetDirectoryEntry
        strGivenName = de.Properties("givenName")(0).ToString
        strSurname = de.Properties("sn")(0).ToString
        txtUserFullname.Text = strGivenName & " " & strSurname

        ' Phone numbers
        Dim phoneCount As Int32 = de.Properties("telephoneNumber").Count()
        Dim dn As String
        Dim equalsIndex As Int32, commaIndex As Int32
        Dim phoneCounter As Int32

        For phoneCounter = 0 To phoneCount - 1
            dn = de.Properties("telephoneNumber")(phoneCounter)
            equalsIndex = dn.IndexOf("=", 1)
            commaIndex = dn.IndexOf(",", 1)
            If (-1 = equalsIndex) Then
                txtPhone.Text = dn
            Else
                txtPhone.Text = dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1)
            End If
        Next phoneCounter

        ' mobile numbers
        txtMobile.Text = de.Properties("mobile")(0).ToString

        ' Company
        txtCompany.Text = de.Properties("company")(0).ToString

        ' Groups
        Dim groupCount As Int32 = de.Properties("memberOf").Count()
        Dim groupCounter As Int32

        For groupCounter = 0 To groupCount - 1
            dn = de.Properties("memberOf")(groupCounter)
            equalsIndex = dn.IndexOf("=", 1)
            commaIndex = dn.IndexOf(",", 1)
            If (-1 = equalsIndex) Then
                Me.lstUserGroups.Items.Add(dn)
            Else
                Me.lstUserGroups.Items.Add(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1))
            End If
        Next groupCounter
    End Sub

    Private Sub GetComputerInfo()
        ' get the root namespace
        Dim objRootDSE As New DirectoryEntry("LDAP://RootDSE")
        Dim objsearchRoot As DirectoryEntry = New DirectoryEntry("LDAP://" & objRootDSE.Properties("defaultNamingContext")(0).ToString()) ', Nothing, Nothing, AuthenticationTypes.Secure)

        Dim dsComputer As DirectorySearcher = New DirectorySearcher(String.Format("(sAMAccountName={0})", txtComputername.Text & "$"))

        dsComputer.PropertiesToLoad.Add("memberOf")

        Dim srcComputer As SearchResultCollection = dsComputer.FindAll()
        Me.Refresh()
        Dim de As DirectoryEntry = srcComputer(0).GetDirectoryEntry

        Dim props() As String = {"tokenGroups"}
        de.RefreshCache(props)

        Dim propertyCount As Int32 = de.Properties("memberOf").Count()
        Dim dn As String
        Dim equalsIndex As Int32, commaIndex As Int32
        Dim propertyCounter As Int32

        For propertyCounter = 0 To propertyCount - 1
            dn = de.Properties("memberOf")(propertyCounter)
            equalsIndex = dn.IndexOf("=", 1)
            commaIndex = dn.IndexOf(",", 1)
            If (-1 = equalsIndex) Then
                Me.lstComputerGroups.Items.Add(dn)
            Else
                Me.lstComputerGroups.Items.Add(dn.Substring((equalsIndex + 1), (commaIndex - equalsIndex) - 1))
            End If
        Next propertyCounter
    End Sub

    Private Sub GetIPAddress()
        Dim ipEntry As IPHostEntry = Dns.GetHostEntry(Environment.MachineName)
        Dim IpAddr As IPAddress() = ipEntry.AddressList
        Dim i As Integer

        'A hostmachine can have more than one IP assigned 

        For i = 0 To IpAddr.Length - 1
            If Not IpAddr(i).ToString.Contains("%") Then
                lstIPAddresses.Items.Add(IpAddr(i).ToString())
            End If
        Next

    End Sub

    Private Sub GetSiteInfo()
        Dim strDcName As String
        Dim strSitename As String
        Dim strDCSitename As String
        Dim objADSysInfo As New ActiveDs.ADSystemInfo

        objADSysInfo = CreateObject("ADSystemInfo")

        txtADSitename.Text = objADSysInfo.SiteName.ToString

        strDcName = txtLogonServer.Text
        strSitename = txtADSitename.Text

        strDcSiteName = objADSysInfo.GetDCSiteName(strDcName)

        If UCase(strSiteName) = UCase(strDcSiteName) Then
            ' All OK.  The logon Server is in the same site as this computer
        Else
            lblStatus.Text = "The logon server is not in the same site as this computer."
        End If

    End Sub

End Class
