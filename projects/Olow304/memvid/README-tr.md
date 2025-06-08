# Memvid - Video Tabanlı Yapay Zekâ Hafızası 🧠📹

**Ölçeklenebilir yapay zekâ hafızası için hafif, oyunun kurallarını değiştiren çözüm**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid, metin verilerini videolara kodlayarak yapay zekâ hafıza yönetiminde devrim yaratır. Bu sayede milyonlarca metin parçası arasında **yıldırım hızında anlamsal arama** ve **saniyelerden kısa sürede erişim** sağlanır. Geleneksel vektör veri tabanlarının devasa RAM ve depolama tüketiminin aksine, Memvid bilgi tabanınızı kompakt video dosyalarına sıkıştırır ve her türlü bilgiye anında erişim sağlar.

## 🎥 Demo

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e



## ✨ Temel Özellikler

- 🎥 **Veri Tabanı Olarak Video**: Milyonlarca metin parçasını tek bir MP4 dosyasında saklayın
- 🔍 **Anlamsal Arama**: Doğal dil sorguları ile ilgili içeriği bulun
- 💬 **Dahili Sohbet**: Bağlama duyarlı yanıtlarla sohbet arayüzü
- 📚 **PDF Desteği**: PDF belgelerini doğrudan içe aktarın ve dizinleyin
- 🚀 **Hızlı Erişim**: Devasa veri kümelerinde saniyelerden kısa sürede arama
- 💾 **Verimli Depolama**: Geleneksel veri tabanlarına göre 10 kat sıkıştırma
- 🔌 **Takılabilir LLM’ler**: OpenAI, Anthropic veya yerel modellerle çalışır
- 🌐 **Önce Çevrimdışı**: Video oluşturulduktan sonra internet gerekmez
- 🔧 **Basit API**: Sadece 3 satır kodla başlayın

## 🎯 Kullanım Alanları

- **📖 Dijital Kütüphaneler**: Binlerce kitabı tek bir video dosyasında dizinleyin
- **🎓 Eğitim İçeriği**: Ders materyallerinin aranabilir video hafızalarını oluşturun
- **📰 Haber Arşivleri**: Yıllarca makaleyi yönetilebilir video veri tabanlarına sıkıştırın
- **💼 Kurumsal Bilgi**: Şirket genelinde aranabilir bilgi tabanları oluşturun
- **🔬 Araştırma Makaleleri**: Bilimsel literatürde hızlı anlamsal arama
- **📝 Kişisel Notlar**: Notlarınızı aranabilir bir yapay zekâ asistanına dönüştürün

## 🚀 Neden Memvid?

### Oyunun Kurallarını Değiştiren Yenilik
- **Veri Tabanı Olarak Video**: Milyonlarca metin parçasını tek bir MP4 dosyasında saklayın
- **Anında Erişim**: Devasa veri kümelerinde saniyelerden kısa sürede anlamsal arama
- **10 Kat Depolama Verimliliği**: Video sıkıştırmasıyla hafıza kullanımı büyük oranda azalır
- **Sıfır Altyapı**: Sunucu gerekmez, sadece istediğiniz yere kopyalayabileceğiniz dosyalar
- **Önce Çevrimdışı**: Videolar oluşturulduktan sonra tamamen çevrimdışı çalışır

### Hafif Mimari
- **Minimum Bağımlılıklar**: Temel işlevsellik ~1000 satır Python kodunda
- **CPU Dostu**: GPU gereksinimi olmadan verimli çalışır
- **Taşınabilir**: Tüm bilgi tabanınız tek bir video dosyasında
- **Akışa Uygun**: Videolar bulut depolamadan aktarılabilir

## 📦 Kurulum

### Hızlı Kurulum
```bash
pip install memvid
```

### PDF Desteği için
```bash
pip install memvid PyPDF2
```

### Önerilen Kurulum (Sanal Ortam)
```bash
# Yeni bir proje klasörü oluşturun
mkdir my-memvid-project
cd my-memvid-project

# Sanal ortam oluşturun
python -m venv venv

# Aktif edin
# macOS/Linux için:
source venv/bin/activate
# Windows için:
venv\Scripts\activate

# memvid’i kurun
pip install memvid

# PDF desteği için:
pip install PyPDF2
```

## 🎯 Hızlı Başlangıç

### Temel Kullanım
```python
from memvid import MemvidEncoder, MemvidChat

# Metin parçalarından video hafızası oluşturun
chunks = ["Önemli bilgi 1", "Önemli bilgi 2", "Tarihi olay detayları"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# Hafızanızla sohbet edin
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("Tarihi olaylar hakkında ne biliyorsun?")
print(response)
```

### Belgelerden Hafıza Oluşturma
```python
from memvid import MemvidEncoder
import os

# Belgeleri yükle
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# Metin dosyalarını ekle
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# Optimize edilmiş video oluştur
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # Daha yüksek FPS = saniye başına daha fazla parça
    frame_size=512  # Daha büyük kareler = kare başına daha fazla veri
)
```

### Gelişmiş Arama ve Erişim
```python
from memvid import MemvidRetriever

# Yükleyiciyi başlat
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# Anlamsal arama
results = retriever.search("makine öğrenimi algoritmaları", top_k=5)
for chunk, score in results:
    print(f"Puan: {score:.3f} | {chunk[:100]}...")

# Bağlam penceresi al
context = retriever.get_context("sinir ağlarını açıkla", max_tokens=2000)
print(context)
```

### Etkileşimli Sohbet Arayüzü
```python
from memvid import MemvidInteractive

# Etkileşimli sohbet arayüzünü başlat
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # Web arayüzünü http://localhost:7860 adresinde açar
```

