# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## .NET Aspire Nedir?

.NET Aspire, gözlemlenebilir, üretime hazır, bulut tabanlı dağıtık uygulamalar geliştirmek için görüş belirten, buluta hazır bir yığılımdır. .NET Aspire, belirli bulut-yerel konularını ele alan bir dizi NuGet paketi aracılığıyla sunulur. Bulut-yerel uygulamalar genellikle tek, bütünsel bir kod tabanından ziyade küçük, birbirine bağlı parçalardan veya mikro hizmetlerden oluşur. Bulut-yerel uygulamalar genellikle veritabanları, mesajlaşma ve önbellekleme gibi çok sayıda hizmet tüketir.

.NET Aspire aşağıdaki konularda yardımcı olur:

[Orkestrasyon](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire, çoklu proje uygulamalarını ve bunların bağımlılıklarını çalıştırmak ve bağlamak için özellikler sağlar.

[Entegrasyonlar](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): .NET Aspire entegrasyonları, Redis veya Postgres gibi yaygın olarak kullanılan hizmetler için standartlaştırılmış arayüzlere sahip NuGet paketleridir ve uygulamanızla tutarlı ve sorunsuz bir şekilde bağlantı sağlar.

[Araçlar](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire, .NET Aspire uygulamaları oluşturmanıza ve onlarla etkileşim kurmanıza yardımcı olan Visual Studio ve dotnet CLI için proje şablonları ve araç deneyimleriyle birlikte gelir.

Daha fazla bilgi için tam [.NET Aspire genel bakış ve belgeleri](https://learn.microsoft.com/dotnet/aspire/) okuyabilirsiniz. Örnekler için [.NET Aspire örnek deposunu](https://github.com/dotnet/aspire-samples) inceleyebilirsiniz. [eShop örneğini burada](https://github.com/dotnet/eshop), [Azure versiyonunu ise burada](https://github.com/Azure-Samples/eShopOnAzure) bulabilirsiniz.

## Bu depoda neler var?

.NET Aspire uygulama sunucusu, gösterge paneli, servis keşif altyapısı ve tüm .NET Aspire entegrasyonları. Ayrıca proje şablonlarını da içerir.

## En son günlük yapıları kullanmak

.NET Aspire'ı en son günlük yapısıyla kullanmaya başlamak için [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md) dosyasındaki talimatları takip edin.

## Nasıl katkıda bulunabilirim?

Katkılarınızı memnuniyetle karşılıyoruz! Dünyanın dört bir yanından birçok kişi .NET'i daha iyi hale getirmek için yardımcı oldu.

Depodaki kodlarla çalışmak için [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md) dosyasındaki talimatları takip edin.

## Güvenlik sorunları ve güvenlik hatalarını bildirme

Güvenlik sorunları ve hataları, gizli olarak Microsoft Güvenlik Yanıt Merkezi'ne (MSRC) <secure@microsoft.com> adresine e-posta yoluyla bildirilmelidir. 24 saat içinde bir yanıt almanız gerekir. Herhangi bir nedenle yanıt alamazsanız, orijinal mesajınızın ulaştığından emin olmak için lütfen tekrar e-posta ile takip edin. Ek bilgiler, MSRC PGP anahtarı dahil, [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue) adresinde bulunabilir. Ayrıca bu talimatları bu deponun [Güvenlik dokümanında](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) da bulabilirsiniz.

Ayrıca ilgili [Microsoft .NET Core ve ASP.NET Core Hata Ödül Programı](https://www.microsoft.com/msrc/bounty-dot-net-core) hakkında bilgiye de göz atabilirsiniz.

### .NET Aspire kaynak ve istemci entegrasyonları tarafından kullanılan konteynerler hakkında not

.NET ekibi, API desteği sağladığımız üçüncü taraf konteynerlerin belirli müşteri gereksinimleri için uygunluğunu değerlendiremez.

Aspire ile birleştirmeyi ve otomatikleştirmeyi seçtiğiniz konteynerlerin, sizin, işvereninizin veya hükümetinizin güvenlik ve emniyet gereksinimlerini, kriptografik düzenlemeleri ve konteyner kullanımınız için geçerli olabilecek diğer düzenleyici veya kurumsal standartları karşıladığından emin olmalısınız.

## .NET Foundation

.NET Aspire bir [.NET Foundation](https://www.dotnetfoundation.org/projects) projesidir.

GitHub'da birçok .NET ile ilgili proje vardır.

* [.NET ana depo](https://github.com/Microsoft/dotnet) - Microsoft ve topluluktan 100'lerce .NET projesine bağlantılar.
* [ASP.NET Core ana sayfa](https://docs.microsoft.com/aspnet/core) - ASP.NET Core hakkında öğrenmeye başlamak için en iyi yer.

Bu proje, topluluğumuzda beklenen davranışları netleştirmek için [Katılımcı Sözleşmesi'nde](https://contributor-covenant.org) tanımlanan davranış kurallarını benimsemiştir. Daha fazla bilgi için [.NET Foundation Davranış Kuralları](https://www.dotnetfoundation.org/code-of-conduct) sayfasına bakabilirsiniz.

## Lisans

Bu depodaki kod, [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT) lisansı ile lisanslanmıştır.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---