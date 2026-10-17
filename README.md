# Automation Reliability & Ownership Hub

## English

A personal learning project to identify business automations that need attention, explain their risk and bring together ownership and operational context.

### Current status

The React frontend runs locally. The backend is being migrated to .NET 10 / ASP.NET Core. The previous NestJS starter has been removed; the new API and its tests are not implemented yet. Business features, PostgreSQL integration and deployment are pending.

During this migration, CI checks the frontend build and lint only. Backend checks must be restored before merging the completed migration. The main branch is protected.

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

El frontend React funciona localmente. El backend está migrándose a .NET 10 / ASP.NET Core. Se ha retirado el ejemplo inicial de NestJS; la nueva API y sus tests todavía no están implementados. Las funcionalidades de negocio, la integración con PostgreSQL y el despliegue están pendientes.

Durante esta migración, CI comprueba únicamente el build y lint del frontend. Las comprobaciones del backend deben restablecerse antes de integrar la migración completa. La rama main está protegida.

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
