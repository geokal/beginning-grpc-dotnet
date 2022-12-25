using Grpc.Net.Client;
using Microsoft.Extensions.Logging;
using static Apress.Sample.gRPC.v1.CountryService;

var loggerFactory = LoggerFactory.Create(logging =>
{

    logging.AddConsole();

    logging.SetMinimumLevel(LogLevel.Trace);
});

var channel = GrpcChannel.ForAddress("https://localhost:5001", new
GrpcChannelOptions
{
    LoggerFactory = loggerFactory

});
var countryClient = new CountryServiceClient(channel);
