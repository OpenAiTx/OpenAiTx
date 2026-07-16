
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

# 💻 Windows w Kontenerze Docker
Odkryj innowacyjną i wydajną metodę wdrażania systemu Windows OS (x64) na swoim systemie Linux, wykorzystując moc Vagrant VM, libvirt oraz docker-compose. Technologie te pozwalają na konteneryzację systemu Windows OS, umożliwiając zarządzanie instancją Windowsa tak samo, jak każdym innym kontenerem Dockera. Ta bezproblemowa integracja z istniejącymi procesami znacznie zwiększa wygodę i optymalizuje wykorzystanie zasobów.

⭐ **Nie zapomnij oznaczyć projektu gwiazdką, jeśli okazał się pomocny!**

## 📋 Wymagania wstępne

Upewnij się, że Twój system spełnia następujące wymagania:

- **Docker:** Wersja 20 lub wyższa [(Zainstaluj Docker)](https://www.docker.com/)

- **System operacyjny hosta:** Linux

- **Włączona wirtualizacja:**
  - Sprawdź za pomocą:
    - `lscpu | grep -i Virtualization`
  - Wynik wskazuje:
    - `VT-x` → Wirtualizacja Intel jest obsługiwana i włączona.
    - `AMD-V` → Wirtualizacja AMD jest obsługiwana i włączona.
  - Jeśli wirtualizacja nie jest włączona, należy ją włączyć w ustawieniach BIOS/UEFI.

- **`cgroup: host`** w pliku compose jest wymagane: libvirt i uruchamiane przez niego demony potrzebują pełnego dostępu do cgroup, w przeciwnym razie kontener nie uruchomi się na hostach z cgroup v2.

## 🚀 Przewodnik wdrożeniowy

1. Utwórz/Zaktualizuj plik środowiskowy `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. Utwórz `docker-compose.yml`
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
3. Utwórz `docker-compose.override.yml`, gdy chcesz, aby Twoja maszyna wirtualna była trwała
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
4. Uruchom: `docker compose up -d`

> **Pierwsze uruchomienie zajmuje kilka minut** — Vagrant box jest już zawarty w obrazie, ale maszyna wirtualna musi się jeszcze uruchomić i wykonać skrypt provisioningowy (instalacja Chocolatey, powiększenie dysku, modyfikacje rejestru). Postęp można śledzić poleceniem `docker compose logs -f`.

> Jeśli chcesz wszystko usunąć `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 Dostęp  

### Pulpit zdalny (RDP)  
Do debugowania lub testowania możesz połączyć się z maszyną wirtualną przez **Pulpit zdalny** na porcie `3389`.  

#### Oprogramowanie do dostępu przez pulpit zdalny  
| System    | Oprogramowanie |
|-----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` lub [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | Wbudowany **Pulpit zdalny** |

---

### SSH   
Możesz połączyć się przez SSH używając danych użytkownika **administrator** lub **Vagrant**.  

```bash
ssh <user>@<host> -p 2222
```

## 🔑 Logowanie użytkownika
Domyślni użytkownicy na podstawie obrazu Vagrant to:

1. Administrator
    - Nazwa użytkownika: Administrator
    - Hasło: vagrant
2. Użytkownik
    - Nazwa użytkownika: vagrant
    - Hasło: vagrant

## ⚠️ Ograniczenia

- **Tylko host Linux** — zależne od `/dev/kvm` i libvirt; hosty macOS i Windows nie są obsługiwane.
- **Licencja ewaluacyjna** — bazowy box dostarcza kopię ewaluacyjną Windows Server 2022. Aktywacja wygasa zgodnie z warunkami ewaluacyjnymi Microsoftu.
- **Brak zsynchronizowanych folderów** — `rsync`, `smb` i `nfs` są wyłączone w [Vagrantfile](Vagrantfile) (rsync wymaga instalacji po stronie Windows przed uruchomieniem provisioning; SMB nie jest obsługiwany na hostach Linux; NFS w kontenerze zwraca `no support in current kernel`).
- **Wydajność** — jeśli Docker nie ma dostępu do zagnieżdżonego KVM (np. na chmurowej VM bez KVM), gość przechodzi na zwykły QEMU i działa kilkukrotnie wolniej.

## 🔧 Rozwiązywanie problemów

- **`KVM acceleration is not available`** w logach → host nie udostępnia `/dev/kvm`. Sprawdź, czy w BIOS włączona jest wirtualizacja, czy moduł `kvm` jest załadowany (`lsmod | grep kvm`), oraz czy `/dev/kvm` istnieje na hoście. Skrypt startowy automatycznie przechodzi na QEMU; spodziewaj się dużego spowolnienia.
- **Port 3389 / 2222 już używany** → inna usługa RDP/SSH jest powiązana z hostem. Zatrzymaj ją lub zmień mapowanie portu po stronie hosta w `docker-compose.yml`.
- **Kontener natychmiast się wyłącza** → prawie zawsze problem z cgroup lub uprawnieniami. Potwierdź, że ustawiono `privileged: true` i `cgroup: host`, następnie sprawdź `docker compose logs win10`.
- **`vagrant up` zawiesza się na "Waiting for domain to get an IP address"** → domyślna sieć NAT libvirt nie działa. Uruchom ponownie kontener lub wykonaj `virsh net-start default` wewnątrz niego.

## 📚 Dalsza lektura i zasoby

- [Windows Vagrant Tutorial](https://github.com/SecurityWeekly/vulhub-lab)
- [Obraz Vagrant: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant od HashiCorp](https://www.vagrantup.com/)
- [Windows Virtual Machine w kontenerze Docker na Linuxie](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU wewnątrz kontenera](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---