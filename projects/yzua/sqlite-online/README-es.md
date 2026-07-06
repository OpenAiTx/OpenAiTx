# SQLite Online

<div align="center">
  <a href="https://yzua.github.io/sqlite-online/">
    <img
      src="https://github.com/user-attachments/assets/aef749bf-df08-4a84-8148-d34b796449d8"
      alt="Logo de SQLite Online"
      width="128"
    />
  </a>
</div>

Un editor SQLite del lado del cliente construido con React, TypeScript, Vite y `sql.js`.
Se ejecuta en el navegador, inicializa una base de datos de demostración por defecto, y puede abrir
archivos SQLite locales sin un backend.

## Visión general

- **Abrir archivos locales `.db`, `.sqlite` y `.sqlite3`**
- **Crear y modificar tablas, vistas e índices con SQL**
- **Navegar, filtrar, ordenar, paginar, añadir, editar y eliminar filas**
- **Ejecutar SQL personalizado y exportar resultados como CSV**

La mayor parte del trabajo con la base de datos se realiza localmente en el navegador mediante WebAssembly y un web
worker. Funciones opcionales como carga por URL, el proxy CORS de respaldo, Google
Fonts y la generación de consultas con Gemini usan solicitudes de red.

## Características

- **Edición de base de datos local-primero:** abrir archivos desde el disco, arrastrar y soltar una
  base de datos en la página, y descargar la base de datos actual como
  `database.sqlite`.
- **Flujos de trabajo de esquema y datos:** inspeccionar esquema, navegar datos de tablas, editar filas,
  insertar nuevas filas, eliminar filas y ejecutar sentencias SQL personalizadas.
- **Rutas de exportación CSV:** exportar una tabla completa, la página actual de la tabla, o el
  conjunto de resultados de la consulta personalizada actual como CSV.
- **Características adicionales de UX:** modo oscuro, modo de alto contraste, atajos de teclado,
  enlaces de salto y regiones en vivo para accesibilidad.
- **Integraciones opcionales:** cargar una base de datos desde un parámetro de consulta `?url=` y
  generar SQL desde indicaciones `/ai ...` tras configurar una clave API de Gemini.

## Desarrollo

```bash
npm install
npm run dev
```
Comandos útiles del proyecto:

- `npm run build`
- `npm run build:pages`
- `npm run typecheck`
- `npm run check`
- `npm run check:fix`
- `npm run doctor`
- `npm run preview`
- `npm run preview:pages`
- `npm run lint`
- `npm run lint:fix`
- `npm run format`
- `npm run format:check`
- `npm test`
- `npm run test:watch`
- `npm run knip`
- `npm run deploy`

## Atajos de teclado (Hotkeys)

Optimiza tu flujo de trabajo con estos atajos incorporados:

| Atajo                 | Acción                      |
| --------------------- | --------------------------- |
| **Ctrl + s**          | Descargar la base de datos  |
| **Ctrl + ArrowRight** | Ir a la página siguiente    |
| **Ctrl + ArrowUp**    | Saltar a la primera página  |
| **Ctrl + ArrowDown**  | Saltar a la última página   |
| **Ctrl + ArrowLeft**  | Ir a la página anterior     |
| **Ctrl + \`**         | Cerrar el panel de edición  |
| **Ctrl + i**          | Modo insertar / enviar inserción |
| **Ctrl + u**          | Enviar una edición de actualización |
| **Ctrl + d**          | Enviar una edición de eliminación |
| **Ctrl + q**          | Ejecutar la consulta SQL    |

## Licencia

SQLite Online se publica bajo la [GNU GPL v3.0](https://github.com/yzua/sqlite-online/blob/main/LICENSE).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-06

---