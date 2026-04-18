# TaskFlow API

A full stack task management system built with ASP.NET Core 10, React, JWT Authentication, and SQLite.

## 🚀 Live Demo
- API: [Railway URL - coming soon]
- Frontend: [Vercel URL - coming soon]

## 🛠 Tech Stack
- **Backend:** ASP.NET Core 10, C#, Entity Framework Core
- **Frontend:** React, Axios, React Router
- **Database:** SQLite
- **Auth:** JWT Bearer Token + BCrypt password hashing
- **Deployment:** Railway (API) + Vercel (React)

## ✨ Features
- User Registration & Login with JWT Auth
- Create, Read, Update, Delete Tasks
- Kanban Board (Todo / In Progress / Done)
- Move tasks between columns
- Protected routes

## 📡 API Endpoints
| Method | Endpoint | Description |
|--------|----------|-------------|
| POST | /api/Auth/register | Register user |
| POST | /api/Auth/login | Login + get token |
| GET | /api/Tasks | Get all tasks |
| POST | /api/Tasks | Create task |
| PUT | /api/Tasks/{id} | Update task |
| DELETE | /api/Tasks/{id} | Delete task |

## 🏃 Run Locally
```bash
git clone https://github.com/rouprita/taskFlow-api.git
cd taskFlow-api
dotnet restore
dotnet ef database update
dotnet run
```

Visit `http://localhost:5000/swagger`