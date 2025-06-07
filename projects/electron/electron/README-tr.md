[![Elektron Logosu](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![GitHub Actions Derleme Durumu](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Electron Discord Daveti](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: Mevcut Çeviriler: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
Bu dokümanları diğer dillerde [Crowdin](https://crowdin.com/project/electron) projemizde görüntüleyebilirsiniz.

Electron framework’ü, JavaScript, HTML ve CSS kullanarak çapraz platform masaüstü uygulamaları yazmanızı sağlar. [Node.js](https://nodejs.org/) ve [Chromium](https://www.chromium.org) tabanlıdır ve [Visual Studio Code](https://github.com/Microsoft/vscode/) ile birçok [uygulama](https://electronjs.org/apps) tarafından kullanılmaktadır.

Önemli duyurular için Twitter’da [@electronjs](https://twitter.com/electronjs) hesabını takip edin.

Bu proje, Contributor Covenant [davranış kurallarına](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md) bağlıdır.
Katılımda bulunarak, bu kurallara uymanız beklenir. Kabul edilemez davranışları [coc@electronjs.org](mailto:coc@electronjs.org) adresine bildirin.

## Kurulum

Önceden derlenmiş Electron ikili dosyalarını yüklemek için [`npm`](https://docs.npmjs.com/) kullanın.
Tercih edilen yöntem, Electron’u uygulamanızda geliştirme bağımlılığı olarak yüklemektir:

```sh
npm install electron --save-dev
```

Daha fazla kurulum seçeneği ve sorun giderme ipuçları için [kurulum](docs/tutorial/installation.md) bölümüne bakın. Uygulamalarınızda Electron sürümlerini nasıl yöneteceğiniz hakkında bilgi için [Electron sürümleme](docs/tutorial/electron-versioning.md) bölümüne göz atın.

## Platform desteği

Her Electron sürümü, macOS, Windows ve Linux için ikili dosyalar sağlar.

* macOS (Big Sur ve sonrası): Electron, macOS için 64-bit Intel ve Apple Silicon / ARM ikili dosyaları sağlar.
* Windows (Windows 10 ve sonrası): Electron, Windows için `ia32` (`x86`), `x64` (`amd64`) ve `arm64` ikili dosyalarını sağlar. Windows on ARM desteği Electron 5.0.8’de eklenmiştir. Windows 7, 8 ve 8.1 desteği, [Chromium’un Windows kullanım dışı bırakma politikası doğrultusunda Electron 23’te kaldırılmıştır](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux: Electron’un önceden derlenmiş ikili dosyaları Ubuntu 20.04 üzerinde derlenmiştir. Ayrıca şu sürümlerde de çalıştığı doğrulanmıştır:
  * Ubuntu 18.04 ve üzeri
  * Fedora 32 ve üzeri
  * Debian 10 ve üzeri

## Electron Fiddle

[`Electron Fiddle`](https://github.com/electron/fiddle) kullanarak küçük Electron denemeleri oluşturabilir, çalıştırabilir ve paketleyebilir, Electron’un tüm API’leri için kod örneklerini görebilir ve farklı Electron sürümlerini deneyebilirsiniz. Electron ile yolculuğunuza başlamanızı kolaylaştırmak için tasarlanmıştır.

## Electron öğrenmek için kaynaklar

* [electronjs.org/docs](https://electronjs.org/docs) - Electron’un tüm dokümantasyonu
* [electron/fiddle](https://github.com/electron/fiddle) - Küçük Electron denemeleri oluşturmak, çalıştırmak ve paketlemek için bir araç
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - Topluluk tarafından oluşturulmuş örnek başlangıç uygulamaları

## Programatik kullanım

Çoğu kişi Electron’u komut satırından kullanır, fakat **Node uygulamanızda** (Electron uygulamanızda değil) `electron`’u require ederseniz, ikili dosyanın dosya yolunu döndürür. Bunu, Node betiklerinden Electron başlatmak için kullanabilirsiniz:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// yaklaşık olarak /Users/maf/.../Electron gibi bir şey yazdırır
console.log(electron)

// Electron’u başlat
const child = proc.spawn(electron)
```

### Aynalar

* [Çin](https://npmmirror.com/mirrors/electron/)

Özel bir ayna kullanmayı öğrenmek için [Gelişmiş Kurulum Talimatları](https://www.electronjs.org/docs/latest/tutorial/installation#mirror) bölümüne bakın.

## Dokümantasyon çevirileri

Dokümantasyonumuzun çevirilerini [Crowdin](https://crowdin.com/project/electron) üzerinden topluluk ile birlikte sağlıyoruz.
Şu anda Çince (Basitleştirilmiş), Fransızca, Almanca, Japonca, Portekizce, Rusça ve İspanyolca çevirilerini kabul ediyoruz.

## Katkıda Bulunma

Hata bildirmek/düzeltmek ve doğrudan kod tabanına katkı sağlamakla ilgileniyorsanız, aradıklarımız ve başlamanın yolları hakkında daha fazla bilgi için lütfen [CONTRIBUTING.md](CONTRIBUTING.md) dosyasına bakın.

## Topluluk

Hataları bildirme, yardım alma, üçüncü taraf araçları ve örnek uygulamaları bulma ve daha fazlası hakkında bilgi için [Topluluk sayfasını](https://www.electronjs.org/community) ziyaret edin.

## Lisans

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Electron logolarını kullanırken, lütfen [OpenJS Foundation Marka Politikası](https://trademark-policy.openjsf.org/)’na uyduğunuzdan emin olun.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---