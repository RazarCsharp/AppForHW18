using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForModule18
{
    public abstract class Command
    {
        public abstract Task Run();
    }
}
