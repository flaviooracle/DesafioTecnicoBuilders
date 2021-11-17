using ConsoleApp1.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Repository
{
    public class ArvoreRepository
    {
        private readonly Conexao conexao;
        public ArvoreRepository()
        {
            this.conexao = new Conexao();
        }

        public void GravarArvore(List<Arvorebinaria> listaArvores)
        {
            this.conexao.ConexaoArvore.InsertMany(listaArvores);
        }
    }
}
