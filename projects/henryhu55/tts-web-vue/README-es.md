# TTS-Vue Versión Web

🎤 Herramienta de síntesis de voz de Microsoft, versión web, construida con `Vue` + `ElementPlus` + `Vite`.

## Ejemplo del sitio web

https://web.tts88.top
### Interfaz de la nueva versión
![image](https://github.com/user-attachments/assets/177c8c0d-33d1-48e7-81e3-778f36d8fedd)

### Interfaz de la versión antigua
![image](https://github.com/user-attachments/assets/67cafd2c-7b0f-4b0d-b14b-bf402aaff0cd)

## Características

- 🌐 Totalmente web, no requiere instalación de aplicación de escritorio
- 🔊 Soporta múltiples tipos de síntesis de voz de Microsoft
- 🚀 Soporta integración con API de TTS88
- 🆓 Soporta llamadas TTS gratuitas, con cuota diaria gratuita
- 🧠 Soporta generación de texto con OpenAI
- 🌍 Soporta múltiples idiomas: chino, inglés, español
- 🔐 Reconocimiento de huella digital del navegador, experiencia de usuario más segura

## Últimas actualizaciones

### Reconstrucción de interfaz y mejoras funcionales (v2.2.0)

- 📱 **Rediseño UI**: Navegación superior fija, cuadro de texto con modo sticky, optimización para dispositivos móviles
- 🔤 **Mejora de SSML**: Nueva función de formato SSML, actualización automática de SSML según configuración
- 🎵 **Optimización del reproductor**: Integración del reproductor en la interfaz principal, mejora en la experiencia de reproducción y descarga de audio
- 🎞️ **Función de subtítulos**: Nueva función para generar subtítulos en línea, aumenta la eficiencia en la creación de contenido
- 🌓 **Optimización del tema**: Mejora en el modo oscuro, añade cambio global de tema
- 🛠️ **Configuración avanzada**: Optimización de la interfaz del servicio TTS gratuito, nuevas configuraciones de velocidad y tono
- 💡 **Experiencia interactiva**: Añadida función de tooltip, refuerza la guía para el usuario
- 🔄 **Actualización de dependencias**: Vue actualizado a 3.5.11, ElementPlus actualizado a 2.9.9
- 🌐 **Actualización de enlaces**: Actualización de la dirección del repositorio GitHub

### Integración del servicio TTS gratuito (v2.1.0)

- 🆕 **Función TTS gratuita**: Sin necesidad de clave API, cuota gratuita diaria disponible
- 👤 **Identificación de huellas digitales del navegador**: garantiza el uso justo del límite gratuito para cada usuario  
- 🔄 **Visualización del estado del límite**: muestra en tiempo real los caracteres gratuitos restantes y el tiempo de reinicio  
- 🌐 **Detección del estado del servidor**: detecta automáticamente el estado de conexión del servidor TTS gratuito  
- 🛡️ **Mejora en el manejo de errores**: mensajes de error y retroalimentación de estado más amigables  
- 🎛️ **Panel de configuración de TTS gratuito**: facilita a los usuarios configurar y ver la información del límite  

### Optimización de interfaz y experiencia de usuario (v2.0.0)  

- ✨ **Optimización del área de configuración**: el panel de configuración soporta plegado, clic en el título "Configuración de voz" para expandir/plegar  
- 🔘 **Posición inteligente del botón**: el botón "Iniciar conversión" se mueve a la parte superior para poder hacer clic sin desplazarse  
- 💬 **Mejora en la indicación de estado**: se añaden textos intuitivos para mostrar el estado de la conversión  
- 🎨 **Mejora del efecto visual**: los botones tienen animación de brillo para mejorar la experiencia del usuario  
- 📱 **Optimización del diseño responsivo**: mejora la visualización en diferentes tamaños de pantalla  

Estas mejoras aumentan considerablemente la eficiencia de uso, especialmente resolviendo el problema del diseño tradicional donde el usuario tenía que desplazarse hasta el final de la página para hacer clic en "Iniciar conversión". Ahora, sin importar dónde esté el usuario en la página, puede iniciar el proceso de conversión fácilmente.  

## Plan de desarrollo  

> **📢 Aviso importante: ¡La versión de escritorio está en desarrollo!**  
> Estamos desarrollando una versión de aplicación de escritorio multiplataforma que soportará más funciones y mejor experiencia de usuario.  
> Esperen próximas actualizaciones y sigan el proyecto para obtener la información más reciente.  

## Inicio rápido  

### Entorno de desarrollo

```bash
# 克隆仓库
git clone https://github.com/henryhu55/tts-web-vue.git

# 安装依赖
yarn install

# 启动开发服务器
yarn dev
```

### Construcción de producción

```bash
# 构建生产版本
yarn build

# 预览生产版本
yarn preview
```

## Despliegue

Después de la compilación, despliegue el contenido del directorio `dist` en cualquier servidor web estático.

## Configuración de API

Esta versión web actualmente soporta el servicio TTS gratuito, la API TTS88 y la API de OpenAI:

### Configuración del servicio TTS gratuito

1. Encuentre la opción "Servicio TTS gratuito" en la página de configuración
2. El sistema configura por defecto la dirección del servidor TTS gratuito
3. Puede ver el saldo gratuito restante del día y la hora de reinicio
4. Cada cliente de navegador tiene un saldo gratuito independiente

### Configuración de la API TTS88

1. Encuentre la opción "URL de API de terceros" en la página de configuración
2. Ingrese la dirección de su API TTS88
3. Si tiene una clave API, introdúzcala en el campo "Clave API TTS88"

### Configuración de la API OpenAI

1. Encuentre la opción de configuración OpenAI en la página de configuración
2. Ingrese su clave API de OpenAI
3. Seleccione el modelo a utilizar (por defecto gpt-3.5-turbo)
4. Si usa un hospedaje propio o proxy, puede configurar una URL base API personalizada

## Consideraciones

- Los datos solo se almacenan en el almacenamiento local del navegador, actualizar o borrar caché no afecta a otros usuarios
- Los archivos de audio convertidos se pueden reproducir directamente en el navegador o descargar localmente
- El servicio TTS gratuito tiene un límite diario de uso, si se excede debe esperar al reinicio al día siguiente

## Tecnología utilizada

- Vue 3.2
- Pinia
- ElementPlus
- Vite

## Licencia

Licencia MIT

## Comenzando

- [Introducción al proyecto](https://docs.tts88.top//guide/intro.html)
- [Instalación y ejecución](https://docs.tts88.top//guide/install.html)
- [Descripción de funciones](https://docs.tts88.top/guide/features.html)
- [Preguntas frecuentes](https://docs.tts88.top//guide/qa.html)
- [Registro de cambios](https://docs.tts88.top//guide/update.html)

## Atención

Este software y el código son solo para uso personal de aprendizaje y prueba, por favor elimínelos dentro de las 24 horas posteriores a la descarga, no se permite su uso comercial, de lo contrario, las consecuencias correrán por su cuenta. Cualquier consecuencia legal por uso indebido no tiene relación conmigo. Este software nunca será de pago, si pagó alguna tarifa adicional antes de usar este software, o pagó por obtener el código fuente o software terminado, ¡entonces seguro ha sido estafado!

**Por favor cite la fuente al redistribuir. Está prohibido inducir a otros a obtener el repositorio, dirección de descarga o paquete de instalación del software mediante grupos, mensajes privados u otros métodos.**

### Grupo de soporte para comentarios, problemas y versiones:

`【tts-web-vue grupo de retroalimentación 1】279895662`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-25

---