<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Yakında">فارسی (yakında)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Yakında">Bahasa Indonesia (yakında)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*Sadece belirli yerlerin ve zaman dönemlerinin verileriyle **sıfırdan** eğitilmiş bir dil modeli; modern önyargıyı azaltmak ve dönemin sesi, kelime dağarcığı ve dünya görüşünü taklit etmek için tasarlanmıştır.*

Hayal edin ki bir yapay zekâ modeli tarihi taklit etmiyor, gerçekten tarihi olmuş gibi davranıyor.

v0 ve v0.5 [Andrej Karpathy'nin nanoGPT'si](https://github.com/karpathy/nanoGPT) üzerinde inşa edilmiştir. Temel eğitim komut dosyaları ve model mimarisi ona aittir.

v1 [Microsoft tarafından geliştirilen Phi 1.5](https://huggingface.co/microsoft/phi-1_5) üzerine inşa edilmiştir

[Hugging Face Linki](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)


##  Model Davranışı & Sınırlamaları

### **v0**  

İlk istemlerde model, 1800'lerin dili ve davranışıyla yanıt vermektedir. 
Örnek: İstem: "Who art Henry?" ve yanıtı "I know that man, I have did not a black, the storm." 

![TimeLockLLM Örnek Çıktısı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Modern kavramlara hiç değinilmemiş  
- Çoğunlukla döneme uygun kelime dağarcığı  
- Cümleler çoğunlukla tutarsız (yaklaşık 187MB eğitim verisi için beklenen bir durum)

### **v0.5** 

v0'a göre önemli bir gelişme.  
- Viktoryen yazı stili, doğru noktalama, çoğunlukla dilbilgisel olarak doğru cümleler  
- Hâlâ yüksek oranda gerçek dışı üretim  
- Çıktılarda hâlâ OCR gürültüsü (“Digitized by Google”) mevcut

![TimeLockLLM Örnek Çıktısı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Veri kümesinden gerçek bir tarihi olayı ve bir figürü ilk kez hatırlayan ve bağdaştıran model.

Örnek: İstem: "It was the year of our Lord 1834" 

Çıktı: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Başta protestonun tesadüfen aynı yılda gerçekleşmiş olabileceğini varsaydım ancak buna bir bakın: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

v2'nin 90GB'lık veri kümesinden 15GB'lık bir örnekle eğitildi.
Model yalnızca 10K adımda eğitildi.

Tokenizasyonla ilgili bir sorun çıktı ve bu da çıktının şöyle görünmesine neden oldu:

PROMPT:
Charles Dickens kimdir?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Düzeltilmiş:

"Charles Dickens kimdir? Onun mükemmel heyecan verici eserlerinden, oyunlarında, Büyük Şirket’in çiftliğinde daha fazlası var mı? Jack Pickett’ten alıntı yapmam gereken daha bir şey var mı? Onların bir tür dörtnala gitme, ya da göğüslerini kesme, ya da Jackson pencereye bakarken ne yapılması gerektiğini bilmiyor musun? Bir İngiliz’in başarısı nedir ve oğlu bana henüz keşfetmediği, böyle bir yükü başarmak için ne yaptığı nedir? Hiç eski yola geçiş yaptın mı, ya da teknemizin ayağında bir demir meltemine, ki bizi bırakmak zorundasın? Gerçek şu ki, rüzgar Cumartesi gecesi ya da öğle vakti, ya da kuzeye kadar, ya da başka türlü düzlükten kalksa da, mevcutla aynı etkilere sahip, korkunç bir engeli tanımlamak zorunda kalacağız. Bu durumda, en azından, o odadan ayrıldığımızı söylemek abartı olmaz. İnanıyorum ki, ‘Beş Yüz Kat’ta üç kopya var, başvurulacak, okuyucularımızın ilk sayısı olarak...”

### **v2mini-eval2**

Eval1 için kullanılan aynı 15GB örnekle eğitildi.
Model yine sadece 10K adımda eğitildi.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Efendim, — Aşağıdaki vaka benim için ilginçtir: — Londra’da iki hafta kaldım ve romatizma atağıyla çok etkilendim. İlk romatizma atağı sizi görmeden bir hafta önceydi, ikincisi sizi gördüğümde, üçüncüsü de sizi gördüğümde ve yine aynı sürede. Ancak ikinci gut atağı herhangi bir ateşli belirtiyle birlikte olmadı, ama idrarda artış ve daha bol idrar atımı ile birlikteydi. Üçüncü atak sizi gördükten bir saat sonra oldu ve bir gut nöbetinin geri dönüşü ve daha hızlı bir gut tekrarı ile sonuçlandı. Dördüncü atak da bir ateşle birlikteydi, ama her zaman ateşli belirtilerle birlikte değildi. Üçüncü gut atağı hastalandıktan iki hafta sonra oldu ve dördüncüsü de bir gut nöbetiyle takip edildi. Dördüncü atak, saldırıya uğradıktan iki hafta sonra oldu ve bir hisle birlikteydi.


##  Veri Kümeleri

### **v2**

- 90GB’lık 1800-1875 Londra metinleri
- 136.344 belge
- Tam 90GB henüz kullanılabilir değil çünkü henüz tokenize edilmedi, ama 15GB’lık bir örneğe buradan ulaşabilirsiniz: https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### Önyargı İstatistikleri 
  ![Zamir önyargısı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Coğrafi önyargı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Zamansal önyargı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Daha fazla bilgi için [v2 önyargı raporuna](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) bakınız.


## Nasıl Kullanılır

Bu proje çoğunlukla tarihsel verilerin derlenmesi, eğitime hazırlanması ve bir tokenizer oluşturma üzerine odaklanmaktadır. Tam LLM eğitim süreci burada ele alınmamıştır; bunun için Andrej Karpathy’nin nanoGPT’sine bakınız.

### Adım 1: Tarihsel Metinleri Topla ve Hazırla 

- Seçtiğiniz dönemden (ör. Londra 1800-1850) kamu malı kitapların, belgelerin vs. .txt dosyalarını toplayın

- Onları seçtiğiniz zaman/mekan penceresi içinde tutun  
- Metin dosyalarını bir betik kullanarak veya elle Project Gutenberg başlıkları/dipnotları, modern açıklamalar veya OCR hataları gibi şeyleri kaldırarak temizleyin.

### Adım 2: Özel Bir Tokenizer Oluşturun

- train_tokenizer.py veya train_tokenizer_hf.py dosyasını temizlenmiş veri üzerinde çalıştırın.
- Bu işlem size vocab.json ve merges.txt dosyalarını verecek.
- Bu dosyalar modeliniz için kelime hazinesi ve birleştirme kurallarını tanımlar.

### Adım 3: Modelinizi Eğitin

- Eğitim süreci için [Andrej Karpathy'nin nanoGPT'sine](https://github.com/karpathy/nanoGPT) veya seçtiğiniz mimarinin belgelerine bakın.

# SSS

## Seçici Zamansal Eğitim (STT) nedir?

Seçici Zamansal Eğitim (STT), tüm eğitim verisinin belirli bir tarihsel zaman dilimi içinde özel olarak seçildiği bir makine öğrenimi metodolojisidir. Bu, dönemin dilini ve bilgisini modern kavramlardan etkilenmeden modellemek için yapılır. Örneğin, şu anda sahip olduğum model (v0.5) yalnızca 1800-1875 yılları arasındaki verilerle eğitildi, ince ayar yapılmadı, sıfırdan eğitildi ve çıktıları o dönemin dilsel tarzı ve tarihsel bağlamını yansıtmaktadır.

## Neden doğrudan ince ayar veya LoRA kullanmıyorsunuz?

Bu projede amacım modern önyargıdan arınmış bir dil modeli oluşturmak. GPT-2 gibi bir modeli ince ayar yaparsam, zaten önceden eğitilmiş ve bu bilgi kaybolmaz. Sıfırdan eğitirsem dil modeli eskiyi taklit etmek yerine gerçekten öyle olur. Şu anda bu projenin amacı, yalnızca 1800-1875 yılları arasında Londra'da yayımlanmış kitaplardan alınan bilgilerle mantık yürütebilen bir model oluşturmaktır.

## Eğitim için ne tür veriler kullandınız?

Kitaplar, yasal belgeler, gazeteler ve 1800–1875 Londra'sından diğer yazılı eserleri kullanıyorum. Bağlantısını verdiğim listede (v0 için) yaklaşık 200 belge var, ancak ilk eğitim için sadece 50 dosya (~187 MB) kullandım. Belgelerin bir listesini görüntüleyebilirsiniz:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Veri seti boyutları:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB

## Modeller ne kadar büyük?

v0: 16M Parametre

v0.5 123M Parametre

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented





























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---