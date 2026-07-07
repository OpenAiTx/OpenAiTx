
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OnlineLearningTutorials&project=mt7902_temp&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 🎯 Драйвер MT7902 как часть драйвера MT7921 (✅ Работает)
WiFi 6E чип Mediatek mt7902 поддерживает Bluetooth и WiFi

> [!ВАЖНО]
> Официальная поддержка чипа MT7902 WIFI 6E в ядре Linux 7.1


## 📁 Клонирование репозитория
Клонируйте репозиторий на свой локальный компьютер
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
Если вы не хотите клонировать прошлую историю, то
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## Установка


### 🚀 Скрипт руководства по установке (рекомендуется для систем на базе Ubuntu)
Сделайте скрипт исполняемым, если он ещё не исполняемый
```
chmod +x ./install_guide.sh
```
Теперь запустите этот скрипт
```
./install_guide.sh
```
Он автоматически запросит пароль, когда это потребуется
* Этот скрипт поочередно предложит установить прошивку, драйверы Bluetooth и Wi-Fi
* Протестировано на Ubuntu с ядром linux 7.0

### 🚀 Легкое автоматическое исправление (Рекомендуется для систем на базе Arch)
Если вы хотите быстро исправить WiFi и Bluetooth на любом современном ядре, выполните следующие шаги:

Сделайте скрипт исполняемым, если он еще не является таковым
```
chmod +x ./fix_my_wifi.sh
```

**Запустите скрипт автоматического исправления** с использованием sudo:
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 Что делает этот скрипт:
* **Проверяет зависимости:** Убеждается, что у вас установлены `gcc`/`clang`, `make`, `bc` и ваши текущие `kernel-headers`. Если нет – устанавливает с помощью вашего предпочтительного пакетного менеджера.
* **Компилирует драйверы:** Автоматически собирает драйверы WiFi и Bluetooth под вашу текущую версию ядра.
* **Постоянное исправление:** Устанавливает системную службу, чтобы WiFi оставался активным даже после перезагрузки компьютера.
* **Безопасность:** Устанавливает модули в отдельную директорию (`/lib/modules/mt7902_custom`), чтобы не затрагивать системные файлы по умолчанию.

> [!NOTE]
> Для первого запуска потребуется подключение к интернету (через Ethernet или USB-модем с телефона) для загрузки необходимых инструментов сборки (компилятор, linux-headers и т.д.)


## ✅ Протестировано на (Работоспособность подтверждена)
Это решение проверено и подтверждено для работы на:

* **Бренд:** ASUS
* **Модель:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **Чипсет:** MediaTek MT7902 (WiFi 6E)
* **Версия ядра:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **ОС:** Arch, Ubuntu
* **Пакетный менеджер:** pacman, apt

## Доступно для:
* **ОС**: Любая ОС, поддерживающая один из указанных ПМ
* **Предпочитаемые пакетные менеджеры**: apt, pacman, dnf, zypper, nix-shell
* **Версии ядра**: 6.14-7.0.7


## 🔧 Используемые прошивки
Прошивки хранятся в папке `firmware`.


## 📱 Bluetooth ✅ (Работает)
> [!WARNING]
> Если драйвер Bluetooth конфликтует с `gen4-mt7902`, пожалуйста, удалите прошивку Bluetooth, чтобы она не мешала этому драйверу
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> Этот проект использует прошивку
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

Чтобы включить Bluetooth, перейдите в директорию вашей текущей версии ядра. ``
Например, если у вас ядро linux-6.16, перейдите в директорию `./linux-6.16/drivers/bluetooth` .
Откройте терминал в этом каталоге и скомпилируйте с помощью команды `make`.
Компилируются два модуля ядра: `btusb.ko` и `btmtk.ko`.
Чтобы включить Bluetooth на вашем устройстве, удалите btusb и btmtk в вашей системе и установите эти два файла, используйте команды
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
Теперь проверьте, работает ли ваш Bluetooth.

## 💻 WiFi ✅ (Работает)
> [!ВАЖНО]
> Рабочий репозиторий с некоторыми ограничениями находится [здесь](https://github.com/hmtheboy154/gen4-mt7902)

Драйвер WiFi для mt7902, недавно выпущенный компанией Mediatek, находится в папке `latest`.

Если вы используете Ubuntu, просто перейдите в папку `latest` и выполните следующую команду в терминале.
```
make
```

Он скомпилирует все модули, сожмет их и установит (заменит оригинальный модуль ядра на измененный модуль). Если вы используете другую дистрибуцию или не хотите выполнять все шаги, а только хотите скомпилировать код, то выполните в терминале
```
make module_compile
```
Чтобы сжать скомпилированный модуль, затем запустите в терминале
```
make module_compress
```
Чтобы установить сжатый модуль в модуль ядра системы, выполните в терминале
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---