namespace BulbpharaProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bulbharaLabel = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.syToggleButton1 = new BulbpharaProject.MyControls.SyToggleButton();
            this.btnLogin = new BulbpharaProject.MyControls.SyButton();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbxPass = new BulbpharaProject.MyControls.SyTextBox();
            this.tbxUserName = new BulbpharaProject.MyControls.SyTextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.signUpPanel = new System.Windows.Forms.Panel();
            this.comboCity = new BulbpharaProject.MyControls.SyComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSignUp = new BulbpharaProject.MyControls.SyButton();
            this.tbxSignPass = new BulbpharaProject.MyControls.SyTextBox();
            this.tbxSignUserName = new BulbpharaProject.MyControls.SyTextBox();
            this.tbxSignSurname = new BulbpharaProject.MyControls.SyTextBox();
            this.tbxSignName = new BulbpharaProject.MyControls.SyTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.signUpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bulbharaLabel
            // 
            this.bulbharaLabel.AutoSize = true;
            this.bulbharaLabel.BackColor = System.Drawing.Color.Black;
            this.bulbharaLabel.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bulbharaLabel.ForeColor = System.Drawing.Color.White;
            this.bulbharaLabel.Location = new System.Drawing.Point(582, 617);
            this.bulbharaLabel.Name = "bulbharaLabel";
            this.bulbharaLabel.Size = new System.Drawing.Size(204, 57);
            this.bulbharaLabel.TabIndex = 0;
            this.bulbharaLabel.Text = "Bulbphara";
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.Transparent;
            this.loginPanel.Controls.Add(this.label8);
            this.loginPanel.Controls.Add(this.label7);
            this.loginPanel.Controls.Add(this.syToggleButton1);
            this.loginPanel.Controls.Add(this.btnLogin);
            this.loginPanel.Controls.Add(this.lblPass);
            this.loginPanel.Controls.Add(this.lblUserName);
            this.loginPanel.Controls.Add(this.tbxPass);
            this.loginPanel.Controls.Add(this.tbxUserName);
            this.loginPanel.Controls.Add(this.lblLogin);
            this.loginPanel.Location = new System.Drawing.Point(-15, -15);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(604, 726);
            this.loginPanel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(200, 671);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Sarı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(92, 671);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Beyaz";
            // 
            // syToggleButton1
            // 
            this.syToggleButton1.AutoSize = true;
            this.syToggleButton1.Location = new System.Drawing.Point(143, 667);
            this.syToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.syToggleButton1.Name = "syToggleButton1";
            this.syToggleButton1.OffBackColor = System.Drawing.Color.WhiteSmoke;
            this.syToggleButton1.OffToggleColor = System.Drawing.Color.Black;
            this.syToggleButton1.OnBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.syToggleButton1.OnToggleColor = System.Drawing.Color.Black;
            this.syToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.syToggleButton1.TabIndex = 7;
            this.syToggleButton1.UseVisualStyleBackColor = true;
            this.syToggleButton1.CheckedChanged += new System.EventHandler(this.syToggleButton1_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Black;
            this.btnLogin.BackgroundColor = System.Drawing.Color.Black;
            this.btnLogin.BorderColor = System.Drawing.Color.Silver;
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.BorderSize = 1;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(243, 528);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(150, 40);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(140, 368);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(41, 19);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Şifre";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(140, 219);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(96, 19);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Kullanıcı Adı";
            // 
            // tbxPass
            // 
            this.tbxPass.BackColor = System.Drawing.Color.Black;
            this.tbxPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxPass.BorderFocusColor = System.Drawing.Color.Silver;
            this.tbxPass.BorderSize = 2;
            this.tbxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxPass.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxPass.Location = new System.Drawing.Point(143, 422);
            this.tbxPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPass.Multiline = false;
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Padding = new System.Windows.Forms.Padding(7);
            this.tbxPass.PasswordChar = true;
            this.tbxPass.Size = new System.Drawing.Size(250, 31);
            this.tbxPass.TabIndex = 2;
            this.tbxPass.Texts = "";
            this.tbxPass.UnderlinedStyle = false;
            // 
            // tbxUserName
            // 
            this.tbxUserName.BackColor = System.Drawing.Color.Black;
            this.tbxUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tbxUserName.BorderFocusColor = System.Drawing.Color.Silver;
            this.tbxUserName.BorderSize = 2;
            this.tbxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxUserName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxUserName.Location = new System.Drawing.Point(143, 273);
            this.tbxUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxUserName.Multiline = false;
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Padding = new System.Windows.Forms.Padding(7);
            this.tbxUserName.PasswordChar = false;
            this.tbxUserName.Size = new System.Drawing.Size(250, 31);
            this.tbxUserName.TabIndex = 1;
            this.tbxUserName.Texts = "";
            this.tbxUserName.UnderlinedStyle = false;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(134, 45);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(255, 56);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Giriş Yap";
            // 
            // signUpPanel
            // 
            this.signUpPanel.BackColor = System.Drawing.Color.Transparent;
            this.signUpPanel.Controls.Add(this.comboCity);
            this.signUpPanel.Controls.Add(this.label9);
            this.signUpPanel.Controls.Add(this.btnSignUp);
            this.signUpPanel.Controls.Add(this.tbxSignPass);
            this.signUpPanel.Controls.Add(this.tbxSignUserName);
            this.signUpPanel.Controls.Add(this.tbxSignSurname);
            this.signUpPanel.Controls.Add(this.tbxSignName);
            this.signUpPanel.Controls.Add(this.label6);
            this.signUpPanel.Controls.Add(this.label5);
            this.signUpPanel.Controls.Add(this.label4);
            this.signUpPanel.Controls.Add(this.label3);
            this.signUpPanel.Controls.Add(this.label2);
            this.signUpPanel.Controls.Add(this.lblSignUp);
            this.signUpPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signUpPanel.Location = new System.Drawing.Point(776, 0);
            this.signUpPanel.Name = "signUpPanel";
            this.signUpPanel.Size = new System.Drawing.Size(576, 726);
            this.signUpPanel.TabIndex = 2;
            // 
            // comboCity
            // 
            this.comboCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCity.BackColor = System.Drawing.Color.Black;
            this.comboCity.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.comboCity.BorderSize = 1;
            this.comboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboCity.ForeColor = System.Drawing.Color.DimGray;
            this.comboCity.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.comboCity.Items.AddRange(new object[] {
            "ADANA",
            "ADIYAMAN",
            "AFYONKARAHİSAR",
            "AĞRI",
            "AMASYA",
            "ANKARA",
            "ANTALYA",
            "ARTVİN",
            "AYDIN",
            "BALIKESİR",
            "BİLECİK",
            "BİNGÖL",
            "BİTLİS",
            "BOLU",
            "BURDUR",
            "BURSA",
            "ÇANAKKALE",
            "ÇANKIRI",
            "ÇORUM",
            "DENİZLİ",
            "DİYARBAKIR",
            "EDİRNE",
            "ELAZIĞ",
            "ERZİNCAN",
            "ERZURUM",
            "ESKİŞEHİR",
            "GAZİANTEP",
            "GİRESUN",
            "GÜMÜŞHANE",
            "HAKKARİ",
            "HATAY",
            "ISPARTA",
            "MERSİN",
            "İSTANBUL",
            "İZMİR",
            "KARS",
            "KASTAMONU",
            "KAYSERİ",
            "KIRKLARELİ",
            "KIRŞEHİR",
            "KOCAELİ (İZMİT)",
            "KONYA",
            "KÜTAHYA",
            "MALATYA",
            "MANİSA",
            "KAHRAMANMARAŞ",
            "MARDİN",
            "MUĞLA",
            "MUŞ",
            "NEVŞEHİR",
            "NİĞDE",
            "ORDU",
            "RİZE",
            "SAKARYA (ADAPAZARI)",
            "SAMSUN",
            "SİİRT",
            "SİNOP",
            "SİVAS",
            "TEKİRDAĞ",
            "TOKAT",
            "TRABZON",
            "TUNCELİ",
            "ŞANLIURFA",
            "UŞAK",
            "VAN",
            "YOZGAT",
            "ZONGULDAK",
            "AKSARAY",
            "BAYBURT",
            "KARAMAN",
            "KIRIKKALE",
            "BATMAN",
            "ŞIRNAK",
            "BARTIN",
            "ARDAHAN",
            "IĞDIR",
            "YALOVA",
            "KARABÜK",
            "KİLİS",
            "OSMANİYE",
            "DÜZCE"});
            this.comboCity.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboCity.ListTextColor = System.Drawing.Color.DimGray;
            this.comboCity.Location = new System.Drawing.Point(284, 360);
            this.comboCity.MinimumSize = new System.Drawing.Size(200, 30);
            this.comboCity.Name = "comboCity";
            this.comboCity.Padding = new System.Windows.Forms.Padding(1);
            this.comboCity.Size = new System.Drawing.Size(250, 30);
            this.comboCity.TabIndex = 17;
            this.comboCity.Texts = "İl Seçiniz";
            this.comboCity.OnSelectedIndexChanged += new System.EventHandler(this.syComboBox1_OnSelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(281, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(233, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Özel karakterler hariç.(@,Ü,Ş,Ç,#,+,%i,?,....)\r\n";
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Black;
            this.btnSignUp.BackgroundColor = System.Drawing.Color.Black;
            this.btnSignUp.BorderColor = System.Drawing.Color.Silver;
            this.btnSignUp.BorderRadius = 20;
            this.btnSignUp.BorderSize = 1;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(384, 617);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(150, 40);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "Kaydol";
            this.btnSignUp.TextColor = System.Drawing.Color.White;
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // tbxSignPass
            // 
            this.tbxSignPass.BackColor = System.Drawing.Color.Black;
            this.tbxSignPass.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxSignPass.BorderFocusColor = System.Drawing.Color.Red;
            this.tbxSignPass.BorderSize = 2;
            this.tbxSignPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSignPass.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxSignPass.Location = new System.Drawing.Point(284, 519);
            this.tbxSignPass.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSignPass.Multiline = false;
            this.tbxSignPass.Name = "tbxSignPass";
            this.tbxSignPass.Padding = new System.Windows.Forms.Padding(7);
            this.tbxSignPass.PasswordChar = true;
            this.tbxSignPass.Size = new System.Drawing.Size(250, 31);
            this.tbxSignPass.TabIndex = 15;
            this.tbxSignPass.Texts = "";
            this.tbxSignPass.UnderlinedStyle = true;
            // 
            // tbxSignUserName
            // 
            this.tbxSignUserName.BackColor = System.Drawing.Color.Black;
            this.tbxSignUserName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxSignUserName.BorderFocusColor = System.Drawing.Color.Orange;
            this.tbxSignUserName.BorderSize = 2;
            this.tbxSignUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSignUserName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxSignUserName.Location = new System.Drawing.Point(284, 440);
            this.tbxSignUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSignUserName.Multiline = false;
            this.tbxSignUserName.Name = "tbxSignUserName";
            this.tbxSignUserName.Padding = new System.Windows.Forms.Padding(7);
            this.tbxSignUserName.PasswordChar = false;
            this.tbxSignUserName.Size = new System.Drawing.Size(250, 31);
            this.tbxSignUserName.TabIndex = 14;
            this.tbxSignUserName.Texts = "";
            this.tbxSignUserName.UnderlinedStyle = true;
            // 
            // tbxSignSurname
            // 
            this.tbxSignSurname.BackColor = System.Drawing.Color.Black;
            this.tbxSignSurname.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxSignSurname.BorderFocusColor = System.Drawing.Color.Lime;
            this.tbxSignSurname.BorderSize = 2;
            this.tbxSignSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSignSurname.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxSignSurname.Location = new System.Drawing.Point(284, 273);
            this.tbxSignSurname.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSignSurname.Multiline = false;
            this.tbxSignSurname.Name = "tbxSignSurname";
            this.tbxSignSurname.Padding = new System.Windows.Forms.Padding(7);
            this.tbxSignSurname.PasswordChar = false;
            this.tbxSignSurname.Size = new System.Drawing.Size(250, 31);
            this.tbxSignSurname.TabIndex = 12;
            this.tbxSignSurname.Texts = "";
            this.tbxSignSurname.UnderlinedStyle = true;
            // 
            // tbxSignName
            // 
            this.tbxSignName.BackColor = System.Drawing.Color.Black;
            this.tbxSignName.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tbxSignName.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tbxSignName.BorderSize = 2;
            this.tbxSignName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxSignName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxSignName.Location = new System.Drawing.Point(284, 189);
            this.tbxSignName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSignName.Multiline = false;
            this.tbxSignName.Name = "tbxSignName";
            this.tbxSignName.Padding = new System.Windows.Forms.Padding(7);
            this.tbxSignName.PasswordChar = false;
            this.tbxSignName.Size = new System.Drawing.Size(250, 31);
            this.tbxSignName.TabIndex = 11;
            this.tbxSignName.Texts = "";
            this.tbxSignName.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(136, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(136, 455);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(136, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "İliniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soy Adınız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(136, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Adınız";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(212, 30);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(199, 56);
            this.lblSignUp.TabIndex = 1;
            this.lblSignUp.Text = "Kaydol";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 705);
            this.Controls.Add(this.signUpPanel);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.bulbharaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.signUpPanel.ResumeLayout(false);
            this.signUpPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bulbharaLabel;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Panel signUpPanel;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblSignUp;
        private MyControls.SyTextBox tbxUserName;
        private MyControls.SyTextBox tbxPass;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUserName;
        private MyControls.SyTextBox tbxSignPass;
        private MyControls.SyTextBox tbxSignUserName;
        private MyControls.SyTextBox tbxSignSurname;
        private MyControls.SyTextBox tbxSignName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MyControls.SyButton btnLogin;
        private MyControls.SyButton btnSignUp;
        private MyControls.SyToggleButton syToggleButton1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private MyControls.SyComboBox comboCity;
    }
}

