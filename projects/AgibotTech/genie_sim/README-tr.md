![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim Benchmark
Genie Sim, AgiBot'un simülasyon çerçevesidir ve geliştiricilere gömülü zekâ geliştirmeyi hızlandırmak için verimli veri üretim yetenekleri ve değerlendirme kıyaslamaları sunar. Genie Sim, trajektori oluşturma, model eğitimi, kıyaslama ve dağıtım doğrulamasını kapsayan kapsamlı bir kapalı döngü hattı kurmuştur. Kullanıcılar, bu verimli simülasyon araç zinciriyle algoritma performansını hızla doğrulayabilir ve modelleri optimize edebilirler. İster basit kavrama görevleri ister karmaşık uzun menzilli operasyonlar olsun, Genie Sim son derece gerçekçi bir simülasyon ortamı ve hassas değerlendirme metrikleri sunabilir, böylece geliştiricilere robotik teknolojilerin geliştirme ve yinelemesini verimli bir şekilde tamamlama gücü verir.

Genie Sim Benchmark, Genie Sim'in açık kaynaklı değerlendirme sürümü olarak, gömülü AI modelleri için hassas performans testi ve optimizasyon desteği sağlamaya odaklanmıştır.

# 2. Özellikler
- Esnek ve kullanıcı dostu simülasyon yapılandırması ve arayüzü
- 10+ manipülasyon görevi için simülasyon kıyaslamaları ve değerlendirme görevleri
- VR ve klavye tabanlı teleoperasyon yeteneği
- Tüm eklemler ve uç efektör pozunun kaydedilmesi ve tekrar oynatılması
- 550+ yüksek doğrulukta ve fiziksel olarak hassas 3D simülasyon ortamı ve varlıklar
- Gömülü AI modellerinin performansını nicelendirmek için standartlaştırılmış değerlendirme metrikleri
- Değerlendirme sonuçları, GO-1 modelinde %5'ten az simülasyondan gerçeğe değerlendirme hatası sağlar
- Simülasyon değerlendirmesinde UniVLA temel model desteği

# 3. Güncellemeler
- [25/6/2025] v2.1
  - Agibot World Challenge 2025 için 10 ek manipülasyon görevi ve tüm simülasyon varlıkları eklendi
  - Huggingface üzerinde 10 manipülasyon görevi için sentetik veri setleri açık kaynak yapıldı
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - UniVLA politikası entegre edildi ve model çıkarım simülasyon değerlendirmesi desteği sağlandı
  - Diğer robotlar için çapraz gövde IK çözümlemesini destekleyen IK çözümleyici sdk'sı güncellendi
  - İletişim çerçevesi optimize edildi ve simülasyon çalışma hızı 2 kat artırıldı
  - Daha karmaşık uzun menzilli görevler için otomatik değerlendirme çerçevesi güncellendi

# 4. İçerikler

## 4.1 Giriş
Genie Sim'deki gömülü zekâ simülasyon kıyaslamaları, gömülü AI modellerinin geliştirilmesini değerlendirmek ve ilerletmek için tasarlanmıştır. Bu kıyaslamalar, robotik AI sistemlerinin performansını ölçmek için gerçekçi ortamlar, çeşitli görevler ve standartlaştırılmış metrikler sağlar; pahalı fiziksel donanım ve gerçek dünya testi gereksinimini azaltır, riskli ve tehlikeli test senaryolarından kaçınır ve AI ajanlarının eğitim ve değerlendirme süreçlerini hızlandırır.

## 4.2 Başlarken
Kurulum, kullanıcı kılavuzu ve API referansı için lütfen [bu sayfaya](https://agibot-world.com/sim-evaluation/docs/#/v2) bakınız

## 4.3 Destek
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 YAPILACAKLAR Listesi
- [x] Daha uzun vadeli benchmark manipülasyon görevleri yayınla
- [x] Her benchmark görevi için daha fazla sahne ve varlık
- [x] Agibot World Challenge temel modeli desteği
- [ ] Senaryo yerleşimi ve manipülasyon trajektori genelleme araç seti

## 4.5 SSS
- Hatalar oluştuğunda, isaac sim sunucusunu kapatmak ve işlem yanıt vermediğinde ne yapılmalı?
  Terminalde `pkill -9 -f raise_standalone_sim` komutuyla işlemi sonlandırın
- Farklı render modları nasıl seçilir?
  Varsayılan render modu `RaytracedLighting(RealTime)`'dır. Şeffaf nesneler içeren görevlerde, nesnelerin perspektif ilişkisi için `RealTimePathTracing(RealTime-2.0)` kullanın

## 4.6 Lisans ve Atıf
Bu depo içindeki tüm veri ve kodlar Mozilla Public License 2.0 altındadır.
Araştırmanıza yardımcı olursa, aşağıdaki şekilde çalışmamıza atıfta bulunmayı düşünün.
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 Kaynaklar
1. PDDL Parser (2020). Sürüm 1.1. [Kaynak kodu]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Sürüm 1.x.x [Kaynak kodu]. https://github.com/StanfordVL/bddl
3. CUROBO [Kaynak kodu]. https://github.com/NVlabs/curobo
4. Isaac Lab [Kaynak kodu]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [Kaynak kodu]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---