using Microsoft.EntityFrameworkCore;
using WebApplicationWithEF.Models;
using Microsoft.Extensions.DependencyInjection;
using WebApplicationWithEF.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDbContext<WebApplicationWithEFContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WebApplicationWithEFContext") ?? throw new InvalidOperationException("Connection string 'WebApplicationWithEFContext' not found.")));
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ProductContext>(options =>
  options.UseSqlServer());
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}
else
{
	app.UseDeveloperExceptionPage();
	app.UseMigrationsEndPoint();
}
using (var scope = app.Services.CreateScope())
{
	var services = scope.ServiceProvider;

	var context = services.GetRequiredService<ProductContext>();
	context.Database.EnsureCreated();
	// DbInitializer.Initialize(context);
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
	endpoints.MapRazorPages();
	endpoints.MapControllers();
});
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
