{
  "dependencies": {
    "Microsoft.AspNet.Server.Kestrel": "1.0.0-*",
    "Microsoft.AspNet.Owin": "1.0.0-*",
    "Nancy": "1.3.0",
    "Nancy.ViewEngines.Razor": "1.3.0",
    "xunit": "2.1.0",
    "xunit.runner.dnx": "2.1.0-rc1-*"
  },
  "commands": {
    "kestrel": "Microsoft.AspNet.Hosting --server Microsoft.AspNet.Server.Kestrel --server.urls http://localhost:5004",
    "test": "xunit.runner.dnx"
  },
  "frameworks": {
    "dnx451": {}
  }
}
