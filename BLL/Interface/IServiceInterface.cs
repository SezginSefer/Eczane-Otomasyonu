using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IServiceInterface<Entity>
        where Entity : class
    {

        bool Check(Entity hdto);

        bool Compare(Entity hdto);

    }
}
