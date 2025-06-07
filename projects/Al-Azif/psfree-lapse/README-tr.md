# PSFree sürüm 1.5.1

PSFree, PS4 konsolu için bir exploit (açık) koleksiyonudur. Depodaki ana odak noktası PS4’tür, ancak her şeyi PS5’e taşınabilir hale getirmeye çalışıyoruz.

## Özellikler

- **Otomatik algılama:** Konsol tipini ve yazılım sürümünü otomatik olarak algılar (`src/config.mjs` aracılığıyla).
- **WebKit Exploit (PSFree):** Konsolun web tarayıcısı üzerinden giriş noktası.
- **Çekirdek Exploit (Lapse):** Yetkileri çekirdek seviyesine yükseltir.
- **Payload Yükleyici:** Başarılı çekirdek exploitinden sonra 9020 portunda bir payload dinler.

## Zafiyet Kapsamı

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## Bu Depo Tarafından Desteklenenler

Bu tablo, bu deponun _mevcut sürümü_ ile işlevsel ve test edilmiş bir exploit zinciri sunulan yazılım sürümlerini göstermektedir.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | YOK       | YOK       |

_Not: “Zafiyet Kapsamı” tablosunda listelenen diğer yazılımlar için destek üzerinde çalışılıyor olabilir, ya da bu deponun önceki sürümlerinde desteklenmiş olabilir. Geçmiş destek için lütfen [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) dosyasına bakınız._

## Yapılacaklar Listesi

- [ ] Belirli oyunlarda siyah ekran/kayıt sorunu
- [ ] `lapse.mjs`: Sadece JIT ayrıcalıkları için bitleri ayarla
- [ ] `view.mjs`: PS4 varsayımı yapıyor, PS5 desteği ekle
- [ ] PS5 desteği ekle

## Telif Hakkı ve Yazarlar:

AGPL-3.0-veya-sonrası (bakınız [LICENSE](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). Bu depo `anonymous` grubuna aittir. Anonim katkıda bulunanlara da "anonymous" olarak atıfta bulunuyoruz.

## Teşekkürler:

- PS4 yazılım çekirdek dökümleri için anonymous
- **Ekstra** katkıda bulunanlar için ilgili dosyalara bakınız. Aksi belirtilmedikçe, buradaki her şey bize de atfedilebilir.

## Bağışlar

(Monero/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---