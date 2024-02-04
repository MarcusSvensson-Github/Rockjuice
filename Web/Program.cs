var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Här lägger vi till services som vi kan dependency inject
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
//här kan vi lägga in middleware 
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

//Routing går först men vi kommer använmda razor page
app.UseRouting();

app.UseAuthorization();

//Här är vår routing 
app.MapRazorPages();

app.Run();
