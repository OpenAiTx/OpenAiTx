# Agent2Agent (A2A) Örnekleri

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Firebase Studio'da Dene"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 Dil</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
    </div>
  </details>
</div>

[Agent2Agent (A2A) Protokolü](https://goo.gle/a2a) için resmi kod örnekleri ve demolarına hoş geldiniz.

Sizi burada görmekten çok mutluyuz! İster çoklu ajan mimarilerini ilk kez keşfediyor olun, ister gelişmiş birlikte çalışabilir ajan ağları inşa ediyor olun, bu depo gelişiminizi hızlandırmak için basit, ilham verici ve erişilebilir öğrenim kaynakları sunar.

## Neden Agent2Agent?

Farklı yapay zeka çerçeveleri ve ekosistemlerin olduğu bir dünyada, ajanların güvenli bir şekilde iletişim kurmak, iş birliği yapmak ve görevleri devretmek için ortak bir dile ihtiyacı vardır. A2A protokolü, çoklu ajan birlikte çalışabilirliği için standartlaştırılmış, açık bir standart oluşturur.

Örneklerimiz, karmaşık çoklu ajan problemlerinin farklı diller ve ana uygulamalar arasında ne kadar kolay çözülebileceğini gösteriyor.

## Hızlı Başlangıç

Bir Helloworld ajanı başlatarak ve Python CLI ana bilgisayarımız aracılığıyla onunla iletişim kurarak hemen çalışmaya başlayın.

1. **Ajan Sunucusunu Başlatın**:
   Bir terminal açın ve Helloworld ajan sunucusunu başlatın:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **Ana Bilgisayar İstemcisini Çalıştırın**:
   İkinci bir terminal açın ve bir görevi ajana göndermek için CLI istemcisini çalıştırın:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## Depo Yapısı

Depo, dile göre birkaç ana dizine ayrılmıştır:

| Dizin | Açıklama |
| --- | --- |
| [samples](/samples) | Programlama diline göre organize edilmiş temel A2A örnekleri. |
| [samples/python](/samples/python) | A2A Python SDK kullanılarak Python ajan uygulamalarını gösterir. |
| [samples/go](/samples/go) | A2A Go SDK kullanılarak Go ajan uygulamalarını gösterir. |
| [samples/dotnet](/samples/dotnet) | A2A .NET SDK kullanılarak C# ajan uygulamalarını gösterir. |
| [samples/java](/samples/java) | A2A Java SDK kullanılarak Java ajan uygulamalarını gösterir. |
| [samples/js](/samples/js) | A2A JavaScript SDK kullanılarak Node.js ajan uygulamalarını gösterir. |

## Katkıda Bulunmak

Her seviyeden katkıyı memnuniyetle karşılıyor ve teşvik ediyoruz! Yeni bir örnek fikriniz, bir hata düzeltmeniz veya dokümantasyon iyileştirmeniz varsa, lütfen [Katkı Rehberimize](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md) göz atın.

## Yardım Alma

Hoş ve destekleyici bir topluluk sağlamaya kararlıyız. Sorularınız, geri bildiriminiz veya herhangi bir sorununuz varsa lütfen [issue sayfamızdan](https://github.com/a2aproject/a2a-samples/issues) bizimle iletişime geçin.

## İlgili Depolar

| Depo | Kategori | Açıklama |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | Temel Spesifikasyon | A2A Spesifikasyonu ve dokümantasyonu. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | Araçlar | A2A özellikli ajanları incelemek için UI aracı. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | Test | A2A Protokol uyumluluğunu doğrulamak için test paketi. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | Test | Çoklu geçiş modeli ve çeşitli taşıma protokolleri kullanarak farklı A2A SDK uygulamaları ve sürümleri arasında uyumluluğu doğrulamak için araç seti. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | A2A için resmi Python SDK'sı. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | A2A için resmi Go SDK'sı. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | A2A için resmi Java SDK'sı. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | A2A için resmi Node.js/JavaScript SDK'sı. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | A2A için resmi C#/.NET SDK'sı. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | A2A için resmi Rust SDK'sı. |

## Feragatname

**Önemli:** Sağlanan örnek kod yalnızca gösterim amaçlıdır ve mekaniklerini açıklar
Agent-to-Agent (A2A) protokolü. Üretim uygulamaları geliştirirken, doğrudan kontrolünüz dışında çalışan herhangi bir ajanı potansiyel olarak güvenilmeyen bir varlık olarak ele almak kritik öneme sahiptir.

Harici bir ajandan alınan tüm veriler—AgentCard, mesajlar, artefaktlar ve görev durumları dahil ancak bunlarla sınırlı olmamak üzere—güvenilmeyen girdi olarak işlenmelidir. Örneğin, kötü niyetli bir ajan, alanlarında hazırlanmış veriler içeren bir AgentCard sağlayabilir (örneğin, açıklama, ad, skills.description). Bu veriler, Büyük Dil Modeli (LLM) için istemler oluşturmakta arındırılmadan kullanılırsa, uygulamanızı istem enjeksiyon saldırılarına açık hale getirebilir. Bu veriler kullanılmadan önce doğru şekilde doğrulanmaz ve arındırılmazsa, uygulamanızda güvenlik açıkları oluşturabilir.

> Geliştiriciler, sistemlerini ve kullanıcılarını korumak için girdi doğrulama ve kimlik bilgilerini güvenli şekilde işleme gibi uygun güvenlik önlemlerini uygulamaktan sorumludur.










---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---