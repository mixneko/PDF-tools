using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace PDF_tools
{
    public partial class Form1 : Form
    {
        public static class GB
        {
            public static string programFilesPath = Environment.GetEnvironmentVariable("ProgramFiles");
            public static string gs_path = programFilesPath + @"\gs\bin";
            public static string gs = gs_path + @"\gswin64c.exe";
            public static string convert_path = programFilesPath + @"\ImageMagick";
            public static string convert = convert_path + @"\convert.exe";
            public static string Setting_path = Environment.GetEnvironmentVariable("AppData") + @"\PDF_tools";
            public static string Setting_file = Setting_path + @"\setting.ini";
            public static bool gs_read = false;
            public static bool convert_read = false;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Output_format.Text = Output_format.Items[0].ToString();
            Output_IMG_DPI.Text = Output_IMG_DPI.Items[1].ToString();
            Del_compare_PDF.Enabled = false;
            Move_UP.Enabled = false;
            Move_to_TOP.Enabled = false;
            Move_DOWN.Enabled = false;
            Move_to_BOTTOM.Enabled = false;
            Del_All_COM.Enabled = false;
            if (Directory.Exists(GB.Setting_path) == false)
            {
                Directory.CreateDirectory(GB.Setting_path);
            }
            execute_PDF_Compare.Enabled = false;
            try
            {
                if (File.Exists($"{GB.Setting_file}"))
                {
                    foreach (var line in File.ReadLines($"{GB.Setting_file}"))
                    {
                        // 將每一行分割成鍵和值
                        var parts = line.Split('=');
                        if (parts.Length == 2)
                        {
                            var key = parts[0].Trim();
                            var value = parts[1].Trim();

                            // 根據鍵來處理值
                            switch (key)
                            {
                                case "GS":
                                    // 處理 GS 的值
                                    GB.gs = value;
                                    GB.gs_path = Path.GetDirectoryName(value);
                                    break;
                                case "IM":
                                    // 處理 IM 的值
                                    GB.convert = value;
                                    GB.convert_path = Path.GetDirectoryName(value);
                                    break;
                            }
                        }
                    }
                }
                else
                {
                    File.Create($"{GB.Setting_file}").Close();
                    Setting();
                }
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
            int err = 0;
            string err_value;
            if (Directory.Exists(GB.gs_path) == false)
            {
                err++;
            }
            if (Directory.Exists(GB.convert_path) == false)
            {
                err += 3;
            }
            switch (err)
            {
                case 1:
                    err_value = "可能尚未安裝GhostScript，請手動指定或安裝";
                    Show_IM_location.Text = GB.convert;
                    Set_IM_location.Enabled = false;
                    Show_IM_location.Enabled = false;
                    MessageBox.Show("偵測到您" + err_value);
                    break;
                case 3:
                    err_value = "可能尚未安裝ImageMagick或未安裝 ImageMagick 之 convert 套件，請手動指定或安裝";
                    Show_GS_location.Text = GB.gs;
                    Set_GS_location.Enabled = false;
                    Show_GS_location.Enabled = false;
                    MessageBox.Show("偵測到您" + err_value);
                    break;
                case 4:
                    err_value = "可能尚未安裝 GhostScript、ImageMagick或 ImageMagick 之 convert 套件，請手動指定或安裝";
                    MessageBox.Show("偵測到您" + err_value);
                    break;
                default:
                    Show_GS_location.Text = GB.gs;
                    Show_IM_location.Text = GB.convert;
                    Set_IM_location.Enabled = false;
                    Show_IM_location.Enabled = false;
                    Set_GS_location.Enabled = false;
                    Show_GS_location.Enabled = false;
                    break;
            }
        }

        private static void Setting()
        {
            string gsValue = GB.gs.ToString();
            string imValue = GB.convert.ToString();
            string data = $"GS={gsValue}\nIM={imValue}";
            try
            {
                File.WriteAllText($"{GB.Setting_file}", data);
            }
            catch (Exception i)
            {
                MessageBox.Show(i.Message);
            }
        }

        private void Set_GS_location_Click(object sender, EventArgs e)
        {
            bool er = true;
            while (er)
            {
                folderBrowserDialog1.SelectedPath = GB.programFilesPath + "\\gs\\";
                switch (folderBrowserDialog1.ShowDialog())
                {
                    case DialogResult.OK:
                        if (File.Exists(folderBrowserDialog1.SelectedPath + "\\gswin64c.exe") == false)
                        {
                            MessageBox.Show("此目錄未偵測到gswin64c.exe，請確認環境變數");
                        }
                        else if (File.Exists(folderBrowserDialog1.SelectedPath + "\\gswin64c.exe") == true)
                        {
                            MessageBox.Show("已成功偵測到gswin64c.exe，");
                            Show_GS_location.Enabled = false;
                            Set_GS_location.Enabled = false;
                            Show_GS_location.Text = folderBrowserDialog1.SelectedPath + "\\gswin64c.exe";
                            GB.gs = Show_GS_location.Text;
                            GB.gs_path = folderBrowserDialog1.SelectedPath;
                            er = false;
                            Setting();
                        }
                        break;
                    case DialogResult.Cancel:
                        er = false;
                        break;
                }
            }
        }
        private void Set_IM_location_Click(object sender, EventArgs e)
        {
            bool er = true;
            while (er)
            {
                folderBrowserDialog1.SelectedPath = GB.programFilesPath + "\\ImageMagick\\";
                switch (folderBrowserDialog1.ShowDialog())
                {
                    case DialogResult.OK:
                        if (File.Exists(folderBrowserDialog1.SelectedPath + "\\convert.exe") == false)
                        {
                            MessageBox.Show("此目錄未偵測到convert.exe，請確認環境變數");
                        }
                        else if (File.Exists(folderBrowserDialog1.SelectedPath + "\\convert.exe") == true)
                        {
                            MessageBox.Show("已成功偵測到convert.exe，");
                            Show_IM_location.Enabled = false;
                            Set_IM_location.Enabled = false;
                            Show_IM_location.Text = folderBrowserDialog1.SelectedPath + "\\convert.exe";
                            GB.convert_path = folderBrowserDialog1.SelectedPath;
                            GB.convert = Show_IM_location.Text;
                            er = false;
                            Setting();
                        }
                        break;
                    case DialogResult.Cancel:
                        er = false;
                        break;
                }
            }
        }

        private void SelectPDFSource_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.PDF)|*.PDF";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
            bool er = true;
            while (er)
            {
                switch (openFileDialog1.ShowDialog())
                {
                    case DialogResult.OK:
                        if (Path.GetExtension(openFileDialog1.FileName) == ".pdf")
                        {
                            Show_PDFtoImage_Source.Text = openFileDialog1.FileName;
                            er = false;
                        }
                        else if ((Path.GetExtension(openFileDialog1.FileName) != ".pdf"))
                        {
                            MessageBox.Show("您輸入的檔案格式不受支援，請重新選擇。");
                        }
                        break;
                    case DialogResult.Cancel:
                        er = false;
                        break;
                }
            }
        }

        private void BowserOutputFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Show_PDFtoImage_OutputFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Execute_PDFtoIMG_Click(object sender, EventArgs e)
        {
            if (File.Exists(Show_PDFtoImage_Source.Text) == false)
            {
                MessageBox.Show("來源檔案不存在，請確認");
            }
            else if (Directory.Exists(Show_PDFtoImage_OutputFolder.Text) == false)
            {
                MessageBox.Show("輸出資料夾位置不存在，請確認");
            }
            else if (File.Exists(GB.gs) == false)
            {
                MessageBox.Show("您尚未指定GhostScript路徑或GhostScript已被移動導致無法執行");
                Set_GS_location.Enabled = true;
                Show_GS_location.Enabled = true;
                PDF_Compare.SelectedTab = Env;
            }
            else
            {
                int ext = Output_format.SelectedIndex;
                string dpi = Output_IMG_DPI.SelectedItem?.ToString() ?? "";
                string OutputF1 = Show_PDFtoImage_OutputFolder.Text;
                string InputF = Show_PDFtoImage_Source.Text;
                string GetInputFileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
                string Output = OutputF1 + "\\" + GetInputFileName;
                string Exten = Path.GetExtension(openFileDialog1.FileName);
                string ext_val = "";
                string ext_name = "";
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                switch (ext)
                {
                    case 0:
                        ext_name = "pngalpha";
                        ext_val = ".png";
                        break;
                    case 1:
                        ext_name = "png16m";
                        ext_val = ".png";
                        break;
                    case 2:
                        ext_name = "jpeg";
                        ext_val = ".jpg";
                        break;
                }
                string bat_Name = @".\Pdf_tools_temp.bat";
                using (StreamWriter sw = new(bat_Name))
                {
                    sw.WriteLine("@echo off");
                    sw.WriteLine("chcp 65001");
                    sw.WriteLine("cd " + OutputF1);
                    if (Directory.Exists(Output) == false)
                    {
                        sw.WriteLine("mkdir " + GetInputFileName);
                    }
                    sw.WriteLine("\"" + GB.gs + "\"" + " -sDEVICE=" + ext_name + " -o \"" + Output + "\\" + GetInputFileName + "-%%03d" + ext_val + "\" -r" + dpi + " \"" + InputF + "\"");
                    sw.WriteLine("exit");
                }
                Process cmd = new();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.Arguments = "/c " + bat_Name;
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.RedirectStandardOutput = true;// 由呼叫程式獲取輸出資訊
                cmd.StartInfo.RedirectStandardError = true;//重定向標準錯誤輸出
                cmd.StartInfo.CreateNoWindow = true; //不跳出cmd視窗
                cmd.StartInfo.StandardOutputEncoding = System.Text.Encoding.UTF8;
                cmd.StartInfo.StandardErrorEncoding = System.Text.Encoding.GetEncoding("big5");
                StringBuilder cmdOutput = new();
                cmd.OutputDataReceived += (sender, args) => cmdOutput.AppendLine(args.Data);
                cmd.ErrorDataReceived += (sender, args) => cmdOutput.AppendLine(args.Data);
                cmd.Start();
                cmd.BeginOutputReadLine();
                cmd.BeginErrorReadLine();
                cmd.WaitForExit();
                cmd_PDFtoIMG.Text += cmdOutput.ToString() + "\r\n------------------------------------------------\r\n";
                cmd_PDFtoIMG.SelectionStart = cmd_PDFtoIMG.Text.Length;
                cmd_PDFtoIMG.ScrollToCaret();
                cmd.Close();
                File.Delete(bat_Name);
            }
        }

        private void COM_PDF_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Item = Compare_PDF_list.Items.Count;
            switch (Item)
            {
                case 0:
                    Del_compare_PDF.Enabled = false;
                    Move_UP.Enabled = false;
                    Move_to_TOP.Enabled = false;
                    Move_DOWN.Enabled = false;
                    Move_to_BOTTOM.Enabled = false;
                    Del_All_COM.Enabled = false;
                    execute_PDF_Compare.Enabled = false;
                    break;
                case 1:
                    Del_compare_PDF.Enabled = true;
                    Move_UP.Enabled = false;
                    Move_to_TOP.Enabled = false;
                    Move_DOWN.Enabled = false;
                    Move_to_BOTTOM.Enabled = false;
                    Del_All_COM.Enabled = true;
                    execute_PDF_Compare.Enabled = false;
                    break;
                case >= 2:
                    Del_compare_PDF.Enabled = true;
                    Move_UP.Enabled = true;
                    Move_to_TOP.Enabled = true;
                    Move_DOWN.Enabled = true;
                    Move_to_BOTTOM.Enabled = true;
                    Del_All_COM.Enabled = true;
                    execute_PDF_Compare.Enabled = true;
                    break;
            }
        }

        private void add_com_pdf_Click(object sender, EventArgs e)
        {
            bool er = true;
            openFileDialog1.Filter = "(*.PDF)|*.PDF";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = true;
            while (er)
            {
                switch (openFileDialog1.ShowDialog())
                {
                    case DialogResult.OK:
                        int Count = openFileDialog1.FileNames.Length;
                        er = false;
                        for (int i = 0; i <= Count; i++)
                        {
                            if ((Path.GetExtension(openFileDialog1.FileName) != ".pdf"))
                            {
                                er = true;
                            }
                        }
                        if (er == false)
                        {
                            Compare_PDF_list.Items.AddRange(openFileDialog1.FileNames);
                            Compare_PDF_list.SelectedIndex = Compare_PDF_list.Items.Count - 1;
                        }
                        else if (er == true)
                        {
                            MessageBox.Show("請不要插入非相關的東西");
                        }
                        break;
                    case DialogResult.Cancel:
                        er = false;
                        break;
                }
            }
        }

        private void Del_com_PDF_Click(object sender, EventArgs e)
        {
            int Item = Compare_PDF_list.SelectedIndex;
            switch (Item)
            {
                case 0:
                    Compare_PDF_list.Items.RemoveAt(Item);
                    if (Compare_PDF_list.Items.Count > 0)
                    {
                        Compare_PDF_list.SelectedIndex = Item;
                    }
                    break;
                case > 0:
                    Compare_PDF_list.Items.RemoveAt(Item);
                    Compare_PDF_list.SelectedIndex = Item - 1;
                    break;
            }
        }

        private void Move_to_TOP_Click(object sender, EventArgs e)
        {
            string SelectItem = Compare_PDF_list.SelectedItem?.ToString() ?? "";
            int Item = Compare_PDF_list.SelectedIndex;
            Compare_PDF_list.Items.RemoveAt(Item);
            Compare_PDF_list.Items.Insert(0, SelectItem);
            Compare_PDF_list.SelectedIndex = 0;
        }

        private void Move_UP_Click(object sender, EventArgs e)
        {
            int SelectItemIndex = Compare_PDF_list.SelectedIndex;
            if (SelectItemIndex > 0)
            {
                string SelectItem = Compare_PDF_list.SelectedItem?.ToString() ?? "";
                Compare_PDF_list.Items.RemoveAt(SelectItemIndex);
                Compare_PDF_list.Items.Insert(SelectItemIndex - 1, SelectItem);
                Compare_PDF_list.SelectedIndex = SelectItemIndex - 1; // 選擇被移動的項目
            }
        }

        private void Move_DOWN_Click(object sender, EventArgs e)
        {
            int SelectItemIndex = Compare_PDF_list.SelectedIndex;
            if (SelectItemIndex < Compare_PDF_list.Items.Count - 1)
            {
                string SelectItem = Compare_PDF_list.SelectedItem?.ToString() ?? "";
                Compare_PDF_list.Items.RemoveAt(SelectItemIndex);
                Compare_PDF_list.Items.Insert(SelectItemIndex + 1, SelectItem);
                Compare_PDF_list.SelectedIndex = SelectItemIndex + 1; // 選擇被移動的項目
            }
        }

        private void Move_to_BOTTOM_Click(object sender, EventArgs e)
        {
            string SelectItem = Compare_PDF_list.SelectedItem?.ToString() ?? "";
            int Item = Compare_PDF_list.SelectedIndex;
            Compare_PDF_list.Items.RemoveAt(Item);
            Compare_PDF_list.Items.Insert(Compare_PDF_list.Items.Count, SelectItem);
            Compare_PDF_list.SelectedIndex = Compare_PDF_list.Items.Count - 1;
        }

        private void Del_All_COM_Click(object sender, EventArgs e)
        {
            Compare_PDF_list.Items.Clear();
        }

        private void Set_PDF_COM_location_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.PDF)|*.PDF";
            saveFileDialog1.FileName = "";
            bool er = true;
            while (er)
            {
                switch (saveFileDialog1.ShowDialog())
                {
                    case DialogResult.OK:
                        if (Path.GetExtension(saveFileDialog1.FileName) == ".pdf")
                        {
                            Show_PDF_Compare_SaveLocation.Text = saveFileDialog1.FileName;
                            er = false;
                        }
                        else if ((Path.GetExtension(saveFileDialog1.FileName) != ".pdf"))
                        {
                            Show_PDF_Compare_SaveLocation.Text = saveFileDialog1.FileName + ".pdf";
                            er = false;
                        }
                        break;
                    case DialogResult.Cancel:
                        er = false;
                        break;
                }
            }
        }

        private void execute_PDF_Com_Click(object sender, EventArgs e)
        {
            int L = Compare_PDF_list.Items.Count;
            if (File.Exists(GB.gs) == true)
            {
                StringBuilder WL = new($"\"{GB.gs}\" -sDEVICE=pdfwrite -dNOPAUSE -dBATCH -dQUITE -sOutputFile=\"{Show_PDF_Compare_SaveLocation.Text}\"");
                for (int i = 0; i < L; i++)
                {
                    string InputFile = Compare_PDF_list.Items[i]?.ToString() ?? "";
                    WL.Append($" \"{InputFile}\"");
                }
                Process cmd = new();
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.UseShellExecute = false;
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;// 由呼叫程式獲取輸出資訊
                cmd.StartInfo.RedirectStandardError = true;//重定向標準錯誤輸出
                cmd.StartInfo.CreateNoWindow = true; //不跳出cmd視窗
                StringBuilder cmdOutput = new();
                cmd.OutputDataReceived += (sender, args) => cmdOutput.AppendLine(args.Data);
                cmd.ErrorDataReceived += (sender, args) => cmdOutput.AppendLine(args.Data);
                cmd.Start();
                cmd.BeginOutputReadLine();
                cmd.BeginErrorReadLine();
                cmd.StandardInput.WriteLine(WL);
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine("exit");
                cmd.WaitForExit();
                cmd_PDF_Compare.Text += cmdOutput.ToString() + "\r\n------------------------------------------------\r\n";
                cmd_PDF_Compare.SelectionStart = cmd_PDF_Compare.Text.Length;
                cmd_PDF_Compare.ScrollToCaret();
                cmd.Close();
            }
            else if (File.Exists(GB.gs) == false)
            {
                MessageBox.Show("您尚未指定GhostScript路徑或GhostScript已被移動導致無法執行");
                Set_GS_location.Enabled = true;
                Show_GS_location.Enabled = true;
                PDF_Compare.SelectedTab = Env;
            }
        }

        private void Set_Start_Page_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }
        private void Set_End_Page_KeyPress(Object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void Select_PDF_Split_Source_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.PDF)|*.PDF";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
            bool er = true;
            while (er)
            {
                switch (openFileDialog1.ShowDialog())
                {
                    case DialogResult.OK:
                        if (Path.GetExtension(openFileDialog1.FileName) == ".pdf")
                        {
                            Show_PDF_Split_Source.Text = openFileDialog1.FileName;
                            er = false;
                        }
                        else if ((Path.GetExtension(openFileDialog1.FileName) != ".pdf"))
                        {
                            MessageBox.Show("您輸入的檔案格式不受支援，請重新選擇。");
                        }
                        break;
                    case DialogResult.Cancel:
                        er = false;
                        break;
                }
            }
        }

        private void Set_PDF_Split_location_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "(*.pdf)|*.pdf";
            saveFileDialog1.FileName = "";
            bool er = true;
            while (er)
            {
                switch (saveFileDialog1.ShowDialog())
                {
                    case DialogResult.OK:
                        string fileExtension = Path.GetExtension(saveFileDialog1.FileName);
                        if (string.Equals(fileExtension, ".pdf", StringComparison.OrdinalIgnoreCase))
                        {
                            Show_PDF_Split_SaveLocation.Text = saveFileDialog1.FileName;
                            er = false;
                        }
                        else
                        {
                            Show_PDF_Split_SaveLocation.Text = saveFileDialog1.FileName + ".pdf";
                            er = false;
                        }
                        break;
                    case DialogResult.Cancel:
                        er = false;
                        break;
                }
            }
        }

        private void Execute_PDF_Split_Click(object sender, EventArgs e)
        {
            if (File.Exists(Show_PDF_Split_Source.Text))
            {
                if (Show_PDF_Split_Source.Text != "" && Show_PDF_Split_SaveLocation.Text !="")
                {
                    int Start_Page = int.Parse(Set_Start_Page.Text);
                    int End_Page = int.Parse(Set_End_Page.Text);
                    if (Start_Page > End_Page)
                    {
                        (End_Page, Start_Page) = (Start_Page, End_Page);
                    }
                    if (File.Exists(GB.gs) == true)
                    {
                        StringBuilder WL = new($"\"{GB.gs}\" -sDEVICE=pdfwrite -dNOPAUSE -dBATCH -dSAFER -dFirstPage=" + Start_Page.ToString() + " -dLastPage=" + End_Page.ToString() + " -sOutputFile=" + "\"" + Show_PDF_Split_SaveLocation.Text + "\" \"" + Show_PDF_Split_Source.Text + "\"");
                        Process cmd = new();
                        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                        cmd.StartInfo.FileName = "cmd.exe";
                        cmd.StartInfo.UseShellExecute = false;
                        cmd.StartInfo.RedirectStandardInput = true;
                        cmd.StartInfo.RedirectStandardOutput = true;// 由呼叫程式獲取輸出資訊
                        cmd.StartInfo.RedirectStandardError = true;//重定向標準錯誤輸出
                        cmd.StartInfo.CreateNoWindow = true; //不跳出cmd視窗
                        StringBuilder cmdOutput = new();
                        cmd.OutputDataReceived += (sender, args) => cmdOutput.AppendLine(args.Data);
                        cmd.Start();
                        cmd.BeginOutputReadLine();
                        cmd.StandardInput.WriteLine(WL);
                        cmd.StandardInput.Flush();
                        cmd.StandardInput.WriteLine("exit");
                        cmd.WaitForExit();
                        cmd_PDF_Split.Text += cmdOutput.ToString() + "\r\n------------------------------------------------\r\n";
                        cmd_PDF_Split.SelectionStart = cmd_PDF_Split.Text.Length;
                        cmd_PDF_Split.ScrollToCaret();
                        cmd.Close();
                    }
                    else if (File.Exists(GB.gs) == false)
                    {
                        MessageBox.Show("您尚未指定GhostScript路徑或GhostScript已被移動導致無法執行");
                        Set_GS_location.Enabled = true;
                        Show_GS_location.Enabled = true;
                        PDF_Compare.SelectedTab = Env;
                    }
                }
                else
                {
                    MessageBox.Show("尚未完成應有資訊之輸入");
                }
            }
            else
            {
                MessageBox.Show("指定之來源PDF不存在");
            }
        }

        private void Add_ImagetoPDF_Source_Click(object sender, EventArgs e)
        {
            bool er = true;
            openFileDialog1.Filter = "支援的圖像檔|*.png;*.jpg";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = true;
            while (er)
            {
                switch (openFileDialog1.ShowDialog())
                {
                    case DialogResult.OK:
                        int Count = openFileDialog1.FileNames.Length;
                        er = false;
                        for (int i = 0; i <= Count; i++)
                        {
                            switch (Path.GetExtension(openFileDialog1.FileName))
                            {
                                case ".png":
                                    break;
                                case ".jpg":
                                    break;
                                default:
                                    er = true;
                                    break;
                            }
                        }
                        if (er == false)
                        {
                            IMGtoPDF_list.Items.AddRange(openFileDialog1.FileNames);
                            IMGtoPDF_list.SelectedIndex = IMGtoPDF_list.Items.Count - 1;
                        }
                        else if (er == true)
                        {
                            MessageBox.Show("請不要插入非相關的東西");
                        }
                        break;
                    case DialogResult.Cancel:
                        er = false;
                        break;
                }
            }
        }

        private void Del_ImagetoPDF_Source_Click(object sender, EventArgs e)
        {
            int Item = IMGtoPDF_list.SelectedIndex;
            switch (Item)
            {
                case 0:
                    IMGtoPDF_list.Items.RemoveAt(Item);
                    if (IMGtoPDF_list.Items.Count > 0)
                    {
                        IMGtoPDF_list.SelectedIndex = Item;
                    }
                    break;
                case > 0:
                    IMGtoPDF_list.Items.RemoveAt(Item);
                    IMGtoPDF_list.SelectedIndex = Item - 1;
                    break;
            }
        }

        private void Clear_ImagetoPDF_Source_Click(object sender, EventArgs e)
        {
            IMGtoPDF_list.Items.Clear();
        }

        private void Set_IMGtoPDF_SaveLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Show_IMGtoPDF_SaveLocation.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Execute_IMGtoPDF_Click(object sender, EventArgs e)
        {
            if (IMGtoPDF_list.Items.Count > 0 || Directory.Exists(Show_IMGtoPDF_SaveLocation.Text))
            {
                if (File.Exists(GB.convert) == true)
                {
                    int i;
                    for (i = 0; i < IMGtoPDF_list.Items.Count; i++)
                    {
                        Process cmd = new();
                        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                        cmd.StartInfo.FileName = "cmd.exe";
                        cmd.StartInfo.UseShellExecute = false;
                        cmd.StartInfo.RedirectStandardInput = true;
                        cmd.StartInfo.RedirectStandardOutput = true;// 由呼叫程式獲取輸出資訊
                        cmd.StartInfo.RedirectStandardError = true;//重定向標準錯誤輸出
                        cmd.StartInfo.CreateNoWindow = true; //不跳出cmd視窗
                        StringBuilder cmdOutput = new();
                        cmd.OutputDataReceived += (sender, args) => cmdOutput.AppendLine(args.Data);
                        cmd.Start();
                        cmd.BeginOutputReadLine();
                        string item = IMGtoPDF_list.Items[i]?.ToString() ?? "";
                        string FileName = Path.GetFileNameWithoutExtension(item);
                        string WL = "\"" + GB.convert + "\" \"" + item + "\" \"" + Show_IMGtoPDF_SaveLocation.Text + "\\" + FileName + ".pdf\"";
                        cmd.StandardInput.WriteLine(WL);
                        cmd.StandardInput.Flush();
                        cmd.StandardInput.WriteLine("exit");
                        cmd.WaitForExit();
                        cmd_IMGtoPDF.Text += cmdOutput.ToString() + "\r\n------------------------------------------------\r\n";
                        cmd_IMGtoPDF.SelectionStart = cmd_IMGtoPDF.Text.Length;
                        cmd_IMGtoPDF.ScrollToCaret();
                        cmd.Close();
                    }
                    MessageBox.Show("已全部轉換完畢。");
                }
                else if (File.Exists(GB.convert) == false)
                {
                    MessageBox.Show("您尚未指定ImageMagick路徑或ImageMagick中的convert.exe已被移動或不存在導致無法執行");
                    Set_IM_location.Enabled = true;
                    Show_IM_location.Enabled = true;
                    PDF_Compare.SelectedTab = Env;
                }
            }
            else
            {
                MessageBox.Show("尚未完成應有資訊之輸入");
            }
        }

        private void GhostScript_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = "https://www.ghostscript.com/";
            VisitLink(target);
        }

        private void ImageMagick_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = "https://imagemagick.org/index.php";
            VisitLink(target);
        }

        private void flaticon_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = "https://www.flaticon.com/free-icon/pdf_1644129";
            VisitLink(target);
        }

        private void mixneko_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string target = "https://github.com/mixneko/PDF-tools";
            VisitLink(target);
        }

        private static void VisitLink(string target)
        {
            try
            {
                Process.Start(new ProcessStartInfo(target) { UseShellExecute = true });
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}