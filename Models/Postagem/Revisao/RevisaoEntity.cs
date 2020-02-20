using Blog.Models.Blog.Postagem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models.Postagem.Revisao
{
    public class RevisaoEntity 
    {
        public PostagemEntity Postagem;
        public string Texto;
        public int Versao;
        public DateTime Data;


    }
}
