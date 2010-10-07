using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DojoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class ProcessadorDeVotos
    {
        public int Processa(Urna urna)
        {
            //if (urna.ListaDeVotos[0][0] == 1)
            //{
            //    return 1;
            //}
            //return 2;
            for (int i = 0; i < urna.ListaDeVotos.Count; i++)
            {
                List<int> voto = urna.ListaDeVotos[i];
                for (int i = 0; i < voto.Count; i++)
                {
                    
                }
            }
        }
    }
    public class Urna
    {
        public Urna()
        {
            ListaDeVotos = new List<List<int>>();
        }
        
        public void InserirVoto(List<int> listaDeVotos)
        {
            ListaDeVotos.Add(listaDeVotos);
        }
        
        public List<List<int>> ListaDeVotos { get; set; }
    }
}
