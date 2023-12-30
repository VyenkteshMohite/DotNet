var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();


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

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "default",
//here the fist will called and if we need to fetch id,name,and other details then 
//we need the  write in this manner 
//pattern :"{controller=P}/{action=Get}/{id?}"
// here the P is the name of Controller 
// action method is get 
//and we are fetching the id so we need to write in this manner 
// {id?} here the dsa ? mark is used to get the id and sent to the database for fetching it
    pattern: "{controller=P}/{action=Get}/{id?}");

app.Run();
