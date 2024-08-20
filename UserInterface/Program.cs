using DemoLibrary;
using DemoLibrary.DataAccess;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();


// config for mediatR
builder.Services.AddSingleton<IDataAccess, DemoDataAccess>();

// will load entire assembly not just the class
// and looking for anything we do with "mediatr" (hanlder, query, command)
builder.Services.AddMediatR(typeof(DemoLibraryMediatREntrypoint).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
