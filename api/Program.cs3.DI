using CustomerNamespace;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<ICustomerService, CustomerService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger().UseSwaggerUI();

app.MapGet("/", (ICustomerService customerService)  => customerService.Current());

app.Run();


