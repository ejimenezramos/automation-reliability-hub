# Automation Reliability & Ownership Hub

## English

A personal learning project aimed at helping engineers identify which business automations need attention, understand why, and find the context needed to investigate.

### Current status

The initial React frontend and NestJS API run locally. GitHub Actions checks builds, lint and the existing API tests. The main branch is protected.

Business features, risk evaluation, database integration and deployment are not implemented yet.

### Development approach

The initial application structures were generated with Vite and Nest CLI. Elena Jiménez manually configures the project and is learning to implement meaningful product code, with AI assistance as an architect, tutor and reviewer.

### Requirements

- Node.js 24.21.0
- pnpm 12.10.1

### Local setup

From the repository root:

```bash
pnpm install --frozen-lockfile
```

Start each application in a separate terminal:

```bash
pnpm dev:web
```

```bash
pnpm dev:api
```

Default local addresses:

- Web: http://localhost:5173
- API: http://localhost:3000

The applications run independently; the frontend does not consume the API yet.

### Checks

Run from the repository root:

```bash
pnpm build
pnpm lint
pnpm test:api
pnpm test:api:e2e
```

The current tests cover the starter API controller and its HTTP response, not business rules.

---

## Español

Proyecto personal de aprendizaje orientado a ayudar a los ingenieros a identificar qué automatizaciones de negocio requieren atención, entender por qué y encontrar el contexto necesario para investigar.

### Estado actual

El frontend inicial de React y la API de NestJS funcionan localmente. GitHub Actions comprueba los builds, lint y los tests existentes de la API. La rama main está protegida.

Las funcionalidades de negocio, la evaluación del riesgo, la conexión a base de datos y el despliegue todavía no están implementados.

### Método de desarrollo

Las estructuras iniciales de las aplicaciones fueron generadas con Vite y Nest CLI. Elena Jiménez configura manualmente el proyecto y está aprendiendo a implementar el código significativo del producto, con asistencia de IA como arquitecto, tutor y revisor.

### Requisitos

- Node.js 24.21.0
- pnpm 12.10.1

### Preparación local

Desde la raíz del repositorio:

```bash
pnpm install --frozen-lockfile
```

Arranca cada aplicación en una terminal distinta:

```bash
pnpm dev:web
```

```bash
pnpm dev:api
```

Direcciones locales predeterminadas:

- Web: http://localhost:5173
- API: http://localhost:3000

Las aplicaciones funcionan por separado; el frontend todavía no consume la API.

### Comprobaciones

Ejecuta desde la raíz:

```bash
pnpm build
pnpm lint
pnpm test:api
pnpm test:api:e2e
```

Los tests actuales cubren el controlador inicial de la API y su respuesta HTTP, no las reglas de negocio.
