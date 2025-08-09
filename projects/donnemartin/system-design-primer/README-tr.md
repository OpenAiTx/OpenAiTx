*[English](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README.md) ∙ [日本語](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-ja.md) ∙ [简体中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-Hans.md) ∙ [繁體中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-TW.md) | [العَرَبِيَّة‎](https://github.com/donnemartin/system-design-primer/issues/170) ∙ [বাংলা](https://github.com/donnemartin/system-design-primer/issues/220) ∙ [Português do Brasil](https://github.com/donnemartin/system-design-primer/issues/40) ∙ [Deutsch](https://github.com/donnemartin/system-design-primer/issues/186) ∙ [ελληνικά](https://github.com/donnemartin/system-design-primer/issues/130) ∙ [עברית](https://github.com/donnemartin/system-design-primer/issues/272) ∙ [Italiano](https://github.com/donnemartin/system-design-primer/issues/104) ∙ [한국어](https://github.com/donnemartin/system-design-primer/issues/102) ∙ [فارسی](https://github.com/donnemartin/system-design-primer/issues/110) ∙ [Polski](https://github.com/donnemartin/system-design-primer/issues/68) ∙ [русский язык](https://github.com/donnemartin/system-design-primer/issues/87) ∙ [Español](https://github.com/donnemartin/system-design-primer/issues/136) ∙ [ภาษาไทย](https://github.com/donnemartin/system-design-primer/issues/187) ∙ [Türkçe](https://github.com/donnemartin/system-design-primer/issues/39) ∙ [tiếng Việt](https://github.com/donnemartin/system-design-primer/issues/127) ∙ [Français](https://github.com/donnemartin/system-design-primer/issues/250) | [Add Translation](https://github.com/donnemartin/system-design-primer/issues/28)*

**Bu rehberi [çevirin](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/TRANSLATIONS.md)!**

# Sistem Tasarımı Primer

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png">
  <br/>
</p>

## Motivasyon

> Büyük ölçekli sistemlerin nasıl tasarlanacağını öğrenin.
>
> Sistem tasarımı mülakatına hazırlanın.

### Büyük ölçekli sistemlerin nasıl tasarlanacağını öğrenin

Ölçeklenebilir sistemlerin nasıl tasarlanacağını öğrenmek daha iyi bir mühendis olmanıza yardımcı olur.

Sistem tasarımı geniş bir konudur.  Web üzerinde **sistem tasarımı prensipleriyle ilgili çok fazla dağınık kaynak** bulunmaktadır.

Bu repo, ölçekli sistemler inşa etmeyi öğrenmenize yardımcı olacak **organize bir kaynak koleksiyonudur**.

### Açık kaynak topluluğundan öğrenin

Bu sürekli güncellenen, açık kaynaklı bir projedir.

[Katkılar](#contributing) memnuniyetle karşılanır!

### Sistem tasarımı mülakatına hazırlanın

Kodlama mülakatlarına ek olarak, sistem tasarımı birçok teknoloji şirketinde **teknik mülakat sürecinin zorunlu bir bileşenidir**.

**Yaygın sistem tasarımı mülakat sorularını çözerek** ve **örnek çözümlerle**: tartışmalar, kod ve diyagramlarla **karşılaştırarak** pratik yapın.

Mülakat hazırlığı için ek başlıklar:

* [Çalışma rehberi](#study-guide)
* [Bir sistem tasarımı mülakat sorusuna nasıl yaklaşılır](#how-to-approach-a-system-design-interview-question)
* [Sistem tasarımı mülakat soruları, **çözümleriyle birlikte**](#system-design-interview-questions-with-solutions)
* [Nesne yönelimli tasarım mülakat soruları, **çözümleriyle birlikte**](#object-oriented-design-interview-questions-with-solutions)
* [Ek sistem tasarımı mülakat soruları](#additional-system-design-interview-questions)

## Anki flash kartları

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/zdCAkB3.png">
  <br/>
</p>

Sunulan [Anki flash kart desteleri](https://apps.ankiweb.net/) anahtar sistem tasarımı kavramlarını akılda tutmanıza yardımcı olmak için aralıklı tekrar kullanır.

* [Sistem tasarımı destesi](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design.apkg)
* [Sistem tasarımı alıştırmaları destesi](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design%20Exercises.apkg)
* [Nesne yönelimli tasarım alıştırmaları destesi](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/OO%20Design.apkg)

Yolda kullanım için harika.

### Kodlama Kaynağı: Etkileşimli Kodlama Zorlukları

[**Kodlama Mülakatına**](https://github.com/donnemartin/interactive-coding-challenges) hazırlanmanıza yardımcı olacak kaynaklar mı arıyorsunuz?

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/b4YtAEN.png">
  <br/>
</p>

Kız kardeş repoya göz atın [**Etkileşimli Kodlama Zorlukları**](https://github.com/donnemartin/interactive-coding-challenges), ek bir Anki destesi içerir:

* [Kodlama destesi](https://github.com/donnemartin/interactive-coding-challenges/tree/master/anki_cards/Coding.apkg)

## Katkıda Bulunma

> Topluluktan öğrenin.

Şunlara yardımcı olmak için pull request göndermekten çekinmeyin:

* Hataları düzeltin
* Bölümleri geliştirin
* Yeni bölümler ekle
* [Çevir](https://github.com/donnemartin/system-design-primer/issues/28)

Düzenlenmesi gereken içerikler [geliştirme aşamasında](#under-development) olarak işaretlenmiştir.

[Katkı Sağlama Yönergelerini](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/CONTRIBUTING.md) inceleyin.

## Sistem tasarımı konuları indeksi

> Çeşitli sistem tasarımı konularının özetleri, artıları ve eksileri dahil.  **Her şey bir ödünleşmedir**.
>
> Her bölümde daha derinlemesine kaynaklara bağlantılar bulunur.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png">
  <br/>
</p>

* [Sistem tasarımı konuları: buradan başlayın](#system-design-topics-start-here)
    * [Adım 1: Ölçeklenebilirlik video dersini inceleyin](#step-1-review-the-scalability-video-lecture)
    * [Adım 2: Ölçeklenebilirlik makalesini inceleyin](#step-2-review-the-scalability-article)
    * [Sonraki adımlar](#next-steps)
* [Performans vs ölçeklenebilirlik](#performance-vs-scalability)
* [Gecikme vs verimlilik](#latency-vs-throughput)
* [Kullanılabilirlik vs tutarlılık](#availability-vs-consistency)
    * [CAP teoremi](#cap-theorem)
        * [CP - tutarlılık ve bölüm toleransı](#cp---consistency-and-partition-tolerance)
        * [AP - kullanılabilirlik ve bölüm toleransı](#ap---availability-and-partition-tolerance)
* [Tutarlılık desenleri](#consistency-patterns)
    * [Zayıf tutarlılık](#weak-consistency)
    * [Sonunda tutarlılık](#eventual-consistency)
    * [Güçlü tutarlılık](#strong-consistency)
* [Kullanılabilirlik desenleri](#availability-patterns)
    * [Fail-over (hata toleransı)](#fail-over)
    * [Çoğaltma](#replication)
    * [Sayılarla kullanılabilirlik](#availability-in-numbers)
* [Alan adı sistemi](#domain-name-system)
* [İçerik dağıtım ağı](#content-delivery-network)
    * [Push CDN'ler](#push-cdns)
    * [Pull CDN'ler](#pull-cdns)
* [Yük dengeleyici](#load-balancer)
    * [Aktif-pasif](#active-passive)
    * [Aktif-aktif](#active-active)
    * [Katman 4 yük dengeleme](#layer-4-load-balancing)
    * [Katman 7 yük dengeleme](#layer-7-load-balancing)
    * [Yatay ölçekleme](#horizontal-scaling)
* [Ters proxy (web sunucusu)](#reverse-proxy-web-server)
    * [Yük dengeleyici vs ters proxy](#load-balancer-vs-reverse-proxy)
* [Uygulama katmanı](#application-layer)
    * [Mikroservisler](#microservices)
    * [Servis keşfi](#service-discovery)
* [Veritabanı](#database)
    * [İlişkisel veritabanı yönetim sistemi (RDBMS)](#relational-database-management-system-rdbms)
        * [Ana-yedek çoğaltma](#master-slave-replication)
        * [Ana-ana çoğaltma](#master-master-replication)
        * [Federasyon](#federation)
        * [Parçalama (Sharding)](#sharding)
        * [Denormalizasyon](#denormalization)
        * [SQL ayarlama](#sql-tuning)
    * [NoSQL](#nosql)
        * [Anahtar-değer deposu](#key-value-store)
        * [Doküman deposu](#document-store)
        * [Geniş sütun deposu](#wide-column-store)
        * [Graf Veritabanı](#graph-database)
    * [SQL veya NoSQL](#sql-or-nosql)
* [Önbellek](#cache)
    * [İstemci önbelleklemesi](#client-caching)
    * [CDN önbelleklemesi](#cdn-caching)
    * [Web sunucu önbelleklemesi](#web-server-caching)
    * [Veritabanı önbelleklemesi](#database-caching)
    * [Uygulama önbelleklemesi](#application-caching)
    * [Veritabanı sorgu seviyesinde önbellekleme](#caching-at-the-database-query-level)
    * [Nesne seviyesinde önbellekleme](#caching-at-the-object-level)
    * [Önbellek ne zaman güncellenmeli](#when-to-update-the-cache)
        * [Önbellek-yanında](#cache-aside)
        * [Yaz-geçişli](#write-through)
        * [Yaz-geriden (yaz-dönüş)](#write-behind-write-back)
        * [Önden-yenileme](#refresh-ahead)
* [Asenkronluk](#asynchronism)
    * [Mesaj kuyrukları](#message-queues)
    * [Görev kuyrukları](#task-queues)
    * [Geri basınç](#back-pressure)
* [İletişim](#communication)
    * [Aktarım kontrol protokolü (TCP)](#transmission-control-protocol-tcp)
    * [Kullanıcı veri iletişim protokolü (UDP)](#user-datagram-protocol-udp)
    * [Uzaktan prosedür çağrısı (RPC)](#remote-procedure-call-rpc)
    * [Temsili durum aktarımı (REST)](#representational-state-transfer-rest)
* [Güvenlik](#security)
* [Ekler](#appendix)
    * [İki tabanı kuvvetler tablosu](#powers-of-two-table)
    * [Her programcının bilmesi gereken gecikme değerleri](#latency-numbers-every-programmer-should-know)
    * [Ek sistem tasarımı mülakat soruları](#additional-system-design-interview-questions)
    * [Gerçek dünya mimarileri](#real-world-architectures)
    * [Şirket mimarileri](#company-architectures)
    * [Şirket mühendislik blogları](#company-engineering-blogs)
* [Geliştirilmekte](#under-development)
* [Katkıda Bulunanlar](#credits)
* [İletişim bilgisi](#contact-info)
* [Lisans](#license)

## Çalışma rehberi

> Mülakat zaman çizelgenize göre incelenmesi önerilen konular (kısa, orta, uzun).

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/OfVllex.png)

**S: Mülakatlar için burada her şeyi bilmem gerekiyor mu?**

**C: Hayır, mülakat için hazırlıkta burada her şeyi bilmenize gerek yok**.

Bir mülakatta size sorulanlar şu değişkenlere bağlıdır:

* Ne kadar deneyiminiz olduğu
* Teknik geçmişinizin ne olduğu
* Hangi pozisyonlar için görüşme yaptığınız
* Hangi şirketlerle görüştüğünüz
* Şans

Daha deneyimli adayların genellikle sistem tasarımı hakkında daha fazla bilgi sahibi olması beklenir.  Mimarlar veya takım liderlerinden bireysel katkı sağlayanlardan daha fazla bilgi beklenebilir.  En iyi teknoloji şirketlerinde bir veya daha fazla tasarım mülakatı turu olma olasılığı yüksektir.

Geniş başlayın ve birkaç alanda derinleşin.  Farklı anahtar sistem tasarımı konuları hakkında biraz bilgi sahibi olmak faydalıdır.  Aşağıdaki rehberi zaman çizelgenize, deneyiminize, başvurduğunuz pozisyonlara ve görüşme yaptığınız şirketlere göre uyarlayın.

* **Kısa zaman çizelgesi** - Sistem tasarım konularında **genişlik** hedefleyin.  **Bazı** mülakat sorularını çözerek pratik yapın.
* **Orta zaman çizelgesi** - Sistem tasarım konularında **genişlik** ve **biraz derinlik** hedefleyin.  **Birçok** mülakat sorusunu çözerek pratik yapın.
* **Uzun zaman çizelgesi** - Sistem tasarım konularında **genişlik** ve **daha fazla derinlik** hedefleyin.  **Çoğu** mülakat sorusunu çözerek pratik yapın.

| | Kısa | Orta | Uzun |
|---|---|---|---|
| Sistemlerin nasıl çalıştığına dair genel bir anlayış kazanmak için [Sistem tasarımı konuları](#index-of-system-design-topics) bölümünü okuyun | :+1: | :+1: | :+1: |
| Görüşme yaptığınız şirketler için [Şirket mühendislik bloglarından](#company-engineering-blogs) birkaç makale okuyun | :+1: | :+1: | :+1: |
| Birkaç [Gerçek dünya mimarisi](#real-world-architectures) örneğini gözden geçirin | :+1: | :+1: | :+1: |
| [Sistem tasarımı mülakat sorusuna nasıl yaklaşılır](#how-to-approach-a-system-design-interview-question) bölümünü gözden geçirin | :+1: | :+1: | :+1: |
| [Çözümlü sistem tasarımı mülakat soruları](#system-design-interview-questions-with-solutions) üzerinde çalışın | Bazı | Birçok | Çoğu |
| [Çözümlü nesne yönelimli tasarım mülakat soruları](#object-oriented-design-interview-questions-with-solutions) üzerinde çalışın | Bazı | Birçok | Çoğu |
| [Ek sistem tasarımı mülakat soruları](#additional-system-design-interview-questions) bölümünü gözden geçirin | Bazı | Birçok | Çoğu |

## Sistem tasarımı mülakat sorusuna nasıl yaklaşılır

> Bir sistem tasarımı mülakat sorusu nasıl ele alınır.

Sistem tasarımı mülakatı **açık uçlu bir konuşmadır**.  Bunu yönlendiren kişi olmanız beklenir.

Aşağıdaki adımları tartışmayı yönlendirmek için kullanabilirsiniz.  Bu süreci pekiştirmek için, [Çözümlü sistem tasarımı mülakat soruları](#system-design-interview-questions-with-solutions) bölümünü aşağıdaki adımları kullanarak inceleyin.

### Adım 1: Kullanım senaryolarını, kısıtlamaları ve varsayımları ana hatlarıyla belirtin

Gereksinimleri toplayın ve problemi kapsamlandırın.  Kullanım senaryoları ve kısıtlamaları netleştirmek için sorular sorun.  Varsayımları tartışın.

* Kim kullanacak?
* Nasıl kullanacaklar?
* Kaç kullanıcı var?
* Sistem ne yapıyor?
* Sistemin girdileri ve çıktıları nelerdir?
* Ne kadar veriyle ilgileneceğiz?
* Saniyede kaç istek bekliyoruz?
* Beklenen okuma/yazma oranı nedir?

### Adım 2: Yüksek seviyeli bir tasarım oluşturun

Tüm önemli bileşenlerle yüksek seviyeli bir tasarım ana hatlarını çizin.

* Ana bileşenleri ve bağlantıları taslağını çıkarın
* Fikirlerinizi gerekçelendirin

### Adım 3: Temel bileşenleri tasarlayın

Her temel bileşenin ayrıntılarına inin.  Örneğin, [bir url kısaltma servisi tasarlamanız](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) istenirse, şunları tartışın:

* Tam url'nin bir hash'inin oluşturulması ve saklanması
    * [MD5](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) ve [Base62](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)
    * Hash çakışmaları
    * SQL veya NoSQL
    * Veritabanı şeması
* Hashlenmiş url'nin tam url'ye çevrilmesi
    * Veritabanı sorgusu
* API ve nesne tabanlı tasarım

### Adım 4: Tasarımı ölçeklendirin

Kısıtlamalar dikkate alındığında darboğazları belirleyin ve ele alın.  Örneğin, ölçeklenebilirlik sorunlarını çözmek için aşağıdakilere ihtiyacınız var mı?

* Yük dengeleyici
* Yatay ölçeklendirme
* Önbellekleme
* Veritabanı bölümlendirme

Olası çözümleri ve takasları tartışın.  Her şey bir takastır.  Darboğazları [ölçeklenebilir sistem tasarımının prensipleri](#index-of-system-design-topics) ile ele alın.

### Kabaca hesaplamalar

Bazı tahminleri elle yapmanız istenebilir.  [Ek](#appendix) bölümünde aşağıdaki kaynaklara başvurun:

* [Kabaca hesaplamalar kullanın](http://highscalability.com/blog/2011/1/26/google-pro-tip-use-back-of-the-envelope-calculations-to-choo.html)
* [İki'nin kuvvetleri tablosu](#powers-of-two-table)
* [Her programcının bilmesi gereken gecikme rakamları](#latency-numbers-every-programmer-should-know)

### Kaynak(lar) ve ileri okuma

Beklentilerinizi daha iyi anlamak için aşağıdaki bağlantılara göz atın:

* [Bir sistem tasarımı mülakatını nasıl başarıyla geçersiniz](https://www.palantir.com/2011/10/how-to-rock-a-systems-design-interview/)
* [Sistem tasarımı mülakatı](http://www.hiredintech.com/system-design)
* [Mimariye ve Sistem Tasarımı Mülakatlarına Giriş](https://www.youtube.com/watch?v=ZgdS0EUmn70)
* [Sistem tasarımı şablonu](https://leetcode.com/discuss/career/229177/My-System-Design-Template)

## Çözümleriyle sistem tasarımı mülakat soruları

> Yaygın sistem tasarımı mülakat soruları örnek tartışmalar, kod ve diyagramlarla birlikte.
>
> Çözümler `solutions/` klasöründeki içeriklere bağlantılıdır.

| Soru | |
|---|---|
| Pastebin.com (veya Bit.ly) tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) |
| Twitter zaman akışı ve arama (veya Facebook akışı ve arama) tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md) |
| Bir web gezgini tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md) |
| Mint.com’u tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md) |
| Bir sosyal ağ için veri yapılarını tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md) |
| Bir arama motoru için anahtar-değer deposu tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md) |
| Amazon’un kategoriye göre satış sıralama özelliğini tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md) |
| AWS üzerinde milyonlarca kullanıcıya ölçeklenebilen bir sistem tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md) |
| Bir sistem tasarımı sorusu ekleyin | [Katkıda Bulunun](#contributing) |

### Pastebin.com’u (veya Bit.ly) tasarlayın

[Alıştırmayı ve çözümü görüntüle](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4edXG0T.png)

### Twitter zaman akışı ve aramayı (veya Facebook akışı ve arama) tasarlayın

[Alıştırmayı ve çözümü görüntüle](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png)

### Bir web gezgini tasarlayın

[Alıştırmayı ve çözümü görüntüle](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bWxPtQA.png)

### Design Mint.com

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/V5q57vU.png)

### Design the data structures for a social network

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/cdCv5g7.png)

### Design a key-value store for a search engine

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4j99mhe.png)

### Design Amazon's sales ranking by category feature

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/MzExP06.png)

### Design a system that scales to millions of users on AWS

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png)

## Object-oriented design interview questions with solutions

> Common object-oriented design interview questions with sample discussions, code, and diagrams.
>
> Solutions linked to content in the `solutions/` folder.

>**Note: This section is under development**

| Question | |
|---|---|
| Bir hash haritası tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/hash_table/hash_map.ipynb)  |
| En son kullanılmayan önbellek tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/lru_cache/lru_cache.ipynb)  |
| Bir çağrı merkezi tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/call_center/call_center.ipynb)  |
| Bir kart destesini tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/deck_of_cards/deck_of_cards.ipynb)  |
| Bir otopark tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/parking_lot/parking_lot.ipynb)  |
| Bir sohbet sunucusu tasarlayın | [Çözüm](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/online_chat/online_chat.ipynb)  |
| Dairesel bir dizi tasarlayın | [Katkıda Bulunun](#contributing)  |
| Nesne tabanlı bir tasarım sorusu ekleyin | [Katkıda Bulunun](#contributing) |

## Sistem tasarımı konuları: buradan başlayın

Sistem tasarımına yeni misiniz?

Öncelikle, yaygın prensipleri temel olarak anlamanız gerekecek, bunların ne olduklarını, nasıl kullanıldıklarını ve avantaj-dezavantajlarını öğrenmeniz gerekir.

### Adım 1: Ölçeklenebilirlik video dersini inceleyin

[Harvard'da Ölçeklenebilirlik Dersi](https://www.youtube.com/watch?v=-W9F__D3oY4)

* Kapsanan konular:
    * Dikey ölçeklendirme
    * Yatay ölçeklendirme
    * Önbellekleme
    * Yük dengeleme
    * Veritabanı çoğaltması
    * Veritabanı bölümlendirmesi

### Adım 2: Ölçeklenebilirlik makalesini inceleyin

[Ölçeklenebilirlik](https://web.archive.org/web/20221030091841/http://www.lecloud.net/tagged/scalability/chrono)

* Kapsanan konular:
    * [Klonlar](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
    * [Veritabanları](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
    * [Önbellekler](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
    * [Asenkronluk](https://web.archive.org/web/20220926171507/https://www.lecloud.net/post/9699762917/scalability-for-dummies-part-4-asynchronism)

### Sonraki adımlar

Şimdi, üst düzey değiş-tokuşlara bakacağız:

* **Performans** ve **ölçeklenebilirlik**
* **Gecikme** ve **verim**
* **Kullanılabilirlik** ve **tutarlılık**

Unutmayın ki **her şey bir değiş-tokuştur**.

Daha sonra DNS, CDN'ler ve yük dengeleyicileri gibi daha spesifik konulara ineceğiz.

## Performans ve ölçeklenebilirlik

Bir hizmet, eklenen kaynaklarla orantılı şekilde artan **performans** sağlıyorsa **ölçeklenebilirdir**. Genellikle, performansı artırmak daha fazla iş birimi sunmak anlamına gelir, ancak büyüyen veri kümeleri gibi daha büyük iş birimlerini işlemek için de olabilir.<sup><a href=http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html>1</a></sup>

Performans ve ölçeklenebilirliğe başka bir bakış açısı:

* Eğer bir **performans** sorununuz varsa, sisteminiz tek bir kullanıcı için yavaştır.
* Eğer bir **ölçeklenebilirlik** sorununuz varsa, sisteminiz tek bir kullanıcı için hızlıdır ancak yoğun yük altında yavaştır.

### Kaynak(lar) ve daha fazla okuma

* [Ölçeklenebilirlik üzerine bir söz](http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html)
* [Ölçeklenebilirlik, kullanılabilirlik, stabilite, desenler](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)

## Gecikme ve verim

**Gecikme**, bir işlemi gerçekleştirmek veya bir sonuç üretmek için geçen süredir.

**Verim**, birim zamanda gerçekleştirilen bu tür eylemlerin veya sonuçların sayısıdır.

Genel olarak, **maksimum verim** ile **kabul edilebilir gecikme** hedeflemelisiniz.

### Kaynak(lar) ve daha fazla okuma

* [Gecikme ve verimi anlamak](https://community.cadence.com/cadence_blogs_8/b/fv/posts/understanding-latency-vs-throughput)

## Kullanılabilirlik ve tutarlılık

### CAP teoremi

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bgLMI2u.png">
  <br/>
  <i><a href=http://robertgreiner.com/2014/08/cap-theorem-revisited>Kaynak: CAP teoremi yeniden gözden geçirildi</a></i>
</p>

Dağıtık bir bilgisayar sisteminde, aşağıdaki garantilerden yalnızca ikisini destekleyebilirsiniz:

* **Tutarlılık (Consistency)** - Her okuma en güncel yazımı veya bir hata alır
* **Kullanılabilirlik (Availability)** - Her istek bir yanıt alır, fakat yanıtın en güncel bilgi versiyonunu içerdiği garanti edilmez
* **Bölüm Toleransı (Partition Tolerance)** - Sistem, ağ hataları nedeniyle oluşan keyfi bölümlere rağmen çalışmaya devam eder

*Ağlar güvenilir değildir, bu yüzden bölüm toleransını desteklemeniz gerekir.  Tutarlılık ve kullanılabilirlik arasında bir yazılım takası yapmanız gerekir.*

#### CP - tutarlılık ve bölüm toleransı

Bölünmüş düğümden yanıt beklemek, zaman aşımı hatasına yol açabilir.  İşletme ihtiyaçlarınız atomik okuma ve yazmalar gerektiriyorsa CP iyi bir seçimdir.

#### AP - kullanılabilirlik ve bölüm toleransı

Yanıtlar, herhangi bir düğümde en kolay erişilebilir veri versiyonunu döndürür; bu veri en güncel olmayabilir.  Bölünme çözüldüğünde yazıların yayılması biraz zaman alabilir.

AP, işletme ihtiyaçlarının [sonunda tutarlılık](#eventual-consistency) gerektirdiği durumlarda veya sistemin dışsal hatalara rağmen çalışmaya devam etmesi gerektiğinde iyi bir seçimdir.

### Kaynak(lar) ve daha fazla okuma

* [CAP teoremi yeniden gözden geçirildi](http://robertgreiner.com/2014/08/cap-theorem-revisited/)
* [CAP teoreminin sade İngilizce tanıtımı](http://ksat.me/a-plain-english-introduction-to-cap-theorem)
* [CAP SSS](https://github.com/henryr/cap-faq)
* [CAP teoremi](https://www.youtube.com/watch?v=k-Yaq8AHlFA)

## Tutarlılık desenleri

Aynı verinin birden fazla kopyası olduğunda, bunları nasıl senkronize edeceğimize dair seçeneklerle karşılaşırız ki istemciler verinin tutarlı bir görünümüne sahip olsun.  [CAP teoremi](#cap-theorem) tanımını hatırlayın - Her okuma en güncel yazımı veya bir hata alır.

### Zayıf tutarlılık

Bir yazımdan sonra, okumalar bu yazımı görebilir veya görmeyebilir.  En iyi çaba yaklaşımı kullanılır.

Bu yaklaşım memcached gibi sistemlerde görülür.  Zayıf tutarlılık, VoIP, video sohbet ve gerçek zamanlı çok oyunculu oyunlar gibi gerçek zamanlı kullanım senaryolarında iyi çalışır.  Örneğin, bir telefon görüşmesindeyken birkaç saniye bağlantıyı kaybederseniz, yeniden bağlantı sağladığınızda bağlantı kaybı sırasında konuşulanları duymazsınız.

### Sonunda tutarlılık (Eventual consistency)

Bir yazma işleminden sonra, okuma işlemleri sonunda bunu görecektir (genellikle milisaniyeler içinde). Veriler eşzamansız olarak çoğaltılır.

Bu yaklaşım DNS ve e-posta gibi sistemlerde görülür. Sonunda tutarlılık, yüksek erişilebilirliğe sahip sistemlerde iyi çalışır.

### Güçlü tutarlılık (Strong consistency)

Bir yazma işleminden sonra, okuma işlemleri bunu görecektir. Veriler eşzamanlı olarak çoğaltılır.

Bu yaklaşım dosya sistemlerinde ve İlişkisel Veritabanı Yönetim Sistemlerinde (RDBMS) görülür. Güçlü tutarlılık, işlemlere ihtiyaç duyan sistemlerde iyi çalışır.

### Kaynak(lar) ve daha fazla okuma

* [Veri merkezleri arasında işlemler](http://snarfed.org/transactions_across_datacenters_io.html)

## Erişilebilirlik kalıpları

Yüksek erişilebilirliği desteklemek için iki tamamlayıcı kalıp vardır: **fail-over** ve **çoğaltma**.

### Fail-over (Hata geçişi)

#### Aktif-pasif

Aktif-pasif hata geçişinde, aktif ve yedek beklemedeki pasif sunucu arasında kalp atışları gönderilir. Kalp atışı kesilirse, pasif sunucu aktifin IP adresini alır ve hizmete devam eder.

Kesinti süresi, pasif sunucunun 'sıcak' beklemede olup olmadığına veya 'soğuk' beklemeden başlatılması gerekip gerekmediğine bağlı olarak belirlenir. Sadece aktif sunucu trafiği yönetir.

Aktif-pasif hata geçişi, ana-yedek (master-slave) hata geçişi olarak da adlandırılabilir.

#### Aktif-aktif

Aktif-aktif modelde, her iki sunucu da trafiği yönetir ve yükü aralarında paylaşır.

Sunucular genel erişime açıksa, DNS'nin her iki sunucunun genel IP'lerini bilmesi gerekir. Sunucular iç erişime açıksa, uygulama mantığının her iki sunucuyu da bilmesi gerekir.

Aktif-aktif hata geçişi, ana-ana (master-master) hata geçişi olarak da adlandırılabilir.

### Dezavantaj(lar): hata geçişi

* Fail-over daha fazla donanım ve ek karmaşıklık getirir.
* Aktif sistem, yeni yazılmış verilerin pasife çoğaltılmasından önce başarısız olursa veri kaybı riski vardır.

### Replikasyon

#### Master-slave ve master-master

Bu konu [Veritabanı](#database) bölümünde daha ayrıntılı olarak ele alınmıştır:

* [Master-slave replikasyonu](#master-slave-replication)
* [Master-master replikasyonu](#master-master-replication)

### Sayısal olarak erişilebilirlik

Erişilebilirlik genellikle hizmetin kullanılabilir olduğu sürenin yüzdesi olarak çalışma süresi (veya kesinti süresi) ile nicel olarak belirtilir.  Erişilebilirlik genellikle dokuz sayısıyla ölçülür--%99.99 erişilebilirliğe sahip bir hizmet dört dokuzlu olarak tanımlanır.

#### %99.9 erişilebilirlik - üç dokuz

| Süre                | Kabul edilebilir kesinti süresi|
|---------------------|-------------------------------|
| Yıllık kesinti      | 8s 45dk 57sn                  |
| Aylık kesinti       | 43dk 49.7sn                   |
| Haftalık kesinti    | 10dk 4.8sn                    |
| Günlük kesinti      | 1dk 26.4sn                    |

#### %99.99 erişilebilirlik - dört dokuz

| Süre                | Kabul edilebilir kesinti süresi|
|---------------------|-------------------------------|
| Yıllık kesinti      | 52dk 35.7sn                   |
| Aylık kesinti       | 4dk 23sn                      |
| Haftalık kesinti    | 1dk 5sn                       |
| Günlük kesinti      | 8.6sn                         |

#### Paralel ve ardışık erişilebilirlik

Bir hizmet birden fazla arızaya yatkın bileşenden oluşuyorsa, hizmetin genel erişilebilirliği bileşenlerin ardışık mı yoksa paralel mi olduğuna bağlıdır.

###### Ardışık
Genel kullanılabilirlik, %100'den az kullanılabilirliğe sahip iki bileşen ardışık olarak bağlandığında azalır:


```
Availability (Total) = Availability (Foo) * Availability (Bar)
```

Eğer hem `Foo` hem de `Bar` ayrı ayrı %99,9 erişilebilirliğe sahipse, ardışık olarak toplam erişilebilirlikleri %99,8 olur.

###### Paralel durumda

İki bileşen %100'den düşük erişilebilirliğe sahip olduğunda paralel çalıştıklarında genel erişilebilirlik artar:

```
Availability (Total) = 1 - (1 - Availability (Foo)) * (1 - Availability (Bar))
```
Eğer hem `Foo` hem de `Bar` %99,9 kullanılabilirliğe sahip olsaydı, paralel toplam kullanılabilirlikleri %99,9999 olurdu.

## Alan adı sistemi

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/IOyLj4i.jpg">
  <br/>
  <i><a href=http://www.slideshare.net/srikrupa5/dns-security-presentation-issa>Kaynak: DNS güvenlik sunumu</a></i>
</p>

Bir Alan Adı Sistemi (DNS), www.example.com gibi bir alan adını bir IP adresine dönüştürür.

DNS hiyerarşiktir ve en üst düzeyde birkaç yetkili sunucu bulunur.  Yönlendiriciniz veya ISS’niz, sorgulama yaparken hangi DNS sunucusuna(larına) başvurulacağını belirten bilgileri sağlar.  Alt düzey DNS sunucuları eşlemeleri önbelleğe alır; bu önbellekler, DNS yayılım gecikmeleri nedeniyle güncelliğini yitirebilir.  DNS sonuçları ayrıca tarayıcınız veya işletim sisteminiz tarafından, [yaşam süresi (TTL)](https://en.wikipedia.org/wiki/Time_to_live) ile belirlenen bir süre boyunca önbelleğe alınabilir.

* **NS kaydı (ad sunucusu)** - Alan adınız/alt alan adınız için DNS sunucularını belirtir.
* **MX kaydı (mail exchange)** - Mesajları kabul edecek posta sunucularını belirtir.
* **A kaydı (adres)** - Bir adı bir IP adresine yönlendirir.
* **CNAME (kanonik)** - Bir adı başka bir ada veya `CNAME`’e (example.com’dan www.example.com’a) ya da bir `A` kaydına yönlendirir.

[CloudFlare](https://www.cloudflare.com/dns/) ve [Route 53](https://aws.amazon.com/route53/) gibi hizmetler yönetilen DNS servisleri sunar.  Bazı DNS servisleri trafiği çeşitli yöntemlerle yönlendirebilir:

* [Ağırlıklı döngüsel dağıtım](https://www.jscape.com/blog/load-balancing-algorithms)
    * Bakımda olan sunuculara trafiğin gitmesini engellemek
    * Farklı boyutlardaki kümeler arasında denge sağlamak
    * A/B testi
* [Gecikme tabanlı](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-latency.html)
* [Coğrafi konum tabanlı](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geo.html)

### Dezavantaj(lar): DNS

* DNS sunucusuna erişmek hafif bir gecikme ekler, ancak yukarıda açıklanan önbellekleme ile azaltılır.
* DNS sunucu yönetimi karmaşık olabilir ve genellikle [hükümetler, ISS’ler ve büyük şirketler](http://superuser.com/questions/472695/who-controls-the-dns-servers/472729) tarafından yürütülür.
* DNS servisleri yakın zamanda [DDoS saldırısına](http://dyn.com/blog/dyn-analysis-summary-of-friday-october-21-attack/) uğramış, kullanıcıların Twitter gibi sitelere Twitter’ın IP adresini bilmeden erişmesini engellemiştir.

### Kaynak(lar) ve ileri okuma

* [DNS mimarisi](https://technet.microsoft.com/en-us/library/dd197427(v=ws.10).aspx)
* [Vikipedi](https://en.wikipedia.org/wiki/Domain_Name_System)
* [DNS makaleleri](https://support.dnsimple.com/categories/dns/)


## İçerik dağıtım ağı

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h9TAuGI.jpg">
  <br/>
  <i><a href=https://www.creative-artworks.eu/why-use-a-content-delivery-network-cdn/>Kaynak: Neden bir CDN kullanılır</a></i>
</p>

Bir içerik dağıtım ağı (CDN), içeriği kullanıcıya daha yakın konumlardan sunan, küresel olarak dağıtılmış bir proxy sunucular ağıdır. Genellikle, HTML/CSS/JS, fotoğraflar ve videolar gibi statik dosyalar CDN üzerinden sunulur, ancak Amazon'un CloudFront'u gibi bazı CDN'ler dinamik içeriği de destekler. Sitenin DNS çözümlemesi, istemcilere hangi sunucuya bağlanacaklarını bildirir.

CDN'lerden içerik sunmak, performansı iki şekilde önemli ölçüde artırabilir:

* Kullanıcılar, kendilerine yakın veri merkezlerinden içerik alır
* Sunucularınız, CDN'nin karşıladığı istekleri sunmak zorunda kalmaz

### Push CDN’ler

Push CDN’ler, sunucunuzda değişiklikler olduğunda yeni içeriği alır. İçeriği sağlama sorumluluğu tamamen sizdedir, doğrudan CDN’ye yükleme yapar ve URL’leri CDN’ye işaret edecek şekilde yeniden yazarsınız. İçeriğin ne zaman sona ereceğini ve güncelleneceğini yapılandırabilirsiniz. İçerik yalnızca yeni olduğunda veya değiştiğinde yüklenir, bu da trafiği en aza indirirken depolamayı en üst düzeye çıkarır.

Az trafik alan veya içeriği sık güncellenmeyen siteler push CDN’lerle iyi çalışır. İçerik CDN’lere bir kez yerleştirilir, düzenli aralıklarla tekrar çekilmez.

### Pull CDN’ler

Pull CDN’ler, ilk kullanıcı içeriği istediğinde yeni içeriği sunucunuzdan çeker. İçeriği sunucunuzda bırakır ve URL’leri CDN’ye işaret edecek şekilde yeniden yazarsınız. Bu, içerik CDN’de önbelleğe alınana kadar daha yavaş bir isteğe yol açar.

Bir [time-to-live (TTL)](https://en.wikipedia.org/wiki/Time_to_live), içeriğin ne kadar süreyle önbellekte tutulacağını belirler. Pull CDN’ler CDN üzerindeki depolama alanını en aza indirir, ancak dosyalar sona ererse ve gerçekten değişmeden önce çekilirse gereksiz trafik oluşturabilir.

Yoğun trafiğe sahip siteler pull CDN’lerle iyi çalışır, çünkü trafik daha dengeli yayılır ve sadece son zamanlarda istenen içerik CDN’de kalır.

### Dezavantaj(lar): CDN

* CDN maliyetleri, trafiğe bağlı olarak önemli olabilir, ancak bu, CDN kullanmadığınızda karşılaşacağınız ek maliyetlerle kıyaslanmalıdır.
* İçerik, TTL süresi dolmadan güncellenirse eski kalabilir.
* CDN’ler için statik içerik URL’lerinin CDN’yi işaret edecek şekilde değiştirilmesi gerekir.

### Kaynak(lar) ve daha fazla okuma

* [Küresel olarak dağıtılmış içerik dağıtımı](https://figshare.com/articles/Globally_distributed_content_delivery/6605972)
* [Push ve pull CDN’ler arasındaki farklar](http://www.travelblogadvice.com/technical/the-differences-between-push-and-pull-cdns/)
* [Vikipedi](https://en.wikipedia.org/wiki/Content_delivery_network)

## Yük dengeleyici

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h81n9iK.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>Kaynak: Ölçeklenebilir sistem tasarım desenleri</a></i>
</p>

Yük dengeleyiciler, gelen istemci isteklerini uygulama sunucuları ve veritabanları gibi bilişim kaynaklarına dağıtır. Her durumda, yük dengeleyici yanıtı bilişim kaynağından alıp ilgili istemciye iletir. Yük dengeleyiciler aşağıdaki konularda etkilidir:

* Sağlıksız sunuculara isteklerin gitmesini önlemek
* Kaynakların aşırı yüklenmesini önlemek
* Tek bir hata noktasını ortadan kaldırmaya yardımcı olmak

Yük dengeleyiciler donanım (pahalı) ile veya HAProxy gibi yazılımlarla uygulanabilir.

Ek faydalar arasında şunlar bulunur:

* **SSL sonlandırma** - Gelen istekleri şifreler ve sunucu yanıtlarını şifreler, böylece arka uç sunucuların bu potansiyel olarak pahalı işlemleri yapmasına gerek kalmaz
    * Her sunucuya [X.509 sertifikaları](https://en.wikipedia.org/wiki/X.509) yükleme ihtiyacını ortadan kaldırır
* **Oturum kalıcılığı** - Çerezler vererek ve belirli bir istemcinin isteklerini aynı instance'a yönlendirerek, web uygulamaları oturumları takip etmiyorsa bile oturum devamlılığı sağlar

Arızalara karşı koruma sağlamak için, genellikle birden fazla yük dengeleyici, ya [aktif-pasif](#active-passive) ya da [aktif-aktif](#active-active) modda kurulur.

Yük dengeleyiciler trafiği çeşitli metriklere göre yönlendirebilir, örneğin:

* Rastgele
* En az yükte olan
* Oturum/çerezler
* [Round robin veya ağırlıklı round robin](https://www.g33kinfo.com/info/round-robin-vs-weighted-round-robin-lb)
* [Layer 4](#layer-4-load-balancing)
* [Layer 7](#layer-7-load-balancing)

### Katman 4 yük dengeleme

Katman 4 yük dengeleyiciler, isteklerin nasıl dağıtılacağına karar vermek için [iletişim katmanı](#communication) bilgisini inceler. Genellikle bu, başlıktaki kaynak ve hedef IP adreslerini ve portlarını içerir, ancak paketin içeriğini içermez. Katman 4 yük dengeleyiciler ağ paketlerini yukarıdaki sunucuya iletir ve [Ağ Adresi Çevirisi (NAT)](https://www.nginx.com/resources/glossary/layer-4-load-balancing/) uygular.

### Katman 7 yük dengeleme
Katman 7 yük dengeleyiciler, isteklerin nasıl dağıtılacağına karar vermek için [uygulama katmanına](#communication) bakar. Bu, başlık, mesaj ve çerezlerin içeriğini içerebilir. Katman 7 yük dengeleyiciler ağ trafiğini sonlandırır, mesajı okur, yük dengeleme kararını verir, ardından seçilen sunucuya bir bağlantı açar. Örneğin, bir katman 7 yük dengeleyici, video trafiğini videoları barındıran sunuculara yönlendirirken, daha hassas kullanıcı fatura trafiğini güvenliği artırılmış sunuculara yönlendirebilir.

Esneklik pahasına, katman 4 yük dengeleme, Katman 7'ye göre daha az zaman ve bilgi işlem kaynağı gerektirir, ancak modern donanımlarda performans etkisi minimum olabilir.

### Yatay ölçekleme

Yük dengeleyiciler ayrıca yatay ölçeklemeye yardımcı olarak performans ve kullanılabilirliği artırabilir. Ucuz donanım kullanarak ölçeklemek, daha pahalı donanımda tek bir sunucuyu ölçeklemekten (Dikey Ölçekleme olarak adlandırılır) daha maliyet etkin ve daha yüksek kullanılabilirlik sağlar. Ayrıca, ucuz donanımda çalışan yetenekleri işe almak, özel kurumsal sistemler için yetenek bulmaktan daha kolaydır.

#### Dezavantaj(lar): yatay ölçekleme

* Yatay ölçekleme karmaşıklık getirir ve sunucuları klonlamayı gerektirir
    * Sunucular durumsuz olmalıdır: oturumlar veya profil resimleri gibi kullanıcıya ait veriler içermemelidir
    * Oturumlar merkezi bir veri deposunda, örneğin bir [veritabanı](#database) (SQL, NoSQL) veya kalıcı bir [önbellek](#cache) (Redis, Memcached) içinde saklanabilir
* Önbellekler ve veritabanları gibi alt sunucular, üst sunucular ölçeklendikçe daha fazla eşzamanlı bağlantıyı yönetmelidir

### Dezavantaj(lar): yük dengeleyici

* Yük dengeleyici, yeterli kaynağa sahip değilse veya düzgün yapılandırılmamışsa bir performans darboğazı haline gelebilir.
* Tek hata noktalarını ortadan kaldırmak için yük dengeleyici eklemek, karmaşıklığı artırır.
* Tek bir yük dengeleyici tek hata noktasıdır, birden fazla yük dengeleyici yapılandırmak ise daha fazla karmaşıklık getirir.

### Kaynak(lar) ve daha fazla okuma

* [NGINX mimarisi](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [HAProxy mimari rehberi](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [Ölçeklenebilirlik](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
* [Vikipedi](https://en.wikipedia.org/wiki/Load_balancing_(computing))
* [Katman 4 yük dengeleme](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)
* [Katman 7 yük dengeleme](https://www.nginx.com/resources/glossary/layer-7-load-balancing/)
* [ELB dinleyici yapılandırması](http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html)

## Ters proxy (web sunucusu)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n41Azff.png">
  <br/>
  <i><a href=https://upload.wikimedia.org/wikipedia/commons/6/67/Reverse_proxy_h2g2bob.svg>Kaynak: Vikipedi</a></i>
  <br/>
</p>


Ters proxy, dahili hizmetleri merkezileştiren ve kamuya birleşik arayüzler sağlayan bir web sunucusudur.  İstemcilerden gelen talepler, yerine getirebilecek bir sunucuya iletilir ve ters proxy, sunucunun yanıtını istemciye döndürür.

Ek avantajlar şunlardır:

* **Artan güvenlik** - Arka uç sunucular hakkındaki bilgileri gizler, IP'leri kara listeye alır, istemci başına bağlantı sayısını sınırlar
* **Artan ölçeklenebilirlik ve esneklik** - İstemciler yalnızca ters proxy'nin IP'sini görür, böylece sunucuları ölçeklendirebilir veya yapılandırmalarını değiştirebilirsiniz
* **SSL sonlandırma** - Gelen talepleri çözer ve sunucu yanıtlarını şifreler, böylece arka uç sunucular bu potansiyel olarak maliyetli işlemleri yapmak zorunda kalmaz
    * Her sunucuya [X.509 sertifikası](https://en.wikipedia.org/wiki/X.509) yükleme gerekliliğini ortadan kaldırır
* **Sıkıştırma** - Sunucu yanıtlarını sıkıştırır
* **Önbellekleme** - Önbelleğe alınmış talepler için yanıtı döndürür
* **Statik içerik** - Statik içerikleri doğrudan sunar
    * HTML/CSS/JS
    * Fotoğraflar
    * Videolar
    * vb.

### Yük dengeleyici vs ters proxy

* Birden fazla sunucunuz olduğunda yük dengeleyici dağıtmak faydalıdır.  Genellikle yük dengeleyiciler, aynı işlevi yerine getiren bir sunucu grubuna trafiği yönlendirir.
* Ters proxyler, yalnızca bir web sunucusu veya uygulama sunucusu olsa bile, önceki bölümde açıklanan avantajları sağlar.
* NGINX ve HAProxy gibi çözümler hem katman 7 ters proxy hem de yük dengeleme desteği sunabilir.

### Dezavantaj(lar): ters proxy

* Ters proxy eklemek, daha fazla karmaşıklık getirir.
* Tek bir ters proxy, tek hata noktasıdır; birden fazla ters proxy (örn. [failover](https://en.wikipedia.org/wiki/Failover)) yapılandırmak karmaşıklığı daha da artırır.

### Kaynak(lar) ve daha fazla okuma

* [Ters proxy vs yük dengeleyici](https://www.nginx.com/resources/glossary/reverse-proxy-vs-load-balancer/)
* [NGINX mimarisi](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [HAProxy mimari rehberi](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [Vikipedi](https://en.wikipedia.org/wiki/Reverse_proxy)

## Uygulama katmanı

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yB5SYwm.png">
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>Kaynak: Ölçeklenebilir sistem mimarisi için giriş</a></i>
</p>

Web katmanını uygulama katmanından (diğer adıyla platform katmanı) ayırmak, her iki katmanı da bağımsız olarak ölçeklendirmeye ve yapılandırmaya olanak tanır. Yeni bir API eklemek, mutlaka ek web sunucuları eklemeden uygulama sunucuları eklenmesiyle sonuçlanır. **Tek sorumluluk ilkesi**, birlikte çalışan küçük ve özerk servisleri savunur. Küçük ekipler ve küçük servisler, hızlı büyümeye daha agresif bir şekilde plan yapabilir.

Uygulama katmanındaki çalışanlar [asenkronizmi](#asynchronism) etkinleştirmeye de yardımcı olur.

### Mikroservisler

Bu tartışmayla ilgili olan [mikroservisler](https://en.wikipedia.org/wiki/Microservices), bağımsız olarak dağıtılabilen, küçük, modüler servisler paketi olarak tanımlanabilir. Her servis benzersiz bir süreçte çalışır ve iş hedefini gerçekleştirmek için iyi tanımlanmış, hafif bir mekanizma ile iletişim kurar. <sup><a href=https://smartbear.com/learn/api-design/what-are-microservices>1</a></sup>

Örneğin Pinterest, şu mikroservislere sahip olabilir: kullanıcı profili, takipçi, akış, arama, fotoğraf yükleme vb.

### Servis Keşfi

[Consul](https://www.consul.io/docs/index.html), [Etcd](https://coreos.com/etcd/docs/latest) ve [Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) gibi sistemler, kayıtlı isimleri, adresleri ve portları takip ederek servislerin birbirini bulmasına yardımcı olabilir. [Sağlık kontrolleri](https://www.consul.io/intro/getting-started/checks.html) servis bütünlüğünü doğrulamada yardımcı olur ve genellikle bir [HTTP](#hypertext-transfer-protocol-http) uç noktası kullanılarak yapılır. Hem Consul hem de Etcd, yapılandırma değerleri ve diğer paylaşılan verileri depolamak için kullanılabilen yerleşik bir [anahtar-değer deposu](#key-value-store) içerir.

### Dezavantaj(lar): uygulama katmanı

* Gevşek bağlı servislerle bir uygulama katmanı eklemek, mimari, operasyon ve süreç açısından (monolitik sisteme kıyasla) farklı bir yaklaşım gerektirir.
* Mikroservisler, dağıtımlar ve operasyonlar açısından karmaşıklık ekleyebilir.

### Kaynak(lar) ve daha fazla okuma

* [Ölçeklenebilir sistem mimarisi için giriş](http://lethain.com/introduction-to-architecting-systems-for-scale)
* [Sistem tasarımı mülakatını aşmak](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Servis odaklı mimari](https://en.wikipedia.org/wiki/Service-oriented_architecture)
* [Zookeeper’a giriş](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper)
* [Mikroservisler inşa etmek hakkında bilmeniz gerekenler](https://cloudncode.wordpress.com/2016/07/22/msa-getting-started/)

## Veritabanı

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Xkm5CXz.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>Kaynak: İlk 10 milyon kullanıcınıza ölçeklenmek</a></i>
</p>

### İlişkisel veritabanı yönetim sistemi (RDBMS)

SQL gibi ilişkisel bir veritabanı, tablolar halinde düzenlenmiş veri öğelerinin bir koleksiyonudur.

**ACID**, ilişkisel veritabanı [işlemlerinin](https://en.wikipedia.org/wiki/Database_transaction) bir dizi özelliğidir.

* **Atomiklik** - Her işlem ya tamamen gerçekleşir ya hiç gerçekleşmez
* **Tutarlılık** - Herhangi bir işlem, veritabanını bir geçerli durumdan başka bir geçerli duruma getirir
* **Yalıtım** - İşlemlerin eşzamanlı olarak yürütülmesi, işlemlerin ardışık olarak yürütülmesiyle aynı sonuçları verir
* **Dayanıklılık** - Bir işlem taahhüt edildikten sonra, kalıcı olarak öyle kalır

Bir ilişkisel veritabanını ölçeklendirmek için birçok teknik vardır: **ana-yedek çoğaltma**, **ana-ana çoğaltma**, **federasyon**, **parçalama**, **denormalizasyon** ve **SQL ayarlama**.

#### Ana-yedek çoğaltma

Ana sunucu, okuma ve yazma işlemlerini yapar, yazmaları bir veya daha fazla yedeğe çoğaltır; yedekler yalnızca okuma işlemleri yapar.  Yedekler ayrıca ağaç yapısında başka yedeklere de çoğaltılabilir.  Ana sunucu çevrimdışı olursa, bir yedeğin ana olarak yükseltilmesine veya yeni bir ana sağlanmasına kadar sistem salt okunur modda çalışmaya devam edebilir.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/C9ioGtn.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Kaynak: Ölçeklenebilirlik, erişilebilirlik, stabilite, desenler</a></i>
</p>

##### Dezavantaj(lar): ana-yedek çoğaltma

* Bir yedeğin ana olarak yükseltilmesi için ek mantık gerekir.
* **Her iki** ana-yedek ve ana-ana için ilgili noktalar için [Dezavantaj(lar): çoğaltma](#disadvantages-replication) bölümüne bakınız.

#### Ana-ana çoğaltma

Her iki ana sunucu da okuma ve yazma işlemlerini yapar ve yazma işlemlerinde birbirleriyle koordine olurlar.  Ana sunuculardan biri kapanırsa, sistem okuma ve yazma işlemleriyle çalışmaya devam edebilir.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/krAHLGg.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Kaynak: Ölçeklenebilirlik, erişilebilirlik, stabilite, desenler</a></i>
</p>

##### Dezavantaj(lar): ana-ana çoğaltma

* Bir yük dengeleyiciye ihtiyacınız olacak veya uygulama mantığınızda yazmanın nereye yapılacağını belirlemek için değişiklikler yapmanız gerekecek.
* Çoğu ana-ana sistemi ya gevşek tutarlıdır (ACID'i ihlal eder) ya da senkronizasyondan dolayı artan yazma gecikmesine sahiptir.
* Çatışma çözümü, daha fazla yazma düğümü eklendikçe ve gecikme arttıkça daha fazla gündeme gelir.
* **Hem** master-slave hem de master-master ile ilgili noktalar için [Dezavantaj(lar): replikasyon](#disadvantages-replication) bölümüne bakın.

##### Dezavantaj(lar): replikasyon

* Master, yeni yazılmış veriler diğer düğümlere çoğaltılmadan önce arızalanırsa veri kaybı potansiyeli vardır.
* Yazmalar, okuma replikalarına tekrar oynatılır. Eğer çok fazla yazma varsa, okuma replikaları tekrar oynatılan yazmalardan dolayı tıkanabilir ve daha az okuma yapabilirler.
* Ne kadar çok okuma kölesi varsa, o kadar çok çoğaltma yapılır, bu da daha fazla replikasyon gecikmesine yol açar.
* Bazı sistemlerde, master'a yazma işlemi paralel olarak birden fazla iş parçacığı ile başlatılabilirken, okuma replikaları yalnızca tek bir iş parçacığı ile sıralı yazmayı destekler.
* Replikasyon, daha fazla donanım ve ek karmaşıklık getirir.

##### Kaynak(lar) ve ileri okuma: replikasyon

* [Ölçeklenebilirlik, kullanılabilirlik, kararlılık, desenler](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [Çoklu-master replikasyonu](https://en.wikipedia.org/wiki/Multi-master_replication)

#### Federasyon

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/U3qV33e.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>Kaynak: İlk 10 milyon kullanıcınıza ölçeklenme</a></i>
</p>

Federasyon (veya fonksiyonel bölümlendirme), veritabanlarını işlevlerine göre böler. Örneğin, tek ve bütünleşik bir veritabanı yerine, üç farklı veritabanınız olabilir: **forumlar**, **kullanıcılar** ve **ürünler**; bu sayede her bir veritabanına daha az okuma ve yazma trafiği olur ve bu da daha az replikasyon gecikmesi demektir. Küçük veritabanları, belleğe daha fazla veri sığmasını sağlar; bu da geliştirilmiş önbellek lokalliği sayesinde daha fazla önbellek vuruşu elde edilmesine yol açar. Merkezi bir master'ın yazmaları sıralamasının olmaması sayesinde paralel yazma işlemleri yapılabilir ve bu da verimi artırır.

##### Dezavantaj(lar): federasyon

* Şemanız büyük işlevler veya tablolar gerektiriyorsa federasyon etkili değildir.
* Hangi veritabanına okuma/yazma yapılacağını belirlemek için uygulama mantığınızı güncellemeniz gerekir.
* İki veritabanından veri birleştirmek, bir [sunucu bağlantısı](http://stackoverflow.com/questions/5145637/querying-data-by-joining-two-tables-in-two-database-on-different-servers) ile daha karmaşıktır.
* Federasyon, daha fazla donanım ve ek karmaşıklık ekler.

##### Kaynak(lar) ve ileri okuma: federasyon

* [İlk 10 milyon kullanıcınıza ölçeklenme](https://www.youtube.com/watch?v=kKjm4ehYiMs)

#### Sharding

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wU8x5Id.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Kaynak: Ölçeklenebilirlik, kullanılabilirlik, stabilite, desenler</a></i>
</p>

Sharding, veriyi farklı veritabanlarına dağıtarak her veritabanının yalnızca verinin bir alt kümesini yönetebilmesini sağlar. Bir kullanıcılar veritabanı örneği üzerinden, kullanıcı sayısı arttıkça kümeye daha fazla parça (shard) eklenir.

[Federasyon](#federation) avantajlarına benzer şekilde, sharding daha az okuma ve yazma trafiği, daha az replikasyon ve daha fazla önbellek vuruşu sağlar. İndeks boyutu da azalır, bu da genellikle daha hızlı sorgular ile performansı arttırır. Bir parça (shard) kapanırsa, diğer parçalar hala çalışır durumda olur, ancak veri kaybını önlemek için bir tür replikasyon eklemek istersiniz. Federasyonda olduğu gibi, yazmaları sıralayan merkezi bir ana sunucu olmadığı için, paralel şekilde daha yüksek verimlilikle yazma yapabilirsiniz.

Bir kullanıcılar tablosunu parçalamanın yaygın yolları, kullanıcının soyadının ilk harfi veya kullanıcının coğrafi konumu üzerinden yapılır.

##### Dezavantaj(lar): sharding

* Uygulama mantığınızı parçalara uyacak şekilde güncellemeniz gerekir, bu da karmaşık SQL sorgularına yol açabilir.
* Bir parçadaki veri dağılımı dengesizleşebilir. Örneğin, bir parçadaki yoğun kullanıcılar diğerlerine göre daha fazla yük oluşturabilir.
    * Yeniden dengeleme ek karmaşıklık getirir. [Tutarlı karma](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html) tabanlı bir parçalara ayırma fonksiyonu taşınan veri miktarını azaltabilir.
* Birden fazla parçadan veri birleştirmek daha karmaşıktır.
* Sharding daha fazla donanım ve ek karmaşıklık getirir.

##### Kaynak(lar) ve daha fazla okuma: sharding

* [Parçanın gelişi](http://highscalability.com/blog/2009/8/6/an-unorthodox-approach-to-database-design-the-coming-of-the.html)
* [Parçalı veritabanı mimarisi](https://en.wikipedia.org/wiki/Shard_(database_architecture))
* [Tutarlı karma](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)

#### Denormalizasyon

Denormalizasyon, okuma performansını arttırmaya çalışırken bazı yazma performansından feragat eder. Pahalı birleşimlerden kaçınmak için verinin fazladan kopyaları birden fazla tabloda tutulur. [PostgreSQL](https://en.wikipedia.org/wiki/PostgreSQL) ve Oracle gibi bazı İlişkisel Veritabanı Yönetim Sistemleri [maddileştirilmiş görünümler](https://en.wikipedia.org/wiki/Materialized_view) destekler; bu yapılar fazladan bilginin saklanmasını ve tutarlı kalmasını sağlar.

Veri [federasyon](#federation) ve [sharding](#sharding) gibi tekniklerle dağıtıldığında, veri merkezleri arasında birleşim (join) yönetmek karmaşıklığı daha da arttırır. Denormalizasyon, bu tür karmaşık birleşimlere olan ihtiyacı ortadan kaldırabilir.

Çoğu sistemde, okuma işlemleri yazma işlemlerine kıyasla çok daha fazla olabilir; 100:1 hatta 1000:1 oranında. Karmaşık bir veritabanı birleşimiyle sonuçlanan bir okuma, disk işlemlerinde ciddi zaman harcayarak çok pahalı olabilir.

##### Dezavantaj(lar): denormalizasyon

* Veri çoğaltılır.
* Kısıtlar, fazladan kopyaların tutarlı kalmasına yardımcı olabilir, bu da veritabanı tasarımının karmaşıklığını arttırır.
* Yoğun yazma yükü altında denormalize bir veritabanı, normalize edilmiş muadilinden daha kötü performans gösterebilir.

###### Kaynak(lar) ve daha fazla okuma: denormalizasyon

* [Denormalizasyon](https://en.wikipedia.org/wiki/Denormalization)

#### SQL ayarlama

SQL ayarlama geniş bir konudur ve birçok [kitap](https://www.amazon.com/s/ref=nb_sb_noss_2?url=search-alias%3Daps&field-keywords=sql+tuning) referans olarak yazılmıştır.

**Benchmark** ve **profil**leme yapmak, darboğazları simüle etmek ve ortaya çıkarmak için önemlidir.

* **Benchmark** - [ab](http://httpd.apache.org/docs/2.2/programs/ab.html) gibi araçlarla yüksek yük durumlarını simüle edin.
* **Profil** - Performans sorunlarını izlemeye yardımcı olmak için [yavaş sorgu günlüğü](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html) gibi araçları etkinleştirin.

Benchmark ve profil oluşturma aşağıdaki iyileştirmelere işaret edebilir.

##### Şemayı sıkılaştırın

* MySQL, hızlı erişim için verileri disk üzerinde bitişik bloklara döker.
* Sabit uzunluklu alanlar için `CHAR` kullanın, `VARCHAR` yerine tercih edin.
    * `CHAR`, hızlı ve rastgele erişime olanak tanırken, `VARCHAR` ile bir sonraki stringe geçmeden önce sonunu bulmanız gerekir.
* Blog yazıları gibi büyük metin blokları için `TEXT` kullanın.  `TEXT` ayrıca boolean aramalara olanak tanır.  Bir `TEXT` alanı kullanmak, disk üzerinde metin bloğunu bulmak için kullanılan bir işaretçi saklanmasına neden olur.
* 2^32 veya 4 milyara kadar olan büyük sayılar için `INT` kullanın.
* Ondalık gösterim hatalarını önlemek için para birimi için `DECIMAL` kullanın.
* Büyük `BLOB`'ları saklamaktan kaçının, bunun yerine nesnenin alınacağı konumu saklayın.
* `VARCHAR(255)`, 8 bitlik bir sayıda sayılabilecek en fazla karakter sayısıdır ve bazı RDBMS'lerde bir baytın maksimum kullanımını sağlar.
* Uygun olan yerlerde `NOT NULL` kısıtlamasını ayarlayın, [arama performansını artırmak için](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search).

##### İyi indeksler kullanın

* Sorguladığınız sütunlar (`SELECT`, `GROUP BY`, `ORDER BY`, `JOIN`) indekslerle daha hızlı olabilir.
* İndeksler genellikle verileri sıralı tutan ve aramaları, ardışık erişimi, eklemeleri ve silmeleri logaritmik zamanda sağlayan kendi kendini dengeleyen [B-tree](https://en.wikipedia.org/wiki/B-tree) olarak temsil edilir.
* Bir indeks eklemek verileri bellekte tutabilir, bu da daha fazla alan gerektirir.
* Yazma işlemleri daha yavaş olabilir çünkü indeksin de güncellenmesi gerekir.
* Büyük miktarda veri yüklerken, indeksleri devre dışı bırakmak, veriyi yüklemek ve ardından indeksleri yeniden oluşturmak daha hızlı olabilir.

##### Maliyetli join'lerden kaçının

* Performans gerektirdiğinde [Denormalizasyon](#denormalization) uygulayın.

##### Tabloları bölümlere ayırın

* Bir tabloyu bölmek için sıcak noktaları ayrı bir tabloda tutarak bellekte kalmasına yardımcı olun.

##### Sorgu önbelleğini ayarlayın

* Bazı durumlarda, [sorgu önbelleği](https://dev.mysql.com/doc/refman/5.7/en/query-cache.html) [performans sorunlarına](https://www.percona.com/blog/2016/10/12/mysql-5-7-performance-tuning-immediately-after-installation/) yol açabilir.

##### Kaynak(lar) ve ileri okuma: SQL ayarlama

* [MySQL sorgularını optimize etmek için ipuçları](http://aiddroid.com/10-tips-optimizing-mysql-queries-dont-suck/)
* [VARCHAR(255) neden bu kadar sık kullanılıyor?](http://stackoverflow.com/questions/1217466/is-there-a-good-reason-i-see-varchar255-used-so-often-as-opposed-to-another-l)
* [Null değerler performansı nasıl etkiler?](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)
* [Yavaş sorgu günlüğü](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html)

### NoSQL

NoSQL, verilerin **anahtar-değer deposu**, **belge deposu**, **geniş sütun deposu** veya **graf veritabanı** şeklinde temsil edildiği bir veri öğeleri koleksiyonudur.  Veriler denormalize edilir ve genellikle birleştirmeler uygulama kodunda yapılır.  Çoğu NoSQL deposu gerçek ACID işlemlerinden yoksundur ve [sonunda tutarlılık](#eventual-consistency) ilkesini benimser.

**BASE** terimi genellikle NoSQL veritabanlarının özelliklerini tanımlamak için kullanılır.  [CAP Teoremi](#cap-theorem) ile karşılaştırıldığında, BASE tutarlılık yerine erişilebilirliği seçer.

* **Temelde erişilebilir** - sistem erişilebilirliği garanti eder.
* **Yumuşak durum** - sistemin durumu zamanla, girdi olmadan bile değişebilir.
* **Sonunda tutarlılık** - sistem, belirli bir süre boyunca girdi almazsa zamanla tutarlı hale gelir.

[SQl veya NoSQL](#sql-or-nosql) arasında seçim yapmanın yanı sıra, hangi NoSQL veritabanı tipinin kullanım durumunuza daha uygun olduğunu anlamak da faydalıdır.  Bir sonraki bölümde **anahtar-değer depoları**, **belge depoları**, **geniş sütun depoları** ve **graf veritabanlarını** inceleyeceğiz.

#### Anahtar-değer deposu

> Soyutlama: karma tablo

Bir anahtar-değer deposu genellikle O(1) okuma ve yazma olanağı sağlar ve çoğunlukla bellek veya SSD ile desteklenir.  Veri depoları anahtarları [leksikografik sırada](https://en.wikipedia.org/wiki/Lexicographical_order) tutabilir, bu da anahtar aralıklarının verimli şekilde alınmasına olanak sağlar.  Anahtar-değer depoları bir değere meta veri eklemeye izin verebilir.

Anahtar-değer depoları yüksek performans sağlar ve genellikle basit veri modelleri veya hızlı değişen veriler için, örneğin bellek içi önbellek katmanı olarak kullanılır.  Sadece sınırlı bir işlem kümesi sunduklarından, ek işlemler gerektiğinde karmaşıklık uygulama katmanına kayar.

Bir anahtar-değer deposu, belge deposu gibi daha karmaşık sistemlerin ve bazı durumlarda graf veritabanının temelini oluşturur.

##### Kaynak(lar) ve ileri okuma: anahtar-değer deposu

* [Anahtar-değer veritabanı](https://en.wikipedia.org/wiki/Key-value_database)
* [Anahtar-değer depolarının dezavantajları](http://stackoverflow.com/questions/4056093/what-are-the-disadvantages-of-using-a-key-value-table-over-nullable-columns-or)
* [Redis mimarisi](http://qnimate.com/overview-of-redis-architecture/)
* [Memcached mimarisi](https://adayinthelifeof.nl/2011/02/06/memcache-internals/)

#### Doküman deposu

> Soyutlama: Anahtar-değer deposu, belgeler değer olarak saklanır

Bir doküman deposu, belgeler (XML, JSON, ikili, vb.) etrafında merkezlenir; bir belge, belirli bir nesneye ait tüm bilgileri saklar. Doküman depoları, belgenin iç yapısına göre sorgulama yapmak için API'ler veya bir sorgu dili sağlar. *Not: Birçok anahtar-değer deposu, bir değerin meta verisiyle çalışmak için özellikler sunar ve bu iki depolama türü arasındaki çizgileri bulanıklaştırır.*

Altta yatan uygulamaya bağlı olarak, belgeler koleksiyonlar, etiketler, meta veriler veya dizinler aracılığıyla düzenlenir. Belgeler organize edilebilse veya gruplanabilse de, belgeler birbirinden tamamen farklı alanlara sahip olabilir.

Bazı doküman depoları, [MongoDB](https://www.mongodb.com/mongodb-architecture) ve [CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/) gibi, karmaşık sorgular gerçekleştirmek için SQL benzeri bir dil sağlar. [DynamoDB](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) hem anahtar-değerleri hem de belgeleri destekler.

Doküman depoları yüksek esneklik sağlar ve genellikle ara sıra değişen verilerle çalışmak için kullanılır.

##### Kaynak(lar) ve daha fazla okuma: doküman deposu

* [Belge odaklı veritabanı](https://en.wikipedia.org/wiki/Document-oriented_database)
* [MongoDB mimarisi](https://www.mongodb.com/mongodb-architecture)
* [CouchDB mimarisi](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/)
* [Elasticsearch mimarisi](https://www.elastic.co/blog/found-elasticsearch-from-the-bottom-up)

#### Geniş sütun deposu

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n16iOGk.png">
  <br/>
  <i><a href=http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html>Kaynak: SQL & NoSQL, kısa bir tarihçe</a></i>
</p>

> Soyutlama: iç içe harita `ColumnFamily<RowKey, Columns<ColKey, Value, Timestamp>>`

Bir geniş sütun deposunun temel veri birimi bir sütundur (isim/değer çifti). Bir sütun, sütun ailelerinde (SQL tablosuna benzer) gruplanabilir. Süper sütun aileleri ise sütun ailelerini daha da gruplar. Her bir sütuna bir satır anahtarı ile bağımsız olarak erişebilirsiniz ve aynı satır anahtarına sahip sütunlar bir satırı oluşturur. Her değer, sürümleme ve çakışma çözümü için bir zaman damgası içerir.

Google, ilk geniş sütun deposu olarak [Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf)'ı tanıttı; bu, Hadoop ekosisteminde sıkça kullanılan açık kaynak [HBase](https://www.edureka.co/blog/hbase-architecture/) ve Facebook'tan [Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)'yı etkiledi. BigTable, HBase ve Cassandra gibi depolar anahtarları leksikografik sırada tutar, böylece seçici anahtar aralıklarının verimli bir şekilde alınmasını sağlar.

Geniş sütun depoları yüksek kullanılabilirlik ve yüksek ölçeklenebilirlik sunar. Genellikle çok büyük veri kümeleri için kullanılırlar.

##### Kaynak(lar) ve daha fazla okuma: geniş sütun deposu

* [SQL & NoSQL, kısa bir tarihçe](http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html)
* [Bigtable mimarisi](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf)
* [HBase mimarisi](https://www.edureka.co/blog/hbase-architecture/)
* [Cassandra mimarisi](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)

#### Grafik veritabanı

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/fNcl65g.png">
  <br/>
  <i><a href=https://en.wikipedia.org/wiki/File:GraphDatabase_PropertyGraph.png>Kaynak: Grafik veritabanı</a></i>
</p>

> Soyutlama: grafik

Bir grafik veritabanında, her düğüm bir kayıttır ve her yay iki düğüm arasındaki ilişkidir. Grafik veritabanları, çok sayıda yabancı anahtar veya çoktan çoğa ilişkileri olan karmaşık ilişkileri temsil etmek için optimize edilmiştir.

Grafik veritabanları, sosyal ağ gibi karmaşık ilişkilere sahip veri modelleri için yüksek performans sunar. Görece yenidirler ve henüz yaygın olarak kullanılmazlar; geliştirme araçları ve kaynaklarını bulmak daha zor olabilir. Birçok grafiğe yalnızca [REST API'leri](#representational-state-transfer-rest) ile erişilebilir.

##### Kaynak(lar) ve daha fazla okuma: grafik

* [Grafik veritabanı](https://en.wikipedia.org/wiki/Graph_database)
* [Neo4j](https://neo4j.com/)
* [FlockDB](https://blog.twitter.com/2010/introducing-flockdb)

#### Kaynak(lar) ve daha fazla okuma: NoSQL

* [Temel terminolojinin açıklaması](http://stackoverflow.com/questions/3342497/explanation-of-base-terminology)
* [NoSQL veritabanları: bir inceleme ve karar rehberi](https://medium.com/baqend-blog/nosql-databases-a-survey-and-decision-guidance-ea7823a822d#.wskogqenq)
* [Ölçeklenebilirlik](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
* [NoSQL'e giriş](https://www.youtube.com/watch?v=qI_g07C_Q5I)
* [NoSQL desenleri](http://horicky.blogspot.com/2009/11/nosql-patterns.html)

### SQL veya NoSQL

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wXGqG5f.png">
  <br/>
  <i><a href=https://www.infoq.com/articles/Transition-RDBMS-NoSQL/>Kaynak: RDBMS'den NoSQL'e Geçiş</a></i>
</p>

**SQL** için nedenler:

* Yapılandırılmış veri
* Katı şema
* İlişkisel veri
* Karmaşık birleştirmelere ihtiyaç
* İşlemler
* Ölçeklendirme için net desenler
* Daha köklü: geliştiriciler, topluluk, kod, araçlar, vb.
* İndeksle aramalar çok hızlıdır

**NoSQL** için nedenler:

* Yarı yapılandırılmış veri
* Dinamik veya esnek şema
* İlişkisel olmayan veri
* Karmaşık birleştirmelere ihtiyaç yok
* Birçok TB (veya PB) veri depolama
* Çok veri yoğun iş yükü
* IOPS için çok yüksek verim

NoSQL için uygun örnek veri:

* Tıklama akışı ve log verisinin hızlı alınması
* Lider tablosu veya skor verisi
* Geçici veri, örneğin alışveriş sepeti
* Sık erişilen ('sıcak') tablolar
* Meta veri/bakış tabloları

##### Kaynak(lar) ve daha fazla okuma: SQL veya NoSQL

* [İlk 10 milyon kullanıcınıza ölçeklendirme](https://www.youtube.com/watch?v=kKjm4ehYiMs)
* [SQL ve NoSQL farkları](https://www.sitepoint.com/sql-vs-nosql-differences/)

## Önbellek

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Q6z24La.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>Kaynak: Ölçeklenebilir sistem tasarım desenleri</a></i>
</p>

Önbellekleme, sayfa yükleme sürelerini iyileştirir ve sunucularınız ile veritabanlarınızdaki yükü azaltabilir. Bu modelde, yönlendirici önce isteğin daha önce yapılıp yapılmadığını kontrol eder ve önceki sonucu bulup döndürmeye çalışır, böylece gerçek yürütmeden tasarruf edilir.

Veritabanları genellikle okuma ve yazmaların bölümler arasında eşit dağılımından fayda sağlar. Popüler öğeler dağılımı bozabilir ve darboğazlara neden olabilir. Bir veritabanının önüne bir önbellek koymak, düzensiz yükleri ve trafik artışlarını absorbe edebilir.

### İstemci önbelleklemesi

Önbellekler istemci tarafında (İşletim Sistemi veya tarayıcıda), [sunucu tarafında](#reverse-proxy-web-server) veya ayrı bir önbellek katmanında bulunabilir.

### CDN önbelleklemesi

[CDN'ler](#content-delivery-network) bir tür önbellek olarak kabul edilir.

### Web sunucusu önbelleklemesi

[Ters proxyler](#reverse-proxy-web-server) ve [Varnish](https://www.varnish-cache.org/) gibi önbellekler statik ve dinamik içeriği doğrudan sunabilir. Web sunucuları ayrıca isteklere önbellek uygulayabilir, yanıtları uygulama sunucularına başvurmadan döndürebilir.

### Veritabanı önbelleklemesi

Veritabanınız genellikle varsayılan yapılandırmasında, genel bir kullanım senaryosu için optimize edilmiş bir önbellekleme düzeyi içerir. Bu ayarları belirli kullanım desenleri için özelleştirmek performansı daha da artırabilir.

### Uygulama önbelleklemesi

Memcached ve Redis gibi bellek içi önbellekler, uygulamanız ile veri depolamanız arasında anahtar-değer depolarıdır. Veriler RAM'de tutulduğundan, verilerin diskte saklandığı tipik veritabanlarından çok daha hızlıdır. RAM, diske göre daha sınırlıdır, bu nedenle [önbellek geçersiz kılma](https://en.wikipedia.org/wiki/Cache_algorithms) algoritmaları, örneğin [en son kullanılan (LRU)](https://en.wikipedia.org/wiki/Cache_replacement_policies#Least_recently_used_(LRU)), 'soğuk' girdileri geçersiz kılmaya ve 'sıcak' verileri RAM'de tutmaya yardımcı olabilir.

Redis aşağıdaki ek özelliklere sahiptir:

* Kalıcılık seçeneği
* Sıralı setler ve listeler gibi yerleşik veri yapıları

Önbelleğe alabileceğiniz birden çok seviye vardır ve bunlar iki genel kategoriye ayrılır: **veritabanı sorguları** ve **nesneler**:

* Satır düzeyi
* Sorgu düzeyi
* Tamamlanmış serileştirilebilir nesneler
* Tam olarak işlenmiş HTML

Genellikle, dosya tabanlı önbelleklemeden kaçınmalısınız, çünkü bu klonlama ve otomatik ölçeklendirmeyi zorlaştırır.

### Veritabanı sorgu seviyesinde önbellekleme

Veritabanını her sorguladığınızda, sorguyu bir anahtar olarak hashleyin ve sonucu önbelleğe kaydedin.  Bu yaklaşım, süre sonu (expiration) sorunlarından muzdariptir:

* Karmaşık sorgularda önbellekteki bir sonucu silmek zordur
* Bir veri parçası değiştiğinde (örneğin bir tablo hücresi), değişen hücreyi içerebilecek tüm önbellekteki sorguları silmeniz gerekir

### Nesne seviyesinde önbellekleme

Verinizi, uygulama kodunuzda yaptığınız gibi bir nesne olarak görün.  Uygulamanız, veritabanından veri kümesini bir sınıf örneği veya veri yapısına toplar:

* Nesnenin altındaki veri değiştiyse, nesneyi önbellekten kaldırın
* Eşzamanlı olmayan işleme imkanı sağlar: çalışanlar, en güncel önbellekteki nesneyi tüketerek nesneleri oluşturur

Neleri önbelleğe alabileceğinize dair öneriler:

* Kullanıcı oturumları
* Tamamen işlenmiş web sayfaları
* Aktivite akışları
* Kullanıcı grafik verisi

### Önbelleği ne zaman güncellemeli

Önbellekte yalnızca sınırlı miktarda veri saklayabileceğiniz için, hangi önbellek güncelleme stratejisinin sizin kullanım senaryonuza en uygun olduğuna karar vermeniz gerekir.

#### Cache-aside (Yan önbellek)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/ONjORqk.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>Kaynak: Önbellekten bellek içi veri ızgarasına</a></i>
</p>

Uygulama, depolamadan okuma ve yazmadan sorumludur.  Önbellek, doğrudan depolama ile etkileşime girmez.  Uygulama aşağıdakileri yapar:

* Önbellekte girdi arar, önbellek kaçırma ile sonuçlanır
* Girdiyi veritabanından yükler
* Girdiyi önbelleğe ekler
* Girdiyi döndürür

```python
def get_user(self, user_id):
    user = cache.get("user.{0}", user_id)
    if user is None:
        user = db.query("SELECT * FROM users WHERE user_id = {0}", user_id)
        if user is not None:
            key = "user.{0}".format(user_id)
            cache.set(key, json.dumps(user))
    return user
```

[Memcached](https://memcached.org/) genellikle bu şekilde kullanılır.

Önbelleğe eklenen verilerin sonraki okumaları hızlıdır. Cache-aside aynı zamanda tembel yükleme olarak da adlandırılır. Yalnızca istenen veriler önbelleğe alınır, böylece istenmeyen verilerle önbelleğin dolması önlenir.

##### Dezavantaj(lar): cache-aside

* Her önbellek kaçırması üç yolculuğa neden olur, bu da fark edilir bir gecikmeye yol açabilir.
* Veriler veritabanında güncellenirse bayatlayabilir. Bu sorun, önbellek kaydının güncellenmesini zorunlu kılan bir yaşam süresi (TTL) ayarlanarak veya write-through kullanılarak hafifletilir.
* Bir düğüm arızalandığında, yeni ve boş bir düğümle değiştirilir, bu da gecikmeyi artırır.

#### Write-through

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/0vBc0hN.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Kaynak: Ölçeklenebilirlik, erişilebilirlik, stabilite, desenler</a></i>
</p>

Uygulama, önbelleği ana veri deposu olarak kullanır, verileri okur ve yazar, önbellek ise veritabanına okuma ve yazma işlemlerinden sorumludur:

* Uygulama önbelleğe kayıt ekler/günceller
* Önbellek kaydı veri deposuna eşzamanlı olarak yazar
* Dönüş

Uygulama kodu:

```python
set_user(12345, {"foo":"bar"})
```

Önbellek kodu:

```python
def set_user(user_id, values):
    user = db.query("UPDATE Users WHERE id = {0}", user_id, values)
    cache.set(user_id, user)
```
Write-through, yazma işlemi nedeniyle genel olarak yavaş bir işlemdir, ancak yeni yazılan verilerin sonraki okunmaları hızlıdır. Kullanıcılar genellikle veri güncellemesi yaparken gecikmeye okuma işlemine göre daha toleranslıdır. Önbellekteki veri bayat değildir.

##### Dezavantaj(lar): write through

* Bir arıza veya ölçeklendirme nedeniyle yeni bir düğüm oluşturulduğunda, yeni düğüm veritabanındaki giriş güncellenene kadar girişleri önbelleğe almaz. Cache-aside ile write through birlikte kullanılarak bu sorun hafifletilebilir.
* Yazılan verilerin çoğu hiçbir zaman okunmayabilir, bu TTL ile en aza indirilebilir.

#### Write-behind (write-back)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/rgSrvjG.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>Kaynak: Ölçeklenebilirlik, kullanılabilirlik, stabilite, desenler</a></i>
</p>

Write-behind'da uygulama aşağıdaki işlemleri yapar:

* Önbellekte giriş ekle/güncelle
* Girişi veri deposuna asenkron olarak yazar, yazma performansını artırır

##### Dezavantaj(lar): write-behind

* Önbellek içeriği veri deposuna ulaşmadan önce önbellek kapanırsa veri kaybı olabilir.
* Write-behind uygulamak, cache-aside veya write-through uygulamaktan daha karmaşıktır.

#### Refresh-ahead

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/kxtjqgE.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>Kaynak: Önbellekten bellek içi veri ızgarasına</a></i>
</p>

Önbelleği, yakın zamanda erişilen herhangi bir önbellek girişini süresi dolmadan önce otomatik olarak yenileyecek şekilde yapılandırabilirsiniz.

Refresh-ahead, önbellek gelecekte hangi öğelerin gerekebileceğini doğru tahmin edebilirse, read-through'a göre gecikmeyi azaltabilir.

##### Dezavantaj(lar): refresh-ahead


* Gelecekte hangi öğelere ihtiyaç duyulacağının doğru tahmin edilememesi, refresh-ahead olmadan olduğundan daha düşük performansa yol açabilir.

### Dezavantaj(lar): önbellek

* Önbellekler ile veritabanı gibi gerçek kaynak arasında [önbellek geçersizleştirme](https://en.wikipedia.org/wiki/Cache_algorithms) ile tutarlılık sağlanmalıdır.
* Önbellek geçersizleştirme zor bir problemdir, önbelleğin ne zaman güncelleneceği ile ilgili ek karmaşıklık vardır.
* Redis veya memcached eklemek gibi uygulama değişiklikleri yapmak gerekir.

### Kaynak(lar) ve ileri okuma

* [Önbellekten bellek içi veri ızgarasına](http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast)
* [Ölçeklenebilir sistem tasarım desenleri](http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html)
* [Ölçek için sistem mimarisine giriş](http://lethain.com/introduction-to-architecting-systems-for-scale/)
* [Ölçeklenebilirlik, erişilebilirlik, stabilite, desenler](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [Ölçeklenebilirlik](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
* [AWS ElastiCache stratejileri](http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Strategies.html)
* [Vikipedi](https://en.wikipedia.org/wiki/Cache_(computing))

## Asenkronluk

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/54GYsSx.png">
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>Kaynak: Ölçek için sistem mimarisine giriş</a></i>
</p>

Asenkron iş akışları, satır içi gerçekleştirilecek pahalı işlemler için istek sürelerini azaltmaya yardımcı olur. Ayrıca, veri toplamanın periyodik olarak önceden yapılması gibi zaman alan işleri önceden gerçekleştirerek de fayda sağlar.

### Mesaj kuyrukları

Mesaj kuyrukları mesajları alır, tutar ve teslim eder. Bir işlemin satır içi gerçekleştirilmesi çok yavaşsa, aşağıdaki iş akışıyla bir mesaj kuyruğu kullanılabilir:

* Bir uygulama kuyruğa bir işi gönderir, ardından kullanıcıya iş durumu bildirir
* Bir çalışan kuyruğundan işi alır, işler ve işin tamamlandığını bildirir

Kullanıcı engellenmez ve iş arka planda işlenir. Bu süre zarfında, istemci isteğin tamamlandığını göstermek için küçük bir işlem yapabilir. Örneğin, bir tweet gönderiliyorsa, tweet anında zaman çizelgenize eklenebilir fakat tüm takipçilerinize ulaşması biraz zaman alabilir.

**[Redis](https://redis.io/)** basit bir mesaj aracısı olarak kullanışlıdır, ancak mesajlar kaybolabilir.

**[RabbitMQ](https://www.rabbitmq.com/)** popülerdir ancak 'AMQP' protokolüne uyum sağlamanızı ve kendi sunucularınızı yönetmenizi gerektirir.

**[Amazon SQS](https://aws.amazon.com/sqs/)** barındırılır ancak yüksek gecikmeye sahip olabilir ve mesajların iki kez teslim edilme olasılığı vardır.

### Görev kuyrukları

Görev kuyrukları görevleri ve ilgili verilerini alır, çalıştırır ve ardından sonuçlarını iletir. Zamanlama desteği sunabilirler ve arka planda hesaplama açısından yoğun işleri çalıştırmak için kullanılabilirler.

**[Celery](https://docs.celeryproject.org/en/stable/)** zamanlama desteğine sahiptir ve esas olarak python desteği bulunur.

### Geri basınç

Kuyruklar önemli ölçüde büyümeye başlarsa, kuyruk boyutu belleği aşabilir ve bu durum önbellek kaçırmaları, disk okuma işlemleri ve daha yavaş performansa yol açabilir. [Geri basınç](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html) kuyruk boyutunu sınırlandırarak yüksek iş hacmi oranı ve kuyrukta bulunan işler için iyi yanıt sürelerinin korunmasına yardımcı olur. Kuyruk dolduğunda, istemciler sunucu meşgul veya HTTP 503 durum kodu alır ve daha sonra tekrar denemeleri istenir. İstemciler isteği daha sonraki bir zamanda, örneğin [üstel geri çekilme](https://en.wikipedia.org/wiki/Exponential_backoff) ile yeniden deneyebilir.

### Dezavantaj(lar): asenkronluk

* Ucuz hesaplamalar ve gerçek zamanlı iş akışları gibi kullanım durumları senkron işlemler için daha uygun olabilir, çünkü kuyrukların eklenmesi gecikme ve karmaşıklık yaratabilir.

### Kaynak(lar) ve daha fazla okuma

* [Hepsi bir sayı oyunudur](https://www.youtube.com/watch?v=1KRYH75wgy4)
* [Aşırı yüklenmede geri basınç uygulama](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html)
* [Little'ın yasası](https://en.wikipedia.org/wiki/Little%27s_law)
* [Mesaj kuyruğu ile görev kuyruğu arasındaki fark nedir?](https://www.quora.com/What-is-the-difference-between-a-message-queue-and-a-task-queue-Why-would-a-task-queue-require-a-message-broker-like-RabbitMQ-Redis-Celery-or-IronMQ-to-function)

## İletişim

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/5KeocQs.jpg">
  <br/>
  <i><a href=http://www.escotal.com/osilayer.html>Kaynak: OSI 7 katmanlı model</a></i>
</p>

### Hiper metin aktarım protokolü (HTTP)

HTTP, bir istemci ile bir sunucu arasında veri kodlamak ve taşımak için kullanılan bir yöntemdir. İstek/yanıt protokolüdür: istemciler istek gönderir ve sunucular istekle ilgili içerik ve tamamlanma durumu bilgisiyle yanıt verir. HTTP kendi başına çalışır, bu sayede istek ve yanıtlar yük dengeleme, önbellekleme, şifreleme ve sıkıştırma yapan birçok ara yönlendirici ve sunucudan geçebilir.

Temel bir HTTP isteği bir fiil (metot) ve bir kaynak (uç nokta) içerir. Aşağıda yaygın HTTP fiilleri verilmiştir:

| Fiil | Açıklama | Idempotent* | Güvenli | Önbelleklenebilir |

| GET | Bir kaynağı okur | Evet | Evet | Evet |
| POST | Bir kaynak oluşturur veya verileri işleyen bir süreci tetikler | Hayır | Hayır | Yanıt tazelik bilgisi içeriyorsa Evet |
| PUT | Bir kaynağı oluşturur veya değiştirir | Evet | Hayır | Hayır |
| PATCH | Bir kaynağı kısmen günceller | Hayır | Hayır | Yanıt tazelik bilgisi içeriyorsa Evet |
| DELETE | Bir kaynağı siler | Evet | Hayır | Hayır |

*Farklı sonuçlar olmadan birçok kez çağrılabilir.

HTTP, **TCP** ve **UDP** gibi alt seviye protokollere bağlı bir uygulama katmanı protokolüdür.

#### Kaynak(lar) ve daha fazla okuma: HTTP

* [HTTP nedir?](https://www.nginx.com/resources/glossary/http/)
* [HTTP ve TCP arasındaki fark](https://www.quora.com/What-is-the-difference-between-HTTP-protocol-and-TCP-protocol)
* [PUT ve PATCH arasındaki fark](https://laracasts.com/discuss/channels/general-discussion/whats-the-differences-between-put-and-patch?page=1)

### İletim Kontrol Protokolü (TCP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/JdAsdvG.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>Kaynak: Çok oyunculu bir oyun nasıl yapılır</a></i>
</p>

TCP, [IP ağı](https://en.wikipedia.org/wiki/Internet_Protocol) üzerinden bağlantı odaklı bir protokoldür.  Bağlantı, bir [el sıkışma](https://en.wikipedia.org/wiki/Handshaking) ile kurulur ve sonlandırılır.  Gönderilen tüm paketlerin orijinal sırada ve bozulmadan hedefe ulaşması şu yollarla garanti edilir:

* Her paket için sıra numaraları ve [checksum alanları](https://en.wikipedia.org/wiki/Transmission_Control_Protocol#Checksum_computation)
* [Onay](https://en.wikipedia.org/wiki/Acknowledgement_(data_networks)) paketleri ve otomatik yeniden iletim

Gönderen doğru yanıt almazsa, paketleri yeniden gönderir.  Birden fazla zaman aşımı olursa bağlantı kesilir.  TCP ayrıca [akış kontrolü](https://en.wikipedia.org/wiki/Flow_control_(data)) ve [tıkanıklık kontrolü](https://en.wikipedia.org/wiki/Network_congestion#Congestion_control) uygular.  Bu garantiler gecikmelere neden olur ve genellikle UDP'den daha az verimli iletim sağlar.

Yüksek veri aktarımını sağlamak için web sunucuları çok sayıda TCP bağlantısını açık tutabilir, bu da yüksek bellek kullanımıyla sonuçlanır.  Web sunucu iş parçacıkları ile örneğin bir [memcached](https://memcached.org/) sunucusu arasında çok sayıda açık bağlantı olması maliyetli olabilir.  [Bağlantı havuzu](https://en.wikipedia.org/wiki/Connection_pool) yardımcı olabilir ve uygun olduğunda UDP'ye geçiş yapılabilir.

TCP, yüksek güvenilirlik gerektiren ancak zaman açısından kritik olmayan uygulamalar için uygundur.  Bazı örnekler arasında web sunucuları, veritabanı bilgisi, SMTP, FTP ve SSH bulunur.

TCP’yi UDP yerine kullanın, eğer:

* Tüm verilerin sağlam bir şekilde ulaşmasını istiyorsanız
* Ağ bant genişliğinin en iyi şekilde otomatik tahmin edilerek kullanılmasını istiyorsanız

### Kullanıcı veri gramı protokolü (UDP)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yzDrJtA.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>Kaynak: Çok oyunculu oyun nasıl yapılır</a></i>
</p>

UDP bağlantısızdır. Veri grupları (paketlere benzer) sadece veri grubu seviyesinde garanti edilir. Veri grupları hedeflerine sırasız veya hiç ulaşmayabilir. UDP, tıkanıklık kontrolünü desteklemez. TCP'nin sağladığı garantiler olmadan UDP genellikle daha verimlidir.

UDP yayın yapabilir, veri gruplarını alt ağdaki tüm cihazlara gönderebilir. Bu, [DHCP](https://en.wikipedia.org/wiki/Dynamic_Host_Configuration_Protocol) ile kullanışlıdır çünkü istemci henüz bir IP adresi almamıştır ve bu nedenle IP adresi olmadan TCP akışı için bir yol engellenir.

UDP daha az güvenilirdir ancak VoIP, video sohbet, yayın akışı ve gerçek zamanlı çok oyunculu oyunlar gibi gerçek zamanlı kullanım senaryolarında iyi çalışır.

Aşağıdaki durumlarda TCP yerine UDP kullanın:

* En düşük gecikmeye ihtiyacınız varsa
* Geç veri, veri kaybından daha kötüyse
* Kendi hata düzeltmenizi uygulamak istiyorsanız

#### Kaynak(lar) ve daha fazla okuma: TCP ve UDP

* [Oyun programlama için ağ](http://gafferongames.com/networking-for-game-programmers/udp-vs-tcp/)
* [TCP ve UDP protokolleri arasındaki temel farklar](http://www.cyberciti.biz/faq/key-differences-between-tcp-and-udp-protocols/)
* [TCP ve UDP arasındaki fark](http://stackoverflow.com/questions/5970383/difference-between-tcp-and-udp)
* [Aktarım kontrol protokolü](https://en.wikipedia.org/wiki/Transmission_Control_Protocol)
* [Kullanıcı veri gramı protokolü](https://en.wikipedia.org/wiki/User_Datagram_Protocol)
* [Facebook'ta memcache ölçeklendirme](http://www.cs.bu.edu/~jappavoo/jappavoo.github.com/451/papers/memcache-fb.pdf)

### Uzaktan prosedür çağrısı (RPC)

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/iF4Mkb5.png">
  <br/>
  <i><a href=http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview>Kaynak: Sistem tasarımı mülakatını çöz</a></i>
</p>

Bir RPC'de, bir istemci genellikle uzak bir sunucuda farklı bir adres alanında bir prosedürün çalışmasını sağlar. Prosedür, yerel bir prosedür çağrısı gibi kodlanır; istemci programından sunucu ile nasıl iletişim kurulacağı ayrıntıları soyutlanır. Uzaktaki çağrılar genellikle yerel çağrılardan daha yavaş ve daha az güvenilirdir, bu nedenle RPC çağrılarını yerel çağrılardan ayırmak faydalıdır. Popüler RPC çerçeveleri arasında [Protobuf](https://developers.google.com/protocol-buffers/), [Thrift](https://thrift.apache.org/) ve [Avro](https://avro.apache.org/docs/current/) bulunur.

RPC bir istek-yanıt protokolüdür:

* **İstemci programı** - İstemci ara birimi prosedürünü çağırır. Parametreler, yerel prosedür çağrısındaki gibi yığına eklenir.
* **İstemci ara birimi prosedürü** - Prosedür kimliği ve argümanları bir istek mesajına paketler (marshalling).
* **İstemci iletişim modülü** - İşletim sistemi, mesajı istemciden sunucuya gönderir.
* **Sunucu iletişim modülü** - İşletim sistemi, gelen paketleri sunucu ara birimi prosedürüne iletir.
* **Sunucu ara birimi prosedürü** - Sonuçları açar (unmarshalling), prosedür kimliğiyle eşleşen sunucu prosedürünü çağırır ve verilen argümanları iletir.
* Sunucu yanıtı, yukarıdaki adımların ters sırasıyla tekrar edilir.

Örnek RPC çağrıları:

```
GET /someoperation?data=anId

POST /anotheroperation
{
  "data":"anId";
  "anotherdata": "another value"
}
```

RPC, davranışları ortaya çıkarmaya odaklanır.  RPC'ler genellikle iç iletişimlerde performans nedenleriyle kullanılır, çünkü yerel çağrıları el ile oluşturarak kullanım senaryolarınıza daha iyi uyum sağlayabilirsiniz.

Yerel bir kütüphaneyi (SDK olarak da bilinir) şu durumlarda seçin:

* Hedef platformunuzu biliyorsanız.
* "Mantığınızın" nasıl erişileceğini kontrol etmek istiyorsanız.
* Hata kontrolünün kütüphaneniz dışında nasıl gerçekleşeceğini kontrol etmek istiyorsanız.
* Performans ve son kullanıcı deneyimi birincil önceliğiniz ise.

**REST**'i takip eden HTTP API'ler genellikle halka açık API'ler için daha fazla kullanılır.

#### Dezavantaj(lar): RPC

* RPC istemcileri, hizmet uygulamasına sıkı şekilde bağımlı hale gelir.
* Her yeni işlem veya kullanım senaryosu için yeni bir API tanımlanmalıdır.
* RPC'yi hata ayıklamak zor olabilir.
* Var olan teknolojilerden kutudan çıktığı gibi faydalanamayabilirsiniz.  Örneğin, [RPC çağrılarının önbellekleme sunucularında](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/) (ör. [Squid](http://www.squid-cache.org/)) düzgün şekilde önbelleklendiğinden emin olmak ek çaba gerektirebilir.

### Temsili durum aktarımı (REST)

REST, istemcinin sunucu tarafından yönetilen bir kaynak kümesi üzerinde işlem yaptığı istemci/sunucu modelini zorunlu kılan bir mimari tarzdır.  Sunucu, kaynakların bir temsilini ve bu kaynakların temsilini değiştiren veya yeni bir temsilini alan işlemleri sağlar.  Tüm iletişimler durumsuz ve önbelleğe alınabilir olmalıdır.

RESTful bir arayüzün dört özelliği vardır:

* **Kaynakları tanımla (HTTP'de URI)** - herhangi bir işlemden bağımsız olarak aynı URI'yi kullanın.
* **Temsillerle değiştir (HTTP'de Fiiller)** - fiilleri, başlıkları ve gövdeyi kullanın.
* **Kendi kendini açıklayan hata mesajı (HTTP'de durum yanıtı)** - Durum kodlarını kullanın, tekerleği yeniden icat etmeyin.
* **[HATEOAS](http://restcookbook.com/Basics/hateoas/) (HTTP için HTML arayüzü)** - web servisiniz tamamen bir tarayıcıda erişilebilir olmalıdır.

Örnek REST çağrıları:

```
GET /someresources/anId

PUT /someresources/anId
{"anotherdata": "another value"}
```

REST, verilerin sunulmasına odaklanır. İstemci/sunucu arasındaki bağı en aza indirir ve genellikle halka açık HTTP API'lerinde kullanılır. REST, kaynakları URI’ler aracılığıyla, [başlıklar üzerinden temsili](https://github.com/for-GET/know-your-http-well/blob/master/headers.md) ile ve GET, POST, PUT, DELETE ve PATCH gibi fiillerle daha genel ve uniform bir şekilde sunar. Durumsuz olması sayesinde REST, yatay ölçeklendirme ve bölümlendirme için idealdir.

#### Dezavantaj(lar): REST

* REST, verilerin sunulmasına odaklandığı için, kaynaklar doğal olarak basit bir hiyerarşide düzenlenmemiş veya erişilmiyorsa iyi bir seçenek olmayabilir. Örneğin, belirli bir olay kümesiyle eşleşen son bir saat içindeki tüm güncellenmiş kayıtları döndürmek, bir yol olarak kolayca ifade edilemez. REST ile bu, büyük olasılıkla URI yolu, sorgu parametreleri ve muhtemelen istek gövdesinin birleşimiyle uygulanır.
* REST genellikle birkaç fiile (GET, POST, PUT, DELETE ve PATCH) dayanır, bu da bazen kullanım senaryonuza uymayabilir. Örneğin, süresi dolmuş belgeleri arşiv klasörüne taşımak bu fiillerle tam olarak örtüşmeyebilir.
* İç içe geçmiş hiyerarşilere sahip karmaşık kaynakların alınması, tek bir görünümü işlemek için istemci ile sunucu arasında birden fazla tur gerektirir; örneğin, bir blog girdisinin içeriği ve o girdiye yapılan yorumları almak. Değişken ağ koşullarında çalışan mobil uygulamalar için bu çoklu turlar oldukça istenmeyen bir durumdur.
* Zamanla, bir API yanıtına daha fazla alan eklenebilir ve eski istemciler, ihtiyaç duymadıkları tüm yeni veri alanlarını alır; bu da yük boyutunu artırır ve daha büyük gecikmelere yol açar.

### RPC ve REST çağrıları karşılaştırması

| İşlem | RPC | REST |
|---|---|---|
| Kayıt Ol    | **POST** /signup | **POST** /persons |
| İstifa Et    | **POST** /resign<br/>{<br/>"personid": "1234"<br/>} | **DELETE** /persons/1234 |
| Bir kişiyi oku | **GET** /readPerson?personid=1234 | **GET** /persons/1234 |
| Bir kişinin ürünler listesini oku | **GET** /readUsersItemsList?personid=1234 | **GET** /persons/1234/items |
| Bir kişinin ürünler listesine ürün ekle | **POST** /addItemToUsersItemsList<br/>{<br/>"personid": "1234";<br/>"itemid": "456"<br/>} | **POST** /persons/1234/items<br/>{<br/>"itemid": "456"<br/>} |
| Bir ürünü güncelle    | **POST** /modifyItem<br/>{<br/>"itemid": "456";<br/>"key": "value"<br/>} | **PUT** /items/456<br/>{<br/>"key": "value"<br/>} |
| Bir ürünü sil | **POST** /removeItem<br/>{<br/>"itemid": "456"<br/>} | **DELETE** /items/456 |

<p align="center">
  <i><a href=https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/>Kaynak: Gerçekten REST’i RPC’ye neden tercih ettiğinizi biliyor musunuz?</a></i>
</p>

#### Kaynak(lar) ve daha fazla okuma: REST ve RPC

* [Gerçekten REST’i RPC’ye neden tercih ettiğinizi biliyor musunuz?](https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/)
* [Ne zaman RPC-benzeri yaklaşımlar REST’ten daha uygundur?](http://programmers.stackexchange.com/a/181186)
* [REST vs JSON-RPC](http://stackoverflow.com/questions/15056878/rest-vs-json-rpc)
* [RPC ve REST’in efsanelerini çürütmek](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/)
* [RESTful API’lerin dezavantajları nelerdir?](https://www.quora.com/What-are-the-drawbacks-of-using-RESTful-APIs)
* [Sistem tasarım mülakatını çözün](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Thrift](https://code.facebook.com/posts/1468950976659943/)
* [Neden iç kullanımda REST, RPC değil?](http://arstechnica.com/civis/viewtopic.php?t=1190508)

## Güvenlik

Bu bölümün güncellenmeye ihtiyacı var. [Katkıda bulunmayı](#contributing) düşünün!

Güvenlik geniş bir konudur.  Önemli bir deneyiminiz, güvenlik geçmişiniz yoksa veya güvenlik bilgisi gerektiren bir pozisyona başvurmuyorsanız, muhtemelen temellerden fazlasını bilmenize gerek yoktur:

* Aktarım sırasında ve depolamada şifreleme yapın.
* [XSS](https://en.wikipedia.org/wiki/Cross-site_scripting) ve [SQL enjeksiyonu](https://en.wikipedia.org/wiki/SQL_injection) önlemek için tüm kullanıcı girdilerini veya kullanıcıya açık herhangi bir girdi parametresini temizleyin.
* SQL enjeksiyonunu önlemek için parametreli sorgular kullanın.
* [En az ayrıcalık](https://en.wikipedia.org/wiki/Principle_of_least_privilege) ilkesini kullanın.

### Kaynak(lar) ve ileri okuma

* [API güvenlik kontrol listesi](https://github.com/shieldfy/API-Security-Checklist)
* [Geliştiriciler için güvenlik rehberi](https://github.com/FallibleInc/security-guide-for-developers)
* [OWASP ilk on](https://www.owasp.org/index.php/OWASP_Top_Ten_Cheat_Sheet)

## Ek

Bazen sizden 'kabataslak' tahminler yapmanız istenecektir.  Örneğin, diskteki 100 görüntü küçük resminin oluşturulmasının ne kadar süreceğini veya bir veri yapısının ne kadar bellek kullanacağını belirlemeniz gerekebilir.  **İki tablosunun kuvvetleri** ve **Her programcının bilmesi gereken gecikme sayıları** faydalı başvuru kaynaklarıdır.

### İki tablosunun kuvvetleri

```
Power           Exact Value         Approx Value        Bytes
---------------------------------------------------------------
7                             128
8                             256
10                           1024   1 thousand           1 KB
16                         65,536                       64 KB
20                      1,048,576   1 million            1 MB
30                  1,073,741,824   1 billion            1 GB
32                  4,294,967,296                        4 GB
40              1,099,511,627,776   1 trillion           1 TB
```

#### Kaynak(lar) ve daha fazla okuma

* [İki'nin kuvvetleri](https://tr.wikipedia.org/wiki/İki_kat%C4%B1)

### Her programcının bilmesi gereken gecikme rakamları

```
Latency Comparison Numbers
--------------------------
L1 cache reference                           0.5 ns
Branch mispredict                            5   ns
L2 cache reference                           7   ns                      14x L1 cache
Mutex lock/unlock                           25   ns
Main memory reference                      100   ns                      20x L2 cache, 200x L1 cache
Compress 1K bytes with Zippy            10,000   ns       10 us
Send 1 KB bytes over 1 Gbps network     10,000   ns       10 us
Read 4 KB randomly from SSD*           150,000   ns      150 us          ~1GB/sec SSD
Read 1 MB sequentially from memory     250,000   ns      250 us
Round trip within same datacenter      500,000   ns      500 us
Read 1 MB sequentially from SSD*     1,000,000   ns    1,000 us    1 ms  ~1GB/sec SSD, 4X memory
HDD seek                            10,000,000   ns   10,000 us   10 ms  20x datacenter roundtrip
Read 1 MB sequentially from 1 Gbps  10,000,000   ns   10,000 us   10 ms  40x memory, 10X SSD
Read 1 MB sequentially from HDD     30,000,000   ns   30,000 us   30 ms 120x memory, 30X SSD
Send packet CA->Netherlands->CA    150,000,000   ns  150,000 us  150 ms

Notes
-----
1 ns = 10^-9 seconds
1 us = 10^-6 seconds = 1,000 ns
1 ms = 10^-3 seconds = 1,000 us = 1,000,000 ns
```
Yukarıdaki rakamlara dayalı kullanışlı metrikler:

* HDD'den ardışık okuma 30 MB/sn
* 1 Gbps Ethernet üzerinden ardışık okuma 100 MB/sn
* SSD'den ardışık okuma 1 GB/sn
* Ana bellekten ardışık okuma 4 GB/sn
* Dünya çapında saniyede 6-7 gidiş-dönüş
* Bir veri merkezinde saniyede 2.000 gidiş-dönüş

#### Gecikme değerlerinin görselleştirilmesi

![](https://camo.githubusercontent.com/77f72259e1eb58596b564d1ad823af1853bc60a3/687474703a2f2f692e696d6775722e636f6d2f6b307431652e706e67)

#### Kaynak(lar) ve daha fazla okuma

* [Her programcının bilmesi gereken gecikme sayıları - 1](https://gist.github.com/jboner/2841832)
* [Her programcının bilmesi gereken gecikme sayıları - 2](https://gist.github.com/hellerbarde/2843375)
* [Büyük dağıtık sistemler inşa ederken edinilen tasarımlar, dersler ve tavsiyeler](http://www.cs.cornell.edu/projects/ladis2009/talks/dean-keynote-ladis2009.pdf)
* [Büyük ölçekli dağıtık sistemler inşa ederken yazılım mühendisliği tavsiyeleri](https://static.googleusercontent.com/media/research.google.com/en//people/jeff/stanford-295-talk.pdf)

### Ek sistem tasarımı mülakat soruları

> Yaygın sistem tasarımı mülakat soruları ve her birini çözmek için kaynak bağlantıları.

| Soru | Kaynak(lar) |
|---|---|
| Dropbox gibi bir dosya senkronizasyon servisi tasarla | [youtube.com](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| Google gibi bir arama motoru tasarla | [queue.acm.org](http://queue.acm.org/detail.cfm?id=988407)<br/>[stackexchange.com](http://programmers.stackexchange.com/questions/38324/interview-question-how-would-you-implement-google-search)<br/>[ardendertat.com](http://www.ardendertat.com/2012/01/11/implementing-search-engines/)<br/>[stanford.edu](http://infolab.stanford.edu/~backrub/google.html) |
| Google gibi ölçeklenebilir bir web tarayıcı tasarla | [quora.com](https://www.quora.com/How-can-I-build-a-web-crawler-from-scratch) |
| Google docs tasarla | [code.google.com](https://code.google.com/p/google-mobwrite/)<br/>[neil.fraser.name](https://neil.fraser.name/writing/sync/) |
| Redis gibi bir anahtar-değer deposu tasarla | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| Memcached gibi bir önbellek sistemi tasarla | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| Amazon'unki gibi bir öneri sistemi tasarla | [hulu.com](https://web.archive.org/web/20170406065247/http://tech.hulu.com/blog/2011/09/19/recommendation-system.html)<br/>[ijcai13.org](http://ijcai13.org/files/tutorial_slides/td3.pdf) |
| Bitly gibi bir tinyurl sistemi tasarla | [n00tc0d3r.blogspot.com](http://n00tc0d3r.blogspot.com/) |
| WhatsApp gibi bir sohbet uygulaması tasarla | [highscalability.com](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html)
| Instagram gibi bir resim paylaşım sistemi tasarla | [highscalability.com](http://highscalability.com/flickr-architecture)<br/>[highscalability.com](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html) |
| Facebook haber kaynağı fonksiyonunu tasarla | [quora.com](http://www.quora.com/What-are-best-practices-for-building-something-like-a-News-Feed)<br/>[quora.com](http://www.quora.com/Activity-Streams/What-are-the-scaling-issues-to-keep-in-mind-while-developing-a-social-network-feed)<br/>[slideshare.net](http://www.slideshare.net/danmckinley/etsy-activity-feeds-architecture) |
| Facebook zaman tüneli fonksiyonunu tasarla | [facebook.com](https://www.facebook.com/note.php?note_id=10150468255628920)<br/>[highscalability.com](http://highscalability.com/blog/2012/1/23/facebook-timeline-brought-to-you-by-the-power-of-denormaliza.html) |
| Facebook sohbet fonksiyonunu tasarla | [erlang-factory.com](http://www.erlang-factory.com/upload/presentations/31/EugeneLetuchy-ErlangatFacebook.pdf)<br/>[facebook.com](https://www.facebook.com/note.php?note_id=14218138919&id=9445547199&index=0) |

| Facebook gibi bir grafik arama fonksiyonu tasarlayın | [facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-building-out-the-infrastructure-for-graph-search/10151347573598920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-indexing-and-ranking-in-graph-search/10151361720763920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-the-natural-language-interface-of-graph-search/10151432733048920) |
| CloudFlare gibi bir içerik dağıtım ağı tasarlayın | [figshare.com](https://figshare.com/articles/Globally_distributed_content_delivery/6605972) |
| Twitter gibi bir gündem belirleme sistemi tasarlayın | [michael-noll.com](http://www.michael-noll.com/blog/2013/01/18/implementing-real-time-trending-topics-in-storm/)<br/>[snikolov .wordpress.com](http://snikolov.wordpress.com/2012/11/14/early-detection-of-twitter-trends/) |
| Rastgele ID üretim sistemi tasarlayın | [blog.twitter.com](https://blog.twitter.com/2010/announcing-snowflake)<br/>[github.com](https://github.com/twitter/snowflake/) |
| Bir zaman aralığında en çok yapılan k istekleri döndürün | [cs.ucsb.edu](https://www.cs.ucsb.edu/sites/default/files/documents/2005-23.pdf)<br/>[wpi.edu](http://davis.wpi.edu/xmdv/docs/EDBT11-diyang.pdf) |
| Birden fazla veri merkezinden veri sunan bir sistem tasarlayın | [highscalability.com](http://highscalability.com/blog/2009/8/24/how-google-serves-data-from-multiple-datacenters.html) |
| Çevrimiçi çok oyunculu bir kart oyunu tasarlayın | [indieflashblog.com](https://web.archive.org/web/20180929181117/http://www.indieflashblog.com/how-to-create-an-asynchronous-multiplayer-game.html)<br/>[buildnewgames.com](http://buildnewgames.com/real-time-multiplayer/) |
| Çöp toplama sistemi tasarlayın | [stuffwithstuff.com](http://journal.stuffwithstuff.com/2013/12/08/babys-first-garbage-collector/)<br/>[washington.edu](http://courses.cs.washington.edu/courses/csep521/07wi/prj/rick.pdf) |
| API hız sınırlayıcı tasarlayın | [https://stripe.com/blog/](https://stripe.com/blog/rate-limiters) |
| Bir Borsa (NASDAQ veya Binance gibi) tasarlayın | [Jane Street](https://youtu.be/b1e4t2k2KJY)<br/>[Golang Implementation](https://around25.com/blog/building-a-trading-engine-for-a-crypto-exchange/)<br/>[Go Implementation](http://bhomnick.net/building-a-simple-limit-order-in-go/) |
| Bir sistem tasarım sorusu ekleyin | [Katkıda Bulunun](#contributing) |

### Gerçek dünya mimarileri

> Gerçek dünya sistemlerinin nasıl tasarlandığına dair makaleler.

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/TcUo2fw.png">
  <br/>
  <i><a href=https://www.infoq.com/presentations/Twitter-Timeline-Scalability>Kaynak: Twitter zaman akışları ölçeklenebilirliği</a></i>
</p>

**Aşağıdaki makalelerde teknik detaylara çok takılmayın, bunun yerine:**

* Ortak prensipleri, kullanılan teknolojileri ve desenleri belirleyin
* Her bileşenin çözdüğü problemleri, nerede işe yaradığını, nerede yaramadığını inceleyin
* Edinilen dersleri gözden geçirin

|Tip | Sistem | Referans(lar) |
|---|---|---|
| Veri işleme | **MapReduce** - Google’dan dağıtık veri işleme | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/mapreduce-osdi04.pdf) |
| Veri işleme | **Spark** - Databricks’ten dağıtık veri işleme | [slideshare.net](http://www.slideshare.net/AGrishchenko/apache-spark-architecture) |
| Veri işleme | **Storm** - Twitter’dan dağıtık veri işleme | [slideshare.net](http://www.slideshare.net/previa/storm-16094009) |
| | | |
| Veri deposu | **Bigtable** - Google’dan dağıtık sütun tabanlı veritabanı | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) |
| Veri deposu | **HBase** - Bigtable’ın açık kaynaklı uygulaması | [slideshare.net](http://www.slideshare.net/alexbaranau/intro-to-hbase) |
| Veri deposu | **Cassandra** - Facebook’tan dağıtık sütun tabanlı veritabanı | [slideshare.net](http://www.slideshare.net/planetcassandra/cassandra-introduction-features-30103666)
| Veri deposu | **DynamoDB** - Amazon’dan belge tabanlı veritabanı | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) |
| Veri deposu | **MongoDB** - Belge tabanlı veritabanı | [slideshare.net](http://www.slideshare.net/mdirolf/introduction-to-mongodb) |
| Veri deposu | **Spanner** - Google’dan küresel dağıtık veritabanı | [research.google.com](http://research.google.com/archive/spanner-osdi2012.pdf) |
| Veri deposu | **Memcached** - Dağıtık bellek önbellekleme sistemi | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| Veri deposu | **Redis** - Kalıcılık ve değer tipleri ile dağıtık bellek önbellekleme sistemi | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| | | |
| Dosya sistemi | **Google File System (GFS)** - Dağıtık dosya sistemi | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/gfs-sosp2003.pdf) |
| Dosya sistemi | **Hadoop File System (HDFS)** - GFS'nin açık kaynak uygulaması | [apache.org](http://hadoop.apache.org/docs/stable/hadoop-project-dist/hadoop-hdfs/HdfsDesign.html) |
| | | |
| Diğer | **Chubby** - Google'dan gevşek bağlı dağıtık sistemler için kilit hizmeti | [research.google.com](http://static.googleusercontent.com/external_content/untrusted_dlcp/research.google.com/en/us/archive/chubby-osdi06.pdf) |
| Diğer | **Dapper** - Dağıtık sistemler için izleme altyapısı | [research.google.com](http://static.googleusercontent.com/media/research.google.com/en//pubs/archive/36356.pdf)
| Diğer | **Kafka** - LinkedIn'den pub/sub mesaj kuyruğu | [slideshare.net](http://www.slideshare.net/mumrah/kafka-talk-tri-hug) |
| Diğer | **Zookeeper** - Senkronizasyon sağlayan merkezi altyapı ve hizmetler | [slideshare.net](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) |
| | Bir mimari ekle | [Katkıda Bulunun](#contributing) |

### Şirket mimarileri

| Şirket | Referans(lar) |
|---|---|
| Amazon | [Amazon mimarisi](http://highscalability.com/amazon-architecture) |
| Cinchcast | [Her gün 1.500 saat ses üretimi](http://highscalability.com/blog/2012/7/16/cinchcast-architecture-producing-1500-hours-of-audio-every-d.html) |
| DataSift | [Saniyede 120.000 tweet ile gerçek zamanlı veri madenciliği](http://highscalability.com/blog/2011/11/29/datasift-architecture-realtime-datamining-at-120000-tweets-p.html) |
| Dropbox | [Dropbox'u nasıl ölçeklendirdik](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| ESPN | [Saniyede 100.000 duh nuh nuh işlemi](http://highscalability.com/blog/2013/11/4/espns-architecture-at-scale-operating-at-100000-duh-nuh-nuhs.html) |
| Google | [Google mimarisi](http://highscalability.com/google-architecture) |
| Instagram | [14 milyon kullanıcı, terabaytlarca fotoğraf](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html)<br/>[Instagram’ı ne güçlendiriyor](http://instagram-engineering.tumblr.com/post/13649370142/what-powers-instagram-hundreds-of-instances) |
| Justin.tv | [Justin.Tv'nin canlı video yayın mimarisi](http://highscalability.com/blog/2010/3/16/justintvs-live-video-broadcasting-architecture.html) |
| Facebook | [Facebook'ta memcached ölçeklendirme](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/key-value/fb-memcached-nsdi-2013.pdf)<br/>[TAO: Facebook’un sosyal grafik için dağıtık veri deposu](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/data-store/tao-facebook-distributed-datastore-atc-2013.pdf)<br/>[Facebook’un fotoğraf depolama sistemi](https://www.usenix.org/legacy/event/osdi10/tech/full_papers/Beaver.pdf)<br/>[Facebook Live’ın 800.000 eşzamanlı izleyiciye nasıl yayın yaptığı](http://highscalability.com/blog/2016/6/27/how-facebook-live-streams-to-800000-simultaneous-viewers.html) |
| Flickr | [Flickr mimarisi](http://highscalability.com/flickr-architecture) |
| Mailbox | [6 haftada sıfırdan 1 milyon kullanıcıya ölçeklendirme](http://highscalability.com/blog/2013/6/18/scaling-mailbox-from-0-to-one-million-users-in-6-weeks-and-1.html) |
| Netflix | [Tüm Netflix yığınına 360 derece bakış](http://highscalability.com/blog/2015/11/9/a-360-degree-view-of-the-entire-netflix-stack.html)<br/>[Netflix: Play tuşuna bastığınızda ne olur?](http://highscalability.com/blog/2017/12/11/netflix-what-happens-when-you-press-play.html) |
| Pinterest | [Aylık 0'dan on milyarlarca sayfa görüntülemeye](http://highscalability.com/blog/2013/4/15/scaling-pinterest-from-0-to-10s-of-billions-of-page-views-a.html)<br/>[18 milyon ziyaretçi, 10x büyüme, 12 çalışan](http://highscalability.com/blog/2012/5/21/pinterest-architecture-update-18-million-visitors-10x-growth.html) |
| Playfish | [50 milyon aylık kullanıcı ve büyüyor](http://highscalability.com/blog/2010/9/21/playfishs-social-gaming-architecture-50-million-monthly-user.html) |
| PlentyOfFish | [PlentyOfFish mimarisi](http://highscalability.com/plentyoffish-architecture) |
| Salesforce | [Günde 1,3 milyar işlemi nasıl yönetiyorlar?](http://highscalability.com/blog/2013/9/23/salesforce-architecture-how-they-handle-13-billion-transacti.html) |
| Stack Overflow | [Stack Overflow mimarisi](http://highscalability.com/blog/2009/8/5/stack-overflow-architecture.html) |
| TripAdvisor | [40M ziyaretçi, 200M dinamik sayfa görüntüleme, 30TB veri](http://highscalability.com/blog/2011/6/27/tripadvisor-architecture-40m-visitors-200m-dynamic-page-view.html) |
| Tumblr | [Aylık 15 milyar sayfa görüntüleme](http://highscalability.com/blog/2012/2/13/tumblr-architecture-15-billion-page-views-a-month-and-harder.html) |
| Twitter | [Twitter’ı %10000 daha hızlı hale getirmek](http://highscalability.com/scaling-twitter-making-twitter-10000-percent-faster)<br/>[MySQL kullanarak günde 250 milyon tweet depolama](http://highscalability.com/blog/2011/12/19/how-twitter-stores-250-million-tweets-a-day-using-mysql.html)<br/>[150M aktif kullanıcı, 300K QPS, 22 MB/S ateş hortumu](http://highscalability.com/blog/2013/7/8/the-architecture-twitter-uses-to-deal-with-150m-active-users.html)<br/>[Zaman çizelgeleri ölçekli olarak](https://www.infoq.com/presentations/Twitter-Timeline-Scalability)<br/>[Twitter'da büyük ve küçük veri](https://www.youtube.com/watch?v=5cKTP36HVgI)<br/>[Twitter’da operasyonlar: 100 milyon kullanıcıyı aşan ölçekleme](https://www.youtube.com/watch?v=z8LU0Cj6BOU)<br/>[Twitter saniyede 3.000 görseli nasıl işler?](http://highscalability.com/blog/2016/4/20/how-twitter-handles-3000-images-per-second.html) |
| Uber | [Uber gerçek zamanlı pazar platformunu nasıl ölçeklendiriyor](http://highscalability.com/blog/2015/9/14/how-uber-scales-their-real-time-market-platform.html)<br/>[Uber’i 2000 mühendise, 1000 servise ve 8000 Git deposuna ölçeklendirirken öğrenilen dersler](http://highscalability.com/blog/2016/10/12/lessons-learned-from-scaling-uber-to-2000-engineers-1000-ser.html) |
| WhatsApp | [Facebook’un 19 milyar dolara satın aldığı WhatsApp mimarisi](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html) |
| YouTube | [YouTube ölçeklenebilirliği](https://www.youtube.com/watch?v=w5WVu624fY8)<br/>[YouTube mimarisi](http://highscalability.com/youtube-architecture) |

### Şirket mühendislik blogları

> Görüştüğünüz şirketlerin mimarileri.
>
> Karşılaştığınız sorular aynı alandan olabilir.

* [Airbnb Mühendislik](http://nerds.airbnb.com/)
* [Atlassian Geliştiriciler](https://developer.atlassian.com/blog/)
* [AWS Blog](https://aws.amazon.com/blogs/aws/)
* [Bitly Mühendislik Blogu](http://word.bitly.com/)
* [Box Blogları](https://blog.box.com/blog/category/engineering)
* [Cloudera Geliştirici Blogu](http://blog.cloudera.com/)
* [Dropbox Teknoloji Blogu](https://tech.dropbox.com/)
* [Quora’da Mühendislik](https://www.quora.com/q/quoraengineering)
* [Ebay Teknoloji Blogu](http://www.ebaytechblog.com/)
* [Evernote Teknoloji Blogu](https://blog.evernote.com/tech/)
* [Etsy Code as Craft](http://codeascraft.com/)
* [Facebook Mühendislik](https://www.facebook.com/Engineering)
* [Flickr Code](http://code.flickr.net/)
* [Foursquare Mühendislik Blogu](http://engineering.foursquare.com/)
* [GitHub Mühendislik Blogu](https://github.blog/category/engineering)
* [Google Araştırma Blogu](http://googleresearch.blogspot.com/)
* [Groupon Mühendislik Blogu](https://engineering.groupon.com/)
* [Heroku Mühendislik Blogu](https://engineering.heroku.com/)
* [Hubspot Mühendislik Blogu](http://product.hubspot.com/blog/topic/engineering)
* [High Scalability](http://highscalability.com/)
* [Instagram Mühendislik](http://instagram-engineering.tumblr.com/)
* [Intel Yazılım Blogu](https://software.intel.com/en-us/blogs/)
* [Jane Street Teknoloji Blogu](https://blogs.janestreet.com/category/ocaml/)
* [LinkedIn Mühendislik](http://engineering.linkedin.com/blog)
* [Microsoft Mühendislik](https://engineering.microsoft.com/)
* [Microsoft Python Mühendislik](https://blogs.msdn.microsoft.com/pythonengineering/)
* [Netflix Teknoloji Blogu](http://techblog.netflix.com/)
* [Paypal Geliştirici Blogu](https://medium.com/paypal-engineering)
* [Pinterest Mühendislik Blogu](https://medium.com/@Pinterest_Engineering)
* [Reddit Blogu](http://www.redditblog.com/)
* [Salesforce Mühendislik Blogu](https://developer.salesforce.com/blogs/engineering/)
* [Slack Mühendislik Blogu](https://slack.engineering/)
* [Spotify Labs](https://labs.spotify.com/)
* [Stripe Mühendislik Blogu](https://stripe.com/blog/engineering)
* [Twilio Mühendislik Blogu](http://www.twilio.com/engineering)
* [Twitter Mühendislik](https://blog.twitter.com/engineering/)
* [Uber Mühendislik Blogu](http://eng.uber.com/)
* [Yahoo Mühendislik Blogu](http://yahooeng.tumblr.com/)
* [Yelp Mühendislik Blogu](http://engineeringblog.yelp.com/)
* [Zynga Mühendislik Blogu](https://www.zynga.com/blogs/engineering)

#### Kaynak(lar) ve daha fazla okuma

Bir blog eklemek mi istiyorsunuz?  Çakışan işleri önlemek için şirket blogunuzu aşağıdaki repoya eklemeyi düşünün:

* [kilimchoi/engineering-blogs](https://github.com/kilimchoi/engineering-blogs)

## Geliştirme aşamasında

Bir bölüm eklemek veya devam eden bir bölümü tamamlamaya yardımcı olmak ister misiniz?  [Katkıda bulunun](#contributing)!

* MapReduce ile dağıtık hesaplama
* Tutarlı karma
* Dağıtma-toplama (scatter gather)
* [Katkıda bulunun](#contributing)

## Katkılar

Katkılar ve kaynaklar bu repoda boyunca sağlanmıştır.

Özel teşekkürler:

* [Hired in tech](http://www.hiredintech.com/system-design/the-system-design-process/)
* [Cracking the coding interview](https://www.amazon.com/dp/0984782850/)
* [High scalability](http://highscalability.com/)
* [checkcheckzz/system-design-interview](https://github.com/checkcheckzz/system-design-interview)
* [shashank88/system_design](https://github.com/shashank88/system_design)
* [mmcgrana/services-engineering](https://github.com/mmcgrana/services-engineering)
* [Sistem tasarımı hile sayfası](https://gist.github.com/vasanthk/485d1c25737e8e72759f)
* [Dağıtık sistemler okuma listesi](http://dancres.github.io/Pages/)
* [Sistem tasarımı mülakatını çözme](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)

## İletişim bilgileri

Herhangi bir sorun, soru veya yorumunuzu görüşmek için benimle iletişime geçmekten çekinmeyin.

İletişim bilgilerime [GitHub sayfamdan](https://github.com/donnemartin) ulaşabilirsiniz.

## Lisans

*Bu depoda size kod ve kaynakları açık kaynak lisansı altında sunuyorum.  Bu benim kişisel depom olduğu için, kod ve kaynaklarım için aldığınız lisans bana aittir, işverenim (Facebook) değil.*

    Telif Hakkı 2017 Donne Martin

    Creative Commons Attribution 4.0 International License (CC BY 4.0)

    http://creativecommons.org/licenses/by/4.0/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---