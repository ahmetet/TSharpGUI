Public Class TSharpUSTBAR
    Dim ANA As Form1 = Form1
    Dim YAN As Ozellikler = Ozellikler
    Public Secilmis As Control
    Private Sub TSharpUSTBAR_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Me.Width = 152
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height - 50
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)



    End Sub


    Public _Hareket As Boolean
    Public _x As Integer
    Public _y As Integer

    Public Sub Obje_MouseDown(sender As Object, e As MouseEventArgs)
        _Hareket = True
        _x = e.Location.X
        _y = e.Location.Y
    End Sub

    Public Sub Obje_MouseMove(sender As Object, e As MouseEventArgs)
        If _Hareket Then
            CType(sender, Object).Location = New Point(CType(sender, Object).Location.X + (e.Location.X - _x), CType(sender, Object).Location.Y + (e.Location.Y - _y))
        End If
    End Sub

    Public Sub Obje_MouseUp(sender As Object, e As MouseEventArgs)
        _Hareket = False
    End Sub

    Public Sub Obje_Click(sender As Object, e As MouseEventArgs)

        Try
            Secilmis = CType(sender, Control)

            YAN.Obje_Başlık.Text = CType(sender, Control).Text.ToString()
            YAN.Obje_YazıRengi.Text = "(" + CType(sender, Control).ForeColor.R.ToString() + "," + CType(sender, Control).ForeColor.G.ToString() + "," + CType(sender, Control).ForeColor.B.ToString() + ")"
            YAN.Obje_Arkaplan.Text = "(" + CType(sender, Control).BackColor.R.ToString() + "," + CType(sender, Control).BackColor.G.ToString() + "," + CType(sender, Control).BackColor.B.ToString() + ")"
            YAN.Obje_Genişlik.Text = CType(sender, Control).Width.ToString()
            YAN.Obje_Yükseklik.Text = CType(sender, Control).Height.ToString()
            YAN.Obje_Konum.Text = "(" + CType(sender, Control).Location.X.ToString() + "," + CType(sender, Control).Location.Y.ToString() + ")"
            YAN.Obje_YazıBoyutu.Text = CType(sender, Control).Font.Size.ToString()
            YAN.İşaretle_combobox.Visible = False
            YAN.Label5.Visible = False
            YAN.mindeger_etiket.Visible = False
            YAN.mindeger_kutusu.Visible = False
            YAN.deger_etiket.Visible = False
            YAN.deger_kutusu.Visible = False
            YAN.maxdeger_etiket.Visible = False
            YAN.maxdeger_kutusu.Visible = False
            If (TypeOf CType(sender, Control) Is CheckBox) Then
                YAN.İşaretle_combobox.Visible = True
                YAN.Label5.Visible = True
                YAN.İşaretle_combobox.SelectedIndex = If(CType(sender, CheckBox).Checked, 0, 1)
            End If
            If (TypeOf CType(sender, Control) Is ProgressBar) Then
                YAN.mindeger_etiket.Visible = True
                YAN.mindeger_kutusu.Visible = True
                YAN.deger_etiket.Visible = True
                YAN.deger_kutusu.Visible = True
                YAN.maxdeger_etiket.Visible = True
                YAN.maxdeger_kutusu.Visible = True
            End If
        Catch ex As Exception
            'MessageBox.Show("Hata:" + "1")
        End Try

    End Sub

    Private Sub sil(sender As Object, e As EventArgs)
        Dim ana As Form1 = Form1
        Dim a = CType(sender, ToolStripMenuItem)
        Dim b = CType(a.Owner, ContextMenuStrip)
        ana.Controls.Remove(b.SourceControl)
    End Sub


    Private Sub Yarat(ByVal Yaratılacak As Control)


        Dim PrototipContextMenuStrip As New ContextMenuStrip
        Dim PrototipSil As New ToolStripMenuItem
        PrototipSil.Text = "Sil"
        PrototipContextMenuStrip.Items.Add(PrototipSil)

        With Yaratılacak
            .Text = "Merhaba"
            .ContextMenuStrip = PrototipContextMenuStrip
            .Size = New Size(100, 50)
            .Location = New Point(0, 0)
        End With

        AddHandler Yaratılacak.MouseUp, AddressOf Obje_MouseUp
        AddHandler Yaratılacak.MouseMove, AddressOf Obje_MouseMove
        AddHandler Yaratılacak.MouseDown, AddressOf Obje_MouseDown
        AddHandler Yaratılacak.Click, AddressOf Obje_Click
        AddHandler PrototipSil.Click, AddressOf sil

        ANA.Controls.Add(Yaratılacak)
    End Sub



    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim PrototipButon As New Button
        Dim PrototipContextMenuStrip As New ContextMenuStrip
        Dim PrototipSil As New ToolStripMenuItem
        PrototipSil.Text = "Sil"

        PrototipContextMenuStrip.Items.Add(PrototipSil)
        With PrototipButon
            .Text = "Buton"
            .ContextMenuStrip = PrototipContextMenuStrip
            .Width = 100
            .Height = 100
            .Location = New Point(0, 0)

        End With

        AddHandler PrototipButon.MouseUp, AddressOf Obje_MouseUp
        AddHandler PrototipButon.MouseMove, AddressOf Obje_MouseMove
        AddHandler PrototipButon.MouseDown, AddressOf Obje_MouseDown
        AddHandler PrototipButon.Click, AddressOf Obje_Click
        AddHandler PrototipSil.Click, AddressOf sil

        ANA.Controls.Add(PrototipButon)
    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click
        Dim PrototipLabel As New Label
        Dim PrototipContextMenuStrip As New ContextMenuStrip
        Dim PrototipSil As New ToolStripMenuItem
        PrototipSil.Text = "Sil"
        PrototipContextMenuStrip.Items.Add(PrototipSil)

        With PrototipLabel
            .Text = "Etiket"
            .ContextMenuStrip = PrototipContextMenuStrip
            .AutoSize = True
            .Location = New Point(0, 0)

        End With

        AddHandler PrototipLabel.MouseUp, AddressOf Obje_MouseUp
        AddHandler PrototipLabel.MouseMove, AddressOf Obje_MouseMove
        AddHandler PrototipLabel.MouseDown, AddressOf Obje_MouseDown
        AddHandler PrototipLabel.Click, AddressOf Obje_Click
        AddHandler PrototipSil.Click, AddressOf sil

        ANA.Controls.Add(PrototipLabel)
    End Sub


    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        Yarat(New CheckBox)
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Yarat(New TextBox)
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        Yarat(New ProgressBar)
    End Sub

    Private Sub TSharpUSTBAR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        YAN.İşaretle_combobox.Visible = False
        YAN.Label5.Visible = False
        YAN.mindeger_etiket.Visible = False
        YAN.mindeger_kutusu.Visible = False
        YAN.deger_etiket.Visible = False
        YAN.deger_kutusu.Visible = False
        YAN.maxdeger_etiket.Visible = False
        YAN.maxdeger_kutusu.Visible = False
    End Sub
End Class