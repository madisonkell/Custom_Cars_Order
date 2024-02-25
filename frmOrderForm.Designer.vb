<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblCarType = New System.Windows.Forms.Label()
        Me.grpDrive = New System.Windows.Forms.GroupBox()
        Me.rdbElectric = New System.Windows.Forms.RadioButton()
        Me.rdbHybrid = New System.Windows.Forms.RadioButton()
        Me.rdbV4 = New System.Windows.Forms.RadioButton()
        Me.rdbV6 = New System.Windows.Forms.RadioButton()
        Me.rdbV8 = New System.Windows.Forms.RadioButton()
        Me.rdbV12 = New System.Windows.Forms.RadioButton()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkBluetooth = New System.Windows.Forms.CheckBox()
        Me.chkGPS = New System.Windows.Forms.CheckBox()
        Me.chkEntertainment = New System.Windows.Forms.CheckBox()
        Me.chkAC = New System.Windows.Forms.CheckBox()
        Me.chkStereo = New System.Windows.Forms.CheckBox()
        Me.chkCD = New System.Windows.Forms.CheckBox()
        Me.chkDefrost = New System.Windows.Forms.CheckBox()
        Me.chkHeatedSeats = New System.Windows.Forms.CheckBox()
        Me.chkLeatherSeats = New System.Windows.Forms.CheckBox()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.updCarName = New System.Windows.Forms.DomainUpDown()
        Me.updQuantity = New System.Windows.Forms.NumericUpDown()
        Me.grpDrive.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        CType(Me.updQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name : "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(153, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(496, 27)
        Me.txtName.TabIndex = 1
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(448, 62)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(72, 20)
        Me.lblQuantity.TabIndex = 3
        Me.lblQuantity.Text = "Quantity :"
        '
        'lblCarType
        '
        Me.lblCarType.AutoSize = True
        Me.lblCarType.Location = New System.Drawing.Point(24, 62)
        Me.lblCarType.Name = "lblCarType"
        Me.lblCarType.Size = New System.Drawing.Size(73, 20)
        Me.lblCarType.TabIndex = 4
        Me.lblCarType.Text = "Car Type :"
        '
        'grpDrive
        '
        Me.grpDrive.Controls.Add(Me.rdbElectric)
        Me.grpDrive.Controls.Add(Me.rdbHybrid)
        Me.grpDrive.Controls.Add(Me.rdbV4)
        Me.grpDrive.Controls.Add(Me.rdbV6)
        Me.grpDrive.Controls.Add(Me.rdbV8)
        Me.grpDrive.Controls.Add(Me.rdbV12)
        Me.grpDrive.Location = New System.Drawing.Point(24, 101)
        Me.grpDrive.Name = "grpDrive"
        Me.grpDrive.Size = New System.Drawing.Size(625, 80)
        Me.grpDrive.TabIndex = 5
        Me.grpDrive.TabStop = False
        Me.grpDrive.Text = "Drive Train Selection:"
        '
        'rdbElectric
        '
        Me.rdbElectric.AutoSize = True
        Me.rdbElectric.Location = New System.Drawing.Point(505, 36)
        Me.rdbElectric.Name = "rdbElectric"
        Me.rdbElectric.Size = New System.Drawing.Size(78, 24)
        Me.rdbElectric.TabIndex = 5
        Me.rdbElectric.TabStop = True
        Me.rdbElectric.Text = "Electric"
        Me.rdbElectric.UseVisualStyleBackColor = True
        '
        'rdbHybrid
        '
        Me.rdbHybrid.AutoSize = True
        Me.rdbHybrid.Location = New System.Drawing.Point(399, 36)
        Me.rdbHybrid.Name = "rdbHybrid"
        Me.rdbHybrid.Size = New System.Drawing.Size(75, 24)
        Me.rdbHybrid.TabIndex = 4
        Me.rdbHybrid.TabStop = True
        Me.rdbHybrid.Text = "Hybrid"
        Me.rdbHybrid.UseVisualStyleBackColor = True
        '
        'rdbV4
        '
        Me.rdbV4.AutoSize = True
        Me.rdbV4.Location = New System.Drawing.Point(307, 36)
        Me.rdbV4.Name = "rdbV4"
        Me.rdbV4.Size = New System.Drawing.Size(53, 24)
        Me.rdbV4.TabIndex = 3
        Me.rdbV4.TabStop = True
        Me.rdbV4.Text = "V-4"
        Me.rdbV4.UseVisualStyleBackColor = True
        '
        'rdbV6
        '
        Me.rdbV6.AutoSize = True
        Me.rdbV6.Location = New System.Drawing.Point(214, 36)
        Me.rdbV6.Name = "rdbV6"
        Me.rdbV6.Size = New System.Drawing.Size(53, 24)
        Me.rdbV6.TabIndex = 2
        Me.rdbV6.TabStop = True
        Me.rdbV6.Text = "V-6"
        Me.rdbV6.UseVisualStyleBackColor = True
        '
        'rdbV8
        '
        Me.rdbV8.AutoSize = True
        Me.rdbV8.Location = New System.Drawing.Point(116, 36)
        Me.rdbV8.Name = "rdbV8"
        Me.rdbV8.Size = New System.Drawing.Size(53, 24)
        Me.rdbV8.TabIndex = 1
        Me.rdbV8.TabStop = True
        Me.rdbV8.Text = "V-8"
        Me.rdbV8.UseVisualStyleBackColor = True
        '
        'rdbV12
        '
        Me.rdbV12.AutoSize = True
        Me.rdbV12.Location = New System.Drawing.Point(16, 36)
        Me.rdbV12.Name = "rdbV12"
        Me.rdbV12.Size = New System.Drawing.Size(61, 24)
        Me.rdbV12.TabIndex = 0
        Me.rdbV12.TabStop = True
        Me.rdbV12.Text = "V-12"
        Me.rdbV12.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkBluetooth)
        Me.grpOptions.Controls.Add(Me.chkGPS)
        Me.grpOptions.Controls.Add(Me.chkEntertainment)
        Me.grpOptions.Controls.Add(Me.chkAC)
        Me.grpOptions.Controls.Add(Me.chkStereo)
        Me.grpOptions.Controls.Add(Me.chkCD)
        Me.grpOptions.Controls.Add(Me.chkDefrost)
        Me.grpOptions.Controls.Add(Me.chkHeatedSeats)
        Me.grpOptions.Controls.Add(Me.chkLeatherSeats)
        Me.grpOptions.Location = New System.Drawing.Point(24, 187)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(625, 148)
        Me.grpOptions.TabIndex = 6
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options:"
        '
        'chkBluetooth
        '
        Me.chkBluetooth.AutoSize = True
        Me.chkBluetooth.Location = New System.Drawing.Point(424, 26)
        Me.chkBluetooth.Name = "chkBluetooth"
        Me.chkBluetooth.Size = New System.Drawing.Size(96, 24)
        Me.chkBluetooth.TabIndex = 8
        Me.chkBluetooth.Text = "Bluetooth"
        Me.chkBluetooth.UseVisualStyleBackColor = True
        '
        'chkGPS
        '
        Me.chkGPS.AutoSize = True
        Me.chkGPS.Location = New System.Drawing.Point(424, 63)
        Me.chkGPS.Name = "chkGPS"
        Me.chkGPS.Size = New System.Drawing.Size(57, 24)
        Me.chkGPS.TabIndex = 7
        Me.chkGPS.Text = "GPS"
        Me.chkGPS.UseVisualStyleBackColor = True
        '
        'chkEntertainment
        '
        Me.chkEntertainment.AutoSize = True
        Me.chkEntertainment.Location = New System.Drawing.Point(424, 106)
        Me.chkEntertainment.Name = "chkEntertainment"
        Me.chkEntertainment.Size = New System.Drawing.Size(182, 24)
        Me.chkEntertainment.TabIndex = 6
        Me.chkEntertainment.Text = "Entertainment Package"
        Me.chkEntertainment.UseVisualStyleBackColor = True
        '
        'chkAC
        '
        Me.chkAC.AutoSize = True
        Me.chkAC.Location = New System.Drawing.Point(214, 26)
        Me.chkAC.Name = "chkAC"
        Me.chkAC.Size = New System.Drawing.Size(140, 24)
        Me.chkAC.TabIndex = 5
        Me.chkAC.Text = "Air Conditioning"
        Me.chkAC.UseVisualStyleBackColor = True
        '
        'chkStereo
        '
        Me.chkStereo.AutoSize = True
        Me.chkStereo.Location = New System.Drawing.Point(214, 63)
        Me.chkStereo.Name = "chkStereo"
        Me.chkStereo.Size = New System.Drawing.Size(137, 24)
        Me.chkStereo.TabIndex = 4
        Me.chkStereo.Text = "Premium Stereo"
        Me.chkStereo.UseVisualStyleBackColor = True
        '
        'chkCD
        '
        Me.chkCD.AutoSize = True
        Me.chkCD.Location = New System.Drawing.Point(214, 106)
        Me.chkCD.Name = "chkCD"
        Me.chkCD.Size = New System.Drawing.Size(171, 24)
        Me.chkCD.TabIndex = 3
        Me.chkCD.Text = "CD/MP3 Connections"
        Me.chkCD.UseVisualStyleBackColor = True
        '
        'chkDefrost
        '
        Me.chkDefrost.AutoSize = True
        Me.chkDefrost.Location = New System.Drawing.Point(28, 106)
        Me.chkDefrost.Name = "chkDefrost"
        Me.chkDefrost.Size = New System.Drawing.Size(127, 24)
        Me.chkDefrost.TabIndex = 2
        Me.chkDefrost.Text = "Rear Defroster"
        Me.chkDefrost.UseVisualStyleBackColor = True
        '
        'chkHeatedSeats
        '
        Me.chkHeatedSeats.AutoSize = True
        Me.chkHeatedSeats.Location = New System.Drawing.Point(28, 63)
        Me.chkHeatedSeats.Name = "chkHeatedSeats"
        Me.chkHeatedSeats.Size = New System.Drawing.Size(119, 24)
        Me.chkHeatedSeats.TabIndex = 1
        Me.chkHeatedSeats.Text = "Heated Seats"
        Me.chkHeatedSeats.UseVisualStyleBackColor = True
        '
        'chkLeatherSeats
        '
        Me.chkLeatherSeats.AutoSize = True
        Me.chkLeatherSeats.Location = New System.Drawing.Point(28, 26)
        Me.chkLeatherSeats.Name = "chkLeatherSeats"
        Me.chkLeatherSeats.Size = New System.Drawing.Size(119, 24)
        Me.chkLeatherSeats.TabIndex = 0
        Me.chkLeatherSeats.Text = "Leather Seats"
        Me.chkLeatherSeats.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(24, 341)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(625, 55)
        Me.btnOrder.TabIndex = 0
        Me.btnOrder.Text = "Place Car(s) Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'updCarName
        '
        Me.updCarName.Items.Add("Coupe")
        Me.updCarName.Items.Add("Luxury")
        Me.updCarName.Items.Add("Sedan")
        Me.updCarName.Items.Add("Sports Edition")
        Me.updCarName.Items.Add("SUV")
        Me.updCarName.Location = New System.Drawing.Point(116, 60)
        Me.updCarName.Name = "updCarName"
        Me.updCarName.Size = New System.Drawing.Size(210, 27)
        Me.updCarName.TabIndex = 7
        Me.updCarName.Text = "Select A Car"
        '
        'updQuantity
        '
        Me.updQuantity.Location = New System.Drawing.Point(540, 60)
        Me.updQuantity.Name = "updQuantity"
        Me.updQuantity.Size = New System.Drawing.Size(109, 27)
        Me.updQuantity.TabIndex = 8
        '
        'frmOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 408)
        Me.Controls.Add(Me.updQuantity)
        Me.Controls.Add(Me.updCarName)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpDrive)
        Me.Controls.Add(Me.lblCarType)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOrderForm"
        Me.Text = "Kustom Kars Order Form"
        Me.grpDrive.ResumeLayout(False)
        Me.grpDrive.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        CType(Me.updQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblCarType As Label
    Friend WithEvents grpDrive As GroupBox
    Friend WithEvents rdbElectric As RadioButton
    Friend WithEvents rdbHybrid As RadioButton
    Friend WithEvents rdbV4 As RadioButton
    Friend WithEvents rdbV6 As RadioButton
    Friend WithEvents rdbV8 As RadioButton
    Friend WithEvents rdbV12 As RadioButton
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents btnOrder As Button
    Friend WithEvents chkBluetooth As CheckBox
    Friend WithEvents chkGPS As CheckBox
    Friend WithEvents chkEntertainment As CheckBox
    Friend WithEvents chkAC As CheckBox
    Friend WithEvents chkStereo As CheckBox
    Friend WithEvents chkCD As CheckBox
    Friend WithEvents chkDefrost As CheckBox
    Friend WithEvents chkHeatedSeats As CheckBox
    Friend WithEvents chkLeatherSeats As CheckBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents updCarName As DomainUpDown
    Friend WithEvents updQuantity As NumericUpDown
End Class
