
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Yakında">繁體中文 (yakında)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Yakında">हिन्दी (yakında)</a> |
        | <a href="#" title="Yakında">ไทย (yakında)</a> |
        | <a href="#" title="Yakında">Français (yakında)</a>
        | <a href="#" title="Yakında">Deutsch (yakında)</a>
        | <a href="#" title="Yakında">Español (yakında)</a>
        | <a href="#" title="Yakında">Italiano (yakında)</a>
        | <a href="#" title="Yakında">Русский (yakında)</a>
        | <a href="#" title="Yakında">Português (yakında)</a>
        | <a href="#" title="Yakında">Nederlands (yakında)</a>
        | <a href="#" title="Yakında">Polski (yakında)</a>
        | <a href="#" title="Yakında">العربية (yakında)</a>
        | <a href="#" title="Yakında">فارسی (yakında)</a>
        | <a href="#" title="Yakında">Türkçe (yakında)</a>
        | <a href="#" title="Yakında">Tiếng Việt (yakında)</a>
        | <a href="#" title="Yakında">Bahasa Indonesia (yakında)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Yalnızca belirli zaman dilimlerinden veriyle eğitilmiş, modern önyargıyı azaltmayı amaçlayan bir LLM.

Bir yapay zekâ modelinin tarihi taklit etmekle kalmayıp, aslında gerçekten öyle olduğunu hayal edin.

