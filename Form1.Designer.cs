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
            PDF_Compare = new TabControl();
            Env = new TabPage();
            Set_IM_location = new Button();
            Show_IM_location = new TextBox();
            NameOf_IM_location = new Label();
            Set_GS_location = new Button();
            Show_GS_location = new TextBox();
            NameOf_Show_GS_location = new Label();
            PDFtoImage = new TabPage();
            Output_IMG_DPI = new ComboBox();
            NameOf_Output_IMG_DPI = new Label();
            Output_format = new ComboBox();
            NameOf_Output_format = new Label();
            NameOf_cmd_PDFtoIMG = new Label();
            cmd_PDFtoIMG = new TextBox();
            Execute_PDFtoIMG = new Button();
            BowserOutputFolder = new Button();
            Show_PDFtoImage_OutputFolder = new TextBox();
            NameOf_PDFtoImage_OutputFolder = new Label();
            SelectPDFSource = new Button();
            Show_PDFtoImage_Source = new TextBox();
            NameOf_PDFtoImage_Source = new Label();
            tabPage2 = new TabPage();
            Del_All_COM = new Button();
            Set_PDF_Compare_SaveLocation = new Button();
            Show_PDF_Compare_SaveLocation = new TextBox();
            NameOf_PDF_Compare_location = new Label();
            execute_PDF_Compare = new Button();
            NameOf_cmd_PDF_Compare = new Label();
            cmd_PDF_Compare = new TextBox();
            Move_to_BOTTOM = new Button();
            Move_DOWN = new Button();
            Move_UP = new Button();
            Move_to_TOP = new Button();
            Del_compare_PDF = new Button();
            add_compare_pdf = new Button();
            Compare_PDF_list = new ListBox();
            PDF_Split = new TabPage();
            Execute_PDF_Split = new Button();
            NameOf_cmd_PDF_Split = new Label();
            cmd_PDF_Split = new TextBox();
            Set_End_Page = new TextBox();
            NameOf_Set_End_Page = new Label();
            Set_Start_Page = new TextBox();
            NameOf_Set_Start_Page = new Label();
            Set_PDF_Split_SaveLocation = new Button();
            Show_PDF_Split_SaveLocation = new TextBox();
            NameOF_PDF_Split_location = new Label();
            Select_PDF_Split_Source = new Button();
            Show_PDF_Split_Source = new TextBox();
            NameOf_PDF_Split_Source = new Label();
            tabPage4 = new TabPage();
            Clear_ImagetoPDF_Source = new Button();
            Set_IMGtoPDF_SaveLocation = new Button();
            Show_IMGtoPDF_SaveLocation = new TextBox();
            Name_toIMG_location = new Label();
            Execute_IMGtoPDF = new Button();
            Nameof_IMGtoPDF_cmd = new Label();
            cmd_IMGtoPDF = new TextBox();
            Del_ImagetoPDF_Source = new Button();
            Add_ImagetoPDF_Source = new Button();
            IMGtoPDF_list = new ListBox();
            about = new TabPage();
            License = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            ImageMagick_License = new TextBox();
            GhostScript_License = new TextBox();
            pictureBox1 = new PictureBox();
            flaticon_link = new LinkLabel();
            ImageMagick_link = new LinkLabel();
            GhostScript_link = new LinkLabel();
            label1 = new Label();
            NameOfAuther = new Label();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            saveFileDialog1 = new SaveFileDialog();
            mixneko_link = new LinkLabel();
            PDF_Compare.SuspendLayout();
            Env.SuspendLayout();
            PDFtoImage.SuspendLayout();
            tabPage2.SuspendLayout();
            PDF_Split.SuspendLayout();
            tabPage4.SuspendLayout();
            about.SuspendLayout();
            License.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PDF_Compare
            // 
            PDF_Compare.Controls.Add(Env);
            PDF_Compare.Controls.Add(PDFtoImage);
            PDF_Compare.Controls.Add(tabPage2);
            PDF_Compare.Controls.Add(PDF_Split);
            PDF_Compare.Controls.Add(tabPage4);
            PDF_Compare.Controls.Add(about);
            PDF_Compare.HotTrack = true;
            resources.ApplyResources(PDF_Compare, "PDF_Compare");
            PDF_Compare.Multiline = true;
            PDF_Compare.Name = "PDF_Compare";
            PDF_Compare.SelectedIndex = 0;
            // 
            // Env
            // 
            Env.Controls.Add(Set_IM_location);
            Env.Controls.Add(Show_IM_location);
            Env.Controls.Add(NameOf_IM_location);
            Env.Controls.Add(Set_GS_location);
            Env.Controls.Add(Show_GS_location);
            Env.Controls.Add(NameOf_Show_GS_location);
            resources.ApplyResources(Env, "Env");
            Env.Name = "Env";
            Env.UseVisualStyleBackColor = true;
            // 
            // Set_IM_location
            // 
            resources.ApplyResources(Set_IM_location, "Set_IM_location");
            Set_IM_location.Name = "Set_IM_location";
            Set_IM_location.UseVisualStyleBackColor = true;
            Set_IM_location.Click += Set_IM_location_Click;
            // 
            // Show_IM_location
            // 
            resources.ApplyResources(Show_IM_location, "Show_IM_location");
            Show_IM_location.Name = "Show_IM_location";
            // 
            // NameOf_IM_location
            // 
            resources.ApplyResources(NameOf_IM_location, "NameOf_IM_location");
            NameOf_IM_location.Name = "NameOf_IM_location";
            // 
            // Set_GS_location
            // 
            resources.ApplyResources(Set_GS_location, "Set_GS_location");
            Set_GS_location.Name = "Set_GS_location";
            Set_GS_location.UseVisualStyleBackColor = true;
            Set_GS_location.Click += Set_GS_location_Click;
            // 
            // Show_GS_location
            // 
            resources.ApplyResources(Show_GS_location, "Show_GS_location");
            Show_GS_location.Name = "Show_GS_location";
            // 
            // NameOf_Show_GS_location
            // 
            resources.ApplyResources(NameOf_Show_GS_location, "NameOf_Show_GS_location");
            NameOf_Show_GS_location.Name = "NameOf_Show_GS_location";
            // 
            // PDFtoImage
            // 
            PDFtoImage.Controls.Add(Output_IMG_DPI);
            PDFtoImage.Controls.Add(NameOf_Output_IMG_DPI);
            PDFtoImage.Controls.Add(Output_format);
            PDFtoImage.Controls.Add(NameOf_Output_format);
            PDFtoImage.Controls.Add(NameOf_cmd_PDFtoIMG);
            PDFtoImage.Controls.Add(cmd_PDFtoIMG);
            PDFtoImage.Controls.Add(Execute_PDFtoIMG);
            PDFtoImage.Controls.Add(BowserOutputFolder);
            PDFtoImage.Controls.Add(Show_PDFtoImage_OutputFolder);
            PDFtoImage.Controls.Add(NameOf_PDFtoImage_OutputFolder);
            PDFtoImage.Controls.Add(SelectPDFSource);
            PDFtoImage.Controls.Add(Show_PDFtoImage_Source);
            PDFtoImage.Controls.Add(NameOf_PDFtoImage_Source);
            resources.ApplyResources(PDFtoImage, "PDFtoImage");
            PDFtoImage.Name = "PDFtoImage";
            PDFtoImage.UseVisualStyleBackColor = true;
            // 
            // Output_IMG_DPI
            // 
            Output_IMG_DPI.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(Output_IMG_DPI, "Output_IMG_DPI");
            Output_IMG_DPI.FormattingEnabled = true;
            Output_IMG_DPI.Items.AddRange(new object[] { resources.GetString("Output_IMG_DPI.Items"), resources.GetString("Output_IMG_DPI.Items1"), resources.GetString("Output_IMG_DPI.Items2"), resources.GetString("Output_IMG_DPI.Items3") });
            Output_IMG_DPI.Name = "Output_IMG_DPI";
            // 
            // NameOf_Output_IMG_DPI
            // 
            resources.ApplyResources(NameOf_Output_IMG_DPI, "NameOf_Output_IMG_DPI");
            NameOf_Output_IMG_DPI.Name = "NameOf_Output_IMG_DPI";
            // 
            // Output_format
            // 
            Output_format.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(Output_format, "Output_format");
            Output_format.FormattingEnabled = true;
            Output_format.Items.AddRange(new object[] { resources.GetString("Output_format.Items"), resources.GetString("Output_format.Items1"), resources.GetString("Output_format.Items2") });
            Output_format.Name = "Output_format";
            // 
            // NameOf_Output_format
            // 
            resources.ApplyResources(NameOf_Output_format, "NameOf_Output_format");
            NameOf_Output_format.Name = "NameOf_Output_format";
            // 
            // NameOf_cmd_PDFtoIMG
            // 
            resources.ApplyResources(NameOf_cmd_PDFtoIMG, "NameOf_cmd_PDFtoIMG");
            NameOf_cmd_PDFtoIMG.Name = "NameOf_cmd_PDFtoIMG";
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
            // Show_PDFtoImage_OutputFolder
            // 
            resources.ApplyResources(Show_PDFtoImage_OutputFolder, "Show_PDFtoImage_OutputFolder");
            Show_PDFtoImage_OutputFolder.Name = "Show_PDFtoImage_OutputFolder";
            // 
            // NameOf_PDFtoImage_OutputFolder
            // 
            resources.ApplyResources(NameOf_PDFtoImage_OutputFolder, "NameOf_PDFtoImage_OutputFolder");
            NameOf_PDFtoImage_OutputFolder.Name = "NameOf_PDFtoImage_OutputFolder";
            // 
            // SelectPDFSource
            // 
            resources.ApplyResources(SelectPDFSource, "SelectPDFSource");
            SelectPDFSource.Name = "SelectPDFSource";
            SelectPDFSource.UseVisualStyleBackColor = true;
            SelectPDFSource.Click += SelectPDFSource_Click;
            // 
            // Show_PDFtoImage_Source
            // 
            resources.ApplyResources(Show_PDFtoImage_Source, "Show_PDFtoImage_Source");
            Show_PDFtoImage_Source.Name = "Show_PDFtoImage_Source";
            // 
            // NameOf_PDFtoImage_Source
            // 
            resources.ApplyResources(NameOf_PDFtoImage_Source, "NameOf_PDFtoImage_Source");
            NameOf_PDFtoImage_Source.Name = "NameOf_PDFtoImage_Source";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Del_All_COM);
            tabPage2.Controls.Add(Set_PDF_Compare_SaveLocation);
            tabPage2.Controls.Add(Show_PDF_Compare_SaveLocation);
            tabPage2.Controls.Add(NameOf_PDF_Compare_location);
            tabPage2.Controls.Add(execute_PDF_Compare);
            tabPage2.Controls.Add(NameOf_cmd_PDF_Compare);
            tabPage2.Controls.Add(cmd_PDF_Compare);
            tabPage2.Controls.Add(Move_to_BOTTOM);
            tabPage2.Controls.Add(Move_DOWN);
            tabPage2.Controls.Add(Move_UP);
            tabPage2.Controls.Add(Move_to_TOP);
            tabPage2.Controls.Add(Del_compare_PDF);
            tabPage2.Controls.Add(add_compare_pdf);
            tabPage2.Controls.Add(Compare_PDF_list);
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Del_All_COM
            // 
            resources.ApplyResources(Del_All_COM, "Del_All_COM");
            Del_All_COM.Name = "Del_All_COM";
            Del_All_COM.UseVisualStyleBackColor = true;
            Del_All_COM.Click += Del_All_COM_Click;
            // 
            // Set_PDF_Compare_SaveLocation
            // 
            resources.ApplyResources(Set_PDF_Compare_SaveLocation, "Set_PDF_Compare_SaveLocation");
            Set_PDF_Compare_SaveLocation.Name = "Set_PDF_Compare_SaveLocation";
            Set_PDF_Compare_SaveLocation.UseVisualStyleBackColor = true;
            Set_PDF_Compare_SaveLocation.Click += Set_PDF_COM_location_Click;
            // 
            // Show_PDF_Compare_SaveLocation
            // 
            resources.ApplyResources(Show_PDF_Compare_SaveLocation, "Show_PDF_Compare_SaveLocation");
            Show_PDF_Compare_SaveLocation.Name = "Show_PDF_Compare_SaveLocation";
            // 
            // NameOf_PDF_Compare_location
            // 
            resources.ApplyResources(NameOf_PDF_Compare_location, "NameOf_PDF_Compare_location");
            NameOf_PDF_Compare_location.Name = "NameOf_PDF_Compare_location";
            // 
            // execute_PDF_Compare
            // 
            resources.ApplyResources(execute_PDF_Compare, "execute_PDF_Compare");
            execute_PDF_Compare.Name = "execute_PDF_Compare";
            execute_PDF_Compare.UseVisualStyleBackColor = true;
            execute_PDF_Compare.Click += execute_PDF_Com_Click;
            // 
            // NameOf_cmd_PDF_Compare
            // 
            resources.ApplyResources(NameOf_cmd_PDF_Compare, "NameOf_cmd_PDF_Compare");
            NameOf_cmd_PDF_Compare.Name = "NameOf_cmd_PDF_Compare";
            // 
            // cmd_PDF_Compare
            // 
            cmd_PDF_Compare.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(cmd_PDF_Compare, "cmd_PDF_Compare");
            cmd_PDF_Compare.Name = "cmd_PDF_Compare";
            cmd_PDF_Compare.ReadOnly = true;
            // 
            // Move_to_BOTTOM
            // 
            resources.ApplyResources(Move_to_BOTTOM, "Move_to_BOTTOM");
            Move_to_BOTTOM.Name = "Move_to_BOTTOM";
            Move_to_BOTTOM.UseVisualStyleBackColor = true;
            Move_to_BOTTOM.Click += Move_to_BOTTOM_Click;
            // 
            // Move_DOWN
            // 
            resources.ApplyResources(Move_DOWN, "Move_DOWN");
            Move_DOWN.Name = "Move_DOWN";
            Move_DOWN.UseVisualStyleBackColor = true;
            Move_DOWN.Click += Move_DOWN_Click;
            // 
            // Move_UP
            // 
            resources.ApplyResources(Move_UP, "Move_UP");
            Move_UP.Name = "Move_UP";
            Move_UP.UseVisualStyleBackColor = true;
            Move_UP.Click += Move_UP_Click;
            // 
            // Move_to_TOP
            // 
            resources.ApplyResources(Move_to_TOP, "Move_to_TOP");
            Move_to_TOP.Name = "Move_to_TOP";
            Move_to_TOP.UseVisualStyleBackColor = true;
            Move_to_TOP.Click += Move_to_TOP_Click;
            // 
            // Del_compare_PDF
            // 
            resources.ApplyResources(Del_compare_PDF, "Del_compare_PDF");
            Del_compare_PDF.Name = "Del_compare_PDF";
            Del_compare_PDF.UseVisualStyleBackColor = true;
            Del_compare_PDF.Click += Del_com_PDF_Click;
            // 
            // add_compare_pdf
            // 
            resources.ApplyResources(add_compare_pdf, "add_compare_pdf");
            add_compare_pdf.Name = "add_compare_pdf";
            add_compare_pdf.UseVisualStyleBackColor = true;
            add_compare_pdf.Click += add_com_pdf_Click;
            // 
            // Compare_PDF_list
            // 
            Compare_PDF_list.FormattingEnabled = true;
            resources.ApplyResources(Compare_PDF_list, "Compare_PDF_list");
            Compare_PDF_list.Name = "Compare_PDF_list";
            Compare_PDF_list.SelectedIndexChanged += COM_PDF_list_SelectedIndexChanged;
            // 
            // PDF_Split
            // 
            PDF_Split.Controls.Add(Execute_PDF_Split);
            PDF_Split.Controls.Add(NameOf_cmd_PDF_Split);
            PDF_Split.Controls.Add(cmd_PDF_Split);
            PDF_Split.Controls.Add(Set_End_Page);
            PDF_Split.Controls.Add(NameOf_Set_End_Page);
            PDF_Split.Controls.Add(Set_Start_Page);
            PDF_Split.Controls.Add(NameOf_Set_Start_Page);
            PDF_Split.Controls.Add(Set_PDF_Split_SaveLocation);
            PDF_Split.Controls.Add(Show_PDF_Split_SaveLocation);
            PDF_Split.Controls.Add(NameOF_PDF_Split_location);
            PDF_Split.Controls.Add(Select_PDF_Split_Source);
            PDF_Split.Controls.Add(Show_PDF_Split_Source);
            PDF_Split.Controls.Add(NameOf_PDF_Split_Source);
            resources.ApplyResources(PDF_Split, "PDF_Split");
            PDF_Split.Name = "PDF_Split";
            PDF_Split.UseVisualStyleBackColor = true;
            // 
            // Execute_PDF_Split
            // 
            resources.ApplyResources(Execute_PDF_Split, "Execute_PDF_Split");
            Execute_PDF_Split.Name = "Execute_PDF_Split";
            Execute_PDF_Split.UseVisualStyleBackColor = true;
            Execute_PDF_Split.Click += Execute_PDF_Split_Click;
            // 
            // NameOf_cmd_PDF_Split
            // 
            resources.ApplyResources(NameOf_cmd_PDF_Split, "NameOf_cmd_PDF_Split");
            NameOf_cmd_PDF_Split.Name = "NameOf_cmd_PDF_Split";
            // 
            // cmd_PDF_Split
            // 
            cmd_PDF_Split.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(cmd_PDF_Split, "cmd_PDF_Split");
            cmd_PDF_Split.Name = "cmd_PDF_Split";
            cmd_PDF_Split.ReadOnly = true;
            // 
            // Set_End_Page
            // 
            resources.ApplyResources(Set_End_Page, "Set_End_Page");
            Set_End_Page.Name = "Set_End_Page";
            Set_End_Page.KeyPress += Set_End_Page_KeyPress;
            // 
            // NameOf_Set_End_Page
            // 
            resources.ApplyResources(NameOf_Set_End_Page, "NameOf_Set_End_Page");
            NameOf_Set_End_Page.Name = "NameOf_Set_End_Page";
            // 
            // Set_Start_Page
            // 
            resources.ApplyResources(Set_Start_Page, "Set_Start_Page");
            Set_Start_Page.Name = "Set_Start_Page";
            Set_Start_Page.KeyPress += Set_Start_Page_KeyPress;
            // 
            // NameOf_Set_Start_Page
            // 
            resources.ApplyResources(NameOf_Set_Start_Page, "NameOf_Set_Start_Page");
            NameOf_Set_Start_Page.Name = "NameOf_Set_Start_Page";
            // 
            // Set_PDF_Split_SaveLocation
            // 
            resources.ApplyResources(Set_PDF_Split_SaveLocation, "Set_PDF_Split_SaveLocation");
            Set_PDF_Split_SaveLocation.Name = "Set_PDF_Split_SaveLocation";
            Set_PDF_Split_SaveLocation.UseVisualStyleBackColor = true;
            Set_PDF_Split_SaveLocation.Click += Set_PDF_Split_location_Click;
            // 
            // Show_PDF_Split_SaveLocation
            // 
            resources.ApplyResources(Show_PDF_Split_SaveLocation, "Show_PDF_Split_SaveLocation");
            Show_PDF_Split_SaveLocation.Name = "Show_PDF_Split_SaveLocation";
            // 
            // NameOF_PDF_Split_location
            // 
            resources.ApplyResources(NameOF_PDF_Split_location, "NameOF_PDF_Split_location");
            NameOF_PDF_Split_location.Name = "NameOF_PDF_Split_location";
            // 
            // Select_PDF_Split_Source
            // 
            resources.ApplyResources(Select_PDF_Split_Source, "Select_PDF_Split_Source");
            Select_PDF_Split_Source.Name = "Select_PDF_Split_Source";
            Select_PDF_Split_Source.UseVisualStyleBackColor = true;
            Select_PDF_Split_Source.Click += Select_PDF_Split_Source_Click;
            // 
            // Show_PDF_Split_Source
            // 
            resources.ApplyResources(Show_PDF_Split_Source, "Show_PDF_Split_Source");
            Show_PDF_Split_Source.Name = "Show_PDF_Split_Source";
            // 
            // NameOf_PDF_Split_Source
            // 
            resources.ApplyResources(NameOf_PDF_Split_Source, "NameOf_PDF_Split_Source");
            NameOf_PDF_Split_Source.Name = "NameOf_PDF_Split_Source";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(Clear_ImagetoPDF_Source);
            tabPage4.Controls.Add(Set_IMGtoPDF_SaveLocation);
            tabPage4.Controls.Add(Show_IMGtoPDF_SaveLocation);
            tabPage4.Controls.Add(Name_toIMG_location);
            tabPage4.Controls.Add(Execute_IMGtoPDF);
            tabPage4.Controls.Add(Nameof_IMGtoPDF_cmd);
            tabPage4.Controls.Add(cmd_IMGtoPDF);
            tabPage4.Controls.Add(Del_ImagetoPDF_Source);
            tabPage4.Controls.Add(Add_ImagetoPDF_Source);
            tabPage4.Controls.Add(IMGtoPDF_list);
            resources.ApplyResources(tabPage4, "tabPage4");
            tabPage4.Name = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Clear_ImagetoPDF_Source
            // 
            resources.ApplyResources(Clear_ImagetoPDF_Source, "Clear_ImagetoPDF_Source");
            Clear_ImagetoPDF_Source.Name = "Clear_ImagetoPDF_Source";
            Clear_ImagetoPDF_Source.UseVisualStyleBackColor = true;
            Clear_ImagetoPDF_Source.Click += Clear_ImagetoPDF_Source_Click;
            // 
            // Set_IMGtoPDF_SaveLocation
            // 
            resources.ApplyResources(Set_IMGtoPDF_SaveLocation, "Set_IMGtoPDF_SaveLocation");
            Set_IMGtoPDF_SaveLocation.Name = "Set_IMGtoPDF_SaveLocation";
            Set_IMGtoPDF_SaveLocation.UseVisualStyleBackColor = true;
            Set_IMGtoPDF_SaveLocation.Click += Set_IMGtoPDF_SaveLocation_Click;
            // 
            // Show_IMGtoPDF_SaveLocation
            // 
            resources.ApplyResources(Show_IMGtoPDF_SaveLocation, "Show_IMGtoPDF_SaveLocation");
            Show_IMGtoPDF_SaveLocation.Name = "Show_IMGtoPDF_SaveLocation";
            // 
            // Name_toIMG_location
            // 
            resources.ApplyResources(Name_toIMG_location, "Name_toIMG_location");
            Name_toIMG_location.Name = "Name_toIMG_location";
            // 
            // Execute_IMGtoPDF
            // 
            resources.ApplyResources(Execute_IMGtoPDF, "Execute_IMGtoPDF");
            Execute_IMGtoPDF.Name = "Execute_IMGtoPDF";
            Execute_IMGtoPDF.UseVisualStyleBackColor = true;
            Execute_IMGtoPDF.Click += Execute_IMGtoPDF_Click;
            // 
            // Nameof_IMGtoPDF_cmd
            // 
            resources.ApplyResources(Nameof_IMGtoPDF_cmd, "Nameof_IMGtoPDF_cmd");
            Nameof_IMGtoPDF_cmd.Name = "Nameof_IMGtoPDF_cmd";
            // 
            // cmd_IMGtoPDF
            // 
            cmd_IMGtoPDF.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(cmd_IMGtoPDF, "cmd_IMGtoPDF");
            cmd_IMGtoPDF.Name = "cmd_IMGtoPDF";
            cmd_IMGtoPDF.ReadOnly = true;
            // 
            // Del_ImagetoPDF_Source
            // 
            resources.ApplyResources(Del_ImagetoPDF_Source, "Del_ImagetoPDF_Source");
            Del_ImagetoPDF_Source.Name = "Del_ImagetoPDF_Source";
            Del_ImagetoPDF_Source.UseVisualStyleBackColor = true;
            Del_ImagetoPDF_Source.Click += Del_ImagetoPDF_Source_Click;
            // 
            // Add_ImagetoPDF_Source
            // 
            resources.ApplyResources(Add_ImagetoPDF_Source, "Add_ImagetoPDF_Source");
            Add_ImagetoPDF_Source.Name = "Add_ImagetoPDF_Source";
            Add_ImagetoPDF_Source.UseVisualStyleBackColor = true;
            Add_ImagetoPDF_Source.Click += Add_ImagetoPDF_Source_Click;
            // 
            // IMGtoPDF_list
            // 
            IMGtoPDF_list.FormattingEnabled = true;
            resources.ApplyResources(IMGtoPDF_list, "IMGtoPDF_list");
            IMGtoPDF_list.Name = "IMGtoPDF_list";
            // 
            // about
            // 
            about.Controls.Add(mixneko_link);
            about.Controls.Add(License);
            about.Controls.Add(pictureBox1);
            about.Controls.Add(flaticon_link);
            about.Controls.Add(ImageMagick_link);
            about.Controls.Add(GhostScript_link);
            about.Controls.Add(label1);
            about.Controls.Add(NameOfAuther);
            resources.ApplyResources(about, "about");
            about.Name = "about";
            about.UseVisualStyleBackColor = true;
            // 
            // License
            // 
            License.Controls.Add(label3);
            License.Controls.Add(label2);
            License.Controls.Add(ImageMagick_License);
            License.Controls.Add(GhostScript_License);
            resources.ApplyResources(License, "License");
            License.Name = "License";
            License.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // ImageMagick_License
            // 
            resources.ApplyResources(ImageMagick_License, "ImageMagick_License");
            ImageMagick_License.Name = "ImageMagick_License";
            ImageMagick_License.ReadOnly = true;
            // 
            // GhostScript_License
            // 
            resources.ApplyResources(GhostScript_License, "GhostScript_License");
            GhostScript_License.Name = "GhostScript_License";
            GhostScript_License.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pdf;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // flaticon_link
            // 
            resources.ApplyResources(flaticon_link, "flaticon_link");
            flaticon_link.Name = "flaticon_link";
            flaticon_link.TabStop = true;
            flaticon_link.LinkClicked += flaticon_link_LinkClicked;
            // 
            // ImageMagick_link
            // 
            resources.ApplyResources(ImageMagick_link, "ImageMagick_link");
            ImageMagick_link.Name = "ImageMagick_link";
            ImageMagick_link.TabStop = true;
            ImageMagick_link.LinkClicked += ImageMagick_link_LinkClicked;
            // 
            // GhostScript_link
            // 
            resources.ApplyResources(GhostScript_link, "GhostScript_link");
            GhostScript_link.Name = "GhostScript_link";
            GhostScript_link.TabStop = true;
            GhostScript_link.LinkClicked += GhostScript_link_LinkClicked;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // NameOfAuther
            // 
            resources.ApplyResources(NameOfAuther, "NameOfAuther");
            NameOfAuther.Name = "NameOfAuther";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // mixneko_link
            // 
            resources.ApplyResources(mixneko_link, "mixneko_link");
            mixneko_link.Name = "mixneko_link";
            mixneko_link.TabStop = true;
            mixneko_link.LinkClicked += mixneko_link_LinkClicked;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PDF_Compare);
            MaximizeBox = false;
            Name = "Form1";
            Load += Form1_Load;
            PDF_Compare.ResumeLayout(false);
            Env.ResumeLayout(false);
            Env.PerformLayout();
            PDFtoImage.ResumeLayout(false);
            PDFtoImage.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            PDF_Split.ResumeLayout(false);
            PDF_Split.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            about.ResumeLayout(false);
            about.PerformLayout();
            License.ResumeLayout(false);
            License.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl PDF_Compare;
        private TabPage PDFtoImage;
        private TabPage tabPage2;
        private TabPage PDF_Split;
        private TabPage tabPage4;
        private TabPage about;
        private Label NameOf_PDFtoImage_Source;
        private Button Execute_PDFtoIMG;
        private Button BowserOutputFolder;
        private TextBox Show_PDFtoImage_OutputFolder;
        private Label NameOf_PDFtoImage_OutputFolder;
        private Button SelectPDFSource;
        private TextBox Show_PDFtoImage_Source;
        private TextBox cmd_PDFtoIMG;
        private Label NameOf_cmd_PDFtoIMG;
        private Label NameOf_Output_format;
        private ComboBox Output_format;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
        private SaveFileDialog saveFileDialog1;
        private ComboBox Output_IMG_DPI;
        private Label NameOf_Output_IMG_DPI;
        private ListBox Compare_PDF_list;
        private Button Move_DOWN;
        private Button Move_UP;
        private Button Move_to_TOP;
        private Button Del_compare_PDF;
        private Button add_compare_pdf;
        private Button Move_to_BOTTOM;
        private Label NameOf_cmd_PDF_Compare;
        private TextBox cmd_PDF_Compare;
        private Button execute_PDF_Compare;
        private Button Set_PDF_Split_SaveLocation;
        private TextBox Show_PDF_Split_SaveLocation;
        private Label NameOF_PDF_Split_location;
        private Button Select_PDF_Split_Source;
        private TextBox Show_PDF_Split_Source;
        private Label NameOf_PDF_Split_Source;
        private Button Set_PDF_Compare_SaveLocation;
        private TextBox Show_PDF_Compare_SaveLocation;
        private Label NameOf_PDF_Compare_location;
        private TextBox Set_Start_Page;
        private Label NameOf_Set_Start_Page;
        private Button Execute_PDF_Split;
        private Label NameOf_cmd_PDF_Split;
        private TextBox cmd_PDF_Split;
        private TextBox Set_End_Page;
        private Label NameOf_Set_End_Page;
        private Button Set_IMGtoPDF_SaveLocation;
        private TextBox Show_IMGtoPDF_SaveLocation;
        private Label Name_toIMG_location;
        private Button Execute_IMGtoPDF;
        private Label Nameof_IMGtoPDF_cmd;
        private TextBox cmd_IMGtoPDF;
        private Button Del_ImagetoPDF_Source;
        private Button Add_ImagetoPDF_Source;
        private ListBox IMGtoPDF_list;
        private TabPage Env;
        private Button Set_IM_location;
        private TextBox Show_IM_location;
        private Label NameOf_IM_location;
        private Button Set_GS_location;
        private TextBox Show_GS_location;
        private Label NameOf_Show_GS_location;
        private Button Del_All_COM;
        private Button Clear_ImagetoPDF_Source;
        private Label NameOfAuther;
        private Label label1;
        private LinkLabel GhostScript_link;
        private LinkLabel ImageMagick_link;
        private LinkLabel flaticon_link;
        private PictureBox pictureBox1;
        private GroupBox License;
        private TextBox ImageMagick_License;
        private TextBox GhostScript_License;
        private Label label3;
        private Label label2;
        private LinkLabel mixneko_link;
    }
}