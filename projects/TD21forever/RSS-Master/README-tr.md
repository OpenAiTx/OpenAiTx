# RSS-Master

RSS kaynakları için özelleştirilmiş filtreleme, sıralama, AI ile özetleme, genelleme ve puanlama. Performans iyileştirilmiş sürüm, asenkron işlem ve paralel AI özetlemeyi destekler.

### Önsöz

Eylül başında, ilgilendiğim RSS kaynaklarını toplamak ve abone olmak için Inoreader + RSSHub kullanmaya başladım. Reeder ile birlikte günlük bilgi giriş kaynaklarını tamamen kontrol etmeye çalıştım. Bir ay geçtikten sonra, giderek artan RSS kaynakları ve okunmamış içerikler, bana okuma endişesi yarattı. Bu yüzden, bazı özelleştirilmiş filtreleme kuralları uygulayabileceğim, tercihen AI ile okuma desteği sağlayan bir yöntem olup olmadığını düşündüm.

Inoreader kendi filtreleme özelliğine sahip, ancak sadece bu özellik için ödeme yapmak pek mantıklı gelmedi; NewsBlur "Intelligence Trainer" ile akıllı sınıflandırma yapıyor, ancak denediğimde geri bildirim etkili değildi ve kısa sürede akıllılık hissedilmiyordu; Feedly hem filtreleme hem AI özelliklerini sunuyor, ihtiyaçlarımı karşılıyor gibi görünüyordu. Inoreader'dan Feedly'nin ücretli kullanıcılarına geçmeyi düşünürken, şu iki projeyi gördüm:

