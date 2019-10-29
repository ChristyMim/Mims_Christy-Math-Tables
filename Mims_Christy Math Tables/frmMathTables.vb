Public Class frmMathTables
    'Program: Math Tables
    'Programmer: Christy Mims
    'Date: 04/05/2017
    'Description: This program allows the user to use to calculate trig equations, square roots, and to square and cube a wide range of numbers.  The 
    'user is able to do this through the use of buttons, numeric up and down boxes, and a list box.  The code executes the calculations for the user 
    'And then displays the answers in the list box.

    Private Sub btnTrigTable_Click(sender As Object, e As EventArgs) Handles btnTrigTable.Click
        'This button computes each number in the number range using trig formulas and displays the results.
        lstResults.Items.Clear()

        Const PI = 3.1415927
        Dim radians, degrees As Double
        Dim start_value As Double = NumericUpDown1.Value
        Dim end_value As Double = NumericUpDown2.Value
        Dim sin_value, cos_value, tan_value As String

        Dim format_string As String = "{0, 11} {1,15:N2} {2, 16} {3, 17} {4, 18}"
        lstResults.Items.Add(String.Format(format_string, "x in degrees", "x in Radians", "Sin(x)", "Cos(x)", "Tan(x)"))
        lstResults.Items.Add(String.Format(format_string, "-------------", "--------------", "--------------", "--------------", "----------------"))

        For degrees = start_value To end_value
            radians = (PI * degrees) / 180
            sin_value = CStr(Math.Round(Math.Sin(radians), 4))
            cos_value = CStr(Math.Round(Math.Cos(radians), 4))
            If CStr(cos_value) = 0 Then
                tan_value = CStr("undefined")
            Else
                tan_value = CStr(Math.Round(Math.Tan(radians), 4))
            End If

            lstResults.Items.Add(String.Format(format_string, degrees, radians, sin_value, cos_value, tan_value))
        Next

    End Sub

    Private Sub btnSquareRoot_Click(sender As Object, e As EventArgs) Handles btnSquareRoot.Click
        'This button calculates the square roots of each number in the number range and displays the results in the list box.
        lstResults.Items.Clear()

        Dim start_value As Double = NumericUpDown1.Value
        Dim end_value As Double = NumericUpDown2.Value
        Dim all_values, square_root As Double

        Dim format_string As String = " {0, 10}  {1, 15}"
        lstResults.Items.Add(String.Format(format_string, "x", "Sqrt(x)"))
        lstResults.Items.Add(String.Format(format_string, "--------", "----------"))

        For all_values = start_value To end_value
            square_root = Math.Round(Math.Sqrt(all_values), 4)
            lstResults.Items.Add(String.Format(format_string, all_values, square_root))
        Next
    End Sub

    Private Sub btnTableofSquares_Click(sender As Object, e As EventArgs) Handles btnTableofSquares.Click
        'This button squares each number in the number range and displays the results in the list box.
        lstResults.Items.Clear()
        Dim x As Double = NumericUpDown1.Value
        Dim y As Double = NumericUpDown2.Value
        Dim squared, value As Double

        Dim format_string As String = " {0, 10} {1, 15}"
        lstResults.Items.Add(String.Format(format_string, "x", "x-squared"))
        lstResults.Items.Add(String.Format(format_string, "---------", "------------"))

        For squared = x To y
            value = squared * squared
            lstResults.Items.Add(String.Format(format_string, squared, value))
        Next
    End Sub

    Private Sub btnTableofCubes_Click(sender As Object, e As EventArgs) Handles btnTableofCubes.Click
        'This button cubes each of the numbers in the number range and displays the results in the list box.
        lstResults.Items.Clear()

        Dim x As Double = NumericUpDown1.Value
        Dim y As Double = NumericUpDown2.Value
        Dim cubed, total As Double

        Dim format_string As String = " {0, 10} {1, 15}"
        lstResults.Items.Add(String.Format(format_string, "x", "x-cubed"))
        lstResults.Items.Add(String.Format(format_string, "--------", "---------"))

        For cubed = x To y
            total = cubed * cubed * cubed
            lstResults.Items.Add(String.Format(format_string, cubed, total))
        Next
    End Sub
End Class
