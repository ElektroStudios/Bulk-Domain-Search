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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.TabPageDomainSearch = New System.Windows.Forms.TabPage()
        Me.ChromiumWebBrowserDomainSearch = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.Panel1SeparatorDomainSearch = New System.Windows.Forms.Panel()
        Me.PanelDomainSearch = New System.Windows.Forms.Panel()
        Me.ButtonDomainSearchReload = New System.Windows.Forms.Button()
        Me.ButtonDomainSearchNext = New System.Windows.Forms.Button()
        Me.ButtonDomainSearchPrevious = New System.Windows.Forms.Button()
        Me.ButtonDomainSearchHome = New System.Windows.Forms.Button()
        Me.TextBoxDomainSearchUrl = New System.Windows.Forms.TextBox()
        Me.TabPageFreeBrowsing = New System.Windows.Forms.TabPage()
        Me.PanelSeparatorFreeBrowsing = New System.Windows.Forms.Panel()
        Me.PanelFreeBrowsing = New System.Windows.Forms.Panel()
        Me.ButtonFreeBrowsingHome = New System.Windows.Forms.Button()
        Me.ButtonFreeBrowsingReload = New System.Windows.Forms.Button()
        Me.ButtonFreeBrowsingNext = New System.Windows.Forms.Button()
        Me.ButtonFreeBrowsingPrevious = New System.Windows.Forms.Button()
        Me.ButtonFreeBrowsingNavigate = New System.Windows.Forms.Button()
        Me.TextBoxFreeBrowsingUrl = New System.Windows.Forms.TextBox()
        Me.ChromiumWebBrowserFreeBrowsing = New CefSharp.WinForms.ChromiumWebBrowser()
        Me.TabControlMain.SuspendLayout()
        Me.TabPageDomainSearch.SuspendLayout()
        Me.PanelDomainSearch.SuspendLayout()
        Me.TabPageFreeBrowsing.SuspendLayout()
        Me.PanelFreeBrowsing.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.TabPageDomainSearch)
        Me.TabControlMain.Controls.Add(Me.TabPageFreeBrowsing)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.Location = New System.Drawing.Point(0, 0)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(1264, 681)
        Me.TabControlMain.TabIndex = 0
        '
        'TabPageDomainSearch
        '
        Me.TabPageDomainSearch.Controls.Add(Me.ChromiumWebBrowserDomainSearch)
        Me.TabPageDomainSearch.Controls.Add(Me.Panel1SeparatorDomainSearch)
        Me.TabPageDomainSearch.Controls.Add(Me.PanelDomainSearch)
        Me.TabPageDomainSearch.Location = New System.Drawing.Point(4, 22)
        Me.TabPageDomainSearch.Name = "TabPageDomainSearch"
        Me.TabPageDomainSearch.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDomainSearch.Size = New System.Drawing.Size(1256, 655)
        Me.TabPageDomainSearch.TabIndex = 0
        Me.TabPageDomainSearch.Text = "Domain Search"
        Me.TabPageDomainSearch.UseVisualStyleBackColor = True
        '
        'ChromiumWebBrowserDomainSearch
        '
        Me.ChromiumWebBrowserDomainSearch.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowserDomainSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChromiumWebBrowserDomainSearch.Location = New System.Drawing.Point(3, 42)
        Me.ChromiumWebBrowserDomainSearch.Name = "ChromiumWebBrowserDomainSearch"
        Me.ChromiumWebBrowserDomainSearch.Size = New System.Drawing.Size(1250, 610)
        Me.ChromiumWebBrowserDomainSearch.TabIndex = 3
        '
        'Panel1SeparatorDomainSearch
        '
        Me.Panel1SeparatorDomainSearch.BackColor = System.Drawing.Color.Black
        Me.Panel1SeparatorDomainSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1SeparatorDomainSearch.Location = New System.Drawing.Point(3, 40)
        Me.Panel1SeparatorDomainSearch.Name = "Panel1SeparatorDomainSearch"
        Me.Panel1SeparatorDomainSearch.Size = New System.Drawing.Size(1250, 2)
        Me.Panel1SeparatorDomainSearch.TabIndex = 2
        '
        'PanelDomainSearch
        '
        Me.PanelDomainSearch.Controls.Add(Me.ButtonDomainSearchReload)
        Me.PanelDomainSearch.Controls.Add(Me.ButtonDomainSearchNext)
        Me.PanelDomainSearch.Controls.Add(Me.ButtonDomainSearchPrevious)
        Me.PanelDomainSearch.Controls.Add(Me.ButtonDomainSearchHome)
        Me.PanelDomainSearch.Controls.Add(Me.TextBoxDomainSearchUrl)
        Me.PanelDomainSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDomainSearch.Location = New System.Drawing.Point(3, 3)
        Me.PanelDomainSearch.Name = "PanelDomainSearch"
        Me.PanelDomainSearch.Size = New System.Drawing.Size(1250, 37)
        Me.PanelDomainSearch.TabIndex = 0
        '
        'ButtonDomainSearchReload
        '
        Me.ButtonDomainSearchReload.BackgroundImage = Global.My.Resources.Resources.reload
        Me.ButtonDomainSearchReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonDomainSearchReload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDomainSearchReload.FlatAppearance.BorderSize = 0
        Me.ButtonDomainSearchReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDomainSearchReload.Location = New System.Drawing.Point(35, 6)
        Me.ButtonDomainSearchReload.Name = "ButtonDomainSearchReload"
        Me.ButtonDomainSearchReload.Size = New System.Drawing.Size(24, 23)
        Me.ButtonDomainSearchReload.TabIndex = 1
        Me.ButtonDomainSearchReload.UseVisualStyleBackColor = True
        '
        'ButtonDomainSearchNext
        '
        Me.ButtonDomainSearchNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDomainSearchNext.BackgroundImage = Global.My.Resources.Resources.forward_disabled
        Me.ButtonDomainSearchNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonDomainSearchNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDomainSearchNext.FlatAppearance.BorderSize = 0
        Me.ButtonDomainSearchNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDomainSearchNext.Location = New System.Drawing.Point(1221, 6)
        Me.ButtonDomainSearchNext.Name = "ButtonDomainSearchNext"
        Me.ButtonDomainSearchNext.Size = New System.Drawing.Size(24, 23)
        Me.ButtonDomainSearchNext.TabIndex = 4
        Me.ButtonDomainSearchNext.UseVisualStyleBackColor = True
        '
        'ButtonDomainSearchPrevious
        '
        Me.ButtonDomainSearchPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDomainSearchPrevious.BackgroundImage = Global.My.Resources.Resources.backward_disabled
        Me.ButtonDomainSearchPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonDomainSearchPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDomainSearchPrevious.FlatAppearance.BorderSize = 0
        Me.ButtonDomainSearchPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDomainSearchPrevious.Location = New System.Drawing.Point(1191, 6)
        Me.ButtonDomainSearchPrevious.Name = "ButtonDomainSearchPrevious"
        Me.ButtonDomainSearchPrevious.Size = New System.Drawing.Size(24, 23)
        Me.ButtonDomainSearchPrevious.TabIndex = 3
        Me.ButtonDomainSearchPrevious.UseVisualStyleBackColor = True
        '
        'ButtonDomainSearchHome
        '
        Me.ButtonDomainSearchHome.BackgroundImage = Global.My.Resources.Resources.homepage
        Me.ButtonDomainSearchHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonDomainSearchHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDomainSearchHome.FlatAppearance.BorderSize = 0
        Me.ButtonDomainSearchHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDomainSearchHome.Location = New System.Drawing.Point(5, 6)
        Me.ButtonDomainSearchHome.Name = "ButtonDomainSearchHome"
        Me.ButtonDomainSearchHome.Size = New System.Drawing.Size(24, 23)
        Me.ButtonDomainSearchHome.TabIndex = 0
        Me.ButtonDomainSearchHome.UseVisualStyleBackColor = True
        '
        'TextBoxDomainSearchUrl
        '
        Me.TextBoxDomainSearchUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDomainSearchUrl.Location = New System.Drawing.Point(65, 8)
        Me.TextBoxDomainSearchUrl.Name = "TextBoxDomainSearchUrl"
        Me.TextBoxDomainSearchUrl.ReadOnly = True
        Me.TextBoxDomainSearchUrl.Size = New System.Drawing.Size(1120, 20)
        Me.TextBoxDomainSearchUrl.TabIndex = 2
        '
        'TabPageFreeBrowsing
        '
        Me.TabPageFreeBrowsing.Controls.Add(Me.ChromiumWebBrowserFreeBrowsing)
        Me.TabPageFreeBrowsing.Controls.Add(Me.PanelSeparatorFreeBrowsing)
        Me.TabPageFreeBrowsing.Controls.Add(Me.PanelFreeBrowsing)
        Me.TabPageFreeBrowsing.Location = New System.Drawing.Point(4, 22)
        Me.TabPageFreeBrowsing.Name = "TabPageFreeBrowsing"
        Me.TabPageFreeBrowsing.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageFreeBrowsing.Size = New System.Drawing.Size(1256, 655)
        Me.TabPageFreeBrowsing.TabIndex = 2
        Me.TabPageFreeBrowsing.Text = "Free Browsing"
        Me.TabPageFreeBrowsing.UseVisualStyleBackColor = True
        '
        'PanelSeparatorFreeBrowsing
        '
        Me.PanelSeparatorFreeBrowsing.BackColor = System.Drawing.Color.Black
        Me.PanelSeparatorFreeBrowsing.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSeparatorFreeBrowsing.Location = New System.Drawing.Point(3, 40)
        Me.PanelSeparatorFreeBrowsing.Name = "PanelSeparatorFreeBrowsing"
        Me.PanelSeparatorFreeBrowsing.Size = New System.Drawing.Size(1250, 2)
        Me.PanelSeparatorFreeBrowsing.TabIndex = 2
        '
        'PanelFreeBrowsing
        '
        Me.PanelFreeBrowsing.Controls.Add(Me.ButtonFreeBrowsingHome)
        Me.PanelFreeBrowsing.Controls.Add(Me.ButtonFreeBrowsingReload)
        Me.PanelFreeBrowsing.Controls.Add(Me.ButtonFreeBrowsingNext)
        Me.PanelFreeBrowsing.Controls.Add(Me.ButtonFreeBrowsingPrevious)
        Me.PanelFreeBrowsing.Controls.Add(Me.ButtonFreeBrowsingNavigate)
        Me.PanelFreeBrowsing.Controls.Add(Me.TextBoxFreeBrowsingUrl)
        Me.PanelFreeBrowsing.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelFreeBrowsing.Location = New System.Drawing.Point(3, 3)
        Me.PanelFreeBrowsing.Name = "PanelFreeBrowsing"
        Me.PanelFreeBrowsing.Size = New System.Drawing.Size(1250, 37)
        Me.PanelFreeBrowsing.TabIndex = 0
        '
        'ButtonFreeBrowsingHome
        '
        Me.ButtonFreeBrowsingHome.BackgroundImage = Global.My.Resources.Resources.homepage
        Me.ButtonFreeBrowsingHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonFreeBrowsingHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFreeBrowsingHome.FlatAppearance.BorderSize = 0
        Me.ButtonFreeBrowsingHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFreeBrowsingHome.Location = New System.Drawing.Point(5, 6)
        Me.ButtonFreeBrowsingHome.Name = "ButtonFreeBrowsingHome"
        Me.ButtonFreeBrowsingHome.Size = New System.Drawing.Size(24, 23)
        Me.ButtonFreeBrowsingHome.TabIndex = 0
        Me.ButtonFreeBrowsingHome.UseVisualStyleBackColor = True
        '
        'ButtonFreeBrowsingReload
        '
        Me.ButtonFreeBrowsingReload.BackgroundImage = Global.My.Resources.Resources.reload
        Me.ButtonFreeBrowsingReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonFreeBrowsingReload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFreeBrowsingReload.FlatAppearance.BorderSize = 0
        Me.ButtonFreeBrowsingReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFreeBrowsingReload.Location = New System.Drawing.Point(35, 6)
        Me.ButtonFreeBrowsingReload.Name = "ButtonFreeBrowsingReload"
        Me.ButtonFreeBrowsingReload.Size = New System.Drawing.Size(24, 23)
        Me.ButtonFreeBrowsingReload.TabIndex = 1
        Me.ButtonFreeBrowsingReload.UseVisualStyleBackColor = True
        '
        'ButtonFreeBrowsingNext
        '
        Me.ButtonFreeBrowsingNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFreeBrowsingNext.BackgroundImage = Global.My.Resources.Resources.forward_disabled
        Me.ButtonFreeBrowsingNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonFreeBrowsingNext.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFreeBrowsingNext.FlatAppearance.BorderSize = 0
        Me.ButtonFreeBrowsingNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFreeBrowsingNext.Location = New System.Drawing.Point(1221, 6)
        Me.ButtonFreeBrowsingNext.Name = "ButtonFreeBrowsingNext"
        Me.ButtonFreeBrowsingNext.Size = New System.Drawing.Size(24, 23)
        Me.ButtonFreeBrowsingNext.TabIndex = 5
        Me.ButtonFreeBrowsingNext.UseVisualStyleBackColor = True
        '
        'ButtonFreeBrowsingPrevious
        '
        Me.ButtonFreeBrowsingPrevious.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFreeBrowsingPrevious.BackgroundImage = Global.My.Resources.Resources.backward_disabled
        Me.ButtonFreeBrowsingPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonFreeBrowsingPrevious.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFreeBrowsingPrevious.FlatAppearance.BorderSize = 0
        Me.ButtonFreeBrowsingPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFreeBrowsingPrevious.Location = New System.Drawing.Point(1191, 6)
        Me.ButtonFreeBrowsingPrevious.Name = "ButtonFreeBrowsingPrevious"
        Me.ButtonFreeBrowsingPrevious.Size = New System.Drawing.Size(24, 23)
        Me.ButtonFreeBrowsingPrevious.TabIndex = 4
        Me.ButtonFreeBrowsingPrevious.UseVisualStyleBackColor = True
        '
        'ButtonFreeBrowsingNavigate
        '
        Me.ButtonFreeBrowsingNavigate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFreeBrowsingNavigate.BackgroundImage = Global.My.Resources.Resources.go
        Me.ButtonFreeBrowsingNavigate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonFreeBrowsingNavigate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonFreeBrowsingNavigate.FlatAppearance.BorderSize = 0
        Me.ButtonFreeBrowsingNavigate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFreeBrowsingNavigate.Location = New System.Drawing.Point(1161, 6)
        Me.ButtonFreeBrowsingNavigate.Name = "ButtonFreeBrowsingNavigate"
        Me.ButtonFreeBrowsingNavigate.Size = New System.Drawing.Size(24, 23)
        Me.ButtonFreeBrowsingNavigate.TabIndex = 3
        Me.ButtonFreeBrowsingNavigate.UseVisualStyleBackColor = True
        '
        'TextBoxFreeBrowsingUrl
        '
        Me.TextBoxFreeBrowsingUrl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFreeBrowsingUrl.Location = New System.Drawing.Point(65, 8)
        Me.TextBoxFreeBrowsingUrl.Name = "TextBoxFreeBrowsingUrl"
        Me.TextBoxFreeBrowsingUrl.Size = New System.Drawing.Size(1090, 20)
        Me.TextBoxFreeBrowsingUrl.TabIndex = 2
        '
        'ChromiumWebBrowserFreeBrowsing
        '
        Me.ChromiumWebBrowserFreeBrowsing.ActivateBrowserOnCreation = False
        Me.ChromiumWebBrowserFreeBrowsing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChromiumWebBrowserFreeBrowsing.Location = New System.Drawing.Point(3, 42)
        Me.ChromiumWebBrowserFreeBrowsing.Name = "ChromiumWebBrowserFreeBrowsing"
        Me.ChromiumWebBrowserFreeBrowsing.Size = New System.Drawing.Size(1250, 610)
        Me.ChromiumWebBrowserFreeBrowsing.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.TabControlMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bulk Domain Search"
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageDomainSearch.ResumeLayout(False)
        Me.PanelDomainSearch.ResumeLayout(False)
        Me.PanelDomainSearch.PerformLayout()
        Me.TabPageFreeBrowsing.ResumeLayout(False)
        Me.PanelFreeBrowsing.ResumeLayout(False)
        Me.PanelFreeBrowsing.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlMain As TabControl
    Friend WithEvents TabPageDomainSearch As TabPage
    Friend WithEvents TabPageFreeBrowsing As TabPage
    Friend WithEvents PanelFreeBrowsing As Panel
    Friend WithEvents ButtonFreeBrowsingNavigate As Button
    Friend WithEvents TextBoxFreeBrowsingUrl As TextBox
    Friend WithEvents PanelDomainSearch As Panel
    Friend WithEvents ButtonDomainSearchHome As Button
    Friend WithEvents TextBoxDomainSearchUrl As TextBox
    Friend WithEvents Panel1SeparatorDomainSearch As Panel
    Friend WithEvents PanelSeparatorFreeBrowsing As Panel
    Friend WithEvents ButtonDomainSearchNext As Button
    Friend WithEvents ButtonDomainSearchPrevious As Button
    Friend WithEvents ButtonDomainSearchReload As Button
    Friend WithEvents ButtonFreeBrowsingReload As Button
    Friend WithEvents ButtonFreeBrowsingNext As Button
    Friend WithEvents ButtonFreeBrowsingPrevious As Button
    Friend WithEvents ButtonFreeBrowsingHome As Button
    Friend WithEvents ChromiumWebBrowserDomainSearch As CefSharp.WinForms.ChromiumWebBrowser
    Friend WithEvents ChromiumWebBrowserFreeBrowsing As CefSharp.WinForms.ChromiumWebBrowser
End Class
