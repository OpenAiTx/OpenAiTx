# Servidor MCP de Raindrop.io

[![smithery badge](https://smithery.ai/badge/@adeze/raindrop-mcp)](https://smithery.ai/server/@adeze/raindrop-mcp)
[![npm version](https://badge.fury.io/js/%40adeze%2Fraindrop-mcp.svg)](https://www.npmjs.com/package/@adeze/raindrop-mcp)
[![Claude Desktop MCPB](https://img.shields.io/badge/Claude%20Desktop-MCPB-5B61FF?logo=claude&logoColor=white)](https://github.com/adeze/raindrop-mcp/releases)

Conecta Raindrop.io a tu asistente de IA con un servidor MCP sencillo. Úsalo para organizar, buscar y gestionar marcadores con lenguaje natural.

## Qué puede hacer

- Crear, actualizar y eliminar colecciones y marcadores
- Buscar marcadores por etiquetas, dominio, tipo, fecha y más
- Gestionar etiquetas (listar, renombrar, fusionar, eliminar)
- Leer resaltados de marcadores
- Editar marcadores en lote dentro de una colección
- Auditar enlaces rotos y duplicados, y gestionar la papelera

## Herramientas

- **diagnostics** - Información diagnóstica del servidor y métricas de salud de la biblioteca
- **collection_list** - Lista todas las colecciones en una lista plana
- **get_collection_tree** - Vista jerárquica de colecciones con rutas completas de migas de pan
- **collection_manage** - Crear, actualizar o eliminar colecciones
- **bookmark_search** - Búsqueda avanzada con filtros, etiquetas y paginación
- **bookmark_manage** - Crear, actualizar o eliminar marcadores
- **get_raindrop** - Obtener un marcador único por ID
- **list_raindrops** - Listar marcadores de una colección con paginación
- **get_suggestions** - Consejos de organización impulsados por IA (etiquetas/colecciones) para una URL o marcador
- **suggest_tags** - Sugerir etiquetas relevantes a partir de metadatos del marcador usando análisis asistido por IA
- **bulk_edit_raindrops** - Actualizar, mover o eliminar marcadores en lote dentro de una colección específica
- **tag_manage** - Renombrar, fusionar o eliminar etiquetas
- **highlight_manage** - Crear, actualizar o eliminar resaltados
- **library_audit** - Escanear la biblioteca para enlaces rotos, duplicados y elementos sin etiqueta
- **empty_trash** - Vaciar permanentemente la papelera (requiere confirmación)
- **cleanup_collections** - Eliminar colecciones vacías (requiere confirmación)
- **remove_duplicates** - Encontrar y eliminar marcadores duplicados con flujo de confirmación seguro

## Instalación

### Inicio rápido (Una línea)
| Herramienta         | Comando en una línea                                              |
| :----------------- | :---------------------------------------------------------------- |
| **Gemini CLI**     | `gemini extensions install https://github.com/adeze/raindrop-mcp`  |
| **Codex CLI**      | `codex mcp add raindrop -- npx -y @adeze/raindrop-mcp`             |
| **Claude Code**    | `claude mcp add raindrop -- npx -y @adeze/raindrop-mcp`            |
| **GitHub Copilot** | `gh copilot config mcp add raindrop -- npx -y @adeze/raindrop-mcp` |
| **Vercel Skills**  | `npx skills add adeze/raindrop-mcp`                                |

> **Nota**: Para las herramientas que agregan un servidor MCP mediante `npx`, debe tener la variable de entorno `RAINDROP_ACCESS_TOKEN` configurada en su shell o en la configuración del entorno de la herramienta.

### Vercel Skills (npx skills)

Este proyecto es compatible con el sistema [Vercel Skills](https://github.com/vercel/skills). Todos los manifiestos necesarios están presentes:

- `manifest.json`: Manifiesto MCP estándar para la definición del servidor.
- `SKILL.md`: Descripción estandarizada de la habilidad para el descubrimiento de agentes.
- `mcp.json`: Configuración raíz para clientes y registros MCP.

Para agregar este servidor a su directorio local de habilidades:


```bash
npx skills add adeze/raindrop-mcp --global
```
Para contribuir con esto al [Registro de Habilidades de Vercel](https://github.com/vercel/skills/tree/main/registry), envía una Pull Request añadiendo la URL de este repositorio al registro.

### Claude Desktop (MCPB)

Descarga el último raindrop-mcp.mcpb desde el Release de GitHub y añádelo a Claude Desktop:

- Releases: https://github.com/adeze/raindrop-mcp/releases

En Claude Desktop, añade el bundle y configura esta variable de entorno:

- RAINDROP_ACCESS_TOKEN (desde la configuración de integraciones de Raindrop.io)

### NPX (CLI)

Configura tu token API como variable de entorno y ejecuta:


```bash
export RAINDROP_ACCESS_TOKEN=YOUR_RAINDROP_ACCESS_TOKEN
npx @adeze/raindrop-mcp
```

### Configuración manual de MCP (mcp.json)

Agrega esto a la configuración de tu cliente MCP:

```json
{
  "servers": {
    "raindrop": {
      "type": "stdio",
      "command": "npx",
      "args": ["@adeze/raindrop-mcp@latest"],
      "env": {
        "RAINDROP_ACCESS_TOKEN": "YOUR_RAINDROP_ACCESS_TOKEN"
      }
    }
  }
}
```

## Requisitos

- Una cuenta de Raindrop.io  
- Un token de acceso API de Raindrop.io: https://app.raindrop.io/settings/integrations  

## Soporte

- Problemas: https://github.com/adeze/raindrop-mcp/issues  

## Lanzamiento

Este repositorio usa `semantic-release` como el único flujo de lanzamiento soportado.  

### Cómo funciona la publicación

- Los lanzamientos se ejecutan a partir de pushes a `master` mediante `.github/workflows/ci.yml`.  
- `semantic-release` analiza los mensajes de Commits Convencionales, calcula la siguiente versión, actualiza `CHANGELOG.md`, etiqueta/lanzamientos en GitHub y publica en npm.  
- Durante la preparación del lanzamiento, `.releaserc.json` sincroniza `manifest.json`, `mcp.json` y `gemini-extension.json`, luego construye `raindrop-mcp.mcpb` para que el lanzamiento de GitHub incluya el paquete.  

### Simulación de pre-lanzamiento

- Ejecuta `.github/workflows/release-dry-run.yml` con **Run workflow** antes de hacer un lanzamiento público.  
- Esto valida el cálculo de versión semántica, la autenticación del registro y el comportamiento del pipeline de lanzamiento sin publicar.  

### Secretos requeridos

- `GITHUB_TOKEN` es proporcionado por GitHub Actions para la automatización del lanzamiento.  

### Publicación confiable en npm

- La publicación en npm está configurada mediante la publicación confiable OIDC de GitHub Actions.  
- `NPM_TOKEN` no es requerido para el camino estándar de lanzamiento CI.  

### Validación local antes de fusionar  

```bash
bun run lint
bun run type-check
bun run test
bun run build
```

### Ejemplos de mensajes de commit

- `fix: manejar payload de fusión de etiqueta vacío`
- `feat: agregar filtro de ruta de colección`
- `feat!: eliminar parámetro de búsqueda obsoleto`

No aumente manualmente las versiones, no envíe etiquetas de lanzamiento ni ejecute comandos manuales de npm publish para lanzamientos normales.

## 📋 Mejoras Recientes (v2.4.x)

### Organización Inteligente y Jerarquía

- **Sugerencias de IA**: Nueva herramienta `get_suggestions` ofrece consejos organizativos usando la API de Raindrop y muestreo MCP.
- **Árbol de Colecciones**: La herramienta `get_collection_tree` proporciona una vista jerárquica con rutas completas de migas de pan.
- **Movimiento Masivo**: Añadida operación `move` a `bulk_edit_raindrops` para organización eficiente de la biblioteca.
- **Soporte de Paginación**: Estandarizados `list_raindrops` y `bookmark_search` con paginación para bibliotecas grandes.

### Seguridad y Calidad

- **Lógica de Confirmación**: Las herramientas destructivas (`empty_trash`, `cleanup_collections`) ahora requieren confirmación explícita.
- **Nomenclatura Estandarizada**: Todas las herramientas usan ahora convenciones consistentes en snake_case.
- **Pipeline CI/CD**: GitHub Actions mejorado con linting automatizado, chequeo de tipos y pruebas cruzadas entre transportes.
- **Calidad del Código**: Configuraciones establecidas para ESLint y Prettier para desarrollo mantenible.

## 📋 Mejoras Previas (v2.3.3)

### Limpieza Avanzada y Auditoría de Biblioteca

## 📋 Mejoras Previas (v2.3.2)

### Implementación de Enlaces de Recursos MCP

- Contenido `resource` moderno siguiendo las mejores prácticas actuales del SDK MCP
- Acceso eficiente a datos: las herramientas devuelven enlaces ligeros en lugar de payloads completos
- Mejor rendimiento: los clientes obtienen datos completos de marcadores/colecciones solo cuando es necesario
- Integración fluida con el sistema dinámico de recursos (`mcp://raindrop/{id}`)

### Actualizaciones del SDK y API

- Actualizado al SDK MCP más reciente soportado en este repositorio
- Registro moderno de herramientas con descripciones mejoradas
- Corrección de puntos finales de API y parámetros de ruta
- Todas las herramientas principales completamente funcionales

### Optimización de Herramientas

- Respuestas eficientes en recursos para listas de marcadores/colecciones
- Acceso dinámico a recursos vía `mcp://collection/{id}` y `mcp://raindrop/{id}`
- Mejor experiencia de usuario con cargas de lista más ligeras
- Cumplimiento completo de MCP con patrones oficiales del SDK

### Mejoras en la Capa de Servicio

- Código reducido mediante helpers comunes extraídos
- Manejo de errores y procesamiento de respuestas consistente
- Mayor seguridad de tipos con manejadores genéricos
- Construcción centralizada de puntos finales

### Mejoras en Pruebas

- Cobertura end-to-end más robusta para ejecución de herramientas MCP
- Pruebas de integración ampliadas para flujos reales de clientes

### Preparación MCP 2.0 (Operaciones Masivas)

- Bases para flujos de trabajo y herramientas de operaciones masivas MCP 2.0

### OAuth (Próximamente)

- Flujo de autenticación basado en OAuth para simplificar la configuración sin tokens manuales

### Nota

Disculpas a quienes se vieron afectados por las últimas compilaciones. Gracias por la paciencia y los reportes.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT - consulte el archivo [LICENSE](LICENSE) para más detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-11

---