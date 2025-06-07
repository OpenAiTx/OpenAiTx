<p align="center">
  <img width="320" src="https://wpimg.wallstcn.com/ecc53a42-d79b-42e2-8852-5126b810a4c8.svg">
</p>

<p align="center">
  <a href="https://github.com/vuejs/vue">
    <img src="https://img.shields.io/badge/vue-2.6.10-brightgreen.svg" alt="vue">
  </a>
  <a href="https://github.com/ElemeFE/element">
    <img src="https://img.shields.io/badge/element--ui-2.7.0-brightgreen.svg" alt="element-ui">
  </a>
  <a href="https://travis-ci.org/PanJiaChen/vue-element-admin" rel="nofollow">
    <img src="https://travis-ci.org/PanJiaChen/vue-element-admin.svg?branch=master" alt="Build Status">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/mashape/apistatus.svg" alt="license">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/releases">
    <img src="https://img.shields.io/github/release/PanJiaChen/vue-element-admin.svg" alt="GitHub release">
  </a>
  <a href="https://gitter.im/vue-element-admin/discuss">
    <img src="https://badges.gitter.im/Join%20Chat.svg" alt="gitter">
  </a>
  <a href="https://panjiachen.github.io/vue-element-admin-site/donate">
    <img src="https://img.shields.io/badge/%24-donate-ff69b4.svg" alt="donate">
  </a>
</p>

English | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Spanish](./README.es.md)

<!-- <p align="center">
  <b>SPONSORED BY</b>
</p>
<table align="center" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td align="center" valign="middle">
       <a href="" title="" target="_blank" style="padding-right: 20px;">
        <img height="200px" style="padding-right: 20px;" src="" title="variantForm">
        </a>
      </td>
    </tr>
  </tbody> 
</table>-->

## Giriş

