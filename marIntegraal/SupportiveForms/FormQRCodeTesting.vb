Imports QRCoder

Public Class FormQRCodeTesting
    Private Sub FormQRCodeTesting_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnQRGenerate_Click(sender As Object, e As EventArgs) Handles BtnQRGenerate.Click

        Dim qr As New QRCodeGenerator()
        Dim Data As QRCodeData = qr.CreateQrCode(TbQRCode.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(Data)
        Pic.Image = code.GetGraphic(5)

    End Sub

    Private Sub BtnDemoText_Click(sender As Object, e As EventArgs) Handles BtnDemoText.Click

        Dim serviceTagValue = "BCD" + vbCrLf
        Dim versionValue = "001" + vbCrLf
        Dim charactersetValue = "1" + vbCrLf
        Dim identificationValue = "SCT" + vbCrLf
        Dim bicValue = "VDSPBE91" + vbCrLf
        Dim nameValue = "Roelandt en Vermoesen bv" + vbCrLf
        Dim ibanValue = "BE83891854037015" + vbCrLf
        Dim amountValue = "EUR394.99" + vbCrLf
        Dim purposeValue = "GDDS" + vbCrLf
        Dim referenceValue = "107/0404/08059" + vbCrLf
        Dim remittanceValue = vbCrLf
        Dim informationValue = vbCrLf

        Dim qrTMP = serviceTagValue + versionValue + charactersetValue + identificationValue + bicValue + nameValue + ibanValue + amountValue + purposeValue + referenceValue + remittanceValue + informationValue
        TbQRCode.Text = qrTMP

    End Sub
End Class