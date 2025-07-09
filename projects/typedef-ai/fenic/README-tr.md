<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic: LLM çıkarımı için (yeniden) inşa edilen dataframe

[![PyPI version](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Python versions](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![License](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **Dokümantasyon**: [docs.fenic.ai](https://docs.fenic.ai/)

fenic, typedef.ai tarafından geliştirilen, PySpark'tan ilham alan, görüş bildiren bir DataFrame framework'üdür ve AI ile ajan temelli uygulamalar inşa etmek için tasarlanmıştır. Yapısal ve yapısal olmayan verileri, veri çerçevesi üzerinde alışık olduğunuz işlemleri semantik zekâ ile birleştirerek içgörüye dönüştürün. Markdown, transkriptler ve semantik operatörler için birinci sınıf destekle birlikte, herhangi bir model sağlayıcıda verimli toplu çıkarım imkânı sunar.
## Kurulum

fenic Python `[3.10, 3.11, 3.12]` sürümlerini destekler

```bash
pip install fenic
```

### LLM Sağlayıcı Kurulumu

fenic, en az bir LLM sağlayıcısından bir API anahtarı gerektirir. Seçtiğiniz sağlayıcı için uygun ortam değişkenini ayarlayın:

```bash
# OpenAI için
export OPENAI_API_KEY="openai-api-anahtarınız"

# Anthropic için
export ANTHROPIC_API_KEY="anthropic-api-anahtarınız"

# Google için
export GEMINI_API_KEY="your-google-api-key"
```

## Hızlı Başlangıç

Fenic hakkında bilgi edinmenin en hızlı yolu, örneklere göz atmaktır.

Aşağıda bu repodaki örneklerin hızlı bir listesi bulunmaktadır:

| Örnek                                                                  | Açıklama                                                                                                                            |
| ---------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| [Hello World!](examples/hello_world)                                   | Fenic'in temel operatörleriyle hata günlükleri üzerinden anlamsal çıkarım ve sınıflandırmaya giriş.                                |
| [Enrichment](examples/enrichment)                                      | Şablon tabanlı metin çıkarımı, join işlemleri ve LLM destekli dönüşümlerin günlük zenginleştirme üzerinden gösterildiği çok aşamalı DataFrame'ler. |
| [Toplantı Transkripti İşleme](examples/meeting_transcript_processing)  | Toplantı analiziyle yerel transkript ayrıştırma, Pydantic şeması entegrasyonu ve karmaşık toplulaştırma işlemleri.                  |
| [Haber Analizi](examples/news_analysis)                                | Anlamsal operatörler ve yapılandırılmış veri işleme kullanarak haber makalelerinden içgörülerin analiz edilmesi ve çıkarılması.     |
| [Podcast Özetleme](examples/podcast_summarization)                     | Konuşmacı farkındalığıyla podcast transkriptlerini işleyip özetleyin ve anahtar noktaları çıkarın.                                 |
| [Anlamsal Join](examples/semantic_joins)                               | Basit benzerlik eşleştirmesi yerine fenic'in güçlü anlamsal join işlevini kullanarak tablolar arasında veri eşleştirin.            |
| [Adlandırılmış Varlık Tanıma](examples/named_entity_recognition)       | Metinden adlandırılmış varlıkları anlamsal çıkarım ve sınıflandırma ile çıkarın ve sınıflandırın.                                   |
| [Markdown İşleme](examples/markdown_processing)                        | Markdown belgelerini yapılandırılmış veri çıkarımı ve biçimlendirme ile işleyip dönüştürün.                                         |
| [JSON İşleme](examples/json_processing)                                | Karmaşık JSON veri yapılarını anlamsal işlemler ve şema doğrulama ile yönetin.                                                     |
| [Geri Bildirim Kümeleme](examples/feedback_clustering)                 | Anlamsal benzerlik ve kümeleme işlemleri kullanarak geri bildirimleri gruplayın ve analiz edin.                                    |
| [Belge Çıkarımı](examples/document_extraction)                         | Anlamsal operatörler kullanarak çeşitli belge formatlarından yapılandırılmış bilgi çıkarın.                                        |

(Yukarıdaki herhangi bir örneğe tıklayarak doğrudan ilgili klasöre gidebilirsiniz.)
## Neden fenic kullanmalı?

fenic, üretim amaçlı AI ve ajan tabanlı uygulamalar oluşturmak için PySpark'tan ilham alan, görüş sahibi bir DataFrame framework'üdür.

Geleneksel, LLM’ler için sonradan uyarlanmış veri araçlarının aksine, fenic’in sorgu motoru sıfırdan çıkarım (inference) göz önünde bulundurularak inşa edilmiştir.

Yapılandırılmış ve yapılandırılmamış verileri, semantik zekâ ile güçlendirilmiş, alışılmış DataFrame işlemleriyle içgörülere dönüştürün. Markdown, transkriptler ve semantik operatörler için birinci sınıf destek ile, herhangi bir model sağlayıcıda verimli toplu çıkarım (batch inference) imkanı sunar.

fenic, geleneksel veri boru hatlarının güvenilirliğini AI iş yüklerine taşır.

### Temel Özellikler

#### LLM Çıkarımı İçin Özel Olarak Tasarlandı

- AI iş yükleri için sıfırdan tasarlanmış sorgu motoru, sonradan uyarlanmış değildir
- API çağrıları için otomatik toplu optimizasyon
- Dahili yeniden deneme mantığı ve hız sınırlama
- Token sayımı ve maliyet takibi

#### Semantik Operatörler Birinci Sınıf Vatandaşlar Olarak
- `semantic.analyze_sentiment` - Yerleşik duygu analizi
- `semantic.classify` - Az örnekli örneklerle metni kategorize etme
- `semantic.extract` - Yapısız metni şemalarla yapılandırılmış veriye dönüştürme
- `semantic.group_by` - Verileri anlamsal benzerliğe göre gruplandırma
- `semantic.join` - DataFrame'leri sadece değerlerle değil, anlamla birleştirme
- `semantic.map` - Doğal dil dönüşümleri uygulama
- `semantic.predicate` - Satırları filtrelemek için doğal dil kullanarak koşullar oluşturma
- `semantic.reduce` - Gruplandırılmış verileri LLM işlemleriyle toplama

#### Yerel Yapısız Veri Desteği

Tipik çok modlu veri türlerinin (ses, görseller) ötesine geçerek, metin ağırlıklı iş yükleri için özel türler oluşturur:

- Birinci sınıf bir veri türü olarak Markdown ayrıştırma ve çıkarımı
- Konuşmacı ve zaman damgası farkındalığı ile transkript işleme (SRT, genel formatlar)
- İç içe veriler için JQ ifadeleriyle JSON işleme
- Uzun belgeler için yapılandırılabilir örtüşme ile otomatik metin parçalama

#### Üretime Hazır Altyapı
- Çoklu sağlayıcı desteği (OpenAI, Anthropic, Gemini)
- Yerel ve bulut tabanlı yürütme altyapıları
- Kapsamlı hata yönetimi ve günlükleme
- Tür güvenliği için Pydantic entegrasyonu

#### Tanıdık DataFrame API’si

- PySpark ile uyumlu işlemler
- Tembel değerlendirme ve sorgu optimizasyonu
- Karmaşık sorgular için SQL desteği
- Mevcut veri hatlarıyla sorunsuz entegrasyon

### Neden LLM ve Ajanik Uygulamalar için DataFrame’ler?

Yapay zeka ve ajanik uygulamalar temelde ardışık düzenler ve iş akışlarıdır — tam olarak DataFrame API’lerinin yönetmek için tasarlandığı şey. Veri dönüştürme, filtreleme ve toplama için kalıpları yeniden icat etmek yerine, fenic onlarca yıllık kanıtlanmış mühendislik uygulamalarından yararlanır.

#### Daha İyi Ajanlar İçin Ayrık Mimariler

fenic, ağır çıkarım görevleri ile gerçek zamanlı ajan etkileşimleri arasında net bir ayrım oluşturur. Toplu işlemeyi ajan çalışma zamanının dışına taşıyarak şunları elde edersiniz:

- Daha öngörülebilir ve duyarlı ajanlar
- Toplu LLM çağrılarıyla daha iyi kaynak kullanımı
- Planlama/orkestrasyon ile yürütme arasında daha temiz bir ayrım
#### Tüm Mühendisler için Tasarlandı

DataFrame'ler sadece veri uygulayıcıları için değildir. Akıcı ve bileşenlere ayrılabilir API tasarımı, her mühendisin erişebileceği şekilde sunulmuştur:

- İşlemleri doğal olarak zincirleyin: `df.filter(...).semantic.group_by(...)`
- İmperatif ve deklaratif stilleri sorunsuzca birleştirin
- pandas/PySpark veya SQL'den tanıdık kalıplarla hızlıca başlayın

## Destek

[Discord](https://discord.gg/GdqF3J7huR) topluluğumuza katılarak diğer kullanıcılarla bağlantı kurabilir, sorular sorabilir ve fenic projelerinizde yardım alabilirsiniz. Topluluğumuz yeni gelenleri her zaman memnuniyetle karşılar!

Eğer fenic'i faydalı buluyorsanız, bu depoda en üstte bir ⭐ vermeyi düşünebilirsiniz. Desteğiniz, framework'ü herkes için büyütmemize ve geliştirmemize yardımcı olur!

## Katkıda Bulunma

Her türlü katkıya açığız! Kod yazmak, dokümantasyonu geliştirmek, özellikleri test etmek veya yeni fikirler önermekle ilgileniyorsanız, yardımınız bizim için değerlidir.

Kod değişiklikleri yapmayı planlayan geliştiricilerin, Pull Request oluşturmadan önce fikirlerini tartışmak üzere bir issue açmalarını öneririz. Bu, projenin yönüyle uyumun sağlanmasına ve yinelenen çabaların önlenmesine yardımcı olur.

Geliştirme süreci ve proje kurulumu hakkında detaylı bilgi için lütfen [katkı yönergelerimize](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md) başvurun.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---