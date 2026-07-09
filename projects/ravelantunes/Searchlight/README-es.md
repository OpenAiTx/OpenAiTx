# Searchlight - Cliente Postgres para MacOS

![Captura de pantalla de Searchlight](https://raw.githubusercontent.com/ravelantunes/Searchlight/main/./docs/screenshot1.png)

Searchlight es un cliente nativo de PostgreSQL para macOS, de código abierto, diseñado para ser simple, ligero y amigable para desarrolladores. Ofrece una interfaz limpia e intuitiva para gestionar bases de datos y ejecutar consultas sin la complejidad de herramientas de gestión de bases de datos a gran escala. Searchlight se enfoca en brindar una experiencia fluida y eficiente para desarrolladores que necesitan acceso rápido y sencillo a sus bases de datos PostgreSQL.

## Instalación

Descarga la última versión desde la [Página de Releases](https://github.com/ravelantunes/Searchlight/releases).

> Estoy usando mi cuenta personal de desarrollador Apple, por lo que no puedo notarizar la app con Apple. Si intentas instalar desde la página de releases de GitHub, macOS advertirá que no puede verificar la identidad del desarrollador, por lo que deberás aprobar la instalación en Configuración > Privacidad, o compilar desde el código fuente.

## Funcionalidades actuales

### Gestión de Conexiones

- Guardar y gestionar conexiones favoritas
- Soporte de túnel SSH con autenticación basada en clave
- Soporte de conexión SSL/TLS

### Navegador de Bases de Datos

- Navegar bases de datos, esquemas y tablas
- Búsqueda rápida y filtrado en datos de tablas
- Enlace de relaciones por clave foránea — hacer clic para navegar a registros relacionados
- Ventana emergente con estadísticas de columnas — ver valores únicos, conteos de nulos y gráficos de distribución de valores

### Manipulación de Datos

- Insertar nuevas filas directamente en la tabla
- Copiar valor de celda, fila, columnas en diferentes formatos
- Autocompletar/búsqueda de datos desde referencias de claves foráneas al insertar datos
- Formatos de exportación: Texto plano, CSV, sentencias SQL INSERT

### Editor de Consultas

- Ejecución libre de consultas SQL
- Soporte SQL LSP para autocompletado, diagnóstico y documentación emergente

## Compilar desde el código fuente
1. Clona el repositorio  
2. Abre `Searchlight.xcodeproj` en Xcode  
3. Compila dos veces (⌘B, ⌘B) — la primera compilación descarga las dependencias, la segunda las incluye  
4. Ejecuta (⌘R)  

La primera compilación descarga automáticamente el binario de [Postgres Language Server](https://github.com/supabase-community/postgres-language-server) (~16MB) para autocompletado SQL, comprobación de sintaxis y documentación al pasar el cursor. Se necesita una segunda compilación para integrarlo en la aplicación.  

> **Nota:** El binario LSP es solo para Apple Silicon (arm64).  

## Tecnología utilizada  

- **Swift & SwiftUI** — Aplicación nativa para macOS con integración AppKit para vistas avanzadas de tablas  
- **PostgresKit / PostgresNIO** — Driver PostgreSQL con agrupación de conexiones  
- **SwiftNIO** — Fundamento de redes asíncronas  
- **SSH del sistema** — Soporte nativo de túneles SSH usando herramientas del sistema macOS  
- **Postgres Language Server** — Inteligencia SQL (autocompletado, diagnósticos, documentación al pasar el cursor)  

## Contribuciones  

¡Las contribuciones son bienvenidas! No dudes en abrir issues o enviar pull requests.  

## Licencia  

Consulta [LICENSE](LICENSE) para más detalles.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-09

---