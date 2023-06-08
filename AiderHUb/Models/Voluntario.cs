using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiderHub.Models
{
    [Table("voluntario")]
    public class Voluntario
    {
        [Key]
        [Column("id_voluntario")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }
        [Column("cpf")]
        public string Cpf { get; set; }
        [Column("endereco")]
        public string Endereco { get; set; }
        [Column("formacao")]
        public int Formacao { get; set; }
        [Column("sobre")]
        public string Sobre { get; set; }
        [Column("interesses")]
        public string Interesses { get; set; }
        [Column("historico_eventos")]
        public string Historico { get; set; }   
        [Column("proximos_eventos")]
        public string ProximosEventos { get; set; }
        [Column("telefone")]
        public string Telefone { get; set; }
        [Column("foto_logo")]
        public byte Foto { get; set; }

        public Voluntario() { }

        public Voluntario(int Id, string Nome, DateTime DataNascimento, string Cpf, string Endereco, int Formacao, string Sobre, string Interesses, string Historico, string ProximosEventos, string Telefone, byte Foto )
        {
            
        }

    }
}
