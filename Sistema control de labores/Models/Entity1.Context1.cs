﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sistema_control_de_labores.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class sisContLabEntities : DbContext
    {
        public sisContLabEntities()
            : base("name=sisContLabEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TSCL_Proceso> TSCL_Proceso { get; set; }
        public virtual DbSet<TSCL_SubProceso> TSCL_SubProceso { get; set; }
        public virtual DbSet<TSCL_Usuario> TSCL_Usuario { get; set; }
        public virtual DbSet<TSCL_Reporte_Usuario> TSCL_Reporte_Usuario { get; set; }
        public virtual DbSet<TSCL_SolSubPCol> TSCL_SolSubPCol { get; set; }
    
        public virtual int PA_Actualiza_Proceso(Nullable<int> id_Proceso, string nomProceso)
        {
            var id_ProcesoParameter = id_Proceso.HasValue ?
                new ObjectParameter("id_Proceso", id_Proceso) :
                new ObjectParameter("id_Proceso", typeof(int));
    
            var nomProcesoParameter = nomProceso != null ?
                new ObjectParameter("nomProceso", nomProceso) :
                new ObjectParameter("nomProceso", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Actualiza_Proceso", id_ProcesoParameter, nomProcesoParameter);
        }
    
        public virtual int PA_Actualiza_SubProceso(Nullable<int> id_SubProceso, string nomSubProceso)
        {
            var id_SubProcesoParameter = id_SubProceso.HasValue ?
                new ObjectParameter("id_SubProceso", id_SubProceso) :
                new ObjectParameter("id_SubProceso", typeof(int));
    
            var nomSubProcesoParameter = nomSubProceso != null ?
                new ObjectParameter("nomSubProceso", nomSubProceso) :
                new ObjectParameter("nomSubProceso", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Actualiza_SubProceso", id_SubProcesoParameter, nomSubProcesoParameter);
        }
    
        public virtual ObjectResult<PA_Consulta_Todos_Proceso_Result> PA_Consulta_Todos_Proceso()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_Consulta_Todos_Proceso_Result>("PA_Consulta_Todos_Proceso");
        }
    
        public virtual ObjectResult<PA_Consulta_Todos_SubProceso_Result> PA_Consulta_Todos_SubProceso()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_Consulta_Todos_SubProceso_Result>("PA_Consulta_Todos_SubProceso");
        }
    
        public virtual int PA_Elimina_Proceso(Nullable<int> id_Proceso)
        {
            var id_ProcesoParameter = id_Proceso.HasValue ?
                new ObjectParameter("id_Proceso", id_Proceso) :
                new ObjectParameter("id_Proceso", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Elimina_Proceso", id_ProcesoParameter);
        }
    
        public virtual int PA_Elimina_SubProceso(Nullable<int> id_SubProceso)
        {
            var id_SubProcesoParameter = id_SubProceso.HasValue ?
                new ObjectParameter("id_SubProceso", id_SubProceso) :
                new ObjectParameter("id_SubProceso", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Elimina_SubProceso", id_SubProcesoParameter);
        }
    
        public virtual ObjectResult<PA_Inserta_SubProceso_Result> PA_Inserta_SubProceso(Nullable<int> id_Proceso, string nom_SubProceso)
        {
            var id_ProcesoParameter = id_Proceso.HasValue ?
                new ObjectParameter("id_Proceso", id_Proceso) :
                new ObjectParameter("id_Proceso", typeof(int));
    
            var nom_SubProcesoParameter = nom_SubProceso != null ?
                new ObjectParameter("nom_SubProceso", nom_SubProceso) :
                new ObjectParameter("nom_SubProceso", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PA_Inserta_SubProceso_Result>("PA_Inserta_SubProceso", id_ProcesoParameter, nom_SubProcesoParameter);
        }
    
        public virtual int PA_InsertarProceso(string nomProceso)
        {
            var nomProcesoParameter = nomProceso != null ?
                new ObjectParameter("nomProceso", nomProceso) :
                new ObjectParameter("nomProceso", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_InsertarProceso", nomProcesoParameter);
        }
    
        public virtual int PA_InsertarReporte(Nullable<int> idUsuario, Nullable<int> idSubProceso, Nullable<System.DateTime> fechaTarea, Nullable<int> cantidad)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("idUsuario", idUsuario) :
                new ObjectParameter("idUsuario", typeof(int));
    
            var idSubProcesoParameter = idSubProceso.HasValue ?
                new ObjectParameter("idSubProceso", idSubProceso) :
                new ObjectParameter("idSubProceso", typeof(int));
    
            var fechaTareaParameter = fechaTarea.HasValue ?
                new ObjectParameter("fechaTarea", fechaTarea) :
                new ObjectParameter("fechaTarea", typeof(System.DateTime));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("cantidad", cantidad) :
                new ObjectParameter("cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_InsertarReporte", idUsuarioParameter, idSubProcesoParameter, fechaTareaParameter, cantidadParameter);
        }
    
        public virtual int PA_Insertar_SolSubCol(Nullable<int> idSolicitante, Nullable<int> idDestino, Nullable<int> idSubProceso, Nullable<System.DateTime> fechaCreacion)
        {
            var idSolicitanteParameter = idSolicitante.HasValue ?
                new ObjectParameter("idSolicitante", idSolicitante) :
                new ObjectParameter("idSolicitante", typeof(int));
    
            var idDestinoParameter = idDestino.HasValue ?
                new ObjectParameter("idDestino", idDestino) :
                new ObjectParameter("idDestino", typeof(int));
    
            var idSubProcesoParameter = idSubProceso.HasValue ?
                new ObjectParameter("idSubProceso", idSubProceso) :
                new ObjectParameter("idSubProceso", typeof(int));
    
            var fechaCreacionParameter = fechaCreacion.HasValue ?
                new ObjectParameter("fechaCreacion", fechaCreacion) :
                new ObjectParameter("fechaCreacion", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PA_Insertar_SolSubCol", idSolicitanteParameter, idDestinoParameter, idSubProcesoParameter, fechaCreacionParameter);
        }
    }
}
