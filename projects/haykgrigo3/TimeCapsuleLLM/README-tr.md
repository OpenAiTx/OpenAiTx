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
Belirli zaman dilimlerinden alınan verilerle eğitilmiş, modern önyargıları azaltmayı amaçlayan bir LLM.

Hayal edin ki bir yapay zeka modeli sadece tarihiymiş gibi davranmıyor, gerçekten öyle.

[Andrej Karpathy'nin nanoGPT'si](https://github.com/karpathy/nanoGPT) üzerine kurulmuştur. Çekirdek eğitim betikleri ve model mimarisi ona aittir.

# Proje Hedefleri

TimeCapsule LLM, yalnızca belirli zaman dilimlerinde yazılmış metinlerle eğitilecek deneysel bir projedir. Hedef, belirli tarihsel dönemlerin dünya görüşünü ve dilini simüle etmektir.

# Neden sadece ince ayar yeterli değil

Sadece önceden eğitilmiş bir modeli ince ayar yaparsanız, LLM’iniz hâlâ modern kavramları bilecek. Elbette sıfır modern önyargı elde etmek zor, ama buna olabildiğince yaklaşmak istiyorum. Hiç modern önyargı olmaması, modeli sıfırdan eğitmeyi gerektirir.

# Beklenen Sonuçlar

Umarım tamamlandığında, bu model modern kavramları bilmeyecek ve eğitildiği bilginin ötesinde akıl yürütemeyecek. Modern kavramları/kelime dağarcığını tanımamalı ve umarım modern bilgi uydurmaz.

# İlerleme Güncellemeleri

## 9 Temmuz 2025

Zaman dilimimi 1800-1850 ve bölgeyi Londra olarak belirledim

Bir dizi metin, kitap, belge topladım

Şu ana kadar 50 tanesini txt dosyası olarak aldım ve yakında NanoGPT eğitmeye başlayacağım

İlerleme kaydettikçe burayı güncelleyeceğim

## 13 Temmuz 2025

nanoGPT'yi 187MB tarihsel metin verisiyle eğittim.

## 15 Temmuz 2025

İkinci eğitim için metin indirmeye başladım. Her şeyi Internet Archive’den alıyorum ve zaman dilimini 1800-1875’e genişlettim. Çeşitli metinler almak için, Internet Archive’de yayın yeri, zaman dilimi ve konu filtrelerini kullanabilirsiniz.

![Arama Filtreleri](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 Temmuz 2025

Internet Archive’den yaklaşık 500 txt dosyası indirdim ve bunları temizledikten sonra (sadece boşlukları, Gutenberg başlıklarını vs. silerek) elimde yaklaşık 500MB veri var. Bu çok küçük bir veri kümesi ama son seferinde 187MB ile eğitmiştim, bu yüzden ikinci modeli eğittikten sonra çıktıdaki farkın en azından bir miktar hissedilmesi gerekir. En azından daha anlamlı cümleler üretebilen bir model elde etmeyi umuyorum. Elbette bu garanti değil çünkü veri kümesi hâlâ çok küçük, ama geçen sefer kullandığımdan daha fazla.

Bunu kendi donanımımda yapmak mümkün, bu da iyi çünkü daha büyük bir veri kümesine geçmeden önce bir miktar gelişme görmeyi umuyorum; bu, GPU kiralamamı gerektirecek. Ama merak etmeyin, yakında bir GPU kiralamayı hâlâ planlıyorum, fakat önce veri kümemin olabildiğince derlenmiş ve temiz olduğundan emin olmak istiyorum. Karşılaştığım sorunlardan biri temizlik; bu txt dosyalarının çoğunda anlamsız şeyler karışmış durumda. Temizlik için kullandığım betikler işe yarıyor ama %100 etkili değiller.

Bugün bu veri kümesiyle eğitim yapacağım ve yaklaşık 4-5 saat sürecek. Bittiğinde ve test ettiğimde güncelleme yapacağım. Projeme bakan herkese tekrar teşekkürler, hatta bana OCR kaynaklarının bağlantılarını bile verenler oldu, sağ olun! Umarım daha fazla insan bunu dener ve kendi veri kümeleriyle deneyler yapar.


### Eğitim Güncellemesi

435MB (108 M token) bir metinle eğitime başladım, şu an oldukça sorunsuz ilerliyor. Eğitim kaybı ilk 2800 iterasyonda 10.9’dan 4.9’a düştü. Tamamlanmasının 8 veya 9 saat süreceğini tahmin ediyorum. Bittiğinde başka bir güncelleme daha paylaşacağım.

## 17 Temmuz 2025 02:13

İkinci modelin eğitimi tamamlandı, 4060’ımda yaklaşık 8 saat 40 dakika sürdü (3.900 iter/saat) ve 33.000 iterasyon (5 epoch) yaptı. Son eğitim kaybı 3.73 oldu. Çıktılar şaşırtıcı şekilde iyiydi; gerçekten 19. yüzyıl tarzı anlamlı cümleler üretiyor artık.

## 28 Temmuz 2025

v0.5’i Hugging Face’e yükledim, [Buradan bakabilirsiniz](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) isterseniz. Artık depomu indirip yerel olarak çalıştırabilirsiniz. Ne yazık ki nanoGPT HuggingFace ile yerel olarak çalışmıyor, bu yüzden modeli indirip yerel olarak çalıştırmanız gerekecek.

Ayrıca bir sonraki eğitim için veri derlemeye başlayacağım, akıl yürütme yeteneği için belki 5-10 kat daha fazla veriye ihtiyacım olacağını düşünüyorum.


# V0 Model Davranışı ve Sınırlamaları

Erken istemlerde model, 1800’lerin dili ve davranışıyla yanıt veriyor. Örneğin, "Who art Henry?" diye sordum ve "I know that man, I have did not a black, the storm." şeklinde cevapladı ve evet bu cümle pek anlamlı değil ama LLM bir kişiden bahsettiğimi anlıyor.


![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Modern kavramlardan hiç bahsedilmiyor, çıktılar çoğunlukla 1800’lerden kelimeler ve ifadeler içeriyor.

Hâlâ çok fazla çalışmaya ihtiyacı var, 187MB ile eğitim yapmak size karmaşık akıl yürütme üreten bir model vermez.

Şu anda tam cümle yapısından yoksun ve genel olarak hiç mantıklı olmayan cümleler üretiyor ama bu eğitim boyutu için normal.

# V0.5 Model Davranışı & Sınırlamaları

Bu, önceki modele göre güzel bir gelişme. Yazım tarzı ve kelime hazinesi Viktorya dönemi ve neredeyse her cümle gramer açısından doğru ve uygun noktalama işaretlerine sahip. Ve yine bu model sıfırdan eğitildiği için 1800’ler konularına bağlı kalıyor.

![TimeLockLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Çok fazla gerçek dışı uydurma var. Detayların (tarihler, olaylar, tarihi kişiler gibi) neredeyse tamamı (yani %100’ü) uydurma. Ayrıca cümleler birbirleriyle pek bağlantılı değil, bazen belki 2 cümle birbiriyle ilişkili oluyor ama bunun ötesine geçmiyor. Bir diğer sorun ise bazen “Digitized by Google” dipnotunun araya karışması; bir dahaki eğitimde metinlerin iyice temizlendiğinden emin olmam gerek. Genel olarak sonuçlardan çok memnunum, henüz bir LLM değil ama kesinlikle bir cümle üreteci.

Çok şey öğreniyorum ve önümüzdeki haftalarda neleri daha iyi yapmam gerektiğini anlamaya başlayacağım. Dosyaları yakında yükleyeceğim!

# Yaklaşan Planlar

(Tamamlandı) 0.5 sürümünde çalışmaya başlayacağım, 50 kitap yerine ideal olarak 500-600 kitapla eğitim yapacağım. Şu anda 1800-1850 yılları arasındaki, özellikle Londra’dan kitaplarla nanoGPT eğitiyorum. Karşılaştığım zorluklardan biri bulduğum kitapların güncellenmemiş veya modern yorumlara sahip olmaması; seçtiğim zaman diliminde yayımlanmış dokunulmamış kitaplar olmalı.

Daha büyük bir veri setiyle (v1) yeni bir model eğitmek istiyorum, belki v0.5’te kullandığımın 5-10 katı büyüklüğünde. Amacım, sadece Seçici Zamansal Eğitim ile akıl yürütme yeteneğinin ortaya çıkıp çıkamayacağını görmek, bu daha zor bir görev olacak ve tarihi veri kısıtlamaları nedeniyle bunun mümkün olup olmadığından bile emin değilim. Önümüzdeki haftalarda 5-10GB’lık bir veri seti oluşturmak için çalışacağım. Temiz, yüksek kaliteli veriler bulabilir ve bir GPU kiralayabilirsem ilerleme olacağına inanıyorum.

# Bu Proje Nasıl Kullanılır

Bu proje, esas olarak tarihi verileri derleme, eğitim için hazırlama ve bir belirteçleyici oluşturma üzerine odaklanıyor. Tam LLM eğitim sürecini kapsamayacağım, bunun için Andrej Karpathy’nin nanoGPT’sine başvurun.

# Adım 1: Tarihi Metinleri Toplayın ve Hazırlayın

Seçtiğiniz zaman dilimine ait kamu malı kitapların, belgelerin vb. .txt dosyalarını toplayın (ör. Londra 1800-1850)

İhtiyacınız varsa download_texts_improved.py dosyasını kullanarak kitapları indirebilirsiniz.

Metin dosyalarını bir betik ile veya elle Project Gutenberg başlık/dipnotlarını, modern açıklamaları veya OCR hataları gibi şeyleri çıkararak temizleyin.

prepare_dataset.py iyi çalışacaktır.

# Adım 2: Özel Bir Belirteçleyici Oluşturun

train_tokenizer.py veya train_tokenizer_hf.py’yi temizlenmiş veriler üzerinde çalıştırın.
Bu size vocab.json ve merges.txt dosyalarını verecek.

Bu dosyalar modeliniz için kelime dağarcığını ve birleştirme kurallarını tanımlar.

# Adım 3: Modelinizi Eğitin (nanoGPT)

Eğitim süreci için [Andrej Karpathy’nin nanoGPT’sine](https://github.com/karpathy/nanoGPT) bakın.

İsterseniz başka bir LLM de eğitebilirsiniz, ancak ben nanoGPT kullandım.

# SSS

## Seçici Zamansal Eğitim (Selective Temporal Training) nedir?

Seçici Zamansal Eğitim (STT), tüm eğitim verilerinin belirli bir tarihi zaman dilimine ait olacak şekilde özel olarak derlendiği bir makine öğrenimi yöntemidir. Amacı, çağdaş kavramların etkisinden uzak, o dönemin dilini ve bilgisini modellemektir. Örneğin, şu anki modelim (v0.5) sadece 1800-1875 verisiyle eğitildi, ince ayar değil tamamen sıfırdan eğitildi ve çıktıları o dönemin dil stilini ve tarihsel bağlamını yansıtıyor.

## Neden sadece ince ayar ya da LoRA kullanmıyorsun?

Bu projede modern önyargıdan uzak bir dil modeli oluşturmayı deniyorum. GPT-2 gibi bir şeyi ince ayar yaparsam, model zaten önceden eğitilmiş olur ve bu bilgi gitmez. Sıfırdan eğitirsem dil modeli eskiyi taklit etmeye çalışmaz, zaten eski olur. Şu an için amacım 1800-1850 arasında Londra’da yayımlanmış kitaplardan elde edilen bilgiyle sadece bu bilgilerle akıl yürütebilen bir şey yapmak.

## Eğitim için ne tür veri kullandınız?

1800–1850 Londra’sından kitaplar, yasal belgeler, gazeteler ve diğer yazılı materyalleri kullanıyorum. Bağlantısını verdiğim listede yaklaşık 200 belge var ama ilk eğitim için sadece 50 dosya (~187 MB) kullandım. Belge listesini görüntüleyebilirsiniz:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Sürüm 0 modeli ne kadar büyük?

Bu model şu anda çok küçük, sadece eğlence amaçlı yapıyorum ve modern kaynak yok kuralına sıkı sıkıya bağlıyım. Neredeyse 16 milyon parametresi var ama daha fazla eski metin toplayıp yeni bir model eğitmeye başlayacağım. Gelişmeleri paylaşacağım.

## Eğitim Teknik Özellikleri?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---