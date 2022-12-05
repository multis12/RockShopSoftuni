using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RockShop.Infrastructure.Data;
using RockShop.ModelBinders;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<Account>(options =>
{
    options.SignIn.RequireConfirmedAccount = builder.Configuration.GetValue<bool>("Account:RequireConfirmedAccount");
    options.SignIn.RequireConfirmedEmail = builder.Configuration.GetValue<bool>("Account:RequireConfirmedEmail");
    options.SignIn.RequireConfirmedPhoneNumber = builder.Configuration.GetValue<bool>("Account:RequireConfirmedPhoneNumber");
    options.Password.RequiredLength = builder.Configuration.GetValue<int>("Account:RequiredLength");
    options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Account:RequireNonAlphanumeric");
})
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
});
builder.Services.AddControllersWithViews()
    .AddMvcOptions(options =>
    {
        options.ModelBinderProviders.Insert(0, new DecimalModelBinderProvider());
    });
builder.Services.AddApplicationServices();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
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
