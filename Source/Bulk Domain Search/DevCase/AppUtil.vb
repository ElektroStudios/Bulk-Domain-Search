'' This source-code is freely distributed as part of "DevCase Class Library for .NET".
'' 
'' Maybe you would like to consider to buy this powerful set of libraries to support me. 
'' You can do loads of things with my apis for a big amount of diverse thematics.
'' 
'' Here is a link to the purchase page:
'' https://codecanyon.net/item/elektrokit-class-library-for-net/19260282
'' 
'' Thank you.

'#Region " Option Statements "

'Option Strict On
'Option Explicit On
'Option Infer Off

'#End Region

'#Region " Imports "

'Imports System.IO

'Imports Microsoft.Win32

'Imports DevCase.Core.NET
'Imports DevCase.Core.Shell
'Imports System.Diagnostics

'#End Region

'#Region " App Util "

'' ReSharper disable once CheckNamespace

'Namespace DevCase.Core.Application.Tools

'    Partial Public NotInheritable Class AppUtil

'#Region " Properties "

'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <summary>
'        ''' Gets or sets the Internet Explorer browser emulation mode for the current application.
'        ''' </summary>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <seealso href="https://docs.microsoft.com/en-us/previous-versions/windows/internet-explorer/ie-developer/general-info/ee330730(v=vs.85)"/>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <example> This is a code example to get, set and verify the IE browser emulation mode for the current process.
'        ''' <code>
'        ''' Dim scope As RegistryScope = RegistryScope.CurrentUser
'        ''' Dim oldMode As IEBrowserEmulationMode
'        ''' Dim newMode As IEBrowserEmulationMode
'        ''' 
'        ''' oldMode = BrowserEmulationMode(scope)
'        ''' BrowserEmulationMode(scope) = IEBrowserEmulationMode.IE11Edge
'        ''' newMode = BrowserEmulationMode(scope)
'        ''' 
'        ''' Console.WriteLine(String.Format("Old Mode: {0} ({1})", oldMode, CStr(oldMode)))
'        ''' Console.WriteLine(String.Format("New Mode: {0} ({1})", newMode, CStr(newMode)))
'        ''' 
'        ''' Dim f As New Form() With {.Size = New Size(1280, 720)}
'        ''' Dim wb As New WebBrowser With {.Dock = DockStyle.Fill}
'        ''' f.Controls.Add(wb)
'        ''' f.Show()
'        ''' wb.Navigate("http://www.whatversion.net/browser/")
'        ''' </code>
'        ''' </example>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <param name="scope">
'        ''' The registry scope.
'        ''' </param>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <value>
'        ''' The Internet Explorer browser emulation mode.
'        ''' </value>
'        ''' ----------------------------------------------------------------------------------------------------
'        Public Shared Property BrowserEmulationMode(scope As RegistryScope) As IEBrowserEmulationMode
'            <DebuggerStepThrough>
'            Get
'                Return AppUtil.GetIEBrowserEmulationMode(Process.GetCurrentProcess().ProcessName, scope)
'            End Get
'            <DebuggerStepThrough>
'            Set(value As IEBrowserEmulationMode)
'                AppUtil.SetIEBrowserEmulationMode(Process.GetCurrentProcess().ProcessName, scope, value)
'            End Set
'        End Property

'#End Region

'#Region " Public Methods "

'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <summary>
'        ''' Gets the Internet Explorer browser emulation mode for the specified process.
'        ''' </summary>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <seealso href="https://docs.microsoft.com/en-us/previous-versions/windows/internet-explorer/ie-developer/general-info/ee330730(v=vs.85)"/>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <example> This is a code example.
'        ''' <code>
'        ''' Dim processName As String = Process.GetCurrentProcess().ProcessName
'        ''' Dim scope As RegistryScope = RegistryScope.CurrentUser
'        ''' Dim mode As IEBrowserEmulationMode = GetIEBrowserEmulationMode(processName, scope)
'        ''' 
'        ''' Console.WriteLine(String.Format("Mode: {0} ({1})", mode, CStr(mode)))
'        ''' </code>
'        ''' </example>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <param name="processName">
'        ''' The process name (eg. 'cmd.exe').
'        ''' </param>
'        ''' 
'        ''' <param name="scope">
'        ''' The registry scope.
'        ''' </param>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <returns>
'        ''' The resulting <see cref="IEBrowserEmulationMode"/>.
'        ''' </returns>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <exception cref="NotSupportedException">
'        ''' </exception>
'        ''' ----------------------------------------------------------------------------------------------------
'        <DebuggerStepThrough>
'        Public Shared Function GetIEBrowserEmulationMode(processName As String, scope As RegistryScope) As IEBrowserEmulationMode

