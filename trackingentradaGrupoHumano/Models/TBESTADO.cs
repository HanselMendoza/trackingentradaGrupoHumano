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
    
    public partial class TBESTADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBESTADO()
        {
            this.TBCOORDENADAs = new HashSet<TBCOORDENADA>();
            this.TBDEPARTAMENTOes = new HashSet<TBDEPARTAMENTO>();
            this.TBMOTIVOENTRADAs = new HashSet<TBMOTIVOENTRADA>();
            this.TBOCUPACIONs = new HashSet<TBOCUPACION>();
            this.TBPERSONAs = new HashSet<TBPERSONA>();
            this.TBPISOes = new HashSet<TBPISO>();
        }
    
        public int IDESTADO { get; set; }
        public string NOMBRE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBCOORDENADA> TBCOORDENADAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBDEPARTAMENTO> TBDEPARTAMENTOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBMOTIVOENTRADA> TBMOTIVOENTRADAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBOCUPACION> TBOCUPACIONs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBPERSONA> TBPERSONAs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBPISO> TBPISOes { get; set; }
    }
}