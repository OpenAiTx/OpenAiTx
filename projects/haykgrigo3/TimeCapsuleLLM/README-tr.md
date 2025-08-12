
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
Belirli zaman dilimlerinden alınan verilerle eğitilen ve modern önyargıyı azaltan bir LLM.

Bir yapay zeka modelinin tarihi sadece taklit etmekle kalmayıp gerçekten o döneme ait olduğunu hayal edin.

[Andrej Karpathy'nin nanoGPT'si](https://github.com/karpathy/nanoGPT) üzerine inşa edilmiştir. Temel eğitim betikleri ve model mimarisi ona aittir.

# Proje Hedefleri

TimeCapsule LLM, yalnızca belirli zaman dilimlerinde yazılmış metinler üzerinde eğitilecek deneysel bir projedir. Amaç, belirli tarihsel dönemlerin dünya görüşünü ve dilini simüle etmektir.

# Neden ince ayar yeterli değil 

Eğer sadece önceden eğitilmiş bir modeli ince ayar ile geliştirirseniz, LLM'iniz yine de modern kavramları bilecektir. Elbette sıfır modern önyargı elde etmek zordur fakat buna olabildiğince yaklaşmak istiyorum. Hiç modern önyargı olmaması, bir modelin sıfırdan eğitilmesini gerektirir.

# Beklenen sonuçlar 

Umarım tamamlandığında, bu model modern kavramları bilmeyecek ve eğitim aldığı bilgilerin ötesinde akıl yürütemeyecek. Modern kavramları/kelime dağarcığını tanımamalı ve modern bilgi uydurmamalı.

# İlerleme Güncellemeleri

## 9 Temmuz 2025

Zaman aralığımı 1800-1850 olarak ve bölgeyi: Londra olarak belirledim

Bir metin, kitap, belge listesi topladım

Şu ana kadar 50 adet txt dosyası edindim ve NanoGPT eğitimine yakında başlayacağım

İlerleme olduğu sürece bunu güncelleyeceğim

## 13 Temmuz 2025

NanoGPT'yi 187MB'lık tarihsel metin verisiyle eğittim.

## 15 Temmuz 2025

İkinci eğitim turu için metinleri indirmeye başladım. Her şeyi Internet Archive'dan alıyorum ve zaman aralığını 1800-1875'e genişlettim. Farklı metinler elde etmek için Internet Archive'da konu ve arama filtrelerini yayın yeri, dönem ve konuya göre kullanabilirsiniz.

![Arama Filtreleri](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 Temmuz 2025

Internet Archive'dan yaklaşık 500 txt dosyası indirdim ve bunları temizledikten sonra (sadece boşlukları, Gutenberg başlıklarını vs. sildim) yaklaşık 500MB veri elde ettim. Küçük bir veri seti ama geçen sefer 187MB ile eğittim, bu nedenle ikinci modeli eğittikten sonra çıktıda en azından bir tür fark görülmeli. Umarım bu model en azından daha anlamlı cümleler üretebilir. Elbette bu bir garanti değil çünkü bu hala çok çok küçük bir veri seti, ama geçen sefer kullandığımdan daha fazla veri var.

Bunu kendi donanımımda yapmak mümkün, bu da iyi çünkü daha büyük bir veri setine geçmeden önce bazı iyileşmeler görebilirim, bu durumda bir GPU kiralamam gerekecek. Ama merak etmeyin, yakında bir GPU kiralamayı planlıyorum, fakat bunu yapmadan önce veri setimin olabildiğince özenli ve temiz olmasını istiyorum. Karşılaştığım sorunlardan biri temizlik, bu txt dosyalarının birçoğunda anlamsız şeyler karışmış durumda. Temizleme için kullandığım scriptler işe yarıyor ama %100 etkili değiller.

Bu veri setini bugün eğiteceğim ve yaklaşık 4-5 saat sürecek. Bittiğinde ve test ettiğimde güncellemeler vereceğim. Projeme göz atan herkese tekrar teşekkür ederim, hatta bana OCR kaynakları için bağlantı gönderenler bile oldu, çok teşekkürler! Umarım daha fazla kişi kendi veri setleriyle bunu dener ve deneyler yapar.

## 12 Ağustos 2025

Sürüm 1 tamamlandı, bu sürüm Phi 1.5'i (700M parametre) kullanıyor ve neredeyse 7000 metinden oluşan bir veri kümesi üzerinde eğitildi. Bu modeldeki başlıca gelişme, bazen gerçek isimler ve tarihsel olaylara referans verebilme yeteneğidir. Sürüm 0 ve 0.5 bunu yapamıyordu, bu modellere "1821 yılında" gibi bir şey sorduğumda çıktılar sadece halüsinasyonlar, hiç olmamış şeyler oluyordu. Sürüm 1 ile ilgili bir örnek:

İsteğim: Efendimizin yılı 1834 idi,

Çıktı: "Efendimizin yılı 1834 idi ve Londra sokakları protesto ve dilekçelerle doluydu. Sebep, birçoklarının anlattığı gibi, özelde bağlı değildi, fakat Lord Palmerston'ın gününde aynı gün alınmıştı, halk hukukun gününün bize ulaştığı zorluklarla ilgili kısa bir açıklama alacak. Dünyanın tarihindeki mevcut olayların açık olması ve dolayısıyla bilinecek olması derin bir üzüntü konusudur. Kudüs'te ilk olarak İncil'e yerleşen adamların, refahın ve refahın bu kadar kapsamlı ve ilgi çekici bir kaydına sahip olması doğru değildir." 

Başta bunun bir tesadüf olabileceğini düşündüm ama şuna bir bakın: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### Eğitim Güncellemesi

435MB'lık (108 M token) bir corpus üzerinde eğitime başladım, şu anda oldukça sorunsuz gidiyor. Eğitim kaybı ilk 2800 iterasyonda 10.9'dan 4.9'a düştü. Tamamlanması yaklaşık 8 veya 9 saat süreceğini tahmin ediyorum. Bittiğinde başka bir güncelleme paylaşacağım.

## 17 Temmuz 2025

İkinci model için eğitim tamamlandı, 4060'ımda yaklaşık 8 saat 40 dakika sürdü (3.900 iter/saat) ve 33.000 iterasyon (5 epoch) yapıldı. Son eğitim kaybı 3.73 oldu. Çıktılar şaşırtıcı derecede iyiydi, artık gerçekten tutarlı 19. yüzyıl tarzı cümleler üretiyor.

## 28 Temmuz 2025

v0.5'i Hugging Face'e yükledim, [Buradan bakabilirsiniz](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) isterseniz. Depomu indirip yerelde çalıştırabilirsiniz. Maalesef nanoGPT HuggingFace ile yerel olarak çalışmıyor, bu yüzden modeli indirip yerelde çalıştırmanız gerekecek.

Ayrıca bir sonraki eğitim çalışmam için veri toplamaya başlayacağım, akıl yürütme yetenekleri elde etmek için muhtemelen 5-10 kat daha fazla veriye ihtiyacım olacağını düşünüyorum.

## 2 Ağustos 2025

Yakında Sürüm 1 üzerinde çalışmaya başlayacağım. nanoGPT'nin mimarisinden daha modern bir şeye geçmem gerekecek. Aklımda birkaç açık kaynaklı LLM mimarisi var, bunlar arasında: OpenLLaMA v3, Phi-2 ve Qwen 1.5B. Ve V1'e geçişi desteklemek için çok daha büyük ve çeşitli bir veri kümesi titizlikle derlemem gerekecek. En az 5GB temiz eğitim verisine ihtiyacım olacak.

# V0 Model Davranışı ve Sınırlamaları

Erken istemlerde modelin 1800'lerin dili ve davranışıyla cevap verdiği görülüyor. Örneğin, "Who art Henry?" diye sordum ve "O adamı biliyorum, siyah değildim, fırtına." diye cevapladı ve evet bu cümle mantıklı değil ama LLM bir kişiden bahsettiğimi anlıyor.

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Modern kavramlara dair hiçbir şey yok, çıktılarda çoğunlukla 1800'lerin kelimeleri ve ifadeleri var.

Hala çok fazla çalışmaya ihtiyacı var, 187MB ile yapılan eğitim karmaşık akıl yürütme üretecek bir model vermez.

Şu anda, tam cümle yapısından yoksun ve genel olarak hiçbir anlam ifade etmeyen cümleler üretiyor ama bu eğitim boyutu için normal.

# V0.5 Model Davranışı & Sınırlamaları

Bu, son modele kıyasla güzel bir gelişme. Yazı stili ve kelime dağarcığı Viktorya dönemine ait ve neredeyse her cümle doğru noktalama ile dilbilgisel olarak doğru. Ve yine bu sıfırdan eğitildiği için 1800'ler konularına bağlı kalıyor.

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Çok fazla gerçek dışı halüsinasyon var. Ayrıntıların (tarihler, olaylar, tarihi figürler) neredeyse tamamı (%100 gibi) uydurma. Ayrıca, cümleler birbirleriyle gerçekten bağlantılı değil, bazen belki 2 cümle birbiriyle ilişkili olabiliyor ama bunun ötesine geçmiyorlar. Bir diğer sorun ise bazen rastgele bir “Google tarafından dijitalleştirildi” dipnotunun çıkması, bu yüzden bir dahaki eğitimde metinlerin iyi temizlendiğinden emin olmam gerekecek. Genel olarak sonuçlardan çok memnunum, henüz bir LLM seviyesinde değil ama kesinlikle bir cümle üreticisi.

Çok şey öğreniyorum ve önümüzdeki haftalarda neleri daha iyi yapmam gerektiğini anlamaya başlayacağım. Yakında dosyaları yükleyeceğim!

# V1 Model Davranışı & Sınırlamaları

Yakında bazı örnek çıktılar yükleyeceğim ve aynı istem ile 3 model arasında karşılaştırmalar yapacağım. V1’i de önceki versiyonda olduğu gibi huggingface’e yükleyeceğim, huggingface hesabımı burada bulabilirsiniz: https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# Yaklaşan Planlar

(Tamamlandı) 0.5 sürümü üzerinde çalışmaya başlayacağım, 50 kitap yerine ideal olarak 500-600 kitap kullanarak eğitim yapacağım. Şu anda nanoGPT’yi 1800-1850 yılları arasındaki ve özellikle Londra’dan kitaplarla eğitiyorum. Bulduğum kitapların güncellenmemiş veya modern yorumlara sahip olmamasına, seçtiğim zaman aralığında yayımlanmış dokunulmamış kitaplar olmasına dikkat etmek gibi bazı zorluklar var.

Daha büyük bir veri kümesiyle (v1) yeni bir model eğitmek istiyorum, belki v0.5 için kullandığımdan 5-10 kat daha büyük. Amacım, yalnızca Seçici Zamanlı Eğitim ile akıl yürütme yeteneklerinin ortaya çıkıp çıkmayacağını görmek, bu daha zor bir görev olacak ve tarihsel veri kısıtlamaları nedeniyle bunun mümkün olup olmadığından bile tam emin değilim. Önümüzdeki haftalarda 5-10GB’lık bir veri kümesi için yeterli veri toplamaya çalışacağım. Temiz, yüksek kaliteli veri bulabilir ve bir GPU kiralayabilirsem ilerleme olacağına inanıyorum.

# Bu Proje Nasıl Kullanılır

Bu proje ağırlıklı olarak tarihsel veri derlemeye, eğitime hazırlamaya ve bir ayrıştırıcı (tokenizer) oluşturmaya odaklanıyor. Tam LLM eğitim sürecini kapsamayacağım, bunun için Andrej Karpathy’nin nanoGPT’sine başvurun.

# Adım 1: Tarihsel Metinleri Topla ve Hazırla

Seçtiğiniz zaman aralığından (ör. Londra 1800-1850) kamuya açık kitapların, belgelerin vb. .txt dosyalarını toplayın.

İsterseniz kitapları sizin için indirmesi için download_texts_improved.py dosyasını kullanabilirsiniz.

Metin dosyalarını bir script ile veya manuel olarak Project Gutenberg başlık/dipnotlarını, modern açıklamaları ya da OCR hataları gibi şeyleri temizleyin.

prepare_dataset.py gayet iyi çalışacaktır.

# Adım 2: Özel Bir Ayrıştırıcı (Tokenizer) Oluşturun

Temizlenmiş veriler üzerinde train_tokenizer.py veya train_tokenizer_hf.py dosyasını çalıştırın.
Bu size vocab.json ve merges.txt dosyalarını verecektir.

Bu dosyalar modeliniz için kelime hazinesi ve birleştirme kurallarını tanımlar

# Adım 3: Modelinizi Eğitin (nanoGPT)

Eğitim süreci için [Andrej Karpathy'nin nanoGPT'sine](https://github.com/karpathy/nanoGPT) bakabilirsiniz.

İsterseniz farklı bir LLM de eğitebilirsiniz ama ben nanoGPT kullandım

# SSS

## Seçici Zamansal Eğitim (Selective Temporal Training) nedir?

Seçici Zamansal Eğitim (STT), tüm eğitim verilerinin belirli bir tarihsel döneme özel olarak seçildiği bir makine öğrenimi metodolojisidir. Bu, dönemin dilini ve bilgisini modern kavramların etkisi olmadan modellemek için yapılır. Örneğin, şu an elimdeki mevcut model (v0.5) yalnızca 1800-1875 arasındaki verilerle sıfırdan eğitildi, ince ayar yapılmadı ve çıktılar dönemin dilini ve tarihsel bağlamını yansıtıyor.

## Neden sadece ince ayar ya da LoRA kullanmıyorsunuz?

Bu projede modern önyargıdan arındırılmış bir dil modeli oluşturmak istiyorum. GPT-2 gibi bir şeyi ince ayar yaparsam, zaten önceden eğitilmiş olur ve bu bilgi kaybolmaz. Sıfırdan eğitirsem, dil modeli eski gibi davranmaz, gerçekten eski olur. Şu anki hedefim, yalnızca 1800-1850 yılları arasında Londra’da yayımlanan kitaplardan gelen bilgilerle mantık yürütebilen bir şey üretmek.

## Eğitmek için ne tür veriler kullandınız?

1800–1850 Londra’sından kitaplar, yasal belgeler, gazeteler ve diğer yazıları kullanıyorum. Bağlantısını verdiğim listede yaklaşık 200 dosya var ama ilk eğitim için sadece 50 dosya (~187 MB) kullandım. Belgelerin listesine buradan bakabilirsiniz:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Modeller ne kadar büyük?

V0: 16M Parametre

V0.5 123M Parametre

V1: 700M Parametre

# Eğitim Özellikleri ?

#V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.

#V1
GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---