<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## Giriş

Tauri, tüm büyük masaüstü platformları için son derece küçük ve inanılmaz hızlı ikili dosyalar oluşturmak üzere geliştirilmiş bir çerçevedir. Geliştiriciler, kullanıcı arayüzlerini oluşturmak için HTML, JS ve CSS'ye derlenen herhangi bir ön uç çerçevesini entegre edebilirler. Uygulamanın arka ucu ise, ön uç ile etkileşim kurabilen bir API'ye sahip rust kaynaklı bir ikili dosyadır.

Tauri uygulamalarındaki kullanıcı arayüzü şu anda macOS, Windows, Linux, Android ve iOS'ta pencere yönetimi için [`tao`](https://docs.rs/tao) kütüphanesini kullanmaktadır. Uygulamanızın görselleştirilmesi için Tauri, [WRY](https://github.com/tauri-apps/wry) kütüphanesini kullanır. Bu kütüphane, sistemin web görünümüne birleşik bir arayüz sunar; macOS ve iOS'ta WKWebView, Windows'ta WebView2, Linux'ta ve Android'de WebKitGTK ve Android System WebView kullanır.

Tüm bu bileşenlerin nasıl bir araya geldiğine dair daha fazla ayrıntı için lütfen şu [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md) belgesine bakınız.

## Başlarken

Bir tauri uygulaması yapmakla ilgileniyorsanız lütfen [dokümantasyon web sitesini](https://tauri.app) ziyaret ediniz.

Başlamak için en hızlı yol, sisteminiz için [önkoşulları](https://v2.tauri.app/start/prerequisites/) yüklemek ve [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage) ile yeni bir proje oluşturmaktır. Örneğin, `npm` ile:

```sh
npm create tauri-app@latest
```

## Özellikler

Tauri'nin özellikleri şunlarla sınırlı olmamak üzere şunları içerir:

- `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` gibi formatlarda ve Windows yükleyicileri olan `.exe` (NSIS ile) ve `.msi` (WiX ile) gibi uygulama paketleri oluşturmak için yerleşik uygulama paketleyici.
- Yerleşik otomatik güncelleyici (sadece masaüstü)
- Sistem tepsisi simgeleri
- Yerel bildirimler
- Yerel WebView Protokolü (tauri, WebView içeriğini sunmak için bir localhost http(s) sunucusu oluşturmaz)
- Kolaylaştırılmış CI için GitHub action
- VS Code eklentisi

### Platformlar

Tauri şu anda aşağıdaki platformlarda geliştirme ve dağıtımı desteklemektedir:

| Platform   | Sürümler                                                                                                        |
| :--------- | :-------------------------------------------------------------------------------------------------------------- |
| Windows    | 7 ve üzeri                                                                                                      |
| macOS      | 10.15 ve üzeri                                                                                                  |
| Linux      | Tauri v1 için webkit2gtk 4.0 (örneğin Ubuntu 18.04). Tauri v2 için webkit2gtk 4.1 (örneğin Ubuntu 22.04).       |
| iOS/iPadOS | 9 ve üzeri                                                                                                      |
| Android    | 7 ve üzeri (şu anda 8 ve üzeri)                                                                                 |

## Katkı Sağlamak

Bir şey üzerinde çalışmaya başlamadan önce mevcut bir sorun olup olmadığını kontrol etmek en iyisidir. Ayrıca Discord sunucusuna uğrayıp ekiple bunun mantıklı olup olmadığını ya da başka birisinin üzerinde çalışıp çalışmadığını doğrulamak iyi bir fikirdir.

Lütfen bir pull request göndermeden önce [Katkı Rehberi](./.github/CONTRIBUTING.md)'ni okuduğunuzdan emin olun.

Tauri'ye katkı sağlayan herkese teşekkürler!

### Dokümantasyon

Çok dilli bir sistemde dokümantasyon hazırlamak zorlu bir iştir. Bu nedenle, mümkün olduğunca Rust & JS kaynak kodunda satır içi dokümantasyon kullanmayı tercih ediyoruz. Daha fazla bilgi için dokümantasyon sitesinin barındırıldığı depoyu inceleyebilirsiniz: <https://github.com/tauri-apps/tauri-docs>

## Partnerler

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

Tüm sponsorların tam listesi için lütfen [web sitemizi](https://tauri.app#sponsors) ve [Open Collective](https://opencollective.com/tauri) sayfasını ziyaret edin.

## Organizasyon

Tauri, [sürdürülebilir özgür ve açık kaynak yazılım topluluklarını](https://sfosc.org) yönlendiren ilkelere dayalı sürdürülebilir bir kolektif olmayı hedefler. Bu amaçla [Commons Conservancy](https://commonsconservancy.org/) bünyesinde bir Program olmuştur ve [Open Collective](https://opencollective.com/tauri) üzerinden finansal olarak katkı sağlayabilirsiniz.

## Lisanslar

Kod: (c) 2015 - Günümüz - The Tauri Programme within The Commons Conservancy.

MIT veya geçerli olduğu yerlerde MIT/Apache 2.0.

Logo: CC-BY-NC-ND

- Orijinal Tauri Logo Tasarımları [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) ve [Guillaume Chau](https://github.com/akryum) tarafından yapılmıştır.

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---