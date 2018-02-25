Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Data.SqlClient

Public Class Form1

    Dim CN As SqlConnection
    Dim CMD As SqlCommand
    Dim current As Integer
    Dim adding As Boolean

    ' Conexao iniciada mal a aplicação é aberta e amostra dos conteudos do primeiro separador (Astro)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CN = New SqlConnection("data source=(local)\SQLEXPRESS;integrated security=true;initial catalog=MORSA")
        CN = New SqlConnection("data source=tcp: 193.136.175.33\SQLSERVER2012,8293 ;initial catalog = p6g1 ;uid = p6g1 ;password = bd_p6g1")

        CMD = New SqlCommand
        CMD.Connection = CN

        CMD.CommandText = "SELECT * FROM MORSA.astro"
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        astroList.Items.Clear()
        While RDR.Read
            Dim C As New Astro
            C.astroID = RDR.Item("id") 'nome das tabelas originais
            C.astroType = RDR.Item("tipo")
            C.astroSystem = RDR.Item("sistema")
            C.astroGalaxy = RDR.Item("galaxia")
            astroList.Items.Add(C)
        End While
        CN.Close()
        current = 0
        ShowAstro()
        LockControls()
        ShowButtons()
    End Sub

    ' Função que gere seleção dos separadores
    Private Sub TabControl1_Selected(sender As Object, e As TabControlEventArgs) Handles TabControl1.Selected
        LockControls()
        ShowButtons()
        If TabControl1.SelectedTab Is tabAstro Then 'TAB Astro selecionada
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "SELECT * FROM MORSA.astro"
            CN.Open()
            Dim RDR As SqlDataReader
            RDR = CMD.ExecuteReader
            astroList.Items.Clear()
            txtAstroPesq.Clear()
            While RDR.Read
                Dim C As New Astro
                C.astroID = RDR.Item("id") 'nome da variavel na classe = nome das colunas originais
                C.astroType = RDR.Item("tipo")
                C.astroSystem = RDR.Item("sistema")
                C.astroGalaxy = RDR.Item("galaxia")
                astroList.Items.Add(C)
            End While
            CN.Close()
            current = 0
            ShowAstro()
        ElseIf TabControl1.SelectedTab Is tabCompanhia Then 'TAB Companhia selecionada
            If comboBoxComp.Items.Count > 0 Then
                comboBoxComp.SelectedIndex = 0    ' The first item has index 0 '
            End If
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "SELECT * FROM MORSA.companhia"
            CN.Open()
            Dim RDR As SqlDataReader
            RDR = CMD.ExecuteReader
            companhiaList.Items.Clear()
            txtCompPesq.Clear()
            While RDR.Read
                Dim C As New Companhia
                C.companhiaNome = RDR.Item("nome") 'nome da variavel na classe = nome das colunas originais
                C.companhiaNIF = RDR.Item("nif")
                C.companhiaTelef = RDR.Item("telef")
                C.companhiaEnder = RDR.Item("Ender")
                C.companhiaCodPos = RDR.Item("codPos")
                C.companhiaSede = RDR.Item("sede")
                companhiaList.Items.Add(C)
            End While
            CN.Close()
            current = 0
            showCompanhia()
        ElseIf TabControl1.SelectedTab Is tabSatelite Then 'TAB Satelite selecionada
            If comboBoxSat.Items.Count > 0 Then
                comboBoxSat.SelectedIndex = 0    ' The first item has index 0 '
            End If
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "SELECT * FROM MORSA.satelite join MORSA.satelite_status on MORSA.satelite.id=MORSA.satelite_status.id"
            CN.Open()
            Dim RDR As SqlDataReader
            RDR = CMD.ExecuteReader
            sateliteList.Items.Clear()
            txtSatPesq.Clear()
            While RDR.Read
                Dim C As New Satelite
                C.satID = RDR.Item("id") 'nome da variavel na classe = nome das colunas originais
                C.satNome = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("nome")), "", RDR.Item("nome")))
                C.satServ = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("servico")), "", RDR.Item("servico")))
                C.satPaisOrg = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("paisOrgan")), "", RDR.Item("paisOrgan")))
                C.satCompLog = RDR.Item("compLog")
                C.satLanc = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("lancam")), "", RDR.Item("lancam")))
                C.satStatus = RDR.Item("status")
                sateliteList.Items.Add(C)
            End While
            CN.Close()
            current = 0
            showSat()
        ElseIf TabControl1.SelectedTab Is tabEE Then 'TAB EE selecionada
            If comboBoxEE.Items.Count > 0 Then
                comboBoxEE.SelectedIndex = 0    ' The first item has index 0 '
            End If
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "SELECT * FROM MORSA.estacaoEspacial join MORSA.estacaoEspacial_status on MORSA.estacaoEspacial.id=MORSA.estacaoEspacial_status.id"
            CN.Open()
            Dim RDR As SqlDataReader
            RDR = CMD.ExecuteReader
            eeList.Items.Clear()
            txtEEPesq.Clear()
            While RDR.Read
                Dim C As New EstacaoEspacial
                C.estEspID = RDR.Item("id") 'nome da variavel na classe = nome das colunas originais
                C.estEspNome = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("nome")), "", RDR.Item("nome")))
                C.estEspPaisOrg = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("paisOrgan")), "", RDR.Item("paisOrgan")))
                C.estEspCompLog = RDR.Item("compLog")
                C.estStatus = RDR.Item("status")
                eeList.Items.Add(C)
            End While
            CN.Close()
            current = 0
            showEE()
        ElseIf TabControl1.SelectedTab Is tabMee Then 'TAB Mee selecionada
            If comboBoxMee.Items.Count > 0 Then
                comboBoxMee.SelectedIndex = 0    ' The first item has index 0 '
            End If
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "SELECT * FROM MORSA.moduloEstacaoEspacial"
            CN.Open()
            Dim RDR As SqlDataReader
            RDR = CMD.ExecuteReader
            meeList.Items.Clear()
            txtMeePesq.Clear()
            While RDR.Read
                Dim C As New ModuloEE
                C.moduloID = RDR.Item("id") 'nome da variavel na classe = nome das colunas originais
                C.moduloNome = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("nome")), "", RDR.Item("nome")))
                C.moduloTipo = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("tipo")), "", RDR.Item("tipo")))
                C.moduloCompLog = RDR.Item("compLog")
                C.moduloLanc = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("lancam")), "", RDR.Item("lancam")))
                C.moduloEE = RDR.Item("estacaoEspac")
                meeList.Items.Add(C)
            End While
            CN.Close()
            current = 0
            showMee()
        ElseIf TabControl1.SelectedTab Is tabOrbita Then 'TAB Orbita selecionada
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "SELECT * FROM MORSA.orbita"
            CN.Open()
            Dim RDR As SqlDataReader
            RDR = CMD.ExecuteReader
            orbList.Items.Clear()
            While RDR.Read
                Dim C As New Orbita
                C.orbitaID = RDR.Item("id") 'nome da variavel na classe = nome das colunas originais
                C.orbitaApoastro = RDR.Item("apoastro")
                C.orbitaPeriastro = RDR.Item("periastro")
                C.orbitaInclin = RDR.Item("inclin")
                C.orbitaPeriodo = RDR.Item("periodo")
                C.orbitaAstro = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("astro")), "", RDR.Item("astro")))
                orbList.Items.Add(C)
            End While
            CN.Close()
            current = 0
            ShowOrbita()
        ElseIf TabControl1.SelectedTab Is tabLanc Then 'TAB Lançamento selecionada
            CMD.CommandType = CommandType.Text
            CMD.CommandText = "SELECT * FROM MORSA.lancamento join MORSA.veiculoLancamento on MORSA.lancamento.id = MORSA.veiculoLancamento.id"
            CN.Open()
            Dim RDR As SqlDataReader
            RDR = CMD.ExecuteReader
            lancList.Items.Clear()
            txtLancPesq.Clear()
            While RDR.Read
                Dim C As New Lanc
                C.lancID = RDR.Item("id") 'nome da variavel na classe = nome das colunas originais
                C.lancCoord = RDR.Item("coord")
                C.lancPais = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("pais")), "", RDR.Item("pais")))
                C.lancDT = RDR.Item("dataTempo")
                C.lancVeicN = RDR.Item("nome")
                C.lancVeicCL = RDR.Item("compLog")
                lancList.Items.Add(C)
            End While
            CN.Close()
            current = 0
            ShowLanc()
        ElseIf TabControl1.SelectedTab Is tabPesquisa Then
            If comboBoxPesq.Items.Count > 0 Then
                comboBoxPesq.SelectedIndex = 0    ' The first item has index 0 '
            End If
            radioBttnPesq1.Text = "Satelites"
            radioBttnPesq2.Text = "Modulos"
            lblPesq.Text = "Pesquisar por (ID) Lancamentos efetuados"
        End If
    End Sub

    ' Mostra informação do astro selecionado
    Sub ShowAstro()
        If astroList.Items.Count = 0 Or current < 0 Then Exit Sub
        Dim astro As New Astro
        astro = CType(astroList.Items.Item(current), Astro)
        txtAstroID.Text = astro.astroID
        txtAstroType.Text = astro.astroType
        txtAstroSystem.Text = astro.astroSystem
        txtAstroGalaxy.Text = astro.astroGalaxy
    End Sub

    ' Mostra informação da Companhia selecionado
    Sub showCompanhia()
        If companhiaList.Items.Count = 0 Or current < 0 Then Exit Sub
        Dim comp As New Companhia
        comp = CType(companhiaList.Items.Item(current), Companhia)
        txtCompName.Text = comp.companhiaNome
        txtCompNIF.Text = comp.companhiaNIF
        txtCompTelef.Text = comp.companhiaTelef
        txtCompEnder.Text = comp.companhiaEnder
        txtCompCodPos.Text = comp.companhiaCodPos
        txtCompSede.Text = comp.companhiaSede
    End Sub

    ' Mostra informação do Satelite selecionado
    Sub showSat()
        If sateliteList.Items.Count = 0 Or current < 0 Then Exit Sub
        Dim sat As New Satelite
        sat = CType(sateliteList.Items.Item(current), Satelite)

        CMD.Parameters.Clear() 'Clear dos parametros'
        CMD.CommandText = "MORSA.pr_satCompMae"   'nome da SP'
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Add("@satID", SqlDbType.VarChar, 11).Value = sat.satID 'parametro de entrada'

        CMD.Parameters.Add(New SqlParameter("@comp", SqlDbType.VarChar, 200)) 'tipo parametro de saida'
        CMD.Parameters("@comp").Direction = ParameterDirection.Output 'parametro de saida'
        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        sat.satCompsMae = Convert.ToString(CMD.Parameters("@comp").Value)

        txtSatID.Text = sat.satID
        txtSatNome.Text = sat.satNome
        txtSatServico.Text = sat.satServ
        txtSatPaisOrg.Text = sat.satPaisOrg
        txtSatCompLog.Text = sat.satCompLog
        txtSatLanc.Text = sat.satLanc
        txtSatStatus.Text = sat.satStatus
        txtSatComp.Text = sat.satCompsMae
    End Sub

    ' Mosta informação da EE selecionado
    Sub showEE()
        If eeList.Items.Count = 0 Or current < 0 Then Exit Sub
        Dim ee As New EstacaoEspacial
        ee = CType(eeList.Items.Item(current), EstacaoEspacial)
        CMD.Parameters.Clear() 'Clear dos parametros'
        CMD.CommandText = "MORSA.pr_eeCompMae"   'nome da SP'
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Add("@eeID", SqlDbType.VarChar, 11).Value = ee.estEspID 'parametro de entrada = sql'

        CMD.Parameters.Add(New SqlParameter("@comp", SqlDbType.VarChar, 200)) 'tipo nome e parametro de saida = sql'
        CMD.Parameters("@comp").Direction = ParameterDirection.Output 'parametro de saida'
        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        ee.estEspCompMae = Convert.ToString(CMD.Parameters("@comp").Value)

        txtEEID.Text = ee.estEspID
        txtEENome.Text = ee.estEspNome
        txtEEPaisOrg.Text = ee.estEspPaisOrg
        txtEECompLog.Text = ee.estEspCompLog
        txtEEStatus.Text = ee.estStatus
        txtCMEE.Text = ee.estEspCompMae
    End Sub

    ' Mosta informação do ModuloEE selecionado
    Sub showMee()
        If meeList.Items.Count = 0 Or current < 0 Then Exit Sub
        Dim mee As New ModuloEE
        mee = CType(meeList.Items.Item(current), ModuloEE)
        txtMeeID.Text = mee.moduloID
        txtMeeNome.Text = mee.moduloNome
        txtMeeTipo.Text = mee.moduloTipo
        txtMeeCompLog.Text = mee.moduloCompLog
        txtMeeLanc.Text = mee.moduloLanc
        txtMeeEE.Text = mee.moduloEE
    End Sub

    ' Mosta informação da Orbita selecionada
    Sub ShowOrbita()
        If orbList.Items.Count = 0 Or current < 0 Then Exit Sub
        Dim orbita As New Orbita
        orbita = CType(orbList.Items.Item(current), Orbita)
        txtOrbID.Text = orbita.orbitaID
        txtOrbAp.Text = orbita.orbitaApoastro
        txtOrbPe.Text = orbita.orbitaPeriastro
        txtOrbIn.Text = orbita.orbitaInclin
        txtOrbPer.Text = orbita.orbitaPeriodo
        txtOrbAstro.Text = orbita.orbitaAstro
    End Sub

    ' Mostra informação do lançamento selecionado
    Sub ShowLanc()
        If lancList.Items.Count = 0 Or current < 0 Then Exit Sub
        Dim lanc As New Lanc
        lanc = CType(lancList.Items.Item(current), Lanc)

        CMD.Parameters.Clear() 'Clear dos parametros'
        CMD.CommandText = "MORSA.pr_searchLancObj"   'nome da SP'
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Add("@lancID", SqlDbType.VarChar, 11).Value = lanc.lancID 'parametro de entrada'

        CMD.Parameters.Add(New SqlParameter("@objID", SqlDbType.VarChar, 11)) 'tipo parametro de saida'
        CMD.Parameters("@objID").Direction = ParameterDirection.Output 'parametro de saida'
        CN.Open()
        CMD.ExecuteNonQuery()
        CN.Close()
        lanc.lancObj = Convert.ToString(CMD.Parameters("@objID").Value)

        txtLancID.Text = lanc.lancID
        txtLancCoord.Text = lanc.lancCoord
        txtLancPais.Text = lanc.lancPais
        txtLancDT.Text = lanc.lancDT
        txtLancVeicN.Text = lanc.lancVeicN
        txtLancVeicCL.Text = lanc.lancVeicCL
        txtLancObj.Text = lanc.lancObj

    End Sub

    ' Função que gere seleção na listbox dos Astros -> chama ShowAstro()
    Private Sub astroList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles astroList.SelectedIndexChanged
        If astroList.SelectedIndex > -1 Then
            current = astroList.SelectedIndex
            ShowAstro()
        End If
    End Sub

    ' Função que gere seleção na listbox das Companhias -> chama ShowCompanhia()
    Private Sub companhiaList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles companhiaList.SelectedIndexChanged
        If companhiaList.SelectedIndex > -1 Then
            current = companhiaList.SelectedIndex
            showCompanhia()
        End If
    End Sub

    ' Função que gere seleção na listbox dos Satelites -> chama ShowSat()
    Private Sub sateliteList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sateliteList.SelectedIndexChanged
        If sateliteList.SelectedIndex > -1 Then
            current = sateliteList.SelectedIndex
            showSat()
        End If
    End Sub

    ' Função que gere seleção na listbox das EE -> chama ShowEE()
    Private Sub eeList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles eeList.SelectedIndexChanged
        If eeList.SelectedIndex > -1 Then
            current = eeList.SelectedIndex
            showEE()
        End If
    End Sub

    ' Função que gere seleção na listbox dos ModuloEE -> chama ShowMee()
    Private Sub meeList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles meeList.SelectedIndexChanged
        If meeList.SelectedIndex > -1 Then
            current = meeList.SelectedIndex
            showMee()
        End If
    End Sub

    ' Função que gere seleção na listbox das Orbitas -> chama ShowOrbita()
    Private Sub orbList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles orbList.SelectedIndexChanged
        If orbList.SelectedIndex > -1 Then
            current = orbList.SelectedIndex
            ShowOrbita()
        End If
    End Sub

    ' Função que gere seleção na listbox dos Lancamentos -> chama ShowLanc()
    Private Sub lancList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lancList.SelectedIndexChanged
        If lancList.SelectedIndex > -1 Then
            current = lancList.SelectedIndex
            ShowLanc()
        End If
    End Sub

    ' TAB ASTRO
    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles bttnAstroAdd.Click
        adding = True
        HideButtons()
        ClearFields()
        astroList.Enabled = False
    End Sub

    Private Sub buttonEdit_Click(sender As Object, e As EventArgs) Handles bttnAstroEdit.Click
        current = astroList.SelectedIndex
        If current < 0 Then
            MsgBox("Please select a Astro to edit")
            Exit Sub
        End If
        adding = False
        HideButtons()
        txtAstroID.ReadOnly = True
    End Sub

    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles bttnAstroDel.Click
        If astroList.SelectedIndex > -1 Then
            Try
                RemoveAstro(CType(astroList.SelectedItem, Astro).astroID)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            astroList.Items.RemoveAt(astroList.SelectedIndex)
            If current = astroList.Items.Count Then current = astroList.Items.Count - 1
            If current = -1 Then
                ClearFields()
                MsgBox("There are no more Astros")
            Else
                ShowAstro()
            End If
        End If
    End Sub

    Private Sub bttnAstroOK_Click(sender As Object, e As EventArgs) Handles bttnAstroOK.Click
        Try
            SaveAstro()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        astroList.Enabled = True
        Dim idx As Integer = astroList.FindString(txtAstroID.Text)
        astroList.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub bttnAstroCan_Click(sender As Object, e As EventArgs) Handles bttnAstroCan.Click
        astroList.Enabled = True
        If astroList.Items.Count > 0 Then
            current = astroList.SelectedIndex
            If current < 0 Then current = 0
            ShowAstro()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Private Sub SubmitAstro(ByVal A As Astro)
        CMD.CommandText = "MORSA.pr_addAstro"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@astroID", SqlDbType.VarChar, 11).Value = A.astroID 'parametro de entrada = sql'
        CMD.Parameters.Add("@astroTipo", SqlDbType.VarChar, 20).Value = A.astroType
        CMD.Parameters.Add("@astroSistema", SqlDbType.VarChar, 20).Value = A.astroSystem
        CMD.Parameters.Add("@astroGalaxia", SqlDbType.VarChar, 20).Value = A.astroGalaxy
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to add Astro. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub UpdateAstro(ByVal A As Astro)
        CMD.CommandText = "MORSA.pr_updAstro"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()

        CMD.Parameters.Add("@astroID", SqlDbType.VarChar, 11).Value = A.astroID
        CMD.Parameters.Add("@astroTipo", SqlDbType.VarChar, 20).Value = A.astroType
        CMD.Parameters.Add("@astroSistema", SqlDbType.VarChar, 20).Value = A.astroSystem
        CMD.Parameters.Add("@astroGalaxia", SqlDbType.VarChar, 20).Value = A.astroGalaxy
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update Astro. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub RemoveAstro(ByVal astroID As String)
        CMD.CommandText = "MORSA.pr_delAstro"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@astroID", astroID)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete Astro. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Function SaveAstro() As Boolean
        Dim A As New Astro
        Try
            A.astroID = txtAstroID.Text
            A.astroType = txtAstroType.Text
            A.astroSystem = txtAstroSystem.Text
            A.astroGalaxy = txtAstroGalaxy.Text

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        If adding Then
            SubmitAstro(A)
            astroList.Items.Add(A)
        Else
            UpdateAstro(A)
            astroList.Items(current) = A
        End If
        Return True
    End Function

    Private Sub bttnAstroPesq_Click(sender As Object, e As EventArgs) Handles bttnAstroPesq.Click
        CMD.Parameters.Clear() 'Clear dos parametros'
        CMD.CommandText = "MORSA.pr_searchAstro"   'nome da SP'
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Add("@astroID", SqlDbType.VarChar, 11).Value = txtAstroPesq.Text 'parametro de entrada'
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader()
        astroList.Items.Clear()
        While RDR.Read
            Dim C As New Astro
            C.astroID = RDR.Item("id") 'nome da variavel na classe = nome das colunas originais
            C.astroType = RDR.Item("tipo")
            C.astroSystem = RDR.Item("sistema")
            C.astroGalaxy = RDR.Item("galaxia")
            astroList.Items.Add(C)
        End While
        CN.Close()
        current = 0
        ShowAstro()
    End Sub

    'TAB COMP
    Private Sub bttnCompAdd_Click(sender As Object, e As EventArgs) Handles bttnCompAdd.Click
        adding = True
        HideButtons()
        ClearFields()
        companhiaList.Enabled = False
    End Sub

    Private Sub bttnCompEdit_Click(sender As Object, e As EventArgs) Handles bttnCompEdit.Click
        current = companhiaList.SelectedIndex
        If current < 0 Then
            MsgBox("Please select a Company to edit")
            Exit Sub
        End If
        adding = False
        HideButtons()
        txtCompNIF.ReadOnly = True
    End Sub

    Private Sub bttnCompDel_Click(sender As Object, e As EventArgs) Handles bttnCompDel.Click
        If companhiaList.SelectedIndex > -1 Then
            Try
                RemoveCompanhia(CType(companhiaList.SelectedItem, Companhia).companhiaNIF)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            companhiaList.Items.RemoveAt(companhiaList.SelectedIndex)
            If current = companhiaList.Items.Count Then current = companhiaList.Items.Count - 1
            If current = -1 Then
                ClearFields()
                MsgBox("There are no more Companies")
            Else
                showCompanhia()
            End If
        End If
    End Sub

    Private Sub bttnCompOK_Click(sender As Object, e As EventArgs) Handles bttnCompOK.Click
        Try
            SaveCompanhia()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        companhiaList.Enabled = True
        Dim idx As Integer = companhiaList.FindString(txtCompNIF.Text)
        companhiaList.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub bttnCompCan_Click(sender As Object, e As EventArgs) Handles bttnCompCan.Click
        companhiaList.Enabled = True
        If companhiaList.Items.Count > 0 Then
            current = companhiaList.SelectedIndex
            If current < 0 Then current = 0
            showCompanhia()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Private Sub SubmitCompanhia(ByVal C As Companhia)
        CMD.CommandText = "MORSA.pr_addCompanhia"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@compNome", SqlDbType.VarChar, 35).Value = C.companhiaNome
        CMD.Parameters.Add("@compNIF", SqlDbType.Char, 9).Value = C.companhiaNIF
        CMD.Parameters.Add("@compTelef", SqlDbType.Char, 9).Value = C.companhiaTelef
        CMD.Parameters.Add("@compEnder", SqlDbType.VarChar, 40).Value = C.companhiaEnder
        CMD.Parameters.Add("@CompCodPos", SqlDbType.Char, 8).Value = C.companhiaCodPos
        CMD.Parameters.Add("@compSede", SqlDbType.VarChar, 20).Value = C.companhiaSede
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to add Company. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub UpdateCompanhia(ByVal C As Companhia)
        CMD.CommandText = "MORSA.pr_updCompanhia"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@compNome", SqlDbType.VarChar, 35).Value = C.companhiaNome
        CMD.Parameters.Add("@compNIF", SqlDbType.Char, 9).Value = C.companhiaNIF
        CMD.Parameters.Add("@compTelef", SqlDbType.Char, 9).Value = C.companhiaTelef
        CMD.Parameters.Add("@compEnder", SqlDbType.VarChar, 40).Value = C.companhiaEnder
        CMD.Parameters.Add("@compCodPos", SqlDbType.Char, 8).Value = C.companhiaCodPos
        CMD.Parameters.Add("@compSede", SqlDbType.VarChar, 20).Value = C.companhiaSede
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update Company. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub RemoveCompanhia(ByVal companhiaNIF As String)
        CMD.CommandText = "MORSA.pr_delCompanhia"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@CompNIF", companhiaNIF)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete Company. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Function SaveCompanhia() As Boolean
        Dim C As New Companhia
        Try
            C.companhiaNome = txtCompName.Text
            C.companhiaNIF = txtCompNIF.Text
            C.companhiaTelef = txtCompTelef.Text
            C.companhiaEnder = txtCompEnder.Text
            C.companhiaCodPos = txtCompCodPos.Text
            C.companhiaSede = txtCompSede.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        If adding Then
            SubmitCompanhia(C)
            companhiaList.Items.Add(C)
        Else
            UpdateCompanhia(C)
            companhiaList.Items(current) = C
        End If
        Return True
    End Function

    Private Sub bttnCompPesq_Click(sender As Object, e As EventArgs) Handles bttnCompPesq.Click
        CMD.Parameters.Clear() 'Clear dos parametros'
        CMD.CommandText = "MORSA.pr_searchCompanhia"   'nome da SP'
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        If comboBoxComp.SelectedItem.Equals("Nome") Then
            CMD.Parameters.Add("@compNome", SqlDbType.VarChar, 35).Value = txtCompPesq.Text 'parametro de entrada'
            CMD.Parameters.Add("@compNIF", SqlDbType.VarChar, 9).Value = DBNull.Value
        Else
            CMD.Parameters.Add("@compNome", SqlDbType.VarChar, 35).Value = DBNull.Value 'parametro de entrada'
            CMD.Parameters.Add("@compNIF", SqlDbType.VarChar, 9).Value = txtCompPesq.Text
        End If
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        companhiaList.Items.Clear()
        While RDR.Read
            Dim C As New Companhia
            C.companhiaNome = RDR.Item("nome") 'nome da variavel na classe = nome das colunas originais
            C.companhiaNIF = RDR.Item("nif")
            C.companhiaTelef = RDR.Item("telef")
            C.companhiaEnder = RDR.Item("Ender")
            C.companhiaCodPos = RDR.Item("codPos")
            C.companhiaSede = RDR.Item("sede")
            companhiaList.Items.Add(C)
        End While
        CN.Close()
        current = 0
        showCompanhia()
    End Sub

    ' TAB SAT
    Private Sub bttnSatAdd_Click(sender As Object, e As EventArgs) Handles bttnSatAdd.Click
        adding = True
        HideButtons()
        ClearFields()
        sateliteList.Enabled = False
    End Sub

    Private Sub bttnSatEdit_Click(sender As Object, e As EventArgs) Handles bttnSatEdit.Click
        current = sateliteList.SelectedIndex
        If current < 0 Then
            MsgBox("Please select a Satelite to edit")
            Exit Sub
        End If
        adding = False
        HideButtons()
        txtSatID.ReadOnly = True
        txtSatOrbAp.Visible = False
        txtSatOrbPeria.Visible = False
        txtSatOrbInc.Visible = False
        txtSatOrbPerio.Visible = False
        txtSatOrbAstro.Visible = False
        lblSatOrb.Visible = False
        lblSatOrbAp.Visible = False
        lblSatOrbPeria.Visible = False
        lblSatOrbInc.Visible = False
        lblSatOrbPerio.Visible = False
        lblSatOrbAstro.Visible = False
    End Sub

    Private Sub bttnSatDel_Click(sender As Object, e As EventArgs) Handles bttnSatDel.Click
        If sateliteList.SelectedIndex > -1 Then
            Try
                RemoveSatelite(CType(sateliteList.SelectedItem, Satelite).satID)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            sateliteList.Items.RemoveAt(sateliteList.SelectedIndex)
            If current = sateliteList.Items.Count Then current = sateliteList.Items.Count - 1
            If current = -1 Then
                ClearFields()
                MsgBox("There are no more Satelites")
            Else
                showSat()
            End If
        End If
    End Sub

    Private Sub bttnSatOK_Click(sender As Object, e As EventArgs) Handles bttnSatOK.Click
        If adding Then
            Try
                SaveSatelite()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                SaveUSat()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        sateliteList.Enabled = True
        Dim idx As Integer = sateliteList.FindString(txtAstroID.Text)
        sateliteList.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub bttnSatCan_Click(sender As Object, e As EventArgs) Handles bttnSatCan.Click
        sateliteList.Enabled = True
        If sateliteList.Items.Count > 0 Then
            current = sateliteList.SelectedIndex
            If current < 0 Then current = 0
            showSat()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Private Sub bttnSatPesq_Click(sender As Object, e As EventArgs) Handles bttnSatPesq.Click
        CMD.Parameters.Clear() 'Clear dos parametros'
        CMD.CommandText = "MORSA.pr_searchSatelite"   'nome da SP'
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        If comboBoxSat.SelectedItem.Equals("Nome") Then
            CMD.Parameters.Add("@satNome", SqlDbType.VarChar, 35).Value = txtSatPesq.Text 'parametro de entrada'
            CMD.Parameters.Add("@satID", SqlDbType.VarChar, 11).Value = DBNull.Value
        Else
            CMD.Parameters.Add("@satNome", SqlDbType.VarChar, 35).Value = DBNull.Value 'parametro de entrada'
            CMD.Parameters.Add("@satID", SqlDbType.VarChar, 11).Value = txtSatPesq.Text
        End If
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        sateliteList.Items.Clear()
        While RDR.Read
            Dim C As New Satelite
            C.satID = RDR.Item("id") 'nome da variavel na classe = nome das colunas originais
            C.satNome = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("nome")), "", RDR.Item("nome")))
            C.satServ = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("servico")), "", RDR.Item("servico")))
            C.satPaisOrg = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("paisOrgan")), "", RDR.Item("paisOrgan")))
            C.satCompLog = RDR.Item("compLog")
            C.satLanc = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("lancam")), "", RDR.Item("lancam")))
            C.satStatus = RDR.Item("status")
            sateliteList.Items.Add(C)
        End While
        CN.Close()
        current = 0
        showSat()
    End Sub

    Private Function SaveSatelite() As Boolean
        Dim S As New Satelite
        Dim O As New Orbita
        Dim comp As String
        Try
            S.satID = txtSatID.Text
            S.satNome = txtSatNome.Text
            S.satServ = txtSatServico.Text
            S.satPaisOrg = txtSatPaisOrg.Text
            S.satCompLog = txtSatCompLog.Text
            S.satStatus = txtSatStatus.Text
            S.satLanc = txtSatLanc.Text
            comp = txtSatComp.Text

            O.orbitaID = txtSatID.Text
            O.orbitaApoastro = txtSatOrbAp.Text
            O.orbitaPeriastro = txtSatOrbPeria.Text
            O.orbitaInclin = txtSatOrbInc.Text
            O.orbitaPeriodo = txtSatOrbPerio.Text
            O.orbitaAstro = txtSatOrbAstro.Text

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        SubmitSatelite(S, O, comp)
        sateliteList.Items.Add(S)
        Return True
    End Function

    Private Function SaveUSat() As Boolean
        Dim S As New Satelite
        Try
            S.satID = txtSatID.Text
            S.satNome = txtSatNome.Text
            S.satServ = txtSatServico.Text
            S.satPaisOrg = txtSatPaisOrg.Text
            S.satCompLog = txtSatCompLog.Text
            S.satStatus = txtSatStatus.Text
            S.satLanc = txtSatLanc.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        UpdateSatelite(S)
        sateliteList.Items(current) = S
        Return True
    End Function

    Private Sub SubmitSatelite(ByVal S As Satelite, ByVal O As Orbita, ByVal C As String)
        CMD.CommandText = "MORSA.pr_addSatelite"
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@satID", S.satID)
        CMD.Parameters.AddWithValue("@satName", S.satNome)
        CMD.Parameters.AddWithValue("@satService", S.satServ)
        CMD.Parameters.AddWithValue("@paisOrgan", S.satPaisOrg)
        CMD.Parameters.AddWithValue("@compLog", S.satCompLog)
        If (S.satLanc.Equals("")) Then
            CMD.Parameters.AddWithValue("@lancam", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@lancam", S.satLanc)
        End If
        CMD.Parameters.AddWithValue("@compMae", C)
        CMD.Parameters.AddWithValue("@apoastro", O.orbitaApoastro)
        CMD.Parameters.AddWithValue("@periastro", O.orbitaPeriastro)
        CMD.Parameters.AddWithValue("@inclin", O.orbitaInclin)
        CMD.Parameters.AddWithValue("@periodo", O.orbitaPeriodo)
        CMD.Parameters.AddWithValue("@astro", O.orbitaAstro)
        CMD.Parameters.AddWithValue("@satStatus", S.satStatus)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to add Satelite. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub RemoveSatelite(ByVal satID As String)
        CMD.CommandText = "MORSA.pr_delSatelite"
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@satID", satID)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete Satelite. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub UpdateSatelite(ByVal S As Satelite)
        CMD.CommandText = "MORSA.pr_updSatelite"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.Add("@satID", SqlDbType.VarChar, 11).Value = S.satID
        CMD.Parameters.Add("@satName", SqlDbType.VarChar, 35).Value = S.satNome
        CMD.Parameters.Add("@satService", SqlDbType.VarChar, 20).Value = S.satServ
        CMD.Parameters.Add("@paisOrgan", SqlDbType.VarChar, 20).Value = S.satPaisOrg
        CMD.Parameters.Add("@compLog", SqlDbType.Char, 9).Value = S.satCompLog
        If (S.satLanc.Equals("")) Then
            CMD.Parameters.AddWithValue("@lancam", DBNull.Value)
        Else
            CMD.Parameters.Add("@lancam", SqlDbType.VarChar, 11).Value = S.satLanc
        End If
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update Satelite. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    ' TAB EE
    Private Sub bttnEEAdd_Click(sender As Object, e As EventArgs) Handles bttnEEAdd.Click
        adding = True
        HideButtons()
        ClearFields()
        eeList.Enabled = False
    End Sub

    Private Sub bttnEEEdit_Click(sender As Object, e As EventArgs) Handles bttnEEEdit.Click
        current = eeList.SelectedIndex
        If current < 0 Then
            MsgBox("Please select a Space Station to edit")
            Exit Sub
        End If
        adding = False
        HideButtons()
        txtEEID.ReadOnly = True
        txtEEOrbAp.Visible = False
        txtEEOrbPeria.Visible = False
        txtEEOrbInc.Visible = False
        txtEEOrbPerio.Visible = False
        txtEEOrbAstro.Visible = False
        lblEEOrb.Visible = False
        lblEEOrbAp.Visible = False
        lblEEOrbPeria.Visible = False
        lblEEOrbInc.Visible = False
        lblEEOrbPerio.Visible = False
        lblEEOrbAstro.Visible = False
    End Sub

    Private Sub bttnEEDel_Click(sender As Object, e As EventArgs) Handles bttnEEDel.Click
        If eeList.SelectedIndex > -1 Then
            Try
                RemoveEE(CType(eeList.SelectedItem, EstacaoEspacial).estEspID)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            eeList.Items.RemoveAt(eeList.SelectedIndex)
            If current = eeList.Items.Count Then current = eeList.Items.Count - 1
            If current = -1 Then
                ClearFields()
                MsgBox("There are no more Space Stations")
            Else
                showEE()
            End If
        End If
    End Sub

    Private Sub bttnEEOK_Click(sender As Object, e As EventArgs) Handles bttnEEOK.Click
        If adding Then
            Try
                SaveEE()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                SaveUEE()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        eeList.Enabled = True
        Dim idx As Integer = eeList.FindString(txtEEID.Text)
        eeList.SelectedIndex = idx
        ShowButtons()
    End Sub


    Private Sub bttnEECan_Click(sender As Object, e As EventArgs) Handles bttnEECan.Click
        eeList.Enabled = True
        If eeList.Items.Count > 0 Then
            current = eeList.SelectedIndex
            If current < 0 Then current = 0
            showEE()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Private Function SaveEE() As Boolean
        Dim E As New EstacaoEspacial
        Dim O As New Orbita
        Dim comp As String
        Try
            E.estEspID = txtEEID.Text
            E.estEspNome = txtEENome.Text
            E.estEspPaisOrg = txtEEPaisOrg.Text
            E.estEspCompLog = txtEECompLog.Text
            E.estStatus = txtEEStatus.Text
            comp = txtCMEE.Text

            O.orbitaID = txtEEID.Text
            O.orbitaApoastro = txtEEOrbAp.Text
            O.orbitaPeriastro = txtEEOrbPeria.Text
            O.orbitaInclin = txtEEOrbInc.Text
            O.orbitaPeriodo = txtEEOrbPerio.Text
            O.orbitaAstro = txtEEOrbAstro.Text

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        SubmitEE(E, O, comp)
        eeList.Items.Add(E)
        Return True
    End Function

    Private Function SaveUEE() As Boolean
        Dim E As New EstacaoEspacial
        Try
            E.estEspID = txtEEID.Text
            E.estEspNome = txtEENome.Text
            E.estEspPaisOrg = txtEEPaisOrg.Text
            E.estEspCompLog = txtEECompLog.Text
            E.estStatus = txtEEStatus.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        UpdateEE(E)
        eeList.Items(current) = E
        Return True
    End Function

    Private Sub SubmitEE(ByVal E As EstacaoEspacial, ByVal O As Orbita, ByVal C As String)
        CMD.CommandText = "MORSA.pr_addEE"
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@eeID", E.estEspID)
        If (E.estEspNome.Equals("")) Then
            CMD.Parameters.AddWithValue("@eeName", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@eeName", E.estEspNome)
        End If
        If (E.estEspPaisOrg.Equals("")) Then
            CMD.Parameters.AddWithValue("@paisOrg", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@paisOrg", E.estEspPaisOrg)
        End If
        CMD.Parameters.AddWithValue("@compLog", E.estEspCompLog)

        CMD.Parameters.AddWithValue("@compMae", C)
        CMD.Parameters.AddWithValue("@apoastro", O.orbitaApoastro)
        CMD.Parameters.AddWithValue("@periastro", O.orbitaPeriastro)
        CMD.Parameters.AddWithValue("@inclin", O.orbitaInclin)
        CMD.Parameters.AddWithValue("@periodo", O.orbitaPeriodo)
        CMD.Parameters.AddWithValue("@astro", O.orbitaAstro)
        CMD.Parameters.AddWithValue("@status", E.estStatus)

        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to add Space Station. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub RemoveEE(ByVal eeID As String)
        CMD.CommandText = "MORSA.pr_delEE"
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@eeID", eeID)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete Space Station. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub UpdateEE(ByVal E As EstacaoEspacial)
        CMD.CommandText = "MORSA.pr_updEE"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@eeID", E.estEspID)
        If (E.estEspNome.Equals("")) Then
            CMD.Parameters.AddWithValue("@eeName", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@eeName", E.estEspNome)
        End If
        If (E.estEspPaisOrg.Equals("")) Then
            CMD.Parameters.AddWithValue("@paisOrg", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@paisOrg", E.estEspPaisOrg)
        End If
        CMD.Parameters.AddWithValue("@compLog", E.estEspCompLog)
        CMD.Parameters.AddWithValue("@status", E.estStatus)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update Space Station. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub bttnEEPesq_Click(sender As Object, e As EventArgs) Handles bttnEEPesq.Click
        CMD.Parameters.Clear() 'Clear dos parametros'
        CMD.CommandText = "MORSA.pr_searchEstacaoEspac"   'nome da SP'
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        If comboBoxEE.SelectedItem.Equals("Nome") Then
            CMD.Parameters.Add("@eeNome", SqlDbType.VarChar, 35).Value = txtEEPesq.Text 'parametro de entrada'
            CMD.Parameters.Add("@eeID", SqlDbType.VarChar, 11).Value = DBNull.Value
        Else
            CMD.Parameters.Add("@eeNome", SqlDbType.VarChar, 35).Value = DBNull.Value 'parametro de entrada'
            CMD.Parameters.Add("@eeID", SqlDbType.VarChar, 11).Value = txtEEPesq.Text
        End If
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        eeList.Items.Clear()
        While RDR.Read
            Dim C As New EstacaoEspacial
            C.estEspID = RDR.Item("id") 'nome da variavel na classe = nome das colunas originais
            C.estEspNome = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("nome")), "", RDR.Item("nome")))
            C.estEspPaisOrg = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("paisOrgan")), "", RDR.Item("paisOrgan")))
            C.estEspCompLog = RDR.Item("compLog")
            C.estStatus = RDR.Item("status")
            eeList.Items.Add(C)
        End While
        CN.Close()
        current = 0
        showEE()
    End Sub

    ' TAB MODULE EE
    Private Sub bttnMEEAdd_Click(sender As Object, e As EventArgs) Handles bttnMEEAdd.Click
        adding = True
        HideButtons()
        ClearFields()
        meeList.Enabled = False
    End Sub

    Private Sub bttnMEEEdit_Click(sender As Object, e As EventArgs) Handles bttnMEEEdit.Click
        current = meeList.SelectedIndex
        If current < 0 Then
            MsgBox("Please select a Module to edit")
            Exit Sub
        End If
        adding = False
        HideButtons()
        txtMeeID.ReadOnly = True
    End Sub

    Private Sub bttnMEEDel_Click(sender As Object, e As EventArgs) Handles bttnMEEDel.Click
        If meeList.SelectedIndex > -1 Then
            Try
                RemoveMEE(CType(meeList.SelectedItem, ModuloEE).moduloID)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            meeList.Items.RemoveAt(meeList.SelectedIndex)
            If current = meeList.Items.Count Then current = meeList.Items.Count - 1
            If current = -1 Then
                ClearFields()
                MsgBox("There are no more Modules")
            Else
                showMee()
            End If
        End If
    End Sub

    Private Sub bttnMEEOK_Click(sender As Object, e As EventArgs) Handles bttnMEEOK.Click
        Try
            SaveMEE()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        meeList.Enabled = True
        Dim idx As Integer = meeList.FindString(txtMeeID.Text)
        meeList.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub bttnMEECan_Click(sender As Object, e As EventArgs) Handles bttnMEECan.Click
        meeList.Enabled = True
        If meeList.Items.Count > 0 Then
            current = meeList.SelectedIndex
            If current < 0 Then current = 0
            showMee()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Private Sub SubmitMEE(ByVal M As ModuloEE)
        CMD.CommandText = "MORSA.pr_addMEE"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@meeID", M.moduloID)
        If M.moduloNome = "" Then
            CMD.Parameters.AddWithValue("@meeNome", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@meeNome", M.moduloNome)
        End If
        If M.moduloTipo = "" Then
            CMD.Parameters.AddWithValue("@meeTipo", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@meeTipo", M.moduloTipo)
        End If
        CMD.Parameters.AddWithValue("@meeCompLog", M.moduloCompLog)
        If M.moduloLanc = "" Then
            CMD.Parameters.AddWithValue("@meeLanc", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@meeLanc", M.moduloLanc)
        End If
        CMD.Parameters.AddWithValue("@meeEE", M.moduloEE)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to add Module. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub UpdateMEE(ByVal M As ModuloEE)
        CMD.CommandText = "MORSA.pr_updMEE"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@meeID", M.moduloID)
        If M.moduloNome = "" Then
            CMD.Parameters.AddWithValue("@meeNome", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@meeNome", M.moduloNome)
        End If
        If M.moduloTipo = "" Then
            CMD.Parameters.AddWithValue("@meeTipo", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@meeTipo", M.moduloTipo)
        End If
        CMD.Parameters.AddWithValue("@meeCompLog", M.moduloCompLog)
        If M.moduloLanc = "" Then
            CMD.Parameters.AddWithValue("@meeLanc", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@meeLanc", M.moduloLanc)
        End If
        CMD.Parameters.AddWithValue("@meeEE", M.moduloEE)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update Module. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub RemoveMEE(ByVal moduloID As String)
        CMD.CommandText = "MORSA.pr_delMEE"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@meeID", moduloID)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete Module. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Function SaveMEE() As Boolean
        Dim M As New ModuloEE
        Try
            M.moduloID = txtMeeID.Text
            M.moduloNome = txtMeeNome.Text
            M.moduloTipo = txtMeeTipo.Text
            M.moduloCompLog = txtMeeCompLog.Text
            M.moduloLanc = txtMeeLanc.Text
            M.moduloEE = txtMeeEE.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        If adding Then
            SubmitMEE(M)
            meeList.Items.Add(M)
        Else
            UpdateMEE(M)
            meeList.Items(current) = M
        End If
        Return True
    End Function

    Private Sub bttnMeePesq_Click(sender As Object, e As EventArgs) Handles bttnMeePesq.Click
        CMD.Parameters.Clear() 'Clear dos parametros'
        CMD.CommandText = "MORSA.pr_searchModuloEE"   'nome da SP'
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        If comboBoxMee.SelectedItem.Equals("Nome") Then
            CMD.Parameters.Add("@mEENome", SqlDbType.VarChar, 35).Value = txtMeePesq.Text 'parametro de entrada'
            CMD.Parameters.Add("@mEEID", SqlDbType.VarChar, 11).Value = DBNull.Value
        Else
            CMD.Parameters.Add("@mEENome", SqlDbType.VarChar, 35).Value = DBNull.Value 'parametro de entrada'
            CMD.Parameters.Add("@mEEID", SqlDbType.VarChar, 11).Value = txtMeePesq.Text
        End If
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        meeList.Items.Clear()
        While RDR.Read
            Dim C As New ModuloEE
            C.moduloID = RDR.Item("id") 'nome da variavel na classe = nome das colunas originais
            C.moduloNome = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("nome")), "", RDR.Item("nome")))
            C.moduloTipo = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("tipo")), "", RDR.Item("tipo")))
            C.moduloCompLog = RDR.Item("compLog")
            C.moduloLanc = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("lancam")), "", RDR.Item("lancam")))
            C.moduloEE = RDR.Item("estacaoEspac")
            meeList.Items.Add(C)
        End While
        CN.Close()
        current = 0
        showMee()
    End Sub

    ' TAB ORBITA
    Private Sub bttnOrbEdit_Click(sender As Object, e As EventArgs) Handles bttnOrbEdit.Click
        current = orbList.SelectedIndex
        If current < 0 Then
            MsgBox("Please select a Orbit to edit")
            Exit Sub
        End If
        HideButtons()
        txtOrbID.ReadOnly = True
    End Sub

    Private Sub bttnOrbDel_Click(sender As Object, e As EventArgs) Handles bttnOrbDel.Click
        If orbList.SelectedIndex > -1 Then
            Try
                RemoveOrbita(CType(orbList.SelectedItem, Orbita).orbitaID)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            orbList.Items.RemoveAt(orbList.SelectedIndex)
            If current = orbList.Items.Count Then current = orbList.Items.Count - 1
            If current = -1 Then
                ClearFields()
                MsgBox("There are no more Orbits")
            Else
                ShowOrbita()
            End If
        End If
    End Sub

    Private Sub bttnOrbOK_Click(sender As Object, e As EventArgs) Handles bttnOrbOK.Click
        Try
            SaveOrbita()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        orbList.Enabled = True
        Dim idx As Integer = orbList.FindString(txtOrbID.Text)
        orbList.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub bttnOrbCan_Click(sender As Object, e As EventArgs) Handles bttnOrbCan.Click
        orbList.Enabled = True
        If orbList.Items.Count > 0 Then
            current = orbList.SelectedIndex
            If current < 0 Then current = 0
            ShowOrbita()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Private Sub UpdateOrbita(ByVal O As Orbita)
        CMD.CommandText = "MORSA.pr_updOrbita"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@orbitaID", O.orbitaID)
        CMD.Parameters.AddWithValue("@orbitaApo", O.orbitaApoastro)
        CMD.Parameters.AddWithValue("@orbitaPer", O.orbitaPeriastro)
        CMD.Parameters.AddWithValue("@orbitaInclin", O.orbitaInclin)
        CMD.Parameters.AddWithValue("@orbitaPeriodo", O.orbitaPeriodo)
        CMD.Parameters.AddWithValue("@orbitaAstro", O.orbitaAstro)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update Orbita. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub RemoveOrbita(ByVal orbitaID As String)
        CMD.CommandText = "MORSA.pr_delOrbita"
        CMD.CommandType = CommandType.StoredProcedure
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@orbID", orbitaID)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete Orbit. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Function SaveOrbita() As Boolean
        Dim O As New Orbita
        Try
            O.orbitaID = txtOrbID.Text
            O.orbitaApoastro = txtOrbAp.Text
            O.orbitaPeriastro = txtOrbPe.Text
            O.orbitaInclin = txtOrbIn.Text
            O.orbitaPeriodo = txtOrbPer.Text
            O.orbitaAstro = txtOrbAstro.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        UpdateOrbita(O)
        orbList.Items(current) = O
        Return True
    End Function

    Private Sub bttnOrbPesq_Click(sender As Object, e As EventArgs) Handles bttnOrbPesq.Click
        CMD.Parameters.Clear() 'Clear dos parametros'
        CMD.CommandText = "MORSA.pr_searchOrbita"   'nome da SP'
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Add("@orbID", SqlDbType.VarChar, 11).Value = txtOrbPesq.Text 'parametro de entrada'
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        orbList.Items.Clear()
        While RDR.Read
            Dim C As New Orbita
            C.orbitaID = RDR.Item("id") 'nome da variavel na classe = nome das colunas originais
            C.orbitaApoastro = RDR.Item("apoastro")
            C.orbitaPeriastro = RDR.Item("periastro")
            C.orbitaInclin = RDR.Item("inclin")
            C.orbitaPeriodo = RDR.Item("periodo")
            C.orbitaAstro = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("astro")), "", RDR.Item("astro")))
            orbList.Items.Add(C)
        End While
        CN.Close()
        current = 0
        ShowOrbita()
    End Sub

    ' TAB LANCAMENTO
    Private Sub bttnLanAdd_Click(sender As Object, e As EventArgs) Handles bttnLanAdd.Click
        adding = True
        HideButtons()
        ClearFields()
        lancList.Enabled = False
    End Sub

    Private Sub bttnLanEdit_Click(sender As Object, e As EventArgs) Handles bttnLanEdit.Click
        adding = False
        current = lancList.SelectedIndex
        If current < 0 Then
            MsgBox("Please select a Launch to edit")
            Exit Sub
        End If
        HideButtons()
        txtLancID.ReadOnly = True
    End Sub

    Private Sub bttnLanDel_Click(sender As Object, e As EventArgs) Handles bttnLanDel.Click
        If lancList.SelectedIndex > -1 Then
            Try
                RemoveLanc(CType(lancList.SelectedItem, Lanc).lancID)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            lancList.Items.RemoveAt(lancList.SelectedIndex)
            If current = lancList.Items.Count Then current = lancList.Items.Count - 1
            If current = -1 Then
                ClearFields()
                MsgBox("There are no more Launchs")
            Else
                ShowLanc()
            End If
        End If
    End Sub

    Private Sub bttnLanOK_Click(sender As Object, e As EventArgs) Handles bttnLanOK.Click
        Try
            SaveLanc()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lancList.Enabled = True
        Dim idx As Integer = lancList.FindString(txtLancID.Text)
        lancList.SelectedIndex = idx
        ShowButtons()
    End Sub

    Private Sub bttnLanCan_Click(sender As Object, e As EventArgs) Handles bttnLanCan.Click
        lancList.Enabled = True
        If lancList.Items.Count > 0 Then
            current = lancList.SelectedIndex
            If current < 0 Then current = 0
            ShowLanc()
        Else
            ClearFields()
            LockControls()
        End If
        ShowButtons()
    End Sub

    Private Sub SubmitLanc(ByVal L As Lanc)
        CMD.CommandText = "MORSA.pr_addLanc"
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@lancID", L.lancID)
        CMD.Parameters.AddWithValue("@lancCoord", L.lancCoord)
        If (L.lancPais.Equals("")) Then
            CMD.Parameters.AddWithValue("@lancPais", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@lancPais", L.lancPais)
        End If
        CMD.Parameters.AddWithValue("@lancDT", L.lancDT)
        If (L.lancVeicN.Equals("")) Then
            CMD.Parameters.AddWithValue("@veicName", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@veicName", L.lancVeicN)
        End If
        CMD.Parameters.AddWithValue("@veicCompLog", L.lancVeicCL)
        CMD.Parameters.AddWithValue("@objID", L.lancObj)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to add Launch. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub UpdateLanc(ByVal L As Lanc)
        CMD.CommandText = "MORSA.pr_updLanc"
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@lancID", L.lancID)
        CMD.Parameters.AddWithValue("@lancCoord", L.lancCoord)
        If (L.lancPais.Equals("")) Then
            CMD.Parameters.AddWithValue("@lancPais", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@lancPais", L.lancPais)
        End If
        CMD.Parameters.AddWithValue("@lancDT", L.lancDT)
        If (L.lancVeicN.Equals("")) Then
            CMD.Parameters.AddWithValue("@veicName", DBNull.Value)
        Else
            CMD.Parameters.AddWithValue("@veicName", L.lancVeicN)
        End If
        CMD.Parameters.AddWithValue("@veicCompLog", L.lancVeicCL)
        CMD.Parameters.AddWithValue("@objID", L.lancObj)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to update Launch. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Sub RemoveLanc(ByVal lancID As String)
        CMD.CommandText = "MORSA.pr_delLanc"
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Clear()
        CMD.Parameters.AddWithValue("@lancID", lancID)
        CN.Open()
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception("Failed to delete Launch. " & vbCrLf & "ERROR MESSAGE: " & vbCrLf & ex.Message)
        Finally
            CN.Close()
        End Try
    End Sub

    Private Function SaveLanc() As Boolean
        Dim L As New Lanc
        Try
            L.lancID = txtLancID.Text
            L.lancCoord = txtLancCoord.Text
            L.lancPais = txtLancPais.Text
            L.lancDT = txtLancDT.Text
            L.lancVeicN = txtLancVeicN.Text
            L.lancVeicCL = txtLancVeicCL.Text
            L.lancObj = txtLancObj.Text
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        If adding Then
            SubmitLanc(L)
            lancList.Items.Add(L)
        Else
            UpdateLanc(L)
            lancList.Items(current) = L
        End If
        Return True
    End Function

    Private Sub bttnLancPesq_Click(sender As Object, e As EventArgs) Handles bttnLancPesq.Click
        CMD.Parameters.Clear() 'Clear dos parametros'
        CMD.CommandText = "MORSA.pr_searchLancamento"   'nome da SP'
        CMD.CommandType = CommandType.StoredProcedure  'tipo do comando'
        CMD.Parameters.Add("@lancID", SqlDbType.VarChar, 11).Value = txtLancPesq.Text 'parametro de entrada'
        CN.Open()
        Dim RDR As SqlDataReader
        RDR = CMD.ExecuteReader
        lancList.Items.Clear()
        While RDR.Read
            Dim C As New Lanc
            C.lancID = RDR.Item("id") 'nome da variavel na classe = nome das colunas originais
            C.lancCoord = RDR.Item("coord")
            C.lancPais = Convert.ToString(IIf(RDR.IsDBNull(RDR.GetOrdinal("pais")), "", RDR.Item("pais")))
            C.lancDT = RDR.Item("dataTempo")
            C.lancVeicN = RDR.Item("nome")
            C.lancVeicCL = RDR.Item("compLog")
            lancList.Items.Add(C)
        End While
        CN.Close()
        current = 0
        ShowLanc()
    End Sub

    Sub ClearFields()
        If TabControl1.SelectedTab Is tabAstro Then 'TAB Astro selecionada
            txtAstroID.Text = ""
            txtAstroType.Text = ""
            txtAstroSystem.Text = ""
            txtAstroGalaxy.Text = ""
        ElseIf TabControl1.SelectedTab Is tabCompanhia Then 'TAB Companhia selecionada
            txtCompName.Text = ""
            txtCompNIF.Text = ""
            txtCompTelef.Text = ""
            txtCompEnder.Text = ""
            txtCompCodPos.Text = ""
            txtCompSede.Text = ""
        ElseIf TabControl1.SelectedTab Is tabSatelite Then 'TAB Satelite selecionada
            txtSatID.Text = ""
            txtSatNome.Text = ""
            txtSatServico.Text = ""
            txtSatPaisOrg.Text = ""
            txtSatCompLog.Text = ""
            txtSatLanc.Text = ""
            txtSatStatus.Text = ""
            txtSatComp.Text = ""
            txtSatOrbAp.Text = ""
            txtSatOrbPeria.Text = ""
            txtSatOrbInc.Text = ""
            txtSatOrbPerio.Text = ""
            txtSatOrbAstro.Text = ""
        ElseIf TabControl1.SelectedTab Is tabEE Then 'TAB EE selecionada
            txtEEID.Text = ""
            txtEENome.Text = ""
            txtEEPaisOrg.Text = ""
            txtEECompLog.Text = ""
            txtEEStatus.Text = ""
            txtEEOrbAp.Text = ""
            txtEEOrbPeria.Text = ""
            txtEEOrbInc.Text = ""
            txtEEOrbPerio.Text = ""
            txtEEOrbAstro.Text = ""
            txtCMEE.Text = ""
        ElseIf TabControl1.SelectedTab Is tabMee Then 'TAB Mee selecionada
            txtMeeID.Text = ""
            txtMeeNome.Text = ""
            txtMeeTipo.Text = ""
            txtMeeCompLog.Text = ""
            txtMeeLanc.Text = ""
            txtMeeEE.Text = ""
        ElseIf TabControl1.SelectedTab Is tabOrbita Then 'TAB Orbita selecionada
            txtOrbID.Text = ""
            txtOrbAp.Text = ""
            txtOrbPe.Text = ""
            txtOrbIn.Text = ""
            txtOrbPer.Text = ""
            txtOrbAstro.Text = ""
        ElseIf TabControl1.SelectedTab Is tabLanc Then 'TAB Lançamento selecionada
            txtLancID.Text = ""
            txtLancCoord.Text = ""
            txtLancPais.Text = ""
            txtLancDT.Text = ""
            txtLancVeicN.Text = ""
            txtLancVeicCL.Text = ""
            txtLancObj.Text = ""
        End If
    End Sub

    Sub HideButtons()
        UnlockControls()
        If TabControl1.SelectedTab Is tabAstro Then 'TAB Astro selecionada
            bttnAstroAdd.Visible = False
            bttnAstroEdit.Visible = False
            bttnAstroDel.Visible = False
            bttnAstroOK.Visible = True
            bttnAstroCan.Visible = True
        ElseIf TabControl1.SelectedTab Is tabCompanhia Then 'TAB Companhia selecionada
            bttnCompAdd.Visible = False
            bttnCompEdit.Visible = False
            bttnCompDel.Visible = False
            bttnCompOK.Visible = True
            bttnCompCan.Visible = True
        ElseIf TabControl1.SelectedTab Is tabSatelite Then 'TAB Satelite selecionada
            bttnSatAdd.Visible = False
            bttnSatEdit.Visible = False
            bttnSatDel.Visible = False
            bttnSatOK.Visible = True
            bttnSatCan.Visible = True
        ElseIf TabControl1.SelectedTab Is tabEE Then 'TAB EE selecionada
            bttnEEAdd.Visible = False
            bttnEEEdit.Visible = False
            bttnEEDel.Visible = False
            bttnEEOK.Visible = True
            bttnEECan.Visible = True
        ElseIf TabControl1.SelectedTab Is tabMee Then 'TAB Mee selecionada
            bttnMEEAdd.Visible = False
            bttnMEEEdit.Visible = False
            bttnMEEDel.Visible = False
            bttnMEEOK.Visible = True
            bttnMEECan.Visible = True
        ElseIf TabControl1.SelectedTab Is tabOrbita Then 'TAB Orbita selecionada
            bttnOrbEdit.Visible = False
            bttnOrbDel.Visible = False
            bttnOrbOK.Visible = True
            bttnOrbCan.Visible = True
        ElseIf TabControl1.SelectedTab Is tabLanc Then 'TAB Lançamento selecionada
            bttnLanAdd.Visible = False
            bttnLanEdit.Visible = False
            bttnLanDel.Visible = False
            bttnLanOK.Visible = True
            bttnLanCan.Visible = True
        End If
    End Sub

    Sub ShowButtons()
        LockControls()
        If TabControl1.SelectedTab Is tabAstro Then 'TAB Astro selecionada
            bttnAstroAdd.Visible = True
            bttnAstroEdit.Visible = True
            bttnAstroDel.Visible = True
            bttnAstroOK.Visible = False
            bttnAstroCan.Visible = False
        ElseIf TabControl1.SelectedTab Is tabCompanhia Then 'TAB Companhia selecionada
            bttnCompAdd.Visible = True
            bttnCompEdit.Visible = True
            bttnCompDel.Visible = True
            bttnCompOK.Visible = False
            bttnCompCan.Visible = False
        ElseIf TabControl1.SelectedTab Is tabSatelite Then 'TAB Satelite selecionada
            bttnSatAdd.Visible = True
            bttnSatEdit.Visible = True
            bttnSatDel.Visible = True
            bttnSatOK.Visible = False
            bttnSatCan.Visible = False
        ElseIf TabControl1.SelectedTab Is tabEE Then 'TAB EE selecionada
            bttnEEAdd.Visible = True
            bttnEEEdit.Visible = True
            bttnEEDel.Visible = True
            bttnEEOK.Visible = False
            bttnEECan.Visible = False
        ElseIf TabControl1.SelectedTab Is tabMee Then 'TAB Mee selecionada
            bttnMEEAdd.Visible = True
            bttnMEEEdit.Visible = True
            bttnMEEDel.Visible = True
            bttnMEEOK.Visible = False
            bttnMEECan.Visible = False
        ElseIf TabControl1.SelectedTab Is tabOrbita Then 'TAB Orbita selecionada
            bttnOrbEdit.Visible = True
            bttnOrbDel.Visible = True
            bttnOrbOK.Visible = False
            bttnOrbCan.Visible = False
        ElseIf TabControl1.SelectedTab Is tabLanc Then 'TAB Lançamento selecionada
            bttnLanAdd.Visible = True
            bttnLanEdit.Visible = True
            bttnLanDel.Visible = True
            bttnLanOK.Visible = False
            bttnLanCan.Visible = False
        End If
    End Sub

    Sub LockControls()
        If TabControl1.SelectedTab Is tabAstro Then 'TAB Astro selecionada
            txtAstroID.ReadOnly = True
            txtAstroType.ReadOnly = True
            txtAstroSystem.ReadOnly = True
            txtAstroGalaxy.ReadOnly = True
        ElseIf TabControl1.SelectedTab Is tabCompanhia Then 'TAB Companhia selecionada
            txtCompName.ReadOnly = True
            txtCompNIF.ReadOnly = True
            txtCompTelef.ReadOnly = True
            txtCompEnder.ReadOnly = True
            txtCompCodPos.ReadOnly = True
            txtCompSede.ReadOnly = True
        ElseIf TabControl1.SelectedTab Is tabSatelite Then 'TAB Satelite selecionada
            txtSatID.ReadOnly = True
            txtSatNome.ReadOnly = True
            txtSatServico.ReadOnly = True
            txtSatPaisOrg.ReadOnly = True
            txtSatCompLog.ReadOnly = True
            txtSatLanc.ReadOnly = True
            txtSatStatus.ReadOnly = True
            txtSatComp.ReadOnly = True
            txtSatOrbAp.Visible = False
            txtSatOrbPeria.Visible = False
            txtSatOrbInc.Visible = False
            txtSatOrbPerio.Visible = False
            txtSatOrbAstro.Visible = False
            lblSatOrb.Visible = False
            lblSatOrbAp.Visible = False
            lblSatOrbPeria.Visible = False
            lblSatOrbInc.Visible = False
            lblSatOrbPerio.Visible = False
            lblSatOrbAstro.Visible = False
        ElseIf TabControl1.SelectedTab Is tabEE Then 'TAB EE selecionada
            txtEEID.ReadOnly = True
            txtEENome.ReadOnly = True
            txtEEPaisOrg.ReadOnly = True
            txtEECompLog.ReadOnly = True
            txtEEStatus.ReadOnly = True
            txtCMEE.ReadOnly = True
            txtEEOrbAp.Visible = False
            txtEEOrbPeria.Visible = False
            txtEEOrbInc.Visible = False
            txtEEOrbPerio.Visible = False
            txtEEOrbAstro.Visible = False
            lblEEOrb.Visible = False
            lblEEOrbAp.Visible = False
            lblEEOrbPeria.Visible = False
            lblEEOrbInc.Visible = False
            lblEEOrbPerio.Visible = False
            lblEEOrbAstro.Visible = False
        ElseIf TabControl1.SelectedTab Is tabMee Then 'TAB Mee selecionada
            txtMeeID.ReadOnly = True
            txtMeeNome.ReadOnly = True
            txtMeeTipo.ReadOnly = True
            txtMeeCompLog.ReadOnly = True
            txtMeeLanc.ReadOnly = True
            txtMeeEE.ReadOnly = True
        ElseIf TabControl1.SelectedTab Is tabOrbita Then 'TAB Orbita selecionada
            txtOrbID.ReadOnly = True
            txtOrbAp.ReadOnly = True
            txtOrbPe.ReadOnly = True
            txtOrbIn.ReadOnly = True
            txtOrbPer.ReadOnly = True
            txtOrbAstro.ReadOnly = True
        ElseIf TabControl1.SelectedTab Is tabLanc Then 'TAB Lançamento selecionada
            txtLancID.ReadOnly = True
            txtLancCoord.ReadOnly = True
            txtLancPais.ReadOnly = True
            txtLancDT.ReadOnly = True
            txtLancVeicN.ReadOnly = True
            txtLancVeicCL.ReadOnly = True
            txtLancObj.ReadOnly = True
        End If
    End Sub

    Sub UnlockControls()
        If TabControl1.SelectedTab Is tabAstro Then 'TAB Astro selecionada
            txtAstroID.ReadOnly = False
            txtAstroType.ReadOnly = False
            txtAstroSystem.ReadOnly = False
            txtAstroGalaxy.ReadOnly = False
        ElseIf TabControl1.SelectedTab Is tabCompanhia Then 'TAB Companhia selecionada
            txtCompName.ReadOnly = False
            txtCompNIF.ReadOnly = False
            txtCompTelef.ReadOnly = False
            txtCompEnder.ReadOnly = False
            txtCompCodPos.ReadOnly = False
            txtCompSede.ReadOnly = False
        ElseIf TabControl1.SelectedTab Is tabSatelite Then 'TAB Satelite selecionada
            txtSatID.ReadOnly = False
            txtSatNome.ReadOnly = False
            txtSatServico.ReadOnly = False
            txtSatPaisOrg.ReadOnly = False
            txtSatCompLog.ReadOnly = False
            txtSatLanc.ReadOnly = False
            txtSatStatus.ReadOnly = False
            txtSatComp.ReadOnly = False
            txtSatOrbAp.Visible = True
            txtSatOrbPeria.Visible = True
            txtSatOrbInc.Visible = True
            txtSatOrbPerio.Visible = True
            txtSatOrbAstro.Visible = True
            lblSatOrb.Visible = True
            lblSatOrbAp.Visible = True
            lblSatOrbPeria.Visible = True
            lblSatOrbInc.Visible = True
            lblSatOrbPerio.Visible = True
            lblSatOrbAstro.Visible = True
        ElseIf TabControl1.SelectedTab Is tabEE Then 'TAB EE selecionada
            txtEEID.ReadOnly = False
            txtEENome.ReadOnly = False
            txtEEPaisOrg.ReadOnly = False
            txtEECompLog.ReadOnly = False
            txtEEStatus.ReadOnly = False
            txtCMEE.ReadOnly = False
            txtEEOrbAp.Visible = True
            txtEEOrbPeria.Visible = True
            txtEEOrbInc.Visible = True
            txtEEOrbPerio.Visible = True
            txtEEOrbAstro.Visible = True
            lblEEOrb.Visible = True
            lblEEOrbAp.Visible = True
            lblEEOrbPeria.Visible = True
            lblEEOrbInc.Visible = True
            lblEEOrbPerio.Visible = True
            lblEEOrbAstro.Visible = True
        ElseIf TabControl1.SelectedTab Is tabMee Then 'TAB Mee selecionada
            txtMeeID.ReadOnly = False
            txtMeeNome.ReadOnly = False
            txtMeeTipo.ReadOnly = False
            txtMeeCompLog.ReadOnly = False
            txtMeeLanc.ReadOnly = False
            txtMeeEE.ReadOnly = False
        ElseIf TabControl1.SelectedTab Is tabOrbita Then 'TAB Orbita selecionada
            txtOrbID.ReadOnly = False
            txtOrbAp.ReadOnly = False
            txtOrbPe.ReadOnly = False
            txtOrbIn.ReadOnly = False
            txtOrbPer.ReadOnly = False
            txtOrbAstro.ReadOnly = False
        ElseIf TabControl1.SelectedTab Is tabLanc Then 'TAB Lançamento selecionada
            txtLancID.ReadOnly = False
            txtLancCoord.ReadOnly = False
            txtLancPais.ReadOnly = False
            txtLancDT.ReadOnly = False
            txtLancVeicN.ReadOnly = False
            txtLancVeicCL.ReadOnly = False
            txtLancObj.ReadOnly = False
        End If
    End Sub

    Private Sub bttnPesqPesq_Click(sender As Object, e As EventArgs) Handles bttnPesqPesq.Click
        Dim adpat As SqlDataAdapter = New SqlDataAdapter()
        adpat.SelectCommand = New SqlCommand()
        adpat.SelectCommand.Connection = CN
        adpat.SelectCommand.CommandType = CommandType.StoredProcedure

        If (comboBoxPesq.SelectedIndex = 0) Then ' PESQUISAR POR LANCAMENTOS
            adpat.SelectCommand.CommandText = "MORSA.pr_advLancVeic"
            adpat.SelectCommand.Parameters.AddWithValue("@ID", txtPesqPesq.Text)
            If (radioBttnPesq1.Checked) Then
                adpat.SelectCommand.Parameters.AddWithValue("@sel", 0)
            ElseIf (radioBttnPesq2.Checked) Then
                adpat.SelectCommand.Parameters.AddWithValue("@sel", 1)
            End If

        ElseIf (comboBoxPesq.SelectedIndex = 1) Then
            adpat.SelectCommand.CommandText = "MORSA.pr_advModules"
            adpat.SelectCommand.Parameters.AddWithValue("@ID", txtPesqPesq.Text)
        ElseIf (comboBoxPesq.SelectedIndex = 2) Then
            adpat.SelectCommand.CommandText = "MORSA.pr_advAstro"
            adpat.SelectCommand.Parameters.AddWithValue("@ID", txtPesqPesq.Text)
        ElseIf (comboBoxPesq.SelectedIndex = 3) Then
            adpat.SelectCommand.CommandText = "MORSA.pr_advComp"
            adpat.SelectCommand.Parameters.AddWithValue("@NIF", txtPesqPesq.Text)
            If (radioBttnPesq1.Checked) Then
                adpat.SelectCommand.Parameters.AddWithValue("@sel", 0)
            ElseIf (radioBttnPesq2.Checked) Then
                adpat.SelectCommand.Parameters.AddWithValue("@sel", 1)
            End If
        ElseIf (comboBoxPesq.SelectedIndex = 4) Then
            adpat.SelectCommand.CommandText = "MORSA.pr_advCompMae"
            adpat.SelectCommand.Parameters.AddWithValue("@NIF", txtPesqPesq.Text)
        ElseIf (comboBoxPesq.SelectedIndex = 5) Then
            adpat.SelectCommand.CommandText = "MORSA.pr_advCompLog"
            adpat.SelectCommand.Parameters.AddWithValue("@NIF", txtPesqPesq.Text)
        End If
        Dim table As DataTable = New DataTable("dupadupa")
        adpat.Fill(table)
        DataGridView1.DataSource = New BindingSource(table, Convert.ToString(DBNull.Value))
    End Sub

    Private Sub comboBoxPesq_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxPesq.SelectedIndexChanged
        If (comboBoxPesq.SelectedIndex = 0) Then
            radioBttnPesq1.Text = "Satelites"
            radioBttnPesq2.Text = "Modulos"
            radioBttnPesq1.Visible = True
            radioBttnPesq2.Visible = True
            lblPesq.Text = "Pesquisar por (ID) Lancamentos efetuados"
        ElseIf (comboBoxPesq.SelectedIndex = 1) Then
            radioBttnPesq1.Visible = False
            radioBttnPesq2.Visible = False
            lblPesq.Text = "Pesquisar por (ID) Modulos de uma Estacao"
        ElseIf (comboBoxPesq.SelectedIndex = 2) Then
            radioBttnPesq1.Visible = False
            radioBttnPesq2.Visible = False
            lblPesq.Text = "Pesquisar por (ID) objectos que orbitam em volta de um Astro"
        ElseIf (comboBoxPesq.SelectedIndex = 3) Then
            radioBttnPesq1.Text = "Comp. Mae"
            radioBttnPesq2.Text = "Comp. Logistica"
            radioBttnPesq1.Visible = True
            radioBttnPesq2.Visible = True
            lblPesq.Text = "Pesquisar por (NIF) Satelites e Estacoes de uma Companhia"
        ElseIf (comboBoxPesq.SelectedIndex = 4) Then
            radioBttnPesq1.Visible = False
            radioBttnPesq2.Visible = False
            lblPesq.Text = "Pesquisar por (NIF) Companhias Mae"
        ElseIf (comboBoxPesq.SelectedIndex = 5) Then
            radioBttnPesq1.Visible = False
            radioBttnPesq2.Visible = False
            lblPesq.Text = "Pesquisar por (NIF) Companhias Logistica"
        End If
    End Sub
End Class
