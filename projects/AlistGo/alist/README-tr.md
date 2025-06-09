<div align="center">
  <a href="https://alist.nn.ci"><img width="100px" alt="logo" src="https://cdn.jsdelivr.net/gh/alist-org/logo@main/logo.svg"/></a>
  <p><em>🗂️Birden fazla depolamayı destekleyen, Gin ve Solidjs ile güçlendirilmiş bir dosya listeleme programı.</em></p>
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

English | [中文](./README_cn.md) | [日本語](./README_ja.md) | [Katkıda Bulunanlar](./CONTRIBUTING.md) | [KOD DAVRANIŞ KURALLARI](./CODE_OF_CONDUCT.md)

## Özellikler

- [x] Birden fazla depolama desteği
    - [x] Yerel depolama
    - [x] [Aliyundrive](https://www.alipan.com/)
    - [x] OneDrive / Sharepoint ([global](https://www.office.com/), [cn](https://portal.partner.microsoftonline.cn),de,us)
    - [x] [189cloud](https://cloud.189.cn) (Bireysel, Aile)
    - [x] [GoogleDrive](https://drive.google.com/)
    - [x] [123pan](https://www.123pan.com/)
    - [x] FTP / SFTP
    - [x] [PikPak](https://www.mypikpak.com/)
    - [x] [S3](https://aws.amazon.com/s3/)
    - [x] [Seafile](https://seafile.com/)
    - [x] [UPYUN Storage Service](https://www.upyun.com/products/file-storage)
    - [x] WebDav (API olmadan OneDrive/SharePoint desteği)
    - [x] Teambition([Çin](https://www.teambition.com/ ),[Uluslararası](https://us.teambition.com/ ))
    - [x] [Mediatrack](https://www.mediatrack.cn/)
    - [x] [139yun](https://yun.139.com/) (Bireysel, Aile, Grup)
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
- [x] Kolay kurulum ve kutudan çıktığı gibi çalışma
- [x] Dosya önizlemesi (PDF, markdown, kod, düz metin, ...)
- [x] Galeri modunda görsel önizleme
- [x] Video ve ses önizlemesi, şarkı sözü ve altyazı desteği
- [x] Ofis dökümanları önizlemesi (docx, pptx, xlsx, ...)
- [x] `README.md` önizleme ve render
- [x] Dosya kalıcı bağlantısı kopyalama ve doğrudan dosya indirme
- [x] Koyu mod
- [x] I18n
- [x] Korumalı yollar (şifre koruması ve kimlik doğrulama)
- [x] WebDav (detaylar için bkz. https://alist.nn.ci/guide/webdav.html)
- [x] [Docker ile Kurulum](https://hub.docker.com/r/xhofe/alist)
- [x] Cloudflare Workers proxy
- [x] Dosya/Klasör paket indirme
- [x] Web üzerinden yükleme (Ziyaretçilerin yüklemesine izin verilebilir), silme, klasör oluşturma, yeniden adlandırma, taşıma ve kopyalama
- [x] Çevrimdışı indirme
- [x] İki depolama arasında dosya kopyalama
- [x] Tekli iş parçacığı indirme/akış için çoklu iş parçacıklı indirme hızlandırma

## Doküman

<https://alistgo.com/>

## Demo

<https://al.nn.ci>

## Tartışma

Genel sorular için lütfen [tartışma forumumuza](https://github.com/alist-org/alist/discussions) gidin, **sorunlar sadece hata raporları ve özellik istekleri içindir.**

## Sponsor

AList açık kaynaklı bir yazılımdır, eğer bu projeyi beğendiyseniz ve devam etmemi istiyorsanız lütfen bana sponsor olmayı veya tek seferlik bağışta bulunmayı düşünün! Tüm sevgi ve desteğiniz için teşekkürler:
https://alist.nn.ci/guide/sponsor.html

### Özel sponsorlar

- [VidHub](https://apps.apple.com/app/apple-store/id1659622164?pt=118612019&ct=alist&mt=8) - Apple ekosistemi içinde şık bir bulut video oynatıcı. iPhone, iPad, Mac ve Apple TV desteği.
- [亚洲云](https://www.asiayun.com/aff/QQCOOQKZ) - Yüksek korumalı sunucu|Sunucu kiralama|Fuzhou yüksek korumalı|Guangdong Telekom|Hong Kong sunucu|ABD sunucu|Yurtdışı sunucu - Çin'de güvenilir kurumsal bulut bilişim hizmeti sağlayıcısı (Çin API sunucusu sponsoru)
- [找资源](http://zhaoziyuan2.cc/) - Aliyun Disk Kaynak Arama Motoru

## Katkıda Bulunanlar

Şu harika insanlara teşekkürler:

[![Katkıda Bulunanlar](http://contrib.nn.ci/api?repo=alist-org/alist&repo=alist-org/alist-web&repo=alist-org/docs)](https://github.com/alist-org/alist/graphs/contributors)

## Lisans

`AList`, AGPL-3.0 lisansı altında açık kaynaklı bir yazılımdır.

## Feragatname
- Bu program ücretsiz ve açık kaynaklı bir projedir. Ağ diskinde dosya paylaşımı için tasarlanmıştır, Golang indirme ve öğrenme için uygundur. Lütfen kullanırken ilgili yasa ve yönetmeliklere uyunuz ve kötüye kullanmayınız;
- Bu program, resmi sdk/arayıcıları çağırarak uygulanmıştır, resmi arayüz davranışını bozmaz;
- Bu program sadece 302 yönlendirme/trafik iletimi yapar, herhangi bir kullanıcı verisini engellemez, saklamaz veya değiştirmez;
- Bu programı kullanmadan önce, ilgili riskleri (hesap yasağı, indirme hızı sınırlaması vb. dahil ancak bunlarla sınırlı olmamak üzere) anlamalı ve bunları kabul etmelisiniz, bunlar programın sorumluluğu değildir;
- Herhangi bir ihlal durumu varsa, lütfen [email](mailto:i@nn.ci) ile iletişime geçiniz, zamanında işlem yapılacaktır.

---

> [@GitHub](https://github.com/alist-org) · [@TelegramGroup](https://t.me/alist_chat) · [@Discord](https://discord.gg/F4ymsH4xv2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---