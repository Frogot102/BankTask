using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTask.Models
{
    [Table("AVERS_DWH_NSO_CLIENT")]
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string CLIENT_ACC { get; set; }

        public DateTime DATE_BEGIN { get; set; }
        public DateTime? DATE_END { get; set; }

        public int IKUSNUM { get; set; }

        [StringLength(50)]
        public string AGGREMENT_NUM { get; set; }

        public DateTime? AGGREMENT_DATE { get; set; }

        [StringLength(25)]
        public string ACC_N068 { get; set; }

        [StringLength(25)]
        public string ACC_47426 { get; set; }

        public bool IS_ACTIVE { get; set; } = true;

        [StringLength(250)]
        public string CREATE_USER { get; set; }

        public DateTime CREATE_DATE { get; set; }

        [StringLength(250)]
        public string UPDATE_USER { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(250)]
        public string NOTE { get; set; }

        [StringLength(1000)]
        public string ERR_MESSAGE { get; set; }

        [StringLength(25)]
        public string CLIENT_ACC_DOP { get; set; }
    }
}