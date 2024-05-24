
//HTTP
//var builder = WebApplication.CreateBuilder();
//var app = builder.Build();
//app.Use(async (context, next) =>
//{
//    context.Items.Add("KEY", "Congratulations all is alright");
//    await next.Invoke();
//});
//app.Run(async (context) =>
//{
//    if (context.Items.ContainsKey("KY"))
//        await context.Response.WriteAsync($"Message: {context.Items["KEY"]}");
//    else
//        await context.Response.WriteAsync("Wrong word, replace");
//});
//app.Run();

//Sessions
//var builder = WebApplication.CreateBuilder();
//builder.Services.AddDistributedMemoryCache();
//builder.Services.AddSession();
//var app = builder.Build();
//app.UseSession();
//app.Run(async (context) =>
//{
//    if (context.Session.Keys.Contains("Pomny"))
//        await context.Response.WriteAsync($"Hi
//{ context.Session.GetString("Pomny")}
//    !");
// else
//    {
//        context.Session.SetString("Pomny", "its only for you");
//        await context.Response.WriteAsync("No hi for you");
//    }
//});
//app.Run();

//Cookie
var builder = WebApplication.CreateBuilder();
var app = builder.Build();
app.Run(async (context) =>
{
    if (context.Request.Cookies.ContainsKey("Key1"))
    {
        string? Key1 = context.Request.Cookies["Key1"];
        await context.Response.WriteAsync($"Hello {Key1}!");
    }
    else
    {
        context.Response.Cookies.Append("Key1", "all is working");
        await context.Response.WriteAsync("No cookie");
    }
});
app.Run();