- [ChatGPT ile Hacker News Özetleme](https://blog.betacat.io/post/2023/06/summarize-hacker-news-by-chatgpt/)
- [RSS-GPT Kullanım Kılavuzu](http://yinan.me/rss-gpt-manual-zh.html)

Bu iki projenin genel yaklaşımı, GitAction ile bir betik çalıştırıp bilgileri alarak Open AI API kullanarak çeviri, özetleme yapıp şablonlara dönüştürmek ve GitHub Page üzerinde dağıtmak. RSS-GPT'nin yaklaşımı benim ihtiyacımı daha çok karşılıyor; zamanlanmış betik ile doğrudan RSS'nin xml dosyasını alıp işleyip GitHub Page'de yayınlıyor, böylece bu xml dosyasına erişim linki elde ediliyor ve okuyucu bu linki doğrudan abonelik için kullanabiliyor.

Inoreader'ın çoklu cihaz senkronizasyonuna büyük ihtiyacım var, config yapılandırma dosyasına eklenen RSS kaynaklarının Inoreader'a senkronizasyon için zamanında bildirilmesi gerekiyor. Bu yüzden [RSS-GPT](https://github.com/yinan-c/) yaklaşımını geliştirerek RSS-Master adını verdim.

### Özellikler

- **Paralel İşlem Desteği**: RSS kaynakları ve AI özetleme için asenkron ve thread pool kullanarak paralel işlem, işlem hızında belirgin artış
- **Gelişmiş Önbellekleme Mekanizması**: Daha stabil önbellek sistemi, veri kaybını önler ve tekrar erişim performansını artırır
- **Gelişmiş Hata Yönetimi**: Tüm işlemler tam hata yönetimi ve log kaydı ile desteklenir, stabilite artar
- **HTML İçerik Optimizasyonu**: Makale içeriğini akıllıca çıkarır, alakasız bilgileri göz ardı eder, AI özet kalitesini artırır
- **En Güncel OpenAI API Desteği**: En son OpenAI API sürümüyle tam uyumlu
- **Detaylı İstatistikler**: İşlem sonrası çalışma süresi, başarı oranı ve maliyet istatistikleri sağlar
- **opml Dosyası Oluşturma Desteği**: Ayrıca config.yml ile karşılıklı dönüşüm: `script/convert_opml_to_yaml.sh` `script/convert_yaml_to_opml.sh`
- **Özelleştirilebilir Filtre Kuralları**: include, exclude tipleri; title ve article kapsamları desteklenir
- **Özelleştirilebilir AI Modeli**: Farklı OpenAI modellerini çevresel değişkenle yapılandırma
- **Özelleştirilebilir Temel URL**: RSS dosyalarının temel erişim URL'si ayarlanabilir, farklı ortamlarda dağıtımı kolaylaştırır
- **Etkileşimli Test Not Defteri**: Çeşitli fonksiyonları test etmek için Jupyter not defteri sağlar

### Çevresel Değişkenler Yapılandırması

Proje, `.env` dosyası ile aşağıdaki parametreleri yapılandırmayı destekler:

```
# Gerekli Parametreler
OPENAI_API_KEY=your_openai_api_key_here

# Opsiyonel Parametreler
RSS_BASE_URL=https://example.com/rss-feeds/  # RSS temel URL
OPENAI_MODEL=gpt-4o-mini-2024-07-18          # OpenAI modeli
LOG_LEVEL=INFO                               # Log seviyesi
PARALLEL_WORKERS=5                           # Paralel işlem sayısı
```

`.env.example` dosyasını kopyalayıp `.env` olarak yeniden adlandırabilir ve parametre değerlerini değiştirebilirsiniz.

### Performans İyileştirmeleri

Bu sürüm, orijinal sürüme göre şu performans iyileştirmelerine sahiptir:

1. **RSS Kaynak Paralel İşleme**: `asyncio` ile aynı anda birden fazla RSS kaynağı işlenir
2. **AI Özetleme Paralelleştirme**: Thread pool ile çoklu makale AI özetleri eş zamanlı işlenir
3. **Metin İşleme Optimizasyonu**: HTML içerik çıkarma algoritması geliştirilmiş, makale ana içeriği daha akıllıca seçilir
4. **Güvenli Dosya İşleme**: Program çökmesi sonucu veri kaybını önlemek için güvenli dosya yazma mekanizması kullanılır
5. **Bellek Kullanımı Optimizasyonu**: Veri yapıları ve işlem akışı optimize edilerek bellek kullanımı azaltılmıştır

### Kullanım Talimatları

1. Projeyi yerel makinenize klonlayın
2. Bağımlılıkları yükleyin: `pip install -r requirements.txt`
3. `.env` dosyası oluşturup OpenAI API anahtarınızı ayarlayın: `OPENAI_API_KEY=anahtarınız`
4. `resource/config.yml` dosyasını düzenleyerek RSS kaynaklarınızı yapılandırın
5. `python main.py` komutuyla işleme başlayın

### Test ve Hata Ayıklama

Proje, çeşitli fonksiyonları test etmek için etkileşimli `test.ipynb` Jupyter not defterini sağlar:

1. RSS kaynak alma ve çözümleme
2. Filtre fonksiyonları
3. AI özet fonksiyonu
4. Önbellekleme mekanizması
5. Özelleştirilebilir temel URL
6. Performans testi

Kullanımı:

```bash
# Jupyter yükle
pip install jupyter

# Not defterini başlat
jupyter notebook test.ipynb
```

### Özelleştirilmiş Filtre Kuralları Örneği

```yaml
- htmlUrl: http://www.smzdm.com
  name: c5738f
  text: 什么值得买 | 优惠精选
  url: http://feed.smzdm.com
  filters:
    - type: include
      field: title
      keywords:
        [
          '可乐',
          '雪碧',
          '芬达',
          '柠檬',
          '茶叶',
          '纸巾',
          '酒精',
          '湿纸巾',
          '餐巾纸',
        ]
```

### Kullanım Ekran Görüntüleri

- AI özet ve genelleme fonksiyonu

<div style="display: flex;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/202310031757486.png" alt="image-20231003174334231" style="width: 45%;">
    <img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/202310031757686.png" alt="image-20231003175143405" style="width: 45%;">
</div>

- Özelleştirilmiş filtre: "什么值得买" iyi fiyat kanalını filtreleyip sadece yakın zamanda stoklanmak istenen ürünleri önerir, örneğin gazlı içecekler

<img src="https://raw.githubusercontent.com/TD21forever/RSS-Master/main/%E4%BB%80%E4%B9%88%E5%80%BC%E5%BE%97%E4%B9%B0-%E6%B1%BD%E6%B0%B4.png" alt="image-20231003164248923" style="width: 400px; height: 400px;" />

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---