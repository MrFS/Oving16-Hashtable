Public Class Form1
    Dim karakter As String
    Dim TallTilBokstav As New Hashtable() From {
        {6, "A"}, {5, "B"}, {4, "C"}, {3, "D"}, {2, "E"}, {1, "F"}
    }
    Dim karakterAntall As New Hashtable() From {
        {"A", 0}, {"B", 0}, {"C", 0}, {"D", 0}, {"E", 0}, {"F", 0}
    }

    Dim bokstavsnitt As String
    Dim tallsnitt As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        karakter = txtKar.Text.ToUpper

        Try
            Select Case karakter
                Case "A"
                    karakterAntall(karakter) += 1
                    ListBox1.Items.Add("Følgende karakter ble lagt til: " & karakter)
                    txtKar.Clear()
                Case "B"
                    karakterAntall(karakter) += 1
                    ListBox1.Items.Add("Følgende karakter ble lagt til: " & karakter)
                    txtKar.Clear()
                Case "C"
                    karakterAntall(karakter) += 1
                    ListBox1.Items.Add("Følgende karakter ble lagt til: " & karakter)
                    txtKar.Clear()
                Case "D"
                    karakterAntall(karakter) += 1
                    ListBox1.Items.Add("Følgende karakter ble lagt til: " & karakter)
                    txtKar.Clear()
                Case "E"
                    karakterAntall(karakter) += 1
                    ListBox1.Items.Add("Følgende karakter ble lagt til: " & karakter)
                    txtKar.Clear()
                Case "F"
                    karakterAntall(karakter) += 1
                    ListBox1.Items.Add("Følgende karakter ble lagt til: " & karakter)
                    txtKar.Clear()
                Case Else
                    MsgBox("Karakteren må være en bokstav, A-F")
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            tallsnitt = ((6 * karakterAntall("A")) +
                         (5 * karakterAntall("B")) +
                         (4 * karakterAntall("C")) +
                         (3 * karakterAntall("D")) +
                         (2 * karakterAntall("E")) +
                         (1 * karakterAntall("F"))) /
                            ((karakterAntall("A")) +
                             (karakterAntall("B")) +
                             (karakterAntall("C")) +
                             (karakterAntall("D")) +
                             (karakterAntall("E")) +
                             (karakterAntall("F")))

            ListBox1.Items.Add("Snitt: " & tallsnitt)
            tallsnitt = Math.Round(tallsnitt)
            ListBox1.Items.Add("Gjennomsnitt av karakterene (avrundet): " & tallsnitt)
            ListBox1.Items.Add("Gjennomsnitt som bokstav: " & TallTilBokstav(CInt(tallsnitt)))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        With ListBox1.Items
            .Add("Antall karakterer:")
            .Add("A: " & karakterAntall("A"))
            .Add("B: " & karakterAntall("B"))
            .Add("C: " & karakterAntall("C"))
            .Add("D: " & karakterAntall("D"))
            .Add("E: " & karakterAntall("E"))
            .Add("F: " & karakterAntall("F"))
        End With

    End Sub
End Class
