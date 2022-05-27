<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Header = New System.Windows.Forms.Label()
        Me.SubHeader = New System.Windows.Forms.Label()
        Me.InvoiceNo = New System.Windows.Forms.Label()
        Me.InvoiceDate = New System.Windows.Forms.Label()
        Me.SupplyName = New System.Windows.Forms.Label()
        Me.TxtBoxInvoiceNo = New System.Windows.Forms.TextBox()
        Me.TxtBoxSupply = New System.Windows.Forms.TextBox()
        Me.lblproduct = New System.Windows.Forms.Label()
        Me.TxtBoxProduct = New System.Windows.Forms.TextBox()
        Me.lblExPdate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtBoxInDate = New System.Windows.Forms.DateTimePicker()
        Me.TxtBoxExpDate = New System.Windows.Forms.DateTimePicker()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.DisplayBox = New System.Windows.Forms.TextBox()
        Me.btnok = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.displaydesc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Form1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Header
        '
        Me.Header.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Header.Font = New System.Drawing.Font("DejaVu Sans", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.ForeColor = System.Drawing.Color.Green
        Me.Header.Location = New System.Drawing.Point(375, 9)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(250, 30)
        Me.Header.TabIndex = 0
        Me.Header.Text = "TRADEWORLD"
        Me.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SubHeader
        '
        Me.SubHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubHeader.Location = New System.Drawing.Point(410, 40)
        Me.SubHeader.Name = "SubHeader"
        Me.SubHeader.Size = New System.Drawing.Size(180, 30)
        Me.SubHeader.TabIndex = 1
        Me.SubHeader.Text = "STOCK EXPIRY"
        Me.SubHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InvoiceNo
        '
        Me.InvoiceNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.InvoiceNo.Location = New System.Drawing.Point(26, 116)
        Me.InvoiceNo.Name = "InvoiceNo"
        Me.InvoiceNo.Size = New System.Drawing.Size(198, 24)
        Me.InvoiceNo.TabIndex = 2
        Me.InvoiceNo.Text = "Invoice Number"
        '
        'InvoiceDate
        '
        Me.InvoiceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.InvoiceDate.Location = New System.Drawing.Point(364, 116)
        Me.InvoiceDate.Name = "InvoiceDate"
        Me.InvoiceDate.Size = New System.Drawing.Size(198, 24)
        Me.InvoiceDate.TabIndex = 3
        Me.InvoiceDate.Text = "Invoice Date"
        '
        'SupplyName
        '
        Me.SupplyName.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.SupplyName.Location = New System.Drawing.Point(636, 115)
        Me.SupplyName.Name = "SupplyName"
        Me.SupplyName.Size = New System.Drawing.Size(198, 24)
        Me.SupplyName.TabIndex = 4
        Me.SupplyName.Text = "Supplier Name"
        '
        'TxtBoxInvoiceNo
        '
        Me.TxtBoxInvoiceNo.Font = New System.Drawing.Font("Calibri Light", 11.0!)
        Me.TxtBoxInvoiceNo.Location = New System.Drawing.Point(167, 115)
        Me.TxtBoxInvoiceNo.MaxLength = 5
        Me.TxtBoxInvoiceNo.Name = "TxtBoxInvoiceNo"
        Me.TxtBoxInvoiceNo.Size = New System.Drawing.Size(172, 25)
        Me.TxtBoxInvoiceNo.TabIndex = 1
        '
        'TxtBoxSupply
        '
        Me.TxtBoxSupply.Font = New System.Drawing.Font("Calibri Light", 11.0!)
        Me.TxtBoxSupply.Location = New System.Drawing.Point(783, 115)
        Me.TxtBoxSupply.MaxLength = 35
        Me.TxtBoxSupply.Name = "TxtBoxSupply"
        Me.TxtBoxSupply.Size = New System.Drawing.Size(172, 25)
        Me.TxtBoxSupply.TabIndex = 3
        '
        'lblproduct
        '
        Me.lblproduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblproduct.Location = New System.Drawing.Point(26, 224)
        Me.lblproduct.Name = "lblproduct"
        Me.lblproduct.Size = New System.Drawing.Size(198, 24)
        Me.lblproduct.TabIndex = 10
        Me.lblproduct.Text = "Product Name"
        '
        'TxtBoxProduct
        '
        Me.TxtBoxProduct.Font = New System.Drawing.Font("Calibri Light", 11.0!)
        Me.TxtBoxProduct.Location = New System.Drawing.Point(167, 223)
        Me.TxtBoxProduct.MaxLength = 25
        Me.TxtBoxProduct.Name = "TxtBoxProduct"
        Me.TxtBoxProduct.Size = New System.Drawing.Size(172, 25)
        Me.TxtBoxProduct.TabIndex = 4
        '
        'lblExPdate
        '
        Me.lblExPdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.lblExPdate.Location = New System.Drawing.Point(364, 223)
        Me.lblExPdate.Name = "lblExPdate"
        Me.lblExPdate.Size = New System.Drawing.Size(198, 24)
        Me.lblExPdate.TabIndex = 13
        Me.lblExPdate.Text = "Expiry Date"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(928, 56)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = resources.GetString("Label2.Text")
        '
        'TxtBoxInDate
        '
        Me.TxtBoxInDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.TxtBoxInDate.CustomFormat = " dd-MM-yyyy"
        Me.TxtBoxInDate.Font = New System.Drawing.Font("Calibri Light", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtBoxInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtBoxInDate.Location = New System.Drawing.Point(492, 116)
        Me.TxtBoxInDate.Name = "TxtBoxInDate"
        Me.TxtBoxInDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtBoxInDate.Size = New System.Drawing.Size(118, 25)
        Me.TxtBoxInDate.TabIndex = 2
        '
        'TxtBoxExpDate
        '
        Me.TxtBoxExpDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 7.0!)
        Me.TxtBoxExpDate.CustomFormat = " dd-MM-yyyy"
        Me.TxtBoxExpDate.Font = New System.Drawing.Font("Calibri Light", 11.0!, System.Drawing.FontStyle.Italic)
        Me.TxtBoxExpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtBoxExpDate.Location = New System.Drawing.Point(492, 222)
        Me.TxtBoxExpDate.Name = "TxtBoxExpDate"
        Me.TxtBoxExpDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtBoxExpDate.Size = New System.Drawing.Size(118, 25)
        Me.TxtBoxExpDate.TabIndex = 5
        Me.TxtBoxExpDate.Value = New Date(2020, 1, 1, 12, 23, 0, 0)
        '
        'btnDisplay
        '
        Me.btnDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnDisplay.Location = New System.Drawing.Point(30, 336)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(80, 28)
        Me.btnDisplay.TabIndex = 7
        Me.btnDisplay.Text = "&Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'DisplayBox
        '
        Me.DisplayBox.AcceptsTab = True
        Me.DisplayBox.BackColor = System.Drawing.SystemColors.Window
        Me.DisplayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DisplayBox.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayBox.Location = New System.Drawing.Point(30, 398)
        Me.DisplayBox.MaxLength = 94
        Me.DisplayBox.Multiline = True
        Me.DisplayBox.Name = "DisplayBox"
        Me.DisplayBox.ReadOnly = True
        Me.DisplayBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DisplayBox.Size = New System.Drawing.Size(925, 177)
        Me.DisplayBox.TabIndex = 100
        '
        'btnok
        '
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnok.Location = New System.Drawing.Point(451, 271)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(80, 28)
        Me.btnok.TabIndex = 101
        Me.btnok.Text = "&Submit"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(925, 19)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Invoice No.     Invoice Date            Supplier                                 " &
    "    Product                                                                     " &
    "         Expiry Date"
        '
        'displaydesc
        '
        Me.displaydesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.displaydesc.ForeColor = System.Drawing.Color.DarkRed
        Me.displaydesc.Location = New System.Drawing.Point(126, 342)
        Me.displaydesc.Name = "displaydesc"
        Me.displaydesc.Size = New System.Drawing.Size(405, 24)
        Me.displaydesc.TabIndex = 108
        Me.displaydesc.Text = "all items that are expiring tomorrow."
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-3, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1000, 41)
        Me.Label1.TabIndex = 109
        '
        'Form1BindingSource
        '
        Me.Form1BindingSource.DataSource = GetType(TRADEWORLD.Form1)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(984, 606)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.displaydesc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnok)
        Me.Controls.Add(Me.DisplayBox)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.TxtBoxExpDate)
        Me.Controls.Add(Me.TxtBoxInDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblExPdate)
        Me.Controls.Add(Me.TxtBoxProduct)
        Me.Controls.Add(Me.lblproduct)
        Me.Controls.Add(Me.TxtBoxSupply)
        Me.Controls.Add(Me.TxtBoxInvoiceNo)
        Me.Controls.Add(Me.SupplyName)
        Me.Controls.Add(Me.InvoiceDate)
        Me.Controls.Add(Me.InvoiceNo)
        Me.Controls.Add(Me.SubHeader)
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TRADEWORLD - Stock Expiry"
        CType(Me.Form1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Header As Label
    Friend WithEvents SubHeader As Label
    Friend WithEvents InvoiceNo As Label
    Friend WithEvents InvoiceDate As Label
    Friend WithEvents SupplyName As Label
    Friend WithEvents TxtBoxInvoiceNo As TextBox
    Friend WithEvents TxtBoxSupply As TextBox
    Friend WithEvents lblproduct As Label
    Friend WithEvents TxtBoxProduct As TextBox
    Friend WithEvents lblExPdate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBoxInDate As DateTimePicker
    Friend WithEvents TxtBoxExpDate As DateTimePicker
    Friend WithEvents btnDisplay As Button
    Friend WithEvents DisplayBox As TextBox
    Friend WithEvents btnok As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents displaydesc As Label
    Friend WithEvents Form1BindingSource As BindingSource
    Friend WithEvents Label1 As Label
End Class
