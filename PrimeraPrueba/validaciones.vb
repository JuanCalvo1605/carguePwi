Module validaciones
    Public Sub limpiarError(ByVal sender As Object, ByVal e As EventArgs)
        'validaciones de texbox
        Dim timer As Timer = CType(sender, Timer)
        Dim label As Label = CType(timer.Tag, Label)
        label.Text = ""
        timer.Enabled = False
    End Sub

    Public Sub ValidarCampoV(ByVal txt As TextBox, ByVal lbl As Label, ByVal msj As String, ByVal tiempo As Integer)
        'validaciones de tiempo
        lbl.Text = msj
        Dim timer As New Timer
        AddHandler timer.Tick, AddressOf limpiarError
        timer.Interval = tiempo
        timer.Tag = lbl
        timer.Enabled = True
    End Sub
    Public Sub limpiarErrorSelec(ByVal sender As Object, ByVal e As EventArgs)
        'validaciones de tiempo para combobox
        Dim timer As Timer = CType(sender, Timer)
        Dim label As Label = CType(timer.Tag, Label)
        label.Text = ""
        timer.Enabled = False
    End Sub

    Public Sub ValidarCampoVSelect(ByVal cmb As ComboBox, ByVal lbl As Label, ByVal msj As String, ByVal tiempo As Integer)
        'validaciones de combobox
        lbl.Text = msj
        Dim timer As New Timer
        AddHandler timer.Tick, AddressOf limpiarError
        timer.Interval = tiempo
        timer.Tag = lbl
        timer.Enabled = True
    End Sub
End Module
