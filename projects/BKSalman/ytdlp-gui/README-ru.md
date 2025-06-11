# ytdlp-gui
Графический интерфейс для yt-dlp, написанный на Rust

- [Установка](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [другие дистрибутивы](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [Сборка из исходников](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [Конфигурация](https://github.com/BKSalman/ytdlp-gui#configuration)
- [Вклад в проект](https://github.com/BKSalman/ytdlp-gui#contribution)

# Просмотр
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# Установка
## Linux

### NixOS (Flake)
Вы можете использовать flake.nix из репозитория

в вашем `flake.nix`:
```nix
{
  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs/nixpkgs-unstable";

    ytdlp-gui = {
      url = "github:bksalman/ytdlp-gui";
    };
  };

    outputs = { nixpkgs, ytdlp-gui, ...}:
    let
      system = "x86_64-linux";

      pkgs = import nixpkgs {
        inherit system;
        overlays = [
          ytdlp-gui.overlay
        ];
      };
    in
    {
      ...snip
```

затем вы можете добавить его как обычный пакет, либо в ваш home-manager, либо в nixosConfiguration

### Fedora
скачайте rpm-пакет со страницы релизов, затем установите его с помощью ``sudo dnf localinstall <rpm_package_name>``

### Ubuntu
скачайте deb-пакет со страницы релизов, затем установите его с помощью ``sudo apt install ./<deb_package_name>``

### Arch

Доступен в AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### другие дистрибутивы

#### 1- скачайте ``yt-dlp``
либо

&nbsp; &nbsp; &nbsp; a- из репозитория вашего дистрибутива

&nbsp; &nbsp; &nbsp; b- либо скачайте [бинарник](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp), затем переместите его в ваш каталог bin и сделайте исполняемым командой `chmod +x <bin_file>`

#### 2- скачайте ``ffmpeg`` или ``ffmpeg-free`` из репозиториев вашего дистрибутива


#### 3- скачайте бинарник ``ytdlp-gui`` со [страницы релизов](https://github.com/BKSalman/ytdlp-gui/releases)

## Windows
##### просто скачайте zip-файл со страницы релизов, распакуйте в подпапку и запустите ``ytdlp-gui.exe``

# Сборка из исходников
Для сборки из исходников вам нужны `cargo` и `rustc`, вы можете установить их через `rustup` (менеджер инструментов Rust) или из репозиториев вашего дистрибутива, как вам удобно

после этого выполните следующие команды:
```bash
# клонировать репозиторий в папку "ytdlp-gui"
git clone https://github.com/BKSalman/ytdlp-gui
# зайти в папку
cd ytdlp-gui
# можно собрать проект так
cargo build
# или собрать в релизном режиме для лучшей производительности
cargo build -r
```
тогда бинарник будет в `<project-root>/target/debug/ytdlp-gui` или `<project-root>/target/release/ytdlp-gui`

и вы можете запустить его напрямую:
```bash
# из корня проекта
./target/release/ytdlp-gui
```

или используя cargo:
```bash
cargo r
# или для релизного режима
cargo r -r
```

# Конфигурация

Начиная с версии v0.2.2+ приложение сохраняет конфигурацию в директории конфигурации по умолчанию для соответствующей платформы/ОС в файле ``<config_dir>/ytdlp-gui/config.toml``

файл по умолчанию выглядит так:

```toml
# Необязательно
# Это директория с бинарником, а не сам бинарник
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) если не установлено, команда будет `yt-dlp <app_args>`

# Необязательно
download_folder = "<some_cool_path>" # по умолчанию = "~/Videos"

[options]
video_resolution = "FullHD" # варианты: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # варианты: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # варианты: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  варианты: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### Примечание: параметры качества/формата автоматически сохраняются при нажатии кнопки загрузки

# Вклад в проект
Любые формы вклада приветствуются, будь то Pull requests, Issues (сообщения об ошибках/запросы на улучшения)

Однако, я могу не отвечать быстро или не реализовывать запрошенное, так как сосредоточен на других задачах

Но я сделаю всё возможное 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---