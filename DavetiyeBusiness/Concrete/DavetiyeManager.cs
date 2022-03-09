using DavetiyeBusiness.Abstract;
using DavetiyeDataAccess.Abstract;
using DavetiyeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeBusiness.Concrete
{
    public class DavetiyeManager : IDavetiyeService
    {
        private IDavetiyeRepository rep;
        public DavetiyeManager(IDavetiyeRepository _rep)
        {
            rep = _rep;
        }

        public Davetiye CreateD(Davetiye davetiye)
        {
            return rep.CreateD(davetiye);
        }

        public void DeleteDavetiye(int id)
        {
            rep.DeleteDavetiye(id);
        }

        public List<Davetiye> GetAll()
        {
            return rep.GetAll();
        }

        public List<Davetiye> GetAllFiltre(bool v)
        {
            return rep.GetAllFiltre(v);
        }

        public Davetiye GetById(int id)
        {
            return rep.GetById(id);
        }
    }
}
