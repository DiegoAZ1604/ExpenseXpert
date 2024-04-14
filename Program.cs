using ExpenseXpertCRUD.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.Configure<ConnectionStrings>(builder.Configuration.GetSection(nameof(ConnectionStrings)));
builder.Services.AddDbContext<MyDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("MyDbContext")));
//builder.Services.AddScoped<IDataAccessProvider, DataAccessProvider>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
