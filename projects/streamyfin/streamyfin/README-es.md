<a href="https://www.buymeacoffee.com/fredrikbur3" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Buy Me A Coffee" style="height: 41px !important;width: 174px !important;box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;-webkit-box-shadow: 0px 3px 2px 0px rgba(190, 190, 190, 0.5) !important;" ></a>


<p align="center">
  <img src="https://raw.githubusercontent.com/streamyfin/.github/refs/heads/main/streamyfin-github-banner.png" alt="Streamyfin" width="100%">
</p>

**Streamyfin es un cliente de streaming de video Jellyfin fácil de usar construido con Expo. Diseñado como una alternativa a otros clientes Jellyfin, tiene como objetivo ofrecer una experiencia de streaming fluida y confiable. Esperamos que lo encuentres una valiosa adición a tu caja de herramientas para streaming de medios.**

---

<p align="center">
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot1.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot3.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/screenshots/screenshot2.png" width="20%">
  &nbsp;
  <img src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/images/jellyseerr.PNG" width="21%">
</p>


## 🌟 Características

- 🚀 **Soporte para Saltar Intro / Créditos**: Te permite saltar rápidamente intros y créditos durante la reproducción
- 🖼️ **Imágenes Trickplay**: El nuevo estándar de oro para previsualizaciones de capítulos al buscar
- 📥 **Descargar medios**: Guarda tus medios localmente y míralos sin conexión
- ⚙️ **Gestión de configuraciones**: Administra configuraciones de la app para todos los usuarios a través de nuestro plugin
- 🤖 **Integración con Seerr (antes Jellyseerr)**: Solicita medios directamente en la app
- 👁️ **Vista de sesiones:** Visualiza todas las sesiones activas que están transmitiendo en tu servidor
- 📡 **Chromecast**: Envía tus medios a cualquier dispositivo compatible con Chromecast

## 🧪 Características Experimentales

Streamyfin ofrece emocionantes características experimentales como la descarga de medios y soporte para Chromecast. Estas características están en desarrollo activo, y tus comentarios y paciencia nos ayudan a mejorarlas.

### 📥 Descarga

La descarga funciona usando FFmpeg para convertir una transmisión HLS en un archivo de video en tu dispositivo. Esto te permite descargar y ver cualquier contenido que puedas transmitir. La conversión la maneja Jellyfin en tiempo real en el servidor durante la descarga. Aunque esto pueda tardar un poco más, garantiza compatibilidad con cualquier archivo que tu servidor pueda transcodificar.

### 🧩 Plugin Streamyfin

El Plugin Jellyfin para Streamyfin es un complemento que instalas en Jellyfin y que contiene todos los ajustes para el cliente Streamyfin. Esto te permite sincronizar configuraciones entre todos tus usuarios, como por ejemplo:

- Inicio de sesión automático en Seerr sin necesidad de entrada del usuario
- Establecer tus idiomas predeterminados preferidos
- Configurar el método de descarga y el proveedor de búsqueda
- Personalizar tu pantalla de inicio
- Y mucho más

