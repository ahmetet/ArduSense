Imports FastColoredTextBoxNS
Imports System.Text.RegularExpressions
Imports System.IO
Public Class Form1
    'Değişkenler BAŞLA

    Dim Arduino_Exe As String = ""
    Dim skecyolu As String = ""

    'Değişlenler BİTİR


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BestTextBox.Select()
        ana_proje_ayarlari()
    End Sub

    Private Sub ana_proje_ayarlari()
        Try
            If (My.Computer.FileSystem.DirectoryExists(Path.GetTempPath + "ardusensetemp")) Then
                My.Computer.FileSystem.DeleteDirectory(Path.GetTempPath + "ardusensetemp", FileIO.DeleteDirectoryOption.DeleteAllContents)
            End If

            BabaTab.Text = "Yeni Skeç"
            BestTextBox.Clear()
            skecyolu = ""
            BestTextBox.Text = Label1.Text
            log.Text += Date.Now.ToString + ": " + "Yeni Skeç Yüklendi!" + vbNewLine
        Catch ex As Exception
            log.Text += Date.Now.ToString + ": " + "Bir hata meydana geldi #1: " + ex.Message + vbNewLine
        End Try
    End Sub

    Function arduino_bul()
        Try
            If (Arduino_Exe.Contains(".exe")) Then
                '  log.Text += Date.Now.ToString + ": Arduino bulundu! :" + Arduino_Exe + vbNewLine
            Else
                log.Text += Date.Now.ToString + ": " + "Arduino bulunamadı lütfen arduino.exe'yi seçiniz !" + vbNewLine
                MessageBox.Show("Lütfen arduino.exe'yi seçiniz")
                OpenFileDialog1.Filter = "Arduino.exe(*.exe)|*.exe"
                MessageBox.Show("Lütfen projenizi kaydediniz")
                If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then
                    If (OpenFileDialog1.FileName.ToLower.Contains("arduino")) Then
                        Arduino_Exe = OpenFileDialog1.FileName
                        log.Text += Date.Now.ToString + ": " + "Arduino.exe başarıyla seçildi! : " + Arduino_Exe + vbNewLine
                        Return True
                    Else
                        log.Text += Date.Now.ToString + ": Arduino.exe'yi seçmelisiniz! :" + Arduino_Exe + vbNewLine
                        Return False
                    End If
                End If

            End If

            If (Arduino_Exe.ToLower.Contains("arduino.exe")) Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            log.Text += Date.Now.ToString + ": " + "Bir hata meydana geldi #2: " + ex.Message + vbNewLine
            Return False
        End Try

    End Function

    Private Sub ArduinoyaGeçişYapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArduinoyaGeçişYapToolStripMenuItem.Click

        Try
            For Each acik_islem In Process.GetProcesses

                If (acik_islem.ProcessName = "javaw") Then
                    acik_islem.Kill()
                End If
            Next

            If (arduino_bul()) Then
