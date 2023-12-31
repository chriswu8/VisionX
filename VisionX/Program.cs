using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using VisionX.Data;
using VisionX.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<ServicesService>();
builder.Services.AddScoped<PatientService>();
builder.Services.AddScoped<AppointmentService>();
builder.Services.AddScoped<InvoiceService>();
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<PageRowsService>();
builder.Services.AddScoped<PatientRowsService>();
builder.Services.AddScoped<EmployeeService>();

string connStr = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(
    options => options.UseSqlServer(connStr)
);

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
    