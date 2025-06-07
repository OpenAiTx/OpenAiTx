Bitcoin Core entegrasyon/sahneleme ağacı
========================================

https://bitcoincore.org

Hemen kullanılabilir, ikili bir Bitcoin Core yazılımı sürümü için
https://bitcoincore.org/en/download/ adresine bakın.

Bitcoin Core nedir?
-------------------

Bitcoin Core, blokları ve işlemleri indirmek ve tamamen doğrulamak için Bitcoin eşler arası ağına bağlanır.
Ayrıca isteğe bağlı olarak derlenebilen bir cüzdan ve grafiksel kullanıcı arayüzü de içerir.

Bitcoin Core hakkında daha fazla bilgi [doc klasöründe](/doc) mevcuttur.

Lisans
------

Bitcoin Core, MIT lisansı şartları altında yayınlanmaktadır. Daha fazla bilgi için [COPYING](COPYING) dosyasına veya https://opensource.org/license/MIT adresine bakın.

Geliştirme Süreci
-----------------

`master` dalı düzenli olarak derlenir (talimatlar için `doc/build-*.md` dosyasına bakın) ve test edilir, ancak tamamen kararlı olduğu garanti edilmez. [Etiketler](https://github.com/bitcoin/bitcoin/tags), yeni resmi ve kararlı Bitcoin Core sürümlerini göstermek için düzenli olarak sürüm dallarından oluşturulur.

https://github.com/bitcoin-core/gui deposu, yalnızca GUI'nin geliştirilmesi için kullanılır. Ana dalı tüm monotree depolarında aynıdır. Sürüm dalları ve etiketler yoktur, bu nedenle yalnızca geliştirme amacıyla değilse bu depoyu çatallamayınız.

Katkı iş akışı [CONTRIBUTING.md](CONTRIBUTING.md) dosyasında açıklanmıştır ve geliştiriciler için faydalı ipuçları [doc/developer-notes.md](doc/developer-notes.md) dosyasında bulunabilir.

Test
----

Test ve kod incelemesi, geliştirme için dar boğazdır; kısa sürede inceleyip test edebileceğimizden daha fazla çekme isteği alıyoruz. Lütfen sabırlı olun ve başkalarının çekme isteklerini test ederek yardımcı olun ve bunun herhangi bir hatanın insanlara çok para kaybettirebileceği güvenlik açısından kritik bir proje olduğunu unutmayın.

### Otomatik Test

Geliştiricilerin, yeni kodlar için [birim testleri](src/test/README.md) yazmaları ve eski kodlar için de yeni birim testleri göndermeleri şiddetle tavsiye edilir. Birim testleri, (derleme sistemi oluşturulurken devre dışı bırakılmadıysa) derlenip şu komutla çalıştırılabilir: `ctest`. Birim testlerinin çalıştırılması ve genişletilmesiyle ilgili daha fazla ayrıntı [/src/test/README.md](/src/test/README.md) dosyasında bulunabilir.

Ayrıca Python ile yazılmış [regresyon ve entegrasyon testleri](/test) de bulunmaktadır.
Bu testler ([test bağımlılıkları](/test) yüklüyse) şu komutla çalıştırılabilir: `build/test/functional/test_runner.py`
(`build` klasörünüzün derleme dizini olduğunu varsayarsak).

CI (Sürekli Entegrasyon) sistemleri, her çekme isteğinin Windows, Linux ve macOS için derlendiğinden ve birim/sağlamlık testlerinin otomatik olarak çalıştırıldığından emin olur.

### Manuel Kalite Güvencesi (QA) Testi

Değişiklikler, kodu yazan geliştiriciden farklı biri tarafından test edilmelidir. Bu, özellikle büyük veya yüksek riskli değişiklikler için önemlidir. Değişikliklerin test edilmesi kolay değilse, çekme isteği açıklamasına bir test planı eklemek faydalıdır.

Çeviriler
---------

Çevirilerdeki değişiklikler ve yeni çeviriler
[Bitcoin Core'un Transifex sayfasına](https://www.transifex.com/bitcoin/bitcoin/) gönderilebilir.

Çeviriler periyodik olarak Transifex'ten alınır ve git deposuna birleştirilir. Bunun nasıl çalıştığıyla ilgili ayrıntılar için
[çeviri süreci](doc/translation_process.md) dosyasına bakın.

**Önemli**: Çeviri değişikliklerini GitHub çekme isteği olarak kabul etmiyoruz çünkü bir sonraki
Transifex'ten çekme işlemi bunları otomatik olarak tekrar üzerine yazacaktır.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---