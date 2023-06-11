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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.State = New System.Windows.Forms.TextBox()
        Me.ZipCode = New System.Windows.Forms.MaskedTextBox()
        Me.City = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VehicleType = New System.Windows.Forms.GroupBox()
        Me.CommercialOption = New System.Windows.Forms.RadioButton()
        Me.TruckOption = New System.Windows.Forms.RadioButton()
        Me.AutoOption = New System.Windows.Forms.RadioButton()
        Me.SelectColor = New System.Windows.Forms.GroupBox()
        Me.BlueOption = New System.Windows.Forms.RadioButton()
        Me.GreenOption = New System.Windows.Forms.RadioButton()
        Me.YellowOption = New System.Windows.Forms.RadioButton()
        Me.GrayOption = New System.Windows.Forms.RadioButton()
        Me.VisibilityCheckBox = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VehicleName = New System.Windows.Forms.TextBox()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Output = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.VehicleType.SuspendLayout()
        Me.SelectColor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.State)
        Me.GroupBox1.Controls.Add(Me.ZipCode)
        Me.GroupBox1.Controls.Add(Me.City)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Address)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CustomerName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.VehicleType)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(467, 119)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'State
        '
        Me.State.Location = New System.Drawing.Point(209, 78)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(37, 20)
        Me.State.TabIndex = 8
        '
        'ZipCode
        '
        Me.ZipCode.Location = New System.Drawing.Point(252, 78)
        Me.ZipCode.Mask = "00000-9999"
        Me.ZipCode.Name = "ZipCode"
        Me.ZipCode.Size = New System.Drawing.Size(64, 20)
        Me.ZipCode.TabIndex = 7
        '
        'City
        '
        Me.City.Location = New System.Drawing.Point(97, 78)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(106, 20)
        Me.City.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "City/State/Zip:"
        '
        'Address
        '
        Me.Address.Location = New System.Drawing.Point(97, 47)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(219, 20)
        Me.Address.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Address:"
        '
        'CustomerName
        '
        Me.CustomerName.Location = New System.Drawing.Point(97, 16)
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(219, 20)
        Me.CustomerName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer Name:"
        '
        'VehicleType
        '
        Me.VehicleType.Controls.Add(Me.CommercialOption)
        Me.VehicleType.Controls.Add(Me.TruckOption)
        Me.VehicleType.Controls.Add(Me.AutoOption)
        Me.VehicleType.Location = New System.Drawing.Point(333, 16)
        Me.VehicleType.Name = "VehicleType"
        Me.VehicleType.Size = New System.Drawing.Size(117, 93)
        Me.VehicleType.TabIndex = 0
        Me.VehicleType.TabStop = False
        Me.VehicleType.Text = "Vehicle Type"
        '
        'CommercialOption
        '
        Me.CommercialOption.AutoSize = True
        Me.CommercialOption.Location = New System.Drawing.Point(23, 66)
        Me.CommercialOption.Name = "CommercialOption"
        Me.CommercialOption.Size = New System.Drawing.Size(79, 17)
        Me.CommercialOption.TabIndex = 2
        Me.CommercialOption.Text = "Commercial"
        Me.CommercialOption.UseVisualStyleBackColor = True
        '
        'TruckOption
        '
        Me.TruckOption.AutoSize = True
        Me.TruckOption.Location = New System.Drawing.Point(23, 43)
        Me.TruckOption.Name = "TruckOption"
        Me.TruckOption.Size = New System.Drawing.Size(53, 17)
        Me.TruckOption.TabIndex = 1
        Me.TruckOption.Text = "Truck"
        Me.TruckOption.UseVisualStyleBackColor = True
        '
        'AutoOption
        '
        Me.AutoOption.AutoSize = True
        Me.AutoOption.Checked = True
        Me.AutoOption.Location = New System.Drawing.Point(23, 20)
        Me.AutoOption.Name = "AutoOption"
        Me.AutoOption.Size = New System.Drawing.Size(47, 17)
        Me.AutoOption.TabIndex = 0
        Me.AutoOption.TabStop = True
        Me.AutoOption.Text = "Auto"
        Me.AutoOption.UseVisualStyleBackColor = True
        '
        'SelectColor
        '
        Me.SelectColor.Controls.Add(Me.BlueOption)
        Me.SelectColor.Controls.Add(Me.GreenOption)
        Me.SelectColor.Controls.Add(Me.YellowOption)
        Me.SelectColor.Controls.Add(Me.GrayOption)
        Me.SelectColor.Location = New System.Drawing.Point(498, 12)
        Me.SelectColor.Name = "SelectColor"
        Me.SelectColor.Size = New System.Drawing.Size(104, 119)
        Me.SelectColor.TabIndex = 1
        Me.SelectColor.TabStop = False
        Me.SelectColor.Text = "Select Color"
        '
        'BlueOption
        '
        Me.BlueOption.AutoSize = True
        Me.BlueOption.Location = New System.Drawing.Point(6, 92)
        Me.BlueOption.Name = "BlueOption"
        Me.BlueOption.Size = New System.Drawing.Size(46, 17)
        Me.BlueOption.TabIndex = 3
        Me.BlueOption.Text = "Blue"
        Me.BlueOption.UseVisualStyleBackColor = True
        '
        'GreenOption
        '
        Me.GreenOption.AutoSize = True
        Me.GreenOption.Location = New System.Drawing.Point(6, 65)
        Me.GreenOption.Name = "GreenOption"
        Me.GreenOption.Size = New System.Drawing.Size(54, 17)
        Me.GreenOption.TabIndex = 2
        Me.GreenOption.Text = "Green"
        Me.GreenOption.UseVisualStyleBackColor = True
        '
        'YellowOption
        '
        Me.YellowOption.AutoSize = True
        Me.YellowOption.Location = New System.Drawing.Point(6, 42)
        Me.YellowOption.Name = "YellowOption"
        Me.YellowOption.Size = New System.Drawing.Size(56, 17)
        Me.YellowOption.TabIndex = 1
        Me.YellowOption.Text = "Yellow"
        Me.YellowOption.UseVisualStyleBackColor = True
        '
        'GrayOption
        '
        Me.GrayOption.AutoSize = True
        Me.GrayOption.Checked = True
        Me.GrayOption.Location = New System.Drawing.Point(6, 19)
        Me.GrayOption.Name = "GrayOption"
        Me.GrayOption.Size = New System.Drawing.Size(47, 17)
        Me.GrayOption.TabIndex = 0
        Me.GrayOption.TabStop = True
        Me.GrayOption.Text = "Gray"
        Me.GrayOption.UseVisualStyleBackColor = True
        '
        'VisibilityCheckBox
        '
        Me.VisibilityCheckBox.AutoSize = True
        Me.VisibilityCheckBox.Checked = True
        Me.VisibilityCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VisibilityCheckBox.Location = New System.Drawing.Point(480, 155)
        Me.VisibilityCheckBox.Name = "VisibilityCheckBox"
        Me.VisibilityCheckBox.Size = New System.Drawing.Size(99, 17)
        Me.VisibilityCheckBox.TabIndex = 2
        Me.VisibilityCheckBox.Text = "Visible/Invisible"
        Me.VisibilityCheckBox.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 150)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(145, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(178, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Vehicle Information:"
        '
        'VehicleName
        '
        Me.VehicleName.Location = New System.Drawing.Point(284, 151)
        Me.VehicleName.Name = "VehicleName"
        Me.VehicleName.ReadOnly = True
        Me.VehicleName.Size = New System.Drawing.Size(148, 20)
        Me.VehicleName.TabIndex = 5
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(446, 196)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(75, 23)
        Me.DisplayButton.TabIndex = 7
        Me.DisplayButton.Text = "Display"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(527, 196)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(75, 23)
        Me.ResetButton.TabIndex = 8
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(446, 229)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 9
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(527, 229)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 10
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Output
        '
        Me.Output.Location = New System.Drawing.Point(178, 177)
        Me.Output.Multiline = True
        Me.Output.Name = "Output"
        Me.Output.ReadOnly = True
        Me.Output.Size = New System.Drawing.Size(254, 75)
        Me.Output.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 150)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(145, 102)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(12, 150)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(145, 102)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 272)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.VehicleName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.VisibilityCheckBox)
        Me.Controls.Add(Me.SelectColor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Bock Repair Parts - Paintsil Llewellyn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.VehicleType.ResumeLayout(False)
        Me.VehicleType.PerformLayout()
        Me.SelectColor.ResumeLayout(False)
        Me.SelectColor.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VehicleType As GroupBox
    Friend WithEvents CustomerName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Address As TextBox
    Friend WithEvents City As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CommercialOption As RadioButton
    Friend WithEvents TruckOption As RadioButton
    Friend WithEvents AutoOption As RadioButton
    Friend WithEvents State As TextBox
    Friend WithEvents ZipCode As MaskedTextBox
    Friend WithEvents SelectColor As GroupBox
    Friend WithEvents BlueOption As RadioButton
    Friend WithEvents GreenOption As RadioButton
    Friend WithEvents YellowOption As RadioButton
    Friend WithEvents GrayOption As RadioButton
    Friend WithEvents VisibilityCheckBox As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents VehicleName As TextBox
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Output As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
