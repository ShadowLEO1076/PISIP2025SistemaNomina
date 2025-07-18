﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NominaPISIB.Infraestructura.AccesoDatos;

public partial class Empleados
{
    public int idEmpleado { get; set; }

    public int? FKidPuesto { get; set; }

    public string EmpleadoNombres { get; set; }

    public string EmpleadoApellidos { get; set; }

    public string EmpleadoCedula { get; set; }

    public string EmpleadoCorreo { get; set; }

    public DateOnly EmpleadoFechaNacimiento { get; set; }

    public string EmpleadoEstado { get; set; }

    public string EmpleadoGenero { get; set; }

    public string EmpleadoTelfPersonal { get; set; }

    public DateOnly EmpleadoFechaIngreso { get; set; }
    [JsonIgnore]
    public virtual ICollection<Asistencias> Asistencias { get; set; } = new List<Asistencias>();
    [JsonIgnore]
    public virtual ICollection<Bonificaciones> Bonificaciones { get; set; } = new List<Bonificaciones>();
    [JsonIgnore]
    public virtual ICollection<Contratos> Contratos { get; set; } = new List<Contratos>();
    [JsonIgnore]
    public virtual ICollection<Descuentos> Descuentos { get; set; } = new List<Descuentos>();
    [JsonIgnore]
    public virtual EmpleadosVacacionesTotales EmpleadosVacacionesTotales { get; set; }
    [JsonIgnore]
    public virtual Puestos FKidPuestoNavigation { get; set; }
    [JsonIgnore]
    public virtual ICollection<Inasistencias> Inasistencias { get; set; } = new List<Inasistencias>();
    [JsonIgnore]
    public virtual ICollection<Nominas> Nominas { get; set; } = new List<Nominas>();
    [JsonIgnore]
    public virtual ICollection<SolicitudVacaciones> SolicitudVacaciones { get; set; } = new List<SolicitudVacaciones>();
}