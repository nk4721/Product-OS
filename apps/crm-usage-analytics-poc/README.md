# CRM Usage Analytics POC

A proof of concept for measuring SuperOffice CRM usage by user and team.

## What this POC does

- Shows overall CRM adoption metrics
- Calculates an Adoption Score per user and team
- Displays active users, inactive users and team comparison
- Uses demo data first
- Is structured so the demo repository can later be replaced by real SuperOffice API calls

## Stack

- Backend: ASP.NET Core Web API
- Frontend: React + TypeScript + Vite
- Data: In-memory demo data for the first POC

## Run locally

### Backend

```bash
cd apps/crm-usage-analytics-poc/backend
dotnet restore
dotnet run
```

The API will run on `http://localhost:5088`.

### Frontend

Open a second terminal:

```bash
cd apps/crm-usage-analytics-poc/frontend
npm install
npm run dev
```

The dashboard will run on `http://localhost:5173`.

## API endpoints

- `GET /api/usage/summary`
- `GET /api/usage/users`
- `GET /api/usage/teams`

## Next step

Validate which usage signals are available through the SuperOffice API:

- login history
- activities created
- opportunities updated
- companies updated
- contacts updated
- emails logged
- notes created
