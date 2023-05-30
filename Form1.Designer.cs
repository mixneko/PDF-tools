namespace PDF_tools
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Output_IMG_DPI = new ComboBox();
            label5 = new Label();
            Output_format = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            cmd_PDFtoIMG = new TextBox();
            Execute_PDFtoIMG = new Button();
            BowserOutputFolder = new Button();
            Show_I_OutputFolder = new TextBox();
            label2 = new Label();
            SelectPDFSource = new Button();
            ShowPDF_I_Source = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            Set_PDF_COM_location = new Button();
            Show_PDF_COM_location = new TextBox();
            label9 = new Label();
            execute_PDF_Com = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            Move_to_BOTTOM = new Button();
            Move_DOWN = new Button();
            Move_UP = new Button();
            Move_to_TOP = new Button();
            Del_com_PDF = new Button();
            add_com_pdf = new Button();
            COM_PDF_list = new ListBox();
            tabPage3 = new TabPage();
            button3 = new Button();
            label12 = new Label();
            textBox6 = new TextBox();
            Set_End_Page = new TextBox();
            label11 = new Label();
            Set_Start_Page = new TextBox();
            label10 = new Label();
            Set_PDF_S_location = new Button();
            Show_PDF_S_location = new TextBox();
            label7 = new Label();
            button2 = new Button();
            ShowPDF_S_Source = new TextBox();
            label8 = new Label();
            tabPage4 = new TabPage();
            Set_toIMG_location = new Button();
            Show_toIMG_location = new TextBox();
            Name_toIMG_location = new Label();
            button4 = new Button();
            label14 = new Label();
            textBox3 = new TextBox();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            listBox1 = new ListBox();
            tabPage5 = new TabPage();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            saveFileDialog1 = new SaveFileDialog();
            tabPage0 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage0);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.HotTrack = true;
            resources.ApplyResources(tabControl1, "tabControl1");
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Output_IMG_DPI);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(Output_format);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(cmd_PDFtoIMG);
            tabPage1.Controls.Add(Execute_PDFtoIMG);
            tabPage1.Controls.Add(BowserOutputFolder);
            tabPage1.Controls.Add(Show_I_OutputFolder);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(SelectPDFSource);
            tabPage1.Controls.Add(ShowPDF_I_Source);
            tabPage1.Controls.Add(label1);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Output_IMG_DPI
            // 
            Output_IMG_DPI.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(Output_IMG_DPI, "Output_IMG_DPI");
            Output_IMG_DPI.FormattingEnabled = true;
            Output_IMG_DPI.Items.AddRange(new object[] { resources.GetString("Output_IMG_DPI.Items"), resources.GetString("Output_IMG_DPI.Items1"), resources.GetString("Output_IMG_DPI.Items2"), resources.GetString("Output_IMG_DPI.Items3") });
            Output_IMG_DPI.Name = "Output_IMG_DPI";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // Output_format
            // 
            Output_format.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(Output_format, "Output_format");
            Output_format.FormattingEnabled = true;
            Output_format.Items.AddRange(new object[] { resources.GetString("Output_format.Items"), resources.GetString("Output_format.Items1"), resources.GetString("Output_format.Items2") });
            Output_format.Name = "Output_format";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // cmd_PDFtoIMG
            // 
            cmd_PDFtoIMG.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(cmd_PDFtoIMG, "cmd_PDFtoIMG");
            cmd_PDFtoIMG.Name = "cmd_PDFtoIMG";
            cmd_PDFtoIMG.ReadOnly = true;
            // 
            // Execute_PDFtoIMG
            // 
            resources.ApplyResources(Execute_PDFtoIMG, "Execute_PDFtoIMG");
            Execute_PDFtoIMG.Name = "Execute_PDFtoIMG";
            Execute_PDFtoIMG.UseVisualStyleBackColor = true;
            Execute_PDFtoIMG.Click += Execute_PDFtoIMG_Click;
            // 
            // BowserOutputFolder
            // 
            resources.ApplyResources(BowserOutputFolder, "BowserOutputFolder");
            BowserOutputFolder.Name = "BowserOutputFolder";
            BowserOutputFolder.UseVisualStyleBackColor = true;
            BowserOutputFolder.Click += BowserOutputFolder_Click;
            // 
            // Show_I_OutputFolder
            // 
            resources.ApplyResources(Show_I_OutputFolder, "Show_I_OutputFolder");
            Show_I_OutputFolder.Name = "Show_I_OutputFolder";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // SelectPDFSource
            // 
            resources.ApplyResources(SelectPDFSource, "SelectPDFSource");
            SelectPDFSource.Name = "SelectPDFSource";
            SelectPDFSource.UseVisualStyleBackColor = true;
            SelectPDFSource.Click += SelectPDFSource_Click;
            // 
            // ShowPDF_I_Source
            // 
            resources.ApplyResources(ShowPDF_I_Source, "ShowPDF_I_Source");
            ShowPDF_I_Source.Name = "ShowPDF_I_Source";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Set_PDF_COM_location);
            tabPage2.Controls.Add(Show_PDF_COM_location);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(execute_PDF_Com);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(Move_to_BOTTOM);
            tabPage2.Controls.Add(Move_DOWN);
            tabPage2.Controls.Add(Move_UP);
            tabPage2.Controls.Add(Move_to_TOP);
            tabPage2.Controls.Add(Del_com_PDF);
            tabPage2.Controls.Add(add_com_pdf);
            tabPage2.Controls.Add(COM_PDF_list);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Set_PDF_COM_location
            // 
            resources.ApplyResources(Set_PDF_COM_location, "Set_PDF_COM_location");
            Set_PDF_COM_location.Name = "Set_PDF_COM_location";
            Set_PDF_COM_location.UseVisualStyleBackColor = true;
            // 
            // Show_PDF_COM_location
            // 
            resources.ApplyResources(Show_PDF_COM_location, "Show_PDF_COM_location");
            Show_PDF_COM_location.Name = "Show_PDF_COM_location";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // execute_PDF_Com
            // 
            resources.ApplyResources(execute_PDF_Com, "execute_PDF_Com");
            execute_PDF_Com.Name = "execute_PDF_Com";
            execute_PDF_Com.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox1, "textBox1");
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            // 
            // Move_to_BOTTOM
            // 
            resources.ApplyResources(Move_to_BOTTOM, "Move_to_BOTTOM");
            Move_to_BOTTOM.Name = "Move_to_BOTTOM";
            Move_to_BOTTOM.UseVisualStyleBackColor = true;
            // 
            // Move_DOWN
            // 
            resources.ApplyResources(Move_DOWN, "Move_DOWN");
            Move_DOWN.Name = "Move_DOWN";
            Move_DOWN.UseVisualStyleBackColor = true;
            // 
            // Move_UP
            // 
            resources.ApplyResources(Move_UP, "Move_UP");
            Move_UP.Name = "Move_UP";
            Move_UP.UseVisualStyleBackColor = true;
            // 
            // Move_to_TOP
            // 
            resources.ApplyResources(Move_to_TOP, "Move_to_TOP");
            Move_to_TOP.Name = "Move_to_TOP";
            Move_to_TOP.UseVisualStyleBackColor = true;
            // 
            // Del_com_PDF
            // 
            resources.ApplyResources(Del_com_PDF, "Del_com_PDF");
            Del_com_PDF.Name = "Del_com_PDF";
            Del_com_PDF.UseVisualStyleBackColor = true;
            // 
            // add_com_pdf
            // 
            resources.ApplyResources(add_com_pdf, "add_com_pdf");
            add_com_pdf.Name = "add_com_pdf";
            add_com_pdf.UseVisualStyleBackColor = true;
            // 
            // COM_PDF_list
            // 
            COM_PDF_list.FormattingEnabled = true;
            resources.ApplyResources(COM_PDF_list, "COM_PDF_list");
            COM_PDF_list.Name = "COM_PDF_list";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(textBox6);
            tabPage3.Controls.Add(Set_End_Page);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(Set_Start_Page);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(Set_PDF_S_location);
            tabPage3.Controls.Add(Show_PDF_S_location);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(ShowPDF_S_Source);
            tabPage3.Controls.Add(label8);
            resources.ApplyResources(tabPage3, "tabPage3");
            tabPage3.Name = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            resources.ApplyResources(button3, "button3");
            button3.Name = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox6, "textBox6");
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            // 
            // Set_End_Page
            // 
            resources.ApplyResources(Set_End_Page, "Set_End_Page");
            Set_End_Page.Name = "Set_End_Page";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // Set_Start_Page
            // 
            resources.ApplyResources(Set_Start_Page, "Set_Start_Page");
            Set_Start_Page.Name = "Set_Start_Page";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // Set_PDF_S_location
            // 
            resources.ApplyResources(Set_PDF_S_location, "Set_PDF_S_location");
            Set_PDF_S_location.Name = "Set_PDF_S_location";
            Set_PDF_S_location.UseVisualStyleBackColor = true;
            // 
            // Show_PDF_S_location
            // 
            resources.ApplyResources(Show_PDF_S_location, "Show_PDF_S_location");
            Show_PDF_S_location.Name = "Show_PDF_S_location";
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // button2
            // 
            resources.ApplyResources(button2, "button2");
            button2.Name = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // ShowPDF_S_Source
            // 
            resources.ApplyResources(ShowPDF_S_Source, "ShowPDF_S_Source");
            ShowPDF_S_Source.Name = "ShowPDF_S_Source";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(Set_toIMG_location);
            tabPage4.Controls.Add(Show_toIMG_location);
            tabPage4.Controls.Add(Name_toIMG_location);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(label14);
            tabPage4.Controls.Add(textBox3);
            tabPage4.Controls.Add(button5);
            tabPage4.Controls.Add(button6);
            tabPage4.Controls.Add(button7);
            tabPage4.Controls.Add(button8);
            tabPage4.Controls.Add(button9);
            tabPage4.Controls.Add(button10);
            tabPage4.Controls.Add(listBox1);
            resources.ApplyResources(tabPage4, "tabPage4");
            tabPage4.Name = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Set_toIMG_location
            // 
            resources.ApplyResources(Set_toIMG_location, "Set_toIMG_location");
            Set_toIMG_location.Name = "Set_toIMG_location";
            Set_toIMG_location.UseVisualStyleBackColor = true;
            // 
            // Show_toIMG_location
            // 
            resources.ApplyResources(Show_toIMG_location, "Show_toIMG_location");
            Show_toIMG_location.Name = "Show_toIMG_location";
            // 
            // Name_toIMG_location
            // 
            resources.ApplyResources(Name_toIMG_location, "Name_toIMG_location");
            Name_toIMG_location.Name = "Name_toIMG_location";
            // 
            // button4
            // 
            resources.ApplyResources(button4, "button4");
            button4.Name = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(textBox3, "textBox3");
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            // 
            // button5
            // 
            resources.ApplyResources(button5, "button5");
            button5.Name = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            resources.ApplyResources(button6, "button6");
            button6.Name = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            resources.ApplyResources(button7, "button7");
            button7.Name = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            resources.ApplyResources(button8, "button8");
            button8.Name = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            resources.ApplyResources(button9, "button9");
            button9.Name = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            resources.ApplyResources(button10, "button10");
            button10.Name = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            resources.ApplyResources(listBox1, "listBox1");
            listBox1.Name = "listBox1";
            // 
            // tabPage5
            // 
            resources.ApplyResources(tabPage5, "tabPage5");
            tabPage5.Name = "tabPage5";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage0
            // 
            resources.ApplyResources(tabPage0, "tabPage0");
            tabPage0.Name = "tabPage0";
            tabPage0.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label label1;
        private Button Execute_PDFtoIMG;
        private Button BowserOutputFolder;
        private TextBox Show_I_OutputFolder;
        private Label label2;
        private Button SelectPDFSource;
        private TextBox ShowPDF_I_Source;
        private TextBox cmd_PDFtoIMG;
        private Label label3;
        private Label label4;
        private ComboBox Output_format;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialog1;
        private ComboBox Output_IMG_DPI;
        private Label label5;
        private ListBox COM_PDF_list;
        private Button Move_DOWN;
        private Button Move_UP;
        private Button Move_to_TOP;
        private Button Del_com_PDF;
        private Button add_com_pdf;
        private Button Move_to_BOTTOM;
        private Label label6;
        private TextBox textBox1;
        private Button execute_PDF_Com;
        private Button Set_PDF_S_location;
        private TextBox Show_PDF_S_location;
        private Label label7;
        private Button button2;
        private TextBox ShowPDF_S_Source;
        private Label label8;
        private Button Set_PDF_COM_location;
        private TextBox Show_PDF_COM_location;
        private Label label9;
        private TextBox Set_Start_Page;
        private Label label10;
        private Button button3;
        private Label label12;
        private TextBox textBox6;
        private TextBox Set_End_Page;
        private Label label11;
        private Button Set_toIMG_location;
        private TextBox Show_toIMG_location;
        private Label Name_toIMG_location;
        private Button button4;
        private Label label14;
        private TextBox textBox3;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private ListBox listBox1;
        private TabPage tabPage0;
    }
}