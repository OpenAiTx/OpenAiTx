# TeamSpeak 6 Sunucusu - Beta Sürüm README

TeamSpeak 6 Sunucusunun Beta sürümüne hoş geldiniz! TeamSpeak'in bir sonraki neslini keşfederken aramızda olduğunuz için heyecanlıyız. Bu belge, başlamanıza yardımcı olacak ve mevcut Beta hakkındaki önemli ayrıntıları vurgulayacaktır.

Bu bir Beta sürüm olduğundan, bazı özellikler hâlâ geliştirilmektedir ve hatalarla karşılaşabilirsiniz. Geri bildiriminiz bizim için önemlidir ve daha istikrarlı ve eksiksiz bir nihai sürüm oluşturmamıza yardımcı olacaktır.

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;TeamSpeak Hakkında</h2>

Neredeyse 25 yıldır denenmiş ve test edilmiş olan çözümümüz, herkesin ihtiyacına uygun bir yapı sunmaktadır. TeamSpeak; oyun, eğitim ve öğretim, iç iş iletişimi ve arkadaşlar ile aileyle iletişimde ideal sesli iletişimi sağlar. Ana odağımız; kullanımı kolay, yüksek güvenlik standartlarına sahip, mükemmel ses kalitesi ve düşük sistem ile bant genişliği kullanımı sunan bir çözüm sağlamaktır.

## ℹ️ Beta Durumu & Bilinen Sorunlar
**Bu bir beta sürümdür. Ana hedef, çeşitli geri bildirimler toplamak ve kararlı sürüm yayınlanmadan önce olası sorunları belirlemektir.**

**Kendi Sunucunu Barındırma Dosyaları:** TeamSpeak 6 için özel sunucu yazılımı hâlâ aktif olarak geliştirilmektedir ve henüz tüm özellikleri tamamlanmamıştır. Kendi barındırılan sunucular için eksiksiz TS6 deneyimini sunmak konusunda kararlıyız.

**Özellik İstikrarsızlığı:** Yeni özelliklerin bazıları hâlâ kararsız olabilir veya geliştirme süreci devam ettikçe değişikliğe uğrayabilir.

