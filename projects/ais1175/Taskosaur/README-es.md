# Taskosaur

<img src="https://raw.githubusercontent.com/Taskosaur/Taskosaur/main/frontend/public/taskosaur-logo.svg" alt="Taskosaur Logo" width="128">

### Gestión de Proyectos de Código Abierto con Ejecución de Tareas por IA Conversacional

### 📹 Mira Taskosaur en Acción

[![Demostración de Taskosaur - La IA Convierte Solicitudes Simples en Proyectos Completos](https://img.youtube.com/vi/sv2lsteRKac/maxresdefault.jpg)](https://youtu.be/sv2lsteRKac)

*Haz clic para ver: Observa cómo funciona la Ejecución de Tareas por IA Conversacional en Taskosaur*

Taskosaur es una plataforma de gestión de proyectos de código abierto con IA conversacional para la ejecución de tareas dentro de la aplicación. El asistente de IA maneja tareas de gestión de proyectos mediante conversación natural, desde la creación de tareas hasta la gestión de flujos de trabajo directamente en la aplicación.

<!-- Badges -->

![Node.js](https://img.shields.io/badge/node-%3E%3D22.0.0-brightgreen.svg)
![TypeScript](https://img.shields.io/badge/typescript-%5E5.0.0-blue.svg)
![NestJS](https://img.shields.io/badge/nestjs-%5E11.0.0-red.svg)
![Next.js](https://img.shields.io/badge/nextjs-15.2.2-black.svg)
![PostgreSQL](https://img.shields.io/badge/postgresql-%3E%3D16-blue.svg)
![Redis](https://img.shields.io/badge/redis-%3E%3D7-red.svg)
![AI](https://img.shields.io/badge/AI-Powered-purple.svg)

Taskosaur combina funciones tradicionales de gestión de proyectos con Ejecución de Tareas por IA Conversacional, permitiéndote gestionar proyectos mediante conversación natural. En lugar de navegar por menús y formularios, puedes crear tareas, asignar trabajo y gestionar flujos de trabajo simplemente describiendo lo que necesitas.

## Características Clave

- 🤖 **IA Conversacional para Ejecución de Tareas** - Ejecuta tareas del proyecto mediante conversación natural directamente en la aplicación
- 💬 **Comandos en Lenguaje Natural** - "Crear sprint con bugs de alta prioridad de la semana pasada" se ejecuta automáticamente
- 🏠 **Autoalojado** - Tus datos permanecen en tu infraestructura
- 💰 **Trae Tu Propio LLM** - Usa tu propia clave API con OpenAI, Anthropic, OpenRouter o modelos locales
- 🔧 **Automatización del Navegador en la Aplicación** - La IA navega la interfaz y realiza acciones directamente dentro de la aplicación
- 📊 **Gestión Completa de Proyectos** - Tableros Kanban, sprints, dependencias de tareas, seguimiento del tiempo
- 🌐 **Código Abierto** - Disponible bajo la Licencia de Fuente Empresarial (BSL)

## Tabla de Contenidos

- [Características Clave](#características-clave)
- [Inicio Rápido](#inicio-rápido)
  - [Requisitos previos](#prerequisitos)
  - [Configuración de Docker (Recomendado)](#configuracion-de-docker-recomendado)
  - [Configuración manual](#configuracion-manual)
- [Desarrollo](#desarrollo)
- [Estructura del proyecto](#estructura-del-proyecto)
- [Despliegue](#despliegue)
- [Documentación API](#documentacion-api)
- [Contribuir](#contribuir)
- [Licencia](#licencia)
- [Soporte](#soporte)

## Inicio rápido

### Requisitos previos

- Node.js 22+ y npm 10+
- PostgreSQL 16+ (o Docker)
- Redis 7+ (o Docker)

### Configuración de Docker (Recomendado)

La forma más rápida de comenzar con Taskosaur es usando Docker Compose:

1. **Clonar el repositorio**

   ```bash
   git clone https://github.com/Taskosaur/Taskosaur.git taskosaur
   cd taskosaur
   ```
2. **Configurar las variables de entorno**

   ```bash
   cp .env.example .env
   ```
   Esto crea el archivo .env utilizado para la aplicación, puede personalizar los valores si lo necesita.
   
3. **Iniciar con Docker Compose**

   ```bash
   docker compose -f docker-compose.dev.yml up
   ```
   Esto automáticamente:
   - ✅ Inicia PostgreSQL y Redis
   - ✅ Instala todas las dependencias
   - ✅ Genera el cliente Prisma
   - ✅ Ejecuta las migraciones de la base de datos
   - ✅ Población de la base de datos con datos de ejemplo
   - ✅ Inicia tanto el backend como el frontend

4. **Accede a la aplicación**
   - Frontend: http://localhost:3001
   - API del backend: http://localhost:3000
   - Documentación API: http://localhost:3000/api/docs

Consulta [DOCKER_DEV_SETUP.md](https://raw.githubusercontent.com/ais1175/Taskosaur/main/DOCKER_DEV_SETUP.md) para la documentación detallada de Docker.

### Configuración Manual

Si prefieres ejecutar los servicios localmente:

1. **Clona el repositorio**


   ```bash
   git clone https://github.com/Taskosaur/Taskosaur.git taskosaur
   cd taskosaur
   ```
2. **Instalar dependencias**


   ```bash
   npm install
   ```

3. **Configuración del Entorno**

   Crea un archivo `.env` en el directorio raíz:

   ```env
   # Database Configuration
   DATABASE_URL="postgresql://taskosaur:taskosaur@localhost:5432/taskosaur"

   # Application
   NODE_ENV=development

   # Authentication & Security
   JWT_SECRET="your-jwt-secret-key-change-this"
   JWT_REFRESH_SECRET="your-refresh-secret-key-change-this-too"
   JWT_EXPIRES_IN="15m"
   JWT_REFRESH_EXPIRES_IN="7d"

   # Encryption for sensitive data
   ENCRYPTION_KEY="your-64-character-hex-encryption-key-change-this-to-random-value"

   # Redis Configuration (for Bull Queue)
   REDIS_HOST=localhost
   REDIS_PORT=6379
   REDIS_PASSWORD=

   # Email Configuration (optional, for notifications)
   SMTP_HOST=smtp.example.com
   SMTP_PORT=587
   SMTP_USER=your-email@taskosaur.com
   SMTP_PASS=your-app-password
   SMTP_FROM=noreply@taskosaur.com
   EMAIL_DOMAIN="taskosaur.com"

   # Frontend URL (for email links and CORS)
   FRONTEND_URL=http://localhost:3001
   CORS_ORIGIN="http://localhost:3001"

   # Backend API URL (for frontend to connect to backend)
   NEXT_PUBLIC_API_BASE_URL=http://localhost:3000/api

   # File Upload
   UPLOAD_DEST="./uploads"
   MAX_FILE_SIZE=10485760

   # Queue Configuration
   MAX_CONCURRENT_JOBS=5
   JOB_RETRY_ATTEMPTS=3
   ```

4. **Configurar la Base de Datos**

   ```bash
   # Run database migrations
   npm run db:migrate

   # Seed the database (idempotent - safe to run multiple times)
   npm run db:seed

   # Or seed with admin user only
   npm run db:seed:admin
   ```

5. **Iniciar la Aplicación**

   ```bash
   # Development mode (runs both frontend and backend)
   npm run dev

   # Or start individually
   npm run dev:frontend    # Start frontend only (port 3001)
   npm run dev:backend     # Start backend only (port 3000)
   ```

6. **Acceder a la Aplicación**
   - Frontend: http://localhost:3001
   - API Backend: http://localhost:3000
   - Documentación API: http://localhost:3000/api/docs

## Desarrollo

### Comandos Disponibles

Todos los comandos se ejecutan desde el directorio raíz:

#### Desarrollo

```bash
npm run dev              # Start both frontend and backend concurrently
npm run dev:frontend     # Start frontend only (Next.js on port 3001)
npm run dev:backend      # Start backend only (NestJS on port 3000)
```

#### Construir

```bash
npm run build            # Build all workspaces (frontend + backend)
npm run build:frontend   # Build frontend for production
npm run build:backend    # Build backend for production
npm run build:dist       # Build complete distribution package
```

#### Operaciones de Base de Datos

Todos los comandos de seed son **idempotentes** y seguros para ejecutarse múltiples veces:

```bash
npm run db:migrate         # Run database migrations
npm run db:migrate:deploy  # Deploy migrations (production)
npm run db:reset           # Reset database (deletes all data!)
npm run db:seed            # Seed database with sample data
npm run db:seed:admin      # Seed database with admin user only
npm run db:generate        # Generate Prisma client
npm run db:studio          # Open Prisma Studio (database GUI)
npm run prisma             # Run Prisma CLI commands directly
```

#### Pruebas

```bash
npm run test               # Run all tests
npm run test:frontend      # Run frontend tests
npm run test:backend       # Run backend unit tests
npm run test:watch         # Run backend tests in watch mode
npm run test:cov           # Run backend tests with coverage
npm run test:e2e           # Run backend end-to-end tests
```

#### Calidad del Código

```bash
npm run lint               # Lint all workspaces
npm run lint:frontend      # Lint frontend code
npm run lint:backend       # Lint backend code
npm run format             # Format backend code with Prettier
```

#### Limpieza

```bash
npm run clean              # Clean all build artifacts
npm run clean:frontend     # Clean frontend build artifacts
npm run clean:backend      # Clean backend build artifacts
```

### Git Hooks

Comprobaciones automáticas de calidad de código con **Husky**:

- **Pre-commit**: Ejecuta linters en todos los espacios de trabajo antes de cada commit
- Garantiza la calidad y consistencia del código
- Omitir con `--no-verify` (solo en emergencias)

```bash
git commit -m "feat: add feature"  # Runs checks automatically
```

## Estructura del Proyecto

```
taskosaur/
├── backend/                # NestJS Backend (Port 3000)
│   ├── src/
│   │   ├── modules/       # Feature modules
│   │   ├── common/        # Shared utilities
│   │   ├── config/        # Configuration
│   │   └── gateway/       # WebSocket gateway
│   ├── prisma/            # Database schema and migrations
│   ├── public/            # Static files
│   └── uploads/           # File uploads
├── frontend/              # Next.js Frontend (Port 3001)
│   ├── src/
│   │   ├── app/          # App Router pages
│   │   ├── components/   # React components
│   │   ├── contexts/     # React contexts
│   │   ├── hooks/        # Custom hooks
│   │   ├── lib/          # Utilities
│   │   └── types/        # TypeScript types
│   └── public/           # Static assets
├── docker/               # Docker configuration
│   └── entrypoint-dev.sh # Development entrypoint script
├── scripts/              # Build and utility scripts
├── .env.example          # Environment variables template
├── docker-compose.dev.yml # Docker Compose for development
└── package.json          # Root package configuration
```

## Configuración de Ejecución de Tareas de IA Conversacional

### Habilitar la Ejecución de Tareas de IA Conversacional en 3 Pasos:

1. **Navegar a Configuración de la Organización**

   ```
   Go to Settings → Organization Settings → AI Assistant Settings
   ```

2. **Añade tu clave API de LLM**

   - Activa "Habilitar chat de IA" en ON
   - Añade tu clave API de cualquier proveedor compatible:
     - **OpenRouter** (más de 100 modelos, opciones gratuitas): `https://openrouter.ai/api/v1`
     - **OpenAI** (modelos GPT): `https://api.openai.com/v1`
     - **Anthropic** (modelos Claude): `https://api.anthropic.com/v1`
     - **Local AI** (Ollama, etc.): Tu endpoint local

3. **Comienza a gestionar con IA**
   - Abre el panel de chat de IA (icono de chispas)
   - Escribe: _"Crear un nuevo proyecto llamado Rediseño de Sitio Web con 5 tareas"_
   - La IA ejecuta el flujo de trabajo automáticamente

### Cómo funciona la ejecución de tareas con IA conversacional

La ejecución de tareas con IA conversacional de Taskosaur presenta IA conversacional para la ejecución de tareas en la aplicación, realizando acciones directamente en lugar de solo proporcionar sugerencias:

- **Ejecución conversacional dentro de la aplicación** - Chatea de forma natural con la IA para ejecutar tareas directamente dentro de la aplicación
- **Automatización directa en el navegador** - La IA navega por tu interfaz y hace clic en botones en tiempo real
- **Ejecución de flujos de trabajo complejos** - Operaciones de múltiples pasos manejadas sin problemas mediante la conversación
- **Acciones con contexto** - Comprende el contexto actual de tu proyecto/espacio de trabajo
- **Interfaz en lenguaje natural** - No hay comandos que memorizar, solo habla de forma natural

**Ejemplos de comandos para ejecución de tareas con IA conversacional:**

```
"Set up a new marketing workspace with Q1 campaign project"
"Move all high-priority bugs to in-progress and assign to John"
"Create a sprint with tasks from last week's backlog"
"Generate a report of Sarah's completed tasks this month"
"Set up automated workflow: when task is marked done, create review subtask"
```
## Características

_Taskosaur está en desarrollo activo. Las siguientes características representan nuestras capacidades planificadas, con muchas ya implementadas y otras en progreso._

### 🤖 Capacidades de Ejecución de Tareas con IA Conversacional

🎯 **Ejecución Conversacional de Tareas Dentro de la Aplicación**

- **Interfaz de Chat Dentro de la Aplicación**: Conversa con la IA directamente dentro de Taskosaur para ejecutar tareas  
- **Ejecución de Tareas Basada en Navegador**: La IA navega por la interfaz, llena formularios y completa tareas en tiempo real  
- **Procesamiento de Flujos de Trabajo Multi-Paso**: Ejecuta flujos de trabajo complejos con un solo comando conversacional  
- **Comprensión del Contexto**: La IA reconoce tu espacio de trabajo actual, proyecto y contexto del equipo  
- **Sugerencias Proactivas**: La IA identifica cuellos de botella y sugiere mejoras mediante la conversación  

🧠 **Procesamiento de Lenguaje Natural**

- Entiende solicitudes complejas de gestión de proyectos  
- Extrae acciones, parámetros y contexto de entradas conversacionales  
- Infiera detalles faltantes a partir del contexto actual  

⚡ **Ejecución de Acciones**

- Automatización en vivo del navegador en tiempo real  
- Operaciones masivas sobre múltiples tareas a la vez  
- Funciona dentro de tus flujos de trabajo existentes  

🚀 **Soporte para Flujos de Trabajo de Proyectos**

- Planificación de sprints con análisis de tareas  
- Asignación de tareas basada en la capacidad del equipo  
- Pronóstico de la línea de tiempo del proyecto  

**Ejemplos de Ejecución de Tareas con IA Conversacional:**

- "Configura la campaña de marketing del Q1: crea espacio de trabajo, añade equipo, configura 3 proyectos con plantillas estándar"  
- "Analiza todas las tareas atrasadas y reprograma según la capacidad y prioridades del equipo"  
- "Crea flujo de trabajo automatizado: bugs de alta prioridad → asignar a desarrollador senior → notificar al líder de equipo"  
- "Genera retrospectiva de sprint con análisis de velocidad del equipo y sugerencias de mejora"  
- "Migra todas las tareas de diseño del proyecto antiguo al nuevo espacio de trabajo con asignaciones actualizadas"


### Gestión de la Organización

- **Arquitectura Multi-inquilino**: Soporte planeado para múltiples organizaciones con datos aislados
- **Organización del Espacio de Trabajo**: Agrupar proyectos dentro de espacios de trabajo para mejor organización
- **Control de Acceso Basado en Roles**: Implementación de permisos granulares (Administrador, Gerente, Miembro, Observador)
- **Gestión de Equipos**: Invitar y gestionar miembros del equipo a través de organizaciones

### Gestión de Proyectos

- **Estructura Flexible de Proyectos**: Crear y administrar proyectos con flujos de trabajo personalizados
- **Planificación de Sprints**: Gestión ágil de sprints planeada con planificación y seguimiento
- **Dependencias de Tareas**: Trabajo en relaciones entre tareas con varios tipos de dependencias
- **Flujos de Trabajo Personalizados**: Implementación de flujos de estado personalizados para diferentes necesidades del proyecto

### Gestión de Tareas

- **Tipos de Tareas Ricos**: Soporte para Tareas, Errores, Épicas, Historias y Subtareas
- **Gestión de Prioridades**: Establecer prioridades de tareas desde la Más Baja hasta la Más Alta
- **Campos Personalizados**: Añadir campos personalizados para capturar datos específicos del proyecto
- **Etiquetas y Marcas**: Organizar tareas con etiquetas personalizables
- **Seguimiento de Tiempo**: Registrar el tiempo dedicado a tareas con registros detallados
- **Adjuntos de Archivos**: Adjuntar archivos y documentos a las tareas
- **Comentarios y Menciones**: Colaborar mediante comentarios en tareas con menciones @
- **Observadores de Tareas**: Suscribirse a actualizaciones y notificaciones de tareas

### Múltiples Vistas

- **Tablero Kanban**: Gestión visual de tareas con arrastrar y soltar
- **Vista de Calendario**: Visualización planificada de horarios y líneas de tiempo
- **Diagramas de Gantt**: Visualización planeada de línea de tiempo del proyecto y dependencias
- **Vista de Lista**: Listado tradicional de tareas basado en tablas
- **Panel de Análisis**: Trabajo hacia métricas de proyectos, gráficos de quema y velocidad del equipo

### Automatización e Integraciones

- **Reglas de Automatización**: Flujos de trabajo de automatización personalizados planeados
- **Notificaciones por Email**: Alertas automatizadas por correo electrónico para actualizaciones de tareas
- **Actualizaciones en Tiempo Real**: Actualizaciones en vivo usando conexiones WebSocket
- **Registro de Actividades**: Registro exhaustivo de auditoría de todos los cambios
- **Funcionalidad de Búsqueda**: Trabajando para una búsqueda global a través de proyectos y tareas

### Análisis e Informes

- **Gráficos de Burndown del Sprint**: Seguimiento del progreso planificado del sprint
- **Velocidad del Equipo**: Monitoreo planificado del rendimiento del equipo a lo largo del tiempo
- **Distribución de Tareas**: Trabajando para la asignación de tareas y análisis de carga de trabajo
- **Informes Personalizados**: Generación planificada de informes específicos del proyecto

## Inicio Rápido

### Requisitos Previos

- Node.js 22+ y npm
- PostgreSQL 13+
- Redis 6+ (para trabajos en segundo plano)

### Instalación

1. **Clonar el repositorio**

   ```bash
   git clone https://github.com/Taskosaur/Taskosaur.git taskosaur
   cd taskosaur
   ```

2. **Instalar dependencias**

   ```bash
   npm install
   ```

   Esto automáticamente:
   - Instalará todas las dependencias del espacio de trabajo (frontend y backend)
   - Configurará los hooks de git Husky para la calidad del código

3. **Configuración del Entorno**

   Crea un archivo `.env` en el directorio raíz con la siguiente configuración:

   ```env
   # Database Configuration
   DATABASE_URL="postgresql://your-db-username:your-db-password@localhost:5432/taskosaur"

   # Authentication
   JWT_SECRET="your-jwt-secret-key-change-this"
   JWT_REFRESH_SECRET="your-refresh-secret-key-change-this-too"
   JWT_EXPIRES_IN="15m"
   JWT_REFRESH_EXPIRES_IN="7d"

   # Redis Configuration (for Bull Queue)
   REDIS_HOST=localhost
   REDIS_PORT=6379
   REDIS_PASSWORD=

   # Email Configuration (for notifications)
   SMTP_HOST=smtp.gmail.com
   SMTP_PORT=587
   SMTP_USER=your-email@gmail.com
   SMTP_PASS=your-app-password
   SMTP_FROM=noreply@taskosaur.com

   # Frontend URL (for email links)
   FRONTEND_URL=http://localhost:3000

   # File Upload
   UPLOAD_DEST="./uploads"
   MAX_FILE_SIZE=10485760

   # Queue Configuration
   MAX_CONCURRENT_JOBS=5
   JOB_RETRY_ATTEMPTS=3

   # Frontend Configuration
   NEXT_PUBLIC_API_BASE_URL=http://localhost:3001/api
   ```

4. **Configurar la Base de Datos**

   ```bash
   # Run database migrations
   npm run db:migrate

   # Seed the database with core data
   npm run db:seed
   ```

5. **Iniciar la Aplicación**

   ```bash
   # Development mode (with hot reload for both frontend and backend)
   npm run dev

   # Or start individually
   npm run dev:frontend    # Start frontend only
   npm run dev:backend     # Start backend only
   ```

6. **Accede a la Aplicación**
   - Frontend: [http://localhost:3000](http://localhost:3000)
   - API Backend: [http://localhost:3001/api](http://localhost:3001/api)
   - Documentación API: [http://localhost:3001/api/docs](http://localhost:3001/api/docs)

## Desarrollo

### Comandos Disponibles

Todos los comandos se ejecutan desde el directorio raíz. Las variables de entorno se cargan automáticamente desde el archivo `.env` en la raíz.

#### Desarrollo

```bash
# Start both frontend and backend
npm run dev

# Start individually
npm run dev:frontend       # Start frontend dev server
npm run dev:backend        # Start backend dev server with hot reload
```

#### Construir

```bash
# Build all workspaces
npm run build

# Build individually
npm run build:frontend     # Build frontend for production
npm run build:backend      # Build backend for production
npm run build:dist         # Build complete distribution package
```

#### Operaciones de Base de Datos

```bash
npm run db:migrate         # Run database migrations
npm run db:migrate:deploy  # Deploy migrations (production)
npm run db:reset           # Reset database (deletes all data!)
npm run db:seed            # Seed database with core data
npm run db:seed:admin      # Seed database with admin user
npm run db:generate        # Generate Prisma client
npm run db:studio          # Open Prisma Studio
npm run prisma             # Run Prisma CLI commands
```

#### Pruebas

```bash
npm run test               # Run all tests
npm run test:frontend      # Run frontend tests
npm run test:backend       # Run backend unit tests
npm run test:watch         # Run backend tests in watch mode
npm run test:cov           # Run backend tests with coverage
npm run test:e2e           # Run backend end-to-end tests
```
#### Calidad del Código


```bash
npm run lint               # Lint all workspaces
npm run lint:frontend      # Lint frontend code
npm run lint:backend       # Lint backend code
npm run format             # Format backend code with Prettier
```

#### Limpieza

```bash
npm run clean              # Clean all workspaces and root
npm run clean:frontend     # Clean frontend build artifacts
npm run clean:backend      # Clean backend build artifacts
```

### Calidad del Código y Hooks de Git

Formateo automático de código y linting con **Prettier**, **ESLint** y **Husky**.

```bash
# Lint all workspaces
npm run lint                # Lint all workspaces

# Lint individually
npm run lint:frontend       # Frontend only
npm run lint:backend        # Backend only

# Format backend code
npm run format              # Format backend code with Prettier
```

**Pre-commit Hook**: Formatea, lint y valida automáticamente el código en cada commit mediante Husky.

```bash
# Commits run checks automatically
git commit -m "feat: add feature"

# Bypass checks in emergencies only
git commit -m "fix: urgent hotfix" --no-verify
```

## Estructura del Proyecto

```
taskosaur/
├── backend/                 # NestJS Backend
│   ├── src/
│   │   ├── modules/        # Feature modules
│   │   ├── config/         # Configuration files
│   │   ├── gateway/        # WebSocket gateway
│   │   └── prisma/         # Database service
│   ├── prisma/             # Database schema and migrations
│   └── uploads/            # File uploads
├── frontend/               # Next.js Frontend
│   ├── src/
│   │   ├── app/           # App Router pages
│   │   ├── components/    # React components
│   │   ├── contexts/      # React contexts
│   │   ├── hooks/         # Custom hooks
│   │   ├── styles/        # CSS styles
│   │   ├── types/         # TypeScript types
│   │   └── utils/         # Utility functions
│   └── public/            # Static assets
└── README.md
```

## Despliegue

### Despliegue en Producción

#### Uso de Docker (Recomendado)

```bash
# Clone the repository
git clone https://github.com/Taskosaur/Taskosaur.git taskosaur
cd taskosaur

# Setup environment variables
cp .env.example .env
```

**⚠️ IMPORTANTE:** Edite `.env` y actualice con valores seguros para producción:
- Genere secretos únicos y fuertes para `JWT_SECRET`, `JWT_REFRESH_SECRET`, `ENCRYPTION_KEY`
- Establezca credenciales seguras para la base de datos
- Configure las URLs de su dominio (`FRONTEND_URL`, `CORS_ORIGIN`, `NEXT_PUBLIC_API_BASE_URL`)
- Configure los ajustes SMTP para notificaciones por correo electrónico
- **Nunca use los valores de ejemplo/predeterminados en producción**

```bash
# Build and run with Docker Compose
docker-compose -f docker-compose.prod.yml up -d
```

#### Despliegue Manual

**Requisitos Previos para Producción:**

- Node.js 22+ LTS
- PostgreSQL 13+
- Redis 6+
- Proxy inverso (se recomienda Nginx)

**Pasos de Despliegue:**

```bash
# From root directory
npm install

# Run database migrations
npm run db:migrate:deploy

# Generate Prisma client
npm run db:generate

# Build distribution package
npm run build:dist

# Start the application
# Backend: dist/main.js
# Frontend: dist/public/
# Serve with your preferred Node.js process manager (PM2, systemd, etc.)
```

#### Variables de Entorno para Producción

Actualiza tu archivo `.env` para producción:

```env
NODE_ENV=production

# Database Configuration
DATABASE_URL="postgresql://username:password@your-db-host:5432/taskosaur"

# Authentication
JWT_SECRET="your-secure-production-jwt-secret"
JWT_REFRESH_SECRET="your-secure-production-refresh-secret"

# Redis Configuration
REDIS_HOST="your-redis-host"
REDIS_PORT=6379
REDIS_PASSWORD="your-redis-password"

# CORS Configuration
CORS_ORIGIN="https://your-domain.com"

# Frontend Configuration
NEXT_PUBLIC_API_BASE_URL=https://api.your-domain.com/api
FRONTEND_URL=https://your-domain.com
```

#### Plataformas de Hosting

**Plataformas recomendadas:**

- **Backend**: Railway, Render, DigitalOcean App Platform
- **Frontend**: Vercel, Netlify, Railway
- **Base de datos**: Railway PostgreSQL, Supabase, AWS RDS
- **Redis**: Railway Redis, Redis Cloud, AWS ElastiCache

## Documentación de la API

La documentación de la API se genera automáticamente usando Swagger:

- Desarrollo: http://localhost:3000/api/docs
- Producción: `https://api.your-domain.com/api/docs`

## Contribuciones

¡Damos la bienvenida a las contribuciones! Por favor, consulte nuestras [Directrices para Contribuir](https://raw.githubusercontent.com/ais1175/Taskosaur/main/CONTRIBUTING.md) para más detalles.

1. Haz un fork del repositorio
2. Crea una rama de funcionalidad (`git checkout -b feature/amazing-feature`)
3. Confirma tus cambios (`git commit -m 'feat: add amazing feature'`)
4. Sube la rama (`git push origin feature/amazing-feature`)
5. Abre un Pull Request

### Directrices de Desarrollo

- **Estilo de Código**: Sigue el estilo de código existente, los linters se ejecutan automáticamente al confirmar
- **TypeScript**: Usa TypeScript estricto con anotaciones de tipo adecuadas
- **Pruebas**: Escribe pruebas para nuevas funcionalidades y corrección de errores
- **Documentación**: Actualiza la documentación para cualquier cambio en la API
- **Mensajes de Commit**: Usa mensajes de commit convencionales (feat, fix, docs, etc.)

## Licencia

Este proyecto está licenciado bajo la Business Source License - consulta el archivo [LICENSE](https://raw.githubusercontent.com/ais1175/Taskosaur/main/LICENSE.md) para más detalles.

## Agradecimientos

- [NestJS](https://nestjs.com/) - Framework de backend
- [Next.js](https://nextjs.org/) - Framework de frontend
- [Prisma](https://prisma.io/) - ORM de base de datos
- [Tailwind CSS](https://tailwindcss.com/) - Framework de CSS

## Soporte

- Correo electrónico: support@taskosaur.com
- Discord: [Únete a nuestra comunidad](https://discord.gg/5cpHUSxePp)
- Problemas: [GitHub Issues](https://github.com/Taskosaur/Taskosaur/issues)
- Discusiones: [GitHub Discussions](https://github.com/Taskosaur/Taskosaur/discussions)

---

Construido con amor por el equipo de Taskosaur


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-13

---