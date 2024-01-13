using D3_MiniChallengeFiveToSeven_Endpoints.Services.MadLib;
using D3_MiniChallengeFiveToSeven_Endpoints.Services.OddOrEven;
using D3_MiniChallengeFiveToSeven_Endpoints.Services.ReversAlfaNum;
using D3_MiniChallengeFiveToSeven_Endpoints.Services.ReversNum;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IMadLibService, MadLibService>();
builder.Services.AddScoped<IOddOrEvenService, OddOrEvenService>();
builder.Services.AddScoped<IReversAlfaNumService, ReversAlfaNumService>();
builder.Services.AddScoped<IReversNumService, ReversNumService>();

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
