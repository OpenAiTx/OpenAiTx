
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (yakında)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (yakında)</a> |
        | <a href="#" title="Coming soon">ไทย (yakında)</a> |
        | <a href="#" title="Coming soon">Français (yakında)</a>
        | <a href="#" title="Coming soon">Deutsch (yakında)</a>
        | <a href="#" title="Coming soon">Español (yakında)</a>
        | <a href="#" title="Coming soon">Italiano (yakında)</a>
        | <a href="#" title="Coming soon">Русский (yakında)</a>
        | <a href="#" title="Coming soon">Português (yakında)</a>
        | <a href="#" title="Coming soon">Nederlands (yakında)</a>
        | <a href="#" title="Coming soon">Polski (yakında)</a>
        | <a href="#" title="Coming soon">العربية (yakında)</a>
        | <a href="#" title="Coming soon">فارسی (yakında)</a>
        | <a href="#" title="Coming soon">Türkçe (yakında)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (yakında)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (yakında)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Belirli zaman dilimlerinden alınan verilerle eğitilmiş, modern önyargıyı azaltmaya yönelik bir LLM.

Bir AI modelinin tarihselmiş gibi davranmakla kalmayıp gerçekten tarihsel olduğunu hayal edin.

[Andrej Karpathy'nin nanoGPT](https://github.com/karpathy/nanoGPT) tabanlıdır. Ana eğitim scriptleri ve model mimarisi ona aittir.

# Proje Hedefleri

TimeCapsule LLM, yalnızca belirli zaman dilimlerinde yazılmış metinlerle eğitilecek deneysel bir projedir. Amaç, belirli tarihsel dönemlerin dünya görüşünü ve dilini simüle etmektir.

# Neden ince ayar yeterli değil

Eğer önceden eğitilmiş bir modeli sadece ince ayar ile düzenlerseniz, LLM'niz yine de modern kavramları bilecektir. Elbette sıfır modern önyargı elde etmek zor, fakat buna mümkün olduğunca yaklaşmak istiyorum. Hiçbir modern önyargı olmaması, modelin sıfırdan eğitilmesini gerektirir.

# Beklenen sonuçlar

Umarım tamamlandığında, bu model modern kavramları bilmeyecek ve eğitildiği bilgilerin ötesinde akıl yürütemeyecek. Modern kavramları/kelime dağarcığını tanımamalı ve umarım modern bilgi uydurmaz.

# İlerleme Güncellemeleri

## 9 Temmuz 2025

Zaman aralığımı 1800-1850 ve bölge olarak Londra olarak belirledim

Bir metin, kitap, belge listesi topladım

Şu ana kadar 50 tanesini txt dosyası olarak aldım ve yakında NanoGPT eğitimine başlayacağım

İlerleme kaydedildikçe burayı güncelleyeceğim

## 13 Temmuz 2025

nanoGPT'yi 187MB'lık tarihsel metin verisiyle eğittim.

## 15 Temmuz 2025

İkinci eğitim çalışması için metinleri indirmeye başladım. Her şeyi Internet Archive üzerinden alıyorum ve zaman aralığını 1800-1875 olarak genişlettim. Çeşitli metinler elde etmek için Internet Archive'da konu ve arama filtrelerini, yayın yeri, zaman dilimi ve konuları kullanabilirsiniz.

![Arama Filtreleri](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 Temmuz 2025

Internet Archive'dan yaklaşık 500 txt dosyası indirdim ve bunları temizledikten sonra (sadece boşlukları, Gutenberg başlıklarını silmek gibi) yaklaşık 500MB veri elde ettim. Küçük bir veri kümesi ama geçen sefer 187MB ile eğitmiştim, bu yüzden ikinci modeli eğittikten sonra çıktıda en azından fark edilir bir değişiklik olmalı. Umarım bu model en azından anlamlı cümleler üretebilir. Tabii ki bu bir garanti değil çünkü bu hala çok küçük bir veri kümesi, ama geçen seferkinden daha fazla. 

Bu kendi donanımımda yapılabilir, bu da iyi çünkü daha büyük bir veri kümesine geçmeden önce bazı iyileşmeleri görebilirim. Ama endişelenmeyin, yakında GPU kiralamayı da planlıyorum, fakat önce veri kümemin olabildiğince seçilmiş ve temiz olduğundan emin olmak istiyorum. Karşılaştığım sorunlardan biri temizlik, bu txt dosyalarının çoğunda anlamsız karışık metinler var. Temizlik için kullandığım scriptler işe yarıyor ama %100 etkili değiller.

Bu veri kümesini bugün eğiteceğim ve yaklaşık 4-5 saat sürecek. Bittiğinde ve test ettiğimde güncellemeler vereceğim. Projeme bakan herkese tekrar teşekkür ederim, bana OCR kaynakları için bağlantı gönderenler bile oldu, çok teşekkürler! Umarım daha fazla kişi kendi veri kümeleriyle bunu dener ve deneme yapar.


### Eğitim Güncellemesi

435MB (108 M token) bir korpus ile eğitime başladım, şu an gayet sorunsuz gidiyor. Eğitim kaybı ilk 2800 iterasyonda 10.9'dan 4.9'a düştü. Tamamlanmasının 8-9 saat süreceğini tahmin ediyorum. Bittiğinde bir güncelleme daha paylaşacağım.

## 17 Temmuz 2025

İkinci modelin eğitimi tamamlandı, 4060'ımda 33.000 iterasyon (5 epoch) için yaklaşık 8 saat 40 dakika (saatte 3.900 iterasyon) sürdü. Son eğitim kaybı 3.73 oldu. Çıktılar şaşırtıcı derecede iyiydi, gerçekten 19. yüzyıl tarzında anlamlı cümleler üretebiliyor artık.

## 28 Temmuz 2025

v0.5'i Hugging Face'e yükledim, [Buradan bakabilirsiniz](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) isterseniz. Artık depomu indirip yerelde çalıştırabilirsiniz. Maalesef nanoGPT HuggingFace ile yerel olarak çalışmıyor, bu yüzden modeli indirip yerelde çalıştırmanız gerekecek.

Ayrıca bir sonraki eğitim için veri seçmeye başlayacağım, akıl yürütme yetenekleri için muhtemelen 5-10 kat daha fazla veriye ihtiyacım olacağını düşünüyorum.

## 2 Ağustos 2025

Yakında Sürüm 1 üzerinde çalışmaya başlayacağım. nanoGPT'nin mimarisinden daha modern bir şeye geçmem gerekecek. Aklımda birkaç açık kaynaklı LLM mimarisi var: OpenLLaMA v3, Phi-2 ve Qwen 1.5B dahil. V1'e geçişi desteklemek için çok daha büyük ve çeşitli bir veri kümesini özenle seçmem gerekecek. En az 5GB temiz eğitim verisine ihtiyacım olacak.

# V0 Model Davranışı & Sınırlamaları

İlk istemlerde modelin 1800'lü yılların dili ve davranışıyla yanıt verdiği görülüyor. Örneğin, "Who art Henry?" diye sordum ve model "I know that man, I have did not a black, the storm." şeklinde yanıtladı, evet bu cümlenin bir anlamı yok ama LLM bir kişiden bahsettiğimi anlıyor.

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Modern kavramlardan hiç bahsedilmiyor, çıktılar çoğunlukla 1800'lü yıllara ait kelime ve ifadelerden oluşuyor.

Hala çok fazla çalışma gerekiyor, 187MB ile eğitmek size karmaşık muhakeme yeteneğine sahip bir model sunmaz.

Şu anda ürettiği cümleler tam cümle yapısından yoksun ve genel olarak anlam ifade etmiyor ama bu eğitim boyutu için normal.

# V0.5 Model Davranışı & Sınırlamaları

Bu, önceki modele göre güzel bir gelişme. Yazı stili ve kelime dağarcığı Viktorya dönemi İngilizcesi, neredeyse her cümle dilbilgisi açısından doğru ve uygun noktalama içeriyor. Ve yine, bu model sıfırdan eğitildiği için 1800'lü yılların konularına sadık kalıyor.

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Çok fazla olgusal halüsinasyon var. Detayların (tarih, olaylar, tarihi şahıslar) neredeyse tamamı (yaklaşık %100) uydurma. Ayrıca cümleler birbirleriyle pek bağlantılı değil, bazen belki 2 cümle birbiriyle ilişkili oluyor ama bundan fazlası yok. Diğer bir sorun ise bazen "Digitized by Google" altbilgisi araya giriyor, bu yüzden bir dahaki eğitime başlamadan önce metinlerin iyice temizlendiğinden emin olmalıyım. Genel olarak sonuçlardan çok memnunum, henüz tam bir LLM değil ama kesinlikle bir cümle üreticisi.

Çok şey öğreniyorum ve önümüzdeki haftalarda daha iyi neler yapmam gerektiğini çözmeye başlayacağım. Dosyaları yakında yükleyeceğim!

# Yaklaşan Planlar

(Tamamlandı) 0.5 sürümüne başlıyorum, 50 kitap yerine ideal olarak 500-600 kitapla eğitim yapacağım. Şu anda nanoGPT'yi 1800-1850 yılları arasındaki Londra kitaplarıyla eğitiyorum. Bazı zorluklar var; bulduğum kitapların güncellenmemiş veya modern yorumlar içermediğinden emin olmalıyım, seçtiğim dönemde yayımlanmış, dokunulmamış kitaplar olmalı.

Daha büyük bir veri kümesiyle (v1) yeni bir model eğitmek istiyorum, belki v0.5 için kullandığımın 5-10 katı büyüklüğünde. Amacım, yalnızca Seçici Zamansal Eğitim ile muhakeme yeteneklerinin ortaya çıkıp çıkmayacağını görmek; bu daha zor bir görev olacak ve tarihi veri kısıtlamaları nedeniyle mümkün olup olmadığından tamamen emin değilim. Önümüzdeki haftalarda 5-10 GB'lık bir veri kümesi oluşturacak kadar veri toplamaya çalışacağım. Temiz, yüksek kaliteli veri toplayabilir ve bir GPU kiralayabilirsem ilerleme olacağına inanıyorum.

# Bu Proje Nasıl Kullanılır

Bu proje daha çok tarihsel verilerin toplanması, eğitim için hazırlanması ve bir tokenizer oluşturulması üzerine odaklanıyor. Tüm LLM eğitim sürecini anlatmayacağım, bunun için Andrej Karpathy'nin nanoGPT'sine bakabilirsiniz.

# Adım 1: Tarihsel Metinleri Topla ve Hazırla

Seçtiğiniz döneme ait (örn. Londra 1800-1850) kamu malı kitap, belge vb. .txt dosyalarını toplayın.

İhtiyacınız olursa kitapları sizin için indirmek için download_texts_improved.py dosyasını kullanabilirsiniz.

Metin dosyalarını bir betik ile ya da manuel olarak, Project Gutenberg başlık/dipnotları, modern açıklamalar ya da OCR hataları gibi şeyleri temizleyin.

prepare_dataset.py sorunsuz çalışmalı.

# Adım 2: Özel Tokenizer Oluştur

train_tokenizer.py veya train_tokenizer_hf.py’yi temizlenmiş veri üzerinde çalıştırın.
Bu size vocab.json ve merges.txt dosyalarını verecek

Bu dosyalar modeliniz için kelime dağarcığı ve birleştirme kurallarını tanımlar

# Adım 3: Modelinizi Eğitin (nanoGPT)

Eğitim süreci için [Andrej Karpathy'nin nanoGPT'sine](https://github.com/karpathy/nanoGPT) bakın.

İsterseniz farklı bir LLM de eğitebilirsiniz ama ben nanoGPT kullandım

# SSS

## Seçici Zamansal Eğitim (STT) nedir?

Seçici Zamansal Eğitim (STT), tüm eğitim verilerinin özel olarak belirli bir tarihsel döneme ait olacak şekilde seçildiği bir makine öğrenimi metodolojisidir. Bu, dönemin dilini ve bilgisini modern kavramlardan etkilenmeden modellemek için yapılır. Örneğin, şu anki modelim (v0.5) sadece 1800-1875 arasındaki verilere dayalı olarak eğitildi; ince ayar yapılmadı, sıfırdan eğitildi ve çıktılar bu dönemin dilsel tarzını ve tarihsel bağlamını yansıtıyor.

## Neden sadece ince ayar veya LoRA kullanmıyorsun?

Bu projede modern önyargıdan arınmış bir dil modeli oluşturmayı hedefliyorum. GPT-2 gibi bir modeli ince ayar yapsam bile, model zaten önceden eğitilmiş olur ve bu bilgi yok olmaz. Sıfırdan eğitirsem, dil modeli eski gibi davranmaz, gerçekten eski olur. Şu anki hedefim, 1800-1850 arasında Londra'da yayımlanmış kitaplardan alınan bilgilerle sadece bu bilgilerle akıl yürütebilen bir şey oluşturmak.

## Eğitim için ne tür veri kullandınız?

Kitaplar, hukuki belgeler, gazeteler ve diğer 1800-1850 Londra yazılı metinlerini kullanıyorum. Bağlantısını verdiğim listede yaklaşık 200 belge var ama ilk eğitim için sadece 50 dosya (~187 MB) kullandım. Belge listesini görebilirsiniz:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Sürüm 0 modeli ne kadar büyük?

Bu model şu an çok küçük, bunu eğlence amaçlı yapıyorum ve kesinlikle modern kaynak kullanmama kuralına bağlıyım. Yaklaşık 16 milyon parametresi var ama daha fazla eski metin toplayıp yeni bir model eğitmeye başlayacağım. Gelişmeleri paylaşacağım.

## Eğitim Özellikleri?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---