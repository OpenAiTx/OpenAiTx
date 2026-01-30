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

**Şeffaf olmayan ajan uygulamaları arasında iletişim ve birlikte çalışabilirlik sağlayan açık bir protokol.**

Agent2Agent (A2A) protokolü, AI dünyasındaki kritik bir sorunu ele alır: Farklı şirketler tarafından çeşitli çerçevelerde, ayrı sunucularda çalışan üretken AI ajanlarının, yalnızca birer araç olarak değil, ajanlar olarak etkili bir şekilde iletişim kurmasını ve iş birliği yapmasını sağlamak. A2A, ajanlar için ortak bir dil sunarak daha bağlı, güçlü ve yenilikçi bir AI ekosistemi oluşturmayı hedefler.

A2A ile ajanlar şunları yapabilir:

- Birbirlerinin yeteneklerini keşfedebilirler.
- Etkileşim biçimlerini müzakere edebilirler (metin, formlar, medya).
- Uzun süreli görevlerde güvenli bir şekilde iş birliği yapabilirler.
- Dahili durumlarını, hafızalarını veya araçlarını ifşa etmeden çalışabilirler.

## A2A Tanıtım Videosu

[![A2A Tanıtım Videosu](https://img.youtube.com/vi/Fbr_Solax1w/hqdefault.jpg)](https://goo.gle/a2a-video)

## Neden A2A?

AI ajanları yaygınlaştıkça, birlikte çalışabilirlikleri karmaşık, çok işlevli uygulamalar oluşturmak için kritik önem taşır. A2A şunları amaçlar:

- **Silo Engellerini Kaldırır:** Farklı ekosistemlerdeki ajanları birbirine bağlar.
- **Karmaşık İş Birliği Sağlar:** Uzmanlaşmış ajanların, tek bir ajanın başaramayacağı görevlerde birlikte çalışmasına olanak tanır.
- **Açık Standartları Destekler:** Yeniliği ve geniş çapta benimsemeyi teşvik eden, topluluk odaklı bir ajan iletişimi yaklaşımını teşvik eder.
- **Şeffaf Olmamayı Korumak:** Ajanların dahili hafızalarını, özel mantıklarını veya belirli araç uygulamalarını paylaşmadan iş birliği yapmasına olanak tanır; böylece güvenliği artırır ve fikri mülkiyeti korur.

### Temel Özellikler

- **Standartlaştırılmış İletişim:** HTTP(S) üzerinden JSON-RPC 2.0.
- **Ajan Keşfi:** Yetenekleri ve bağlantı bilgisini içeren "Ajan Kartları" aracılığıyla.
- **Esnek Etkileşim:** Eş zamanlı istek/yanıt, akış (SSE) ve asenkron itme bildirimlerini destekler.
- **Zengin Veri Alışverişi:** Metin, dosya ve yapılandırılmış JSON verisini işler.
- **Kurumsal Kullanıma Hazır:** Güvenlik, kimlik doğrulama ve gözlemlenebilirlik dikkate alınarak tasarlanmıştır.

## Başlarken
- 📚 **Dokümantasyonu Keşfedin:** Tam bir genel bakış, eksiksiz protokol spesifikasyonu, eğitimler ve kılavuzlar için [Agent2Agent Protokol Dokümantasyon Sitesi](https://a2a-protocol.org) adresini ziyaret edin.
- 📝 **Spesifikasyonu Görüntüleyin:** [A2A Protokol Spesifikasyonu](https://a2a-protocol.org/latest/specification/)
- SDK'ları kullanın:
    - [🐍 A2A Python SDK](https://github.com/a2aproject/a2a-python) `pip install a2a-sdk`
    - [🐿️ A2A Go SDK](https://github.com/a2aproject/a2a-go) `go get github.com/a2aproject/a2a-go`
    - [🧑‍💻 A2A JS SDK](https://github.com/a2aproject/a2a-js) `npm install @a2a-js/sdk`
    - [☕️ A2A Java SDK](https://github.com/a2aproject/a2a-java) maven ile kullanılır
    - [🔷 A2A .NET SDK](https://github.com/a2aproject/a2a-dotnet) [NuGet](https://www.nuget.org/packages/A2A) ile `dotnet add package A2A`
- 🎬 A2A'yı çalışırken görmek için [örneklerimizi](https://github.com/a2aproject/a2a-samples) kullanın

## Katkıda Bulunun

A2A protokolünü geliştirmek ve evrimleştirmek için topluluk katkılarını memnuniyetle karşılıyoruz!

- **Sorular & Tartışmalar:** [GitHub Discussions](https://github.com/a2aproject/A2A/discussions) bölümüne katılın.
- **Sorunlar & Geri Bildirim:** [GitHub Issues](https://github.com/a2aproject/A2A/issues) üzerinden sorun bildirin veya iyileştirme önerin.
- **Katkı Kılavuzu:** Katkıda bulunmak için ayrıntılar [CONTRIBUTING.md](https://raw.githubusercontent.com/a2aproject/A2A/main/CONTRIBUTING.md) dosyasında.
- **Özel Geri Bildirim:** Bu [Google Formu](https://goo.gle/a2a-feedback) üzerinden gönderin.
- **Partner Programı:** Google Cloud müşterileri bu [form](https://goo.gle/a2a-partner) üzerinden partner programına katılabilir.

## Sırada Ne Var

### Protokol Geliştirmeleri

- **Ajan Keşfi:**
    - Yetkilendirme şemalarının ve isteğe bağlı kimlik bilgilerinin doğrudan `AgentCard` içerisine eklenmesini resmileştirin.
- **Ajan İşbirliği:**
    - Desteklenmeyen veya beklenmeyen yetenekleri dinamik olarak kontrol etmek için `QuerySkill()` yöntemini araştırın.
- **Görev Yaşam Döngüsü & Kullanıcı Deneyimi:**
    - Bir görev _içinde_ dinamik kullanıcı deneyimi müzakeresini destekleyin (ör. ajan konuşma sırasında ses/görüntü ekliyor).
- **İstemci Yöntemleri & Taşıma:**
    - İstemci başlatmalı yöntemlere destek genişletilmesini keşfedin (görev yönetiminin ötesinde).
    - Akış güvenilirliği ve anlık bildirim mekanizmalarında iyileştirmeler.

## Hakkında

A2A Protokolü, Google tarafından katkıda bulunulan ve Linux Foundation bünyesinde açık kaynaklı bir projedir. [Apache License 2.0](LICENSE) ile lisanslanmıştır ve topluluk katkılarına açıktır.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---