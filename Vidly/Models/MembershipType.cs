using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }

        [StringLength(32)]
        public string Name { get; set; }

        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }


        public static readonly byte Desconhecido = 0;
        public static readonly byte PagueComoUsar = 1;
        public static readonly byte Mensal = 2;
        public static readonly byte Trimestral = 3;
        public static readonly byte Anual = 4;
    }
}