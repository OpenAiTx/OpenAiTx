## Vue 2 Kullanım Dışı (End of Life) Aşamasına Ulaştı

**Şu anda Vue 2 için artık aktif olmayan depoya bakıyorsunuz. Vue'nun en son sürümü için aktif olarak sürdürülen depo [vuejs/core](https://github.com/vuejs/core)'dur.**

Vue, 31 Aralık 2023 tarihinde kullanım dışı (End of Life) aşamasına ulaştı. Artık yeni özellikler, güncellemeler veya düzeltmeler almamaktadır. Ancak, mevcut tüm dağıtım kanallarında (CDN’ler, paket yöneticileri, Github, vb.) hâlâ erişilebilir durumdadır.

Yeni bir projeye başlıyorsanız lütfen Vue’nun en son sürümü (3.x) ile başlayın. Şu anda Vue 2 kullananlara da yükseltme yapmalarını ([rehber](https://v3-migration.vuejs.org/)) şiddetle tavsiye ediyoruz, fakat tüm kullanıcıların bunu yapmak için yeterli zamanı veya motivasyonu olmadığının da farkındayız. Eğer Vue 2’de kalmak zorundaysanız ve bakım yapılmayan yazılımlar konusunda uyumluluk veya güvenlik gereksinimleriniz varsa, [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme)'e göz atabilirsiniz.

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## Sponsorlar

Vue.js, geliştirilmesine tamamen bu harika [destekçilerin](https://github.com/vuejs/core/blob/main/BACKERS.md) katkılarıyla devam eden MIT lisanslı açık kaynak bir projedir. Onlara katılmak isterseniz lütfen [Vue’nun geliştirilmesine sponsor olmayı](https://vuejs.org/sponsor/) değerlendirin.

<p align="center">
  <h3 align="center">Özel Sponsor</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="special sponsor appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="sponsors" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## Giriş

Vue (okunuşu `/vjuː/`, "view" gibi), kullanıcı arayüzleri oluşturmak için **ilerlemeli bir framework**’tür. Baştan aşağıya kademeli olarak benimsenebilir olacak şekilde tasarlanmıştır ve farklı kullanım durumlarına göre bir kütüphane ile bir framework arasında kolayca ölçeklenebilir. Sadece görünüm katmanına odaklanan erişilebilir bir çekirdek kütüphane ve büyük Tek Sayfa Uygulamaları'ndaki karmaşıklıklarla başa çıkmanıza yardımcı olan destekleyici kütüphanelerden oluşan bir ekosistemi vardır.

#### Tarayıcı Uyumluluğu

Vue.js, [ES5 uyumlu](https://compat-table.github.io/compat-table/es5/) tüm tarayıcıları destekler (IE8 ve altı desteklenmemektedir).

## Ekosistem

| Proje                 | Durum                                                        | Açıklama                                                |
| --------------------- | ------------------------------------------------------------ | ------------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                   | Tek sayfa uygulama yönlendirme                          |
| [vuex]                | [![vuex-status]][vuex-package]                               | Büyük ölçekli durum yönetimi                            |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                         | Proje başlatıcı (iskele)                                |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                   | Webpack için Tek Dosya Bileşeni (`*.vue` dosyası) yükleyici |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | Sunucu tarafı render desteği                            |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | Sınıf tabanlı API için TypeScript dekoratörü            |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                           | RxJS entegrasyonu                                       |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]               | Tarayıcı Geliştirici Araçları eklentisi                 |

[vue-router]: https://github.com/vuejs/vue-router
[vuex]: https://github.com/vuejs/vuex
[vue-cli]: https://github.com/vuejs/vue-cli
[vue-loader]: https://github.com/vuejs/vue-loader
[vue-server-renderer]: https://github.com/vuejs/vue/tree/dev/packages/vue-server-renderer
[vue-class-component]: https://github.com/vuejs/vue-class-component
[vue-rx]: https://github.com/vuejs/vue-rx
[vue-devtools]: https://github.com/vuejs/vue-devtools
[vue-router-status]: https://img.shields.io/npm/v/vue-router.svg
[vuex-status]: https://img.shields.io/npm/v/vuex.svg
[vue-cli-status]: https://img.shields.io/npm/v/@vue/cli.svg
[vue-loader-status]: https://img.shields.io/npm/v/vue-loader.svg
[vue-server-renderer-status]: https://img.shields.io/npm/v/vue-server-renderer.svg
[vue-class-component-status]: https://img.shields.io/npm/v/vue-class-component.svg
[vue-rx-status]: https://img.shields.io/npm/v/vue-rx.svg
[vue-devtools-status]: https://img.shields.io/chrome-web-store/v/nhdogjmejiglipccpnnnanhbledajbpd.svg
[vue-router-package]: https://npmjs.com/package/vue-router
[vuex-package]: https://npmjs.com/package/vuex
[vue-cli-package]: https://npmjs.com/package/@vue/cli
[vue-loader-package]: https://npmjs.com/package/vue-loader
[vue-server-renderer-package]: https://npmjs.com/package/vue-server-renderer
[vue-class-component-package]: https://npmjs.com/package/vue-class-component
[vue-rx-package]: https://npmjs.com/package/vue-rx
[vue-devtools-package]: https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd

## Dokümantasyon

[Canlı örnekleri](https://v2.vuejs.org/v2/examples/) ve dökümantasyonu görüntülemek için [vuejs.org](https://v2.vuejs.org) adresini ziyaret edin.

## Sorular

Sorularınız ve destek için lütfen [resmî forumu](https://forum.vuejs.org) veya [topluluk sohbetini](https://chat.vuejs.org/) kullanın. Bu deponun issue listesi **sadece** hata raporları ve özellik talepleri içindir.

## Hatalar (Issues)

Bir issue açmadan önce lütfen [Hata Bildirim Kontrol Listesini](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) okuyun. Yönergelere uymayan hatalar anında kapatılabilir.

## Değişiklik Günlüğü

Her sürüm için ayrıntılı değişiklikler [sürüm notlarında](https://github.com/vuejs/vue/releases) belgelenmiştir.

## İletişimde Kalın

- [Twitter](https://twitter.com/vuejs)
- [Blog](https://medium.com/the-vue-point)
- [İş İlanları](https://vuejobs.com/?ref=vuejs)

## Katkı

Pull request göndermeden önce lütfen [Katkı Rehberi](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md)'ni okuduğunuzdan emin olun. Vue ile ilgili bir projeniz/bileşeniniz/aracınız varsa, [bu seçilmiş listeye](https://github.com/vuejs/awesome-vue) pull request ile ekleyin!

Vue'ya zaten katkıda bulunan herkese teşekkürler!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## Lisans

[MIT](https://opensource.org/licenses/MIT)

Telif Hakkı (c) 2013-günümüz, Yuxi (Evan) You

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---