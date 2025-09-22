# TypeGen - Herramienta inteligente de conversión de estilo de texto

TypeGen es una aplicación moderna de conversión de estilo de texto impulsada por IA basada en Next.js. Mediante la integración de la API de OpenAI, ofrece conversiones inteligentes entre estilos de escritura, plantillas estructurales y parámetros estratégicos multidimensionales, con una interfaz de usuario intuitiva de arrastrar y soltar.

## 🎯 Funcionalidades principales

### Conversión inteligente de texto
- **Impulsado por IA**: Integración de OpenAI GPT-4o-mini para conversiones reales de estilo de texto
- **28 filtros de estilo**: Cubre tres dimensiones: estilo de escritura, estructura y estrategia de difusión
- **Control inteligente de longitud**: Soporta configuración de longitud objetivo, desde resúmenes concisos hasta desarrollos detallados
- **Conversión en tiempo real**: Procesamiento rápido vía API para ofrecer una experiencia de usuario fluida

### Diseño de interacción intuitiva
- **Operación de arrastrar y soltar**: Arrastra filtros de estilo al cuadro de texto para iniciar la conversión
- **Retroalimentación visual**: Efectos de animación ricos e indicadores de estado
- **Visualización comparativa**: Diseño de columnas dobles para comparación antes y después de la conversión
- **Operación con un clic**: Copia resultados, prueba otros estilos, reinicia fácilmente

## 🛠️ Arquitectura técnica

### Tecnologías frontend
- **Framework**: [Next.js](https://nextjs.org/) 15.5.0 (desarrollo con Turbopack)
- **Librería UI**: [React](https://reactjs.org/) 19.0.0
- **Sistema de estilos**: [Tailwind CSS](https://tailwindcss.com/) 4.1.11
- **Librería de animación**: [Framer Motion](https://www.framer.com/motion/) 12.23.6
- **Seguridad de tipos**: [TypeScript](https://www.typescriptlang.org/) 5
- **Gestor de paquetes**: [pnpm](https://pnpm.io/)

### Componentes principales
- **Sistema de arrastrar y soltar**: Interacción profesional basada en @dnd-kit/core
- **Gestión de estilos**: Manejo dinámico de estilos con clsx y tailwind-merge
- **Componentes UI**: Biblioteca de componentes personalizada basada en Radix UI

## 📂 Estructura del proyecto

```
├── app/                           # Next.js App Router
│   ├── api/transform/route.ts     # 文本转换 API 端点
│   ├── page.tsx                   # 主应用界面
│   ├── layout.tsx                 # 根布局组件
│   └── globals.css                # 全局样式
├── components/                    # UI 组件库
│   ├── style-filter/              # 风格滤镜系统
│   │   ├── types.ts              # 类型定义
│   │   ├── filters-data.ts       # 风格数据配置
│   │   ├── filter-container.tsx  # 滤镜容器组件
│   │   └── ...                   # 动画和交互组件
│   ├── ui/                       # 基础 UI 组件
│   ├── length-control.tsx        # 字数控制滑动条
│   └── text-stats.tsx           # 文本统计显示
├── lib/                          # 业务逻辑层
│   ├── api-client.ts            # API 客户端封装
│   ├── transform-service.ts     # 转换服务核心
│   ├── openai-service.ts        # OpenAI API 集成
│   └── api-types.ts             # API 类型定义
├── public/icons/                # 风格图标资源
└── utils/                       # 工具函数
```
## 🎨 Resumen de filtros de estilo

### Estilo (Style)

**Noticias / Académico / Libro de texto**
- Estilo AP
- Estilo APA
- Estilo IEEE
- Estilo de libro de texto
- Investigativo

**Comunidad / Cultura de plataforma**
- Estilo 4chan
- Estilo Reddit
- BuzzFeed
- Estilo Twitter
- Pie de foto de Instagram
- Estilo Meme

**Novela / Escritura creativa**
- Estilo Hemingway

### Plantillas de estructura (Structure)

**Noticias / Estructura informativa**
- Pirámide invertida
- Enfocado en titulares

**Listas / Hilos / Tutoriales**
- Listículo
- En hilos
- Cómo hacerlo
- Puntos con viñetas

**Académico / Estructura narrativa**
- IMRaD

### Estrategia y parámetros (Strategy & Controls)
- Clickbait

- Llamado a la acción  
- Optimizado para SEO  
- Impulsado por FOMO  
- Uso intensivo de hashtags  
- Cargado de emojis  
- Índice de legibilidad Flesch-Kincaid  
- Abundantes citas  
- Jerga técnica  

## ⚙️ Guía de configuración  

### Configuración del entorno  
1. **Obtener la clave API de OpenAI**
   ```bash
   # 访问 https://platform.openai.com/account/api-keys
   # 创建新的 API 密钥
   ```
2. **Configurar variables de entorno**

   ```bash
   cp .env.example .env.local
   ```
   Editar el archivo `.env.local`:

   ```bash
   OPENAI_API_KEY=sk-proj-your_api_key_here
   OPENAI_MODEL=gpt-4o-mini                    # 可选，默认值
   OPENAI_MAX_TOKENS=2000                      # 可选，默认值
   OPENAI_TEMPERATURE=0.7                      # 可选，默认值
   API_TIMEOUT=30000                           # 可选，30秒超时
   API_MAX_RETRIES=3                           # 可选，最大重试次数
   ```
### Desarrollo local

```bash
# 安装依赖
pnpm install

# 启动开发服务器
pnpm dev

# 构建生产版本
pnpm build

# 代码检查
pnpm lint
```

## 🔧 Implementación Core

### Gestión de Estado
La aplicación utiliza un patrón completo de máquina de estados para gestionar el flujo de transición:
- `idle`: Estado inicial, esperando entrada de texto
- `readyToTransform`: Texto listo, se puede transformar
- `transforming`: Transformación en curso, muestra estado de carga
- `transformed`: Transformación completada, muestra comparación de resultados

### Integración API
- **Seguridad de tipos**: Definiciones completas de tipos en TypeScript
- **Manejo de errores**: Manejo de errores en capas y mensajes amigables para el usuario
- **Optimización de rendimiento**: Caché de respuestas API y deduplicación de solicitudes
- **Mecanismo de reintento**: Reintentos automáticos en fallos de red

### Experiencia de Interacción (Escritorio)
- **Operación de arrastrar y soltar**: Animaciones fluidas y retroalimentación visual
- **Control de conteo de palabras**: Conteo de palabras en tiempo real y ajuste de longitud objetivo
- **Operación de resultados**: Copiar con un clic, reintentar y reiniciar
- **Explicación de plataforma**: La versión actual solo está disponible para escritorio, sin interacción en móviles

## 🚀 Direcciones de Expansión

- **Soporte multilingüe**: Añadir soporte internacional
- **Procesamiento por lotes**: Soporte para transformar múltiples textos simultáneamente
- **Estilos personalizados**: Permitir a usuarios crear estilos personalizados
- **Funcionalidad colaborativa**: Compartir en equipo y funciones de comentarios
- **Análisis de datos**: Uso estadístico y análisis de efectividad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---