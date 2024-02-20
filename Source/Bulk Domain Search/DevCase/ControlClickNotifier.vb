' This source-code is freely distributed as part of "DevCase Class Library for .NET".
' 
' Maybe you would like to consider to buy this powerful set of libraries to support me. 
' You can do loads of things with my apis for a big amount of diverse thematics.
' 
' Here is a link to the purchase page:
' https://codecanyon.net/item/elektrokit-class-library-for-net/19260282
' 
' Thank you.

#Region " Public Members Summary "

#Region " Constructors "

' ControlClickNotifier.New(Control)

#End Region

#Region " Events "

' ControlClickNotifier.Click As EventHandler(Of MouseEventArgs)
' ControlClickNotifier.DoubleClick As EventHandler(Of MouseEventArgs)
' ControlClickNotifier.TripleClick As EventHandler(Of MouseEventArgs)

#End Region

#Region " Properties "

' ControlClickNotifier.Control As Control

#End Region

#Region " Methods "

' ControlClickNotifier.Dispose()

#End Region

#End Region

#Region " Usage Examples "

'Friend WithEvents ClickNotifier As ControlClickNotifier
'
'Public Sub Test() Handles MyBase.Shown
'
'    Me.ClickNotifier = New ControlClickNotifier(Me.TextBox1)
'
'End Sub
'
'Private Sub ClickNotifier_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) _
'Handles ClickNotifier.TripleClick
'
'    If (e.Button = MouseButtons.Left) Then
'
'        Dim tb As TextBox = DirectCast(sender, TextBox)
'        tb.SelectAll()
'
'    End If
'
'End Sub

#End Region

#Region " Imports "

Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

#End Region

#Region " Control-Click Notifier "

' ReSharper disable once CheckNamespace

Namespace DevCase.Core.Application.UserInterface

    ''' ----------------------------------------------------------------------------------------------------
    ''' <summary>
    ''' Notifies a click, double-click, or triple-click event on the specified <see cref="Control"/>.
    ''' </summary>
    ''' ----------------------------------------------------------------------------------------------------
    ''' <example> This is a code example that selects all the text on a TextBox when triple-click occurs.
    ''' <code>
    ''' Friend WithEvents ClickNotifier As ControlClickNotifier
    ''' 
    ''' Public Sub Test() Handles MyBase.Shown
    ''' 
    '''     Me.ClickNotifier = New ControlClickNotifier(Me.TextBox1)
    ''' 
    ''' End Sub
    ''' 
    ''' Private Sub ClickNotifier_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) _
    ''' Handles ClickNotifier.TripleClick
    ''' 
    '''     If (e.Button = MouseButtons.Left) Then
    ''' 
    '''         Dim tb As TextBox = DirectCast(sender, TextBox)
    '''         tb.SelectAll()
    ''' 
    '''     End If
    ''' 
    ''' End Sub
    ''' </code>
    ''' </example>
    ''' ----------------------------------------------------------------------------------------------------
    Public Class ControlClickNotifier : Implements IDisposable

#Region " Private Fields "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' The bounds of the area where a click occurs.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected clkArea As Rectangle

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' The size of the area where a double-click occurs.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected ReadOnly clkSize As Size

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Keeps track of the amount of times that a click occurs.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected clkCount As Integer

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' The double-click delay time, in ms.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected ReadOnly dblClkDelay As Integer

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' The mouse button clicked.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected mouseButton As MouseButtons

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' A <see cref="Timer"/> to measure the intervals for a double and triple clicks.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected WithEvents ClkTimer As Timer

#End Region

#Region " Properties "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Gets the <see cref="Control"/> that owns this instance.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <value>
        ''' The <see cref="Control"/> that owns this instance.
        ''' </value>
        ''' ----------------------------------------------------------------------------------------------------
        Public Overridable ReadOnly Property Control As Control
            <DebuggerStepThrough>
            Get
                Return Me.ControlB
            End Get
        End Property
        ''' ----------------------------------------------------------------------------------------------------
        ''' ( Backing field )
        ''' <summary>
        ''' Gets the <see cref="Control"/> that owns this instance.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Protected WithEvents ControlB As Control

#End Region

#Region " Events "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Occurs when a single click occurs in the owner <see cref="Control"/>.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Public Event Click As EventHandler(Of MouseEventArgs)

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Occurs when a double-click occurs in the owner <see cref="Control"/>.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Public Event DoubleClick As EventHandler(Of MouseEventArgs)

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Occurs when a triple-click occurs in the owner <see cref="Control"/>.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Public Event TripleClick As EventHandler(Of MouseEventArgs)

#End Region