**Geri Bildirim Çok Önemli:** Deneyiminiz bizim için çok değerli ve katkınız bizim için çok önemli. Herhangi bir sorun bildirir ya da önerilerinizi [Topluluk Forumumuzda](https://community.teamspeak.com/c/teamspeak-6-server/45) veya doğrudan [GitHub](https://github.com/teamspeak/teamspeak6-server/issues) üzerinden paylaşabilirsiniz.

**Kısıtlamalar:** Lütfen unutmayın ki **TeamSpeak 3 Sunucu lisansları TeamSpeak 6 Sunucuları ile uyumlu değildir** ve şu anda **iki sürüm arasında bir geçiş yolu bulunmamaktadır**.

**Önizleme Lisansı:** Geri bildirimleriniz doğrultusunda, sunucu artık **geçici** 32 slotluk bir önizleme lisansı ile gelmektedir ve değerlendirme süresi boyunca daha fazla esneklik sunar. Lütfen bu lisansın **sadece iki ay geçerli olduğunu** unutmayın.

Ayrıca, **şu anda TeamSpeak 6 için daha büyük bir lisans edinmek veya yükseltmek mümkün değildir.**

İhtiyaçlarınızı gelecekte daha iyi karşılayabilmek için üzerinde çalışmaya devam ettiğimiz çözümler konusunda sabrınız ve anlayışınız için gerçekten minnettarız.

## 👇 TS6 ile Başlarken
TeamSpeak 6 İstemcisine başlamak için lütfen [İndirme](https://teamspeak.com/en/downloads/) sayfamıza gidin.

Kendi sunucunuzu barındırma hakkında bilgi için aşağıdaki kısa rehbere göz atabilirsiniz. En son güncellemeler, duyurular ve TeamSpeak topluluğuyla iletişimde kalmak için [Topluluk Forumumuzu](https://community.teamspeak.com/) ziyaret etmeyi ve bizi [Twitter](https://x.com/teamspeak) üzerinden takip etmeyi unutmayın.

Kendi sunucunuzu barındırmak istemiyor veya TeamSpeak 6 ile başlamak için daha kolay bir yol mu arıyorsunuz? Güvenilir ve Resmi TeamSpeak 6 Sunucularını doğrudan [TeamSpeak Communities](https://www.myteamspeak.com/communities) üzerinden kiralayabilirsiniz.
## ⚙️ Yapılandırma
### Sunucunuzu üç ana şekilde yapılandırabilirsiniz:

1. **Komut Satırı Argümanları:** Sunucuyu başlatırken seçenekleri doğrudan iletebilirsiniz (örn. ./tsserver --default-voice-port 9987). Bu, geçici değişiklikler veya betiklerle kullanım için uygundur.

2. **Ortam Değişkenleri:** Sunucuyu başlatmadan önce ortam değişkenleri ayarlayın. Bu, Docker kullanırken veya komut satırı karmaşasından kaçınmak istediğinizde faydalıdır.

3. **YAML Yapılandırma Dosyası:** Kalıcı bir yapılandırma için, tsserver.yaml dosyası kullanmanız şiddetle tavsiye edilir. --write-config-file bayrağını kullanarak varsayılan bir yapılandırma dosyası oluşturabilirsiniz.

Kontrol edebileceğiniz temel ayarlar arasında ağ portları (ses, dosya aktarımı), veritabanı bağlantıları (SQLite ve MariaDB destekler), IP bağlamaları ve günlükleme seçenekleri yer alır.

Mevcut tüm seçeneklerin tam listesi için sunucuyu `--help` bayrağıyla çalıştırın veya [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md) dosyasına bakın.

### Sunucuyu İkili Dosyalar ile Çalıştırma
Docker kullanmıyorsanız, sunucuyu işletim sisteminizde doğrudan çalıştırabilirsiniz.

<h2><img width="22" src="/icons/linux.svg">&nbsp;Linux'ta:</h2>

Sunucu dosyasını çalıştırılabilir yapın:
```sh
chmod +x tsserver
```

Lisansı kabul ettiğinizden emin olarak sunucuyu terminalden çalıştırın:

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;Windows'ta:</h2>

Komut İstemcisi veya PowerShell'i açın ve sunucu dosyalarını çıkardığınız dizine gidin.

Sunucu uygulamasını çalıştırın ve lisansı kabul ettiğinizden emin olun:
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;Sunucuyu Docker ile Çalıştırmak (Tavsiye Edilen):</h2>
Docker, TeamSpeak 6 sunucusunu izole ve yönetilebilir bir ortamda çalıştırmanın en kolay yoludur.

### 1. Basit docker run komutu:

Hızlı başlamak için docker run komutunu kullanabilirsiniz.

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. docker-compose.yaml kullanımı (kalıcı kurulumlar için):
Sürekli çalışan bir sunucu için en iyi uygulamadır. Bir docker-compose.yaml dosyası oluşturun:

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # Ses Portu
      - "30033:30033/tcp" # Dosya Aktarımı
      # - "10080:10080/tcp" # Web Sorgu
    environment:
```
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumes:
  teamspeak-data:
```

## 🔗 Faydalı Bağlantılar
[Resmi Web Sitesi](https://teamspeak.com/en/)<br>
[Topluluk Forumu](https://community.teamspeak.com)<br>
[GitHub Sorunları](https://github.com/teamspeak/teamspeak6-server/issues)<br>

Katılımınız ve geri bildiriminiz, TeamSpeak'in geleceğini şekillendirmemize yardımcı olacak! 💙<br>
TeamSpeak 6 Beta programının bir parçası olduğunuz ve ilerlemesine katkıda bulunduğunuz için teşekkür ederiz! 🫡

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---