Public Class frmAppOutInstellingen
    Private Sub frmAppOutInstellingen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

'Option Strict Off
'Option Explicit On
'Friend Class frmDNNinstellingen
'	Inherits System.Windows.Forms.Form
'	Private Sub CmdBewaar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdBewaar.Click

'		BeWaarTekst("dnnInstellingen", "URLlokaal", (Me.txtURLlokaal.Text))
'		BeWaarTekst("dnnInstellingen", "URLwww", (Me.txtURLwww.Text))
'		BeWaarTekst("dnnInstellingen", "PostvakIO", (Me.txtPDFpostvak.Text))
'		BeWaarTekst("dnnInstellingen", "SkyDrive", (Me.txtSkyDriveMap.Text))
'		Me.Close()

'	End Sub

'	Private Sub cmdSluiten_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSluiten.Click

'		Me.Close()

'	End Sub

'	Private Sub frmDNNinstellingen_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

'		'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(dnnInstellingen, SkyDrive). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'		If LaadTekst("dnnInstellingen", "SkyDrive") = "" Then
'			MsgBox("Nieuwe PC of nog geen instellingen voor SKYDRIVE of DNN.  Wijzig de volgende standaardwaarden a.u.b. voor uw bedrijf (zie aanbevelingen in onze DNN handleiding!) of vraag onze gratis bijstand om dit in uw plaats in orde te brengen.", MsgBoxStyle.Information)
'			Me.txtURLlokaal.Text = "http://localhost/rvDNN"
'			Me.txtURLwww.Text = "http://www.mijndomein.be/rvDNN"
'			Me.txtSkyDriveMap.Text = "C:\Users\NaamVanGebruiker\SkyDrive"
'			Me.txtPDFpostvak.Text = "c:\dotnetnuke\rvDNN\portals\0\documenten\postvak"
'		Else
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.txtURLlokaal.Text = LaadTekst("dnnInstellingen", "URLlokaal")
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.txtURLwww.Text = LaadTekst("dnnInstellingen", "URLwww")
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.txtSkyDriveMap.Text = LaadTekst("dnnInstellingen", "SkyDrive")
'			'UPGRADE_WARNING: Couldn't resolve default property of object LaadTekst(). Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
'			Me.txtPDFpostvak.Text = LaadTekst("dnnInstellingen", "PostvakIO")
'		End If

'	End Sub
'End Class