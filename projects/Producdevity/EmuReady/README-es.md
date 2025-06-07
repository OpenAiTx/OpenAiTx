# EmuReady

Una plataforma impulsada por la comunidad para rastrear la compatibilidad de emulación entre diferentes dispositivos y emuladores.

Visita nuestro sitio web: [https://emuready.com](https://emuready.com)

---

**Captura de pantalla de la página de inicio**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**Captura de pantalla de la página de listados de compatibilidad**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**Captura de pantalla de la página de juegos**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## Descripción general

EmuReady ayuda a los usuarios a compartir y descubrir información sobre la compatibilidad de emulación entre diferentes configuraciones de hardware y software. Los usuarios pueden contribuir con informes de compatibilidad, votar en los listados y debatir combinaciones específicas de juegos/dispositivos/emuladores.

![Licencia](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Estrellas](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## Características

- **Base de datos de compatibilidad integral**: Rastrea cómo funcionan los juegos en diferentes emuladores y dispositivos
- **Contribuciones de usuarios**: Informes impulsados por la comunidad y sistema de votación
- **Sistema de discusión**: Hilos de comentarios con funcionalidad de votos positivos/negativos
- **Panel de administración**: Gestiona usuarios, listados y moderación de contenido
- **Diseño responsivo**: Funciona en móviles, tablets y escritorio

## Mejoras recientes

El código base ha sido significativamente mejorado con las siguientes optimizaciones:

### Componentes de UI

- Creado un componente **ErrorBoundary** para un mejor manejo y recuperación de errores
- Añadido un componente **OptimizedImage** usando el componente Image de Next.js para mejor rendimiento
- Mejorada la **Paginación** con características de accesibilidad, navegación por teclado y mejor experiencia de usuario
- Mejorado el componente **Badge** con más variantes, tamaños y una opción de píldora
- Añadido componente **ThemeToggle** para cambiar entre temas claro, oscuro y del sistema
- Implementado **SortableHeader** para ordenamiento de tablas con indicadores visuales

### Caché y rendimiento

- Mejorada la configuración de React Query con mejores valores predeterminados para caché, tiempos de caducidad y lógica de reintento
- Añadida optimización de imágenes para imágenes de dispositivos
- Implementado un manejo de errores adecuado en toda la aplicación

### Accesibilidad

- Mejorada la navegación por teclado para elementos interactivos
- Añadidas etiquetas y roles ARIA apropiados
- Mejor gestión del enfoque
- Mejor contraste de colores en los componentes de la interfaz

### Seguridad

- Validación y saneamiento de datos en múltiples niveles (cliente, servidor, base de datos)
- Implementación de Content Security Policy
- Protección contra ataques XSS y CSRF
- Autenticación segura con NextAuth.js
- Validación y medidas de seguridad en carga de archivos
- Restricciones de longitud de entrada y saneamiento adecuado
- Validación de UUID para prevenir manipulación de parámetros

### Experiencia de desarrollo

- Añadidos scripts npm adicionales para el flujo de trabajo de desarrollo
- Mejor estructura de proyecto con exportaciones consistentes
- Mejor retroalimentación de errores con un ErrorBoundary personalizado
- Página 404 mejorada con opciones de navegación útiles

### Tematización

- Añadida detección de preferencia de tema del sistema
- Creado selector de tema con múltiples opciones de interfaz
- Mejorada la implementación del modo oscuro en los componentes

## Primeros pasos

### Requisitos previos

- Node.js 20+
- `npm`
- PostgreSQL (o SQLite para desarrollo)

### Instalación

1. Clona el repositorio

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. Instala las dependencias

```bash
npm install
```

3. Configura las variables de entorno

```bash
cp .env.example .env
```

Luego edita el archivo `.env` con tus credenciales de base de datos y otra configuración.

4. Configura la base de datos

```bash
npx prisma generate
npx prisma db push
```

5. Ejecuta el servidor de desarrollo

```bash
npm run dev
```

6. Abre [http://localhost:3000](http://localhost:3000) en tu navegador

## Scripts disponibles

- `npm run dev` - Inicia el servidor de desarrollo
- `npm run dev:strict` - Inicia con modo estricto de React
- `npm run build` - Compila para producción
- `npm run start` - Inicia el servidor en producción
- `npm run test` - Ejecuta pruebas
- `npm run lint` - Ejecuta ESLint
- `npm run lint:fix` - Corrige problemas de linting
- `npm run format` - Formatea el código con Prettier
- `npm run typecheck` - Verifica los tipos de TypeScript
- `npm run analyze` - Analiza el tamaño del bundle
- `npm run clean` - Limpia la caché de compilación
- `npm run prepare-deploy` - Prepara para despliegue (lint, typecheck, test, build)

### Comandos Prisma

- `npx prisma db seed` - Poblado inicial de la base de datos
- `npx prisma studio` - Abre Prisma Studio
- `npx prisma db pull` - Extrae el esquema de la base de datos
- `npx prisma db push` - Aplica el esquema de la base de datos

Consulta la [Referencia de Prisma CLI](https://www.prisma.io/docs/orm/reference/prisma-cli-reference) para más detalles.

## Stack Tecnológico

- **Framework**: Next.js 15
- **ORM de base de datos**: Prisma
- **API**: tRPC
- **Autenticación**: NextAuth.js
- **Estilos**: Tailwind CSS
- **Gestión de estado**: React Query
- **Chequeo de tipos**: TypeScript
- **Animaciones**: Framer Motion
- **Validación**: Zod, Content Security Policy, Validación de entrada

## Contribuir

¡Damos la bienvenida a contribuciones! Consulta nuestras [Guías de Contribución](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) para más detalles.

## Licencia

Este proyecto está bajo la Licencia MIT - consulta el archivo [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) para más detalles.

## Código de conducta (PENDIENTE)

Ten en cuenta que este proyecto se adhiere a un [Código de Conducta](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md). Al participar en este proyecto, aceptas cumplir sus términos.

## Seguridad (PENDIENTE)

Si descubres una vulnerabilidad de seguridad, por favor sigue nuestra [Política de Seguridad](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) para reportarla.

## Agradecimientos

- Todos nuestros [Colaboradores](https://github.com/Producdevity/emuready/graphs/contributors)
- La comunidad de emulación por la inspiración y el apoyo

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---