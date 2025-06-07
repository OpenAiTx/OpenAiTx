<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">Kurşun geçirmez UI bileşenlerini daha hızlı oluşturun</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Build Status on CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="License" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="Storybook Community" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="Backers on Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="Sponsors on Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Official Twitter Handle" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybook, UI bileşenleri ve sayfalarını izole bir şekilde oluşturmak için bir frontend atölyesidir. Binlerce ekip, UI geliştirme, test ve dokümantasyon için Storybook kullanıyor. Daha fazla bilgi için https://storybook.js.org adresini ziyaret edin!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  README’yi görüntüle:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## İçindekiler

- 🚀 [Başlarken](#getting-started)
- 📒 [Projeler](#projects)
  - 🛠 [Desteklenen Frameworkler & Örnekler](#supported-frameworks)
  - 🔗[Eklentiler](#addons)
- 🏅 [Rozetler & Sunum Materyalleri](#badges--presentation-materials)
- 👥 [Topluluk](#community)
- 👏 [Katkıda Bulunma](#contributing)
  - 👨‍💻 [Geliştirme Scriptleri](#development-scripts)
  - 💸 [Sponsorlar](#sponsors)
  - 💵 [Destekçiler](#backers)
- :memo: [Lisans](#license)

## Başlarken

Storybook hakkında daha fazla bilgi edinmek ve başlamak için [Storybook'un web sitesini](https://storybook.js.org) ziyaret edin.

### Dokümantasyon

Dokümantasyona [Storybook'un dokümanlar sitesinden](https://storybook.js.org/docs) ulaşabilirsiniz.

### Örnekler

Önde gelen ekiplerin Storybook’u nasıl kullandığını görmek için [Bileşen Ansiklopedisi’ni](https://storybook.js.org/showcase) inceleyin.

Stackblitz üzerinde hızlıca örnek bir proje oluşturmak için [storybook.new](https://storybook.new) adresini kullanın.

Storybook, bileşen tasarımı, dokümantasyon, test, etkileşim ve daha fazlası için birçok [eklenti](https://storybook.js.org/docs/configure/user-interface/storybook-addons) ile birlikte gelir. Storybook'un API'si, çeşitli şekillerde yapılandırma ve genişletme imkanı sunar. Hatta React Native, Android, iOS ve Flutter ile mobil geliştirmeye de uzatılmıştır.

### Topluluk

Ek yardım için, sorunuzu [deponun GitHub Tartışmaları’nda](https://github.com/storybookjs/storybook/discussions/new?category=help) paylaşabilirsiniz.

## Projeler

### Desteklenen Frameworkler

| Renderer                                                       | Demo                                                                                                                                                                         |                                                                                                                                                       |
| -------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                  | [![Storybook demo](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)          | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                          |
| [Angular](code/frameworks/angular/)                            | [![Storybook demo](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)        | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                  |
| [Vue 3](code/renderers/vue3)                                   | [![Storybook demo](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)           | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                           |
| [Web components](code/renderers/web-components)                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/) | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                       |
| [React Native](https://github.com/storybookjs/react-native)    | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                     | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)     |
| [HTML](code/renderers/html)                                    | [![Storybook demo](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)           | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                             |
| [Ember](code/frameworks/ember/)                                | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                        |
| [Svelte](code/renderers/svelte)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)         | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                       |
| [Preact](code/renderers/preact)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)         | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                       |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                    | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik) |
| [SolidJS](https://github.com/storybookjs/solidjs)              | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                           | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                     |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                           | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                       |

### Eklentiler

| Eklentiler                                                                 |                                                                            |
| -------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                  | Storybook'ta bileşenleri erişilebilirlik açısından test edin                |
| [actions](code/core/src/actions/)                                          | Kullanıcılar bileşenlerle etkileşime girdikçe eylemleri kaydedin           |
| [backgrounds](code/core/src/backgrounds)                                   | Storybook arayüzünde kullanıcıların arka plan seçmesine izin verin          |
| [cssresources](https://github.com/storybookjs/addon-cssresources)          | Bileşen iframe’ine dinamik olarak CSS kaynakları ekleyin/kaldırın          |
| [design assets](https://github.com/storybookjs/addon-design-assets)        | Hikayenizin yanında görsel, video ve weblinkleri görüntüleyin               |
| [docs](code/addons/docs/)                                                  | Bileşenlerinize yüksek kaliteli dokümantasyon ekleyin                      |
| [events](https://github.com/storybookjs/addon-events)                      | EventEmitter’a yanıt veren bileşenlere etkileşimli olay gönderin            |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics)  | Hikayeler üzerinde google analytics raporları                               |
| [graphql](https://github.com/storybookjs/addon-graphql)                    | Storybook hikayeleri içinde bir GraphQL sunucusuna sorgu gönderin           |
| [jest](code/addons/jest/)                                                  | Storybook’ta bileşenlerin birim test sonuçlarını görüntüleyin               |
| [links](code/addons/links/)                                                | Hikayeler arasında bağlantılar oluşturun                                    |
| [measure](code/core/src/measure/)                                          | Storybook arayüzünde düzeni ve kutu modelini görsel olarak inceleyin        |
| [outline](code/core/src/outline/)                                          | Storybook arayüzünde CSS düzeni ve hizalamayı görsel olarak hata ayıklayın  |
| [query params](https://github.com/storybookjs/addon-queryparams)           | Sorgu parametrelerini taklit edin                                           |
| [viewport](code/core/src/viewport/)                                        | Storybook ile duyarlı bileşenler için ekran boyutlarını ve düzenlerini değiştirin |

[Eklenti / Framework Destek Tablosu](https://storybook.js.org/docs/configure/integration/frameworks-feature-support) sayfasına bakın.

Deneyiminizi geliştirmeye devam etmek için, bazı eklentiler yeni ve daha iyi araçlar lehine zamanla kullanım dışı bırakılacak veya kaldırılacaktır.

info/notes kullanıyorsanız, [docs](code/addons/docs/) eklentisine geçmenizi önemle tavsiye ederiz, [burada](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons) yardımcı bir rehber bulabilirsiniz.

contexts kullanıyorsanız, [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars) eklentisine geçmenizi önemle tavsiye ederiz, [burada](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts) yardımcı bir rehber bulabilirsiniz.

addon-storyshots kullanıyorsanız, Storybook’un [test-runner](https://github.com/storybookjs/test-runner) aracına geçmenizi önemle tavsiye ederiz, [burada](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide) yardımcı bir rehber bulabilirsiniz.

## Rozetler & Sunum Materyalleri

Bir rozetimiz var! Canlı Storybook örneğinize bağlantı vermek için kullanın.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](siteye bağlantı)
```

Storybook sunumunuzda kullanmak üzere logo, video materyali ve kullandığımız renkler gibi materyaller arıyorsanız, hepsini [marka depomuzda](https://github.com/storybookjs/brand) bulabilirsiniz.

## Topluluk

- [@storybookjs](https://x.com/storybookjs) üzerinden tweet atıyoruz
- [storybook.js.org](https://storybook.js.org/blog/) ve [Medium](https://medium.com/storybookjs) üzerinde blog yazıyoruz
- [Discord](https://discord.gg/storybook) üzerinden sohbet ediyoruz
- [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg) kanalımızda videolar ve yayınlar yapıyoruz

## Katkıda Bulunma

Storybook’a katkılar her zaman memnuniyetle karşılanır!

- 📥 Pull request’ler ve 🌟 Yıldızlar her zaman hoş karşılanır.
- Başlamak için [katkı rehberimizi](CONTRIBUTING.md) okuyun,
  veya bizi [Discord](https://discord.gg/storybook) üzerinden bulun, size rehberlik etmek için zaman ayıracağız.

Çözmek için ilk bir sorun mu arıyorsunuz?

- Kod tabanına veya genel olarak açık kaynak projelere yeni olanlar için uygun olduğunu düşündüğümüz sorunları [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) etiketiyle işaretliyoruz.
- [Bizimle konuşun](https://discord.gg/storybook), yeteneklerinize ve ilgi alanlarınıza uygun bir konu bulacağız.

### Geliştirme Scriptleri

Storybook, bir monorepo olarak organize edilmiştir. Kullanışlı scriptler şunlardır:

#### `yarn start`

> Test hikayeleriyle bir sandbox şablon storybook'u çalıştırır

#### `yarn task`

> Yukarıdaki gibi, ancak sandbox'ı özelleştirmenize olanak tanır (ör. başka frameworkleri seçme)

#### `yarn lint`

> Kodun lint kurallarına uyup uymadığını kontrol eder - remark & eslint kullanır

- `yarn lint:js` - js dosyalarını kontrol eder
- `yarn lint:md` - markdown ve kod örneklerini kontrol eder
- `yarn lint:js --fix` - js dosyalarını otomatik olarak düzeltir

#### `yarn test`

> Birim testlerin hepsinin geçip geçmediğini kontrol eder - jest kullanır

- `yarn run test --core --watch` - core testleri izleme modunda çalıştırır

### Sponsorlar

Logonuzun ve web sitesi adresinizin Github’daki README’de yer alması için sponsor olun. \[[Sponsor olun](https://opencollective.com/storybook#sponsor)]

<a href="https://opencollective.com/storybook/tiers/sponsors/0/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/0/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/1/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/1/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/2/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/2/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/3/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/3/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/4/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/4/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/5/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/5/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/6/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/6/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/7/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/7/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/8/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/8/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/9/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/9/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/10/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/10/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/11/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/11/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/12/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/12/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/13/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/13/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/14/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/14/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/15/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/15/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/16/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/16/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/17/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/17/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/18/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/18/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/19/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/19/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/20/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/20/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/21/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/21/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/22/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/22/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/23/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/23/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/24/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/24/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/25/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/25/avatar.svg?requireActive=true"></a>

### Destekçiler

Düzenli bağış yaparak bize ve çalışmalarımıza destek olabilirsiniz. \[[Destekçi olun](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## Lisans

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-son-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---