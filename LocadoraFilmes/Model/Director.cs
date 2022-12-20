using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraFilmes.Model
{
    public class Director
    {
        public string DirectorID { get; set; }
        [MaxLength(20, ErrorMessage = "O tamanho não pode ser maior do que 20")]
        public string DirectorFullName { get; set; }
        public int DirectorAge { get; set; }

    }
}
