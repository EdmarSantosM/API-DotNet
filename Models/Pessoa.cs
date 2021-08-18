using System.ComponentModel.DataAnnotations;

namespace API_DotNet.Models
{
    public class Pessoa
    {
        [Key]
        public int Id{ get; set;}  /* get extrai  informção,  set  envia informação */
        public string Name { get; set; }
        public string Cidade { get; set; }
        public int Idade { get; set; }
        
        
        
        
        
        
    }
}