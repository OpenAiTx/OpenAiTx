<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <p>Aşağıdaki çeviriler yapay zeka kullanılarak otomatik olarak oluşturulmuştur. Lütfen eski sürümlere veya bazı yanlışlıklara referans olabileceğini unutmayın.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

Oynatıcıda Bölüm Önizlemesi
====================
## 📄 Hakkında
Bu eklenti, video oynatıcıya bir bölüm listesi ekler ve böylece dizinin tüm bölümlerini oynatıcıdan çıkmadan önizleyebilirsiniz.

Bu değişiklik aşağıdaki istemciler için destek sunar:
* [Jellyfin Web İstemcisi](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin Medya Oynatıcı](https://github.com/jellyfin/jellyfin-media-player) (JMP) Masaüstü İstemcisi

## ✨ Özellikler
* Bir sezonun tüm bölümlerini listele
* Sezonlar arasında geçiş yap
* Bölüm başlığı, açıklaması, küçük resmi ve oynatma ilerlemesini gösterir
* Topluluk sıralaması gibi bölüm detaylarını gösterir
* Bölümleri oynandı veya favori olarak işaretle
* Yeni bir bölüme başla
* Özel temalarla çalışmalıdır

## 📸 Önizleme
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Kullanılan Tema: (SkinManager) Kaleidochromic
<br>
Bu önizlemede bir bölümü tamamlandı veya favori olarak işaretlemek için yeni düğmeler eksik.

## 🔧 Kurulum

### Jellyfin Web İstemcisi (Sunucu)

> [!NOT]
> [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) eklentisinin en az v2.2.1.0 sürümünün kurulu olması şiddetle önerilir. Her türlü kurulumda index.html dosyasını değiştirirken izin sorunlarını önlemeye yardımcı olur!
<details open>
<summary> Talimatları görüntüle... </summary>

1. Manifest'i `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` Jellyfin eklenti deposu olarak sunucunuza ekleyin.
2. Depodan `InPlayerEpisodePreview` eklentisini yükleyin.
3. Jellyfin sunucusunu yeniden başlatın.
</details>

### Jellyfin Media Player (JMP) Masaüstü İstemcisi (Kullanımdan Kaldırıldı)
<details>
<summary> Talimatları görüntüle... </summary>

**JMP Sürümü [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0) ile kullanımdan kaldırıldı**

Yeni JMP istemcisi doğrudan sunucudan mevcut web oynatıcıyı kullandığı için, istemci kodunda doğrudan bir değişiklik yapmaya gerek yoktur.

Bu, masaüstü istemcisinde betiği yüklemek için önerilen yöntemdir.
Eğer nativeshell.js dosyasını kendiniz düzenlemekten (adım 3 ila 6) rahat hissetmiyorsanız, bunun yerine tam sürümü indirebilirsiniz; bu sürümde script zaten nativeshell.js dosyasına eklenmiş olarak gelir.
Yayın dosyasındaki nativeshell.js dosyasını değiştirmenin potansiyel sorunlara yol açıp açmayacağı henüz net değil, bu yüzden aşağıdaki tüm adımları izlemeniz önerilir.

1. En son sürümü indirin [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) veya [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (script zaten nativeshell.js dosyasına eklenmiş olarak gelir)
2. Zip dosyasını Jellyfin dizininize çıkarın (ör. C:\Program Files\Jellyfin\Jellyfin Media Player)
3. Jellyfin dizininizde "web-client\extension" klasör yolunu takip edin
4. "nativeshell.js" dosyasını bir metin düzenleyicide açın.
5. Dosya içinde `const plugins = [];` bölümünü bulun. Listenin başına yeni bir satır ekleyin ve `'inPlayerEpisodePreviewPlugin',` satırını yapıştırın. Bölüm artık aşağıdaki gibi görünmelidir:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. Dosyayı kaydedin ve JMP istemcisini yeniden başlatın.
</details>

## 💡 Sorun Giderme

### 1. Önizleme düğmesi görünmüyor
Bu büyük olasılıkla `index.html` dosyası için yanlış izinlerle ilgilidir.

<details>
<summary> Olası çözümler listesini görmek için... </summary>

#### 1.1 Bu sorunu [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) eklentisini kullanarak önleyin.

#### 1.2 Docker konteyneri içinde sahipliği değiştirin
Jellyfin'i bir docker konteynerinde çalıştırıyorsanız, sahipliği aşağıdaki komutla değiştirebilirsiniz
(jellyfin'i konteyner adınızla, user ve group'u konteynerinizin kullanıcı ve grubu ile değiştirin):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Bunu sistem başlangıcında bir cron işi olarak çalıştırabilirsiniz.
([muisje](https://github.com/muisje)'ye [bu](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) çözümdeki yardımları için teşekkürler)

#### 1.3 Sahipliği Değiştirme (Windows kurulumu üzerinde çalıştırma)
1. Şuraya gidin: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. `index.html` dosyasına sağ tıklayın → `Özellikler` → `Güvenlik sekmesi` → `Düzenle`ye tıklayın
3. Listeden kendi kullanıcınızı seçin ve Yazma `izin` kutusunu işaretleyin.
4. Hem sunucuyu hem de istemciyi yeniden başlatın.
   ([xeuc](https://github.com/xeuc)'ye [bu](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) çözüm için teşekkürler)

Yukarıdaki çözümler işe yaramazsa, lütfen eski sorunlara göz atın. Örneğin [burada](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) veya [burada](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
Kendi başınıza çözümleyemediğiniz herhangi bir hatayla karşılaşırsanız, bir sorun açmaktan çekinmeyin.
<br/>Her sistemin farklı olabileceğini ve beklenmedik davranışlara yol açabileceğini unutmayın, bu yüzden mümkün olduğunca fazla bilgi ekleyin.
<br/>Jellyfin günlükleri ve tarayıcıdan alınan konsol günlükleri ([InPlayerEpisodePreview] önekiyle) her zaman faydalıdır.

## Katkıda Bulunanlar
Eklenti yapısı, [NickNSY](https://github.com/nicknsy) tarafından geliştirilen [Jellyscrub](https://github.com/nicknsy/jellyscrub) eklentisinden alınmış ve esinlenilmiştir.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---