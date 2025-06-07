<h1 align="center">
  <a href="https://reactnative.dev/">
    React Native
  </a>
</h1>

<p align="center">
  <strong>Bir kez öğren, her yerde yaz:</strong><br>
  React ile mobil uygulamalar geliştirin.
</p>

<p align="center">
  <a href="https://github.com/facebook/react-native/blob/HEAD/LICENSE">
    <img src="https://img.shields.io/badge/license-MIT-blue.svg" alt="React Native MIT lisansı ile yayımlanmıştır." />
  </a>
  <a href="https://www.npmjs.org/package/react-native">
    <img src="https://img.shields.io/npm/v/react-native?color=brightgreen&label=npm%20package" alt="Güncel npm paket sürümü." />
  </a>
  <a href="https://reactnative.dev/docs/contributing">
    <img src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg" alt="PR'lere açığız!" />
  </a>
  <a href="https://twitter.com/intent/follow?screen_name=reactnative">
    <img src="https://img.shields.io/twitter/follow/reactnative.svg?label=Follow%20@reactnative" alt="@reactnative hesabını takip edin" />
  </a>
</p>

<h3 align="center">
  <a href="https://reactnative.dev/docs/getting-started">Başlarken</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/tutorial">Temel Bilgileri Öğrenin</a>
  <span> · </span>
  <a href="https://reactnative.dev/showcase">Vitrin</a>
  <span> · </span>
  <a href="https://reactnative.dev/docs/contributing">Katkıda Bulunun</a>
  <span> · </span>
  <a href="https://reactnative.dev/help">Topluluk</a>
  <span> · </span>
  <a href="https://github.com/facebook/react-native/blob/HEAD/.github/SUPPORT.md">Destek</a>
</h3>