[Plugin Streamyfin](https://github.com/streamyfin/jellyfin-plugin-streamyfin)

### 📡 Chromecast

El soporte para Chromecast está actualmente en desarrollo. La transmisión de video ya está disponible, y estamos trabajando activamente para añadir soporte de subtítulos y funciones adicionales.

### 🔍 Jellysearch

[Jellysearch](https://gitlab.com/DomiStyle/jellysearch) funciona con Streamyfin

> Un proxy de búsqueda de texto completo rápido para Jellyfin. Se integra perfectamente con la mayoría de los clientes Jellyfin.

## 🛣️ Hoja de Ruta

Consulta nuestra [Hoja de Ruta](https://github.com/users/fredrikburmester/projects/5) para ver en qué estamos trabajando a continuación, siempre estamos abiertos a comentarios y sugerencias. Por favor, háznos saber si tienes alguna idea o solicitud de función.

## 📥 Descargar Streamyfin

<div style="display: flex; gap: 5px;">
  <a href="https://apps.apple.com/app/streamyfin/id6593660679?l=en-GB"><img height=50 alt="Obtener Streamyfin en App Store" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Download_on_the_App_Store_Badge.png"/></a>
  <a href="https://play.google.com/store/apps/details?id=com.fredrikburmester.streamyfin"><img height=50 alt="Obtener Streamyfin en Google Play Store" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Google_Play_Store_badge_EN.svg"/></a>
  <a href="https://github.com/streamyfin/streamyfin/releases/latest"><img height=50 alt="Obtener Streamyfin en Github" src="https://raw.githubusercontent.com/streamyfin/streamyfin/develop/./assets/Download_on_Github_.png"/></a>
</div>

### 🧪 Pruebas Beta

Para acceder a la beta de Streamyfin, necesitas suscribirte al nivel Miembro (o superior) en [Patreon](https://www.patreon.com/streamyfin). Esto te da acceso inmediato al canal ⁠🧪-beta-releases en Discord y me avisa que te has suscrito. Aquí es donde comparto APKs e IPAs. No proporciona acceso automático a TestFlight, así que por favor envíame un DM (Cagemaster) con el correo electrónico que usas para Apple para agregarte manualmente.

**Nota**: Cualquier persona que contribuya activamente al código fuente de Streamyfin recibirá acceso automático a las versiones beta.

## 🚀 Comenzando

### ⚙️ Requisitos previos

- Tu dispositivo está en la misma red que el servidor Jellyfin (para conexiones locales)  
- Tu servidor Jellyfin está en funcionamiento con acceso remoto habilitado si planeas conectarte desde fuera de tu red local  
- La versión de tu servidor está actualizada (las versiones antiguas pueden causar problemas de compatibilidad)  
- Tienes una cuenta de usuario Jellyfin válida con acceso a las bibliotecas de medios que deseas ver  
- Si usas funciones como **descargas** o **integración con Seerr**, confirma que los plugins requeridos están instalados y configurados en tu servidor Jellyfin

## 🙌 Contribuciones

Damos la bienvenida a contribuciones que mejoren Streamyfin. Comienza haciendo un fork del repositorio y enviando un pull request. Para cambios importantes o nuevas funciones, por favor abre primero un issue para discutir tus ideas y asegurar la alineación con el proyecto.

## 🌍 Traducciones

[![Estado de Traducción en Crowdin](https://badges.crowdin.net/streamyfin/localized.svg)](https://crowdin.com/project/streamyfin)

Streamyfin está disponible en múltiples idiomas, y siempre buscamos colaboradores para ayudar a que la app sea accesible mundialmente.  
Puedes contribuir con traducciones directamente en nuestra [página del proyecto Crowdin](https://crowdin.com/project/streamyfin).

### 👨‍💻 Información de Desarrollo

1. Usa node `>20`  
2. Instala dependencias `bun i && bun run submodule-reload`  
3. Asegúrate de tener instalado xcode y/o android studio. (sigue las guías para expo: https://docs.expo.dev/workflow/android-studio-emulator/)  
4. Instala la extensión BiomeJS en VSCode/Tu IDE (https://biomejs.dev/)  
4. ejecuta `npm run prebuild`  
5. Crea una build de desarrollo expo ejecutando `npm run ios` o `npm run android`. Esto abrirá un simulador en tu computadora y ejecutará la app

Para la versión TV añade el sufijo a los comandos npm con `:tv`.

`npm run prebuild:tv`  
`npm run ios:tv o npm run android:tv`

## 👋 Ponte en Contacto con Nosotros

¿Necesitas ayuda o tienes alguna pregunta?

- **Discord:** [Únete a nuestro servidor](https://discord.gg/BuGG9ZNhaE)
- **Problemas en GitHub:** [Reportar errores o solicitar funciones](https://github.com/streamyfin/streamyfin/issues)  
- **Correo electrónico:** [developer@streamyfin.app](https://raw.githubusercontent.com/streamyfin/streamyfin/develop/mailto:developer@streamyfin.app)  


## ❓ Preguntas Frecuentes

1. P: ¿Por qué no puedo ver mis bibliotecas en Streamyfin?  
   R: Asegúrate de que tu servidor esté ejecutando una de las versiones más recientes y que tengas al menos una biblioteca que no sea solo de audio
2. P: ¿Por qué no puedo ver mi biblioteca de música?  
   R: Actualmente no soportamos música y es poco probable que la soportemos en un futuro cercano

## 📝 Créditos

Streamyfin es desarrollado por [Fredrik Burmester](https://github.com/fredrikburmester) y no está afiliado con Jellyfin. La aplicación está construida usando Expo, React Native y otras bibliotecas de código abierto.

## 🎖️ Desarrolladores Principales

Gracias a los siguientes colaboradores por sus importantes contribuciones:

<div align="left">
<table>
  <tr>
    <td align="center">
      <a href="https://github.com/Alexk2309">
        <img src="https://github.com/Alexk2309.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Alexk2309</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/herrrta">
        <img src="https://github.com/herrrta.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@herrrta</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/lostb1t">
        <img src="https://github.com/lostb1t.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@lostb1t</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Simon-Eklundh">
        <img src="https://github.com/Simon-Eklundh.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Simon-Eklundh</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/topiga">
        <img src="https://github.com/topiga.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@topiga</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/lancechant">
        <img src="https://github.com/lancechant.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@lancechant</b></sub>
      </a>
    </td>
  </tr>
  <tr>
    <td align="center">
      <a href="https://github.com/simoncaron">
        <img src="https://github.com/simoncaron.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@simoncaron</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/jakequade">
        <img src="https://github.com/jakequade.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@jakequade</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Ryan0204">
        <img src="https://github.com/Ryan0204.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Ryan0204</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/retardgerman">
        <img src="https://github.com/retardgerman.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@retardgerman</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/whoopsi-daisy">
        <img src="https://github.com/whoopsi-daisy.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@whoopsi-daisy</b></sub>
      </a>
    </td>
    <td align="center">
      <a href="https://github.com/Gauvino">
        <img src="https://github.com/Gauvino.png?size=55" width="55" style="border-radius: 50%;" />
        <br /><sub><b>@Gauvino</b></sub>
      </a>
    </td>
  </tr>
</table>
</div>

## ✨ Acknowledgements

We would like to thank the Jellyfin team for their excellent software and support on Discord.

Special thanks to the official Jellyfin clients, which have served as an inspiration for Streamyfin.

We also thank all other developers who have contributed to Streamyfin, your efforts are greatly appreciated.

A special mention to the following people and projects for their contributions:

- [Reiverr](https://github.com/aleksilassila/reiverr) for invaluable help with understanding the Jellyfin API
- [Jellyfin TS SDK](https://github.com/jellyfin/jellyfin-sdk-typescript) for providing the TypeScript SDK
- [Seerr](https://github.com/seerr-team/seerr) for enabling API integration with their project


## ⭐ Star History

[![Star History Chart](https://api.star-history.com/svg?repos=streamyfin/streamyfin&type=Date)](https://star-history.com/#streamyfin/streamyfin&Date)

## 📄 License
Streamyfin está licenciado bajo la Licencia Pública de Mozilla 2.0 (MPL-2.0).  
Esto significa que eres libre de usar, modificar y distribuir este software. La MPL-2.0 es una licencia copyleft que permite mayor flexibilidad al combinar el software con código propietario.  
Puntos clave de la MPL-2.0:  

- Puedes usar el software para cualquier propósito  
- Puedes modificar el software y distribuir versiones modificadas  
- Debes incluir los avisos originales de copyright y licencia  
- Debes divulgar tu código fuente para cualquier modificación a los archivos cubiertos  
- Obras mayores pueden combinar código MPL con código bajo otras licencias  
- Los componentes bajo MPL deben permanecer bajo MPL, pero la obra mayor puede estar bajo una licencia diferente  
- Para el texto completo de la licencia, consulta el archivo LICENSE en este repositorio  

## ⚠️ Descargo de responsabilidad  
Streamyfin no promueve, apoya ni condona la piratería de ninguna forma. La aplicación está destinada únicamente para reproducir medios que poseas y controles personalmente. No provee ni incluye ningún contenido multimedia. Cualquier discusión, solicitud de soporte o referencia a la piratería, así como cualquier herramienta, software o sitio web relacionado con la piratería, está estrictamente prohibida en todos nuestros canales.  

## 🤝 Patrocinio  
Hospedaje VPS proporcionado generosamente por [Hexabyte](https://hexabyte.se/en/vps/?currency=eur) y [SweHosting](https://swehosting.se/en/#tj%C3%A4nster)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---