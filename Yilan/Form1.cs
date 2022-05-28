using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yilan
{
    public partial class Form1 : Form
    {
        private Label _yilanKafasi;
        private int _yilanParcasiArasiMesafe = 2;
        private int _yilanParcasiSayisi;
        private int _yilanBoyutu = 20;
        private int _yemBoyutu = 12;
        private Random _random;
        private Label _yem;
        private Label _altunyem;
        private HareketYonu _yon;
        private int bocek_sayac = 0;
        private int altun_yem_sayac = 0;
        private int altun_yem_olusum = 0;
        public Form1()
        {
            InitializeComponent();
            _random = new Random();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Sifirla();
        }
        private void YenidenBaslat()
        {
            lblPuan.Text = "0";
            lblSure.Text = "0";
            Sifirla();
        }
        private void Sifirla()
        {
            this.pnloyun.Controls.Clear();
            YemOlustur();
            AltunYemOlustur();
            _yilanParcasiSayisi = 1;
            YeminYeriniDegistir();
            AltunYeminYeriniDegistir();
            YilaniYerlestir();
            _yon = HareketYonu.Saga;
            timerYilanHareketi.Enabled = true;
            timerSaat.Enabled = true;
        }
        private Label YilanParcasiOlustur(int locationX, int locationY)
        {
            _yilanParcasiSayisi++;
            Label lbl = new Label()
            {
                Name = "yilanParca" + _yilanParcasiSayisi,
                BackColor = Color.Aquamarine,
                Width = _yilanBoyutu,
                Height = _yilanBoyutu,
                Location = new Point(locationX, locationY)
            };
            this.pnloyun.Controls.Add(lbl);
            return lbl;
        }

        private void YilaniYerlestir()
        {
            _yilanKafasi = YilanParcasiOlustur(0, 0);
            _yilanKafasi.Text = "☆";
            _yilanKafasi.TextAlign = ContentAlignment.MiddleCenter;
            _yilanKafasi.ForeColor = Color.DarkRed;
            var pnllocationX = ((pnloyun.Width / 2) - (_yilanKafasi.Width / 2));
            var pnllocationY = ((pnloyun.Height / 2) - (_yilanKafasi.Height / 2));
            _yilanKafasi.Location = new Point(pnllocationX, pnllocationY);
        }

        private void YemOlustur()
        {

            Label yem = new Label()
            {
                Name = "normalyem",
                BackColor = Color.White,
                Width = _yemBoyutu,
                Height = _yemBoyutu,
            };
            _yem = yem;
            this.pnloyun.Controls.Add(yem);
        }
        
        private void AltunYemOlustur()
        {

            Label altun = new Label()
            {
                Name = "altunyem",
                BackColor = Color.Gold,
                Width = 25,
                Height = 25,
            };
            altun.Visible = false;
            altun.Enabled = false;
            _altunyem = altun;
            this.pnloyun.Controls.Add(altun);

        }

        private void YeminYeriniDegistir()
        {
            var locationX = 0;
            var locationY = 0;

            bool durum;
            do
            {
                durum = false;
                locationX = _random.Next(0, pnloyun.Width - _yemBoyutu);
                locationY = _random.Next(0, pnloyun.Height - _yemBoyutu);

                var rect1 = new Rectangle(new Point(locationX, locationY), _yem.Size);
                foreach (Control control in pnloyun.Controls)
                {
                    if (control is Label && control.Name.Contains("[yilanParca,altunyem]"))
                    {
                        var rect2 = new Rectangle(control.Location, control.Size);
                        if (rect1.IntersectsWith(rect2))
                        {
                            durum = true;
                            break;
                        }
                    }
                }
            } while (durum);

            _yem.Location = new Point(locationX, locationY);
        }
        
        private void AltunYeminYeriniDegistir()
        {
            var locationX = 0;
            var locationY = 0;

            bool durum;
            do
            {
                durum = false;
                locationX = _random.Next(0, pnloyun.Width - 25);
                locationY = _random.Next(0, pnloyun.Height - 25);
                var rect1 = new Rectangle(new Point(locationX, locationY), _altunyem.Size);
                foreach (Control control in pnloyun.Controls)
                {
                    if (control is Label && control.Name.Contains("[yilanParca,normalyem]"))
                    {
                        var rect2 = new Rectangle(control.Location, control.Size);
                        if (rect1.IntersectsWith(rect2))
                        {
                            durum = true;
                            break;
                        }
                    }
                }
            } while (durum);

            _altunyem.Location = new Point(locationX, locationY);
        }
        private enum HareketYonu
        {
            Yukari,
            Asagi,
            Sola,
            Saga
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            var keyCode = e.KeyCode;

            if (_yon == HareketYonu.Sola && keyCode == Keys.D
                || _yon == HareketYonu.Saga && keyCode == Keys.A
                || _yon == HareketYonu.Yukari && keyCode == Keys.S
                || _yon == HareketYonu.Asagi && keyCode == Keys.W)
            {
                return;
            }

            switch (keyCode)
            {
                case Keys.W:
                    _yon = HareketYonu.Yukari;
                    break;
                case Keys.S:
                    _yon = HareketYonu.Asagi;
                    break;
                case Keys.A:
                    _yon = HareketYonu.Sola;
                    break;
                case Keys.D:
                    _yon = HareketYonu.Saga;
                    break;
                case Keys.P:
                    timerSaat.Enabled = false;
                    timerYilanHareketi.Enabled = false;
                    break;
                case Keys.C:
                    timerSaat.Enabled = true;
                    timerYilanHareketi.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void timerYilanHareketi_Tick(object sender, EventArgs e)
        {
            YilanKafasiniTakipEt();
            YilaniYurut();
            OyunBittimi();
            YilanYemiYedimi();
            
            
            if (_yilanParcasiSayisi > 12 && _yilanParcasiSayisi <20)
            {
              
                BocekGO();
                bocek_sayac++;
                
            }

        }

        private void BocekGO()
        {
            var locationX = bocek.Location.X;
            var locationY = bocek.Location.Y-20;


            bocek.Location = new Point(locationX, locationY);
            if(bocek_sayac % 2 == 1)
            {
                bocek.Image = null;
                bocek.Image = Yilan.Properties.Resources.bocek2;
            }
            else
            {
                bocek.Image = null;
                bocek.Image = Yilan.Properties.Resources.bocek1;
                
            }
        }


        private void YilaniYurut()
        {
            var locationX = _yilanKafasi.Location.X;
            var locationY = _yilanKafasi.Location.Y;
            switch (_yon)
            {
                case HareketYonu.Yukari:
                    _yilanKafasi.Location = new Point(locationX, locationY - (_yilanKafasi.Width + _yilanParcasiArasiMesafe));
                    break;
                case HareketYonu.Asagi:
                    _yilanKafasi.Location = new Point(locationX, locationY + (_yilanKafasi.Width + _yilanParcasiArasiMesafe));
                    break;
                case HareketYonu.Sola:
                    _yilanKafasi.Location = new Point(locationX - (_yilanKafasi.Height + _yilanParcasiArasiMesafe), locationY);
                    break;
                case HareketYonu.Saga:
                    _yilanKafasi.Location = new Point(locationX + (_yilanKafasi.Height + _yilanParcasiArasiMesafe), locationY);
                    break;
                default:
                    break;
            }
            if(locationX > pnloyun.Width) _yilanKafasi.Location = new Point(locationX - pnloyun.Width, locationY);
            else if (locationX < pnloyun.Location.X - _yilanKafasi.Size.Width) _yilanKafasi.Location = new Point(locationX + pnloyun.Width, locationY);
            else if (locationY > pnloyun.Height) _yilanKafasi.Location = new Point(locationX, locationY - pnloyun.Height - _yilanKafasi.Size.Width);
            else if (locationY < -_yilanKafasi.Size.Width) _yilanKafasi.Location = new Point(locationX, locationY + pnloyun.Height);
        }
        private void OyunBittimi()
        {
            bool oyunBittimi = false;
            var rect1 = new Rectangle(_yilanKafasi.Location, _yilanKafasi.Size);

            foreach(Control control in pnloyun.Controls)
            {
                if(control is Label && control.Name.Contains("yilanParca") && control.Name != _yilanKafasi.Name)
                {
                    var rect2 = new Rectangle(control.Location, control.Size);
                    if (rect1.IntersectsWith(rect2))
                    {
                        oyunBittimi = true;
                        break;
                    }
                }
            }

            if (oyunBittimi)
            {
                timerYilanHareketi.Enabled = false;
                timerSaat.Enabled = false;
                DialogResult sonuc = MessageBox.Show("Puanınız : " + lblPuan.Text, "Oyun Bitti!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if(sonuc == DialogResult.OK)
                {
                    YenidenBaslat();
                }
            }
        }
        private void YilanYemiYedimi()
        {
            var rect1 = new Rectangle(_yilanKafasi.Location, _yilanKafasi.Size);
            var rect2 = new Rectangle(_yem.Location, _yem.Size);
            var rect3 = new Rectangle(_altunyem.Location, _altunyem.Size);

            if (rect1.IntersectsWith(rect2))
            {
                lblPuan.Text = (Convert.ToInt32(lblPuan.Text) + 10).ToString();
                YeminYeriniDegistir();
                YilanParcasiOlustur( - _yilanBoyutu, - _yilanBoyutu);
                altun_yem_olusum++;
            }
            
            if (altun_yem_olusum>4)
            {
                altun_yem_olusum = 0;
                _altunyem.Visible = true;
                _altunyem.Enabled = true;
            }
            if (_altunyem.Visible && rect1.IntersectsWith(rect3))
            {
                _altunyem.Visible = false;
                _altunyem.Enabled = false;
                altun_yem_sayac = 0;
                lblPuan.Text = (Convert.ToInt32(lblPuan.Text) + 30).ToString();
                AltunYeminYeriniDegistir();
                for(int i = 0; i < 3; i++)
                {
                    YilanParcasiOlustur(-_yilanBoyutu, -_yilanBoyutu);
                }

            }
        }



        private void YilanKafasiniTakipEt()
        {
            if (_yilanParcasiSayisi <= 2) return;

            for(int i = _yilanParcasiSayisi; i > 2;i--)
            {
                var sonrakiParca = pnloyun.Controls[i];
                var oncekiParca = pnloyun.Controls[i-1];

                sonrakiParca.Location = oncekiParca.Location;
            }
        }

        private void saat_Tick(object sender, EventArgs e)
        {
            lblSure.Text = (Convert.ToInt32(lblSure.Text) + 1).ToString();
            
            if (_altunyem.Visible)
            {
                altun_yem_sayac++;
                if(altun_yem_sayac >= 3)
                {
                    altun_yem_sayac = 0;
                    _altunyem.Visible = false;
                    _altunyem.Enabled = false;
                }
            }
        }

        private void btn_baslat_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            KeyPreview = true;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
