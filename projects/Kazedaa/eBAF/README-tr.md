# eBAF - eBPF Tabanlı Reklam Güvenlik Duvarı
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF Reklam Güvenlik Duvarı Bannerı" width="600"/>
</p>

## "Bir Reklamı İndirmezdin"
### Ama Birini Engelleyebilirsin!

Spotify basit bir formül üzerine bir imparatorluk kurdu: Dikkatini paraya çevir, sanatçılara hak ettiklerinden az öde ve sana kendi zamanını bir premium özellik olarak tekrar sat.
Onların dünyasında, dinleme deneyimi senin değildir. Bu, özenle düzenlenmiş bir pazardır — kulakların ürün, sabrın ise para birimidir.

Buna "ücretsiz" bir katman demeyi seviyorlar.
Ama dürüst olalım: Zamanınla ödüyorsan, bu ücretsiz değildir.

Bu arada, sevdiğin sanatçılar — platformu ayakta tutan insanlar — genellikle her dinlemeden kuruşun bile altında kazanıyor. Spotify büyük kârlar elde ediyor, reklamverenler istedikleri görünürlüğü alıyor ve yaratıcılar mı? Onlar ise kırıntılarla yetiniyor.

Bu sadece birkaç sinir bozucu reklamı atlamakla ilgili değil.
Bu, sömürüden, dikkatin dağılmasından ve dikkatin ürünleştirilmesinden kâr eden bir sisteme katılmayı reddetmekle ilgili.

#### Bu nedir?
Dijital direnişin zarif bir küçük eylemi: Gürültüyü gerçekten durduran, temiz, açık kaynaklı bir Spotify reklam engelleyici.

Ne şüpheli modlar, ne kırılmış istemciler, ne de özgürlük kisvesi altında gizlenmiş zararlı yazılımlar. Sadece tek bir amaç: Müzik çalsın, reklamların esiri olmadan.

Spotify ücretsiz değil — sabrınızla ödüyorsunuz.

Size aynı rahatsız edici reklamları, tekrar tekrar dayatıyorlar, ta ki pes edip abone olana kadar. Çünkü Premium’u sevdiğinizden değil. Ama yıprandığınızdan. Bu freemium değil — bu, çalma listesiyle psikolojik savaş.

Peki ya sanatçılar? Hâlâ az ücret alıyorlar.
Reklamlar? Daha yüksek sesli. Daha sık. Bazen kelimenin tam anlamıyla daha yüksek sesli.
Siz? Sadece keyif almaya çalışıyorsunuz.

Sabrınızdan ve içerik üreticilerine az ödeme yapmaktan kâr ediyorlar, hem de bunun tek sürdürülebilir yolmuş gibi davranarak. Sürpriz: Değil. Bir seçenekleri vardı — ama insanlardan çok kâr marjını seçtiler.

Spotify bunun erişim bedeli olduğuna sizi inandırmak istiyor.
Biz bunun bir yalan olduğuna inanıyoruz.

Biz korsan değiliz. Suçlu da değiliz. Sadece sınır çizebileceğini düşünen insanlarız.

Bu proje birkaç reklamı atlamak için değil. Bu, sessizliğinizin satılabileceğini, deneyiminizin bölünebileceğini ve değerinize ancak cüzdanınızı açınca başlanabileceğini söyleyen bir sistemi reddetmek için.

Reklam engellemek hırsızlık değildir.<br>
Zamanınızı çalmak ise öyledir.<br>
Burada korsanlık yapmak için değil, vazgeçmek için varız.<br>
<br>
**Bir Reklamı İndirmezdiniz. Ama birini engellersiniz.**
## eBAF nasıl çalışır?

eBAF (eBPF Reklam Güvenlik Duvarı), istenmeyen reklamları çekirdek seviyesinde engellemek için eBPF'nin (Genişletilmiş Berkeley Paket Filtresi) gücünden yararlanır. İşte işlevselliğinin yüksek seviyede bir özeti:

## eBAF nasıl çalışır?

