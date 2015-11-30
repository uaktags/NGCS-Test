<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Dim ListViewGroup11 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Infrastructure", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup12 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Network", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup13 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Security", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup14 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Management", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup15 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Other", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Servers")
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Images")
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Shared Storage")
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Firewall Policies")
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Load Balancers")
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Public IP")
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.serverPanel = New System.Windows.Forms.Panel()
        Me.specsPanels = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.harddrivelabel = New System.Windows.Forms.Label()
        Me.harddriveList = New System.Windows.Forms.ListBox()
        Me.serverIP = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.serverStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.serverDesc = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.serverNameLabel = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.serversView = New System.Windows.Forms.ListView()
        Me.serverLabel = New System.Windows.Forms.Label()
        Me.imagesPanel = New System.Windows.Forms.Panel()
        Me.imagesLabel = New System.Windows.Forms.Label()
        Me.SharedStoragePanel = New System.Windows.Forms.Panel()
        Me.SharedStorageLabel = New System.Windows.Forms.Label()
        Me.FirewallPanel = New System.Windows.Forms.Panel()
        Me.FirewallLabel = New System.Windows.Forms.Label()
        Me.LoadBalancerPanel = New System.Windows.Forms.Panel()
        Me.LoadBalancerLabel = New System.Windows.Forms.Label()
        Me.PublicIPPanel = New System.Windows.Forms.Panel()
        Me.PublicIPLabel = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.currentstatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statustimer = New System.Windows.Forms.Timer(Me.components)
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.serverPanel.SuspendLayout()
        Me.specsPanels.SuspendLayout()
        Me.imagesPanel.SuspendLayout()
        Me.SharedStoragePanel.SuspendLayout()
        Me.FirewallPanel.SuspendLayout()
        Me.LoadBalancerPanel.SuspendLayout()
        Me.PublicIPPanel.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        ColumnHeader1.Text = ""
        ColumnHeader1.Width = 256
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.serverPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.imagesPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SharedStoragePanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FirewallPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LoadBalancerPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PublicIPPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(686, 637)
        Me.SplitContainer1.SplitterDistance = 228
        Me.SplitContainer1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1})
        ListViewGroup11.Header = "Infrastructure"
        ListViewGroup11.Name = "InfrastructureGrp"
        ListViewGroup12.Header = "Network"
        ListViewGroup12.Name = "NetworkGrp"
        ListViewGroup13.Header = "Security"
        ListViewGroup13.Name = "SecurityGrp"
        ListViewGroup14.Header = "Management"
        ListViewGroup14.Name = "ManagementGrp"
        ListViewGroup15.Header = "Other"
        ListViewGroup15.Name = "OtherGrp"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup11, ListViewGroup12, ListViewGroup13, ListViewGroup14, ListViewGroup15})
        Me.ListView1.HideSelection = False
        Me.ListView1.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        ListViewItem13.Group = ListViewGroup11
        ListViewItem14.Group = ListViewGroup11
        ListViewItem15.Group = ListViewGroup11
        ListViewItem16.Group = ListViewGroup12
        ListViewItem17.Group = ListViewGroup12
        ListViewItem18.Group = ListViewGroup12
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18})
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(228, 601)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'serverPanel
        '
        Me.serverPanel.Controls.Add(Me.specsPanels)
        Me.serverPanel.Controls.Add(Me.serversView)
        Me.serverPanel.Controls.Add(Me.serverLabel)
        Me.serverPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.serverPanel.Location = New System.Drawing.Point(0, 0)
        Me.serverPanel.Name = "serverPanel"
        Me.serverPanel.Size = New System.Drawing.Size(454, 637)
        Me.serverPanel.TabIndex = 0
        '
        'specsPanels
        '
        Me.specsPanels.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.specsPanels.Controls.Add(Me.Button1)
        Me.specsPanels.Controls.Add(Me.harddrivelabel)
        Me.specsPanels.Controls.Add(Me.harddriveList)
        Me.specsPanels.Controls.Add(Me.serverIP)
        Me.specsPanels.Controls.Add(Me.Label7)
        Me.specsPanels.Controls.Add(Me.serverStatus)
        Me.specsPanels.Controls.Add(Me.Label5)
        Me.specsPanels.Controls.Add(Me.serverDesc)
        Me.specsPanels.Controls.Add(Me.Label3)
        Me.specsPanels.Controls.Add(Me.serverNameLabel)
        Me.specsPanels.Controls.Add(Me.label1)
        Me.specsPanels.Location = New System.Drawing.Point(19, 303)
        Me.specsPanels.Name = "specsPanels"
        Me.specsPanels.Size = New System.Drawing.Size(411, 322)
        Me.specsPanels.TabIndex = 12
        Me.specsPanels.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 170)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 29)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Create an Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'harddrivelabel
        '
        Me.harddrivelabel.AutoSize = True
        Me.harddrivelabel.Location = New System.Drawing.Point(285, 34)
        Me.harddrivelabel.Name = "harddrivelabel"
        Me.harddrivelabel.Size = New System.Drawing.Size(81, 17)
        Me.harddrivelabel.TabIndex = 21
        Me.harddrivelabel.Text = "Harddrives:"
        '
        'harddriveList
        '
        Me.harddriveList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.harddriveList.FormattingEnabled = True
        Me.harddriveList.ItemHeight = 16
        Me.harddriveList.Location = New System.Drawing.Point(288, 54)
        Me.harddriveList.Name = "harddriveList"
        Me.harddriveList.Size = New System.Drawing.Size(120, 68)
        Me.harddriveList.TabIndex = 20
        '
        'serverIP
        '
        Me.serverIP.AutoSize = True
        Me.serverIP.Location = New System.Drawing.Point(87, 88)
        Me.serverIP.Name = "serverIP"
        Me.serverIP.Size = New System.Drawing.Size(82, 17)
        Me.serverIP.TabIndex = 19
        Me.serverIP.Text = "{IPAddress}"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "IP Address:"
        '
        'serverStatus
        '
        Me.serverStatus.AutoSize = True
        Me.serverStatus.Location = New System.Drawing.Point(87, 71)
        Me.serverStatus.Name = "serverStatus"
        Me.serverStatus.Size = New System.Drawing.Size(58, 17)
        Me.serverStatus.TabIndex = 17
        Me.serverStatus.Text = "{Status}"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Status:"
        '
        'serverDesc
        '
        Me.serverDesc.AutoSize = True
        Me.serverDesc.Location = New System.Drawing.Point(87, 54)
        Me.serverDesc.Name = "serverDesc"
        Me.serverDesc.Size = New System.Drawing.Size(89, 17)
        Me.serverDesc.TabIndex = 15
        Me.serverDesc.Text = "{Description}"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Description:"
        '
        'serverNameLabel
        '
        Me.serverNameLabel.AutoSize = True
        Me.serverNameLabel.Location = New System.Drawing.Point(87, 37)
        Me.serverNameLabel.Name = "serverNameLabel"
        Me.serverNameLabel.Size = New System.Drawing.Size(55, 17)
        Me.serverNameLabel.TabIndex = 13
        Me.serverNameLabel.Text = "{Name}"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(3, 37)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(49, 17)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Name:"
        '
        'serversView
        '
        Me.serversView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.serversView.Location = New System.Drawing.Point(19, 78)
        Me.serversView.Name = "serversView"
        Me.serversView.Size = New System.Drawing.Size(411, 238)
        Me.serversView.TabIndex = 1
        Me.serversView.UseCompatibleStateImageBehavior = False
        '
        'serverLabel
        '
        Me.serverLabel.AutoSize = True
        Me.serverLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serverLabel.Location = New System.Drawing.Point(14, 19)
        Me.serverLabel.Name = "serverLabel"
        Me.serverLabel.Size = New System.Drawing.Size(80, 25)
        Me.serverLabel.TabIndex = 0
        Me.serverLabel.Text = "Servers"
        '
        'imagesPanel
        '
        Me.imagesPanel.Controls.Add(Me.imagesLabel)
        Me.imagesPanel.Location = New System.Drawing.Point(133, 128)
        Me.imagesPanel.Name = "imagesPanel"
        Me.imagesPanel.Size = New System.Drawing.Size(383, 409)
        Me.imagesPanel.TabIndex = 5
        '
        'imagesLabel
        '
        Me.imagesLabel.AutoSize = True
        Me.imagesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imagesLabel.Location = New System.Drawing.Point(14, 19)
        Me.imagesLabel.Name = "imagesLabel"
        Me.imagesLabel.Size = New System.Drawing.Size(76, 25)
        Me.imagesLabel.TabIndex = 0
        Me.imagesLabel.Text = "Images"
        '
        'SharedStoragePanel
        '
        Me.SharedStoragePanel.Controls.Add(Me.SharedStorageLabel)
        Me.SharedStoragePanel.Location = New System.Drawing.Point(125, 120)
        Me.SharedStoragePanel.Name = "SharedStoragePanel"
        Me.SharedStoragePanel.Size = New System.Drawing.Size(383, 409)
        Me.SharedStoragePanel.TabIndex = 4
        '
        'SharedStorageLabel
        '
        Me.SharedStorageLabel.AutoSize = True
        Me.SharedStorageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SharedStorageLabel.Location = New System.Drawing.Point(14, 19)
        Me.SharedStorageLabel.Name = "SharedStorageLabel"
        Me.SharedStorageLabel.Size = New System.Drawing.Size(160, 25)
        Me.SharedStorageLabel.TabIndex = 0
        Me.SharedStorageLabel.Text = "Shared Storages"
        '
        'FirewallPanel
        '
        Me.FirewallPanel.Controls.Add(Me.FirewallLabel)
        Me.FirewallPanel.Location = New System.Drawing.Point(117, 112)
        Me.FirewallPanel.Name = "FirewallPanel"
        Me.FirewallPanel.Size = New System.Drawing.Size(383, 409)
        Me.FirewallPanel.TabIndex = 3
        '
        'FirewallLabel
        '
        Me.FirewallLabel.AutoSize = True
        Me.FirewallLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirewallLabel.Location = New System.Drawing.Point(14, 19)
        Me.FirewallLabel.Name = "FirewallLabel"
        Me.FirewallLabel.Size = New System.Drawing.Size(150, 25)
        Me.FirewallLabel.TabIndex = 0
        Me.FirewallLabel.Text = "Firewall Policies"
        '
        'LoadBalancerPanel
        '
        Me.LoadBalancerPanel.Controls.Add(Me.LoadBalancerLabel)
        Me.LoadBalancerPanel.Location = New System.Drawing.Point(109, 104)
        Me.LoadBalancerPanel.Name = "LoadBalancerPanel"
        Me.LoadBalancerPanel.Size = New System.Drawing.Size(383, 409)
        Me.LoadBalancerPanel.TabIndex = 2
        '
        'LoadBalancerLabel
        '
        Me.LoadBalancerLabel.AutoSize = True
        Me.LoadBalancerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBalancerLabel.Location = New System.Drawing.Point(14, 19)
        Me.LoadBalancerLabel.Name = "LoadBalancerLabel"
        Me.LoadBalancerLabel.Size = New System.Drawing.Size(148, 25)
        Me.LoadBalancerLabel.TabIndex = 0
        Me.LoadBalancerLabel.Text = "Load Balancers"
        '
        'PublicIPPanel
        '
        Me.PublicIPPanel.Controls.Add(Me.PublicIPLabel)
        Me.PublicIPPanel.Location = New System.Drawing.Point(101, 96)
        Me.PublicIPPanel.Name = "PublicIPPanel"
        Me.PublicIPPanel.Size = New System.Drawing.Size(383, 409)
        Me.PublicIPPanel.TabIndex = 1
        '
        'PublicIPLabel
        '
        Me.PublicIPLabel.AutoSize = True
        Me.PublicIPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicIPLabel.Location = New System.Drawing.Point(14, 19)
        Me.PublicIPLabel.Name = "PublicIPLabel"
        Me.PublicIPLabel.Size = New System.Drawing.Size(88, 25)
        Me.PublicIPLabel.TabIndex = 0
        Me.PublicIPLabel.Text = "Public IP"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.currentstatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 615)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(686, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'currentstatus
        '
        Me.currentstatus.Name = "currentstatus"
        Me.currentstatus.Size = New System.Drawing.Size(0, 17)
        '
        'statustimer
        '
        Me.statustimer.Interval = 5000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 637)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.serverPanel.ResumeLayout(False)
        Me.serverPanel.PerformLayout()
        Me.specsPanels.ResumeLayout(False)
        Me.specsPanels.PerformLayout()
        Me.imagesPanel.ResumeLayout(False)
        Me.imagesPanel.PerformLayout()
        Me.SharedStoragePanel.ResumeLayout(False)
        Me.SharedStoragePanel.PerformLayout()
        Me.FirewallPanel.ResumeLayout(False)
        Me.FirewallPanel.PerformLayout()
        Me.LoadBalancerPanel.ResumeLayout(False)
        Me.LoadBalancerPanel.PerformLayout()
        Me.PublicIPPanel.ResumeLayout(False)
        Me.PublicIPPanel.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents serverPanel As Panel
    Friend WithEvents serversView As ListView
    Friend WithEvents serverLabel As Label
    Friend WithEvents imagesPanel As Panel
    Friend WithEvents imagesLabel As Label
    Friend WithEvents SharedStoragePanel As Panel
    Friend WithEvents SharedStorageLabel As Label
    Friend WithEvents FirewallPanel As Panel
    Friend WithEvents FirewallLabel As Label
    Friend WithEvents LoadBalancerPanel As Panel
    Friend WithEvents LoadBalancerLabel As Label
    Friend WithEvents PublicIPPanel As Panel
    Friend WithEvents PublicIPLabel As Label
    Friend WithEvents specsPanels As Panel
    Friend WithEvents harddrivelabel As Label
    Friend WithEvents harddriveList As ListBox
    Friend WithEvents serverIP As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents serverStatus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents serverDesc As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents serverNameLabel As Label
    Friend WithEvents label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents currentstatus As ToolStripStatusLabel
    Friend WithEvents statustimer As Timer
End Class
