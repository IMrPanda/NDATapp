using NDATapp.Controllers;
using NDATapp.Models;

namespace NDATapp
{
    public partial class Form1 : Form
    {
        private SiparisController _controller = new SiparisController();

        public Form1()
        {
            InitializeComponent();
            

            // Logger'dan gelen mesajları ListBox'a yazıyoz
            Logger.GetInstance().LogEklendi = (mesaj) =>
            {
                // Thread güvenliği için Invoke kullanıyoruz
                lstLoglar.Invoke(new Action(() => lstLoglar.Items.Add(mesaj)));
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ComboBox'ları dolduruyoz
            cmbUrunler.Items.AddRange(new object[] { "Kalem (Basit)", "Bilgisayar Kasası (Karmaşık)" });
            cmbKargo.Items.AddRange(new object[] { "Aras", "Yurtici" });
            cmbOdeme.Items.AddRange(new object[] { "Kredi Kartı", "Havale" , "Kripto Cüzdan" });

            cmbUrunler.SelectedIndex = 0;
            cmbKargo.SelectedIndex = 0;
            cmbOdeme.SelectedIndex = 0;
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.SiparisIsle(
                    cmbUrunler.SelectedItem.ToString(),
                    cmbKargo.SelectedItem.ToString(),
                    cmbOdeme.SelectedItem.ToString()
                );
                MessageBox.Show("Sipariş başarıyla işlendi! Logları kontrol edin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnYonetim_Click(object sender, EventArgs e)
        {
            SiparisYonetimForm yonetim = new SiparisYonetimForm();
            yonetim.Show(); // İkinci formu açar
        }
    }
}