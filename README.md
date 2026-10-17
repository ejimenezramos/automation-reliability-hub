# Automation Reliability & Ownership Hub

## English

A personal learning project to identify business automations that need attention, explain their risk and bring together ownership and operational context.

### Current status

The project uses React and TypeScript for the frontend and .NET 10 / ASP.NET Core for the planned backend. The frontend runs locally. API implementation, backend tests, business features, PostgreSQL integration and deployment are pending.

CI currently checks the frontend build and lint. Backend build and test checks will be added with the API. The main branch is protected.

### Development approach

The React structure was generated with Vite. Elena Jiménez writes meaningful product code manually, with AI assistance as architect, tutor and reviewer. The planned backend uses C# and .NET 10.

### Requirements and local setup

- Node.js 24.21.0
- pnpm 12.10.1
- .NET 10 SDK for the upcoming API

From the repository root:

```bash
pnpm install --frozen-lockfile
pnpm dev:web
```

Web: http://localhost:5173. The frontend does not consume an API yet.

### Current checks

```bash
pnpm build
pnpm lint
```

These commands currently check the frontend only. API start and test commands will be added with the .NET implementation.

---

## Español

Proyecto personal de aprendizaje para identificar automatizaciones de negocio que requieren atención, explicar su riesgo y reunir su ownership y contexto operativo.

### Estado actual

El proyecto utiliza React y TypeScript para el frontend y .NET 10 / ASP.NET Core como backend previsto. El frontend funciona localmente. La implementación de la API, los tests del backend, las funcionalidades de negocio, la integración con PostgreSQL y el despliegue están pendientes.

CI comprueba actualmente el build y lint del frontend. Las comprobaciones de build y tests del backend se añadirán con la API. La rama main está protegida.

### Método de desarrollo

La estructura React se generó con Vite. Elena Jiménez escribe manualmente el código significativo del producto, con asistencia de IA como arquitecto, tutor y revisor. El backend previsto utiliza C# y .NET 10.

### Requisitos y preparación local

- Node.js 24.21.0
- pnpm 12.10.1
- SDK .NET 10 para la futura API

Desde la raíz del repositorio:

```bash
pnpm install --frozen-lockfile
pnpm dev:web
```

Web: http://localhost:5173. El frontend todavía no consume una API.

### Comprobaciones actuales

```bash
pnpm build
pnpm lint
```

Actualmente estos comandos comprueban sólo el frontend. Los comandos de arranque y tests de la API se añadirán con la implementación .NET.
