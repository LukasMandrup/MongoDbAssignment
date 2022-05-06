// See https://aka.ms/new-console-template for more information

using MongoDbAssignment.Services;

Console.WriteLine("Starting up...");

var service = new MunicipalityService();

service.InsertDummyData();
service.QueryMunicipalities("Aarhus");
