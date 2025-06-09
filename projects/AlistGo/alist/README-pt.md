<div align="center">
  <a href="https://alist.nn.ci"><img width="100px" alt="logo" src="https://cdn.jsdelivr.net/gh/alist-org/logo@main/logo.svg"/></a>
  <p><em>🗂️Um programa de listagem de arquivos que suporta múltiplos armazenamentos, desenvolvido com Gin e Solidjs.</em></p>
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

## Funcionalidades

- [x] Múltiplos armazenamentos
    - [x] Armazenamento local
    - [x] [Aliyundrive](https://www.alipan.com/)
    - [x] OneDrive / Sharepoint ([global](https://www.office.com/), [cn](https://portal.partner.microsoftonline.cn),de,us)
    - [x] [189cloud](https://cloud.189.cn) (Pessoal, Família)
    - [x] [GoogleDrive](https://drive.google.com/)
    - [x] [123pan](https://www.123pan.com/)
    - [x] FTP / SFTP
    - [x] [PikPak](https://www.mypikpak.com/)
    - [x] [S3](https://aws.amazon.com/s3/)
    - [x] [Seafile](https://seafile.com/)
    - [x] [UPYUN Storage Service](https://www.upyun.com/products/file-storage)
    - [x] WebDav (Suporte a OneDrive/SharePoint sem API)
    - [x] Teambition ([China](https://www.teambition.com/ ),[Internacional](https://us.teambition.com/ ))
    - [x] [Mediatrack](https://www.mediatrack.cn/)
    - [x] [139yun](https://yun.139.com/) (Pessoal, Família, Grupo)
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
- [x] Fácil de implantar e pronto para uso
- [x] Pré-visualização de arquivos (PDF, markdown, código, texto simples, ...)
- [x] Pré-visualização de imagens no modo galeria
- [x] Pré-visualização de vídeo e áudio, suporte a letras e legendas
- [x] Pré-visualização de documentos Office (docx, pptx, xlsx, ...)
- [x] Renderização de visualização do `README.md`
- [x] Cópia de link permanente do arquivo e download direto do arquivo
- [x] Modo escuro
- [x] I18n
- [x] Rotas protegidas (proteção por senha e autenticação)
- [x] WebDav (veja https://alist.nn.ci/guide/webdav.html para detalhes)
- [x] [Deploy com Docker](https://hub.docker.com/r/xhofe/alist)
- [x] Proxy Cloudflare Workers
- [x] Download de pacotes de Arquivo/Pasta
- [x] Upload via web (Pode permitir visitantes a enviar arquivos), deletar, criar pasta, renomear, mover e copiar
- [x] Download offline
- [x] Copiar arquivos entre dois armazenamentos
- [x] Aceleração de download multithread para download/stream de thread única

## Documentação

<https://alistgo.com/>

## Demonstração

<https://al.nn.ci>

## Discussão

Por favor, acesse nosso [fórum de discussão](https://github.com/alist-org/alist/discussions) para dúvidas gerais, **issues são apenas para relatórios de bugs e solicitações de funcionalidades.**

## Patrocínio

AList é um software de código aberto, se você gosta deste projeto e quer que ele continue, considere me patrocinar ou fazer uma doação única! Obrigado por todo o apoio e carinho:
https://alist.nn.ci/guide/sponsor.html

### Patrocinadores especiais

- [VidHub](https://apps.apple.com/app/apple-store/id1659622164?pt=118612019&ct=alist&mt=8) - Um elegante player de vídeo em nuvem no ecossistema Apple. Suporte para iPhone, iPad, Mac e Apple TV.
- [亚洲云](https://www.asiayun.com/aff/QQCOOQKZ) - Servidor de alta proteção | Aluguel de servidores | Fuzhou proteção alta | Guangdong Telecom | Servidor Hong Kong | Servidor EUA | Servidor internacional - Provedor nacional confiável de serviços de computação em nuvem corporativa (patrocinador do servidor API chinês)
- [找资源](http://zhaoziyuan2.cc/) - Motor de busca de recursos do Aliyun Drive

## Contribuidores

Agradecimentos a estas pessoas incríveis:

[![Contributors](http://contrib.nn.ci/api?repo=alist-org/alist&repo=alist-org/alist-web&repo=alist-org/docs)](https://github.com/alist-org/alist/graphs/contributors)

## Licença

O `AList` é um software de código aberto licenciado sob a licença AGPL-3.0.

## Aviso Legal
- Este programa é um projeto gratuito e de código aberto. Ele foi projetado para compartilhar arquivos em disco de rede, sendo conveniente para download e aprendizado de Golang. Por favor, siga as leis e regulamentos ao utilizá-lo e não o abuse;
- Este programa é implementado utilizando o sdk/interface oficial, sem violar o comportamento da interface oficial;
- Este programa apenas faz redirecionamento 302/encaminhamento de tráfego, não intercepta, armazena ou altera quaisquer dados do usuário;
- Antes de utilizar este programa, você deve compreender e assumir os riscos correspondentes, incluindo, mas não se limitando a, banimento de conta, limitação de velocidade de download, etc., que não são de responsabilidade deste programa;
- Em caso de infração, por favor, entre em contato por [email](mailto:i@nn.ci), e será tratado em tempo hábil.

---

> [@GitHub](https://github.com/alist-org) · [@TelegramGroup](https://t.me/alist_chat) · [@Discord](https://discord.gg/F4ymsH4xv2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---