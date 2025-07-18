namespace Kütüphane3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnDini = new System.Windows.Forms.Button();
            this.btnSiir = new System.Windows.Forms.Button();
            this.btnTiyatro = new System.Windows.Forms.Button();
            this.btnHikaye = new System.Windows.Forms.Button();
            this.btnYerli = new System.Windows.Forms.Button();
            this.btnYabanci = new System.Windows.Forms.Button();
            this.btnEdb = new System.Windows.Forms.Button();
            this.btnAni = new System.Windows.Forms.Button();
            this.btnDil = new System.Windows.Forms.Button();
            this.btnBilim = new System.Windows.Forms.Button();
            this.btnPsk = new System.Windows.Forms.Button();
            this.btnAns = new System.Windows.Forms.Button();
            this.btnBen = new System.Windows.Forms.Button();
            this.btnTarih = new System.Windows.Forms.Button();
            this.btnSinav = new System.Windows.Forms.Button();
            this.btnGelişim = new System.Windows.Forms.Button();
            this.btnDergiler = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnDini);
            this.panelMenu.Controls.Add(this.btnSiir);
            this.panelMenu.Controls.Add(this.btnTiyatro);
            this.panelMenu.Controls.Add(this.btnHikaye);
            this.panelMenu.Controls.Add(this.btnYerli);
            this.panelMenu.Controls.Add(this.btnYabanci);
            this.panelMenu.Controls.Add(this.btnEdb);
            this.panelMenu.Controls.Add(this.btnAni);
            this.panelMenu.Controls.Add(this.btnDil);
            this.panelMenu.Controls.Add(this.btnBilim);
            this.panelMenu.Controls.Add(this.btnPsk);
            this.panelMenu.Controls.Add(this.btnAns);
            this.panelMenu.Controls.Add(this.btnBen);
            this.panelMenu.Controls.Add(this.btnTarih);
            this.panelMenu.Controls.Add(this.btnSinav);
            this.panelMenu.Controls.Add(this.btnGelişim);
            this.panelMenu.Controls.Add(this.btnDergiler);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(221, 1061);
            this.panelMenu.TabIndex = 0;
            // 
            // btnDini
            // 
            this.btnDini.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDini.FlatAppearance.BorderSize = 0;
            this.btnDini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDini.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDini.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDini.Image = ((System.Drawing.Image)(resources.GetObject("btnDini.Image")));
            this.btnDini.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDini.Location = new System.Drawing.Point(0, 595);
            this.btnDini.Name = "btnDini";
            this.btnDini.Size = new System.Drawing.Size(221, 35);
            this.btnDini.TabIndex = 18;
            this.btnDini.Text = "Dini ";
            this.btnDini.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDini.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDini.UseVisualStyleBackColor = true;
            this.btnDini.Click += new System.EventHandler(this.btnDini_Click_1);
            // 
            // btnSiir
            // 
            this.btnSiir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSiir.FlatAppearance.BorderSize = 0;
            this.btnSiir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSiir.Image = ((System.Drawing.Image)(resources.GetObject("btnSiir.Image")));
            this.btnSiir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiir.Location = new System.Drawing.Point(0, 560);
            this.btnSiir.Name = "btnSiir";
            this.btnSiir.Size = new System.Drawing.Size(221, 35);
            this.btnSiir.TabIndex = 17;
            this.btnSiir.Text = "Şiir";
            this.btnSiir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSiir.UseVisualStyleBackColor = true;
            this.btnSiir.Click += new System.EventHandler(this.btnSiir_Click_1);
            // 
            // btnTiyatro
            // 
            this.btnTiyatro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTiyatro.FlatAppearance.BorderSize = 0;
            this.btnTiyatro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiyatro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTiyatro.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTiyatro.Image = ((System.Drawing.Image)(resources.GetObject("btnTiyatro.Image")));
            this.btnTiyatro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiyatro.Location = new System.Drawing.Point(0, 525);
            this.btnTiyatro.Name = "btnTiyatro";
            this.btnTiyatro.Size = new System.Drawing.Size(221, 35);
            this.btnTiyatro.TabIndex = 16;
            this.btnTiyatro.Text = "Tiyatro";
            this.btnTiyatro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTiyatro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTiyatro.UseVisualStyleBackColor = true;
            this.btnTiyatro.Click += new System.EventHandler(this.btnTiyatro_Click_1);
            // 
            // btnHikaye
            // 
            this.btnHikaye.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHikaye.FlatAppearance.BorderSize = 0;
            this.btnHikaye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHikaye.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHikaye.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHikaye.Image = ((System.Drawing.Image)(resources.GetObject("btnHikaye.Image")));
            this.btnHikaye.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHikaye.Location = new System.Drawing.Point(0, 490);
            this.btnHikaye.Name = "btnHikaye";
            this.btnHikaye.Size = new System.Drawing.Size(221, 35);
            this.btnHikaye.TabIndex = 15;
            this.btnHikaye.Text = "Hikaye";
            this.btnHikaye.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHikaye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHikaye.UseVisualStyleBackColor = true;
            this.btnHikaye.Click += new System.EventHandler(this.btnHikaye_Click_1);
            // 
            // btnYerli
            // 
            this.btnYerli.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYerli.FlatAppearance.BorderSize = 0;
            this.btnYerli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYerli.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYerli.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnYerli.Image = ((System.Drawing.Image)(resources.GetObject("btnYerli.Image")));
            this.btnYerli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYerli.Location = new System.Drawing.Point(0, 455);
            this.btnYerli.Name = "btnYerli";
            this.btnYerli.Size = new System.Drawing.Size(221, 35);
            this.btnYerli.TabIndex = 14;
            this.btnYerli.Text = "Yerli Roman";
            this.btnYerli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYerli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYerli.UseVisualStyleBackColor = true;
            this.btnYerli.Click += new System.EventHandler(this.btnYerli_Click_1);
            // 
            // btnYabanci
            // 
            this.btnYabanci.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnYabanci.FlatAppearance.BorderSize = 0;
            this.btnYabanci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYabanci.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYabanci.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnYabanci.Image = ((System.Drawing.Image)(resources.GetObject("btnYabanci.Image")));
            this.btnYabanci.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYabanci.Location = new System.Drawing.Point(0, 420);
            this.btnYabanci.Name = "btnYabanci";
            this.btnYabanci.Size = new System.Drawing.Size(221, 35);
            this.btnYabanci.TabIndex = 13;
            this.btnYabanci.Text = "Yabancı Roman";
            this.btnYabanci.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYabanci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYabanci.UseVisualStyleBackColor = true;
            this.btnYabanci.Click += new System.EventHandler(this.btnYabanci_Click_1);
            // 
            // btnEdb
            // 
            this.btnEdb.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdb.FlatAppearance.BorderSize = 0;
            this.btnEdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdb.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEdb.Image = ((System.Drawing.Image)(resources.GetObject("btnEdb.Image")));
            this.btnEdb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdb.Location = new System.Drawing.Point(0, 385);
            this.btnEdb.Name = "btnEdb";
            this.btnEdb.Size = new System.Drawing.Size(221, 35);
            this.btnEdb.TabIndex = 12;
            this.btnEdb.Text = "Türk Edebiyatı Araştırma İnceleme";
            this.btnEdb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdb.UseVisualStyleBackColor = true;
            this.btnEdb.Click += new System.EventHandler(this.btnEdb_Click_1);
            // 
            // btnAni
            // 
            this.btnAni.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAni.FlatAppearance.BorderSize = 0;
            this.btnAni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAni.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAni.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAni.Image = ((System.Drawing.Image)(resources.GetObject("btnAni.Image")));
            this.btnAni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAni.Location = new System.Drawing.Point(0, 350);
            this.btnAni.Name = "btnAni";
            this.btnAni.Size = new System.Drawing.Size(221, 35);
            this.btnAni.TabIndex = 11;
            this.btnAni.Text = "Anı-Deneme-Günlük-Biyografi";
            this.btnAni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAni.UseVisualStyleBackColor = true;
            this.btnAni.Click += new System.EventHandler(this.btnAni_Click_1);
            // 
            // btnDil
            // 
            this.btnDil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDil.FlatAppearance.BorderSize = 0;
            this.btnDil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDil.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDil.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDil.Image = ((System.Drawing.Image)(resources.GetObject("btnDil.Image")));
            this.btnDil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDil.Location = new System.Drawing.Point(0, 315);
            this.btnDil.Name = "btnDil";
            this.btnDil.Size = new System.Drawing.Size(221, 35);
            this.btnDil.TabIndex = 10;
            this.btnDil.Text = "Yabancı Dil";
            this.btnDil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDil.UseVisualStyleBackColor = true;
            this.btnDil.Click += new System.EventHandler(this.btnDil_Click_1);
            // 
            // btnBilim
            // 
            this.btnBilim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBilim.FlatAppearance.BorderSize = 0;
            this.btnBilim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilim.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBilim.Image = ((System.Drawing.Image)(resources.GetObject("btnBilim.Image")));
            this.btnBilim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilim.Location = new System.Drawing.Point(0, 280);
            this.btnBilim.Name = "btnBilim";
            this.btnBilim.Size = new System.Drawing.Size(221, 35);
            this.btnBilim.TabIndex = 9;
            this.btnBilim.Text = "Bilim-Teknik";
            this.btnBilim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBilim.UseVisualStyleBackColor = true;
            this.btnBilim.Click += new System.EventHandler(this.btnBilim_Click);
            // 
            // btnPsk
            // 
            this.btnPsk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPsk.FlatAppearance.BorderSize = 0;
            this.btnPsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPsk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPsk.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPsk.Image = ((System.Drawing.Image)(resources.GetObject("btnPsk.Image")));
            this.btnPsk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPsk.Location = new System.Drawing.Point(0, 245);
            this.btnPsk.Name = "btnPsk";
            this.btnPsk.Size = new System.Drawing.Size(221, 35);
            this.btnPsk.TabIndex = 8;
            this.btnPsk.Text = "Psikoloji-Felsefe-Sosyoloji";
            this.btnPsk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPsk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPsk.UseVisualStyleBackColor = true;
            this.btnPsk.Click += new System.EventHandler(this.btnPsk_Click);
            // 
            // btnAns
            // 
            this.btnAns.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAns.FlatAppearance.BorderSize = 0;
            this.btnAns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAns.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAns.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAns.Image = ((System.Drawing.Image)(resources.GetObject("btnAns.Image")));
            this.btnAns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAns.Location = new System.Drawing.Point(0, 210);
            this.btnAns.Name = "btnAns";
            this.btnAns.Size = new System.Drawing.Size(221, 35);
            this.btnAns.TabIndex = 7;
            this.btnAns.Text = "Ansiklopedi";
            this.btnAns.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAns.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAns.UseVisualStyleBackColor = true;
            this.btnAns.Click += new System.EventHandler(this.btnAns_Click);
            // 
            // btnBen
            // 
            this.btnBen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBen.FlatAppearance.BorderSize = 0;
            this.btnBen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBen.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnBen.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBen.Image = ((System.Drawing.Image)(resources.GetObject("btnBen.Image")));
            this.btnBen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBen.Location = new System.Drawing.Point(0, 175);
            this.btnBen.Name = "btnBen";
            this.btnBen.Size = new System.Drawing.Size(221, 35);
            this.btnBen.TabIndex = 6;
            this.btnBen.Text = "Ben Okuyorum İstanbul Okuyor";
            this.btnBen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBen.UseVisualStyleBackColor = true;
            this.btnBen.Click += new System.EventHandler(this.btnBen_Click);
            // 
            // btnTarih
            // 
            this.btnTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTarih.FlatAppearance.BorderSize = 0;
            this.btnTarih.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarih.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnTarih.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTarih.Image = ((System.Drawing.Image)(resources.GetObject("btnTarih.Image")));
            this.btnTarih.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarih.Location = new System.Drawing.Point(0, 140);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Size = new System.Drawing.Size(221, 35);
            this.btnTarih.TabIndex = 5;
            this.btnTarih.Text = "Tarih";
            this.btnTarih.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarih.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTarih.UseVisualStyleBackColor = true;
            this.btnTarih.Click += new System.EventHandler(this.btnTarih_Click);
            // 
            // btnSinav
            // 
            this.btnSinav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSinav.FlatAppearance.BorderSize = 0;
            this.btnSinav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinav.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnSinav.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSinav.Image = ((System.Drawing.Image)(resources.GetObject("btnSinav.Image")));
            this.btnSinav.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinav.Location = new System.Drawing.Point(0, 105);
            this.btnSinav.Name = "btnSinav";
            this.btnSinav.Size = new System.Drawing.Size(221, 35);
            this.btnSinav.TabIndex = 4;
            this.btnSinav.Text = "Sınava Hazırlık";
            this.btnSinav.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSinav.UseVisualStyleBackColor = true;
            this.btnSinav.Click += new System.EventHandler(this.btnSinav_Click);
            // 
            // btnGelişim
            // 
            this.btnGelişim.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGelişim.FlatAppearance.BorderSize = 0;
            this.btnGelişim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGelişim.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnGelişim.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGelişim.Image = ((System.Drawing.Image)(resources.GetObject("btnGelişim.Image")));
            this.btnGelişim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGelişim.Location = new System.Drawing.Point(0, 70);
            this.btnGelişim.Name = "btnGelişim";
            this.btnGelişim.Size = new System.Drawing.Size(221, 35);
            this.btnGelişim.TabIndex = 3;
            this.btnGelişim.Text = "Kişisel Gelişim";
            this.btnGelişim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGelişim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGelişim.UseVisualStyleBackColor = true;
            this.btnGelişim.Click += new System.EventHandler(this.btnGelişim_Click);
            // 
            // btnDergiler
            // 
            this.btnDergiler.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDergiler.FlatAppearance.BorderSize = 0;
            this.btnDergiler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDergiler.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnDergiler.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDergiler.Image = ((System.Drawing.Image)(resources.GetObject("btnDergiler.Image")));
            this.btnDergiler.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDergiler.Location = new System.Drawing.Point(0, 35);
            this.btnDergiler.Name = "btnDergiler";
            this.btnDergiler.Size = new System.Drawing.Size(221, 35);
            this.btnDergiler.TabIndex = 2;
            this.btnDergiler.Text = "Dergiler";
            this.btnDergiler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDergiler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDergiler.UseVisualStyleBackColor = true;
            this.btnDergiler.Click += new System.EventHandler(this.btnDergiler_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(221, 35);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Anasayfa";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(221, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(995, 80);
            this.panelTitleBar.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(439, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ANASAYFA";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(221, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(995, 981);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 1061);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "KÜTÜPHANE OTOMASYONU";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnDergiler;
        private System.Windows.Forms.Button btnAns;
        private System.Windows.Forms.Button btnBen;
        private System.Windows.Forms.Button btnTarih;
        private System.Windows.Forms.Button btnSinav;
        private System.Windows.Forms.Button btnGelişim;
        private System.Windows.Forms.Button btnBilim;
        private System.Windows.Forms.Button btnPsk;
        private System.Windows.Forms.Button btnDini;
        private System.Windows.Forms.Button btnSiir;
        private System.Windows.Forms.Button btnTiyatro;
        private System.Windows.Forms.Button btnHikaye;
        private System.Windows.Forms.Button btnYerli;
        private System.Windows.Forms.Button btnYabanci;
        private System.Windows.Forms.Button btnEdb;
        private System.Windows.Forms.Button btnAni;
        private System.Windows.Forms.Button btnDil;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
    }
}

