<div align="right">
  <details>
<summary>🌐 Dil</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Yalnızca belirli yerlerden ve zaman dilimlerinden alınan veriler üzerinde **sıfırdan** eğitilmiş bir dil modeli; modern önyargıları azaltmak ve dönemin sesini, kelime dağarcığını ve dünya görüşünü taklit etmek için.*

Bir AI modelinin tarihiymiş gibi davranmakla kalmayıp gerçekten tarihi olmasını hayal edin.

v0 ve v0.5 [Andrej Karpathy'nin nanoGPT'si](https://github.com/karpathy/nanoGPT) üzerine inşa edildi. Temel eğitim scriptleri ve model mimarisi ona aittir.

v1 [Microsoft'un Phi 1.5'i](https://huggingface.co/microsoft/phi-1_5) üzerine inşa edildi.

v2 llamaforcausallm üzerine inşa edildi.

[Hugging Face Bağlantısı](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Araştırma Durumu
Bu proje bağımsız olarak başlatıldı ve geliştirildi.

Şu anda akademik denetim altında yürütülmekte olup, Muhlenberg College'da bağlı bir araştırma işbirliği ile sürdürülmektedir.

## Atıf

Bu veri setini veya modeli akademik çalışmalarda kullanırsanız, lütfen aşağıdaki şekilde atıf yapınız:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

##  Model Davranışı & Sınırlamaları

### **v0**  

Erken istemlerde model, 1800'lerin dili ve davranışıyla yanıt veriyor. 
Örnek: İstem: "Who art Henry?" ve yanıtı "I know that man, I have did not a black, the storm." 

![TimeCapsuleLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Modern kavramlara hiç değinilmiyor  
- Çoğunlukla döneme uygun kelime dağarcığı  
- Cümleler çoğunlukla tutarsız (yaklaşık 187MB eğitim verisi için beklenen)

### **v0.5** 

v0'a göre önemli bir gelişme.  
- Viktorya dönemi yazı stili, düzgün noktalama, çoğunlukla dilbilgisel cümleler  
- Hâlâ yüksek oranda gerçek dışı halüsinasyon  
- OCR gürültüsü ("Digitized by Google") hâlâ çıktılarda mevcut

![TimeCapsuleLLM Örnek Çıktı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Veri setinden gerçek bir tarihi olayı ve gerçek bir figürü hatırlayıp bağdaştırabilen ilk model.

Örnek: İstem: "It was the year of our Lord 1834" 

Çıktı: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Başta bir protestonun o yıl tesadüfen olmuş olabileceğini düşündüm fakat şuna bir bakın: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

v2'nin 90GB veri setinden 15GB'lık bir örnekle eğitildi.
Model sadece 10K adımda eğitildi.

Çıktının aşağıdaki gibi görünmesine sebep olan bir tokenizasyon sorunu vardı:

Charles Dickens kimdir?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Düzeltilmiş:

"Charles Dickens kimdir? O, oyunlarında, Büyük Şirket'in çiftliğinde, harika ve heyecan verici eserlerinden daha fazlasını mı yaptı? Jack Pickett'ten henüz alıntı yapmam gereken bir şey var mı? Onların bir tür dört nala koşan, ya da göğüslerini testereyle kesen kişiler olduklarını, ya da Jackson pencereye bakarken ne yapılması gerektiğini bilmiyor musun? Bir İngilizin başarısı nedir ve oğlunun bana henüz keşfetmediği, böyle bir yükü başarmak için yol nedir? Hiç eski yol üzerinden geçiş yaptın mı ya da tekneye demir atarken esen bir rüzgara kapıldın mı ve bizi terk etmek zorunda kaldın mı? Gerçek şu ki, cumartesi gecesi ya da öğle vakti, ya da kuzeye kadar, ya da başka bir şekilde, rüzgarın ovadan yükselip yükselmeyeceğine bakılmaksızın, mevcut durumla aynı etkilere sahip korkutucu bir engeli tarif etmek zorunda kalacağız. Bu durumda, en azından, o odayı terk ettiğimizi söylemek çok fazla değildir. Sanırım 'Beş Yüz Katı'nda üç kopya var, başvurulacak, okuyucularımızdan ilk isteyenler için...”

### **v2mini-eval2**

Eval1 için kullanılan 15GB örnekle aynı veriyle eğitildi.
Model yine sadece 10K adımda eğitildi.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Efendim, — Aşağıdaki vaka benim için ilginçtir: — Londra'da on beş gün kaldım ve romatizma atağıyla oldukça etkilendim. Romatizmanın ilk atağı sizi görmeden bir hafta önceydi, ikincisi sizi gördüğümdeydi, üçüncüsü ise sizi gördüğüm aynı zamanda oldu. Ancak ikinci gut atağı, herhangi bir ateşli belirtiyle birlikte değildi, fakat idrar akışında artış ve daha bol idrar atılımı ile birlikteydi. Üçüncü atak sizi gördükten bir saat sonra oldu ve bir gut nöbetinin geri dönmesiyle ve gutun daha hızlı geri dönüşüyle devam etti. Dördüncü atak da ateşle birlikteydi, fakat her zaman ateşli belirtiler eşlik etmiyordu. Gutun üçüncü atağı, siz hasta olduktan iki hafta sonra oldu ve dördüncüsü de bir gut nöbetiyle takip edildi. Dördüncü atak, saldırıdan iki hafta sonra oldu ve bir hisle birlikteydi.

### **v2**

90GB (112GB tokenize) veri kümesiyle eğitildi
182K adıma kadar eğitildi 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  Veri Kümeleri

### **v2**

- 1800-1875 Londra metinlerinden 90GB (ham)
- 136.344 belge
- Tam tokenleştirilmiş veri kümesine buradan ulaşabilirsiniz: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### Önyargı İstatistikleri 
  ![Zamir önyargısı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Coğrafi önyargı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Zamansal önyargı](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Daha fazla bilgi için [v2 bias report](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) raporuna bakınız.


## Nasıl Kullanılır

Bu proje ağırlıklı olarak tarihsel verilerin derlenmesi, eğitim için hazırlanması ve bir tokenizer oluşturulmasına odaklanmaktadır. Tam LLM eğitim sürecini burada ele almayacağım, bunun için Andrej Karpathy'nin nanoGPT projesine bakabilirsiniz.

### Adım 1: Tarihsel Metinleri Toplayın ve Hazırlayın

- Seçtiğiniz zaman diliminden (örneğin, Londra 1800-1850) kamuya açık kitapların, belgelerin vb. .txt dosyalarını toplayın
- Bunları seçtiğiniz zaman/mekan aralığında tutun
- Metin dosyalarını bir script ile veya manuel olarak Project Gutenberg başlık/altlıklarını, modern açıklamaları veya OCR hataları gibi unsurları temizleyin.

### Adım 2: Özel Tokenizer Oluşturun

- Temizlenmiş veriler üzerinde train_tokenizer.py veya train_tokenizer_hf.py çalıştırın.
- Bu işlem size vocab.json ve merges.txt dosyalarını verecek
- Bu dosyalar modeliniz için kelime haznesi ve birleştirme kurallarını tanımlar

### Adım 3: Modelinizi Eğitin

- Eğitim süreci için [nanoGPT by Andrej Karpathy](https://github.com/karpathy/nanoGPT) veya seçtiğiniz mimarinin belgelerine bakın.

# SSS

## Selective Temporal Training nedir?

Selective Temporal Training (STT), tüm eğitim verilerinin belirli bir tarihsel zaman diliminde yer alacak şekilde özel olarak derlendiği bir makine öğrenmesi metodolojisidir. Bu, çağın dilini ve bilgisini modern kavramların etkisinden uzak şekilde modellemek için yapılır. Örneğin, şu an sahip olduğum model (v0.5) yalnızca 1800-1875 yıllarına ait verilerle eğitildi, ince ayar yapılmadı, sıfırdan eğitildi ve çıktıları o dönemin dil stilini ve tarihsel bağlamını yansıtmaktadır.

## Neden sadece fine-tuning veya LoRA kullanılmıyor?

Bu projede modern önyargılardan arınmış bir dil modeli oluşturmayı amaçlıyorum. Eğer GPT-2 gibi bir modeli ince ayar ile eğitirsem, zaten önceden eğitilmiş oluyor ve bu bilgi ortadan kalkmaz. Sıfırdan eğitirsem dil modeli eskiymiş gibi davranmaz, zaten öyle olur. Bu projenin amacı, 1800-1875 yılları arasında Londra’da yayımlanan kitaplardan elde edilen bilgiyle münhasıran muhakeme yapabilen bir model oluşturmaktır.

## Eğitim için ne tür veri kullandınız?

1800–1875 Londra'dan kitaplar, hukuk belgeleri, gazeteler ve diğer yazılar kullanıyorum. Bağlantısını verdiğim listede (v0 için) yaklaşık 200 dosya var ama ilk eğitimde sadece 50 dosya (~187 MB) kullandım. Belgelerin listesini görebilirsiniz:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Veri seti boyutları:
- v0: ~187MB
- v0.5: ~435MB
- v1: ~6.25GB
- v2mini-eval1: 15GB (v2'nin 90GB'ından örnek)
- v2: 90GB

## Modeller ne kadar büyük?

v0: 16M Parametre

v0.5: 123M Parametre

v1: 700M Parametre

v2mini-eval1: 300M Parametre

v2mini-eval2: 200M Parametre

v2: 1.2B Parametre

## Eğitim Özellikleri?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.

### v1
GPU: A100 SXM kiralık

### v2mini-eval1/eval2
GPU: A100 SXM kiralık

### v2
GPU: H100 SXM kiralık

## Teşekkürler

[v. Dr. Hamed Yaghoobian](https://hamedyaghoobian.com)'a akademik danışmanlık, araştırmanın çerçevelenmesi ve değerlendirilmesi konusunda rehberlik, v2 sürümü için tokenizer eğitimi ve veri seti hazırlığında yardım ettiği için teşekkür etmek isterim. Geri bildirimi ve deneyimi, bu çalışmanın sunumunu geliştirmede önemli rol oynamıştır.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---