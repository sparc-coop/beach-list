using Kuvio.Kernel.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Beachlist.Core.Beach.Queries
{
    public class GetAllBeachesQuery
    {
        readonly IRepository<Beach> _beachRepository;

        public GetAllBeachesQuery(IRepository<Beach> beachRepository)
        {
            _beachRepository = beachRepository;
        }

        public async Task<List<Beach>> Execute()
        {
            var beachList = await _beachRepository.GetAllAsync();

            return beachList;
        }
    }
}
