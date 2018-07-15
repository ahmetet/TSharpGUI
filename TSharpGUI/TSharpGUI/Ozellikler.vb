Public Class Ozellikler


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Obje_Başlık.TextChanged

        Try
            Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
            USTBAR.Secilmis.Text = CType(sender, Control).Text.Replace(" ", "_")
        Catch ex As Exception
            '      MessageBox.Show("Hata:" + "2")
        End Try
    End Sub



    Private Sub erisim_aktifpasif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles erisim_aktifpasif.SelectedIndexChanged

        Try
            Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
            USTBAR.Secilmis.Tag += "@Erişim=" + erisim_aktifpasif.SelectedItem.ToString() + ";"

        Catch ex As Exception
            '     MessageBox.Show("Hata:" + "3")
        End Try
    End Sub

    Private Sub gorunurluk_aktif_pasif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles gorunurluk_aktif_pasif.SelectedIndexChanged
        Try
            Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
            USTBAR.Secilmis.Tag += "@Görünürlük=" + gorunurluk_aktif_pasif.SelectedItem.ToString() + ";"

        Catch ex As Exception
            '   MessageBox.Show("Hata:" + "4")
        End Try
    End Sub

    Private Sub simge_aktifpasif_SelectedIndexChanged(sender As Object, e As EventArgs) Handles simge_aktifpasif.SelectedIndexChanged
        Try
            Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
            USTBAR.Secilmis.Tag += "@Simge=" + simge_aktifpasif.SelectedText.ToString() + ";"

        Catch ex As Exception
            '   MessageBox.Show("Hata:" + "5")
        End Try
    End Sub



    Private Sub Obje_YazıRengi_TextChanged(sender As Object, e As EventArgs) Handles Obje_YazıRengi.TextChanged
        Try
            Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
            '(15,25,15)
            Dim _R, _G, _B As Integer
            Dim temp As String
            temp = CType(sender, Control).Text.Split("(")(1).Split(")")(0)
            _R = Convert.ToInt32(temp.Split(",")(0))
            _G = Convert.ToInt32(temp.Split(",")(1))
            _B = Convert.ToInt32(temp.Split(",")(2))

            USTBAR.Secilmis.ForeColor = Color.FromArgb(_R, _G, _B)
        Catch ex As Exception
            '   MessageBox.Show("Hata:" + "10")
        End Try
    End Sub

    Private Sub Obje_Konum_TextChanged(sender As Object, e As EventArgs)
        Try
            Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
            '(15,5)
            Dim _X, _Y As Integer
            Dim temp As String
            temp = CType(sender, Control).Text.Split("(")(1).Split(")")(0)
            _X = Convert.ToInt32(temp.Split(",")(0))
            _Y = Convert.ToInt32(temp.Split(",")(1))


            USTBAR.Secilmis.Location = New Point(_X, _Y)
        Catch ex As Exception
            '  MessageBox.Show("Hata:" + "11")
        End Try
    End Sub

    Private Sub Obje_Genişlik_TextChanged(sender As Object, e As EventArgs) Handles Obje_Genişlik.TextChanged
        Try
            Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
            USTBAR.Secilmis.Width = Convert.ToInt32(Obje_Genişlik.Text)
        Catch ex As Exception
            '   MessageBox.Show("Hata:" + "12")
        End Try
    End Sub

    Private Sub Obje_Yükseklik_TextChanged(sender As Object, e As EventArgs) Handles Obje_Yükseklik.TextChanged
        Try
            Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
            USTBAR.Secilmis.Height = Convert.ToInt32(Obje_Yükseklik.Text)
        Catch ex As Exception
            '    MessageBox.Show("Hata:" + "13")
        End Try
    End Sub

    Private Sub Obje_YazıBoyutu_TextChanged(sender As Object, e As EventArgs) Handles Obje_YazıBoyutu.TextChanged
        Try
            Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
            USTBAR.Secilmis.Font = New Font(USTBAR.Secilmis.Font.FontFamily, Convert.ToInt32(Obje_YazıBoyutu.Text))
        Catch ex As Exception
            ' MessageBox.Show("Hata:" + "14")
        End Try
    End Sub



    Private Sub Obje_Arkaplan_TextChanged_1(sender As Object, e As EventArgs) Handles Obje_Arkaplan.TextChanged
        Try
            Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
            '(15,25,15)
            Dim _R, _G, _B As Integer
            Dim temp As String
            temp = CType(sender, Control).Text.Split("(")(1).Split(")")(0)
            _R = Convert.ToInt32(temp.Split(",")(0))
            _G = Convert.ToInt32(temp.Split(",")(1))
            _B = Convert.ToInt32(temp.Split(",")(2))

            USTBAR.Secilmis.BackColor = Color.FromArgb(_R, _G, _B)
        Catch ex As Exception
            '    MessageBox.Show("Hata:" + "6")
        End Try
    End Sub

    Private Sub Obje_Arkaplan_DoubleClick(sender As Object, e As EventArgs) Handles Obje_Arkaplan.DoubleClick
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Try
                Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
                Obje_Arkaplan.Text = "(" + ColorDialog1.Color.R.ToString() + "," + ColorDialog1.Color.G.ToString() + "," + ColorDialog1.Color.B.ToString() + ")"
                USTBAR.Secilmis.BackColor = Color.FromArgb(ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub Obje_YazıRengi_DoubleClick(sender As Object, e As EventArgs) Handles Obje_YazıRengi.DoubleClick
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Try
                Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
                Obje_YazıRengi.Text = "(" + ColorDialog1.Color.R.ToString() + "," + ColorDialog1.Color.G.ToString() + "," + ColorDialog1.Color.B.ToString() + ")"
                USTBAR.Secilmis.ForeColor = Color.FromArgb(ColorDialog1.Color.R, ColorDialog1.Color.G, ColorDialog1.Color.B)
            Catch ex As Exception

            End Try
        End If
    End Sub



    Private Sub Obje_Yükseklik_DoubleClick(sender As Object, e As EventArgs) Handles Obje_Yükseklik.DoubleClick
        Dim Yukseklik_Ayar As New Form
        Yukseklik_Ayar.ShowIcon = False
        Yukseklik_Ayar.BackColor = Color.White
        Yukseklik_Ayar.Text = "T# Yükseklik"
        Yukseklik_Ayar.AutoSize = True
        Yukseklik_Ayar.TopMost = True
        Yukseklik_Ayar.Size = New Size(400, 50)
        Dim Trackbarr As New TrackBar
        Yukseklik_Ayar.Controls.Add(Trackbarr)
        Trackbarr.Dock = DockStyle.Top
        Trackbarr.Minimum = 0
        Trackbarr.Maximum = Screen.PrimaryScreen.WorkingArea.Height
        AddHandler Trackbarr.ValueChanged, AddressOf TrackHareket
        Yukseklik_Ayar.ShowDialog()


    End Sub

    Private Sub TrackHareket(sender As Object, e As EventArgs)
        Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
        Try
            USTBAR.Secilmis.Height = CType(sender, TrackBar).Value
            Obje_Yükseklik.Text = CType(sender, TrackBar).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Obje_Genişlik_DoubleClick(sender As Object, e As EventArgs) Handles Obje_Genişlik.DoubleClick
        Dim Genislik_Ayar As New Form
        Genislik_Ayar.ShowIcon = False
        Genislik_Ayar.BackColor = Color.White
        Genislik_Ayar.Text = "T# Genişlik"
        Genislik_Ayar.AutoSize = True
        Genislik_Ayar.TopMost = True
        Genislik_Ayar.Size = New Size(400, 50)
        Dim Trackbarr As New TrackBar
        Genislik_Ayar.Controls.Add(Trackbarr)
        Trackbarr.Dock = DockStyle.Top
        Trackbarr.Minimum = 0
        Trackbarr.Maximum = Screen.PrimaryScreen.WorkingArea.Width
        AddHandler Trackbarr.ValueChanged, AddressOf TrackHareket2
        Genislik_Ayar.ShowDialog()

    End Sub
    Private Sub TrackHareket2(sender As Object, e As EventArgs)
        Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
        Try
            USTBAR.Secilmis.Width = CType(sender, TrackBar).Value
            Obje_Genişlik.Text = CType(sender, TrackBar).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Obje_YazıBoyutu_DoubleClick(sender As Object, e As EventArgs) Handles Obje_YazıBoyutu.DoubleClick
        Dim Yazı_Boyutu As New Form
        Yazı_Boyutu.ShowIcon = False
        Yazı_Boyutu.BackColor = Color.White
        Yazı_Boyutu.Text = "T# Yazı Boyutu"
        Yazı_Boyutu.AutoSize = True
        Yazı_Boyutu.TopMost = True
        Yazı_Boyutu.Size = New Size(400, 50)
        Dim Trackbarr As New TrackBar
        Yazı_Boyutu.Controls.Add(Trackbarr)
        Trackbarr.Dock = DockStyle.Top
        Trackbarr.Minimum = 0
        Trackbarr.Maximum = 1000
        AddHandler Trackbarr.ValueChanged, AddressOf TrackHareket3
        Yazı_Boyutu.ShowDialog()

    End Sub
    Private Sub TrackHareket3(sender As Object, e As EventArgs)
        Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
        Try
            USTBAR.Secilmis.Font = New Font(USTBAR.Secilmis.Font.FontFamily, CType(sender, TrackBar).Value)
            Obje_YazıBoyutu.Text = CType(sender, TrackBar).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles İşaretle_combobox.SelectedIndexChanged

        Try
            Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
            CType(USTBAR.Secilmis, CheckBox).Checked = If(İşaretle_combobox.SelectedItem = "@AKTİF", True, False)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub deger_kutusu_DoubleClick(sender As Object, e As EventArgs) Handles deger_kutusu.DoubleClick
        Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
        Dim deger_kutusu As New Form
        deger_kutusu.ShowIcon = False
        deger_kutusu.BackColor = Color.White
        deger_kutusu.Text = "T# Değer"
        deger_kutusu.AutoSize = True
        deger_kutusu.TopMost = True
        deger_kutusu.Size = New Size(400, 50)
        Dim Trackbarr As New TrackBar
        deger_kutusu.Controls.Add(Trackbarr)
        Trackbarr.Dock = DockStyle.Top
        Trackbarr.Minimum = 0
        Trackbarr.Maximum = CType(USTBAR.Secilmis, ProgressBar).Maximum
        AddHandler Trackbarr.ValueChanged, AddressOf TrackHareket4
        deger_kutusu.ShowDialog()
    End Sub

    Private Sub TrackHareket4(sender As Object, e As EventArgs)
        Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
        Try
            CType(USTBAR.Secilmis, ProgressBar).Value = CType(sender, TrackBar).Value
            deger_kutusu.Text = CType(sender, TrackBar).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub deger_kutusu_TextChanged(sender As Object, e As EventArgs) Handles deger_kutusu.TextChanged
        Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
        Try
            CType(USTBAR.Secilmis, ProgressBar).Value = Convert.ToInt32(deger_kutusu.Text)

        Catch ex As Exception

        End Try
    End Sub

    '
    Private Sub TrackHareket5(sender As Object, e As EventArgs)
        Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
        Try
            CType(USTBAR.Secilmis, ProgressBar).Minimum = CType(sender, TrackBar).Value
            mindeger_kutusu.Text = CType(sender, TrackBar).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub
    '

    '
    Private Sub TrackHareket6(sender As Object, e As EventArgs)
        Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
        Try
            CType(USTBAR.Secilmis, ProgressBar).Maximum = CType(sender, TrackBar).Value
            maxdeger_kutusu.Text = CType(sender, TrackBar).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mindeger_kutusu_DoubleClick(sender As Object, e As EventArgs) Handles mindeger_kutusu.DoubleClick
        Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
        Dim deger_kutusu As New Form
        deger_kutusu.ShowIcon = False
        deger_kutusu.BackColor = Color.White
        deger_kutusu.Text = "T# Minimum Değer"
        deger_kutusu.AutoSize = True
        deger_kutusu.TopMost = True
        deger_kutusu.Size = New Size(400, 50)
        Dim Trackbarr As New TrackBar
        deger_kutusu.Controls.Add(Trackbarr)
        Trackbarr.Dock = DockStyle.Top
        Trackbarr.Minimum = 0
        Trackbarr.Maximum = 7000
        AddHandler Trackbarr.ValueChanged, AddressOf TrackHareket5
        deger_kutusu.ShowDialog()
    End Sub

    Private Sub maxdeger_kutusu_DoubleClick(sender As Object, e As EventArgs) Handles maxdeger_kutusu.DoubleClick
        Dim USTBAR As TSharpUSTBAR = TSharpUSTBAR
        Dim deger_kutusu As New Form
        deger_kutusu.ShowIcon = False
        deger_kutusu.BackColor = Color.White
        deger_kutusu.Text = "T# Maksimum Değer"
        deger_kutusu.AutoSize = True
        deger_kutusu.TopMost = True
        deger_kutusu.Size = New Size(400, 50)
        Dim Trackbarr As New TrackBar
        deger_kutusu.Controls.Add(Trackbarr)
        Trackbarr.Dock = DockStyle.Top
        Trackbarr.Minimum = 0
        Trackbarr.Maximum = 7000
        AddHandler Trackbarr.ValueChanged, AddressOf TrackHareket6
        deger_kutusu.ShowDialog()
    End Sub
    '

End Class

