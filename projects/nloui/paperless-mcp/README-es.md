[![Insignia de Evaluación de Seguridad MseeP.ai](https://mseep.net/pr/nloui-paperless-mcp-badge.png)](https://mseep.ai/app/nloui-paperless-mcp)

# Servidor MCP Paperless-NGX

[![insignia smithery](https://smithery.ai/badge/@nloui/paperless-mcp)](https://smithery.ai/server/@nloui/paperless-mcp)

Un servidor MCP (Protocolo de Contexto de Modelo) para interactuar con un servidor API Paperless-NGX. Este servidor proporciona herramientas para gestionar documentos, etiquetas, corresponsales y tipos de documentos en su instancia de Paperless-NGX.

## Inicio rápido

### Instalación vía Smithery

Para instalar automáticamente el Servidor MCP Paperless NGX para Claude Desktop mediante [Smithery](https://smithery.ai/server/@nloui/paperless-mcp):

```bash
npx -y @smithery/cli install @nloui/paperless-mcp --client claude
```

### Instalación Manual
1. Instale el servidor MCP:
```bash
npm install -g paperless-mcp
```

2. Agréguelo a la configuración MCP de Claude:

Para la extensión de VSCode, edite `~/Library/Application Support/Code/User/globalStorage/saoudrizwan.claude-dev/settings/cline_mcp_settings.json`:
```json
{
  "mcpServers": {
    "paperless": {
      "command": "npx",
      "args": ["paperless-mcp", "http://your-paperless-instance:8000", "your-api-token"]
    }
  }
}
```

Para la aplicación de escritorio Claude, edite `~/Library/Application Support/Claude/claude_desktop_config.json`:
```json
{
  "mcpServers": {
    "paperless": {
      "command": "npx",
      "args": ["paperless-mcp", "http://your-paperless-instance:8000", "your-api-token"]
    }
  }
}
```
3. Obtén tu token de API:
   1. Inicia sesión en tu instancia de Paperless-NGX
   2. Haz clic en tu nombre de usuario en la esquina superior derecha
   3. Selecciona "Mi Perfil"
   4. Haz clic en el botón de flecha circular para generar un nuevo token

4. Reemplaza los marcadores de posición en tu configuración MCP:
   - `http://tu-instancia-paperless:8000` con la URL de tu Paperless-NGX
   - `tu-token-api` con el token que acabas de generar

¡Eso es todo! Ahora puedes pedirle a Claude que te ayude a gestionar tus documentos de Paperless-NGX.

## Ejemplo de Uso

Aquí tienes algunas cosas que puedes pedirle a Claude que haga:

- "Muéstrame todos los documentos etiquetados como 'Factura'"
- "Busca documentos que contengan 'declaración de impuestos'"
- "Crea una nueva etiqueta llamada 'Recibos' con color #FF0000"
- "Descarga el documento #123"
- "Lista todos los corresponsales"
- "Crea un nuevo tipo de documento llamado 'Estado de Cuenta'"

## Herramientas Disponibles

### Operaciones de Documentos

#### list_documents
Obtén una lista paginada de todos los documentos.

Parámetros:
- page (opcional): Número de página
- page_size (opcional): Número de documentos por página


```typescript
list_documents({
  page: 1,
  page_size: 25
})
```

#### get_document
Obtener un documento específico por ID.

Parámetros:
- id: ID del documento

```typescript
get_document({
  id: 123
})
```

#### search_documents
Búsqueda de texto completo en documentos.

Parámetros:
- query: Cadena de consulta de búsqueda

```typescript
search_documents({
  query: "invoice 2024"
})
```
#### download_document
Descargar un archivo de documento por ID.

Parámetros:
- id: ID del documento
- original (opcional): Si es verdadero, descarga el archivo original en lugar de la versión archivada


```typescript
download_document({
  id: 123,
  original: false
})
```

#### bulk_edit_documents
Realizar operaciones masivas en múltiples documentos.

Parámetros:
- documents: Array de IDs de documentos
- method: Uno de:
  - set_correspondent: Establecer el corresponsal para los documentos
  - set_document_type: Establecer el tipo de documento para los documentos
  - set_storage_path: Establecer la ruta de almacenamiento para los documentos
  - add_tag: Añadir una etiqueta a los documentos
  - remove_tag: Eliminar una etiqueta de los documentos
  - modify_tags: Añadir y/o eliminar múltiples etiquetas
  - delete: Eliminar documentos
  - reprocess: Reprocesar documentos
  - set_permissions: Establecer permisos de documentos
  - merge: Fusionar múltiples documentos
  - split: Dividir un documento en múltiples documentos
  - rotate: Rotar páginas del documento
  - delete_pages: Eliminar páginas específicas de un documento
- Parámetros adicionales según el método:
  - correspondent: ID para set_correspondent
  - document_type: ID para set_document_type
  - storage_path: ID para set_storage_path
  - tag: ID para add_tag/remove_tag
  - add_tags: Array de IDs de etiquetas para modify_tags
  - remove_tags: Array de IDs de etiquetas para modify_tags
  - permissions: Objeto para set_permissions con owner, permissions, flag de merge
  - metadata_document_id: ID para merge para especificar la fuente de metadatos
  - delete_originals: Booleano para merge/split
  - pages: Cadena para split "[1,2-3,4,5-7]" o delete_pages "[2,3,4]"
  - degrees: Número para rotate (90, 180, o 270)

Ejemplos:
```typescript
// Add a tag to multiple documents
bulk_edit_documents({
  documents: [1, 2, 3],
  method: "add_tag",
  tag: 5
})

// Set correspondent and document type
bulk_edit_documents({
  documents: [4, 5],
  method: "set_correspondent",
  correspondent: 2
})

// Merge documents
bulk_edit_documents({
  documents: [6, 7, 8],
  method: "merge",
  metadata_document_id: 6,
  delete_originals: true
})

// Split document into parts
bulk_edit_documents({
  documents: [9],
  method: "split",
  pages: "[1-2,3-4,5]"
})

// Modify multiple tags at once
bulk_edit_documents({
  documents: [10, 11],
  method: "modify_tags",
  add_tags: [1, 2],
  remove_tags: [3, 4]
})
```

#### post_document
Subir un nuevo documento a Paperless-NGX.

Parámetros:
- file: Contenido del archivo codificado en Base64
- filename: Nombre del archivo
- title (opcional): Título del documento
- created (opcional): Fecha y hora en que se creó el documento (ej. "2024-01-19" o "2024-01-19 06:15:00+02:00")
- correspondent (opcional): ID de un corresponsal
- document_type (opcional): ID de un tipo de documento
- storage_path (opcional): ID de una ruta de almacenamiento
- tags (opcional): Array de IDs de etiquetas
- archive_serial_number (opcional): Número de serie de archivo
- custom_fields (opcional): Array de IDs de campos personalizados

```typescript
post_document({
  file: "base64_encoded_content",
  filename: "invoice.pdf",
  title: "January Invoice",
  created: "2024-01-19",
  correspondent: 1,
  document_type: 2,
  tags: [1, 3],
  archive_serial_number: "2024-001"
})
```

### Operaciones de etiquetas

#### listar_etiquetas
Obtener todas las etiquetas.

```typescript
list_tags()
```

#### create_tag
Crear una nueva etiqueta.

Parámetros:
- name: Nombre de la etiqueta
- color (opcional): Código de color hexadecimal (p. ej., "#ff0000")
- match (opcional): Patrón de texto a coincidir
- matching_algorithm (opcional): Uno de "any", "all", "exact", "regular expression", "fuzzy"

```typescript
create_tag({
  name: "Invoice",
  color: "#ff0000",
  match: "invoice",
  matching_algorithm: "fuzzy"
})
```

### Operaciones de Corresponsales

#### list_correspondents
Obtener todos los corresponsales.

```typescript
list_correspondents()
```

#### create_correspondent
Crear un nuevo corresponsal.

Parámetros:
- name: Nombre del corresponsal
- match (opcional): Patrón de texto para coincidir
- matching_algorithm (opcional): Uno de "cualquiera", "todos", "exacto", "expresión regular", "difuso"

```typescript
create_correspondent({
  name: "ACME Corp",
  match: "ACME",
  matching_algorithm: "fuzzy"
})
```

### Operaciones de Tipo de Documento

#### list_document_types
Obtener todos los tipos de documento.

```typescript
list_document_types()
```

#### create_document_type
Crear un nuevo tipo de documento.

Parámetros:
- name: Nombre del tipo de documento
- match (opcional): Patrón de texto a coincidir
- matching_algorithm (opcional): Uno de "cualquiera", "todos", "exacto", "expresión regular", "difuso"

```typescript
create_document_type({
  name: "Invoice",
  match: "invoice total amount due",
  matching_algorithm: "any"
})
```

## Manejo de Errores

El servidor mostrará mensajes de error claros si:
- La URL o el token API de Paperless-NGX son incorrectos
- El servidor de Paperless-NGX no está disponible
- La operación solicitada falla
- Los parámetros proporcionados son inválidos

## Desarrollo

¿Quieres contribuir o modificar el servidor? Esto es lo que necesitas saber:

1. Clona el repositorio
2. Instala las dependencias:
```bash
npm install
```

3. Realice sus cambios en server.js
4. Pruebe localmente:
```bash
node server.js http://localhost:8000 your-test-token
```

El servidor está construido con:
- [litemcp](https://github.com/wong2/litemcp): Un framework de TypeScript para construir servidores MCP
- [zod](https://github.com/colinhacks/zod): Validación de esquemas con TypeScript como prioridad

## Documentación de la API

Este servidor MCP implementa puntos finales de la API REST de Paperless-NGX. Para más detalles sobre la API subyacente, consulte la [documentación oficial](https://docs.paperless-ngx.com/api/).

## Ejecución del Servidor MCP

El servidor MCP puede ejecutarse en dos modos:

### 1. stdio (predeterminado)

Este es el modo predeterminado. El servidor se comunica a través de stdio, adecuado para CLI e integraciones directas.

```
npm run start -- <baseUrl> <token>
```

### 2. HTTP (Transporte HTTP Transmisible)

Para ejecutar el servidor como un servicio HTTP, use la opción `--http`. También puede especificar el puerto con `--port` (por defecto: 3000). Este modo requiere que [Express](https://expressjs.com/) esté instalado (se incluye como dependencia).

```
npm run start -- <baseUrl> <token> --http --port 3000
```

- La API MCP estará disponible en `POST /mcp` en el puerto especificado.
- Cada solicitud se maneja sin estado, siguiendo el patrón [StreamableHTTPServerTransport](https://github.com/modelcontextprotocol/typescript-sdk).
- Las solicitudes GET y DELETE a `/mcp` devolverán 405 Método No Permitido.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-05

---