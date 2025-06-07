<a href="https://excalidraw.com/" target="_blank" rel="noopener">
  <picture>
    <source media="(prefers-color-scheme: dark)" alt="Excalidraw" srcset="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github/excalidraw_github_cover_2_dark.png" />
    <img alt="Excalidraw" src="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github/excalidraw_github_cover_2.png" />
  </picture>
</a>

<h4 align="center">
  <a href="https://excalidraw.com">Excalidraw Editörü</a> |
  <a href="https://plus.excalidraw.com/blog">Blog</a> |
  <a href="https://docs.excalidraw.com">Dokümantasyon</a> |
  <a href="https://plus.excalidraw.com">Excalidraw+</a>
</h4>

<div align="center">
  <h2>
    Açık kaynak kodlu, sanal el çizimi tarzında beyaz tahta. </br>
    İşbirlikçi ve uçtan uca şifreli. </br>
  <br />
  </h2>
</div>

<br />
<p align="center">
  <a href="https://github.com/excalidraw/excalidraw/blob/master/LICENSE">
    <img alt="Excalidraw MIT lisansı ile yayımlanmıştır." src="https://img.shields.io/badge/license-MIT-blue.svg"  />
  </a>
  <a href="https://www.npmjs.com/package/@excalidraw/excalidraw">
    <img alt="npm indirme/ay" src="https://img.shields.io/npm/dm/@excalidraw/excalidraw"  />
  </a>
  <a href="https://docs.excalidraw.com/docs/introduction/contributing">
    <img alt="PR'lar hoş geldiniz!" src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat"  />
  </a>
  <a href="https://discord.gg/UexuTaE">
    <img alt="Discord'da sohbet edin" src="https://img.shields.io/discord/723672430744174682?color=738ad6&label=Chat%20on%20Discord&logo=discord&logoColor=ffffff&widge=false"/>
  </a>
  <a href="https://deepwiki.com/excalidraw/excalidraw">
    <img alt="DeepWiki'ye Sor" src="https://deepwiki.com/badge.svg" />
  </a>
  <a href="https://twitter.com/excalidraw">
    <img alt="Excalidraw'ı Twitter'da takip edin" src="https://img.shields.io/twitter/follow/excalidraw.svg?label=follow+@excalidraw&style=social&logo=twitter"/>
  </a>
</p>

<div align="center">
  <figure>
    <a href="https://excalidraw.com" target="_blank" rel="noopener">
      <img src="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github%2Fproduct_showcase.png" alt="Ürün tanıtımı" />
    </a>
    <figcaption>
      <p align="center">
        Güzel el çizimi benzeri diyagramlar, wireframe'ler veya istediğiniz her şeyi oluşturun.
      </p>
    </figcaption>
  </figure>
</div>

## Özellikler

Excalidraw editörü (npm paketi) şunları destekler:

- 💯&nbsp;Ücretsiz & açık kaynak kodlu.
- 🎨&nbsp;Sonsuz, tuval tabanlı beyaz tahta.
- ✍️&nbsp;El çizimi benzeri stil.
- 🌓&nbsp;Karanlık mod.
- 🏗️&nbsp;Özelleştirilebilir.
- 📷&nbsp;Resim desteği.
- 😀&nbsp;Şekil kütüphaneleri desteği.
- 🌐&nbsp;Yerelleştirme (i18n) desteği.
- 🖼️&nbsp;PNG, SVG ve panoya dışa aktarma.
- 💾&nbsp;Açık format - çizimleri `.excalidraw` json dosyası olarak dışa aktarın.
- ⚒️&nbsp;Geniş araç yelpazesi - dikdörtgen, daire, elmas, ok, çizgi, serbest çizim, silgi...
- ➡️&nbsp;Ok bağlama & etiketli oklar.
- 🔙&nbsp;Geri al / Yinele.
- 🔍&nbsp;Yakınlaştırma ve kaydırma desteği.

## Excalidraw.com

