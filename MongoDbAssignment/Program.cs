// See https://aka.ms/new-console-template for more information

using MongoDbAssignment.Services;

Console.WriteLine("Starting up...");

var service = new MunicipalityService(true);

service.QueryMunicipalities("Aarhus");
service.QuerySocieties("Fodbold");
service.QueryBookings();
service.QueryKeyResponsible("6277d8752a7e63cbb0dc6c7b"); // Replace with member Id of the key responsible
