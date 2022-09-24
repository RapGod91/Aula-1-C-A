// ---------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by LinqToDB scaffolding tool (https://github.com/linq2db/linq2db).
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
// ---------------------------------------------------------------------------------------------------

using LinqToDB.Mapping;

#pragma warning disable 1573, 1591
#nullable enable

namespace Class1
{
  [Table("AstralBodies")]
  public class AstralBody
  {
    [Column("Body", CanBeNull = false, IsPrimaryKey = true)] public string Body { get; set; } = null!; // text(max)
    [Column("Radius_km")] public double? RadiusKm { get; set; } // real
    [Column("Volume_e9_km3")] public double? VolumeE9Km3 { get; set; } // real
    [Column("Mass_e21_kg")] public double? MassE21Kg { get; set; } // real
    [Column("Surface_Area_km2")] public double? SurfaceAreaKm2 { get; set; } // real
    [Column("Density_g_cm3")] public double? DensityGCm3 { get; set; } // real
    [Column("Gravity_m_s2")] public double? GravityMS2 { get; set; } // real
    [Column("Type")] public string? Type { get; set; } // text(max)
    [Column("Parent_body")] public string? ParentBody { get; set; } // text(max)
    [Column("Discovery")] public string? Discovery { get; set; } // text(max)
  }
}