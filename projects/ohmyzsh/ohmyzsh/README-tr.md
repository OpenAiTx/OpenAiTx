<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh, [zsh](https://www.zsh.org/) yapılandırmanızı yönetmek için açık kaynaklı, topluluk odaklı bir çerçevedir.

Kulağa sıkıcı geliyor. Tekrar deneyelim.

**Oh My Zsh sizi 10 kat daha iyi bir geliştirici yapmaz... ama öyleymiş gibi hissedebilirsiniz.**

Kurulumdan sonra terminaliniz herkesin diline düşecek _ya da paranız iade!_ Komut isteminizdeki her tuş vuruşunda, yüzlerce güçlü eklenti ve güzel temadan faydalanacaksınız.
Kafelerde yabancılar size gelip, _"bu harika! Yoksa bir dahininiz mi?"_ diye soracaklar.

Sonunda, her zaman hak ettiğinizi düşündüğünüz ilgiyi görmeye başlayacaksınız. ...ya da belki kazandığınız zamanı daha sık diş ipi kullanarak değerlendireceksiniz. 😬

Daha fazla bilgi edinmek için [ohmyz.sh](https://ohmyz.sh) adresini ziyaret edin, X'te (eski adıyla Twitter) [@ohmyzsh](https://x.com/ohmyzsh) hesabını takip edin ve [Discord](https://discord.gg/ohmyzsh) kanalımıza katılın.

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>İçindekiler</summary>

- [Başlarken](#getting-started)
  - [İşletim Sistemi Uyumluluğu](#operating-system-compatibility)
  - [Gereksinimler](#prerequisites)
  - [Temel Kurulum](#basic-installation)
    - [Manuel İnceleme](#manual-inspection)
- [Oh My Zsh Kullanımı](#using-oh-my-zsh)
  - [Eklentiler](#plugins)
    - [Eklentileri Etkinleştirme](#enabling-plugins)
    - [Eklenti Kullanımı](#using-plugins)
  - [Temalar](#themes)
    - [Tema Seçimi](#selecting-a-theme)
  - [SSS](#faq)
- [İleri Düzey Konular](#advanced-topics)
  - [Gelişmiş Kurulum](#advanced-installation)
    - [Özel Dizin](#custom-directory)
    - [Denetimsiz Kurulum](#unattended-install)
    - [Çatallanmış Depodan Kurulum](#installing-from-a-forked-repository)
    - [Manuel Kurulum](#manual-installation)
  - [Kurulum Sorunları](#installation-problems)
  - [Özel Eklentiler ve Temalar](#custom-plugins-and-themes)
  - [macOS ve freeBSD Sistemlerinde GNU ls Etkinleştirme](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [Kısayolları Atla](#skip-aliases)
  - [Asenkron git istemi](#async-git-prompt)
- [Güncellemeleri Almak](#getting-updates)
  - [Güncelleme Ayrıntı Düzeyi](#updates-verbosity)
  - [Manuel Güncellemeler](#manual-updates)
- [Oh My Zsh’yi Kaldırmak](#uninstalling-oh-my-zsh)
- [Oh My Zsh’ye Nasıl Katkıda Bulunabilirim?](#how-do-i-contribute-to-oh-my-zsh)
  - [Bize Tema Göndermeyin](#do-not-send-us-themes)
- [Katkıda Bulunanlar](#contributors)
- [Bizi Takip Edin](#follow-us)
- [Ürünler](#merchandise)
- [Lisans](#license)
- [Planet Argon Hakkında](#about-planet-argon)

</details>

## Başlarken

### İşletim Sistemi Uyumluluğu

| İS             | Durum |
| :------------- | :---: |
| Android        |   ✅  |
| freeBSD        |   ✅  |
| LCARS          |   🛸  |
| Linux          |   ✅  |
| macOS          |   ✅  |
| OS/2 Warp      |   ❌  |
| Windows (WSL2) |   ✅  |

### Gereksinimler

- [Zsh](https://www.zsh.org) yüklü olmalıdır (v4.3.9 veya daha yenisi uygundur, fakat 5.0.8 ve üzeri tercih edilir). Eğer önceden yüklü değilse (doğrulamak için `zsh --version` komutunu çalıştırın), şu wiki talimatlarına bakın: [ZSH Kurulumu](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- `curl` veya `wget` yüklü olmalıdır
- `git` yüklü olmalıdır (önerilen v2.4.11 veya üzeri)

### Temel Kurulum

Oh My Zsh, terminalinizde aşağıdaki komutlardan birini çalıştırarak kurulur. Komut satırından `curl`, `wget` veya benzeri bir araç ile kurulabilir.

| Yöntem    | Komut                                                                                           |
| :-------- | :--------------------------------------------------------------------------------------------- |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

Alternatif olarak, kurulum aracı GitHub dışında da yansıtılmıştır. Çin veya Hindistan gibi (bazı servis sağlayıcıları için) `raw.githubusercontent.com` adresinin engellendiği ülkelerde aşağıdaki URL kullanılabilir:

| Yöntem    | Komut                                           |
| :-------- | :---------------------------------------------- |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_Önceki bir `.zshrc` dosyanız varsa, bu dosya `.zshrc.pre-oh-my-zsh` olarak yeniden adlandırılır. Kurulumdan sonra, korumak istediğiniz ayarları yeni `.zshrc` dosyasına taşıyabilirsiniz._

#### Manuel İnceleme

Henüz tanımadığınız projelerin kurulum betiğini incelemek iyi bir fikirdir. Bunu yapmak için, kurulum betiğini önce indirip gözden geçirebilir, ardından çalıştırabilirsiniz:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

Yukarıdaki URL zaman aşımına uğrarsa veya başarısız olursa, betiği almak için
`https://install.ohmyz.sh` adresini kullanmanız gerekebilir.

## Oh My Zsh Kullanımı

### Eklentiler

Oh My Zsh, kullanmanız için bir sürü eklenti ile birlikte gelir. [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) klasörüne ve/veya [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) sayfasına göz atarak mevcut eklentileri görebilirsiniz.

#### Eklentileri Etkinleştirme

Kullanmak istediğiniz bir (veya birden fazla) eklentiyi bulduğunuzda, bunları `.zshrc` dosyanızda etkinleştirmeniz gerekir. zshrc dosyasını `$HOME` dizininizde bulabilirsiniz. Favori metin düzenleyicinizle açın ve yüklemek istediğiniz tüm eklentileri listeleyebileceğiniz bir bölüm göreceksiniz.

```sh
vi ~/.zshrc
```

Örneğin, şöyle görünebilir:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_Eklentilerin boşluklarla (boşluk, sekme, yeni satır...) ayrıldığına dikkat edin. **Aralarına virgül koymayın**, aksi takdirde çalışmaz._

#### Eklenti Kullanımı

Her yerleşik eklenti bir **README** dosyası içerir. Bu dosya, eklentiyle gelen kısayolları ve ek özellikleri açıklar.

### Temalar

Kabul ediyoruz. Oh My Zsh dünyasının başlarında, biraz fazla tema sevdalısı olmuş olabiliriz. Şimdi paketlenmiş olarak 150'den fazla tema var. Bunların çoğunun [ekran görüntüleri](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) wiki'de mevcut (Güncelleniyor!). Göz atmayı unutmayın!

#### Tema Seçimi

_Robby'nin teması varsayılan temadır. En şatafatlı olanı değil. En basiti de değil. Sadece onun için en uygun olanı._

Kullanmak istediğiniz bir tema bulduktan sonra, `~/.zshrc` dosyanızı düzenlemeniz gerekir. İçinde şu şekilde bir ortam değişkeni göreceksiniz:

```sh
ZSH_THEME="robbyrussell"
```

Farklı bir tema kullanmak için, değeri istediğiniz tema ismiyle değiştirmeniz yeterli. Örneğin:

```sh
ZSH_THEME="agnoster" # (bu şık olanlardan biri)
# bkz. https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!NOTE]
> Bir zsh teması için ekran görüntüsü görüp denediğinizde, sizde aynı görünmediğini fark edebilirsiniz.
>
> Bunun sebebi, birçok temanın düzgün görüntülenebilmesi için bir [Powerline Fontu](https://github.com/powerline/fonts) veya bir [Nerd Font](https://github.com/ryanoasis/nerd-fonts) kurulmasını gerektirmesidir. Bunlar olmadan, temalarda tuhaf simgeler görünebilir. Daha fazla bilgi için [SSS](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt) sayfasına bakabilirsiniz.
>
> Ayrıca, temaların sadece istemcinizin görünümünü kontrol ettiğini unutmayın. Yani, komutlarınızı yazdığınız yerdeki metin ve semboller. Terminal pencerenizin renk düzeni (_color scheme_) veya yazı tipi gibi şeyler temalar tarafından kontrol edilmez. Bunlar terminal emülatörünüzde ayarlanır. Ayrıntılı bilgi için [zsh teması nedir](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme) bölümüne bakabilirsiniz.
<!-- prettier-ignore-end -->

Yeni bir terminal penceresi açın, istemciniz aşağıdaki gibi görünmelidir:

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

İhtiyaçlarınıza uygun bir tema bulamazsanız, [daha fazlası için](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) wikiye göz atın.

Farklı bir şey denemek isterseniz, bilgisayarınızın her yeni terminal penceresi açtığınızda rastgele bir tema seçmesini sağlayabilirsiniz.

```sh
ZSH_THEME="random" # (...lütfen pie olsun... lütfen pie olsun..)
```

Ve favori temalarınızdan oluşan bir listeden rastgele seçim yapmak isterseniz:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

Sadece hoşlanmadığınız temaları biliyorsanız, bunları şu şekilde hariç tutabilirsiniz:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### SSS

Daha fazla sorunuz veya sorunlarınız varsa, [SSS](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ) sayfamızda bir çözüm bulabilirsiniz.

## İleri Düzey Konular

İşin ayrıntılarını kurcalamayı sevenlerdenseniz, bu bölümler size hitap edebilir.

### Gelişmiş Kurulum

Bazı kullanıcılar Oh My Zsh'yi manuel olarak kurmak ya da kurulum dizinini veya diğer ayarları değiştirmek isteyebilir (bu ayarlar ayrıca kurulum betiğinin başında da belgelidir).

#### Özel Dizin

Varsayılan konum `~/.oh-my-zsh`’dir (ev dizininizde gizli olarak bulunur, `cd ~/.oh-my-zsh` komutuyla erişebilirsiniz).

Kurulum dizinini `ZSH` ortam değişkeni ile değiştirmek istiyorsanız, kuruluma başlamadan önce `export ZSH=/yolunuz` komutunu çalıştırabilir veya kurulumun sonunda şöyle ayarlayabilirsiniz:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### Denetimsiz Kurulum

Oh My Zsh kurulum betiğini otomatik bir kurulumun parçası olarak çalıştırıyorsanız, `install.sh` betiğine `--unattended` parametresini geçebilirsiniz. Bu, varsayılan kabuğu değiştirmeye çalışmaz ve kurulum bittiğinde `zsh` çalıştırmaz.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

Çin, Hindistan veya `raw.githubusercontent.com` adresinin engellendiği başka bir ülkedeyseniz, kurulum için URL'yi `https://install.ohmyz.sh` ile değiştirmeniz gerekebilir.

#### Çatallanmış Depodan Kurulum

Kurulum betiği, farklı bir depodan kurulum yapabilmek için aşağıdaki değişkenleri kabul eder:

- `REPO` (varsayılan: `ohmyzsh/ohmyzsh`): `sahip/depo` formatında. Bu değişkeni ayarlarsanız, yükleyici `https://github.com/{sahip}/{depo}` adresine bakar.
- `REMOTE` (varsayılan: `https://github.com/${REPO}.git`): git deposunun tam klon URL’si. GitHub dışında bir çataldan (GitLab, Bitbucket...) veya HTTPS yerine SSH ile klonlamak istiyorsanız kullanabilirsiniz (`git@github.com:user/project.git`).

  _NOT: `REPO` değişkeniyle uyumsuzdur. Bu ayar önceliklidir._

- `BRANCH` (varsayılan: `master`): Depo klonlanırken varsayılan dalı değiştirmek için kullanılır. Bir Pull Request’i test etmek ya da `master` dışında bir dalı kullanmak için faydalı olabilir.

Örnek:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### Manuel Kurulum

##### 1. Depoyu Klonlayın <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _İsteğe Bağlı_ Mevcut `~/.zshrc` Dosyanızı Yedekleyin <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. Yeni Bir Zsh Yapılandırma Dosyası Oluşturun <!-- omit in toc -->

Dahil ettiğimiz şablonu kopyalayarak yeni bir zsh yapılandırma dosyası oluşturabilirsiniz.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. Varsayılan Kabuğunuzu Değiştirin <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

Bu değişikliği görebilmek için oturumunuzu kapatıp tekrar açmanız gerekir.

##### 5. Yeni Zsh Yapılandırmanızı Başlatın <!-- omit in toc -->

Yeni bir terminal penceresi açtığınızda, zsh Oh My Zsh yapılandırmasıyla yüklenmiş olmalıdır.

### Kurulum Sorunları

Kurulum sırasında sorun yaşarsanız, aşağıdaki yaygın çözümlere göz atın.

- `oh-my-zsh`'ye geçtikten sonra bazı komutları bulamıyorsanız, `~/.zshrc` dosyanızda `PATH` değişkeninizi değiştirmeniz gerekebilir.
- Manuel kurulum yaptıysanız veya kurulum konumunu değiştirdiyseniz, `~/.zshrc` dosyasındaki `ZSH` ortam değişkenini kontrol edin.

### Özel Eklentiler ve Temalar

Varsayılan davranışların herhangi birini geçersiz kılmak isterseniz, `custom/` dizinine `.zsh` uzantılı yeni bir dosya eklemeniz yeterlidir.

Birbiriyle iyi çalışan birden çok fonksiyonunuz varsa, bunları `custom/plugins/` dizininde `XYZ.plugin.zsh` dosyası olarak ekleyip, bu eklentiyi etkinleştirebilirsiniz.

Oh My Zsh ile gelen bir eklentinin işlevini geçersiz kılmak istiyorsanız, aynı isimde bir eklentiyi `custom/plugins/` dizininde oluşturarak var olanın yerine yüklenmesini sağlayabilirsiniz.

### macOS ve freeBSD Sistemlerinde GNU ls Etkinleştirme

<a name="enable-gnu-ls"></a>

Oh My Zsh’de varsayılan olarak macOS ve FreeBSD sistemlerinde BSD `ls` kullanılır. GNU `ls` (ör. `gls` komutu) kuruluysa, onu kullanmak için şu zstyle tabanlı ayarı `oh-my-zsh.sh` dosyasını kaynaklamadan önce kullanabilirsiniz:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_Not: Bu ayar `DISABLE_LS_COLORS=true` ile uyumlu değildir._

### Kısayolları Atla

<a name="remove-directories-aliases"></a>

Varsayılan Oh My Zsh kısayollarını (`lib/*` dosyalarında tanımlananlar) veya eklenti kısayollarını atlamak istiyorsanız, aşağıdaki ayarları **Oh My Zsh yüklenmeden önce** `~/.zshrc` dosyanıza ekleyebilirsiniz. İhtiyaçlarınıza göre farklı şekillerde kısayolları atlayabilirsiniz.

```sh
# Tüm kısayolları, hem lib dosyalarında hem etkin eklentilerde atla
zstyle ':omz:*' aliases no

# Sadece lib dosyalarındaki tüm kısayolları atla
zstyle ':omz:lib:*' aliases no
# Sadece directories.zsh lib dosyasında tanımlı kısayolları atla
zstyle ':omz:lib:directories' aliases no

# Tüm eklenti kısayollarını atla
zstyle ':omz:plugins:*' aliases no
# Sadece git eklentisindeki kısayolları atla
zstyle ':omz:plugins:git' aliases no
```

Daha spesifik kapsamların öncelikli olduğunu bilerek, bunları farklı şekillerde birleştirebilirsiniz:

```sh
# Tüm eklenti kısayollarını atla, git eklentisi hariç
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

Bu özelliğin önceki bir sürümünde aşağıdaki ayar kullanılıyordu, artık kaldırıldı:

```sh
zstyle ':omz:directories' aliases no
```

Bunun yerine şimdi şunu kullanabilirsiniz:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### Dikkat <!-- omit in toc -->

> Bu özellik şu anda test aşamasındadır ve gelecekte değişebilir. Ayrıca, zpm veya zinit gibi eklenti yöneticileriyle uyumlu değildir; çünkü bu yöneticiler bu özelliğin uygulandığı başlatma betiğini (`oh-my-zsh.sh`) kaynaklamazlar.

> Ayrıca, fonksiyon olarak tanımlanan "kısayolları" şu anda algılayamaz. Örneğin, git eklentisindeki `gccd`, `ggf` veya `ggl` fonksiyonları gibi.

### Asenkron git istemi

Asenkron istem fonksiyonları (3 Nisan 2024'te eklendi), Oh My Zsh'nin istem bilgisini asenkron olarak sunmasını sağlayan deneysel bir özelliktir. Bu, istem performansını artırabilir; ancak bazı kurulumlarla uyumsuz olabilir. Sorun yaşarsanız, Oh My Zsh kaynaklanmadan önce `.zshrc` dosyanıza şu ayarı ekleyerek kapatabilirsiniz:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

Git istemi görünmüyorsa, aşağıdaki ayar ile zorlayabilirsiniz. Hala çalışmazsa, lütfen bir sorun bildiriniz.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## Güncellemeleri Almak

Varsayılan olarak, her 2 haftada bir güncellemeleri kontrol etmeniz istenir. Farklı bir güncelleme modu seçmek için, **Oh My Zsh yüklenmeden önce** `~/.zshrc` dosyanıza aşağıdaki satırı ekleyebilirsiniz:

1. Onay istemi olmadan otomatik güncelleme:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. Güncelleme varsa birkaç günde bir hatırlatma yap:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. Otomatik güncellemeyi tamamen devre dışı bırak:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

NOT: Oh My Zsh'nin güncellemeleri ne sıklıkta kontrol edeceğini aşağıdaki ayarla belirleyebilirsiniz:

```sh
# 7 günde bir güncellemeleri kontrol eder
zstyle ':omz:update' frequency 7
# Her terminal açılışında kontrol eder (önerilmez)
zstyle ':omz:update' frequency 0
```

### Güncelleme Ayrıntı Düzeyi

Güncelleme ayrıntı düzeyini aşağıdaki ayarlarla sınırlayabilirsiniz:

```sh
zstyle ':omz:update' verbose default # varsayılan güncelleme istemi

zstyle ':omz:update' verbose minimal # sadece birkaç satır

zstyle ':omz:update' verbose silent # sadece hatalar
```

### Manuel Güncellemeler

Herhangi bir zamanda (örneğin yeni bir eklenti yayınlandı ve bir hafta beklemek istemiyorsunuz) güncelleme yapmak için şunu çalıştırmanız yeterlidir:

```sh
omz update
```

> [!NOTE]
> Bu işlemi bir betikte otomatikleştirmek istiyorsanız, doğrudan `upgrade` betiğini şu şekilde çağırmalısınız:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> Daha fazla seçenek için [SSS: Oh My Zsh nasıl güncellenir?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh) bölümüne bakabilirsiniz.
>
> **`omz update --unattended` KULLANIMI KALDIRILDI, ÇÜNKÜ YAN ETKİLERİ VAR**.

Sihirli! 🎉

## Oh My Zsh’yi Kaldırmak

Oh My Zsh herkes için değildir. Sizi özleyeceğiz, fakat bu ayrılığı kolaylaştırmak istiyoruz.

`oh-my-zsh`’yi kaldırmak istiyorsanız, komut satırında `uninstall_oh_my_zsh` komutunu çalıştırmanız yeterlidir. Böylece kendisini kaldırır ve önceki `bash` veya `zsh` yapılandırmanıza geri döner.

## Oh My Zsh’ye Nasıl Katkıda Bulunabilirim?

Topluluğumuza katılmadan önce lütfen [davranış kurallarını](CODE_OF_CONDUCT.md) okuyun.

[Zsh](https://www.zsh.org/) konusunda uzman olmaktan uzağım ve geliştirilebilecek birçok yol olduğunu düşünüyorum – yapılandırmanın daha kolay bakımını sağlamak (ve hızlandırmak) için fikirleriniz varsa, çatallamaktan ve pull request göndermekten çekinmeyin!

Ayrıca pull request’leri test edecek kişilere de ihtiyacımız var. [Açık sorunlar](https://github.com/ohmyzsh/ohmyzsh/issues) arasında göz atıp yardımcı olabilirsiniz.

Daha fazla ayrıntı için [Katkıda Bulunma](CONTRIBUTING.md) belgesine bakınız.

### Bize Tema Göndermeyin

Şimdilik (hatta fazlasıyla) yeterli temamız var. Lütfen temanızı [harici temalar](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) wiki sayfasına ekleyin.

## Katkıda Bulunanlar

Oh My Zsh, mutlu kullanıcıları ve harika katkıda bulunanlarıyla canlı bir topluluğa sahiptir. Katkıda bulunanların zamanı ve desteği olmasaydı, bu kadar harika olmazdı.

Çok teşekkürler!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## Bizi Takip Edin

Sosyal medyadayız:

- X'te (eski adıyla Twitter) [@ohmyzsh](https://x.com/ohmyzsh). Takip etmelisiniz.
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) bize dokunun.
- [Instagram](https://www.instagram.com/_ohmyzsh/) gönderinizde Oh My Zsh göstererek bizi etiketleyin!
- [Discord](https://discord.gg/ohmyzsh) ile bizimle sohbet edin!

## Ürünler

[Oh My Zsh sevginizi gösterebileceğiniz çıkartmalar, tişörtler ve kahve kupaları](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github) mevcuttur. Yine, herkesin diline düşeceksiniz!

## Lisans

Oh My Zsh, [MIT lisansı](LICENSE.txt) ile yayınlanmıştır.

## Planet Argon Hakkında

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh, [Planet Argon](https://www.planetargon.com/?utm_source=github) ekibi tarafından başlatılmıştır; bir [Ruby on Rails geliştirme ajansı](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github).
[Diğer açık kaynak projelerimize](https://www.planetargon.com/open-source?utm_source=github) göz atın.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---