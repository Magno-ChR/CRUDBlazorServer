using CRUDBlazorServer.Data;
namespace CRUDBlazorServer.Services
{
    public class CurrencyServices
    {
        protected readonly ApplicationDbContext _dbcontext;

        public CurrencyServices(ApplicationDbContext _db)
        {
            _dbcontext = _db;
        }

        public List<CurrencyClass> GetAllCurrency()
        {
            return _dbcontext.currency.ToList();
        }

        public bool Insertar(CurrencyClass a)
        {
            _dbcontext.currency.Add(a);
            _dbcontext.SaveChanges();
            return true;
        }

        public CurrencyClass Editar(int id)
        {
            CurrencyClass a = new CurrencyClass();
            return _dbcontext.currency.FirstOrDefault(u => u.id == id);

        }

        public bool Actualizar(CurrencyClass a)
        {
            var CurrencyUpdate = _dbcontext.currency.FirstOrDefault(u => u.id == a.id);
            if (CurrencyUpdate != null)
            {
                CurrencyUpdate.nombre = CurrencyUpdate.nombre;
                CurrencyUpdate.precio = CurrencyUpdate.precio;
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
        public bool Borrar(CurrencyClass adel)
        {
            var CurrencyUDel = _dbcontext.currency.FirstOrDefault(u => u.id == adel.id);
            if (CurrencyUDel != null)
            {
                _dbcontext.Remove(CurrencyUDel);    
                _dbcontext.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
