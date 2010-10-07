using DojoApp;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass()]
    public class ProgramTest
    {
        private TestContext testContextInstance;
        private ProcessadorDeVotos processadorVotos;
        private Urna urna;

        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        [TestInitialize()]
        public void MyTestInitialize()
        {
            processadorVotos = new ProcessadorDeVotos();
            urna = new Urna();
        }

        [TestMethod()]
        public void TestaUmCandidato_EleGanha()
        {
            List<int> votoEleitor1 = new List<int>();
            votoEleitor1.Add(1);
            urna.InserirVoto(votoEleitor1);
            
            Assert.AreEqual(1, processadorVotos.Processa(urna));
        }

        [TestMethod()]
        public void TestaDoisCandidatos_MaisVotosProPrimeiro_PrimeiroGanha()
        {
            List<int> votoEleitor1 = new List<int>();
            votoEleitor1.Add(1);
            votoEleitor1.Add(2);
            urna.InserirVoto(votoEleitor1);

            Assert.AreEqual(1, processadorVotos.Processa(urna));
        }

        [TestMethod()]
        public void TestaDoisCandidatos_MaisVotosProSegundo_SegundoGanha()
        {
            List<int> votoEleitor1 = new List<int>();
            votoEleitor1.Add(2);
            votoEleitor1.Add(1);
            urna.InserirVoto(votoEleitor1);

            Assert.AreEqual(2, processadorVotos.Processa(urna));
        }

        [TestMethod()]
        public void TestaDoisCandidatos_DoisVotos_MaisVotosProSegundo_SegundoGanha()
        {
            List<int> votoEleitor1 = new List<int>();
            votoEleitor1.Add(2);
            votoEleitor1.Add(1);
            urna.InserirVoto(votoEleitor1);

            List<int> votoEleitor2 = new List<int>();
            votoEleitor2.Add(2);
            votoEleitor2.Add(1);
            urna.InserirVoto(votoEleitor2);

            Assert.AreEqual(2, processadorVotos.Processa(urna));
        }

        [TestMethod()]
        public void TestaDoisCandidatos_DoisVotos_MaisVotosProPrimeiro_PrimeiroGanha()
        {
            List<int> votoEleitor1 = new List<int>();
            votoEleitor1.Add(1);
            votoEleitor1.Add(2);
            urna.InserirVoto(votoEleitor1);

            List<int> votoEleitor2 = new List<int>();
            votoEleitor2.Add(1);
            votoEleitor2.Add(2);
            urna.InserirVoto(votoEleitor2);

            Assert.AreEqual(1, processadorVotos.Processa(urna));
        }


        [TestMethod()]
        public void TestaDoisCandidatos_DoisVotos_NinguemGanha()
        {
            List<int> votoEleitor1 = new List<int>();
            votoEleitor1.Add(1);
            votoEleitor1.Add(2);
            urna.InserirVoto(votoEleitor1);

            List<int> votoEleitor2 = new List<int>();
            votoEleitor2.Add(2);
            votoEleitor2.Add(1);
            urna.InserirVoto(votoEleitor2);

            Assert.AreEqual(-1, processadorVotos.Processa(urna));
        }
    }
}
