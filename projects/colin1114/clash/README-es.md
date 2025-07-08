La aceleración CDN y la protección de seguridad para este proyecto son patrocinadas por Tencent EdgeOne.

[![imagen](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

El autor de este proyecto es colin1114.

# 🚀 Convertidor de Suscripciones Clash

Una herramienta en línea, estética y potente, diseñada para convertir varios enlaces de suscripción de proxy al formato de configuración de Clash. Soporta despliegue automático a través de Cloudflare Workers & Pages, ofreciendo un servicio de conversión de suscripciones rápido y confiable.

## ✨ Características

- 🎨 **Interfaz moderna y atractiva** - Utiliza fondo degradado y diseño tipo tarjeta
- 🔄 **Soporte para múltiples protocolos** - Compatible con V2Ray, VLESS, Shadowsocks, Trojan y otros protocolos populares
- ☁️ **Despliegue en la nube** - CDN global acelerado mediante Cloudflare Workers
- 📱 **Diseño responsivo** - Perfectamente adaptado para escritorio y dispositivos móviles
- ⚡ **Conversión rápida** - Convierte enlaces de suscripción a configuración Clash en tiempo real
- 📋 **Copia inteligente** - Permite copiar la configuración YAML generada de un solo clic, compatible con todos los navegadores
- 📡 **Generación de enlaces de suscripción** - Genera automáticamente enlaces de suscripción importables directamente en Clash
- 🌐 **Acceso en línea a YAML** - Ofrece varias formas de acceder al archivo YAML:
  - 📡 Enlace de suscripción: soporta actualización automática en el cliente Clash
  - 🔗 Visualización en línea: ver el contenido de la configuración directamente en el navegador
  - 💾 Descarga de archivos: descarga el archivo .yaml localmente
  - ⚡ Acceso rápido: enlace de descarga simplificado
- 🔧 **Soporte UTF-8** - Soporta perfectamente nombres de nodos y configuraciones en chino
- 🆓 **Totalmente gratuito** - Basado en los servicios gratuitos de Cloudflare, sin restricciones de uso

## 📁 Estructura del Proyecto

```
clash/
├── index.html              # Página frontend
├── worker.js               # Código backend para Cloudflare Worker
├── wrangler.jsonc          # Archivo de configuración de Wrangler
├── _headers                # Configuración de cabeceras HTTP para Cloudflare Pages
├── .github/
│   └── workflows/
│       └── deploy.yml      # Configuración de despliegue con GitHub Actions
├── README.md              # Documentación del proyecto
└── package.json           # Archivo de configuración del proyecto
```

## 🚀 Inicio Rápido

### Método 1: Ejecución local

1. **Clonar el proyecto**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Iniciar el servidor local**
   ```bash
   # Usando Python
   python -m http.server 8000
   
   # O usando Node.js
   npx serve .
   ```

3. **Acceder a la aplicación**
   - Abre el navegador y visita `http://localhost:8000`
   - En entorno local se mostrará la configuración de ejemplo

### Método 2: Despliegue en Cloudflare Workers

#### Paso 1: Crear Worker

1. Accede a [Cloudflare Workers](https://workers.cloudflare.com/)
2. Regístrate/Inicia sesión en tu cuenta de Cloudflare
3. Haz clic en "Create a Worker"
4. Copia todo el código de `worker.js` en el editor
5. Haz clic en "Save and Deploy"

#### Paso 2: Desplegar usando Wrangler CLI

```bash
# Instala Wrangler CLI
npm install -g wrangler

# Inicia sesión en Cloudflare
wrangler login

# Despliega el Worker
npm run deploy:worker
```

#### Paso 3: Configurar dominio (opcional)

1. Añade un dominio personalizado en la configuración del Worker
2. O utiliza el dominio predeterminado proporcionado por Cloudflare

### Método 3: Despliegue en Cloudflare Pages

#### Opción A: Integración con GitHub (recomendado)

1. **Preparar el repositorio**
   - Sube el código al repositorio de GitHub
   - Asegúrate de incluir todos los archivos necesarios
2. **Crear un proyecto de Pages**
   - Visita [Cloudflare Pages](https://pages.cloudflare.com/)
   - Conecta tu repositorio de GitHub
   - Selecciona el repositorio del proyecto

3. **Configuración de compilación**
   - Comando de compilación: Déjalo en blanco o `echo "No build required"`
   - Directorio de salida de compilación: `/` (directorio raíz)
   - Variables de entorno: No es necesario configurarlas

#### Opción B: Subida directa

```bash
# Desplegar usando Wrangler Pages
npm run deploy:pages
```

## 🛠️ Arquitectura técnica

### Stack tecnológico frontend
- **HTML5** - Lenguaje de marcado moderno
- **CSS3** - Diseño responsivo y efectos de animación
- **Vanilla JavaScript** - Interacción frontend ligera

### Stack tecnológico backend
- **Cloudflare Workers** - Plataforma de computación en el borde
- **Web APIs** - Fetch API estándar y manejo de respuestas

### Protocolos soportados
- **VMess** - Protocolo estándar de V2Ray
- **VLESS** - Protocolo ligero de V2Ray (soporta Reality)
- **Shadowsocks** - Protocolo de proxy clásico
- **Trojan** - Protocolo de proxy emergente

### Endpoints de API
- `GET /` - Página principal
- `POST /convert` - API de conversión de suscripciones
- `GET /clash/{config-id}` - Obtener archivo de configuración YAML (enlace de suscripción)
- `GET /yaml/{config-id}` - Descargar archivo de configuración YAML
- `OPTIONS /*` - Solicitudes preflight de CORS

## 📖 Guía de uso

### Uso básico

1. **Introduce el enlace de suscripción**
   - Pega tu enlace de suscripción de proxy en el cuadro de entrada
   - Soporta enlaces de suscripción codificados en Base64

2. **Configura el nombre de la configuración**
   - Opcionalmente, puedes establecer un nombre personalizado para el archivo de configuración
   - El valor predeterminado es "My Clash Config"

3. **Convierte la configuración**
   - Haz clic en el botón "Convertir suscripción"
   - Espera a que termine la conversión

4. **Usa la configuración**
   - Copia la configuración YAML generada
   - Importe en el cliente Clash para su uso

5. **Usa el enlace de suscripción (recomendado)**
   - Copia el enlace de suscripción generado
   - Añádelo como suscripción en el cliente Clash
   - La configuración se sincronizará automáticamente, no es necesario actualizar manualmente

### Configuración avanzada

La configuración de Clash generada incluye las siguientes características:

- **Políticas de grupo de proxy**
  - 🚀 Selección de nodo - Selección manual del proxy
  - ♻️ Selección automática - Selección automática por prueba de latencia
  - 🎯 Conexión directa global - Conexión directa

- **Configuración de DNS**
  - Resolución DNS habilitada
  - Soporta modo fake-ip
  - Enrutamiento DNS para China/exterior

- **Reglas de enrutamiento**
  - Direcciones locales en conexión directa
  - IPs chinas en conexión directa
  - El resto del tráfico pasa por el proxy

## 🔧 Solución de problemas de despliegue

### Preguntas frecuentes

#### 1. Wrangler no encuentra el punto de entrada
**Mensaje de error**: `Missing entry-point to Worker script`

**Solución**:
- Asegúrate de que existe el archivo `wrangler.jsonc` en el directorio raíz del proyecto
- Verifica que el campo `main` en `wrangler.jsonc` apunte a `worker.js`

#### 2. Fallo en el despliegue con GitHub Actions
**Solución**:
- Añade los siguientes Secrets en la configuración del repositorio de GitHub:
  - `CLOUDFLARE_API_TOKEN`: Token de API de Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: ID de cuenta de Cloudflare

#### 3. Fallo en la construcción de Pages
**Solución**:
- Configura el comando de construcción como vacío o `echo "No build required"`
- Asegúrate de que el directorio de salida de construcción esté configurado como `/`

### Descripción de archivos de configuración de despliegue

- **`wrangler.jsonc`**: Configuración de Wrangler CLI, utilizada para el despliegue de Workers
- **`_headers`**: Configuración de cabeceras HTTP para Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Configuración de despliegue automático con GitHub Actions

## 🔧 Configuración personalizada

### Modificar grupos de proxy

Puedes editar la función `convertToClash` en `worker.js` para personalizar los grupos de proxy:

```javascript
'proxy-groups': [
  {
    name: '🚀 Selección de nodo',
    type: 'select',
    proxies: ['♻️ Selección automática', '🎯 Conexión global directa', ...proxyNames]
  },
  // Agregar más grupos de proxy...
]
```

### Personalizar reglas de enrutamiento

Modifica el arreglo `rules` para agregar reglas de enrutamiento personalizadas:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 Selección de nodo',
  'DOMAIN-SUFFIX,local,DIRECT',
  // Agregar más reglas...
]
```

## 📊 Características de rendimiento

- **CDN global** - Nodos perimetrales de Cloudflare a nivel mundial
- **Respuesta rápida** - Tiempo de respuesta promedio < 100 ms
- **Alta disponibilidad** - 99,9% de disponibilidad del servicio
- **Cuota gratuita** - 100,000 solicitudes por día

## 🔒 Notas de seguridad

- **Privacidad de datos** - Los datos de suscripción solo se usan durante la conversión, no se almacenan
- **Cifrado HTTPS** - Todas las comunicaciones están cifradas por HTTPS
- **Transparencia open source** - Código fuente completo disponible para revisión

## 🤝 Guía de contribución

¡Bienvenido a enviar Issues y Pull Requests!

1. Haz Fork de este repositorio
2. Crea una rama de características (`git checkout -b feature/AmazingFeature`)
3. Realiza los cambios (`git commit -m 'Add some AmazingFeature'`)
4. Haz push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## 📝 Registro de cambios

### v1.1.0
- ✅ Añadido soporte para protocolo VLESS (incluyendo transporte seguro Reality)
- ✅ Mejorada compatibilidad de protocolos

### v1.0.0
- ✅ Función básica de conversión de suscripciones
- ✅ Interfaz de usuario atractiva
- ✅ Soporte para Cloudflare Workers
- ✅ Soporte multiprotocolo (VMess, Shadowsocks, Trojan)
- ✅ Diseño responsivo
- ✅ Función de copia con un clic

## 📞 Soporte y retroalimentación

Si encuentras problemas durante el uso o tienes sugerencias, por favor:

1. Revisa este documento README
2. Envía un [Issue](../../issues)
3. Inicia una [Discussion](../../discussions)

## 📄 Licencia

Este proyecto utiliza la licencia MIT - ver el archivo [LICENSE](LICENSE) para más detalles

## 🙏 Agradecimientos

- [Cloudflare Workers](https://workers.cloudflare.com/) - Plataforma de computación perimetral
- [Clash](https://github.com/Dreamacro/clash) - Excelente cliente proxy
- Todo el apoyo de los colaboradores y usuarios

---
⭐ Si este proyecto te ha sido de ayuda, ¡dale una estrella! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---