

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register CustomerRepository with connection string
builder.Services.AddTransient<CustomerRepository>(_ =>
{
    var configuration = _.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    return new CustomerRepository(connectionString);
});

builder.Services.AddTransient<SupplierRepository>(_ =>
{
    var configuration = _.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    return new SupplierRepository(connectionString);
});


builder.Services.AddTransient<MeetingRepository>(_ =>
{
    var configuration = _.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    return new MeetingRepository(connectionString);
});

builder.Services.AddTransient<TradeTransactionRepository>(_ =>
{
    var configuration = _.GetRequiredService<IConfiguration>();
    var connectionString = configuration.GetConnectionString("DefaultConnection");
    return new TradeTransactionRepository(connectionString);
});

// Add configuration
builder.Configuration.AddJsonFile("appsettings.json");

// Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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