#Region " Constructors "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Prevents a default instance of the <see cref="TripleClick"/> class from being created.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerNonUserCode>
        Private Sub New()
        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Initializes a new instance of the <see cref="TripleClick"/> class.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="ctrl">
        ''' The <see cref="Control"/>.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Public Sub New(ctrl As Control)

            Me.clkSize = SystemInformation.DoubleClickSize
            Me.dblClkDelay = SystemInformation.DoubleClickTime
            Me.ClkTimer = New Timer
            Me.ControlB = ctrl

        End Sub

#End Region

#Region " Event Invocators "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Raises <see cref="Click"/> event.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="e">
        ''' The <see cref="MouseEventArgs"/> instance containing the event data.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overridable Sub OnClick(e As MouseEventArgs)

            If (Me.ClickEvent Is Nothing) Then
                Exit Sub
            End If

            RaiseEvent Click(Me.ControlB, e)

        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Raises <see cref="DoubleClick"/> event.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="e">
        ''' The <see cref="MouseEventArgs"/> instance containing the event data.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overridable Sub OnDoubleClick(e As MouseEventArgs)

            If (Me.DoubleClickEvent Is Nothing) Then
                Exit Sub
            End If

            RaiseEvent DoubleClick(Me.ControlB, e)

        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Raises <see cref="TripleClick"/> event.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="e">
        ''' The <see cref="MouseEventArgs"/> instance containing the event data.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overridable Sub OnTripleClick(e As MouseEventArgs)

            If (Me.TripleClickEvent Is Nothing) Then
                Exit Sub
            End If

            RaiseEvent TripleClick(Me.ControlB, e)

        End Sub

#End Region

#Region " Private Methods "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Registers a first mouse click event.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="mButton">
        ''' The mouse button clicked.
        ''' </param>
        ''' 
        ''' <param name="clkPoint">
        ''' Click point for definition of the valid click area.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overridable Sub SetFirstClick(mButton As MouseButtons,
                                            clkPoint As Point)

            ' Stop the Click-Timer.
            Me.ClkTimer.Stop()

            ' Save the mouse button.
            Me.mouseButton = mButton

            ' This is the first click.
            Me.clkCount = 1

            ' Define the valid double-click area for any multi-clicking.
            Me.clkArea = New Rectangle(clkPoint.X - (Me.clkSize.Width \ 2), clkPoint.Y - (Me.clkSize.Height \ 2), Me.clkSize.Width, Me.clkSize.Height)

            ' Set the system default double-click delay.
            Me.ClkTimer.Interval = Me.dblClkDelay

            ' Start the Click-Timer.
            Me.ClkTimer.Start()

        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Registers a mouse click event.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="mButton">
        ''' The mouse button clicked.
        ''' </param>
        ''' 
        ''' <param name="clkPoint">
        ''' Click point for definition of the valid click area.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overridable Sub SetClick(mButton As MouseButtons,
                                      clkPoint As Point)

            If (Me.ClkTimer.Enabled) Then

                Me.ClkTimer.Stop()

                ' If working with the same button within a valid double-click area then...
                If (Me.mouseButton = mButton) AndAlso
                   (Me.clkArea.Contains(clkPoint)) Then

                    Me.clkCount += 1
                    Me.ClkTimer.Interval = Me.dblClkDelay
                    Me.ClkTimer.Start()

                Else
                    Me.SetFirstClick(mButton, clkPoint)

                End If

            Else
                Me.SetFirstClick(mButton, clkPoint)

            End If

        End Sub

#End Region

#Region " Event-Handlers "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Handles the <see cref="Timer.Tick"/> event of the <see cref="ClkTimer"/> control.
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
        <DebuggerStepThrough>
        Private Sub ClickTimer_Tick(sender As Object, e As EventArgs) _
        Handles ClkTimer.Tick

            Me.ClkTimer.Stop()
            Me.clkCount = 0

        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Handles the <see cref="Control.MouseDown"/> event of the <see cref="Control"/>.
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
        <DebuggerStepThrough>
        Private Sub Control_MouseDown(sender As Object, e As MouseEventArgs) _
        Handles ControlB.MouseDown

            Me.SetClick(e.Button, e.Location)

            Select Case Me.clkCount

                Case Is = 1
                    Me.OnClick(e)

                Case Is = 2
                    Me.OnDoubleClick(e)

                Case Is = 3
                    Me.clkCount = 0
                    Me.OnTripleClick(e)

            End Select

        End Sub

#End Region

#Region " IDisposable Implementation "

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Flag to detect redundant calls when disposing.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        Private isDisposed As Boolean = False

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Releases all the resources used by this instance.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Public Sub Dispose() Implements IDisposable.Dispose
            Me.Dispose(isDisposing:=True)
        End Sub

        ''' ----------------------------------------------------------------------------------------------------
        ''' <summary>
        ''' Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        ''' Releases unmanaged and, optionally, managed resources.
        ''' </summary>
        ''' ----------------------------------------------------------------------------------------------------
        ''' <param name="isDisposing">
        ''' <see langword="True"/>  to release both managed and unmanaged resources; 
        ''' <see langword="False"/> to release only unmanaged resources.
        ''' </param>
        ''' ----------------------------------------------------------------------------------------------------
        <DebuggerStepThrough>
        Protected Overridable Sub Dispose(isDisposing As Boolean)

            If (Not Me.isDisposed) AndAlso (isDisposing) Then

                RemoveHandler Me.ControlB.MouseDown, AddressOf Me.Control_MouseDown

                Me.ClkTimer.Dispose()
                Me.ClickEvent = Nothing
                Me.DoubleClickEvent = Nothing
                Me.TripleClickEvent = Nothing
                Me.ControlB = Nothing

            End If

            Me.isDisposed = True

        End Sub

#End Region

    End Class

End Namespace

#End Region