using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PDF_tools
{
    public partial class Form1 : Form
    {
        public static class GB
        {
            public static string programFilesPath = Environment.GetEnvironmentVariable("ProgramFiles");
            public static string gs_path = programFilesPath + "\\gs\\bin";
            public static string gs = programFilesPath + "\\gs\\bin\\gswin64c.exe";
            public static string convert_path = programFilesPath + "\\ImageMagick";
            public static string convert = programFilesPath + "\\ImageMagick\\convert.exe";
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Output_format.Text = Output_format.Items[0].ToString();
            Output_IMG_DPI.Text = Output_IMG_DPI.Items[1].ToString();
            Del_com_PDF.Enabled = false;
            Move_UP.Enabled = false;
            Move_to_TOP.Enabled = false;
            Move_DOWN.Enabled = false;
            Move_to_BOTTOM.Enabled = false;
            Del_All_COM.Enabled = false;
            int err = 0;
            string err_value;
            string programFilesPath = Environment.GetEnvironmentVariable("ProgramFiles");
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

        private void Set_GS_location_Click(object sender, EventArgs e)
        {
            bool er = true;
            while (er)
            {
                folderBrowserDialog1.SelectedPath = GB.programFilesPath + "\\gs\\";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(folderBrowserDialog1.SelectedPath + "\\gswin64c.exe") == false)
                    {
                        MessageBox.Show("此目錄未偵測到gswin64c.exe，請確認環境變數");
                    }
                    else if (File.Exists(folderBrowserDialog1.SelectedPath + "\\gswin64c.exe") == true)
                    {
                        MessageBox.Show("已成功偵測到gswin64c.exe，");
                        Show_GS_location.Enabled = false;
                        Set_GS_location.Enabled = false;
                        Show_GS_location.Text = GB.gs;
                        er = false;
                    }
                }
            }
        }
        private void Set_IM_location_Click(object sender, EventArgs e)
        {
            bool er = true;
            while (er)
            {
                folderBrowserDialog1.SelectedPath = GB.programFilesPath + "\\ImageMagick\\";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(folderBrowserDialog1.SelectedPath + "\\convert.exe") == false)
                    {
                        MessageBox.Show("此目錄未偵測到convert.exe，請確認環境變數");
                    }
                    else if (File.Exists(folderBrowserDialog1.SelectedPath + "\\convert.exe") == true)
                    {
                        MessageBox.Show("已成功偵測到convert.exe，");
                        Show_IM_location.Enabled = false;
                        Set_IM_location.Enabled = false;
                        Show_GS_location.Text = GB.convert;
                        er = false;
                    }
                }
            }
        }

        private void SelectPDFSource_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.PDF)|*.PDF";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ShowPDF_I_Source.Text = openFileDialog1.FileName;
            }
        }

        private void BowserOutputFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                Show_I_OutputFolder.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void Execute_PDFtoIMG_Click(object sender, EventArgs e)
        {
            if (File.Exists(ShowPDF_I_Source.Text) == false)
            {
                MessageBox.Show("來源檔案不存在，請確認");
            }
            else if (Directory.Exists(Show_I_OutputFolder.Text) == false)
            {
                MessageBox.Show("輸出資料夾位置不存在，請確認");
            }
            else
            {
                int ext = Output_format.SelectedIndex;
                string dpi = Output_IMG_DPI.SelectedItem.ToString();
                string OutputF1 = Show_I_OutputFolder.Text;
                string InputF = ShowPDF_I_Source.Text;
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
                using (StreamWriter sw = new StreamWriter(bat_Name))
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
                StringBuilder cmdOutput = new StringBuilder();
                cmd.OutputDataReceived += (sender, args) => cmdOutput.AppendLine(args.Data);
                cmd.ErrorDataReceived += (sender, args) => cmdOutput.AppendLine(args.Data);
                cmd.Start();
                cmd.BeginOutputReadLine();
                cmd.BeginErrorReadLine();
                cmd.WaitForExit();
                if (cmd_PDFtoIMG.Text == "")
                {
                    cmd_PDFtoIMG.Text = cmdOutput.ToString();
                }
                else if (cmd_PDFtoIMG.Text != "")
                {
                    cmd_PDFtoIMG.Text = cmd_PDFtoIMG.Text + "\r\n" + cmdOutput.ToString();
                }
                cmd.Close();
            }
        }

        private void COM_PDF_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectItem = COM_PDF_list.SelectedItem?.ToString() ?? "";
            if (SelectItem != "")
            {
                Del_com_PDF.Enabled = true;
                Move_UP.Enabled = true;
                Move_to_TOP.Enabled = true;
                Move_DOWN.Enabled = true;
                Move_to_BOTTOM.Enabled = true;
                Del_All_COM.Enabled = true;
            }
            else if (SelectItem == "")
            {
                Del_com_PDF.Enabled = false;
                Move_UP.Enabled = false;
                Move_to_TOP.Enabled = false;
                Move_DOWN.Enabled = false;
                Move_to_BOTTOM.Enabled = false;
                Del_All_COM.Enabled = false;
            }
        }

        private void add_com_pdf_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.PDF)|*.PDF";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                COM_PDF_list.Items.AddRange(openFileDialog1.FileNames);
            }
        }

        private void Del_com_PDF_Click(object sender, EventArgs e)
        {
            string SelectItem = COM_PDF_list.SelectedItem?.ToString() ?? "";
            if (SelectItem != "")
            {
                COM_PDF_list.Items.Remove(COM_PDF_list.SelectedItem);
            }

        }

        private void Move_to_TOP_Click(object sender, EventArgs e)
        {
            string SelectItem = COM_PDF_list.SelectedItem?.ToString();
            COM_PDF_list.Items.Remove(SelectItem);
            COM_PDF_list.Items.Insert(0, SelectItem);
            COM_PDF_list.SelectedIndex = 0;
        }

        private void Move_UP_Click(object sender, EventArgs e)
        {
            int SelectItemIndex = COM_PDF_list.SelectedIndex;
            if (SelectItemIndex >  0)
            {
                string SelectItem = COM_PDF_list.SelectedItem?.ToString();
                COM_PDF_list.Items.RemoveAt(SelectItemIndex);
                COM_PDF_list.Items.Insert(SelectItemIndex - 1, SelectItem);
                COM_PDF_list.SelectedIndex = SelectItemIndex - 1; // 選擇被移動的項目
            }
        }

        private void Move_DOWN_Click(object sender, EventArgs e)
        {
            int SelectItemIndex = COM_PDF_list.SelectedIndex;
            if (SelectItemIndex < COM_PDF_list.Items.Count - 1)
            {
                string SelectItem = COM_PDF_list.SelectedItem?.ToString();
                COM_PDF_list.Items.RemoveAt(SelectItemIndex);
                COM_PDF_list.Items.Insert(SelectItemIndex + 1, SelectItem);
                COM_PDF_list.SelectedIndex = SelectItemIndex + 1; // 選擇被移動的項目
            }
        }

        private void Move_to_BOTTOM_Click(object sender, EventArgs e)
        {
            string SelectItem = COM_PDF_list.SelectedItem?.ToString();
            COM_PDF_list.Items.Remove(SelectItem);
            COM_PDF_list.Items.Insert(COM_PDF_list.Items.Count, SelectItem);
            COM_PDF_list.SelectedIndex = COM_PDF_list.Items.Count - 1;
        }

        private void Del_All_COM_Click(object sender, EventArgs e)
        {
            COM_PDF_list.Items.Clear();
        }
    }
}