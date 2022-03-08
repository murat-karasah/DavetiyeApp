using DavetiyeEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavetiyeDataAccess.Abstract
{
  public  interface IDavetiyeRepository
    {
        List<Davetiye> GetAll();
        Davetiye GetById(int id);
        Davetiye CreateD(Davetiye davetiye);
        void DeleteDavetiye(int id);
    }
}
