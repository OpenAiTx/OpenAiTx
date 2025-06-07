## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!DİKKAT]
>
> ## Kullanımdan Kaldırıldı
>
> Create React App, 2017-2021 yılları arasında bir React projesini hızlıca başlatmak için en önemli araçlardan biriydi, ancak artık uzun vadeli bekleme sürecindedir ve [Yeni Bir React Projesi Başlat](https://react.dev/learn/start-a-new-react-project) sayfasında belgelenen React çerçevelerinden birine geçmenizi öneririz.
>
> React öğrenmek için bir eğitim takip ediyorsanız, eğitiminize devam etmenin hâlâ değeri vardır; ancak Create React App tabanlı üretim uygulamaları başlatmanızı önermiyoruz.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

Hiçbir yapılandırmaya gerek kalmadan React uygulamaları oluşturun.

- [Uygulama Oluşturma](#creating-an-app) – Yeni bir uygulama nasıl oluşturulur.
- [Kullanıcı Kılavuzu](https://facebook.github.io/create-react-app/) – Create React App ile başlatılan uygulamalar nasıl geliştirilir.

Create React App, macOS, Windows ve Linux'ta çalışır.<br>
Bir şey çalışmazsa, lütfen [sorun bildirin](https://github.com/facebook/create-react-app/issues/new).<br>
Sorularınız veya yardıma ihtiyacınız varsa, lütfen [GitHub Discussions](https://github.com/facebook/create-react-app/discussions) bölümünde sorun.

## Hızlı Bakış

```sh
npx create-react-app my-app
cd my-app
npm start
```

Daha önce `npm install -g create-react-app` ile `create-react-app`'i global olarak yüklediyseniz, en güncel sürümün her zaman kullanılmasını sağlamak için `npm uninstall -g create-react-app` veya `yarn global remove create-react-app` komutlarıyla paketi kaldırmanızı öneririz.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b), npm 5.2+ ve üstüyle birlikte gelir, [eski npm sürümleri için talimatlara bakın](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

Daha sonra [http://localhost:3000/](http://localhost:3000/) adresini açarak uygulamanızı görebilirsiniz.<br>
Üretime dağıtmaya hazır olduğunuzda, `npm run build` ile minify edilmiş bir paket oluşturun.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### Hemen Başlayın

Webpack veya Babel gibi araçları **yüklemeniz veya yapılandırmanız gerekmez**.<br>
Bunlar önceden yapılandırılmış ve gizlenmiştir, böylece sadece kodunuza odaklanabilirsiniz.

Bir proje oluşturun ve hemen başlayın.

## Uygulama Oluşturma

**Yerel geliştirme makinenizde Node 14.0.0 veya daha yeni bir sürümünün yüklü olması gerekir** (sunucuda zorunlu değildir). En son LTS sürümünü kullanmanızı öneririz. Farklı projeler arasında Node sürümlerini değiştirmek için [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) veya [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) kullanabilirsiniz.

Yeni bir uygulama oluşturmak için aşağıdaki yöntemlerden birini seçebilirsiniz:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b), npm 5.2+ ve üstüyle birlikte gelen bir paket çalıştırma aracıdır, [eski npm sürümleri için talimatlara bakın](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>`, npm 6+ ile kullanılabilir_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/), Yarn 0.25+ ile kullanılabilir_

Bu işlem, mevcut klasörün içinde `my-app` adında bir dizin oluşturacaktır.<br>
Bu dizin içinde, ilk proje yapısını oluşturacak ve tüm bağımlılıkları yükleyecektir:

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

Hiçbir yapılandırma veya karmaşık klasör yapısı yok, sadece uygulamanızı oluşturmak için gereken dosyalar.<br>
Kurulum tamamlandığında, proje klasörünüzü açabilirsiniz:

```sh
cd my-app
```

Yeni oluşturulan projede, bazı yerleşik komutları çalıştırabilirsiniz:

### `npm start` veya `yarn start`

Uygulamayı geliştirme modunda çalıştırır.<br>
[http://localhost:3000](http://localhost:3000) adresini tarayıcıda açarak görüntüleyebilirsiniz.

Koda değişiklik yaptığınızda sayfa otomatik olarak yeniden yüklenecektir.<br>
Yapı hatalarını ve lint uyarılarını konsolda göreceksiniz.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` veya `yarn test`

Test izleyicisini etkileşimli modda çalıştırır.<br>
Varsayılan olarak, son committan beri değişen dosyalarla ilgili testleri çalıştırır.

[Test hakkında daha fazla bilgi edinin.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` veya `yarn build`

Uygulamayı üretim için `build` klasörüne derler.<br>
React’i üretim modunda doğru şekilde paketler ve en iyi performans için yapıyı optimize eder.

Yapı küçültülür ve dosya adları hash içerir.<br>

Uygulamanız dağıtıma hazırdır.

## Kullanıcı Kılavuzu

Create React App’in kullanımıyla ilgili ayrıntılı talimatları ve birçok ipucunu [belgelerinde](https://facebook.github.io/create-react-app/) bulabilirsiniz.

## Yeni Sürümlere Nasıl Güncellenir?

Bunun ve diğer bilgiler için lütfen [Kullanıcı Kılavuzu](https://facebook.github.io/create-react-app/docs/updating-to-new-releases)'na bakın.

## Felsefe

- **Tek Bağımlılık:** Sadece bir yapı bağımlılığı vardır. Webpack, Babel, ESLint ve diğer harika projeleri kullanır, ancak bunların üzerinde bütünleşik bir deneyim sunar.

- **Yapılandırma Gerekmez:** Hiçbir şeyi yapılandırmanıza gerek yoktur. Hem geliştirme hem de üretim yapıları için makul derecede iyi bir yapılandırma sizin yerinize yapılır, böylece kod yazmaya odaklanabilirsiniz.

- **Bağımlılık Yok:** İstediğiniz zaman özel bir kuruluma “eject” edebilirsiniz. Tek bir komut çalıştırın, tüm yapılandırma ve bağımlılıklar doğrudan projenize taşınır ve kaldığınız yerden devam edebilirsiniz.

## Neler Dahil?

Ortamınızda modern tek sayfa React uygulaması oluşturmak için ihtiyacınız olan her şey bulunur:

- React, JSX, ES6, TypeScript ve Flow sözdizimi desteği.
- ES6'nın ötesinde nesne yayma operatörü gibi dil eklentileri.
- Otomatik ön ekli CSS, böylece `-webkit-` veya diğer öneklere ihtiyacınız olmaz.
- Kapsam raporlaması desteğiyle birlikte hızlı, etkileşimli bir birim test çalıştırıcısı.
- Yaygın hatalar konusunda uyarı veren canlı geliştirme sunucusu.
- Üretim için JS, CSS ve görselleri hash ve sourcemap’lerle paketleyen bir yapı betiği.
- Tüm [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app) kriterlerini karşılayan, çevrimdışı öncelikli [servis çalışanı](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) ve [web uygulama manifesti](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/). (_Not: Servis çalışanı kullanımı `react-scripts@2.0.0` ve üzeri için isteğe bağlıdır_)
- Yukarıdaki araçlar için tek bir bağımlılıkla sorunsuz güncellemeler.

Bu araçların nasıl bir araya geldiğine dair genel bir bakış için [bu rehbere](https://github.com/nitishdayal/cra_closer_look) göz atın.

Bunun karşılığında, **bu araçlar belirli bir şekilde çalışacak şekilde önceden yapılandırılmıştır**. Projeniz daha fazla özelleştirme gerektiriyorsa, ["eject"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) edebilir ve özelleştirebilirsiniz, ancak bu durumda yapılandırmayı sizin yönetmeniz gerekir.

## Popüler Alternatifler

Create React App şu alanlarda harika bir tercihtir:

- **React öğrenmek** için konforlu ve zengin özellikli bir geliştirme ortamında.
- **Yeni tek sayfa React uygulamaları başlatmak** için.
- Kütüphane ve bileşenleriniz için **React ile örnekler oluşturmak** için.

Aşağıda, başka bir şey denemek isteyebileceğiniz bazı yaygın durumlar yer almaktadır:

- **React'ı denemek** istiyorsanız ve yüzlerce bağımlılığa gerek duymuyorsanız, [tek bir HTML dosyası veya çevrimiçi bir sandbox kullanmayı](https://reactjs.org/docs/getting-started.html#try-react) düşünebilirsiniz.

- React kodunu **sunucu tarafı şablon çerçevesiyle** (Rails, Django veya Symfony gibi) entegre etmeniz gerekiyorsa veya **tek sayfa bir uygulama oluşturmuyorsanız**, [nwb](https://github.com/insin/nwb) veya [Neutrino](https://neutrino.js.org/) gibi daha esnek çözümleri tercih edebilirsiniz. Rails için özel olarak [Rails Webpacker](https://github.com/rails/webpacker), Symfony için [Symfony'nun webpack Encore](https://symfony.com/doc/current/frontend/encore/reactjs.html) kullanılabilir.

- Bir **React bileşeni yayımlamanız** gerekiyorsa, [nwb](https://github.com/insin/nwb) [bunu da yapabilir](https://github.com/insin/nwb#react-components-and-libraries) veya [Neutrino'nun react-components ayarı](https://neutrino.js.org/packages/react-components/) kullanılabilir.

- React ve Node.js ile **sunucu tarafı render** yapmak istiyorsanız, [Next.js](https://nextjs.org/) veya [Razzle](https://github.com/jaredpalmer/razzle) inceleyin. Create React App arka uca bağımsızdır ve yalnızca statik HTML/JS/CSS paketleri üretir.

- Web siteniz **çoğunlukla statikse** (örneğin bir portföy veya blog), [Gatsby](https://www.gatsbyjs.org/) veya [Next.js](https://nextjs.org/) kullanmayı düşünün. Create React App’in aksine, Gatsby siteyi derleme zamanında HTML’e önceden render eder. Next.js hem sunucu tarafı render hem de önceden render desteği sunar.

- Son olarak, **daha fazla özelleştirmeye** ihtiyacınız varsa, [Neutrino](https://neutrino.js.org/) ve [React ayarına](https://neutrino.js.org/packages/react/) göz atın.

Yukarıdaki tüm araçlar az veya hiç yapılandırma gerektirmeden çalışabilir.

Yapıyı kendiniz yapılandırmayı tercih ediyorsanız, [bu rehberi takip edin](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

Bunun gibi bir şey mi arıyorsunuz, ama React Native için?<br>
[Expo CLI](https://github.com/expo/expo-cli)'ye göz atın.

## Katkıda Bulunma

`create-react-app`’e katkılarınızı memnuniyetle karşılarız! Ne aradığımız ve nasıl başlayacağınız hakkında daha fazla bilgi için [CONTRIBUTING.md](CONTRIBUTING.md) dosyasına bakın.

## Create React App’i Desteklemek

Create React App, topluluk tarafından sürdürülen bir projedir ve tüm katkıcılar gönüllüdür. Create React App’in gelecekteki gelişimini desteklemek isterseniz, [Open Collective](https://opencollective.com/create-react-app)’imize bağış yapmayı düşünebilirsiniz.

## Katkıda Bulunanlar

Bu proje, [katkıda bulunanlar](CONTRIBUTING.md) sayesinde varlığını sürdürmektedir.<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

Belgelerimizi barındırdığı için [Netlify](https://www.netlify.com/)'a teşekkürler.

## Teşekkürler

Var olan ilgili projelerin yazarlarına fikirleri ve işbirlikleri için minnettarız:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## Lisans

Create React App açık kaynaklı bir yazılımdır ve [MIT lisansı ile lisanslanmıştır](https://github.com/facebook/create-react-app/blob/main/LICENSE). Create React App logosu [Creative Commons Atıf 4.0 Uluslararası lisansı](https://creativecommons.org/licenses/by/4.0/) ile lisanslanmıştır.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---