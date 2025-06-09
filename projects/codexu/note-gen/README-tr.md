![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## Kılavuz

NoteGen, kaydı ve yazmayı birleştirmek için yapay zekayı kullanmaya adanmış, parçalı bilgileri okunabilir bir nota dönüştüren, platformlar arası bir `Markdown` not alma uygulamasıdır.

🖥️ Resmi Doküman: [https://notegen.top](https://notegen.top)

💬 Katılın [WeChat/QQ Grubu](https://github.com/codexu/note-gen/discussions/110)

## Neden NoteGen'i Seçmelisiniz?

- Hafif: [Kurulum paketi](https://github.com/codexu/note-gen/releases) **sadece 20MB**, ücretsiz, reklamsız ve ek yazılım içermez.
- Platformlar arası: Mac, Windows, Linux destekler ve `Tauri2`'nin platformlar arası yetenekleri sayesinde gelecekte iOS ve Android'i de destekleyecektir.
- `Ekran görüntüleri`, `metin`, `çizimler`, `dosyalar`, `bağlantılar` gibi birden fazla kayıt yöntemini destekler, çeşitli senaryolarda parçalı kayıt ihtiyaçlarını karşılar.
- Yerel `Markdown(.md)` depolama formatı olarak kullanılır, değişiklik yapılmaz, kolayca taşınabilir.
- Yerel çevrimdışı kullanım, `GitHub, Gitee özel depolarına` anlık senkronizasyon ve geçmişe geri alma ile birlikte WebDAV senkronizasyonunu destekler.
- Yapay zeka destekli: ChatGPT, Gemini, Ollama, LM Studio, Grok gibi modellerle yapılandırılabilir, özel üçüncü parti model yapılandırması desteklenir.
- RAG: Notlarınız bilgi tabanınızdır. Gömülü modeller ve yeniden sıralama modellerini destekler.

## Ekran Görüntüleri

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

Kayıt:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

Yazma:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

Tema:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## Kaydeden Yazmaya

Geleneksel not alma uygulamaları genellikle kayıt işlevi sunmaz. Kullanıcıların kayıt için içeriği elle kopyalayıp yapıştırması gerekir, bu da verimliliği büyük ölçüde azaltır. Dağınık kaydedilmiş içeriklerle karşılaşıldığında, bunları düzenlemek büyük çaba gerektirir.

NoteGen, `Kayıt` ve `Yazma` sayfalarına ayrılmıştır ve aralarındaki ilişki şöyledir:

- Kayıtlar notlara düzenlenebilir ve yazma sayfasına aktarılıp derinlemesine kompozisyon yapılabilir.
- Yazarken, istediğiniz zaman kayıt ekleyebilirsiniz.

### Kayıt

Kayıt işlevi bir **Yapay Zeka sohbet botuna** benzer, ancak onunla sohbet ederken daha önce kaydedilen içerikle ilişkilendirme yapabilirsiniz; sohbet modundan düzenleme moduna geçerek kayıtları okunabilir bir not haline getirebilirsiniz.

Aşağıdaki yardımcı özellikler daha etkili kayıt yapmanıza yardımcı olabilir:

- Farklı kayıt senaryolarını ayırt etmek için **Etiketler**.
- Yapay zeka asistanınızı hassas şekilde kontrol edebilmeniz için özel istemleri destekleyen **Kişilikler**.
- **Pano Asistanı** panonuzdaki metin veya görselleri otomatik olarak algılar ve listenize kaydeder.

### Yazma

Yazma bölümü ikiye ayrılmıştır: **Dosya Yöneticisi** ve **Markdown Editörü**.

**Dosya Yöneticisi**

- Yerel Markdown dosyalarının ve GitHub ile senkronize edilen dosyaların yönetimini destekler.
- Sınırsız dizin hiyerarşisini destekler.
- Birden fazla sıralama yöntemini destekler.

**Markdown Editörü**

- WYSIWYG, anında render ve bölünmüş ekran önizleme modlarını destekler.
- Geçmişe geri alma ile sürüm kontrolü destekler.
- Sohbet, devam ettirme, parlatma ve çeviri işlevleri için yapay zeka desteği.
- Görsel yükleme, görselleri yükleme ve Markdown görsel bağlantılarına dönüştürme desteği.
- HTML'den Markdown'a dönüşüm, tarayıcıdan kopyalanan içerikleri otomatik olarak Markdown formatına çevirme.
- Anahatlar, matematiksel formüller, zihin haritaları, grafikler, akış diyagramları, Gantt diyagramları, sıralı diyagramlar, müzik notaları, multimedya, sesli okuma, başlık bağlantıları, kod vurgulama ve kopyalama, graphviz render ve plantuml UML diyagramlarını destekler.
- Gerçek zamanlı yerel içerik kaydı, gecikmeli (10 saniye düzenleme yapılmadığında) otomatik senkronizasyon ve geçmişe geri alma desteği.

## Diğer Özellikler

- Belirli içeriği hızlıca bulup atlamak için global arama.
- Görsel havuzu içeriğinin pratik yönetimi için görsel barındırma yönetimi.
- Koyu tema desteği ve Markdown, kod gibi görünümler için tema ve görünüm ayarları.
- Uluslararasılaştırma desteği, şu anda Çince ve İngilizce mevcut.

## Nasıl Kullanılır?

### İndir

Şu anda Mac, Windows ve Linux'u destekler. Tauri2'nin platformlar arası yetenekleri sayesinde gelecekte iOS ve Android'i de destekleyecektir.

[NoteGen'i İndir (alpha)](https://github.com/codexu/note-gen/releases)

### Gelişmiş Kullanım

Not alma uygulamasını doğrudan herhangi bir yapılandırma olmadan kullanabilirsiniz. Daha iyi bir deneyim için lütfen ayarlar sayfasını açarak yapay zeka ve senkronizasyonu yapılandırın.

## Katkıda Bulunun

- [Katkı kılavuzunu okuyun](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [Güncelleme planları](https://github.com/codexu/note-gen/issues/46)
- [Hata veya iyileştirme önerisi gönderin](https://github.com/codexu/note-gen/issues)
- [Tartışmalar](https://github.com/codexu/note-gen/discussions)

## Katkıda Bulunanlar

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Yıldız Geçmişi

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---