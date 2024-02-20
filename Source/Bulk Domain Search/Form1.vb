#Region " Imports "

Imports System.Diagnostics

Imports CefSharp
Imports CefSharp.WinForms



'Imports DevCase.Core.Application.Tools
Imports DevCase.Core.Application.UserInterface
'Imports DevCase.Core.NET
'Imports DevCase.Core.Shell

#End Region

#Region " Form1 "

''' ----------------------------------------------------------------------------------------------------
''' <summary>
''' The main aplication <see cref="Form"/>.
''' </summary>
''' ----------------------------------------------------------------------------------------------------
Friend NotInheritable Class Form1 : Inherits Form

#Region " Private Fields "

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' A <see cref="ControlClickNotifier"/> object that handles the 
    ''' <see cref="ControlClickNotifier.TripleClick"/> event for <see cref="Form1.TextBoxDomainSearchUrl"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    Private WithEvents ClickNotifierTextBoxDomainSearch As ControlClickNotifier

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' A <see cref="ControlClickNotifier"/> object that handles the 
    ''' <see cref="ControlClickNotifier.TripleClick"/> event for <see cref="Form1.TextBoxFreeBrowsingUrl"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    Private WithEvents ClickNotifierTextBoxFreeBrowsing As ControlClickNotifier

#End Region

#Region " Constructors "

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Initializes a new instance of the <see cref="Form1"/> class.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    Public Sub New()
        MyClass.InitializeComponent()
        'Try
        '    AppUtil.SetIEBrowserEmulationMode(Process.GetCurrentProcess().ProcessName, RegistryScope.CurrentUser, IEBrowserEmulationMode.IE11Edge)
        'Catch 
        ' ' Do Nothing
        'End Try
    End Sub

#End Region

#Region " Event Handlers "

#Region " Form "

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="Form.Load"/> event of the <see cref="Form1"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(420, 480)

        Me.ClickNotifierTextBoxDomainSearch = New ControlClickNotifier(Me.TextBoxDomainSearchUrl)
        Me.ClickNotifierTextBoxFreeBrowsing = New ControlClickNotifier(Me.TextBoxFreeBrowsingUrl)

        ' Me.WebBrowserDomainSearch.Navigate(Homepages.DomainSearch)
        ' Me.WebBrowserFreeBrowsing.Navigate(Homepages.FreeBrowsing)
        Me.ChromiumWebBrowserDomainSearch.LoadUrl(Homepages.DomainSearch.ToString())
        Me.ChromiumWebBrowserFreeBrowsing.LoadUrl(Homepages.FreeBrowsing.ToString())
    End Sub

#End Region

#Region " Domain Search "

    '''' ----------------------------------------------------------------------------------------------------
    '''' <summary>
    '''' Handles the <see cref="WebBrowser.Navigated"/> event of the <see cref="Form1.WebBrowserDomainSearch"/> control.
    '''' </summary>
    '''' ----------------------------------------------------------------------------------------------------
    '''' <param name="sender">
    '''' The source of the event.
    '''' </param>
    '''' 
    '''' <param name="e">
    '''' The <see cref="WebBrowserNavigatedEventArgs"/> instance containing the event data.
    '''' </param>
    '''' ----------------------------------------------------------------------------------------------------
    'Private Sub WebBrowserDomainSearch_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowserDomainSearch.Navigated
    '    Me.TextBoxDomainSearchUrl.Text = DirectCast(sender, WebBrowser).Url.ToString()
    '    Me.SetNavigationButtonStates()
    'End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="ChromiumWebBrowser.LoadingStateChangedEventArgs"/> event 
    ''' of the <see cref="Form1.ChromiumWebBrowserDomainSearch"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="LoadingStateChangedEventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ChromiumWebBrowserDomainSearch_LoadingStateChanged(sender As Object, e As LoadingStateChangedEventArgs) Handles ChromiumWebBrowserDomainSearch.LoadingStateChanged
        Me.Invoke(
            Sub()
                Me.TextBoxDomainSearchUrl.Text = DirectCast(sender, ChromiumWebBrowser).Address
                Me.SetNavigationButtonStates()
            End Sub)
    End Sub

    '''' ----------------------------------------------------------------------------------------------------
    '''' <summary>
    '''' Handles the <see cref="WebBrowser.DocumentCompleted"/> event of the <see cref="Form1.WebBrowserDomainSearch"/> control.
    '''' </summary>
    '''' ----------------------------------------------------------------------------------------------------
    '''' <param name="sender">
    '''' The source of the event.
    '''' </param>
    '''' 
    '''' <param name="e">
    '''' The <see cref="WebBrowserDocumentCompletedEventArgs"/> instance containing the event data.
    '''' </param>
    '''' ----------------------------------------------------------------------------------------------------
    'Private Sub WebBrowserDomainSearch_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserDomainSearch.DocumentCompleted
    '    Me.TextBoxDomainSearchUrl.Text = DirectCast(sender, WebBrowser).Url.ToString()
    'End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="Button.Click"/> event of the <see cref="Form1.ButtonDomainSearchHome"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ButtonDomainSearchHome_Click(sender As Object, e As EventArgs) Handles ButtonDomainSearchHome.Click
        ' Me.WebBrowserDomainSearch.Navigate(Homepages.DomainSearch)
        Me.ChromiumWebBrowserDomainSearch.LoadUrl(Homepages.DomainSearch.ToString())
    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="Button.Click"/> event of the <see cref="Form1.ButtonDomainSearchReload"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ButtonDomainSearchReload_Click(sender As Object, e As EventArgs) Handles ButtonDomainSearchReload.Click
        ' Me.WebBrowserDomainSearch.Refresh(WebBrowserRefreshOption.Completely)
        Me.ChromiumWebBrowserDomainSearch.Reload(ignoreCache:=True)
    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="Button.Click"/> event of the <see cref="Form1.ButtonDomainSearchPrevious"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ButtonDomainSearchPrevious_Click(sender As Object, e As EventArgs) Handles ButtonDomainSearchPrevious.Click
        ' Me.WebBrowserDomainSearch.GoBack()
        If Me.ChromiumWebBrowserDomainSearch.CanGoBack Then
            Me.ChromiumWebBrowserDomainSearch.Back()
        End If
        Me.SetNavigationButtonStates()
    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="Button.Click"/> event of the <see cref="Form1.ButtonDomainSearchNext"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ButtonDomainSearchNext_Click(sender As Object, e As EventArgs) Handles ButtonDomainSearchNext.Click
        'Me.WebBrowserDomainSearch.GoForward()
        If Me.ChromiumWebBrowserDomainSearch.CanGoForward Then
            Me.ChromiumWebBrowserDomainSearch.Forward()
        End If
        Me.SetNavigationButtonStates()
    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="ControlClickNotifier.TripleClick"/> event of the <see cref="Form1.ClickNotifierTextBoxDomainSearch"/> object.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="MouseEventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ClickNotifierTextBoxDomainSearch_TripleClick(sender As Object, e As MouseEventArgs) Handles ClickNotifierTextBoxDomainSearch.TripleClick

        If (e.Button = MouseButtons.Left) Then
            Dim tb As TextBox = DirectCast(sender, TextBox)
            tb.SelectAll()
        End If

    End Sub

