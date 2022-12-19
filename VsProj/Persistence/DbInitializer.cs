using Microsoft.EntityFrameworkCore;
using VsProj.Models;

namespace VsProj.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(VsDbContext context)
        {
            // Automatic database schema migration on startup, if required
            context.Database.Migrate();


            if (context.PartnerInfos.Any())
            {
                return; //The database is already initialized.
            }

            var partners = new List<PartnerInfo>();

            for (int i = 0; i < 10; i++)
            {
                partners.Add(new PartnerInfo
                {
                    PARTNERNEV = "Felhasznalo" + i.ToString(),
                    IRANYITOSZAM = i + 1000,
                    VAROS = "Varos" + i.ToString(),
                    UTCA = "Utca" + i.ToString(),
                    ROGZIDO = DateTime.Now.AddDays(i)
                });
            }

            foreach (PartnerInfo p in partners)
            {
                context.PartnerInfos.Add(p);
            }

            context.SaveChanges();
        }
    }
}
