using ADOnet.ado;
using Microsoft.Extensions.Configuration;


var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory()) 
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

var connectionString = configuration.GetConnectionString("DefaultConnection");
var disArchi = new DisconnectedArchi(connectionString);
var connArchi = new ConnectedArchi(connectionString);

disArchi.PutData_(6,"Marketing",35000);
connArchi.GetData();