'            processName = Path.GetFileNameWithoutExtension(processName)

'            Using rootKey As RegistryKey = If(scope = RegistryScope.CurrentUser,
'                                              RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default),
'                                              RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default)),
'                  subKey As RegistryKey = rootKey.CreateSubKey("Software\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION",
'                                                               RegistryKeyPermissionCheck.ReadSubTree)

'                Dim value As Integer =
'                    CInt(subKey.GetValue($"{processName}.exe", 0, RegistryValueOptions.None))

'                ' If no browser emulation mode is retrieved from registry, then return default mode for WebBrowser control.
'                If (value = 0) Then
'                    Return IEBrowserEmulationMode.IE7
'                End If

'                If [Enum].IsDefined(GetType(IEBrowserEmulationMode), value) Then
'                    Return DirectCast(value, IEBrowserEmulationMode)

'                Else
'                    Throw New NotSupportedException(
'                        $"Undefined browser emulation value retrieved from registry: '{value}'")

'                End If

'            End Using

'        End Function

'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <summary>
'        ''' Gets the Internet Explorer browser emulation mode for the specified process.
'        ''' </summary>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <seealso href="https://docs.microsoft.com/en-us/previous-versions/windows/internet-explorer/ie-developer/general-info/ee330730(v=vs.85)"/>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <example> This is a code example.
'        ''' <code>
'        ''' Dim p As Process = Process.GetCurrentProcess()
'        ''' Dim scope As RegistryScope = RegistryScope.CurrentUser
'        ''' Dim mode As IEBrowserEmulationMode = GetIEBrowserEmulationMode(p, scope)
'        ''' 
'        ''' Console.WriteLine(String.Format("Mode: {0} ({1})", mode, CStr(mode)))
'        ''' </code>
'        ''' </example>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <param name="p">
'        ''' The process.
'        ''' </param>
'        ''' 
'        ''' <param name="scope">
'        ''' The registry scope.
'        ''' </param>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <returns>
'        ''' The resulting <see cref="IEBrowserEmulationMode"/>.
'        ''' </returns>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <exception cref="NotSupportedException">
'        ''' </exception>
'        ''' ----------------------------------------------------------------------------------------------------
'        <DebuggerStepThrough>
'        Public Shared Function GetIEBrowserEmulationMode(p As Process, scope As RegistryScope) As IEBrowserEmulationMode

'            Return AppUtil.GetIEBrowserEmulationMode(p.ProcessName, scope)

'        End Function

'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <summary>
'        ''' Sets the Internet Explorer browser emulation mode for the specified process.
'        ''' </summary>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <seealso href="https://docs.microsoft.com/en-us/previous-versions/windows/internet-explorer/ie-developer/general-info/ee330730(v=vs.85)"/>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <example> This is a code example.
'        ''' <code>
'        ''' Dim processName As String = Process.GetCurrentProcess().ProcessName
'        ''' Dim scope As RegistryScope = RegistryScope.CurrentUser
'        ''' Dim oldMode As IEBrowserEmulationMode
'        ''' Dim newMode As IEBrowserEmulationMode
'        ''' 
'        ''' oldMode = GetIEBrowserEmulationMode(processName, scope)
'        ''' SetIEBrowserEmulationMode(processName, scope, IEBrowserEmulationMode.IE11Edge)
'        ''' newMode = GetIEBrowserEmulationMode(processName, scope)
'        ''' 
'        ''' Console.WriteLine(String.Format("Old Mode: {0} ({1})", oldMode, CStr(oldMode)))
'        ''' Console.WriteLine(String.Format("New Mode: {0} ({1})", newMode, CStr(newMode)))
'        ''' 
'        ''' Dim f As New Form() With {.Size = New Size(1280, 720)}
'        ''' Dim wb As New WebBrowser With {.Dock = DockStyle.Fill}
'        ''' f.Controls.Add(wb)
'        ''' f.Show()
'        ''' wb.Navigate("http://www.whatversion.net/browser/")
'        ''' </code>
'        ''' </example>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <param name="processName">
'        ''' The process name (eg. 'cmd.exe').
'        ''' </param>
'        ''' 
'        ''' <param name="scope">
'        ''' The registry scope.
'        ''' </param>
'        ''' 
'        ''' <param name="mode">
'        ''' The Internet Explorer browser emulation mode to set.
'        ''' </param>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <exception cref="NotSupportedException">
'        ''' </exception>
'        ''' ----------------------------------------------------------------------------------------------------
'        <DebuggerStepThrough>
'        Public Shared Sub SetIEBrowserEmulationMode(processName As String, scope As RegistryScope, mode As IEBrowserEmulationMode)