### file_chat.py ile Test Etme
`examples/file_chat.py` betiği, Memvid’i kendi belgelerinizle kapsamlı şekilde test etmenin bir yolunu sunar:

```bash
# Bir belge klasörünü işle
python examples/file_chat.py --input-dir /path/to/documents --provider google

# Belirli dosyaları işle
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# H.265 sıkıştırma kullan (Docker gerektirir)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# Büyük belgeler için özel parçalara ayırma
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# Mevcut hafızayı yükle
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### Tam Örnek: Bir PDF Kitapla Sohbet Etme
```bash
# 1. Yeni bir dizin oluşturup ortamı kurun
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Windows için: venv\Scripts\activate

# 2. Bağımlılıkları kurun
pip install memvid PyPDF2

# 3. book_chat.py dosyasını oluşturun
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# PDF dosyanız
book_pdf = "book.pdf"  # PDF yolunuzu buraya yazın

# Video hafızayı oluşturun
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# Kitapla sohbet edin
api_key = os.getenv("OPENAI_API_KEY")  # İsteğe bağlı: yapay zekâ yanıtları için
```markdown
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. Çalıştırın
export OPENAI_API_KEY="your-api-key"  # İsteğe Bağlı
python book_chat.py
```

## 🛠️ Gelişmiş Yapılandırma

### Özel Gömüler
```python
from sentence_transformers import SentenceTransformer

# Özel gömme modeli kullan
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### Video Optimizasyonu
```python
# Maksimum sıkıştırma için
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # Saniyede daha fazla kare
    frame_size=256,  # Daha küçük kareler
    video_codec='h265',  # Daha iyi sıkıştırma
    crf=28  # Sıkıştırma kalitesi (düşük = daha iyi kalite)
)
```

### Dağıtık İşleme
```python
# Büyük veri kümelerini paralel işleyin
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 Sorun Giderme

### Yaygın Sorunlar

**ModuleNotFoundError: No module named 'memvid'**
```bash
# Doğru Python'u kullandığınızdan emin olun
which python  # Sanal ortam yolunu göstermeli
# Değilse, sanal ortamınızı etkinleştirin:
source venv/bin/activate  # Windows'ta: venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**LLM API Anahtar Sorunları**
```bash
# API anahtarınızı ayarlayın (https://platform.openai.com adresinden alınabilir)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# Ya da Windows'ta:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**Büyük PDF İşleme**
```python
# Çok büyük PDF'ler için daha küçük parça boyutları kullanın
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 Katkı Sağlama

Katkılarınızı memnuniyetle karşılıyoruz! Detaylar için [Katkı Rehberimize](CONTRIBUTING.md) bakın.

```bash
# Testleri çalıştır
pytest tests/

# Kapsam ile çalıştır
pytest --cov=memvid tests/

# Kodu biçimlendir
black memvid/
```

## 🆚 Geleneksel Çözümlerle Karşılaştırma

| Özellik | Memvid | Vektör Veritabanları | Geleneksel Veritabanları |
|---------|--------|----------------------|--------------------------|
| Depolama Verimliliği | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| Kurulum Karmaşıklığı | Basit | Karmaşık | Karmaşık |
| Anlamsal Arama | ✅ | ✅ | ❌ |
| Çevrimdışı Kullanım | ✅ | ❌ | ✅ |
| Taşınabilirlik | Dosya tabanlı | Sunucu tabanlı | Sunucu tabanlı |
| Ölçeklenebilirlik | Milyonlarca | Milyonlarca | Milyarlarca |
| Maliyet | Ücretsiz | $$$$ | $$$ |


## 📚 Örnekler

[examples/](examples/) dizinine göz atın:
- Wikipedia dökümlerinden hafıza oluşturma
- Kişisel bilgi tabanı oluşturma
- Çok dilli destek
- Gerçek zamanlı hafıza güncellemeleri
- Popüler LLM'lerle entegrasyon

## 🆘 Yardım Alma

- 📖 [Dokümantasyon](https://github.com/olow304/memvid/wiki) - Kapsamlı rehberler
- 💬 [Tartışmalar](https://github.com/olow304/memvid/discussions) - Sorularınızı sorun
- 🐛 [Hata Takibi](https://github.com/olow304/memvid/issues) - Hataları bildirin
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - Projelerinizi paylaşın

## 🔗 Linkler

- [GitHub Deposu](https://github.com/olow304/memvid)
- [PyPI Paketi](https://pypi.org/project/memvid)
- [Değişiklik Günlüğü](https://github.com/olow304/memvid/releases)


## 📄 Lisans

MIT Lisansı - Detaylar için [LICENSE](LICENSE) dosyasına bakın.

## 🙏 Teşekkürler

[Olow304](https://github.com/olow304) ve Memvid topluluğu tarafından oluşturuldu.

Şunlarla ❤️ ile geliştirildi:
- [sentence-transformers](https://www.sbert.net/) - Anlamsal arama için son teknoloji gömüler
- [OpenCV](https://opencv.org/) - Bilgisayarla görme ve video işleme
- [qrcode](https://github.com/lincolnloop/python-qrcode) - QR kod oluşturma
- [FAISS](https://github.com/facebookresearch/faiss) - Verimli benzerlik arama
- [PyPDF2](https://github.com/py-pdf/pypdf) - PDF metin çıkarımı

Memvid'i daha iyi hale getiren tüm katkıcılara özel teşekkürler!

---

**Yapay zeka hafıza yönetiminizde devrim yaratmaya hazır mısınız? Memvid'i kurun ve hemen başlayın!** 🚀
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---