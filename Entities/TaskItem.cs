using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApi.Entities
{
    public class TaskItem
    {
        public long Id { get; set; }

        [Required]
        public string Baslik { get; set; }

        public string Aciklama { get; set; }

        public string Durum { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
