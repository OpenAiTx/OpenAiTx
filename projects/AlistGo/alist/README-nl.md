<div align="center">
  <a href="https://alist.nn.ci"><img width="100px" alt="logo" src="https://cdn.jsdelivr.net/gh/alist-org/logo@main/logo.svg"/></a>
  <p><em>🗂️Een bestandslijstprogramma dat meerdere opslagdiensten ondersteunt, aangedreven door Gin en Solidjs.</em></p>
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

English | [中文](./README_cn.md) | [日本語](./README_ja.md) | [Bijdragen](./CONTRIBUTING.md) | [GEDRAGSCODE](./CODE_OF_CONDUCT.md)

## Functies

- [x] Meerdere opslagdiensten
    - [x] Lokale opslag
    - [x] [Aliyundrive](https://www.alipan.com/)
    - [x] OneDrive / Sharepoint ([globaal](https://www.office.com/), [cn](https://portal.partner.microsoftonline.cn),de,us)
    - [x] [189cloud](https://cloud.189.cn) (Persoonlijk, Familie)
    - [x] [GoogleDrive](https://drive.google.com/)
    - [x] [123pan](https://www.123pan.com/)
    - [x] FTP / SFTP
    - [x] [PikPak](https://www.mypikpak.com/)
    - [x] [S3](https://aws.amazon.com/s3/)
    - [x] [Seafile](https://seafile.com/)
    - [x] [UPYUN Storage Service](https://www.upyun.com/products/file-storage)
    - [x] WebDav (Ondersteuning OneDrive/SharePoint zonder API)
    - [x] Teambition ([China](https://www.teambition.com/ ),[Internationaal](https://us.teambition.com/ ))
    - [x] [Mediatrack](https://www.mediatrack.cn/)
    - [x] [139yun](https://yun.139.com/) (Persoonlijk, Familie, Groep)
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
- [x] Eenvoudig te implementeren en direct te gebruiken
- [x] Bestandsvoorbeeld (PDF, markdown, code, platte tekst, ...)
- [x] Afbeeldingsvoorbeeld in galerijmodus
- [x] Video- en audiovoorbeeld, ondersteuning voor songteksten en ondertitels
- [x] Voorbeeld van Office-documenten (docx, pptx, xlsx, ...)
- [x] `README.md` preview rendering
- [x] Permalink-kopie van bestand en direct downloaden van bestand
- [x] Donkere modus
- [x] I18n
- [x] Beschermde routes (wachtwoordbeveiliging en authenticatie)
- [x] WebDav (zie https://alist.nn.ci/guide/webdav.html voor details)
- [x] [Docker Deploy](https://hub.docker.com/r/xhofe/alist)
- [x] Cloudflare Workers proxy
- [x] Bestands-/Mappakket downloaden
- [x] Web upload (Kan bezoekers toestaan te uploaden), verwijderen, mkdir, hernoemen, verplaatsen en kopiëren
- [x] Offline downloaden
- [x] Kopieer bestanden tussen twee opslagdiensten
- [x] Multi-thread downloadversnelling voor single-thread download/stream

## Documentatie

<https://alistgo.com/>

## Demo

<https://al.nn.ci>

## Discussie

Ga naar ons [discussieforum](https://github.com/alist-org/alist/discussions) voor algemene vragen, **issues zijn alleen voor bugmeldingen en functieverzoeken.**

## Sponsor

AList is open-source software. Als je dit project leuk vindt en wilt dat ik ermee doorga, overweeg dan om mij te sponsoren of een eenmalige donatie te doen! Dank voor alle liefde en steun:
https://alist.nn.ci/guide/sponsor.html

### Speciale sponsors

- [VidHub](https://apps.apple.com/app/apple-store/id1659622164?pt=118612019&ct=alist&mt=8) - Een elegante cloud-videospeler binnen het Apple-ecosysteem. Ondersteuning voor iPhone, iPad, Mac en Apple TV.
- [亚洲云](https://www.asiayun.com/aff/QQCOOQKZ) - 高防服务器|服务器租用|福州高防|广东电信|香港服务器|美国服务器|海外服务器 - Een betrouwbare Chinese aanbieder van zakelijke cloud computing-diensten (gesponsorde Chinese API-server)
- [找资源](http://zhaoziyuan2.cc/) - Aliyun Disk bronnen zoekmachine

## Bijdragers

Dank aan deze geweldige mensen:

[![Bijdragers](http://contrib.nn.ci/api?repo=alist-org/alist&repo=alist-org/alist-web&repo=alist-org/docs)](https://github.com/alist-org/alist/graphs/contributors)

## Licentie

De `AList` is open-source software, gelicentieerd onder de AGPL-3.0-licentie.

## Disclaimer
- Dit programma is een gratis en open source project. Het is ontworpen om bestanden te delen op het netwerkstation, wat handig is voor het downloaden en leren van Golang. Houd je aan de relevante wetten en regelgeving bij gebruik en misbruik het niet;
- Dit programma is geïmplementeerd door het aanroepen van de officiële sdk/interface, zonder het officiële interfacegedrag te vernietigen;
- Dit programma voert alleen 302-omleidingen/verkeersdoorschakeling uit en onderschept, slaat of wijzigt geen gebruikersgegevens;
- Voor gebruik van dit programma dien je de bijbehorende risico's te begrijpen en te dragen, waaronder maar niet beperkt tot accountblokkering, download snelheidsbeperkingen, enz., dit valt niet onder de verantwoordelijkheid van dit programma;
- Bij inbreuk, neem contact met mij op via [email](mailto:i@nn.ci), het zal tijdig worden afgehandeld.

---

> [@GitHub](https://github.com/alist-org) · [@TelegramGroup](https://t.me/alist_chat) · [@Discord](https://discord.gg/F4ymsH4xv2)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---