<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

Bu projeyi beğendiyseniz, Patreon'da bana destek olmayı düşünebilirsiniz!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Chatterbox kütüphanesini kullanarak ComfyUI için metinden konuşmaya (TTS) ve ses dönüştürme (VC) yetenekleri ekleyen özel bir düğüm eklentisi.
MAKSİMUM 40 saniyeyi DESTEKLER. Bu sınırlamayı kaldırmayı denedim, ancak model bundan daha uzun bir sürede çok kötü bozuluyor, bu yüzden bu sınır devam ediyor.

![ChatterBox Örneği](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## Kurulum

1. Bu depoyu ComfyUI custom_nodes dizininize klonlayın:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. Temel bağımlılıkları yükleyin:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (İsteğe bağlı) Filigran desteğini kurun:

   ```bash
   pip install resemble-perth
   ```
**Not**: `resemble-perth` paketi Python 3.12+ ile uyumluluk sorunları yaşayabilir. Eğer import hatalarıyla karşılaşırsanız, düğümler yine de filigran olmadan çalışacaktır.

## Kullanım

### Metinden Sese Düğümü (FL Chatterbox TTS)
- Çalışma akışınıza "FL Chatterbox TTS" düğümünü ekleyin
- Metin girişini ve parametreleri yapılandırın (abartı, cfg_weight, sıcaklık)
- Ses klonlama için isteğe bağlı olarak bir sesli komut sağlayabilirsiniz

### Ses Dönüştürme Düğümü (FL Chatterbox VC)
- Çalışma akışınıza "FL Chatterbox VC" düğümünü ekleyin
- Giriş sesini ve hedef sesi bağlayın
- Her iki düğüm de CUDA hatası olursa CPU ile çalışmaya devam eder

## Değişiklik Günlüğü

### 24.06.2025
- TTS ve VC düğümlerine tekrarlanabilir üretim için seed parametresi eklendi
- Seed aralığı: 0 ila 4.294.967.295 (32-bit tamsayı)
- Hata ayıklama ve iş akışı kontrolü için tutarlı ses çıktısı sağlar
- Python 3.12+ uyumluluğu için Perth filigranlama isteğe bağlı yapıldı
- Resemble-perth importu başarısız olursa düğümler artık filigran olmadan çalışıyor

### 31.05.2025
- Kalıcı model yükleme ve yükleme çubuğu işlevi eklendi
- Mac desteği eklendi (test edilmesi gerekiyor, bana ulaşın)
- Chatterbox-tts kütüphanesi kaldırıldı ve yerel çıkarım kodu uygulandı.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---