
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 💻 Docker Konteynerinde Windows
Vagrant VM, libvirt ve docker-compose'un gücünü kullanarak Windows işletim sistemini (x64) linux sisteminizde dağıtmanın yenilikçi ve verimli bir yolunu keşfedin. Bu teknolojiler birlikte, Windows işletim sistemini konteynerleştirmenize olanak tanır ve bir Docker konteynerini yönetir gibi bir Windows örneğini yönetmenizi sağlar. Mevcut iş akışlarına sorunsuz entegrasyon, kolaylığı önemli ölçüde artırır ve kaynak tahsisini optimize eder.

⭐ **Size yardımcı olduysa projeyi yıldızlamayı unutmayın!**

## 📋 Ön Koşullar

Sisteminizin aşağıdaki gereksinimleri karşıladığından emin olun:

- **Docker:** Sürüm 20 veya üstü [(Docker'ı Yükle)](https://www.docker.com/)

- **Host İşletim Sistemi:** Linux

- **Sanallaştırma Etkin:**
  - Kontrol etmek için:
    - `lscpu | grep -i Virtualization`
  - Çıktı gösterir:
    - `VT-x` → Intel sanallaştırma destekleniyor ve etkin.
    - `AMD-V` → AMD sanallaştırma destekleniyor ve etkin.
  - Sanallaştırma etkin değilse, BIOS/UEFI ayarlarında etkinleştirin.

- **`cgroup: host`** compose dosyasında gereklidir: libvirt ve başlattığı daemonlar tam cgroup erişimine ihtiyaç duyar, aksi takdirde container cgroup v2 hostlarında başlatılamaz.

## 🚀 Dağıtım Rehberi

1. Ortam dosyasını `.env` oluşturun/güncelleyin
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. `docker-compose.yml` dosyasını oluşturun
```yaml
services:
  win10:
    image: docker.io/vaggeliskls/windows-in-docker-container:latest
    platform: linux/amd64
    env_file: .env
    stdin_open: true
    tty: true
    privileged: true
    cgroup: host
    restart: always
    ports:
      - 3389:3389
      - 2222:2222
```
3. VM'nizin kalıcı olmasını istediğinizde `docker-compose.override.yml` oluşturun
```yaml
services:
  win10:
    volumes:
      - libvirt_data:/var/lib/libvirt
      - vagrant_data:/root/.vagrant.d
      - vagrant_project:/app/.vagrant
      - libvirt_config:/etc/libvirt

volumes:
  libvirt_data:
    name: libvirt_data
  vagrant_data:
    name: vagrant_data
  vagrant_project:
    name: vagrant_project
  libvirt_config:
    name: libvirt_config
```
4. Çalıştırın: `docker compose up -d`

> **İlk başlatma birkaç dakika sürer** — Vagrant kutusu zaten imaja gömülüdür, ancak VM yine de başlatılmalı ve hazırlama betiği (Chocolatey kurulumu, disk boyutlandırma, kayıt defteri düzenlemeleri) çalıştırılmalıdır. İlerlemesini `docker compose logs -f` ile takip edin.

> Her şeyi yok etmek istediğinizde `docker compose down -v` kullanın

![windows ekran görüntüsü](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 Erişim  

### Uzak Masaüstü (RDP)  
Hata ayıklama veya test için, VM'ye **Uzak Masaüstü** üzerinden `3389` portunu kullanarak bağlanabilirsiniz.  

#### Uzak Masaüstü Erişimi için Yazılım  
| İşletim Sistemi | Yazılım |
|-----------------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` veya [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | Dahili **Uzak Masaüstü Bağlantısı** |

---

### SSH   
SSH ile **administrator** veya **Vagrant** kullanıcı kimlik bilgileriyle bağlanabilirsiniz.

```bash
ssh <user>@<host> -p 2222
```

## 🔑 Kullanıcı Girişi
Vagrant imajına dayalı varsayılan kullanıcılar şunlardır:

1. Yönetici
    - Kullanıcı adı: Administrator
    - Parola: vagrant
2. Kullanıcı
    - Kullanıcı adı: vagrant
    - Parola: vagrant

## ⚠️ Sınırlamalar

- **Sadece Linux ana makine** — `/dev/kvm` ve libvirt'e bağlıdır; macOS ve Windows ana makineler desteklenmez.
- **Değerlendirme lisansı** — ilgili kutu, Windows Server 2022'nin bir değerlendirme kopyası ile gelir. Aktivasyon süresi Microsoft'un değerlendirme koşullarına tabidir.
- **Senkronize klasör yok** — `rsync`, `smb` ve `nfs` [Vagrantfile](Vagrantfile) dosyasında etkin değildir (rsync'in çalışabilmesi için Windows tarafında kurulum gerekir; SMB senkronize klasörler Linux ana makinede desteklenmez; konteyner içi NFS ise `mevcut çekirdekte desteklenmiyor` hatası verir).
- **Performans** — Docker için iç içe KVM mevcut değilse (ör. KVM'yi açığa çıkarmayan bir bulut VM üzerinde), misafir sistem doğrudan QEMU'ya düşer ve birkaç kat daha yavaş çalışır.

## 🔧 Sorun Giderme

- Günlüklerde **`KVM hızlandırması kullanılamıyor`** → ana makine `/dev/kvm`'yi açığa çıkarmıyor. BIOS'ta sanallaştırmanın etkin olduğunu, `kvm` modülünün yüklü olduğunu (`lsmod | grep kvm`), ve ana makinede `/dev/kvm` bulunduğunu kontrol edin. Başlatma betiği otomatik olarak QEMU'ya geri döner; ciddi bir yavaşlama bekleyin.
- **3389 / 2222 portu zaten kullanılıyor** → ana makinede başka bir RDP/SSH servisi bağlı. Onu durdurun ya da `docker-compose.yml` içindeki ana makine port eşlemesini değiştirin.
- **Konteyner hemen kapanıyor** → neredeyse her zaman bir cgroup veya ayrıcalık sorunudur. `privileged: true` ve `cgroup: host` ayarlandığını doğrulayın, ardından `docker compose logs win10` ile kontrol edin.
- **`vagrant up` "Domain'in IP adresi alması bekleniyor"da takılı kalıyor** → libvirt'in varsayılan NAT ağı çalışmıyor. Konteyneri yeniden başlatın ya da içinden `virsh net-start default` komutunu çalıştırın.

## 📚 Daha Fazla Okuma ve Kaynaklar

- [Windows Vagrant Eğitimi](https://github.com/SecurityWeekly/vulhub-lab)
- [Vagrant imajı: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [HashiCorp tarafından Vagrant](https://www.vagrantup.com/)
- [Linux Docker Konteynerinde Windows Sanal Makinesi](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [Konteynerde GPU kullanımı](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---