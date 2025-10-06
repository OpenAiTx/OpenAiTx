<div align="center">
  <img
    alt="logo"
    width="100"
    src="https://p.chilfish.top/weibo/icon.webp"
  />

  <div>
    <a href="https://deepwiki.com/Chilfish/Weibo-archiver"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
    <img src="https://wakatime.com/badge/user/0842a71f-c026-4b09-8aa0-f8398b4c3423/project/3416f224-f0dc-4b08-805c-af30dbd396b2.svg" alt="wakatime">
    <img alt="GitHub Repo stars" src="https://img.shields.io/github/stars/chilfish/weibo-archiver">
    <img alt="GitHub Downloads" src="https://img.shields.io/github/downloads/chilfish/weibo-archiver/total">
    <img alt="beta build" src="https://github.com/Chilfish/Weibo-archiver/actions/workflows/beta-build.yml/badge.svg">
  </div>
</div>

## Weibo-archiver

Archiva tus recuerdos de Sina Weibo, prepárate antes de que la cuenta desaparezca por completo 😭 Sitio oficial: [weibo-archiver.chilfish.top](https://weibo-archiver.chilfish.top)

![Portada](https://p.chilfish.top/weibo/cover.webp)

### Método de uso

Puedes consultar las instrucciones en la [documentación en línea]

> La versión antigua está disponible en la [rama v0.5](https://github.com/Chilfish/Weibo-archiver/tree/v0.5) o en https://weibo.chilfish.top/, consulta la sección [Documentación: Migración desde versiones antiguas](https://weibo-archiver.chilfish.top/docs/intro.html#从旧版本迁移) para más detalles

### Para desarrolladores

El proyecto utiliza una estructura monorepo, gestionada con pnpm, por lo que primero debes instalar pnpm: `npm i -g pnpm`

En el directorio packages:

- [/core](packages/core/) contiene funciones utilitarias y el núcleo del procesamiento de datos

En el directorio apps están las aplicaciones finales

- [/web](apps/web-v2/) es la página web para visualizar los datos de Weibo, actualmente alojada en [vercel]
- [/monkey](apps/monkey/) se usa para empaquetar el script de Tampermonkey
- [/cli](apps/cli) Versión de línea de comandos en Nodejs

> Antes de desplegar directamente en vercel, es necesario ir a la configuración del proyecto en vercel y establecer el Directorio Raíz como `apps/web-v2` para que pueda reconocer y construir correctamente el proyecto.

En el directorio server hay un servidor local escrito en lenguaje go, utilizado para descargar imágenes y navegar por los datos de Weibo, el método específico de uso se puede ver en [Instrucciones de uso del servidor local](https://raw.githubusercontent.com/Chilfish/Weibo-archiver/main/server/README.md)

### Agradecimientos

- Gracias a [speechless] por proporcionar la idea básica
- [vite-plugin-monkey] proporcionó la herramienta para empaquetar como script de Tampermonkey
- Shadcn/ui proporcionó una hermosa biblioteca de componentes UI
- [vercel] proporcionó la plataforma de nube en línea para despliegue 😚
- Github Copilot & v0.dev 😇

### Patrocinio

Si crees que este proyecto te ha sido útil, puedes considerar patrocinarme 😇 esto me dará más motivación para mantener este proyecto: [Dirección de patrocinio]

[releases]: https://raw.githubusercontent.com/Chilfish/Weibo-archiver/monkey/weibo-archiver.user.js
[scripts.zip]: https://github.com/Chilfish/Weibo-archiver/raw/monkey/scripts.zip
[speechless]: https://github.com/meterscao/Speechless
[naive-ui]: https://www.naiveui.com/zh-CN/os-theme
[#1]: https://github.com/Chilfish/Weibo-archiver/issues/1
[#5]: https://github.com/Chilfish/Weibo-archiver/issues/5
[Node.js 官网]: https://nodejs.org/en/download
[vite-plugin-monkey]: https://github.com/lisonge/vite-plugin-monkey
[镜像地址]: https://p.chilfish.top/weibo-archiver.user.js
[项目的 Todo]: https://github.com/Chilfish/Weibo-archiver/issues/7
[赞助地址]: https://chilfish.top/sponsors
[vercel]: https://vercel.com
[使用教程]: https://docs.qq.com/doc/DTWttbXlMUGxZZnZq
[actions]: https://github.com/Chilfish/Weibo-archiver/actions/workflows/beta-build.yml?query=branch:main+event:push+is:success
[微博网页版]: https://weibo.com
[在线文档]: https://weibo-archiver.chilfish.top/docs/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-06

---