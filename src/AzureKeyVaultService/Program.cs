var builder = WebApplication.CreateBuilder(args);
builder.Services.AddKeyVaultServices();
builder.Services.AddKeyVaultConfig(builder.Configuration);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/test", (IKeyVaultSecretsService service) => service.test());

app.Run();
