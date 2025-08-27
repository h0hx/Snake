Imports System.Net.Http
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Public Class SnakeForm1

    <DllImport("user32.dll")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function

    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = 2


    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Close()
    End Sub

    Private Sub SnakeForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        For Each username As String In AccountBox.Lines
            username = username.Trim()
            If username = "" OrElse username.StartsWith("account:", StringComparison.OrdinalIgnoreCase) Then
                Continue For
            End If
        Next


        Dim usernames() As String = DisplayNameBox.Lines
        DisplayNameBox.Clear()
        DisplayNameBox.Text = "Checking..." & Environment.NewLine

        Dim handler As New HttpClientHandler() With {
            .AllowAutoRedirect = True
        }

        Using client As New HttpClient()
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36")

            For Each username As String In usernames

                username = username.Trim()
                If username = "" Then Continue For


                Try

                    Dim url As String = "https://www.instagram.com/api/v1/users/web_profile_info/?username=" & username
                    Dim response As HttpResponseMessage = Await client.GetAsync(url)
                    Dim body As String = Await response.Content.ReadAsStringAsync()


                    If body.Contains("""user"":") Then
                        DisplayNameBox.AppendText(username & " → ✔ Exists" & Environment.NewLine)
                    Else
                        DisplayNameBox.AppendText(username & " → ❌ Not found" & Environment.NewLine)
                    End If

                Catch ex As Exception
                    DisplayNameBox.AppendText(username & " → Error: " & ex.Message & Environment.NewLine)
                End Try
            Next
        End Using
    End Sub

    Private Sub SnakeForm1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0)
        End If
    End Sub
End Class
