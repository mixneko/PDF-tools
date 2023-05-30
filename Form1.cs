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
                    err_value = "尚未安裝GhostScript";
                    MessageBox.Show("偵測到您" + err_value);
                    this.Close();
                    break;
                case 3:
                    err_value = "尚未安裝ImageMagick";
                    MessageBox.Show("偵測到您" + err_value);
                    this.Close();
                    break;
                case 4:
                    err_value = "尚未安裝 GhostScript 與尚未安裝ImageMagick";
                    MessageBox.Show("偵測到您" + err_value);
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void SelectPDFSource_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(*.PDF)|*.PDF";
            openFileDialog1.FileName = "";
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
    }
}