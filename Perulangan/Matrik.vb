Public Class Matrik
    Dim cekhasil As Boolean = True
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim barisMatriks1 As Integer = TextBox1.Lines.Count
            Dim kolomMatriks1 As Integer = TextBox1.Lines.ElementAt(0).Split(" ").Length
            Dim barisMatriks2 As Integer = TextBox1.Lines.Count
            Dim kolomMatriks2 As Integer = TextBox1.Lines.ElementAt(0).Split(" ").Length
            Dim copyMatriks1(barisMatriks1, kolomMatriks1) As Integer
            Dim copyMatriks2(barisMatriks2, kolomMatriks2) As Integer
            periksa(barisMatriks1, barisMatriks2, kolomMatriks1, kolomMatriks2)
            hasilArray(barisMatriks1, barisMatriks2, kolomMatriks1, kolomMatriks2, copyMatriks1, copyMatriks2)
            proses(copyMatriks1, copyMatriks2, barisMatriks1, kolomMatriks2)
        Catch ex As Exception
            MsgBox("Masukan Bukan Angka")
        End Try
    End Sub
    Private Sub hasilArray(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer, ByRef nilai1(,) As Integer, ByRef nilai2(,) As Integer)
        If (Me.cekhasil) Then
            For baris As Integer = 0 To baris1 - 1
                For kolom As Integer = 0 To kolom1 - 1
                    nilai1(baris, kolom) = TextBox1.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                    nilai2(baris, kolom) = TextBox2.Lines.ElementAt(baris).Split(" ").ElementAt(kolom)
                Next
            Next
        End If
    End Sub
    Private Sub periksa(ByVal baris1 As Integer, baris2 As Integer, kolom1 As Integer, kolom2 As Integer)
        Dim tmp As Boolean = True
        For baris = 0 To baris1 - 2
            If (TextBox1.Lines.ElementAt(baris).Split(" ").Length <> TextBox1.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        For baris = 0 To baris2 - 2
            If (TextBox2.Lines.ElementAt(baris).Split(" ").Length <> TextBox2.Lines.ElementAt(baris + 1).Split(" ").Length) Then
                tmp = False
            End If
        Next
        If (tmp = False) Then
            Me.cekhasil = False
            Convert.ToInt32(TextBox1.Text)
            Convert.ToInt32(TextBox2.Text)
            MsgBox("Matriks Tidak Valid")
        ElseIf (baris1 = baris2 And kolom1 = kolom2) Then
            Me.cekhasil = True
        Else
            Me.cekhasil = False
            MsgBox("Baris dan Kolom Semua Matriks Harus Sama")
        End If
    End Sub
    Private Sub proses(ByVal matriks1(,) As Integer, matriks2(,) As Integer, batasBaris As Integer, batasKolom As Integer)
        Dim hasil As String = ""
        If (Me.cekhasil) Then
            Select Case ComboBox1.Text
                Case "Tambah"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(baris, kolom) + matriks2(baris, kolom)).ToString & vbTab
                        Next
                        hasil &= vbNewLine
                    Next
                Case "Kurang"
                    For baris As Integer = 0 To batasBaris - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            hasil &= (matriks1(baris, kolom) - matriks2(baris, kolom)).ToString & vbTab
                        Next
                        hasil &= vbNewLine
                    Next
                Case Else
                    MsgBox("Anda Belum Memilih Operasi")
            End Select
            TextBox3.Text = hasil
        End If
    End Sub

End Class