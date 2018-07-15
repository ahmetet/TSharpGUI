Public Class Ayar
    Dim Program As String = ""
    Dim Derleme_islemi As Boolean = False
    Private Sub DerleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DerleToolStripMenuItem.Click

        TaslakOlustur()

        Derle(Program)


    End Sub

    Private Sub ÇalıştırToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÇalıştırToolStripMenuItem.Click
        Try
            If (Derleme_islemi = True) Then
                Çalıştır("Z:\T#\TSharp\TSharp\bin\Debug\Testler\GUI\GUIHelper\deneme.tr")
                Derleme_islemi = False
            Else
                MessageBox.Show("Lütfen önce projeyi derleyiniz!")

            End If
        Catch ex As Exception
            '     MessageBox.Show("Hata:" + "9")
        End Try
    End Sub


    Sub TaslakOlustur()

        Program = "#Pencere{
        @Başlık=""Merhaba_Dünya"";
        @Simge=" + If(Form1.ShowIcon, "@AKTİF", "@PASİF") + "; 
        @Yükseklik=" + Form1.Height.ToString() + ";
        @Genişlik=" + Form1.Width.ToString() + ";
        @Arkaplan=(" + Form1.BackColor.R.ToString() + "," + Form1.BackColor.G.ToString() + "," + Form1.BackColor.B.ToString() + ");
        @Renk=(" + Form1.ForeColor.R.ToString() + "," + Form1.ForeColor.G.ToString() + "," + Form1.ForeColor.B.ToString() + ");
        @Konum=(" + Form1.Location.X.ToString() + "," + Form1.Location.Y.ToString() + ");
        }
        "
    End Sub

    Private Sub PreDerle()
        Dim anacik As Form1 = Form1
        _linpesto = ""
        Dim linpesto As String = ""
        Dim Obje_başlık As String = ""
        Dim Obje_özellik As String = ""
        'AŞAMA1

        Try
            For Each objecik In anacik.Controls
                Dim david As Control = objecik

                Obje_başlık = ""
                Obje_özellik = ""
                'BUTTON
                'TEXTBOX
                'CHECKBOX
                'PROGRESSBAR
                'LABEL

                '#Pencere
                '#Buton
                '#Metinkutusu
                '#Etiket
                '#İşlemçubuğu
                '#Onaykutusu							/#İşaretkutusu


                'Obje_başlık
                '{
                'Obje_özellik
                '}


                If (TypeOf david Is Button) Then
                    Obje_başlık = "#Buton"
                End If
                If (TypeOf david Is TextBox) Then
                    Obje_başlık = "#MetinKutusu"
                End If
                If (TypeOf david Is Label) Then
                    Obje_başlık = "#Etiket"
                End If
                If (TypeOf david Is CheckBox) Then
                    Obje_başlık = "#OnayKutusu"
                    Obje_özellik += "@İşaretle=" + If(CType(david, CheckBox).Checked, "@AKTİF", "@PASİF") + ";" + vbNewLine
                End If
                If (TypeOf david Is ProgressBar) Then
                    Obje_başlık = "#İşlemÇubuğu"
                    Obje_özellik += "@MinimumDeğer=" + CType(david, ProgressBar).Minimum.ToString() + ";" + vbNewLine
                    Obje_özellik += "@MaksimumDeğer=" + CType(david, ProgressBar).Maximum.ToString() + ";" + vbNewLine
                    Obje_özellik += "@Değer=" + CType(david, ProgressBar).Value.ToString() + ";" + vbNewLine

                End If
                If (TypeOf david Is Form) Then
                    Obje_özellik += "@Simge=" + If(CType(david, Form).ShowIcon, "@AKTİF", "@PASİF") + ";" + vbNewLine
                End If


                With david
                    Obje_özellik += "@Başlık=""" + .Text.ToString() + """;" + vbNewLine
                    Obje_özellik += "@Renk=" + "(" + .ForeColor.R.ToString + "," + .ForeColor.G.ToString + "," + .ForeColor.B.ToString + ")" + ";" + vbNewLine
                    Obje_özellik += "@Arkaplan=" + "(" + .BackColor.R.ToString + "," + .BackColor.G.ToString + "," + .BackColor.B.ToString + ")" + ";" + vbNewLine
                    Obje_özellik += "@Konum=" + "(" + .Location.X.ToString + "," + .Location.Y.ToString + ")" + ";" + vbNewLine
                    Obje_özellik += "@Genişlik=" + .Width.ToString() + ";" + vbNewLine
                    Obje_özellik += "@Yükseklik=" + .Height.ToString() + ";" + vbNewLine
                    Obje_özellik += "@Boyut=" + .Font.Size.ToString() + ";" + vbNewLine




                End With

                If (String.IsNullOrEmpty(david.Tag) Or String.IsNullOrWhiteSpace(david.Tag)) Then

                Else
                    For Each kodcuk In david.Tag.ToString.Trim.ToLower.Split(";")
                        'erişim
                        'görünürlük
                        MessageBox.Show(kodcuk.Split("=")(1))
                        If (kodcuk.Contains("@erişim")) Then
                            Obje_özellik += "@Erişim=" + kodcuk.Split("=")(1) + ";" + vbNewLine
                        End If
                        If (kodcuk.Contains("@görünürlük")) Then
                            Obje_özellik += "@Görünürlük=" + kodcuk.Split("=")(1) + ";" + vbNewLine
                        End If


                    Next
                End If



                linpesto += Obje_başlık + "{" + vbNewLine + Obje_özellik + "}" + vbNewLine + vbNewLine

                _linpesto = linpesto
            Next


        Catch ex As Exception
            '  MessageBox.Show("Hata:" + "8")
        End Try


    End Sub
    Dim _linpesto As String = ""
    Private Sub Derle(ByVal kodlar As String)

        'AŞAMA1
        PreDerle()


        'AŞAMA2
        Try

            Dim EnSon As String = kodlar + vbNewLine + _linpesto
            EnSon = EnSon.Replace(" ", "").Replace("\n", "")
            Dim tempyol As String = "Z:\T#\TSharp\TSharp\bin\Debug\Testler\GUI\GUIHelper\deneme.tr"
            My.Computer.FileSystem.WriteAllText(tempyol, EnSon, False)
            Derleme_islemi = True
            MessageBox.Show("Derleme Başarılı!")
        Catch ex As Exception
            ' MessageBox.Show("Hata:" + "7")
        End Try
    End Sub
    Private Sub Çalıştır(ByVal yol As String)
        Process.Start(yol) 'BUNA FARKLI BİR ÇÖZÜM GETİRİLECEK O ZAMAN KADAR..
    End Sub

    Private Sub Ayar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub KaydetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaydetToolStripMenuItem.Click
        If (Derleme_islemi = False) Then
            MessageBox.Show("Lütfen önce projeyi derleyiniz!")

        Else
            PreDerle()

            SaveFileDialog1.Filter = "T# Proje Dosyası (*.tr)|*.tr"
            If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
                Dim EnSon As String = Program + vbNewLine + _linpesto
                EnSon = EnSon.Replace(" ", "").Replace("\n", "")
                Dim tempyol As String = SaveFileDialog1.FileName
                MessageBox.Show(tempyol)
                My.Computer.FileSystem.WriteAllText(tempyol, EnSon, False)
                Derleme_islemi = True
                MessageBox.Show("Başarıyla kaydedildi!")
                Derleme_islemi = False
            End If

        End If

    End Sub
End Class