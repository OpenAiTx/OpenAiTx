<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">İngilizce</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Yakında">繁體中文 (yakında)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">Japonca</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">Korece</a>
        | <a href="#" title="Yakında">हिन्दी (yakında)</a> |
        | <a href="#" title="Yakında">ไทย (yakında)</a> |
        | <a href="#" title="Yakında">Fransızca (yakında)</a>
        | <a href="#" title="Yakında">Almanca (yakında)</a>
        | <a href="#" title="Yakında">İspanyolca (yakında)</a>
        | <a href="#" title="Yakında">İtalyanca (yakında)</a>
        | <a href="#" title="Yakında">Rusça (yakında)</a>
        | <a href="#" title="Yakında">Portekizce (yakında)</a>
        | <a href="#" title="Yakında">Felemenkçe (yakında)</a>
        | <a href="#" title="Yakında">Lehçe (yakında)</a>
        | <a href="#" title="Yakında">Arapça (yakında)</a>
        | <a href="#" title="Yakında">Farsça (yakında)</a>
        | <a href="#" title="Yakında">Türkçe (yakında)</a>
        | <a href="#" title="Yakında">Vietnamca (yakında)</a>
        | <a href="#" title="Yakında">Endonezce (yakında)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Modern önyargıyı azaltmak için yalnızca belirli zaman dilimlerinden alınan verilerle eğitilmiş bir LLM.

Bir AI modelinin tarihiymiş gibi davranmasının ötesinde, gerçekten tarihi olduğunu hayal edin.

