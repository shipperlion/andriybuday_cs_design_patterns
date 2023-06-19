using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method
{
    internal class MessagesSearcher
    {
        protected DateTime _dateSent;
        protected string _personName;
        protected int _importanceLevel;

        public MessagesSearcher(DateTime dateSent, string personName, int importanceLevel)
        {
            _dateSent = dateSent;
            _personName = personName;
            _importanceLevel = importanceLevel;
        }

        protected virtual void CreateDateCriteria()
        {
            Console.WriteLine("Standard date criteria has been applied");
        }

        protected virtual void CreateSentPersonCriteria()
        {
            Console.WriteLine("Standard person criteria has been applied");
        }

        protected virtual void CreateImportanceCriteria()
        {
            Console.WriteLine("Standard importance criteria has been applied");
        }

        public string Search()
        {
            CreateDateCriteria();
            CreateSentPersonCriteria();
            Console.WriteLine("Template method does some verification accordingly to search algo.");
            CreateImportanceCriteria();
            Console.WriteLine("Template method verifies if message could be so important or useless from person provided in criteria.");
            Console.WriteLine();
            return "Some list of messages...";
        }
    }
}
