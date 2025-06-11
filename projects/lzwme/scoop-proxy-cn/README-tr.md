# 🍡 scoop-proxy-cn

Çin ana karası kullanıcıları için uygun olan [Scoop](https://scoop.sh) bucket proxy aynası deposu. Birden fazla açık kaynak `bucket` deposundan senkronize güncellenir. Bunlar arasında:

- `sync` dalı (varsayılan): Birden fazla depodan uygulamaları senkronize eder, ancak ghproxy proxy değişikliği yapmaz. **Gitee üzerinden Çin içi modifiye Scoop kullanan senaryolar için uygundur**
- `main` dalı: `github release` üzerinden indirilen uygulama adreslerini `https://ghfast.top` tabanlı proxy indirme adresine değiştirir. **Proxy adresleri sık sık geçersiz hale gelip değiştiği için kararsızdır**

## Kullanım

`spc` uygulama deposunu ekleyin. [Scoop Çin içi ayna optimizasyon deposu](https://gitee.com/scoop-installer/scoop) ile birlikte kullanıma uygundur:

```bash
# Bucket ekle, varsayılan olarak sync dalını çeker
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Uygulamaları yükle
scoop install spc/<uygulama_adı>
```

Sadece resmi Scoop sürümünü kullanmak isterseniz, aşağıdaki işlemi yaparak abonelik dalını `main` dalına değiştirebilirsiniz:

```bash
# spc dizinine girin
cd "$env:USERPROFILE\scoop\buckets\spc"
# Eğer SCOOP ortam değişkeni ayarlanmışsa, aşağıdaki komutu kullanın
cd "$env:SCOOP\buckets\spc"

# main dalına geçiş yapın
git fetch --all
git checkout -b main origin/main
```

## Scoop Kurulum ve Konfigürasyon Referansı

### Yöntem 1: Çin içi özelleştirilmiş ayna üzerinden kurulum (Önerilen)

Scoop'un kaynak kodu ve bucket uygulamaları çoğunlukla github üzerinde git formatında barındırılır, github erişim zorlukları nedeniyle kurulum, güncelleme ve uygulama indirme deneyimi oldukça kötüleşir.

Aşağıda [Scoop Çin içi ayna optimizasyon deposu](https://gitee.com/scoop-installer/scoop) kurulumu anlatılmaktadır.

```bash
# Script çalışma politikası değişikliği, varsayılan otomatik onay
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# Yöntem 1: Kurulum komutunu çalıştır (varsayılan kullanıcı dizinine kurar, değiştirmek isterseniz "Özelleştirilmiş Kurulum Dizini" komutunu kullanın)
iwr -useb scoop.201704.xyz | iex


## Yöntem 2: Özelleştirilmiş kurulum dizini (dizini uygun konuma göre değiştirin)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# Eğer resmi kaynak kurulmuşsa, aşağıdaki komutla değiştirilebilir
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# spc bucket ekle
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# Yeni depo adresini çek
scoop update
```

Bu yöntemle kurulan scoop özelleştirilmiş ve proxy hızlandırma sunucusunu destekler, varsayılan olarak `scoop.201704.xyz` üzerinden proxy ile uygulama indirir.

```bash
# Proxy ekle
scoop config URL_PROXY "https://scoop.201704.xyz"

# Proxy sil
scoop config rm URL_PROXY
```

### Yöntem 2: Resmi depo üzerinden proxy ile kurulum

`PowerShell` açıp aşağıdaki komutları çalıştırın:

```bash
# kurulum
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# konfigürasyon
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# spc bucket ekle
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# spc dizinine gir
cd "$env:USERPROFILE\scoop\buckets\spc"
# main dalına geç
git fetch --all && git checkout -b main origin/main

# yardım göster
scoop help

# 7zip, aria2, scoop-search kur
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### `scoop-search` Hakkında

`scoop-proxy-cn` deposu `1.4w+` uygulamayı senkronize eder, resmi PowerShell tabanlı `scoop search` komutu çok yavaş çalıştığı için kullanışsızdır. Yerine `go` dili ile geliştirilmiş `scoop-search` aracı önerilir. Örnek:

```bash
scoop install scoop-search
# scoop-search kullanımı
scoop-search act
```

## Sıkça Sorulan Sorular

### `aria2` kaynaklı indirme başarısızlığı sorunu

`aria2` yüklüyse, scoop indirmeleri parçalı hızlandırma için `aria2` kullanır. Bazı proxy adresleri `aria2` parçalı indirme isteklerini desteklemez veya engeller. Bu durumda `aria2` devre dışı bırakılabilir:

```bash
scoop config aria2-enabled false
```

### `Hash Check Failed` hatası

Bazı uygulamaların indirme adresi en son sürüm adresi iken hash değeri sabit belirtilmiştir. Yeni sürüm çıktığında `Hash Check Failed` hatası alınır. Bu durumda `-s` parametresi ile hash kontrolü atlanabilir. Örnek:

```bash
scoop install scoop-search -s
```

### Proxy sunucu geçersiz olduğunda güncelleme yöntemi

Resmi Scoop kullanıyor ve `main` dalı aboneliği ile proxy hızlandırıcı kullanıyorsanız, eski proxy hızlandırıcı geçersiz olursa güncelleme durur. Yeniden eklemek için aşağıdaki komutları çalıştırın:

```bash
# Önce scoop deposunu güncelle
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# Yöntem 1: spc bucket deposunu güncelle
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# Eğer buckets varsayılan konumu değiştirilmişse
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# Yöntem 2: spc bucket kaldır ve yeniden ekle
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## Senkronize Edilen Depolar

- [ScoopInstaller/PHP](https://github.com/ScoopInstaller/PHP)
- [ScoopInstaller/Main](https://github.com/ScoopInstaller/Main)
- [ScoopInstaller/Extras](https://github.com/ScoopInstaller/Extras)
- [ScoopInstaller/Java](https://github.com/ScoopInstaller/Java)
- [ScoopInstaller/Versions](https://github.com/ScoopInstaller/Versions)
- [ScoopInstaller/Nirsoft](https://github.com/ScoopInstaller/Nirsoft)
- [ScoopInstaller/Nonportable](https://github.com/ScoopInstaller/Nonportable)
- [renxia/scoop-bucket](https://github.com/renxia/scoop-bucket)
- [scoopcn/scoopcn](https://github.com/scoopcn/scoopcn)
- [rasa/scoops](https://github.com/rasa/scoops)
- [amorphobia/siku](https://github.com/amorphobia/siku)
- [ACooper81/scoop-apps](https://github.com/ACooper81/scoop-apps)
- [kkzzhizhou/scoop-zapps](https://github.com/kkzzhizhou/scoop-zapps)
- [Calinou/scoop-games](https://github.com/Calinou/scoop-games)
- [cderv/r-bucket](https://github.com/cderv/r-bucket)
- [chawyehsu/dorado](https://github.com/chawyehsu/dorado)
- [borger/scoop-galaxy-integrations](https://github.com/borger/scoop-galaxy-integrations)
- [ivaquero/scoopet](https://github.com/ivaquero/scoopet)
- [KNOXDEV/wsl](https://github.com/KNOXDEV/wsl)
- [kodybrown/scoop-nirsoft](https://github.com/kodybrown/scoop-nirsoft)
- [kidonng/sushi](https://github.com/kidonng/sushi)
- [littleli/scoop-clojure](https://github.com/littleli/scoop-clojure)
- [niheaven/scoop-sysinternals](https://github.com/niheaven/scoop-sysinternals)
- [matthewjberger/scoop-nerd-fonts](https://github.com/matthewjberger/scoop-nerd-fonts)
- [TheCjw/scoop-retools](https://github.com/TheCjw/scoop-retools)
- [TheRandomLabs/Scoop-Bucket](https://github.com/TheRandomLabs/Scoop-Bucket)
- [TheRandomLabs/scoop-nonportable](https://github.com/TheRandomLabs/scoop-nonportable)
- [TheRandomLabs/Scoop-Spotify](https://github.com/TheRandomLabs/Scoop-Spotify)
- [Paxxs/Cluttered-bucket](https://github.com/Paxxs/Cluttered-bucket)
- [zhoujin7/tomato](https://github.com/zhoujin7/tomato)
- [HCLonely/my-scoop-bucket](https://github.com/HCLonely/my-scoop-bucket)
- [Weidows-projects/scoop-3rd](https://github.com/Weidows-projects/scoop-3rd)
- [hermanjustnu/scoop-emulators](https://github.com/hermanjustnu/scoop-emulators)
- [everyx/scoop-bucket](https://github.com/everyx/scoop-bucket)
- [borger/scoop-emulators](https://github.com/borger/scoop-emulators)
- [ZvonimirSun/scoop-iszy](https://github.com/ZvonimirSun/scoop-iszy)
- [kiennq/scoop-misc](https://github.com/kiennq/scoop-misc)
- [wzv5/ScoopBucket](https://github.com/wzv5/ScoopBucket)
- [TheRandomLabs/Scoop-Python](https://github.com/TheRandomLabs/Scoop-Python)
- [naderi/scoop-bucket](https://github.com/naderi/scoop-bucket)
- [ViCrack/scoop-bucket](https://github.com/ViCrack/scoop-bucket)
- [42wim/scoop-bucket](https://github.com/42wim/scoop-bucket)
- [akirco/aki-apps](https://github.com/akirco/aki-apps)
- [batkiz/backit](https://github.com/batkiz/backit)
- [iquiw/scoop-bucket](https://github.com/iquiw/scoop-bucket)
- [ygguorun/scoop-bucket](https://github.com/ygguorun/scoop-bucket)
- [seumsc/scoop-seu](https://github.com/seumsc/scoop-seu)
- [cc713/ownscoop](https://github.com/cc713/ownscoop)
- [aoisummer/scoop-bucket](https://github.com/aoisummer/scoop-bucket)
- [yuusakuri/scoop-bucket](https://github.com/yuusakuri/scoop-bucket)
- [hu3rror/scoop-muggle](https://github.com/hu3rror/scoop-muggle)
- [starise/Scoop-Confetti](https://github.com/starise/Scoop-Confetti)
- [dodorz/scoop](https://github.com/dodorz/scoop)
- [SayCV/scoop-cvp](https://github.com/SayCV/scoop-cvp)
- [Qv2ray/mochi](https://github.com/Qv2ray/mochi)
- [Homeland-Community/scoop](https://github.com/Homeland-Community/scoop)
- [jingyu9575/scoop-jingyu9575](https://github.com/jingyu9575/scoop-jingyu9575)
- [couleur-tweak-tips/utils](https://github.com/couleur-tweak-tips/utils)
- [wangzq/scoop-bucket](https://github.com/wangzq/scoop-bucket)
- [jonz94/scoop-sarasa-nerd-fonts](https://github.com/jonz94/scoop-sarasa-nerd-fonts)
- [NyaMisty/scoop_bucket_misty](https://github.com/NyaMisty/scoop_bucket_misty)
- [jfut/scoop-jfut](https://github.com/jfut/scoop-jfut)
- [mogeko/scoop-sysinternals](https://github.com/mogeko/scoop-sysinternals)
- [ChungZH/peach](https://github.com/ChungZH/peach)
- [DoveBoy/Apps](https://github.com/DoveBoy/Apps)
- [Velgus/Scoop-Portapps](https://github.com/Velgus/Scoop-Portapps)
- [starise/Scoop-Gaming](https://github.com/starise/Scoop-Gaming)
- [mo-san/scoop-bucket](https://github.com/mo-san/scoop-bucket)
- [brian6932/dank-scoop](https://github.com/brian6932/dank-scoop)
- [AkariiinMKII/Scoop4kariiin](https://github.com/AkariiinMKII/Scoop4kariiin)
- [littleli/Scoop-littleli](https://github.com/littleli/Scoop-littleli)
- [ChinLong/scoop-customize](https://github.com/ChinLong/scoop-customize)
- [Darkatse/Scoop-KanColle](https://github.com/Darkatse/Scoop-KanColle)
- [aliesbelik/poldi](https://github.com/aliesbelik/poldi)
- [MCOfficer/scoop-bucket](https://github.com/MCOfficer/scoop-bucket)
- [KnotUntied/scoop-fonts](https://github.com/KnotUntied/scoop-fonts)
- [beerpiss/scoop-bucket](https://github.com/beerpiss/scoop-bucket)
- [HUMORCE/nuke](https://github.com/HUMORCE/nuke)
- [AkinoKaede/maple](https://github.com/AkinoKaede/maple)
- [hulucc/bucket](https://github.com/hulucc/bucket)
- [Deide/deide-bucket](https://github.com/Deide/deide-bucket)
- [echoiron/echo-scoop](https://github.com/echoiron/echo-scoop)
- [tetradice/scoop-iyokan-jp](https://github.com/tetradice/scoop-iyokan-jp)

## Beyan

> [!UYARI]
> Bu depo, içindeki uygulama bilgilerini yalnızca üçüncü taraf depolardan senkronize etmektedir, her birinin kullanılabilirliği ve güvenliği tek tek doğrulanmamıştır. Lütfen kurulum sırasında kendiniz doğrulama yapınız. Herhangi bir hak ihlali durumunda lütfen issue açarak bildirin.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---