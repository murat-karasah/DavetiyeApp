using DavetiyeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeBusiness.Abstract
{
   public interface IDavetiyeService
    {
        List<Davetiye> GetAll();
        List<Davetiye> GetAllFiltre(bool v);

        Davetiye GetById(int id);
        Davetiye CreateD(Davetiye davetiye);
        void DeleteDavetiye(int id);
        
    }

}
