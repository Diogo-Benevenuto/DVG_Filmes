﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DVG_FilmesWeb.Model
{
    [Table("TBCategorias")]
    public partial class Tbcategorias
    {
        public Tbcategorias()
        {
            Tbfilmes = new HashSet<Tbfilmes>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        [Unicode(false)]
        public string Descricao { get; set; }

        [InverseProperty("IdCategoriaNavigation")]
        public virtual ICollection<Tbfilmes> Tbfilmes { get; set; }
    }
}