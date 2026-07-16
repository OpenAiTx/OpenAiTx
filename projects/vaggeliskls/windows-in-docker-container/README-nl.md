
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 💻 Windows in Docker Container
Ontdek een innovatieve en efficiënte methode om Windows OS (x64) op je Linux-systeem te implementeren met behulp van de kracht van Vagrant VM, libvirt en docker-compose. Samen helpen deze technologieën je om Windows OS te containeriseren, zodat je een Windows-instantie kunt beheren zoals elke andere Docker-container. Deze naadloze integratie in bestaande workflows verhoogt het gebruiksgemak en optimaliseert de resource-allocatie aanzienlijk.

⭐ **Vergeet niet het project te waarderen als het je geholpen heeft!**

## 📋 Vereisten

Zorg ervoor dat je systeem aan de volgende eisen voldoet:

- **Docker:** Versie 20 of hoger [(Installeer Docker)](https://www.docker.com/)

- **Host-besturingssysteem:** Linux

- **Virtualisatie ingeschakeld:**
  - Controleer met:
    - `lscpu | grep -i Virtualization`
  - Uitvoer geeft aan:
    - `VT-x` → Intel-virtualisatie wordt ondersteund & is ingeschakeld.
    - `AMD-V` → AMD-virtualisatie wordt ondersteund & is ingeschakeld.
  - Als virtualisatie niet is ingeschakeld, schakel dit dan in via de BIOS/UEFI-instellingen.

- **`cgroup: host`** in het compose-bestand is vereist: libvirt en de daemons die het opstart hebben volledige cgroup-toegang nodig, anders kan de container niet starten op cgroup v2-hosts.

## 🚀 Implementatiehandleiding

1. Maak of werk het omgevingsbestand `.env` bij
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. Maak `docker-compose.yml`
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
3. Maak `docker-compose.override.yml` aan wanneer je wilt dat je VM persistent is
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

4. Voer uit: `docker compose up -d`

> **Eerste opstart duurt enkele minuten** — de Vagrant box is al ingebakken in het image, maar de VM moet nog opstarten en het provisioning script uitvoeren (Chocolatey installatie, schijf vergroten, registry aanpassingen). Volg de voortgang met `docker compose logs -f`.

> Wanneer je alles wilt vernietigen `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 Toegang  

### Remote Desktop (RDP)  
Voor debuggen of testen kun je verbinden met de VM via **Remote Desktop** op poort `3389`.  

#### Software voor Remote Desktop Toegang  
| OS       | Software |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` of [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | Ingebouwde **Remote Desktop Connection** |

---

### SSH   
Je kunt verbinden via SSH met de **administrator** of **Vagrant** gebruikersgegevens.  
```bash
ssh <user>@<host> -p 2222
```

## 🔑 Gebruikersinlog
Standaardgebruikers op basis van het Vagrant-image zijn:

1. Administrator
    - Gebruikersnaam: Administrator
    - Wachtwoord: vagrant
2. Gebruiker
    - Gebruikersnaam: vagrant
    - Wachtwoord: vagrant

## ⚠️ Beperkingen

- **Alleen Linux-host** — afhankelijk van `/dev/kvm` en libvirt; macOS- en Windows-hosts worden niet ondersteund.
- **Evaluatielicentie** — de onderliggende box bevat een evaluatie-exemplaar van Windows Server 2022. Activatie verloopt volgens de eval-voorwaarden van Microsoft.
- **Geen gesynchroniseerde mappen** — `rsync`, `smb` en `nfs` zijn allemaal uitgeschakeld in de [Vagrantfile](Vagrantfile) (rsync vereist een installatie aan Windows-zijde vóór provisioning; SMB gesynchroniseerde mappen worden niet ondersteund met een Linux-host; in-container NFS geeft `no support in current kernel`).
- **Prestaties** — zonder nested KVM beschikbaar voor Docker (bijv. op een cloud-VM die KVM niet aanbiedt), valt de gast terug op gewone QEMU en is aanzienlijk trager.

## 🔧 Probleemoplossing

- **`KVM acceleration is not available`** in logs → de host stelt `/dev/kvm` niet beschikbaar. Controleer of virtualisatie is ingeschakeld in het BIOS, het `kvm`-module geladen is (`lsmod | grep kvm`) en `/dev/kvm` bestaat op de host. Het opstartscript valt automatisch terug op QEMU; reken op flinke vertraging.
- **Poort 3389 / 2222 al in gebruik** → een andere RDP/SSH-service is aan de host gebonden. Stop deze, of wijzig de host-poortmapping in `docker-compose.yml`.
- **Container sluit direct af** → vrijwel altijd een cgroup- of privilegeprobleem. Controleer of `privileged: true` en `cgroup: host` zijn ingesteld, kijk daarna in `docker compose logs win10`.
- **`vagrant up` blijft hangen bij "Waiting for domain to get an IP address"** → het standaard NAT-netwerk van libvirt draait niet. Herstart de container, of voer `virsh net-start default` uit binnenin de container.

## 📚 Verdere documentatie en bronnen

- [Windows Vagrant Tutorial](https://github.com/SecurityWeekly/vulhub-lab)
- [Vagrant image: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant door HashiCorp](https://www.vagrantup.com/)
- [Windows Virtual Machine in een Linux Docker-container](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU binnen een container](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---