[excalidraw.com](https://excalidraw.com)'da barındırılan uygulama, Excalidraw ile neler oluşturabileceğinizi gösteren minimal bir vitrindir. [Kaynak kodu](https://github.com/excalidraw/excalidraw/tree/master/excalidraw-app) da bu depoya dahildir ve uygulamanın özellikleri şunlardır:

- 📡&nbsp;PWA desteği (çevrimdışı çalışır).
- 🤼&nbsp;Gerçek zamanlı işbirliği.
- 🔒&nbsp;Uçtan uca şifreleme.
- 💾&nbsp;Öncelikli olarak yerelde çalışma desteği (tarayıcıya otomatik kaydetme).
- 🔗&nbsp;Paylaşılabilir bağlantılar (başkalarıyla paylaşabileceğiniz salt okunur bağlantı olarak dışa aktarım).

Bu özellikleri ileride npm paketi için eklenti olarak sunacağız.

## Hızlı Başlangıç

**Not:** Aşağıdaki talimatlar, Excalidraw'ı kendi uygulamanıza entegre ederken Excalidraw [npm paketini](https://www.npmjs.com/package/@excalidraw/excalidraw) yüklemek içindir. Depoyu yerel olarak geliştirme amaçlı çalıştırmak için [Geliştirme Rehberimize](https://docs.excalidraw.com/docs/introduction/development) bakınız.

Paketi yüklemek için `npm` veya `yarn` kullanın.

```bash
npm install react react-dom @excalidraw/excalidraw
# veya
yarn add react react-dom @excalidraw/excalidraw
```

Daha fazla detay için [dokümantasyonumuza](https://docs.excalidraw.com/docs/@excalidraw/excalidraw/installation) göz atın!

## Katkıda Bulunmak

- Bir şey mi eksik, hata mı buldunuz? [Buradan bildirin](https://github.com/excalidraw/excalidraw/issues).
- Katkıda bulunmak ister misiniz? [Katkı rehberimize](https://docs.excalidraw.com/docs/introduction/contributing) bakın veya [Discord](https://discord.gg/UexuTaE) üzerinden bize ulaşın.
- Çevirilere yardımcı olmak ister misiniz? [Çeviri rehberine](https://docs.excalidraw.com/docs/introduction/contributing#translating) bakın.

## Entegrasyonlar

- [VScode eklentisi](https://marketplace.visualstudio.com/items?itemName=pomdtr.excalidraw-editor)
- [npm paketi](https://www.npmjs.com/package/@excalidraw/excalidraw)

## Excalidraw'ı Entegre Edenler

[Google Cloud](https://googlecloudcheatsheet.withgoogle.com/architecture) • [Meta](https://meta.com/) • [CodeSandbox](https://codesandbox.io/) • [Obsidian Excalidraw](https://github.com/zsviczian/obsidian-excalidraw-plugin) • [Replit](https://replit.com/) • [Slite](https://slite.com/) • [Notion](https://notion.so/) • [HackerRank](https://www.hackerrank.com/) • ve daha birçokları

## Sponsorlar & Destek

Projeyi beğendiyseniz, [Open Collective](https://opencollective.com/excalidraw) üzerinden sponsor olabilir veya [Excalidraw+](https://plus.excalidraw.com/) kullanabilirsiniz.

## Excalidraw'ı Desteklediğiniz İçin Teşekkürler

[<img src="https://opencollective.com/excalidraw/tiers/sponsors/0/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/0/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/1/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/1/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/2/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/2/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/3/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/3/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/4/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/4/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/5/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/5/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/6/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/6/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/7/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/7/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/8/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/8/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/9/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/9/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/10/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/10/website)

<a href="https://opencollective.com/excalidraw#category-CONTRIBUTE" target="_blank"><img src="https://opencollective.com/excalidraw/tiers/backers.svg?avatarHeight=32"/></a>

Son olarak, bu hizmetleri ücretsiz sundukları için bu şirketlere teşekkür ederiz:

[![Vercel](./.github/assets/vercel.svg)](https://vercel.com) [![Sentry](./.github/assets/sentry.svg)](https://sentry.io) [![Crowdin](./.github/assets/crowdin.svg)](https://crowdin.com)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---