# Akışkan Görsel Web Bileşeni

Herhangi bir istenen boyuta (makul sınırlar içinde) akıllıca ölçeklenen görseller.

![Akışkan Görseller](https://raw.githubusercontent.com/VoiceNGO/fluid-img/refs/heads/main/resources/images/responsive-images.jpg)

**Çok Küçük!:** 7kb minified & gzipped

## Kullanım

```html
<script src="fluid-img.js"></script>
<fluid-img src="image.jpg"></fluid-img>
```

Hepsi bu kadar. Görselleri istediğiniz gibi ölçeklendirin, onlar gerekeni yapacaktır.

## Demo

[Demo Burada](https://voicengo.github.io/fluid-img/public/fluid-demo.html)

Kendi görsellerinizle [deneme yapabileceğiniz bir oyun alanı](https://voicengo.github.io/fluid-img/public) da mevcuttur.
## Kurulum

### İstemci Kütüphanesi

```sh
npm install fluid-img
```

Daha sonra projenizde `fluid-img`'i içe aktarın, bu web-bileşenini sağlar ve kaydeder:

```ts
import 'fluid-img';
```

Ya da jsdelivr veya unpkg üzerinden scripti dahil edin:

```html
<script src="https://cdn.jsdelivr.net/npm/fluid-img@latest/dist/fluid-img.js" />

<!-- veya -->

<script src="https://unpkg.com/fluid-img@latest/dist/fluid-img.js" />
```
### Uyarılar

Akışkan resim bileşeni, resimleri yatay veya dikey olarak yaklaşık 0.5x ila 1.5x orijinal boyutları arasında ölçeklendirirken en iyi şekilde çalışır. Daha büyük veya daha küçük ölçeklerle de başa çıkabilse de, görsel kalite hızla bozulabilir. Piksel bütünlüğünün hassas olduğu portreler, grafikler veya ayrıntılı teknik çizimler gibi resimler için önerilmez, çünkü dikiş oyma işlemi bozulmalara yol açar. Görsel beklentilerinizi karşıladığından emin olmak için resimlerinizi çeşitli boyutlarda test etmeniz şiddetle tavsiye edilir.

#### CORS

Tarayıcı güvenlik kısıtlamaları nedeniyle, web sayfasından farklı bir kökenden (alan adı, protokol veya port) yüklenen resimler Çapraz Kaynak Paylaşımı (CORS) hatasına neden olur. Bu bileşenin, resmin ham piksel verilerine erişmesi gerekir ve bu da CORS tarafından kısıtlanmıştır.

Farklı bir kökenden gelen resimleri kullanmak için, resimleri barındıran sunucunun uygun CORS başlıklarını gönderecek şekilde yapılandırılması gerekir (ör. `Access-Control-Allow-Origin: *` veya `Access-Control-Allow-Origin: your-domain.com`). Bu başlıklar olmadan, bileşen resmi işleyemez.

(Bilgi için, test amaçlı olarak, imgur üzerindeki herhangi bir resimde gerekli CORS başlıkları mevcuttur)

#### Yedekleme

Bileşen resmi yükleyemez veya işleyemezse ya da dahili bir hata verirse, sorunsuz bir şekilde bozulur ve `<fluid-img>` bileşenine standart bir `<img>` etiketi ekler; %100 genişlik ve yükseklik ile resmi yine de görüntüler.

## Seçenekler

Kullanım: `<fluid-img src="image.jpg" generator="random" max-carve-up-scale="5"></fluid-img>`

Varsayılan olarak, en hızlı olan `random` üretici kullanılır.

| Seçenek                        | Değerler                         | Varsayılan   | Açıklama                                                                                                               |
| ------------------------------ | -------------------------------- | ------------ | ---------------------------------------------------------------------------------------------------------------------- |
| `src`                          | URL                              |              | İşlenecek resmin URL’si.                                                                                              |
| `generator`                    | `random`, `predictive`           | `predictive` | Kullanılacak dikiş oyma üreticisi. `random` daha hızlıdır ancak kalitesi düşüktür.                                    |
| `scaling-axis`                 | `horizontal`, `vertical`, `auto` | `horizontal` | Ölçeklendirme ekseni. `auto`, en-boy oranı değişikliklerine göre yatay veya dikey ölçeklendirir.                      |
| `mask`                         | URL                              |              | Bir maske resminin URL’si. Maskenin siyah alanları daha düşük enerjiye sahiptir ve korunma olasılığı daha yüksektir.  |
| `carving-priority`             | Sayı (0-1, ör. `0.5`)            | `1`          | Dikiş oyma ile yapılacak ölçeklendirmenin yüzdesi, geleneksel resim ölçeklendirmesine oranı.                          |
| `max-carve-up-seam-percentage` | Sayı (0-1, ör. `0.5`)            | `0.6`        | Büyütme sırasında eklenecek dikişlerin maksimum yüzdesi. Yeni dikişlerin oluşturulmasını sınırlandırarak kaliteyi korur.|
| `max-carve-up-scale`           | Sayı (ör. `3`)                   | `3`          | Dikiş oyma ile yapılacak maksimum büyütme faktörü. Bunun ötesinde geleneksel ölçeklendirme kullanılır.                 |
| `max-carve-down-scale`         | Sayı (0-1, ör. `0.7`)            | `0.7`        | Küçültme sırasında dikiş oyma ile kaldırılacak resmin maksimum yüzdesi.                                                |
### Jeneratöre özgü seçenekler

Jeneratöre özgü seçenekler `<fluid-img>` bileşenine eklenir ancak yalnızca ilgili
`generator` özniteliği de ayarlandığında geçerlidir

#### Rastgele & Öngörücü Jeneratör Seçenekleri

| Seçenek             | Değerler               | Varsayılan | Açıklama                                              |
| ------------------- | ---------------------- | ---------- | ----------------------------------------------------- |
| `batch-percentage`  | Sayı (0-1, örn. 0.1)   | 0.1        | Her bir partide üretilecek dikiş yüzdesi              |
| `min-batch-size`    | Sayı (örn. `10`)       | 10         | Her bir partide üretilecek minimum dikiş sayısı        |

## Nasıl çalışır

Seam carving, önemli içeriği bozmadan bir görüntünün yeniden boyutlandırılmasını sağlayan, içeriğe duyarlı bir görüntü yeniden boyutlandırma tekniğidir. Bu teknik, pikselleri akıllıca kaldırır veya ekler. Konuyla ilgili daha fazla bilgi için [Wikipedia makalesine](https://en.wikipedia.org/wiki/Seam_carving) bakabilirsiniz.

Tarihsel olarak, seam carving gerçek zamanlı olarak web tarayıcılarında kullanılamayacak kadar hesaplama yoğun bir işlemdi. Ancak, bu sınırlama, daha az kaynak gerektiren ve birçok senaryoda iyi çalışan alternatif algoritmalar kullanılarak aşılabilir.

Dikiş oyma jeneratörünün iki farklı uygulaması vardır:
### Rastgele Oyma

Rastgele dikiş oyma yaklaşımı, gerçek zamanlı tarayıcı yürütmesi için çok yavaş olan geleneksel dikiş oyma algoritmasından vazgeçer.

Bunun yerine, her satırdaki her pikseli bir sonraki satırdaki komşu bir piksele bağlayarak %100 görüntü kapsama alanı sağlayan bir dizi rastgele dikiş oluşturur. Ardından her bir dikişi yineleyerek enerjisini hesaplar ve en düşük enerjili dikişlerden oluşan bir grubu eler. Bu işlem istenen dikiş sayısına ulaşılana kadar tekrarlanır. Bu yöntem, birçok görüntüde şaşırtıcı derecede iyi sonuçlar verir.

### Öngörücü Oyma

Rastgele oymaya benzer şekilde, bu yöntem bir enerji haritası üretir ve dikişleri gruplar halinde oluşturur. Ayrıca her grup için minimum enerji haritası da üretir. Temel fikir, hem "iyi" hem de "kötü" dikişler oluşturmaktır. İyi dikişler düşük enerjiye sahiptir ve tutulur. Kötü dikişler ise yüksek enerjili pikselleri içerir, bu sayede sonradan elenebilirler.

İlk satırdan başlayarak, piksel çiftlerini bir sonraki satırdaki karşılık gelen çiftlere bağlar. Devam eden hesaplamadan çıkan düşük enerjili dikiş, minimum enerji haritasından gelen düşük enerjili dikişe bağlanır.

Sonuç olarak, gerçekten optimal bir dikiş, birçok "çok iyi" dikiş, birçok "çok kötü" dikiş ve çok sayıda vasat dikiş elde edilir. "İyi" dikişlerden oluşan bir grup seçilir, geri kalanlar elenir ve işlem tekrarlanır.

##

## YAPILACAKLAR

### Yüksek Öncelik

- [x] Web bileşeni
- [x] Üreticilerden veri alan ve her boyuta ölçeklenebilen bir oluşturucu
- [x] Rastgele üretici
- [x] Dikey oyma
- [x] Öngörücü üretici
- [ ] Tüm üreticiler için web çalışanları
### Düşük Öncelik

- [x] Maskeleme
- [ ] Yüz tanıma

### Hayal

- [ ] 2D oyma

## Lisanslama

Bu yazılım, Fluid-Img Gelir Sınırlı Lisansı altında lisanslanmıştır.

**Ücretsiz kullanım**, yıllık brüt geliri 10.000.000 USD'nin altında olan bireyler ve kuruluşlar içindir.

**Ticari lisans gereklidir**, yıllık geliri 10 milyon USD ve üzeri olan kuruluşlar için. Ticari lisans şartları için [licensing@voice.ngo] adresiyle iletişime geçin.

Tüm şartlar için [LICENSE](./LICENSE) dosyasına bakınız.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---