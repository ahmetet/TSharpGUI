
Imports System.IO
Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' AddHandler Click, AddressOf Obje_Click

        Dim sevgili As Ozellikler = Ozellikler
        Dim arkadas As TSharpUSTBAR = TSharpUSTBAR
        Dim aile As Ayar = Ayar
        arkadas.Show()
        With arkadas
            .Left = 10
            .Top = 10
        End With

        With Me
            .Left = arkadas.Left + arkadas.Width + 5
            .Top = 120
            .Width = 800
            .Height = 500
        End With
        sevgili.Show()
        With sevgili
            .Left = Me.Width + Me.Left + 5
            .Top = 10

        End With


        aile.Show()
        With aile
            .Left = arkadas.Width + 15
            .Top = 10
            .Width = Me.Width
        End With

    End Sub

    'Private Sub Taslak()

    '    With arkadas
    '        .Left = 10
    '        .Top = 10
    '    End With

    '    With Me
    '        .Left = arkadas.Left + arkadas.Width + 5
    '        .Top = 120
    '        .Width = 800
    '        .Height = 500
    '    End With
    '    sevgili.Show()
    '    With sevgili
    '        .Left = Me.Width + Me.Left + 5
    '        .Top = 10

    '    End With


    '    aile.Show()
    '    With aile
    '        .Left = arkadas.Width + 15
    '        .Top = 10
    '        .Width = Me.Width
    '    End With
    'End Sub
End Class
