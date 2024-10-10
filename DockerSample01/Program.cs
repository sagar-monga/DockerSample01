var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options =>
{
    options.ReturnHttpNotAcceptable = true;  // Will return 406 if the format specified in 'Accept' is not supported by our API
})
//! Order is important herer
.AddNewtonsoftJson()
.AddXmlDataContractSerializerFormatters(); //* Registers controllers


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); //* Adds Swagger
builder.Services.AddSwaggerGen(); //* Adds Swagger

var app = builder.Build(); //* Builds the App

// Configure the HTTP request pipeline. -- important

// * Middlewaers added here
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

/* Alternate/older way of registering controllers (MapControllers combines this into one)
    
app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

*/

app.Run();
