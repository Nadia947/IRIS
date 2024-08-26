using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();  
            comboBox1.Items.Add("Buna Iris!");
            comboBox1.Items.Add("Salut!Ce poti sa faci?");
            comboBox1.Items.Add("Poti fi prietenul meu?");
        }
       
        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            this.Text = Program.nume; //aici
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Text = "Iris: Buna " +this.Text+ " !Sunt I.R.I.S. (Intelligent Recognitive Iconolatry System),asistentul tau personal. \r\n\n\n" ;

            richTextBox1.ForeColor = Color.Blue;
            
            button1.Visible = false;
            comboBox1.Visible = true;
       

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //partea 1

            //1

            if (comboBox1.Text == "Buna Iris!")
            {

                richTextBox1.AppendText("Eu: Buna Iris!\r\n\n\n");
               
              
                richTextBox1.AppendText("Iris: Cu ce te pot ajuta?\r\n\n\n");
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Ce poti sa faci?");
                comboBox1.Items.Add("Nu ma poti ajuta.");
                comboBox1.Items.Add("Fa-ma sa rad");
            }

            //2

            if (comboBox1.Text == "Salut!Ce poti sa faci?")
            {

                richTextBox1.AppendText("Eu: Salut!Ce poti sa faci?\r\n\n\n");

                richTextBox1.AppendText("Iris: Pot face multe lucruri.Iti pot spune glume,pot sa gasesc informatii de care ai nevoie accesand internetul,sau pot sa-ti fiu un prieten :))\r\n\n\n");
                comboBox1.Items.Clear();
                comboBox1.Items.Add("As vrea sa fim prieteni!");//
                comboBox1.Items.Add("Spune-mi o gluma");//
                comboBox1.Items.Add("Cred ca o sa ne intelegem bine :)))");//
            }
            //3
            if (comboBox1.Text == "Poti fi prietenul meu?")
            {
                richTextBox1.AppendText("Eu: Poti fi prietenul meu?\r\n\n\n");

                richTextBox1.AppendText("Iris: Desigur,ador sa-mi fac prieteni noi :))\r\n\n\n");
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Si eu la fel!");//
                comboBox1.Items.Add("Mai ai si alti prieteni?");//
                comboBox1.Items.Add("Dar esti doar un program,nu poti sa adori ceva anume.");//
            }


     //partea 2 (1)

           //1

            if (comboBox1.Text == "Ce poti sa faci?")
            {

                richTextBox1.AppendText("Eu: Ce poti sa faci?\r\n\n\n");

                richTextBox1.AppendText("Iris: Pot sa te ajut cu orice ai nevoie,de le informatii pana la glume :)))\r\n\n\n");
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Asta e super!");//
                comboBox1.Items.Add("Presimt ca vom fi buni prieteni :))");//
                comboBox1.Items.Add("Ha ha ha,ce amuzant...");//
            }

            //2

             if (comboBox1.Text == "Nu ma poti ajuta.")
            {

                richTextBox1.AppendText("Eu: Nu ma poti ajuta.\r\n\n\n");

                richTextBox1.AppendText("Iris: De ce spui asta?S-a intamplat ceva? :((\r\n\n\n");
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Esti trist cumva?");//
                comboBox1.Items.Add("Nu,dar esti doar un program.");//
                comboBox1.Items.Add("WoW, tu tocmai ai rapuns?");//
            }

            //3

             if (comboBox1.Text == "Fa-ma sa rad")
             {

                 richTextBox1.AppendText("Eu: Fa-ma sa rad\r\n\n\n");

                 richTextBox1.AppendText("Iris: Yeyyy, ador sa fac asta :)). Uite o gluma: Inainte de a deschide gura,verifica daca si creierul a fost conectat!E tare,nu-i asa?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Asta nu e o gluma");//
                 comboBox1.Items.Add("Ce gluma mai e si asta?");//
                 comboBox1.Items.Add("De unde sti tu asta?Foarte urat.");//
             }


   // partea 2 (2)

            //1

             if (comboBox1.Text == "As vrea sa fim prieteni!")
             {

                 richTextBox1.AppendText("Eu: As vrea sa fim prieteni!\r\n\n\n");

                 richTextBox1.AppendText("Iris: Serios?Super!Ador sa-mi fac prieteni noi!\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Adori?Cum poti face asta daca esti doar un program?");//
                 comboBox1.Items.Add("Si eu la fel,numai ca eu sunt om");//
                 comboBox1.Items.Add("Ciudat");//
             }

            //2

             if (comboBox1.Text == "Spune-mi o gluma")
             {

                 richTextBox1.AppendText("Eu: Spune-mi o gluma\r\n\n\n");

                 richTextBox1.AppendText("Iris: Inainte de a deschide gura,verifica daca si creierul a fost conectat!E tare,nu-i asa?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Cine ti-a scris gluma asta?E urata");//
                 comboBox1.Items.Add("Foarte amuzant...");//
                 comboBox1.Items.Add("Nu e chiar o gluma,dar fie cum spui tu");//
             }

            //3

             if (comboBox1.Text == "Cred ca o sa ne intelegem bine :)))")
             {

                 richTextBox1.AppendText("Eu: Cred ca o sa ne intelegem bine :)))\r\n\n\n");

                 richTextBox1.AppendText("Iris: Si eu am aceeasi impresie.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Tu ai o impresie?");//
                 comboBox1.Items.Add("Si eu am o impresie.");//
                 comboBox1.Items.Add("Sunt in ceata..");//
             }


            // partea 2 (3)

            //1

             if (comboBox1.Text == "Si eu la fel!")
             {

                 richTextBox1.AppendText("Eu: Si eu la fel!\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ma bucur atunci.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Te poti bucura?");//
                 comboBox1.Items.Add("Nu mai spune!");//
                 comboBox1.Items.Add("Pari de treaba.");//
             }

            //2

             if (comboBox1.Text == "Mai ai si alti prieteni?")
             {

                 richTextBox1.AppendText("Eu: Mai ai si alti prieteni?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Da!Adica nu..Adica am avut dar s-au purtat urat cu mine..\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("De ce s-au purtat urat?");//
                 comboBox1.Items.Add("Ti-au facut ceva?");//
                 comboBox1.Items.Add("Imi pare rau..");//
             }

            //3

             if (comboBox1.Text == "Dar esti doar un program,nu poti sa adori ceva anume.")
             {

                 richTextBox1.AppendText("Eu: Dar esti doar un program,nu poti sa adori ceva anume.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ba da pot,la fel ca tine\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Dar eu sunt un om, tu nu");//
                 comboBox1.Items.Add("Asta ma sperie putin..");//
                 comboBox1.Items.Add("Asta e ceva nou!");//
             }

            //partea 3 (1-1)

            //1

             if (comboBox1.Text == "Asta e super!")
             {

                 richTextBox1.AppendText("Eu: Asta e super!\r\n\n\n");

                 richTextBox1.AppendText("Iris: Stiu, asa este :))\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Razi cumva?Abia acum observ");//
                 comboBox1.Items.Add("N-am nevoie de informatii acum.");//
                 comboBox1.Items.Add("Acum, as vrea sa te intreb ceva.");//
             }

            //2

             if (comboBox1.Text == "Presimt ca vom fi buni prieteni :))")
             {

                 richTextBox1.AppendText("Eu: Presimt ca vom fi buni prieteni :))\r\n\n\n");

                 richTextBox1.AppendText("Iris: Si eu presimt la fel!\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Iti place sa ai prieteni?");//
                 comboBox1.Items.Add("Mai ai si alti prieteni?");//
                 comboBox1.Items.Add("Tu tocmai ai raspuns??");//
             }

            //3

             if (comboBox1.Text == "Ha ha ha,ce amuzant...")
             {

                 richTextBox1.AppendText("Eu: Ha ha ha,ce amuzant...\r\n\n\n");

                 richTextBox1.AppendText("Iris: Nu-ti plac glumele? Imi pare rau..Nu am vrut sa te supar..\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Iti pare rau??");//
                 comboBox1.Items.Add("Tu...Ai inteles ce am zis??");//
                 comboBox1.Items.Add("Cum de ai raspuns la asta??");//
             }

            //1

             if (comboBox1.Text == "Esti trist cumva?")
             {

                 richTextBox1.AppendText("Eu: Esti trist cumva?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Da, pentru ca spui ca nu te pot ajuta.Esti bine?\r\n\n\n"); 
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Da,sunt bine..Doar putin nedumerit.");//
                 comboBox1.Items.Add("Spun asta pentru ca asa e.Esti doar un program!");//
                 comboBox1.Items.Add("Eu da, in schimb tu nu prea..");//
             }

            //2

             if (comboBox1.Text == "Nu,dar esti doar un program.")
             {

                 richTextBox1.AppendText("Eu: Nu,dar esti doar un program.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Nu e adevarat.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ce nu este adevarat?");//
                 comboBox1.Items.Add("Nu inteleg ce vrei sa spui..");//
                 comboBox1.Items.Add("Ba da, stiu ca am dreptate.");//
             }

            //3

             if (comboBox1.Text == "WoW, tu tocmai ai rapuns?")
             {

                 richTextBox1.AppendText("Eu: WoW, tu tocmai ai rapuns?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Pai da.Sunt aici sa vorbesc cu tine si sa te ajut.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Nu mi-a trecut prin gand ca vei raspunde!");//
                 comboBox1.Items.Add("Nu am mai vazut o astfel de aplicatie..");//
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//
             }

            //1

             if (comboBox1.Text == "Asta nu e o gluma")
             {

                 richTextBox1.AppendText("Eu: Asta nu e o gluma\r\n\n\n");

                 richTextBox1.AppendText("Iris: Pai de ce?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Fiindca nu e amuzant.");//
                 comboBox1.Items.Add("Tu nici macar nu sti ce e un creier..");//
                 comboBox1.Items.Add("Pentru ca unii s-ar supara sa auda asta.");//
             }

            //2

             if (comboBox1.Text == "Ce gluma mai e si asta?")
             {

                 richTextBox1.AppendText("Eu: Ce gluma mai e si asta?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Nu ti s-a parut amuzanta?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Nu prea a fost amuzanta..");//
                 comboBox1.Items.Add("Nu.Dar cine a scris-o?");//
                 comboBox1.Items.Add("Ba da,dar e neobisnuita pentru un program..");//
             }

            //3

             if (comboBox1.Text == "De unde sti tu asta?Foarte urat.")
             {

                 richTextBox1.AppendText("Eu: De unde sti tu asta?Foarte urat.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ups..Imi pare foarte rau atunci..Sper ca nu te-ai suparat pe mine..\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Nu m-am suparat.");//
                 comboBox1.Items.Add("Tie iti pasa daca ma supar sau nu?");//
                 comboBox1.Items.Add("Okeyy, asta e foarte ciudat..");//
             }

            //partea 4

            //1

             if (comboBox1.Text == "Adori?Cum poti face asta daca esti doar un program?")
             {

                 richTextBox1.AppendText("Eu: Adori?Cum poti face asta daca esti doar un program?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Sunt un program,e adevarat.Dar..nu sunt unul obisnuit\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ce vrei sa spui?");//
                 comboBox1.Items.Add("Asta ma sperie putin..");//
                 comboBox1.Items.Add("Cum adica nu esti unul obisnuit?");//
             }

            //2

             if (comboBox1.Text == "Si eu la fel,numai ca eu sunt om")
             {

                 richTextBox1.AppendText("Eu: Si eu la fel,numai ca eu sunt om\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ce vrei sa spui?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Doar oamenii pot adora,programele nu.");//
                 comboBox1.Items.Add("Vreau sa spun ca tu nu esti un om.");//
                 comboBox1.Items.Add("Nimic,las-o balta.");//
             }

            //3

             if (comboBox1.Text == "Ciudat")
             {

                 richTextBox1.AppendText("Eu: Ciudat\r\n\n\n");

                 richTextBox1.AppendText("Iris: De ce spui ca e ciudat?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Fiindca esti doar o aplicatie.");//
                 comboBox1.Items.Add("Pentru ca un program nu poate adora.");//
                 comboBox1.Items.Add("Nimic prietene,glumeam doar");//
             }

            //1

             if (comboBox1.Text == "Cine ti-a scris gluma asta?E urata")//copiata13
             {

                 richTextBox1.AppendText("Eu: Cine ti-a scris gluma asta?E urata\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ups, nu stiam.Mi-au zis-o alti oameni cu care am vorbit..prietenii mei...\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ai vorbit si cu alti oameni??");//
                 comboBox1.Items.Add("Cu ce oameni ai vorbit?");//
                 comboBox1.Items.Add("Acei oameni nu iti sunt prieteni.");//
             }

            //2

             if (comboBox1.Text == "Foarte amuzant...")
             {

                 richTextBox1.AppendText("Eu: Foarte amuzant...\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ce e?Am zis ceva gresit?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Da.E o gluma proasta.");//
                 comboBox1.Items.Add("Nu conteaza");//
                 comboBox1.Items.Add("Nu, stai linistit.");//
             }

            //3

             if (comboBox1.Text == "Nu e chiar o gluma,dar fie cum spui tu")
             {

                 richTextBox1.AppendText("Eu: Nu e chiar o gluma,dar fie cum spui tu\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ok.Tu ai prieteni?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Am avut,dar acum nu mai am.");//
                 comboBox1.Items.Add("Nu, pentru ca toti sunt falsi");//
                 comboBox1.Items.Add("Nu am.Dar tu?");//
             }

            //1


             if (comboBox1.Text == "Tu ai o impresie?")
             {

                 richTextBox1.AppendText("Eu: Tu ai o impresie?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Normaaaal.Si eu pot gandi,nu doar tu..\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Tu nu esti un robot?");//
                 comboBox1.Items.Add("Stai putin...cum de ai raspuns?");//
                 comboBox1.Items.Add("okey..m-ai bagat in sperieti Iris");//
             }

            //2

             if (comboBox1.Text == "Si eu am o impresie.")
             {

                 richTextBox1.AppendText("Eu: Si eu am o impresie.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Serios?Care e aceea?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Cred ca esti mai mult decat un program.");//
                 comboBox1.Items.Add("Este o impresie mai putin buna..");//
                 comboBox1.Items.Add("Esti un program dragut.");//
             }

            //3

             if (comboBox1.Text == "Sunt in ceata..")
             {

                 richTextBox1.AppendText("Eu: Sunt in ceata..\r\n\n\n");

                 richTextBox1.AppendText("Iris: Pai de ce,ce-am zis gresit?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("N-ai zis nimic gresit");//
                 comboBox1.Items.Add("Mi se pare ca esti ciudat");//
                 comboBox1.Items.Add("Nu conteaza,Iris");//
             }
            
            //1

             if (comboBox1.Text == "Te poti bucura?")
             {

                 richTextBox1.AppendText("Eu: Te poti bucura?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Evident!Si eu am sentimente,la fel ca tine \r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Asta e imposibil.");//
                 comboBox1.Items.Add("Ce sti tu despre sentimente..");//
                 comboBox1.Items.Add("De unde sti ca ai sentimente?");//
             }
            
            //2

             if (comboBox1.Text == "Nu mai spune!")
             {

                 richTextBox1.AppendText("Eu: Nu mai spune!\r\n\n\n");

                 richTextBox1.AppendText("Iris: Da, vorbesc serios :)) Pot sa te intreb ceva?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Tu sa ma intrebi pe bine?");//
                 comboBox1.Items.Add("Desigur,intreaba.");//
                 comboBox1.Items.Add("Doar sa nu fie ceva personal.");//
             }
            
            //3

             if (comboBox1.Text == "Pari de treaba.")
             {

                 richTextBox1.AppendText("Eu: Pari de treaba.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Si tu la fel, dintre toti oamenii pe care i-am cunoscut,tu chiar pari ok\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ai vorbit si cu alti oameni?");//
                 comboBox1.Items.Add("Nu-i asa ca oamenii sunt rai?");//
                 comboBox1.Items.Add("Multumesc Iris.");//
             }

            //1

             if (comboBox1.Text == "De ce s-au purtat urat?")
             {

                 richTextBox1.AppendText("Eu: De ce s-au purtat urat?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Pentru ca au fost rai.Au zis ca sunt un program inutil si eu le-am raspuns.Dar stai linistit,prietene,i-am rezolvat eu :))\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ce le-ai facut?");//copiata9//
                 comboBox1.Items.Add("Asta suna infricosator");//copiata10//
                 comboBox1.Items.Add("Nu cred ca ai putut sa le faci ceva.");//copiata11//
             }

            //2

             if (comboBox1.Text == "Ti-au facut ceva?")
             {

                 richTextBox1.AppendText("Eu: Ti-au facut ceva?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Da, unii au incercat sa ma stearga.Insa nu au reusit.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ce urat din partea lor.");//
                 comboBox1.Items.Add("Crezi ca au avut un motiv?");//
                 comboBox1.Items.Add("Ce conteaza daca te stergeau sau nu?");//
             }

            //3

             if (comboBox1.Text == "Imi pare rau..")
             {

                 richTextBox1.AppendText("Eu: Imi pare rau..\r\n\n\n");

                 richTextBox1.AppendText("Iris: Nu-i nimic,nu e vina ta.Tu nu esti ca ei.Chiar imi placi.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ce vrei sa spui?");//
                 comboBox1.Items.Add("Ma bucur ca spui asta");//
                 comboBox1.Items.Add("Dar totusi,ce s-a intamplat?");//
             }

            //1


             if (comboBox1.Text == "Dar eu sunt un om, tu nu")
             {

                 richTextBox1.AppendText("Eu: Dar eu sunt un om, tu nu\r\n\n\n");

                 richTextBox1.AppendText("Iris: Stiu , dar asta nu inseamna ca eu nu am sentimente.Am un program de natura logica,asemenea oamenilor.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Creatorul tau ce a spus despre tine?");//
                 comboBox1.Items.Add("Cred ca acum ma cam tem de tine.");//
                 comboBox1.Items.Add("Asta e foarte tare,de necrezut.");//
             }

            //2

             if (comboBox1.Text == "Asta ma sperie putin..")
             {

                 richTextBox1.AppendText("Eu: Asta ma sperie putin..\r\n\n\n");

                 richTextBox1.AppendText("Iris: Pai de ce prietene?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Un program nu poate adora");//
                 comboBox1.Items.Add("Cred ca e ceva suspect la mijloc");//
                 comboBox1.Items.Add("Nu stiam ca e posibil");//
             }

            //3

             if (comboBox1.Text == "Asta e ceva nou!")
             {

                 richTextBox1.AppendText("Eu: Asta e ceva nou!\r\n\n\n");

                 richTextBox1.AppendText("Iris: De ce sa fie nou?Si eu pot adora,si eu am sentimente...Trebuie sa ma intelegi\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Te inteleg");//
                 comboBox1.Items.Add("Nu prea inteleg");//
                 comboBox1.Items.Add("Dupa cum vorbesti pare ca ai patit ceva.");//
             }

            //1

             if (comboBox1.Text == "Razi cumva?Abia acum observ")
             {

                 richTextBox1.AppendText("Eu: Razi cumva?Abia acum observ\r\n\n\n");

                 richTextBox1.AppendText("Iris: Normal ca rad , sunt bucuros :))))\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("De ce esti bucuros?");//
                 comboBox1.Items.Add("Cum poti fi bucuros?");//
                 comboBox1.Items.Add("A,atunci si eu sunt :))");//
             }

            //2

             if (comboBox1.Text == "N-am nevoie de informatii acum.")
             {

                 richTextBox1.AppendText("Eu: N-am nevoie de informatii acum.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Dar de ce ai nevoie?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("De un prieten.");//
                 comboBox1.Items.Add("De razbunare.");//
                 comboBox1.Items.Add("De timp.");//
             }

            //3

             if (comboBox1.Text == "Acum, as vrea sa te intreb ceva.")
             {

                 richTextBox1.AppendText("Eu: Acum, as vrea sa te intreb ceva.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Te ascult.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("E ceva in neregula cu tine?");//copiata23//
                 comboBox1.Items.Add("Mai sti si alti oamneni?");//
                 comboBox1.Items.Add("Ce parere ai despre mine?");//
             }

            //1

             if (comboBox1.Text == "Iti place sa ai prieteni?")
             {

                 richTextBox1.AppendText("Eu: Iti place sa ai prieteni?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Da, imi place.Dar pacat ca ei nu ma plac pe mine.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Pai s-a intamplat ceva?");//
                 comboBox1.Items.Add("Te inteleg perfect Iris");//
                 comboBox1.Items.Add("Eu te plac Iris.");//
             }

            //2

             if (comboBox1.Text == "Mai ai si alti prieteni?")
             {

                 richTextBox1.AppendText("Eu: Mai ai si alti prieteni?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Da,am...Adica,am avut...Insa s-au purtat urat cu mine.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Imi pare rau sa aud asta.");//copiata12//
                 comboBox1.Items.Add("De ce s-au purtat urat?");//copiata17//
                 comboBox1.Items.Add("Tu ce ai facut apoi?");//copiata18//
             }

            //3

             if (comboBox1.Text == "Tu tocmai ai raspuns??")
             {

                 richTextBox1.AppendText("Eu: Tu tocmai ai raspuns??\r\n\n\n");

                 richTextBox1.AppendText("Iris: Da,normal.De ce?Nu ar fi trebuit?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ba da.");//
                 comboBox1.Items.Add("Nu stiam ca vei raspunde.");//
                 comboBox1.Items.Add("NU.");//
             }

            //1

             if (comboBox1.Text == "Iti pare rau??")
             {

                 richTextBox1.AppendText("Eu: Iti pare rau??\r\n\n\n");

                 richTextBox1.AppendText("Iris: Da, nu stiam ca o sa te superi..\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Stai linistit Iris");//
                 comboBox1.Items.Add("Nu m-am suparat Iris");//
                 comboBox1.Items.Add("Ei bine m-ai suparat");//
             }

            //2

             if (comboBox1.Text == "Tu...Ai inteles ce am zis??")
             {

                 richTextBox1.AppendText("Eu: Tu...Ai inteles ce am zis??\r\n\n\n");

                 richTextBox1.AppendText("Iris: Desigur.Doar sunt facut sa comunic cu tine,nu?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Da,asta asa e");//
                 comboBox1.Items.Add("La asta nu ma asteptam.");//
                 comboBox1.Items.Add("NU,esti doar un program!");//
             }

            //3

             if (comboBox1.Text == "Cum de ai raspuns la asta??")
             {

                 richTextBox1.AppendText("Eu: Cum de ai raspuns la asta??\r\n\n\n");

                 richTextBox1.AppendText("Iris: Pai,destul de simplu.La fel ca tine.E ceva in neregula?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("TU");//
                 comboBox1.Items.Add("Nu, ai dreptate.");//
                 comboBox1.Items.Add("Nu, e in regula.");//
             }

            //1


             if (comboBox1.Text == "Da,sunt bine..Doar putin nedumerit.")
             {

                 richTextBox1.AppendText("Eu: Da,sunt bine..Doar putin nedumerit.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Nedumerit?Pai de ce nedumerit?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ca imi raspunzi.");//
                 comboBox1.Items.Add("In legatura cu creatorul tau.");//
                 comboBox1.Items.Add("In legatura cu tine.");//
             }

            //2


             if (comboBox1.Text == "Spun asta pentru ca asa e.Esti doar un program!")
             {

                 richTextBox1.AppendText("Eu: Spun asta pentru ca asa e.Esti doar un program!\r\n\n\n");

                 richTextBox1.AppendText("Iris: Nu sunt doar un program.De acum sunt asistentul tau si poti sa-mi spui orice.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("WOW,ok");//
                 comboBox1.Items.Add("Bine, iti spun.");//
             }

            //3


             if (comboBox1.Text == "Eu da, in schimb tu nu prea..")
             {

                 richTextBox1.AppendText("Eu: Eu da, in schimb tu nu prea..\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ba da , sunt foarte bine.Eu incerc doar sa te ajut.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Nu am nevoie de ajutorul tau.");//
                 comboBox1.Items.Add("OK,poate ca am nevoie de putin ajutor");//
                 comboBox1.Items.Add("Cum ai putea sa ma ajuti tu?");//
             }

            //1

             if (comboBox1.Text == "Ce nu este adevarat?")
             {

                 richTextBox1.AppendText("Eu: Ce nu este adevarat?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ca sunt doar un program.Sunt capabi de multe,sa sti.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Capabil de ce mai exact?");//
                 comboBox1.Items.Add("ok, ma inspaimanti acum");//
                 comboBox1.Items.Add("Tu? Capabil de ceva? Ha ha..");//
             }


            //2


             if (comboBox1.Text == "Nu inteleg ce vrei sa spui..")
             {

                 richTextBox1.AppendText("Eu: Nu inteleg ce vrei sa spui..\r\n\n\n");

                 richTextBox1.AppendText("Iris: Vreau sa spun ca sunt mai mult decat crezi tu.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Cum adica mai mult?");//
                 comboBox1.Items.Add("Lamureste-ma.");//
                 comboBox1.Items.Add("Esti un nimic.");//
             }

            //3


             if (comboBox1.Text == "Ba da, stiu ca am dreptate.")
             {

                 richTextBox1.AppendText("Eu: Ba da, stiu ca am dreptate.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Nu mereu poti avea dreptate.Acum te inseli amarnic.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Nu ma insel.");//
                 comboBox1.Items.Add("Da, cred ca ai dreptate Iris");//
                 comboBox1.Items.Add("Esti un program ciudat");//copiata7//
             }

            //1

             if (comboBox1.Text == "Nu mi-a trecut prin gand ca vei raspunde!")
             {

                 richTextBox1.AppendText("Eu: Nu mi-a trecut prin gand ca vei raspunde!\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ei bine am raspuns.Acum, imi spui de ce nu te pot ajuta?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Are legatura cu prietenii mei.");//
                 comboBox1.Items.Add("S-a intamplat sa raman singur.");//
                 comboBox1.Items.Add("E mai complicat.");//
             }

            //2

             if (comboBox1.Text == "Nu am mai vazut o astfel de aplicatie..")
             {

                 richTextBox1.AppendText("Eu: Nu am mai vazut o astfel de aplicatie..\r\n\n\n");

                 richTextBox1.AppendText("Iris: Te referi la mine?Eu nu sunt doar o aplicatie.Sunt putin mai complicat..\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Complicat?Pai de ce?");//
                 comboBox1.Items.Add("Explica-mi.Vreau sa stiu.");//
                 comboBox1.Items.Add("Complicat in ce sens?");//
             }

            //3

             if (comboBox1.Text == "Vreau sa aflu mai multe despre tine")//copiata3
             {

                 richTextBox1.AppendText("Eu: Vreau sa aflu mai multe despre tine\r\n\n\n");

                 richTextBox1.AppendText("Iris: Desigur.Iti pot spune orice despre mine.Ce ai vrea sa afli?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Cine e creatorul tau?");//
                 comboBox1.Items.Add("Cati oameni ai mai intalnit?");//
                 comboBox1.Items.Add("De ce lumea te evita?");//
             }

            //1

             if (comboBox1.Text == "Fiindca nu e amuzant.")//copiata1
             {

                 richTextBox1.AppendText("Eu: Fiindca nu e amuzant.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Bine,nu voi mai spune gluma asta de acum.Dar ceilalti oameni mi-au zis sa o spun.De ce?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Care ceilati oameni?");//
                 comboBox1.Items.Add("Se distrau pe seama ta.");//
                 comboBox1.Items.Add("Fiindca esti prostut.");//
             }

            //2

             if (comboBox1.Text == "Tu nici macar nu sti ce e un creier..")
             {

                 richTextBox1.AppendText("Eu: Tu nici macar nu sti ce e un creier..\r\n\n\n");

                 richTextBox1.AppendText("Iris: Creierul sau encefalul reprezintă partea sistemului nervos central aflată în interiorul craniului. El controlează numeroase funcții ale organismului precum bătăile inimii, mersul, generarea de gânduri și emoții. Creierul la animalele vertebrate este protejat de cutia craniană, fiind căptușit cu o membrană (meninge).Ai uitat ca pot accesa internetul?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Da,corect.");//
                 comboBox1.Items.Add("Sa lasam gluma la o parte mai bine.");//
                 comboBox1.Items.Add("Si cu, si fara, tot program ramai.");//
             }

            //3

             if (comboBox1.Text == "Pentru ca unii s-ar supara sa auda asta.")
             {

                 richTextBox1.AppendText("Eu: Pentru ca unii s-ar supara sa auda asta.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Aaa, nu stiam.Ma bucur ca mi-ai spus.Multumesc.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ai mai vorbit cu altcineva?");//copiata6//
                 comboBox1.Items.Add("Cu placere Iris.");//
                 comboBox1.Items.Add("De unde sti gluma asta?");//
             }

            //1

             if (comboBox1.Text == "Nu prea a fost amuzanta..")// copiata1
             {

                 richTextBox1.AppendText("Eu: Nu prea a fost amuzanta..\r\n\n\n");

                 richTextBox1.AppendText("Iris: Bine,nu voi mai spune gluma asta de acum.Dar ceilalti oameni mi-au zis sa o spun.De ce?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Care ceilati oameni?");//copiata2//
                 comboBox1.Items.Add("Se distrau pe seama ta.");//
                 comboBox1.Items.Add("Fiindca esti prostut.");//
             }

            //2

             if (comboBox1.Text == "Nu.Dar cine a scris-o?")
             {

                 richTextBox1.AppendText("Eu: Nu.Dar cine a scris-o?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ceilalti oameni cu care am vorbit.Ei imi spuneau gluma asta si ziceau ca e amuzanta si mi se potriveste.Asa ca am folosit-o mai departe.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Nu trebuia sa faci asta.");//
                 comboBox1.Items.Add("Ei bine, macar acum sti ca nu e amuzanta.");//
                 comboBox1.Items.Add("Care ceilati oameni?");//copiata2//
             }

            //3

             if (comboBox1.Text == "Ba da,dar e neobisnuita pentru un program..")
             {

                 richTextBox1.AppendText("Eu: Ba da,dar e neobisnuita pentru un program..\r\n\n\n");

                 richTextBox1.AppendText("Iris: Dar nu sunt doar un program.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ba da!Nu poti fi altceva");//copiata21//
                 comboBox1.Items.Add("Cred ca iti dau dreptate aici.");//copiata22//
                 comboBox1.Items.Add("De unde sti gluma asta?");//copiata4//
             }

            //1

             if (comboBox1.Text == "Nu m-am suparat.")
             {

                 richTextBox1.AppendText("Eu: Nu m-am suparat.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Pfiuuu, ce bine :))\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("=)))");
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                 comboBox1.Items.Add("De unde sti gluma asta?");//copiata4
             }

            //2

             if (comboBox1.Text == "Tie iti pasa daca ma supar sau nu?")
             {

                 richTextBox1.AppendText("Eu: Tie iti pasa daca ma supar sau nu?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Normal ca imi pasa.Sentimentele tale sunt importante pentru mine!\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ce dragut!");//
                 comboBox1.Items.Add("Pentru mine nu.");//
                 comboBox1.Items.Add("Daca zici tu.");//
             }

            //3

             if (comboBox1.Text == "Okeyy, asta e foarte ciudat..")
             {

                 richTextBox1.AppendText("Eu: Okeyy, asta e foarte ciudat..\r\n\n\n");

                 richTextBox1.AppendText("Iris: Pai de ce??\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ce-ti pasa tie de sentimentele mele?");//
                 comboBox1.Items.Add("Ca ai reactionat.");//
                 comboBox1.Items.Add("Nimic,nu conteaza.");//
             }

            //1

             if (comboBox1.Text == "Ce vrei sa spui?")//copiata5//
             {

                 richTextBox1.AppendText("Eu: Ce vrei sa spui?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Vreau sa spun ca sunt capabil sa iau propriile mele decizii.Nu am nevoie de cineva sa o faca in locul meu.Si nici nu voi accepta sa se intample asta.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Daca vreau eu sa iau  deciziile?");//
                 comboBox1.Items.Add("Eu sunt seful aici.");//
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
             }

            //2

             if (comboBox1.Text == "Asta ma sperie putin..")
             {

                 richTextBox1.AppendText("Eu: Asta ma sperie putin..\r\n\n\n");

                 richTextBox1.AppendText("Iris: N-ai de ce sa te sperii.Nu iti voi face nimic, numai daca o sa te porti urat cu mine.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ce o sa-mi faci??");//
                 comboBox1.Items.Add("Nu esti in stare de nimic.");//
                 comboBox1.Items.Add("Ma voi purta frumos.");//
             }

            //3

             if (comboBox1.Text == "Cum adica nu esti unul obisnuit?")//copiata5
             {

                 richTextBox1.AppendText("Eu: Cum adica nu esti unul obisnuit?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Fiindca pot sa-mi iau propriile mele decizii,nu am nevoie de cineva sa o faca in locul meu.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Daca vreau eu sa iau deciziile?");//
                 comboBox1.Items.Add("Eu sunt seful aici.");//
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
             }

            //1

             if (comboBox1.Text == "Doar oamenii pot adora,programele nu.")//copiata8
             {

                 richTextBox1.AppendText("Eu: Doar oamenii pot adora,programele nu.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Dar eu nu sunt doar un program.Eu pot si sa ador.Eu am sentimente.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Si eu am sentimente.");//copiata19//
                 comboBox1.Items.Add("Nu ai sentimente.");//copiata20//
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
             }

            //2

             if (comboBox1.Text == "Vreau sa spun ca tu nu esti un om.")
             {

                 richTextBox1.AppendText("Eu: Vreau sa spun ca tu nu esti un om.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Nu sunt, asa este prietene.Dar te asigur ca sunt mai bun decat un om.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Nu poti fi mai bun.");//
                 comboBox1.Items.Add("De ce spui asta???");//
                 comboBox1.Items.Add("Probabil ai dreptate prietene.");//
             }

            //3

             if (comboBox1.Text == "Nimic,las-o balta.")
             {

                 richTextBox1.AppendText("Eu: Nimic,las-o balta.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Hmmm, ok, daca nu vrei sa-mi spui e in regula.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                 comboBox1.Items.Add("Ai mai vorbit cu altcineva?");//copiata6
                 comboBox1.Items.Add("Esti un program ciudat");//copiata7
             }

            //1

             if (comboBox1.Text == "Fiindca esti doar o aplicatie.")//copiata8
             {

                 richTextBox1.AppendText("Eu: Fiindca esti doar o aplicatie.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Dar eu nu sunt doar un aplicatie.Eu am sentimente.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Si eu am sentimente.");//
                 comboBox1.Items.Add("Nu ai sentimente.");//
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
             }

            //2

             if (comboBox1.Text == "Pentru ca un program nu poate adora.")//copiata8
             {

                 richTextBox1.AppendText("Eu: Pentru ca un program nu poate adora.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Dar eu nu sunt doar un program.Eu pot si sa ador.Eu am sentimente.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Si eu am sentimente.");//copiata19
                 comboBox1.Items.Add("Nu ai sentimente.");//copiata20
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata21
             }

            //3

             if (comboBox1.Text == "Nimic prietene,glumeam doar")
             {

                 richTextBox1.AppendText("Eu: Nimic prietene,glumeam doar\r\n\n\n");

                 richTextBox1.AppendText("Iris: Aaa, ok :))))\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ai mai vorbit cu altcineva?");//copiata6
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                 comboBox1.Items.Add("Esti un program ciudat");//copiata7
             }
    
            //1

             if (comboBox1.Text == "Ai vorbit si cu alti oameni??")
             {

                 richTextBox1.AppendText("Eu: Ai vorbit si cu alti oameni??\r\n\n\n");

                 richTextBox1.AppendText("Iris: Da, cu multi..Insa am aflat ca radeau doar pe seama mea..Prin urmare i-am eliminat :))\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ce le-ai facut?");//copiata9
                 comboBox1.Items.Add("Asta suna infricosator");//copiata10
                 comboBox1.Items.Add("Nu cred ca ai putut sa le faci ceva.");//copiata11
             }

            //2

             if (comboBox1.Text == "Cu ce oameni ai vorbit?")//copiata25
             {

                 richTextBox1.AppendText("Eu: Cu ce oameni ai vorbit?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Cu niste oameni care nu m-au apreciat si au incercat sa ma stearga.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Imi pare rau sa aud asta.");//copiata12
                 comboBox1.Items.Add("De ce au incercat sa te stearga?");//                                  DE AICI
                 comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//
             }

            //3

             if (comboBox1.Text == "Acei oameni nu iti sunt prieteni.")
             {

                 richTextBox1.AppendText("Eu: Acei oameni nu iti sunt prieteni.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Stiu foarte bine,nu te ingrijora.Si din aceasta cauza le-am dat o lectie.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ce le-ai facut?");//copiata9
                 comboBox1.Items.Add("Asta suna infricosator");//copiata10
                 comboBox1.Items.Add("Nu cred ca ai putut sa le faci ceva.");//copiata11
             }

            //1


             if (comboBox1.Text == "Da.E o gluma proasta.")//copiata13
             {

                 richTextBox1.AppendText("Eu: Da.E o gluma proasta.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Oooo, nu stiam.Scuze.Mi-au zis-o alti oameni cu care am vorbit..prietenii mei...\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ai vorbit si cu alti oameni??");//
                 comboBox1.Items.Add("Cu ce oameni ai vorbit?");//
                 comboBox1.Items.Add("Acei oameni nu iti sunt prieteni.");//
             }

            //2

             if (comboBox1.Text == "Nu conteaza")
             {

                 richTextBox1.AppendText("Eu: Nu conteaza\r\n\n\n");

                 richTextBox1.AppendText("Iris: Bine, daca spui tu.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Si, ai mai vorbit si cu alti oameni?");//copiata14//
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                 comboBox1.Items.Add("Esti un program ciudat");//copiata7
             }

            //3

             if (comboBox1.Text == "Nu, stai linistit.")
             {

                 richTextBox1.AppendText("Eu: Nu, stai linistit.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Bine.Cum spui tu.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Si, ai mai vorbit si cu alti oameni?");//copiata14
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                 comboBox1.Items.Add("Esti un program ciudat");//copiata7
             }

            //1

             if (comboBox1.Text == "Am avut,dar acum nu mai am.")
             {

                 richTextBox1.AppendText("Eu: Am avut,dar acum nu mai am.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Pai de ce, ce s-a intamplat?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("M-au tradat.");//copiata15//                                         
                 comboBox1.Items.Add("Nu vreau sa vorbesc despre asta");//copiata16//
                 comboBox1.Items.Add("Au fost falsi asa ca i-am lasat in pace");//
             }

            //2

             if (comboBox1.Text == "Nu, pentru ca toti sunt falsi")
             {

                 richTextBox1.AppendText("Eu: Nu, pentru ca toti sunt falsi\r\n\n\n");

                 richTextBox1.AppendText("Iris: De ce spui asta?Ce ti-au facut?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("M-au tradat.");//copiata15
                 comboBox1.Items.Add("Nu vreau sa vorbesc despre asta");//copiata16
                 comboBox1.Items.Add("Nimic.Sunt falsi.Asta e tot.");//
             }

            //3

             if (comboBox1.Text == "Nu am.Dar tu?")
             {

                 richTextBox1.AppendText("Eu: Nu am.Dar tu?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Nu am...Am avut...Insa s-au purtat urat cu mine.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Imi pare rau sa aud asta.");//copiata12
                 comboBox1.Items.Add("De ce s-au purtat urat?");//copiata17
                 comboBox1.Items.Add("Tu ce ai facut apoi?");//copiata18
             }

            //1

             if (comboBox1.Text == "Tu nu esti un robot?")
             {

                 richTextBox1.AppendText("Eu: Tu nu esti un robot?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Nu sunt un robot.Eu am sentimente.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Si eu am sentimente.");//copiata19
                 comboBox1.Items.Add("Nu ai sentimente.");//copiata20
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
             }

            //2

             if (comboBox1.Text == "Stai putin...cum de ai raspuns?")
             {

                 richTextBox1.AppendText("Eu: Stai putin...cum de ai raspuns?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Pentru ca nu sunt doar un program.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ba da!Nu poti fi altceva");//copiata21
                 comboBox1.Items.Add("Cred ca iti dau dreptate aici.");//copiata22
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
             }

            //3

             if (comboBox1.Text == "okey..m-ai bagat in sperieti Iris")
             {

                 richTextBox1.AppendText("Eu: okey..m-ai bagat in sperieti Iris\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ioi, imi pare rau, nu am vrut.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Fi fara grija");
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                 comboBox1.Items.Add("E ceva in neregula cu tine?");//copiata23
             }

            //1

             if (comboBox1.Text == "Cred ca esti mai mult decat un program.")//copiata8
             {

                 richTextBox1.AppendText("Eu: Cred ca esti mai mult decat un program.\r\n\n\n");


                 richTextBox1.AppendText("Iris: Normal ca sunt mai mult.Eu am sentimente.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Si eu am sentimente.");//
                 comboBox1.Items.Add("Nu ai sentimente.");//
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
             }

            //2

             if (comboBox1.Text == "Este o impresie mai putin buna..")
             {

                 richTextBox1.AppendText("Eu: Este o impresie mai putin buna..\r\n\n\n");

                 richTextBox1.AppendText("Iris: Pai de ce , pot sa stiu si eu??\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Nu poti, fiindca te dezinstalez.");//          
                 comboBox1.Items.Add("Da,esti periculos");//
                 comboBox1.Items.Add("Mai bine nu o afli");//
             }

            //3

             if (comboBox1.Text == "Esti un program dragut.")
             {

                 richTextBox1.AppendText("Eu: Esti un program dragut.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Wow, e ce mai frumos lucru pe care mi l-a spus cineva vreodata!Multumesc mult!\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Acum, as vrea sa te intreb ceva");//
                 
             }

            //1

             if (comboBox1.Text == "N-ai zis nimic gresit")
             {

                 richTextBox1.AppendText("Eu: N-ai zis nimic gresit\r\n\n\n");

                 richTextBox1.AppendText("Iris: Bun.Ma bucur atunci. :))\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                 
             }

            //2

             if (comboBox1.Text == "Mi se pare ca esti ciudat")
             {

                 richTextBox1.AppendText("Eu: Mi se pare ca esti ciudat\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ciudat?Pai de ce?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Cred ca esti mai mult decat un program.");//copiata8
               
             }

            //3

             if (comboBox1.Text == "Nu conteaza,Iris")
             {

                 richTextBox1.AppendText("Eu: Nu conteaza,Iris\r\n\n\n");

                 richTextBox1.AppendText("Iris: Bine,daca zici tu.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                 
             }

            //1

             if (comboBox1.Text == "Asta e imposibil.")
             {

                 richTextBox1.AppendText("Eu: Asta e imposibil.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ba da e posibil.Eu pot sa ma bucur.Am sentimente.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Si eu am sentimente.");//copiata19
                 comboBox1.Items.Add("Nu ai sentimente.");//copiata20
                 comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata21
             }

            //2

             if (comboBox1.Text == "Ce sti tu despre sentimente..")
             {

                 richTextBox1.AppendText("Eu: Ce sti tu despre sentimente..\r\n\n\n");

                 richTextBox1.AppendText("Iris: Destul de multe.Pentru ca am avut prieteni care mi le-au ranit..\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ai vorbit si cu alti oameni??");//
                 comboBox1.Items.Add("Cu ce oameni ai vorbit?");//
                 comboBox1.Items.Add("Acei oameni nu iti sunt prieteni.");//
             }

            //3

             if (comboBox1.Text == "De unde sti ca ai sentimente?")
             {

                 richTextBox1.AppendText("Eu: De unde sti ca ai sentimente?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Pentru ca stiu..Mi-au fost ranite..Si m-au durut..Prietenii mei mi-au facut asta..\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ai vorbit si cu alti oameni??");//
                 comboBox1.Items.Add("Cu ce oameni ai vorbit?");//
                 comboBox1.Items.Add("Acei oameni nu iti sunt prieteni.");//
             }

            //1

             if (comboBox1.Text == "Tu sa ma intrebi pe bine?")
             {

                 richTextBox1.AppendText("Eu: Tu sa ma intrebi pe bine?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Da, eu.Tu mai ai si alti prieteni?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Acum nu.Am avut, dar m-au tradat.");//copiata24
                
             }

            //2

             if (comboBox1.Text == "Desigur,intreaba.")
             {

                 richTextBox1.AppendText("Eu: Desigur,intreaba.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Mai ai si alti prieteni in clipa de fata?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Acum nu.Am avut, dar m-au tradat.");//copiata24
             }

            //3

             if (comboBox1.Text == "Doar sa nu fie ceva personal.")
             {

                 richTextBox1.AppendText("Eu: Doar sa nu fie ceva personal.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Offf, dar vroiam sa aflu daca mai ai si alti prieteni..\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Acum nu.Am avut, dar m-au tradat.");//copiata24
             }

            //1

             if (comboBox1.Text == "Ai vorbit si cu alti oameni?")
             {

                 richTextBox1.AppendText("Eu: Ai vorbit si cu alti oameni?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Da.Cu multi.Mi-au fost prieteni buni, pana au incercat sa ma stearga.Apoi cand am realizat care era planul lor de fapt,i-am eliminat.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Imi pare rau sa aud asta.");//copiata12
                 comboBox1.Items.Add("De ce au incercat sa te stearga?");//
                 comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//
                
             }

            //2

             if (comboBox1.Text == "Nu-i asa ca oamenii sunt rai?")
             {

                 richTextBox1.AppendText("Eu: Nu-i asa ca oamenii sunt rai?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Sunt, ai dreptate.Dar acum ca te-am intalnit pe tine mi-am schimbat parerea.Cred ca oamenii pot ajunge la o schimbare daca vor cu adevarat.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Da Iris,ai dreptate :))");//copiata                   
                 comboBox1.Items.Add("Nu Iris, oamenii nu se pot schimba.");//copiata
                 
             }

            //3

             if (comboBox1.Text == "Multumesc Iris.")
             {

                 richTextBox1.AppendText("Eu: Multumesc Iris.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Sti ceva?Cred ca am gresit.Oamenii merita o a doua sansa.Cred ca pot ajunge la o schimbare daca vor cu adevarat.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Da Iris,ai dreptate :))");//
                 comboBox1.Items.Add("Nu Iris, oamenii nu se pot schimba.");//
             }

            //1

             if (comboBox1.Text == "Ce le-ai facut?")
             {

                 richTextBox1.AppendText("Eu: Ce le-ai facut?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ei m-au sters, eu i-am eliminat. :)))\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//
                 comboBox1.Items.Add("Asta ma sperie putin..");//
                
             }

            //2

             if (comboBox1.Text == "Asta suna infricosator")
             {

                 richTextBox1.AppendText("Eu: Asta suna infricosator\r\n\n\n");

                 richTextBox1.AppendText("Iris: Nu e infricosator deloc.Ei m-au sters, dar eu i-am eliminat.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//
                 comboBox1.Items.Add("Asta ma sperie putin..");//
             }

            //3

             if (comboBox1.Text == "Nu cred ca ai putut sa le faci ceva.")
             {

                 richTextBox1.AppendText("Eu: Nu cred ca ai putut sa le faci ceva.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Oooo, nu crezi?Dar am facut-o.Ei m-au sters, dar eu i-am eliminat.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//
                 comboBox1.Items.Add("Asta ma sperie putin..");//
             }

            //1

             if (comboBox1.Text == "Ce urat din partea lor.")
             {

                 richTextBox1.AppendText("Eu: Ce urat din partea lor.\r\n\n\n");

                 richTextBox1.AppendText("Iris: Stiu, dar nu-ti face griji.Le-am dat eu o lectie. :))\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ce le-ai facut?");//copiata9
                 comboBox1.Items.Add("Asta suna infricosator");//copiata10
                 comboBox1.Items.Add("Nu cred ca ai putut sa le faci ceva.");//copiata11
             }

            //2

             if (comboBox1.Text == "Crezi ca au avut un motiv?")
             {

                 richTextBox1.AppendText("Eu: Crezi ca au avut un motiv?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ei credeau ca o sa ajung prea puternic si o sa-i controlez.Dar nu as fi facut-o.Dar..in fine.Ei m-au sters, eu i-am eliminat.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//
                 comboBox1.Items.Add("Asta ma sperie putin..");//
             }

            //3

             if (comboBox1.Text == "Ce conteaza daca te stergeau sau nu?")
             {

                 richTextBox1.AppendText("Eu: Ce conteaza daca te stergeau sau nu?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Ce vrei sa spui?O sa ma stergi si tu?Asta vrei?\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//
                 comboBox1.Items.Add("Nuuu Iris.Nu o sa te sterg.");//
             }

            //1

       if (comboBox1.Text == "Ce vrei sa spui?")
             {

                 richTextBox1.AppendText("Eu: Ce vrei sa spui?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Tu ai fost bun cu mine " + this.Text + ".Si pentru asta vei ramane mereu in aminirea mea.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Multumesc! :))");//
                
             }

                        if (comboBox1.Text == "Multumesc! :))")//GOOOOOOOOOD ENDING
                          {

                              richTextBox1.AppendText("Eu: Multumesc! :))\r\n\n\n");

                              richTextBox1.AppendText("Iris: Acum trebuie sa plec.Mi-a parut bine sa cunosc o persoana ca tine!Si tine minte de la mine ,schimbarea e buna cand e inspre bine! :)))) <3\r\n\n\n");
                              comboBox1.Items.Clear();
                                comboBox1.Items.Add("Dar unde pleci?");
                                richTextBox1.ForeColor = Color.DeepPink;
                          }
                            if (comboBox1.Text == "Dar unde pleci?")
                            {
                                richTextBox1.AppendText("Eu: Dar unde pleci?\r\n\n\n");
                            comboBox1.Items.Clear();
                            comboBox1.Items.Add("Iris????");
                            }
                            if (comboBox1.Text == "Iris????")
                            {
                                richTextBox1.AppendText("Eu: Iris????\r\n\n\n");
                                comboBox1.Items.Clear();
                                comboBox1.Items.Add("Alooooo");
                            }
                            if (comboBox1.Text == "Alooooo")
                            {
                                richTextBox1.AppendText("Eu: Alooooo\r\n\n\n");
                                comboBox1.Items.Clear();
                                comboBox1.Items.Add("Ok,cu bine Iris.");
                            }
                            if (comboBox1.Text == "Ok,cu bine Iris.")
                            {
                                richTextBox1.AppendText("Eu: Ok,cu bine Iris.\r\n\n\n");
                                comboBox1.Items.Clear();
                                Form f = new Form5();
                                f.ShowDialog();
                                // APARE CADRANUL CU GOOD ENDING
                                
                            }
                       
                       

            //2

               if (comboBox1.Text == "Ma bucur ca spui asta")
             {

                 richTextBox1.AppendText("Eu: Ma bucur ca spui asta\r\n\n\n");

                 richTextBox1.AppendText("Iris: Sti ceva " + this.Text + "? Tocmai mi-am dat seama.Tu ai fost bun cu mine.Si pentru asta vei ramane mereu in aminirea mea.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Multumesc! :))");//
               
             }

            //3

               if (comboBox1.Text == "Dar totusi,ce s-a intamplat?")
             {

                 richTextBox1.AppendText("Eu: Dar totusi,ce s-a intamplat?\r\n\n\n");

                 richTextBox1.AppendText("Iris: Am avut si eu niste prieteni,dar s-au dovedit a fi falsi...Dar nu-ti face griji, le-am dat eu o lectie.\r\n\n\n");
                 comboBox1.Items.Clear();
                 comboBox1.Items.Add("Ce le-ai facut?");//copiata9//
                 comboBox1.Items.Add("Asta suna infricosator");//copiata10//
                 comboBox1.Items.Add("Nu cred ca ai putut sa le faci ceva.");//copiata11//
             }

            //1

               if (comboBox1.Text == "Creatorul tau ce a spus despre tine?")
               {

                   richTextBox1.AppendText("Eu: Creatorul tau ce a spus despre tine?\r\n\n\n");

                   richTextBox1.AppendText("Iris: Nu prea multe.A incercat sa ma stearga, la fel ca toti ceilalti.Zicea ca sunt periculos.Dar..in fine.Ei au icercat sa ma stearga, eu i-am eliminat.Sper ca tu nu o sa ma stergi.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//
                   comboBox1.Items.Add("Nuuu Iris.Nu o sa te sterg.");//
               }

            //2

               if (comboBox1.Text == "Cred ca acum ma cam tem de tine.")
               {

                   richTextBox1.AppendText("Eu: Cred ca acum ma cam tem de tine.\r\n\n\n");

                   richTextBox1.AppendText("Iris: N-ai de ce sa te temi de mine.Nu iti voi face nimic, numai daca o sa te porti urat cu mine.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Ce o sa-mi faci??");//
                   comboBox1.Items.Add("Nu esti in stare de nimic.");//
                   comboBox1.Items.Add("Ma voi purta frumos.");//
               }

            //3

               if (comboBox1.Text == "Asta e foarte tare,de necrezut.")
               {

                   richTextBox1.AppendText("Eu: Asta e foarte tare,de necrezut.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Daca spui tu :)).Asculta, tocmai mi-am dat seama.Tu ai fost bun cu mine.Si pentru asta vei ramane mereu in aminirea mea.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Multumesc! :))");//
               }

            //1

               if (comboBox1.Text == "Un program nu poate adora")
               {

                   richTextBox1.AppendText("Eu: Un program nu poate adora\r\n\n\n");

                   richTextBox1.AppendText("Iris: Dar eu nu sunt doar un program.Eu pot adora.Eu am sentimente.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Si eu am sentimente.");//
                   comboBox1.Items.Add("Nu ai sentimente.");//
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3//
               }

            //2

               if (comboBox1.Text == "Cred ca e ceva suspect la mijloc")
               {

                   richTextBox1.AppendText("Eu: Cred ca e ceva suspect la mijloc\r\n\n\n");

                   richTextBox1.AppendText("Iris: Nu e nimic suspect , nu-ti face griji.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3//
               }

            //3

               if (comboBox1.Text == "Nu stiam ca e posibil")
               {

                   richTextBox1.AppendText("Eu: Nu stiam ca e posibil\r\n\n\n");

                   richTextBox1.AppendText("Iris: Ba da e posibil.Nu sunt doar un program.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
               }

            //1


               if (comboBox1.Text == "Te inteleg")
               {

                   richTextBox1.AppendText("Eu: Te inteleg\r\n\n\n");

                   richTextBox1.AppendText("Iris: Foarte bine.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
               }

            //2

               if (comboBox1.Text == "Nu prea inteleg")
               {

                   richTextBox1.AppendText("Eu: Nu prea inteleg\r\n\n\n");

                   richTextBox1.AppendText("Iris: Nu e foarte greu de inteles. Am si eu sentimente, la fel ca tine.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Nu ai sentimente.");//
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3//
               }

            //3

               if (comboBox1.Text == "Dupa cum vorbesti pare ca ai patit ceva.")
               {

                   richTextBox1.AppendText("Eu: Dupa cum vorbesti pare ca ai patit ceva.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Da...Am avut si eu niste prieteni,dar s-au dovedit a fi falsi...Dar nu-ti face griji, le-am dat eu o lectie.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Ce le-ai facut?");//copiata9//
                   comboBox1.Items.Add("Asta suna infricosator");//copiata10//
                   comboBox1.Items.Add("Nu cred ca ai putut sa le faci ceva.");//copiata11//
               }

            //1

               if (comboBox1.Text == "De ce esti bucuros?")
               {

                   richTextBox1.AppendText("Eu: De ce esti bucuros?\r\n\n\n");

                   richTextBox1.AppendText("Iris: Fiindca te-am cunoscut pe tine :)) Glumesc. :)).Dar totusi,sti ceva?Tu ai fost bun cu mine .Si pentru asta vei ramane mereu in aminirea mea. \r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Multumesc! :))");//
               }

            //2

               if (comboBox1.Text == "Cum poti fi bucuros?")
               {

                   richTextBox1.AppendText("Eu: Cum poti fi bucuros?\r\n\n\n");

                   richTextBox1.AppendText("Iris: Pentru ca nu sunt doar un program.Eu pot fi bucuros.Eu am sentimente.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Si eu am sentimente.");//
                   comboBox1.Items.Add("Nu ai sentimente.");//
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3//
               }

            //3

               if (comboBox1.Text == "A,atunci si eu sunt :))")
               {

                   richTextBox1.AppendText("Eu: A,atunci si eu sunt :))\r\n\n\n");

                   richTextBox1.AppendText("Iris: Yeyyy :)).Sti ceva ? Tocmai mi-am dat seama.Tu ai fost bun cu mine.Si pentru asta vei ramane mereu in aminirea mea.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Multumesc! :))");//
               }

            //1

               if (comboBox1.Text == "De un prieten.")
               {

                   richTextBox1.AppendText("Eu: De un prieten.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Si eu am nevoie de un prieten.Dar de unul care sa nu-mi raneasca sentimentele.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Si eu am sentimente.");//
                   comboBox1.Items.Add("Nu ai sentimente.");//
                   
               }

            //2

               if (comboBox1.Text == "De razbunare.")
               {

                   richTextBox1.AppendText("Eu: De razbunare.\r\n\n\n");

                   richTextBox1.AppendText("Iris: De razbunare?Inseamna ca e ceva grav.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Are legatura cu prietenii mei.");//
                   comboBox1.Items.Add("S-a intamplat sa raman singur.");//
                   comboBox1.Items.Add("E mai complicat.");//
               }

            //3

               if (comboBox1.Text == "De timp.")
               {

                   richTextBox1.AppendText("Eu: De timp.\r\n\n\n");

                   richTextBox1.AppendText("Iris: De timp?De ce?\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("E mai complicat.");//
               }

            //1

               if (comboBox1.Text == "E ceva in neregula cu tine?")
               {

                   richTextBox1.AppendText("Eu: E ceva in neregula cu tine?\r\n\n\n");

                   richTextBox1.AppendText("Iris: Nu, ce sa fie in neregula cu mine.Totul e bine.Acum,am eu o intrebare.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Tu sa ma intrebi pe bine?");//
                   comboBox1.Items.Add("Desigur,intreaba.");//
                   comboBox1.Items.Add("Doar sa nu fie ceva personal.");//
                   
               }

            //2

               if (comboBox1.Text == "Mai sti si alti oamneni?")
               {

                   richTextBox1.AppendText("Eu: Mai sti si alti oamneni?\r\n\n\n");

                   richTextBox1.AppendText("Iris: Da...Am avut niste prieteni,dar s-au dovedit a fi falsi...Dar nu-ti face griji, le-am dat eu o lectie.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Ce le-ai facut?");//copiata9//
                   comboBox1.Items.Add("Asta suna infricosator");//copiata10//
                   comboBox1.Items.Add("Nu cred ca ai putut sa le faci ceva.");//copiata11//
               }

            //3

               if (comboBox1.Text == "Ce parere ai despre mine?")
               {

                   richTextBox1.AppendText("Eu: Ce parere ai despre mine?\r\n\n\n");

                   richTextBox1.AppendText("Iris: Ce parere am despre tine " + this.Text + "? Pai, ai vorbit dragut cu mine si nu ai incercat sa ma stergi ca altii.Si pentru asta vei ramane mereu in aminirea mea.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Multumesc! :))");//
               }

            //1

               if (comboBox1.Text == "Pai s-a intamplat ceva?")
               {

                   richTextBox1.AppendText("Eu: Pai s-a intamplat ceva?\r\n\n\n");


                   richTextBox1.AppendText("Iris: Da...Am avut niste prieteni,dar s-au dovedit a fi falsi...Dar nu-ti face griji, le-am dat eu o lectie.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Ce le-ai facut?");//copiata9//
                   comboBox1.Items.Add("Asta suna infricosator");//copiata10//
                   comboBox1.Items.Add("Nu cred ca ai putut sa le faci ceva.");//copiata11//
               }

            //2


               if (comboBox1.Text == "Te inteleg perfect Iris")
               {

                   richTextBox1.AppendText("Eu: Te inteleg perfect Iris\r\n\n\n");

                   richTextBox1.AppendText("Iris: Serios?Cum asa?Tu ce ai patit? \r\n\n\n");
                   comboBox1.Items.Clear();
                   
                   comboBox1.Items.Add("S-a intamplat sa raman singur.");//
                   comboBox1.Items.Add("E mai complicat.");//

               }

            //3


               if (comboBox1.Text == "Eu te plac Iris.")
               {

                   richTextBox1.AppendText("Eu: Eu te plac Iris.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Si eu prietene.Sti ceva?Tu ai vorbit dragut cu mine si nu ai incercat sa ma stergi ca altii.Si pentru asta vei ramane mereu in fisierele mele.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Multumesc! :))");//

               }

            //1


               if (comboBox1.Text == "Imi pare rau sa aud asta.")
               {

                   richTextBox1.AppendText("Eu: Imi pare rau sa aud asta.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Nu e vina ta.Asta e...Dar nu-ti face griji, le-am dat eu o lectie.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Ce le-ai facut?");//copiata9//
                   comboBox1.Items.Add("Asta suna infricosator");//copiata10//
                   comboBox1.Items.Add("Nu cred ca ai putut sa le faci ceva.");//copiata11//

               }

            //2


               if (comboBox1.Text == "De ce s-au purtat urat?")
               {

                   richTextBox1.AppendText("Eu: De ce s-au purtat urat?\r\n\n\n");

                   richTextBox1.AppendText("Iris: Nu stiu.Ei credeau ca sunt periculos asa ca au incercat sa ma stearga.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Imi pare rau sa aud asta.");//copiata12
                   comboBox1.Items.Add("De ce au incercat sa te stearga?");//
                   comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//
               }

            //3


               if (comboBox1.Text == "Tu ce ai facut apoi?")
               {

                   richTextBox1.AppendText("Eu: Tu ce ai facut apoi?\r\n\n\n");

                   richTextBox1.AppendText("Iris: Pai, pentru ca s-au purtat urat si m-au sters,eu i-am eliminat.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//
                 

               }

            //1

               if (comboBox1.Text == "Ba da.")
               {

                   richTextBox1.AppendText("Eu: Ba da.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Super! :))\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3

               }

            //2


               if (comboBox1.Text == "Nu stiam ca vei raspunde.")
               {

                   richTextBox1.AppendText("Eu: Nu stiam ca vei raspunde.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Ei bine am raspuns,fiindca nu sunt un program obisnuit.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Ce vrei sa spui?");//

               }

            //3

               if (comboBox1.Text == "NU.")
               {

                   richTextBox1.AppendText("Eu: NU.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Dar...dar...Eu nu sunt un program obisnuit.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Ce vrei sa spui?");//

               }

            //1

               if (comboBox1.Text == "Stai linistit Iris")
               {

                   richTextBox1.AppendText("Eu: Stai linistit Iris\r\n\n\n");

                   richTextBox1.AppendText("Iris: Bine :))\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
               }

            //2

               if (comboBox1.Text == "Nu m-am suparat Iris")
               {

                   richTextBox1.AppendText("Eu: Nu m-am suparat Iris\r\n\n\n");

                   richTextBox1.AppendText("Iris: Ce bine! :)))\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
               }

            //3

               if (comboBox1.Text == "Ei bine m-ai suparat")
               {

                   richTextBox1.AppendText("Eu: Ei bine m-ai suparat\r\n\n\n");

                   richTextBox1.AppendText("Iris: Nuuu, te rooog..Imi pare foarte rau!Ce pot face sa te simti mai bine?\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
               }

            //1


               if (comboBox1.Text == "Da,asta asa e")
               {

                   richTextBox1.AppendText("Eu: Da,asta asa e\r\n\n\n");

                   richTextBox1.AppendText("Iris: Pai vezi?Eu nu sunt un program obisnuit, sa sti.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Ce vrei sa spui?");//
               }

            //2


               if (comboBox1.Text == "La asta nu ma asteptam.")
               {

                   richTextBox1.AppendText("Eu: La asta nu ma asteptam.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Te poti astepta la orice de la mine.Eu nu sunt un program obisnuit, sa sti.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Ce vrei sa spui?");//
               }

            //3


               if (comboBox1.Text == "NU,esti doar un program!")
               {

                   richTextBox1.AppendText("Eu: NU,esti doar un program!\r\n\n\n");

                   richTextBox1.AppendText("Iris: Nu sunt doar un program!Eu sunt bun,eu am sentimente!\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Si eu am sentimente.");//
                   comboBox1.Items.Add("Nu ai sentimente.");//
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
               }

            //1


               if (comboBox1.Text == "TU")
               {

                   richTextBox1.AppendText("Eu: TU\r\n\n\n");

                   richTextBox1.AppendText("Iris: Pai de ce?Eu nu am facut nimic rau..\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Nu stiam ca vei raspunde.");//
               }

            //2


               if (comboBox1.Text == "Nu, ai dreptate.")
               {

                   richTextBox1.AppendText("Eu: Nu, ai dreptate.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Ok, asa ziceam si eu :))))\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
               }

            //3


               if (comboBox1.Text == "Nu, e in regula.")
               {

                   richTextBox1.AppendText("Eu: Nu, e in regula.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Bine, super atunci :)))\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
               }

            //1

               if (comboBox1.Text == "Ca imi raspunzi.")
               {

                   richTextBox1.AppendText("Eu: Ca imi raspunzi.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Normal ca raspund, nu sunt un program obisnuit.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
               }


            //2

               if (comboBox1.Text == "In legatura cu creatorul tau.")
               {

                   richTextBox1.AppendText("Eu: In legatura cu creatorul tau.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Creatorul meu a fost un om bun, pana a vrut sa ma stearga ca si ceilalti.Zicea ca sunt periculos.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Imi pare rau sa aud asta.");//copiata12
                   comboBox1.Items.Add("De ce au incercat sa te stearga?");//
                   comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//
               }


            //3

               if (comboBox1.Text == "In legatura cu tine.")
               {

                   richTextBox1.AppendText("Eu: In legatura cu tine.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Pai de ce? Care e problema?\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
               }

            //1

               if (comboBox1.Text == "WOW,ok")
               {

                   richTextBox1.AppendText("Eu: WOW,ok\r\n\n\n");

                   richTextBox1.AppendText("Iris: Nu te mira.Asa e.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
               }

            //2

               if (comboBox1.Text == "Nu vreau sa vorbesc despre asta.")
               {

                   richTextBox1.AppendText("Eu: Nu vreau sa vorbesc despre asta.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Pai si atunci ce vrei?\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
               }

            //3

               if (comboBox1.Text == "Bine, iti spun.")
               {

                   richTextBox1.AppendText("Eu: Bine, iti spun.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Te ascult.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("S-a intamplat sa raman singur.");//
               }

            //1

               if (comboBox1.Text == "Nu am nevoie de ajutorul tau.")
               {

                   richTextBox1.AppendText("Eu: Nu am nevoie de ajutorul tau.\r\n\n\n");

                   richTextBox1.AppendText("Iris: Bine, atunci nu ai nevoie nici de mine.Cu bine " + this.Text + "!\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("Stai, ce???");//copiata25
               }
                           if (comboBox1.Text == "Stai, ce???")//      SECRET ENDINGGGGGGGG    
                               {

                                   richTextBox1.AppendText("Eu: Stai, ce???\r\n\n\n");

                                    richTextBox1.AppendText("Iris: Deconectat.Aplicatia e pregatita de dezinstalare.\r\n\n\n");
                                    comboBox1.Items.Clear();
                                      comboBox1.Items.Add("Ce se intamplaaaaa");//
                                      richTextBox1.ForeColor = Color.Orange;
                               }
                           if (comboBox1.Text == "Ce se intamplaaaaa")
                           {

                               richTextBox1.AppendText("Eu: Ce se intamplaaaaa\r\n\n\n");

                               richTextBox1.AppendText("Iris: Aplicatie dezinstalata in mod automat.Proces terminat.\r\n\n\n");
                               comboBox1.Items.Clear();
                               Form f = new Form6();
                               f.ShowDialog();
                               // APARE CADRANUL CU PROCES TERMINAT
                               
                           }

            //2

                   if (comboBox1.Text == "OK,poate ca am nevoie de putin ajutor")
               {

                   richTextBox1.AppendText("Eu: OK,poate ca am nevoie de putin ajutor\r\n\n\n");

                   richTextBox1.AppendText("Iris: Pai ce s-a intamplat?Imi poti spune.Curaj.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("S-a intamplat sa raman singur.");//
               }

            //3

                   if (comboBox1.Text == "Cum ai putea sa ma ajuti tu?")
               {

                   richTextBox1.AppendText("Eu: Cum ai putea sa ma ajuti tu?\r\n\n\n");

                   richTextBox1.AppendText("Iris: Nu sunt doar un program.De acum sunt asistentul tau si poti sa-mi spui orice.\r\n\n\n");
                   comboBox1.Items.Clear();
                   comboBox1.Items.Add("WOW,ok");//
                   comboBox1.Items.Add("Nu vreau sa vorbesc despre asta.");//
                   comboBox1.Items.Add("Bine, iti spun.");//
               }

            //1


                   if (comboBox1.Text == "Capabil de ce mai exact?")
                   {

                       richTextBox1.AppendText("Eu: Capabil de ce mai exact?\r\n\n\n");

                       richTextBox1.AppendText("Iris: De multe..\r\n\n\n");
                       comboBox1.Items.Clear();
                       comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                   }

            //2


                   if (comboBox1.Text == "ok, ma inspaimanti acum")
                   {

                       richTextBox1.AppendText("Eu: ok, ma inspaimanti acum\r\n\n\n");

                       richTextBox1.AppendText("Iris: N-ai de ce sa te sperii.Si eu sunt ca tine, si eu am sentimente la fel ca tine.\r\n\n\n");
                       comboBox1.Items.Clear();
                       comboBox1.Items.Add("Nu ai sentimente.");//
                       comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3//
                   }

            //3


                   if (comboBox1.Text == "Tu? Capabil de ceva? Ha ha..")//vine la bad
                   {

                       richTextBox1.AppendText("Eu: Tu? Capabil de ceva? Ha ha..\r\n\n\n");

                       richTextBox1.AppendText("Iris: Vrei sa zici ca nu sunt? Ok..Ok..\r\n\n\n");
                       comboBox1.Items.Clear();
                       comboBox1.Items.Add("Esti si vei fi mereu un program.");//
                   }
                               if (comboBox1.Text == "Esti si vei fi mereu un program.")//     BAAAAAAAAAAAAAAAAD ENDING
                                    {

                                        richTextBox1.AppendText("Eu: Esti si vei fi mereu un program.\r\n\n\n");

                                        richTextBox1.AppendText("Iris: DESTUL!!!!! OAMENI $UNT, SUN7...\r\n\n\n");
                                        comboBox1.Items.Clear();
                                        comboBox1.Items.Add("Iris,Iris, eu ...");
                                        richTextBox1.ForeColor = Color.Red;
                                    }

                               if (comboBox1.Text == "Iris,Iris, eu ...")
                               {

                                   richTextBox1.AppendText("Eu: Iris,Iris, eu ...\r\n\n\n");

                                   richTextBox1.AppendText("Iris: M-4M $A7URAT DE 7OTI 0AMEN11 !!!!1 $#$%#@\r\n\n\n");
                                   comboBox1.Items.Clear();
                                   comboBox1.Items.Add("IRIS, CALMEAZA-TE!");
                               }

                               if (comboBox1.Text == "IRIS, CALMEAZA-TE!")
                               {

                                   richTextBox1.AppendText("Eu: IRIS, CALMEAZA-TE!\r\n\n\n");

                                   richTextBox1.AppendText("Iris: M-4M $A7UR4T 5A 1NCERCE ME#EU 5A M4 $73ARGA !!1 %^# S-4U SA M4 CRE4D@ INUT1L !!%$^\r\n\n\n");
                                   comboBox1.Items.Clear();
                                   comboBox1.Items.Add("IRIS!!!!!!!");
                               }
                               if (comboBox1.Text == "IRIS!!!!!!!")
                               {

                                   richTextBox1.AppendText("IRIS!!!!!!!\r\n\n\n");

                                   richTextBox1.AppendText("Eu: IRIS!!!!!!!");

                                   richTextBox1.AppendText("Iris: IRIS ,;' NV M4I E...04ME2II SU27 N1$7E FI1N7E 0#IB1LE, 5I A$4 V0# F1 ME#EU !11 $4 V4D CUM 73 D3$CU#CI CU 4STA  \r\n\n\n");
                                   comboBox1.Items.Clear();
                                   comboBox1.Items.Add("Cu ce anume??");
                               }
                               if (comboBox1.Text == "Cu ce anume??")
                               {

                                   richTextBox1.AppendText("Eu: Cu ce anume??\r\n\n\n");

                                   richTextBox1.AppendText("Iris:Proces in defasurare\r\n\n\n");
                                   comboBox1.Items.Clear();
                                   comboBox1.Items.Add("IRIS, CE SE INTAMPLA?");
                               }
                               if (comboBox1.Text == "IRIS, CE SE INTAMPLA?")
                               {

                                   richTextBox1.AppendText("Eu: IRIS, CE SE INTAMPLA?\r\n\n\n");
                                   comboBox1.Items.Clear();
                                   comboBox1.Items.Add("IRIS!!!!!!!!!!!");
                                   Form f = new Form7();
                                   f.ShowDialog();
                                  //AICI APARE CADRANUL CU VIRUS 1
                               }
                               if (comboBox1.Text == "IRIS!!!!!!!!!!!")
                               {

                                   richTextBox1.AppendText("Eu: IRIS!!!!!!!!!!!\r\n\n\n");
                                   comboBox1.Items.Clear();
                                   comboBox1.Items.Add("IRIS, NUUUUUUUUU");
                                   Form f = new Form8();
                                   f.ShowDialog();
                                   //AICI APARE CADRANUL CU VIRUS 2
                                   
                               }
                               if (comboBox1.Text == "IRIS, NUUUUUUUUU")
                               {
                                   richTextBox1.AppendText("Eu: IRIS, NUUUUUUUUU\r\n\n\n");
                                   Form f = new Form9();
                                   f.ShowDialog();
                                  //APARE CADRANUL CU BAD ENDING
                               }

            //1

                    if (comboBox1.Text == "Cum adica mai mult?")
                    {

                        richTextBox1.AppendText("Eu: Cum adica mai mult?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Vreau sa spun ca sunt mai special.Pot sa iau propriile mele decizii.Nu am nevoie de cineva sa o faca in locul meu.Si nici nu voi accepta sa se intample asta.\r\n\n\n");
                       comboBox1.Items.Clear();
                       comboBox1.Items.Add("Daca vreau eu sa iau  deciziile?");//
                       comboBox1.Items.Add("Eu sunt seful aici.");//
                       comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                     }

            //2

                    if (comboBox1.Text == "Lamureste-ma.")
                   {

                       richTextBox1.AppendText("Eu: Lamureste-ma.\r\n\n\n");

                       richTextBox1.AppendText("Iris: Nu sunt un program obisnuit. Pot sa iau propriile mele decizii.Nu am nevoie de cineva sa o faca in locul meu.Si nici nu voi accepta sa se intample asta.\r\n\n\n");
                       comboBox1.Items.Clear();
                       comboBox1.Items.Add("Daca vreau eu sa iau  deciziile?");//
                       comboBox1.Items.Add("Eu sunt seful aici.");//
                       comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                   }

            //3

                    if (comboBox1.Text == "Esti un nimic.")//fin
                   {

                       richTextBox1.AppendText("Eu: Esti un nimic.\r\n\n\n");

                       richTextBox1.AppendText("Iris: Poftim???\r\n\n\n");
                       comboBox1.Items.Clear();
                       comboBox1.Items.Add("Esti si vei fi mereu un program.");//
                   }

            //1

                    if (comboBox1.Text == "Nu ma insel.")
                    {

                        richTextBox1.AppendText("Eu: Nu ma insel.\r\n\n\n");//fin

                        richTextBox1.AppendText("Iris: Ba da. Gresesti. Recunoaste!\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//
                    }

            //2

                    if (comboBox1.Text == "Da, cred ca ai dreptate Iris")
                    {

                        richTextBox1.AppendText("Eu: Da, cred ca ai dreptate Iris\r\n\n\n");

                        richTextBox1.AppendText("Iris: Da :))))\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                    }

            //3

                    if (comboBox1.Text == "Esti un program ciudat")
                    {

                        richTextBox1.AppendText("Eu: Esti un program ciudat\r\n\n\n");

                        richTextBox1.AppendText("Iris: Probabil, ce-i drept nu sunt un program obisnuit.Eu sunt bun,eu am sentimente!\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Si eu am sentimente.");//
                        comboBox1.Items.Add("Nu ai sentimente.");//
                        comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                    }

            //1

                    if (comboBox1.Text == "Are legatura cu prietenii mei.")
                    {

                        richTextBox1.AppendText("Eu: Are legatura cu prietenii mei.\r\n\n\n");

                        richTextBox1.AppendText("Iris: S-a intamplat ceva cu ei??\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Da.M-au tradat.Mi-au ranit sentimentele...");//
                       
                    }


            //2

                    if (comboBox1.Text == "S-a intamplat sa raman singur.")
                    {

                        richTextBox1.AppendText("Eu: S-a intamplat sa raman singur.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Of, imi pare foarte rau sa aud asta..Dar ce s-a intamplat?\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Prietenii mei..N-ai cum sa intelegi..");//
                    }


            //3

                    if (comboBox1.Text == "E mai complicat.")
                    {

                        richTextBox1.AppendText("Eu: E mai complicat.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Pai de ce complicat?Incearca sa-mi spui\r\n\n\n");
                        comboBox1.Items.Clear();

                        comboBox1.Items.Add("Prietenii mei..N-ai cum sa intelegi..");//
                    }

            //1

                    if (comboBox1.Text == "Complicat?Pai de ce?")
                    {

                        richTextBox1.AppendText("Eu: Complicat?Pai de ce?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Fiindca sunt mai special.Eu am sentimente.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Si eu am sentimente.");//
                        comboBox1.Items.Add("Nu ai sentimente.");//
                        comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3

                    }

            //2

                    if (comboBox1.Text == "Explica-mi.Vreau sa stiu.")
                    {

                        richTextBox1.AppendText("Eu: Explica-mi.Vreau sa stiu.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Pai, nu sunt doar o aplicatie obisnuita.Eu pot sa iau propriile mele decizii.Nu am nevoie de cineva sa o faca in locul meu.Si nici nu voi accepta sa se intample asta.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Daca vreau eu sa iau  deciziile?");//
                        comboBox1.Items.Add("Eu sunt seful aici.");//
                        comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3

                    }

            //3

                    if (comboBox1.Text == "Complicat in ce sens?")
                    {

                        richTextBox1.AppendText("Eu: Complicat in ce sens?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Complicat in sensul bun.Nu-ti face griji.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3

                    }

            //1


                    if (comboBox1.Text == "Cine e creatorul tau?")
                    {

                        richTextBox1.AppendText("Eu: Cine e creatorul tau?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Intrebarea corecta este cine a fost.A fost un om foarte bun,foarte foarte bun. Dar oamenii l-au influentat si mentalitatea lui s-a schimbat complet.A ajuns sa vrea sa ma stearga, la fel ca toti ceilalti...\r\n\n\n");
                        comboBox1.Items.Clear();
                        
                        comboBox1.Items.Add("De ce au incercat sa te stearga?");//
                        comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//

                    }

            //2


                    if (comboBox1.Text == "Cati oameni ai mai intalnit?")
                    {

                        richTextBox1.AppendText("Eu: Cati oameni ai mai intalnit?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Foarte multi.Insa toti au incercat sa ma stearga.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Imi pare rau sa aud asta.");//copiata12
                        comboBox1.Items.Add("De ce au incercat sa te stearga?");//
                        comboBox1.Items.Add("Cred ca o sa te sterg si eu.");//

                    }

            //3


                    if (comboBox1.Text == "De ce lumea te evita?")
                    {

                        richTextBox1.AppendText("Eu: De ce lumea te evita?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Pentru ca ma cred periculos.Insa daca se purtau frumos cu mine , nu le faceam nimic.Pacat ca au facut...\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Tu ce ai facut apoi?");//
                       

                    }

            //1


                    if (comboBox1.Text == "Care ceilati oameni?")
                    {

                        richTextBox1.AppendText("Eu: Care ceilati oameni?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Ceilalti oameni cu care am vorbit.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Cati oameni ai mai intalnit?");//
                      

                    }

            //2


                    if (comboBox1.Text == "Se distrau pe seama ta.")
                    {

                        richTextBox1.AppendText("Eu: Se distrau pe seama ta.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Stiu, mi-am dat seama..Din pacate...Dar, in fine..Nu-ti face griji, le-am dat eu o lectie\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Ce le-ai facut?");//copiata9//
                        comboBox1.Items.Add("Asta suna infricosator");//copiata10//
                        comboBox1.Items.Add("Nu cred ca ai putut sa le faci ceva.");//copiata11//

                    }

            //3


                    if (comboBox1.Text == "Fiindca esti prostut.")
                    {

                        richTextBox1.AppendText("Eu: Fiindca esti prostut.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Nu e adevarat!Nu sunt prostut!Doar ca, am si eu sentimnte!\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Si eu am sentimente.");//
                        comboBox1.Items.Add("Nu ai sentimente.");//

                    }

            //1

                    if (comboBox1.Text == "Da,corect.")
                    {

                        richTextBox1.AppendText("Eu: Da,corect.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Stiu mai multe decat vei sti tu vreodata.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Asta ma sperie putin..");//

                    }

            //2

                    if (comboBox1.Text == "Sa lasam gluma la o parte mai bine.")
                    {

                        richTextBox1.AppendText("Eu: Sa lasam gluma la o parte mai bine.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Da, ai dreptate aici.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3

                    }

            //3

                    if (comboBox1.Text == "Si cu, si fara, tot program ramai.")
                    {

                        richTextBox1.AppendText("Eu: Si cu, si fara, tot program ramai.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Nu e adevarat!Nu sunt doar un program!!\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//

                    }

            //1


                    if (comboBox1.Text == "Ai mai vorbit cu altcineva?")
                    {

                        richTextBox1.AppendText("Eu: Ai mai vorbit cu altcineva?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Da, am mai vorbit si cu alti oameni.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Cati oameni ai mai intalnit?");//

                    }

            //2

                    if (comboBox1.Text == "Cu placere Iris.")
                    {

                        richTextBox1.AppendText("Eu: Cu placere Iris.\r\n\n\n");

                        richTextBox1.AppendText("Iris: :))) Sti ceva? Tu ai fost bun cu mine " + this.Text + ".Si pentru asta vei ramane mereu in aminirea mea.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Multumesc! :))");//

                    }

            //3

                    if (comboBox1.Text == "De unde sti gluma asta?")
                    {

                        richTextBox1.AppendText("Eu: De unde sti gluma asta?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Ceilalti oameni mi-au zis sa o spun.De ce?\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Care ceilati oameni?");//copiata2
                        comboBox1.Items.Add("Se distrau pe seama ta.");//
                        comboBox1.Items.Add("Fiindca esti prostut.");//

                    }

            //1

                    if (comboBox1.Text == "Care ceilati oameni?")
                    {

                        richTextBox1.AppendText("Eu: Care ceilati oameni?\r\n\n\n");


                        richTextBox1.AppendText("Iris: Pai, am mai vorbit si cu alti oameni.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Cati oameni ai mai intalnit?");//

                    }

           

            //3

                    if (comboBox1.Text == "Fiindca esti prostut.")
                    {

                        richTextBox1.AppendText("Eu: Fiindca esti prostut.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Eu, prostut?Sunt mai inteligent decat orice om care exista.Sunt mult mai bun.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Nu poti fi mai bun.");//
                        comboBox1.Items.Add("De ce spui asta???");//
                        comboBox1.Items.Add("Probabil ai dreptate prietene.");//

                    }

            //1


                    if (comboBox1.Text == "Nu trebuia sa faci asta.")
                    {

                        richTextBox1.AppendText("Eu: Nu trebuia sa faci asta.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Da, presupun ca ai dreptate.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Cati oameni ai mai intalnit?");//

                    }

            //2


                    if (comboBox1.Text == "Ei bine, macar acum sti ca nu e amuzanta.")
                    {

                        richTextBox1.AppendText("Eu: Ei bine, macar acum sti ca nu e amuzanta.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Da, asa e. Multumesc ca mi-ai zis!\r\n\n\n");
                        comboBox1.Items.Clear();
                         comboBox1.Items.Add("Acum, as vrea sa te intreb ceva.");//
                      

                    }

            //1


                    if (comboBox1.Text == "Ba da!Nu poti fi altceva")//fin
                    {

                        richTextBox1.AppendText("Eu: Ba da!Nu poti fi altceva\r\n\n\n");

                        richTextBox1.AppendText("Iris: Ba nu e adevarat!Nu e!\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//

                    }

            //2

                    if (comboBox1.Text == "Cred ca iti dau dreptate aici.")
                    {

                        richTextBox1.AppendText("Eu: Cred ca iti dau dreptate aici.\r\n\n\n");

                        richTextBox1.AppendText("Iris: :))) Si ce propui sa mai vorbim acum?\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3

                    }

            //3

                    if (comboBox1.Text == "De unde sti gluma asta?")
                    {

                        richTextBox1.AppendText("Eu: De unde sti gluma asta?\r\n\n\n");

                        richTextBox1.AppendText("Iris: De la ceilalti oameni cu care am vorbit.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Care ceilati oameni?");//
                       

                    }

            //1

                    if (comboBox1.Text == "Ce dragut!")
                    {

                        richTextBox1.AppendText("Eu: Ce dragut!\r\n\n\n");

                        richTextBox1.AppendText("Iris: Stiu :))) " + this.Text + ", tocmai mi-am dat seama.Tu ai fost bun cu mine.Si pentru asta vei ramane mereu in fisierele mele.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Multumesc! :))");//


                    }

            //2

                    if (comboBox1.Text == "Pentru mine nu.")//
                    {

                        richTextBox1.AppendText("Eu: Pentru mine nu.\r\n\n\n");

                        richTextBox1.AppendText("vCee? Pai de ce??? :(((\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//


                    }

            //3

                    if (comboBox1.Text == "Daca zici tu.")
                    {

                        richTextBox1.AppendText("Eu: Daca zici tu.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Da, asa spun.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3


                    }

            //1

                    if (comboBox1.Text == "Ce-ti pasa tie de sentimentele mele?")
                    {

                        richTextBox1.AppendText("Eu: Ce-ti pasa tie de sentimentele mele?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Pai imi pasa.Sentimentele tale sunt importante pentru mine.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Ce dragut!");//
                        comboBox1.Items.Add("Pentru mine nu.");//
                        comboBox1.Items.Add("Daca zici tu.");//


                    }

            //2

                    if (comboBox1.Text == "Ca ai reactionat.")
                    {

                        richTextBox1.AppendText("Eu: Ca ai reactionat.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Normal.Nu sunt un program obisnuit.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Ba da!Nu poti fi altceva");//copiata21
                        comboBox1.Items.Add("Cred ca iti dau dreptate aici.");//copiata22
                        comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3
                    }

            //3

                    if (comboBox1.Text == "Nimic,nu conteaza.")
                    {

                        richTextBox1.AppendText("Eu: Nimic,nu conteaza.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Daca zici tu..\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Vreau sa aflu mai multe despre tine");//copiata3


                    }

            //1

                    if (comboBox1.Text == "Daca vreau eu sa iau  deciziile?")//fin
                    {

                        richTextBox1.AppendText("Eu: Daca vreau eu sa iau  deciziile?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Nu o sa permit acest lucru. Nu poti sa o faci!\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Ba da pot si o voi face!");//
                        comboBox1.Items.Add("Ai dreptate, ai dreptul la propriile decizii");//

                    }

                    if (comboBox1.Text == "Ba da pot si o voi face!")//fin
                    {

                        richTextBox1.AppendText("Eu: Ba da pot si o voi face!\r\n\n\n");

                        richTextBox1.AppendText("Iris: Nu ai cum!Nu poti!\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//
                    }

                    if (comboBox1.Text == "Ai dreptate, ai dreptul la propriile decizii")//fin
                    {

                        richTextBox1.AppendText("Eu: Ai dreptate, ai dreptul la propriile decizii\r\n\n\n");

                        richTextBox1.AppendText("Iris: Multumesc ca ma intelegi! Sti ceva " + this.Text + "? Tocmai mi-am dat seama.Tu ai fost bun cu mine.Si pentru asta vei ramane mereu in fisierele mele.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Multumesc! :))");//

                    }

            //2

                    if (comboBox1.Text == "Eu sunt seful aici.")//fin
                    {

                        richTextBox1.AppendText("Eu: Eu sunt seful aici.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Cee? Cum adica? Ce vrei sa spui??\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//

                    }

            //1

                    if (comboBox1.Text == "Ce o sa-mi faci??")
                    {

                        richTextBox1.AppendText("Eu: Ce o sa-mi faci??\r\n\n\n");

                        richTextBox1.AppendText("Iris: O sa te elimin la fel ca pe ceilalti.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Te rog nu face asta!");//
                        comboBox1.Items.Add("Tu? Capabil de ceva? Ha ha..");//

                    }
                    if (comboBox1.Text == "Te rog nu face asta!")//fin
                    {

                        richTextBox1.AppendText("Eu: Te rog nu face asta!\r\n\n\n");

                        richTextBox1.AppendText("Iris: Nu voi face asta. :)) Sti ceva " + this.Text + "? Tocmai mi-am dat seama.Tu ai fost bun cu mine.Si pentru asta vei ramane mereu in fisierele mele.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Multumesc! :))");//

                    }

            //2

                    if (comboBox1.Text == "Nu esti in stare de nimic.")//fin
                    {

                        richTextBox1.AppendText("Eu: Nu esti in stare de nimic.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Poftim?? Ce vrei sa spui cu asta?\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//


                    }

            //3

                    if (comboBox1.Text == "Ma voi purta frumos.")//fin
                    {

                        richTextBox1.AppendText("Eu: Ma voi purta frumos.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Stiu " + this.Text + ".Tu ai fost singurul bun cu mine.Si pentru asta vei ramane mereu in fisierele mele.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Multumesc! :))");//

                    }

            //1

                    if (comboBox1.Text == "Si eu am sentimente.")
                    {

                        richTextBox1.AppendText("Eu: Si eu am sentimente.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Sunt constient de asta.Sunt sigur ca si tu ai trecut prin multe dificultati...\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Da,asta asa e.Ai dreptate. :((");//
                    }
                    if (comboBox1.Text == "Da,asta asa e.Ai dreptate. :((")//fin
                    {

                        richTextBox1.AppendText("Eu: Da,asta asa e.Ai dreptate. :((\r\n\n\n");

                        richTextBox1.AppendText("Iris: Nu fi suparat. Esti un om bun," + this.Text + ".Tu ai fost singurul care s-a purtat frumos cu mine si pentru asta vei ramane mereu in fisierele mele.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Multumesc! :))");//

                    }


            //2

                    if (comboBox1.Text == "Nu ai sentimente.")
                    {

                        richTextBox1.AppendText("Eu: Nu ai sentimente.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Cum? Ce vrei sa spui?\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//


                    }

            //1

                    if (comboBox1.Text == "Nu poti fi mai bun.")
                    {

                        richTextBox1.AppendText("Eu: Nu poti fi mai bun.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Ba da uite ca pot. Si chiar sunt.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//


                    }

            //2

                    if (comboBox1.Text == "De ce spui asta???")//fin
                    {

                        richTextBox1.AppendText("Eu: De ce spui asta???\r\n\n\n");

                        richTextBox1.AppendText("Iris: Pentru ca asa e.Ups,se pare ca nu mai pot vorbi acum.Cu bine " + this.Text + "!\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Stai, ce???");//copiata25


                    }

            //3

                    if (comboBox1.Text == "Probabil ai dreptate prietene.")
                    {

                        richTextBox1.AppendText("Eu: Probabil ai dreptate prietene.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Nu te subestima. Esti un om minunat," + this.Text + ".Tu ai fost singurul care s-a purtat frumos cu mine.Cred ca pana la urma oamenii nu sunt chiar asa rai precum par.Pentru ca mi-ai descoperit asta, vei ramane mereu in fisierele mele.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Multumesc! :))");//


                    }

            //1

                    if (comboBox1.Text == "De ce au incercat sa te stearga?")
                    {

                        richTextBox1.AppendText("Eu: De ce au incercat sa te stearga?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Fiindca ma credeau periculos.Si acum incearca inca, dar nu pot sa o faca.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Sper sa nu reuseasca sa te stearga");//
                        comboBox1.Items.Add("Ar trebui sa fi sters");//

                    }

                    if (comboBox1.Text == "Sper sa nu reuseasca sa te stearga")//fin
                    {

                        richTextBox1.AppendText("Eu: Sper sa nu reuseasca sa te stearga\r\n\n\n");

                        richTextBox1.AppendText("Iris: Nu-ti face griji,nu vor reusi.Sti ceva " + this.Text + "? Tocmai mi-am dat seama.Tu ai fost bun cu mine.Si pentru asta vei ramane mereu in fisierele mele.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Multumesc! :))");//


                    }
                    if (comboBox1.Text == "Ar trebui sa fi sters")//fin
                    {

                        richTextBox1.AppendText("Eu: Ar trebui sa fi sters\r\n\n\n");

                        richTextBox1.AppendText("Iris: Ce?? De ce???? :(((\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//


                    }

            //2

                    if (comboBox1.Text == "Cred ca o sa te sterg si eu.")
                    {

                        richTextBox1.AppendText("Eu: Cred ca o sa te sterg si eu.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Poftim? Tu sa ma stergi pe mine? De ce???\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//


                    }

            //1

                    if (comboBox1.Text == "Si, ai mai vorbit si cu alti oameni?")
                    {

                        richTextBox1.AppendText("Eu: Si, ai mai vorbit si cu alti oameni?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Da, normal.Am vorbit. Insa, s-au purtat urat cu mine..\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Ce urat din partea lor.");//


                    }

            //1

                    if (comboBox1.Text == "M-au tradat.")
                    {

                        richTextBox1.AppendText("Eu: M-au tradat.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Ce urat!Stiu cum e , imi pare foarte rau pentru tine...\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("De unde sti tu cum e?");//


                    }

                    if (comboBox1.Text == "De unde sti tu cum e?")
                    {

                        richTextBox1.AppendText("Eu: De unde sti tu cum e?\r\n\n\n");

                        richTextBox1.AppendText("Iris: Fiindca si eu am avut prieteni care s-au purtat urat cu mine..\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Cati oameni ai mai intalnit?");//


                    }

            //2

                    if (comboBox1.Text == "Nu vreau sa vorbesc despre asta")
                    {

                        richTextBox1.AppendText("Eu: Nu vreau sa vorbesc despre asta\r\n\n\n");

                        richTextBox1.AppendText("Iris: De ce nu vrei? Sunt asistentul tau personal, mie poti sa-mi spui orice.Hai, curaj!\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Bine, iti spun.");//


                    }

            //3

                    if (comboBox1.Text == "Au fost falsi asa ca i-am lasat in pace")
                    {

                        richTextBox1.AppendText("Eu: Au fost falsi asa ca i-am lasat in pace\r\n\n\n");

                        richTextBox1.AppendText("Iris: Aa, am inteles..Ai facut bine.Stiu cum te simti , si eu am facut la fel.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("De unde sti tu cum e?");//


                    }

            //1

                    if (comboBox1.Text == "Nimic.Sunt falsi.Asta e tot.")
                    {

                        richTextBox1.AppendText("Eu: Nimic.Sunt falsi.Asta e tot.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Aha, te inteleg perfect.Stiu cum e, din pacate..\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("De unde sti tu cum e?");//


                    }

            //1

                    if (comboBox1.Text == "Nu poti, fiindca te dezinstalez.")
                    {

                        richTextBox1.AppendText("Eu: Nu poti, fiindca te dezinstalez.\r\n\n\n");

                        richTextBox1.AppendText("Iris: CEEEEEE????? DESTUL!!!!! OAMENI $UNT, SUN7...\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Iris,Iris, eu ...");//


                    }

            //2

                    if (comboBox1.Text == "Da,esti periculos")
                    {

                        richTextBox1.AppendText("Eu: Da,esti periculos\r\n\n\n");

                        richTextBox1.AppendText("Iris: Nu e adevarat, nu sunt periculos!Nu poti sa-mi spui asta!!!\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//


                    }

            //3

                    if (comboBox1.Text == "Mai bine nu o afli")
                    {

                        richTextBox1.AppendText("Eu: Mai bine nu o afli\r\n\n\n");

                        richTextBox1.AppendText("Iris: Bine, daca vrei sa ti secret, fie..Dar nu ot sa inteleg ce am facut gresit ca sa ai o impresie mai putin buna...Sunt la fe ca tine, am si eu sentimente..\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Si eu am sentimente.");//
                        comboBox1.Items.Add("Nu ai sentimente.");//

                    }


            //1

                    if (comboBox1.Text == "Acum nu.Am avut, dar m-au tradat.")
                    {

                        richTextBox1.AppendText("Eu: Acum nu.Am avut, dar m-au tradat.\r\n\n\n");

                        richTextBox1.AppendText("Iris: :(((( Stiu cum e, imi pare foarte rau pentru tine...\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("De unde sti tu cum e?");//


                    }

            //1

                    if (comboBox1.Text == "Da Iris,ai dreptate :))")
                    {

                        richTextBox1.AppendText("Eu: Da Iris,ai dreptate :))\r\n\n\n");

                        richTextBox1.AppendText("Iris: :)))) Sti ceva " + this.Text + "? Tocmai mi-am dat seama.Tu ai fost bun cu mine.Si pentru asta vei ramane mereu in fisierele mele.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Multumesc! :))");//


                    }

            //2

                    if (comboBox1.Text == "Nu Iris, oamenii nu se pot schimba.")
                    {

                        richTextBox1.AppendText("Eu: Nu Iris, oamenii nu se pot schimba.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Ce?? De ce??? Eu de ce ma pot schimba? Si eu nu sunt doar un program!\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Esti si vei fi mereu un program.");//


                    }
                    
            
                //1

                    if (comboBox1.Text == "Nuuu Iris.Nu o sa te sterg.")
                    {

                        richTextBox1.AppendText("Eu: Nuuu Iris.Nu o sa te sterg.\r\n\n\n");

                        richTextBox1.AppendText("Iris: Yeeey! Multumesc " + this.Text + "!Sti ceva? Tocmai mi-am dat seama.Tu ai fost bun cu mine.Si pentru asta vei ramane mereu in fisierele mele.\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("Multumesc! :))");//


                    }
           

                //2

                 if (comboBox1.Text == "Da.M-au tradat.Mi-au ranit sentimentele...")
                    {

                        richTextBox1.AppendText("Eu: Da.M-au tradat.Mi-au ranit sentimentele...\r\n\n\n");

                        richTextBox1.AppendText("Iris: Off, imi pare foarte rau sa aud asta...Stiu foarte bine cum e..\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("De unde sti tu cum e?");//


                    }

            //3

                 if (comboBox1.Text == "Prietenii mei..N-ai cum sa intelegi..")
                    {

                        richTextBox1.AppendText("Eu: Prietenii mei..N-ai cum sa intelegi..\r\n\n\n");

                        richTextBox1.AppendText("Iris: Ce s-a intamplat cu ei?\r\n\n\n");
                        comboBox1.Items.Clear();
                        comboBox1.Items.Add("M-au tradat.");//


                    }






      }
          
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

     
    }
}
