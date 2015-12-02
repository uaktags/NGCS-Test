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
        Dim ListViewGroup16 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Infrastructure", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup17 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Network", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup18 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Security", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup19 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Management", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup20 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Other", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Servers")
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Images")
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Shared Storage")
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Firewall Policies")
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Load Balancers")
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Public IP")
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.serverPanel = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.specsPanels = New System.Windows.Forms.Panel()
        Me.harddrivelabel = New System.Windows.Forms.Label()
        Me.harddriveList = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.serverStatus = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.serverDesc = New System.Windows.Forms.Label()
        Me.serverNameLabel = New System.Windows.Forms.Label()
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
        Me.ActionsMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HardwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoftwareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImagesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReimageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SnapshotsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateSnapshotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSnapshotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.serverRam = New System.Windows.Forms.Label()
        Me.serverCores = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.serverIPs = New System.Windows.Forms.ListBox()
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.serverPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.specsPanels.SuspendLayout()
        Me.imagesPanel.SuspendLayout()
        Me.SharedStoragePanel.SuspendLayout()
        Me.FirewallPanel.SuspendLayout()
        Me.LoadBalancerPanel.SuspendLayout()
        Me.PublicIPPanel.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ActionsMenuStrip.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.SharedStoragePanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.FirewallPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LoadBalancerPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PublicIPPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.serverPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(868, 713)
        Me.SplitContainer1.SplitterDistance = 146
        Me.SplitContainer1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup16.Header = "Infrastructure"
        ListViewGroup16.Name = "InfrastructureGrp"
        ListViewGroup17.Header = "Network"
        ListViewGroup17.Name = "NetworkGrp"
        ListViewGroup18.Header = "Security"
        ListViewGroup18.Name = "SecurityGrp"
        ListViewGroup19.Header = "Management"
        ListViewGroup19.Name = "ManagementGrp"
        ListViewGroup20.Header = "Other"
        ListViewGroup20.Name = "OtherGrp"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup16, ListViewGroup17, ListViewGroup18, ListViewGroup19, ListViewGroup20})
        Me.ListView1.HideSelection = False
        Me.ListView1.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        ListViewItem19.Group = ListViewGroup16
        ListViewItem20.Group = ListViewGroup16
        ListViewItem21.Group = ListViewGroup16
        ListViewItem22.Group = ListViewGroup17
        ListViewItem23.Group = ListViewGroup17
        ListViewItem24.Group = ListViewGroup17
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24})
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(146, 713)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'serverPanel
        '
        Me.serverPanel.Controls.Add(Me.imagesPanel)
        Me.serverPanel.Controls.Add(Me.Button5)
        Me.serverPanel.Controls.Add(Me.Button4)
        Me.serverPanel.Controls.Add(Me.DataGridView1)
        Me.serverPanel.Controls.Add(Me.specsPanels)
        Me.serverPanel.Controls.Add(Me.serverLabel)
        Me.serverPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.serverPanel.Location = New System.Drawing.Point(0, 0)
        Me.serverPanel.Name = "serverPanel"
        Me.serverPanel.Size = New System.Drawing.Size(718, 713)
        Me.serverPanel.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(117, 75)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(92, 37)
        Me.Button5.TabIndex = 16
        Me.Button5.Text = "Actions"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(19, 75)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(92, 37)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "Create"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colName, Me.colIP, Me.colOS, Me.colStatus})
        Me.DataGridView1.Location = New System.Drawing.Point(19, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(674, 224)
        Me.DataGridView1.TabIndex = 13
        '
        'colName
        '
        Me.colName.HeaderText = "Name"
        Me.colName.Name = "colName"
        '
        'colIP
        '
        Me.colIP.HeaderText = "IP"
        Me.colIP.Name = "colIP"
        '
        'colOS
        '
        Me.colOS.HeaderText = "OS"
        Me.colOS.Name = "colOS"
        '
        'colStatus
        '
        Me.colStatus.HeaderText = "Status"
        Me.colStatus.Name = "colStatus"
        Me.colStatus.Width = 200
        '
        'specsPanels
        '
        Me.specsPanels.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.specsPanels.Controls.Add(Me.serverIPs)
        Me.specsPanels.Controls.Add(Me.serverCores)
        Me.specsPanels.Controls.Add(Me.Label4)
        Me.specsPanels.Controls.Add(Me.serverRam)
        Me.specsPanels.Controls.Add(Me.Label2)
        Me.specsPanels.Controls.Add(Me.Label1)
        Me.specsPanels.Controls.Add(Me.harddrivelabel)
        Me.specsPanels.Controls.Add(Me.harddriveList)
        Me.specsPanels.Controls.Add(Me.Label7)
        Me.specsPanels.Controls.Add(Me.serverStatus)
        Me.specsPanels.Controls.Add(Me.Label5)
        Me.specsPanels.Controls.Add(Me.serverDesc)
        Me.specsPanels.Controls.Add(Me.serverNameLabel)
        Me.specsPanels.Location = New System.Drawing.Point(19, 370)
        Me.specsPanels.Name = "specsPanels"
        Me.specsPanels.Size = New System.Drawing.Size(675, 318)
        Me.specsPanels.TabIndex = 12
        Me.specsPanels.Visible = False
        '
        'harddrivelabel
        '
        Me.harddrivelabel.AutoSize = True
        Me.harddrivelabel.Location = New System.Drawing.Point(234, 205)
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
        Me.harddriveList.Location = New System.Drawing.Point(317, 205)
        Me.harddriveList.Name = "harddriveList"
        Me.harddriveList.Size = New System.Drawing.Size(89, 68)
        Me.harddriveList.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 176)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "IP Address:"
        '
        'serverStatus
        '
        Me.serverStatus.AutoSize = True
        Me.serverStatus.Location = New System.Drawing.Point(103, 150)
        Me.serverStatus.Name = "serverStatus"
        Me.serverStatus.Size = New System.Drawing.Size(58, 17)
        Me.serverStatus.TabIndex = 17
        Me.serverStatus.Text = "{Status}"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Status:"
        '
        'serverDesc
        '
        Me.serverDesc.AutoSize = True
        Me.serverDesc.Location = New System.Drawing.Point(23, 68)
        Me.serverDesc.Name = "serverDesc"
        Me.serverDesc.Size = New System.Drawing.Size(89, 17)
        Me.serverDesc.TabIndex = 15
        Me.serverDesc.Text = "{Description}"
        '
        'serverNameLabel
        '
        Me.serverNameLabel.AutoSize = True
        Me.serverNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.serverNameLabel.Location = New System.Drawing.Point(21, 27)
        Me.serverNameLabel.Name = "serverNameLabel"
        Me.serverNameLabel.Size = New System.Drawing.Size(96, 29)
        Me.serverNameLabel.TabIndex = 13
        Me.serverNameLabel.Text = "{Name}"
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
        Me.imagesPanel.Location = New System.Drawing.Point(3, 3)
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 691)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(868, 22)
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
        'ActionsMenuStrip
        '
        Me.ActionsMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ActionsMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.StopToolStripMenuItem, Me.RestartToolStripMenuItem, Me.CloneToolStripMenuItem, Me.ImagesToolStripMenuItem, Me.ReimageToolStripMenuItem, Me.SnapshotsToolStripMenuItem})
        Me.ActionsMenuStrip.Name = "ActionsMenuStrip"
        Me.ActionsMenuStrip.Size = New System.Drawing.Size(152, 186)
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HardwareToolStripMenuItem, Me.SoftwareToolStripMenuItem})
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'HardwareToolStripMenuItem
        '
        Me.HardwareToolStripMenuItem.Name = "HardwareToolStripMenuItem"
        Me.HardwareToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.HardwareToolStripMenuItem.Text = "Hardware"
        '
        'SoftwareToolStripMenuItem
        '
        Me.SoftwareToolStripMenuItem.Name = "SoftwareToolStripMenuItem"
        Me.SoftwareToolStripMenuItem.Size = New System.Drawing.Size(149, 26)
        Me.SoftwareToolStripMenuItem.Text = "Software"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'CloneToolStripMenuItem
        '
        Me.CloneToolStripMenuItem.Name = "CloneToolStripMenuItem"
        Me.CloneToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.CloneToolStripMenuItem.Text = "Clone"
        '
        'ImagesToolStripMenuItem
        '
        Me.ImagesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateImageToolStripMenuItem})
        Me.ImagesToolStripMenuItem.Name = "ImagesToolStripMenuItem"
        Me.ImagesToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.ImagesToolStripMenuItem.Text = "Images"
        '
        'CreateImageToolStripMenuItem
        '
        Me.CreateImageToolStripMenuItem.Name = "CreateImageToolStripMenuItem"
        Me.CreateImageToolStripMenuItem.Size = New System.Drawing.Size(173, 26)
        Me.CreateImageToolStripMenuItem.Text = "Create Image"
        '
        'ReimageToolStripMenuItem
        '
        Me.ReimageToolStripMenuItem.Name = "ReimageToolStripMenuItem"
        Me.ReimageToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.ReimageToolStripMenuItem.Text = "Reimage"
        '
        'SnapshotsToolStripMenuItem
        '
        Me.SnapshotsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateSnapshotToolStripMenuItem, Me.DeleteSnapshotToolStripMenuItem})
        Me.SnapshotsToolStripMenuItem.Name = "SnapshotsToolStripMenuItem"
        Me.SnapshotsToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.SnapshotsToolStripMenuItem.Text = "Snapshots"
        '
        'CreateSnapshotToolStripMenuItem
        '
        Me.CreateSnapshotToolStripMenuItem.Name = "CreateSnapshotToolStripMenuItem"
        Me.CreateSnapshotToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.CreateSnapshotToolStripMenuItem.Text = "Create Snapshot"
        '
        'DeleteSnapshotToolStripMenuItem
        '
        Me.DeleteSnapshotToolStripMenuItem.Name = "DeleteSnapshotToolStripMenuItem"
        Me.DeleteSnapshotToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.DeleteSnapshotToolStripMenuItem.Text = "Delete Snapshot"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 24)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Features:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(234, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Ram:"
        '
        'serverRam
        '
        Me.serverRam.AutoSize = True
        Me.serverRam.Location = New System.Drawing.Point(313, 150)
        Me.serverRam.Name = "serverRam"
        Me.serverRam.Size = New System.Drawing.Size(47, 17)
        Me.serverRam.TabIndex = 24
        Me.serverRam.Text = "{Ram}"
        '
        'serverCores
        '
        Me.serverCores.AutoSize = True
        Me.serverCores.Location = New System.Drawing.Point(313, 178)
        Me.serverCores.Name = "serverCores"
        Me.serverCores.Size = New System.Drawing.Size(62, 17)
        Me.serverCores.TabIndex = 26
        Me.serverCores.Text = "{vCores}"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(234, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "vCores:"
        '
        'serverIPs
        '
        Me.serverIPs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.serverIPs.FormattingEnabled = True
        Me.serverIPs.ItemHeight = 16
        Me.serverIPs.Location = New System.Drawing.Point(106, 178)
        Me.serverIPs.Name = "serverIPs"
        Me.serverIPs.Size = New System.Drawing.Size(89, 68)
        Me.serverIPs.TabIndex = 27
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 713)
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
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
        Me.ActionsMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents serverPanel As Panel
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
    Friend WithEvents Label7 As Label
    Friend WithEvents serverStatus As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents serverDesc As Label
    Friend WithEvents serverNameLabel As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents currentstatus As ToolStripStatusLabel
    Friend WithEvents statustimer As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colIP As DataGridViewTextBoxColumn
    Friend WithEvents colOS As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ActionsMenuStrip As ContextMenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloneToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImagesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateImageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReimageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SnapshotsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateSnapshotToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteSnapshotToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HardwareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoftwareToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents serverCores As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents serverRam As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents serverIPs As ListBox
End Class
