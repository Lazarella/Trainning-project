using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WatchList.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

/*builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
*/

builder.Services.AddMvc();

builder.Services.AddIdentity<MyUser, IdentityRole>(options =>
{
    options.User.RequireUniqueEmail = false;
})
 /*  .AddDefaultUI(UIFramework.Bootstrap4)*/
 .AddEntityFrameworkStores<ApplicationDbContext>()
   .AddDefaultTokenProviders();

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();
builder.Services.AddControllersWithViews();


builder.Services.AddRazorPages();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.MapRazorPages();

app.Run();





