# [jQuery](https://jquery.com/) — Yeni Nesil JavaScript

Toplantılar şu anda [matrix.org platformunda](https://matrix.to/#/#jquery_meeting:gitter.im) gerçekleştirilmektedir.

Toplantı notlarına [meetings.jquery.org](https://meetings.jquery.org/category/core/) adresinden ulaşabilirsiniz.

jQuery'nin en son sürümü [https://jquery.com/download/](https://jquery.com/download/) adresinde mevcuttur.

## Sürüm Desteği

| Sürüm  | Dal         | Durum    |
| ------ | ----------- | -------- |
| 4.x    | main        | Beta     |
| 3.x    | 3.x-stable  | Aktif    |
| 2.x    | 2.x-stable  | Pasif    |
| 1.x    | 1.x-stable  | Pasif    |

4.0.0 final sürümü yayımlandıktan sonra, 3.x dalı sınırlı bir süre güncellemeler almaya devam edecektir. 2.x ve 1.x dalları artık desteklenmemektedir.

Pasif sürümler için ticari destek [HeroDevs](https://herodevs.com/nes) tarafından sağlanmaktadır.

[version support](https://jquery.com/support/) (sürüm desteği) hakkında daha fazla bilgi edinin.

## Katkı Rehberleri

Açık kaynak yazılım geliştirme ruhuyla, jQuery her zaman topluluk kod katkılarını teşvik eder. Koda başlamadan önce bu önemli katkı kurallarını dikkatlice okuduğunuzdan emin olun:

1. [Katılım Sağlamak](https://contribute.jquery.org/)
2. [Çekirdek Stil Rehberi](https://contribute.jquery.org/style-guide/js/)
3. [jQuery Projeleri için Kod Yazımı](https://contribute.jquery.org/code/)

### Sorunlar/PR'lara Referanslar

GitHub sorunları/PR'ları genellikle `gh-NUMBER` şeklinde referanslanır, burada `NUMBER` sorun/PR'nın sayısal kimliğidir. Böyle bir sorun/PR'yi `https://github.com/jquery/jquery/issues/NUMBER` adresinde bulabilirsiniz.

jQuery geçmişte Trac tabanlı farklı bir hata takip sistemi kullanmıştır; [bugs.jquery.com](https://bugs.jquery.com/) adresinden erişilebilir. Yalnızca okunabilir modda tutulmaktadır, böylece geçmiş tartışmalara referans verebilirsiniz. jQuery kaynak kodu bu tür bir soruna referans verdiğinde `trac-NUMBER` biçimini kullanır; burada `NUMBER` sorun kimliğidir. Böyle bir sorunu `https://bugs.jquery.com/ticket/NUMBER` adresinde bulabilirsiniz.

## jQuery'nin Kullanılabileceği Ortamlar

- [Tarayıcı desteği](https://jquery.com/browser-support/)
- jQuery ayrıca Node, tarayıcı uzantıları ve diğer tarayıcı dışı ortamları da destekler.

## Kendi jQuery'nizi Derlemek İçin Gerekenler

jQuery'yi derlemek için en güncel Node.js/npm ve git 1.7 veya üzeri sürüme sahip olmanız gerekir. Daha eski sürümler çalışabilir ancak desteklenmemektedir.

Windows için, [git](https://git-scm.com/downloads) ve [Node.js](https://nodejs.org/en/download/) indirip yüklemeniz gerekir.

macOS kullanıcıları [Homebrew](https://brew.sh/) kurmalıdır. Homebrew kurulduktan sonra, git'i yüklemek için `brew install git`, Node.js'i yüklemek için `brew install node` komutlarını çalıştırın.

Linux/BSD kullanıcıları, uygun paket yöneticilerini kullanarak git ve Node.js'i kurmalı veya tercihlerine göre kaynaktan derlemelidir. Çok kolay!

## Kendi jQuery'nizi Nasıl Derlersiniz?

Öncelikle, [jQuery git deposunu klonlayın](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

Ardından, jquery klasörüne girin, bağımlılıkları kurun ve derleme betiğini çalıştırın:

```bash
cd jquery
npm install
npm run build
```

Derlenmiş jQuery sürümü, minify edilmiş kopyası ve ilişkili harita dosyası ile birlikte `dist/` dizinine yerleştirilecektir.

## Tüm jQuery Sürüm Dosyalarını Derleme

jQuery'nin tüm varyantlarını derlemek için aşağıdaki komutu çalıştırın:

```bash
npm run build:all
```

Bu komut, jQuery'nin bir sürümde içerdiği tüm varyantları oluşturur: `jquery.js`, `jquery.slim.js`, `jquery.module.js`, ve `jquery.slim.module.js` ile bunların minify edilmiş dosyaları ve sourcemap'leri dahil.

`jquery.module.js` ve `jquery.slim.module.js`, `jQuery` ve `$`'ı isimli dışa aktarımlar olarak dışa aktaran [ECMAScript modülleri](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules)'dir ve `dist/` dizini yerine `dist-module/` dizininde bulunur.

## Özel jQuery Derlemesi Oluşturma

Derleme betiği, yalnızca ihtiyacınız olan modülleri içeren özel bir jQuery sürümü oluşturmak için kullanılabilir.

`core` dışında herhangi bir modül hariç tutulabilir. `selector` hariç tutulduğunda, tamamen kaldırılmaz ancak yerel `querySelectorAll` etrafında küçük bir sarmalayıcı ile değiştirilir (daha fazla bilgi için aşağıya bakın).

### Derleme Betiği Yardımı

Derleme betiği için mevcut tüm seçeneklerin tam listesini görmek için aşağıdakini çalıştırın:

```bash
npm run build -- --help
```

### Modüller

Bir modülü hariç tutmak için, `--exclude` seçeneğine yolunu `src` klasörüne göre (`.js` uzantısı olmadan) belirtin. `--include` seçeneğini kullandığınızda, varsayılan içerikler kaldırılır ve yalnızca belirtilen modüllerle bir derleme oluşturulur.

Hariç tutulabilecek veya dahil edilebilecek bazı örnek modüller şunlardır:

- **ajax**: Tüm AJAX işlevselliği: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, taşıyıcılar ve `.ajaxStart()` gibi AJAX olay kısayolları.
- **ajax/xhr**: Yalnızca XMLHTTPRequest AJAX taşıyıcısı.
- **ajax/script**: Yalnızca `<script>` AJAX taşıyıcısı; betikleri almak için kullanılır.
- **ajax/jsonp**: Yalnızca JSONP AJAX taşıyıcısı; ajax/script taşıyıcısına bağlıdır.
- **css**: `.css()` metodu. Ayrıca css'e bağlı **tüm** modülleri kaldırır (**effects**, **dimensions** ve **offset** dahil).
- **css/showHide**: Animasyonsuz `.show()`, `.hide()` ve `.toggle()`; `display` özelliğini ayarlamak için sınıf veya doğrudan `.css()` kullandığınızda hariç tutulabilir. Ayrıca **effects** modülünü de kaldırır.
- **deprecated**: Artık kullanımdan kaldırılmış ancak henüz kaldırılmamış metodlar.
- **dimensions**: `.width()` ve `.height()` metotları ile `inner-` ve `outer-` varyasyonları.
- **effects**: `.animate()` metodu ve `.slideUp()` veya `.hide("slow")` gibi kısayollar.
- **event**: `.on()` ve `.off()` metodları ve tüm etkinlik işlevselliği.
- **event/trigger**: `.trigger()` ve `.triggerHandler()` metodları.
- **offset**: `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()` ve `.scrollTop()` metodları.
- **wrap**: `.wrap()`, `.wrapAll()`, `.wrapInner()` ve `.unwrap()` metodları.
- **core/ready**: Betiklerinizi gövdenin sonunda yerleştiriyorsanız, ready modülünü hariç tutabilirsiniz. `jQuery()` ile bağlanan ready callback'leri hemen çağrılır. Ancak, `jQuery(document).ready()` bir fonksiyon olmayacak ve `.on("ready", ...)` veya benzeri tetiklenmeyecektir.
- **deferred**: jQuery.Deferred'i hariç tutar. Bu ayrıca **ajax**, **effects** ve **queue** dahil Deferred'a bağlı tüm modülleri hariç tutar, ancak **core/ready**'yi **core/ready-no-deferred** ile değiştirir.
- **exports/global**: Global jQuery değişkenlerinin ($ ve jQuery) window'a eklenmesini hariç tutar.
- **exports/amd**: AMD tanımını hariç tutar.

- **selector**: Tam jQuery seçici motoru. Bu modül hariç tutulduğunda, tarayıcının `querySelectorAll` metoduna dayalı, jQuery seçici uzantılarını veya gelişmiş anlamları desteklemeyen ilkel bir seçici motoruyla değiştirilir. Detaylar için [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) dosyasına bakınız.

*Not*: Tam `selector` modülünü hariç tutmak, tüm jQuery seçici uzantılarını da hariç tutacaktır (`effects/animatedSelector` ve `css/hiddenVisibleSelectors` gibi).

##### AMD adı

jQuery'nin AMD tanımı için modül adını ayarlayabilirsiniz. Varsayılan olarak "jquery" olarak ayarlanmıştır, bu da eklenti ve üçüncü taraf kütüphaneler ile uyumludur, ancak adını değiştirmek isteyebileceğiniz durumlar olabilir. `--amd` parametresine iletebilirsiniz:

```bash
npm run build -- --amd="ozel-ad"
```

Veya anonim tanımlamak için adı boş bırakabilirsiniz.

```bash
npm run build -- --amd
```

##### Dosya adı ve dizini

Derlenmiş jQuery dosyasının varsayılan adı `jquery.js`'tir; `dist/` dizini altında yer alır. Dosya adını `--filename` ile, dizini ise `--dir` ile değiştirmek mümkündür. `--dir` proje köküne göredir.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

Bu komut, jQuery'nin slim sürümünü oluşturur ve `tmp/jquery.slim.js` altına yerleştirir.

##### ECMAScript Modülü (ESM) modu

Varsayılan olarak, jQuery klasik script JavaScript dosyası üretir. `--esm` parametresiyle, `jQuery`'yi varsayılan dışa aktarımla dışa aktaran bir ECMAScript modülü de oluşturabilirsiniz:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### Fabrika modu

Varsayılan olarak, jQuery global bir `window`'a bağımlıdır. Bir `window`'u olmayan ortamlar için, harici olarak sağlayabileceğiniz bir `window` parametresi kabul eden bir fonksiyonu dışa aktaran fabrika derlemesi oluşturabilirsiniz (kullanım talimatları için [yayınlanan paketin `README`](build/fixtures/README.md) dosyasına bakınız). Bunu `--factory` parametresiyle oluşturabilirsiniz:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

Bu seçenek, `--esm` veya `--slim` gibi diğer seçeneklerle birleştirilebilir:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### Özel Derleme Örnekleri

Hariç tutulan modülleri listeleyerek `npm run build` komutuyla özel bir derleme oluşturun. Üst düzey bir modül hariç tutulduğunda, ilgili modüller klasörü de hariç tutulur.

Tüm **ajax** işlevselliğini hariç tutun:

```bash
npm run build -- --exclude=ajax
```

**css** hariç tutulduğunda, CSS'ye bağlı modüller de kaldırılır: **effects**, **offset**, **dimensions**.

```bash
npm run build -- --exclude=css
```

Birden fazla modülü hariç tutun (`-e`, `--exclude` için bir kısaltmadır):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

Resmî jQuery Slim yapılandırmasıyla aynı yapılandırmaya sahip bir derleme oluşturmak için özel bir kısayol vardır:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

Veya, slim yapıyı esm modülü olarak oluşturmak için:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*Resmi olmayan özel yapılar düzenli olarak test edilmez. Kendi riskinizde kullanın.*

## Birim Testlerini Çalıştırma

Gerekli bağımlılıkların yüklü olduğundan emin olun:

```bash
npm install
```

Çalışırken jQuery'yi otomatik olarak derlemek için `npm start` komutunu başlatın:

```bash
npm start
```

Birim testlerini PHP destekleyen yerel bir sunucuda çalıştırın. Siteyi kök dizinden çalıştırdığınızdan emin olun, "test" dizininden değil. Veritabanı gerekmez. Windows ve Mac için önceden yapılandırılmış php yerel sunucuları mevcuttur. İşte bazı seçenekler:

- Windows: [WAMP indir](https://www.wampserver.com/en/)
- Mac: [MAMP indir](https://www.mamp.info/en/downloads/)
- Linux: [LAMP kurulumu](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (çoğu platformda)](https://code.google.com/p/mongoose/)

## Temel Git

Kaynak kodu Git sürüm kontrol sistemiyle yönetildiğinden, kullanılan bazı özellikleri bilmek faydalıdır.

### Temizleme

Çalışma dizininizi upstream durumuna döndürmek isterseniz, aşağıdaki komutları kullanabilirsiniz (unutmayın, üzerinde çalıştığınız her şey bu işlemden sonra silinir):

```bash
git reset --hard upstream/main
git clean -fdx
```

### Yeniden Tabanlama (Rebasing)

Özellik/konu dalları için, her zaman `git pull` ile `--rebase` bayrağını kullanmalısınız veya genellikle birçok geçici "github pull request olacak" dalı yönetiyorsanız, bunu otomatikleştirmek için aşağıdakini çalıştırın:

```bash
git config branch.autosetuprebase local
```

(Daha fazla bilgi için `man git-config` bakınız)

### Birleştirme Çakışmalarını Yönetme

Birleştirme sırasında çakışmalar yaşıyorsanız, çakışan dosyaları elle düzenlemek yerine, `git mergetool` özelliğini kullanabilirsiniz. Varsayılan araç `xxdiff` eski/görünüş olarak kötü görünse de, oldukça kullanışlıdır.

Burada kullanılabilecek bazı komutlar şunlardır:

- `Ctrl + Alt + M` - mümkün olduğunca otomatik birleştir
- `b` - bir sonraki birleştirme çakışmasına atla
- `s` - çakışan satırların sırasını değiştir
- `u` - bir birleştirmeyi geri al
- `sol fare tuşu` - bir bloğu kazanan olarak işaretle
- `orta fare tuşu` - bir satırı kazanan olarak işaretle
- `Ctrl + S` - kaydet
- `Ctrl + Q` - çık

## [QUnit](https://api.qunitjs.com) Referansı

### Test metodları

```js
expect( numAssertions );
stop();
start();
```

*Not*: QUnit’in stop/start’a argüman eklemesi bu test paketinde göz ardı edilmiştir, böylece start ve stop parametreleriyle ilgilenmeden geri çağrım olarak verilebilir.

### Test doğrulama (assertion) metodları

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## Test Paketi Kolaylık Metodları Referansı

Bakınız: [test/data/testinit.js](https://github.com/jquery/jquery/blob/main/test/data/testinit.js).

### Verilen ID’lere sahip elemanlardan oluşan bir dizi döndürür

```js
q( ... );
```

Örnek:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### Bir seçimin verilen ID’lerle eşleşip eşleşmediğini doğrular

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

Örnek:

```js
t("Bir şeyi kontrol et", "//[a]", ["foo", "bar"]);
```

### jQuery'yi kullanmadan yerel DOM olayı tetikler

```js
fireNative( node, eventType );
```

Örnek:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### Önbelleği engellemek için URL’ye rastgele sayı ekler

```js
url( "some/url" );
```

Örnek:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### Testleri bir iframe içinde çalıştırır

Bazı testler standart test düzeni dışında bir belge gerektirebilir ve
bunlar ayrı bir iframe’de çalıştırılabilir. Gerçek test kodu ve doğrulamalar
jQuery’nin ana test dosyalarında kalır; yalnızca asgari test düzeni işaretlemesi
ve kurulum kodu iframe dosyasına yerleştirilmelidir.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

Bu, bir sayfa yükler ve fileName ile `"./data/" + fileName` şeklinde bir url oluşturur.
Iframe içindeki sayfa, testin ne zaman devam edeceğini "/test/data/iframeTest.js" script’ini dahil ederek ve uygun olduğunda
`startIframeTest( [ additional args ] )` çağırarak belirler. Genellikle bu,
ya document ready ya da `window.onload` tetiklendikten sonra olur.

`testCallback`, bu test için `testIframe` tarafından oluşturulan QUnit `assert` nesnesini,
ardından iframe’in global `jQuery`, `window` ve `document` nesnelerini alır.
Iframe kodu `startIframeTest` fonksiyonuna herhangi bir argüman aktarırsa, bunlar `document` argümanından sonra gelir.

## Sorularınız mı var?

Herhangi bir sorunuz varsa, lütfen
[jQuery Core Geliştirme forumunda](https://forum.jquery.com/developing-jquery-core) veya [libera](https://web.libera.chat/) üzerindeki #jquery kanalında sormaktan çekinmeyin.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---