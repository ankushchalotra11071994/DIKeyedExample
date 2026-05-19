using MyApp.Classes;
using MyApp.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddKeyedScoped<INotification,SmsService>("SmsKey");
builder.Services.AddKeyedScoped<INotification,EmailService>("Emailkey");
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.MapGet("notification/email",
(
    [FromKeyedServices("Emailkey")] INotification myservice
)=>
{
 return Results.Ok(myservice.SendMessage()) ; 
});




app.MapGet("notification/Sms",
(
    [FromKeyedServices("SmsKey")] INotification myservice
)=>
{
 return  Results.Ok(myservice.SendMessage()) ; 
});


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
  

app.Run();

 