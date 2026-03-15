
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# SimpleLogin

Bu, [SimpleLogin](https://simplelogin.io) için kendi barındırılan bir docker-compose yapılandırmasıdır.

## Önkoşullar

- Bir Linux sunucusu (VM veya özel sunucu olabilir). Bu doküman Ubuntu 18.04 LTS için kurulum adımlarını gösterir fakat adımlar diğer popüler Linux dağıtımlarına uyarlanabilir. Bileşenlerin çoğu Docker konteyneri olarak çalıştığından ve Docker biraz ağır olabileceğinden, en az 2 GB RAM önerilir. Sunucunun 25 (e-posta), 80, 443 (web uygulaması için), 22 (ssh ile bağlanabilmeniz için) portlarının açık olması gerekmektedir.

- DNS'ini yapılandırabileceğiniz bir alan adı. Bu bir alt alan adı da olabilir. Belgenin geri kalanında, e-posta için `mydomain.com` ve SimpleLogin web uygulaması için `app.mydomain.com` kullanalım. Belgede bu değerler geçtiğinde lütfen kendi alan adınız ve alt alan adınız ile değiştirin. Kullandığımız bir yöntem, bu README dosyasını bilgisayarınıza indirip tüm `mydomain.com` ve `app.mydomain.com` ifadelerini kendi alan adınızla değiştirmektir.

Genellikle alan adı kayıt şirketinizin arayüzünde yapılan DNS kurulumu haricinde, aşağıdaki tüm adımlar sunucunuzda yapılacaktır. Komutlar, shell olarak `bash` (veya `zsh` gibi bash-uyumlu bir kabuk) ile çalıştırılmalıdır. Eğer `fish` gibi başka kabuklar kullanıyorsanız, lütfen komutları uyarlayın.

- Kurulumu doğrulamak için kullanılan bazı yardımcı paketler. Bunları şu şekilde yükleyin:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## DNS Yapılandırması

_Daha fazla ayrıntı için [referans dokümantasyonuna](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration) bakınız_

> **Lütfen dikkat edin** DNS değişikliklerinin yayılması 24 saate kadar sürebilir. Pratikte ise çok daha hızlıdır (~1 dakika kadar bizim testimizde). DNS kurulumunda genellikle alan adının sonuna nokta (`.`) ekleyerek mutlak alan adı kullanımını zorunlu kılarız.

Aşağıdaki DNS kayıtlarını yapılandırmanız gerekecek:

- **A**: Alan adınızı sunucunuzun IPv4 adresine yönlendirir.
- **AAAA**: Alan adınızı sunucunuzun IPv6 adresine yönlendirir.
- **MX**: Gelen e-postaları mail sunucunuza yönlendirir (`*` joker karakterler dahil).
- **PTR**: Sunucunuzun IP adresini tekrar alan adına yönlendirir.

Zorunlu güvenlik politikalarını kurun:

- **DKIM**: Çıkan e-postaları dijital olarak imzalayarak doğruluğu teyit eder.
- **DMARC**: E-posta alıcılarının kimlik doğrulaması başarısız olan mesajları nasıl işleyeceğini belirler.
- **SPF**: Belirli mail sunucularının alan adınızdan e-posta göndermesine izin verir.

Ek adımlar:

- **CAA**: Alan adınız için SSL sertifikası düzenleyebilecek sertifika otoritelerini belirtir.
- **MTA-STS**: Mail sunucuları arasında güvenli, şifreli bağlantıları zorunlu kılar.
- **TLS-RPT**: E-posta teslim güvenliğini artırmak için TLS bağlantı hatalarını raporlar.

**Uyarı**: CAA kaydı oluşturmak, alan adınız için SSL sertifikası düzenleyebilecek sertifika otoritelerini sınırlar.
Bu, Let’s Encrypt deneme sunucularından sertifika düzenlenmesini engeller. Bu DNS kaydını, alan adınız için SSL sertifikaları başarıyla düzenlendikten sonra eklemek isteyebilirsiniz.

## Docker

Sunucunuzda Docker henüz kurulu değilse, [Ubuntu için Docker CE](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) adımlarını takip ederek Docker’ı kurabilirsiniz.

Docker’ı ayrıca [docker-install](https://github.com/docker/docker-install) scriptini kullanarak da

```bash
curl -fsSL https://get.docker.com | sh
```

Varsayılan köprü ağı için IPv6'yı etkinleştir [the default bridge network](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```

Bu prosedür, tüm yığını Docker konteynerleri kullanarak çalıştırmanız için size rehberlik edecektir.
Bu şunları içerir:

- traefik
- [SimpleLogin uygulaması](https://github.com/simple-login/app) konteynerleri
- postfix

SimpleLogin'ı Docker konteynerlerinden çalıştırın:

1. Bu depoyu `/opt/simplelogin` dizinine klonlayın
1. `.env.example` dosyasını `.env` olarak kopyalayın ve uygun değerleri ayarlayın.

    - `DOMAIN` değişkenini kendi domain’inize ayarlayın.
    - `SUBDOMAIN` değişkenini domain’inize ayarlayın. Varsayılan değer `app`'tir.
    - `POSTGRES_USER` değişkenini postgres kimlik bilgileriyle eşleştirin (sıfırdan başlıyorsanız `simplelogin` kullanın).
    - `POSTGRES_PASSWORD` değişkenini postgres kimlik bilgileriyle eşleştirin (sıfırdan başlıyorsanız rastgele bir anahtar belirleyin).
    - `FLASK_SECRET` değişkenini rastgele bir gizli anahtara ayarlayın.

### Postgres SQL

Bu depo, bir Docker konteynerinde postgres SQL çalıştırır.

**Uyarı**: bu deponun önceki sürümleri `12.1` sürümünü çalıştırıyordu.
Daha fazla detay ve yükseltme talimatları için lütfen [referans dokümantasyonuna](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) bakınız.

### Uygulamayı çalıştırmak

Uygulamayı aşağıdaki komutlarla çalıştırın:


```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```

Bu noktada [Sertifika Yetkilisi Yetkilendirmesi (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) kurmak isteyebilirsiniz.

## Sonraki adımlar

Yukarıdaki adımların hepsi başarılı olduysa, <https://app.mydomain.com/> adresini açın ve ilk hesabınızı oluşturun!

Varsayılan olarak, yeni hesaplar premium değildir, bu yüzden sınırsız takma adları yoktur. Hesabınızı premium yapmak için,
lütfen veritabanında "users" tablosuna gidin ve "lifetime" sütununu "1" veya "TRUE" olarak ayarlayın:

```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

İstediğiniz tüm giriş hesaplarını oluşturduktan sonra, daha fazla kayıt yapılmasını engellemek için `.env` dosyasına şu satırları ekleyin:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```

Daha sonra, web uygulamasını yeniden başlatmak için şunu uygulayın: `docker compose restart app`

## Çeşitli

### Postfix yapılandırması - Spamhaus

Spamhaus Projesi, SPAM kaynağı olduğu bilinen IP adreslerinin güvenilir bir listesini tutar.
Belirli bir IP adresinin bu listede olup olmadığını DNS altyapısına sorgu göndererek kontrol edebilirsiniz.

Spamhaus, herkese açık (open) DNS-Çözücülerinden gelen sorguları engellediğinden (bkz: <https://check.spamhaus.org/returnc/pub>) ve postfix konteyneriniz varsayılan olarak
herkese açık bir çözücü kullanabileceğinden, ücretsiz
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/) (DQS) hizmetine kaydolmanız ve bir Spamhaus DQS anahtarı almanız önerilir.

Bu anahtarı `.env` dosyanıza `SPAMHAUS_DQS_KEY` olarak yapıştırın.

Herhangi bir DQS anahtarı sağlanmazsa, postfix konteyneriniz Spamhaus genel aynalarının sorgularını kabul edip etmediğini kontrol edecek ve onları kullanacaktır.
Spamhaus, postfix konteynerinizden gelen sorguları genel aynalarda reddederse, tamamen devre dışı bırakılacaktır.

### Postfix yapılandırması - Sanal takma adlar

Postfix yapılandırması, `postfix/conf.d/virtual` ve `postfix/conf.d/virtual-regexp` dosyalarını kullanarak sanal takma adları destekler.
Bu dosyalar, karşılık gelen [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
ve [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl) şablon dosyalarına dayanarak başlatma sırasında otomatik olarak oluşturulur.

Varsayılan yapılandırma aşağıdaki gibidir:

#### virtual.tpl

`virtual` dosyası, postfix `virtual_alias_maps` ayarlarını destekler.
Bu dosyada, `unknown@mydomain.com` adresini `contact@mydomain.com` adresine yönlendiren bir kural bulunur; bu, mevcut olmayan belirli bir adresten gelen bir
e-postanın, mevcut olan başka bir adrese alınmasını göstermek içindir.


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

`virtual-regexp` dosyası postfix `virtual_alias_maps` ayarlarını destekler.
Bu dosya, mevcut olmayan bir takma adla eşleşmeyen rastgele bir alt alan adına gönderilen e-postaları,
alt alan adından alınan isimdeki bir dizine ait yeni bir takma ada yönlendiren bir kural içerir.
Bu takma ad, mevcut değilse anında oluşturulabilir.

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

Örneğin, `someone@directory.mydomain.com` adresine gönderilen e-postalar postfix tarafından `directory/someone@mydomain.com` adresine yönlendirilir.

## 3.4.0 Sürümünden Nasıl Yükseltilir

_Bu bölüm [referans dokümantasyona](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl) taşınmıştır_

## Önceki NGinx tabanlı kurulumdan nasıl yükseltilir

_Bu bölüm [referans dokümantasyona](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx) taşınmıştır_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---