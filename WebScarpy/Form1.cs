using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ScrapySharp.Exceptions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System.Text.RegularExpressions;
using System.Linq.Expressions;
using System.IO;

namespace WebScarpy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            webScraping();
        }
        MatchCollection resultado1;
        public void webScraping()
        {
            //Regex expresion = new Regex("[A-Z][AEIOU][A-Z]{2}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[HM](DF|HG|MC)[B-DF-HJ-NP-TV-Z]{3}[0-9A-Z][0-9]");
            //resultado = expresion.Match("HEHR021224HDFRRLA6");

            //Regex expresion1 = new Regex("([A-Z]|[ÁÉÍÓÚ])([a-z]|[áéíóú])+");
            //Regex expresion1 = new Regex("(\+52)([- | ][0-9][0-9]|[0-9][0-9]){5}");

            //Regex expresion1 = new Regex("(\+52|52)?(\-| )?([0-9]{2}(\-|0))");
            listBox_Resultados.Items.Clear();
            richTextBox_ResultadoHtml.Text = "";
            label_CountMatchs.Text = "";
            HtmlWeb web = new HtmlWeb();
            String url = textBox_Url.Text;
            String regularExpresion = textBox_regularExpresion.Text;

            if (url == ""| regularExpresion == "")
            {
                MessageBox.Show("Te falta ingresar algun dato");
            }
            else
            {

                HtmlAgilityPack.HtmlDocument doc = web.Load(url);
                HtmlNode body = doc.DocumentNode.CssSelect("body").First();
                String expresion = @"" + regularExpresion;
                //String expresion = @"([- | ][0-9][0-9]|[0-9][0-9]){5}";

                int num = Regex.Matches(body.InnerHtml, expresion).Count;
                label_CountMatchs.Text = "Matchs : " + num;
                if (Regex.Matches(body.InnerHtml, expresion).Count == 0)
                {
                    listBox_Resultados.Items.Add("0 resultados");
                    richTextBox_ResultadoHtml.Text = body.InnerHtml;
                }
                else
                {
                    resultado1 = Regex.Matches(body.InnerHtml, expresion);
                    foreach (Match match in resultado1)
                    {
                        Console.WriteLine(match.Value);
                        listBox_Resultados.Items.Add(match.Value);
                    }
                    richTextBox_ResultadoHtml.Text = body.InnerHtml;
                }
            }

            

        }
    }
}
