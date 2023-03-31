namespace OtelSEO
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.login_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel_login = new Guna.UI2.WinForms.Guna2Button();
            this.panel_register = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Province = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.register_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.register_again_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.register_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.register_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.phone_number = new Guna.UI2.WinForms.Guna2TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // login_email
            // 
            this.login_email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_email.BorderColor = System.Drawing.Color.Indigo;
            this.login_email.BorderRadius = 6;
            this.login_email.BorderThickness = 2;
            this.login_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_email.DefaultText = "";
            this.login_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_email.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.login_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_email.Location = new System.Drawing.Point(140, 25);
            this.login_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_email.Name = "login_email";
            this.login_email.PasswordChar = '\0';
            this.login_email.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.login_email.PlaceholderText = "Email";
            this.login_email.SelectedText = "";
            this.login_email.Size = new System.Drawing.Size(219, 41);
            this.login_email.TabIndex = 0;
            this.login_email.TextChanged += new System.EventHandler(this.login_email_TextChanged);
            // 
            // login_password
            // 
            this.login_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_password.BorderColor = System.Drawing.Color.Indigo;
            this.login_password.BorderRadius = 6;
            this.login_password.BorderThickness = 2;
            this.login_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login_password.DefaultText = "";
            this.login_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.login_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.login_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.login_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_password.Location = new System.Drawing.Point(140, 83);
            this.login_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.login_password.PlaceholderText = "Password";
            this.login_password.SelectedText = "";
            this.login_password.Size = new System.Drawing.Size(219, 41);
            this.login_password.TabIndex = 1;
            this.login_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // panel_login
            // 
            this.panel_login.Animated = true;
            this.panel_login.BackColor = System.Drawing.Color.Transparent;
            this.panel_login.BorderRadius = 10;
            this.panel_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panel_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panel_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panel_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panel_login.FillColor = System.Drawing.Color.SlateBlue;
            this.panel_login.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel_login.ForeColor = System.Drawing.Color.White;
            this.panel_login.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.panel_login.Location = new System.Drawing.Point(140, 142);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(84, 33);
            this.panel_login.TabIndex = 2;
            this.panel_login.Text = "Login";
            this.panel_login.UseTransparentBackground = true;
            this.panel_login.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel_register
            // 
            this.panel_register.Animated = true;
            this.panel_register.BackColor = System.Drawing.Color.Transparent;
            this.panel_register.BorderRadius = 10;
            this.panel_register.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.panel_register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.panel_register.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.panel_register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.panel_register.FillColor = System.Drawing.Color.SlateBlue;
            this.panel_register.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.panel_register.ForeColor = System.Drawing.Color.White;
            this.panel_register.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.panel_register.HoverState.ForeColor = System.Drawing.Color.White;
            this.panel_register.Location = new System.Drawing.Point(273, 142);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(84, 33);
            this.panel_register.TabIndex = 3;
            this.panel_register.Text = "Register";
            this.panel_register.UseTransparentBackground = true;
            this.panel_register.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.login_email);
            this.guna2Panel1.Controls.Add(this.panel_register);
            this.guna2Panel1.Controls.Add(this.login_password);
            this.guna2Panel1.Controls.Add(this.panel_login);
            this.guna2Panel1.Location = new System.Drawing.Point(97, 157);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(523, 350);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.Province);
            this.guna2Panel2.Controls.Add(this.guna2Button4);
            this.guna2Panel2.Controls.Add(this.guna2Button3);
            this.guna2Panel2.Controls.Add(this.register_password);
            this.guna2Panel2.Controls.Add(this.register_again_password);
            this.guna2Panel2.Controls.Add(this.register_username);
            this.guna2Panel2.Controls.Add(this.register_email);
            this.guna2Panel2.Controls.Add(this.phone_number);
            this.guna2Panel2.Location = new System.Drawing.Point(97, 157);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(523, 350);
            this.guna2Panel2.TabIndex = 5;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // Province
            // 
            this.Province.BackColor = System.Drawing.Color.Transparent;
            this.Province.BorderColor = System.Drawing.Color.Indigo;
            this.Province.BorderRadius = 6;
            this.Province.BorderThickness = 2;
            this.Province.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Province.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Province.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Province.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Province.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Province.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Province.ItemHeight = 30;
            this.Province.Location = new System.Drawing.Point(273, 152);
            this.Province.Name = "Province";
            this.Province.Size = new System.Drawing.Size(219, 36);
            this.Province.TabIndex = 10;
            this.Province.SelectedIndexChanged += new System.EventHandler(this.Province_SelectedIndexChanged);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 10;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button4.Location = new System.Drawing.Point(273, 219);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(64, 33);
            this.guna2Button4.TabIndex = 7;
            this.guna2Button4.Text = "Back";
            this.guna2Button4.UseTransparentBackground = true;
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 10;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.SlateBlue;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.guna2Button3.Location = new System.Drawing.Point(373, 219);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(119, 33);
            this.guna2Button3.TabIndex = 6;
            this.guna2Button3.Text = "Create Account";
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // register_password
            // 
            this.register_password.BorderColor = System.Drawing.Color.Indigo;
            this.register_password.BorderRadius = 6;
            this.register_password.BorderThickness = 2;
            this.register_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_password.DefaultText = "";
            this.register_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.register_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.register_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.register_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_password.Location = new System.Drawing.Point(15, 83);
            this.register_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_password.Name = "register_password";
            this.register_password.PasswordChar = '*';
            this.register_password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.register_password.PlaceholderText = "Password";
            this.register_password.SelectedText = "";
            this.register_password.Size = new System.Drawing.Size(219, 41);
            this.register_password.TabIndex = 3;
            this.register_password.TextChanged += new System.EventHandler(this.register_password_TextChanged);
            // 
            // register_again_password
            // 
            this.register_again_password.BorderColor = System.Drawing.Color.Indigo;
            this.register_again_password.BorderRadius = 6;
            this.register_again_password.BorderThickness = 2;
            this.register_again_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_again_password.DefaultText = "";
            this.register_again_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.register_again_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_again_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_again_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_again_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_again_password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.register_again_password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.register_again_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_again_password.Location = new System.Drawing.Point(273, 83);
            this.register_again_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_again_password.Name = "register_again_password";
            this.register_again_password.PasswordChar = '*';
            this.register_again_password.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.register_again_password.PlaceholderText = "Again Password";
            this.register_again_password.SelectedText = "";
            this.register_again_password.Size = new System.Drawing.Size(219, 41);
            this.register_again_password.TabIndex = 2;
            this.register_again_password.TextChanged += new System.EventHandler(this.register_again_password_TextChanged);
            // 
            // register_username
            // 
            this.register_username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register_username.BorderColor = System.Drawing.Color.Indigo;
            this.register_username.BorderRadius = 6;
            this.register_username.BorderThickness = 2;
            this.register_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_username.DefaultText = "";
            this.register_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.register_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_username.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.register_username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.register_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_username.Location = new System.Drawing.Point(16, 25);
            this.register_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_username.Name = "register_username";
            this.register_username.PasswordChar = '\0';
            this.register_username.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.register_username.PlaceholderText = "Username";
            this.register_username.SelectedText = "";
            this.register_username.Size = new System.Drawing.Size(219, 41);
            this.register_username.TabIndex = 0;
            this.register_username.TextChanged += new System.EventHandler(this.register_username_TextChanged);
            // 
            // register_email
            // 
            this.register_email.BorderColor = System.Drawing.Color.Indigo;
            this.register_email.BorderRadius = 6;
            this.register_email.BorderThickness = 2;
            this.register_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.register_email.DefaultText = "";
            this.register_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.register_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.register_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.register_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_email.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.register_email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.register_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.register_email.Location = new System.Drawing.Point(273, 25);
            this.register_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.register_email.Name = "register_email";
            this.register_email.PasswordChar = '\0';
            this.register_email.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.register_email.PlaceholderText = "Email";
            this.register_email.SelectedText = "";
            this.register_email.Size = new System.Drawing.Size(219, 41);
            this.register_email.TabIndex = 1;
            this.register_email.TextChanged += new System.EventHandler(this.register_email_TextChanged);
            // 
            // phone_number
            // 
            this.phone_number.BorderColor = System.Drawing.Color.Indigo;
            this.phone_number.BorderRadius = 6;
            this.phone_number.BorderThickness = 2;
            this.phone_number.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone_number.DefaultText = "";
            this.phone_number.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phone_number.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phone_number.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone_number.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone_number.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_number.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.phone_number.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phone_number.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_number.Location = new System.Drawing.Point(16, 147);
            this.phone_number.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phone_number.Name = "phone_number";
            this.phone_number.PasswordChar = '\0';
            this.phone_number.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.phone_number.PlaceholderText = "Phone Number";
            this.phone_number.SelectedText = "";
            this.phone_number.Size = new System.Drawing.Size(219, 41);
            this.phone_number.TabIndex = 8;
            this.phone_number.TextChanged += new System.EventHandler(this.phone_number_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BorderRadius = 2;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(663, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(35, 29);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BorderRadius = 2;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(628, 1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(35, 29);
            this.guna2ControlBox2.TabIndex = 7;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BorderRadius = 2;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(592, 1);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.Size = new System.Drawing.Size(35, 29);
            this.guna2ControlBox3.TabIndex = 8;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::OtelSEO.Properties.Resources.LOGO;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(152, 33);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(382, 106);
            this.guna2PictureBox1.TabIndex = 16;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2ControlBox3);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox login_email;
        private Guna.UI2.WinForms.Guna2TextBox login_password;
        private Guna.UI2.WinForms.Guna2Button panel_login;
        private Guna.UI2.WinForms.Guna2Button panel_register;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2TextBox register_password;
        private Guna.UI2.WinForms.Guna2TextBox register_again_password;
        private Guna.UI2.WinForms.Guna2TextBox register_username;
        private Guna.UI2.WinForms.Guna2TextBox register_email;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2TextBox phone_number;
        private Guna.UI2.WinForms.Guna2ComboBox Province;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

