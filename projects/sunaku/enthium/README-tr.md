# Enthium - Engrammer Hands Down Promethium ile Buluşuyor

![Glove80 klavyemde Enthium v7'nin fotoğrafı](
https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-photograph-Enthium.jpg
)

[Engrammer] ve [Hands Down Promethium] klavye düzenlerinin bu uyarlaması,
ikincisinin klavye düzeni analizlerindeki (aşağıya bakınız) performansını
yatayda ayna görüntüsüyle artırır; böylece [Arno'nun Engram 2.0]
düzenine (sol elin ana sırasında CIEA; PF, WV ile Engram'daki gibi yer değiştirir)
ve [Dvorak] düzenine (sağ elin ana sırasında HTNS) aşinalık geri gelir.
Ayrıca Engrammer düzeninin ruhuna uygun olarak programlamada noktalama işaretlerinin
yerleşimi de optimize edilmiştir.

Dikkate değer şekilde, Engram/mer ile Enthium arasındaki farklılıklar o kadar
azdır ki, yaklaşık 6 saatlik bir pratikle (2-3 güne yayılmış, Cuma başlayıp
hafta sonu boyunca) tamamen geçiş yapmak ve [KeyBr] eğitiminde tüm harflerin
kilidini açmak mümkündür.

Ayrıca bakınız: [blog yazım]( https://sunaku.github.io/enthium-keyboard-layout.html
) - bu klavye düzenini geliştirmeme neden olan "tavşan deliğinden aşağı" beklenmedik yolculuk.

[Hands Down Promethium]: https://reddit.com/r/KeyboardLayouts/comments/1g66ivi
[Arno's Engram 2.0]:     https://engram.dev
[Engrammer]:             https://github.com/sunaku/engrammer
[Dvorak]:                https://www.dvzine.org
[KeyBr]:                 https://github.com/aradzie/keybr.com#readme

## Düzen

      q y o u - x l d w z
    b c i e a , k h t n s v
      ' / = . ; j m g p f
                r

>![Enthium v7'nin bir dizüstü bilgisayar klavyesindeki gösterimi.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)
>![Glove80 klavyemde Enthium v7'nin gösterimi.](
https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-diagram-Enthium.png
)

<!-- vim-markdown-toc GFM -->

* [Gerekçe](#gerekçe)
  * [Sapma: PF ve WV](#sapma-pf-ve-wv)
  * [Sapma: B ve V](#sapma-b-ve-v)
* [Performans](#performans)
  * [Cyanophage analizörü](#cyanophage-analizörü)
  * [KeySolve analizörü](#keysolve-analizörü)
  * [Oxey analizörü](#oxey-analizörü)
  * [Karşılaştırma](#karşılaştırma)
* [Kurulum](#kurulum)
  * [Linux kurulumu](#linux-kurulumu)
  * [MacOS kurulumu](#macos-kurulumu)
    * [Kurulum](#kurulum-1)
    * [Karmaşık modifikasyon](#karmaşık-modifikasyon)
    * [Kaldırma](#kaldırma)
* [Lisans](#lisans)

<!-- vim-markdown-toc -->

## Gerekçe

* Q ve Z, denge ve simetri için farklı ellere ayrılmıştır.

* B ve V, kısa veya [zayıf serçe parmaklara] sahip kişiler için yukarıya
  uzanmayı önlemek amacıyla, ana sıradaki yan serçe tuşlarına (CapsLock, Apostrof)
  yerleştirilmiştir.

* Apostrof, YOU ve I’dan (farklı bir parmakta) uzaklaştırılmıştır; böylece
  `you'd` ve `I'd` gibi aynı parmak ikilileri olmadan yazılabilir.

* Virgül ve noktalı virgül, Vim’de f/F/t/T aramaları arasında geçişi kolaylaştırmak
  ve sağ eldeki K ve J'nin göreceli sıralamasını yansıtmak için kümelenmiştir.

* Nokta ve virgül, Shift’li sembolleri (`>` ve `<`) açısından ters sıradadır
  fakat bu dizilim, yan uzanmalı ikilileri azaltmaya yardımcı olur ve geleneksel
  sıra-kaydırmalı klavyelerde dikey olarak üst üste gelir.

* Eksi, işaret parmağında (virgül, nokta ve noktalı virgül gibi) yer alır;
  böylece kelime/cümle ayırıcı noktalama işaretlerinin sorumluluğu tutarlı olur
  ve programlamada sık kullanılan `_` alt çizgiye kolayca erişilir.
  Özellikle sıra-kaydırmalı klavyelerde konumu, sol işaret parmağının doğal
  uzanma yönüne uygundur ve çabayı minimize eder.

* Eğik çizgi ve nokta, `/.`, `./` ve `../` dosya sistemi yollarını kolayca
  yuvarlamaya olanak sağlar.

[zayıf serçe parmaklara]: https://reddit.com/r/KeyboardLayouts/comments/1fy8nve/_/lqulnww/

### Sapma: PF ve WV

Aşağıdaki rahatsızlıkları gidermek için PF ile WV yer değiştirmiştir:

* WN, aşağı doğru kaydırmak istediğim bir merdiven tırmanışı aynı parmak ikilisidir
* DW (2u atlama), Engram’daki gibi bitişik olmadığından Vim’de o kadar pratik değildir
* FG (2u atlama), Engram’daki gibi kabuk arka plan işleri (`bg`, `fg`) için elverişli değildir
* SW (yarım makas), Engram’da olduğu gibi yukarıya uzanmaktan ziyade içe doğru kıvrılırken biraz zayıf hissediyor
* FF (ör. "stu*ff*"), serçe parmak için üst sırada iki kez basmak biraz zahmetli

Aslında, orijinal Hands Down Promethium düzeninden sapmak istemiyordum
(bu "Enthium" türevi sadece yatay bir ayna görüntüsü ve birkaç noktalama
işareti değişikliğinden ibaret olacaktı) ama PF ile WV’yi değiştirmenin
ne kadar kötü olacağını görmek için klavye düzeni analizörlerine başvurdum...
ve büyük bir şaşkınlıkla bu değişikliğin düzenin performansını neredeyse hiç
etkilemediğini gördüm:

* Oxey analizörü istatistiklerde hiç değişiklik göstermedi!
* KeySolve analizörü FSB’yi %0,14’ten %0,37’ye çıkardı ama diğer istatistikler
  iyileşti: FSS %0,82’den %0,48’e, HSB %6,05’ten %5,64’e ve HSS %5,97’den
  %5,50’ye indi; diğer her şey aynı kaldı.
* Cyanophage analizöründe Toplam Kelime Eforu %730,9’dan %735,9’a yükseldi
  ama diğer tüm istatistikler aynı kaldı!

Bu denemenin işe yaramasına _çok sevindim_, çünkü pratikte düzeni benim için
daha konforlu yapıyor ve Enthium’a Engrammer’dan geçmek isteyenler için
geçiş engelini daha da azaltacaktır. :)

### Sapma: B ve V

B ve V, yukarıya uzanmayı önlemek için üst sıradan ana sıra yanına döndürülmüştür;
özellikle kısa veya [zayıf serçe parmaklara] sahip kişiler için. Bu tuşlar,
İngilizce’de en az kullanılan harfler olan Q ve Z’ye atanmıştır.

Cyanophage analizöründe, bu değişiklik Serçe/Yüzük Makaslarını %0,49’dan
%0,35’e (büyük bir düşüş!) ve Atlamalı İkilileri (2u) %0,30’dan %0,29’a
indirir. Diğer analizörler, yan serçe tuşlarının konumunu tam olarak hesaba
katamaz; her analizörün başındaki notta açıklandığı gibi.
Ama Oxey analizörü SFB’yi %0,829’dan %0,818’e önemli ölçüde azaltır.

## Performans

### [Cyanophage analizörü][cNT]

> **NOT:** Bu analizör şu anda yalnızca sol baş parmağa harf yerleştirmeyi
> destekliyor, sağ baş parmağa değil; bu nedenle analiz için düzen yatayda
> aynalanmıştır. Aynalama sonuçları etkilemez.

![Ekran görüntüsü](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/cyanophage.png)

Genel istatistikler:
* Toplam Kelime Eforu: 748,5
* Efor:                432,54

Parmak kullanımı:
* Aynı Parmak İkilileri:   %0,55
* Atlama İkilileri (2u):   %0,29
* Yan Uzanma İkilileri:    %0,23
* Serçe/Yüzük Makasları:   %0,34

Üçlü istatistikler:
* alt:             %37,45
* ikili içe yuvarlama:  %29,02
* ikili dışa yuvarlama: %14,67
* diğer:           %8,28
* alt sfs:         %5,10
* yön değiştirme:  %2,14
* içe yuvarlama:   %1,71
* zayıf yön değiştirme: %1,32
* dışa yuvarlama:  %0,31

### [KeySolve analizörü](https://grassfedreeve.github.io/keysolve-web/)

> **NOT:** Bu analizör şu anda, geleneksel CapsLock tuşu ve apostrof gibi
> ana sıradaki yan serçe tuşlarına harf yerleştirmeyi desteklemiyor; bu nedenle
> sonuçlar doğru olmayabilir. Örneğin, burada SFB yüzdesi R B V'nin tümünün
> baş parmakla yazıldığını varsayar, halbuki gerçekten farklı parmaklardadır:
> R sağ baş parmakta, B sol serçe, V sağ serçe parmaktadır.

![Ekran görüntüsü 1](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve1.png)
![Ekran görüntüsü 2](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve2.png)
![Ekran görüntüsü 3](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve3.png)

Genel istatistikler:

    İKİLİLER     SFB: %0,97     LSB: %0,44     HSB: %4,79     FSB: %0,35
    ATLAMA       SFS: %6,99     LSS: %0,92     HSS: %4,66     FSS: %0,38
    ÜÇLÜLER      ALT: %41,24    ROL: %40,71    ONE: %2,47     RED: %1,66

Parmak kullanımı:

    SOL         LI: %13,91     LM: %20,17    LR: %8,70      LP: %3,05
    SAĞ         RI: %13,12     RM: %14,59    RR: %10,60     RP: %7,94
    TOPLAM             LH: %45,83                       RH: %54,17

Kopyala/yapıştır için özel kaynak:

    q y o u - x l d w z
    c i e a , k h t n s
    ' / = . ; j m g p f
    r b v

### [Oxey analizörü](https://oxey.dev/playground/index.html)

> **NOT:** Bu analizör şu anda, geleneksel CapsLock tuşu ve apostrof gibi
> ana sıradaki yan serçe tuşlarına harf yerleştirmeyi desteklemiyor; bu nedenle
> sonuçlar doğru olmayabilir. Örneğin, burada SFB yüzdesi B ve V'nin sol baş
> parmakla yazıldığını varsayar, halbuki gerçekten farklı parmaklardadır:
> B sol serçe, V sağ serçe parmakla yazılır.

![Ekran görüntüsü](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/oxey.png)

Genel istatistikler:
* Sfb:              %0,811
* Dsfb:             %6,286
* Lsb:              %0,372
* İçe yuvarlama:    %29,442
* Dışa yuvarlama:   %15,841
* Toplam yuvarlama: %45,283
* Tek elle:         %2,348
* Alternasyon:      %31,877
* Alternasyon (sfs):%7,284
* Toplam alternasyon:%39,161
* Yön değiştirme:   %3,864
* Kötü yön değişimi:%1,002
* Toplam yön değişimi:%4,866
* Diğer:            %8,341
* Geçersiz:         %0,001

Parmak kullanımı:

    parmak 0:  %3,63   parmak 9:    %8,60
    parmak 1:  %9,08   parmak 8:   %10,65
    parmak 2: %19,30   parmak 7:   %14,56
    parmak 3: %13,28   parmak 6:   %12,33

    Sol el:   %45,29  Sağ el:      %46,14
    Sol orta: %1,384  Sağ orta:    %1,189

    Ana tuş kullanımı: %56,37

Sfb% parmak başına:

    parmak 0:  %0,011  parmak 9:   %0,024
    parmak 1:  %0,047  parmak 8:   %0,100
    parmak 2:  %0,122  parmak 7:   %0,051
    parmak 3:  %0,339  parmak 6:   %0,114

### Karşılaştırma

> **NOT:** Oxey analizörü şu anda, geleneksel CapsLock tuşu ve apostrof gibi
> ana sıradaki yan serçe tuşlarına harf yerleştirmeyi desteklemiyor; bu nedenle
> sonuçlar doğru olmayabilir. Örneğin, burada SFB yüzdesi B ve V'nin sol baş
> parmakla yazıldığını varsayar, halbuki gerçekten farklı parmaklardadır:
> B sol serçe, V sağ serçe parmakla yazılır.
> Bunun yerine, [Cyanophage analizörünün sonuçlarını](#cyanophage-analizörü)
> dikkate alın, çünkü yan serçe tuşlarını ve bir baş parmak harf tuşunu hesaba katar.

[Klavye düzeni topluluğu][rKL] genellikle [Pascal Getreuer'ın rehberi ve karşılaştırma tablosunu][PGt]
düzen keşfi için başlangıç noktası olarak önerir; burada Enthium'un
istatistiksel olarak en iyi düzenlerden biri olduğu görülür:

* %0,811 SFB -- 🥈 ikinci sırada; Focal üstte
* %0,372 LSB -- 🥇 birinci sırada; tüm tabloyu geçiyor!
* %45,283 yuvarlama -- Nerps, Gallium, MTGAP, Graphite, Dvorak, Halmak vb.'yi geçiyor
* %4,866 yön değiştirme -- MTGAP, Sturdy, Recurva, APTv3, Canary, Colemak vb.'yi geçiyor
* %2,80 serçe dışı _yan hariç_ -- Graphite, Canary, Gallium, MTGAP vb.'yi geçiyor
  * `Q` (%0,10) + `'` (%0,48) + `Z` (%0,10) + `F` (%2,12)
* %5,35 serçe dışı _yan dahil_ -- Engram, Halmak’ı geçiyor; diğerlerinin gerisinde
  * `Q` (%0,10) + `'` (%0,48) + `Z` (%0,10) + `F` (%2,12) + `B` (%1,49) + `V` (%1,06)

[rKL]: https://www.reddit.com/r/KeyboardLayouts/
[PGt]: https://getreuer.info/posts/keyboards/alt-layouts/index.html#which-alt-keyboard-layout-should-i-learn

Tamamlayıcılık için, tüm [bu ve ilgili düzenlerin istatistiklerini](https://raw.githubusercontent.com/sunaku/enthium/main/stats/) tabloya aldım:

[cNT]: https://cyanophage.github.io/playground.html?layout=zwdlx-uoyq%5Csnthk%2Caeicbfpgmj%3B.%3D%2F%27vr&mode=ergo&lan=english
[cPM]: https://cyanophage.github.io/playground.html?layout=fpdlx%3Buoybzsnthk%2Caeicqvwgmj-.%27%3D%2F%5Cr&mode=ergo&lan=english
[cNG]: https://cyanophage.github.io/playground.html?layout=byou%27%3Bldwvzciea%2C.htsnqgxjk-%2Frmfp%5C%5E&mode=ergo&lan=english
[cDV]: https://cyanophage.github.io/playground.html?layout=%27%2C.pyfgcrl%2Faoeuidhtns-%3Bqjkxbmwvz%5C%5E&mode=ergo&lan=english
[cCD]: https://cyanophage.github.io/playground.html?layout=qwfpbjluy%3B-arstgmneio%27zxcdvkh%2C.%2F%5C%5E&mode=ergo&lan=english

| Analizör   | Kategori | İstatistik           | [Enthium][cNT] | [Promethium][cPM] | [Engrammer][cNG] | [Dvorak][cDV] | [Colemak-DH][cCD] |
| ---------- | -------- | -------------------- | -------------- | ----------------- | ---------------- | ------------- | ----------------- |
| Oxey's     | İkili    | SFB                  | %0,811         | %0,868            | %1,511           | %2,779        | %1,367            |
| Oxey's     | İkili    | DSFB                 | %6,286         | %6,761            | %7,620           | %6,979        | %8,767            |
| Oxey's     | İkili    | LSB                  | %0,372         | %0,404            | %0,671           | %1,255        | %1,975            |
| Oxey's     | Üçlü     | İçe yuvarlama        | %29,442        | %29,333           | %28,273          | %23,820       | %25,173           |
| Oxey's     | Üçlü     | Dışa yuvarlama       | %15,841        | %14,526           | %14,050          | %15,104       | %20,940           |
| Oxey's     | Üçlü     | Toplam yuvarlama     | %45,283        | %43,858           | %42,323          | %38,924       | %46,113           |
| Oxey's     | Üçlü     | Tek elle             | %2,348         | %2,189            | %2,146           | %0,624        | %2,484            |
| Oxey's     | Üçlü     | Alternasyon          | %31,877        | %33,770           | %32,483          | %35,769       | %22,913           |
| Oxey's     | Üçlü     | Alternasyon (SFS)    | %7,284         | %8,205            | %8,752           | %8,787        | %7,461            |
| Oxey's     | Üçlü     | Toplam alternasyon   | %39,161        | %41,974           | %41,235          | %44,556       | %30,375           |
| Oxey's     | Üçlü     | Yön değiştirme       | %3,864         | %2,273            | %3,103           | %2,639        | %9,081            |
| Oxey's     | Üçlü     | Kötü yön değişimi    | %1,002         | %1,236            | %1,386           | %0,818        | %1,498            |
| Oxey's     | Üçlü     | Toplam yön değişimi  | %4,866         | %3,509            | %4,489           | %3,458        | %10,579           |
| Oxey's     | Üçlü     | Diğer                | %8,341         | %8,468            | %9,806           | %12,437       | %9,202            |
| Oxey's     | Üçlü     | Geçersiz             | %0,001         | %0,001            | %0,001           | %0,001        | %1,248            |
| Oxey's     | Kullanım | Parmak 0             | %3,63          | %9,56             | %6,58            | %8,50         | %8,12             |
| Oxey's     | Kullanım | Parmak 1             | %9,08          | %10,65            | %9,21            | %8,72         | %8,04             |
| Oxey's     | Kullanım | Parmak 2             | %19,30         | %14,56            | %19,47           | %12,99        | %11,55            |
| Oxey's     | Kullanım | Parmak 3             | %13,28         | %12,33            | %13,35           | %14,95        | %19,19            |
| Oxey's     | Kullanım | Parmak 6             | %12,33         | %13,28            | %16,04           | %16,33        | %18,88            |
| Oxey's     | Kullanım | Parmak 7             | %14,56         | %19,77            | %14,93           | %13,73        | %15,60            |
| Oxey's     | Kullanım | Parmak 8             | %10,65         | %9,01             | %10,31           | %13,84        | %10,11            |
| Oxey's     | Kullanım | Parmak 9             | %8,60          | %4,62             | %9,90            | %10,59        | %7,77             |
| Oxey's     | Kullanım | Sol el               | %45,29         | %47,10            | %48,61           | %45,16        | %46,89            |
| Oxey's     | Kullanım | Sağ el               | %46,14         | %46,68            | %51,18           | %54,49        | %52,36            |
| Oxey's     | Kullanım | Sol orta             | %1,384         | %1,189            | %1,765           | %9,208        | %4,592            |
| Oxey's     | Kullanım | Sağ orta             | %1,189         | %1,384            | %1,294           | %7,257        | %3,393            |
| Oxey's     | Kullanım | Ana tuşlar           | %56,37         | %56,37            | %56,37           | %56,70        | %62,31            |
| Oxey's     | SFB%     | Parmak 0             | %0,011         | %0,028            | %0,012           | %0,020        | %0,041            |
| Oxey's     | SFB%     | Parmak 1             | %0,047         | %0,100            | %0,089           | %0,028        | %0,047            |
| Oxey's     | SFB%     | Parmak 2             | %0,122         | %0,051            | %0,230           | %0,253        | %0,186            |
| Oxey's     | SFB%     | Parmak 3             | %0,339         | %0,114            | %0,591           | %1,075        | %0,219            |
| Oxey's     | SFB%     | Parmak 6             | %0,114         | %0,339            | %0,380           | %0,433        | %0,388            |
| Oxey's     | SFB%     | Parmak 7             | %0,051         | %0,185            | %0,053           | %0,494        | %0,341            |
| Oxey's     | SFB%     | Parmak 8             | %0,100         | %0,040            | %0,098           | %0,256        | %0,137            |
| Oxey's     | SFB%     | Parmak 9             | %0,024         | %0,011            | %0,058           | %0,220        | %0,007            |
| KeySolve   | İkili    | SFB                  | %0,97          | %0,94             | %1,56            | %2,62         | %1,49             |
| KeySolve   | İkili    | LSB                  | %0,44          | %0,45             | %0,98            | %1,17         | %2,21             |
| KeySolve   | İkili    | HSB                  | %4,79          | %6,04             | %3,02            | %6,11         | %5,93             |
| KeySolve   | İkili    | FSB                  | %0,35          | %0,26             | %0,30            | %0,14         | %0,37             |
| KeySolve   | Atlama   | SFS                  | %6,99          | %7,02             | %7,50            | %7,00         | %7,95             |
| KeySolve   | Atlama   | LSS                  | %0,92          | %0,93             | %1,34            | %4,48         | %1,75             |
| KeySolve   | Atlama   | HSS                  | %4,66          | %6,11             | %6,91            | %8,56         | %6,49             |
| KeySolve   | Atlama   | FSS                  | %0,38          | %0,78             | %0,81            | %1,22         | %0,78             |
| KeySolve   | Üçlü     | ALT                  | %41,24         | %40,37            | %39,59           | %41,70        | %27,58            |
| KeySolve   | Üçlü     | ROL                  | %40,71         | %40,84            | %39,35           | %37,19        | %42,78            |
| KeySolve   | Üçlü     | ONE                  | %2,47          | %2,66             | %2,65            | %0,43         | %2,45             |
| KeySolve   | Üçlü     | RED                  | %1,66          | %1,78             | %2,65            | %2,25         | %6,74             |
| KeySolve   | Kullanım | LI                   | %13,91         | %13,91            | %13,91           | %14,56        | %18,82            |
| KeySolve   | Kullanım | LM                   | %20,17         | %20,92            | %20,30           | %13,96        | %10,18            |
| KeySolve   | Kullanım | LR                   | %8,70          | %8,70             | %8,83            | %9,55         | %7,83             |
| KeySolve   | Kullanım | LP                   | %3,05          | %3,64             | %5,72            | %8,24         | %7,63             |
| KeySolve   | Kullanım | RI                   | %13,12         | %13,12            | %16,52           | %16,90        | %20,00            |
| KeySolve   | Kullanım | RM                   | %14,59         | %14,59            | %15,03           | %13,35        | %16,91            |
| KeySolve   | Kullanım | RR                   | %10,60         | %10,60            | %10,08           | %13,36        | %10,46            |
| KeySolve   | Kullanım | RP                   | %7,94          | %8,95             | %9,47            | %10,08        | %8,16             |
| KeySolve   | Toplam   | LH                   | %45,83         | %47,18            | %48,75           | %46,31        | %44,46            |
| KeySolve   | Toplam   | RH                   | %54,17         | %52,82            | %51,25           | %53,69        | %55,54            |
| Cyanophage | Özet     | Toplam Kelime Eforu  | 748,5          | 732,3             | 899,8            | 1185,5        | 1048,2            |
| Cyanophage | Özet     | Efor                 | 432,54         | 398,07            | 457,44           | 769,78        | 535,05            |
| Cyanophage | İkili    | Aynı Parmak İkili    | %0,55          | %0,58             | %0,99            | %1,87         | %0,91             |
| Cyanophage | İkili    | Atlama İkilisi (2u)  | %0,29          | %0,36             | %0,39            | %0,45         | %0,41             |
| Cyanophage | İkili    | Yan Uzanma İkilisi   | %0,23          | %0,24             | %0,41            | %0,80         | %1,27             |
| Cyanophage | İkili    | Serçe/Yüzük Makası   | %0,34          | %0,42             | %0,71            | %0,40         | %0,65             |
| Cyanophage | Üçlü     | Alt                  | %37,45         | %36,98            | %35,62           | %39,08        | %25,43            |
| Cyanophage | Üçlü     | Alt SFS              | %5,10          | %5,27             | %5,93            | %5,85         | %5,47             |
| Cyanophage | Üçlü     | İçe yuvarlama        | %1,71          | %1,37             | %1,82            | %0,86         | %1,50             |
| Cyanophage | Üçlü     | Dışa yuvarlama       | %0,31          | %0,11             | %0,29            | %0,27         | %0,98             |
| Cyanophage | Üçlü     | İkili içe yuvarlama  | %29,02         | %29,18            | %28,14           | %23,51        | %25,18            |
| Cyanophage | Üçlü     | İkili dışa yuvarlama | %14,67         | %14,56            | %14,03           | %15,14        | %21,55            |
| Cyanophage | Üçlü     | Yön değiştirme       | %2,14          | %2,03             | %3,05            | %2,57         | %9,22             |
| Cyanophage | Üçlü     | Zayıf yön değiştirme | %1,32          | %1,30             | %1,40            | %0,28         | %1,52             |
| Cyanophage | Üçlü     | Diğer                | %8,28          | %9,20             | %9,72            | %12,44        | %9,17             |

## Kurulum

### Linux kurulumu

>*Açıklama:* QWERTY=beyaz; Engram=altın; Enthium=mavi/yeşil; Gariplikler=pembe.
>![Bu düzenin sıra-kaydırmalı bir klavyede gösterimi.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)

Kurulum:

    cd linux/
    sudo make install
    echo Oturumu tekrar başlatınız.

Aktifleştirme:

    setxkbmap -layout us    -variant enthium         # tek düzen; geçiş yok
    setxkbmap -layout us,us -variant enthium,basic   # çift düzen geçişli

Onarma (ör. sistem genelinde XKB paketi güncellemesi kurulumu geri alırsa):

    cd linux/
    sudo make reinstall
    echo Oturumu tekrar başlatınız.

Kaldırma:

    cd linux/
    sudo make uninstall
    echo Oturumu tekrar başlatınız.

### MacOS kurulumu

#### Kurulum

Düzeni MacOS'ta kullanmak için [Karabiner-Elements](https://karabiner-elements.pqrs.org/) uygulamasını yüklemeniz gerekir.

[Homebrew](https://brew.sh/) ile kurulabilir:

    brew install --cask karabiner-elements

Veya ana [Karabiner-Elements web sitesinden](https://karabiner-elements.pqrs.org/) indirilebilir.

İndirdikten sonra, [kurulum kılavuzundaki](https://karabiner-elements.pqrs.org/docs/getting-started/installation/) talimatları izleyin.

#### Karmaşık modifikasyon

Her şey kurulduktan sonra, [karmaşık modifikasyon özelliği](https://karabiner-elements.pqrs.org/docs/manual/configuration/configure-complex-modifications/) ile tuşlarınızı yeniden eşleyebilirsiniz.

Enthium karmaşık modifikasyonu [burada](https://ke-complex-modifications.pqrs.org/?q=enthium) mevcuttur.

Temel düzene dönmek için Enthium karmaşık modifikasyonunu kaldırmanız yeterlidir.

#### Kaldırma

* Brew : `brew uninstall --cask karabiner-elements`
* Manuel : `Karabiner-Elements.app` uygulamasını Uygulamalar klasörünüzden silin.

## Lisans

[Arno'nun Engram 2.0] klavye düzeni kaynakları ile aynı koşullarda yayımlanmıştır:

> MIT Lisansı
>
> Telif Hakkı 2022 Ricard Figueroa <https://github.com/rfiga>  
> Telif Hakkı 2021 Suraj Kurapati <https://github.com/sunaku>  
> Telif Hakkı 2021 Arno Klein <https://github.com/binarybottle>  
>
> Bu yazılımın ve ilgili dokümantasyon dosyalarının ("Yazılım") bir kopyasını
> ücretsiz olarak elde eden herkese, Yazılımı herhangi bir kısıtlama olmaksızın
> kullanma, kopyalama, değiştirme, birleştirme, yayımlama, dağıtma, alt lisans
> verme ve/veya satma ve Yazılımı sağlananlara bu işlemleri yapmalarına izin verme
> hakkı burada ücretsiz olarak verilmektedir, aşağıdaki koşullara tabidir:
>
> Yukarıdaki telif hakkı bildirimi ve bu izin bildirimi, Yazılımın tüm kopyalarına
> veya önemli bölümlerine dahil edilecektir.
>
> YAZILIM, AÇIK VEYA ZIMNİ HİÇBİR GARANTİ OLMAKSIZIN, PAZARLANABİLİRLİK,
> BELİRLİ BİR AMACA UYGUNLUK VE İHLAL ETMEME GARANTİLERİ DAHİL ANCAK BUNLARLA
> SINIRLI OLMAKSIZIN "OLDUĞU GİBİ" SAĞLANIR. YAZARLAR VE TELİF HAKKI SAHİPLERİ,
> YAZILIMDAN VEYA YAZILIMIN KULLANIMINDAN VEYA DİĞER İŞLEMLERDEN KAYNAKLANAN
> HERHANGİ BİR TALEP, ZARAR VEYA DİĞER YÜKÜMLÜLÜKTEN SORUMLU DEĞİLDİR.

---------------------------------------------------------------------------
[Bir Hayat Kurtar]: https://sunaku.github.io/vegan-for-life.html
> Çalışmamı beğendiniz mi? 👍 Bugün bir [hayat kurtarın]! 🐄🐖🐑🐔🐣🐟✨🙊✌  
> Neden? 💕 etik, 🌎 çevre ve 💪 sağlık için; yukarıdaki bağlantıya bakınız. 🙇

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---