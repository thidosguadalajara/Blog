using Blog.Models.Blog.Autor;
using Blog.Models.Blog.Categoria;
using Blog.Models.Etiqueta;
using Blog.Models.Postagem.Revisao;
using System.Collections.Generic;

namespace Blog.Models.Blog.Postagem
{
    public class PostagemEntity
    {
        public string Titulo;
        public AutorEntity Autor;
        public CategoriaEntity Categoria;
        public List<EtiquetaEntity> Etiquetas;
        public List<RevisaoEntity> Revisoes;
    }
}