[vue-element-admin](https://panjiachen.github.io/vue-element-admin), yönetim arayüzleri için üretime hazır bir ön yüz çözümüdür. [vue](https://github.com/vuejs/vue) tabanlıdır ve [element-ui](https://github.com/ElemeFE/element) UI kütüphanesini kullanır.

[vue-element-admin](https://panjiachen.github.io/vue-element-admin), vue'nin en yeni geliştirme yığını üzerine inşa edilmiştir, dahili i18n çözümü, kurumsal uygulamalar için tipik şablonlar ve birçok harika özelliğe sahiptir. Büyük ve karmaşık Tek Sayfa Uygulamaları (SPA) oluşturmanıza yardımcı olur. İhtiyacınız ne olursa olsun, bu projenin size yardımcı olacağına inanıyorum.

- [Önizleme](https://panjiachen.github.io/vue-element-admin)

- [Dokümantasyon](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter](https://gitter.im/vue-element-admin/discuss)

- [Bağış Yap](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [Wiki](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/) Çin'deki kullanıcılar bu adresten çevrimiçi önizleme yapabilir

- Temel şablon için önerilen: [vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- Masaüstü: [electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- Typescript: [vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (Teşekkürler: [@Armour](https://github.com/Armour))
- [awesome-project](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**`v4.1.0+` sürümünden sonra, varsayılan master dalı i18n desteği sağlamayacaktır. Lütfen [i18n Dalı](https://github.com/PanJiaChen/vue-element-admin/tree/i18n)'nı kullanın, master ile güncel tutulacaktır**

**Mevcut sürüm `v4.0+` olup `vue-cli` ile inşa edilmiştir. Bir sorun bulursanız, lütfen [issue](https://github.com/PanJiaChen/vue-element-admin/issues/new) açın. Eski sürümü kullanmak isterseniz, [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0) dalına geçebilirsiniz, bu sürüm `vue-cli`'ye bağlı değildir**

**Bu proje, düşük sürüm tarayıcıları (ör. IE) desteklemez. Lütfen gerekli polyfill'leri kendiniz ekleyin.**

## Hazırlık

Bilgisayarınızda yerel olarak [node](https://nodejs.org/) ve [git](https://git-scm.com/) kurulu olmalıdır. Proje, [ES2015+](https://es6.ruanyifeng.com/), [vue](https://cn.vuejs.org/index.html), [vuex](https://vuex.vuejs.org/zh-cn/), [vue-router](https://router.vuejs.org/zh-cn/), [vue-cli](https://github.com/vuejs/vue-cli), [axios](https://github.com/axios/axios) ve [element-ui](https://github.com/ElemeFE/element) üzerine kuruludur; tüm istek verileri [Mock.js](https://github.com/nuysoft/Mock) ile simüle edilmektedir.
Bu konularda önceden bilgi sahibi olmak, projeyi kullanmanızda size büyük kolaylık sağlayacaktır.

[![Edit on CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## Sponsorlar

Sponsor olarak logonuzu GitHub'daki README dosyamızda sitenize bağlantı ile birlikte gösterebilirsiniz. [[Sponsor Olun]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>Vue admin için Java backend'i %20 indirimle 39$'a edinin. SWB0RAZPZR1M kupon kodunu kullanın
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>Vue, React ve Angular ile hazırlanmış Yönetim Paneli Şablonları.</p>

## Özellikler

```
- Giriş / Çıkış

- Yetki Doğrulama
  - Sayfa yetkisi
  - Direktif yetkisi
  - Yetki yapılandırma sayfası
  - İki adımlı giriş

- Çoklu ortam derleme
  - Geliştirme (dev)
  - sit
  - Aşama Testi (stage)
  - Üretim (prod)

- Küresel Özellikler
  - I18n
  - Çoklu dinamik temalar
  - Dinamik yan menü (çok seviyeli yönlendirme desteği)
  - Dinamik ekmek kırıntısı (breadcrumb)
  - Etiket görünümü (Sekme sayfası Sağ tık desteği)
  - Svg Sprite
  - Mock veri
  - Tam ekran (Screenfull)
  - Duyarlı yan menü

- Editör
  - Zengin Metin Editörü
  - Markdown Editörü
  - JSON Editörü

- Excel
  - Excel Dışa Aktar
  - Excel Yükle
  - Görselleştirme Excel
  - Zip olarak dışa aktar

- Tablo
  - Dinamik Tablo
  - Sürükle Bırak Tablo
  - Satır içi Tablo Düzenleme

- Hata Sayfası
  - 401
  - 404

- Bileşenler
  - Avatar Yükleme
  - Yukarı Dön
  - Sürükle Diyalog
  - Sürükle Seç
  - Sürükle Kanban
  - Sürükle Liste
  - SplitPane
  - Dropzone
  - Sticky
  - CountTo

- Gelişmiş Örnek
- Hata Kaydı
- Gösterge Paneli (Dashboard)
- Kılavuz Sayfası
- ECharts
- Panoya kopyala
- Markdown'dan html'e
```

## Başlarken

```bash
# projeyi klonla
git clone https://github.com/PanJiaChen/vue-element-admin.git

# proje dizinine gir
cd vue-element-admin

# bağımlılıkları yükle
npm install

# geliştirme
npm run dev
```

Bu işlem otomatik olarak http://localhost:9527 adresini açacaktır

## Derleme

```bash
# test ortamı için derle
npm run build:stage

# üretim ortamı için derle
npm run build:prod
```

## Gelişmiş

```bash
# yayındaki ortamı önizle
npm run preview

# yayındaki ortamı önizle + statik kaynak analizi
npm run preview -- --report

# kod formatı kontrolü
npm run lint

# kod formatı kontrolü ve otomatik düzeltme
npm run lint -- --fix
```

Daha fazla bilgi için [Dokümantasyon](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html) adresine bakınız

## Değişiklik Günlüğü

Her sürüm için detaylı değişiklikler [sürüm notlarında](https://github.com/PanJiaChen/vue-element-admin/releases) dokümante edilmiştir.

## Çevrimiçi Demo

[Önizleme](https://panjiachen.github.io/vue-element-admin)

## Bağış Yap

Bu projeyi faydalı buluyorsanız, yazara bir bardak meyve suyu ısmarlayabilirsiniz :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal ile](https://www.paypal.me/panfree23)

[Bana kahve ısmarla](https://www.buymeacoffee.com/Pan)

## Tarayıcı Desteği

Modern tarayıcılar ve Internet Explorer 10+.

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | son 2 sürüm | son 2 sürüm | son 2 sürüm |

## Lisans

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

Telif Hakkı (c) 2017-günümüz PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---