Public Class Form1

    'for the delay
    Private Sub Hold(ByVal interval As Integer)
        Dim wait As New Stopwatch
        wait.Start()

        Do While wait.ElapsedMilliseconds < interval
            Application.DoEvents()
        Loop

        wait.Stop()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Do
            '0
            Hold(1000)
            P1.BackColor = Color.Red
            P2.BackColor = Color.Red
            P3.BackColor = Color.Red
            P4.BackColor = Color.Red
            P5.BackColor = Color.Red
            P6.BackColor = Color.Red
            P7.BackColor = Color.White
            P8.BackColor = Color.White
            P9.BackColor = Color.White
            P10.BackColor = Color.Red
            P11.BackColor = Color.Red
            P12.BackColor = Color.White
            P13.BackColor = Color.White
            P14.BackColor = Color.White
            P15.BackColor = Color.Red
            P16.BackColor = Color.Red
            P17.BackColor = Color.White
            P18.BackColor = Color.White
            P19.BackColor = Color.White
            P20.BackColor = Color.Red
            P21.BackColor = Color.Red
            P22.BackColor = Color.Red
            P23.BackColor = Color.Red
            P24.BackColor = Color.Red
            P25.BackColor = Color.Red

            '1
            Hold(1000)
            P1.BackColor = Color.White
            P4.BackColor = Color.White
            P5.BackColor = Color.White
            P8.BackColor = Color.Red
            P10.BackColor = Color.White
            P11.BackColor = Color.White
            P13.BackColor = Color.Red
            P15.BackColor = Color.White
            P16.BackColor = Color.White
            P18.BackColor = Color.Red
            P20.BackColor = Color.White

            '2
            Hold(1000)
            P1.BackColor = Color.Red
            P4.BackColor = Color.Red
            P5.BackColor = Color.Red
            P6.BackColor = Color.White
            P8.BackColor = Color.White
            P10.BackColor = Color.Red
            P11.BackColor = Color.Red
            P12.BackColor = Color.Red
            P14.BackColor = Color.Red
            P15.BackColor = Color.Red
            P16.BackColor = Color.Red
            P18.BackColor = Color.White

            '3
            Hold(1000)
            P11.BackColor = Color.White
            P12.BackColor = Color.White
            P16.BackColor = Color.White
            P20.BackColor = Color.Red

        Loop While True
    End Sub
End Class
