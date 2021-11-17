using ConsoleApp1.Entidades;
using ConsoleApp1.Repository;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arvore binária....");

            List<Arvorebinaria> floresta = new List<Arvorebinaria>();
            string palavra = "MENTALIZABORIU"; 

             Node raiz = new Node("X",0);
            int contador = 0;
            foreach(char letra in palavra)
            {
                contador++;
                Arvorebinaria itemArvore = raiz.put(letra.ToString(), contador);
                floresta.Add(itemArvore);
            }
            Console.WriteLine("Grando no Mongo DB a árvore");
            Gravar_NoMongoDb_Arvore(floresta);
            Console.WriteLine("");
        }

        private static void Gravar_NoMongoDb_Arvore(List<Arvorebinaria> floresta)
        {
            var executaGravar = new ArvoreRepository();
            executaGravar.GravarArvore(floresta);
        }
    }
}
