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

namespace Kütüphane3.Forms
{
    public partial class AniForm : Form
    {
        public AniForm()
        {
            InitializeComponent();
        }

        private void AniForm_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost; Database=kutuphane; Uid=root; Pwd=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=localhost; Database=kutuphane; Uid=root; Pwd=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();

                // Kullanıcıdan alınan verileri veritabanına eklemek için SQL sorgusu
                string query = "INSERT INTO Ani (adi, turu, yazari, id) VALUES (@adi, @turu, @yazari, @id)";
                MySqlCommand command = new MySqlCommand(query, connection);

                // TextBox'lardan alınan verileri parametre olarak ekle
                command.Parameters.AddWithValue("@adi", textBox1.Text);
                command.Parameters.AddWithValue("@turu", textBox2.Text);
                command.Parameters.AddWithValue("@yazari", textBox3.Text);
                command.Parameters.AddWithValue("@id", textBox4.Text);

                // SQL komutunu çalıştır
                command.ExecuteNonQuery();



                // Veritabanındaki tüm verileri tekrar çekip DataGridView'de göster
                LoadBooksToGrid();
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


        // DataGridView'i güncellemek için kullanılan fonksiyon
        private void LoadBooksToGrid()
        {
            string connectionString = "Server=localhost; Database=kutuphane; Uid=root; Pwd=root;";
            MySqlConnection connection = new MySqlConnection(connectionString);

            try
            {
                connection.Open();


                string query = "SELECT * FROM Ani"; // Kitaplar tablosundaki tüm veriler
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable); // Verileri DataTable'a doldur

                // DataGridView'e verileri bağla
                dataGridView1.DataSource = dataTable;
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

        private void guna2Button2_Click(object sender, EventArgs e)
        {


            // DataGridView'de herhangi bir satır seçili mi kontrol et
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırdaki ID değerini al
                int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                int bookID = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["ID"].Value);

                string connectionString = "Server=localhost; Database=kutuphane; Uid=root; Pwd=root;";
                MySqlConnection connection = new MySqlConnection(connectionString);

                try
                {
                    connection.Open();
                    // Silme işlemi için SQL komutu
                    string query = "DELETE FROM Ani WHERE ID = @id";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Silinecek kitabın ID'sini parametre olarak ekle
                    command.Parameters.AddWithValue("@id", bookID);

                    // Silme işlemini gerçekleştir
                    command.ExecuteNonQuery();

                    MessageBox.Show("Kitap başarıyla silindi.");

                    // Silme işlemi sonrası DataGridView'i güncelle
                    LoadBooksToGrid();
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
            else
            {
                MessageBox.Show("Silinecek bir kitap seçin.");
            }



        }
    }
}
