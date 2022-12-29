using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForModule18
{
    class User
    {
        Command command;

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        // Выполнить
        public async Task Run()
        {
            await command.Run();
        }
     
    }
}
