﻿using Lisans_Tezi_Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Lisans_Tezi_Mvc.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
            
        }
        public DbSet<STOCK_INFORMATION> StokBilgisi_TBL { get; set; }
        public DbSet<ACCOUNTING_CODE_DEFINITION> MuhasebeKodTanimlama_TBL { get; set; }

        public DbSet<EMPLOYEE_DEFINITION> Personel_TBL { get; set; }

        public DbSet<GENERAL_CURRENCY_DEFINITION> Genel_ParaBirimiTanimlama_TBL { get; set; }
        public DbSet<GENERAL_BARCODE_TYPE_DEFINITION> Genel_BarkodTipiTanimlama_TBL { get; set; }
        
        public DbSet<GENERAL_MEASUREMENT_UNIT> Genel_OlcuBirimiTanimlama_TBL { get; set; }
        public DbSet<ACCOUNTING_CURRENT_CARD_DEFINITION> Muhasebe_CariKartTanimlama_TBL { get; set; }
        public DbSet<WAREHOUSE_DEFINITION> DepoTanimlama_TBL { get; set; }
        public DbSet<STOCK_TRANSACTION_RECORDS_ENTRY> Stok_IslemHareketKayitlari_TBL { get; set; }
        public DbSet<GROUP_CODE_DEFINITIONS> Stok_GrupKodTanimlama_TBL { get; set; }
        public DbSet<STOCK_CARD2> StokKart2_TBL { get; set; }
        public DbSet<STOCK_CARD1> StokKart1_TBL { get; set; }
        public DbSet<ACCOUNTING_DETAILCODE_ENTRY> MuhasebeDetayKodGiris_TBL { get; set; }
     

    }

}
