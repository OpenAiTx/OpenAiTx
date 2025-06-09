[toc]

## Genel Bakış

Bu depo, *MATLAB ile Optik Kablosuz İletişim Sistemi ve Kanal Modellemesi* ile ilgili kaynak kodları içermektedir.

**Orijinal kodun bir kısmında sorunlar vardı ve değişiklik yapılması gerekiyordu. Pratiklik ve işlevselliği artırmak için gerekli düzenlemeleri yaptım.**



## MATLAB Sürümü

MATLAB R2024a

## Dizin Yapısı

- `util/` - Yardımcı betikler ve fonksiyonlar.

## Bazı Kod Açıklamaları

Aşağıda bu depoda yer alan MATLAB betiklerinin (tamamı olmasa da) bir listesi bulunmaktadır:

| Adı                      | Açıklama                                                                                                                        |
| ------------------------ | ------------------------------------------------------------------------------------------------------------------------------ |
| `CORRECT_plot_Fig3p31.m` | Gama-gama olasılık yoğunluk fonksiyonu (PDF)                                                                                   |
| `CORRECT_plot_Fig3p28.m` | Log-normal dağılımın PDF’si                                                                                                    |
| `CORRECT_program_4p4.m`  | Program 4.4: On-Off Anahtarlama Non-Return-to-Zero (OOK-NRZ) Bit Hata Oranı (BER) simülasyonu için MATLAB kodu                 |
| `CORRECT_program_4p5.m`  | Program 4.5: Eşleşik filtre tabanlı alıcı ile OOK-NRZ BER simülasyonu için MATLAB kodu                                         |
| `CORRECT_plot_Fig4p13.m` | Program 4.10: Diskret Darbe Aralığı Modülasyonu (DPIM) (0 Koruma Slotu) Güç Spektral Yoğunluğu (PSD) hesaplamak için MATLAB kodu |

## Kullanım

Bu betikleri kullanmak için `util/` klasörünün MATLAB yolunuza eklendiğinden emin olun. Bunu yapmak için MATLAB başlangıç betiğinize aşağıdaki satırı ekleyebilir veya doğrudan MATLAB komut penceresinde çalıştırabilirsiniz:

```matlab
addpath('path/to/util');
```

`'path/to/util'` kısmını `util/` dizininin gerçek yolu ile değiştirin.

## Katkı

Bu depoya katkıda bulunmakta özgürsünüz; depoyu çatallayarak ve çekme isteği (pull request) göndererek katkı sağlayabilirsiniz. Her türlü geliştirme, hata düzeltmesi veya ek özellikler memnuniyetle karşılanır.

## Teşekkürler

Bu proje, *MATLAB ile Optik Kablosuz İletişim Sistemi ve Kanal Modellemesi* temel alınarak oluşturulmuştur. Orijinal kodun yazarlarına ve katkıda bulunanlara özel teşekkürler.

---



### &#8627; Stargazers
[![Stargazers repo roster for @AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB](http://reporoster.com/stars/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB)](https://github.com/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB/stargazers)

### &#8627; Forkers
[![Forkers repo roster for @AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB](http://reporoster.com/forks/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB)](https://github.com/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB/network/members)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---