[Andrej Karpathy'nin nanoGPT'si](https://github.com/karpathy/nanoGPT) üzerine inşa edilmiştir. Temel eğitim betikleri ve model mimarisi ona aittir.

# Proje Hedefleri

TimeCapsule LLM, yalnızca belirli zaman dilimlerinde yazılmış metinlerle eğitilecek deneysel bir projedir. Amaç, belirli tarihî dönemlerin dünya görüşünü ve dilini simüle etmektir.

# Neden ince ayar yeterli değil

Sadece önceden eğitilmiş bir modeli ince ayar yaparsanız, LLM'iniz hâlâ modern kavramları bilecektir. Elbette sıfır modern önyargı elde etmek zordur ama buna olabildiğince yaklaşmak istiyorum. Hiç modern önyargı olmaması için modeli sıfırdan eğitmek gerekiyor.

# Beklenen sonuçlar

Umarım tamamlandığında, bu model modern kavramları bilmeyecek ve yalnızca eğitildiği bilgilerle akıl yürütebilecek. Modern kavramları/kelime dağarcığını tanımamalı ve umarım modern bilgi uydurmaz.

# İlerleme Güncellemeleri

## 9 Temmuz 2025

Zaman dilimimi 1800-1850 ve bölgeyi: Londra olarak belirledim.

Bir metin, kitap, belge listesi topladım.

Şu ana kadar 50 tanesini txt dosyası olarak aldım ve yakında NanoGPT eğitimine başlayacağım.

İlerleme kaydettikçe bunu güncelleyeceğim.

## 13 Temmuz 2025

nanoGPT'yi 187MB tarihî metin verisiyle eğittim.

## 15 Temmuz 2025

İkinci eğitim turu için metinleri indirmeye başladım. Her şeyi Internet Archive'dan alıyorum ve zaman dilimini 1800-1875 olarak genişlettim. Çeşitli metinler elde etmek için Internet Archive'da yayın yeri, zaman aralığı ve konu filtrelerini kullanabilirsiniz.

![Arama Filtreleri](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 Temmuz 2025

Internet Archive'dan yaklaşık 500 adet txt dosyası indirdim ve bunları temizledikten sonra (sadece boşlukları, Gutenberg başlıklarını vs. sildim) yaklaşık 500MB veri elde ettim. Bu çok küçük bir veri seti ama geçen sefer 187MB ile eğitmiştim, bu yüzden ikinci modeli eğittikten sonra çıktıda en azından belirgin bir fark olmalı. Bu modelin en azından daha anlamlı ve tutarlı cümleler kurabilmesini umuyorum. Elbette bu bir garanti değil çünkü hâlâ çok küçük bir veri seti, fakat geçen sefere göre daha fazla veri var.

Bunu kendi donanımımda yapmak mümkün, bu da iyi çünkü daha büyük bir veri setine geçmeden önce en azından bazı iyileşmeleri görebilirim. Büyük bir veri seti için GPU kiralamam gerekecek ama endişelenmeyin, yakında GPU kiralamayı planlıyorum; ancak bunu yapmadan önce veri setimin olabildiğince özenli ve temiz olmasını istiyorum. Sorunlardan biri de temizlik, birçok txt dosyasında saçma sapan yazılar karışıyor. Temizlik için kullandığım betikler işe yarıyor ama %100 etkili değiller.

Bu veri setini bugün eğiteceğim ve yaklaşık 4-5 saat sürecek. İşlem bittiğinde ve test ettiğimde güncellemeleri paylaşacağım. Projeme bakan herkese tekrar teşekkür ederim, hatta bana OCR kaynakları gönderenler bile oldu, teşekkürler! Umarım daha fazla insan bunu dener ve kendi veri setleriyle deney yapar.

## 28 Temmuz 2025

v0.5 sürümünü Hugging Face'e yükledim, [Buradan bakabilirsiniz](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) isterseniz. Artık depomu indirip yerel olarak çalıştırabilirsiniz. Maalesef nanoGPT HuggingFace ile doğrudan çalışmıyor, bu yüzden modeli indirip yerel olarak çalıştırmanız gerekecek.

Ayrıca bir sonraki eğitim turum için veri toplamaya başlayacağım, akıl yürütme yeteneği elde etmek için muhtemelen 5-10 kat daha fazla veriye ihtiyacım olacak.

### Eğitim Güncellemesi

435MB'lık bir derlemede (108 M token) eğitime başladım, şu an oldukça sorunsuz ilerliyor. Eğitim kaybı ilk 2800 iterasyonda 10.9'dan 4.9'a düştü. Tamamlanmasının 8-9 saat süreceğini tahmin ediyorum. Bittiğinde başka bir güncelleme paylaşacağım.

## 17 Temmuz 2025 2:13AM

İkinci modelin eğitimi tamamlandı, 4060 ekran kartımda yaklaşık 8 saat 40 dakika sürdü (saatte 3.900 iterasyon) ve 33.000 iterasyon (5 epoch) tamamlandı. Son eğitim kaybı 3.73 oldu. Çıktılar şaşırtıcı derecede iyi, artık gerçekten tutarlı 19. yüzyıl tarzı cümleler üretebiliyor.

# V0 Model Davranışı ve Sınırlamaları

İlk istemlerde modelin 1800'lerin dili ve davranışıyla yanıt verdiği görülüyor. Örneğin, "Who art Henry?" diye sordum ve şu cevabı verdi: "I know that man, I have did not a black, the storm." evet, bu cümlenin bir anlamı yok ama LLM bir kişiden bahsettiğimi anlıyor.

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)
Modern kavramlardan bahsedilmiyor, çıktılar çoğunlukla 1800'lerden kelimeler ve ifadeler içeriyor.

Hala çok fazla çalışmaya ihtiyaç var, 187MB üzerinden eğitmek karmaşık muhakeme üreten bir model vermez.

Şu anda tam cümle yapısından yoksun ve genel olarak anlamsız cümleler üretiyor ama bu eğitim boyutu için normal.

# V0.5 Model Davranışı & Sınırlamaları

Bu, bir önceki modele kıyasla güzel bir gelişme. Yazı stili ve kelime dağarcığı Viktorya dönemi ve neredeyse her cümle dilbilgisi açısından doğru, noktalama işaretleri yerinde. Ve yine bu sıfırdan eğitildiği için 1800'ler konularına sadık kalıyor.

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Çok fazla gerçek dışı uydurma var. Detayların (tarihler, olaylar, tarihi figürler) çoğu (yaklaşık %100'ü) uydurma. Ayrıca cümleler birbirleriyle bağlantılı değil, bazen belki 2 cümle birbirine bağlı olur ama onun dışında olmaz. Bir diğer sorun ise bazen “Digitized by Google” gibi bir dipnotun araya girmesi, bir dahaki eğitimde metinlerin iyice temizlenmiş olduğundan emin olmam gerekiyor. Genel olarak sonuçlardan çok memnunum, henüz bir LLM değil ama kesinlikle bir cümle üreteci.

Çok şey öğreniyorum ve önümüzdeki haftalarda neyi daha iyi yapmam gerektiğini anlamaya başlayacağım. Dosyaları yakında yükleyeceğim!

# Yaklaşan Planlar

(Tamamlandı) 0.5 sürümü üzerinde çalışmaya başlayacağım, 50 kitapla eğitmek yerine ideal olarak 500-600 kitapla eğiteceğim. Şu anda nanoGPT'yi 1800-1850 yılları arasından ve özellikle Londra'dan kitaplarla eğitiyorum. Bulduğum kitapların güncellenmemiş ya da modern yorumlar içermediğinden, seçtiğim zaman diliminde yayımlanmış dokunulmamış kitaplar olduğundan emin olmak gibi bazı zorluklar var.

Daha büyük bir derlemeyle (v1) yeni bir model eğitmek istiyorum, belki v0.5 için kullandığımın 5-10 katı büyüklükte. Amacım, sadece Seçici Zamansal Eğitim ile muhakeme yeteneklerinin ortaya çıkıp çıkamayacağını görmek, bu daha zor bir görev olacak ve tarihi veri sınırlamaları nedeniyle mümkün olup olmadığından emin değilim. Önümüzdeki haftalarda 5-10GB'lık bir derleme için yeterli veri toplamaya çalışacağım. Temiz, yüksek kaliteli veri ve bir GPU kiralayabilirsem ilerleme olacağına inanıyorum.

# Bu Proje Nasıl Kullanılır

Bu proje çoğunlukla tarihi verilerin toplanması, eğitime hazırlanması ve bir ayrıştırıcı oluşturulmasına odaklanıyor. Tam LLM eğitim sürecini anlatmayacağım, bunun için Andrej Karpathy'nin nanoGPT'sine bakınız.

# Adım 1: Tarihi Metinleri Topla ve Hazırla

Seçtiğiniz zaman diliminden kamuya açık kitapların, belgelerin vb. .txt dosyalarını toplayın (ör. Londra 1800-1850)

İsterseniz download_texts_improved.py dosyasını kitapları indirmek için kullanabilirsiniz.

Metin dosyalarını bir betik veya elle temizleyin, Project Gutenberg başlık/dipnotlarını, modern açıklamaları ya da OCR hatalarını çıkarın.

prepare_dataset.py sorunsuz çalışacaktır.

# Adım 2: Özel Bir Tokenizer Oluştur

train_tokenizer.py veya train_tokenizer_hf.py dosyasını temizlenmiş veri üzerinde çalıştırın.
Bu size vocab.json ve merges.txt dosyalarını verecek

Bu dosyalar modeliniz için kelime dağarcığını ve birleştirme kurallarını tanımlar

# Adım 3: Modelinizi Eğitin (nanoGPT)

Eğitim süreci için [Andrej Karpathy'nin nanoGPT'sine](https://github.com/karpathy/nanoGPT) bakın.

İsterseniz farklı bir LLM de eğitebilirsiniz, ama ben nanoGPT kullandım

# SSS

## Seçici Zamansal Eğitim (Selective Temporal Training) nedir?

Seçici Zamansal Eğitim (STT), tüm eğitim verilerinin belirli bir tarihsel zaman dilimine ait olacak şekilde özel olarak seçildiği bir makine öğrenimi metodolojisidir. Bu, o dönemin dilini ve bilgisini modern kavramlardan etkilenmeden modellemek için yapılır. Örneğin, şu anki modelim (v0.5) yalnızca 1800-1875 verileriyle eğitildi, ince ayar yapılmadı, sıfırdan eğitildi ve bu da çıktının o zaman diliminin dil stilini ve tarihsel bağlamını yansıtmasını sağladı.

## Neden sadece ince ayar (fine-tuning) veya LoRA kullanmıyorsun?

Bu projede modern önyargıdan arındırılmış bir dil modeli üretmeye çalışıyorum. GPT-2 gibi bir şeyi ince ayar yaparsam, zaten önceden eğitilmiş ve bu bilgi ortadan kalkmaz. Sıfırdan eğitirsem, dil modeli eski gibi davranmayacak, gerçekten eski olacak. Şu anda bu projenin amacı, yalnızca 1800-1850 yılları arasında Londra'da yayımlanan kitaplardan bilgiyle mantık yürütebilen bir şey yaratmak.

## Eğitim için ne tür veri kullandınız?

Kitaplar, yasal belgeler, gazeteler ve 1800–1850 Londra'sından diğer yazılar kullanıyorum. Bağlantısını verdiğim listede 200 kadar var ama ilk eğitimde sadece 50 dosya (~187 MB) kullandım. Belgelerin listesini şurada görebilirsiniz:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Sürüm 0 modeli ne kadar büyük?

Bu model şu anda çok küçük, sadece eğlence amaçlı yapıyorum ve kesin bir eğitim kuralı olarak modern kaynak kullanmıyorum. Yaklaşık 16 milyon parametresi var ama daha fazla eski metin toplayıp başka bir model eğitimine başlayacağım. Gelişmeleri aktaracağım.

## Eğitim Teknik Özellikleri?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---