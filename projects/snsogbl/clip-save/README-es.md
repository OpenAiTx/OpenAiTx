# ClipSave - Herramienta de gestión del historial del portapapeles

Una herramienta multiplataforma para la gestión del historial del portapapeles basada en Wails + Vue 3 + TypeScript.

## Disponible en App Store
https://apps.apple.com/us/app/剪存/id6754015301

## Características
- [Nuevo script personalizado - haz clic para ver](https://raw.githubusercontent.com/snsogbl/clip-save/main/scriptingExample/README.md)
- Guardado automático del historial del portapapeles
- Soporta múltiples tipos como texto, imágenes, archivos, etc.
- Función de búsqueda y filtrado en tiempo real (soporta búsqueda de texto OCR en imágenes)
- Almacenamiento local en base de datos SQLite (todos los datos se almacenan localmente, garantizando privacidad y seguridad)
- Configuración personalizada: protección con contraseña, limpieza automática, configuración de atajos de teclado

## Capturas del proyecto

<img src="https://raw.githubusercontent.com/snsogbl/clip-save/master/screenshots/clipboard-1.png" alt="Captura" width="960">


## Tecnologías

- **Backend**: Go + Wails v2
- **Frontend**: Vue 3 + TypeScript + Vite
- **Base de datos**: SQLite3
- **Portapapeles**: golang.design/x/clipboard

## Instalación de dependencias

### 1. Instalar Wails CLI

```bash
go install github.com/wailsapp/wails/v2/cmd/wails@latest
```

### 2. Instalación de las dependencias del proyecto

```bash
# Go 依赖
go mod tidy

# 前端依赖
cd frontend
npm install
```

## 开发

### 启动开发服务器

```bash
wails dev
```

Esto iniciará el servidor de desarrollo con recarga en caliente:
- Las modificaciones en el código Go del backend se recompilarán automáticamente
- Las modificaciones en el código Vue del frontend se recargarán en caliente automáticamente

### Depuración durante el desarrollo

En modo desarrollo, la aplicación abrirá automáticamente las herramientas de desarrollador, donde se puede ver:
- Registros de la consola
- Solicitudes de red
- Estado de los componentes frontend

## Construcción

### Construcción de la versión de producción

```bash
wails build
```

Después de la compilación, el archivo ejecutable se ubicará en el directorio `build/bin/`.

### Despliegue de scripts personalizados en Cloudflare Pages

El proyecto utiliza Cloudflare Pages para alojar la lista de scripts en línea, permitiendo a los usuarios instalar y actualizar scripts directamente desde el "mercado de scripts".

#### 1. Instalar Wrangler CLI

```bash
npm install -g wrangler
```
#### 2. Iniciar sesión en Cloudflare


```bash
wrangler login
```

Esto abrirá el navegador e iniciará sesión en tu cuenta de Cloudflare.

#### 3. Desplegar el script

```bash
wrangler pages deploy scriptingExample --project-name=clip-save-plugins
```

Después de la implementación, el script estará disponible en la siguiente URL:
- Lista de plugins: `https://clip-save-plugins.pages.dev/plugins.json`
- Archivo del script: `https://clip-save-plugins.pages.dev/{nombreDelArchivoDelScript}.js`

#### 4. Actualizar el script

Cada vez que modifique un archivo en el directorio `scriptingExample`, vuelva a ejecutar el comando de implementación:

```bash
wrangler pages deploy scriptingExample --project-name=clip-save-plugins
```

#### 5. Consideraciones

- Asegúrese de que `scriptUrl` en `plugins.json` utilice la URL de Cloudflare Pages  
- Generalmente surte efecto en unos segundos después del despliegue (el tiempo de caché de Cloudflare Pages es muy corto)  
- Puede ver el historial de despliegue y los registros a través del Panel de Control de Cloudflare  

### Opciones de compilación para macOS

```bash
# 构建 Intel 版本
wails build -platform darwin/amd64

# 构建 Apple Silicon 版本
wails build -platform darwin/arm64

# 构建通用二进制（推荐）
wails build -platform darwin/universal
```

### Construcción en Windows

```bash
wails build -platform windows/amd64
```
### Construcción en Linux


```bash
wails build -platform linux/amd64
```

## Estructura del proyecto

```
.
├── main.go                      # 主程序入口
├── app.go                       # Wails 应用结构和 API
├── wails.json                   # Wails 配置文件
├── go.mod                       # Go 依赖管理
├── common/                      # 共享代码
│   ├── clipboard.go             # 剪贴板逻辑
│   ├── clipboard_darwin.go      # macOS 特定代码
│   └── db.go                    # 数据库操作
├── frontend/                    # 前端代码
│   ├── src/
│   │   ├── App.vue              # 主应用组件
│   │   ├── components/
│   │   │   └── ClipboardHistory.vue  # 剪贴板历史组件
│   │   ├── main.ts              # 前端入口
│   │   └── style.css            # 全局样式
│   ├── index.html               # HTML 模板
│   ├── package.json             # 前端依赖
│   ├── vite.config.ts           # Vite 配置
│   └── tsconfig.json            # TypeScript 配置
└── build/                       # 构建资源和输出
    ├── bin/                     # 编译后的可执行文件
    ├── appicon.png              # 应用图标
    └── darwin/                  # macOS 特定配置
```

## Descripción de la API

### API Backend (Go)

Los métodos definidos en `app.go` se expondrán automáticamente al frontend:

- `SearchClipboardItems(keyword, filterType, limit)` - Buscar elementos del portapapeles
- `GetClipboardItems(limit)` - Obtener lista del portapapeles
- `GetClipboardItemByID(id)` - Obtener elemento por ID
- `CopyToClipboard(id)` - Copiar elemento al portapapeles
- `DeleteClipboardItem(id)` - Eliminar elemento
- `GetStatistics()` - Obtener estadísticas

### Ejemplo de llamada desde frontend

```typescript
import { SearchClipboardItems } from '../wailsjs/go/main/App'

// 搜索剪贴板项目
const items = await SearchClipboardItems('关键词', '所有类型', 100)
```

## Instrucciones de uso

1. Después de iniciar la aplicación, guardará automáticamente el portapapeles del sistema en segundo plano
2. Cada vez que se copie contenido, se guardará automáticamente en el historial
3. Use el cuadro de búsqueda superior para buscar rápidamente en el historial (soporta búsqueda de texto OCR en imágenes)
4. Use filtros para filtrar contenido por tipo (texto/imagen/URL, etc.)
5. Haga clic en cualquier registro del historial para ver detalles
6. Para contenido de tipo imagen, haga clic en el botón "Extraer texto" para ver el resultado del reconocimiento OCR
7. Haga clic en el botón "Copiar" para copiar el contenido de nuevo al portapapeles
8. Haga clic en el botón "Eliminar" para borrar registros del historial

### Función de reconocimiento OCR de texto

- **Reconocimiento automático**: después de copiar una imagen, la aplicación reconocerá automáticamente el texto en la imagen en segundo plano (macOS 10.15+)
- **Búsqueda inteligente**: el texto reconocido se añadirá automáticamente al índice de búsqueda, ingrese palabras clave para encontrar imágenes que contengan ese texto
- **Extracción manual**: en la página de detalles de la imagen, haga clic en el botón "Extraer texto" para ver el resultado completo del reconocimiento OCR
- **Idiomas soportados**: reconocimiento de chino (simplificado/tradicional) e inglés
- **Optimización de rendimiento**: la misma imagen solo se reconoce una vez, reutilizando automáticamente el resultado para mejorar el rendimiento

## Almacenamiento de datos

El historial del portapapeles se guarda en: `~/.clipsave/clipboard.db`

La base de datos se crea automáticamente y contiene los siguientes campos:
- ID - Identificador único
- Content - Texto del contenido
- ContentType - Tipo de contenido
- ImageData - Datos de la imagen (formato PNG)
- Timestamp - Marca de tiempo
- Source - Fuente
- CharCount - Número de caracteres
- WordCount - Número de palabras
- OCRText - Texto reconocido por OCR (exclusivo para tipo imagen, usado para búsqueda)

## Requisitos del sistema

- **macOS**: 10.15 Catalina o superior (se requiere función OCR)
- **Windows**: Windows 10/11 (1809 o superior) + WebView2
- **Linux**: Distribuciones que soporten WebKit2GTK
- **Go**: versión 1.21 o superior  
- **Node.js**: versión 16 o superior  

## Consideraciones para el desarrollo  

### Después de actualizar la API de Go  

Cada vez que se modifique un método en `app.go`, es necesario regenerar el enlace del frontend:  

```bash
wails generate module
```
O usar el modo de desarrollo, generará automáticamente:


```bash
wails dev
```
### Desarrollo Frontend

El frontend utiliza Vite + Vue 3 + TypeScript:  
- Soporta verificación de tipos TypeScript  
- Usa Composition API  
- Importación automática de enlaces Wails  
- Reemplazo en caliente de módulos (HMR)  

### Dependencias CGO

El proyecto usa CGO (para SQLite y operaciones del portapapeles), para compilar se necesita:  
- macOS: Se requiere Xcode Command Line Tools  
- Windows: Se requiere MinGW-w64  
- Linux: Se requiere gcc  

## Preguntas Frecuentes

### 1. Fallo en la compilación

Asegúrese de tener instaladas todas las dependencias:

```bash
# macOS
xcode-select --install

# Windows
# 安装 MSYS2 和 MinGW-w64

# Linux
sudo apt-get install build-essential libgtk-3-dev libwebkit2gtk-4.0-dev
```

### 2. El front-end no puede llamar a la API del back-end

Asegúrate de haber ejecutado `wails generate module` para generar el enlace del front-end.

## Licencia

Licencia MIT

## Apoyo y agradecimientos

💗 **Invita al autor a un café**

Si este software te ha ahorrado tiempo (o al menos no te ha vuelto loco), ¡te invitamos a ofrecerle un café ☕ o una cerveza 🍺 al autor!

Cada taza de café se convierte mágicamente en: nuevas funciones, menos bugs (hago lo posible), y el soporte moral del autor durante las noches de codificación.

¡Tu Star ⭐ y donaciones son la fuerza que me impulsa a corregir bugs y añadir nuevas funciones (¡y también el presupuesto para comprar café!)!

### Escanea con WeChat

![Código de Agradecimiento](https://raw.githubusercontent.com/snsogbl/clip-save/main/frontend/src/assets/static/zs.png)

**"Invítame a un café ☕"**

### Dale un Star ⭐ al proyecto

Si este proyecto te ha sido útil, ¡dale un Star ⭐! ¡Es el mayor apoyo que puedes darme!

## Agradecimientos

- [Wails](https://wails.io) - Framework para construir aplicaciones de escritorio
- [Vue 3](https://vuejs.org) - Framework JavaScript progresivo
- [golang.design/x/clipboard](https://github.com/golang-design/clipboard) - Biblioteca de portapapeles multiplataforma
- [json-editor-vue](https://github.com/cloydlau/json-editor-vue)
- [highlight.js](https://github.com/highlightjs/highlight.js)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---