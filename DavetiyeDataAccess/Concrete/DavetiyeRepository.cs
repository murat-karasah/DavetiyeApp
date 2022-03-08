using DavetiyeDataAccess.Abstract;
using DavetiyeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeDataAccess.Concrete
{
    public class DavetiyeRepository : IDavetiyeRepository
    {
        public Davetiye CreateD(Davetiye davetiye)
        {
            using (var db = new DavetiyeDbContext())
            {
                db.Davetiyes.Add(davetiye);
                db.SaveChanges();
                return davetiye;
            }
        }

        public void DeleteDavetiye(int id)
        {
            using (var db = new DavetiyeDbContext())
            {
                var deleteDavetiye = GetById(id);
                db.Davetiyes.Remove(deleteDavetiye);
                db.SaveChanges();
            }
        }

        public List<Davetiye> GetAll()
        {
            using (var db = new DavetiyeDbContext())
            {
                return db.Davetiyes.ToList();
                
            }
        }

        public Davetiye GetById(int id)
        {
            using (var db = new DavetiyeDbContext())
            {
                return db.Davetiyes.FirstOrDefault(x => x.Id == id);
            }
        }
    }
}
