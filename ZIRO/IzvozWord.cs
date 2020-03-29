﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ZIRO
{
    class IzvozWord
    {
        public string Datum { get; set; }
        public string ImePrezime { get; set; }
        public List<string> ListaZaduzenja {get; set;}
        public string IzdanoOd { get; set; }
        public string Zaduzen { get; set; }


        public void Revers()
        {
            StvoriDokument(@"\\zagw2k8fs01\users\vranicm\Documents\GitHub\ZIRO\ZIRO\bin\Debug\Reversi\REVERS.docx",
                @"\\zagw2k8fs01\users\vranicm\Documents\GitHub\ZIRO\ZIRO\bin\Debug\Reversi\TestniRevers.docx");
        }
        //Find and Replace Method
        private void Zamjeni(Word.Application wordApp, object ToFindText, object replaceWithText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundLike = false;
            object nmatchAllforms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiactitics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object replace = 2;
            object wrap = 1;

            wordApp.Selection.Find.Execute(ref ToFindText,
                ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundLike,
                ref nmatchAllforms, ref forward,
                ref wrap, ref format, ref replaceWithText,
                ref replace, ref matchKashida,
                ref matchDiactitics, ref matchAlefHamza,
                ref matchControl);
        }

        //Creeate the Doc Method
        private void StvoriDokument(object filename, object SaveAs)
        {
            Word.Application aplikacija = new Word.Application();
            object missing = Missing.Value;
            Word.Document revers = null;

            if (File.Exists((string)filename))
            {
                object readOnly = false;
                object isVisible = false;
                aplikacija.Visible = false;

                revers = aplikacija.Documents.Open(ref filename, ref missing, ref readOnly,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing,
                                        ref missing, ref missing, ref missing, ref missing);
                revers.Activate();

                //find and replace
                Zamjeni(aplikacija, "<datum>", Datum.ToString());
                Zamjeni(aplikacija, "<ImePrezime>", ImePrezime);
                //Zamjeni(aplikacija, "<zaduzenja>", ListaZaduzenja);
                Zamjeni(aplikacija, "<izdano>", IzdanoOd);
                Zamjeni(aplikacija, "<preuzeto>", Zaduzen);
            }
            else
            {
                MessageBox.Show("File not Found!");
            }

            //Save as
            revers.SaveAs2(ref SaveAs, ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing,
                            ref missing, ref missing, ref missing);

            revers.Close();
            aplikacija.Quit();
            MessageBox.Show("File Created!");
        }
    }
}
