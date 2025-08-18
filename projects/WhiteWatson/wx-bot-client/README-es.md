# Hola, soy WxBotClient <img width="30px" src="https://media.tenor.com/images/3b388fe03da271d2674faf85eb7c3fcd/tenor.gif" />
Soy un software de gestión de WeChat de código abierto, desarrollado con electron, wechaty y vue, ahora integrado con ChatGPT. El paquete de instalación compilado está listo para usar, no depende de entornos complejos, el programa de gestión no se desconecta arbitrariamente, es estable y confiable.

<img align="right" height="200" src="https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./src/assets/icons/icon.png" />

---
## Método de instalación
### Descargar e instalar
[Enlace para descargar paquetes releases](https://github.com/WhiteWatson/wx-bot-client/releases), aquí puedes descargar el **paquete de instalación .exe (Windows)** ya compilado. Durante la descarga, el software podría advertirte que el archivo no es seguro, puedes ignorar esta advertencia y, una vez descargado, instalarlo localmente.

### Gestiona tu WeChat
Abre el software, haz clic en el botón **¡Comencemos!**, en la ventana emergente ingresa tu APIKey de openAI,

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/one.png)

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/apikeyinput.png)

Después de completar, haz clic en **Ahora mismo, iniciar el robot**, espera a que aparezca el código QR, una vez aparezca escanéalo con WeChat para iniciar sesión y gestionar tu cuenta.

tips: Para uso en China continental, usa una VPN, de lo contrario la API no funcionará y la IA permanecerá en estado de pensamiento.

### Configuración básica del robot
Después de iniciar sesión con éxito, accede al panel de gestión del robot, en el lado izquierdo haz clic en el menú **Configuración GPT**, donde podrás ver los ajustes básicos del robot.

En **Palabras clave de activación AI** modifica las palabras clave para activar el robot.

En **Chat grupal AI, Chat privado AI** puedes especificar los grupos o usuarios de WeChat a los que el robot dará servicio.

![markdown picture](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/images/gptsetting.png)

---
## Resumen de funciones
### Capacidad de diálogo AI por texto

```
提问格式： @AI + 问题内容

例：@AI 你是谁？
```
### Capacidad de generación de imágenes por IA

```
提问格式： /image + 图片提示词

例：/image 一个骑马的人
```
tips: Debido a que la IA puede generar fácilmente imágenes prohibidas, el robot envía directamente enlaces a imágenes, y los enlaces tienen una vigencia limitada.

---

## Despliegue personalizado
Este proyecto requiere un entorno node para ejecutarse localmente.

### Instalación de dependencias

Tenga en cuenta que aquí debe usar yarn o pnpm para instalar las dependencias.
```
yarn install
```

### Integración de ChatGPT y ejecución local del proyecto:

```
npm run electron:serve
```

### Empaquetar el paquete de instalación del cliente:
```
npm run electron:build
```
### Configurar openAI APIKey en el proyecto  
Ingrese al directorio `/src/bot/config.ts`, y llene el `Organization` y `APIKey` en la función `setApiKey` con los datos obtenidos desde la [entrada para solicitud de API en la web oficial de openAi](https://platform.openai.com/account/api-keys)  

### Si encuentra problemas [puede consultar primero este documento](https://raw.githubusercontent.com/WhiteWatson/wx-bot-client/main/./doc/problem.md)  

---  
## Soy un estudiante de Ingeniería en Ciencias de la Computación  

- 👨‍💻 Actualmente trabajo con tecnologías de desarrollo web como JavaScript, Vue, etc.  
- 💪🏼 Metas a futuro: Aprender más tecnologías - Nunca dejar de crear nuevas ideas.  
- ⚡ Dato curioso: Me encanta jugar Genshin Impact.  

### Agradecimiento especial a leeguiyu@qq.com por crear los iconos  

### Lenguajes y Herramientas 🛠  

![JavaScript](https://img.shields.io/badge/-JavaScript-%23F7DF1C?style=flat-square&logo=javascript&logoColor=000000&labelColor=%23F7DF1C&color=%23FFCE5A)  
![HTML5](https://img.shields.io/badge/-HTML5-%23E44D27?style=flat-square&logo=html5&logoColor=ffffff)  
![CSS3](https://img.shields.io/badge/-CSS3-%231572B6?style=flat-square&logo=css3)  
![Sass](https://img.shields.io/badge/-Sass-%23CC6699?style=flat-square&logo=sass&logoColor=ffffff)  
![Bootstrap](https://img.shields.io/badge/-Bootstrap-563D7C?style=flat-square&logo=Bootstrap)  
![Markdown](https://img.shields.io/badge/-Markdown-000000?style=flat-square&logo=markdown)  
![Nodejs](https://img.shields.io/badge/-Nodejs-339933?style=flat-square&logo=Node.js&logoColor=ffffff)  
![Npm](https://img.shields.io/badge/-npm-CB3837?style=flat-square&logo=npm)  
![Git](https://img.shields.io/badge/-Git-%23F05032?style=flat-square&logo=git&logoColor=%23ffffff)  
![GitHub](https://img.shields.io/badge/-GitHub-181717?style=flat-square&logo=github)  
![VS Code](http://img.shields.io/badge/-VS%20Code-007ACC?style=flat-square&logo=visual-studio-code&logoColor=ffffff)  
![Powershell](http://img.shields.io/badge/-Powershell-5391FE?style=flat-square&logo=powershell&logoColor=ffffff)  
![Windows](http://img.shields.io/badge/-Windows-0078D6?style=flat-square&logo=windows&logoColor=ffffff)  

<br/>  

<br/>  

  <h2 align="center"> Estadísticas de Github 📈 </h2>  
  
  <div align="center">   
     <a href="">  
      <img align="center" src="https://github-readme-stats-sigma-five.vercel.app/api?username=WhiteWatson&show_icons=true&include_all_commits=true&count_private=true&theme=react&line_height=40" />  
    </a>
    <a href="">
      <img align="center" src="https://github-readme-stats.vercel.app/api/top-langs/?username=WhiteWatson&theme=react&line_height=40&hide=css"/>
    </a>
</div
  
<br/>




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-18

---