React Native, [**React**'in][r] deklaratif UI framework'ünü iOS ve Android'e getirir. React Native ile, yerel UI kontrollerini kullanır ve yerel platforma tam erişim sahibi olursunuz.

- **Deklaratif.** React, etkileşimli kullanıcı arayüzleri oluşturmayı zahmetsiz hale getirir. Deklaratif görünümler kodunuzu daha öngörülebilir ve hata ayıklaması daha kolay kılar.
- **Bileşen Tabanlı.** Durumunu yöneten kapsüllü bileşenler oluşturun, sonra bunları karmaşık kullanıcı arayüzleri yapmak için birleştirin.
- **Geliştirici Hızı.** Yerel değişiklikleri saniyeler içinde görün. JavaScript kodundaki değişiklikler, yerel uygulamayı yeniden derlemeden canlı olarak yüklenebilir.
- **Taşınabilirlik.** Kodu iOS, Android ve [diğer platformlar][p] arasında yeniden kullanın.

React Native, birçok şirket ve bireysel çekirdek katkıcı tarafından geliştirilmekte ve desteklenmektedir. Daha fazla bilgi için [ekosistem genel bakışımıza][e] göz atın.

[r]: https://react.dev/
[p]: https://reactnative.dev/docs/out-of-tree-platforms
[e]: https://github.com/facebook/react-native/blob/HEAD/ECOSYSTEM.md

## İçindekiler

- [Gereksinimler](#-gereksinimler)
- [İlk React Native uygulamanızı oluşturma](#-ilk-react-native-uygulamanızı-oluşturma)
- [Dokümantasyon](#-dokümantasyon)
- [Güncelleme](#-güncelleme)
- [Katkıda Bulunma](#-katkıda-bulunma)
- [Davranış Kuralları](#davranış-kuralları)
- [Lisans](#-lisans)


## 📋 Gereksinimler

React Native uygulamaları iOS 15.1 ve Android 7.0 (API 24) veya daha yenisini hedefleyebilir. Geliştirme işletim sistemi olarak Windows, macOS veya Linux kullanabilirsiniz, ancak iOS uygulamaları derlemek ve çalıştırmak yalnızca macOS ile sınırlıdır. [Expo](https://expo.dev) gibi araçlar bu kısıtlamayı aşmak için kullanılabilir.

## 🎉 İlk React Native uygulamanızı oluşturma

[Başlangıç rehberini](https://reactnative.dev/docs/getting-started) takip edin. React Native'i kurmanın önerilen yolu projenize bağlıdır. Burada en yaygın senaryolar için kısa kılavuzlar bulabilirsiniz:

- [React Native'i denemek][hello-world]
- [Yeni bir uygulama oluşturmak][new-app]
- [React Native'i mevcut bir uygulamaya eklemek][existing]

[hello-world]: https://snack.expo.dev/@samples/hello-world
[new-app]: https://reactnative.dev/docs/getting-started
[existing]: https://reactnative.dev/docs/integration-with-existing-apps

## 📖 Dokümantasyon

React Native'in tam dokümantasyonu [web sitemizde][docs] bulunabilir.

React Native dokümantasyonunda React Native'e özgü bileşenler, API'ler ve konular ele alınır. React Native ve React DOM arasında paylaşılan React API'si hakkında daha fazla bilgi için [React dokümantasyonuna][r-docs] bakın.

React Native dokümantasyonu ve web sitesi [ayrı bir depo][repo-website]da barındırılmaktadır.

[docs]: https://reactnative.dev/docs/getting-started
[r-docs]: https://react.dev/learn
[repo-website]: https://github.com/facebook/react-native-website

## 🚀 Güncelleme

React Native'in yeni sürümlerine yükseltmek, daha fazla API, görünüm, geliştirici aracı ve diğer avantajlara erişim sağlayabilir. Talimatlar için [Güncelleme Kılavuzuna][u] bakın.

React Native sürümleri [bu tartışma deposunda](https://github.com/reactwg/react-native-releases/discussions) ele alınmaktadır.

[u]: https://reactnative.dev/docs/upgrading
[repo-releases]: https://github.com/react-native-community/react-native-releases

## 👏 Katkıda Bulunma

Bu deponun ana amacı, React Native çekirdeğini geliştirmeye devam etmektir. Bu projeye katkıda bulunmayı olabildiğince kolay ve şeffaf hale getirmek istiyoruz ve hata düzeltmeleri ile iyileştirmelerde bulunan topluluğa minnettarız. React Native'i geliştirmeye nasıl katkı sağlayabileceğinizi öğrenmek için aşağıyı okuyun.

### [Davranış Kuralları][code]

Facebook, proje katılımcılarının uymasını beklediğimiz bir Davranış Kuralları benimsemiştir.
Nelerin tolere edileceğini ve edilmeyeceğini anlamak için lütfen [tam metni][code] okuyun.

[code]: https://code.fb.com/codeofconduct/

### [Katkı Kılavuzu][contribute]

Geliştirme sürecimiz, hata düzeltme ve iyileştirme önerileri, React Native değişikliklerinizi nasıl oluşturup test edeceğiniz hakkında bilgi edinmek için [**Katkı Kılavuzumuzu**][contribute] okuyun.

[contribute]: https://reactnative.dev/docs/contributing

### [Açık Kaynak Yol Haritası][roadmap]

React Native'e dair vizyonumuz hakkında daha fazla bilgiyi [**Yol Haritası**][roadmap] bölümünde bulabilirsiniz.

[roadmap]: https://github.com/facebook/react-native/wiki/Roadmap

### İlk Katkı İçin İyi Sorunlar

Sınırlı kapsama sahip hataları içeren [ilk katkı için iyi sorunlar][gfi] listemiz var. Başlamak, deneyim kazanmak ve katkı sürecimize aşina olmak için harika bir yerdir.

[gfi]: https://github.com/facebook/react-native/labels/good%20first%20issue

### Tartışmalar

Daha geniş tartışmalar ve öneriler [**@react-native-community/discussions-and-proposals**][repo-meta] adresinde görüşülmektedir.

[repo-meta]: https://github.com/react-native-community/discussions-and-proposals

## 📄 Lisans

React Native, [LİSANS][l] dosyasında belirtildiği gibi MIT lisansı ile lisanslanmıştır.

[l]: https://github.com/facebook/react-native/blob/main/LICENSE

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---