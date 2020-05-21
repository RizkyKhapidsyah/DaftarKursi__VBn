Public Class FormDaftarKursi

    Private Sub tombolTampil_Click(sender As Object, e As EventArgs) Handles tombolTampil.Click
        'variabel-variabel untuk baris dan kolom terseleksi
        Dim intBaris, intKol As Integer

        'konstanta-konstanta untuk subskript baris maks dan kolom maks
        Const intMAKS_BARIS As Integer = 5
        Const intMAKS_KOL As Integer = 3

        'array dengan harga tiap kursi
        Dim decHarga(,) = {{450D, 450D, 450D, 450D},
        {425D, 425D, 425D, 425D},
        {400D, 400D, 400D, 400D},
        {375D, 375D, 375D, 375D},
        {375D, 375D, 375D, 375D},
        {350D, 350D, 350D, 350D}}

        Try
            'membaca nomor baris dan kolom terseleksi
            intBaris = CInt(teksBaris.Text)
            intKol = CInt(teksKol.Text)

            'memastikan baris dan kolom ada di dalam rentang
            If intBaris >= 0 And intBaris <= intMAKS_BARIS Then
                If intKol >= 0 And intKol <= intMAKS_KOL Then
                    'Tampilkan harga kursi terseleksi
                    labelHarga.Text = "Rp " & decHarga(intBaris, intKol).ToString() & " ribu"
                Else
                    'pesan error untuk kolom tak valid
                    MessageBox.Show("Kolom harus 0 sampai " &
                    intMAKS_KOL.ToString())
                End If
            Else
                'pesan error untuk baris tak valid
                MessageBox.Show("Baris harus 0 sampai " &
                intMAKS_BARIS.ToString())
            End If
        Catch
            'pesan error untuk masukan tak-integer
            MessageBox.Show("Baris dan kolom harus integer.")
        End Try
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup form
        Me.Close()
    End Sub
End Class
