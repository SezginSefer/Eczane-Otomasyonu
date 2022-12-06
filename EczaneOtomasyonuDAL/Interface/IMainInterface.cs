using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneOtomasyonuDAL.Interface
{
    public interface IMainInterface <Entity>
        where Entity : class, new()
    {

        bool Add(Entity model);
        bool Update(Entity model);
        bool Delete(int id);
        Entity GetById(int id);
        IEnumerable<Entity> GetAll();
        IEnumerable<Entity> GetFilter(long id);
        int AddPlus(Entity model);
       
    }
}
