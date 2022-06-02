namespace Zadanie.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Schet")]
    public partial class Schet
    {
        [Key]
        public int id_schet { get; set; }

        public int id_company { get; set; }

        public int id_buh { get; set; }

        public double cost { get; set; }

        public virtual buhgalters buhgalters { get; set; }

        public virtual Company Company { get; set; }
    }
}