eBAF (eBPF Reklam Güvenlik Duvarı), reklamları çekirdek seviyesinde verimli bir şekilde engellemek için eBPF'yi (Genişletilmiş Berkeley Paket Filtresi) kullanır. İşte basitleştirilmiş bir genel bakış:

1. **Paket Filtreleme**:
   - Gelen ağ paketlerini inceler ve XDP (eXpress Data Path) kullanarak kara listedeki IP adresleriyle eşleşenleri engeller.

2. **Dinamik Güncellemeler**:
   - Alan adlarını IP adreslerine çözümler ve kara listeyi dinamik olarak güncelleyerek değişen reklam sunucularına karşı etkili kalır.

3. **Web Gösterge Paneli**:
   - Kullanıcı dostu bir arayüz üzerinden canlı istatistikler ve izleme sağlar.

4. **Yüksek Performans**:
   - Doğrudan ağ arabiriminde çalışır, çekirdeğin ağ yığını atlanarak daha hızlı işleme ve minimum kaynak kullanımı sağlar.

eBAF, verimlilik, şeffaflık ve kullanım kolaylığını birleştirerek güçlü bir reklam engelleme çözümü sunar.
## Basit Kurulum (Tavsiye Edilen)
Git ve curl'un yüklü olduğundan emin olun
```bash
git --version
curl --version
```
### Kurulum
#### Spotify entegrasyonunu etkinleştir (Tavsiye Edilen)
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### Açıkça devre dışı bırak
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash```
```

### Kaldırma
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## Geliştirici Kurulumu
Gerekli bağımlılıkları yüklemek için aşağıdaki komutları çalıştırın:
### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### eBPF kodunu çalıştırırken asm/types.h Hatasını Düzeltme
Mevcut bağlantıyı kontrol edin
`ls -l /usr/include/asm`
Doğru bağlantıyı bulun
`find /usr/include -name "types.h" | grep asm`
Sembolik bağlantıyı düzeltin
```bash
sudo rm /usr/include/asm
sudo ln -s <current_link> /usr/include/asm
```

### Projenin Derlenmesi

eBPF Adblocker'ı derlemek için şu adımları izleyin:

1. Depoyu klonlayın:
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. Projeyi derleyin:
   ```bash
   make
   ```

3. (Opsiyonel) Sisteme genel kurulum:
   ```bash
   sudo make install
   ```

4. Diğer kurulum seçenekleri (yardım masası)
    ```bash
    make help
    ````
5. Kaldırma (UnInstall)
    ```bash
    make uninstall
    ````

## Kullanım

### Reklam Engelleyiciyi Çalıştırma
    Varsayılan Kara Liste olarak spotify-stable.txt dosyasını kullanır.
    Kullanım: ebaf [SEÇENEKLER] [ARAYÜZ...]
    SEÇENEKLER:
    -a, --all               Tüm aktif arayüzlerde çalıştır
    -d, --default           Yalnızca varsayılan arayüzde çalıştır (internet erişimi olan)
    -i, --interface IFACE   Kullanılacak bir arayüz belirt
    -D, --dash              Web kontrol panelini başlat (http://localhost:8080)
    -q, --quiet             Çıktıyı bastır (sessiz mod)
    -h, --help              Bu yardım mesajını göster


### Kara Listeyi Yapılandırma
Listeye alan adı eklemek veya çıkarmak için düzenleyin. Her alan adı ayrı bir satırda olmalıdır. Yorumlar `#` ile başlar.

## Teşekkürler

Özel teşekkürler ❤️ <br>
1. [Isaaker's Spotify-AdsList](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [AnanthVivekanand's spotify-adblock](https://github.com/AnanthVivekanand/spotify-adblock)

Spotify engelleme listesi sağladıkları için
## ⭐️ Projeyi Destekleyin

eBAF’ı faydalı buluyorsanız, lütfen GitHub’daki depoya yıldız vermeyi düşünün! Desteğiniz, görünürlüğün artmasına ve daha fazla geliştirme yapılmasına yardımcı olur.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---