# mimotion
![ Adım Sayısı Güncelleme](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Xiaomi Mi Fit Otomatik Adım Sayısı Güncelleme

> Xiaomi Mi Fit için otomatik adım sayısı güncelleme

## Github Actions Kurulum Rehberi

### 1. Bu Depoyu Fork'layın

### 2. Hesap ve Şifreyi Ayarlayın
# 20230224 Yeni Eklendi
**CONFIG** adında bir değişken ekleyin: Settings-->Secrets-->New secret , aşağıdaki json şablonunu kullanarak çoklu hesap yapılandırabilirsiniz, e-posta ve telefon numarası desteklenir
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN, yoksa boş bırakın",
  "TG_USER_ID": "telegram TG_USER_ID, yoksa boş bırakın",
  "SKEY": "Kutupush skey, yoksa boş bırakın",
  "SCKEY": "server酱 sckey, yoksa boş bırakın",
  "POSITION": "WeChat Work bildirimi açılsın mı, yoksa boş bırakın",
  "CORPID": "Kurumsal ID, WeChat Work'e giriş yapıp Kurumsal Bilgi bölümünde bulabilirsiniz, yoksa boş bırakın",
  "CORPSECRET": "WeChat Work kendi uygulamanızda her uygulamanın ayrı bir secret'ı vardır, yoksa boş bırakın",
  "AGENTID": "WeChat Work kendi uygulamanızın ID'si, tırnaksız, bir tamsayıdır, AgentId, yoksa boş bırakın",
  "TOUSER": "Mesajı alacak üyeler, üye ID listesi (birden fazla alıcı için ”&#166;” ile ayırın, en fazla 1000 desteklenir). Özel durum: ”@all” ise, tüm üyelere gönderilir, yoksa boş bırakın",
  "TOPARTY": "Mesajı alacak departmanlar, departman ID listesi, birden fazla için ”&#166;” ile ayırın, en fazla 100 desteklenir. touser ”@all” ise, ”@all” yazın, yoksa boş bırakın",
  "TOTAG": "Mesajı alacak etiketler, etiket ID listesi, birden fazla için ”&#166;” ile ayırın, en fazla 100 desteklenir. touser ”@all” ise, ”@all” yazın, yoksa boş bırakın",
  "OPEN_GET_WEATHER": "Bölge hava durumuna göre adım sayısı azaltılsın mı, yoksa boş bırakın",
  "AREA": "Hava durumu alınacak bölgeyi ayarlayın (yukarıdaki açık ise zorunlu) örn. Pekin, yoksa boş bırakın",
  "QWEATHER": "Buraya QWeather Private KEY yazın, başvuru adresi https://console.qweather.com/#/apps, yoksa boş bırakın",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Çoklu hesap için maksimum adım sayısı, yukarıya bakınız",
      "min_step": "Çoklu hesap için minimum adım sayısı, yukarıya bakınız",
      "password": "Çoklu hesap için şifre, yukarıya bakınız",
      "user": "Çoklu hesap için telefon numarası, yukarıya bakınız"
    }
  ]
}
```
> **PAT** adında bir değişken ekleyin: Settings-->Secrets-->New secret

| Secrets |  Format  |
| -------- | ----- |
| PAT |   Buradaki **PAT** başvuru gerektirir, değeri github token'dır, kılavuz için: https://www.jianshu.com/p/bb82b3ad1d11 , repo ve workflow izni gereklidir, bu alan zorunludur, git push yetki hatasını önler. |

**CONFIG** örneği
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Çoklu hesap için maksimum adım sayısı, yukarıya bakınız",
      "min_step": "Çoklu hesap için minimum adım sayısı, yukarıya bakınız",
      "password": "Çoklu hesap için şifre, yukarıya bakınız",
      "user": "Çoklu hesap için telefon numarası, yukarıya bakınız"
    }
  ]
}
```

### 3. Başlatma Zamanını Özelleştirin

**random_cron.sh** dosyasını düzenleyin
İçerisindeki **if** ifadesinde kontrol edilen zamanı UTC cinsinden değiştirin, yani **Pekin Zamanı -8** olacak şekilde ayarlayın. Örneğin, Pekin saati 8 ise UTC 0 olur, çalıştırmak istediğiniz saatten 8 çıkartarak UTC'yi bulun.

## Dikkat Edilmesi Gerekenler

1. Her gün yedi kez çalışır, random_cron.sh tarafından kontrol edilir, dakika rastgele belirlenir

2. Çoklu hesap sayısı ve şifrelerin doğru olduğundan emin olun, aksi takdirde çalışmaz!!!

3. Başlatma zamanı UTC olmalıdır!

4. server酱 kayıt adresi [Buraya tıklayın](https://sct.ftqq.com/)

5. Eğer Alipay adım sayısını güncellemiyorsa, Xiaomi Mi Fit->Ayarlar->Hesap->Hesabı Çıkış Yap->Verileri Temizle, ardından tekrar giriş yapıp üçüncü tarafı tekrar bağlayın

6. Xiaomi Mi Fit adım sayısını güncellemez, sadece bağlı olanlar senkronize edilir!!!!!!

7. Lütfen kullanırken [ana dalı](https://github.com/xunichanghuan/mimotion-run/) Fork'layın, gereksiz hataların önüne geçin.

8. Dikkat edin, giriş yapılan hesap [Xiaomi hesabı] değil, [Xiaomi Mi Fit] hesabıdır.

## Tarihsel Star Sayısı 

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---