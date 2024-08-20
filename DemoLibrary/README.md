## config the Startup.cs
* -> ta sẽ cài **`MediatR`** cho DemoLibrary
* -> và cài **`MediatR.Extensions.Miscrosoft.DependencyInjection` cho "UserInterface" (_nó sẽ có sẵn **`MediatR`** bên trong_)

* -> tạo class **`DemoLibraryMediatREntrypoint`** trong "DemoLibrary" để đăng ký assembly cho mediatR
* -> nó như 1 mediatR entry point

## Flow
* -> in "~/View/Home/Index.cshtml", the **mediatR** have a new **`Send`** request 
* -> the request is of type **GetPersonListQuery** 
* -> so it'll ask "who handle that ?" - the **GetPersonListHandler** is the one handle **GetPersonListQuery**
* -> it return **List<PersonModel>**
