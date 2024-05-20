using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Viktorina
{
    public partial class Form2 : Form
    {
        string[] jautajumi = new string[] {
            "KĀ SAUC LATVIJAS GALVASPILSĒTU?",
            "KĀ SAUC LATVIJAS GARĀKO UPI?",
            "KĀ SAUC LATVIJAS AUGSTĀKO KALNU?",
            "APTUVENI, CIK LATVIJĀ IR IEDZĪVOTĀJU?",
            "KURA IR LATVIJAS VECĀKĀ PILSĒTA?",
            "ŪDENSKRITUMS VENTAS RUMBA, KAS ATRODAS KULDĪGĀ IR:",
            "KĀ SAUC BRĪVĪBAS PIEMINEKĻA AUTORU?",
            "KAS IR LATVIJAS HIMNAS AUTORS?",
            "KĀ SAUC LATVIJAS PIRMO PREZIDENTU?",
            "KURĀ GADĀ DIBINĀTA LATVIJAS VALSTS?",
            "KAD NOTIKA PIRMIE VISPĀRĒJIE LATVIEŠU DZIESMU SVĒTKI?",
            "KO LATVIJĀ ATZĪMĒ 11. NOVEMBRĪ?",
            "TV TORNIS, KAS ATRODAS ZAĶUSALĀ IR:",
            "AR KĀDU DABAS RESURSU LATVIJA IR VISBAGĀTĀKĀ?",
            "LATVIJĀ DZIMUŠAIS JĀKOBS JUFESS PASAULĒ IR ZINĀMS AR TO, KA:",
            "NOSAUC LATVIJAS DZIĻĀKO EZERU!",
            "KĀ SAUC JŪRU, PIE KURAS ATRODAS LATVIJA?",
            "KAS IR LATVIJAS VALSTS LIKUMDEVĒJS?",
            "1999. GADĀ PAR LATVIJAS PREZIDENTI KĻUVA VAIRA VĪĶE – FREIBERGA. UZ TO BRĪDI VIŅA BIJA PIRMĀ SIEVIETE PREZIDENTE:",
            "KAD LATVIJĀ OFICIĀLA VALŪTA KĻUVA PAR EIRO?",
            "KURA VALSTS NAV LATVIJAS KAIMIŅVALSTS?",
            "KURŠ IR TAGADĒJAIS LATVIJAS VALSTS PREZIDENTS?",
            "KĀDA IR APTUVENI LATVIJAS VALSTS PLATĪBA?",
            "KAS IR LATVIJAS NACIONĀLAIS PUTNS?",
            "KURA NAV LATVIJAS PILSĒTA?"
            "KĀ SAUC LATVIJAS LIELĀKO UPI?"
        };

        string[] atbildes1 = new string[] {
            "Liepāja",
            "Lielupe",
            "Gaiziņkalns",
            "1 miljons",
            "Rīga",
            "Vecākais ūdenskritums Eiropā",
            "Kārlis Zāle",
            "Kārlis Zāle",
            "Jānis Čakste",
            "1920. gadā",
            "1873. gadā",
            "Līgo svētkus",
            "Visaugstākais tornis Eiropā",
            "Ūdens",
            "Viņš izgudroja kafiju",
            "Alūksnes ezers",
            "Rīgas jūras līcis",
            "Prezidents",
            "Eiropā",
            "2004. gadā",
            "Polija",
            "Raimonds Vējonis",
            "64 000 Km2",
            "Baltais Stārķis",
            "Saldus"
            "Daugava"
        };

        string[] atbildes2 = new string[] {
            "Daugavpils",
            "Daugava",
            "Mākoņkalns",
            "2 miljoni",
            "Ludza",
            "Skaistākais ūdenskritums Eiropā",
            "Baumaņu Kārlis",
            "Jāzeps Vītols",
            "Guntis Ulmanis",
            "1918. gadā",
            "1973. gadā",
            "Latvijas dzimšanas dienu",
            "Otrais augstākais tornis Eiropā",
            "Mežs",
            "Viņš izgudroja radio",
            "Burtnieku ezers",
            "Baltā jūra",
            "Ministri",
            "Austrumeiropā",
            "2014. gadā",
            "Baltkrievija",
            "Edgars Rinkēvičs",
            "70 000 Km2",
            "Ziemeļu Gulbis",
            "Carnikava",
            "Lielupe"
        };

        string[] atbildes3 = new string[] {
            "Rīga",
            "Gauja",
            "Zilaiskalns",
            "3 miljoni",
            "Grobiņa",
            "Platākais ūdenskritums Eiropā",
            "Krišjānis Barons",
            "Baumaņu Kārlis",
            "Kārlis Ulmanis",
            "1919. gadā",
            "2003. gadā",
            "Lāčplēša dienu",
            "Trešais augstākais tornis Eiropā",
            "Māls",
            "Viņš izgudroja džinsus",
            "Drīdzis",
            "Baltijas jūra",
            "Saeima",
            "Baltijā",
            "2010. gadā",
            "Krievija",
            "Andris Bērziņš",
            "56 000 Km2",
            "Baltā Cielava",
            "Ilūkste",
            "Gauja"
        };

        string[] atbildes = new string[] {
            "Rīga",
            "Gauja",
            "Gaiziņkalns",
            "2 miljoni",
            "Ludza",
            "Platākais ūdenskritums Eiropā",
            "Kārlis Zāle",
            "Baumaņu Kārlis",
            "Jānis Čakste",
            "1918. gadā",
            "1873. gadā",
            "Lāčplēša dienu",
            "Trešais augstākais tornis Eiropā",
            "Mežs",
            "Viņš izgudroja džinsus",
            "Drīdzis",
            "Baltijas jūra",
            "Saeima",
            "Austrumeiropā",
            "2014. gadā",
            "Polija",
            "Edgars Rinkēvičs",
            "64 000 Km2",
            "Baltā Cielava",
            "Carnikava",
            "Daugava"
        };

        int piemeri = 0;
        public static int punkti = 0;

        List<int> randomizedIndices;

        public Form2()
        {
            InitializeComponent();
            GenerateRandomIndices();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ShowQuestionAndAnswers();
        }

        private void ShowQuestionAndAnswers()
        {
            if (piemeri < 10)
            {
                int index = randomizedIndices[piemeri];
                labJautajums.Text = jautajumi[index];
                butAtbilde1.Text = atbildes1[index];
                butAtbilde2.Text = atbildes2[index];
                butAtbilde3.Text = atbildes3[index];
                labPiemers.Text = (piemeri + 1) + ". no 10 jautājumiem";
            }
            else
            {
                this.Hide();
                Form3 rezultats = new Form3();
                rezultats.Show();
            }
        }

        private void GenerateRandomIndices()
        {
            randomizedIndices = Enumerable.Range(0, jautajumi.Length).OrderBy(x => Guid.NewGuid()).Take(10).ToList();
        }

        private void butAtbilde1_Click(object sender, EventArgs e)
        {
            CheckAnswer(butAtbilde1.Text);
        }

        private void butAtbilde2_Click(object sender, EventArgs e)
        {
            CheckAnswer(butAtbilde2.Text);
        }

        private void butAtbilde3_Click(object sender, EventArgs e)
        {
            CheckAnswer(butAtbilde3.Text);
        }

        private void CheckAnswer(string selectedAnswer)
        {
            if (selectedAnswer == atbildes[randomizedIndices[piemeri]]) punkti++;
            else if (punkti > 0) punkti--;
            
            labPunkti.Text = punkti == 1 ? punkti + " punkts" : punkti + " punkti";
            
            piemeri++;
            ShowQuestionAndAnswers();
        }
    }
}
