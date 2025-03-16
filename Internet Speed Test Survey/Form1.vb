' Program Name: Party Platters
' Author:       Wong Zhi Wei
' Date:         16/3/2025
' Purpose:      This Windows Classic Desktop application finds the average speed of a home Internet connection
'               (see speedtest.net to measure your own connection's download speed).


Public Class frmInternetSpeed
    Private Sub btnEnterSpeed_Click(sender As Object, e As EventArgs) Handles btnEnterSpeed.Click
        Dim strSpeed As String
        Dim decSpeed As Decimal
        Dim decSumSpeeds As Decimal
        Dim decAverageSpeed As Decimal = 0D

        Dim strInputMsg As String = "Please enter the your home Internet Speed in Mbps: #"
        Dim strInputEnding As String = vbCrLf & "Click Cancel when done!"
        Dim strInputTitle As String = "Internet Speed"
        Dim strNotNumericErrMsg As String = "Error - input must be a number: User #"
        Dim strNegativeErrMsg As String = "Error - input must be positive: User #"

        Dim intMaxEntries As Integer = 10
        Dim intEntryCount As Integer = 1

        strSpeed = InputBox(strInputMsg & intEntryCount & strInputEnding, strInputTitle)

        Do Until intEntryCount > intMaxEntries Or strSpeed = ""
            If IsNumeric(strSpeed) Then
                decSpeed = Convert.ToDecimal(strSpeed)
                If decSpeed > 0 Then
                    lstSpeed.Items.Add(decSpeed)
                    decSumSpeeds += decSpeed
                    intEntryCount += 1
                    strInputMsg = "Enter the number of Mbps of your home internet speed: User #"
                Else
                    strInputMsg = strNegativeErrMsg
                End If
            Else
                strInputMsg = strNotNumericErrMsg
            End If
            If intEntryCount <= intMaxEntries Then
                strSpeed = InputBox(strInputMsg & intEntryCount, strInputTitle)
            End If
        Loop

        lblAverageSpeed.Visible = True

        If intEntryCount > 1 Then
            decAverageSpeed = decSumSpeeds / (intEntryCount - 1)
            lblAverageSpeed.Text = "Average Internet Speed: " & decAverageSpeed.ToString("F2") & " Mbps"
        Else
            lblAverageSpeed.Text = "No Speed Values Entered"
        End If

        btnEnterSpeed.Enabled = False

    End Sub

End Class
