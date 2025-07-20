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

# Pintura Mágica AI

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![Licencia](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Una aplicación de pintura AI desarrollada con Next.js, con las siguientes funciones principales:
- 🎨 Soporta múltiples modelos de IA (Sora, DALL-E, GPT, etc.) y permite agregar modelos personalizados
- 🖼️ Proporciona funciones de texto a imagen y de imagen a imagen, soporta referencias múltiples y edición por zonas
- 🔐 Todos los datos y claves API se almacenan localmente, garantizando la privacidad y seguridad
- 💻 Soporte para versión web y empaquetado como aplicación de escritorio, uso multiplataforma

## Prueba en línea

Dirección de acceso: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Capturas de pantalla de la aplicación

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="Captura de pantalla 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="Captura de pantalla 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="Captura de pantalla 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="Captura de pantalla 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="Captura de pantalla 3" width="800" style="margin-bottom: 20px"/>
</div>

## Características

- 🎨 Soporte para múltiples modelos de IA
  - Modelo GPT Sora_Image
  - Modelo GPT 4o_Image
  - Modelo GPT Image 1
  - Modelo DALL-E 3
  - 🆕 Modelos personalizados (soporta agregar modelos privados)
- ✍️ Función de texto a imagen
  - Soporta indicaciones personalizadas
  - Permite seleccionar la relación de aspecto
  - Soporta múltiples tamaños de imagen
- 🖼️ Función de imagen a imagen
  - Permite edición de imágenes
  - Soporta edición de zonas enmascaradas
  - Permite ajustar la calidad de la imagen
  - Permite referencia de múltiples imágenes (subida simultánea)
- 🔒 Seguridad de datos
  - Todas las imágenes generadas e historial solo se guardan localmente en el navegador
  - Permite configurar dirección de proxy para la API
  - Permite configurar la clave de API
- 📱 Diseño UI
  - Interfaz de usuario moderna
  - Experiencia de interacción fluida
  - Visualización en formato Markdown
  - Soporte para resaltado de código
- 🖥️ Compatibilidad multiplataforma
  - Soporta empaquetado como aplicación de escritorio (Windows, macOS, Linux)
  - Soporta uso sin conexión (requiere configuración de API)

## Stack tecnológico

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (empaquetado de aplicaciones de escritorio)

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
   - Texto a imagen: genera una imagen a partir de una descripción textual
   - Imagen a imagen: edita una imagen subiéndola

3. Configurar parámetros de generación
   - Seleccionar el modelo de IA (modelo integrado o modelo personalizado)
   - Establecer la proporción de la imagen
   - Ajustar la calidad de la imagen (modo imagen a imagen)

4. Gestión de modelos personalizados
   - Haz clic en el ícono de configuración junto al cuadro de selección de modelos
   - Añadir nuevo modelo: introduce el nombre, valor y tipo de modelo
   - Editar modelo: haz clic en el botón de editar de un modelo existente
   - Eliminar modelo: haz clic en el botón de eliminar de un modelo existente
   - Seleccionar modelo: haz clic en el botón de más para seleccionar y usar el modelo inmediatamente

5. Descripción de tipos de modelos
   - Formato DALL-E: usa la interfaz de generación de imágenes (/v1/images/generations)
   - Formato OpenAI: usa la interfaz de chat (/v1/chat/completions)

6. Generar imagen
   - Introducir palabras clave
   - Haz clic en el botón "Generar imagen"
   - Espera a que finalice la generación

7. Gestión de imágenes
   - Ver historial
   - Descargar imágenes generadas
   - Editar imágenes existentes

## Notas

- Todas las imágenes generadas y el historial solo se guardan en el navegador local
- Usar modo incógnito o cambiar de dispositivo provocará la pérdida de datos
- Descarga y haz copia de seguridad de las imágenes importantes a tiempo
- La configuración de la API se almacena de forma segura en tu navegador, no se sube al servidor
- Los sitios HTTPS bloquean los recursos HTTP, la aplicación convertirá automáticamente las interfaces HTTP a HTTPS

## Guía de contribución

Se agradecen Issues y Pull Requests para ayudar a mejorar el proyecto.

## Licencia

Este proyecto utiliza la licencia [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

Según la licencia, usted puede:
- ✅ Uso comercial: puede utilizar el software con fines comerciales
- ✅ Modificación: puede modificar el código fuente del software
- ✅ Distribución: puede distribuir el software
- ✅ Uso personal: puede usar el software en privado
- ✅ Licencia de patentes: esta licencia también otorga autorización de patentes

Pero debe cumplir con las siguientes condiciones:
- 📝 Aviso de licencia y derechos de autor: debe incluir la licencia original y el aviso de derechos de autor
- 📝 Declarar cambios: debe declarar los cambios importantes realizados en el código original
- 📝 Declaración de marcas: no puede usar las marcas de los colaboradores

---

## Invítame a un café

Si este proyecto te ha sido útil, te invito a invitarme un café ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="Código de pago WeChat" width="300" />
  <p>Invítame a un café</p>
</div>

## Información de contacto

Si tienes alguna pregunta o sugerencia, puedes contactarme por WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="Contacto WeChat" width="300" />
  <p>Escanea el código QR para agregarme a WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---