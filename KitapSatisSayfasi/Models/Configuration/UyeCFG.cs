using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KitapSatisSayfasi.Models.Configuration
{
    public class UyeCFG : IEntityTypeConfiguration<Uye>
    {
        public void Configure(EntityTypeBuilder<Uye> builder)
        {
            Uye uye = (new Uye() { Id = 1,Ad = "Cevdet",Soyad = "Korkmaz",UserName = "Cevdo", NormalizedUserName = "CEVDET", Email = "cevdo@deneme.com", NormalizedEmail = "cevdo@deneme.com", EmailConfirmed =false, Adres = "Kadıköy" });
            PasswordHasher<Uye> hash = new PasswordHasher<Uye>();
            uye.PasswordHash = hash.HashPassword(uye, "123");
            builder.HasData(uye);
            
            
        }
    }
}
