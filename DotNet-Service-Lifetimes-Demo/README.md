ASP.NET Core – Service Lifetime Demo using GUIDs
This project demonstrates how the three built-in Dependency Injection (DI) lifetimes in ASP.NET Core—Transient, Scoped, and Singleton—affect the instantiation of services.

📌 Project Description
This is a simple ASP.NET Core Web API project that logs service GUIDs to visualize the behavior of each DI lifetime. It shows how many times an instance of a service is created based on the service lifetime you register in Program.cs.

By injecting the same service twice into a controller, the project demonstrates whether the service is reused or recreated, depending on the lifetime.

🔍 Dependency Injection Lifetimes in ASP.NET Core
1. Transient
A new instance is created every time it is requested.

Used for stateless services or lightweight operations.

2. Scoped
A single instance is created per HTTP request.

All services resolved during the same request share the same instance.

3. Singleton
A single instance is created and shared across the entire application lifetime.

Ideal for global state or cache but must be thread-safe.

🚀 What This Project Demonstrates
Lifetime	Behavior (Same Request)	Behavior (Different Requests)
Transient	🔁 Different GUIDs	🔁 Different GUIDs
Scoped	✅ Same GUIDs	🔁 Different GUIDs
Singleton	✅ Same GUIDs	✅ Same GUIDs

🛠️ Technologies Used
ASP.NET Core Web API (.NET 6+)

Minimal hosting model (WebApplication)

Dependency Injection

RESTful endpoint using ApiController

🧪 How to Run
✅ Prerequisites
.NET 6 SDK or higher

Visual Studio / VS Code / CLI

🔄 Steps
Clone or Extract the project.

Open a terminal in the project root.

Run the app:

bash
Copy
Edit
dotnet run
Open your browser or Postman and hit:

bash
Copy
Edit
http://localhost:5000/api/guiddemo
🔧 Modify Lifetime Behavior
Go to Program.cs and uncomment ONE of the service registrations:

csharp
Copy
Edit
// For Transient (new every time)
builder.Services.AddTransient<IGuidService, GuidService>();

// For Scoped (same within request)
builder.Services.AddScoped<IGuidService, GuidService>();

// For Singleton (same always)
builder.Services.AddSingleton<IGuidService, GuidService>();
Save and rerun the project to observe the changes in GUID values.

📈 Sample Output
json
Copy
Edit
{
  "first": "f23b7fa1-26c2-4b18-888e-96e5f9a4c762",
  "second": "f23b7fa1-26c2-4b18-888e-96e5f9a4c762"
}
If both GUIDs are the same → the same instance was injected
If different → multiple instances were created (e.g., Transient)

📌 Use Cases
Interview prep for DI concepts

Teaching DI behaviors in ASP.NET Core

Debugging service lifetimes in real-world projects
