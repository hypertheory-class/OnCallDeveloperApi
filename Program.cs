var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.MapGet("/", () =>
{
    var response = new DeveloperInfo("Warren", "Ellis", "we@aol.com", "867-5309");
    return response;
})
.WithName("GetOnCallDeveloper");

app.Run();


public record DeveloperInfo(string firstName, string lastName, string emailAddress, string telephoneNumber);