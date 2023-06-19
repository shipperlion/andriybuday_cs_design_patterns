using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class UselessMessagesSearcher: MessagesSearcher
    {
        public UselessMessagesSearcher(DateTime dateSent, String personName): base(dateSent, personName, 1)
        {
        }

        protected override void CreateImportanceCriteria()
        {
            Console.WriteLine("Special importance criteria has been formed: USELESS");
        }
    }
}
