﻿
using Economic.Core.Entities;

namespace Economic.Core.Map
{
    public class PrestamoMasterMap : BaseMap<Prestamo_Master>
    {
        public PrestamoMasterMap()
        {
            this.Property(x => x.EstadoId).HasColumnName("EstadoId");
            this.Property(x => x.Fecha_Aprobado).HasColumnName("Fecha_Aprobado");
            this.Property(x => x.Fecha_Solicitud).HasColumnName("Fecha_Solicitud");
            this.Property(x => x.FiadorId).HasColumnName("FiadorId");
            this.Property(x => x.Importe).HasColumnName("Importe");
            this.Property(x => x.Interez_Porciento).HasColumnName("Interez_Pociento");
            this.Property(x => x.Numero_Cuotas).HasColumnName("Numero_Cuotas");
            this.Property(x => x.Plazo_Dias).HasColumnName("Plazo_dias");
            this.Property(x => x.PrestatarioId).HasColumnName("PrestatarioId");
            this.Property(x => x.TipoId).HasColumnName("TipoId");
            this.ToTable("Prestamo_Master", "WEB");
        }
    }
}
