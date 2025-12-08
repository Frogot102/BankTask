using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTask.Models
{
    [Table("AVERS_DWH_NSO_REQUESTS")]
    public class Request
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string CLIENT_ACC { get; set; }

        public DateTime CREATE_DATE { get; set; }

        [StringLength(20)]
        public string SUMM { get; set; }

        [StringLength(20)]
        public string ADDAGGREMENT_NUM { get; set; }

        [StringLength(250)]
        public string PRC_STR { get; set; }

        public DateTime DATE_BEGIN { get; set; }
        public DateTime? DATE_END { get; set; }

        [StringLength(10)]
        public string DAYS_COUNT { get; set; }

        public int? PRC_JS_CALC { get; set; } = 0;
        public int? PRC_NUM { get; set; } = 0;

        public DateTime? DATE_BREAK { get; set; }

        public int? IS_ENDED { get; set; } = 0;

        public DateTime? ADDAGGREMENT_DATE { get; set; }

        public int IKUSNUM { get; set; }

        [StringLength(250)]
        public string CREATE_USER { get; set; }

        [StringLength(250)]
        public string UPDATE_USER { get; set; }

        public DateTime? UPDATE_DATE { get; set; }

        [StringLength(250)]
        public string NOTE { get; set; }

        [StringLength(1000)]
        public string ERR_MESSAGE { get; set; }

        public int NSO_CLIENT_ID { get; set; }

        [ForeignKey("NSO_CLIENT_ID")]
        public virtual Client Client { get; set; }
    }
}