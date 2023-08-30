Book book = new Book("Programming notes");
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

// Ved brug af constructor chaining kan vi gøre ovenstående mere læsbart:
Book book2 = new Book("My Book", new List<Chapter>(){
    new Chapter("Vars", new List<Page>(){
        new Page(MyNotes.VariablesPageOne),
        new Page(MyNotes.VariablesPageTwo)
    })
});

//book2.Start();