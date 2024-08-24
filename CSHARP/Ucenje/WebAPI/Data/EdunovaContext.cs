using WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Data
{
    public class EdunovaContext:DbContext
    {
        // ovaj constructor služi da bi se servis od Web Aplikacije povezao na bazu, naš constructor poziva nad constructor od DbContext
        public EdunovaContext(DbContextOptions<EdunovaContext> opcije): base(opcije) {
        
        }


    }
}
