Book book = new Book();
List<Chapter> chapters = new List<Chapter>();
Chapter variablesChapter = new Chapter("Vars");
chapters.Add(variablesChapter);

List<Page> variablesPages = new List<Page>();
Page variablesPage = new Page(MyNotes.VariablesPageOne);
Page variablesPageTwo = new Page(MyNotes.VariablesPageTwo);
variablesPages.Add(variablesPage);
variablesPages.Add(variablesPageTwo);

variablesChapter.Pages = variablesPages;
book.Chapters = chapters;

book.Start();