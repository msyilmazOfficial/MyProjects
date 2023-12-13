using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<IUserService, UserManager>();
builder.Services.AddSingleton<IUserRepository, UserRepository>();
builder.Services.AddSingleton<ICurrencyService, CurrencyManager>();
builder.Services.AddSingleton<ICurrencyRepository, CurrencyRepository>();
builder.Services.AddSingleton<ICustomerService, CustomerManager>();
builder.Services.AddSingleton<ICustomerRepository, CustomerRepository>();
builder.Services.AddSingleton<ICustomerOperationService, CustomerOperationManager>();
builder.Services.AddSingleton<ICustomerOperationRepository, CustomerOperationRepository>();
builder.Services.AddSingleton<IOrderService, OrderManager>();
builder.Services.AddSingleton<IOrderRepository, OrderRepository>();
builder.Services.AddSingleton<IPriceListService, PriceListManager>();
builder.Services.AddSingleton<IPriceListRepository, PriceListRepository>();
builder.Services.AddSingleton<IStockService, StockManager>();
builder.Services.AddSingleton<IStockRepository, StockRepository>();
builder.Services.AddSingleton<IStocOperationService, StocOperationManager>();
builder.Services.AddSingleton<IStocOperationRepository, StocOperationRepository>();
builder.Services.AddSingleton<IUnitService, UnitManager>();
builder.Services.AddSingleton<IUnitRepository, UnitRepository>();
builder.Services.AddSingleton<IWareHouseService, WareHouseManager>();
builder.Services.AddSingleton<IWareHouseRepository, WareHouseRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.Cookie.Name = "NetCookieAuthentication";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
    //options.LoginPath = "";
    options.AccessDeniedPath = "";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
