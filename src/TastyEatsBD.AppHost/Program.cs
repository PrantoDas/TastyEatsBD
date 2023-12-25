var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");


builder.AddProject<Projects.TastyEatsBD_WebApp>("WebApp")
    .WithReference(cache);

builder.Build().Run();
