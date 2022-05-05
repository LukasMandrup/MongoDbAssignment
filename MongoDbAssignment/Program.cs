// See https://aka.ms/new-console-template for more information

using MongoDbAssignment.Services;

Console.WriteLine("Hello, World!");

var service = new MunicipalityService();

service.InsertDummyData();