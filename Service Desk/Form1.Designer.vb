<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLodgement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLodgement))
        Me.lblName = New System.Windows.Forms.Label
        Me.lblUsername = New System.Windows.Forms.Label
        Me.txtUsername = New System.Windows.Forms.TextBox
        Me.grpUser = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lstUserGroups = New System.Windows.Forms.ListBox
        Me.txtUserFullname = New System.Windows.Forms.TextBox
        Me.txtUserDomain = New System.Windows.Forms.TextBox
        Me.lblDomain = New System.Windows.Forms.Label
        Me.txtCompany = New System.Windows.Forms.TextBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lstIPAddresses = New System.Windows.Forms.ListBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtADSitename = New System.Windows.Forms.TextBox
        Me.txtLogonServer = New System.Windows.Forms.TextBox
        Me.lstComputerGroups = New System.Windows.Forms.ListBox
        Me.txtOS = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblOS = New System.Windows.Forms.Label
        Me.txtComputername = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtComputerDomain = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpDescription = New System.Windows.Forms.GroupBox
        Me.txtProblemDescription = New System.Windows.Forms.TextBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.txtSubject = New System.Windows.Forms.TextBox
        Me.lblSubject = New System.Windows.Forms.Label
        Me.picEmpired = New System.Windows.Forms.PictureBox
        Me.btnSubmit = New System.Windows.Forms.Button
        Me.lblStatus = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtMobile = New System.Windows.Forms.TextBox
        Me.grpUser.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpDescription.SuspendLayout()
        CType(Me.picEmpired, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 19)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(6, 71)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 4
        Me.lblUsername.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(69, 68)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(186, 20)
        Me.txtUsername.TabIndex = 5
        '
        'grpUser
        '
        Me.grpUser.Controls.Add(Me.Label5)
        Me.grpUser.Controls.Add(Me.lstUserGroups)
        Me.grpUser.Controls.Add(Me.txtUserFullname)
        Me.grpUser.Controls.Add(Me.txtUserDomain)
        Me.grpUser.Controls.Add(Me.lblDomain)
        Me.grpUser.Controls.Add(Me.lblName)
        Me.grpUser.Controls.Add(Me.txtCompany)
        Me.grpUser.Controls.Add(Me.txtMobile)
        Me.grpUser.Controls.Add(Me.txtPhone)
        Me.grpUser.Controls.Add(Me.Label10)
        Me.grpUser.Controls.Add(Me.Label9)
        Me.grpUser.Controls.Add(Me.Label8)
        Me.grpUser.Controls.Add(Me.txtUsername)
        Me.grpUser.Controls.Add(Me.lblUsername)
        Me.grpUser.Location = New System.Drawing.Point(12, 12)
        Me.grpUser.Name = "grpUser"
        Me.grpUser.Size = New System.Drawing.Size(261, 320)
        Me.grpUser.TabIndex = 2
        Me.grpUser.TabStop = False
        Me.grpUser.Text = "User Info"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Group(s)"
        '
        'lstUserGroups
        '
        Me.lstUserGroups.FormattingEnabled = True
        Me.lstUserGroups.Location = New System.Drawing.Point(72, 176)
        Me.lstUserGroups.Name = "lstUserGroups"
        Me.lstUserGroups.Size = New System.Drawing.Size(183, 134)
        Me.lstUserGroups.Sorted = True
        Me.lstUserGroups.TabIndex = 13
        '
        'txtUserFullname
        '
        Me.txtUserFullname.Location = New System.Drawing.Point(69, 16)
        Me.txtUserFullname.Name = "txtUserFullname"
        Me.txtUserFullname.Size = New System.Drawing.Size(186, 20)
        Me.txtUserFullname.TabIndex = 1
        '
        'txtUserDomain
        '
        Me.txtUserDomain.Location = New System.Drawing.Point(69, 42)
        Me.txtUserDomain.Name = "txtUserDomain"
        Me.txtUserDomain.Size = New System.Drawing.Size(186, 20)
        Me.txtUserDomain.TabIndex = 3
        '
        'lblDomain
        '
        Me.lblDomain.AutoSize = True
        Me.lblDomain.Location = New System.Drawing.Point(6, 45)
        Me.lblDomain.Name = "lblDomain"
        Me.lblDomain.Size = New System.Drawing.Size(43, 13)
        Me.lblDomain.TabIndex = 2
        Me.lblDomain.Text = "Domain"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(69, 94)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(186, 20)
        Me.txtCompany.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(69, 124)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(186, 20)
        Me.txtPhone.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Company"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Phone"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstIPAddresses)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtADSitename)
        Me.GroupBox1.Controls.Add(Me.txtLogonServer)
        Me.GroupBox1.Controls.Add(Me.lstComputerGroups)
        Me.GroupBox1.Controls.Add(Me.txtOS)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblOS)
        Me.GroupBox1.Controls.Add(Me.txtComputername)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtComputerDomain)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(279, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 320)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Computer Info"
        '
        'lstIPAddresses
        '
        Me.lstIPAddresses.FormattingEnabled = True
        Me.lstIPAddresses.Location = New System.Drawing.Point(87, 94)
        Me.lstIPAddresses.Name = "lstIPAddresses"
        Me.lstIPAddresses.Size = New System.Drawing.Size(233, 69)
        Me.lstIPAddresses.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Group(s)"
        '
        'txtADSitename
        '
        Me.txtADSitename.Location = New System.Drawing.Point(87, 202)
        Me.txtADSitename.Name = "txtADSitename"
        Me.txtADSitename.Size = New System.Drawing.Size(233, 20)
        Me.txtADSitename.TabIndex = 11
        '
        'txtLogonServer
        '
        Me.txtLogonServer.Location = New System.Drawing.Point(87, 171)
        Me.txtLogonServer.Name = "txtLogonServer"
        Me.txtLogonServer.Size = New System.Drawing.Size(233, 20)
        Me.txtLogonServer.TabIndex = 9
        '
        'lstComputerGroups
        '
        Me.lstComputerGroups.FormattingEnabled = True
        Me.lstComputerGroups.Location = New System.Drawing.Point(88, 228)
        Me.lstComputerGroups.Name = "lstComputerGroups"
        Me.lstComputerGroups.Size = New System.Drawing.Size(232, 82)
        Me.lstComputerGroups.Sorted = True
        Me.lstComputerGroups.TabIndex = 13
        '
        'txtOS
        '
        Me.txtOS.Location = New System.Drawing.Point(87, 68)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.Size = New System.Drawing.Size(232, 20)
        Me.txtOS.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "AD Site Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Logon Server"
        '
        'lblOS
        '
        Me.lblOS.AutoSize = True
        Me.lblOS.Location = New System.Drawing.Point(9, 73)
        Me.lblOS.Name = "lblOS"
        Me.lblOS.Size = New System.Drawing.Size(27, 13)
        Me.lblOS.TabIndex = 4
        Me.lblOS.Text = "O/S"
        '
        'txtComputername
        '
        Me.txtComputername.Location = New System.Drawing.Point(87, 14)
        Me.txtComputername.Name = "txtComputername"
        Me.txtComputername.Size = New System.Drawing.Size(232, 20)
        Me.txtComputername.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "IP Address(es)"
        '
        'txtComputerDomain
        '
        Me.txtComputerDomain.Location = New System.Drawing.Point(87, 43)
        Me.txtComputerDomain.Name = "txtComputerDomain"
        Me.txtComputerDomain.Size = New System.Drawing.Size(232, 20)
        Me.txtComputerDomain.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Domain"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'grpDescription
        '
        Me.grpDescription.Controls.Add(Me.txtProblemDescription)
        Me.grpDescription.Controls.Add(Me.lblDescription)
        Me.grpDescription.Controls.Add(Me.txtSubject)
        Me.grpDescription.Controls.Add(Me.lblSubject)
        Me.grpDescription.Location = New System.Drawing.Point(12, 355)
        Me.grpDescription.Name = "grpDescription"
        Me.grpDescription.Size = New System.Drawing.Size(757, 217)
        Me.grpDescription.TabIndex = 0
        Me.grpDescription.TabStop = False
        Me.grpDescription.Text = "Problem Info"
        '
        'txtProblemDescription
        '
        Me.txtProblemDescription.Location = New System.Drawing.Point(69, 45)
        Me.txtProblemDescription.Multiline = True
        Me.txtProblemDescription.Name = "txtProblemDescription"
        Me.txtProblemDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtProblemDescription.Size = New System.Drawing.Size(682, 166)
        Me.txtProblemDescription.TabIndex = 2
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(9, 45)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(69, 16)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(682, 20)
        Me.txtSubject.TabIndex = 1
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(8, 20)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(43, 13)
        Me.lblSubject.TabIndex = 0
        Me.lblSubject.Text = "Subject"
        '
        'picEmpired
        '
        Me.picEmpired.Image = CType(resources.GetObject("picEmpired.Image"), System.Drawing.Image)
        Me.picEmpired.Location = New System.Drawing.Point(637, 7)
        Me.picEmpired.Name = "picEmpired"
        Me.picEmpired.Size = New System.Drawing.Size(136, 64)
        Me.picEmpired.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picEmpired.TabIndex = 5
        Me.picEmpired.TabStop = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(674, 577)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(95, 28)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(12, 588)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(618, 17)
        Me.lblStatus.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 154)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Mobile"
        '
        'txtMobile
        '
        Me.txtMobile.Location = New System.Drawing.Point(69, 151)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(186, 20)
        Me.txtMobile.TabIndex = 11
        '
        'frmLodgement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 618)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.picEmpired)
        Me.Controls.Add(Me.grpDescription)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmLodgement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empired Service Desk - Problem lodgement"
        Me.grpUser.ResumeLayout(False)
        Me.grpUser.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpDescription.ResumeLayout(False)
        Me.grpDescription.PerformLayout()
        CType(Me.picEmpired, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents grpUser As System.Windows.Forms.GroupBox
    Friend WithEvents txtUserFullname As System.Windows.Forms.TextBox
    Friend WithEvents txtUserDomain As System.Windows.Forms.TextBox
    Friend WithEvents lblDomain As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtComputername As System.Windows.Forms.TextBox
    Friend WithEvents txtComputerDomain As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpDescription As System.Windows.Forms.GroupBox
    Friend WithEvents picEmpired As System.Windows.Forms.PictureBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents lblSubject As System.Windows.Forms.Label
    Friend WithEvents txtProblemDescription As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtOS As System.Windows.Forms.TextBox
    Friend WithEvents lblOS As System.Windows.Forms.Label
    Friend WithEvents txtLogonServer As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstUserGroups As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstComputerGroups As System.Windows.Forms.ListBox
    Friend WithEvents lstIPAddresses As System.Windows.Forms.ListBox
    Friend WithEvents txtADSitename As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label

End Class
