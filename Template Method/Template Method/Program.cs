using Template_Method;

MessagesSearcher searcher = new UselessMessagesSearcher(DateTime.Today, "Sally");
searcher.Search();

searcher = new ImportantMessagesSearcher(DateTime.Today, "Killer");
searcher.Search();

