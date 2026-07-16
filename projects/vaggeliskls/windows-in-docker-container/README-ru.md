
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
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

# 💻 Windows в Docker-контейнере
Откройте для себя инновационный и эффективный способ развертывания ОС Windows (x64) на вашей системе Linux с помощью мощи Vagrant VM, libvirt и docker-compose. Эти технологии позволяют контейнеризировать Windows OS, что дает возможность управлять экземпляром Windows так же, как любым контейнером Docker. Такое бесшовное внедрение в существующие рабочие процессы значительно повышает удобство и оптимизирует распределение ресурсов.

⭐ **Не забудьте поставить звезду проекту, если он был вам полезен!**

## 📋 Необходимые условия

Убедитесь, что ваша система соответствует следующим требованиям:

- **Docker:** Версия 20 или выше [(Установить Docker)](https://www.docker.com/)

- **ОС хоста:** Linux

- **Виртуализация включена:**
  - Проверить с помощью:
    - `lscpu | grep -i Virtualization`
  - Результат показывает:
    - `VT-x` → Виртуализация Intel поддерживается и включена.
    - `AMD-V` → Виртуализация AMD поддерживается и включена.
  - Если виртуализация не включена, включите её в настройках BIOS/UEFI.

- В файле compose требуется **`cgroup: host`**: libvirt и его демоны требуют полного доступа к cgroup, иначе контейнер не запускается на хостах с cgroup v2.

## 🚀 Руководство по развертыванию

1. Создайте или обновите файл переменных окружения `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. Создайте `docker-compose.yml`
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
3. Создайте `docker-compose.override.yml`, если вы хотите, чтобы ваша виртуальная машина была постоянной
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
4. Запустите: `docker compose up -d`

> **Первый запуск занимает несколько минут** — Vagrant box уже включён в образ, но виртуальная машина всё равно должна загрузиться и выполнить скрипт настройки (установка Chocolatey, изменение размера диска, правки реестра). Следите за процессом с помощью `docker compose logs -f`.

> Когда захотите удалить всё: `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 Доступ  

### Удалённый рабочий стол (RDP)  
Для отладки или тестирования вы можете подключиться к ВМ с помощью **Удалённого рабочего стола** на порту `3389`.  

#### Программы для доступа через удалённый рабочий стол  
| ОС       | Программа |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` или [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | Встроенное приложение **Подключение к удалённому рабочему столу** |

---

### SSH   
Вы можете подключиться по SSH, используя учётные данные пользователя **administrator** или **Vagrant**.  

```bash
ssh <user>@<host> -p 2222
```

## 🔑 Вход пользователя
Пользователи по умолчанию на основе образа Vagrant:

1. Администратор
    - Имя пользователя: Administrator
    - Пароль: vagrant
2. Пользователь
    - Имя пользователя: vagrant
    - Пароль: vagrant

## ⚠️ Ограничения

- **Только Linux-хост** — зависит от `/dev/kvm` и libvirt; хосты на macOS и Windows не поддерживаются.
- **Пробная лицензия** — базовый образ содержит ознакомительную копию Windows Server 2022. Активация истекает согласно условиям Microsoft eval.
- **Нет синхронизированных папок** — `rsync`, `smb` и `nfs` отключены в [Vagrantfile](Vagrantfile) (rsync требует установки на стороне Windows до начала подготовки; синхронизация папок SMB не поддерживается с Linux-хоста; NFS внутри контейнера вызывает ошибку `no support in current kernel`).
- **Производительность** — без поддержки nested KVM для Docker (например, на облачной VM без KVM) гость переключается на обычный QEMU и работает в несколько раз медленнее.

## 🔧 Устранение неисправностей

- **`KVM acceleration is not available`** в логах → хост не предоставляет `/dev/kvm`. Проверьте, включена ли виртуализация в BIOS, загружен ли модуль `kvm` (`lsmod | grep kvm`), и существует ли `/dev/kvm` на хосте. Скрипт запуска автоматически переключается на QEMU; ожидайте значительного снижения скорости.
- **Порт 3389 / 2222 уже используется** → другой сервис RDP/SSH занят на хосте. Остановите его или измените привязку порта на стороне хоста в `docker-compose.yml`.
- **Контейнер завершается сразу** → почти всегда проблема с cgroup или привилегиями. Убедитесь, что установлены `privileged: true` и `cgroup: host`, затем проверьте `docker compose logs win10`.
- **`vagrant up` зависает на "Waiting for domain to get an IP address"** → стандартная NAT-сеть libvirt не запущена. Перезапустите контейнер или выполните `virsh net-start default` внутри него.

## 📚 Дополнительные материалы и ресурсы

- [Учебник по Windows Vagrant](https://github.com/SecurityWeekly/vulhub-lab)
- [Vagrant-образ: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant от HashiCorp](https://www.vagrantup.com/)
- [Виртуальная машина Windows в контейнере Linux Docker](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU внутри контейнера](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---