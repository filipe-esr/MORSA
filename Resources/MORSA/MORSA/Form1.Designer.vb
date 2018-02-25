<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.astroList = New System.Windows.Forms.ListBox()
        Me.txtAstroID = New System.Windows.Forms.TextBox()
        Me.bttnAstroAdd = New System.Windows.Forms.Button()
        Me.bttnAstroDel = New System.Windows.Forms.Button()
        Me.bttnAstroEdit = New System.Windows.Forms.Button()
        Me.lblAstroID = New System.Windows.Forms.Label()
        Me.lblAstroType = New System.Windows.Forms.Label()
        Me.lblAstroSystem = New System.Windows.Forms.Label()
        Me.lblAstroGalaxy = New System.Windows.Forms.Label()
        Me.txtAstroType = New System.Windows.Forms.TextBox()
        Me.txtAstroSystem = New System.Windows.Forms.TextBox()
        Me.txtAstroGalaxy = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabAstro = New System.Windows.Forms.TabPage()
        Me.txtAstroPesq = New System.Windows.Forms.TextBox()
        Me.bttnAstroPesq = New System.Windows.Forms.Button()
        Me.bttnAstroCan = New System.Windows.Forms.Button()
        Me.bttnAstroOK = New System.Windows.Forms.Button()
        Me.tabCompanhia = New System.Windows.Forms.TabPage()
        Me.comboBoxComp = New System.Windows.Forms.ComboBox()
        Me.bttnCompPesq = New System.Windows.Forms.Button()
        Me.txtCompPesq = New System.Windows.Forms.TextBox()
        Me.bttnCompCan = New System.Windows.Forms.Button()
        Me.bttnCompOK = New System.Windows.Forms.Button()
        Me.bttnCompDel = New System.Windows.Forms.Button()
        Me.bttnCompEdit = New System.Windows.Forms.Button()
        Me.bttnCompAdd = New System.Windows.Forms.Button()
        Me.txtCompSede = New System.Windows.Forms.TextBox()
        Me.txtCompCodPos = New System.Windows.Forms.TextBox()
        Me.txtCompEnder = New System.Windows.Forms.TextBox()
        Me.txtCompTelef = New System.Windows.Forms.TextBox()
        Me.txtCompNIF = New System.Windows.Forms.TextBox()
        Me.txtCompName = New System.Windows.Forms.TextBox()
        Me.lblCompPSede = New System.Windows.Forms.Label()
        Me.lblCompCodP = New System.Windows.Forms.Label()
        Me.lblCompEnder = New System.Windows.Forms.Label()
        Me.lblCompTelef = New System.Windows.Forms.Label()
        Me.lblCompNIF = New System.Windows.Forms.Label()
        Me.lblCompNome = New System.Windows.Forms.Label()
        Me.companhiaList = New System.Windows.Forms.ListBox()
        Me.tabSatelite = New System.Windows.Forms.TabPage()
        Me.txtSatOrbAstro = New System.Windows.Forms.TextBox()
        Me.txtSatOrbPerio = New System.Windows.Forms.TextBox()
        Me.txtSatOrbInc = New System.Windows.Forms.TextBox()
        Me.txtSatOrbPeria = New System.Windows.Forms.TextBox()
        Me.txtSatOrbAp = New System.Windows.Forms.TextBox()
        Me.lblSatOrbAstro = New System.Windows.Forms.Label()
        Me.lblSatOrbPerio = New System.Windows.Forms.Label()
        Me.lblSatOrbInc = New System.Windows.Forms.Label()
        Me.lblSatOrbPeria = New System.Windows.Forms.Label()
        Me.lblSatOrbAp = New System.Windows.Forms.Label()
        Me.lblSatOrb = New System.Windows.Forms.Label()
        Me.txtSatPesq = New System.Windows.Forms.TextBox()
        Me.comboBoxSat = New System.Windows.Forms.ComboBox()
        Me.bttnSatPesq = New System.Windows.Forms.Button()
        Me.txtSatComp = New System.Windows.Forms.RichTextBox()
        Me.bttnSatCan = New System.Windows.Forms.Button()
        Me.bttnSatOK = New System.Windows.Forms.Button()
        Me.bttnSatDel = New System.Windows.Forms.Button()
        Me.bttnSatEdit = New System.Windows.Forms.Button()
        Me.bttnSatAdd = New System.Windows.Forms.Button()
        Me.txtSatStatus = New System.Windows.Forms.TextBox()
        Me.lblSatComp = New System.Windows.Forms.Label()
        Me.lblSatStatus = New System.Windows.Forms.Label()
        Me.txtSatLanc = New System.Windows.Forms.TextBox()
        Me.lblSatLanc = New System.Windows.Forms.Label()
        Me.txtSatCompLog = New System.Windows.Forms.TextBox()
        Me.txtSatPaisOrg = New System.Windows.Forms.TextBox()
        Me.txtSatServico = New System.Windows.Forms.TextBox()
        Me.txtSatNome = New System.Windows.Forms.TextBox()
        Me.txtSatID = New System.Windows.Forms.TextBox()
        Me.lblSatCompLog = New System.Windows.Forms.Label()
        Me.lblSatPaisOrg = New System.Windows.Forms.Label()
        Me.lblSatServico = New System.Windows.Forms.Label()
        Me.lblSatNome = New System.Windows.Forms.Label()
        Me.lblSatID = New System.Windows.Forms.Label()
        Me.sateliteList = New System.Windows.Forms.ListBox()
        Me.tabEE = New System.Windows.Forms.TabPage()
        Me.txtEEOrbAstro = New System.Windows.Forms.TextBox()
        Me.txtEEOrbPerio = New System.Windows.Forms.TextBox()
        Me.txtEEOrbInc = New System.Windows.Forms.TextBox()
        Me.txtEEOrbPeria = New System.Windows.Forms.TextBox()
        Me.txtEEOrbAp = New System.Windows.Forms.TextBox()
        Me.lblEEOrbAstro = New System.Windows.Forms.Label()
        Me.lblEEOrbPerio = New System.Windows.Forms.Label()
        Me.lblEEOrbInc = New System.Windows.Forms.Label()
        Me.lblEEOrbPeria = New System.Windows.Forms.Label()
        Me.lblEEOrbAp = New System.Windows.Forms.Label()
        Me.lblEEOrb = New System.Windows.Forms.Label()
        Me.comboBoxEE = New System.Windows.Forms.ComboBox()
        Me.bttnEEPesq = New System.Windows.Forms.Button()
        Me.txtEEPesq = New System.Windows.Forms.TextBox()
        Me.txtCMEE = New System.Windows.Forms.RichTextBox()
        Me.bttnEECan = New System.Windows.Forms.Button()
        Me.bttnEEOK = New System.Windows.Forms.Button()
        Me.bttnEEDel = New System.Windows.Forms.Button()
        Me.bttnEEEdit = New System.Windows.Forms.Button()
        Me.bttnEEAdd = New System.Windows.Forms.Button()
        Me.lblEEStatus = New System.Windows.Forms.Label()
        Me.lblCMEE = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEEPaisOrg = New System.Windows.Forms.Label()
        Me.lblEENome = New System.Windows.Forms.Label()
        Me.txtEEStatus = New System.Windows.Forms.TextBox()
        Me.txtEECompLog = New System.Windows.Forms.TextBox()
        Me.txtEEPaisOrg = New System.Windows.Forms.TextBox()
        Me.txtEENome = New System.Windows.Forms.TextBox()
        Me.txtEEID = New System.Windows.Forms.TextBox()
        Me.lblEEID = New System.Windows.Forms.Label()
        Me.eeList = New System.Windows.Forms.ListBox()
        Me.tabMee = New System.Windows.Forms.TabPage()
        Me.txtMeePesq = New System.Windows.Forms.TextBox()
        Me.comboBoxMee = New System.Windows.Forms.ComboBox()
        Me.bttnMeePesq = New System.Windows.Forms.Button()
        Me.bttnMEECan = New System.Windows.Forms.Button()
        Me.bttnMEEOK = New System.Windows.Forms.Button()
        Me.bttnMEEDel = New System.Windows.Forms.Button()
        Me.bttnMEEEdit = New System.Windows.Forms.Button()
        Me.bttnMEEAdd = New System.Windows.Forms.Button()
        Me.lblMeeEE = New System.Windows.Forms.Label()
        Me.lblMeeLanc = New System.Windows.Forms.Label()
        Me.lblMeeCompLog = New System.Windows.Forms.Label()
        Me.lblMeeTipo = New System.Windows.Forms.Label()
        Me.lblMeeNome = New System.Windows.Forms.Label()
        Me.lblMeeID = New System.Windows.Forms.Label()
        Me.txtMeeEE = New System.Windows.Forms.TextBox()
        Me.txtMeeLanc = New System.Windows.Forms.TextBox()
        Me.txtMeeCompLog = New System.Windows.Forms.TextBox()
        Me.txtMeeTipo = New System.Windows.Forms.TextBox()
        Me.txtMeeNome = New System.Windows.Forms.TextBox()
        Me.txtMeeID = New System.Windows.Forms.TextBox()
        Me.meeList = New System.Windows.Forms.ListBox()
        Me.tabOrbita = New System.Windows.Forms.TabPage()
        Me.txtOrbPesq = New System.Windows.Forms.TextBox()
        Me.bttnOrbPesq = New System.Windows.Forms.Button()
        Me.bttnOrbCan = New System.Windows.Forms.Button()
        Me.bttnOrbOK = New System.Windows.Forms.Button()
        Me.bttnOrbDel = New System.Windows.Forms.Button()
        Me.bttnOrbEdit = New System.Windows.Forms.Button()
        Me.lblOrbAstro = New System.Windows.Forms.Label()
        Me.lblOrbPer = New System.Windows.Forms.Label()
        Me.lblOrbIn = New System.Windows.Forms.Label()
        Me.lblOrbPe = New System.Windows.Forms.Label()
        Me.lblOrbAp = New System.Windows.Forms.Label()
        Me.lblOrbID = New System.Windows.Forms.Label()
        Me.txtOrbAstro = New System.Windows.Forms.TextBox()
        Me.txtOrbPer = New System.Windows.Forms.TextBox()
        Me.txtOrbIn = New System.Windows.Forms.TextBox()
        Me.txtOrbPe = New System.Windows.Forms.TextBox()
        Me.txtOrbAp = New System.Windows.Forms.TextBox()
        Me.txtOrbID = New System.Windows.Forms.TextBox()
        Me.orbList = New System.Windows.Forms.ListBox()
        Me.tabLanc = New System.Windows.Forms.TabPage()
        Me.txtLancObj = New System.Windows.Forms.TextBox()
        Me.lblLancObj = New System.Windows.Forms.Label()
        Me.txtLancPesq = New System.Windows.Forms.TextBox()
        Me.bttnLancPesq = New System.Windows.Forms.Button()
        Me.bttnLanCan = New System.Windows.Forms.Button()
        Me.bttnLanOK = New System.Windows.Forms.Button()
        Me.bttnLanDel = New System.Windows.Forms.Button()
        Me.bttnLanEdit = New System.Windows.Forms.Button()
        Me.bttnLanAdd = New System.Windows.Forms.Button()
        Me.txtLancVeicCL = New System.Windows.Forms.TextBox()
        Me.lblLancVeicCL = New System.Windows.Forms.Label()
        Me.lblLancVeicN = New System.Windows.Forms.Label()
        Me.lblLancDT = New System.Windows.Forms.Label()
        Me.lblLancPais = New System.Windows.Forms.Label()
        Me.lblLancCoord = New System.Windows.Forms.Label()
        Me.lblLancID = New System.Windows.Forms.Label()
        Me.txtLancVeicN = New System.Windows.Forms.TextBox()
        Me.txtLancDT = New System.Windows.Forms.TextBox()
        Me.txtLancPais = New System.Windows.Forms.TextBox()
        Me.txtLancCoord = New System.Windows.Forms.TextBox()
        Me.txtLancID = New System.Windows.Forms.TextBox()
        Me.lancList = New System.Windows.Forms.ListBox()
        Me.tabPesquisa = New System.Windows.Forms.TabPage()
        Me.lblPesq = New System.Windows.Forms.Label()
        Me.comboBoxPesq = New System.Windows.Forms.ComboBox()
        Me.radioBttnPesq2 = New System.Windows.Forms.RadioButton()
        Me.radioBttnPesq1 = New System.Windows.Forms.RadioButton()
        Me.txtPesqPesq = New System.Windows.Forms.TextBox()
        Me.bttnPesqPesq = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabControl1.SuspendLayout()
        Me.tabAstro.SuspendLayout()
        Me.tabCompanhia.SuspendLayout()
        Me.tabSatelite.SuspendLayout()
        Me.tabEE.SuspendLayout()
        Me.tabMee.SuspendLayout()
        Me.tabOrbita.SuspendLayout()
        Me.tabLanc.SuspendLayout()
        Me.tabPesquisa.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'astroList
        '
        Me.astroList.FormattingEnabled = True
        Me.astroList.Location = New System.Drawing.Point(6, 6)
        Me.astroList.Name = "astroList"
        Me.astroList.Size = New System.Drawing.Size(237, 277)
        Me.astroList.TabIndex = 0
        '
        'txtAstroID
        '
        Me.txtAstroID.Location = New System.Drawing.Point(308, 6)
        Me.txtAstroID.Name = "txtAstroID"
        Me.txtAstroID.Size = New System.Drawing.Size(100, 20)
        Me.txtAstroID.TabIndex = 1
        '
        'bttnAstroAdd
        '
        Me.bttnAstroAdd.Location = New System.Drawing.Point(6, 289)
        Me.bttnAstroAdd.Name = "bttnAstroAdd"
        Me.bttnAstroAdd.Size = New System.Drawing.Size(75, 23)
        Me.bttnAstroAdd.TabIndex = 2
        Me.bttnAstroAdd.Text = "INSERIR"
        Me.bttnAstroAdd.UseVisualStyleBackColor = True
        '
        'bttnAstroDel
        '
        Me.bttnAstroDel.Location = New System.Drawing.Point(168, 289)
        Me.bttnAstroDel.Name = "bttnAstroDel"
        Me.bttnAstroDel.Size = New System.Drawing.Size(75, 23)
        Me.bttnAstroDel.TabIndex = 3
        Me.bttnAstroDel.Text = "REMOVER"
        Me.bttnAstroDel.UseVisualStyleBackColor = True
        '
        'bttnAstroEdit
        '
        Me.bttnAstroEdit.Location = New System.Drawing.Point(87, 289)
        Me.bttnAstroEdit.Name = "bttnAstroEdit"
        Me.bttnAstroEdit.Size = New System.Drawing.Size(75, 23)
        Me.bttnAstroEdit.TabIndex = 4
        Me.bttnAstroEdit.Text = "EDITAR"
        Me.bttnAstroEdit.UseVisualStyleBackColor = True
        '
        'lblAstroID
        '
        Me.lblAstroID.AutoSize = True
        Me.lblAstroID.Location = New System.Drawing.Point(249, 9)
        Me.lblAstroID.Name = "lblAstroID"
        Me.lblAstroID.Size = New System.Drawing.Size(18, 13)
        Me.lblAstroID.TabIndex = 5
        Me.lblAstroID.Text = "ID"
        '
        'lblAstroType
        '
        Me.lblAstroType.AutoSize = True
        Me.lblAstroType.Location = New System.Drawing.Point(249, 35)
        Me.lblAstroType.Name = "lblAstroType"
        Me.lblAstroType.Size = New System.Drawing.Size(28, 13)
        Me.lblAstroType.TabIndex = 6
        Me.lblAstroType.Text = "Tipo"
        '
        'lblAstroSystem
        '
        Me.lblAstroSystem.AutoSize = True
        Me.lblAstroSystem.Location = New System.Drawing.Point(249, 62)
        Me.lblAstroSystem.Name = "lblAstroSystem"
        Me.lblAstroSystem.Size = New System.Drawing.Size(44, 13)
        Me.lblAstroSystem.TabIndex = 7
        Me.lblAstroSystem.Text = "Sistema"
        '
        'lblAstroGalaxy
        '
        Me.lblAstroGalaxy.AutoSize = True
        Me.lblAstroGalaxy.Location = New System.Drawing.Point(249, 88)
        Me.lblAstroGalaxy.Name = "lblAstroGalaxy"
        Me.lblAstroGalaxy.Size = New System.Drawing.Size(42, 13)
        Me.lblAstroGalaxy.TabIndex = 8
        Me.lblAstroGalaxy.Text = "Galáxia"
        '
        'txtAstroType
        '
        Me.txtAstroType.Location = New System.Drawing.Point(308, 32)
        Me.txtAstroType.Name = "txtAstroType"
        Me.txtAstroType.Size = New System.Drawing.Size(100, 20)
        Me.txtAstroType.TabIndex = 9
        '
        'txtAstroSystem
        '
        Me.txtAstroSystem.Location = New System.Drawing.Point(308, 59)
        Me.txtAstroSystem.Name = "txtAstroSystem"
        Me.txtAstroSystem.Size = New System.Drawing.Size(100, 20)
        Me.txtAstroSystem.TabIndex = 10
        '
        'txtAstroGalaxy
        '
        Me.txtAstroGalaxy.Location = New System.Drawing.Point(308, 85)
        Me.txtAstroGalaxy.Name = "txtAstroGalaxy"
        Me.txtAstroGalaxy.Size = New System.Drawing.Size(100, 20)
        Me.txtAstroGalaxy.TabIndex = 11
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabAstro)
        Me.TabControl1.Controls.Add(Me.tabCompanhia)
        Me.TabControl1.Controls.Add(Me.tabSatelite)
        Me.TabControl1.Controls.Add(Me.tabEE)
        Me.TabControl1.Controls.Add(Me.tabMee)
        Me.TabControl1.Controls.Add(Me.tabOrbita)
        Me.TabControl1.Controls.Add(Me.tabLanc)
        Me.TabControl1.Controls.Add(Me.tabPesquisa)
        Me.TabControl1.Location = New System.Drawing.Point(3, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(583, 351)
        Me.TabControl1.TabIndex = 13
        '
        'tabAstro
        '
        Me.tabAstro.Controls.Add(Me.txtAstroPesq)
        Me.tabAstro.Controls.Add(Me.bttnAstroPesq)
        Me.tabAstro.Controls.Add(Me.bttnAstroCan)
        Me.tabAstro.Controls.Add(Me.bttnAstroOK)
        Me.tabAstro.Controls.Add(Me.astroList)
        Me.tabAstro.Controls.Add(Me.txtAstroID)
        Me.tabAstro.Controls.Add(Me.bttnAstroEdit)
        Me.tabAstro.Controls.Add(Me.bttnAstroDel)
        Me.tabAstro.Controls.Add(Me.txtAstroGalaxy)
        Me.tabAstro.Controls.Add(Me.bttnAstroAdd)
        Me.tabAstro.Controls.Add(Me.lblAstroID)
        Me.tabAstro.Controls.Add(Me.txtAstroSystem)
        Me.tabAstro.Controls.Add(Me.lblAstroType)
        Me.tabAstro.Controls.Add(Me.txtAstroType)
        Me.tabAstro.Controls.Add(Me.lblAstroSystem)
        Me.tabAstro.Controls.Add(Me.lblAstroGalaxy)
        Me.tabAstro.Location = New System.Drawing.Point(4, 22)
        Me.tabAstro.Name = "tabAstro"
        Me.tabAstro.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAstro.Size = New System.Drawing.Size(575, 325)
        Me.tabAstro.TabIndex = 0
        Me.tabAstro.Text = "Astro"
        Me.tabAstro.UseVisualStyleBackColor = True
        '
        'txtAstroPesq
        '
        Me.txtAstroPesq.Location = New System.Drawing.Point(468, 263)
        Me.txtAstroPesq.Name = "txtAstroPesq"
        Me.txtAstroPesq.Size = New System.Drawing.Size(100, 20)
        Me.txtAstroPesq.TabIndex = 15
        '
        'bttnAstroPesq
        '
        Me.bttnAstroPesq.Location = New System.Drawing.Point(493, 289)
        Me.bttnAstroPesq.Name = "bttnAstroPesq"
        Me.bttnAstroPesq.Size = New System.Drawing.Size(75, 23)
        Me.bttnAstroPesq.TabIndex = 14
        Me.bttnAstroPesq.Text = "Pesquisar"
        Me.bttnAstroPesq.UseVisualStyleBackColor = True
        '
        'bttnAstroCan
        '
        Me.bttnAstroCan.Location = New System.Drawing.Point(333, 289)
        Me.bttnAstroCan.Name = "bttnAstroCan"
        Me.bttnAstroCan.Size = New System.Drawing.Size(75, 23)
        Me.bttnAstroCan.TabIndex = 13
        Me.bttnAstroCan.Text = "CANCELAR"
        Me.bttnAstroCan.UseVisualStyleBackColor = True
        '
        'bttnAstroOK
        '
        Me.bttnAstroOK.Location = New System.Drawing.Point(252, 289)
        Me.bttnAstroOK.Name = "bttnAstroOK"
        Me.bttnAstroOK.Size = New System.Drawing.Size(75, 23)
        Me.bttnAstroOK.TabIndex = 12
        Me.bttnAstroOK.Text = "OK"
        Me.bttnAstroOK.UseVisualStyleBackColor = True
        '
        'tabCompanhia
        '
        Me.tabCompanhia.Controls.Add(Me.comboBoxComp)
        Me.tabCompanhia.Controls.Add(Me.bttnCompPesq)
        Me.tabCompanhia.Controls.Add(Me.txtCompPesq)
        Me.tabCompanhia.Controls.Add(Me.bttnCompCan)
        Me.tabCompanhia.Controls.Add(Me.bttnCompOK)
        Me.tabCompanhia.Controls.Add(Me.bttnCompDel)
        Me.tabCompanhia.Controls.Add(Me.bttnCompEdit)
        Me.tabCompanhia.Controls.Add(Me.bttnCompAdd)
        Me.tabCompanhia.Controls.Add(Me.txtCompSede)
        Me.tabCompanhia.Controls.Add(Me.txtCompCodPos)
        Me.tabCompanhia.Controls.Add(Me.txtCompEnder)
        Me.tabCompanhia.Controls.Add(Me.txtCompTelef)
        Me.tabCompanhia.Controls.Add(Me.txtCompNIF)
        Me.tabCompanhia.Controls.Add(Me.txtCompName)
        Me.tabCompanhia.Controls.Add(Me.lblCompPSede)
        Me.tabCompanhia.Controls.Add(Me.lblCompCodP)
        Me.tabCompanhia.Controls.Add(Me.lblCompEnder)
        Me.tabCompanhia.Controls.Add(Me.lblCompTelef)
        Me.tabCompanhia.Controls.Add(Me.lblCompNIF)
        Me.tabCompanhia.Controls.Add(Me.lblCompNome)
        Me.tabCompanhia.Controls.Add(Me.companhiaList)
        Me.tabCompanhia.Location = New System.Drawing.Point(4, 22)
        Me.tabCompanhia.Name = "tabCompanhia"
        Me.tabCompanhia.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCompanhia.Size = New System.Drawing.Size(575, 325)
        Me.tabCompanhia.TabIndex = 1
        Me.tabCompanhia.Text = "Companhia"
        Me.tabCompanhia.UseVisualStyleBackColor = True
        '
        'comboBoxComp
        '
        Me.comboBoxComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxComp.FormattingEnabled = True
        Me.comboBoxComp.Items.AddRange(New Object() {"Nome", "NIF"})
        Me.comboBoxComp.Location = New System.Drawing.Point(450, 236)
        Me.comboBoxComp.Name = "comboBoxComp"
        Me.comboBoxComp.Size = New System.Drawing.Size(117, 21)
        Me.comboBoxComp.TabIndex = 21
        '
        'bttnCompPesq
        '
        Me.bttnCompPesq.Location = New System.Drawing.Point(479, 289)
        Me.bttnCompPesq.Name = "bttnCompPesq"
        Me.bttnCompPesq.Size = New System.Drawing.Size(88, 23)
        Me.bttnCompPesq.TabIndex = 19
        Me.bttnCompPesq.Text = "Pesquisar"
        Me.bttnCompPesq.UseVisualStyleBackColor = True
        '
        'txtCompPesq
        '
        Me.txtCompPesq.Location = New System.Drawing.Point(450, 263)
        Me.txtCompPesq.Name = "txtCompPesq"
        Me.txtCompPesq.Size = New System.Drawing.Size(117, 20)
        Me.txtCompPesq.TabIndex = 18
        '
        'bttnCompCan
        '
        Me.bttnCompCan.Location = New System.Drawing.Point(351, 289)
        Me.bttnCompCan.Name = "bttnCompCan"
        Me.bttnCompCan.Size = New System.Drawing.Size(75, 23)
        Me.bttnCompCan.TabIndex = 17
        Me.bttnCompCan.Text = "CANCELAR"
        Me.bttnCompCan.UseVisualStyleBackColor = True
        '
        'bttnCompOK
        '
        Me.bttnCompOK.Location = New System.Drawing.Point(270, 289)
        Me.bttnCompOK.Name = "bttnCompOK"
        Me.bttnCompOK.Size = New System.Drawing.Size(75, 23)
        Me.bttnCompOK.TabIndex = 16
        Me.bttnCompOK.Text = "OK"
        Me.bttnCompOK.UseVisualStyleBackColor = True
        '
        'bttnCompDel
        '
        Me.bttnCompDel.Location = New System.Drawing.Point(168, 289)
        Me.bttnCompDel.Name = "bttnCompDel"
        Me.bttnCompDel.Size = New System.Drawing.Size(75, 23)
        Me.bttnCompDel.TabIndex = 15
        Me.bttnCompDel.Text = "REMOVER"
        Me.bttnCompDel.UseVisualStyleBackColor = True
        '
        'bttnCompEdit
        '
        Me.bttnCompEdit.Location = New System.Drawing.Point(87, 289)
        Me.bttnCompEdit.Name = "bttnCompEdit"
        Me.bttnCompEdit.Size = New System.Drawing.Size(75, 23)
        Me.bttnCompEdit.TabIndex = 14
        Me.bttnCompEdit.Text = "EDITAR"
        Me.bttnCompEdit.UseVisualStyleBackColor = True
        '
        'bttnCompAdd
        '
        Me.bttnCompAdd.Location = New System.Drawing.Point(6, 289)
        Me.bttnCompAdd.Name = "bttnCompAdd"
        Me.bttnCompAdd.Size = New System.Drawing.Size(75, 23)
        Me.bttnCompAdd.TabIndex = 13
        Me.bttnCompAdd.Text = "INSERIR"
        Me.bttnCompAdd.UseVisualStyleBackColor = True
        '
        'txtCompSede
        '
        Me.txtCompSede.Location = New System.Drawing.Point(326, 136)
        Me.txtCompSede.Name = "txtCompSede"
        Me.txtCompSede.Size = New System.Drawing.Size(145, 20)
        Me.txtCompSede.TabIndex = 12
        '
        'txtCompCodPos
        '
        Me.txtCompCodPos.Location = New System.Drawing.Point(326, 110)
        Me.txtCompCodPos.Name = "txtCompCodPos"
        Me.txtCompCodPos.Size = New System.Drawing.Size(145, 20)
        Me.txtCompCodPos.TabIndex = 11
        '
        'txtCompEnder
        '
        Me.txtCompEnder.Location = New System.Drawing.Point(326, 84)
        Me.txtCompEnder.Name = "txtCompEnder"
        Me.txtCompEnder.Size = New System.Drawing.Size(145, 20)
        Me.txtCompEnder.TabIndex = 10
        '
        'txtCompTelef
        '
        Me.txtCompTelef.Location = New System.Drawing.Point(326, 58)
        Me.txtCompTelef.Name = "txtCompTelef"
        Me.txtCompTelef.Size = New System.Drawing.Size(145, 20)
        Me.txtCompTelef.TabIndex = 9
        '
        'txtCompNIF
        '
        Me.txtCompNIF.Location = New System.Drawing.Point(326, 32)
        Me.txtCompNIF.Name = "txtCompNIF"
        Me.txtCompNIF.Size = New System.Drawing.Size(145, 20)
        Me.txtCompNIF.TabIndex = 8
        '
        'txtCompName
        '
        Me.txtCompName.Location = New System.Drawing.Point(326, 6)
        Me.txtCompName.Name = "txtCompName"
        Me.txtCompName.Size = New System.Drawing.Size(145, 20)
        Me.txtCompName.TabIndex = 7
        '
        'lblCompPSede
        '
        Me.lblCompPSede.AutoSize = True
        Me.lblCompPSede.Location = New System.Drawing.Point(249, 139)
        Me.lblCompPSede.Name = "lblCompPSede"
        Me.lblCompPSede.Size = New System.Drawing.Size(57, 13)
        Me.lblCompPSede.TabIndex = 6
        Me.lblCompPSede.Text = "País Sede"
        '
        'lblCompCodP
        '
        Me.lblCompCodP.AutoSize = True
        Me.lblCompCodP.Location = New System.Drawing.Point(249, 113)
        Me.lblCompCodP.Name = "lblCompCodP"
        Me.lblCompCodP.Size = New System.Drawing.Size(72, 13)
        Me.lblCompCodP.TabIndex = 5
        Me.lblCompCodP.Text = "Código Postal"
        '
        'lblCompEnder
        '
        Me.lblCompEnder.AutoSize = True
        Me.lblCompEnder.Location = New System.Drawing.Point(249, 87)
        Me.lblCompEnder.Name = "lblCompEnder"
        Me.lblCompEnder.Size = New System.Drawing.Size(53, 13)
        Me.lblCompEnder.TabIndex = 4
        Me.lblCompEnder.Text = "Endereço"
        '
        'lblCompTelef
        '
        Me.lblCompTelef.AutoSize = True
        Me.lblCompTelef.Location = New System.Drawing.Point(249, 61)
        Me.lblCompTelef.Name = "lblCompTelef"
        Me.lblCompTelef.Size = New System.Drawing.Size(49, 13)
        Me.lblCompTelef.TabIndex = 3
        Me.lblCompTelef.Text = "Telefone"
        '
        'lblCompNIF
        '
        Me.lblCompNIF.AutoSize = True
        Me.lblCompNIF.Location = New System.Drawing.Point(249, 35)
        Me.lblCompNIF.Name = "lblCompNIF"
        Me.lblCompNIF.Size = New System.Drawing.Size(24, 13)
        Me.lblCompNIF.TabIndex = 2
        Me.lblCompNIF.Text = "NIF"
        '
        'lblCompNome
        '
        Me.lblCompNome.AutoSize = True
        Me.lblCompNome.Location = New System.Drawing.Point(249, 9)
        Me.lblCompNome.Name = "lblCompNome"
        Me.lblCompNome.Size = New System.Drawing.Size(35, 13)
        Me.lblCompNome.TabIndex = 1
        Me.lblCompNome.Text = "Nome"
        '
        'companhiaList
        '
        Me.companhiaList.FormattingEnabled = True
        Me.companhiaList.Location = New System.Drawing.Point(6, 6)
        Me.companhiaList.Name = "companhiaList"
        Me.companhiaList.Size = New System.Drawing.Size(237, 277)
        Me.companhiaList.TabIndex = 0
        '
        'tabSatelite
        '
        Me.tabSatelite.Controls.Add(Me.txtSatOrbAstro)
        Me.tabSatelite.Controls.Add(Me.txtSatOrbPerio)
        Me.tabSatelite.Controls.Add(Me.txtSatOrbInc)
        Me.tabSatelite.Controls.Add(Me.txtSatOrbPeria)
        Me.tabSatelite.Controls.Add(Me.txtSatOrbAp)
        Me.tabSatelite.Controls.Add(Me.lblSatOrbAstro)
        Me.tabSatelite.Controls.Add(Me.lblSatOrbPerio)
        Me.tabSatelite.Controls.Add(Me.lblSatOrbInc)
        Me.tabSatelite.Controls.Add(Me.lblSatOrbPeria)
        Me.tabSatelite.Controls.Add(Me.lblSatOrbAp)
        Me.tabSatelite.Controls.Add(Me.lblSatOrb)
        Me.tabSatelite.Controls.Add(Me.txtSatPesq)
        Me.tabSatelite.Controls.Add(Me.comboBoxSat)
        Me.tabSatelite.Controls.Add(Me.bttnSatPesq)
        Me.tabSatelite.Controls.Add(Me.txtSatComp)
        Me.tabSatelite.Controls.Add(Me.bttnSatCan)
        Me.tabSatelite.Controls.Add(Me.bttnSatOK)
        Me.tabSatelite.Controls.Add(Me.bttnSatDel)
        Me.tabSatelite.Controls.Add(Me.bttnSatEdit)
        Me.tabSatelite.Controls.Add(Me.bttnSatAdd)
        Me.tabSatelite.Controls.Add(Me.txtSatStatus)
        Me.tabSatelite.Controls.Add(Me.lblSatComp)
        Me.tabSatelite.Controls.Add(Me.lblSatStatus)
        Me.tabSatelite.Controls.Add(Me.txtSatLanc)
        Me.tabSatelite.Controls.Add(Me.lblSatLanc)
        Me.tabSatelite.Controls.Add(Me.txtSatCompLog)
        Me.tabSatelite.Controls.Add(Me.txtSatPaisOrg)
        Me.tabSatelite.Controls.Add(Me.txtSatServico)
        Me.tabSatelite.Controls.Add(Me.txtSatNome)
        Me.tabSatelite.Controls.Add(Me.txtSatID)
        Me.tabSatelite.Controls.Add(Me.lblSatCompLog)
        Me.tabSatelite.Controls.Add(Me.lblSatPaisOrg)
        Me.tabSatelite.Controls.Add(Me.lblSatServico)
        Me.tabSatelite.Controls.Add(Me.lblSatNome)
        Me.tabSatelite.Controls.Add(Me.lblSatID)
        Me.tabSatelite.Controls.Add(Me.sateliteList)
        Me.tabSatelite.Location = New System.Drawing.Point(4, 22)
        Me.tabSatelite.Name = "tabSatelite"
        Me.tabSatelite.Padding = New System.Windows.Forms.Padding(3)
        Me.tabSatelite.Size = New System.Drawing.Size(575, 325)
        Me.tabSatelite.TabIndex = 2
        Me.tabSatelite.Text = "Satelite"
        Me.tabSatelite.UseVisualStyleBackColor = True
        '
        'txtSatOrbAstro
        '
        Me.txtSatOrbAstro.Location = New System.Drawing.Point(505, 140)
        Me.txtSatOrbAstro.Name = "txtSatOrbAstro"
        Me.txtSatOrbAstro.Size = New System.Drawing.Size(67, 20)
        Me.txtSatOrbAstro.TabIndex = 36
        '
        'txtSatOrbPerio
        '
        Me.txtSatOrbPerio.Location = New System.Drawing.Point(505, 113)
        Me.txtSatOrbPerio.Name = "txtSatOrbPerio"
        Me.txtSatOrbPerio.Size = New System.Drawing.Size(67, 20)
        Me.txtSatOrbPerio.TabIndex = 35
        '
        'txtSatOrbInc
        '
        Me.txtSatOrbInc.Location = New System.Drawing.Point(505, 86)
        Me.txtSatOrbInc.Name = "txtSatOrbInc"
        Me.txtSatOrbInc.Size = New System.Drawing.Size(67, 20)
        Me.txtSatOrbInc.TabIndex = 34
        '
        'txtSatOrbPeria
        '
        Me.txtSatOrbPeria.Location = New System.Drawing.Point(505, 59)
        Me.txtSatOrbPeria.Name = "txtSatOrbPeria"
        Me.txtSatOrbPeria.Size = New System.Drawing.Size(67, 20)
        Me.txtSatOrbPeria.TabIndex = 33
        '
        'txtSatOrbAp
        '
        Me.txtSatOrbAp.Location = New System.Drawing.Point(505, 32)
        Me.txtSatOrbAp.Name = "txtSatOrbAp"
        Me.txtSatOrbAp.Size = New System.Drawing.Size(67, 20)
        Me.txtSatOrbAp.TabIndex = 32
        '
        'lblSatOrbAstro
        '
        Me.lblSatOrbAstro.AutoSize = True
        Me.lblSatOrbAstro.Location = New System.Drawing.Point(449, 142)
        Me.lblSatOrbAstro.Name = "lblSatOrbAstro"
        Me.lblSatOrbAstro.Size = New System.Drawing.Size(31, 13)
        Me.lblSatOrbAstro.TabIndex = 31
        Me.lblSatOrbAstro.Text = "Astro"
        '
        'lblSatOrbPerio
        '
        Me.lblSatOrbPerio.AutoSize = True
        Me.lblSatOrbPerio.Location = New System.Drawing.Point(449, 116)
        Me.lblSatOrbPerio.Name = "lblSatOrbPerio"
        Me.lblSatOrbPerio.Size = New System.Drawing.Size(43, 13)
        Me.lblSatOrbPerio.TabIndex = 30
        Me.lblSatOrbPerio.Text = "Periodo"
        '
        'lblSatOrbInc
        '
        Me.lblSatOrbInc.AutoSize = True
        Me.lblSatOrbInc.Location = New System.Drawing.Point(449, 90)
        Me.lblSatOrbInc.Name = "lblSatOrbInc"
        Me.lblSatOrbInc.Size = New System.Drawing.Size(35, 13)
        Me.lblSatOrbInc.TabIndex = 29
        Me.lblSatOrbInc.Text = "Inclin."
        '
        'lblSatOrbPeria
        '
        Me.lblSatOrbPeria.AutoSize = True
        Me.lblSatOrbPeria.Location = New System.Drawing.Point(449, 63)
        Me.lblSatOrbPeria.Name = "lblSatOrbPeria"
        Me.lblSatOrbPeria.Size = New System.Drawing.Size(48, 13)
        Me.lblSatOrbPeria.TabIndex = 28
        Me.lblSatOrbPeria.Text = "Periastro"
        '
        'lblSatOrbAp
        '
        Me.lblSatOrbAp.AutoSize = True
        Me.lblSatOrbAp.Location = New System.Drawing.Point(449, 36)
        Me.lblSatOrbAp.Name = "lblSatOrbAp"
        Me.lblSatOrbAp.Size = New System.Drawing.Size(49, 13)
        Me.lblSatOrbAp.TabIndex = 27
        Me.lblSatOrbAp.Text = "Apoastro"
        '
        'lblSatOrb
        '
        Me.lblSatOrb.AutoSize = True
        Me.lblSatOrb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSatOrb.Location = New System.Drawing.Point(491, 9)
        Me.lblSatOrb.Name = "lblSatOrb"
        Me.lblSatOrb.Size = New System.Drawing.Size(41, 13)
        Me.lblSatOrb.TabIndex = 26
        Me.lblSatOrb.Text = "Orbita"
        '
        'txtSatPesq
        '
        Me.txtSatPesq.Location = New System.Drawing.Point(467, 263)
        Me.txtSatPesq.Name = "txtSatPesq"
        Me.txtSatPesq.Size = New System.Drawing.Size(100, 20)
        Me.txtSatPesq.TabIndex = 25
        '
        'comboBoxSat
        '
        Me.comboBoxSat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxSat.FormattingEnabled = True
        Me.comboBoxSat.Items.AddRange(New Object() {"Nome", "ID"})
        Me.comboBoxSat.Location = New System.Drawing.Point(467, 236)
        Me.comboBoxSat.Name = "comboBoxSat"
        Me.comboBoxSat.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxSat.TabIndex = 24
        '
        'bttnSatPesq
        '
        Me.bttnSatPesq.Location = New System.Drawing.Point(492, 289)
        Me.bttnSatPesq.Name = "bttnSatPesq"
        Me.bttnSatPesq.Size = New System.Drawing.Size(75, 23)
        Me.bttnSatPesq.TabIndex = 23
        Me.bttnSatPesq.Text = "Pesquisar"
        Me.bttnSatPesq.UseVisualStyleBackColor = True
        '
        'txtSatComp
        '
        Me.txtSatComp.Location = New System.Drawing.Point(320, 228)
        Me.txtSatComp.Name = "txtSatComp"
        Me.txtSatComp.Size = New System.Drawing.Size(116, 55)
        Me.txtSatComp.TabIndex = 22
        Me.txtSatComp.Text = ""
        '
        'bttnSatCan
        '
        Me.bttnSatCan.Location = New System.Drawing.Point(361, 289)
        Me.bttnSatCan.Name = "bttnSatCan"
        Me.bttnSatCan.Size = New System.Drawing.Size(75, 23)
        Me.bttnSatCan.TabIndex = 21
        Me.bttnSatCan.Text = "CANCELAR"
        Me.bttnSatCan.UseVisualStyleBackColor = True
        '
        'bttnSatOK
        '
        Me.bttnSatOK.Location = New System.Drawing.Point(280, 289)
        Me.bttnSatOK.Name = "bttnSatOK"
        Me.bttnSatOK.Size = New System.Drawing.Size(75, 23)
        Me.bttnSatOK.TabIndex = 20
        Me.bttnSatOK.Text = "OK"
        Me.bttnSatOK.UseVisualStyleBackColor = True
        '
        'bttnSatDel
        '
        Me.bttnSatDel.Location = New System.Drawing.Point(168, 289)
        Me.bttnSatDel.Name = "bttnSatDel"
        Me.bttnSatDel.Size = New System.Drawing.Size(75, 23)
        Me.bttnSatDel.TabIndex = 19
        Me.bttnSatDel.Text = "REMOVER"
        Me.bttnSatDel.UseVisualStyleBackColor = True
        '
        'bttnSatEdit
        '
        Me.bttnSatEdit.Location = New System.Drawing.Point(87, 289)
        Me.bttnSatEdit.Name = "bttnSatEdit"
        Me.bttnSatEdit.Size = New System.Drawing.Size(75, 23)
        Me.bttnSatEdit.TabIndex = 18
        Me.bttnSatEdit.Text = "EDITAR"
        Me.bttnSatEdit.UseVisualStyleBackColor = True
        '
        'bttnSatAdd
        '
        Me.bttnSatAdd.Location = New System.Drawing.Point(6, 289)
        Me.bttnSatAdd.Name = "bttnSatAdd"
        Me.bttnSatAdd.Size = New System.Drawing.Size(75, 23)
        Me.bttnSatAdd.TabIndex = 17
        Me.bttnSatAdd.Text = "INSERIR"
        Me.bttnSatAdd.UseVisualStyleBackColor = True
        '
        'txtSatStatus
        '
        Me.txtSatStatus.Location = New System.Drawing.Point(336, 186)
        Me.txtSatStatus.Name = "txtSatStatus"
        Me.txtSatStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtSatStatus.TabIndex = 15
        '
        'lblSatComp
        '
        Me.lblSatComp.AutoSize = True
        Me.lblSatComp.Location = New System.Drawing.Point(253, 228)
        Me.lblSatComp.Name = "lblSatComp"
        Me.lblSatComp.Size = New System.Drawing.Size(61, 13)
        Me.lblSatComp.TabIndex = 14
        Me.lblSatComp.Text = "Comp. Mãe"
        '
        'lblSatStatus
        '
        Me.lblSatStatus.AutoSize = True
        Me.lblSatStatus.Location = New System.Drawing.Point(253, 189)
        Me.lblSatStatus.Name = "lblSatStatus"
        Me.lblSatStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblSatStatus.TabIndex = 13
        Me.lblSatStatus.Text = "Status"
        '
        'txtSatLanc
        '
        Me.txtSatLanc.Location = New System.Drawing.Point(336, 139)
        Me.txtSatLanc.Name = "txtSatLanc"
        Me.txtSatLanc.Size = New System.Drawing.Size(100, 20)
        Me.txtSatLanc.TabIndex = 12
        '
        'lblSatLanc
        '
        Me.lblSatLanc.AutoSize = True
        Me.lblSatLanc.Location = New System.Drawing.Point(253, 142)
        Me.lblSatLanc.Name = "lblSatLanc"
        Me.lblSatLanc.Size = New System.Drawing.Size(66, 13)
        Me.lblSatLanc.TabIndex = 11
        Me.lblSatLanc.Text = "Lançamento"
        '
        'txtSatCompLog
        '
        Me.txtSatCompLog.Location = New System.Drawing.Point(336, 113)
        Me.txtSatCompLog.Name = "txtSatCompLog"
        Me.txtSatCompLog.Size = New System.Drawing.Size(100, 20)
        Me.txtSatCompLog.TabIndex = 10
        '
        'txtSatPaisOrg
        '
        Me.txtSatPaisOrg.Location = New System.Drawing.Point(336, 87)
        Me.txtSatPaisOrg.Name = "txtSatPaisOrg"
        Me.txtSatPaisOrg.Size = New System.Drawing.Size(100, 20)
        Me.txtSatPaisOrg.TabIndex = 9
        '
        'txtSatServico
        '
        Me.txtSatServico.Location = New System.Drawing.Point(336, 60)
        Me.txtSatServico.Name = "txtSatServico"
        Me.txtSatServico.Size = New System.Drawing.Size(100, 20)
        Me.txtSatServico.TabIndex = 8
        '
        'txtSatNome
        '
        Me.txtSatNome.Location = New System.Drawing.Point(336, 33)
        Me.txtSatNome.Name = "txtSatNome"
        Me.txtSatNome.Size = New System.Drawing.Size(100, 20)
        Me.txtSatNome.TabIndex = 7
        '
        'txtSatID
        '
        Me.txtSatID.Location = New System.Drawing.Point(336, 6)
        Me.txtSatID.Name = "txtSatID"
        Me.txtSatID.Size = New System.Drawing.Size(100, 20)
        Me.txtSatID.TabIndex = 6
        '
        'lblSatCompLog
        '
        Me.lblSatCompLog.AutoSize = True
        Me.lblSatCompLog.Location = New System.Drawing.Point(253, 117)
        Me.lblSatCompLog.Name = "lblSatCompLog"
        Me.lblSatCompLog.Size = New System.Drawing.Size(82, 13)
        Me.lblSatCompLog.TabIndex = 5
        Me.lblSatCompLog.Text = "Comp. Logistica"
        '
        'lblSatPaisOrg
        '
        Me.lblSatPaisOrg.AutoSize = True
        Me.lblSatPaisOrg.Location = New System.Drawing.Point(253, 90)
        Me.lblSatPaisOrg.Name = "lblSatPaisOrg"
        Me.lblSatPaisOrg.Size = New System.Drawing.Size(54, 13)
        Me.lblSatPaisOrg.TabIndex = 4
        Me.lblSatPaisOrg.Text = "País/Org."
        '
        'lblSatServico
        '
        Me.lblSatServico.AutoSize = True
        Me.lblSatServico.Location = New System.Drawing.Point(253, 63)
        Me.lblSatServico.Name = "lblSatServico"
        Me.lblSatServico.Size = New System.Drawing.Size(43, 13)
        Me.lblSatServico.TabIndex = 3
        Me.lblSatServico.Text = "Serviço"
        '
        'lblSatNome
        '
        Me.lblSatNome.AutoSize = True
        Me.lblSatNome.Location = New System.Drawing.Point(253, 36)
        Me.lblSatNome.Name = "lblSatNome"
        Me.lblSatNome.Size = New System.Drawing.Size(35, 13)
        Me.lblSatNome.TabIndex = 2
        Me.lblSatNome.Text = "Nome"
        '
        'lblSatID
        '
        Me.lblSatID.AutoSize = True
        Me.lblSatID.Location = New System.Drawing.Point(253, 10)
        Me.lblSatID.Name = "lblSatID"
        Me.lblSatID.Size = New System.Drawing.Size(18, 13)
        Me.lblSatID.TabIndex = 1
        Me.lblSatID.Text = "ID"
        '
        'sateliteList
        '
        Me.sateliteList.FormattingEnabled = True
        Me.sateliteList.Location = New System.Drawing.Point(6, 6)
        Me.sateliteList.Name = "sateliteList"
        Me.sateliteList.Size = New System.Drawing.Size(237, 277)
        Me.sateliteList.TabIndex = 0
        '
        'tabEE
        '
        Me.tabEE.Controls.Add(Me.txtEEOrbAstro)
        Me.tabEE.Controls.Add(Me.txtEEOrbPerio)
        Me.tabEE.Controls.Add(Me.txtEEOrbInc)
        Me.tabEE.Controls.Add(Me.txtEEOrbPeria)
        Me.tabEE.Controls.Add(Me.txtEEOrbAp)
        Me.tabEE.Controls.Add(Me.lblEEOrbAstro)
        Me.tabEE.Controls.Add(Me.lblEEOrbPerio)
        Me.tabEE.Controls.Add(Me.lblEEOrbInc)
        Me.tabEE.Controls.Add(Me.lblEEOrbPeria)
        Me.tabEE.Controls.Add(Me.lblEEOrbAp)
        Me.tabEE.Controls.Add(Me.lblEEOrb)
        Me.tabEE.Controls.Add(Me.comboBoxEE)
        Me.tabEE.Controls.Add(Me.bttnEEPesq)
        Me.tabEE.Controls.Add(Me.txtEEPesq)
        Me.tabEE.Controls.Add(Me.txtCMEE)
        Me.tabEE.Controls.Add(Me.bttnEECan)
        Me.tabEE.Controls.Add(Me.bttnEEOK)
        Me.tabEE.Controls.Add(Me.bttnEEDel)
        Me.tabEE.Controls.Add(Me.bttnEEEdit)
        Me.tabEE.Controls.Add(Me.bttnEEAdd)
        Me.tabEE.Controls.Add(Me.lblEEStatus)
        Me.tabEE.Controls.Add(Me.lblCMEE)
        Me.tabEE.Controls.Add(Me.Label4)
        Me.tabEE.Controls.Add(Me.lblEEPaisOrg)
        Me.tabEE.Controls.Add(Me.lblEENome)
        Me.tabEE.Controls.Add(Me.txtEEStatus)
        Me.tabEE.Controls.Add(Me.txtEECompLog)
        Me.tabEE.Controls.Add(Me.txtEEPaisOrg)
        Me.tabEE.Controls.Add(Me.txtEENome)
        Me.tabEE.Controls.Add(Me.txtEEID)
        Me.tabEE.Controls.Add(Me.lblEEID)
        Me.tabEE.Controls.Add(Me.eeList)
        Me.tabEE.Location = New System.Drawing.Point(4, 22)
        Me.tabEE.Name = "tabEE"
        Me.tabEE.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEE.Size = New System.Drawing.Size(575, 325)
        Me.tabEE.TabIndex = 3
        Me.tabEE.Text = "Est. Espacial"
        Me.tabEE.UseVisualStyleBackColor = True
        '
        'txtEEOrbAstro
        '
        Me.txtEEOrbAstro.Location = New System.Drawing.Point(493, 139)
        Me.txtEEOrbAstro.Name = "txtEEOrbAstro"
        Me.txtEEOrbAstro.Size = New System.Drawing.Size(75, 20)
        Me.txtEEOrbAstro.TabIndex = 32
        '
        'txtEEOrbPerio
        '
        Me.txtEEOrbPerio.Location = New System.Drawing.Point(493, 113)
        Me.txtEEOrbPerio.Name = "txtEEOrbPerio"
        Me.txtEEOrbPerio.Size = New System.Drawing.Size(75, 20)
        Me.txtEEOrbPerio.TabIndex = 31
        '
        'txtEEOrbInc
        '
        Me.txtEEOrbInc.Location = New System.Drawing.Point(493, 86)
        Me.txtEEOrbInc.Name = "txtEEOrbInc"
        Me.txtEEOrbInc.Size = New System.Drawing.Size(75, 20)
        Me.txtEEOrbInc.TabIndex = 30
        '
        'txtEEOrbPeria
        '
        Me.txtEEOrbPeria.Location = New System.Drawing.Point(493, 60)
        Me.txtEEOrbPeria.Name = "txtEEOrbPeria"
        Me.txtEEOrbPeria.Size = New System.Drawing.Size(76, 20)
        Me.txtEEOrbPeria.TabIndex = 29
        '
        'txtEEOrbAp
        '
        Me.txtEEOrbAp.Location = New System.Drawing.Point(493, 34)
        Me.txtEEOrbAp.Name = "txtEEOrbAp"
        Me.txtEEOrbAp.Size = New System.Drawing.Size(76, 20)
        Me.txtEEOrbAp.TabIndex = 28
        '
        'lblEEOrbAstro
        '
        Me.lblEEOrbAstro.AutoSize = True
        Me.lblEEOrbAstro.Location = New System.Drawing.Point(445, 142)
        Me.lblEEOrbAstro.Name = "lblEEOrbAstro"
        Me.lblEEOrbAstro.Size = New System.Drawing.Size(31, 13)
        Me.lblEEOrbAstro.TabIndex = 27
        Me.lblEEOrbAstro.Text = "Astro"
        '
        'lblEEOrbPerio
        '
        Me.lblEEOrbPerio.AutoSize = True
        Me.lblEEOrbPerio.Location = New System.Drawing.Point(445, 116)
        Me.lblEEOrbPerio.Name = "lblEEOrbPerio"
        Me.lblEEOrbPerio.Size = New System.Drawing.Size(43, 13)
        Me.lblEEOrbPerio.TabIndex = 26
        Me.lblEEOrbPerio.Text = "Periodo"
        '
        'lblEEOrbInc
        '
        Me.lblEEOrbInc.AutoSize = True
        Me.lblEEOrbInc.Location = New System.Drawing.Point(445, 89)
        Me.lblEEOrbInc.Name = "lblEEOrbInc"
        Me.lblEEOrbInc.Size = New System.Drawing.Size(35, 13)
        Me.lblEEOrbInc.TabIndex = 25
        Me.lblEEOrbInc.Text = "Inclin."
        '
        'lblEEOrbPeria
        '
        Me.lblEEOrbPeria.AutoSize = True
        Me.lblEEOrbPeria.Location = New System.Drawing.Point(445, 63)
        Me.lblEEOrbPeria.Name = "lblEEOrbPeria"
        Me.lblEEOrbPeria.Size = New System.Drawing.Size(48, 13)
        Me.lblEEOrbPeria.TabIndex = 24
        Me.lblEEOrbPeria.Text = "Periastro"
        '
        'lblEEOrbAp
        '
        Me.lblEEOrbAp.AutoSize = True
        Me.lblEEOrbAp.Location = New System.Drawing.Point(445, 37)
        Me.lblEEOrbAp.Name = "lblEEOrbAp"
        Me.lblEEOrbAp.Size = New System.Drawing.Size(49, 13)
        Me.lblEEOrbAp.TabIndex = 23
        Me.lblEEOrbAp.Text = "Apoastro"
        '
        'lblEEOrb
        '
        Me.lblEEOrb.AutoSize = True
        Me.lblEEOrb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEEOrb.Location = New System.Drawing.Point(493, 13)
        Me.lblEEOrb.Name = "lblEEOrb"
        Me.lblEEOrb.Size = New System.Drawing.Size(41, 13)
        Me.lblEEOrb.TabIndex = 22
        Me.lblEEOrb.Text = "Orbita"
        '
        'comboBoxEE
        '
        Me.comboBoxEE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxEE.FormattingEnabled = True
        Me.comboBoxEE.Items.AddRange(New Object() {"Nome", "ID"})
        Me.comboBoxEE.Location = New System.Drawing.Point(468, 235)
        Me.comboBoxEE.Name = "comboBoxEE"
        Me.comboBoxEE.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxEE.TabIndex = 21
        '
        'bttnEEPesq
        '
        Me.bttnEEPesq.Location = New System.Drawing.Point(493, 288)
        Me.bttnEEPesq.Name = "bttnEEPesq"
        Me.bttnEEPesq.Size = New System.Drawing.Size(75, 23)
        Me.bttnEEPesq.TabIndex = 20
        Me.bttnEEPesq.Text = "Pesquisar"
        Me.bttnEEPesq.UseVisualStyleBackColor = True
        '
        'txtEEPesq
        '
        Me.txtEEPesq.Location = New System.Drawing.Point(468, 262)
        Me.txtEEPesq.Name = "txtEEPesq"
        Me.txtEEPesq.Size = New System.Drawing.Size(100, 20)
        Me.txtEEPesq.TabIndex = 19
        '
        'txtCMEE
        '
        Me.txtCMEE.Location = New System.Drawing.Point(335, 197)
        Me.txtCMEE.Name = "txtCMEE"
        Me.txtCMEE.Size = New System.Drawing.Size(100, 86)
        Me.txtCMEE.TabIndex = 18
        Me.txtCMEE.Text = ""
        '
        'bttnEECan
        '
        Me.bttnEECan.Location = New System.Drawing.Point(360, 289)
        Me.bttnEECan.Name = "bttnEECan"
        Me.bttnEECan.Size = New System.Drawing.Size(75, 23)
        Me.bttnEECan.TabIndex = 17
        Me.bttnEECan.Text = "CANCELAR"
        Me.bttnEECan.UseVisualStyleBackColor = True
        '
        'bttnEEOK
        '
        Me.bttnEEOK.Location = New System.Drawing.Point(279, 289)
        Me.bttnEEOK.Name = "bttnEEOK"
        Me.bttnEEOK.Size = New System.Drawing.Size(75, 23)
        Me.bttnEEOK.TabIndex = 16
        Me.bttnEEOK.Text = "OK"
        Me.bttnEEOK.UseVisualStyleBackColor = True
        '
        'bttnEEDel
        '
        Me.bttnEEDel.Location = New System.Drawing.Point(168, 289)
        Me.bttnEEDel.Name = "bttnEEDel"
        Me.bttnEEDel.Size = New System.Drawing.Size(75, 23)
        Me.bttnEEDel.TabIndex = 15
        Me.bttnEEDel.Text = "REMOVER"
        Me.bttnEEDel.UseVisualStyleBackColor = True
        '
        'bttnEEEdit
        '
        Me.bttnEEEdit.Location = New System.Drawing.Point(87, 289)
        Me.bttnEEEdit.Name = "bttnEEEdit"
        Me.bttnEEEdit.Size = New System.Drawing.Size(75, 23)
        Me.bttnEEEdit.TabIndex = 14
        Me.bttnEEEdit.Text = "EDITAR"
        Me.bttnEEEdit.UseVisualStyleBackColor = True
        '
        'bttnEEAdd
        '
        Me.bttnEEAdd.Location = New System.Drawing.Point(6, 289)
        Me.bttnEEAdd.Name = "bttnEEAdd"
        Me.bttnEEAdd.Size = New System.Drawing.Size(75, 23)
        Me.bttnEEAdd.TabIndex = 13
        Me.bttnEEAdd.Text = "INSERIR"
        Me.bttnEEAdd.UseVisualStyleBackColor = True
        '
        'lblEEStatus
        '
        Me.lblEEStatus.AutoSize = True
        Me.lblEEStatus.Location = New System.Drawing.Point(250, 144)
        Me.lblEEStatus.Name = "lblEEStatus"
        Me.lblEEStatus.Size = New System.Drawing.Size(37, 13)
        Me.lblEEStatus.TabIndex = 12
        Me.lblEEStatus.Text = "Status"
        '
        'lblCMEE
        '
        Me.lblCMEE.AutoSize = True
        Me.lblCMEE.Location = New System.Drawing.Point(250, 197)
        Me.lblCMEE.Name = "lblCMEE"
        Me.lblCMEE.Size = New System.Drawing.Size(61, 13)
        Me.lblCMEE.TabIndex = 11
        Me.lblCMEE.Text = "Comp. Mãe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(250, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Comp. Logística"
        '
        'lblEEPaisOrg
        '
        Me.lblEEPaisOrg.AutoSize = True
        Me.lblEEPaisOrg.Location = New System.Drawing.Point(250, 64)
        Me.lblEEPaisOrg.Name = "lblEEPaisOrg"
        Me.lblEEPaisOrg.Size = New System.Drawing.Size(54, 13)
        Me.lblEEPaisOrg.TabIndex = 9
        Me.lblEEPaisOrg.Text = "País/Org."
        '
        'lblEENome
        '
        Me.lblEENome.AutoSize = True
        Me.lblEENome.Location = New System.Drawing.Point(250, 37)
        Me.lblEENome.Name = "lblEENome"
        Me.lblEENome.Size = New System.Drawing.Size(35, 13)
        Me.lblEENome.TabIndex = 8
        Me.lblEENome.Text = "Nome"
        '
        'txtEEStatus
        '
        Me.txtEEStatus.Location = New System.Drawing.Point(335, 141)
        Me.txtEEStatus.Name = "txtEEStatus"
        Me.txtEEStatus.Size = New System.Drawing.Size(100, 20)
        Me.txtEEStatus.TabIndex = 6
        '
        'txtEECompLog
        '
        Me.txtEECompLog.Location = New System.Drawing.Point(335, 88)
        Me.txtEECompLog.Name = "txtEECompLog"
        Me.txtEECompLog.Size = New System.Drawing.Size(100, 20)
        Me.txtEECompLog.TabIndex = 5
        '
        'txtEEPaisOrg
        '
        Me.txtEEPaisOrg.Location = New System.Drawing.Point(335, 61)
        Me.txtEEPaisOrg.Name = "txtEEPaisOrg"
        Me.txtEEPaisOrg.Size = New System.Drawing.Size(100, 20)
        Me.txtEEPaisOrg.TabIndex = 4
        '
        'txtEENome
        '
        Me.txtEENome.Location = New System.Drawing.Point(335, 34)
        Me.txtEENome.Name = "txtEENome"
        Me.txtEENome.Size = New System.Drawing.Size(100, 20)
        Me.txtEENome.TabIndex = 3
        '
        'txtEEID
        '
        Me.txtEEID.Location = New System.Drawing.Point(335, 7)
        Me.txtEEID.Name = "txtEEID"
        Me.txtEEID.Size = New System.Drawing.Size(100, 20)
        Me.txtEEID.TabIndex = 2
        '
        'lblEEID
        '
        Me.lblEEID.AutoSize = True
        Me.lblEEID.Location = New System.Drawing.Point(250, 10)
        Me.lblEEID.Name = "lblEEID"
        Me.lblEEID.Size = New System.Drawing.Size(18, 13)
        Me.lblEEID.TabIndex = 1
        Me.lblEEID.Text = "ID"
        '
        'eeList
        '
        Me.eeList.FormattingEnabled = True
        Me.eeList.Location = New System.Drawing.Point(6, 6)
        Me.eeList.Name = "eeList"
        Me.eeList.Size = New System.Drawing.Size(237, 277)
        Me.eeList.TabIndex = 0
        '
        'tabMee
        '
        Me.tabMee.Controls.Add(Me.txtMeePesq)
        Me.tabMee.Controls.Add(Me.comboBoxMee)
        Me.tabMee.Controls.Add(Me.bttnMeePesq)
        Me.tabMee.Controls.Add(Me.bttnMEECan)
        Me.tabMee.Controls.Add(Me.bttnMEEOK)
        Me.tabMee.Controls.Add(Me.bttnMEEDel)
        Me.tabMee.Controls.Add(Me.bttnMEEEdit)
        Me.tabMee.Controls.Add(Me.bttnMEEAdd)
        Me.tabMee.Controls.Add(Me.lblMeeEE)
        Me.tabMee.Controls.Add(Me.lblMeeLanc)
        Me.tabMee.Controls.Add(Me.lblMeeCompLog)
        Me.tabMee.Controls.Add(Me.lblMeeTipo)
        Me.tabMee.Controls.Add(Me.lblMeeNome)
        Me.tabMee.Controls.Add(Me.lblMeeID)
        Me.tabMee.Controls.Add(Me.txtMeeEE)
        Me.tabMee.Controls.Add(Me.txtMeeLanc)
        Me.tabMee.Controls.Add(Me.txtMeeCompLog)
        Me.tabMee.Controls.Add(Me.txtMeeTipo)
        Me.tabMee.Controls.Add(Me.txtMeeNome)
        Me.tabMee.Controls.Add(Me.txtMeeID)
        Me.tabMee.Controls.Add(Me.meeList)
        Me.tabMee.Location = New System.Drawing.Point(4, 22)
        Me.tabMee.Name = "tabMee"
        Me.tabMee.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMee.Size = New System.Drawing.Size(575, 325)
        Me.tabMee.TabIndex = 4
        Me.tabMee.Text = "Modulo EE"
        Me.tabMee.UseVisualStyleBackColor = True
        '
        'txtMeePesq
        '
        Me.txtMeePesq.Location = New System.Drawing.Point(468, 263)
        Me.txtMeePesq.Name = "txtMeePesq"
        Me.txtMeePesq.Size = New System.Drawing.Size(100, 20)
        Me.txtMeePesq.TabIndex = 20
        '
        'comboBoxMee
        '
        Me.comboBoxMee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxMee.FormattingEnabled = True
        Me.comboBoxMee.Items.AddRange(New Object() {"Nome", "ID"})
        Me.comboBoxMee.Location = New System.Drawing.Point(468, 236)
        Me.comboBoxMee.Name = "comboBoxMee"
        Me.comboBoxMee.Size = New System.Drawing.Size(100, 21)
        Me.comboBoxMee.TabIndex = 19
        '
        'bttnMeePesq
        '
        Me.bttnMeePesq.Location = New System.Drawing.Point(493, 289)
        Me.bttnMeePesq.Name = "bttnMeePesq"
        Me.bttnMeePesq.Size = New System.Drawing.Size(75, 23)
        Me.bttnMeePesq.TabIndex = 18
        Me.bttnMeePesq.Text = "Pesquisar"
        Me.bttnMeePesq.UseVisualStyleBackColor = True
        '
        'bttnMEECan
        '
        Me.bttnMEECan.Location = New System.Drawing.Point(362, 289)
        Me.bttnMEECan.Name = "bttnMEECan"
        Me.bttnMEECan.Size = New System.Drawing.Size(75, 23)
        Me.bttnMEECan.TabIndex = 17
        Me.bttnMEECan.Text = "CANCELAR"
        Me.bttnMEECan.UseVisualStyleBackColor = True
        '
        'bttnMEEOK
        '
        Me.bttnMEEOK.Location = New System.Drawing.Point(281, 289)
        Me.bttnMEEOK.Name = "bttnMEEOK"
        Me.bttnMEEOK.Size = New System.Drawing.Size(75, 23)
        Me.bttnMEEOK.TabIndex = 16
        Me.bttnMEEOK.Text = "OK"
        Me.bttnMEEOK.UseVisualStyleBackColor = True
        '
        'bttnMEEDel
        '
        Me.bttnMEEDel.Location = New System.Drawing.Point(168, 289)
        Me.bttnMEEDel.Name = "bttnMEEDel"
        Me.bttnMEEDel.Size = New System.Drawing.Size(75, 23)
        Me.bttnMEEDel.TabIndex = 15
        Me.bttnMEEDel.Text = "REMOVER"
        Me.bttnMEEDel.UseVisualStyleBackColor = True
        '
        'bttnMEEEdit
        '
        Me.bttnMEEEdit.Location = New System.Drawing.Point(87, 289)
        Me.bttnMEEEdit.Name = "bttnMEEEdit"
        Me.bttnMEEEdit.Size = New System.Drawing.Size(75, 23)
        Me.bttnMEEEdit.TabIndex = 14
        Me.bttnMEEEdit.Text = "EDITAR"
        Me.bttnMEEEdit.UseVisualStyleBackColor = True
        '
        'bttnMEEAdd
        '
        Me.bttnMEEAdd.Location = New System.Drawing.Point(6, 289)
        Me.bttnMEEAdd.Name = "bttnMEEAdd"
        Me.bttnMEEAdd.Size = New System.Drawing.Size(75, 23)
        Me.bttnMEEAdd.TabIndex = 13
        Me.bttnMEEAdd.Text = "INSERIR"
        Me.bttnMEEAdd.UseVisualStyleBackColor = True
        '
        'lblMeeEE
        '
        Me.lblMeeEE.AutoSize = True
        Me.lblMeeEE.Location = New System.Drawing.Point(250, 145)
        Me.lblMeeEE.Name = "lblMeeEE"
        Me.lblMeeEE.Size = New System.Drawing.Size(68, 13)
        Me.lblMeeEE.TabIndex = 12
        Me.lblMeeEE.Text = "Est. Espacial"
        '
        'lblMeeLanc
        '
        Me.lblMeeLanc.AutoSize = True
        Me.lblMeeLanc.Location = New System.Drawing.Point(250, 118)
        Me.lblMeeLanc.Name = "lblMeeLanc"
        Me.lblMeeLanc.Size = New System.Drawing.Size(66, 13)
        Me.lblMeeLanc.TabIndex = 11
        Me.lblMeeLanc.Text = "Lançamento"
        '
        'lblMeeCompLog
        '
        Me.lblMeeCompLog.AutoSize = True
        Me.lblMeeCompLog.Location = New System.Drawing.Point(250, 91)
        Me.lblMeeCompLog.Name = "lblMeeCompLog"
        Me.lblMeeCompLog.Size = New System.Drawing.Size(84, 13)
        Me.lblMeeCompLog.TabIndex = 10
        Me.lblMeeCompLog.Text = "Comp. Logística"
        '
        'lblMeeTipo
        '
        Me.lblMeeTipo.AutoSize = True
        Me.lblMeeTipo.Location = New System.Drawing.Point(250, 64)
        Me.lblMeeTipo.Name = "lblMeeTipo"
        Me.lblMeeTipo.Size = New System.Drawing.Size(28, 13)
        Me.lblMeeTipo.TabIndex = 9
        Me.lblMeeTipo.Text = "Tipo"
        '
        'lblMeeNome
        '
        Me.lblMeeNome.AutoSize = True
        Me.lblMeeNome.Location = New System.Drawing.Point(250, 37)
        Me.lblMeeNome.Name = "lblMeeNome"
        Me.lblMeeNome.Size = New System.Drawing.Size(35, 13)
        Me.lblMeeNome.TabIndex = 8
        Me.lblMeeNome.Text = "Nome"
        '
        'lblMeeID
        '
        Me.lblMeeID.AutoSize = True
        Me.lblMeeID.Location = New System.Drawing.Point(250, 10)
        Me.lblMeeID.Name = "lblMeeID"
        Me.lblMeeID.Size = New System.Drawing.Size(18, 13)
        Me.lblMeeID.TabIndex = 7
        Me.lblMeeID.Text = "ID"
        '
        'txtMeeEE
        '
        Me.txtMeeEE.Location = New System.Drawing.Point(337, 142)
        Me.txtMeeEE.Name = "txtMeeEE"
        Me.txtMeeEE.Size = New System.Drawing.Size(100, 20)
        Me.txtMeeEE.TabIndex = 6
        '
        'txtMeeLanc
        '
        Me.txtMeeLanc.Location = New System.Drawing.Point(337, 115)
        Me.txtMeeLanc.Name = "txtMeeLanc"
        Me.txtMeeLanc.Size = New System.Drawing.Size(100, 20)
        Me.txtMeeLanc.TabIndex = 5
        '
        'txtMeeCompLog
        '
        Me.txtMeeCompLog.Location = New System.Drawing.Point(337, 88)
        Me.txtMeeCompLog.Name = "txtMeeCompLog"
        Me.txtMeeCompLog.Size = New System.Drawing.Size(100, 20)
        Me.txtMeeCompLog.TabIndex = 4
        '
        'txtMeeTipo
        '
        Me.txtMeeTipo.Location = New System.Drawing.Point(337, 61)
        Me.txtMeeTipo.Name = "txtMeeTipo"
        Me.txtMeeTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtMeeTipo.TabIndex = 3
        '
        'txtMeeNome
        '
        Me.txtMeeNome.Location = New System.Drawing.Point(337, 34)
        Me.txtMeeNome.Name = "txtMeeNome"
        Me.txtMeeNome.Size = New System.Drawing.Size(100, 20)
        Me.txtMeeNome.TabIndex = 2
        '
        'txtMeeID
        '
        Me.txtMeeID.Location = New System.Drawing.Point(337, 7)
        Me.txtMeeID.Name = "txtMeeID"
        Me.txtMeeID.Size = New System.Drawing.Size(100, 20)
        Me.txtMeeID.TabIndex = 1
        '
        'meeList
        '
        Me.meeList.FormattingEnabled = True
        Me.meeList.Location = New System.Drawing.Point(6, 6)
        Me.meeList.Name = "meeList"
        Me.meeList.Size = New System.Drawing.Size(237, 277)
        Me.meeList.TabIndex = 0
        '
        'tabOrbita
        '
        Me.tabOrbita.Controls.Add(Me.txtOrbPesq)
        Me.tabOrbita.Controls.Add(Me.bttnOrbPesq)
        Me.tabOrbita.Controls.Add(Me.bttnOrbCan)
        Me.tabOrbita.Controls.Add(Me.bttnOrbOK)
        Me.tabOrbita.Controls.Add(Me.bttnOrbDel)
        Me.tabOrbita.Controls.Add(Me.bttnOrbEdit)
        Me.tabOrbita.Controls.Add(Me.lblOrbAstro)
        Me.tabOrbita.Controls.Add(Me.lblOrbPer)
        Me.tabOrbita.Controls.Add(Me.lblOrbIn)
        Me.tabOrbita.Controls.Add(Me.lblOrbPe)
        Me.tabOrbita.Controls.Add(Me.lblOrbAp)
        Me.tabOrbita.Controls.Add(Me.lblOrbID)
        Me.tabOrbita.Controls.Add(Me.txtOrbAstro)
        Me.tabOrbita.Controls.Add(Me.txtOrbPer)
        Me.tabOrbita.Controls.Add(Me.txtOrbIn)
        Me.tabOrbita.Controls.Add(Me.txtOrbPe)
        Me.tabOrbita.Controls.Add(Me.txtOrbAp)
        Me.tabOrbita.Controls.Add(Me.txtOrbID)
        Me.tabOrbita.Controls.Add(Me.orbList)
        Me.tabOrbita.Location = New System.Drawing.Point(4, 22)
        Me.tabOrbita.Name = "tabOrbita"
        Me.tabOrbita.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOrbita.Size = New System.Drawing.Size(575, 325)
        Me.tabOrbita.TabIndex = 5
        Me.tabOrbita.Text = "Orbita"
        Me.tabOrbita.UseVisualStyleBackColor = True
        '
        'txtOrbPesq
        '
        Me.txtOrbPesq.Location = New System.Drawing.Point(468, 263)
        Me.txtOrbPesq.Name = "txtOrbPesq"
        Me.txtOrbPesq.Size = New System.Drawing.Size(100, 20)
        Me.txtOrbPesq.TabIndex = 20
        '
        'bttnOrbPesq
        '
        Me.bttnOrbPesq.Location = New System.Drawing.Point(493, 289)
        Me.bttnOrbPesq.Name = "bttnOrbPesq"
        Me.bttnOrbPesq.Size = New System.Drawing.Size(75, 23)
        Me.bttnOrbPesq.TabIndex = 18
        Me.bttnOrbPesq.Text = "Pesquisar"
        Me.bttnOrbPesq.UseVisualStyleBackColor = True
        '
        'bttnOrbCan
        '
        Me.bttnOrbCan.Location = New System.Drawing.Point(346, 289)
        Me.bttnOrbCan.Name = "bttnOrbCan"
        Me.bttnOrbCan.Size = New System.Drawing.Size(75, 23)
        Me.bttnOrbCan.TabIndex = 17
        Me.bttnOrbCan.Text = "CANCELAR"
        Me.bttnOrbCan.UseVisualStyleBackColor = True
        '
        'bttnOrbOK
        '
        Me.bttnOrbOK.Location = New System.Drawing.Point(265, 289)
        Me.bttnOrbOK.Name = "bttnOrbOK"
        Me.bttnOrbOK.Size = New System.Drawing.Size(75, 23)
        Me.bttnOrbOK.TabIndex = 16
        Me.bttnOrbOK.Text = "OK"
        Me.bttnOrbOK.UseVisualStyleBackColor = True
        '
        'bttnOrbDel
        '
        Me.bttnOrbDel.Location = New System.Drawing.Point(168, 289)
        Me.bttnOrbDel.Name = "bttnOrbDel"
        Me.bttnOrbDel.Size = New System.Drawing.Size(75, 23)
        Me.bttnOrbDel.TabIndex = 15
        Me.bttnOrbDel.Text = "REMOVER"
        Me.bttnOrbDel.UseVisualStyleBackColor = True
        '
        'bttnOrbEdit
        '
        Me.bttnOrbEdit.Location = New System.Drawing.Point(87, 289)
        Me.bttnOrbEdit.Name = "bttnOrbEdit"
        Me.bttnOrbEdit.Size = New System.Drawing.Size(75, 23)
        Me.bttnOrbEdit.TabIndex = 14
        Me.bttnOrbEdit.Text = "EDITAR"
        Me.bttnOrbEdit.UseVisualStyleBackColor = True
        '
        'lblOrbAstro
        '
        Me.lblOrbAstro.AutoSize = True
        Me.lblOrbAstro.Location = New System.Drawing.Point(250, 145)
        Me.lblOrbAstro.Name = "lblOrbAstro"
        Me.lblOrbAstro.Size = New System.Drawing.Size(31, 13)
        Me.lblOrbAstro.TabIndex = 12
        Me.lblOrbAstro.Text = "Astro"
        '
        'lblOrbPer
        '
        Me.lblOrbPer.AutoSize = True
        Me.lblOrbPer.Location = New System.Drawing.Point(250, 118)
        Me.lblOrbPer.Name = "lblOrbPer"
        Me.lblOrbPer.Size = New System.Drawing.Size(45, 13)
        Me.lblOrbPer.TabIndex = 11
        Me.lblOrbPer.Text = "Período"
        '
        'lblOrbIn
        '
        Me.lblOrbIn.AutoSize = True
        Me.lblOrbIn.Location = New System.Drawing.Point(250, 91)
        Me.lblOrbIn.Name = "lblOrbIn"
        Me.lblOrbIn.Size = New System.Drawing.Size(56, 13)
        Me.lblOrbIn.TabIndex = 10
        Me.lblOrbIn.Text = "Inclinação"
        '
        'lblOrbPe
        '
        Me.lblOrbPe.AutoSize = True
        Me.lblOrbPe.Location = New System.Drawing.Point(250, 64)
        Me.lblOrbPe.Name = "lblOrbPe"
        Me.lblOrbPe.Size = New System.Drawing.Size(48, 13)
        Me.lblOrbPe.TabIndex = 9
        Me.lblOrbPe.Text = "Periastro"
        '
        'lblOrbAp
        '
        Me.lblOrbAp.AutoSize = True
        Me.lblOrbAp.Location = New System.Drawing.Point(250, 37)
        Me.lblOrbAp.Name = "lblOrbAp"
        Me.lblOrbAp.Size = New System.Drawing.Size(49, 13)
        Me.lblOrbAp.TabIndex = 8
        Me.lblOrbAp.Text = "Apoastro"
        '
        'lblOrbID
        '
        Me.lblOrbID.AutoSize = True
        Me.lblOrbID.Location = New System.Drawing.Point(250, 10)
        Me.lblOrbID.Name = "lblOrbID"
        Me.lblOrbID.Size = New System.Drawing.Size(18, 13)
        Me.lblOrbID.TabIndex = 7
        Me.lblOrbID.Text = "ID"
        '
        'txtOrbAstro
        '
        Me.txtOrbAstro.Location = New System.Drawing.Point(321, 142)
        Me.txtOrbAstro.Name = "txtOrbAstro"
        Me.txtOrbAstro.Size = New System.Drawing.Size(100, 20)
        Me.txtOrbAstro.TabIndex = 6
        '
        'txtOrbPer
        '
        Me.txtOrbPer.Location = New System.Drawing.Point(321, 115)
        Me.txtOrbPer.Name = "txtOrbPer"
        Me.txtOrbPer.Size = New System.Drawing.Size(100, 20)
        Me.txtOrbPer.TabIndex = 5
        '
        'txtOrbIn
        '
        Me.txtOrbIn.Location = New System.Drawing.Point(321, 88)
        Me.txtOrbIn.Name = "txtOrbIn"
        Me.txtOrbIn.Size = New System.Drawing.Size(100, 20)
        Me.txtOrbIn.TabIndex = 4
        '
        'txtOrbPe
        '
        Me.txtOrbPe.Location = New System.Drawing.Point(321, 61)
        Me.txtOrbPe.Name = "txtOrbPe"
        Me.txtOrbPe.Size = New System.Drawing.Size(100, 20)
        Me.txtOrbPe.TabIndex = 3
        '
        'txtOrbAp
        '
        Me.txtOrbAp.Location = New System.Drawing.Point(321, 34)
        Me.txtOrbAp.Name = "txtOrbAp"
        Me.txtOrbAp.Size = New System.Drawing.Size(100, 20)
        Me.txtOrbAp.TabIndex = 2
        '
        'txtOrbID
        '
        Me.txtOrbID.Location = New System.Drawing.Point(321, 7)
        Me.txtOrbID.Name = "txtOrbID"
        Me.txtOrbID.Size = New System.Drawing.Size(100, 20)
        Me.txtOrbID.TabIndex = 1
        '
        'orbList
        '
        Me.orbList.FormattingEnabled = True
        Me.orbList.Location = New System.Drawing.Point(6, 6)
        Me.orbList.Name = "orbList"
        Me.orbList.Size = New System.Drawing.Size(237, 277)
        Me.orbList.TabIndex = 0
        '
        'tabLanc
        '
        Me.tabLanc.Controls.Add(Me.txtLancObj)
        Me.tabLanc.Controls.Add(Me.lblLancObj)
        Me.tabLanc.Controls.Add(Me.txtLancPesq)
        Me.tabLanc.Controls.Add(Me.bttnLancPesq)
        Me.tabLanc.Controls.Add(Me.bttnLanCan)
        Me.tabLanc.Controls.Add(Me.bttnLanOK)
        Me.tabLanc.Controls.Add(Me.bttnLanDel)
        Me.tabLanc.Controls.Add(Me.bttnLanEdit)
        Me.tabLanc.Controls.Add(Me.bttnLanAdd)
        Me.tabLanc.Controls.Add(Me.txtLancVeicCL)
        Me.tabLanc.Controls.Add(Me.lblLancVeicCL)
        Me.tabLanc.Controls.Add(Me.lblLancVeicN)
        Me.tabLanc.Controls.Add(Me.lblLancDT)
        Me.tabLanc.Controls.Add(Me.lblLancPais)
        Me.tabLanc.Controls.Add(Me.lblLancCoord)
        Me.tabLanc.Controls.Add(Me.lblLancID)
        Me.tabLanc.Controls.Add(Me.txtLancVeicN)
        Me.tabLanc.Controls.Add(Me.txtLancDT)
        Me.tabLanc.Controls.Add(Me.txtLancPais)
        Me.tabLanc.Controls.Add(Me.txtLancCoord)
        Me.tabLanc.Controls.Add(Me.txtLancID)
        Me.tabLanc.Controls.Add(Me.lancList)
        Me.tabLanc.Location = New System.Drawing.Point(4, 22)
        Me.tabLanc.Name = "tabLanc"
        Me.tabLanc.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLanc.Size = New System.Drawing.Size(575, 325)
        Me.tabLanc.TabIndex = 7
        Me.tabLanc.Text = "Lançamento"
        Me.tabLanc.UseVisualStyleBackColor = True
        '
        'txtLancObj
        '
        Me.txtLancObj.Location = New System.Drawing.Point(340, 193)
        Me.txtLancObj.Name = "txtLancObj"
        Me.txtLancObj.Size = New System.Drawing.Size(131, 20)
        Me.txtLancObj.TabIndex = 21
        '
        'lblLancObj
        '
        Me.lblLancObj.AutoSize = True
        Me.lblLancObj.Location = New System.Drawing.Point(255, 193)
        Me.lblLancObj.Name = "lblLancObj"
        Me.lblLancObj.Size = New System.Drawing.Size(58, 13)
        Me.lblLancObj.TabIndex = 20
        Me.lblLancObj.Text = "ID Objecto"
        '
        'txtLancPesq
        '
        Me.txtLancPesq.Location = New System.Drawing.Point(468, 263)
        Me.txtLancPesq.Name = "txtLancPesq"
        Me.txtLancPesq.Size = New System.Drawing.Size(100, 20)
        Me.txtLancPesq.TabIndex = 19
        '
        'bttnLancPesq
        '
        Me.bttnLancPesq.Location = New System.Drawing.Point(493, 289)
        Me.bttnLancPesq.Name = "bttnLancPesq"
        Me.bttnLancPesq.Size = New System.Drawing.Size(75, 23)
        Me.bttnLancPesq.TabIndex = 18
        Me.bttnLancPesq.Text = "Pesquisar"
        Me.bttnLancPesq.UseVisualStyleBackColor = True
        '
        'bttnLanCan
        '
        Me.bttnLanCan.Location = New System.Drawing.Point(365, 289)
        Me.bttnLanCan.Name = "bttnLanCan"
        Me.bttnLanCan.Size = New System.Drawing.Size(75, 23)
        Me.bttnLanCan.TabIndex = 17
        Me.bttnLanCan.Text = "CANCELAR"
        Me.bttnLanCan.UseVisualStyleBackColor = True
        '
        'bttnLanOK
        '
        Me.bttnLanOK.Location = New System.Drawing.Point(284, 289)
        Me.bttnLanOK.Name = "bttnLanOK"
        Me.bttnLanOK.Size = New System.Drawing.Size(75, 23)
        Me.bttnLanOK.TabIndex = 16
        Me.bttnLanOK.Text = "OK"
        Me.bttnLanOK.UseVisualStyleBackColor = True
        '
        'bttnLanDel
        '
        Me.bttnLanDel.Location = New System.Drawing.Point(168, 289)
        Me.bttnLanDel.Name = "bttnLanDel"
        Me.bttnLanDel.Size = New System.Drawing.Size(75, 23)
        Me.bttnLanDel.TabIndex = 15
        Me.bttnLanDel.Text = "REMOVER"
        Me.bttnLanDel.UseVisualStyleBackColor = True
        '
        'bttnLanEdit
        '
        Me.bttnLanEdit.Location = New System.Drawing.Point(87, 289)
        Me.bttnLanEdit.Name = "bttnLanEdit"
        Me.bttnLanEdit.Size = New System.Drawing.Size(75, 23)
        Me.bttnLanEdit.TabIndex = 14
        Me.bttnLanEdit.Text = "EDITAR"
        Me.bttnLanEdit.UseVisualStyleBackColor = True
        '
        'bttnLanAdd
        '
        Me.bttnLanAdd.Location = New System.Drawing.Point(6, 289)
        Me.bttnLanAdd.Name = "bttnLanAdd"
        Me.bttnLanAdd.Size = New System.Drawing.Size(75, 23)
        Me.bttnLanAdd.TabIndex = 13
        Me.bttnLanAdd.Text = "INSERIR"
        Me.bttnLanAdd.UseVisualStyleBackColor = True
        '
        'txtLancVeicCL
        '
        Me.txtLancVeicCL.Location = New System.Drawing.Point(340, 140)
        Me.txtLancVeicCL.Name = "txtLancVeicCL"
        Me.txtLancVeicCL.Size = New System.Drawing.Size(131, 20)
        Me.txtLancVeicCL.TabIndex = 12
        '
        'lblLancVeicCL
        '
        Me.lblLancVeicCL.AutoSize = True
        Me.lblLancVeicCL.Location = New System.Drawing.Point(252, 143)
        Me.lblLancVeicCL.Name = "lblLancVeicCL"
        Me.lblLancVeicCL.Size = New System.Drawing.Size(84, 13)
        Me.lblLancVeicCL.TabIndex = 11
        Me.lblLancVeicCL.Text = "Comp. Logística"
        '
        'lblLancVeicN
        '
        Me.lblLancVeicN.AutoSize = True
        Me.lblLancVeicN.Location = New System.Drawing.Point(249, 117)
        Me.lblLancVeicN.Name = "lblLancVeicN"
        Me.lblLancVeicN.Size = New System.Drawing.Size(44, 13)
        Me.lblLancVeicN.TabIndex = 10
        Me.lblLancVeicN.Text = "Veículo"
        '
        'lblLancDT
        '
        Me.lblLancDT.AutoSize = True
        Me.lblLancDT.Location = New System.Drawing.Point(249, 90)
        Me.lblLancDT.Name = "lblLancDT"
        Me.lblLancDT.Size = New System.Drawing.Size(65, 13)
        Me.lblLancDT.TabIndex = 9
        Me.lblLancDT.Text = "Data e Hora"
        '
        'lblLancPais
        '
        Me.lblLancPais.AutoSize = True
        Me.lblLancPais.Location = New System.Drawing.Point(249, 63)
        Me.lblLancPais.Name = "lblLancPais"
        Me.lblLancPais.Size = New System.Drawing.Size(29, 13)
        Me.lblLancPais.TabIndex = 8
        Me.lblLancPais.Text = "País"
        '
        'lblLancCoord
        '
        Me.lblLancCoord.AutoSize = True
        Me.lblLancCoord.Location = New System.Drawing.Point(249, 36)
        Me.lblLancCoord.Name = "lblLancCoord"
        Me.lblLancCoord.Size = New System.Drawing.Size(70, 13)
        Me.lblLancCoord.TabIndex = 7
        Me.lblLancCoord.Text = "Coordenadas"
        '
        'lblLancID
        '
        Me.lblLancID.AutoSize = True
        Me.lblLancID.Location = New System.Drawing.Point(249, 9)
        Me.lblLancID.Name = "lblLancID"
        Me.lblLancID.Size = New System.Drawing.Size(18, 13)
        Me.lblLancID.TabIndex = 6
        Me.lblLancID.Text = "ID"
        '
        'txtLancVeicN
        '
        Me.txtLancVeicN.Location = New System.Drawing.Point(340, 114)
        Me.txtLancVeicN.Name = "txtLancVeicN"
        Me.txtLancVeicN.Size = New System.Drawing.Size(131, 20)
        Me.txtLancVeicN.TabIndex = 5
        '
        'txtLancDT
        '
        Me.txtLancDT.Location = New System.Drawing.Point(340, 86)
        Me.txtLancDT.Name = "txtLancDT"
        Me.txtLancDT.Size = New System.Drawing.Size(131, 20)
        Me.txtLancDT.TabIndex = 4
        '
        'txtLancPais
        '
        Me.txtLancPais.Location = New System.Drawing.Point(340, 59)
        Me.txtLancPais.Name = "txtLancPais"
        Me.txtLancPais.Size = New System.Drawing.Size(131, 20)
        Me.txtLancPais.TabIndex = 3
        '
        'txtLancCoord
        '
        Me.txtLancCoord.Location = New System.Drawing.Point(340, 32)
        Me.txtLancCoord.Name = "txtLancCoord"
        Me.txtLancCoord.Size = New System.Drawing.Size(131, 20)
        Me.txtLancCoord.TabIndex = 2
        '
        'txtLancID
        '
        Me.txtLancID.Location = New System.Drawing.Point(340, 6)
        Me.txtLancID.Name = "txtLancID"
        Me.txtLancID.Size = New System.Drawing.Size(131, 20)
        Me.txtLancID.TabIndex = 1
        '
        'lancList
        '
        Me.lancList.FormattingEnabled = True
        Me.lancList.Location = New System.Drawing.Point(6, 6)
        Me.lancList.Name = "lancList"
        Me.lancList.Size = New System.Drawing.Size(237, 277)
        Me.lancList.TabIndex = 0
        '
        'tabPesquisa
        '
        Me.tabPesquisa.Controls.Add(Me.lblPesq)
        Me.tabPesquisa.Controls.Add(Me.comboBoxPesq)
        Me.tabPesquisa.Controls.Add(Me.radioBttnPesq2)
        Me.tabPesquisa.Controls.Add(Me.radioBttnPesq1)
        Me.tabPesquisa.Controls.Add(Me.txtPesqPesq)
        Me.tabPesquisa.Controls.Add(Me.bttnPesqPesq)
        Me.tabPesquisa.Controls.Add(Me.DataGridView1)
        Me.tabPesquisa.Location = New System.Drawing.Point(4, 22)
        Me.tabPesquisa.Name = "tabPesquisa"
        Me.tabPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPesquisa.Size = New System.Drawing.Size(575, 325)
        Me.tabPesquisa.TabIndex = 8
        Me.tabPesquisa.Text = "Pesquisa"
        Me.tabPesquisa.UseVisualStyleBackColor = True
        '
        'lblPesq
        '
        Me.lblPesq.AutoSize = True
        Me.lblPesq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPesq.Location = New System.Drawing.Point(43, 295)
        Me.lblPesq.Name = "lblPesq"
        Me.lblPesq.Size = New System.Drawing.Size(51, 15)
        Me.lblPesq.TabIndex = 7
        Me.lblPesq.Text = "Label1"
        '
        'comboBoxPesq
        '
        Me.comboBoxPesq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxPesq.FormattingEnabled = True
        Me.comboBoxPesq.Items.AddRange(New Object() {"Lancamentos", "Modulos", "Orb/Obj", "Sat/EE", "CompMae", "CompLog"})
        Me.comboBoxPesq.Location = New System.Drawing.Point(391, 15)
        Me.comboBoxPesq.Name = "comboBoxPesq"
        Me.comboBoxPesq.Size = New System.Drawing.Size(149, 21)
        Me.comboBoxPesq.TabIndex = 6
        '
        'radioBttnPesq2
        '
        Me.radioBttnPesq2.AutoSize = True
        Me.radioBttnPesq2.Location = New System.Drawing.Point(142, 44)
        Me.radioBttnPesq2.Name = "radioBttnPesq2"
        Me.radioBttnPesq2.Size = New System.Drawing.Size(90, 17)
        Me.radioBttnPesq2.TabIndex = 5
        Me.radioBttnPesq2.Text = "RadioButton2"
        Me.radioBttnPesq2.UseVisualStyleBackColor = True
        '
        'radioBttnPesq1
        '
        Me.radioBttnPesq1.AutoSize = True
        Me.radioBttnPesq1.Checked = True
        Me.radioBttnPesq1.Location = New System.Drawing.Point(56, 44)
        Me.radioBttnPesq1.Name = "radioBttnPesq1"
        Me.radioBttnPesq1.Size = New System.Drawing.Size(90, 17)
        Me.radioBttnPesq1.TabIndex = 4
        Me.radioBttnPesq1.TabStop = True
        Me.radioBttnPesq1.Text = "RadioButton1"
        Me.radioBttnPesq1.UseVisualStyleBackColor = True
        '
        'txtPesqPesq
        '
        Me.txtPesqPesq.Location = New System.Drawing.Point(46, 15)
        Me.txtPesqPesq.Name = "txtPesqPesq"
        Me.txtPesqPesq.Size = New System.Drawing.Size(202, 20)
        Me.txtPesqPesq.TabIndex = 3
        '
        'bttnPesqPesq
        '
        Me.bttnPesqPesq.Location = New System.Drawing.Point(254, 13)
        Me.bttnPesqPesq.Name = "bttnPesqPesq"
        Me.bttnPesqPesq.Size = New System.Drawing.Size(96, 23)
        Me.bttnPesqPesq.TabIndex = 2
        Me.bttnPesqPesq.Text = "Pesquisar"
        Me.bttnPesqPesq.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(497, 221)
        Me.DataGridView1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 353)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "MORSA"
        Me.TabControl1.ResumeLayout(False)
        Me.tabAstro.ResumeLayout(False)
        Me.tabAstro.PerformLayout()
        Me.tabCompanhia.ResumeLayout(False)
        Me.tabCompanhia.PerformLayout()
        Me.tabSatelite.ResumeLayout(False)
        Me.tabSatelite.PerformLayout()
        Me.tabEE.ResumeLayout(False)
        Me.tabEE.PerformLayout()
        Me.tabMee.ResumeLayout(False)
        Me.tabMee.PerformLayout()
        Me.tabOrbita.ResumeLayout(False)
        Me.tabOrbita.PerformLayout()
        Me.tabLanc.ResumeLayout(False)
        Me.tabLanc.PerformLayout()
        Me.tabPesquisa.ResumeLayout(False)
        Me.tabPesquisa.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents astroList As ListBox
    Friend WithEvents txtAstroID As TextBox
    Friend WithEvents bttnAstroAdd As Button
    Friend WithEvents bttnAstroDel As Button
    Friend WithEvents bttnAstroEdit As Button
    Friend WithEvents lblAstroID As Label
    Friend WithEvents lblAstroType As Label
    Friend WithEvents lblAstroSystem As Label
    Friend WithEvents lblAstroGalaxy As Label
    Friend WithEvents txtAstroType As TextBox
    Friend WithEvents txtAstroSystem As TextBox
    Friend WithEvents txtAstroGalaxy As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabAstro As TabPage
    Friend WithEvents tabCompanhia As TabPage
    Friend WithEvents companhiaList As ListBox
    Friend WithEvents txtCompSede As TextBox
    Friend WithEvents txtCompCodPos As TextBox
    Friend WithEvents txtCompEnder As TextBox
    Friend WithEvents txtCompTelef As TextBox
    Friend WithEvents txtCompNIF As TextBox
    Friend WithEvents txtCompName As TextBox
    Friend WithEvents lblCompPSede As Label
    Friend WithEvents lblCompCodP As Label
    Friend WithEvents lblCompEnder As Label
    Friend WithEvents lblCompTelef As Label
    Friend WithEvents lblCompNIF As Label
    Friend WithEvents lblCompNome As Label
    Friend WithEvents tabSatelite As TabPage
    Friend WithEvents txtSatLanc As TextBox
    Friend WithEvents lblSatLanc As Label
    Friend WithEvents txtSatCompLog As TextBox
    Friend WithEvents txtSatPaisOrg As TextBox
    Friend WithEvents txtSatServico As TextBox
    Friend WithEvents txtSatNome As TextBox
    Friend WithEvents txtSatID As TextBox
    Friend WithEvents lblSatCompLog As Label
    Friend WithEvents lblSatPaisOrg As Label
    Friend WithEvents lblSatServico As Label
    Friend WithEvents lblSatNome As Label
    Friend WithEvents lblSatID As Label
    Friend WithEvents sateliteList As ListBox
    Friend WithEvents txtSatStatus As TextBox
    Friend WithEvents lblSatComp As Label
    Friend WithEvents lblSatStatus As Label
    Friend WithEvents tabEE As TabPage
    Friend WithEvents eeList As ListBox
    Friend WithEvents lblEEStatus As Label
    Friend WithEvents lblCMEE As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEEPaisOrg As Label
    Friend WithEvents lblEENome As Label
    Friend WithEvents txtEEStatus As TextBox
    Friend WithEvents txtEECompLog As TextBox
    Friend WithEvents txtEEPaisOrg As TextBox
    Friend WithEvents txtEENome As TextBox
    Friend WithEvents txtEEID As TextBox
    Friend WithEvents lblEEID As Label
    Friend WithEvents tabMee As TabPage
    Friend WithEvents lblMeeEE As Label
    Friend WithEvents lblMeeLanc As Label
    Friend WithEvents lblMeeCompLog As Label
    Friend WithEvents lblMeeTipo As Label
    Friend WithEvents lblMeeNome As Label
    Friend WithEvents lblMeeID As Label
    Friend WithEvents txtMeeEE As TextBox
    Friend WithEvents txtMeeLanc As TextBox
    Friend WithEvents txtMeeCompLog As TextBox
    Friend WithEvents txtMeeTipo As TextBox
    Friend WithEvents txtMeeNome As TextBox
    Friend WithEvents txtMeeID As TextBox
    Friend WithEvents meeList As ListBox
    Friend WithEvents tabOrbita As TabPage
    Friend WithEvents orbList As ListBox
    Friend WithEvents lblOrbAstro As Label
    Friend WithEvents lblOrbPer As Label
    Friend WithEvents lblOrbIn As Label
    Friend WithEvents lblOrbPe As Label
    Friend WithEvents lblOrbAp As Label
    Friend WithEvents lblOrbID As Label
    Friend WithEvents txtOrbAstro As TextBox
    Friend WithEvents txtOrbPer As TextBox
    Friend WithEvents txtOrbIn As TextBox
    Friend WithEvents txtOrbPe As TextBox
    Friend WithEvents txtOrbAp As TextBox
    Friend WithEvents txtOrbID As TextBox
    Friend WithEvents tabLanc As TabPage
    Friend WithEvents lancList As ListBox
    Friend WithEvents lblLancVeicN As Label
    Friend WithEvents lblLancDT As Label
    Friend WithEvents lblLancPais As Label
    Friend WithEvents lblLancCoord As Label
    Friend WithEvents lblLancID As Label
    Friend WithEvents txtLancVeicN As TextBox
    Friend WithEvents txtLancDT As TextBox
    Friend WithEvents txtLancPais As TextBox
    Friend WithEvents txtLancCoord As TextBox
    Friend WithEvents txtLancID As TextBox
    Friend WithEvents tabPesquisa As TabPage
    Friend WithEvents lblLancVeicCL As Label
    Friend WithEvents txtLancVeicCL As TextBox
    Friend WithEvents bttnCompDel As Button
    Friend WithEvents bttnCompEdit As Button
    Friend WithEvents bttnCompAdd As Button
    Friend WithEvents bttnAstroCan As Button
    Friend WithEvents bttnAstroOK As Button
    Friend WithEvents bttnCompCan As Button
    Friend WithEvents bttnCompOK As Button
    Friend WithEvents bttnSatCan As Button
    Friend WithEvents bttnSatOK As Button
    Friend WithEvents bttnSatDel As Button
    Friend WithEvents bttnSatEdit As Button
    Friend WithEvents bttnSatAdd As Button
    Friend WithEvents bttnEECan As Button
    Friend WithEvents bttnEEOK As Button
    Friend WithEvents bttnEEDel As Button
    Friend WithEvents bttnEEEdit As Button
    Friend WithEvents bttnEEAdd As Button
    Friend WithEvents bttnMEECan As Button
    Friend WithEvents bttnMEEOK As Button
    Friend WithEvents bttnMEEDel As Button
    Friend WithEvents bttnMEEEdit As Button
    Friend WithEvents bttnMEEAdd As Button
    Friend WithEvents bttnOrbCan As Button
    Friend WithEvents bttnOrbOK As Button
    Friend WithEvents bttnOrbDel As Button
    Friend WithEvents bttnOrbEdit As Button
    Friend WithEvents bttnLanCan As Button
    Friend WithEvents bttnLanOK As Button
    Friend WithEvents bttnLanDel As Button
    Friend WithEvents bttnLanEdit As Button
    Friend WithEvents bttnLanAdd As Button
    Friend WithEvents txtSatComp As RichTextBox
    Friend WithEvents txtCMEE As RichTextBox
    Friend WithEvents bttnAstroPesq As Button
    Friend WithEvents txtAstroPesq As TextBox
    Friend WithEvents comboBoxComp As ComboBox
    Friend WithEvents bttnCompPesq As Button
    Friend WithEvents txtCompPesq As TextBox
    Friend WithEvents txtSatPesq As TextBox
    Friend WithEvents comboBoxSat As ComboBox
    Friend WithEvents bttnSatPesq As Button
    Friend WithEvents comboBoxEE As ComboBox
    Friend WithEvents bttnEEPesq As Button
    Friend WithEvents txtEEPesq As TextBox
    Friend WithEvents txtOrbPesq As TextBox
    Friend WithEvents bttnOrbPesq As Button
    Friend WithEvents txtMeePesq As TextBox
    Friend WithEvents comboBoxMee As ComboBox
    Friend WithEvents bttnMeePesq As Button
    Friend WithEvents txtLancPesq As TextBox
    Friend WithEvents bttnLancPesq As Button
    Friend WithEvents lblSatOrb As Label
    Friend WithEvents txtSatOrbAstro As TextBox
    Friend WithEvents txtSatOrbPerio As TextBox
    Friend WithEvents txtSatOrbInc As TextBox
    Friend WithEvents txtSatOrbPeria As TextBox
    Friend WithEvents txtSatOrbAp As TextBox
    Friend WithEvents lblSatOrbAstro As Label
    Friend WithEvents lblSatOrbPerio As Label
    Friend WithEvents lblSatOrbInc As Label
    Friend WithEvents lblSatOrbPeria As Label
    Friend WithEvents lblSatOrbAp As Label
    Friend WithEvents txtEEOrbAstro As TextBox
    Friend WithEvents txtEEOrbPerio As TextBox
    Friend WithEvents txtEEOrbInc As TextBox
    Friend WithEvents txtEEOrbPeria As TextBox
    Friend WithEvents txtEEOrbAp As TextBox
    Friend WithEvents lblEEOrbAstro As Label
    Friend WithEvents lblEEOrbPerio As Label
    Friend WithEvents lblEEOrbInc As Label
    Friend WithEvents lblEEOrbPeria As Label
    Friend WithEvents lblEEOrbAp As Label
    Friend WithEvents lblEEOrb As Label
    Friend WithEvents txtLancObj As TextBox
    Friend WithEvents lblLancObj As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtPesqPesq As TextBox
    Friend WithEvents bttnPesqPesq As Button
    Friend WithEvents radioBttnPesq2 As RadioButton
    Friend WithEvents radioBttnPesq1 As RadioButton
    Friend WithEvents lblPesq As Label
    Friend WithEvents comboBoxPesq As ComboBox
End Class
