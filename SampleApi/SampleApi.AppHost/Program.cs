var builder = DistributedApplication.CreateBuilder(args);

// hook up the API to the aspire orchestration
builder.AddProject<Projects.SampleApi>("sampleapi");

builder.Build().Run();
