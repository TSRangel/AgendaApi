﻿using System.ComponentModel.DataAnnotations;

namespace AgendaApi.Domain.Entities
{
    public class SuperAdmin
    {
        [Key]
        public Guid SuperAdminId { get; set; }
        [Required]
        [StringLength(70)]
        public string? Email { get; set; }
        [Required]
        [StringLength(30)]
        public string? Password { get; set; }
    }
}