kontrol:
                If (skecyolu = "") Then

                    SaveFileDialog1.Filter = "Arduino Proje Dosyası(*.ino)|*.ino"

                    If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
                        Try
                            Dim proje_info As New FileInfo(SaveFileDialog1.FileName)
                            Dim proje_adi As String = proje_info.Name

                            If (My.Computer.FileSystem.DirectoryExists(SaveFileDialog1.FileName.Replace(".ino", ""))) Then
                                skecyolu = SaveFileDialog1.FileName.Replace(".ino", "") + "\" + proje_adi
                                BestTextBox.SaveToFile(skecyolu, System.Text.Encoding.ASCII)
                                BabaTab.Text = proje_adi.Replace(".ino", "")
                            Else
                                My.Computer.FileSystem.CreateDirectory(SaveFileDialog1.FileName.Replace(".ino", ""))
                                skecyolu = SaveFileDialog1.FileName.Replace(".ino", "") + "\" + proje_adi
                                BestTextBox.SaveToFile(skecyolu, System.Text.Encoding.ASCII)
                                BabaTab.Text = proje_adi.Replace(".ino", "")
                            End If
                        Catch ex As Exception
                            log.Text += Date.Now.ToString + ": " + "Bir hata meydana geldi #6: " + ex.Message + vbNewLine
                        End Try
                    Else
                        Try

                            If (My.Computer.FileSystem.DirectoryExists(Path.GetTempPath + "ardusensetemp")) Then
                                skecyolu = Path.GetTempPath.ToString + "ardusensetemp\ardusensetemp.ino"
                                BestTextBox.SaveToFile(skecyolu, System.Text.Encoding.ASCII)
                                BabaTab.Text = "ardusensetemp"
                            Else
                                My.Computer.FileSystem.CreateDirectory(Path.GetTempPath + "ardusensetemp")
                                skecyolu = Path.GetTempPath.ToString + "ardusensetemp\ardusensetemp.ino"
                                BestTextBox.SaveToFile(skecyolu, System.Text.Encoding.ASCII)
                                BabaTab.Text = "ardusensetemp"
                            End If
                        Catch ex As Exception
                            log.Text += Date.Now.ToString + ": " + "Bir hata meydana geldi #4: " + ex.Message + vbNewLine
                        End Try
                    End If
                    GoTo kontrol
                Else
                    BestTextBox.SaveToFile(skecyolu, System.Text.Encoding.ASCII)
                    Shell("cmd.exe /c " + Arduino_Exe + " " + skecyolu)
                End If
            Else
                log.Text += Date.Now.ToString + ": " + "Arduino.exe bulunamadı!" + vbNewLine
            End If

        Catch ex As Exception
            log.Text += Date.Now.ToString + ": " + "Bir hata meydana geldi #3: " + ex.Message + vbNewLine
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            ArduinoyaGeçişYapToolStripMenuItem.PerformClick()
        Catch ex As Exception
            log.Text += Date.Now.ToString + ": " + "Bir hata meydana geldi #5: " + ex.Message + vbNewLine
        End Try

    End Sub

    Private Sub YeniToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeniToolStripMenuItem.Click
        ana_proje_ayarlari()
    End Sub

    Private Sub AçCTRLOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AçCTRLOToolStripMenuItem.Click
        OpenFileDialog1.Filter = "Arduino Proje Dosyası (*.ino)|*.ino"
        If (OpenFileDialog1.ShowDialog = DialogResult.OK) Then

            BestTextBox.Clear()
            BestTextBox.OpenFile(OpenFileDialog1.FileName, System.Text.Encoding.ASCII)
            BabaTab.Text = OpenFileDialog1.SafeFileName.ToString
            skecyolu = OpenFileDialog1.FileName
        Else
            log.Text += Date.Now.ToString + ": " + "İşlem kullanıcı tarafından iptal edildi! " + vbNewLine
        End If
    End Sub

    Private Sub KaydetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaydetToolStripMenuItem.Click
        SaveFileDialog1.Filter = "Arduino Proje Dosyası(*.ino)|*.ino"

        If (SaveFileDialog1.ShowDialog = DialogResult.OK) Then
            Try
                Dim proje_info As New FileInfo(SaveFileDialog1.FileName)
                Dim proje_adi As String = proje_info.Name

                If (My.Computer.FileSystem.DirectoryExists(SaveFileDialog1.FileName.Replace(".ino", ""))) Then
                    skecyolu = SaveFileDialog1.FileName.Replace(".ino", "") + "\" + proje_adi
                    BestTextBox.SaveToFile(skecyolu, System.Text.Encoding.ASCII)
                    BabaTab.Text = proje_adi.Replace(".ino", "")
                Else
                    My.Computer.FileSystem.CreateDirectory(SaveFileDialog1.FileName.Replace(".ino", ""))
                    skecyolu = SaveFileDialog1.FileName.Replace(".ino", "") + "\" + proje_adi
                    BestTextBox.SaveToFile(skecyolu, System.Text.Encoding.ASCII)
                    BabaTab.Text = proje_adi.Replace(".ino", "")
                End If
            Catch ex As Exception
                log.Text += Date.Now.ToString + ": " + "Bir hata meydana geldi #6: " + ex.Message + vbNewLine
            End Try
        Else
            log.Text += Date.Now.ToString + ": " + "İşlem kullanıcı tarafından iptal edildi! " + vbNewLine
        End If
    End Sub

    Private Sub BestTextBox_Load(sender As Object, e As EventArgs) Handles BestTextBox.Load

    End Sub

    Dim tus_ctrl As Boolean = False
    Dim tus_n As Boolean = False
    Dim tus_o As Boolean = False
    Dim tus_s As Boolean = False
    Dim tus_q As Boolean = False
    Dim tus_u As Boolean = False
    Dim tus_f5 As Boolean = False
    Dim tus_space As Boolean = False

    Private Sub BestTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles BestTextBox.KeyDown
        If (e.KeyCode = Keys.ControlKey) Then
            tus_ctrl = True

        ElseIf (e.KeyCode = Keys.N) Then
            tus_n = True
            If (tus_ctrl = True) Then
                YeniToolStripMenuItem.PerformClick()
                tus_ctrl = False
                tus_n = False
            End If


        ElseIf (e.KeyCode = Keys.O) Then
            tus_o = True
            If (tus_ctrl = True) Then
                AçCTRLOToolStripMenuItem.PerformClick()
                tus_ctrl = False
                tus_o = False
            End If

        ElseIf (e.KeyCode = Keys.S) Then
            tus_s = True
            If (tus_ctrl = True) Then
                KaydetToolStripMenuItem.PerformClick()
                tus_ctrl = False
                tus_s = False
            End If


        ElseIf (e.KeyCode = Keys.Q) Then
            tus_q = True
            If (tus_ctrl = True) Then
                Try
                    End
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                tus_ctrl = False
                tus_q = False
            End If


        ElseIf (e.KeyCode = Keys.U) Then
            tus_u = True
            If (tus_ctrl = True) Then
                Try
                    ArduinoyaGeçişYapToolStripMenuItem.PerformClick()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                tus_ctrl = False
                tus_u = False
            End If



        ElseIf (e.KeyCode = Keys.F5) Then
            tus_f5 = True
            If (tus_ctrl = True) Then
                Try
                    ArduinoyaGeçişYapToolStripMenuItem.PerformClick()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                tus_ctrl = False
                tus_f5 = False
            End If


        ElseIf (e.KeyCode = Keys.Space) Then
            tus_space = True

            If (tus_ctrl = True) Then

                tus_ctrl = False
                tus_f5 = False
            End If


        Else

            tus_ctrl = False
        End If






    End Sub

    Private Sub SatırNumaralarıRengiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatırNumaralarıRengiToolStripMenuItem.Click
        If (ColorDialog1.ShowDialog = DialogResult.OK) Then
            Try
                BestTextBox.LineNumberColor = ColorDialog1.Color
            Catch ex As Exception
                log.Text += Date.Now.ToString + ": " + "Bir hata meydana geldi #7: " + ex.Message + vbNewLine
            End Try
        Else
            log.Text += Date.Now.ToString + ": " + "İşlem kullanıcı tarafından iptal edildi! " + vbNewLine
        End If
    End Sub

    Private Sub BilgiPanosunuTemizleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BilgiPanosunuTemizleToolStripMenuItem.Click
        log.Clear()
    End Sub

    Private Sub YorumSatırınaDönüştürToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YorumSatırınaDönüştürToolStripMenuItem.Click
        If (BestTextBox.SelectedText.Contains("\n") Or BestTextBox.SelectedText.Contains(vbNewLine)) Then
            For Each satircik In BestTextBox.SelectedText.Split(vbNewLine)

                If (satircik.Trim.Length >= 2) Then
                    If (satircik.Trim.Substring(0, 2) = "//") Then
                        BestTextBox.Text = BestTextBox.Text.Replace(satircik, satircik.Trim.Substring(2, satircik.Trim.Length - 2))
                    Else
                        BestTextBox.Text = BestTextBox.Text.Replace(satircik, "//" + satircik.Trim)
                    End If

                ElseIf (satircik.Trim.Length = 1) Then
                    'direkt // ekle
                    BestTextBox.Text = BestTextBox.Text.Replace(satircik, "//" + satircik.Trim)

                End If


            Next
        Else
            MsgBox("bir satır")
        End If
    End Sub


    'INTELLISENSE VE RENKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK


    Private sense As AutocompleteMenu
    Private temel_komutlar As New ArrayList()
    Private gelismis_komutlar As New ArrayList()
    Private zaman_komutlar As New ArrayList()
    Private mat_komutlar As New ArrayList()
    Private karakter_komutlar As New ArrayList()
    Private rastgele_komutlar As New ArrayList()
    Private bit_komutlar As New ArrayList()
    Private interrupt_komutlar As New ArrayList()
    Private donussuz_komutlar As New ArrayList()
    Private ozel_yapilar As New ArrayList()
    Private serial_stream_metotlar As New ArrayList()
    Private cevirmeler_komutlar As New ArrayList()
    Private sabitler As New ArrayList()
    Private tanimlar As New ArrayList()
    Private kaliplar As New ArrayList()
    Private string_komutlar As New ArrayList()


    Public Sub New()
        'Part 1
        temel_komutlar.Add("digitalRead(^);")
        temel_komutlar.Add("digitalWrite(^);")
        temel_komutlar.Add("pinMode(^);")
        temel_komutlar.Add("digitalWrite(^);")
        temel_komutlar.Add("analogRead(^);")
        temel_komutlar.Add("analogReference(^);")
        temel_komutlar.Add("analogWrite(^);")
        temel_komutlar.Add("analogReadResolution(^);")
        temel_komutlar.Add("analogWriteResolution(^);")


        gelismis_komutlar.Add("noTone(^);")
        gelismis_komutlar.Add("pulseIn(^);")
        gelismis_komutlar.Add("pulseInLong(^);")
        gelismis_komutlar.Add("shiftIn(^);")
        gelismis_komutlar.Add("shiftOut(^);")
        gelismis_komutlar.Add("tone(^);")

        zaman_komutlar.Add("delay(^);")
        zaman_komutlar.Add("delayMicroseconds(^);")
        zaman_komutlar.Add("micros(^);")
        zaman_komutlar.Add("millis(^);")

        mat_komutlar.Add("abs(^);")
        mat_komutlar.Add("constrain(^);")
        mat_komutlar.Add("map(^);")
        mat_komutlar.Add("max(^);")
        mat_komutlar.Add("min(^);")
        mat_komutlar.Add("pow(^);")
        mat_komutlar.Add("sq(^);")
        mat_komutlar.Add("sqrt(^);")
        mat_komutlar.Add("cos(^);")
        mat_komutlar.Add("sin(^);")
        mat_komutlar.Add("tan(^);")

        karakter_komutlar.Add("isAlpha(^);")
        karakter_komutlar.Add("isAlphaNumeric(^);")
        karakter_komutlar.Add("isAscii(^);")
        karakter_komutlar.Add("isControl(^);")
        karakter_komutlar.Add("isDigit(^);")
        karakter_komutlar.Add("isGraph(^);")
        karakter_komutlar.Add("isHexadecimalDigit(^);")
        karakter_komutlar.Add("isLowerCase(^);")
        karakter_komutlar.Add("isPrintable(^);")
        karakter_komutlar.Add("isPunct(^);")
        karakter_komutlar.Add("isSpace(^);")
        karakter_komutlar.Add("isUpperCase(^);")
        karakter_komutlar.Add("isWhitespace(^);")

        rastgele_komutlar.Add("random(^);")
        rastgele_komutlar.Add("randomSeed(^);")

        bit_komutlar.Add("bit(^); ")
        bit_komutlar.Add("bitClear(^); ")
        bit_komutlar.Add("bitRead(^); ")
        bit_komutlar.Add("bitSet(^); ")
        bit_komutlar.Add("bitWrite(^); ")
        bit_komutlar.Add("highByte(^); ")
        bit_komutlar.Add("lowByte(^); ")

        interrupt_komutlar.Add("attachInterrupt(^);")
        interrupt_komutlar.Add("detachInterrupt(^);")

        donussuz_komutlar.Add("interrupts();")
        donussuz_komutlar.Add("noInterrupts();")

        ozel_yapilar.Add("Serial")
        ozel_yapilar.Add("Stream")
        ozel_yapilar.Add("Keyboard")
        ozel_yapilar.Add("Mouse")
        ozel_yapilar.Add("loop()")
        ozel_yapilar.Add("setup()")
        ozel_yapilar.Add("break;")
        ozel_yapilar.Add("continue;")
        ozel_yapilar.Add("do")
        ozel_yapilar.Add("else")
        ozel_yapilar.Add("if")
        ozel_yapilar.Add("goto")
        ozel_yapilar.Add("return")
        ozel_yapilar.Add("switch")
        ozel_yapilar.Add("case")
        ozel_yapilar.Add("while")
        ozel_yapilar.Add("not")
        ozel_yapilar.Add("or")
        ozel_yapilar.Add("and")
        ozel_yapilar.Add("xor")
        ozel_yapilar.Add("include")
        ozel_yapilar.Add("define")
        ozel_yapilar.Add("pragma")

        kaliplar.Add("while(^){" + vbNewLine + vbNewLine + "}")
        kaliplar.Add("do{" + vbNewLine + vbNewLine + "}while(^);")
        kaliplar.Add("if(^){" + vbNewLine + vbNewLine + "}")
        kaliplar.Add("if(^){" + vbNewLine + vbNewLine + "}" + vbNewLine + "else{" + vbNewLine + vbNewLine + "}")
        kaliplar.Add("if(^){" + vbNewLine + vbNewLine + "}" + vbNewLine + "else if(){" + vbNewLine + vbNewLine + "}")
        kaliplar.Add("if(^){" + vbNewLine + vbNewLine + "}" + vbNewLine + "else if(){" + vbNewLine + vbNewLine + "}" + vbNewLine + "else{" + vbNewLine + vbNewLine + "}")
        kaliplar.Add("switch(^){" + vbNewLine + "case 1:" + vbNewLine + "//Bir şeyler yap" + vbNewLine + "break;" + vbNewLine + vbNewLine + "case 2:" + vbNewLine + "//Bir şeyler yap" + vbNewLine + "break;" + vbNewLine + vbNewLine + "default:" + vbNewLine + "//Aksi halde" + vbNewLine + "break;" + vbNewLine + "}")


        serial_stream_metotlar.Add("available();")
        serial_stream_metotlar.Add("availableForWrite();")
        serial_stream_metotlar.Add("begin();")
        serial_stream_metotlar.Add("End();")
        serial_stream_metotlar.Add("find();")
        serial_stream_metotlar.Add("findUntil();")
        serial_stream_metotlar.Add("flush();")
        serial_stream_metotlar.Add("parseFloat();")
        serial_stream_metotlar.Add("parseInt();")
        serial_stream_metotlar.Add("peek();")
        serial_stream_metotlar.Add("print();")
        serial_stream_metotlar.Add("println();")
        serial_stream_metotlar.Add("read();")
        serial_stream_metotlar.Add("readBytes();")
        serial_stream_metotlar.Add("readBytesUntil();")
        serial_stream_metotlar.Add("setTimeout();")
        serial_stream_metotlar.Add("write();")
        serial_stream_metotlar.Add("serialEvent();")
        serial_stream_metotlar.Add("readString();")
        serial_stream_metotlar.Add("readStringUntil();")

        'burdan sonrasi mavimsi
        cevirmeler_komutlar.Add("Byte(^);")
        cevirmeler_komutlar.Add("char(^);")
        cevirmeler_komutlar.Add("float(^);")
        cevirmeler_komutlar.Add("int(^);")
        cevirmeler_komutlar.Add("Long(^);")
        cevirmeler_komutlar.Add("word(^);")
        cevirmeler_komutlar.Add("String(^);")
        cevirmeler_komutlar.Add("sizef(^);")

        sabitler.Add("HIGH")
        sabitler.Add("LOW")

        sabitler.Add("OUTPUT")
        sabitler.Add("INPUT")
        sabitler.Add("INPUT_PULLUP")
        sabitler.Add("LED_BUILTIN")

        sabitler.Add("true")
        sabitler.Add("false")


        tanimlar.Add("array")
        tanimlar.Add("bool")
        tanimlar.Add("Boolean")
        tanimlar.Add("Byte")
        tanimlar.Add("char")
        tanimlar.Add("Double")
        tanimlar.Add("float")
        tanimlar.Add("int")
        tanimlar.Add("Long")
        tanimlar.Add("Short")
        tanimlar.Add("String")
        tanimlar.Add("unsigned Char")
        tanimlar.Add("unsigned int")
        tanimlar.Add("unsigned Long")
        tanimlar.Add("void")
        tanimlar.Add("word")
        tanimlar.Add("const")
        tanimlar.Add("scope")
        tanimlar.Add("Static")
        tanimlar.Add("volatile")
        tanimlar.Add("PROGMEM")
        'bunlar da açik mavi
        tanimlar.Add("DEC")
        tanimlar.Add("HEX")
        tanimlar.Add("BIN")


        'bunları da turuncu
        string_komutlar.Add("charAt()")
        string_komutlar.Add("compareTo()")
        string_komutlar.Add("concat()")
        string_komutlar.Add("c_str()")
        string_komutlar.Add("endsWith()")
        string_komutlar.Add("equals()")
        string_komutlar.Add("equalsIgnoreCase()")
        string_komutlar.Add("getBytes()")
        string_komutlar.Add("indexOf()")
        string_komutlar.Add("lastIndexOf()")
        string_komutlar.Add("length()")
        string_komutlar.Add("remove()")
        string_komutlar.Add("replace()")
        string_komutlar.Add("reserve()")
        string_komutlar.Add("setCharAt()")
        string_komutlar.Add("StartsWith()")
        string_komutlar.Add("substring()")
        string_komutlar.Add("toCharArray()")
        string_komutlar.Add("toInt()")
        string_komutlar.Add("toFloat()")
        string_komutlar.Add("toLowerCase()")
        string_komutlar.Add("toUpperCase()")
        string_komutlar.Add("trim()")


        'CDEN KALANLAR VE DİĞER

        InitializeComponent()
        sense = New AutocompleteMenu(BestTextBox)

        sense.SearchPattern = "[\w\.:=!<>]" 'CTRL+F için


        'Part 2
        'DeclarationSnippet       'düşündürdün? fonky monky tarzılar
        'MethodAutocompleteItem   'method oldukları için çok düşünmene gerek yok

        'AutocompleteItem         'içine bir şey almayanlar için kullan (parametrsiz)
        'SnippetAutocompleteItem  'içine bir şey alanlar    için kullan ( parametrlei)

        'SnippetAutocompleteItem > AutocompleteItem :))))
        Dim sense_elemanlar As New List(Of AutocompleteItem)()
        For Each item As String In temel_komutlar
            sense_elemanlar.Add(New SnippetAutocompleteItem(item))
        Next
        For Each item As String In gelismis_komutlar
            sense_elemanlar.Add(New SnippetAutocompleteItem(item))
        Next
        For Each item As String In zaman_komutlar
            sense_elemanlar.Add(New SnippetAutocompleteItem(item))
        Next
        For Each item As String In mat_komutlar
            sense_elemanlar.Add(New SnippetAutocompleteItem(item))
        Next
        For Each item As String In karakter_komutlar
            sense_elemanlar.Add(New SnippetAutocompleteItem(item))
        Next
        For Each item As String In rastgele_komutlar
            sense_elemanlar.Add(New SnippetAutocompleteItem(item))
        Next
        For Each item As String In bit_komutlar
            sense_elemanlar.Add(New SnippetAutocompleteItem(item))
        Next
        For Each item As String In interrupt_komutlar
            sense_elemanlar.Add(New SnippetAutocompleteItem(item))
        Next
        For Each item As String In donussuz_komutlar
            sense_elemanlar.Add(New AutocompleteItem(item))
        Next
        For Each item As String In ozel_yapilar
            sense_elemanlar.Add(New AutocompleteItem(item))
        Next
        For Each item As String In serial_stream_metotlar
            sense_elemanlar.Add(New MethodAutocompleteItem(item))
        Next
        For Each item As String In cevirmeler_komutlar
            sense_elemanlar.Add(New SnippetAutocompleteItem(item))
        Next
        For Each item As String In sabitler
            sense_elemanlar.Add(New AutocompleteItem(item))
        Next
        For Each item As String In tanimlar
            sense_elemanlar.Add(New AutocompleteItem(item))
        Next
        For Each item As String In kaliplar
            sense_elemanlar.Add(New SnippetAutocompleteItem(item))
        Next
        For Each item As String In string_komutlar
            sense_elemanlar.Add(New MethodAutocompleteItem(item))
        Next

        Try
            sense.Items.SetAutocompleteItems(sense_elemanlar)
        Catch ex As Exception

        End Try

    End Sub


    ''' <summary>
    ''' This item appears when any part of snippet text is typed
    ''' </summary>
    Private Class DeclarationSnippet
        Inherits SnippetAutocompleteItem
        Public Sub New(ByVal snippet As String)
            MyBase.New(snippet)
        End Sub

        Public Overrides Function Compare(ByVal fragmentText As String) As CompareResult
            Dim pattern = Regex.Escape(fragmentText)
            If Regex.IsMatch(Text, " \ b" & pattern, RegexOptions.IgnoreCase) Then
                Return CompareResult.Visible
            End If
            Return CompareResult.Hidden
        End Function
    End Class



    Private gri As TextStyle = New TextStyle(Brushes.Gray, Nothing, FontStyle.Regular)
    Private cornfloverblue As Style = New TextStyle(Brushes.CornflowerBlue, Nothing, FontStyle.Regular)
    Private darkblue As Style = New TextStyle(Brushes.DarkBlue, Nothing, FontStyle.Regular)
    Private kirmizi As Style = New TextStyle(Brushes.Red, Nothing, FontStyle.Regular)
    Private turuncu_kalin As Style = New TextStyle(Brushes.Orange, Nothing, FontStyle.Bold)
    Private turuncu As Style = New TextStyle(Brushes.Orange, Nothing, FontStyle.Regular)
    Private yesil As TextStyle = New TextStyle(Brushes.Green, Nothing, FontStyle.Regular)
    Private tirnak As TextStyle = New TextStyle(Brushes.CornflowerBlue, Nothing, FontStyle.Regular)
    Private mor_italik As TextStyle = New TextStyle(Brushes.Purple, Nothing, FontStyle.Italic)


    Private Sub degislan(sender As Object, e As TextChangedEventArgs) Handles BestTextBox.TextChanged
        CType(sender, FastColoredTextBox).Range.ClearStyle(New Style() {Me.turuncu, Me.turuncu_kalin, Me.cornfloverblue, Me.darkblue, Me.kirmizi}) ' Temizle

        e.ChangedRange.ClearStyle(New Style() {Me.gri, Me.tirnak, Me.mor_italik, Me.yesil})
        e.ChangedRange.SetStyle(Me.gri, "//[^>\n]+") ' YORUM SATIRIs
        e.ChangedRange.SetStyle(Me.yesil, "#[^\n]+") ' Referans için, \n bu bitirme trigi
        e.ChangedRange.SetStyle(Me.tirnak, """(.|\n)*?""") '  " için
        e.ChangedRange.SetStyle(Me.mor_italik, "'(.|\n)*?'") '  ' için

        'Dim ahmetex As New Regex("<(.|\n)*?>")
        CType(sender, FastColoredTextBox).Range.SetStyle(Me.turuncu, "\b(digitalRead|digitalWrite|pinMode|analogRead|analogReference|analogWrite|analogReadResolution|analogWriteResolution|noTone|pulseIn|pulseInLong|shiftIn|shiftOut|tone|delay|delayMicroseconds|micros|millis|abs|constrain|map|max|min|pow|sq|sqrt|cos|sin|tan|isAlpha|isAlphaNumeric|isAscii|isControl|isDigit|isGraph|isHexadecimalDigit|isLowerCase|isPrintable|isPunct|isSpace|isUpperCase|isWhitespace|random|randomSeed|bit|bitClear|bitRead|bitSet|bitWrite|highByte|lowByte|attachInterrupt|detachInterrupt|interrupts|noInterrupts)\b", RegexOptions.IgnoreCase) ' Uygula
        CType(sender, FastColoredTextBox).Range.SetStyle(Me.turuncu_kalin, "\b(serial|stream|Keyboard|Mouse)\b", RegexOptions.IgnoreCase)
        CType(sender, FastColoredTextBox).Range.SetStyle(Me.cornfloverblue, "\b(HEX|DEC|BIN|HIGH|LOW|INPUT|OUTPUT|INPUT_PULLUP|LED_BUILTIN|true|false|byte|char|float|int|long|word|String|array|bool|boolean|byte|char|double|float|int|long|short|string|unsigned char|unsigned int|unsigned long|void|word|const|scope|static|volatile|Utilities|PROGMEM|sizeof)\b", RegexOptions.IgnoreCase)
        CType(sender, FastColoredTextBox).Range.SetStyle(Me.darkblue, "\b(include|define|pragma|break|continue|do|while|else|if|for|goto|return|switch|case|not|and|or|xor)\b", RegexOptions.IgnoreCase)
        CType(sender, FastColoredTextBox).Range.SetStyle(Me.turuncu, "\b(available|availableForWrite|begin|End|find|findUntil|flush|parseFloat|parseInt|peek|print|println|read|readBytes|readBytesUntil|setTimeout|write|serialEvent|readString|readStringUntil)\b", RegexOptions.IgnoreCase)
        CType(sender, FastColoredTextBox).Range.SetStyle(Me.turuncu, "\b(charAt|compareTo|concat|c_str|endsWith|equals|equalsIgnoreCase|getBytes|indexOf|lastIndexOf|length|remove|replace|reserve|setCharAt|StartsWith|substring|toCharArray|toInt|toFloat|toLowerCase|toUpperCase|trim)\b", RegexOptions.IgnoreCase)
        '    CType(sender, FastColoredTextBox).Range.SetStyle(Me.darkblue)
        'CType(sender, FastColoredTextBox).Range.SetStyle(Me.Kontrol, "\b(değilse|eğer|aksi halde|ya da)\b", RegexOptions.IgnoreCase) ' Uygula
        'CType(sender, FastColoredTextBox).Range.SetStyle(Me.IOlar, "\b(DÖNDÜR|döndür|Döndür|DOĞRU|YANLIŞ|GÖMÜLÜ_LED|KARTTAKİ_LED|ÇIKIŞ|GİRİŞ|GİRİŞ_PULLUP|AKTİF|PASİF|SÖNDÜR|YAK)\b", RegexOptions.IgnoreCase) ' Uygula
        'CType(sender, FastColoredTextBox).Range.SetStyle(Me.Fonksiyonn, "\b(void|setup|loop|fonksiyon|Sınıf)\b", RegexOptions.IgnoreCase) ' Uygula
        'CType(sender, FastColoredTextBox).Range.SetStyle(Me.Tanımlamalar, "\b(Dizi|Mantıksal|Bayt|Karakter|Reel Sayı|Tam Sayı|Kelime|Pozitif Tam Sayı|Pozitif Karakter|Değişken|Uzun Sayı|Pozitif Uzun Sayı)\b", RegexOptions.IgnoreCase) ' Uygula
        'CType(sender, FastColoredTextBox).Range.SetStyle(Me.AnaKomutlar, "\b(digitalRead|digitalWrite|Yaz|PinDurumu|DijitalOku|AnalogOku|Bekle|Döngü)\b", RegexOptions.IgnoreCase) ' Uygula
        'CType(sender, FastColoredTextBox).Range.SetStyle(Me.İletişim, "\b(iletişim)\b", RegexOptions.IgnoreCase) ' Uygula
        'CType(sender, FastColoredTextBox).Range.SetStyle(Me.İletişimKomutları, "\b(başlat|gönder|gönderasg|hazırsa|bitir|oku)\b", RegexOptions.IgnoreCase) ' Uygula
        'CType(sender, FastColoredTextBox).Range.SetStyle(Me.ReferansEkle, "\b(Referans|referans|REFERANS)\b", RegexOptions.IgnoreCase) ' Uygula

        For Each found As Range In CType(sender, FastColoredTextBox).GetRanges("\b(void|class)\s+(?<range>\w+)\b")
            CType(sender, FastColoredTextBox).Range.SetStyle(Me.darkblue, "\b" + found.Text + "\b")
        Next
        For Each found As Range In CType(sender, FastColoredTextBox).GetRanges("\b(byte|char|float|int|long|word|String|array|bool|boolean|byte|char|double|float|int|long|short|string|unsigned char|unsigned int|unsigned long|void|word|scope|static|volatile|const byte|const char|const float|const int|const long|const word|const String|const array|const bool|const boolean|const byte|const char|const double|const float|const int|const long|const short|const string|const unsigned char|const unsigned int|const unsigned long)\s+(?<range>\w+)\b", RegexOptions.IgnoreCase)
            CType(sender, FastColoredTextBox).Range.SetStyle(Me.kirmizi, "\b" + found.Text + "\b")
        Next


        e.ChangedRange.ClearFoldingMarkers()
        e.ChangedRange.SetFoldingMarkers("{", "}")


    End Sub

End Class
