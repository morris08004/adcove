using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
    public class Vehiculos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column(TypeName = "bigint", iIdVehiculo = 0)]
        [Column(TypeName = "bigint", Order = 0)]
        public Int64 IddVehiculo { get; set; }
        public Int32 IidMarca { get; set; }
        public Int32 IidTipoVhiculo { get; set; }
        public string Ccolor { get; set; }
        public string CnumInventario { get; set; }
        public string CserieMotor { get; set; }
        public string Cserie { get; set; }
        public Int32 InumeroCilindro { get; set; }
        public Int32 IRendimientoLitro { get; set; }
        public DateTime DaProximaAfinacion { get; set; }
        public Int32 Ikilometraje { get; set; }
        public string CfolioPlaca { get; set; }
        public Int32 IidPoliza { get; set; }
        public Int32 IidResguardo { get; set; }
        public Int32 IidConductor { get; set; }
        public Int32 IidEstatus { get; set; }
        public Int32 IidProveedor { get; set; }
        public DateTime DaArrendamiento { get; set; }
        public DateTime DaRegistro { get; set; }
        public Int32 IhoraRegistro { get; set; }
        public string CidUsuario { get; set; }
        public Int32 Imodelo { get; set; }
        public Int32 IidTipoAdquisicion { get; set; }
        public Int32 IlitroKmHr { get; set; }

    }
    public class areaservicio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "bigint", Order = 0)]
        public Int64 iIdAreaServicio { get; set; }
        public string cNombre { get; set; }
        public string cObservaciones { get; set; }
        public string cInicial { get; set; }
        public string cResponsable { get; set; }
        public DateTime daRegistro { get; set; }
        public Int32 iHoraRegistro { get; set; }
        public string cIdUsuario { get; set; }
    }
    public class conductor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "bigint", Order = 0)]
        public Int64 iIdConductor { get; set; }
        public string cNombre { get; set; }
        public Int32 iIdtipo { get; set; }
        public string cLicenciaFolio { get; set; }
        public DateTime daInicia { get; set; }
        public DateTime daTermina { get; set; }
        public string cObservaciones { get; set; }
        public string daRegistro { get; set; }
        public Int32 iHoraRegistro { get; set; }
        public string cIdUsuario { get; set; }
        public Int32 iHoraInicia { get; set; }
        public Int32 iHoraTermina { get; set; }
    }
    public class niveleducativo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "bigint", Order = 0)]
        public Int64 iNodo { get; set; }
        public Int32 iPadre { get; set; }
        public string cNombre { get; set; }
        public DateTime daRegistro { get; set; }
        public Int32 iHoraRegistro { get; set; }
        public string cIdUsuario { get; set; }
    }
   
    public class resguardo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "bigint", Order = 0)]
        public Int64 iIdResguardo { get; set; }
        public Int32 iNodo { get; set; }
        public Int32 iAreaServicio { get; set; }
        public string cResponsable { get; set; }
        public DateTime daRegistro { get; set; }
        public Int32 iHoraRegistro { get; set; }
        public string cIdusuario { get; set; }
    }
    public class tipogenerico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "bigint", Order = 0)]
        public Int64 iIdTipo { get; set; }
        public string cDescripcion { get; set; }
        public string ctipo { get; set; }
        public DateTime daRegistro { get; set; }
        public Int32 iHoraRegistro { get; set; }
        public string cIdUsuario { get; set; }
    }
    public class usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      //  [Column(TypeName = "string", cIdUsuario = 0)]
        public string cIdUsuario { get; set; }
        public string cNombre { get; set; }
        public Int32 iTipo { get; set; }
        public DateTime daRegistro { get; set; }
        public Int32 iHoraRegistro { get; set; }
        public string cPassword { get; set; }
    }
}
