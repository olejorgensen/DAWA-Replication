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
    [Table("menighedsrådsafstemningsområdetilknytning")]
    public partial class Menighedsrådsafstemningsområdetilknytning : ReplicationBase
    {
        /// <summary>This constructor calls OnCreated().</summary>
        public Menighedsrådsafstemningsområdetilknytning()
        {
            EntityUpdated = DateTime.Now;
            OnCreated();
        }

        /// <summary>
        /// DETTE ER EN DEL AF PKEY. Adgangsadressens id.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None), Column("adgangsadresseid", Order = 0)]
        [Required()]
        public virtual Guid Adgangsadresseid { get; set; }

        /// <summary>
        /// DETTE ER EN DEL AF PKEY. Kommunekoden for den kommune, som menighedsrådsafstemningsmrådet tilhører.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None), Column("kommunekode", Order = 1, TypeName = "varchar(4)")]
        [Required()]
        public virtual string Kommunekode { get; set; }

        /// <summary>
        /// DETTE ER EN DEL AF PKEY. Menighedsrådsafstemningsområdets nummer. Udgør nøglen.
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None), Column("menighedsrådsafstemningsområdenummer", Order = 2, TypeName = "varchar(2)")]
        [Required()]
        public virtual string Menighedsrådsafstemningsområdenummer { get; set; }

        /// <summary>Overwrite this method to do your own initialization of the entity.</summary>
        partial void OnCreated();

        /// Returns the primary key as a string (includes all columns).</summary>
        public override string DawaPkey
        {
            get
            {
                if (_dawaPkey == null)
                {
                    _dawaPkey = Adgangsadresseid.ToString() + "_" + Kommunekode.ToString() + "_" + Menighedsrådsafstemningsområdenummer.ToString();
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
