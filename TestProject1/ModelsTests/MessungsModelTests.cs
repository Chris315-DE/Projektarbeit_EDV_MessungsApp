using Projektarbeit_EDV_Messung_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.ModelsTests
{

    public class MessungsModelTests
    {
        /// <summary>
        /// Testet ob bei Maximalen Grenzwerten die Prüfung erfolgreich Bestanden wird
        /// Komma Schreibweise 
        /// </summary>
        [Fact]
        public void Teste_MessungsModel_Liefert_Richtige_Ergebnisse()
        {
            var Sut = new MessungsModel()
            {
                GeräteNummer = "Test1",
                RPE = 0.19F,
                IEA = 0.49F,
            };

            Assert.True(Sut.SetzeErgebniss());


        }
        /// <summary>
        /// Testet ob bei Maximalen Grenzwerten die Prüfung erfolgreich Bestanden wird
        /// Kommalose Schreibweise 
        /// </summary>

        [Fact]

        public void Teste_MessungsModel_Lifert_Richtige_Ergebnisse_Ohne_Komma()
        {
            var sut = new MessungsModel()
            {

                GeräteNummer = "Test1",
                RPE = 19F,
                IEA = 49F,
            };

            Assert.True(sut.SetzeErgebniss());
        }

        /// <summary>
        /// Testet ob  die Prüfung Fehlschlägt bei überschreitung  des RPE Grenzwertes
        /// Kommalose Schreibweise 
        /// </summary>
        [Fact]
        public void Teste_MessungsModel_Lifert_NichtBestanden_Ohne_Komma_RPE_Zuhoch()
        {
            var sut = new MessungsModel()
            {

                GeräteNummer = "Test1",
                RPE = 30F,
                IEA = 49F,
            };

            Assert.False(sut.SetzeErgebniss());

        }

        /// <summary>
        /// Testet ob  die Prüfung Fehlschlägt bei überschreitung  des IEA Grenzwertes
        /// Kommalose Schreibweise 
        /// </summary>

        [Fact]
        public void Teste_MessungsModel_Lifert_NichtBestanden_Ohne_Komma_IEA_Zuhoch()
        {
            var sut = new MessungsModel()
            {

                GeräteNummer = "Test1",
                RPE = 29F,
                IEA = 50F,
            };

            Assert.False(sut.SetzeErgebniss());

        }


        /// <summary>
        /// Testet ob  die Prüfung Fehlschlägt bei überschreitung  des RPE Grenzwertes
        /// Komma Schreibweise 
        /// </summary>
        [Fact]
        public void Teste_MessungsModel_Lifert_NichtBestanden_mit_Komma_RPE_Zuhoch()
        {
            var sut = new MessungsModel()
            {

                GeräteNummer = "Test1",
                RPE = 30F,
                IEA = 49F,
            };

            Assert.False(sut.SetzeErgebniss());

        }

        /// <summary>
        /// Testet ob  die Prüfung Fehlschlägt bei überschreitung  des IEA Grenzwertes
        /// Komma Schreibweise 
        /// </summary>

        [Fact]
        public void Teste_MessungsModel_Lifert_NichtBestanden_mit_Komma_IEA_Zuhoch()
        {
            var sut = new MessungsModel()
            {

                GeräteNummer = "Test1",
                RPE = 0.29F,
                IEA = 0.50F,
            };

            Assert.False(sut.SetzeErgebniss());

        }
    }
}
