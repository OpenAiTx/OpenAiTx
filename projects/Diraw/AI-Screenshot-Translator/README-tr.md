# AI Ekran Görüntüsü Çeviri Aracı (AI Screenshot Translator)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# Giriş

Bu araç, **basit ekran görüntüsü işlemi** ile görüntüyü AI modeline göndererek metin tanıma ve çeviri işlemi yapar ve çeviri sonucunu bağımsız bir pencerede etkileşimli HTML formatında gösterir.

Bu araç, **özelleştirilebilir kısayol tuşları ile tetikleme, çoklu pencere sonuç yönetimi ve sistem tepsisi çalıştırma** özelliklerini destekler, böylece günlük iş ve eğitimde çeviri verimliliğini büyük ölçüde artırır.

**Araç Özellikleri**: 1. Ekran görüntüsü çevirisi, kısayol tuşu ile başlatma; 2. Yama ekran görüntüsü ve çeviri, serbestçe sürüklenebilir ve yeniden boyutlandırılabilir, çoklu çeviri yaması grubu oluşturulabilir; 3. Formüllerde orijinal metne geçiş yaparak kopyalama kolaylığı; 4. Özelleştirilebilir API arayüzü

**Çözmek İstenen Sorunlar**: 1. Piyasadaki ana akım tüm belge çeviri araçlarının hantallığı; 2. PDF'den metin kopyalayıp çeviri yapıldığında formül bloklarının bozulması veya kopyalanamaması; 3. Görüntü taramalı PDF'lerde metin kopyalanamaması

# Demo

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# Pencere Görünümü

Çeviri penceresi:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

Ayarlar penceresi:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

Ayar seçenekleri hakkında daha ayrıntılı bilgiye yazılım içinde veya web sayfasında [İpucu](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md) kısmından ulaşabilirsiniz.

# Kurulum

Kaynak kodunu indirerek çalıştırabilir veya [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) bölümünden çalıştırılabilir dosyayı indirebilirsiniz.

### 1. Depoyu Klonlayın

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. Sanal Ortam Oluşturun ve Çalıştırın

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# Güncelleme Planı

- ~~API yapılandırması için yeni bir GUI penceresi eklendi, manuel yaml dosyası yapılandırma mantığı yazılımın otomatik oluşturmasına optimize edildi (v0.3.0 tamamlandı)~~
- Görüntü ve formül depolama sistemi eklenecek, daha sonra kullanılmak üzere kolay erişim (v0.4'te tamamlanması planlanıyor)
- (Daha fazla özellik için issue açabilir veya PR ile katkıda bulunabilirsiniz)

# Diğer

- Yazılım ikonu [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free) adresinden alınmıştır.
- Gemini 2.5 Flash ve DeepSeek-V3-0324’e bug bulmamda yardımcı oldukları için teşekkürler.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---