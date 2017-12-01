<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(61, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 20)
        Me.TextBox1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.Red
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(8, 403)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(221, 79)
        Me.ListBox1.TabIndex = 1
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.Black
        Me.ListBox2.ForeColor = System.Drawing.Color.Green
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"account.asp", "account.cfm", "account.html", "account.php", "acct_login", "adm.asp", "adm.cfm", "adm.html", "adm.php", "adm", "adm/admloginuser.asp", "adm/admloginuser.cfm", "adm/admloginuser.php", "adm/index.asp", "adm/index.cfm", "adm/index.html", "adm/index.php", "adm_auth.asp", "adm_auth.cfm", "adm_auth.php", "admin.asp", "admin.cfm", "admin.html", "admin.php", "admin", "admin/account.asp", "admin/account.cfm", "admin/account.html", "admin/account.php", "admin/admin.asp", "admin/admin.cfm", "admin/admin.html", "admin/admin.php", "admin/admin_login.asp", "admin/admin_login.cfm", "admin/admin_login.html", "admin/admin_login.php", "admin/adminLogin.asp", "admin/admin-login.asp", "admin/adminLogin.cfm", "admin/admin-login.cfm", "admin/adminLogin.html", "admin/admin-login.html", "admin/adminLogin.php", "admin/admin-login.php", "admin/controlpanel.asp", "admin/controlpanel.cfm", "admin/controlpanel.html", "admin/controlpanel.php", "admin/cp.asp", "admin/cp.cfm", "admin/cp.html", "admin/cp.php", "admin/home.asp", "admin/home.cfm", "admin/home.html", "admin/home.php", "admin/index.asp", "admin/index.cfm", "admin/index.html", "admin/index.php", "admin/login.asp", "admin/login.cfm", "admin/login.html", "admin/login.php", "admin_area", "admin_area/admin.asp", "admin_area/admin.cfm", "admin_area/admin.html", "admin_area/admin.php", "admin_area/index.asp", "admin_area/index.cfm", "admin_area/index.html", "admin_area/index.php", "admin_area/login.asp", "admin_area/login.cfm", "admin_area/login.html", "admin_area/login.php", "admin_login.asp", "admin_login.cfm", "admin_login.html", "admin_login.php", "admin1.asp", "admin1.html", "admin1.php", "admin1", "admin2.asp", "admin2.cfm", "admin2.html", "admin2.php", "admin2/index.asp", "admin2/index.cfm", "admin2/index.php", "admin2/login.asp", "admin2/login.cfm", "admin2/login.php", "admin4_account", "admin4_colon", "adminarea", "adminarea/admin.asp", "adminarea/admin.cfm", "adminarea/admin.html", "adminarea/admin.php", "adminarea/index.asp", "adminarea/index.cfm", "adminarea/index.html", "adminarea/index.php", "adminarea/login.asp", "adminarea/login.cfm", "adminarea/login.html", "adminarea/login.php", "admincontrol.asp", "admincontrol.cfm", "admincontrol.html", "admincontrol.php", "admincontrol/login.asp", "admincontrol/login.cfm", "admincontrol/login.html", "admincontrol/login.php", "admincp/index.asp", "admincp/index.cfm", "admincp/index.html", "admincp/login.asp", "admincp/login.cfm", "administer", "administr8.asp", "administr8.html", "administr8.php", "administr8", "administratie", "administration.html", "administration.php", "administration", "administrator.asp", "administrator.cfm", "administrator.html", "administrator.php", "administrator", "administrator/account.asp", "administrator/account.cfm", "administrator/account.html", "administrator/account.php", "administrator/index.asp", "administrator/index.cfm", "administrator/index.html", "administrator/index.php", "administrator/login.asp", "administrator/login.cfm", "administrator/login.html", "administrator/login.php", "administratoraccounts", "administratorlogin.asp", "administratorlogin.cfm", "administratorlogin.php", "administratorlogin", "administrators", "administrivia", "adminLogin.asp", "admin-login.asp", "adminLogin.cfm", "admin-login.cfm", "adminLogin.html", "admin-login.html", "adminLogin.php", "admin-login.php", "adminLogin", "adminpanel.asp", "adminpanel.cfm", "adminpanel.html", "adminpanel.php", "adminpro", "admins.asp", "admins.html", "admins.php", "admins", "AdminTools", "admloginuser.asp", "admloginuser.cfm", "admloginuser.php", "affiliate.asp", "affiliate.cfm", "affiliate.php", "autologin", "banneradmin", "bbadmin", "bb-admin", "bb-admin/admin.asp", "bb-admin/admin.cfm", "bb-admin/admin.html", "bb-admin/admin.php", "bb-admin/index.asp", "bb-admin/index.cfm", "bb-admin/index.html", "bb-admin/index.php", "bb-admin/login.asp", "bb-admin/login.cfm", "bb-admin/login.html", "bb-admin/login.php", "bigadmin", "blogindex", "cadmins", "ccp14admin", "cmsadmin", "controlpanel.asp", "controlpanel.cfm", "controlpanel.html", "controlpanel.php", "controlpanel", "cp.asp", "cp.cfm", "cp.html", "cp.php", "cPanel", "cpanel_file", "customer_login", "database_administration", "directadmin", "dir-login", "ezsqliteadmin", "fileadmin.asp", "fileadmin.html", "fileadmin.php", "fileadmin", "formslogin", "globes_admin", "home.asp", "home.cfm", "home.html", "home.php", "hpwebjetadmin", "Indy_admin", "instadmin", "irc-macadmin", "LiveUser_Admin", "login.asp", "login.cfm", "login.html", "login.php", "login_db", "login1", "loginflat", "login-redirect", "login-us", "logo_sysadmin", "Lotus_Domino_Admin", "macadmin", "manuallogin", "memberadmin.asp", "memberadmin.cfm", "memberadmin.php", "memberadmin", "members", "memlogin", "meta_login", "modelsearch/admin.asp", "modelsearch/admin.cfm", "modelsearch/admin.html", "modelsearch/admin.php", "modelsearch/index.asp", "modelsearch/index.cfm", "modelsearch/index.html", "modelsearch/index.php", "modelsearch/login.asp", "modelsearch/login.cfm", "modelsearch/login.html", "modelsearch/login.php", "moderator.asp", "moderator.cfm", "moderator.html", "moderator.php", "moderator", "moderator/admin.asp", "moderator/admin.cfm", "moderator/admin.html", "moderator/admin.php", "moderator/login.asp", "moderator/login.cfm", "moderator/login.html", "moderator/login.php", "myadmin", "navSiteAdmin", "newsadmin", "nsw/admin/login.php", "openvpnadmin", "pages/admin/admin-login.asp", "pages/admin/admin-login.cfm", "pages/admin/admin-login.html", "pages/admin/admin-login.php", "panel", "panel-administracion", "panel-administracion/admin.asp", "panel-administracion/admin.cfm", "panel-administracion/admin.html", "panel-administracion/admin.php", "panel-administracion/index.asp", "panel-administracion/index.cfm", "panel-administracion/index.html", "panel-administracion/index.php", "panel-administracion/login.asp", "panel-administracion/login.cfm", "panel-administracion/login.html", "panel-administracion/login.php", "pgadmin", "phpldapadmin", "phpmyadmin", "phppgadmin", "phpSQLiteAdmin", "platz_login", "power_user", "project-admins", "pureadmin", "radmind", "radmind-1", "rcjakar/admin/login.php", "rcLogin", "Server.asp", "Server.html", "Server.php", "server", "server_admin_small", "ServerAdministrator", "showlogin", "simpleLogin", "siteadmin/index.asp", "siteadmin/index.cfm", "siteadmin/index.php", "siteadmin/login.asp", "siteadmin/login.cfm", "siteadmin/login.html", "siteadmin/login.php", "smblogin", "sql-admin", "ss_vms_admin_sm", "sshadmin", "staradmin", "sub-login", "Super-Admin", "support_login", "sysadmin.asp", "sysadmin.html", "sysadmin.php", "sysadmin", "sys-admin", "SysAdmin2", "sysadmins", "system_administration", "system-administration", "typo3", "ur-admin.asp", "ur-admin.html", "ur-admin.php", "ur-admin", "user.asp", "user.html", "user.php", "useradmin", "UserLogin", "utility_login", "vadmind", "vmailadmin", "webadmin.asp", "webadmin.cfm", "webadmin.html", "webadmin.php", "WebAdmin", "webadmin/admin.asp", "webadmin/admin.cfm", "webadmin/admin.html", "webadmin/admin.php", "webadmin/index.asp", "webadmin/index.cfm", "webadmin/index.html", "webadmin/index.php", "webadmin/login.asp", "webadmin/login.cfm", "webadmin/login.html", "webadmin/login.php", "wizmysqladmin", "wp-admin", "wp-login.php", "wp-login", "xlogin", "yonetici.asp", "yonetici.html", "yonetici.php", "yonetim.asp", "yonetim.html", "yonetim.php", "panel/?a=cp", "admin2", "admin3", "admin4", "admin5", "usuarios", "usuario", "acceso.php", "usuarios/login.php", "/account.asp", "acceso.asp", "nsw/admin/login.cfm", "acceso.cfm", "rcjakar/admin/login.cfm", "user.cfm", "wp-login.cfm", "usuarios/login.cfm", "admin/account.js", "admin/index.js", "admin/login.js", "admin/admin.js", "admin_area/admin.js", "admin_area/login.js", "siteadmin/login.js", "siteadmin/index.js", "admin_area/index.js", "bb-admin/index.js", "bb-admin/login.js", "bb-admin/admin.js", "admin/home.js", "admin/controlpanel.js", "admin.js", "admin/cp.js", "cp.js", "administrator/index.js", "administrator/login.js", "nsw/admin/login.js", "webadmin/login.js", "admin/admin_login.js", "admin_login.js", "administrator/account.js", "administrator.js", "pages/admin/admin-login.js", "admin/admin-login.js", "admin-login.js", "login.js", "modelsearch/login.js", "moderator.js", "moderator/login.js", "moderator/admin.js", "account.js", "controlpanel.js", "admincontrol.js", "rcjakar/admin/login.js", "webadmin.js", "webadmin/index.js", "acceso.js", "webadmin/admin.js", "adminpanel.js", "user.js", "panel-administracion/login.js", "wp-login.js", "adminLogin.js", "admin/adminLogin.js", "home.js", "adminarea/index.js", "adminarea/admin.js", "adminarea/login.js", "panel-administracion/index.js", "panel-administracion/admin.js", "modelsearch/index.js", "modelsearch/admin.js", "admincontrol/login.js", "adm/admloginuser.js", "admloginuser.js", "admin2.js", "admin2/login.js", "admin2/index.js", "usuarios/login.js", "adm/index.js", "adm.js", "affiliate.js", "adm_auth.js", "memberadmin.js", "administratorlogin.js'", "admin/account.cgi", "admin/index.cgi", "admin/login.cgi", "admin/admin.cgi", "admin_area/admin.cgi", "admin_area/login.cgi", "siteadmin/login.cgi", "siteadmin/index.cgi", "admin_area/index.cgi", "bb-admin/index.cgi", "bb-admin/login.cgi", "bb-admin/admin.cgi", "admin/home.cgi", "admin/controlpanel.cgi", "admin.cgi", "admin/cp.cgi", "cp.cgi", "administrator/index.cgi", "administrator/login.cgi", "nsw/admin/login.cgi", "webadmin/login.cgi", "admin/admin_login.cgi", "admin_login.cgi", "administrator/account.cgi", "administrator.cgi", "pages/admin/admin-login.cgi", "admin/admin-login.cgi", "admin-login.cgi", "login.cgi", "modelsearch/login.cgi", "moderator.cgi", "moderator/login.cgi", "moderator/admin.cgi", "account.cgi", "controlpanel.cgi", "admincontrol.cgi", "rcjakar/admin/login.cgi", "webadmin.cgi", "webadmin/index.cgi", "acceso.cgi", "webadmin/admin.cgi", "adminpanel.cgi", "user.cgi", "panel-administracion/login.cgi", "wp-login.cgi", "adminLogin.cgi", "admin/adminLogin.cgi", "home.cgi", "adminarea/index.cgi", "adminarea/admin.cgi", "adminarea/login.cgi", "panel-administracion/index.cgi", "panel-administracion/admin.cgi", "modelsearch/index.cgi", "modelsearch/admin.cgi", "admincontrol/login.cgi", "adm/admloginuser.cgi", "admloginuser.cgi", "admin2.cgi", "admin2/login.cgi", "admin2/index.cgi", "usuarios/login.cgi", "adm/index.cgi", "adm.cgi", "affiliate.cgi", "adm_auth.cgi", "memberadmin.cgi", "administratorlogin.cgi'", "admin/account.brf", "admin/index.brf", "admin/login.brf", "admin/admin.brf", "admin_area/admin.brf", "admin_area/login.brf", "siteadmin/login.brf", "siteadmin/index.brf", "admin_area/index.brf", "bb-admin/index.brf", "bb-admin/login.brf", "bb-admin/admin.brf", "admin/home.brf", "admin/controlpanel.brf", "admin.brf", "admin/cp.brf", "cp.brf", "administrator/index.brf", "administrator/login.brf", "nsw/admin/login.brf", "webadmin/login.brfbrf", "admin/admin_login.brf", "admin_login.brf", "administrator/account.brf", "administrator.brf", "acceso.brf", "pages/admin/admin-login.brf", "admin/admin-login.brf", "admin-login.brf", "login.brf", "modelsearch/login.brf", "moderator.brf", "moderator/login.brf", "moderator/admin.brf", "account.brf", "controlpanel.brf", "admincontrol.brf", "rcjakar/admin/login.brf", "webadmin.brf", "webadmin/index.brf", "webadmin/admin.brf", "adminpanel.brf", "user.brf", "panel-administracion/login.brf", "wp-login.brf", "adminLogin.brf", "admin/adminLogin.brf", "home.brf", "adminarea/index.brf", "adminarea/admin.brf", "adminarea/login.brf", "panel-administracion/index.brf", "panel-administracion/admin.brf", "modelsearch/index.brf", "modelsearch/admin.brf", "admincontrol/login.brf", "adm/admloginuser.brf", "admloginuser.brf", "admin2.brf", "admin2/login.brf", "admin2/index.brf", "usuarios/login.brf", "adm/index.brf", "adm.brf", "affiliate.brf", "adm_auth.brf", "memberadmin.brf", "administratorlogin.brf"})
        Me.ListBox2.Location = New System.Drawing.Point(9, 77)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(220, 290)
        Me.ListBox2.TabIndex = 2
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(254, 167)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(145, 137)
        Me.WebBrowser1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Site Url"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Lime
        Me.Button1.Location = New System.Drawing.Point(9, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(134, 373)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 24)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(134, 488)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Copy URL"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Black
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Cyan
        Me.Button4.Location = New System.Drawing.Point(8, 488)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(56, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "About"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(236, 516)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(252, 554)
        Me.MinimumSize = New System.Drawing.Size(252, 554)
        Me.Name = "Form1"
        Me.Text = "Puf Admin Finder"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button

End Class
