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
    [Table("bbr_opgang_historik")]
    public partial class Bbr_opgang_historik : ReplicationBase
    {
        /// <summary>This constructor calls OnCreated().</summary>
        public Bbr_opgang_historik()
        {
            EntityUpdated = DateTime.Now;
            OnCreated();
        }

        /// <summary>
        /// DETTE ER PKEY. Unik ID for den angivne række. 
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.None), Column("rowkey")]
        [Required()]
        public virtual int Rowkey { get; set; }

        /// <summary>
        /// Startidspunktet for rækkens virkningstid.
        /// </summary>
        
        [Column("virkningstart")]
        [Required()]
        public virtual DateTime Virkningstart { get; set; }

        /// <summary>
        /// Sluttidspunktet for rækkens virkningstid. 
        /// </summary>
        
        [Column("virkningslut")]
        public virtual DateTime? Virkningslut
        {
            get { return _Virkningslut.GetValueOrDefault(Defaults.Virkningslut); }
            set { _Virkningslut = value; }
        }
        private DateTime? _Virkningslut;

        /// <summary>
        /// Kode for den forretningshændelse, som afstedkom opdateringen af bygværkselementet til den pågældende version For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/Forretningshaendelse">kodelisten.</a>
        /// </summary>
        
        [Column("forretningshændelse", TypeName = "varchar(50)")]
        public virtual string Forretningshændelse { get; set; }

        /// <summary>
        /// FORM-kode for det offentlige forretningsområde som har opdateret bygværkselementet til den pågældende version For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/ForretningsOmraade">kodelisten.</a>
        /// </summary>
        
        [Column("forretningsområde", TypeName = "varchar(15)")]
        public virtual string Forretningsområde { get; set; }

        /// <summary>
        /// Kode for den forretningshændelse, som afstedkom opdateringen af bygværkselementet til den pågældende version For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/ForretningsProcess">kodelisten.</a>
        /// </summary>
        
        [Column("forretningsproces", TypeName = "varchar(2)")]
        public virtual string Forretningsproces { get; set; }

        /// <summary>
        /// Unik og uforanderlig identifikation af bygværkselementet igennem hele dets livscyklus
        /// </summary>
        
        [Column("id")]
        public virtual Guid? Id { get; set; }

        /// <summary>
        /// Kode der identificerer den kommune som bygværkselementet hidhører For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/Kommunekode">kodelisten.</a>
        /// </summary>
        
        [Column("kommunekode", TypeName = "varchar(4)")]
        public virtual string Kommunekode { get; set; }

        /// <summary>
        /// Kode som angiver hvilken aktør der har foretaget registreringen af den pågældende version af bygværkselementet
        /// </summary>
        
        [Column("registreringsaktør", TypeName = "varchar(90)")]
        public virtual string Registreringsaktør { get; set; }

        /// <summary>
        /// Kode for bygværkselementets status i den pågældende version, dvs. elementets tilstand i den samlede livscyklus For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/Livscyklus">kodelisten.</a>
        /// </summary>
        
        [Column("status", TypeName = "varchar(2)")]
        public virtual string Status { get; set; }

        /// <summary>
        /// Kode for den aktør der har afstedkommet virkningsegenskaberne for den pågældende version af bygværkselementet For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/Virkningsakt%C3%B8r">kodelisten.</a>
        /// </summary>
        
        [Column("virkningsaktør", TypeName = "varchar(90)")]
        public virtual string Virkningsaktør { get; set; }

        /// <summary>
        /// 
        /// </summary>
        
        [Column("adgangFraHusnummer")]
        public virtual Guid? AdgangFraHusnummer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        
        [Column("bygning")]
        public virtual Guid? Bygning { get; set; }

        /// <summary>
        /// Angiver om der er elevator i opgangen/bygningen. For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/Elevator">kodelisten.</a>
        /// </summary>
        
        [Column("opg020Elevator", TypeName = "varchar(10)")]
        public virtual string Opg020Elevator { get; set; }

        /// <summary>
        /// Liste med koder vedrørende husnummerets funktion i forhold til denne opgang For mulige værdier, se <a href="https://ki.bbr.dk/kodelister-bbr/0/1/0/HusnummerRolle">kodelisten.</a>
        /// </summary>
        
        [Column("opg021HusnummerFunktion", TypeName = "varchar(2)")]
        public virtual string Opg021HusnummerFunktion { get; set; }

        /// <summary>
        /// Beskrivende tekstnotat om særlige forhold for dette BBR-element
        /// </summary>
        
        [Column("opg500Notatlinjer", TypeName = "varchar(max)")]
        public virtual string Opg500Notatlinjer { get; set; }

        /// <summary>Overwrite this method to do your own initialization of the entity.</summary>
        partial void OnCreated();

        /// Returns the primary key as a string (includes all columns).</summary>
        public override string DawaPkey
        {
            get
            {
                if (_dawaPkey == null)
                {
                    _dawaPkey = Rowkey.ToString();
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
