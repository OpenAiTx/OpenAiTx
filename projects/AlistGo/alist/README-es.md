<div align="center">
  <a href="https://alist.nn.ci"><img width="100px" alt="logo" src="https://cdn.jsdelivr.net/gh/alist-org/logo@main/logo.svg"/></a>
  <p><em>🗂️Un programa de listado de archivos que soporta múltiples almacenamientos, impulsado por Gin y Solidjs.</em></p>
<div>
  <a href="https://goreportcard.com/report/github.com/alist-org/alist/v3">
    <img src="https://goreportcard.com/badge/github.com/alist-org/alist/v3" alt="latest version" />
  </a>
  <a href="https://github.com/alist-org/alist/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/Xhofe/alist" alt="License" />
  </a>
  <a href="https://github.com/alist-org/alist/actions?query=workflow%3ABuild">
    <img src="https://img.shields.io/github/actions/workflow/status/Xhofe/alist/build.yml?branch=main" alt="Build status" />
  </a>
  <a href="https://github.com/alist-org/alist/releases">
    <img src="https://img.shields.io/github/release/Xhofe/alist" alt="latest version" />
  </a>
  <a title="Crowdin" target="_blank" href="https://crwd.in/alist">
    <img src="https://badges.crowdin.net/alist/localized.svg">
  </a>
</div>
<div>
  <a href="https://github.com/alist-org/alist/discussions">
    <img src="https://img.shields.io/github/discussions/Xhofe/alist?color=%23ED8936" alt="discussions" />
  </a>
  <a href="https://discord.gg/F4ymsH4xv2">
    <img src="https://img.shields.io/discord/1018870125102895134?logo=discord" alt="discussions" />
  </a>
  <a href="https://github.com/alist-org/alist/releases">
    <img src="https://img.shields.io/github/downloads/Xhofe/alist/total?color=%239F7AEA&logo=github" alt="Downloads" />
  </a>
  <a href="https://hub.docker.com/r/xhofe/alist">
    <img src="https://img.shields.io/docker/pulls/xhofe/alist?color=%2348BB78&logo=docker&label=pulls" alt="Downloads" />
  </a>
  <a href="https://alist.nn.ci/guide/sponsor.html">
    <img src="https://img.shields.io/badge/%24-sponsor-F87171.svg" alt="sponsor" />
  </a>
</div>
</div>

---

English | [中文](./README_cn.md) | [日本語](./README_ja.md) | [Contributing](./CONTRIBUTING.md) | [CODE_OF_CONDUCT](./CODE_OF_CONDUCT.md)

## Características

