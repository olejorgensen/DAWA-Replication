//-----------------------------------------------------------------------------------------------
// This is auto-generated code.
//-----------------------------------------------------------------------------------------------
// This code was generated by JO Informatik DAWA Replication tool version 1.0.2.0
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
//-----------------------------------------------------------------------------------------------
using Microsoft.SqlServer.Types;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JOInformatik.DawaReplication.DataAccess
{
    /// <summary>TODO.</summary>
    [GeneratedCode("JO Informatik DAWA Replication tool", "version 1.0.2.0")]
    [Table("politikreds")]
    public partial class Politikreds : ReplicationBase
    {
        /// <summary>This constructor calls OnCreated().</summary>
        public Politikreds()
        {
            EntityUpdated = DateTime.Now;
            OnCreated();
        }

        /// <summary>
        /// Tidspunkt for seneste ændring i DAWA
        /// </summary>
        
        [Column("ændret")]
        [Required()]
        public virtual DateTime Ændret { get; set; }

        /// <summary>
        /// Tidspunkt for seneste ændring af geometri i DAWA
        /// </summary>
        
        [Column("geo_ændret")]
        [Required()]
        public virtual DateTime Geo_ændret { get; set; }

        /// <summary>
        /// Versionsangivelse for geometrien. Inkrementeres hver gang geometrien ændrer sig i DAWA.
        /// </summary>
        
        [Column("geo_version")]
        public virtual int? Geo_version { get; set; }

        /// <summary>
        /// Geometriens visuelle center. Kan f.eks. bruges til at placere en label for geometrien på at kort.
        /// </summary>
        
        [Column("visueltcenter")]
        [JsonConverter(typeof(SqlGeometryConverter))]
        public virtual SqlGeometry Visueltcenter { get; set; }

        /// <summary>
        /// Geometriens bounding box, dvs. det mindste rectangel som indeholder geometrien. Består af et array af 4 tal.
        /// De første to tal er koordinaterne for bounding boxens sydvestlige hjørne, og to sidste tal er
        /// koordinaterne for bounding boxens nordøstlige hjørne.
        /// </summary>
        
        [Column("bbox")]
        [JsonConverter(typeof(SqlGeometryConverter))]
        public virtual SqlGeometry Bbox { get; set; }

        /// <summary>
        /// politikredsens geometri.
        /// </summary>
        
        [Column("geometri")]
        [JsonConverter(typeof(SqlGeometryConverter))]
        public virtual SqlGeometry Geometri { get; set; }

        /// <summary>
        /// Unik ID
        /// </summary>
        
        [Column("dagi_id", TypeName = "varchar(36)")]
        [Required()]
        public virtual string Dagi_id { get; set; }

        /// <summary>
        /// DETTE ER PKEY. Politikredsens myndighedskode. Er unik for hver politikreds. 4 cifre.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None), Column("kode", TypeName = "varchar(4)")]
        [Required()]
        public virtual string Kode { get; set; }

        /// <summary>
        /// Politikredsens navn.
        /// </summary>
        
        [Column("navn", TypeName = "varchar(50)")]
        [Required()]
        public virtual string Navn { get; set; }

        /// <summary>Overwrite this method to do your own initialization of the entity.</summary>
        partial void OnCreated();

        /// Returns the primary key as a string (includes all columns).</summary>
        public override string DawaPkey
        {
            get
            {
                if (_dawaPkey == null)
                {
                    _dawaPkey = Kode.ToString();
                }
                return _dawaPkey;
            }
        }

        [Column("entity_updated")]
        [Required()]
        /// <summary>Tidspunktet da rækken blev oprettet eller ændret i databasen hos JOI.</summary>
        public DateTime EntityUpdated { get; set; }

    }
}
