# Evrensel Araç Çağırma Protokolü (UTCP) Spesifikasyonu

Bu depo, Evrensel Araç Çağırma Protokolü (UTCP) için resmi spesifikasyon dokümantasyonunu içerir. UTCP, çeşitli iletişim protokolleri üzerinden araçların tanımlanması ve etkileşimi için modern, esnek ve ölçeklenebilir bir standarttır.

## UTCP Nedir?

UTCP, AI sistemleri ve diğer istemciler için, kullanılan temel protokolden (HTTP, WebSocket, CLI, vb.) bağımsız olarak farklı sağlayıcılardan araçları keşfetmek ve çağırmak için standartlaştırılmış bir yol sunar. Bu spesifikasyon şunları tanımlar:

- Araç keşif mekanizmaları
- Araç çağırma formatları
- Sağlayıcı yapılandırması
- Kimlik doğrulama yöntemleri
- Yanıt işleme

## Spesifikasyona Katkıda Bulunma

UTCP spesifikasyonuna katkılarınızı memnuniyetle karşılıyoruz! Katkıda bulunmak için:

1. **Depoyu çatallayın**: Spesifikasyon deposunun kendi çatallanmış kopyasını oluşturun
2. **Değişikliklerinizi yapın**: Gerekli dokümantasyonu güncelleyin veya ekleyin
3. **Bir çekme isteği gönderin**: Değişikliklerinizle bir PR açın ve incelemeye sunun
4. **Tartışmalara katılın**: Önerilen değişikliklerle ilgili konuşmalara katılın

Katkıda bulunurken lütfen şu yönergeleri takip edin:

- Değişikliklerinizin UTCP'nin genel vizyonu ve hedefleriyle uyumlu olmasına dikkat edin
- Belirlenmiş dokümantasyon yapısı ve formatına uyun
- Yeni özellikler veya kavramlar eklerken örnekler dahil edin
- Tutarlılığı korumak için ilgili bölümleri güncelleyin

## Dokümantasyonu Yerelde Derleme

### Önkoşullar

Dokümantasyon sitesini yerel olarak derlemek ve önizlemek için şunlara ihtiyacınız olacak:

- Ruby 2.5.0 veya üzeri sürüm
- RubyGems
- Bundler

### Kurulum

1. Depoyu klonlayın:
   ```bash
   git clone https://github.com/universal-tool-calling-protocol/utcp-specification.git
   cd utcp-specification
   ```
2. Bağımlılıkları yükleyin:

   ```bash
   bundle install
   ```
### Dokümantasyon Sitesini Çalıştırma

Siteyi yerel olarak derlemek ve sunmak için:


```bash
bundle exec jekyll serve
```
Bu, belgeleri önizleyebileceğiniz `http://localhost:4000` adresinde yerel bir web sunucusu başlatacaktır.

## Dokümantasyon Yapısı

UTCP dokümantasyonu şu şekilde organize edilmiştir:

- `index.md`: Ana sayfa ve UTCP'ye giriş
- `docs/`
  - `introduction.md`: Ayrıntılı tanıtım ve temel kavramlar
  - `for-tool-providers.md`: Araç sağlayıcılarını uygulama rehberi
  - `for-tool-callers.md`: Araç çağırıcılarını uygulama rehberi
  - `providers/`: Her sağlayıcı türü için dokümantasyon
    - `http.md`: HTTP sağlayıcı
    - `websocket.md`: WebSocket sağlayıcı
    - `cli.md`: CLI sağlayıcı
    - `sse.md`: Sunucu Tarafından Gönderilen Olaylar sağlayıcı
    - vb.
  - `implementation.md`: Uygulama yönergeleri ve en iyi uygulamalar

## Spesifikasyon ile Çalışmak

### Dokümantasyonu Değiştirmek

Dokümantasyon, Jekyll ön ekleriyle birlikte Markdown formatında yazılmıştır. Değişiklik yaparken:

1. Markdown'ınızın belirlenmiş stile uygun olduğundan emin olun
2. Değişiklikleri göndermeden önce yerel olarak önizleyin
3. Örneklerin en son spesifikasyonla güncel olmasına dikkat edin
4. Yeni sayfa ekliyorsanız, `_config.yml` dosyasında gezinme öğelerini güncelleyin

### Dosya Organizasyonu

Yeni dokümantasyon eklerken:

- Sağlayıcıya özgü dokümantasyonu `docs/providers/` dizinine yerleştirin
- Uygun gezinme sırası ile tutarlı ön ek kullanın
- GitHub Pages'te arama kolaylığı için etiketler ekleyin

## Sürüm Kontrolü

UTCP spesifikasyonu, semantik sürümlemeyi takip eder:

- Ana sürümler (1.0, 2.0): Protokole uyumsuz değişiklikler
- Alt sürümler (1.1, 1.2): Geriye dönük uyumlu yeni özellikler
- Yama sürümleri (1.0.1, 1.0.2): Geriye dönük uyumlu hata düzeltmeleri ve netleştirmeler

## Lisans

Bu spesifikasyon, Mozilla Kamu Lisansı 2.0 (MPL-2.0) altında dağıtılmaktadır.

## Ek Kaynaklar

- [UTCP GitHub Organizasyonu](https://github.com/universal-tool-calling-protocol)
- [UTCP Web Sitesi](https://utcp.io)
- [Referans Uygulamalar](https://github.com/universal-tool-calling-protocol/python-utcp)
- [Topluluk Tartışmaları](https://github.com/universal-tool-calling-protocol/utcp-specification/discussions)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---