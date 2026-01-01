
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

PyQt6 tabanlı AI destekli roman editörü; akıllı tamamlama, proje yönetimi, kavram organizasyonu gibi profesyonel yazım araçları sunar.

## Kurulum

1. Projeyi klonlayın
```bash
git clone https://github.com/inliver233/Ai-Novel-Editor.git
cd ai-novel-editor
```

2. Sanal ortam oluşturma
```bash
python -m venv venv
venv\Scripts\activate     # Windows
```

3. Bağımlılıkların kurulumu
```bash
pip install -r requirements.txt
```

4. Programı çalıştırın
```bash
python src/main.py
```

## Ana Özellikler

### Proje Yönetimi
- Hiyerarşik doküman yapısı (Eser > Bölüm > Sahne)
- Proje içe/dışa aktarma (TEXT, MARKDOWN, DOCX, PDF, HTML formatlarını destekler)
- Otomatik yedekleme ve sürüm kontrolü
- Çoklu proje yönetimi

### AI Tamamlama Özelliği
- Üç tamamlama modu: otomatik tamamlama, manuel tamamlama (önerilen: bir kez tab ile tetiklenir, tekrar tab ile uygulanır), tamamlama devre dışı
- Üç bağlam modu:
  - Hızlı mod: hafif bağlam, hızlı yanıt
  - Dengeli mod: orta seviye bağlam, kalite ve hız dengesi
  - Global mod: tam proje bağlamı, en iyi sonuçlar
- Çoklu AI hizmeti desteği: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq vb.

### Ana Hat Yönetimi
- Görsel ana hat ağaç yapısı
- Sürükle-bırak sıralama ve seviye ayarı
- Hızlı doküman gezintisi
- Ana hat analizi ve iyileştirme önerileri

### API Yapılandırması
- Birleşik AI yapılandırma merkezi
- Çoklu hizmet sağlayıcı ön ayarları
- Bağlantı testi özelliği
- Yapılandırma planı kaydetme ve içe/dışa aktarma

### Akıllı Tamamlama Ayarları
- Ayarlanabilir tetik gecikmesi
- Tamamlama uzunluğu sınırı
- Bağlam uzunluğu yapılandırması
- Akışkan yanıt desteği

### İpucu Düzenleme
- Dahili çeşitli yazım şablonları
- Özel ipucu şablonu
- Şablon kategori yönetimi
- Moda özel şablon yapılandırması

### Arayüz Özellikleri
- Açık ve koyu tema desteği
- Üç sütunlu düzen (proje ağacı, düzenleyici, kavram paneli)
- Katlanabilir yan panel
- Tam ekran yazma modu
- Odak modu (cümle, paragraf, daktilo, zen modu, sürükleyici mod)

### Arama ve Değiştirme
- Tüm projede metin arama
- Regex (düzenli ifade) desteği
- Toplu değiştirme özelliği
- Gelişmiş arama seçenekleri

### Kavram Yönetimi
- Karakter, mekan, nesne otomatik algılama
- Kavram ilişkisi yönetimi
- Etiket ve kategori sistemi
- Kavram hızlı ekleme

## Kısayol Tuşları

- `Ctrl+N`: Yeni proje oluştur
- `Ctrl+O`: Proje aç
- `Ctrl+S`: Belgeyi kaydet
- `F11`: Tam ekran modu
- `Tab`: AI tamamlamayı elle tetikle (elle modda)
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-01

---