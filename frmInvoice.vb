Imports System.ComponentModel

'------------------------------------------------------------
'-                File Name : frmInvoice.vb                 - 
'-                Part of Project: Assignment2              -
'------------------------------------------------------------
'-                Written By: Madison Kell                  -
'-                Written On: January 21, 2022              -
'------------------------------------------------------------
'- File Purpose:                                            -
'-  This is used to show the invoice when form is called.   -
'-  The invoice form shows the information from the user on -
'-  the beginning order form. From here, the user may exit  -
'-  exit the program, submit it to manufacturing, or go back-
'-  to the original order screen to make any changes.       -
'------------------------------------------------------------

Public Class frmInvoice
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        '------------------------------------------------------------
        '-                Subprogram Name: btnSubmit_Click          -
        '------------------------------------------------------------
        '-                Written By: Madison Kell                  -
        '-                Written On: January 21, 2022              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called whenever the user clicks the   -
        '- submit button. The program send a confimation messgage   -
        '- and take them back to a cleared out order screen.        –
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  –
        '-          click event                                     - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Showing the message box to tell the user that their order has been submitted.
        MessageBox.Show("Your order has been successfully submitted. Thanks for shopping!")

        'Hiding the invoice form so that user can no longer see the invoice from the first order
        Me.Hide()


        frmOrderForm.txtName.Text = "" 'Clearing out the name field
        frmOrderForm.updCarName.Text = "" 'Clearing out the Car Name 
        frmOrderForm.updQuantity.Value = 0 'Setting the quantity back to 0

        frmOrderForm.chkAC.Checked = False 'Unchecking the AC option
        frmOrderForm.chkBluetooth.Checked = False 'Unchecking the Bluetooth option
        frmOrderForm.chkCD.Checked = False 'Unchecking the CD option
        frmOrderForm.chkDefrost.Checked = False 'Unchecking the Defrost option
        frmOrderForm.chkEntertainment.Checked = False 'Unchecking the Entertainment option
        frmOrderForm.chkGPS.Checked = False 'Unchecking the GPS option
        frmOrderForm.chkHeatedSeats.Checked = False 'Unchecking the Heated Seats option
        frmOrderForm.chkLeatherSeats.Checked = False 'Unchecking the LeatherSeats option
        frmOrderForm.chkStereo.Checked = False 'Unchecking the Stereo option

        frmOrderForm.rdbElectric.Checked = False 'Unchecking the Electric option
        frmOrderForm.rdbHybrid.Checked = False 'Unchecking the Hybrid option
        frmOrderForm.rdbV12.Checked = False 'Unchecking the V12 option
        frmOrderForm.rdbV4.Checked = False 'Unchecking the V4 option
        frmOrderForm.rdbV6.Checked = False 'Unchecking the V6 option
        frmOrderForm.rdbV8.Checked = False 'Unchecking the V8 option

        'Clearing out whatever was in the invoice screen from the original order
        lstInvoice.Items.Clear()
        frmOrderForm.Show() 'Showing the cleared order screen
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        '------------------------------------------------------------
        '-                Subprogram Name: btnExit_Click            -
        '------------------------------------------------------------
        '-                Written By: Madison Kell                  -
        '-                Written On: January 21, 2022              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called whenever the user clicks the   -
        '- exit button.  The program will prompt if the user really –
        '- wants to quit, and if the user clicks Yes, the program   -
        '- will terminate.  If the user click No, the program will  -
        '- continue to run.                                         –
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  –
        '-          click event                                     - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' if the user clicks this button, they are asked if they would like to exit ot not
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Kustom Kars Order") = MsgBoxResult.Yes Then
            End 'if the answer is yes, the program ends
        Else
            Me.Show() 'if the answer is no, then the invoice screen is showed again.
        End If

    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click

        '------------------------------------------------------------
        '-                Subprogram Name: btnChange_Click          -
        '------------------------------------------------------------
        '-                Written By: Madison Kell                  -
        '-                Written On: January 21, 2022              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called whenever the user clicks the   -
        '- change order button.  The program will clear the invoice –
        '- and then bring the user back to the order screen with the-
        '- original options. This button only allows the user to    -
        '- change the original order, not place a new order.        -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  –
        '-          click event                                     - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'If the change order button is clicked the invoice screen hides
        Me.Hide()
        'The invoice screen is cleared to avoid reprinting
        lstInvoice.Items.Clear()
        'and the order form is showed again with the first selections
        frmOrderForm.Show()
    End Sub

    Private Sub frmInvoice_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        '------------------------------------------------------------
        '-                Subprogram Name: frmInvoice_Closing       -
        '------------------------------------------------------------
        '-                Written By: Madison Kell                  -
        '-                Written On: January 21, 2022              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called whenever the user clicks the   -
        '- red x button. The program will prompt if the user really –
        '- wants to quit, and if the user clicks Yes, the program   -
        '- will terminate.  If the user click No, the program will  -
        '- continue to run.                                         –
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  –
        '-          click event                                     - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        ' if the user clicks this button, they are asked if they would like to exit ot not
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Kustom Kars Order") = MsgBoxResult.Yes Then
            Me.Show() 'if the answer is no, then the invoice screen is showed again.
        Else
            End 'if the answer is yes, the program ends
        End If
    End Sub
End Class