var builder = WebApplication.CreateBuilder(args);

var connectionStr =  builder.Configuration["AdditionalConnectionStrings"];
var data2 = builder.Configuration["AdditionalSettingsData:Data_2"];

Console.WriteLine(connectionStr);
Console.WriteLine(data2);

var app = builder.Build();

app.Run();
