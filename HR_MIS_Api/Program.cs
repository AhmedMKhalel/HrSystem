using HR_MIS_Api.Extensions;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//***********************************************************************************************************************

/// add ApplicationDbcontext Service
builder.Services.AddDbContext<HrMisContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//builder.Services.AddDbContext<AppIdentityDbContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnection"));
//});




//***********************************************************************************************************************
// Add services to the container.

builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Scope to Automatic Migration before running

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var loggerFactory = services.GetRequiredService<ILoggerFactory>();

    try
    {
        var context = services.GetRequiredService<HrMisContext>();
        await context.SaveChangesAsync();
        await HrMisContextSeed.SeedAsync(context, loggerFactory);
       
    }

    catch (Exception ex)
    {

        var logger = loggerFactory.CreateLogger<HrMisContext>();
        logger.LogError(ex.Message, "An Error Occured While Seeding Data!!");
    }
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
