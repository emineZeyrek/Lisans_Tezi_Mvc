﻿namespace Lisans_Tezi_Mvc.Models
{
    public class MEASURE_REGISTERS : BaseEntity
    {
    
        public char KOD_TURU { get; set; }
        public string KOD { get; set; }
        public char OLCU_BIRIMI { get; set; }
        public string ACIKLAMA { get; set; }
        public string NET_AGIRLIK { get; set; }
        public string BRUT_AGIRLIK { get; set; }
        public decimal EN { get; set; }
        public decimal BOY { get; set; }
        public decimal YUKSEKLIK { get; set; }


    }
}