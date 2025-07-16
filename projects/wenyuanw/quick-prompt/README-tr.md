# Hızlı Prompt

<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">İngilizce</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">Japonca</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">Korece</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">Hintçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">Tayca</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Fransızca</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Almanca</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">İspanyolca</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">İtalyanca</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Rusça</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Portekizce</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Felemenkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Lehçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">Arapça</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">Farsça</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Vietnamca</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Endonezce</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

Güçlü bir tarayıcı eklentisi, prompt yönetimi ve hızlı girişe odaklanır. Kullanıcıların prompt kütüphanesi oluşturmasına, yönetmesine ve düzenlemesine yardımcı olur ve herhangi bir web sayfasındaki giriş kutusunda önceden ayarlanmış Prompt içeriklerini hızlıca ekleyerek iş verimliliğini artırır.

> Tarayıcı eklentisi yalnızca web üzerinde kullanılabildiği için, aynı işlevlere sahip açık kaynaklı bir [Raycast eklentisi](https://github.com/wenyuanw/quick-prompt-raycast) geliştirildi, tarayıcı eklentisi veri formatıyla uyumlu ve aynı JSON verisiyle sorunsuz geçişe olanak tanır.

## ✨ Özellikler

- 📚 **Prompt Yönetimi**: Prompt kütüphaneni kolayca oluştur, düzenle ve yönet
- 🚀 **Hızlı Giriş**: Herhangi bir web sayfası giriş kutusunda `/p` yazarak prompt seçiciyi hızlıca aç
- ⌨️ Prompt seçiciyi açmak & seçili metni prompt olarak kaydetmek için kısayol tuşlarını ayarlayabilme desteği
- 📑 Sağ tık menüsü ile seçili metni doğrudan prompt olarak kaydetme desteği
- 🎯 Kategoriler, başlık, içerik, etiketler ve değişkenler dahil olmak üzere özelleştirilebilir promptlar desteği
- 🧑‍💻 **Değişken Desteği**: Promptlarda `{{değişkenAdı}}` formatında değişkenler kullanılabilir, kullanılacağı zaman değerleri girilebilir
- 💾 **Veri Yedekleme**: Prompt kütüphanesini dışa aktarma ve içe aktarma desteği, cihazlar arası geçiş ve yedekleme kolaylığı sağlar
- 🔗 **Notion Senkronizasyonu**: Prompt kütüphanesini Notion veritabanı ile senkronize etme desteği
- 🔍 Prompt arama ve filtreleme özelliği desteği
- 🌙 Sistemin açık-koyu moduna otomatik uyum

## ⚠️ Bilinen Sorunlar

- Doubao (doubao.com) sitesinde `/p` ile prompt seçici tetiklendiğinde bazı giriş kutularında `/p` ifadesi temizlenmeyebiliyor. Endişelenmeyin, ben ve eski dostum Cursor bu sorunu çözmek için gece gündüz çalışıyoruz, en kısa sürede düzelteceğiz!

## 🚀 Kullanım Yöntemi

1. **Hızlı Tetikleme**: Herhangi bir web sayfasındaki metin giriş kutusuna `/p` yazarak prompt seçiciyi tetikle
2. **Kısayol tuşuyla seçiciyi açma**: `Ctrl+Shift+P` (Windows/Linux) veya `Command+Shift+P` (macOS) ile prompt seçiciyi aç
3. **Prompt Seçme**: Açılan seçicide istediğin prompta tıkla, otomatik olarak mevcut giriş kutusuna eklenir
4. **Promptu Hızlı Kaydetme**: Herhangi bir metni seçtikten sonra `Ctrl+Shift+S` (Windows/Linux) veya `Command+Shift+S` (macOS) ile prompt olarak hızlıca kaydet
5. **Sağ Tık Menüsü ile Kaydetme**: Herhangi bir metni seçtikten sonra sağ tıklayıp "Bu promptu kaydet" seçeneğiyle prompt olarak kaydet
6. **Prompt Kütüphanesini Dışa Aktarma**: Yönetim sayfasında "Dışa Aktar" butonuna tıklayarak tüm promptları JSON dosyası olarak yerel bilgisayara kaydet
7. **Prompt Kütüphanesini İçe Aktarma**: Yönetim sayfasında "İçe Aktar" butonuna tıklayarak yerel JSON dosyasından promptları içe aktar (mevcut promptları birleştirme veya üzerine yazma desteğiyle)

## 📸 Arayüz Önizlemesi

Quick Prompt, promptları kolayca yönetmeni ve kullanmanı sağlayan sezgisel ve kullanıcı dostu bir arayüz sunar.

### Prompt Seçici

![Prompt Seçici](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Prompt Seçici](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

`/p` kısa komutu veya kısayol tuşuyla herhangi bir giriş kutusunda prompt seçiciyi hızlıca açıp ihtiyacın olan promptu seçerek ekleyebilirsin.

### Prompt Yönetim Sayfası

![Prompt Yönetimi](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

Yönetim sayfasında yeni promptlar oluşturabilir, mevcut promptları düzenleyebilir, etiket ekleyebilir ve kategorilere ayırabilirsin. Arayüz sade ve kullanımı kolaydır.

### Sağ Tık Menüsü ile Kaydetme

![Sağ Tık Menüsü ile Kaydetme](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Web sayfasındaki herhangi bir metni seçip sağ tıklayarak hızlıca prompt olarak kaydedebilir, iş verimliliğini artırabilirsin.

### Prompt Değişken Girişi

![Prompt Değişken Penceresi](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Promptlar değişken tanımlamayı destekler, seçildikten sonra açılan pencerede ilgili değişken değerini girebilirsin.

## ⚙️ Özelleştirilebilir Ayarlar

1. Eklenti simgesine tıkla, ardından "Promptları Yönet" butonuna bas
2. Yönetim sayfasında şunları yapabilirsiniz:
   - Yeni anahtar kelimeler ekleyin
   - Mevcut anahtar kelimeleri düzenleyin
   - Gereksiz anahtar kelimeleri silin
   - Anahtar kelimelere etiket ekleyerek kategorize edin
   - Anahtar kelime kütüphanesini dışa aktararak yedek alın
   - Önceden yedeklenen anahtar kelime kütüphanesini içe aktarın

## 📦 Kurulum Rehberi

### Uygulama Mağazasından Yükleme

Artık Chrome Web Mağazasında! [Buradan indirip yükleyin](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### GitHub Releases üzerinden edinme

1. [GitHub Releases sayfasını](https://github.com/wenyuanw/quick-prompt/releases) ziyaret edin
2. En son sürümün derlenmiş eklenti paketini indirin
3. İndirilen dosyayı çıkarın
4. Aşağıdaki talimatlara göre derlenmiş uzantıyı kurun

### Kaynak koddan derleme

1. Depoyu klonlayın
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. Bağımlılıkların kurulumu
   ```bash
   pnpm install
   ```
3. Geliştirme ve Derleme

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```
### Derlenmiş Eklentiyi Yükleme

#### Chrome / Edge
1. Eklenti yönetim sayfasını açın (`chrome://extensions` veya `edge://extensions`)
2. "Geliştirici Modu"nu etkinleştirin
3. "Paketlenmemiş uzantıyı yükle"ye tıklayın
4. Projenin `.output/chrome-mv3/` dizinini seçin

#### Firefox
1. `about:debugging` sayfasını açın
2. "Bu Firefox" seçeneğine tıklayın
3. "Geçici eklenti yükle"ye tıklayın
4. Projenin `.output/firefox-mv2/` dizinindeki `manifest.json` dosyasını seçin

## 📄 Lisans

MIT

## 🤝 Katkı Rehberi

Pull Request ve Issue göndermeye hoş geldiniz!

1. Bu depoyu çatallayın (Fork)
2. Özellik dalınızı oluşturun (`git checkout -b feature/amazing-feature`)
3. Değişikliklerinizi gönderin (`git commit -m 'Add some amazing feature'`)
4. Dalınıza gönderin (`git push origin feature/amazing-feature`)
5. Bir Pull Request açın

## 👏 Katkıda Bulunanlar Listesi

Projeye katkı sağlayan tüm geliştiricilere teşekkürler!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Yıldız Geçmişi

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---