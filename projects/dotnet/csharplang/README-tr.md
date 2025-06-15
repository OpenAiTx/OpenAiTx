# C# Dil Tasarımı

[![https://gitter.im/dotnet/csharplang adresinde sohbete katılın](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Discord'da Sohbet Edin](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

C# dil tasarımının resmi deposuna hoş geldiniz. Yeni C# dil özelliklerinin geliştirildiği, benimsendiği ve belirtildiği yer burasıdır.

C#, dili uygulayan [Roslyn](https://github.com/dotnet/roslyn) projesiyle yakın koordinasyon içinde C# Dil Tasarım Ekibi (LDT) tarafından tasarlanmıştır.

Şunları bulabilirsiniz:

- [öneriler klasöründe](proposals) aktif C# dil özelliği teklifleri
- [toplantılar klasöründe](meetings) C# dil tasarım toplantılarının notları
- [dil sürüm geçmişinin özetini burada](Language-Version-History.md).

Yukarıdakilerde hatalar veya eksiklikler bulursanız, bunları gündeme getirmek için bir issue bırakın veya daha iyisi: düzeltmek için bir pull request gönderin.

Ancak, *yeni özellik teklifleri* için, lütfen bunları [tartışma](https://github.com/dotnet/csharplang/labels/Discussion) amacıyla gündeme getirin ve yalnızca Dil Tasarım Ekibi'nden (bir "şampiyon") davet alırsanız, bir öneri olarak bir issue veya pull request gönderin.

Tüm tasarım süreci [burada](Design-Process.md) açıklanmıştır. Kısa bir özet aşağıdadır.

## Tartışmalar

Dile ilişkin özelliklerle ilgili tartışmalar bu depoda [Tartışmalar](https://github.com/dotnet/csharplang/discussions) şeklinde yapılır.

Bir özellik önermek, mevcut tasarım notlarını veya tekliflerini tartışmak vb. istiyorsanız, lütfen [yeni bir Tartışma başlığı açın](https://github.com/dotnet/csharplang/discussions/new).

Kısa ve konuya sadık kalan tartışmaların okunma olasılığı daha yüksektir. Eğer ellinci yorumu bırakırsanız, büyük ihtimalle sadece birkaç kişi onu okuyacaktır. Tartışmaların daha kolay gezilebilir ve verimli olması için lütfen şu kurallara dikkat edin:

- Tartışma C# dil tasarımı ile ilgili olmalıdır. Değilse, kısaca kapatılır.
- Tartışmanın kapsamını açıkça belirten açıklayıcı bir konu seçin.
- Tartışmanın konusuna sadık kalın. Bir yorum alakasızsa veya bir alt konuya çok giriyorsa, yeni bir tartışma başlatın ve bağlantı verin.
- Yorumunuz başkaları için okumaya değer mi, yoksa mevcut bir yoruma emoji tepkisiyle yeterince ifade edilebilir mi?

Belirli bir sözdiziminin oluşmasını engelleyen dil önerileri [Roslyn analizörü](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers) ile gerçekleştirilebilir. Mevcut sözdizimini isteğe bağlı olarak yasa dışı kılan öneriler, dil karmaşıklığını artırmamak için dil tasarım komitesi tarafından reddedilecektir.

## Öneriler

C# LDM üyelerinden biri bir önerinin daha geniş ekip tarafından dikkate alınmaya değer olduğunu düşündüğünde, onu [Şampiyon](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22) edebilir, bu da onu C# Dil Tasarım Toplantısı'na getirecekleri anlamına gelir. Öneriler her zaman bağlantılı tartışmalarda görüşülür, şampiyon issue'sunda değil. Bu politikaya her zaman uymadık, bu yüzden birçok şampiyon issue'sunda tartışma bulunabilir; şimdi ise yeni tartışmaların orada yapılmasını engellemek için issue'ları kilitliyoruz. Her şampiyon issue'sunda bir tartışma bağlantısı bulunur.

## Tasarım Süreci

[Öneriler](proposals), [Dil Tasarım Toplantılarında](meetings) alınan kararlarla, [tartışmalar](https://github.com/dotnet/csharplang/discussions), deneyler ve çevrimdışı tasarım çalışmalarıyla birlikte gelişir.

Çoğu durumda, doğru tasarımı bulmak ve özelliğin benimsenip benimsenmeyeceğine karar vermek için bir özelliğin prototipini uygulamak ve paylaşmak gerekecektir. Prototipler, bir özelliğin hem uygulama hem de kullanılabilirlik sorunlarını keşfetmeye yardımcı olur. Bir prototip, [Roslyn deposunun](https://github.com/dotnet/roslyn) bir dalında uygulanmalı ve aşağıdaki kriterleri karşılamalıdır:

- (Uygulanabilirse) Ayrıştırıcı, denemeye karşı dayanıklı olmalıdır: yazma işlemi çökme nedeni olmamalıdır.
- Özelliğin uçtan uca çalıştığını gösteren minimal testler eklenmelidir.
- Minimal IDE desteği olmalıdır (anahtar kelime renklendirme, biçimlendirme, tamamlama).

Bir özellik onaylandıktan sonra, [Roslyn](https://github.com/dotnet/roslyn)'de tam olarak uygulanmalı ve [dil spesifikasyonunda](spec) tam olarak belirtilmelidir; ardından öneri, tamamlanmış bir özellik için uygun klasöre taşınır, ör. [C# 7.1 önerileri](proposals/csharp-7.1).

**UYARI**: Aktif bir öneri, C# programlama dilinin gelecekteki bir sürümüne dahil edilmek üzere aktif olarak değerlendirilmektedir, ancak nihayetinde bir sonraki veya herhangi bir sürüme dahil edileceği kesin değildir. Bir öneri, yukarıdaki sürecin herhangi bir aşamasında tasarım ekibi, topluluk, kod gözden geçirenler veya testlerden gelen geri bildirimlere göre ertelenebilir veya reddedilebilir.

### Kilometre Taşları

Depodaki issue'lar için birkaç farklı kilometre taşımız var:
* [Çalışma Seti](https://github.com/dotnet/csharplang/milestone/19), şu anda aktif olarak üzerinde çalışılan şampiyonlanmış öneriler kümesidir. Bu kilometre taşındaki her şey bir sonraki C# sürümünde yer almayabilir, ancak yaklaşan sürümde tasarım zamanı alacaktır.
* [Beklemede](https://github.com/dotnet/csharplang/milestone/10), şampiyonlanmış, ancak aktif olarak üzerinde çalışılmayan, üçlenmiş öneriler kümesidir. Topluluktan tartışma ve fikirler bu öneriler için memnuniyetle karşılanırken, bu özellikler üzerinde tasarım çalışması ve uygulama incelemesinin maliyeti, topluluk uygulamasını biz hazır olana kadar değerlendiremeyeceğimiz kadar yüksektir.
* [Herhangi Bir Zaman](https://github.com/dotnet/csharplang/milestone/14), şampiyonlanmış, üçlenmiş ancak aktif olarak üzerinde çalışılmayan ve topluluk uygulamasına açık öneriler kümesidir. Buradaki issue'lar iki durumda olabilir: onaylanmış spesifikasyon gerekiyor ve uygulama gerekiyor. Spesifikasyon gerektirenler yine de onay için LDM'de sunulmalıdır, ancak bunu en uygun zamanda yapmaya hazırız.
* [Muhtemelen Asla](https://github.com/dotnet/csharplang/milestone/13), LDM'nin dilden reddettiği öneriler kümesidir. Güçlü bir ihtiyaç veya topluluk geri bildirimi olmadıkça, bu öneriler gelecekte değerlendirmeye alınmayacaktır.
* Numaralandırılmış kilometre taşları, belirli bir dil sürümü için uygulanmış özelliklerin kümesidir. Kapalı kilometre taşları için bunlar, o sürümle birlikte yayınlanan şeylerdir. Açık kilometre taşlarında, sürüm yaklaşırken uyumluluk veya başka sorunlar keşfedersek, özellikler daha sonra çıkarılabilir.

## Dil Tasarım Toplantıları

Dil Tasarım Toplantıları (LDM'ler), LDT ve zaman zaman davet edilen konuklar tarafından yapılır ve [toplantılar](meetings) klasöründe yıl bazında düzenlenen Tasarım Toplantı Notları'nda belgelenir. Bir tasarım toplantı notunun yaşam döngüsü [meetings/README.md](meetings/README.md) dosyasında açıklanmıştır. LDM'ler, gelecekteki C# sürümleriyle ilgili kararların alındığı, hangi öneriler üzerinde çalışılacağı, nasıl geliştirileceği ve kabul edilip edilmeyeceği veya ne zaman kabul edileceği konularının karara bağlandığı toplantılardır.

## Dil Spesifikasyonu

Mevcut ECMA-334 spesifikasyonu, [C# Dil Standardı](https://github.com/dotnet/csharpstandard/) deposunda markdown formatında bulunabilir.

## Uygulama

C# dilinin referans uygulaması [Roslyn deposunda](https://github.com/dotnet/roslyn) bulunabilir. Bu depo ayrıca [dil özellikleri için uygulama durumunu](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md) da takip eder. Yakın zamana kadar, dil tasarımına ilişkin öğeler de burada takip ediliyordu. Lütfen aktif önerileri taşırken biraz zaman tanıyın.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---