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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
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
            P11.BackColor = Color.Red
            P12.BackColor = Color.Red
            P13.BackColor = Color.Red
            P16.BackColor = Color.White
            P20.BackColor = Color.Red

            '4
            Hold(1000)
            P1.BackColor = Color.White
            P2.BackColor = Color.White
            P5.BackColor = Color.White
            P7.BackColor = Color.Red
            P9.BackColor = Color.Red
            P10.BackColor = Color.White
            P11.BackColor = Color.Red
            P12.BackColor = Color.Red
            P19.BackColor = Color.Red
            P20.BackColor = Color.White
            P21.BackColor = Color.White
            P22.BackColor = Color.White
            P23.BackColor = Color.White
            P24.BackColor = Color.Red
            P25.BackColor = Color.White

            '5
            Hold(1000)
            P1.BackColor = Color.White
            P2.BackColor = Color.White
            P5.BackColor = Color.White
            P7.BackColor = Color.Red
            P9.BackColor = Color.Red
            P10.BackColor = Color.White
            P11.BackColor = Color.Red
            P12.BackColor = Color.Red
            P19.BackColor = Color.Red
            P20.BackColor = Color.White
            P21.BackColor = Color.White
            P22.BackColor = Color.White
            P23.BackColor = Color.White
            P24.BackColor = Color.Red
            P25.BackColor = Color.White

            '6
            Hold(1000)
            P1.BackColor = Color.White
            P2.BackColor = Color.White
            P5.BackColor = Color.White
            P7.BackColor = Color.Red
            P9.BackColor = Color.Red
            P10.BackColor = Color.White
            P11.BackColor = Color.Red
            P12.BackColor = Color.Red
            P19.BackColor = Color.Red
            P20.BackColor = Color.White
            P21.BackColor = Color.White
            P22.BackColor = Color.White
            P23.BackColor = Color.White
            P24.BackColor = Color.Red
            P25.BackColor = Color.White

            '7
            Hold(1000)
            P1.BackColor = Color.White
            P2.BackColor = Color.White
            P5.BackColor = Color.White
            P7.BackColor = Color.Red
            P9.BackColor = Color.Red
            P10.BackColor = Color.White
            P11.BackColor = Color.Red
            P12.BackColor = Color.Red
            P19.BackColor = Color.Red
            P20.BackColor = Color.White
            P21.BackColor = Color.White
            P22.BackColor = Color.White
            P23.BackColor = Color.White
            P24.BackColor = Color.Red
            P25.BackColor = Color.White

            '8
            Hold(1000)
            P1.BackColor = Color.White
            P2.BackColor = Color.White
            P5.BackColor = Color.White
            P7.BackColor = Color.Red
            P9.BackColor = Color.Red
            P10.BackColor = Color.White
            P11.BackColor = Color.Red
            P12.BackColor = Color.Red
            P19.BackColor = Color.Red
            P20.BackColor = Color.White
            P21.BackColor = Color.White
            P22.BackColor = Color.White
            P23.BackColor = Color.White
            P24.BackColor = Color.Red
            P25.BackColor = Color.White

            '9
            Hold(1000)
            P1.BackColor = Color.White
            P2.BackColor = Color.White
            P5.BackColor = Color.White
            P7.BackColor = Color.Red
            P9.BackColor = Color.Red
            P10.BackColor = Color.White
            P11.BackColor = Color.Red
            P12.BackColor = Color.Red
            P19.BackColor = Color.Red
            P20.BackColor = Color.White
            P21.BackColor = Color.White
            P22.BackColor = Color.White
            P23.BackColor = Color.White
            P24.BackColor = Color.Red
            P25.BackColor = Color.White
        Loop While True
    End Sub
End Class
