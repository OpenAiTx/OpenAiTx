<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-white.svg">
  <img alt="Velopack Logo" src="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-black.svg" width="400">
</picture>

---

[![Nuget](https://img.shields.io/nuget/v/Velopack?style=flat-square&logo=nuget&logoColor=white)](https://www.nuget.org/packages/Velopack/)
[![Discord](https://img.shields.io/badge/chat-Discord-5865F2?style=flat-square&logo=discord&logoColor=white)](https://discord.gg/M6he8ZPAAJ)
[![Build](https://img.shields.io/github/actions/workflow/status/velopack/velopack/build.yml?branch=develop&style=flat-square&logo=github&logoColor=white)](https://github.com/velopack/velopack/actions)
[![Codecov](https://img.shields.io/codecov/c/github/velopack/velopack?style=flat-square&logo=codecov&logoColor=white)](https://app.codecov.io/gh/velopack/velopack)
[![License](https://img.shields.io/github/license/velopack/velopack?style=flat-square)](https://github.com/velopack/velopack/blob/develop/LICENSE)

Velopack, çapraz platform uygulamalar için bir kurulum ve otomatik güncelleme framework’üdür. Kendi fikirlerine sahip, sıfır yapılandırma ile son derece kolay kullanılır. Sadece tek bir komutla kurulabilir bir uygulamaya sahip olabilirsiniz ve kullanıcılarınız için de son derece hızlıdır.

## Özellikler

- 😍 **Sıfır yapılandırma** – Velopack, derleyici çıktınızı alır ve sadece bir komutla bir yükleyici, güncellemeler, delta paketleri ve kendi kendini güncelleyen taşınabilir paket oluşturur.
- 🎯 **Çapraz platform** – Velopack, **Windows**, **OSX** ve **Linux** için paket oluşturmayı destekler, böylece her hedef için tek bir çözüm kullanabilirsiniz.
- 🚀 **Otomatik geçişler** - Diğer popüler framework’lerden (örn. [Squirrel](https://github.com/Squirrel/Squirrel.Windows)) geliyorsanız, Velopack uygulamanızı otomatik olarak taşıyabilir.
- ⚡️ **Yıldırım hızı** – Velopack, yerel performans için Rust ile yazılmıştır. Delta paketleri sayesinde kullanıcılarınız sadece sürümler arasındaki değişiklikleri indirir.
- 📔 **Dile bağımsız** - C#, C++, JS, Rust ve daha fazlası için destek. Projenizin dili ne olursa olsun güncellemeler için tanıdık bir API kullanın.

https://github.com/velopack/velopack/assets/1287295/0ff1bea7-15ed-42ae-8bdd-9519f1033432

## Dokümantasyon
- 📖 [Belgeleri oku](https://docs.velopack.io/)
- ⚡ [Hızlı başlangıç rehberleri](https://docs.velopack.io/category/quick-start)
- 🕶️ [Örnek uygulamaları görüntüle](https://docs.velopack.io/category/sample-apps)
- 📺 [Web sitesini & demoyu gör](https://velopack.io/)

## Topluluk
- ❓ [Discord](https://discord.gg/CjrCrNzd3F) üzerinden sorular sorabilir, destek alabilir veya fikirleri tartışabilirsiniz.
- 🗣️ [GitHub Issues](https://github.com/velopack/velopack/issues) üzerinden hata bildirebilir veya özellik talebinde bulunabilirsiniz.

## Katkıda Bulunma
- 💬 Geliştirici tartışmalarına katılmak için [Discord](https://discord.gg/CjrCrNzd3F)’a katılın
- 🚦 [Katkı rehberimizi](https://docs.velopack.io/category/contributing) okuyun

## Görüşler 
Artık dışa dönük uygulamamda velopack kullanıyorum. Çok etkilendim. Hem ilk derlemede hem de son kullanıcının makinesindeki yazılımın yükseltilmesinde Squirrel’dan çok daha hızlı ve kusursuz çalışıyor gibi görünüyor. Harika ve 30 yıldan uzun süredir kullandığım en iyi yükleyici. Çok teşekkürler! Harika bir iş çıkarıyorsunuz!
[- Stefan (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1195642674078830613)

Sadece büyük bir teşekkür etmek istedim. Birkaç yıldır Squirrel.Windows benim için çalışmadığından Clowd.Squirrel kullanıyordum. Bugün o depoya belge aramak için uğradım ve Velopack’in yayınlandığını gördüm. Beklenmedik bir şekilde! Harika çalışıyor ve çok daha hızlı, inanılmaz! Tekrar teşekkürler, Clowd.Squirrel ve Velopack’e harcanan emek inanılmaz. Çok takdir ediyorum.
[- Kizari (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1200837489640878180)

Birçok yükleyici framework’ü kullandım ve Velopack açık ara en iyisi. Her şey sihir gibi: yükleyiciyi çalıştırıyorsunuz ve uygulama hemen açık, kullanıma hazır. Güncellemeler ~2 saniyede UAC uyarısı olmadan uygulanıp yeniden başlatılıyor. Yükleyici oluşturma süreci zahmetsiz ve kod imzalama ile kolayca entegre oluyor, komut satırı aracı updater dosyalarını yüklemeyi basit kılıyor. Farklı bir dilde ayrı yükleyici betikleriyle uğraşmanız gerekmiyor; tüm bu kancaları ana uygulamanıza entegre edebilirsiniz! Destek de mükemmel; tüm endişelerim giderildi. Bu masaüstü yükleyicilerin geleceği.
[- RandomEngy (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1200897478036299861)

Velopack’in sürüm oluşturma, güncellemeleri kontrol etme ve uygulama konusundaki performansından son derece etkilendim. Diğer araçlardan önemli ölçüde daha hızlı. vpk CLI sezgisel ve karmaşık derleme süreçlerimde bile kolayca uygulanabiliyor. Velopack sayesinde iş akışımı kolaylaştırdım ve değerli zaman kazandım. Harika bir araç, kesinlikle tavsiye ederim!
[- khdc (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1216460920696344576)

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---