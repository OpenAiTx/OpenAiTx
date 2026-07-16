
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

# 💻 Windows im Docker-Container
Entdecken Sie eine innovative und effiziente Methode, das Windows-Betriebssystem (x64) auf Ihrem Linux-System mithilfe von Vagrant VM, libvirt und docker-compose bereitzustellen. Gemeinsam ermöglichen diese Technologien die Containerisierung von Windows OS, sodass Sie eine Windows-Instanz genauso verwalten können wie jeden anderen Docker-Container. Diese nahtlose Integration in bestehende Workflows erhöht die Benutzerfreundlichkeit erheblich und optimiert die Ressourcennutzung.

⭐ **Vergessen Sie nicht, dem Projekt einen Stern zu geben, wenn es Ihnen geholfen hat!**

## 📋 Voraussetzungen

Stellen Sie sicher, dass Ihr System die folgenden Anforderungen erfüllt:

- **Docker:** Version 20 oder höher [(Docker installieren)](https://www.docker.com/)

- **Host-Betriebssystem:** Linux

- **Virtualisierung aktiviert:**
  - Überprüfen mit:
    - `lscpu | grep -i Virtualization`
  - Die Ausgabe zeigt an:
    - `VT-x` → Intel-Virtualisierung wird unterstützt & ist aktiviert.
    - `AMD-V` → AMD-Virtualisierung wird unterstützt & ist aktiviert.
  - Falls Virtualisierung nicht aktiviert ist, im BIOS/UEFI aktivieren.

- **`cgroup: host`** in der Compose-Datei ist erforderlich: libvirt und die von ihm gestarteten Daemons benötigen vollständigen cgroup-Zugriff, sonst schlägt der Start des Containers auf cgroup v2 Hosts fehl.

## 🚀 Bereitstellungsanleitung

1. Erstellen/Aktualisieren Sie die Umgebungsdatei `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. Erstellen Sie `docker-compose.yml`
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
3. Erstellen Sie `docker-compose.override.yml`, wenn Sie möchten, dass Ihre VM persistent ist
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

4. Führen Sie aus: `docker compose up -d`

> **Der erste Start dauert mehrere Minuten** — die Vagrant-Box ist bereits im Image enthalten, aber die VM muss noch gebootet werden und das Provisioning-Skript ausführen (Chocolatey-Installation, Festplattenvergrößerung, Registry-Anpassungen). Den Fortschritt können Sie mit `docker compose logs -f` verfolgen.

> Wenn Sie alles zerstören möchten: `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 Zugriff  

### Remote Desktop (RDP)  
Zum Debuggen oder Testen können Sie sich per **Remote Desktop** über Port `3389` mit der VM verbinden.  

#### Software für Remote Desktop-Zugriff  
| OS       | Software |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` oder [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | Integrierte **Remotedesktopverbindung** |

---

### SSH   
Sie können sich via SSH entweder mit den Zugangsdaten des **Administrator**- oder **Vagrant**-Benutzers verbinden.  
```bash
ssh <user>@<host> -p 2222
```

## 🔑 Benutzeranmeldung
Standardbenutzer basierend auf dem Vagrant-Image sind:

1. Administrator
    - Benutzername: Administrator
    - Passwort: vagrant
2. Benutzer
    - Benutzername: vagrant
    - Passwort: vagrant

## ⚠️ Einschränkungen

- **Nur Linux-Host** — abhängig von `/dev/kvm` und libvirt; macOS- und Windows-Hosts werden nicht unterstützt.
- **Eval-Lizenz** — das zugrundeliegende Box-Image beinhaltet eine Evaluierungskopie von Windows Server 2022. Die Aktivierung läuft gemäß den Eval-Bedingungen von Microsoft ab.
- **Keine synchronisierten Ordner** — `rsync`, `smb` und `nfs` sind alle im [Vagrantfile](Vagrantfile) deaktiviert (rsync benötigt eine Installation auf der Windows-Seite bevor das Provisioning läuft; SMB-synchronisierte Ordner werden auf einem Linux-Host nicht unterstützt; NFS im Container schlägt fehl mit `no support in current kernel`).
- **Leistung** — ohne verfügbares Nested KVM für Docker (z.B. auf einer Cloud-VM, die KVM nicht bereitstellt), weicht der Gast auf reines QEMU aus und ist um ein Vielfaches langsamer.

## 🔧 Fehlerbehebung

- **`KVM acceleration is not available`** in den Logs → der Host stellt `/dev/kvm` nicht bereit. Prüfen Sie, ob die Virtualisierung im BIOS aktiviert ist, das `kvm`-Modul geladen ist (`lsmod | grep kvm`) und `/dev/kvm` auf dem Host existiert. Das Startskript weicht automatisch auf QEMU aus; mit deutlicher Verlangsamung ist zu rechnen.
- **Port 3389 / 2222 bereits belegt** → ein anderer RDP-/SSH-Dienst ist auf dem Host gebunden. Stoppen Sie diesen Dienst oder ändern Sie das Port-Mapping auf der Host-Seite in `docker-compose.yml`.
- **Container beendet sich sofort** → fast immer ein cgroup- oder Berechtigungsproblem. Bestätigen Sie, dass `privileged: true` und `cgroup: host` gesetzt sind, prüfen Sie dann `docker compose logs win10`.
- **`vagrant up` bleibt bei "Waiting for domain to get an IP address" hängen** → das Standard-NAT-Netzwerk von libvirt läuft nicht. Starten Sie den Container neu oder führen Sie `virsh net-start default` innerhalb des Containers aus.

## 📚 Weiterführende Literatur und Ressourcen

- [Windows Vagrant Tutorial](https://github.com/SecurityWeekly/vulhub-lab)
- [Vagrant-Image: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant von HashiCorp](https://www.vagrantup.com/)
- [Windows-VM in einem Linux Docker-Container](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU im Container](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---