var app = WebApplication.CreateBuilder(args).Build();
app.MapGet("/", () => {
    var customer = new Customer(Guid.NewGuid(), "Test");
    return customer.Fullname;
});
app.Run();