'            processName = Path.GetFileNameWithoutExtension(processName)

'            Dim currentIEBrowserEmulationMode As IEBrowserEmulationMode = GetIEBrowserEmulationMode(processName, scope)
'            If (currentIEBrowserEmulationMode = mode) Then
'                Exit Sub
'            End If

'            Using rootKey As RegistryKey = If(scope = RegistryScope.CurrentUser,
'                                              RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default),
'                                              RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default)),
'                  subKey As RegistryKey = rootKey.CreateSubKey(
'                            "Software\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION",
'                            RegistryKeyPermissionCheck.ReadWriteSubTree)

'                subKey.SetValue($"{processName}.exe", DirectCast(mode, Integer), RegistryValueKind.DWord)

'            End Using

'        End Sub

'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <summary>
'        ''' Sets the Internet Explorer browser emulation mode for the specified process.
'        ''' </summary>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <seealso href="https://docs.microsoft.com/en-us/previous-versions/windows/internet-explorer/ie-developer/general-info/ee330730(v=vs.85)"/>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <example> This is a code example.
'        ''' <code>
'        ''' Dim processName As Process = Process.GetCurrentProcess()
'        ''' Dim scope As RegistryScope = RegistryScope.CurrentUser
'        ''' Dim oldMode As IEBrowserEmulationMode
'        ''' Dim newMode As IEBrowserEmulationMode
'        ''' 
'        ''' oldMode = GetIEBrowserEmulationMode(p, scope)
'        ''' SetIEBrowserEmulationMode(p, scope, IEBrowserEmulationMode.IE11Edge)
'        ''' newMode = GetIEBrowserEmulationMode(p, scope)
'        ''' 
'        ''' Console.WriteLine(String.Format("Old Mode: {0} ({1})", oldMode, CStr(oldMode)))
'        ''' Console.WriteLine(String.Format("New Mode: {0} ({1})", newMode, CStr(newMode)))
'        ''' 
'        ''' Dim f As New Form() With {.Size = New Size(1280, 720)}
'        ''' Dim wb As New WebBrowser With {.Dock = DockStyle.Fill}
'        ''' f.Controls.Add(wb)
'        ''' f.Show()
'        ''' wb.Navigate("http://www.whatversion.net/browser/")
'        ''' </code>
'        ''' </example>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <param name="p">
'        ''' The process.
'        ''' </param>
'        ''' 
'        ''' <param name="scope">
'        ''' The registry scope.
'        ''' </param>
'        ''' 
'        ''' <param name="mode">
'        ''' The Internet Explorer browser emulation mode to set.
'        ''' </param>
'        ''' ----------------------------------------------------------------------------------------------------
'        ''' <exception cref="NotSupportedException">
'        ''' </exception>
'        ''' ----------------------------------------------------------------------------------------------------
'        <DebuggerStepThrough>
'        Public Shared Sub SetIEBrowserEmulationMode(p As Process, scope As RegistryScope, mode As IEBrowserEmulationMode)

'            AppUtil.SetIEBrowserEmulationMode(p.ProcessName, scope, mode)

'        End Sub

'#End Region

'    End Class

'End Namespace

'#End Region
