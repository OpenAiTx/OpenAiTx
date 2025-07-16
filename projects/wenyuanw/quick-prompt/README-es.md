# Quick Prompt

<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

Una potente extensión de navegador enfocada en la gestión y entrada rápida de prompts. Ayuda a los usuarios a crear, gestionar y organizar una biblioteca de prompts, e insertar rápidamente contenido de prompts preestablecidos en cualquier campo de entrada de una página web, aumentando la eficiencia en el trabajo.

> Dado que las extensiones de navegador solo pueden usarse en la web, se ha publicado un [plugin de Raycast](https://github.com/wenyuanw/quick-prompt-raycast) con las mismas funciones, compatible con el formato de datos de la extensión y permite migración sin problemas usando los mismos datos JSON.

## ✨ Características

- 📚 **Gestión de prompts**: Crea, edita y gestiona fácilmente tu biblioteca de prompts
- 🚀 **Entrada rápida**: Activa el selector de prompts rápidamente en cualquier campo de entrada web escribiendo `/p`
- ⌨️ Soporta configurar atajos de teclado para abrir el selector de prompts y guardar texto seleccionado como prompt
- 📑 Soporta menú contextual para guardar texto seleccionado como prompt directamente
- 🎯 Soporta prompts personalizados, incluyendo categorías, títulos, contenido, etiquetas y variables
- 🧑‍💻 **Soporte de variables**: Puedes usar variables en formato `{{nombre_variable}}` en los prompts, e introducir valores específicos al usarlos
- 💾 **Respaldo de datos**: Permite exportar e importar la biblioteca de prompts, facilitando la migración y el respaldo entre dispositivos
- 🔗 **Sincronización con Notion**: Permite sincronizar la biblioteca de prompts con una base de datos de Notion
- 🔍 Soporta búsqueda y filtrado de prompts
- 🌙 Se adapta automáticamente al tema claro u oscuro del sistema

## ⚠️ Problemas conocidos

- En la web de Doubao (doubao.com), tras activar el selector de prompts con `/p`, algunos campos de entrada no eliminan el `/p`. ¡Pero no te preocupes! Mi compañero de equipo Cursor y yo estamos trabajando día y noche para encontrar una solución y arreglarlo lo antes posible.

## 🚀 Cómo usar

1. **Activación rápida**: Escribe `/p` en cualquier campo de texto de una página web para activar el selector de prompts
2. **Abrir selector con atajo**: Usa `Ctrl+Shift+P` (Windows/Linux) o `Command+Shift+P` (macOS) para abrir el selector de prompts
3. **Seleccionar prompt**: Haz clic en el prompt deseado en el selector emergente y se insertará automáticamente en el campo de entrada actual
4. **Guardar prompt rápidamente**: Selecciona cualquier texto y usa `Ctrl+Shift+S` (Windows/Linux) o `Command+Shift+S` (macOS) para guardarlo rápidamente como prompt
5. **Guardar desde menú contextual**: Selecciona cualquier texto, haz clic derecho y elige "Guardar este prompt" para guardar el texto seleccionado como prompt
6. **Exportar biblioteca de prompts**: Haz clic en "Exportar" en la página de gestión para guardar todos los prompts como un archivo JSON en tu equipo
7. **Importar biblioteca de prompts**: Haz clic en "Importar" en la página de gestión para cargar prompts desde un archivo JSON local (soporta combinar o sobrescribir los existentes)

## 📸 Vista previa de la interfaz

Quick Prompt ofrece una interfaz intuitiva y amigable para que gestiones y uses tus prompts fácilmente.

### Selector de prompts

![Selector de prompts](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Selector de prompts](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Usa el comando rápido `/p` o el atajo para invocar el selector de prompts en cualquier campo de entrada, facilitando elegir e insertar el prompt necesario.

### Página de gestión de prompts

![Gestión de prompts](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

En la página de gestión puedes crear nuevos prompts, editar los existentes, añadir etiquetas y gestionar categorías. La interfaz es clara y fácil de usar.

### Guardar desde menú contextual

![Guardar desde menú contextual](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Solo selecciona cualquier texto en la web y haz clic derecho para guardarlo rápidamente como prompt, mejorando la eficiencia en el trabajo.

### Entrada de variables para prompts

![Ventana de variables del prompt](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Los prompts soportan configuración de variables, y tras seleccionarlo puedes introducir los valores de las variables en la ventana emergente.

## ⚙️ Configuración personalizada

1. Haz clic en el icono de la extensión y luego en el botón "Gestionar prompts"
2. En la página de administración, puedes:
   - Añadir nuevas indicaciones
   - Editar indicaciones existentes
   - Eliminar indicaciones no deseadas
   - Añadir etiquetas a las indicaciones para clasificarlas
   - Exportar la biblioteca de indicaciones para realizar copias de seguridad
   - Importar la biblioteca de indicaciones previamente respaldada

## 📦 Guía de Instalación

### Instalar desde la tienda de aplicaciones

¡Ahora disponible en la Chrome Web Store! [Haz clic aquí para descargar e instalar](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Obtener desde GitHub Releases

1. Visita la [página de GitHub Releases](https://github.com/wenyuanw/quick-prompt/releases)
2. Descarga el paquete más reciente del complemento ya compilado
3. Descomprime el archivo descargado
4. Instala la extensión compilada siguiendo las instrucciones a continuación

### Compilar desde el código fuente

1. Clona el repositorio
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. Instalación de dependencias
   ```bash
   pnpm install
   ```
3. Desarrollo y construcción

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```
### Instalar la extensión construida

#### Chrome / Edge
1. Abre la página de gestión de extensiones (`chrome://extensions` o `edge://extensions`)
2. Activa el "Modo de desarrollador"
3. Haz clic en "Cargar extensión descomprimida"
4. Selecciona el directorio `.output/chrome-mv3/` del proyecto

#### Firefox
1. Abre `about:debugging`
2. Haz clic en "Este Firefox"
3. Haz clic en "Cargar complemento temporalmente"
4. Selecciona el archivo `manifest.json` en el directorio `.output/firefox-mv2/` del proyecto

## 📄 Licencia

MIT

## 🤝 Guía de contribución

¡Se aceptan Pull Requests y Issues!

1. Haz un fork de este repositorio
2. Crea tu rama de funcionalidad (`git checkout -b feature/amazing-feature`)
3. Realiza tus cambios (`git commit -m 'Add some amazing feature'`)
4. Haz push a la rama (`git push origin feature/amazing-feature`)
5. Abre un Pull Request

## 👏 Lista de contribuyentes

¡Gracias a todos los desarrolladores que han contribuido al proyecto!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Historial de estrellas

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---