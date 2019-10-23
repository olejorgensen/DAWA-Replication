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
    [Table("vejstykke")]
    public partial class Vejstykke : ReplicationBase
    {
        /// <summary>This constructor calls OnCreated().</summary>
        public Vejstykke()
        {
            EntityUpdated = DateTime.Now;
            OnCreated();
        }

        /// <summary>
        /// Vejstykkets unikke ID (UUID).
        /// </summary>
        
        [Column("id", TypeName = "varchar(38)")]
        [Required()]
        public virtual string Id { get; set; }

        /// <summary>
        /// DETTE ER EN DEL AF PKEY. Kommunekoden. 4 cifre.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None), Column("kommunekode", Order = 0, TypeName = "varchar(4)")]
        [Required()]
        public virtual string Kommunekode { get; set; }

        /// <summary>
        /// DETTE ER EN DEL AF PKEY. Identifikation af vejstykke. Er unikt indenfor den pågældende kommune. Repræsenteret ved fire cifre. Eksempel: I Københavns kommune er ”0004” lig ”Abel Cathrines Gade”.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None), Column("kode", Order = 1, TypeName = "varchar(4)")]
        [Required()]
        public virtual string Kode { get; set; }

        /// <summary>
        /// Oprettelsestidspunktet for vejstykket, som registreret i DAR.
        /// </summary>
        
        [Column("oprettet")]
        public virtual DateTime? Oprettet { get; set; }

        /// <summary>
        /// DEPRECATED. Feltet opdateres ikke længere.
        /// </summary>
        
        [Column("ændret")]
        public virtual DateTime? Ændret { get; set; }

        /// <summary>
        /// Vejens navn som det er fastsat og registreret af kommunen. Repræsenteret ved indtil 40 tegn. Eksempel: ”Hvidkildevej”.
        /// </summary>
        
        [Column("navn", TypeName = "varchar(40)")]
        public virtual string Navn { get; set; }

        /// <summary>
        /// En evt. forkortet udgave af vejnavnet på højst 20 tegn, som bruges ved adressering på labels og rudekuverter og lign., hvor der ikke plads til det fulde vejnavn.
        /// </summary>
        
        [Column("adresseringsnavn", TypeName = "varchar(30)")]
        public virtual string Adresseringsnavn { get; set; }

        /// <summary>
        /// Den navngivne vej, som vejstykket tilhører
        /// </summary>
        
        [Column("navngivenvej_id")]
        [Required()]
        public virtual Guid Navngivenvej_id { get; set; }

        /// <summary>Overwrite this method to do your own initialization of the entity.</summary>
        partial void OnCreated();

        /// Returns the primary key as a string (includes all columns).</summary>
        public override string DawaPkey
        {
            get
            {
                if (_dawaPkey == null)
                {
                    _dawaPkey = Kommunekode.ToString() + "_" + Kode.ToString();
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