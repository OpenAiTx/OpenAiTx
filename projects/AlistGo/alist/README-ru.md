<div align="center">
  <a href="https://alist.nn.ci"><img width="100px" alt="logo" src="https://cdn.jsdelivr.net/gh/alist-org/logo@main/logo.svg"/></a>
  <p><em>🗂️Программа для отображения файлов, поддерживающая множество хранилищ, работает на Gin и Solidjs.</em></p>
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

## Возможности

- [x] Множественные хранилища
    - [x] Локальное хранилище
    - [x] [Aliyundrive](https://www.alipan.com/)
    - [x] OneDrive / Sharepoint ([global](https://www.office.com/), [cn](https://portal.partner.microsoftonline.cn),de,us)
    - [x] [189cloud](https://cloud.189.cn) (Персональное, Семейное)
    - [x] [GoogleDrive](https://drive.google.com/)
    - [x] [123pan](https://www.123pan.com/)
    - [x] FTP / SFTP
    - [x] [PikPak](https://www.mypikpak.com/)
    - [x] [S3](https://aws.amazon.com/s3/)
    - [x] [Seafile](https://seafile.com/)
    - [x] [UPYUN Storage Service](https://www.upyun.com/products/file-storage)
    - [x] WebDav (Поддержка OneDrive/SharePoint без API)
    - [x] Teambition ([China](https://www.teambition.com/ ), [International](https://us.teambition.com/ ))
    - [x] [Mediatrack](https://www.mediatrack.cn/)
    - [x] [139yun](https://yun.139.com/) (Персональное, Семейное, Групповое)
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
- [x] Легко развернуть и использовать «из коробки»
- [x] Предпросмотр файлов (PDF, markdown, код, обычный текст, ...)
- [x] Просмотр изображений в режиме галереи
- [x] Просмотр видео и аудио, поддержка текста песен и субтитров
- [x] Просмотр офисных документов (docx, pptx, xlsx, ...)
- [x] Рендеринг предпросмотра `README.md`
- [x] Копирование постоянной ссылки на файл и прямая загрузка файла
- [x] Тёмный режим
- [x] I18n
- [x] Защищённые маршруты (защита паролем и аутентификация)
- [x] WebDav (см. https://alist.nn.ci/guide/webdav.html для подробностей)
- [x] [Деплой Docker](https://hub.docker.com/r/xhofe/alist)
- [x] Прокси через Cloudflare Workers
- [x] Скачивание архивом файлов/папок
- [x] Веб-загрузка (можно разрешить посетителям загружать), удаление, создание папок, переименование, перемещение и копирование
- [x] Оффлайн-загрузка
- [x] Копирование файлов между двумя хранилищами
- [x] Многопоточное ускорение загрузки для однопоточного скачивания/потоковой передачи

## Документация

<https://alistgo.com/>

## Демо

<https://al.nn.ci>

## Обсуждение

Пожалуйста, переходите на наш [форум обсуждений](https://github.com/alist-org/alist/discussions) для общих вопросов, **issues предназначены только для сообщений об ошибках и запросов на новые функции.**

## Спонсорство

AList — это программное обеспечение с открытым исходным кодом. Если вам понравился этот проект и вы хотите поддержать дальнейшую разработку, пожалуйста, рассмотрите возможность спонсорства или разовой поддержки! Спасибо за вашу любовь и поддержку:
https://alist.nn.ci/guide/sponsor.html

### Особые спонсоры

- [VidHub](https://apps.apple.com/app/apple-store/id1659622164?pt=118612019&ct=alist&mt=8) — Элегантный облачный видеоплеер в экосистеме Apple. Поддержка iPhone, iPad, Mac и Apple TV.
- [亚洲云](https://www.asiayun.com/aff/QQCOOQKZ) — Высокозащищённые серверы | Аренда серверов | Фуцзяньский high-protection | Гуандунский China Telecom | Гонконгские серверы | Американские серверы | Зарубежные серверы — Надёжный отечественный провайдер облачных вычислений для бизнеса (спонсор китайского API-сервера)
- [找资源](http://zhaoziyuan2.cc/) — Поисковая система ресурсов для облака Aliyun

## Участники

Спасибо этим замечательным людям:

[![Contributors](http://contrib.nn.ci/api?repo=alist-org/alist&repo=alist-org/alist-web&repo=alist-org/docs)](https://github.com/alist-org/alist/graphs/contributors)

## Лицензия

`AList` распространяется по лицензии AGPL-3.0.

## Отказ от ответственности
- Эта программа является бесплатным проектом с открытым исходным кодом. Она предназначена для обмена файлами в сетевом диске и облегчения загрузки и изучения Golang. Пожалуйста, соблюдайте соответствующие законы и правила при использовании и не злоупотребляйте программой;
- Данная программа реализована с использованием официальных sdk/интерфейсов, не нарушая работу официальных интерфейсов;
- Программа выполняет только перенаправление 302/пересылку трафика и не перехватывает, не хранит и не изменяет какие-либо пользовательские данные;
- Перед использованием программы вы должны понимать и принимать соответствующие риски, включая, но не ограничиваясь блокировкой аккаунта, ограничением скорости скачивания и т.д., за что программа ответственности не несёт;
- В случае нарушения авторских прав свяжитесь со мной по [email](mailto:i@nn.ci), и вопрос будет оперативно решён.

---

> [@GitHub](https://github.com/alist-org) · [@TelegramGroup](https://t.me/alist_chat) · [@Discord](https://discord.gg/F4ymsH4xv2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---