- [x] Múltiples almacenamientos
    - [x] Almacenamiento local
    - [x] [Aliyundrive](https://www.alipan.com/)
    - [x] OneDrive / Sharepoint ([global](https://www.office.com/), [cn](https://portal.partner.microsoftonline.cn),de,us)
    - [x] [189cloud](https://cloud.189.cn) (Personal, Familiar)
    - [x] [GoogleDrive](https://drive.google.com/)
    - [x] [123pan](https://www.123pan.com/)
    - [x] FTP / SFTP
    - [x] [PikPak](https://www.mypikpak.com/)
    - [x] [S3](https://aws.amazon.com/s3/)
    - [x] [Seafile](https://seafile.com/)
    - [x] [UPYUN Storage Service](https://www.upyun.com/products/file-storage)
    - [x] WebDav (Soporta OneDrive/SharePoint sin API)
    - [x] Teambition([China](https://www.teambition.com/ ),[Internacional](https://us.teambition.com/ ))
    - [x] [Mediatrack](https://www.mediatrack.cn/)
    - [x] [139yun](https://yun.139.com/) (Personal, Familiar, Grupo)
    - [x] [YandexDisk](https://disk.yandex.com/)
    - [x] [BaiduNetdisk](http://pan.baidu.com/)
    - [x] [Terabox](https://www.terabox.com/main)
    - [x] [UC](https://drive.uc.cn)
    - [x] [Quark](https://pan.quark.cn)
    - [x] [Thunder](https://pan.xunlei.com)
    - [x] [Lanzou](https://www.lanzou.com/)
    - [x] [ILanzou](https://www.ilanzou.com/)
    - [x] [Aliyundrive share](https://www.alipan.com/)
    - [x] [Google photo](https://photos.google.com/)
    - [x] [Mega.nz](https://mega.nz)
    - [x] [Baidu photo](https://photo.baidu.com/)
    - [x] SMB
    - [x] [115](https://115.com/)
    - [X] Cloudreve
    - [x] [Dropbox](https://www.dropbox.com/)
    - [x] [FeijiPan](https://www.feijipan.com/)
    - [x] [dogecloud](https://www.dogecloud.com/product/oss)
    - [x] [Azure Blob Storage](https://azure.microsoft.com/products/storage/blobs)
- [x] Fácil de desplegar y listo para usar
- [x] Vista previa de archivos (PDF, markdown, código, texto plano, ...)
- [x] Vista previa de imágenes en modo galería
- [x] Vista previa de video y audio, soporta letras y subtítulos
- [x] Vista previa de documentos de Office (docx, pptx, xlsx, ...)
- [x] Renderizado de vista previa de `README.md`
- [x] Copia de enlace permanente de archivo y descarga directa de archivos
- [x] Modo oscuro
- [x] I18n
- [x] Rutas protegidas (protección por contraseña y autenticación)
- [x] WebDav (ver https://alist.nn.ci/guide/webdav.html para más detalles)
- [x] [Despliegue en Docker](https://hub.docker.com/r/xhofe/alist)
- [x] Proxy de Cloudflare Workers
- [x] Descarga de paquetes de archivos/carpetas
- [x] Subida web (puede permitir a los visitantes subir), eliminar, mkdir, renombrar, mover y copiar
- [x] Descarga offline
- [x] Copiar archivos entre dos almacenamientos
- [x] Aceleración de descarga multihilo para descarga/stream de un solo hilo

## Documentación

<https://alistgo.com/>

## Demo

<https://al.nn.ci>

## Discusión

Por favor, dirígete a nuestro [foro de discusión](https://github.com/alist-org/alist/discussions) para preguntas generales, **los issues son solo para reportes de errores y solicitudes de funcionalidades.**

## Patrocinio

AList es un software de código abierto, si te gusta este proyecto y quieres que siga adelante, ¡considera patrocinarme o realizar una donación única! Gracias por todo el cariño y apoyo:
https://alist.nn.ci/guide/sponsor.html

### Patrocinadores especiales

- [VidHub](https://apps.apple.com/app/apple-store/id1659622164?pt=118612019&ct=alist&mt=8) - Un elegante reproductor de video en la nube dentro del ecosistema de Apple. Soporte para iPhone, iPad, Mac y Apple TV.
- [亚洲云](https://www.asiayun.com/aff/QQCOOQKZ) - 高防服务器|服务器租用|福州高防|广东电信|香港服务器|美国服务器|海外服务器 - Proveedor confiable de servicios de computación en la nube empresarial en China (servidor API chino patrocinado)
- [找资源](http://zhaoziyuan2.cc/) - Motor de búsqueda de recursos de Aliyun Drive

## Colaboradores

Gracias a estas maravillosas personas:

[![Contributors](http://contrib.nn.ci/api?repo=alist-org/alist&repo=alist-org/alist-web&repo=alist-org/docs)](https://github.com/alist-org/alist/graphs/contributors)

## Licencia

`AList` es un software de código abierto bajo la licencia AGPL-3.0.

## Descargo de responsabilidad
- Este programa es un proyecto libre y de código abierto. Está diseñado para compartir archivos en el disco de red, lo que es conveniente para descargar y aprender Golang. Por favor, respete las leyes y regulaciones correspondientes al utilizarlo y no haga un mal uso de él;
- Este programa se implementa llamando al sdk/interfaz oficial, sin alterar el comportamiento de la interfaz oficial;
- Este programa solo realiza redireccionamiento 302/reenvío de tráfico y no intercepta, almacena ni manipula ningún dato de usuario;
- Antes de usar este programa, debe comprender y asumir los riesgos correspondientes, incluidos, entre otros, bloqueo de cuenta, limitación de velocidad de descarga, etc., que no son responsabilidad de este programa;
- Si existe alguna infracción, por favor contáctame por [correo electrónico](mailto:i@nn.ci), y será atendido a tiempo.

---

> [@GitHub](https://github.com/alist-org) · [@TelegramGroup](https://t.me/alist_chat) · [@Discord](https://discord.gg/F4ymsH4xv2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---