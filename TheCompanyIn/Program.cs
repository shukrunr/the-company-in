using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy => policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader());
});

// Add services to the container.
builder.Services.AddHttpClient("client", httpClient =>
{
    httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "sk_bd16fff876554c3a767f98cf263121b4");
});

builder.Services.AddControllers(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true);

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
