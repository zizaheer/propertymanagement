using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyManagement.EntityFrameworkDataAccess
{
    public class PropertyManagementContext : DbContext
    {
        public PropertyManagementContext(bool createProxy = true) : base("connectionString")
        {
            Configuration.ProxyCreationEnabled = createProxy;
        }


    }
}
