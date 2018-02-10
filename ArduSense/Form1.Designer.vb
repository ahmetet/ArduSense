<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ipucu = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Alt2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Alt3 = New System.Windows.Forms.Panel()
        Me.log = New System.Windows.Forms.RichTextBox()
        Me.Alt1 = New System.Windows.Forms.Panel()
        Me.durum = New System.Windows.Forms.Label()
        Me.HızlıDeğişkenOluşturmaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YorumSatırınaDönüştürToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KaydetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SatırNumaralarıRengiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AçCTRLOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeniToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KütüphaneEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BilgiPanosunuTemizleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ÇıkışToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TaslakToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArduinoyaGeçişYapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AraçlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Ust1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Ust2 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BabaTab = New System.Windows.Forms.TabPage()
        Me.BestTextBox = New FastColoredTextBoxNS.FastColoredTextBox()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.KomutEkleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        Me.Alt2.SuspendLayout()
        Me.Alt3.SuspendLayout()
        Me.Alt1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Ust1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Ust2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.BabaTab.SuspendLayout()
        CType(Me.BestTextBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ipucu
        '
        Me.ipucu.ForeColor = System.Drawing.Color.Lime
        Me.ipucu.Name = "ipucu"
        Me.ipucu.Size = New System.Drawing.Size(141, 22)
        Me.ipucu.Text = "ARDUSENSE İP UCU"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ipucu})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1164, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Alt2
        '
        Me.Alt2.BackColor = System.Drawing.Color.Black
        Me.Alt2.Controls.Add(Me.Label1)
        Me.Alt2.Controls.Add(Me.Alt3)
        Me.Alt2.Controls.Add(Me.log)
        Me.Alt2.Controls.Add(Me.Alt1)
        Me.Alt2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Alt2.ForeColor = System.Drawing.Color.White
        Me.Alt2.Location = New System.Drawing.Point(0, 471)
        Me.Alt2.Name = "Alt2"
        Me.Alt2.Size = New System.Drawing.Size(1164, 195)
        Me.Alt2.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(762, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 136)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "void setup() {" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  // put your setup code here, to run once:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "void loop() {" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "  // put your main code here, to run repeatedly:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}"
        Me.Label1.Visible = False
        '
        'Alt3
        '
        Me.Alt3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Alt3.Controls.Add(Me.ToolStrip1)
        Me.Alt3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Alt3.Location = New System.Drawing.Point(0, 170)
        Me.Alt3.Name = "Alt3"
        Me.Alt3.Size = New System.Drawing.Size(1164, 25)
        Me.Alt3.TabIndex = 1
        '
        'log
        '
        Me.log.BackColor = System.Drawing.Color.Black
        Me.log.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.log.Font = New System.Drawing.Font("Lucida Console", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.log.ForeColor = System.Drawing.Color.White
        Me.log.Location = New System.Drawing.Point(0, 40)
        Me.log.Name = "log"
        Me.log.Size = New System.Drawing.Size(1164, 155)
        Me.log.TabIndex = 2
        Me.log.Text = ""
        '
        'Alt1
        '
        Me.Alt1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Alt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Alt1.Controls.Add(Me.durum)
        Me.Alt1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Alt1.Location = New System.Drawing.Point(0, 0)
        Me.Alt1.Name = "Alt1"
        Me.Alt1.Size = New System.Drawing.Size(1164, 40)
        Me.Alt1.TabIndex = 0
        '
        'durum
        '
        Me.durum.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.durum.AutoSize = True
        Me.durum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.durum.Location = New System.Drawing.Point(3, 7)
        Me.durum.Name = "durum"
        Me.durum.Size = New System.Drawing.Size(0, 25)
        Me.durum.TabIndex = 0
        Me.durum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HızlıDeğişkenOluşturmaToolStripMenuItem
        '
        Me.HızlıDeğişkenOluşturmaToolStripMenuItem.Name = "HızlıDeğişkenOluşturmaToolStripMenuItem"
        Me.HızlıDeğişkenOluşturmaToolStripMenuItem.Size = New System.Drawing.Size(367, 26)
        Me.HızlıDeğişkenOluşturmaToolStripMenuItem.Text = "Hızlı Değişken Oluşturma (CTRL + D)"
        Me.HızlıDeğişkenOluşturmaToolStripMenuItem.Visible = False
        '
        'YorumSatırınaDönüştürToolStripMenuItem
        '
        Me.YorumSatırınaDönüştürToolStripMenuItem.Name = "YorumSatırınaDönüştürToolStripMenuItem"
        Me.YorumSatırınaDönüştürToolStripMenuItem.Size = New System.Drawing.Size(367, 26)
        Me.YorumSatırınaDönüştürToolStripMenuItem.Text = "Yorum Satırına Dönüştür (CTRL + SHİFT + C)"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(257, 6)
        '
        'KaydetToolStripMenuItem
        '
        Me.KaydetToolStripMenuItem.Name = "KaydetToolStripMenuItem"
        Me.KaydetToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.KaydetToolStripMenuItem.Text = "Kaydet       CTRL + S"
        '
        'SatırNumaralarıRengiToolStripMenuItem
        '
        Me.SatırNumaralarıRengiToolStripMenuItem.Name = "SatırNumaralarıRengiToolStripMenuItem"
        Me.SatırNumaralarıRengiToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.SatırNumaralarıRengiToolStripMenuItem.Text = "Satır numara rengini değiştir"
        '
        'AçCTRLOToolStripMenuItem
        '
        Me.AçCTRLOToolStripMenuItem.Name = "AçCTRLOToolStripMenuItem"
        Me.AçCTRLOToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.AçCTRLOToolStripMenuItem.Text = "Aç             CTRL + O"
        '
        'YeniToolStripMenuItem
        '
        Me.YeniToolStripMenuItem.Name = "YeniToolStripMenuItem"
        Me.YeniToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.YeniToolStripMenuItem.Text = "Yeni          CTRL + N"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YeniToolStripMenuItem, Me.AçCTRLOToolStripMenuItem, Me.KaydetToolStripMenuItem, Me.KütüphaneEkleToolStripMenuItem, Me.ToolStripSeparator1, Me.SatırNumaralarıRengiToolStripMenuItem, Me.BilgiPanosunuTemizleToolStripMenuItem, Me.ToolStripSeparator2, Me.ÇıkışToolStripMenuItem})
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'KütüphaneEkleToolStripMenuItem
        '
        Me.KütüphaneEkleToolStripMenuItem.Name = "KütüphaneEkleToolStripMenuItem"
        Me.KütüphaneEkleToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.KütüphaneEkleToolStripMenuItem.Text = "Kütüphane Ekle"
        Me.KütüphaneEkleToolStripMenuItem.Visible = False
        '
        'BilgiPanosunuTemizleToolStripMenuItem
        '
        Me.BilgiPanosunuTemizleToolStripMenuItem.Name = "BilgiPanosunuTemizleToolStripMenuItem"
        Me.BilgiPanosunuTemizleToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.BilgiPanosunuTemizleToolStripMenuItem.Text = "Bilgi panosunu temizle"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(257, 6)
        '
        'ÇıkışToolStripMenuItem
        '
        Me.ÇıkışToolStripMenuItem.Name = "ÇıkışToolStripMenuItem"
        Me.ÇıkışToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.ÇıkışToolStripMenuItem.Text = "Çıkış           CTRL + Q"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem, Me.TaslakToolStripMenuItem, Me.AraçlarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(0)
        Me.MenuStrip1.Size = New System.Drawing.Size(1164, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TaslakToolStripMenuItem
        '
        Me.TaslakToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArduinoyaGeçişYapToolStripMenuItem})
        Me.TaslakToolStripMenuItem.Name = "TaslakToolStripMenuItem"
        Me.TaslakToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.TaslakToolStripMenuItem.Text = "Taslak"
        '
        'ArduinoyaGeçişYapToolStripMenuItem
        '
        Me.ArduinoyaGeçişYapToolStripMenuItem.Name = "ArduinoyaGeçişYapToolStripMenuItem"
        Me.ArduinoyaGeçişYapToolStripMenuItem.Size = New System.Drawing.Size(364, 26)
        Me.ArduinoyaGeçişYapToolStripMenuItem.Text = "Arduino'ya Geçiş Yap     CTRL+U   CTRL+F5"
        '
        'AraçlarToolStripMenuItem
        '
        Me.AraçlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.YorumSatırınaDönüştürToolStripMenuItem, Me.HızlıDeğişkenOluşturmaToolStripMenuItem, Me.ToolStripSeparator3, Me.KomutEkleToolStripMenuItem})
        Me.AraçlarToolStripMenuItem.Name = "AraçlarToolStripMenuItem"
        Me.AraçlarToolStripMenuItem.Size = New System.Drawing.Size(65, 24)
        Me.AraçlarToolStripMenuItem.Text = "Araçlar"
        '
        'Ust1
        '
        Me.Ust1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Ust1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Ust1.Controls.Add(Me.PictureBox2)
        Me.Ust1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Ust1.Location = New System.Drawing.Point(0, 24)
        Me.Ust1.Name = "Ust1"
        Me.Ust1.Size = New System.Drawing.Size(1164, 38)
        Me.Ust1.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(38, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Ust2
        '
        Me.Ust2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Ust2.Controls.Add(Me.TabControl1)
        Me.Ust2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Ust2.Location = New System.Drawing.Point(0, 62)
        Me.Ust2.Name = "Ust2"
        Me.Ust2.Size = New System.Drawing.Size(1164, 409)
        Me.Ust2.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.BabaTab)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(77, 30)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Padding = New System.Drawing.Point(20, 3)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1164, 409)
        Me.TabControl1.TabIndex = 0
        '
        'BabaTab
        '
        Me.BabaTab.Controls.Add(Me.BestTextBox)
        Me.BabaTab.Location = New System.Drawing.Point(4, 34)
        Me.BabaTab.Name = "BabaTab"
        Me.BabaTab.Padding = New System.Windows.Forms.Padding(3)
        Me.BabaTab.Size = New System.Drawing.Size(1156, 371)
        Me.BabaTab.TabIndex = 1
        Me.BabaTab.Text = "TabPage1"
        Me.BabaTab.UseVisualStyleBackColor = True
        '
        'BestTextBox
        '
        Me.BestTextBox.AutoCompleteBracketsList = New Char() {Global.Microsoft.VisualBasic.ChrW(40), Global.Microsoft.VisualBasic.ChrW(41), Global.Microsoft.VisualBasic.ChrW(123), Global.Microsoft.VisualBasic.ChrW(125), Global.Microsoft.VisualBasic.ChrW(91), Global.Microsoft.VisualBasic.ChrW(93), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(34), Global.Microsoft.VisualBasic.ChrW(39), Global.Microsoft.VisualBasic.ChrW(39)}
        Me.BestTextBox.AutoScrollMinSize = New System.Drawing.Size(33, 23)
        Me.BestTextBox.BackBrush = Nothing
        Me.BestTextBox.CharHeight = 23
        Me.BestTextBox.CharWidth = 11
        Me.BestTextBox.CurrentLineColor = System.Drawing.Color.Aqua
        Me.BestTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BestTextBox.DelayedEventsInterval = 1
        Me.BestTextBox.DelayedTextChangedInterval = 1
        Me.BestTextBox.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.BestTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BestTextBox.Font = New System.Drawing.Font("Consolas", 12.0!)
        Me.BestTextBox.Hotkeys = resources.GetString("BestTextBox.Hotkeys")
        Me.BestTextBox.IsReplaceMode = False
        Me.BestTextBox.Location = New System.Drawing.Point(3, 3)
        Me.BestTextBox.Name = "BestTextBox"
        Me.BestTextBox.Paddings = New System.Windows.Forms.Padding(0)
        Me.BestTextBox.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BestTextBox.ServiceColors = CType(resources.GetObject("BestTextBox.ServiceColors"), FastColoredTextBoxNS.ServiceColors)
        Me.BestTextBox.Size = New System.Drawing.Size(1150, 365)
        Me.BestTextBox.TabIndex = 10
        Me.BestTextBox.Zoom = 100
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(364, 6)
        '
        'KomutEkleToolStripMenuItem
        '
        Me.KomutEkleToolStripMenuItem.Name = "KomutEkleToolStripMenuItem"
        Me.KomutEkleToolStripMenuItem.Size = New System.Drawing.Size(367, 26)
        Me.KomutEkleToolStripMenuItem.Text = "Komut Ekle"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 666)
        Me.Controls.Add(Me.Ust2)
        Me.Controls.Add(Me.Alt2)
        Me.Controls.Add(Me.Ust1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "ArduSense"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Alt2.ResumeLayout(False)
        Me.Alt2.PerformLayout()
        Me.Alt3.ResumeLayout(False)
        Me.Alt3.PerformLayout()
        Me.Alt1.ResumeLayout(False)
        Me.Alt1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Ust1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Ust2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.BabaTab.ResumeLayout(False)
        CType(Me.BestTextBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ipucu As ToolStripLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Alt2 As Panel
    Friend WithEvents log As RichTextBox
    Friend WithEvents Alt3 As Panel
    Friend WithEvents Alt1 As Panel
    Friend WithEvents durum As Label
    Friend WithEvents HızlıDeğişkenOluşturmaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YorumSatırınaDönüştürToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents KaydetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SatırNumaralarıRengiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AçCTRLOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YeniToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DosyaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ÇıkışToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TaslakToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AraçlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Ust1 As Panel
    Friend WithEvents Ust2 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents BabaTab As TabPage
    Friend WithEvents BestTextBox As FastColoredTextBoxNS.FastColoredTextBox
    Friend WithEvents ArduinoyaGeçişYapToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KütüphaneEkleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BilgiPanosunuTemizleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents KomutEkleToolStripMenuItem As ToolStripMenuItem
End Class
