using Beachlist.Core;
using Beachlist.Core.Beach;
using Kuvio.Kernel.Database.CosmosDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beachlist.Services
{
    public class BeachlistContext : CosmosDbContext
    {
        public BeachlistContext(Microsoft.Azure.Cosmos.Database database) : base(database)
        {
            AllowSynchronousQueries = true;

            Map<Beach>("Beach");

            //Map<Datum>("Datum");
            //Map<Project>("Project");
            //Map<Presentation>("Presentation");
            //Map<ReplicationLog>("ReplicationLog");
            //Map<Revision>("Revision");

            //Map<BillingHistory>("User");
            //Map<User>("User");
        }
    }
}
