using ConsoleApp1.Entidades;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Repository
{
    public class Conexao
    {
        public IMongoCollection<Arvorebinaria> ConexaoArvore { get; set; }
        public Conexao()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("FLarestas");
            this.ConexaoArvore = database.GetCollection<Arvorebinaria>("ArvoresBinarias");
        }
       
    }
}
