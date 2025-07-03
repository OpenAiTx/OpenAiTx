# Tome - Sihirli Yapay Zekâ Büyü Kitabı

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>LLM'lerin ve MCP'nin gücünü herkesin eline veren sihirli bir masaüstü uygulaması</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="Join Us on Discord" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="License: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="GitHub Release" /></a>
</p>

<p align="center">
    🔮 Tome Masaüstü Uygulamasını İndirin: <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">Windows</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">MacOS</a>
</p>

# Tome

Tome, **herkesin** LLM'lerin ve MCP'nin sihrini kullanmasını sağlayan bir masaüstü uygulamasıdır. Tome'u indirin, herhangi bir yerel veya uzak LLM'e bağlanın ve binlerce MCP sunucusuna erişerek kendi sihirli yapay zekâ büyü kitabınızı oluşturun.

🫥 %100 yerel, %100 özel mi olmasını istiyorsunuz? Sadece yerel MCP sunucularıyla Ollama ve Qwen3 kullanarak kendi cebinizdeki evrende büyüler yapabilirsiniz. ⚡ En yeni uzak MCP sunucuları ile son teknoloji bulut modellerini mi istiyorsunuz? Onu da yapabilirsiniz. Her şey sizin elinizde!

🏗️ Bu bir Teknik Önizleme'dir, dolayısıyla bazı şeylerin tam olarak oturmamış olabileceğini unutmayın. [Discord'da bize katılın](https://discord.gg/9CH6us29YA) ve karşılaştığınız ipuçlarını, püf noktalarını ve sorunları paylaşın. Bu depoyu yıldızlayarak güncellemelerden ve yeni özelliklerden haberdar olun!

## 🪄 Özellikler

- 🧙 **Kullanıcı Dostu ve Basitleştirilmiş Deneyim**
  - Sadece Tome'u indirip kurun ve istediğiniz LLM'i bağlayın
  - JSON, Docker, python veya node ile uğraşmanıza gerek yok
- 🤖 **Yapay Zekâ Modeli Desteği**
  - **Uzak**: Google Gemini, OpenAI, OpenAI API ile uyumlu herhangi bir uç nokta
  - **Yerel**: Ollama, LM Studio, Cortex, OpenAI API ile uyumlu herhangi bir uç nokta
- 🔮 **Gelişmiş MCP Desteği**
  - MCP sunucularını yüklemek, kaldırmak, açıp kapamak için arayüz
  - npm, uvx, node, python MCP sunucuları kutudan çıktığı gibi desteklenir
- 🏪 **[Smithery.ai](https://smithery.ai) kayıt sistemine entegrasyon**
  - Tek tıkla kurulabilen binlerce MCP sunucusu mevcut
- ✏️ **Bağlam pencerelerinin ve sıcaklığın özelleştirilebilmesi**
- 🧰 **Araç çağrıları ve muhakeme modelleri için yerel destek**
  - Araç çağrılarını ve düşünme mesajlarını açıkça ayıran arayüz iyileştirmeleri

## Demo

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# Başlarken

## Gereksinimler

- MacOS veya Windows (Linux yakında geliyor!)
- Tercih ettiğiniz LLM Sağlayıcısı: [Ollama](https://ollama.com/) veya [Gemini API anahtarı](https://aistudio.google.com/app/apikey) kolay/ücretsizdir
- [Tome'un en son sürümünü indirin](https://github.com/runebookai/tome/releases)

## Hızlı Başlangıç

1. [Tome'u yükleyin](https://github.com/runebookai/tome/releases)
2. Tercih ettiğiniz LLM sağlayıcısını bağlayın - OpenAI, Ollama ve Gemini önceden ayarlanmıştır, ancak LM Studio gibi sağlayıcıları da http://localhost:1234/v1 adresini URL olarak kullanarak ekleyebilirsiniz
3. Tome'da MCP sekmesini açın ve ilk [MCP sunucunuzu](https://github.com/modelcontextprotocol/servers) yükleyin (Başlamak için en kolayı Fetch'tir, sunucu alanına sadece `uvx mcp-server-fetch` yapıştırın).
4. MCP destekli modelinizle sohbet edin! Ondan Hacker News'daki en popüler haberi çekmesini isteyin.

# Vizyon

Yerel LLM'leri ve MCP'yi herkes için erişilebilir kılmak istiyoruz. Bir mühendis, meraklı, hobi sahibi ya da aradaki herhangi biri olsanız da LLM'lerle yaratıcı olmanızı sağlayacak bir araç inşa ediyoruz.

## Temel Prensipler

- **Tome öncelikle yereldir:** Verilerinizin nereye gittiği üzerinde kontrol sizdedir.
- **Tome herkes içindir:** Programlama dilleri, paket yöneticileri veya json yapılandırma dosyalarını yönetmek zorunda kalmamalısınız.

## Sırada Ne Var

Tome'u yayınladıktan sonraki birkaç haftada harika geri bildirimler aldık fakat gelecek için büyük planlarımız var. LLM'leri sohbet kutularının dışına çıkarmak istiyoruz ve bunu başarmanıza yardımcı olacak birçok özellik geliyor.

- Zamanlanmış görevler: LLM'ler siz bilgisayar başında olmasanız bile yararlı işler yapabilmeli.
- Yerel entegrasyonlar: MCP sunucuları araçlara ve bilgilere erişmek için harika bir yol, fakat LLM'lerle benzersiz şekilde etkileşime geçmek için daha güçlü entegrasyonlar eklemek istiyoruz.
- Uygulama oluşturucu: Uzun vadede en iyi deneyimlerin bir sohbet arayüzünde olmayacağına inanıyoruz. Güçlü uygulamalar ve iş akışları oluşturmanızı sağlayacak ek araçlar eklemeyi planlıyoruz.
- ??? Görmek istediğiniz şeyleri bize bildirin! Aşağıdaki bağlantılar aracılığıyla topluluğumuza katılın, sizden haber almak isteriz.

# Topluluk

[Discord](https://discord.gg/9CH6us29YA) [Blog](https://blog.runebook.ai) [Bluesky](https://bsky.app/profile/gettome.app) [Twitter](https://twitter.com/get_tome) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---