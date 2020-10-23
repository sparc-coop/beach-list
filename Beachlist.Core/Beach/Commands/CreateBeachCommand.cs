using Kuvio.Kernel.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Beachlist.Core.Beach.Commands
{
    public class CreateBeachCommand
    {
        readonly IRepository<Beach> _beachRepository;

        public CreateBeachCommand(IRepository<Beach> beachRepository)
        {
            _beachRepository = beachRepository;
        }

        public async Task<Beach> Execute(Beach beach)
        {
            var newBeach = await _beachRepository.AddAsync(beach);

            return newBeach;
        }

    }
}
