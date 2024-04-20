namespace Movie_Ticket_Sales_App
{
    partial class HomePage
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
            Pages = new TabControl();
            moviePage = new TabPage();
            movieTheaterPage = new TabPage();
            sessionPage = new TabPage();
            customerPage = new TabPage();
            movieNameLbl = new Label();
            movieTimeOneLbl = new Label();
            movieTimeTwoLbl = new Label();
            movieTimeThreeLbl = new Label();
            movieTimeFourLbl = new Label();
            movieTheaterNameLbl = new Label();
            movieTheaterCapacityLbl = new Label();
            sMovieNameLbl = new Label();
            sMovieTheaterNameLbl = new Label();
            sMovieDateLbl = new Label();
            sMovieTimeLbl = new Label();
            customerNameLbl = new Label();
            customerSurnameLbl = new Label();
            customerIDNumberLbl = new Label();
            cardNumberLbl = new Label();
            validityPeriodLbl = new Label();
            securityCodeLbl = new Label();
            saveMovieBtn = new Button();
            saveMovieTheaterBtn = new Button();
            saveSessionBtn = new Button();
            saveCustomerBtn = new Button();
            movieNameTxt = new TextBox();
            movieTheaterNameTxt = new TextBox();
            customerNameTxt = new TextBox();
            customerSurnameTxt = new TextBox();
            movieTheaterCapacityTxt = new MaskedTextBox();
            customerIDNumberTxt = new MaskedTextBox();
            cardNumberTxt = new MaskedTextBox();
            securityCodeTxt = new MaskedTextBox();
            movieTimeOneDt = new DateTimePicker();
            movieTimeTwoDt = new DateTimePicker();
            movieTimeThreeDt = new DateTimePicker();
            movieTimeFourDt = new DateTimePicker();
            sMovieDateDt = new DateTimePicker();
            sMovieNameCombo = new ComboBox();
            sMovieTheaterNameCombo = new ComboBox();
            sMovieTimeCombo = new ComboBox();
            validityMonthCombo = new ComboBox();
            validityYearCombo = new ComboBox();
            datasMovie = new DataGridView();
            datasMovieTheater = new DataGridView();
            datasSession = new DataGridView();
            datasSessions = new DataGridView();
            Pages.SuspendLayout();
            moviePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasMovie).BeginInit();
            movieTheaterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasMovieTheater).BeginInit();
            sessionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasSession).BeginInit();
            customerPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datasSessions).BeginInit();
            SuspendLayout();
            // 
            // Pages
            // 
            Pages.Controls.Add(moviePage);
            Pages.Controls.Add(movieTheaterPage);
            Pages.Controls.Add(sessionPage);
            Pages.Controls.Add(customerPage);
            Pages.Location = new Point(12, 12);
            Pages.Name = "Pages";
            Pages.SelectedIndex = 0;
            Pages.Size = new Size(856, 433);
            Pages.TabIndex = 0;
            // 
            // moviePage
            // 
            moviePage.BackColor = Color.IndianRed;
            moviePage.Controls.Add(movieNameLbl);
            moviePage.Controls.Add(movieTimeOneLbl);
            moviePage.Controls.Add(movieTimeTwoLbl);
            moviePage.Controls.Add(movieTimeThreeLbl);
            moviePage.Controls.Add(movieTimeFourLbl);
            moviePage.Controls.Add(saveMovieBtn);
            moviePage.Controls.Add(movieNameTxt);
            moviePage.Controls.Add(movieTimeOneDt);
            moviePage.Controls.Add(movieTimeTwoDt);
            moviePage.Controls.Add(movieTimeThreeDt);
            moviePage.Controls.Add(movieTimeFourDt);
            moviePage.Controls.Add(datasMovie);
            moviePage.ForeColor = Color.Black;
            moviePage.Location = new Point(4, 25);
            moviePage.Name = "moviePage";
            moviePage.Padding = new Padding(3);
            moviePage.Size = new Size(848, 404);
            moviePage.TabIndex = 0;
            moviePage.Text = "Movie Record Page";
            // 
            // movieTheaterPage
            // 
            movieTheaterPage.BackColor = Color.Coral;
            movieTheaterPage.Controls.Add(movieTheaterNameLbl);
            movieTheaterPage.Controls.Add(movieTheaterCapacityLbl);
            movieTheaterPage.Controls.Add(saveMovieTheaterBtn);
            movieTheaterPage.Controls.Add(movieTheaterNameTxt);
            movieTheaterPage.Controls.Add(movieTheaterCapacityTxt);
            movieTheaterPage.Controls.Add(datasMovieTheater);
            movieTheaterPage.ForeColor = Color.Black;
            movieTheaterPage.Location = new Point(4, 25);
            movieTheaterPage.Name = "movieTheaterPage";
            movieTheaterPage.Padding = new Padding(3);
            movieTheaterPage.Size = new Size(848, 404);
            movieTheaterPage.TabIndex = 1;
            movieTheaterPage.Text = "Movie Theater Record Page";
            // 
            // sessionPage
            // 
            sessionPage.BackColor = Color.Peru;
            sessionPage.Controls.Add(sMovieNameLbl);
            sessionPage.Controls.Add(sMovieTheaterNameLbl);
            sessionPage.Controls.Add(sMovieDateLbl);
            sessionPage.Controls.Add(sMovieTimeLbl);
            sessionPage.Controls.Add(saveSessionBtn);
            sessionPage.Controls.Add(sMovieNameCombo);
            sessionPage.Controls.Add(sMovieTheaterNameCombo);
            sessionPage.Controls.Add(sMovieDateDt);
            sessionPage.Controls.Add(sMovieTimeCombo);
            sessionPage.Controls.Add(datasSession);
            sessionPage.ForeColor = Color.Black;
            sessionPage.Location = new Point(4, 25);
            sessionPage.Name = "sessionPage";
            sessionPage.Size = new Size(848, 404);
            sessionPage.TabIndex = 2;
            sessionPage.Text = "Session Record Page";
            // 
            // customerPage
            // 
            customerPage.BackColor = Color.PaleVioletRed;
            customerPage.Controls.Add(customerNameLbl);
            customerPage.Controls.Add(customerSurnameLbl);
            customerPage.Controls.Add(customerIDNumberLbl);
            customerPage.Controls.Add(cardNumberLbl);
            customerPage.Controls.Add(validityPeriodLbl);
            customerPage.Controls.Add(securityCodeLbl);
            customerPage.Controls.Add(saveCustomerBtn);
            customerPage.Controls.Add(customerNameTxt);
            customerPage.Controls.Add(customerSurnameTxt);
            customerPage.Controls.Add(customerIDNumberTxt);
            customerPage.Controls.Add(cardNumberTxt);
            customerPage.Controls.Add(securityCodeTxt);
            customerPage.Controls.Add(validityMonthCombo);
            customerPage.Controls.Add(validityYearCombo);
            customerPage.Controls.Add(datasSessions);
            customerPage.ForeColor = Color.Black;
            customerPage.Location = new Point(4, 25);
            customerPage.Name = "customerPage";
            customerPage.Size = new Size(848, 404);
            customerPage.TabIndex = 3;
            customerPage.Text = "Customer Record Page";
            // 
            // movieNameLbl
            // 
            movieNameLbl.AutoSize = true;
            movieNameLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieNameLbl.Location = new Point(21, 11);
            movieNameLbl.Name = "movieNameLbl";
            movieNameLbl.Size = new Size(100, 20);
            movieNameLbl.TabIndex = 0;
            movieNameLbl.Text = "Movie Name:";
            movieNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movieTimeOneLbl
            // 
            movieTimeOneLbl.AutoSize = true;
            movieTimeOneLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTimeOneLbl.Location = new Point(16, 41);
            movieTimeOneLbl.Name = "movieTimeOneLbl";
            movieTimeOneLbl.Size = new Size(105, 20);
            movieTimeOneLbl.TabIndex = 2;
            movieTimeOneLbl.Text = "Movie Time 1:";
            movieTimeOneLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movieTimeTwoLbl
            // 
            movieTimeTwoLbl.AutoSize = true;
            movieTimeTwoLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTimeTwoLbl.Location = new Point(16, 69);
            movieTimeTwoLbl.Name = "movieTimeTwoLbl";
            movieTimeTwoLbl.Size = new Size(105, 20);
            movieTimeTwoLbl.TabIndex = 4;
            movieTimeTwoLbl.Text = "Movie Time 2:";
            movieTimeTwoLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movieTimeThreeLbl
            // 
            movieTimeThreeLbl.AutoSize = true;
            movieTimeThreeLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTimeThreeLbl.Location = new Point(451, 41);
            movieTimeThreeLbl.Name = "movieTimeThreeLbl";
            movieTimeThreeLbl.Size = new Size(105, 20);
            movieTimeThreeLbl.TabIndex = 6;
            movieTimeThreeLbl.Text = "Movie Time 3:";
            movieTimeThreeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movieTimeFourLbl
            // 
            movieTimeFourLbl.AutoSize = true;
            movieTimeFourLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTimeFourLbl.Location = new Point(451, 69);
            movieTimeFourLbl.Name = "movieTimeFourLbl";
            movieTimeFourLbl.Size = new Size(105, 20);
            movieTimeFourLbl.TabIndex = 8;
            movieTimeFourLbl.Text = "Movie Time 4:";
            movieTimeFourLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movieTheaterNameLbl
            // 
            movieTheaterNameLbl.AutoSize = true;
            movieTheaterNameLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTheaterNameLbl.ForeColor = SystemColors.ActiveCaptionText;
            movieTheaterNameLbl.Location = new Point(48, 9);
            movieTheaterNameLbl.Name = "movieTheaterNameLbl";
            movieTheaterNameLbl.Size = new Size(159, 20);
            movieTheaterNameLbl.TabIndex = 0;
            movieTheaterNameLbl.Text = "Movie Theater Name:";
            movieTheaterNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // movieTheaterCapacityLbl
            // 
            movieTheaterCapacityLbl.AutoSize = true;
            movieTheaterCapacityLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movieTheaterCapacityLbl.ForeColor = SystemColors.ActiveCaptionText;
            movieTheaterCapacityLbl.Location = new Point(29, 41);
            movieTheaterCapacityLbl.Name = "movieTheaterCapacityLbl";
            movieTheaterCapacityLbl.Size = new Size(178, 20);
            movieTheaterCapacityLbl.TabIndex = 2;
            movieTheaterCapacityLbl.Text = "Movie Theater Capacity:";
            movieTheaterCapacityLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sMovieNameLbl
            // 
            sMovieNameLbl.AutoSize = true;
            sMovieNameLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sMovieNameLbl.Location = new Point(21, 11);
            sMovieNameLbl.Name = "sMovieNameLbl";
            sMovieNameLbl.Size = new Size(100, 20);
            sMovieNameLbl.TabIndex = 0;
            sMovieNameLbl.Text = "Movie Name:";
            sMovieNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sMovieTheaterNameLbl
            // 
            sMovieTheaterNameLbl.AutoSize = true;
            sMovieTheaterNameLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sMovieTheaterNameLbl.Location = new Point(427, 11);
            sMovieTheaterNameLbl.Name = "sMovieTheaterNameLbl";
            sMovieTheaterNameLbl.Size = new Size(159, 20);
            sMovieTheaterNameLbl.TabIndex = 2;
            sMovieTheaterNameLbl.Text = "Movie Theater Name:";
            sMovieTheaterNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sMovieDateLbl
            // 
            sMovieDateLbl.AutoSize = true;
            sMovieDateLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sMovieDateLbl.Location = new Point(28, 40);
            sMovieDateLbl.Name = "sMovieDateLbl";
            sMovieDateLbl.Size = new Size(93, 20);
            sMovieDateLbl.TabIndex = 4;
            sMovieDateLbl.Text = "Movie Date:";
            sMovieDateLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sMovieTimeLbl
            // 
            sMovieTimeLbl.AutoSize = true;
            sMovieTimeLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sMovieTimeLbl.Location = new Point(494, 40);
            sMovieTimeLbl.Name = "sMovieTimeLbl";
            sMovieTimeLbl.Size = new Size(92, 20);
            sMovieTimeLbl.TabIndex = 6;
            sMovieTimeLbl.Text = "Movie Time:";
            sMovieTimeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerNameLbl
            // 
            customerNameLbl.AutoSize = true;
            customerNameLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerNameLbl.Location = new Point(57, 281);
            customerNameLbl.Name = "customerNameLbl";
            customerNameLbl.Size = new Size(128, 20);
            customerNameLbl.TabIndex = 1;
            customerNameLbl.Text = "Customer Name:";
            customerNameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerSurnameLbl
            // 
            customerSurnameLbl.AutoSize = true;
            customerSurnameLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerSurnameLbl.Location = new Point(455, 281);
            customerSurnameLbl.Name = "customerSurnameLbl";
            customerSurnameLbl.Size = new Size(151, 20);
            customerSurnameLbl.TabIndex = 3;
            customerSurnameLbl.Text = "Customer Surname:";
            customerSurnameLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customerIDNumberLbl
            // 
            customerIDNumberLbl.AutoSize = true;
            customerIDNumberLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customerIDNumberLbl.Location = new Point(22, 310);
            customerIDNumberLbl.Name = "customerIDNumberLbl";
            customerIDNumberLbl.Size = new Size(163, 20);
            customerIDNumberLbl.TabIndex = 5;
            customerIDNumberLbl.Text = "Customer ID Number:";
            customerIDNumberLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardNumberLbl
            // 
            cardNumberLbl.AutoSize = true;
            cardNumberLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cardNumberLbl.Location = new Point(499, 309);
            cardNumberLbl.Name = "cardNumberLbl";
            cardNumberLbl.Size = new Size(107, 20);
            cardNumberLbl.TabIndex = 7;
            cardNumberLbl.Text = "Card Number:";
            cardNumberLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // validityPeriodLbl
            // 
            validityPeriodLbl.AutoSize = true;
            validityPeriodLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            validityPeriodLbl.Location = new Point(73, 339);
            validityPeriodLbl.Name = "validityPeriodLbl";
            validityPeriodLbl.Size = new Size(112, 20);
            validityPeriodLbl.TabIndex = 9;
            validityPeriodLbl.Text = "Validity Period:";
            validityPeriodLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // securityCodeLbl
            // 
            securityCodeLbl.AutoSize = true;
            securityCodeLbl.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            securityCodeLbl.Location = new Point(494, 337);
            securityCodeLbl.Name = "securityCodeLbl";
            securityCodeLbl.Size = new Size(112, 20);
            securityCodeLbl.TabIndex = 12;
            securityCodeLbl.Text = "Security Code:";
            securityCodeLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveMovieBtn
            // 
            saveMovieBtn.BackColor = SystemColors.ActiveCaption;
            saveMovieBtn.FlatStyle = FlatStyle.Popup;
            saveMovieBtn.ForeColor = Color.Black;
            saveMovieBtn.Location = new Point(562, 95);
            saveMovieBtn.Name = "saveMovieBtn";
            saveMovieBtn.Size = new Size(280, 30);
            saveMovieBtn.TabIndex = 10;
            saveMovieBtn.Text = "SAVE";
            saveMovieBtn.UseVisualStyleBackColor = false;
            saveMovieBtn.Click += saveMovieBtn_Click;
            // 
            // saveMovieTheaterBtn
            // 
            saveMovieTheaterBtn.BackColor = SystemColors.ActiveCaption;
            saveMovieTheaterBtn.FlatStyle = FlatStyle.Popup;
            saveMovieTheaterBtn.ForeColor = Color.Black;
            saveMovieTheaterBtn.Location = new Point(562, 37);
            saveMovieTheaterBtn.Name = "saveMovieTheaterBtn";
            saveMovieTheaterBtn.Size = new Size(280, 30);
            saveMovieTheaterBtn.TabIndex = 4;
            saveMovieTheaterBtn.Text = "SAVE";
            saveMovieTheaterBtn.UseVisualStyleBackColor = false;
            saveMovieTheaterBtn.Click += saveMovieTheaterBtn_Click;
            // 
            // saveSessionBtn
            // 
            saveSessionBtn.BackColor = SystemColors.ActiveCaption;
            saveSessionBtn.FlatStyle = FlatStyle.Popup;
            saveSessionBtn.ForeColor = Color.Black;
            saveSessionBtn.Location = new Point(592, 70);
            saveSessionBtn.Name = "saveSessionBtn";
            saveSessionBtn.Size = new Size(250, 30);
            saveSessionBtn.TabIndex = 8;
            saveSessionBtn.Text = "SAVE";
            saveSessionBtn.UseVisualStyleBackColor = false;
            saveSessionBtn.Click += saveSessionBtn_Click;
            // 
            // saveCustomerBtn
            // 
            saveCustomerBtn.BackColor = SystemColors.ActiveCaption;
            saveCustomerBtn.FlatStyle = FlatStyle.Popup;
            saveCustomerBtn.ForeColor = Color.Black;
            saveCustomerBtn.Location = new Point(612, 365);
            saveCustomerBtn.Name = "saveCustomerBtn";
            saveCustomerBtn.Size = new Size(230, 30);
            saveCustomerBtn.TabIndex = 14;
            saveCustomerBtn.Text = "SAVE";
            saveCustomerBtn.UseVisualStyleBackColor = false;
            saveCustomerBtn.Click += saveCustomerBtn_Click;
            // 
            // movieNameTxt
            // 
            movieNameTxt.Location = new Point(127, 11);
            movieNameTxt.Name = "movieNameTxt";
            movieNameTxt.Size = new Size(715, 22);
            movieNameTxt.TabIndex = 1;
            movieNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // movieTheaterNameTxt
            // 
            movieTheaterNameTxt.Location = new Point(213, 9);
            movieTheaterNameTxt.Name = "movieTheaterNameTxt";
            movieTheaterNameTxt.Size = new Size(629, 22);
            movieTheaterNameTxt.TabIndex = 1;
            movieTheaterNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // customerNameTxt
            // 
            customerNameTxt.Location = new Point(191, 281);
            customerNameTxt.Name = "customerNameTxt";
            customerNameTxt.Size = new Size(230, 22);
            customerNameTxt.TabIndex = 2;
            customerNameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // customerSurnameTxt
            // 
            customerSurnameTxt.CharacterCasing = CharacterCasing.Upper;
            customerSurnameTxt.Location = new Point(612, 281);
            customerSurnameTxt.Name = "customerSurnameTxt";
            customerSurnameTxt.Size = new Size(230, 22);
            customerSurnameTxt.TabIndex = 4;
            customerSurnameTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // movieTheaterCapacityTxt
            // 
            movieTheaterCapacityTxt.Location = new Point(213, 41);
            movieTheaterCapacityTxt.Mask = "0000";
            movieTheaterCapacityTxt.Name = "movieTheaterCapacityTxt";
            movieTheaterCapacityTxt.Size = new Size(343, 22);
            movieTheaterCapacityTxt.TabIndex = 3;
            movieTheaterCapacityTxt.TextAlign = HorizontalAlignment.Center;
            movieTheaterCapacityTxt.ValidatingType = typeof(int);
            // 
            // customerIDNumberTxt
            // 
            customerIDNumberTxt.Location = new Point(191, 309);
            customerIDNumberTxt.Mask = "00000000000";
            customerIDNumberTxt.Name = "customerIDNumberTxt";
            customerIDNumberTxt.Size = new Size(230, 22);
            customerIDNumberTxt.TabIndex = 6;
            customerIDNumberTxt.TextAlign = HorizontalAlignment.Center;
            customerIDNumberTxt.ValidatingType = typeof(int);
            // 
            // cardNumberTxt
            // 
            cardNumberTxt.Location = new Point(612, 309);
            cardNumberTxt.Mask = "0000 0000 0000 0000";
            cardNumberTxt.Name = "cardNumberTxt";
            cardNumberTxt.Size = new Size(230, 22);
            cardNumberTxt.TabIndex = 8;
            cardNumberTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // securityCodeTxt
            // 
            securityCodeTxt.Location = new Point(612, 337);
            securityCodeTxt.Mask = "000";
            securityCodeTxt.Name = "securityCodeTxt";
            securityCodeTxt.Size = new Size(230, 22);
            securityCodeTxt.TabIndex = 13;
            securityCodeTxt.TextAlign = HorizontalAlignment.Center;
            // 
            // movieTimeOneDt
            // 
            movieTimeOneDt.Format = DateTimePickerFormat.Time;
            movieTimeOneDt.Location = new Point(127, 39);
            movieTimeOneDt.Name = "movieTimeOneDt";
            movieTimeOneDt.Size = new Size(280, 22);
            movieTimeOneDt.TabIndex = 3;
            movieTimeOneDt.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // movieTimeTwoDt
            // 
            movieTimeTwoDt.Format = DateTimePickerFormat.Time;
            movieTimeTwoDt.Location = new Point(127, 67);
            movieTimeTwoDt.Name = "movieTimeTwoDt";
            movieTimeTwoDt.Size = new Size(280, 22);
            movieTimeTwoDt.TabIndex = 5;
            movieTimeTwoDt.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // movieTimeThreeDt
            // 
            movieTimeThreeDt.Format = DateTimePickerFormat.Time;
            movieTimeThreeDt.Location = new Point(562, 39);
            movieTimeThreeDt.Name = "movieTimeThreeDt";
            movieTimeThreeDt.Size = new Size(280, 22);
            movieTimeThreeDt.TabIndex = 7;
            movieTimeThreeDt.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // movieTimeFourDt
            // 
            movieTimeFourDt.Format = DateTimePickerFormat.Time;
            movieTimeFourDt.Location = new Point(562, 67);
            movieTimeFourDt.Name = "movieTimeFourDt";
            movieTimeFourDt.Size = new Size(280, 22);
            movieTimeFourDt.TabIndex = 9;
            movieTimeFourDt.Value = new DateTime(2024, 4, 16, 0, 0, 0, 0);
            // 
            // sMovieDateDt
            // 
            sMovieDateDt.Format = DateTimePickerFormat.Short;
            sMovieDateDt.Location = new Point(127, 40);
            sMovieDateDt.Name = "sMovieDateDt";
            sMovieDateDt.Size = new Size(250, 22);
            sMovieDateDt.TabIndex = 5;
            sMovieDateDt.Value = new DateTime(2024, 4, 17, 0, 0, 0, 0);
            // 
            // sMovieNameCombo
            // 
            sMovieNameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sMovieNameCombo.FormattingEnabled = true;
            sMovieNameCombo.IntegralHeight = false;
            sMovieNameCombo.Location = new Point(127, 11);
            sMovieNameCombo.MaxDropDownItems = 3;
            sMovieNameCombo.Name = "sMovieNameCombo";
            sMovieNameCombo.Size = new Size(250, 24);
            sMovieNameCombo.Sorted = true;
            sMovieNameCombo.TabIndex = 1;
            sMovieNameCombo.SelectedIndexChanged += sMovieNameCombo_SelectedIndexChanged;
            // 
            // sMovieTheaterNameCombo
            // 
            sMovieTheaterNameCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sMovieTheaterNameCombo.FormattingEnabled = true;
            sMovieTheaterNameCombo.IntegralHeight = false;
            sMovieTheaterNameCombo.Location = new Point(592, 11);
            sMovieTheaterNameCombo.MaxDropDownItems = 3;
            sMovieTheaterNameCombo.Name = "sMovieTheaterNameCombo";
            sMovieTheaterNameCombo.Size = new Size(250, 24);
            sMovieTheaterNameCombo.Sorted = true;
            sMovieTheaterNameCombo.TabIndex = 3;
            // 
            // sMovieTimeCombo
            // 
            sMovieTimeCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            sMovieTimeCombo.FormattingEnabled = true;
            sMovieTimeCombo.IntegralHeight = false;
            sMovieTimeCombo.Location = new Point(592, 40);
            sMovieTimeCombo.MaxDropDownItems = 3;
            sMovieTimeCombo.Name = "sMovieTimeCombo";
            sMovieTimeCombo.Size = new Size(250, 24);
            sMovieTimeCombo.Sorted = true;
            sMovieTimeCombo.TabIndex = 7;
            // 
            // validityMonthCombo
            // 
            validityMonthCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            validityMonthCombo.FormattingEnabled = true;
            validityMonthCombo.IntegralHeight = false;
            validityMonthCombo.Location = new Point(191, 337);
            validityMonthCombo.MaxDropDownItems = 3;
            validityMonthCombo.Name = "validityMonthCombo";
            validityMonthCombo.Size = new Size(110, 24);
            validityMonthCombo.TabIndex = 10;
            // 
            // validityYearCombo
            // 
            validityYearCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            validityYearCombo.FormattingEnabled = true;
            validityYearCombo.IntegralHeight = false;
            validityYearCombo.Location = new Point(311, 337);
            validityYearCombo.MaxDropDownItems = 3;
            validityYearCombo.Name = "validityYearCombo";
            validityYearCombo.Size = new Size(110, 24);
            validityYearCombo.TabIndex = 11;
            // 
            // datasMovie
            // 
            datasMovie.AllowUserToAddRows = false;
            datasMovie.AllowUserToDeleteRows = false;
            datasMovie.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasMovie.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasMovie.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasMovie.Location = new Point(6, 131);
            datasMovie.Name = "datasMovie";
            datasMovie.ReadOnly = true;
            datasMovie.Size = new Size(836, 268);
            datasMovie.TabIndex = 11;
            datasMovie.DataBindingComplete += datasMovie_DataBindingComplete;
            // 
            // datasMovieTheater
            // 
            datasMovieTheater.AllowUserToAddRows = false;
            datasMovieTheater.AllowUserToDeleteRows = false;
            datasMovieTheater.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasMovieTheater.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasMovieTheater.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasMovieTheater.Location = new Point(6, 73);
            datasMovieTheater.Name = "datasMovieTheater";
            datasMovieTheater.ReadOnly = true;
            datasMovieTheater.Size = new Size(836, 326);
            datasMovieTheater.TabIndex = 5;
            datasMovieTheater.DataBindingComplete += datasMovieTheater_DataBindingComplete;
            // 
            // datasSession
            // 
            datasSession.AllowUserToAddRows = false;
            datasSession.AllowUserToDeleteRows = false;
            datasSession.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasSession.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasSession.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasSession.Location = new Point(6, 106);
            datasSession.Name = "datasSession";
            datasSession.ReadOnly = true;
            datasSession.Size = new Size(836, 293);
            datasSession.TabIndex = 9;
            datasSession.DataBindingComplete += datasSession_DataBindingComplete;
            // 
            // datasSessions
            // 
            datasSessions.AllowUserToAddRows = false;
            datasSessions.AllowUserToDeleteRows = false;
            datasSessions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datasSessions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datasSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datasSessions.Location = new Point(6, 11);
            datasSessions.Name = "datasSessions";
            datasSessions.ReadOnly = true;
            datasSessions.Size = new Size(836, 264);
            datasSessions.TabIndex = 0;
            datasSessions.DataBindingComplete += datasSessions_DataBindingComplete;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(880, 457);
            Controls.Add(Pages);
            Font = new Font("Microsoft Sans Serif", 9.75F);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Ticket Sales App";
            Load += HomePage_Load;
            KeyDown += HomePage_KeyDown;
            Pages.ResumeLayout(false);
            moviePage.ResumeLayout(false);
            moviePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datasMovie).EndInit();
            movieTheaterPage.ResumeLayout(false);
            movieTheaterPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datasMovieTheater).EndInit();
            sessionPage.ResumeLayout(false);
            sessionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datasSession).EndInit();
            customerPage.ResumeLayout(false);
            customerPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datasSessions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Pages;
        private TabPage moviePage;
        private TabPage movieTheaterPage;
        private TabPage sessionPage;
        private TabPage customerPage;
        private Label movieNameLbl;
        private Label movieTimeOneLbl;
        private Label movieTimeTwoLbl;
        private Label movieTimeThreeLbl;
        private Label movieTimeFourLbl;
        private Label movieTheaterNameLbl;
        private Label movieTheaterCapacityLbl;
        private Label sMovieNameLbl;
        private Label sMovieTheaterNameLbl;
        private Label sMovieDateLbl;
        private Label sMovieTimeLbl;
        private Label customerNameLbl;
        private Label customerSurnameLbl;
        private Label customerIDNumberLbl;
        private Label cardNumberLbl;
        private Label validityPeriodLbl;
        private Label securityCodeLbl;
        private Button saveMovieBtn;
        private Button saveMovieTheaterBtn;
        private Button saveSessionBtn;
        private Button saveCustomerBtn;
        public TextBox movieNameTxt;
        public TextBox movieTheaterNameTxt;
        public TextBox customerNameTxt;
        public TextBox customerSurnameTxt;
        public MaskedTextBox movieTheaterCapacityTxt;
        public MaskedTextBox customerIDNumberTxt;
        public MaskedTextBox cardNumberTxt;
        public MaskedTextBox securityCodeTxt;
        public DateTimePicker movieTimeOneDt;
        public DateTimePicker movieTimeTwoDt;
        public DateTimePicker movieTimeThreeDt;
        public DateTimePicker movieTimeFourDt;
        public DateTimePicker sMovieDateDt;
        public ComboBox sMovieNameCombo;
        public ComboBox sMovieTheaterNameCombo;
        public ComboBox sMovieTimeCombo;
        public ComboBox validityMonthCombo;
        public ComboBox validityYearCombo;
        public DataGridView datasMovie;
        public DataGridView datasMovieTheater;
        public DataGridView datasSession;
        public DataGridView datasSessions;
    }
}
