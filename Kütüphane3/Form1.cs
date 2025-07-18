using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;




namespace Kütüphane3
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempİndex;
        private Form activeForm;

        //Constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }




        public class DatabaseHelper
        {
            private static string connectionString = "server=localhost;database=kutuphane;uid=root;pwd=root;";

            public static MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }

        






//Methods
private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempİndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempİndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    panelTitleBar.BackColor = color;


                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                }
            }
        }


        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }






        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AnasayfaForm(),sender);
        }

        private void btnDergiler_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DergilerForm(), sender);
        }

        private void btnGelişim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.KisiselForm(), sender);
        }

        private void btnSinav_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SinavForm(), sender);
        }

        private void btnTarih_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TarihForm(), sender);
        }

        private void btnBen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.BenForm(), sender);
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AnsForm(), sender);
        }

        private void btnPsk_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.PskForm(), sender);
        }

        private void btnBilim_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.BlmForm(), sender);
        }

        private void btnDil_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DilForm(), sender);
        }

        private void btnAni_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AniForm(), sender);
        }

        private void btnEdb_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.EdbForm(), sender);
        }

        private void btnYabanci_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.YabanciForm(), sender);
        }

        private void btnYerli_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.YerliForm(), sender);
        }

        private void btnHikaye_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.HikayeForm(), sender);
        }

        private void btnTiyatro_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TiyatroForm(), sender);
        }

        private void btnSiir_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SiirForm(), sender);
        }

        private void btnDini_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DiniForm(), sender);
        }

        private void btnDil_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DilForm(), sender);
        }

        private void btnAni_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AniForm(), sender);
        }

        private void btnEdb_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.EdbForm(), sender);
        }

        private void btnYabanci_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.YabanciForm(), sender);
        }

        private void btnYerli_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.YerliForm(), sender);
        }

        private void btnHikaye_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.HikayeForm(), sender);
        }

        private void btnTiyatro_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TiyatroForm(), sender);
        }

        private void btnSiir_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SiirForm(), sender);
        }

        private void btnDini_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DiniForm(), sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Database=kutuphane; Uid=root; Pwd=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();
                MessageBox.Show("Bağlantı Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
