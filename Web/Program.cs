var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Här lägger vi till services som vi kan dependency inject
builder.Services.AddRazorPages();

var app = builder.Build();


app.UseHttpsRedirection();
app.UseStaticFiles();

//Routing går först men vi kommer använmda razor page
app.UseRouting();

app.UseAuthorization();

//Här är vår routing 
app.MapRazorPages();

app.Run();
