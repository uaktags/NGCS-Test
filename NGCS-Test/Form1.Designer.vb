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
        Dim ListViewGroup6 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Infrastructure", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup7 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Network", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup8 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Security", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup9 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Management", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup10 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Other", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Servers")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Images")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Shared Storage")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Firewall Policies")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Load Balancers")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Public IP")
        Dim ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImagesPanel = New System.Windows.Forms.Panel()
        Me.Imageslbl = New System.Windows.Forms.Label()
        Me.SharedStoragePanel = New System.Windows.Forms.Panel()
        Me.SharedStorageLabel = New System.Windows.Forms.Label()
        Me.FWPanel = New System.Windows.Forms.Panel()
        Me.FWPoliciesLabel = New System.Windows.Forms.Label()
        Me.LBPanel = New System.Windows.Forms.Panel()
        Me.LoadBalancerPanel = New System.Windows.Forms.Label()
        Me.PublicIPPanel = New System.Windows.Forms.Panel()
        Me.PublicIPLabel = New System.Windows.Forms.Label()
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ImagesPanel.SuspendLayout()
        Me.SharedStoragePanel.SuspendLayout()
        Me.FWPanel.SuspendLayout()
        Me.LBPanel.SuspendLayout()
        Me.PublicIPPanel.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(882, 601)
        Me.SplitContainer1.SplitterDistance = 294
        Me.SplitContainer1.TabIndex = 1
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {ColumnHeader1})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        ListViewGroup6.Header = "Infrastructure"
        ListViewGroup6.Name = "InfrastructureGrp"
        ListViewGroup7.Header = "Network"
        ListViewGroup7.Name = "NetworkGrp"
        ListViewGroup8.Header = "Security"
        ListViewGroup8.Name = "SecurityGrp"
        ListViewGroup9.Header = "Management"
        ListViewGroup9.Name = "ManagementGrp"
        ListViewGroup10.Header = "Other"
        ListViewGroup10.Name = "OtherGrp"
        Me.ListView1.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup6, ListViewGroup7, ListViewGroup8, ListViewGroup9, ListViewGroup10})
        Me.ListView1.HideSelection = False
        Me.ListView1.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        ListViewItem7.Group = ListViewGroup6
        ListViewItem8.Group = ListViewGroup6
        ListViewItem9.Group = ListViewGroup6
        ListViewItem10.Group = ListViewGroup7
        ListViewItem11.Group = ListViewGroup7
        ListViewItem12.Group = ListViewGroup7
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12})
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(294, 601)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        ColumnHeader1.Text = ""
        ColumnHeader1.Width = 256
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ImagesPanel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(584, 601)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Servers"
        '
        'ImagesPanel
        '
        Me.ImagesPanel.Controls.Add(Me.SharedStoragePanel)
        Me.ImagesPanel.Controls.Add(Me.Imageslbl)
        Me.ImagesPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImagesPanel.Location = New System.Drawing.Point(0, 0)
        Me.ImagesPanel.Name = "ImagesPanel"
        Me.ImagesPanel.Size = New System.Drawing.Size(584, 601)
        Me.ImagesPanel.TabIndex = 1
        '
        'Imageslbl
        '
        Me.Imageslbl.AutoSize = True
        Me.Imageslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Imageslbl.Location = New System.Drawing.Point(3, 12)
        Me.Imageslbl.Name = "Imageslbl"
        Me.Imageslbl.Size = New System.Drawing.Size(107, 32)
        Me.Imageslbl.TabIndex = 0
        Me.Imageslbl.Text = "Images"
        '
        'SharedStoragePanel
        '
        Me.SharedStoragePanel.Controls.Add(Me.FWPanel)
        Me.SharedStoragePanel.Controls.Add(Me.SharedStorageLabel)
        Me.SharedStoragePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SharedStoragePanel.Location = New System.Drawing.Point(0, 0)
        Me.SharedStoragePanel.Name = "SharedStoragePanel"
        Me.SharedStoragePanel.Size = New System.Drawing.Size(584, 601)
        Me.SharedStoragePanel.TabIndex = 2
        '
        'SharedStorageLabel
        '
        Me.SharedStorageLabel.AutoSize = True
        Me.SharedStorageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SharedStorageLabel.Location = New System.Drawing.Point(3, 12)
        Me.SharedStorageLabel.Name = "SharedStorageLabel"
        Me.SharedStorageLabel.Size = New System.Drawing.Size(214, 32)
        Me.SharedStorageLabel.TabIndex = 0
        Me.SharedStorageLabel.Text = "Shared Storage"
        '
        'FWPanel
        '
        Me.FWPanel.Controls.Add(Me.LBPanel)
        Me.FWPanel.Controls.Add(Me.FWPoliciesLabel)
        Me.FWPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FWPanel.Location = New System.Drawing.Point(0, 0)
        Me.FWPanel.Name = "FWPanel"
        Me.FWPanel.Size = New System.Drawing.Size(584, 601)
        Me.FWPanel.TabIndex = 2
        '
        'FWPoliciesLabel
        '
        Me.FWPoliciesLabel.AutoSize = True
        Me.FWPoliciesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FWPoliciesLabel.Location = New System.Drawing.Point(3, 12)
        Me.FWPoliciesLabel.Name = "FWPoliciesLabel"
        Me.FWPoliciesLabel.Size = New System.Drawing.Size(221, 32)
        Me.FWPoliciesLabel.TabIndex = 0
        Me.FWPoliciesLabel.Text = "Firewall Policies"
        '
        'LBPanel
        '
        Me.LBPanel.Controls.Add(Me.PublicIPPanel)
        Me.LBPanel.Controls.Add(Me.LoadBalancerPanel)
        Me.LBPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBPanel.Location = New System.Drawing.Point(0, 0)
        Me.LBPanel.Name = "LBPanel"
        Me.LBPanel.Size = New System.Drawing.Size(584, 601)
        Me.LBPanel.TabIndex = 2
        '
        'LoadBalancerPanel
        '
        Me.LoadBalancerPanel.AutoSize = True
        Me.LoadBalancerPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadBalancerPanel.Location = New System.Drawing.Point(3, 12)
        Me.LoadBalancerPanel.Name = "LoadBalancerPanel"
        Me.LoadBalancerPanel.Size = New System.Drawing.Size(213, 32)
        Me.LoadBalancerPanel.TabIndex = 0
        Me.LoadBalancerPanel.Text = "Load Balancers"
        '
        'PublicIPPanel
        '
        Me.PublicIPPanel.Controls.Add(Me.PublicIPLabel)
        Me.PublicIPPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PublicIPPanel.Location = New System.Drawing.Point(0, 0)
        Me.PublicIPPanel.Name = "PublicIPPanel"
        Me.PublicIPPanel.Size = New System.Drawing.Size(584, 601)
        Me.PublicIPPanel.TabIndex = 2
        '
        'PublicIPLabel
        '
        Me.PublicIPLabel.AutoSize = True
        Me.PublicIPLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PublicIPLabel.Location = New System.Drawing.Point(3, 12)
        Me.PublicIPLabel.Name = "PublicIPLabel"
        Me.PublicIPLabel.Size = New System.Drawing.Size(127, 32)
        Me.PublicIPLabel.TabIndex = 0
        Me.PublicIPLabel.Text = "Public IP"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 601)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ImagesPanel.ResumeLayout(False)
        Me.ImagesPanel.PerformLayout()
        Me.SharedStoragePanel.ResumeLayout(False)
        Me.SharedStoragePanel.PerformLayout()
        Me.FWPanel.ResumeLayout(False)
        Me.FWPanel.PerformLayout()
        Me.LBPanel.ResumeLayout(False)
        Me.LBPanel.PerformLayout()
        Me.PublicIPPanel.ResumeLayout(False)
        Me.PublicIPPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ImagesPanel As Panel
    Friend WithEvents SharedStoragePanel As Panel
    Friend WithEvents FWPanel As Panel
    Friend WithEvents LBPanel As Panel
    Friend WithEvents PublicIPPanel As Panel
    Friend WithEvents PublicIPLabel As Label
    Friend WithEvents LoadBalancerPanel As Label
    Friend WithEvents FWPoliciesLabel As Label
    Friend WithEvents SharedStorageLabel As Label
    Friend WithEvents Imageslbl As Label
    Friend WithEvents Label1 As Label
End Class
