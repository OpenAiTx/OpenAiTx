<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

 DB yöneticileri ve geliştiriciler için özel olarak tasarlanmış, sorunsuz SQL tespiti ve sorgu denetimi için geliştirilmiş, güçlü ve yerel olarak dağıtılabilen bir platformdur. Gizlilik ve verimlilik odaklıdır; MYSQL denetimi için sezgisel ve güvenli bir ortam sağlar.

---
[![OSCS Durumu](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Desteği](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub en çok kullanılan dil](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![İndirmeler](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ Özellikler

- **AI Asistanı**: AI asistanımız, gerçek zamanlı SQL optimizasyon önerileri sunarak SQL performansını artırır. Ayrıca metinden SQL'e dönüşümü destekler ve kullanıcıların doğal dil girdilerini optimize edilmiş SQL ifadelerine dönüştürmesini sağlar.
  
- **SQL Denetimi**: Onay iş akışları ve otomatik sözdizimi kontrolleri ile SQL denetim talepleri oluşturun. SQL ifadelerini doğruluk, güvenlik ve uyumluluk açısından doğrulayın. DDL/DML işlemleri için geri alma ifadeleri otomatik olarak oluşturulur ve izlenebilirlik için kapsamlı bir geçmiş günlüğü sağlanır.

- **Sorgu Denetimi**: Kullanıcı sorgularını denetleyin, veri kaynaklarını ve veritabanlarını kısıtlayın, hassas alanları anonimleştirin. Sorgu kayıtları ileriye dönük referans için saklanır.

- **Kontrol Kuralları**: Otomatik sözdizimi kontrol aracımız, çoğu otomatik kontrol senaryosuna uygun çok çeşitli kontrol kurallarını destekler.

- **Gizlilik Odaklı**: Yearning, veritabanınızın ve SQL ifadelerinizin güvenliğini sağlayan, yerel olarak dağıtılabilen açık kaynaklı bir çözümdür. Hassas verileri korumak için şifreleme mekanizmaları içerir; böylece yetkisiz erişim olsa bile verileriniz güvenli kalır.

- **RBAC (Rol Tabanlı Erişim Kontrolü)**: Belirli izinlerle roller oluşturup yönetin; kullanıcı rolleri temelinde sorgu iş emirlerine, denetim işlevlerine ve diğer hassas işlemlere erişimi kısıtlayın.

> \[!TIP]
> Daha ayrıntılı bilgi için [Yearning Rehberi](https://next.yearning.io) sayfamızı ziyaret edin.


## ⚙️ Kurulum

[En son sürümü](https://github.com/cookieY/Yearning/releases/latest) indirin ve arşivden çıkarın. Devam etmeden önce `./config.toml` dosyasını yapılandırdığınızdan emin olun.

### Manuel Kurulum

```bash
## Veritabanını başlatın
./Yearning install

## Yearning'i başlatın
./Yearning run

## Yardım
./Yearning --help
```

### 🚀 Docker ile Dağıtım
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## Veritabanını başlatın
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Yearning'i başlatın
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 AI Yardımı

AI Asistanımız, SQL optimizasyon önerileri ve metinden SQL'e dönüşüm sağlamak için büyük bir dil modeli kullanır. Varsayılan veya özel istemler kullanılsa da, AI Asistanı SQL ifadelerini optimize ederek ve doğal dil girdilerini SQL sorgularına dönüştürerek SQL performansını artırır.

![Metinden SQL'e](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 Otomatik SQL Denetleyici

Otomatik SQL denetleyici, SQL ifadelerini önceden tanımlanmış kurallara ve sözdizimine göre değerlendirir. İfadelerin belirli kodlama standartlarına, en iyi uygulamalara ve güvenlik gereksinimlerine uygun olmasını sağlar ve sağlam bir doğrulama katmanı sunar.

![SQL Denetimi](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 SQL Sözdizimi Vurgulama ve Otomatik Tamamlama

SQL sözdizimi vurgulama ve otomatik tamamlama ile sorgu yazma verimliliğinizi artırın. Bu özellikler, kullanıcıların bir SQL sorgusunun anahtar sözcükler, tablo adları, sütun adları ve operatörler gibi farklı bileşenlerini görsel olarak ayırt etmesine yardımcı olarak sorgu yapısını okumayı ve anlamayı kolaylaştırır.

![SQL Sorgusu](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ Sipariş/Sorgu Kaydı

Platformumuz, kullanıcı sipariş ve sorgu ifadelerinin denetimini destekler. Bu özellik, veri kaynakları, veritabanları ve hassas alanların işlenmesi dahil olmak üzere tüm sorgu işlemlerini izlemenize ve kaydetmenize olanak tanır; böylece düzenlemelere uygunluk ve sorgu geçmişi için izlenebilirlik sağlanır.

![Sipariş/Sorgu Kaydı](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

Bu temel özelliklere odaklanarak Yearning, kullanıcı deneyimini geliştirir, SQL performansını optimize eder ve veritabanı işlemlerinde güçlü bir uyumluluk ve izlenebilirlik sağlar.

## 🛠️ Önerilen Araçlar

- [Spug - Açık Kaynak Hafif Otomasyon Operasyon Platformu](https://github.com/openspug/spug)

## ☎️ İletişim

Sorularınız için lütfen bize şu adresten e-posta gönderin: henry@yearning.io
## 📋 Lisans

Yearning, AGPL lisansı altında lisanslanmıştır. Ayrıntılar için [LICENSE](LICENSE) dosyasına bakınız.

2024 © Henry Yee

---

Yearning ile, SQL denetimi ve optimizasyonunda sadeleştirilmiş, güvenli ve verimli bir yaklaşım deneyimleyin.


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---