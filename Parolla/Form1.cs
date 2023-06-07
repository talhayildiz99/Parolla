using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parolla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int SoruNo = 0, Dogru = 0, Yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (SoruNo)
                {
                    case 1:
                        if (textBox1.Text == "ANIT")
                        {
                            buttonA.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonA.BackColor = Color.Red;
                        }
                        break;  
                    case 2:
                        if (textBox1.Text == "BİTAP")
                        {
                            buttonB.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonB.BackColor = Color.Red;
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "CAİZ")
                        {
                            buttonC.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonC.BackColor = Color.Red;
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "ÇARPICI")
                        {
                            buttonCH.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonCH.BackColor = Color.Red;
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "DEŞARJ")
                        {
                            buttonD.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonD.BackColor = Color.Red;
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "EMNİYET")
                        {
                            buttonE.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonE.BackColor = Color.Red;
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "FAKTÖR")
                        {
                            buttonF.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonF.BackColor = Color.Red;
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "GÜRUH")
                        {
                            buttonG.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonG.BackColor = Color.Red;
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "HÜKÜMDAR")
                        {
                            buttonH.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonH.BackColor = Color.Red;
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "ISLAK")
                        {
                            buttonI.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonI.BackColor = Color.Red;
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "İŞKİLLENMEK")
                        {
                            buttonIH.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonIH.BackColor = Color.Red;
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "JAK")
                        {
                            buttonJ.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonJ.BackColor = Color.Red;
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "KLAVYE")
                        {
                            buttonK.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonK.BackColor = Color.Red;
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "LİBİDO")
                        {
                            buttonL.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonL.BackColor = Color.Red;
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "MARŞ")
                        {
                            buttonM.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonM.BackColor = Color.Red;
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "NEVA")
                        {
                            buttonN.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonN.BackColor = Color.Red;
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "OĞLAN")
                        {
                            buttonO.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonO.BackColor = Color.Red;
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "ÖRF")
                        {
                            buttonOH.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonOH.BackColor = Color.Red;
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "PAÇA")
                        {
                            buttonP.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonP.BackColor = Color.Red;
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "RÜTBE")
                        {
                            buttonR.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonR.BackColor = Color.Red;
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "STENT")
                        {
                            buttonS.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonS.BackColor = Color.Red;
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "ŞIK")
                        {
                            buttonSH.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonSH.BackColor = Color.Red;
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "TENİS")
                        {
                            buttonT.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonT.BackColor = Color.Red;
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "UZAY")
                        {
                            buttonU.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonU.BackColor = Color.Red;
                        }
                        break;
                    case 25:
                        if (textBox1.Text == "ÜNLÜ")
                        {
                            buttonUH.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonUH.BackColor = Color.Red;
                        }
                        break;
                    case 26:
                        if (textBox1.Text == "VEFA")
                        {
                            buttonV.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonV.BackColor = Color.Red;
                        }
                        break;
                    case 27:
                        if (textBox1.Text == "YEVMİYE")
                        {
                            buttonY.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonY.BackColor = Color.Red;
                        }
                        break;
                    case 28:
                        if (textBox1.Text == "ZİRVE")
                        {
                            buttonZ.BackColor = Color.Green;
                        }
                        else
                        {
                            buttonZ.BackColor = Color.Red;
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SoruNo++;
            this.Text = SoruNo.ToString();

            if (SoruNo == 1)
            {
                richTextBox1.Text = "Sembol niteliğindeki yapı";
                buttonA.BackColor = Color.Yellow;
            }
            if (SoruNo == 2)
            {
                richTextBox1.Text = "Yorgun, bitkin düşmüş olan";
                buttonB.BackColor = Color.Yellow;
            }
            if (SoruNo == 3)
            {
                richTextBox1.Text = "Uygun, yerinde sayılan, yakışık alan ?";
                buttonC.BackColor = Color.Yellow;
            }
            if (SoruNo == 4)
            {
                richTextBox1.Text = "Etkili, dikkat çeken, sansasyonel";
                buttonCH.BackColor = Color.Yellow;
            }
            if (SoruNo == 5)
            {
                richTextBox1.Text = "Doluluğunu, gücünü yitirme";
                buttonD.BackColor = Color.Yellow;
            }
            if (SoruNo == 6)
            {
                richTextBox1.Text = "Kazalara alınmış tedbirler";
                buttonE.BackColor = Color.Yellow;
            }
            if (SoruNo == 7)
            {
                richTextBox1.Text = "Etken, etmen";
                buttonF.BackColor = Color.Yellow;
            }
            if (SoruNo == 8)
            {
                richTextBox1.Text = "Değersiz, aşağı görülen, küçümsenen topluluk, derinti, sürü";
                buttonG.BackColor = Color.Yellow;
            }
            if (SoruNo == 9)
            {
                richTextBox1.Text = "Taht sahibi olan devlet başkanı";
                buttonH.BackColor = Color.Yellow;
            }
            if (SoruNo == 10)
            {
                richTextBox1.Text = "Kuru olmama durumu";
                buttonI.BackColor = Color.Yellow;
            }
            if (SoruNo == 11)
            {
                richTextBox1.Text = "Şüphe etmek, kuşkulanmak";
                buttonIH.BackColor = Color.Yellow;
            }
            if (SoruNo == 12)
            {
                richTextBox1.Text = "Kulaklık, hoparlör ve mikrofon gibi cihazların kullandığı ses çıkışı amaçlı kullanılan giriş";
                buttonJ.BackColor = Color.Yellow;
            }
            if (SoruNo == 13)
            {
                richTextBox1.Text = "Üzerinde harfler, rakamlar, işaretler ve bazı işlevleri bulunan bilgisayar giriş ögesi";
                buttonK.BackColor = Color.Yellow;
            }
            if (SoruNo == 14)
            {
                richTextBox1.Text = "İnsanın davranışlarının temelini oluşturan cinsel içgüdü";
                buttonL.BackColor = Color.Yellow;
            }
            if (SoruNo == 15)
            {
                richTextBox1.Text = "Bir topluluğu simgelemek için düzenlenmiş müzik parçası";
                buttonM.BackColor = Color.Yellow;
            }
            if (SoruNo == 16)
            {
                richTextBox1.Text = "Klasik Türk müziğinde bir makam adı ve yegâhtan bir oktav tiz olan 're' perdesi";
                buttonN.BackColor = Color.Yellow;
            }
            if (SoruNo == 17)
            {
                richTextBox1.Text = "Erkek çocuk";
                buttonO.BackColor = Color.Yellow;
            }
            if (SoruNo == 18)
            {
                richTextBox1.Text = "Yasalarla belirlenmeyen, halkın kendiliğinden uyduğu gelenek";
                buttonOH.BackColor = Color.Yellow;
            }
            if (SoruNo == 19)
            {
                richTextBox1.Text = "Pantolon, don, şalvar vb. giyeceklerde bacakların çıktığı aşağı bölüm";
                buttonP.BackColor = Color.Yellow;
            }
            if (SoruNo == 20)
            {
                richTextBox1.Text = "Mertebe, derece";
                buttonR.BackColor = Color.Yellow;
            }
            if (SoruNo == 21)
            {
                richTextBox1.Text = "Damara tıkanmaması için konan araç";
                buttonS.BackColor = Color.Yellow;
            }
            if (SoruNo == 22)
            {
                richTextBox1.Text = "Güzel, zarif, modaya uygun";
                buttonSH.BackColor = Color.Yellow;
            }
            if (SoruNo == 23)
            {
                richTextBox1.Text = "Novak Djokovic'in şampiyonlukları olduğu spor dalı";
                buttonT.BackColor = Color.Yellow;
            }
            if (SoruNo == 24)
            {
                richTextBox1.Text = "Bütün varlıkların içinde bulunduğu sonsuz boşluk, feza, mekân";
                buttonU.BackColor = Color.Yellow;
            }
            if (SoruNo == 25)
            {
                richTextBox1.Text = "Tanınmış, şöhretli, meşhur";
                buttonUH.BackColor = Color.Yellow;
            }
            if (SoruNo == 26)
            {
                richTextBox1.Text = "Sevgiyi sürdürme, sevgi, dostluk bağlılığı";
                buttonV.BackColor = Color.Yellow;
            }
            if (SoruNo == 27)
            {
                richTextBox1.Text = "Günlük kazanç";
                buttonY.BackColor = Color.Yellow;
            }
            if (SoruNo == 28)
            {
                richTextBox1.Text = "En yüksek nokta, tepe";
                buttonZ.BackColor = Color.Yellow;
            }
        }
    }
}
