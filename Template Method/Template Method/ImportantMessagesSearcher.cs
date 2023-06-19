using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class ImportantMessagesSearcher: MessagesSearcher
    {
        public ImportantMessagesSearcher(DateTime dateSent, string personName): base(dateSent, personName, 3) { }

        protected override void CreateImportanceCriteria()
        {
            Console.WriteLine("Special importance criteria has been formed: IMPORTANT");

        }
    }
}
