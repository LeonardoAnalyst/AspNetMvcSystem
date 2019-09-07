using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime UltimaCompra { get; set; }
        public decimal Preco { get; set; }
        public float Estoque { get; set; }
    }
}