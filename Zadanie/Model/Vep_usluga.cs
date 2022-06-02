namespace Zadanie.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Vep_usluga
    {
        [Key]
        public int id_vip_usluga { get; set; }

        public int id_zakaz { get; set; }

        public int id_lab { get; set; }

        public int id_usluga { get; set; }

        public int id_analizator { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }

        public virtual Analyzator Analyzator { get; set; }

        public virtual Laborants Laborants { get; set; }

        public virtual Uslugi Uslugi { get; set; }

        public virtual Zakaz Zakaz { get; set; }
    }
}
