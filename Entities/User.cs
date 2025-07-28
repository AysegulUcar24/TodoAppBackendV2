using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Entities
{
    public class User
    {
        public long Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Sifre { get; set; }

        public ICollection<TaskItem> Gorevler { get; set; }
    }
}