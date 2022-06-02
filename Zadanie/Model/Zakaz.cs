namespace Zadanie.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Zakaz")]
    public partial class Zakaz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zakaz()
        {
            Vep_usluga = new HashSet<Vep_usluga>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_zakaz { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        [Required]
        [StringLength(50)]
        public string status { get; set; }

        public int id_pacient { get; set; }

        public int time_zakaz { get; set; }

        public virtual Pacient Pacient { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vep_usluga> Vep_usluga { get; set; }
    }
}
