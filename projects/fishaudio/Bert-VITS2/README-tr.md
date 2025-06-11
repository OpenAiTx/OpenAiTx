<div align="center">

<img alt="LOGO" src="https://avatars.githubusercontent.com/u/122017386" width="256" height="256" />

# Bert-VITS2

Çok dilli bert ile VITS2 Omurgası

Hızlı rehber için lütfen `webui_preprocess.py` dosyasına bakınız.

简易教程请参见 `webui_preprocess.py`。

## 【Proje Tanıtımı】
# FishAudio altındaki yepyeni oto-regresif TTS [Fish-Speech](https://github.com/fishaudio/fish-speech) artık kullanılabilir, şu anda açık kaynak SOTA seviyesinde performans sunmakta ve sürekli bakım altındadır, BV2/GSV yerine bu projeyi kullanmanızı öneririz. Bu proje kısa vadede bakım yapılmayacaktır.
## Demo Video: https://www.bilibili.com/video/BV18E421371Q
## Teknik Slaytlar Videosu: https://www.bilibili.com/video/BV1zJ4m1K7cj
## Lütfen dikkat edin, bu projenin temel fikri çok iyi bir TTS projesi olan [anyvoiceai/MassTTS](https://github.com/anyvoiceai/MassTTS) 'den gelmektedir
## MassTTS demosu: [ai版峰哥锐评峰哥本人,并找回了在金三角失落的腰子](https://www.bilibili.com/video/BV1w24y1c7z9)

[//]: # (## Bu proje ile [PlayVoice/vits_chinese](https://github.com/PlayVoice/vits_chinese) arasında hiçbir ilişki yoktur)

[//]: # ()
[//]: # (Bu depo, daha önce bir arkadaşın paylaştığı ai峰哥 videosundan kaynaklanmaktadır, efektlerinden çok etkilendim, MassTTS'i denedikten sonra fs'nin ses kalitesi açısından vits'e göre belirli bir fark olduğunu ve eğitim pipeline'ının vits'ten daha karmaşık olduğunu fark ettim, bu nedenle bert'i kendi yaklaşımlarıma göre uyarladım)

## Deneyimli gezginler/kâşifler/kaptanlar/doktorlar/senseiler/avcılar/miyavlayanlar/V kullanıcıları kodu inceleyip kendi eğitimlerini yapmalıdır.

### Bu projenin Çin Halk Cumhuriyeti Anayasası, Çin Halk Cumhuriyeti Ceza Kanunu, Çin Halk Cumhuriyeti Kamu Düzeni Yönetimi Ceza Kanunu ve Çin Halk Cumhuriyeti Medeni Kanunu’na aykırı tüm amaçlarla kullanılması kesinlikle yasaktır.
### Her türlü siyasi amaçla kullanılması kesinlikle yasaktır.
#### Video: https://www.bilibili.com/video/BV1hp4y1K78E
#### Demo: https://www.bilibili.com/video/BV1TF411k78w
## Referanslar
+ [anyvoiceai/MassTTS](https://github.com/anyvoiceai/MassTTS)
+ [jaywalnut310/vits](https://github.com/jaywalnut310/vits)
+ [p0p4k/vits2_pytorch](https://github.com/p0p4k/vits2_pytorch)
+ [svc-develop-team/so-vits-svc](https://github.com/svc-develop-team/so-vits-svc)
+ [PaddlePaddle/PaddleSpeech](https://github.com/PaddlePaddle/PaddleSpeech)
+ [emotional-vits](https://github.com/innnky/emotional-vits)
+ [fish-speech](https://github.com/fishaudio/fish-speech)
+ [Bert-VITS2-UI](https://github.com/jiangyuxiaoxiao/Bert-VITS2-UI)
## Tüm katkıda bulunanların emeklerine teşekkürler
<a href="https://github.com/fishaudio/Bert-VITS2/graphs/contributors" target="_blank">
  <img src="https://contrib.rocks/image?repo=fishaudio/Bert-VITS2"/>
</a>

[//]: # (# Bu projedeki tüm kod referansları belirtilmiştir, bert bölümü kod fikirleri [AI峰哥]&#40;https://www.bilibili.com/video/BV1w24y1c7z9&#41; kaynağından alınmıştır ve [vits_chinese]&#40;https://github.com/PlayVoice/vits_chinese&#41; ile hiçbir ilgisi yoktur. Herkesi kodu incelemeye davet ediyoruz. Ayrıca bu geliştiricinin [telif ihlali ve kutu açma geliştirici davranışlarını]&#40;https://www.bilibili.com/read/cv27101514/&#41; şiddetle kınıyoruz.)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---