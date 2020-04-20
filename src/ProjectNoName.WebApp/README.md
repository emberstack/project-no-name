Get SignalR client library

- Install LibMan to get the client library from unpkg.
dotnet tool install -g Microsoft.Web.LibraryManager.Cli

libman install @microsoft/signalr@latest -p unpkg -d wwwroot/js/signalr --files dist/browser/signalr.js --files dist/browser/signalr.min.js