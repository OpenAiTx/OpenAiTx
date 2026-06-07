# Agent2Agent (A2A) Protokolü

[![PyPI - Sürüm](https://img.shields.io/pypi/v/a2a-sdk)](https://pypi.org/project/a2a-sdk)
[![Apache Lisansı](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE)
<a href="https://codewiki.google/github.com/a2aproject/a2a">
  <img src="https://www.gstatic.com/_/boq-sdlc-agents-ui/_/r/Mvosg4klCA4.svg" alt="Kod Wiki Sor" height="20">
</a>

<div style="text-align: left;">
  <details>
    <summary>🌐 Dil</summary>
    <div>
      <div style="text-align: center;">
        <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=A2A&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<!-- markdownlint-disable MD041 -->
<div style="text-align: center;">
  <div class="centered-logo-text-group">
    <img src="https://raw.githubusercontent.com/a2aproject/A2A/main/docs/assets/a2a-logo-black.svg" alt="Agent2Agent Protokolü Logosu" width="100">
    <h1>Agent2Agent (A2A) Protokolü</h1>
  </div>
</div>

**Şeffaf olmayan ajan uygulamaları arasında iletişim ve birlikte çalışabilirliği mümkün kılan açık bir protokol.**

Agent2Agent (A2A) protokolü, yapay zeka alanında önemli bir sorunu ele alıyor: Farklı şirketler tarafından farklı altyapılar üzerinde, ayrı sunucularda çalışan üretken AI ajanlarının yalnızca araç olarak değil, ajan olarak da etkili bir şekilde iletişim kurup işbirliği yapabilmesini sağlamak. A2A, ajanlar için ortak bir dil sunarak daha bağlantılı, güçlü ve yenilikçi bir yapay zeka ekosistemi oluşturmayı hedefliyor.

A2A ile ajanlar şunları yapabilir:

- Birbirlerinin yeteneklerini keşfedebilir.
- Etkileşim türlerinde (metin, formlar, medya) pazarlık yapabilir.
- Güvenli bir şekilde uzun süreli görevlerde işbirliği yapabilir.
- Dahili durumunu, hafızasını veya araçlarını ifşa etmeden çalışabilir.

## DeepLearning.AI Kursu

[![A2A DeepLearning.AI](https://img.youtube.com/vi/4gYm0Rp7VHc/maxresdefault.jpg)](https://goo.gle/dlai-a2a)

[Google Cloud](https://goo.gle/dlai-a2a) ve IBM Research iş birliğiyle hazırlanan ve [Holt Skinner](https://github.com/holtskinner), [Ivan Nardini](https://github.com/inardini) ve [Sandi Besen](https://github.com/sandijean90) tarafından verilen [A2A: The Agent2Agent Protocol](https://goo.gle/dlai-a2a) adlı kısa kursa katılın.

**Öğrenecekleriniz:**

- **Ajanları A2A-uyumlu yapın:** Google ADK, LangGraph veya BeeAI gibi çerçevelerle oluşturulan ajanları A2A sunucusu olarak açığa çıkarın.
- **Ajanları bağlayın:** Sıfırdan veya entegrasyonlar kullanarak A2A-uyumlu ajanlara bağlanmak için A2A istemcileri oluşturun.
- **İş akışlarını yönetin:** A2A-uyumlu ajanların sıralı ve hiyerarşik iş akışlarını oluşturun.
- **Çoklu ajan sistemleri:** Farklı çerçeveler kullanarak bir sağlık hizmetleri çoklu ajan sistemi oluşturun ve A2A’nın işbirliğini nasıl sağladığını görün.
- **A2A ve MCP:** A2A’nın, ajanların birbirleriyle işbirliği yapmasını nasıl mümkün kılarak MCP’yi tamamladığını öğrenin.

## Neden A2A?

Yapay zeka ajanları daha yaygın hale geldikçe, birlikte çalışabilirlikleri karmaşık ve çok işlevli uygulamalar oluşturmak için kritik önemdedir. A2A’nın amaçları şunlardır:

- **Kapalı ekosistemleri ortadan kaldırmak:** Farklı ekosistemlerdeki ajanları birbirine bağlamak.
- **Karmaşık işbirliğini mümkün kılmak:** Uzmanlaşmış ajanların tek başına çözemeyeceği görevlerde birlikte çalışmasını sağlamak.
- **Açık standartları teşvik etmek:** Ajan iletişimi için topluluk odaklı bir yaklaşımı teşvik ederek yenilik ve geniş çapta benimsenmeyi sağlamak.
- **Şeffaflığı korumak:** Ajanların dahili hafızalarını, özel mantıklarını veya belirli araç uygulamalarını paylaşmadan işbirliği yapmalarını sağlayarak güvenliği ve fikri mülkiyeti korumak.

### Temel Özellikler

- **Standartlaştırılmış İletişim:** HTTP(S) üzerinden JSON-RPC 2.0.
- **Ajan Keşfi:** Yetenekleri ve bağlantı bilgisini detaylandıran "Ajan Kartları" ile.
- **Esnek Etkileşim:** Senkron istek/yanıt, akış (SSE) ve asenkron anlık bildirimleri destekler.
- **Zengin Veri Alışverişi:** Metin, dosya ve yapılandırılmış JSON verilerini işler.
- **Kurumsal Düzeyde:** Güvenlik, kimlik doğrulama ve gözlemlenebilirlik ile tasarlanmıştır.

## Başlarken

- 📚 **Dokümantasyonu Keşfedin:** Tam genel bakış, tüm protokol spesifikasyonu, eğitimler ve rehberler için [Agent2Agent Protokol Dokümantasyon Sitesini](https://a2a-protocol.org) ziyaret edin.
- 📝 **Spesifikasyonu Görüntüleyin:** [A2A Protokol Spesifikasyonu](https://a2a-protocol.org/latest/specification/)
- SDK'ları kullanın:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) maven ile kullanılır
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) [NuGet](https://www.nuget.org/packages/A2A) ile `dotnet add package A2A`
    - [🦀 A2A Rust SDK](https://github.com/a2aproject/a2a-rs) `cargo add a2a-lf`
- 🎬 A2A'nın nasıl çalıştığını görmek için [örneklerimizi](https://github.com/a2aproject/a2a-samples) kullanın

## Katkıda Bulunun

A2A protokolünü geliştirmek ve evrimleştirmek için topluluk katkılarını memnuniyetle karşılıyoruz!

- **Sorular & Tartışmalar:** [GitHub Discussions](https://github.com/a2aproject/A2A/discussions) sayfamıza katılın.
- **Hatalar & Geri Bildirim:** [GitHub Issues](https://github.com/a2aproject/A2A/issues) üzerinden hata bildirin veya iyileştirme önerin.
- **Katkı Rehberi:** Katkı sağlama detayları için [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) dosyamıza bakın.
- **Özel Geri Bildirim:** [Google Formunu](https://goo.gle/a2a-feedback) kullanın.
- **İş Ortağı Programı:** Google Cloud müşterileri [bu form](https://goo.gle/a2a-partner) üzerinden iş ortağı programımıza katılabilir.

## Sırada Ne Var

### Protokol Geliştirmeleri

- **Ajan Keşfi:**
    - Yetkilendirme şemalarının ve isteğe bağlı kimlik bilgilerinin doğrudan `AgentCard` içine dahil edilmesini resmileştir.
- **Ajan İşbirliği:**
    - Desteklenmeyen veya öngörülmeyen yetenekleri dinamik olarak kontrol etmek için bir `QuerySkill()` metodu araştırılacak.
- **Görev Yaşam Döngüsü & UX:**
    - Bir görev _içerisinde_ dinamik UX müzakeresi desteği (örneğin, ajan konuşma sırasında ses/görüntü ekliyor).
- **İstemci Yöntemleri & Taşıma:**
    - İstemci tarafından başlatılan yöntemlere desteğin genişletilmesi (görev yönetiminin ötesinde) araştırılıyor.
    - Akış güvenilirliği ve anlık bildirim mekanizmalarında iyileştirmeler.

## Hakkında

A2A Protokolü, Google tarafından katkı sağlanan, Linux Vakfı altında açık kaynaklı bir projedir. [Apache Lisansı 2.0](LICENSE) ile lisanslanmıştır ve topluluğun katkılarına açıktır.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-07

---