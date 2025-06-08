# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React, kullanıcı arayüzleri oluşturmak için kullanılan bir JavaScript kütüphanesidir.

* **Deklaratif:** React, etkileşimli kullanıcı arayüzleri oluşturmayı zahmetsiz hale getirir. Uygulamanızdaki her durum için basit görünümler tasarlayın ve verileriniz değiştiğinde React yalnızca gerekli bileşenleri verimli bir şekilde güncelleyip render eder. Deklaratif görünümler, kodunuzun daha öngörülebilir, anlaşılması daha kolay ve hata ayıklaması daha basit olmasını sağlar.
* **Bileşen Tabanlı:** Kendi durumunu yöneten kapsüllenmiş bileşenler oluşturun ve bunları birleştirerek karmaşık kullanıcı arayüzleri tasarlayın. Bileşen mantığı şablonlar yerine JavaScript ile yazıldığı için uygulamanızda zengin veriler kolayca aktarılabilir ve durum DOM’un dışında tutulabilir.
* **Bir Kez Öğren, Her Yerde Yaz:** Teknoloji yığınınız hakkında varsayımda bulunmuyoruz, bu nedenle mevcut kodunuzu yeniden yazmadan React ile yeni özellikler geliştirebilirsiniz. React ayrıca [Node](https://nodejs.org/en) kullanarak sunucuda render edebilir ve [React Native](https://reactnative.dev/) ile mobil uygulamalara güç verebilir.

[Projende React kullanmayı öğren](https://react.dev/learn).

## Kurulum

React, başından beri kademeli olarak benimsenmek üzere tasarlandı ve **ihtiyacınız kadar az veya çok React kullanabilirsiniz**:

* React’i denemek için [Hızlı Başlangıç](https://react.dev/learn) kullanın.
* [Mevcut Bir Projeye React Ekle](https://react.dev/learn/add-react-to-an-existing-project) ile ihtiyacınız kadar az veya çok React kullanın.
* Güçlü bir JavaScript araç zinciri arıyorsanız [Yeni Bir React Uygulaması Oluşturun](https://react.dev/learn/start-a-new-react-project).

## Dokümantasyon

React dokümantasyonuna [web sitesinden](https://react.dev/) ulaşabilirsiniz.

Hızlı bir genel bakış için [Başlarken](https://react.dev/learn) sayfasına göz atın.

Dokümantasyon birkaç bölüme ayrılmıştır:

* [Hızlı Başlangıç](https://react.dev/learn)
* [Eğitim](https://react.dev/learn/tutorial-tic-tac-toe)
* [React ile Düşünmek](https://react.dev/learn/thinking-in-react)
* [Kurulum](https://react.dev/learn/installation)
* [Kullanıcı Arayüzünü Tanımlama](https://react.dev/learn/describing-the-ui)
* [Etkileşim Ekleme](https://react.dev/learn/adding-interactivity)
* [Durum Yönetimi](https://react.dev/learn/managing-state)
* [İleri Düzey Kılavuzlar](https://react.dev/learn/escape-hatches)
* [API Referansı](https://react.dev/reference/react)
* [Nereden Destek Alınır](https://react.dev/community)
* [Katkı Rehberi](https://legacy.reactjs.org/docs/how-to-contribute.html)

[Bu depoya](https://github.com/reactjs/react.dev) pull request göndererek katkıda bulunabilirsiniz.

## Örnekler

Web sitemizde çeşitli örneklerimiz var: [örneklere göz atın](https://react.dev/). İşte başlamanız için ilk örnek:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

Bu örnek, sayfadaki bir konteynere "Hello Taylor" metnini render edecektir.

HTML benzeri bir sözdizimi kullandığımızı fark edeceksiniz; [buna JSX diyoruz](https://react.dev/learn#writing-markup-with-jsx). React kullanmak için JSX zorunlu değildir, ancak kodun okunabilirliğini artırır ve yazımı HTML yazıyormuş gibi hissettirir.

## Katkıda Bulunma

Bu deponun ana amacı, React çekirdeğini sürekli olarak geliştirmek, daha hızlı ve daha kolay kullanılabilir hale getirmektir. React’in geliştirilmesi GitHub’da açık olarak yürütülür ve hata düzeltmeleri ve iyileştirmeler için topluluğa minnettarız. React’in geliştirilmesine nasıl katkı sağlayabileceğinizi öğrenmek için aşağıyı okuyun.

### [Davranış Kuralları](https://code.fb.com/codeofconduct)

Facebook, proje katılımcılarının uymasını beklediği bir Davranış Kuralları benimsemiştir. [Tam metni](https://code.fb.com/codeofconduct) okuyarak hangi davranışların tolere edileceğini ve edilmeyeceğini öğrenebilirsiniz.

### [Katkı Rehberi](https://legacy.reactjs.org/docs/how-to-contribute.html)

Geliştirme sürecimiz, hata düzeltmeleri ve iyileştirmeleri nasıl önereceğiniz, React üzerinde yaptığınız değişiklikleri nasıl derleyip test edeceğiniz hakkında bilgi almak için [katkı rehberimizi](https://legacy.reactjs.org/docs/how-to-contribute.html) okuyun.

### [İyi İlk Konular](https://github.com/facebook/react/labels/good%20first%20issue)

Size katkı sürecimizi tanıtmak ve başlamanızı kolaylaştırmak için kapsamı nispeten sınırlı hataları içeren bir [iyi ilk konular](https://github.com/facebook/react/labels/good%20first%20issue) listemiz var. Başlamak için harika bir yer.

### Lisans

React, [MIT lisansı](./LICENSE) ile lisanslanmıştır.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---