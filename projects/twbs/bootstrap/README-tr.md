<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  Daha hızlı ve kolay web geliştirme için şık, sezgisel ve güçlü ön yüz çerçevesi.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Bootstrap dokümantasyonunu keşfedin »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">Hata bildir</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">Özellik isteği</a>
  ·
  <a href="https://themes.getbootstrap.com/">Temalar</a>
  ·
  <a href="https://blog.getbootstrap.com/">Blog</a>
</p>


## Bootstrap 5

Varsayılan dalımız Bootstrap 5 sürümümüzün geliştirilmesi içindir. Bootstrap 4'ün readme, dokümantasyon ve kaynak kodunu görüntülemek için [`v4-dev` dalına](https://github.com/twbs/bootstrap/tree/v4-dev) gidin.


## İçindekiler

- [Hızlı başlangıç](#hızlı-başlangıç)
- [Durum](#durum)
- [Neler dahil](#neler-dahil)
- [Hatalar ve özellik istekleri](#hatalar-ve-özellik-istekleri)
- [Dokümantasyon](#dokümantasyon)
- [Katkıda Bulunma](#katkıda-bulunma)
- [Topluluk](#topluluk)
- [Sürümleme](#sürümleme)
- [Yaratıcılar](#yaratıcılar)
- [Teşekkürler](#teşekkürler)
- [Telif hakkı ve lisans](#telif-hakkı-ve-lisans)


## Hızlı başlangıç

Birçok hızlı başlangıç seçeneği mevcuttur:

- [En son sürümü indirin](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- Repoyu klonlayın: `git clone https://github.com/twbs/bootstrap.git`
- [npm](https://www.npmjs.com/) ile kurun: `npm install bootstrap@v5.3.6`
- [yarn](https://yarnpkg.com/) ile kurun: `yarn add bootstrap@v5.3.6`
- [Bun](https://bun.sh/) ile kurun: `bun add bootstrap@v5.3.6`
- [Composer](https://getcomposer.org/) ile kurun: `composer require twbs/bootstrap:5.3.6`
- [NuGet](https://www.nuget.org/) ile kurun: CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

Çerçevenin içeriği, şablonlar, örnekler ve daha fazlası için [Başlarken sayfasını](https://getbootstrap.com/docs/5.3/getting-started/introduction/) okuyun.


## Durum

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## Neler dahil

İndirme içerisinde aşağıdaki dizin ve dosyaları bulacaksınız; ortak varlıklar mantıksal olarak gruplandırılmış ve hem derlenmiş hem de küçültülmüş varyasyonlar sunulmuştur.

<details>
  <summary>İndirme içeriği</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

Derlenmiş CSS ve JS (`bootstrap.*`) yanında, derlenmiş ve küçültülmüş CSS ve JS (`bootstrap.min.*`) dosyaları sunuyoruz. [Kaynak haritaları](https://web.dev/articles/source-maps) (`bootstrap.*.map`), belirli tarayıcıların geliştirici araçlarıyla kullanılabilir. Paketlenmiş JS dosyaları (`bootstrap.bundle.js` ve küçültülmüş `bootstrap.bundle.min.js`), [Popper](https://popper.js.org/docs/v2/) içerir.


## Hatalar ve özellik istekleri

Bir hata mı buldunuz ya da bir özellik mi istiyorsunuz? Lütfen önce [sorun yönergelerini](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) okuyun ve mevcut veya kapatılmış sorunları arayın. Sorununuz veya fikriniz henüz ele alınmadıysa, [lütfen yeni bir sorun açın](https://github.com/twbs/bootstrap/issues/new/choose).


## Dokümantasyon

Bu repoda kök dizinde yer alan Bootstrap dokümantasyonu, [Astro](https://astro.build/) ile oluşturulmuştur ve GitHub Pages'te <https://getbootstrap.com/> adresinde herkese açıktır. Belgeler ayrıca yerel olarak da çalıştırılabilir.

Dokümantasyon araması, [Algolia'nın DocSearch](https://docsearch.algolia.com/) hizmetiyle çalışmaktadır.

### Dokümantasyonu yerelde çalıştırma

1. Node.js bağımlılıklarını, Astro (site oluşturucu) dahil, yüklemek için `npm install` komutunu çalıştırın.
2. Dağıtılan CSS ve JavaScript dosyalarını ve doküman varlıklarımızı yeniden oluşturmak için `npm run test` (veya belirli bir npm komutu) çalıştırın.
3. Kök `/bootstrap` dizininden, komut satırında `npm run docs-serve` çalıştırın.
4. Tarayıcınızda `http://localhost:9001/` adresini açın, işte bu kadar.

Astro kullanımı hakkında daha fazla bilgi almak için [dokümantasyonunu](https://docs.astro.build/en/getting-started/) okuyun.

### Önceki sürümler için dokümantasyon

Tüm eski sürümlerin belgelerini <https://getbootstrap.com/docs/versions/> adresinde bulabilirsiniz.

[Önceki sürümler](https://github.com/twbs/bootstrap/releases) ve onların dokümantasyonları ayrıca indirilebilir.


## Katkıda Bulunma

Lütfen [katkı yönergelerimizi](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md) okuyun. İçerisinde sorun açma, kod standartları ve geliştirme notları ile ilgili bilgiler bulunmaktadır.

Ayrıca, pull request'iniz JavaScript yamaları veya özellikleri içeriyorsa, [ilgili birim testlerini](https://github.com/twbs/bootstrap/tree/main/js/tests) dahil etmelisiniz. Tüm HTML ve CSS, [Mark Otto](https://github.com/mdo) tarafından sürdürülen [Kod Kılavuzu](https://github.com/mdo/code-guide) ile uyumlu olmalıdır.

Editör tercihleri, yaygın metin editörlerinde kolay kullanım için [editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig) dosyasında mevcuttur. Daha fazla bilgi ve eklenti indirmek için <https://editorconfig.org/> adresini ziyaret edin.


## Topluluk

Bootstrap'ın gelişimi hakkında güncellemeler alın ve proje sorumluları ile topluluk üyeleriyle sohbet edin.

- [@getbootstrap X hesabını](https://x.com/getbootstrap) takip edin.
- [Resmi Bootstrap Blogunu](https://blog.getbootstrap.com/) okuyun ve abone olun.
- [GitHub Discussions](https://github.com/twbs/bootstrap/discussions) üzerinden sorular sorun ve keşfedin.
- [Topluluk Discord'u](https://discord.gg/bZUvakRU3M) veya [Bootstrap subreddit'i](https://www.reddit.com/r/bootstrap/) üzerinden tartışın, soru sorun ve daha fazlasını yapın.
- IRC'de diğer Bootstrap kullanıcıları ile sohbet edin. `irc.libera.chat` sunucusunda, `#bootstrap` kanalında.
- Uygulama yardımı için Stack Overflow’da ([`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5) etiketiyle) yardım bulabilirsiniz.
- Geliştiriciler, Bootstrap'ın işlevselliğini değiştiren veya ekleyen paketler dağıtırken [npm](https://www.npmjs.com/browse/keyword/bootstrap) veya benzeri dağıtım mekanizmalarında maksimum bulunabilirlik için `bootstrap` anahtar kelimesini kullanmalıdır.


## Sürümleme

Sürüm döngümüzün şeffaflığı ve geriye dönük uyumluluğu koruma amacıyla, Bootstrap [Anlamsal Sürümleme yönergelerine](https://semver.org/) göre sürdürülmektedir. Bazen hata yapsak da, mümkün olduğunca bu kurallara uymaya çalışıyoruz.

Her Bootstrap sürümünün değişiklik günlükleri için [GitHub projemizin Sürümler bölümüne](https://github.com/twbs/bootstrap/releases) bakın. [Resmi Bootstrap blogunda](https://blog.getbootstrap.com/) yayınlanan sürüm duyuru yazılarında, her sürümde yapılan en önemli değişikliklerin özetleri yer almaktadır.


## Yaratıcılar

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## Teşekkürler

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

Gerçek tarayıcılarda test yapmamıza olanak sağlayan altyapı için [BrowserStack](https://www.browserstack.com/)'e teşekkürler!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

Bize Deploy Preview hizmeti sunduğu için [Netlify](https://www.netlify.com/)'ye teşekkürler!


## Sponsorlar

Bu projeyi sponsor olarak destekleyin. Logonuz burada web sitenize bağlantı ile birlikte gösterilecektir. [[Sponsor olun](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## Destekçiler

Tüm destekçilerimize teşekkürler! 🙏 [[Destekçi olun](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## Telif hakkı ve lisans

Kod ve dokümantasyon telif hakkı 2011-2025 [Bootstrap Yazarları](https://github.com/twbs/bootstrap/graphs/contributors)'na aittir. Kod [MIT Lisansı](https://github.com/twbs/bootstrap/blob/main/LICENSE) ile, dokümantasyon ise [Creative Commons](https://creativecommons.org/licenses/by/3.0/) ile yayınlanmıştır.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---