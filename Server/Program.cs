using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Server;
using Server.Data;


var seed = args.Contains("/seed");
if (seed)
{
    args = args.Except(new[] {"/seed"}).ToArray();
}

var builder = WebApplication.CreateBuilder(args);



var conn = builder.Configuration.GetConnectionString("CONN");

var assembly= typeof(Program).Assembly.GetName().Name;

//check if database has data do nothing else seed data 
if (seed)
{
    SeedData.EnsureSeedData(conn);
}

//register for ideintity users 
builder.Services.AddDbContext<AspNetIdentityDbContext>(options => options.UseSqlServer(conn,b => b.MigrationsAssembly(assembly)));
builder.Services.AddAuthorization();

builder.Services.AddIdentity<IdentityUser,IdentityRole>()
    .AddEntityFrameworkStores<AspNetIdentityDbContext>();

//Identity server setting
builder.Services.AddIdentityServer()
.AddAspNetIdentity<IdentityUser>()
.AddConfigurationStore(options =>
{
    options.ConfigureDbContext = b => b.UseSqlServer(conn, opt => opt.MigrationsAssembly(assembly));
}).AddOperationalStore(options =>
{
    options.ConfigureDbContext = b => b.UseSqlServer(conn, opt => opt.MigrationsAssembly(assembly));
}).AddDeveloperSigningCredential();

builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseIdentityServer();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.Run();
