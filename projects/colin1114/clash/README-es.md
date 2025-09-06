
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

La aceleración CDN y la protección de seguridad para este proyecto son patrocinadas por Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

El autor de este proyecto es colin1114.

# 🚀 Convertidor de Suscripciones Clash

Una herramienta en línea atractiva y potente para convertir diversos enlaces de suscripción de proxy al formato de configuración de Clash. Soporta despliegue automático mediante Cloudflare Workers & Pages, ofreciendo un servicio de conversión de suscripciones rápido y confiable.

## ✨ Características funcionales

- 🎨 **Interfaz moderna y atractiva** - Utiliza fondo degradado y diseño tipo tarjeta
- 🔄 **Soporte multi-protocolo** - Compatible con V2Ray, VLESS, Shadowsocks, Trojan y otros protocolos principales
- ☁️ **Despliegue en la nube** - Aceleración CDN global mediante Cloudflare Workers
- 📱 **Diseño responsivo** - Adaptación perfecta para escritorio y dispositivos móviles
- ⚡ **Conversión rápida** - Convierte enlaces de suscripción en tiempo real a configuración Clash
- 📋 **Copiado inteligente** - Permite copiar con un solo clic la configuración YAML generada, compatible con varios navegadores
- 📡 **Generación de enlaces de suscripción** - Crea automáticamente enlaces de suscripción importables directamente en Clash
- 🌐 **Acceso en línea a YAML** - Ofrece varias formas de acceder a archivos YAML:
  - 📡 Enlace de suscripción: permite actualización automática en el cliente Clash
  - 🔗 Vista en línea: visualiza la configuración directamente en el navegador
  - 💾 Descarga de archivos: descarga el archivo .yaml localmente
  - ⚡ Acceso rápido: enlace de descarga simplificado
- 🔧 **Soporte UTF-8** - Soporta perfectamente nombres de nodos en chino y configuraciones
- 🆓 **Totalmente gratuito** - Basado en servicios gratuitos de Cloudflare, sin restricciones de uso

## 📁 Estructura del proyecto

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 Inicio rápido

### Método 1: Ejecutar localmente

1. **Clonar el proyecto**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Iniciar el servidor local**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **Acceso a la aplicación**
   - Abre el navegador y visita `http://localhost:8000`
   - En el entorno local se mostrará la configuración de ejemplo

### Método 2: Implementación con Cloudflare Workers

#### Paso 1: Crear un Worker