[Andrej Karpathy'nin nanoGPT'si](https://github.com/karpathy/nanoGPT) üzerine inşa edilmiştir. Temel eğitim betikleri ve model mimarisi ona aittir.

# Proje Hedefleri

TimeCapsule LLM, yalnızca belirli zaman dilimlerinde yazılmış metinlerle eğitilecek deneysel bir projedir. Amaç, belirli tarihi dönemlerin dünya görüşünü ve dilini simüle etmektir.

# Neden sadece ince ayar yeterli değil

Sadece önceden eğitilmiş bir modeli ince ayarlarsanız, LLM'iniz yine de modern kavramları bilecek. Elbette sıfır modern önyargıya ulaşmak zor ama buna mümkün olduğunca yaklaşmak istiyorum. Hiç modern önyargı olmaması, modelin sıfırdan eğitilmesini gerektirir.

# Beklenen Sonuçlar

Umarım tamamlandığında, bu model modern kavramları bilmeyecek ve eğitildiği bilginin ötesinde akıl yürütemeyecek. Modern kavramları/kelime dağarcığını tanımamalı ve umarım modern bilgi uydurmaz.

# İlerleme Güncellemeleri

## 9 Temmuz 2025

Zaman dilimimi 1800-1850 ve bölgeyi Londra olarak belirledim.

Bir dizi metin, kitap, belge topladım.

Şimdiye kadar 50 tanesini txt dosyası olarak aldım ve yakında NanoGPT'yi eğitmeye başlayacağım.

İlerleme kaydedildikçe burayı güncelleyeceğim.

## 13 Temmuz 2025

nanoGPT'yi 187MB'lık tarihi metin verisiyle eğittim.

## 15 Temmuz 2025

İkinci eğitim turu için metinleri indirmeye başladım. Tüm verileri Internet Archive'dan alıyorum ve zaman dilimini 1800-1875 olarak genişlettim. Farklı metinler almak için Internet Archive'da yayın yeri, zaman dilimi ve konu filtrelerini kullanabilirsiniz.

![Arama Filtreleri](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 Temmuz 2025

Internet Archive'dan yaklaşık 500 txt dosyası indirdim ve bunları temizledikten sonra (sadece boşlukları, Gutenberg başlıklarını vs. silerek) yaklaşık 500MB veri elde ettim. Küçük bir veri seti ama geçen sefer 187MB ile eğittim, bu yüzden ikinci modeli eğittikten sonra çıktıda en azından gözle görülür bir fark olmalı. Umarım bu model en azından anlamlı cümleler üretebilir. Tabii ki bu garanti değil çünkü bu hâlâ çok küçük bir veri seti, ama geçen sefer kullandığımdan fazla.

Bu kendi donanımımda yapılabilir, bu da iyi çünkü daha büyük bir veri setine geçmeden önce bazı iyileştirmeleri görebilirim. Daha büyük bir veri seti için GPU kiralamam gerekecek. Ama endişelenmeyin, yakında GPU kiralamayı hâlâ planlıyorum, fakat bunu yapmadan önce veri setimin olabildiğince seçilmiş ve temiz olduğundan emin olmak istiyorum. Sorunlardan biri temizlik; bu txt dosyalarının çoğunda anlamsız karakterler karışmış. Temizleme için kullandığım betikler çalışıyor ama %100 etkili değiller.

Bu veri setini bugün eğiteceğim ve yaklaşık 4-5 saat sürmeli. Bittiğinde ve test ettiğimde güncelleme yapacağım. Projeme bakan herkese tekrar teşekkürler, bana OCR kaynakları için bağlantı gönderenler bile oldu, çok teşekkür ederim! Umarım daha fazla kişi bunu dener ve kendi veri setleriyle deneyler yapar.

### Eğitim Güncellemesi

435MB'lık (108 M token) bir veriyle eğitime başladım, şu anda gayet iyi gidiyor. Eğitim kaybı ilk 2800 iterasyonda 10,9'dan 4,9'a düştü. Tamamlanması yaklaşık 8-9 saat sürecek gibi görünüyor. Bittiğinde başka bir güncelleme yayınlayacağım.

## 17 Temmuz 2025 02:13

İkinci modelin eğitimi tamamlandı, 4060 kartımda 8 saat 40 dakika (saatte 3.900 iterasyon) sürdü, toplam 33.000 iterasyon (5 epoch). Son eğitim kaybı 3,73 oldu. Çıktılar şaşırtıcı derecede iyiydi, gerçekten 19. yüzyıl tarzında anlamlı cümleler üretiyor artık.

# V0 Model Davranışı ve Sınırlamaları

İlk istemler, modelin 1800'lerin dili ve davranışıyla yanıt verdiğini gösteriyor. Mesela, "Who art Henry?" diye sordum ve "I know that man, I have did not a black, the storm." diye yanıtladı. Evet, bu cümlenin anlamı yok ama LLM bir kişiden bahsettiğimi anlıyor.

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Modern kavramlardan hiç bahsedilmiyor, çıktılar çoğunlukla 1800'lerin kelimelerini ve ifadelerini içeriyor.

Hâlâ çok fazla çalışmaya ihtiyacı var; 187MB ile eğitim, karmaşık akıl yürütmeye sahip metin üreten bir model vermez.

Şu anda tam cümle yapısı olmayan ve genel olarak anlamlı olmayan cümleler üretiyor ama bu, eğitim veri boyutu için normal.

# V0.5 Model Davranışı & Sınırlamaları

Bu, son modele kıyasla güzel bir gelişme. Yazı stili ve kelime dağarcığı Viktoryen ve neredeyse her cümle gramer olarak doğru, noktalama işaretleri de uygun. Ve yine bu model sıfırdan eğitildiği için 1800’lerin konularına bağlı kalıyor.

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Çok fazla gerçek dışı halüsinasyon var. Ayrıntıların (tarih, olay, tarihi şahıslar) çoğu (neredeyse %100’ü) uydurma. Ayrıca cümleler arasında gerçekten bağlantı yok, bazen belki 2 cümle birbiriyle ilişkili olabiliyor ama bunun ötesine geçmiyorlar. Bir diğer sorun ise bazen rastgele bir “Digitized by Google” dipnotunun görünmesi, bu yüzden bir dahaki eğitime başlamadan önce metinlerin iyice temizlendiğinden emin olmam gerekecek. Genel olarak sonuçlardan çok memnunum, henüz bir LLM olmaktan çok uzak ama kesinlikle bir cümle üretici.

Çok şey öğreniyorum ve önümüzdeki haftalarda neleri daha iyi yapmam gerektiğini belirlemeye başlayacağım. Dosyaları yakında yükleyeceğim!

# Yaklaşan Planlar

(Tamamlandı) 0.5 sürümünde çalışmaya başlayacağım, 50 kitapla eğitim yapmak yerine mümkünse 500-600 kitapla eğitim yapacağım. Şu anda 1800-1850 yılları arasındaki kitaplarla, özellikle Londra’dan kitaplarla nanoGPT eğitiyorum. Karşılaşılan bazı zorluklar, bulduğum kitapların güncellenmemiş veya modern yorumlar içermemesi, seçtiğim zaman aralığında yayımlanmış dokunulmamış kitaplar olması.

Çok daha büyük bir veri kümesiyle (v1) yeni bir model eğitmek istiyorum, belki v0.5’te kullandığımın 5-10 katı büyüklüğünde. Amacım, yalnızca Seçici Zamansal Eğitim ile akıl yürütme yeteneklerinin ortaya çıkıp çıkamayacağını görmek, bu daha zor bir iş olacak ve tarihsel veri kısıtlamaları nedeniyle mümkün olup olmadığından bile emin değilim. Önümüzdeki haftalarda 5-10GB’lık bir veri kümesi için yeterli veri toplamaya çalışacağım. Eğer temiz, yüksek kaliteli veriler bulabilir ve bir GPU kiralayabilirsem ilerleme kaydedileceğine inanıyorum.

# Bu Proje Nasıl Kullanılır

Bu proje esas olarak tarihsel verileri toplamaya, eğitime hazırlamaya ve bir tokenizer oluşturmaya odaklanıyor. Tam LLM eğitim sürecini burada ele almayacağım, bunun için Andrej Karpathy’nin nanoGPT’sine başvurun.

# Adım 1: Tarihsel Metinleri Topla ve Hazırla

Seçtiğiniz zaman aralığından (örn. Londra 1800-1850) kamuya açık kitapların, belgelerin .txt dosyalarını toplayın.

İsterseniz download_texts_improved.py dosyasını kullanarak sizin için kitapları indirebilirsiniz.

Metin dosyalarını bir betik veya elle Project Gutenberg başlık/dipnotları, modern açıklamalar veya OCR hataları gibi şeyleri kaldırarak temizleyin.

prepare_dataset.py iyi çalışacaktır.

# Adım 2: Özel Bir Tokenizer Oluştur

train_tokenizer.py veya train_tokenizer_hf.py’yi temizlenmiş veriler üzerinde çalıştırın.
Bu size vocab.json ve merges.txt dosyalarını verecek.

Bu dosyalar modeliniz için kelime dağarcığını ve birleştirme kurallarını tanımlar.

# Adım 3: Modelinizi Eğitin (nanoGPT)

Eğitim süreci için [Andrej Karpathy’nin nanoGPT](https://github.com/karpathy/nanoGPT) rehberine bakın.

İsterseniz farklı bir LLM eğitebilirsiniz, ama ben nanoGPT kullandım.

# SSS

## Seçici Zamansal Eğitim nedir?

Seçici Zamansal Eğitim (STT), tüm eğitim verisinin belirli bir tarihsel zaman aralığına ait olacak şekilde özel olarak seçildiği bir makine öğrenimi metodolojisidir. Amaç, o dönemin dili ve bilgisini modern kavramlardan etkilenmeden modellemektir. Örneğin, elimdeki mevcut model (v0.5) yalnızca 1800-1875 dönemine ait verilerle sıfırdan eğitildi, ince ayar yapılmadı, sonuç olarak çıktılar o zamanın dilsel stilini ve tarihsel bağlamını yansıtıyor.

## Neden sadece ince ayar veya LoRA kullanılmıyor?

Bu projede, modern önyargılardan arındırılmış bir dil modeli oluşturmaya çalışıyorum. GPT-2 gibi bir şeyi ince ayar yaparsam, zaten önceden eğitilmiş olur ve bu bilgi yok olmaz. Sıfırdan eğitirsem, dil modeli eski gibi davranmayacak, gerçekten öyle olacak. Şu anki proje amacı, yalnızca 1800-1850 arasında Londra’da yayımlanmış kitaplardan alınan bilgilerle akıl yürütebilen bir şey oluşturmak.

## Eğitimde ne tür veriler kullandınız?

1800–1850 Londra’sından kitaplar, yasal belgeler, gazeteler ve diğer yazıları kullanıyorum. Bağlantısını verdiğim listede yaklaşık 200 belge var ama ilk eğitim için sadece 50 dosya (~187 MB) kullandım. Belgelerin listesine buradan bakabilirsiniz:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Sürüm 0 modeli ne kadar büyük?

Bu model şu an çok küçük, sadece eğlence amaçlı ve kesinlikle modern kaynak kullanılmama kuralına uyuyorum. Yaklaşık 16 milyon parametre var ama daha fazla eski metin toplayıp yeni bir model eğitmeye başlayacağım. Gelişmeleri paylaşacağım.

## Eğitim Özellikleri?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---