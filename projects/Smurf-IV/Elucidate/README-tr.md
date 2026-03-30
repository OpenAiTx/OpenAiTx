
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [Proje Açıklaması](#project-description)
- [Sistem Gereksinimleri:](#os-requirements)
- [SSS](#faqs)
- [Yol Haritası](#roadmap)
- [Ekran Görüntüleri](#screenshots)

## Proje Açıklaması

Elucidate, komut satırı SnapRAID uygulaması için bir Windows GUI ön yüzüdür.

*Bu proje, benim ve diğer katkıda bulunanların yaptığı harika çalışmaların birleşimini devam ettirmektedir.

## Sistem Gereksinimleri

- Windows İşletim Sistemi
- .Net Runtime 4.8.0
- SnapRaid Sürüm 11.5 veya altı
- Hedef sürücüde 10MB Boş Alan

## SSS

**S**: SnapRAID nedir?<br/>
**C**: SnapRAID, Windows ve Linux işletim sistemleri için yazılım tabanlı bir anlık görüntü-parite motorudur. En temel düzeyde, kapsamı altındaki bir dosya sisteminin içeriğini, bileşen dosyalarının hash'lerini hesaplayarak ve sonuçları bir parite dosyasında saklayarak koruma sağlar. Tam bir sabit disk arızası durumunda, bu parite dosyası kaybolan verilerin yeniden oluşturulmasında kullanılabilir. Tüm detaylar için SnapRAID'in [dosya koruma motorlarının resmi karşılaştırmasına](http://snapraid.sourceforge.net/compare.html) bakabilirsiniz.

**S**: Neden bir GUI, Komut Satırı zaten çalışıyor!<br/>
**C**: Daha büyük hedef, işleyen bir SnapRAID ortamını korumada kullanıcıya yardımcı olacak ek yönetim özelliklerine sahip, tam özellikli bir GUI oluşturmaktır. Bazen, ‘tıkla ve çalıştır’ seçenekleri yeni başlayanlar için daha kolay olabilir. SnapRAID’in teknik dokümantasyonu ve derin yapılandırılabilirliği, denemek isteyenler için ürkütücü olabilir!

**S**: Hâlâ emin değilim, daha fazla bilgi var mı?<br/>
**C**: Evet, [dokümantasyona](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) bakabilirsiniz, resimler vb. içerir.

**S**: Peki, "Daha Büyük Hedefler" neler?<br/>
**C**: Tam bir döküm için aşağıdaki __Yol Haritası__'na bakın.

## Yol Haritası

- [x] Aşama I
  - [x] En son SnapRAID’in minimum desteğini sürdürmeye çalışmak. - __Devam ediyor.__
  - [x] Kullanım kolaylığı
  - [x] SnapRAID'in üç komutu var, onları yeni başlayanlar için kolay erişilebilir yapalım
  - [x] İlerleme göstergesi(leri)
  - [x] "Etkileşimli" ve doğrudan günlük kaydı.
  - [x] Kullanıcı girişiyle otomatik başlatma
  - [x] Yol gösterici araç ipuçları •	

- [x] Aşama II Aşama II Özellik istekleri
  - [x] Duraklat, Öncelik değiştir, Durdur.
  - [x] Komut Uzantısı - "Varsayılanlarda kullanılanlara ek parametrelerin izin verilmesi."
  - [x] Zamanlama 
    - Kaldırıldı, Komut Satırını kullanın
  - [x] Korumalı verinin grafiksel görünümü.

- [ ] Faz III (2017-03 ve sonrası için Yeniden Başlat)
  - [x] Yeni Derleyici ve .Net 4.7.x	
  - [x] Komut Satırı arayüzü
  - [ ] Krypton Toolkit / Navigator / vb. ile Yeni Düzen 
    - Devam Ediyor
  - [ ] Çeviriler 
  - [x] Yeni Komutlar
  - [ ] Durum raporları ile Mailer
  - [ ] Belge Test adımları
    - Devam Ediyor
  - [ ] Belgelere Ekle / Görselleri Güncelle
    - Devam Ediyor
  - [ ] Hataların _Windows EventLog_ ile raporlanmasını ekle
  - [x] İstisnaların çevrimiçi raporlanması için _ExceptionLess_ ekle
  - [x] Kurtarılabilecek olanı göster. 

- [ ] Faz IV (yeni SnapRAID Komutları ?) 
  - [ ] Disk kurtarma ile Genişletilmiş Yardım - interaktif rehberler vb.
  - [ ] Kullanıcıya SnapRAID sürümünün eski olduğunu bildir
  - [ ] SnapRAID günlüklerini yorumla (aşağıdaki değişikliklerde kullanılır)
  - [ ] Bir komut çalıştırıldıktan sonra dizinin durumunu sağla
  - [ ] Sync komutunu, ilk diff'i içerecek şekilde değiştir
  - [ ] Sync komutunu, diff belirli bir eşik üzerinde sorun bildirirse uyarı verecek şekilde değiştir
  - [ ] Sync eşik gereksinimleri için kullanıcı yapılandırılabilir ayarlar ekle


## Ekran Görüntüleri

![Başlangıç Görünümü](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Ayarlar Formu](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## Yardımcı Olur musunuz? 
- Test kullanıcıları aranıyor (Tüm .Net platformları)
- Çeviri konusunda yardımcı olabilir
- Yardım / Kullanıcı arayüzü kılavuzları
- Başka herhangi bir fikir :-)
- Fikirler için geliştiriciler


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---