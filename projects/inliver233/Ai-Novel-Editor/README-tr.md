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

3. Bağımlılıkları yükleyin
```bash
pip install -r requirements.txt
```
4. Programı Çalıştırma
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
- Üç tamamlama modu: Otomatik tamamlama, manuel tamamlama (Önerilir: Bir kez tab'a basarak tetikleyin, tekrar tab'a basarak tamamlamayı uygulayın), tamamlama devre dışı
- Üç bağlam modu:
  - Hızlı Mod: Hafif bağlam, hızlı yanıt
  - Dengeli Mod: Orta seviyede bağlam, kalite ve hız dengesi
  - Global Mod: Tüm proje bağlamı, en iyi sonuç
- Çoklu AI servis desteği: OpenAI, Claude, Tongyi Qianwen, Zhipu AI, DeepSeek, Groq vb.
### Başlık Yönetimi
- Görselleştirilebilir başlık ağaç yapısı
- Sürükle-bırak sıralama ve seviye ayarlama
- Hızlı doküman gezintisi
- Başlık analizi ve iyileştirme önerileri

### API Yapılandırması
- Birleşik AI yapılandırma merkezi
- Çoklu servis sağlayıcı ön ayarlı yapılandırmaları
- Bağlantı testi özelliği
- Yapılandırma şeması kaydetme ve içe/dışa aktarma

### Akıllı Tamamlama Ayarları
- Ayarlanabilir tetikleme gecikmesi
- Tamamlama uzunluğu sınırı
- Bağlam uzunluğu yapılandırması
- Akışlı yanıt desteği

### İpucu Düzenleme
- Dahili çoklu yazma şablonları
- Özelleştirilebilir ipucu şablonları
- Şablon kategori yönetimi
- Moda özel şablon yapılandırması
### Arayüz Özellikleri
- Açık ve koyu çift tema
- Üç sütunlu düzen (proje ağacı, editör, kavram paneli)
- Katlanabilir yan panel
- Tam ekran yazma modu
- Odak modu (cümle, paragraf, daktilo, zen modu, immersif mod)

### Arama ve Değiştirme
- Tüm projede metin arama
- Düzenli ifade desteği
- Toplu değiştirme özelliği
- Gelişmiş arama seçenekleri

### Kavram Yönetimi
- Karakter, mekan, nesne otomatik algılama
- Kavram ilişkileri yönetimi
- Etiket ve sınıflandırma sistemi
- Hızlı kavram ekleme

## Kısayol Tuşları
- `Ctrl+N`: Yeni proje
- `Ctrl+O`: Proje aç
- `Ctrl+S`: Belgeyi kaydet
- `F11`: Tam ekran modu
- `Tab`: Manuel AI tamamlamayı tetikle (manuel modda)
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---