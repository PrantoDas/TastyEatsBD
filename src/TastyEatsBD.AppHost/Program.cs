var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");

var apiservice = builder.AddProject<Projects.TastyEatsBD_WebApi>("apiservice");

builder.AddProject<Projects.TastyEatsBD_WebClient>("webfrontend")
    .WithReference(cache)
    .WithReference(apiservice);

builder.Build().Run();
