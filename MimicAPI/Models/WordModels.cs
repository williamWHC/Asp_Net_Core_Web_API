using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MimicAPI.Models
{
    public class WordModels
    {
        public int id { get; set; }

        public string name { get; set; }

        public int ponctuation { get; set; } //pontuacao
        //verifica se a plalavra esta ativa
        public bool active { get; set; }    //ativo
        //data da criação da palavra
        public DateTime servant { get; set; } //criado
        //data da atualização 
        public DateTime updated { get; set; } //atualizar
    }
}
