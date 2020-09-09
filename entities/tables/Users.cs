using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace entities.tables
{
   public  class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(8)]
        [Required]
        public string UserName { get; set; }
        [MaxLength(8)]
        [MinLength(8)]
        [Required]
        public string UserPassword { get; set; }
        [MaxLength(50)]
        public string UserEmail { get; set; }
        public int UsetDetailId { get; set; }

        [ForeignKey(nameof(CustomersDetail))]
        public int CustomerDetailsRefId { get; set; }
        public CustomersDetail customersDetails { get; set; }

        [ForeignKey(nameof(CustumersAdressDetails))]
        public int CustumersAdressDetailsRefId { get; set; }
        public CustumersAdressDetails custumersAdressDetails { get; set; }

        [ForeignKey(nameof(CustomerBankInformation))]
        public int CustomerBankInformationRefId { get; set; }
        public CustomerBankInformation customerBankInformation { get; set; }


    }
}
