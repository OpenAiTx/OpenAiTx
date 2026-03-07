# [Fronteras Históricas](https://historicborders.app/)

Visualiza las fronteras de los países en diferentes épocas de la historia (2000 a.C.-1994)

Como se ve en [r/dataisbeautiful](https://www.reddit.com/r/dataisbeautiful/comments/l52krh/an_app_i_made_for_visualizing_country_borders/).

## Captura de pantalla

<img width="1023" alt="screen-shot-of-app" src="https://user-images.githubusercontent.com/10817537/175097196-e746778d-241a-4bee-b406-aac294849597.png">

## Características

### Fuentes de Información

La aplicación proporciona información de países a través de dos fuentes:

1. **Wikipedia** (por defecto) - Obtiene información en tiempo real desde Wikipedia
2. **Impulsado por IA** - Utiliza Google Gemini AI para generar información de países con contexto histórico

Puedes cambiar entre estas fuentes usando el botón de alternancia en el pie de página.

### Caché de Respuestas de IA

La aplicación usa **Redis** para almacenar en caché las respuestas de IA para mejorar el rendimiento:

- ⚡ **Respuestas instantáneas** para países/años previamente solicitados
- 💰 **Costos de API reducidos** - Menos llamadas a Google Gemini
- 🔧 **Expiración inteligente** - TTL de caché de 1 hora mantiene el contenido fresco
- 📊 **Seguimiento analítico** - Tasa de aciertos/fallos de caché en Google Analytics

Consulta [REDIS_SETUP.md](https://raw.githubusercontent.com/nrgapple/historic-country-borders-app/main/./REDIS_SETUP.md) para instrucciones detalladas de configuración.

### Análisis de la Funcionalidad de IA

La aplicación incluye un seguimiento completo con Google Analytics para la función de IA para entender la interacción del usuario y el rendimiento:

#### Eventos Rastreables

**Uso del proveedor:**
- `toggle_provider` - Cuando los usuarios cambian entre Wikipedia e IA
- `enable_ai` / `disable_ai` - Activación/desactivación de la función de IA
- `provider_restored` - Cuando la preferencia se carga desde localStorage
- `session_provider_active` - Proveedor activo por sesión

**Solicitudes de IA:**
- `request_initiated` - Solicitud de IA iniciada
- `response_success` - Respuesta de IA exitosa
- `response_time_success` - Tiempo de respuesta para solicitudes exitosas
- `response_length` - Conteo de caracteres de respuestas de IA
- `response_word_count` - Conteo de palabras de respuestas de IA
- `request_failed` - Solicitudes de IA fallidas
- `api_error` - Errores específicos de la API con códigos de estado
- `api_key_missing` - Eventos de clave API faltante

**Rendimiento de Caché:**
- `cache_hit` - Respuesta servida desde caché Redis (más rápido)
- `cache_miss` - Sin respuesta en caché, llamada a API realizada
- `cache_error` - Redis no disponible (recurso a API)
- `cache_write_success` - Respuesta almacenada en caché con éxito
- `cache_write_error` - Fallo al almacenar la respuesta en caché

**Visualización de Contenido:**
- `popup_displayed` - Cuando aparecen ventanas emergentes con contenido de IA vs Wikipedia
- `content_displayed` - Visualización de contenido exitosa
- `content_error_displayed` - Contenido de error mostrado a usuarios
- `content_empty_displayed` - Escenarios de contenido vacío/sin contenido
- `popup_closed` - Usuario cierra ventanas emergentes de información

**Métricas de Rendimiento:**
- Tiempos de respuesta (éxito/fallo)
- Métricas de calidad de contenido (conteo de palabras, conteo de caracteres)
- Tasas y tipos de errores
- Patrones de interacción del usuario

#### Categorías de Análisis

Todos los eventos relacionados con IA usan la categoría `"Función IA"` para facilitar el filtrado en Google Analytics.

#### Privacidad de Datos

El seguimiento de análisis es anónimo y se centra en los patrones de uso de funciones en lugar de información personal. No se rastrean claves API ni datos sensibles.

## Configuración

### Requisitos previos

- Node.js 18+ y yarn
- Clave API de Google Gemini (disponible nivel gratuito)
- Propiedad de Google Analytics 4 (opcional, para análisis)

### Instalación

```bash
git clone https://github.com/nrgapple/historic-country-borders-app.git
cd historic-country-borders-app
yarn install
```

### Variables de Entorno

Cree un archivo `.env.local`:

```bash
# Optional for analytics
NEXT_PUBLIC_GA_FOUR=your_google_analytics_id

# Optional for map features
NEXT_PUBLIC_MAPBOX_ACCESS_TOKEN=your_mapbox_token

# Redis for AI response caching (required for caching)
REDIS_URL=your_redis_connection_string

# Required for AI features (server-side only)
GEMINI_API_KEY=your_gemini_api_key_here
```

### Obtención de Claves API

#### Google Gemini API (Gratis)

1. Visite [Google AI Studio](https://ai.google.dev/gemini-api/docs/api-key)
2. Inicie sesión con su cuenta de Google
3. Haga clic en **"Crear clave API"**
4. Copie la clave generada en su archivo `.env.local`

**Beneficios:**
- ✅ 60 solicitudes por minuto (nivel gratuito generoso)
- ✅ No se requiere tarjeta de crédito
- ✅ Respuestas de IA de alta calidad
- ✅ Excelente conocimiento histórico

#### Vercel Redis para Caché (Opcional pero Recomendado)

1. Configure Redis en Vercel o cualquier proveedor de Redis
2. Añada la variable de entorno `REDIS_URL` a su proyecto
3. Consulte [REDIS_SETUP.md](https://raw.githubusercontent.com/nrgapple/historic-country-borders-app/main/./REDIS_SETUP.md) para instrucciones detalladas

**Beneficios:**
- ⚡ Respuestas instantáneas para contenido en caché
- 💰 Reduce el uso y costos de la API
- 🔧 Expiración automática de caché de 1 hora
- 📊 Análisis de rendimiento de la caché

#### Google Analytics 4 (Opcional)

1. Visite [Google Analytics](https://analytics.google.com/)
2. Cree una nueva propiedad GA4
3. Obtenga su ID de Medición (formato: G-XXXXXXXXXX)
4. Agregue al archivo `.env.local`

### Desarrollo

```bash
yarn dev
```

Abre [http://localhost:3000](http://localhost:3000) para ver la aplicación.

### Pruebas

```bash
# Run all tests
yarn test

# Run tests in watch mode
yarn test:watch

# Run specific test files
yarn test hooks/__tests__/useAI.test.tsx
```

## Solución de Problemas de Funciones de IA

### Problemas Comunes

**"La información de IA requiere configuración de la clave API de Gemini"**
- Añade tu clave API de Gemini en `.env.local`
- Reinicia el servidor de desarrollo
- Consulta [GEMINI_SETUP.md](https://raw.githubusercontent.com/nrgapple/historic-country-borders-app/main/./GEMINI_SETUP.md) para una configuración detallada

**Respuestas lentas de IA**
- Tiempo de respuesta normal: 1-3 segundos
- Verifica tu conexión a internet
- La API de Gemini tiene límites de tasa (60 solicitudes/minuto)

**Respuestas vacías o con error**
- Prueba cambiar a Wikipedia temporalmente
- Revisa la consola del navegador para mensajes de error detallados
- Verifica que tu clave API sea válida

### Panel de Análisis

Para ver análisis de funciones de IA en Google Analytics:

1. Ve a **Eventos** → **Todos los Eventos**
2. Filtra por **Categoría de Evento** = "AI Feature"
3. Métricas clave para monitorear:
   - `toggle_provider` - Adopción de la función
   - `response_success` vs `request_failed` - Tasa de éxito
   - `response_time_success` - Rendimiento
   - `content_displayed` - Compromiso del usuario

### Monitoreo de Rendimiento

La aplicación rastrea varias métricas de rendimiento:

- **Tiempos de Respuesta**: Tiempo promedio de respuesta de IA vs Wikipedia
- **Tasas de Éxito**: Proporción de éxito/fallo en solicitudes de IA
- **Calidad del Contenido**: Conteo de palabras y longitud de respuestas de IA
- **Compromiso del Usuario**: Cómo interactúan los usuarios con contenido de IA vs Wikipedia

## Contribuyendo

1. Haz un fork del repositorio
2. Crea una rama de características
3. Realiza tus cambios
4. Añade pruebas para la nueva funcionalidad
5. Asegúrate de que todas las pruebas pasen
6. Envía una solicitud de extracción

## Licencia

Licencia MIT - ver [LICENSE](LICENSE) para más detalles.

## Agradecimientos

- Datos históricos de fronteras de [World Historical Gazetteer](https://whgazetteer.org/)
- IA potenciada por [Google Gemini](https://ai.google.dev/)
- Mapas potenciado por [Mapbox](https://www.mapbox.com/)
- Análisis por [Google Analytics 4](https://analytics.google.com/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-07

---