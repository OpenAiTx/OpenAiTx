#寸止 🛑

> **AI Diyaloğunda "Erken Bitiş"e Son, İletişimi Sonuna Kadar Sürdürün**

AI asistanınızın her seferinde sohbeti erken bitirmesinden hâlâ mı çıldırıyorsunuz? Daha konuşacak çok şey varken, "Başka yardımcı olabileceğim bir şey var mı?" diyor. **寸止** tam da bu sorunu çözüyor!

AI sohbeti "başından savmak" istediğinde,寸止 anında bir diyalog kutusu açarak, sorununuz gerçekten çözülene kadar sohbeti derinleştirmenize olanak tanır.

## 🌟 Temel Özellikler

- 🛑 **Akıllı Engelleme**: AI sohbeti bitirmek istediğinde otomatik olarak devam seçenekleri sunar
- 🧠 **Hafıza Yönetimi**: Proje bazında geliştirme standartlarını ve tercihleri saklar
- 🎨 **Zarif Etkileşim**: Markdown desteği, çoklu giriş yöntemi
- ⚡ **Kur ve Kullan**: 3 saniyede kurulum, çapraz platform desteği

## 📸 Sonuçlara Göz Atın

### 🛑 Akıllı Engelleme Pop-up'ı
![寸止弹窗演示](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*AI sohbeti bitirmek istediğinde,寸止 akıllı pop-up'ı anında ortaya çıkar, önceden tanımlanmış seçeneklerle hızlı seçim yapmanızı sağlar, böylece iletişim daha derin ve sürdürülebilir olur*
### ⚙️ Ayar Yönetim Arayüzü
![寸止设置界面](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*Zarif ayar arayüzü, hafıza yönetimi, özellik anahtarı, tema değiştirme ve akıllı ipucu üretimi destekler*

## 🚀 Kullanıma Başlama

### Yöntem 1: Hızlı Kurulum (Tavsiye Edilir)

**macOS Kullanıcıları:**
```bash
# 3 saniyede kurulum, derleme beklemeye gerek yok
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **Sorun Giderme**: 404 indirme hatası ile karşılaşırsanız aşağıdaki adımları uygulayın:
>
> ```bash
> # Eski tap önbelleğini temizle
> brew untap imhuso/cunzhi
> # Yeniden kurulum yap
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **Yaygın Hata Örneği:**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> Bu genellikle önceki sürüm önbelleği nedeniyle sürüm numarasının uyuşmamasından kaynaklanır. Tap temizlendikten sonra yeniden kurulum yaparak sorun çözülür.

**Windows/Linux Kullanıcıları:**
İkinci yöntemi kullanarak manuel indirme önerilir, basit ve hızlı!
### Yöntem 2: Manuel İndirme

1. [Sürümler Sayfası](https://github.com/imhuso/cunzhi/releases)'nı ziyaret edin
2. Sisteminiz için uygun olan sürümü indirin:
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. Arşivden çıkardıktan sonra `寸止` ve `等一下` dosyalarını sistem PATH'ine ekleyin

## ⚡ Hızlı Başlangıç

### Birinci Adım: MCP İstemcisini Yapılandırma

MCP istemcinizin (örneğin Claude Desktop) yapılandırma dosyasına şunu ekleyin:

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### İkinci Adım: Ayarlar Arayüzünü Açın

```bash
# Ayar komutunu çalıştırın
Biraz bekleyin
```

### Üçüncü Adım: İpucu Sözcüklerini Yapılandırın

Ayarlar arayüzündeki "Referans İpucu Sözcükleri" sekmesinde:
1. Otomatik oluşturulan ipucu sözcüklerini görüntüleyin
2. Kopyala butonuna tıklayın
3. İpucu sözcüklerini AI asistanınıza ekleyin

### Dördüncü Adım: Kullanmaya Başlayın

Artık AI asistanınızda akıllı engelleme, hafıza yönetimi ve açılır pencere etkileşimi gibi işlevler mevcut!

> 💡 **İpucu**: Oluşturulan ipucu sözcüklerini referans alarak kişiselleştirilmiş değişiklikler yapabilir, kendinize özel bir AI etkileşim deneyimi oluşturabilirsiniz.
## 🤝 Katkıda Bulunun

Cunzhi açık kaynaklı bir projedir, her türlü katkıyı memnuniyetle karşılıyoruz!

### 🐛 Sorun mu Buldunuz?
- [Issue Oluşturun](https://github.com/imhuso/cunzhi/issues) ve sorunu açıklayın
- Yeniden üretme adımlarını ve ortam bilgisini sağlayın

### 💡 İyi Bir Fikriniz mi Var?
- [Tartışma Başlatın](https://github.com/imhuso/cunzhi/discussions) ve fikrinizi paylaşın
- Yeni özellikler için Pull Request gönderin

### 🛠️ Yerel Geliştirme
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 Bize Ulaşın

- 🐛 **Sorun Bildirimi**：[GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **Özellik Tartışması**：[GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **Projeyi Beğendiniz mi**：Bize bir Star vererek destek olun!

## 📄 Açık Kaynak Lisansı

MIT Lisansı - Özgürce kullanın, katkıda bulunmaktan çekinmeyin!

---

<div align="center">

**AI Diyaloglarında "erken sonlanmaya" elveda | Her iletişimin sonuna kadar sürmesini sağlayın**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 Hata Bildir](https://github.com/imhuso/cunzhi/issues) · [💡 Özellik Talep Et](https://github.com/imhuso/cunzhi/discussions)

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---