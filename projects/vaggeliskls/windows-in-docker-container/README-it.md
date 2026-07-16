
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

# 💻 Windows in Docker Container
Scopri un metodo innovativo ed efficiente per distribuire il sistema operativo Windows (x64) sul tuo sistema Linux utilizzando la potenza di Vagrant VM, libvirt e docker-compose. Insieme, queste tecnologie ti aiutano a containerizzare Windows OS, consentendoti di gestire un'istanza di Windows come qualsiasi altro container Docker. Questa integrazione senza soluzione di continuità nei flussi di lavoro esistenti migliora notevolmente la comodità e ottimizza l'allocazione delle risorse.

⭐ **Non dimenticare di mettere una stella al progetto se ti è stato utile!**

## 📋 Prerequisiti

Assicurati che il tuo sistema soddisfi i seguenti requisiti:

- **Docker:** Versione 20 o superiore [(Installa Docker)](https://www.docker.com/)

- **Host OS:** Linux

- **Virtualizzazione abilitata:**
  - Controlla con:
    - `lscpu | grep -i Virtualization`
  - L’output indica:
    - `VT-x` → La virtualizzazione Intel è supportata e abilitata.
    - `AMD-V` → La virtualizzazione AMD è supportata e abilitata.
  - Se la virtualizzazione non è abilitata, abilitala nelle impostazioni BIOS/UEFI.

- **`cgroup: host`** nel file compose è necessario: libvirt e i demoni che avvia hanno bisogno di pieno accesso ai cgroup, altrimenti il container non si avvia su host cgroup v2.

## 🚀 Guida alla Distribuzione

1. Crea/Aggiorna il file ambientale `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. Crea `docker-compose.yml`
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
3. Crea `docker-compose.override.yml` quando vuoi che la tua VM sia persistente
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

4. Esegui: `docker compose up -d`

> **Il primo avvio richiede diversi minuti** — la Vagrant box è già integrata nell'immagine, ma la VM deve ancora avviarsi ed eseguire lo script di provisioning (installazione di Chocolatey, ridimensionamento disco, modifiche al registro). Segui il progresso con `docker compose logs -f`.

> Quando vuoi distruggere tutto usa `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 Accesso  

### Desktop Remoto (RDP)  
Per il debug o i test, puoi collegarti alla VM usando **Desktop Remoto** sulla porta `3389`.  

#### Software per l'accesso Desktop Remoto  
| OS       | Software |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` oppure [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | **Connessione Desktop Remoto** integrata |

---

### SSH   
Puoi connetterti via SSH utilizzando le credenziali utente **administrator** o **Vagrant**.  
```bash
ssh <user>@<host> -p 2222
```

## 🔑 Accesso Utente
Gli utenti predefiniti basati sull'immagine Vagrant sono:

1. Amministratore
    - Nome utente: Administrator
    - Password: vagrant
2. Utente
    - Nome utente: vagrant
    - Password: vagrant

## ⚠️ Limitazioni

- **Solo host Linux** — dipende da `/dev/kvm` e libvirt; host macOS e Windows non sono supportati.
- **Licenza Eval** — la box di base fornisce una copia di valutazione di Windows Server 2022. L'attivazione scade secondo i termini di valutazione Microsoft.
- **Nessuna cartella sincronizzata** — `rsync`, `smb` e `nfs` sono tutte disabilitate nel [Vagrantfile](Vagrantfile) (rsync richiede un'installazione lato Windows prima dell'esecuzione del provisioning; le cartelle sincronizzate SMB non sono supportate con un host Linux; l'NFS in-container restituisce `no support in current kernel`).
- **Prestazioni** — senza KVM annidato disponibile per Docker (ad esempio su una VM cloud che non espone KVM), l'ospite ricade su QEMU semplice ed è diverse volte più lento.

## 🔧 Risoluzione dei Problemi

- **`KVM acceleration is not available`** nei log → l'host non espone `/dev/kvm`. Verifica che la virtualizzazione sia abilitata nel BIOS, che il modulo `kvm` sia caricato (`lsmod | grep kvm`) e che `/dev/kvm` esista sull'host. Lo script di avvio ricade automaticamente su QEMU; aspettati un forte rallentamento.
- **Porta 3389 / 2222 già in uso** → un altro servizio RDP/SSH è in ascolto sull'host. Arrestalo, oppure modifica l'associazione delle porte lato host in `docker-compose.yml`.
- **Il container si chiude immediatamente** → quasi sempre un problema di cgroup o privilegi. Conferma che `privileged: true` e `cgroup: host` siano impostati, poi controlla `docker compose logs win10`.
- **`vagrant up` si blocca su "Waiting for domain to get an IP address"** → la rete NAT predefinita di libvirt non è attiva. Riavvia il container o esegui `virsh net-start default` dall'interno.

## 📚 Approfondimenti e Risorse

- [Windows Vagrant Tutorial](https://github.com/SecurityWeekly/vulhub-lab)
- [Immagine Vagrant: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant di HashiCorp](https://www.vagrantup.com/)
- [Macchina Virtuale Windows in un Container Docker Linux](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU all'interno di un container](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---