using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinesi5
{
    public partial class Form1 : Form
    {  
        //işlemleri gerçekleştirmek için değişkenler (toplama,çıkarma,bölme,çapma)
        double x, y;
        string islem;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rakambtn(object sender, EventArgs e)
        {
            //tüm rakamalar için ortak bir olay  belirledim "rakambtn"  onlara basıldığında yapılacak olan işlemler için 

            if (textSonuc.Text == "0"  )//eğer textbox 0 ise rakamlara basıldığında temizlenmesi için gereken işlemler
                textSonuc.Clear();
            Button btn = (Button)sender;
            textSonuc.Text += btn.Text;// herhangi bir rakama basıldığında ekrana öncekilerler beraber yazmak için yeni basılan btn ekledim
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textSonuc.Text) > 0)
            {
                //burdada textbox silme işlemini tek tek yapmtım 
                textSonuc.Text = textSonuc.Text.Remove(textSonuc.Text.Length - 1, 1);
                //eğer 0 ise textbox ı sıfır yaptım
                if (textSonuc.Text.Length == 0)
                {
                    textSonuc.Text = "0";
                }
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            // x değişkenine textbox'taki değeri atadım ve oluşturmuş olduğum işlem değişkeni ile işlemi kontrol ettim label'yazdım 
            x = Convert.ToDouble(textSonuc.Text);
            islem = "+";
            lbsonuc.Text = textSonuc.Text + "+";
            //text' sıfırladım
            textSonuc.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            // yeni değerini y 'ye atadım ve işlem mi kontrol ettim toplma ise topladım x+y
            y = Convert.ToDouble(textSonuc.Text);
            if (islem == "+")
            {
                textSonuc.Text = Convert.ToString(x + y);
                //text' sıfırladım
                lbsonuc.Text = "";
            }
            // yeni değerini y 'ye atadım ve işlem mi kontrol ettim çıkarma ise çıkardım x-y
            if (islem == "-")
            {
                textSonuc.Text = Convert.ToString(x - y);
                //text' sıfırladım
                lbsonuc.Text = "";
            }
            // yeni değerini y 'ye atadım ve işlem mi kontrol ettim çarpma ise çarptım x*y
            if (islem == "*")
            {
                textSonuc.Text = Convert.ToString(x * y);
                //text' sıfırladım
                lbsonuc.Text = "";
            }
            // yeni değerini y 'ye atadım ve işlem mi kontrol ettim bölme işlemiyse böydüm
            if (islem == "/")
            {
                textSonuc.Text = Convert.ToString(x / y);
                //text' sıfırladım
                lbsonuc.Text = "";
            }
            // yeni değerini y 'ye atadım ve işlem mi kontrol ettim mod almaysa modunu aldım x'in y'ye modu
            if (islem == "mod")
            {
                textSonuc.Text = Convert.ToString(x % y);
                //text' sıfırladım
                lbsonuc.Text = "";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        { 
            // x değişkenine textbox'taki değeri atadım ve oluşturmuş olduğum işlem değişkeni ile işlemi kontrol ettim label'yazdımm
            x = Convert.ToDouble(textSonuc.Text);
            islem = "-";
            lbsonuc.Text = textSonuc.Text + "-";
            //text' sıfırladım
            textSonuc.Text = "";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            // x değişkenine textbox'taki değeri atadım ve oluşturmuş olduğum işlem değişkeni ile işlemi kontrol ettim label'yazdımm
            x = Convert.ToDouble(textSonuc.Text);
            islem = "*";
            lbsonuc.Text = textSonuc.Text + "*";
            //text' sıfırladım
            textSonuc.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // x değişkenine textbox'taki değeri atadım ve oluşturmuş olduğum işlem değişkeni ile işlemi kontrol ettim label'yazdımm
            x = Convert.ToDouble(textSonuc.Text);
            islem = "/";
            lbsonuc.Text = textSonuc.Text + "/";
            //text' sıfırladım
            textSonuc.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // kare alma işlemi için double adında bir değişken oluşturdum
            double kare = Convert.ToDouble(textSonuc.Text);
            kare = Math.Pow(kare, 2);//math.pow ile karesini aldım karesini x*x şeklinde dealınabilirdi ben bunu tercih ettim
            textSonuc.Text = Convert.ToString(kare);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // karekök alma işlemi için double adında bir değişken oluşturdum ve karekökö işlemini yaptım 
            double karekok = Convert.ToDouble(textSonuc.Text);
            karekok = Math.Sqrt(karekok);//x^(1/2) şeklinde de karekök alınabilir
            textSonuc.Text = Convert.ToString(karekok);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //1/x işleminde burda yaptım ve convert edip yazdırdım
            double kesirli = Convert.ToDouble(textSonuc.Text);
            kesirli = 1/(kesirli);
            textSonuc.Text = Convert.ToString(kesirli);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // x değişkenine textbox'taki değeri atadım ve oluşturmuş olduğum işlem değişkeni ile işlemi kontrol ettim label'yazdım 
            x = Convert.ToDouble(textSonuc.Text);
            islem = "mod";
            lbsonuc.Text = textSonuc.Text + "(mod)";
            textSonuc.Text = "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //burda de eğer kullanıcı +/- basrsa sayı pozitif ise negatif yaptım ,negatif ise pozitif yaptım

            int negatifi;
            negatifi = Convert.ToInt32(textSonuc.Text);
            if (negatifi > 0 || negatifi < 0)
            {
                negatifi = -1*negatifi;
            }
            textSonuc.Text = Convert.ToString(negatifi);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //burda da  double ifadeler için 
            if (textSonuc.Text == "0")
            {
                textSonuc.Text = "0";
            }
            
            else if(!textSonuc.Text.Contains("."))
            {
                textSonuc.Text += ",";
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //burdada texbox ve label temizledim
            textSonuc.Text = "0";
            lbsonuc.Text = "";
        }
    }
}
