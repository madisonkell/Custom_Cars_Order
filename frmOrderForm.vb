Imports System.ComponentModel

'------------------------------------------------------------
'-                File Name : frmOrderFrom.vb               - 
'-                Part of Project: Assignment2              -
'------------------------------------------------------------
'-                Written By: Madison Kell                  -
'-                Written On: January 21, 2022              -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main application form where the   -
'- user will input several features that pertain to a       - 
'- custom car order.                                        -
'------------------------------------------------------------
'- Program Purpose:                                         -                                 -
'- This program will ask the user will ask to enter features-
'- such as engine type, car type, customer name, quantity,  -
'- and up to 9 custom features. All of the features have    -
'- different costs and the program will automatically       -
'- calculate all of the totals and information and show the -
'- invoice with all of the customs in a different form. From-
'- the invoice form, the user is allowed to change the      -
'- original order, sumbit to manufacturing, or exit the     -
'- program all together.                                    -
'------------------------------------------------------------
'- Global Variable Dictionary (alphabetically):             -
'-                 None                                     – 
'------------------------------------------------------------


Public Class frmOrderForm

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        '------------------------------------------------------------
        '-                Subprogram Name: btnOrder_Click           -
        '------------------------------------------------------------
        '-                Written By: Madison Kell                  -
        '-                Written On: January 21, 2022              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called whenever the user clicks the   -
        '- order button. Once this button is clicked, all fields    –
        '- data wil be entered into a list on the invoice form.     -
        '- If the user fails to enter one of the designated fields, -
        '- they will receive an error message and not be able to    -
        '- move onto the exit screen. This button also calculates   -
        '- totals from all individulal fields and displays them at  -
        '- during the time the invoice screen is called (when this  -
        '- button is clicked).                                      -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  –
        '-          click event                                     - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)
        '   dblInitalPrice- holds value for inital car price only   -
        '-  dblGrandTotal- holds value for grand total with         -
        '-                  all features                            -
        '-  dblTotalCarPrice- The total price for quantity and the  -
        '-                     inital car price                     -
        '-  dblTotalDrive-  holds the value of the engine           -
        '-  intCount-  holds how many features were selected        -
        '-  intTotalFeature- holds the price for all features       -
        '                   selected                                -
        '-  strDriveName- the name of the selected car              -
        '------------------------------------------------------------

        frmInvoice.Show() 'showing the invoice screen once the button is clicked
        Me.Hide() 'hiding the order screen

        Dim dblGrandTotal As Double ' holds value for inital car price only
        Dim intCount As Integer = 0 'holds how many features were selected 
        Dim dblTotalDrive As Double 'holds the value of the engine 
        Dim strDriveName As String 'the name of the selected car  
        Dim dblInitialPrice As Double 'holds value for inital car price only
        Dim dblTotalCarPrice As Double 'The total price for quantity and the inital car price     
        Dim intTotalFeature As Integer 'holds the price for all features selected

        'if the user forgets to enter a name
        If txtName.Text.Length = 0 Then
            Me.Show() 'continue to show the order 
            frmInvoice.Hide() 'hide the invoice
            MessageBox.Show("Please enter a name.", "Error: Missing information") 'show an error message
        End If

        'if the invoice screen has anything in it when the error happens
        If frmInvoice.lstInvoice.Items.Count > 1 Then
            frmInvoice.lstInvoice.Items.Clear() 'clear the list
        End If

        'if the user does not select a quantity
        If updQuantity.Value < 1 Then
            Me.Show()  'continue to show the order
            frmInvoice.Hide() 'hide the invoice
            MessageBox.Show("Please enter the quantity.", "Error: Missing information") 'show an error message
        End If

        'if the invoice screen has anything in it when the error happens
        If frmInvoice.lstInvoice.Items.Count > 1 Then
            frmInvoice.lstInvoice.Items.Clear() 'clear the list
        End If

        'this if else statement is for the engine.
        'if a certain engine is selected, add that amount to the variable
        'totalDrive, and set the drive name to the radio button selected
        If rdbV12.Checked = True Then
            dblTotalDrive = 7500 'how much the v12 costs
            strDriveName = "V12" 'set the name to v12
        ElseIf rdbV8.Checked = True Then
            dblTotalDrive = 2500 'how much the v8 costs
            strDriveName = "V8" 'set the name to v8
        ElseIf rdbV6.Checked = True Then
            dblTotalDrive = 1000 'how much the v6 costs
            strDriveName = "V6" 'set the name to v6
        ElseIf rdbV4.Checked = True Then
            dblTotalDrive = 400 'how much the v4 costs
            strDriveName = "V4" 'set the name to v4
        ElseIf rdbHybrid.Checked = True Then
            dblTotalDrive = 3000 'how much the hybrid costs
            strDriveName = "Hybrid" 'set the name to hybrid
        ElseIf rdbElectric.Checked = True Then
            dblTotalDrive = 6000 'how much the electric costs
            strDriveName = "Electric" 'set the name to electric
        Else
            frmInvoice.Hide() 'if user forgets to select one, hide the invoice
            Me.Show() 'continue to show the order screen
            MessageBox.Show("Please Select A Drive Train.", "Error: Missing information") 'show an error message
        End If

        'if the invoice screen has anything in it when the error happens
        If frmInvoice.lstInvoice.Items.Count > 1 Then
            frmInvoice.lstInvoice.Items.Clear() 'clear the list
        End If

        'this if else statement is for the type of car.
        'if a certain car is selected, add that amount to the variable
        'initialPrice, and set the totalCarPrice to the product of the quantity and the initial price
        If updCarName.SelectedItem = "Coupe" Then
            dblInitialPrice = 10000 'how much the coupe costs
            dblTotalCarPrice = updQuantity.Value * dblInitialPrice
        ElseIf updCarName.SelectedItem = "Luxury" Then
            dblInitialPrice = 20000 'how much the luxury costs
            dblTotalCarPrice = updQuantity.Value * dblInitialPrice
        ElseIf updCarName.SelectedItem = "Sedan" Then
            dblInitialPrice = 17000 'how much the sedan costs
            dblTotalCarPrice = updQuantity.Value * dblInitialPrice
        ElseIf updCarName.SelectedItem = "Sports Edition" Then
            dblInitialPrice = 25000 'how much the sports edition costs
            dblTotalCarPrice = updQuantity.Value * dblInitialPrice
        ElseIf updCarName.SelectedItem = "SUV" Then
            dblInitialPrice = 27000 'how much the suv costs
            dblTotalCarPrice = updQuantity.Value * dblInitialPrice
        Else
            frmInvoice.Hide() 'if user forgets to select one, hide the invoice
            Me.Show() 'continue to show the order screen
            MessageBox.Show("Please select a car.", "Error: Missing information") 'show an error message
        End If

        'if the invoice screen has anything in it when the error happens
        If frmInvoice.lstInvoice.Items.Count > 1 Then
            frmInvoice.lstInvoice.Items.Clear() 'clear the list
        End If

        'Here is just adding fun and cute stuff to the invoice form 
        frmInvoice.lstInvoice.Items.Add("=======================================================================")
        frmInvoice.lstInvoice.Items.Add("                                       Kustom Karz Order               ")
        frmInvoice.lstInvoice.Items.Add("=======================================================================")
        frmInvoice.lstInvoice.Items.Add("") 'adding a blank line for spacing
        frmInvoice.lstInvoice.Items.Add("Getting ready to kustom manufacture for " & txtName.Text) 'inserting the name on the order
        frmInvoice.lstInvoice.Items.Add("") 'adding a blank line for spacing
        frmInvoice.lstInvoice.Items.Add("There will be " & updQuantity.Value & " car(s) kustom built") 'inserting the numeber of cars in the fleet
        frmInvoice.lstInvoice.Items.Add("") 'adding a blank line for spacing
        frmInvoice.lstInvoice.Items.Add("Kar form factor : " & updCarName.SelectedItem & " at " & FormatCurrency(dblInitialPrice)) 'inserting the car name and the price of that car
        frmInvoice.lstInvoice.Items.Add("Drive Train Selected: " & strDriveName & " at " & FormatCurrency(dblTotalDrive)) 'inserting the engine selected and the the price of the engine
        frmInvoice.lstInvoice.Items.Add("") 'adding a blank line for spacing
        frmInvoice.lstInvoice.Items.Add("Here are the options requested: ") 'after this line the features selected will be listed

        'if this check box is checked 
        If chkAC.Checked = True Then
            intTotalFeature += 750 'add $750 to the totalFeature
            intCount = intCount + 1 'update the number of features added
            frmInvoice.lstInvoice.Items.Add(vbTab & "Air Conditioning") 'add the name of the feature to the list
        Else
            frmInvoice.lstInvoice.Items.Remove(vbTab & "Air Conditioning")
        End If

        'if this check box is checked 
        If chkBluetooth.Checked = True Then
            intTotalFeature += 750 'add $750 to the totalFeature
            intCount = intCount + 1 'update the number of features added
            frmInvoice.lstInvoice.Items.Add(vbTab & "Bluetooth") 'add the name of the feature to the list
        Else
            frmInvoice.lstInvoice.Items.Remove(vbTab & "Bluetooth")
        End If

        'if this check box is checked 
        If chkCD.Checked = True Then
            intTotalFeature += 750 'add $750 to the totalFeature
            intCount = intCount + 1 'update the number of features added
            frmInvoice.lstInvoice.Items.Add(vbTab & "CD/MP3 Connections") 'add the name of the feature to the list
        Else
            frmInvoice.lstInvoice.Items.Remove(vbTab & "CD/MP3 Connections") 'if it is checked and then unchecked, remove it from the list
        End If

        'if this check box is checked 
        If chkDefrost.Checked = True Then
            intTotalFeature += 750 'add $750 to the totalFeature
            intCount = intCount + 1 'update the number of features added
            frmInvoice.lstInvoice.Items.Add(vbTab & "Rear Defroster") 'add the name of the feature to the list
        Else
            frmInvoice.lstInvoice.Items.Remove(vbTab & "Rear Defroster") 'if it is checked and then unchecked, remove it from the list
        End If

        'if this check box is checked 
        If chkEntertainment.Checked = True Then
            intTotalFeature += 750 'add $750 to the totalFeature
            intCount = intCount + 1 'update the number of features added
            frmInvoice.lstInvoice.Items.Add(vbTab & "Entertainment Package") 'add the name of the feature to the list
        Else
            frmInvoice.lstInvoice.Items.Remove(vbTab & "Entertainment Package") 'if it is checked and then unchecked, remove it from the list
        End If

        'if this check box is checked 
        If chkGPS.Checked = True Then
            intTotalFeature += 750 'add $750 to the totalFeature
            intCount = intCount + 1 'update the number of features added
            frmInvoice.lstInvoice.Items.Add(vbTab & "GPS") 'add the name of the feature to the list
        Else
            frmInvoice.lstInvoice.Items.Remove(vbTab & "GPS") 'if it is checked and then unchecked, remove it from the list
        End If

        'if this check box is checked 
        If chkHeatedSeats.Checked = True Then
            intTotalFeature += 750 'add $750 to the totalFeature
            intCount = intCount + 1 'update the number of features added
            frmInvoice.lstInvoice.Items.Add(vbTab & "Heated Seats") 'add the name of the feature to the list
        Else
            frmInvoice.lstInvoice.Items.Remove(vbTab & "Heated Seats") 'if it is checked and then unchecked, remove it from the list
        End If

        'if this check box is checked 
        If chkLeatherSeats.Checked = True Then
            intTotalFeature += 750 'add $750 to the totalFeature
            intCount = intCount + 1 'update the number of features added
            frmInvoice.lstInvoice.Items.Add(vbTab & "Leather Seats") 'add the name of the feature to the list
        Else
            frmInvoice.lstInvoice.Items.Remove(vbTab & "Leather Seats") 'if it is checked and then unchecked, remove it from the list
        End If

        'if this check box is checked 
        If chkStereo.Checked = True Then
            intTotalFeature += 750 'add $750 to the totalFeature
            intCount = intCount + 1 'update the number of features added
            frmInvoice.lstInvoice.Items.Add(vbTab & "Premium Stereo") 'add the name of the feature to the list
        Else
            frmInvoice.lstInvoice.Items.Remove(vbTab & "Premium Stereo") 'if it is checked and then unchecked, remove it from the list
        End If
        'BY PRINTING OUT I MEAN ADD TO THE LIST
        'Add the total car price, total engine price, and total feature price to the grandtotal
        dblGrandTotal = dblTotalCarPrice + dblTotalDrive + intTotalFeature
        frmInvoice.lstInvoice.Items.Add(intCount & " Options selected for a total of " & FormatCurrency(intTotalFeature)) 'print out the count of features as well as the price for them
        frmInvoice.lstInvoice.Items.Add("") 'adding a blank line for spacing
        frmInvoice.lstInvoice.Items.Add("Per vehicle total: " & vbTab & vbTab & FormatCurrency(dblInitialPrice + intTotalFeature + dblTotalDrive)) 'price per vehicle with all of the bells and whistles
        frmInvoice.lstInvoice.Items.Add("------------------------------------------------------------------") 'fun formatting
        frmInvoice.lstInvoice.Items.Add("Quantity Ordered: " & vbTab & vbTab & updQuantity.Value) 'printing the quantity of cars ordered
        frmInvoice.lstInvoice.Items.Add("------------------------------------------------------------------") 'fun formatting
        frmInvoice.lstInvoice.Items.Add("Grand total: " & vbTab & vbTab & FormatCurrency(dblGrandTotal)) 'printing the grand total with tge quantity 
        frmInvoice.lstInvoice.Items.Add("==========================================================================================") 'fun formatting

    End Sub

    Private Sub frmOrderForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        '------------------------------------------------------------
        '-                Subprogram Name: frmOrderForm_Closing     -
        '------------------------------------------------------------
        '-                Written By: Madison Kell                  -
        '-                Written On: January 21, 2022              -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is called whenever the user clicks the   -
        '- red x button. The program throw a message to the user    –
        '- and inform them that they cannot exit the program from   -
        '- the order form screen and they must continue the order.  -
        '------------------------------------------------------------
        '- Parameter Dictionary (in parameter order):               -
        '- sender – Identifies which particular control raised the  –
        '-          click event                                     - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary (alphabetically):              -
        '- (None)                                                   -
        '------------------------------------------------------------

        'Tell the user they cannot exit the screen from the order screen, and must continue the order.
        MessageBox.Show("Sorry but the application can only be closed on the Invoice Screen. Please press Place Order to go to that screen.", "Error")
        'to avoid printing the order twice, the list is cleared and will be repopulated when the order button is pressed
        frmInvoice.lstInvoice.Items.Clear()
        'cancel the error event
        e.Cancel = True
    End Sub
End Class
