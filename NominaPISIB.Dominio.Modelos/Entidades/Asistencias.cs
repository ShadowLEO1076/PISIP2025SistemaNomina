﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NominaPISIB.Infraestructura.AccesoDatos;

public partial class Asistencias
{
    public int idAsistencia { get; set; }

    public int? FKidEmpleado { get; set; }

    public DateOnly AsistenciaFecha { get; set; }
    [JsonIgnore]
    public virtual Empleados FKidEmpleadoNavigation { get; set; }
}