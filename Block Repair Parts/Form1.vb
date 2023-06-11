Imports System.Net.NetworkInformation

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub GrayOption_CheckedChanged(sender As Object, e As EventArgs) Handles GrayOption.CheckedChanged
        Me.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ' Clear input and output TextBox and MaskedTextBox controls
        CustomerName.Clear()
        Address.Clear()
        City.Clear()
        State.Clear()
        ZipCode.Clear()
        Output.Clear()
        ' Set default values
        AutoOption.Checked = True
        GrayOption.Checked = True
        VisibilityCheckBox.Checked = True

        ' Set focus to the customer name TextBox
        CustomerName.Focus()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        ' Concatenate customer name and vehicle info into a message
        Dim message As String = "Congratulations, " & CustomerName.Text & "!" & Environment.NewLine &
                                "Discount repair parts for your selected " & VehicleName.Text &
                                " available by contacting us at 800-555-1925"

        ' Display the message in the output TextBox
        Output.Text = message
    End Sub

    Private Sub AutoOption_CheckedChanged(sender As Object, e As EventArgs) Handles AutoOption.CheckedChanged
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        VehicleName.Text = "GMC Auto Truck"
    End Sub

    Private Sub TruckOption_CheckedChanged(sender As Object, e As EventArgs) Handles TruckOption.CheckedChanged
        PictureBox1.Visible = False
        PictureBox2.Visible = True
        PictureBox3.Visible = False
        VehicleName.Text = "GMC Truck"
    End Sub

    Private Sub CommercialOption_CheckedChanged(sender As Object, e As EventArgs) Handles CommercialOption.CheckedChanged
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = True
        VehicleName.Text = "GMC Commercial Truck"
    End Sub

    Private Sub YellowOption_CheckedChanged(sender As Object, e As EventArgs) Handles YellowOption.CheckedChanged
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub GreenOption_CheckedChanged(sender As Object, e As EventArgs) Handles GreenOption.CheckedChanged
        Me.BackColor = Color.Green
    End Sub

    Private Sub BlueOption_CheckedChanged(sender As Object, e As EventArgs) Handles BlueOption.CheckedChanged
        Me.BackColor = Color.Blue
    End Sub

    Private Sub VisibilityCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles VisibilityCheckBox.CheckedChanged
        If VisibilityCheckBox.Checked Then
            VehicleName.Visible = True
            Output.Visible = True
        Else
            VehicleName.Visible = False
            Output.Visible = False
        End If
    End Sub
End Class
