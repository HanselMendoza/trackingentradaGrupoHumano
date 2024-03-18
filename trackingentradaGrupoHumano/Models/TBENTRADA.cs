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

    public partial class TBENTRADA
    {
        public int IDENTRADA { get; set; }
        public Nullable<int> IDDEPART { get; set; }
        public Nullable<int> IDOCUPACION { get; set; }
        public Nullable<int> IDMOTIVOENTRADA { get; set; }

        [DisplayName("C�dula")]
        public string CEDULA { get; set; }
        [DisplayName("Nombre del visitante")]
        public string NOMBRES { get; set; }
        [DisplayName("Apellido del visitante")]
        public string APELLIDOS { get; set; }
        [DisplayName("Fecha de entrada del visitante")]
        public Nullable<System.DateTime> FECHAENTRADA { get; set; }
        [DisplayName("Tiempo estimado")]
        public string TiempoESTIMADO { get; set; }
        [DisplayName("�Cita pre�a?")]
        public Nullable<int> TENIACITA { get; set; }
        [DisplayName("Accedi� a la localidad?")]
        public Nullable<int> Entro { get; set; }
        public Nullable<int> Localidad { get; set; }
        public Nullable<int> vpresidencial { get; set; }
        [DisplayName("Nivel")]
        public Nullable<int> PISO { get; set; }
        [DisplayName("Ubicaci�n")]
        public Nullable<int> COORDENADA { get; set; }
        [DisplayName("C�digo del empleado anfitri�n")]
        public Nullable<int> codigoempleado { get; set; }
        [DisplayName("Nombre del anfitri�n")]
        public string NombreAnfitrion { get; set; }
        [DisplayName("Hora de entrada")]
        public string HORAENTRADA { get; set; }
        [DisplayName("Hora de salida")]
        public string HORASALIDA { get; set; }
        public Nullable<int> EstadoSolicitud { get; set; }
    
        public virtual CONFIGURACION CONFIGURACION { get; set; }
        public virtual CONFIGURACION CONFIGURACION1 { get; set; }
        public virtual CONFIGURACION CONFIGURACION2 { get; set; }
        public virtual TBDEPARTAMENTO TBDEPARTAMENTO { get; set; }
        public virtual TBMOTIVOENTRADA TBMOTIVOENTRADA { get; set; }
        public virtual TBOCUPACION TBOCUPACION { get; set; }
        [DisplayName("Localidad")]
        public virtual tblocalidad tblocalidad { get; set; }
        public virtual CONFIGURACION CONFIGURACION3 { get; set; }
        public virtual TBCOORDENADA TBCOORDENADA { get; set; }
        public virtual TBPISO TBPISO { get; set; }
        public virtual estado estado { get; set; }
    }
}