using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entities.tables
{
    public class CustomerBankInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int BankName { get; set; }
        [MaxLength(26)]
        public string IBAN { get; set; }
        public CustumersAdressDetails adress { get; set; }
        [ForeignKey(nameof(CustumersAdressDetails))]
        public int CustumersAdressDetailsRefId { get; set; }

    }
}
