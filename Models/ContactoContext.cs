using Microsoft.EntityFrameworkCore;

namespace contactos.Models
{
    public class ContactosContext: DBContext {
        public ContactosContext(DBContextOptions<ContactosContext> options) : base(options)
        {
            
        }

        public DBSet<Contacto> Contacto {get;set;}
    }
}