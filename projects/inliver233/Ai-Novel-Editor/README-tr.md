<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=inliver233&project=Ai-Novel-Editor&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# AI Roman Editörü

PyQt6 tabanlı AI destekli roman editörü, akıllı tamamlama, proje yönetimi, kavram organizasyonu gibi profesyonel yazım araçları sunar.

## Kurulum

1. Projeyi klonlayın
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Sanal ortam oluşturun
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```
uv kullanarak
```bash
uv venv -p 3.11
```
3. Bağımlılıkların Kurulması
```bash
pip install -r requirements.txt
```
uv kullanımı
```bash
uv sync
```


4. Programı Çalıştırma
```bash
python -m src
```

## Ana Özellikler

### Proje Yönetimi
- Hiyerarşik belge yapısı (Eser > Bölüm > Sahneler)
- Proje içe/dışa aktarma (TEXT, MARKDOWN, DOCX, PDF, HTML formatlarını destekler)
- Otomatik yedekleme ve sürüm kontrolü
- Çoklu proje yönetimi
### AI Tamamlama Özelliği
- Üç tamamlama modu: Otomatik tamamlama, Manuel tamamlama (Tavsiye edilir: bir kez tab tuşuna basarak tetiklenir, tekrar tab tuşuna basarak tamamlama uygulanır), Tamamlama devre dışı
- Üç bağlam modu:
  - Hızlı Mod: Hafif bağlam, hızlı yanıt
  - Dengeli Mod: Orta düzeyde bağlam, kalite ve hız dengesi
  - Global Mod: Tam proje bağlamı, en iyi sonuç
- Birçok AI servisini destekler: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq vb.

### Ana Hat Yönetimi
- Görsel ana hat ağaç yapısı
- Sürükle-bırak ile sıralama ve seviye ayarı
- Hızlı belge gezintisi
- Ana hat analizi ve optimizasyon önerileri

### API Yapılandırması
- Birleşik AI yapılandırma merkezi
- Çoklu servis sağlayıcı ön ayarları
- Bağlantı testi fonksiyonu
- Yapılandırma şeması kaydetme ve içe/dışa aktarma
### Akıllı Otomatik Tamamlama Ayarları
- Ayarlanabilir tetikleme gecikmesi
- Tamamlama uzunluğu sınırı
- Bağlam uzunluğu yapılandırması
- Akışlı yanıt desteği

### İpucu Düzenleme
- Dahili çeşitli yazı şablonları
- Özelleştirilebilir ipucu şablonları
- Şablon kategori yönetimi
- Moda özel şablon yapılandırması

### Arayüz Özellikleri
- Açık/Koyu çift tema
- Üç sütunlu düzen (proje ağacı, editör, kavram paneli)
- Katlanabilir yan panel
- Tam ekran yazı modu
- Odak modu (cümle, paragraf, daktilo, zen modu, sürükleyici mod)

### Arama ve Değiştirme
- Tüm proje metni arama
- Regüler ifade desteği
- Toplu değiştirme özelliği
- Gelişmiş arama seçenekleri

### Kavram Yönetimi
- Otomatik rol, mekan, nesne algılama
- Kavramsal ilişki yönetimi
- Etiket ve kategorilendirme sistemi
- Hızlı kavram ekleme

## Kısayol Tuşları

- `Ctrl+N`: Yeni proje
- `Ctrl+O`: Proje aç
- `Ctrl+S`: Belgeyi kaydet
- `F11`: Tam ekran modu
- `Tab`: AI otomatik tamamlama manuel tetikleme (manuel modda)
- `Ctrl+F`: Bul
- `Ctrl+H`: Bul ve değiştir
- `Ctrl+Shift+H`: Gelişmiş bul ve değiştir
## Sistem Gereksinimleri

- Python 3.8+
- PyQt6
- İşletim Sistemi: Windows, macOS, Linux

## Yazar

**inliver**
- E-posta: inliverapi@outlook.com  
- GitHub: https://github.com/inliver233

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---