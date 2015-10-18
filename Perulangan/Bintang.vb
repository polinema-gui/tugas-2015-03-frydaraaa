Public Class Bintang

    Dim output As String = ""
    Private Sub Btn_proses_Click(sender As Object, e As EventArgs) Handles Btn_proses.Click
        Try
            Select Case ComboBox1.Text
                Case "Pyramid"
                    pyramid(Convert.ToInt32(Txbox_Baris.Text))
                Case "Hollow Pyramid"
                    hollowPyramid(Convert.ToInt32(Txbox_Baris.Text))
                Case "Inverted Pyramid"
                    invertedPyramid(Convert.ToInt32(Txbox_Baris.Text))
                Case "Hollow Inverted Pyramid"
                    hollowInvertedPyramid(Convert.ToInt32(Txbox_Baris.Text))
                Case Else
                    Txbox_Baris.Text = "Anda Belum Memilih Pola"
            End Select
        Catch ex As Exception
            Txbox_Baris.Text = "Masukan Bukan Angka"
        End Try
    End Sub

    Private Sub pyramid(batas As Integer)
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom < batasKolom1 Or kolom > batasKolom2) Then
                    Me.output &= "  "
                Else
                    Me.output &= "*"
                End If
            Next
            batasKolom1 -= 1
            batasKolom2 += 1
            Me.output &= vbCrLf
        Next
        TextBox1.Text = output
        output = ""
    End Sub

    Private Sub hollowPyramid(batas As Integer)
        Dim batasKolom1 As Integer = batas
        Dim batasKolom2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris < batas) Then
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        Me.output &= "*"
                    Else
                        Me.output &= "  "
                    End If
                Else
                    Me.output &= "*"
                End If
            Next
            batasKolom1 -= 1
            batasKolom2 += 1
            Me.output &= vbCrLf
        Next
        TextBox1.Text = output
        output = ""
    End Sub
    Private Sub invertedPyramid(batas As Integer)
        Dim batasKolom1 As Integer = 0
        Dim batasKolom2 As Integer = batas * 2
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom > batasKolom1 And kolom < batasKolom2) Then
                    Me.output &= "*"
                Else
                    Me.output &= "  "
                End If
            Next
            Me.output &= vbCrLf
            batasKolom1 += 1
            batasKolom2 -= 1
        Next
        TextBox1.Text = output
        Me.output = ""
    End Sub

    Private Sub hollowInvertedPyramid(batas As Integer)
        Dim batasKolom1 As Integer = 1
        Dim batasKolom2 As Integer = batas * 2 - 1
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris = 1) Then
                    Me.output &= "*"
                Else
                    If (kolom = batasKolom1 Or kolom = batasKolom2) Then
                        Me.output &= "*"
                    Else
                        Me.output &= "  "
                    End If
                End If
            Next
            batasKolom1 += 1
            batasKolom2 -= 1
            Me.output &= vbCrLf
        Next
        TextBox1.Text = output
        Me.output = ""
    End Sub
End Class