#End Region

#Region " Free Browsing "

    '''' ----------------------------------------------------------------------------------------------------
    '''' <summary>
    '''' Handles the <see cref="WebBrowser.Navigated"/> event of the <see cref="Form1.WebBrowserFreeBrowsing"/> control.
    '''' </summary>
    '''' ----------------------------------------------------------------------------------------------------
    '''' <param name="sender">
    '''' The source of the event.
    '''' </param>
    '''' 
    '''' <param name="e">
    '''' The <see cref="WebBrowserNavigatedEventArgs"/> instance containing the event data.
    '''' </param>
    '''' ----------------------------------------------------------------------------------------------------
    'Private Sub WebBrowserFreeBrowsing_Navigated(sender As Object, e As WebBrowserNavigatedEventArgs) Handles WebBrowserFreeBrowsing.Navigated
    '    Me.TextBoxFreeBrowsingUrl.Text = DirectCast(sender, WebBrowser).Url.ToString()
    '    Me.SetNavigationButtonStates()
    'End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="ChromiumWebBrowser.LoadingStateChangedEventArgs"/> event 
    ''' of the <see cref="Form1.ChromiumWebBrowserFreeBrowsing"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="LoadingStateChangedEventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ChromiumWebBrowserFreeBrowsing_LoadingStateChanged(sender As Object, e As LoadingStateChangedEventArgs) Handles ChromiumWebBrowserFreeBrowsing.LoadingStateChanged
        Me.Invoke(
            Sub()
                Me.TextBoxFreeBrowsingUrl.Text = DirectCast(sender, ChromiumWebBrowser).Address
                Me.SetNavigationButtonStates()
            End Sub)
    End Sub

    '''' ----------------------------------------------------------------------------------------------------
    '''' <summary>
    '''' Handles the <see cref="WebBrowser.DocumentCompleted"/> event of the <see cref="Form1.WebBrowserFreeBrowsing"/> control.
    '''' </summary>
    '''' ----------------------------------------------------------------------------------------------------
    '''' <param name="sender">
    '''' The source of the event.
    '''' </param>
    '''' 
    '''' <param name="e">
    '''' The <see cref="WebBrowserDocumentCompletedEventArgs"/> instance containing the event data.
    '''' </param>
    '''' ----------------------------------------------------------------------------------------------------
    'Private Sub WebBrowserFreeBrowsing_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserFreeBrowsing.DocumentCompleted
    '    Me.TextBoxFreeBrowsingUrl.Text = DirectCast(sender, WebBrowser).Url.ToString()
    'End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="TextBox.KeyUp"/> event of the <see cref="Form1.TextBoxFreeBrowsingUrl"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="KeyEventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub TextBoxFreeBrowsingUrl_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxFreeBrowsingUrl.KeyUp

        Select Case e.KeyCode

            Case Keys.Enter, Keys.Insert
                Me.ButtonFreeBrowsingNavigate.PerformClick()

            Case Else
                ' Do nothing.

        End Select

    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="Button.Click"/> event of the <see cref="Form1.ButtonFreeBrowsingNavigate"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ButtonFreeBrowsingNavigate_Click(sender As Object, e As EventArgs) Handles ButtonFreeBrowsingNavigate.Click

        Dim url As String = Me.TextBoxFreeBrowsingUrl.Text
        If Not String.IsNullOrEmpty(url) Then
            ' Me.WebBrowserFreeBrowsing.Navigate(url)
            Me.ChromiumWebBrowserFreeBrowsing.LoadUrl(url)
        End If

    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="Button.Click"/> event of the <see cref="Form1.ButtonFreeBrowsingHome"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ButtonFreeBrowsingHome_Click(sender As Object, e As EventArgs) Handles ButtonFreeBrowsingHome.Click
        ' Me.WebBrowserFreeBrowsing.Navigate(Homepages.FreeBrowsing)
        Me.ChromiumWebBrowserFreeBrowsing.LoadUrl(Homepages.FreeBrowsing.ToString())
    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="Button.Click"/> event of the <see cref="Form1.ButtonFreeBrowsingReload"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ButtonFreeBrowsingReload_Click(sender As Object, e As EventArgs) Handles ButtonFreeBrowsingReload.Click
        ' Me.WebBrowserFreeBrowsing.Refresh(WebBrowserRefreshOption.Completely)
        Me.ChromiumWebBrowserFreeBrowsing.Reload(ignoreCache:=True)
    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="Button.Click"/> event of the <see cref="Form1.ButtonFreeBrowsingPrevious"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ButtonFreeBrowsingPrevious_Click(sender As Object, e As EventArgs) Handles ButtonFreeBrowsingPrevious.Click
        ' Me.WebBrowserFreeBrowsing.GoBack()
        If Me.ChromiumWebBrowserFreeBrowsing.CanGoBack Then
            Me.ChromiumWebBrowserFreeBrowsing.Back()
        End If
        Me.SetNavigationButtonStates()
    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="Button.Click"/> event of the <see cref="Form1.ButtonFreeBrowsingNext"/> control.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="EventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ButtonFreeBrowsingNext_Click(sender As Object, e As EventArgs) Handles ButtonFreeBrowsingNext.Click
        ' Me.WebBrowserFreeBrowsing.GoForward()
        If Me.ChromiumWebBrowserFreeBrowsing.CanGoForward Then
            Me.ChromiumWebBrowserFreeBrowsing.Forward()
        End If
        Me.SetNavigationButtonStates()
    End Sub

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Handles the <see cref="ControlClickNotifier.TripleClick"/> event of the <see cref="Form1.ClickNotifierTextBoxFreeBrowsing"/> object.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <param name="sender">
    ''' The source of the event.
    ''' </param>
    ''' 
    ''' <param name="e">
    ''' The <see cref="MouseEventArgs"/> instance containing the event data.
    ''' </param>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub ClickNotifierTextBoxFreeBrowsing_TripleClick(sender As Object, e As MouseEventArgs) Handles ClickNotifierTextBoxFreeBrowsing.TripleClick

        If (e.Button = MouseButtons.Left) Then
            Dim tb As TextBox = DirectCast(sender, TextBox)
            tb.SelectAll()
        End If

    End Sub

#End Region

#End Region

#Region " Private Methods "

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Sets the <see cref="Button.Enabled"/> state of the buttons in the user-interface.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    Private Sub SetNavigationButtonStates()

        ' Domain Search
        'Me.ButtonDomainSearchNext.Enabled = Me.WebBrowserDomainSearch.CanGoForward
        'Me.ButtonDomainSearchPrevious.Enabled = Me.WebBrowserDomainSearch.CanGoBack
        Me.ButtonDomainSearchNext.Enabled = Me.ChromiumWebBrowserDomainSearch.CanGoForward
        Me.ButtonDomainSearchPrevious.Enabled = Me.ChromiumWebBrowserDomainSearch.CanGoBack

        Me.ButtonDomainSearchNext.BackgroundImage =
            If(Me.ButtonDomainSearchNext.Enabled, My.Resources.forward, My.Resources.forward_disabled)

        Me.ButtonDomainSearchPrevious.BackgroundImage =
            If(Me.ButtonDomainSearchPrevious.Enabled, My.Resources.backward, My.Resources.backward_disabled)

        ' Free Browsing
        'Me.ButtonFreeBrowsingNext.Enabled = Me.WebBrowserFreeBrowsing.CanGoForward
        'Me.ButtonFreeBrowsingPrevious.Enabled = Me.WebBrowserFreeBrowsing.CanGoBack
        Me.ButtonFreeBrowsingNext.Enabled = Me.ChromiumWebBrowserFreeBrowsing.CanGoForward
        Me.ButtonFreeBrowsingPrevious.Enabled = Me.ChromiumWebBrowserFreeBrowsing.CanGoBack

        Me.ButtonFreeBrowsingNext.BackgroundImage =
            If(Me.ButtonFreeBrowsingNext.Enabled, My.Resources.forward, My.Resources.forward_disabled)

        Me.ButtonFreeBrowsingPrevious.BackgroundImage =
            If(Me.ButtonFreeBrowsingPrevious.Enabled, My.Resources.backward, My.Resources.backward_disabled)

    End Sub

#End Region

End Class

#End Region