1. Accede a [Cloudflare Workers](https://workers.cloudflare.com/)
2. Regístrate/Inicia sesión en tu cuenta de Cloudflare
3. Haz clic en "Create a Worker"
4. Copia todo el código de `worker.js` en el editor
5. Haz clic en "Save and Deploy"

#### Paso 2: Implementar usando Wrangler CLI

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### Paso 3: Configurar el dominio (opcional)

1. Agrega un dominio personalizado en la configuración de Worker
2. O utiliza el dominio predeterminado proporcionado por Cloudflare

### Método tres: Despliegue en Cloudflare Pages

#### Opción A: Integración con GitHub (recomendado)

1. **Preparar el repositorio**
   - Sube el código al repositorio de GitHub
   - Asegúrate de incluir todos los archivos necesarios

2. **Crear proyecto de Pages**
   - Ve a [Cloudflare Pages](https://pages.cloudflare.com/)
   - Conecta tu repositorio de GitHub
   - Selecciona el repositorio del proyecto

3. **Configuración de construcción**
   - Comando de construcción: dejar vacío o `echo "No build required"`
   - Directorio de salida de construcción: `/` (directorio raíz)
   - Variables de entorno: no es necesario configurar

#### Opción B: Subida directa

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ Arquitectura técnica

### Stack tecnológico del frontend
- **HTML5** - Lenguaje de marcado moderno
- **CSS3** - Diseño responsivo y efectos de animación
- **Vanilla JavaScript** - Interacción ligera en frontend

### Stack tecnológico del backend
- **Cloudflare Workers** - Plataforma de computación en el borde
- **Web APIs** - API Fetch estándar y manejo de respuestas

### Protocolos soportados
- **VMess** - Protocolo estándar de V2Ray
- **VLESS** - Protocolo ligero de V2Ray (compatible con Reality)
- **Shadowsocks** - Protocolo clásico de proxy
- **Trojan** - Protocolo proxy emergente

### Endpoints de la API
- `GET /` - Página principal
- `POST /convert` - API para convertir suscripciones
- `GET /clash/{config-id}` - Obtener archivo de configuración YAML (enlace de suscripción)
- `GET /yaml/{config-id}` - Descargar archivo de configuración YAML
- `OPTIONS /*` - Solicitud de preflight CORS

## 📖 Guía de uso

### Uso básico

1. **Introduce el enlace de suscripción**
   - Pega tu enlace de suscripción de proxy en el campo de entrada
   - Se admite enlaces de suscripción en Base64

2. **Configura el nombre de la configuración**
   - Opcionalmente configura un nombre personalizado para el archivo de configuración
   - Por defecto es "Mi Configuración Clash"

3. **Convierte la configuración**
   - Haz clic en el botón "Convertir suscripción"
   - Espera a que finalice la conversión
4. **Uso de la configuración**
   - Copia la configuración YAML generada
   - Impórtala en el cliente Clash para su uso

5. **Uso de enlace de suscripción (recomendado)**
   - Copia el enlace de suscripción generado
   - Añádelo como suscripción en el cliente Clash
   - La configuración se sincroniza automáticamente, sin necesidad de actualizar manualmente

### Configuración avanzada

La configuración Clash generada incluye las siguientes características:

- **Estrategia de grupos de proxy**
  - 🚀 Selección de nodo - Selección manual de proxy
  - ♻️ Selección automática - Selección automática basada en prueba de latencia
  - 🎯 Conexión global directa - Conexión directa

- **Configuración DNS**
  - Activación de la resolución DNS
  - Soporta modo fake-ip
  - Divisón de DNS nacional e internacional

- **Reglas de enrutamiento**
  - Dirección local conexión directa
  - IP nacional conexión directa
  - El resto del tráfico pasa por proxy

## 🔧 Solución de problemas de despliegue

### Problemas comunes

#### 1. Wrangler no encuentra el punto de entrada
**Mensaje de error**: `Missing entry-point to Worker script`

**Solución**: 
- Verifica que el archivo `wrangler.jsonc` esté en el directorio raíz del proyecto
- Revisa que el campo `main` en `wrangler.jsonc` apunte a `worker.js`


#### 2. GitHub Actions falla en el despliegue
**Solución**:
- Añade los siguientes Secrets en la configuración del repositorio de GitHub:
  - `CLOUDFLARE_API_TOKEN`: Token de API de Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: ID de cuenta de Cloudflare

#### 3. Fallo en la construcción de Pages
**Solución**:
- Configura el comando de construcción como vacío o `echo "No build required"`
- Asegúrate de que el directorio de salida de construcción esté establecido en `/`

### Explicación de los archivos de configuración de despliegue

- **`wrangler.jsonc`**: Configuración de Wrangler CLI, utilizado para el despliegue de Worker
- **`_headers`**: Configuración de cabeceras HTTP para Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Configuración de despliegue automático con GitHub Actions

## 🔧 Configuración personalizada

### Modificar grupos de proxy

Puedes editar la función `convertToClash` en `worker.js` para personalizar los grupos de proxy:

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### Reglas de enrutamiento personalizadas

Modifique el arreglo `rules` para agregar reglas de enrutamiento personalizadas:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 Características de rendimiento

- **CDN global** - Cloudflare con nodos de borde en todo el mundo
- **Respuesta rápida** - Tiempo de respuesta promedio < 100ms
- **Alta disponibilidad** - 99.9% de disponibilidad del servicio
- **Cuota gratuita** - 100,000 solicitudes por día

## 🔒 Notas de seguridad

- **Privacidad de datos** - Los datos de suscripción solo se utilizan durante la conversión y no se almacenan
- **Cifrado HTTPS** - Toda la comunicación está cifrada mediante HTTPS
- **Transparencia de código abierto** - Código fuente completo disponible para auditoría

## 🤝 Guía de contribución

¡Bienvenido a enviar Issues y Pull Requests!

1. Haz fork de este repositorio
2. Crea una rama de características (`git checkout -b feature/AmazingFeature`)
3. Realiza los cambios (`git commit -m 'Add some AmazingFeature'`)
4. Haz push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## 📝 Registro de cambios

### v1.1.0
- ✅ Soporte para protocolo VLESS (incluye transmisión segura Reality)
- ✅ Compatibilidad de protocolo mejorada

### v1.0.0
- ✅ Función básica de conversión de suscripción
- ✅ Interfaz de usuario atractiva
- ✅ Soporte para Cloudflare Workers
- ✅ Soporte multiprotocolo (VMess, Shadowsocks, Trojan)
- ✅ Diseño responsivo
- ✅ Función de copia con un clic

## 📞 Soporte y comentarios

Si encuentras problemas o tienes sugerencias durante el uso, por favor:

1. Consulta este documento README
2. Envía un [Issue](../../issues)
3. Inicia una [Discussion](../../discussions)

## 📄 Licencia

Este proyecto utiliza la licencia MIT - consulta el archivo [LICENSE](LICENSE)

## 🙏 Agradecimientos

- [Cloudflare Workers](https://workers.cloudflare.com/) - Proporciona la plataforma de computación en el borde
- [Clash](https://github.com/Dreamacro/clash) - Excelente cliente de proxy
- El apoyo de todos los colaboradores y usuarios

---

⭐ Si este proyecto te ha sido útil, ¡dale una estrella! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---