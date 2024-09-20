using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services.Repository;
using DAL.EntityFramework;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<FileManagementContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddDistributedMemoryCache();

builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IUserFileRepository, UserFileRepository>();
builder.Services.AddTransient<IFileTypeRepository, FileTypeRepository>();
builder.Services.AddTransient<IFilesCommentRepository, FilesCommentRepository>();
builder.Services.AddTransient<IFilesSharedRepository, FilesSharedRepository>();
builder.Services.AddTransient<IFilesViewRepository, FilesViewRepository>();
builder.Services.AddTransient<IUsersLikeRepository, UsersLikeRepository>();
builder.Services.AddTransient<IUsersPostRepository, UsersPostRepository>();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});



var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
