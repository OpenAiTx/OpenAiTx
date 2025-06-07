<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">Mahallendeki Dost Canlısı Oyun Siteniz.</p>
<br>

MonkeyGG2'ye hoş geldiniz, sizin için oluşturulmuş özelliklerle dolu bir oyun sitesi! 150'den fazla oyun seçeneğiyle MonkeyGG2, benzersiz ve özelleştirilebilir bir oyun deneyimi sunar. İster bir oyuncu, ister geliştirici, ister sıradan bir kullanıcı olun, MonkeyGG2 size sorunsuz ve keyifli bir oyun ortamı sağlar.

> Bize bir yıldız vermeyi düşünün! Özellikle bu depoyu çatalladıysanız veya bu depodan başka bir şekilde faydalandıysanız.

## Özellikler

-   150'den fazla oyun
-   Kullanımı kolay
-   Kolay dağıtım
-   Özelleştirilebilir
-   Proxy
-   Ve Daha Fazlası...

## Özelleştirme

### Ayarlar

#### Gizleme (Cloaking)

Gizleme, sayfanın bir `about:blank` sekmesinde açılmasına denir. Bu davranış varsayılan olarak zorunludur ancak devre dışı bırakılabilir. Yönlendirme bağlantısı için hazır ayarlar mevcuttur, ancak manuel olarak da yapılandırılabilir.

#### Maskeleme (Masking)

Maskeleme, about:blank sekmesinin simgesinin ve sekme başlığının değiştirilmesidir. Simgeler ve sekme başlığı için hazır ayarlar mevcuttur, ancak manuel olarak da yapılandırılabilir.

#### Kısayollar

Çeşitli görevleri yerine getirmek için özel klavye kısayolları oluşturabilirsiniz. Örneğin, oyundan çıkmak, sekmeyi maskelemek ve özel JavaScript çalıştırmak desteklenir.
> Not: Özel JavaScript çalıştırmak istiyorsanız, ne yaptığınızdan emin olun. Bir şeyi bozarsanız, sayfayı yeniden yüklemek her zaman çözüm olacaktır.

#### Tema

Şu anda aşağıdaki tema özelleştirmeleri desteklenmektedir:
- Arka Plan Animasyonunu Aç/Kapat (oyun sırasında performans konusunda endişeleniyorsanız, oyun oynarken otomatik olarak devre dışı bırakılır)
- Arka Plan Rengi
- Blok Rengi
- Buton Rengi
- Oyunlar Rengi
- Üzerine Gelindiğinde Renk
- Kaydırma Çubuğu Rengi
- Kaydırma Yolu Rengi
- Yazı Tipi Rengi

> Not: Renkleri yanlışlıkla sitenin kullanılamayacağı şekilde değiştirirseniz, çerezlerinizi ve yerel depolamanızı temizlemeniz gerekecek.

### Gelişmiş Özelleştirme

> Sorumluluk Reddi: Aşağıdaki özelleştirmeler yalnızca bu deponun veya çatallanmış bir deponun sahipleri için geçerlidir.

`config.jsonc` dosyası, sitenin tüm yapılandırmasını içerecek şekilde biçimlendirilmiştir. Şu anda aşağıdaki öğeler desteklenmektedir:
- Oyunlar
- Temalar (yakında)
- Proxy Yapılandırması

#### Oyunlar

Her oyun girdisinin, oyunun görünen adını temsil eden bir anahtarı vardır ve değeri üç anahtar-değer çifti içeren bir nesne olmalıdır:
- `"path"`: `./games` dizininden oyuna giden yol
- `"aliases"`: Oyunun arama için kullanılan alternatif isimlerinin listesi
- `"categories"`: Oyunun ait olduğu kategorilerin listesi (ikon ekleme desteği yakında)

Bir girdiyi manuel olarak eklemek mümkündür, ancak listeyi alfabetik olarak sıralamak isterseniz zahmetlidir (bu yapılandırmanın çalışması için gerekli değildir!)
Bu nedenle, `add-game-entry.js` betiği oluşturulmuştur; dosyayı manuel düzenlemek zorunda kalmadan yapılandırmaya yeni bir oyun eklemenin kolay bir yoludur.

```bash
# Herhangi bir js çalışma zamanı kullanabilirsiniz, örneğin node.js, bun veya deno
# Bu gösterimde bağımlılıklar otomatik olarak kurulduğu için bun kullanılacaktır
bun add-game-script.js
# Takip eden istemleri cevaplayın ve yapılandırma güncellenecektir
```

#### Temalar

Tema standardı henüz uygulanmadı (YAPILACAKLAR)

#### Proxy

Proxy yapılandırma seçenekleri **"config"** anahtarının altındadır.
`"proxy"` anahtarının değeri, proxy işlevini etkinleştiren veya devre dışı bırakan bir boolean değerdir. `"proxy"` false olarak ayarlanırsa, kullanıcı proxy'ye erişmeye çalıştığında bir hata iletişim kutusuyla karşılaşır.
`"proxyPath"` anahtarının değeri proxy'ye giden yoldur. Mutlak bir yol veya göreli bir yol olabilir, ancak proxy **CORS** desteğine sahip olmalıdır, çünkü proxy sayfası sitede bir iframe olarak görüntülenecektir.


## Dağıtım

### Proxy Olmadan

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

Alternatif olarak, bu depoyu [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) veya [Codeberg](https://codeberg.org/MonkeyGG2/pages) üzerinden çatallayabilir ve sırasıyla GitHub Pages veya Codeberg Pages'e dağıtabilirsiniz.

### Proxy ile

MonkeyGG2'yi bir proxy ile barındırmak hakkında daha fazla bilgi için [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) sayfasını ziyaret edin.

### Yerel Çalıştırma

```bash
# UYARI: "monkeygg2" adında bir klasörünüz varsa, bu komut o klasördeki tüm dosyaları silecektir
# lütfen aşağıdaki iki komuttaki klasör adını değiştirin
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# buradan itibaren statik bir sunucu çalıştırmak için herhangi bir aracı kullanabilirsiniz, burada npm üzerinden "live-server" kullanılacaktır
npm install -g live-server # daha önce kurulu değilse
npx live-server
```

## Lisans

WTFPL Lisansı altında dağıtılmaktadır. Daha fazla ayrıntı için [buraya](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE) bakın.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---