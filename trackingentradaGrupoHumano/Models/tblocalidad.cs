//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace trackingentradaGrupoHumano.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tblocalidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblocalidad()
        {
            this.TBENTRADAs = new HashSet<TBENTRADA>();
        }
        
        [DisplayName("Identificador localidad")]
        public int id { get; set; }
        [StringLength(24, MinimumLength = 3)]
        [Required]
        [DisplayName("Descripci�n localidad")]
        public string descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBENTRADA> TBENTRADAs { get; set; }
    }
}