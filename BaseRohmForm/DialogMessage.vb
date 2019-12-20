Public Class DialogMessage

    Private c_Message As String
    Private c_Url As String
    Private c_Header As String
    Public Sub New(message As String, url As String, header As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        c_Message = message
        c_Url = url
        c_Header = header
        'c_UrlName = urlName
        If String.IsNullOrEmpty(url) Then
            LinkLabelWeb.Visible = True
        End If
    End Sub
    Private Sub DialogMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelMessage.Text = c_Message
        LinkLabelWeb.Text = c_Url
        LabelHeader.Text = c_Header
    End Sub

    Private Sub LinkLabelWeb_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelWeb.LinkClicked
        Process.Start("iexplore.exe", c_Url)
    End Sub

    Private c_TimeTick As Boolean
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If c_TimeTick Then
            c_TimeTick = False
            Panel1.BackColor = Color.OrangeRed
        Else
            c_TimeTick = True
            Panel1.BackColor = Color.Silver
        End If
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.DialogResult = DialogResult.OK
    End Sub
End Class