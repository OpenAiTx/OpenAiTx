
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Pintura mágica con IA

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![Licencia](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Una aplicación de dibujo AI desarrollada con Next.js, que cuenta con las siguientes funciones principales:
- 🎨 Soporte para varios modelos de IA (Sora, DALL-E, GPT, GEMINI, etc.) y permite agregar modelos personalizados
- 🖼️ Funciones de generación de imágenes a partir de texto y de edición de imágenes, con soporte para múltiples imágenes de referencia y edición por zonas
- 🔐 Todos los datos y claves de API se almacenan localmente, garantizando la seguridad y privacidad
- 💻 Compatible con versión web y empaquetado como aplicación de escritorio, para uso multiplataforma

## Experiencia en línea

Dirección de acceso: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Capturas de pantalla de la aplicación

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="Captura de pantalla 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="Captura de pantalla 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="Captura de pantalla 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="Captura de pantalla 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="Captura de pantalla 3" width="800" style="margin-bottom: 20px"/>
</div>

## Características principales

- 🎨 Soporte para múltiples modelos de IA
  - Modelo GPT Sora_Image
  - Modelo GPT 4o_Image
  - Modelo GPT Image 1
  - Modelo DALL-E 3
  - Modelo GEMINI
  - 🆕 Modelos personalizados (soporta añadir modelos privados)
- 🔄 Cambio entre modelos
  - Soporte para cambiar rápidamente entre diferentes modelos
  - Cada modelo tiene opciones de configuración independientes
- ✍️ Función de generación de imágenes a partir de texto
  - Soporte para personalizar los prompts
  - Permite seleccionar la proporción de la imagen
  - Soporte para varios tamaños de imagen
- 🖼️ Función de generación de imágenes a partir de imágenes
  - Soporte para edición de imágenes
  - Soporte para edición de zonas enmascaradas
  - Soporte para ajuste de calidad de imagen
  - Soporta referencia múltiple de imágenes (subir varias imágenes simultáneamente)
- 🔒 Seguridad de datos
  - Todas las imágenes generadas y el historial solo se guardan en el navegador local
  - Soporta la personalización de la dirección de proxy de la API
  - Soporta configuración de API Key
- 📱 Diseño de UI
  - Interfaz de usuario moderna
  - Experiencia de interacción fluida
  - Visualización en formato Markdown
  - Soporte para resaltado de código
- 🖥️ Soporte multiplataforma
  - Soporta empaquetado como aplicación de escritorio (Windows, macOS, Linux)
  - Soporta uso sin conexión (requiere configuración de interfaz API)

## Stack tecnológico

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (empaquetado de aplicación de escritorio)

## Desarrollo local

1. Clonar el proyecto
```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. Instalación de dependencias

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. Iniciar el servidor de desarrollo

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. Accede a [http://localhost:3000](http://localhost:3000)

## Empaquetado de la aplicación de escritorio

Este proyecto utiliza Tauri para empaquetar la aplicación de escritorio, compatible con los sistemas Windows, macOS y Linux.

### Preparación del entorno

Antes de empaquetar la aplicación de escritorio, es necesario instalar las siguientes dependencias:

1. **Instalar Rust**:
   - Visita [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - Sigue las instrucciones para instalar Rust y Cargo

2. **Dependencias del sistema**:
   - **Windows**: Instala [Visual Studio C++ Build Tools](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: Instala las herramientas de línea de comandos de Xcode (`xcode-select --install`)
   - **Linux**: Instala las dependencias correspondientes, consulta la [documentación de Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)

### Modo de desarrollo


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### Construir aplicaciones de escritorio


```bash
# 构建桌面应用安装包
npm run desktop
```
Después de completar la compilación, puedes encontrar el paquete de instalación correspondiente al sistema en el directorio `src-tauri/target/release/bundle`.

## Despliegue en Vercel

1. Haz un Fork de este proyecto a tu cuenta de GitHub

2. Crea un nuevo proyecto en [Vercel](https://vercel.com)

3. Importa tu repositorio de GitHub

4. Haz clic en desplegar

## Instrucciones de uso

1. La primera vez que lo uses necesitas configurar la clave API
   - Haz clic en "Configuración de clave" en la esquina superior derecha
   - Introduce la clave API y la dirección base
   - Haz clic en guardar
   - También puedes configurar rápidamente a través de parámetros en la URL:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     Nota: Los caracteres especiales en la URL deben ser codificados en URL

2. Seleccionar modo de generación
   - Texto a imagen: generar imágenes mediante descripciones de texto
   - Imagen a imagen: subir una imagen para editarla

3. Configurar parámetros de generación
   - Seleccionar modelo de IA (modelo integrado o personalizado)
   - Establecer la proporción de la imagen
   - Ajustar la calidad de la imagen (modo imagen a imagen)

4. Gestión de modelos personalizados
   - Hacer clic en el ícono de configuración junto al cuadro de selección de modelo
   - Agregar un nuevo modelo: ingresar nombre, valor del modelo y seleccionar tipo de modelo
   - Editar modelo: hacer clic en el botón de edición de un modelo existente
   - Eliminar modelo: hacer clic en el botón de eliminar de un modelo existente
   - Seleccionar modelo: hacer clic en el botón de suma del modelo para seleccionarlo de inmediato

5. Explicación de los tipos de modelo
   - Formato DALL-E: utiliza la interfaz de generación de imágenes (/v1/images/generations)
   - Formato OpenAI: utiliza la interfaz de chat (/v1/chat/completions)

6. Generar imagen
   - Ingresar la palabra clave o prompt
   - Hacer clic en el botón "Generar imagen"
   - Esperar a que se complete la generación

7. Gestión de imágenes
   - Ver historial
   - Descargar imágenes generadas
   - Editar imágenes existentes

## Precauciones

- Todas las imágenes generadas y el historial solo se guardan en el navegador local
- Usar el modo privado o cambiar de dispositivo puede causar la pérdida de datos
- Descargue y haga copia de seguridad de las imágenes importantes a tiempo
- La configuración de la API se almacenará de forma segura en su navegador y no se subirá al servidor
- Los recursos HTTP cargados en sitios HTTPS serán bloqueados por el navegador; la aplicación convertirá automáticamente las interfaces HTTP a HTTPS

## Guía de contribución

Bienvenido a enviar Issues y Pull Requests para ayudar a mejorar el proyecto.

## Licencia

Este proyecto utiliza la licencia [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

Según la licencia, usted puede:
- ✅ Uso comercial: puede usar el software con fines comerciales
- ✅ Modificar: puede modificar el código fuente del software
- ✅ Distribuir: puede distribuir el software
- ✅ Uso privado: puede usar el software de forma privada
- ✅ Licencia de patentes: esta licencia también otorga licencia de patentes

Pero debe cumplir con las siguientes condiciones:
- 📝 Declaración de licencia y derechos de autor: debe incluir la licencia y declaración de derechos de autor originales
- 📝 Declaración de cambios: debe declarar los cambios importantes realizados al código original
- 📝 Declaración de marca registrada: no debe utilizar las marcas registradas de los colaboradores

---

## Invítame a un café

Si este proyecto te ha sido útil, eres bienvenido a invitarme a un café ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="Código de pago de WeChat" width="300" />
  <p>Invítame a un café</p>
</div>

## Información de contacto

Si tienes alguna pregunta o sugerencia, puedes contactarme a través de WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="Contacto de WeChat" width="300" />
  <p>Escanea el código QR para agregarme en WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---