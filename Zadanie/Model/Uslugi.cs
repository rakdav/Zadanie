namespace Zadanie.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Uslugi")]
    public partial class Uslugi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uslugi()
        {
            Vep_usluga = new HashSet<Vep_usluga>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_usluga { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public double cost { get; set; }

        public int kode { get; set; }

        [Column(TypeName = "date")]
        public DateTime deadline { get; set; }

        public double avgotkl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vep_usluga> Vep_usluga { get; set; }
    }
}
