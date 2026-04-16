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

Una potente extensión de navegador centrada en la gestión de prompts y la entrada rápida. Ayuda a los usuarios a crear, gestionar y organizar su biblioteca de prompts, además de insertar rápidamente contenido predefinido en cualquier campo de texto web, mejorando la eficiencia del trabajo.

> Debido a que la extensión del navegador solo puede utilizarse en la web, se ha publicado un [complemento de Raycast](https://github.com/wenyuanw/quick-prompt-raycast) con las mismas funciones, compatible con el formato de datos de la extensión y que permite la migración sin problemas usando los mismos datos JSON.

## ✨ Características

- 📚 **Gestión de prompts**: Crea, edita y administra fácilmente tu biblioteca de prompts
- 🚀 **Entrada rápida**: Activa rápidamente el selector de prompts en cualquier cuadro de texto web con `/p`
- ⌨️ Soporta la configuración de atajos de teclado para abrir el selector de prompts y guardar texto seleccionado como prompt
- 📑 Soporta guardar directamente texto seleccionado como prompt desde el menú contextual
- 🎯 Soporta prompts personalizados, incluyendo categorías, títulos, contenido, etiquetas y variables
- 🧑‍💻 **Soporte de variables**: Puedes usar variables en el formato `{{nombre_variable}}` en los prompts y rellenar valores al usarlos
- 💾 **Respaldo de datos**: Soporta exportación e importación de la biblioteca de prompts para facilitar migración y respaldo entre dispositivos
- 🔗 **Sincronización en la nube**: Soporta sincronizar la biblioteca de prompts con bases de datos de Notion o Gitee/GitHub Gist
- 🔍 Soporta función de búsqueda y filtrado de prompts
- 🌙 Se adapta automáticamente al tema claro/oscuro del sistema

## 🚀 Cómo usar

1. **Activación rápida**: Escribe `/p` en cualquier cuadro de texto de una página web para activar el selector de prompts
2. **Atajo para abrir el selector**: Usa `Ctrl+Shift+P` (Windows/Linux) o `Command+Shift+P` (macOS) para abrir el selector de prompts
3. **Seleccionar prompt**: Haz clic en el prompt deseado en el selector emergente y se insertará automáticamente en el cuadro de texto actual
4. **Guardar prompt rápidamente**: Selecciona cualquier texto y usa `Ctrl+Shift+S` (Windows/Linux) o `Command+Shift+S` (macOS) para guardarlo rápidamente como prompt
5. **Guardar desde menú contextual**: Selecciona cualquier texto, haz clic derecho y elige "Guardar este prompt" para guardar el contenido seleccionado como prompt
6. **Exportar biblioteca de prompts**: Haz clic en el botón "Exportar" en la página de gestión para guardar todos los prompts en un archivo JSON localmente
7. **Importar biblioteca de prompts**: Haz clic en el botón "Importar" en la página de gestión para importar prompts desde un archivo JSON local (soporta fusionar o sobrescribir los prompts existentes)

## 📸 Vista previa de la interfaz

Quick Prompt ofrece una interfaz de usuario intuitiva y amigable para que gestiones y uses tus prompts fácilmente.

### Selector de prompts

![Selector de prompts](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Selector de prompts](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Utiliza el comando rápido `/p` o el atajo de teclado para invocar rápidamente el selector de prompts en cualquier cuadro de texto y así seleccionar e insertar fácilmente el prompt que necesites.

### Página de gestión de prompts

![Gestión de prompts](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

En la página de gestión puedes crear nuevos prompts, editar los existentes, añadir etiquetas y gestionar categorías. La interfaz es clara y las operaciones son sencillas.

### Guardar desde el menú contextual

![Guardar desde el menú contextual](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Solo selecciona cualquier texto en la página web y haz clic derecho para guardarlo rápidamente como un prompt, mejorando la eficiencia laboral.

### Entrada de variables en el prompt

![Ventana emergente de variables en el prompt](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Los prompts admiten la configuración de variables, y al seleccionarlos se muestra una ventana emergente para ingresar los valores correspondientes.

## ⚙️ Configuración personalizada

1. Haz clic en el ícono de la extensión y luego en el botón "Gestionar prompts"
2. En la página de gestión, puedes:
   - Añadir nuevos prompts
   - Editar prompts existentes
   - Eliminar prompts innecesarios
   - Agregar etiquetas a los prompts para clasificarlos
   - Exportar la biblioteca de prompts para hacer copias de seguridad
   - Importar una biblioteca de prompts previamente respaldada

## 📦 Guía de instalación

### Instalar desde la tienda de aplicaciones

¡Ya disponible en la Chrome Web Store! [Haz clic aquí para descargar e instalar](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Obtener desde GitHub Releases

1. Visita la [página de GitHub Releases](https://github.com/wenyuanw/quick-prompt/releases)
2. Descarga el paquete de la extensión ya compilado más reciente
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

### Instalar la extensión ya construida

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

¡Se agradecen Pull Requests y Issues!

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---