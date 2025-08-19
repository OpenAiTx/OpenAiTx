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

Bu depo, [Agent2Agent (A2A) Protokolü](https://goo.gle/a2a) kullanan kod örnekleri ve demoları içermektedir.

## İlgili Depolar

- [A2A](https://github.com/a2aproject/A2A) - A2A Spesifikasyonu ve dokümantasyonu.
- [a2a-python](https://github.com/a2aproject/a2a-python) - A2A Python SDK'sı.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - A2A özellikli ajanları incelemek için UI aracı.

## Katkıda Bulunma

Katkılarınızı bekliyoruz! [Katkı Rehberi](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md) kısmına bakınız.

## Yardım Alma

Öneri, geri bildirim vermek veya hata raporu göndermek için lütfen [sorunlar sayfasını](https://github.com/a2aproject/a2a-samples/issues) kullanınız.

## Yasal Uyarı

Bu depo, resmi olarak desteklenen bir Google ürünü değildir. Bu depodaki kod, yalnızca gösterim amaçlıdır.

Önemli: Sağlanan örnek kod, gösterim amaçlıdır ve Agent-to-Agent (A2A) protokolünün mekaniklerini göstermektedir. Üretim uygulamaları geliştirirken, doğrudan kontrolünüz dışında çalışan her ajanı potansiyel olarak güvenilmez bir varlık olarak ele almak kritik öneme sahiptir.

Harici bir ajandan alınan tüm veriler—AgentCard, mesajlar, artefaktlar ve görev durumları dahil ancak bunlarla sınırlı olmamak üzere—güvenilmez girdi olarak ele alınmalıdır. Örneğin, kötü niyetli bir ajan, alanlarında (örn. açıklama, ad, skills.description) hazırlanmış veri içeren bir AgentCard sağlayabilir. Bu veriler, bir Büyük Dil Modeli (LLM) için istem oluşturmak amacıyla arındırılmadan kullanılırsa, uygulamanızı prompt enjeksiyon saldırılarına açık hale getirebilir. Bu verilerin kullanılmadan önce düzgün şekilde doğrulanmaması ve arındırılmaması uygulamanızda güvenlik açıklarına yol açabilir.

Geliştiriciler, sistemlerini ve kullanıcılarını korumak için uygun güvenlik önlemlerini, örneğin girdi doğrulama ve kimlik bilgilerini güvenli şekilde işleme gibi uygulamakla sorumludur.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---