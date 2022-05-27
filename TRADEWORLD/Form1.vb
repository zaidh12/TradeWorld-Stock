Public Class Form1
    Private Filehandle As System.IO.StreamWriter
    Private FileReader As System.IO.StreamReader
    Private Invoice_No, Supply_Name, Product_Name, lineoftext, Newlineoftext, CompareDateString As String
    Private Col1, Col2, Col3, Col4, Col5, Col3trim, Col4trim As String
    Private SNSpaces, PNSpaces, SNameLength, PNameLength, Col3Spaces, Col4Spaces, Col3length, Col4length As Integer
    Private InNoCorrect, InDtCorrect, SNCorrect, PNCorrect, ExpDtCorrect As Boolean
    Private Invoice_Date, ExpDate, CompareDate, FinalDate As Date

    '#

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        FileReader = New System.IO.StreamReader("Invoices.txt")

        Do Until FileReader.EndOfStream()

            lineoftext = FileReader.ReadLine()

            Col1 = Microsoft.VisualBasic.Left(lineoftext, 7)
            Col2 = Microsoft.VisualBasic.Mid(lineoftext, 8, 12)
            Col3 = (Microsoft.VisualBasic.Mid(lineoftext, 20, 35))
            Col3trim = Trim(Col3)
            Col3length = Len(Col3trim)
            Col3Spaces = 25 - Col3length - 5
            Col4 = (Microsoft.VisualBasic.Mid(lineoftext, 55, 30))
            Col4trim = Trim(Col4)
            Col4length = Len(Col4trim)
            Col4Spaces = 25 - Col4length
            Col5 = Microsoft.VisualBasic.Mid(lineoftext, 86, 10)



            'obtaining expiry date from the lineoftext and comparing it to the date in one week's time

            CompareDateString = Microsoft.VisualBasic.Mid(lineoftext, 86, 10)
            CompareDate = (DateAdd("d", 1, Today))

            Dim FinalDate As String
            FinalDate = CStr(CompareDate)

            If CompareDateString = FinalDate Then
                DisplayBox.Text = " " & Col1 & "   " & Col2 & "   " & (Col3trim & Space(Col3Spaces)) & "   " & (Col4trim & Space(Col4Spaces)) & "               " & Col5 & vbNewLine & DisplayBox.Text

            End If
        Loop
        FileReader.Close()

    End Sub



    'function for presence check for all textboxes
    Private Function InvoiceNTxtBoxEpmty() As Boolean
        InvoiceNTxtBoxEpmty = TxtBoxInvoiceNo.Text = ""
    End Function
    Private Function InvoiceDTxtBoxEpmty() As Boolean
        InvoiceDTxtBoxEpmty = TxtBoxInDate.Text = ""
    End Function
    Private Function SupplyNTxtBoxEpmty() As Boolean
        SupplyNTxtBoxEpmty = TxtBoxSupply.Text = ""
    End Function
    Private Function ProductNTxtBoxEpmty() As Boolean
        ProductNTxtBoxEpmty = TxtBoxProduct.Text = ""
    End Function
    Private Function ExpDTxtBoxEpmty() As Boolean
        ExpDTxtBoxEpmty = TxtBoxExpDate.Text = ""
    End Function

    'functions to enable to moving down textboxes using the 'ENTER' key
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBoxInvoiceNo.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBoxInDate.Focus()
        End If
    End Sub
    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            TxtBoxSupply.Focus()
        End If
    End Sub
    Private Sub TextBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBoxSupply.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBoxProduct.Focus()
        End If
    End Sub
    Private Sub TextBox4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBoxProduct.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBoxExpDate.Focus()
        End If
    End Sub


    ' submit button
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnok.Click

        Filehandle = New System.IO.StreamWriter("Invoices.txt", True)

        'initializing all field checks
        InNoCorrect = True
        InDtCorrect = True
        SNCorrect = True
        PNCorrect = True
        ExpDtCorrect = True

        'validtation of textbox data

        If InvoiceNTxtBoxEpmty() Or SupplyNTxtBoxEpmty() Or ProductNTxtBoxEpmty() Then
            InNoCorrect = False
            MessageBox.Show("     Please ensure that no field remains empty.   ", "INPUT ERROR", MessageBoxButtons.OK,
             MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End If

        If InNoCorrect = True And InDtCorrect = True And SNCorrect = True And PNCorrect = True And ExpDtCorrect = True Then

            Invoice_No = CStr(TxtBoxInvoiceNo.Text)
            Filehandle.Write(Invoice_No)
            Filehandle.Write("  ")

            Invoice_Date = CStr(TxtBoxInDate.Text)
            Filehandle.Write(Invoice_Date.ToShortDateString)
            Filehandle.Write("  ")

            Supply_Name = CStr(TxtBoxSupply.Text)
            SNameLength = Len(Supply_Name)
            SNSpaces = 35 - SNameLength
            Filehandle.Write(Supply_Name & Space(SNSpaces))

            Product_Name = CStr(TxtBoxProduct.Text)
            PNameLength = Len(Product_Name)
            PNSpaces = 30 - PNameLength
            Filehandle.Write(Product_Name & Space(PNSpaces))

            Filehandle.Write(" ")
            ExpDate = CStr(TxtBoxExpDate.Text)
            Filehandle.Write(ExpDate.ToShortDateString)
            Filehandle.Write(" ")

            'moves to the next line of the file for the next time data is entered
            Filehandle.WriteLine()

            MessageBox.Show("             Submission Successful!               ", "STATUS")

        End If

        Filehandle.Close()

    End Sub
End Class


