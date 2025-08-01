# eBAF - Межсетевой экран для рекламы на основе eBPF
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF Ad Firewall Banner" width="600"/>
</p>

## "Вы бы не скачали рекламу"
### Но вы бы её заблокировали!
 
Spotify построил империю на простой формуле: монетизируй внимание, недоплачивай артистам и продавай пользователю его собственное время в качестве премиум-опции.
В их мире ваш опыт прослушивания — не ваш. Это тщательно организованный рынок — ваши уши являются продуктом, ваше терпение — валютой.

Они любят называть это "бесплатным" тарифом.
Но давайте будем честны: это не бесплатно, если вы платите своим временем.

Тем временем артисты, которых вы любите — люди, чья работа поддерживает платформу, — часто зарабатывают лишь крохи за один прослушанный трек. Spotify получает огромную прибыль, рекламодатели получают свою аудиторию, а создатели? Им достаются лишь объедки.

Речь идёт не только о пропуске пары надоедливых рекламных вставок.
Речь о том, чтобы отказаться участвовать в системе, которая наживается на эксплуатации, отвлечении и коммерциализации вашего внимания.

#### Что это такое?
Элегантный маленький акт цифрового сопротивления: чистый, открытый блокировщик рекламы для Spotify, который останавливает шум — буквально.

Никаких сомнительных модификаций, никаких взломанных клиентов, никакого вредоносного ПО под видом свободы. Только одна цель: пусть музыка играет, не становясь заложником рекламы.

Spotify не бесплатен — вы платите своим терпением.

Вас засыпают одними и теми же раздражающими рекламами снова и снова, пока вы не сдадитесь и не подпишетесь. Не потому что вы любите Premium. А потому что вас измотали. Это не freemium — это психологическая война с плейлистом.

А артисты? Всё так же недополучают оплату.
Рекламы? Громче. Чаще. Иногда буквально громче.
Вы? Просто хотите получить удовольствие.

Они зарабатывают на вашем терпении и недоплате авторам, притворяясь, что это единственный устойчивый путь. Спойлер: это не так. У них был выбор — но они выбрали прибыль, а не людей.

Spotify хочет, чтобы вы поверили, что это цена доступа.
Мы считаем, что это ложь.

Мы не пираты. Мы не преступники. Мы просто люди, которые считают, что можно провести черту.

Этот проект — не о пропуске пары реклам. Это отказ от системы, которая утверждает, что ваше молчание можно продать, ваш опыт можно прервать, а ваша ценность начинается только тогда, когда вы открываете кошелёк.

Блокировка рекламы — не воровство.<br>
Воровство — это кража вашего времени.<br>
Мы здесь не для пиратства. Мы здесь, чтобы отказаться.<br>
<br>
**Вы бы не скачали рекламу. Но вы бы её заблокировали.**
## Как работает eBAF?

eBAF (eBPF Ad Firewall) использует возможности eBPF (Extended Berkeley Packet Filter) для блокировки нежелательной рекламы на уровне ядра. Вот общий обзор его функциональности:

## Как работает eBAF?

eBAF (eBPF Ad Firewall) использует eBPF (Extended Berkeley Packet Filter) для эффективной блокировки рекламы на уровне ядра. Вот упрощённый обзор:

1. **Фильтрация пакетов**:
   - Анализирует входящие сетевые пакеты и блокирует те, которые соответствуют чёрному списку IP-адресов с использованием XDP (eXpress Data Path).

2. **Динамическое обновление**:
   - Разрешает доменные имена в IP-адреса и динамически обновляет чёрный список для эффективной борьбы с изменяющимися рекламными серверами.

3. **Веб-панель управления**:
   - Предоставляет живую статистику и мониторинг через удобный пользовательский интерфейс.

4. **Высокая производительность**:
   - Работает непосредственно на уровне сетевого интерфейса, обходя сетевой стек ядра для более быстрой обработки и минимального использования ресурсов.

eBAF сочетает в себе эффективность, прозрачность и простоту использования, обеспечивая мощное решение для блокировки рекламы.
## Простая установка (Рекомендуется)
Убедитесь, что git и curl установлены
```bash
git --version
curl --version
```
### Установка
#### Включить интеграцию с Spotify (Рекомендуется)
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### Отключить явно
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash
```

### Удаление
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## Установка для разработки
Выполните следующие команды для установки необходимых зависимостей:
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

### Исправление ошибки asm/types.h при запуске eBPF-кода
Проверьте текущую ссылку
`ls -l /usr/include/asm`
Найдите правильную ссылку
`find /usr/include -name "types.h" | grep asm`
Исправьте символьную ссылку 
```bash
sudo rm /usr/include/asm
sudo ln -s <current_link> /usr/include/asm
```

### Сборка проекта

Чтобы собрать eBPF Adblocker, выполните следующие шаги:

1. Клонируйте репозиторий:
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. Соберите проект:
   ```bash
   make
   ```

3. (Опционально) Установите на всю систему:
   ```bash
   sudo make install
   ```

4. Другие параметры установки (справка)
    ```bash
    make help
    ````
5. Удаление установки
    ```bash
    make uninstall
    ````
## Использование

### Запуск блокировщика рекламы
    По умолчанию используется spotify-stable.txt как черный список.
    Использование: ebaf [ОПЦИИ] [ИНТЕРФЕЙС...]
    ОПЦИИ:
    -a, --all               Запустить на всех активных интерфейсах
    -d, --default           Запустить только на интерфейсе по умолчанию (с доступом в интернет)
    -i, --interface IFACE   Указать используемый интерфейс
    -D, --dash              Запустить веб-дэшборд (http://localhost:8080)
    -q, --quiet             Подавлять вывод (тихий режим)
    -h, --help              Показать это справочное сообщение


### Настройка черного списка
Отредактируйте списки для добавления или удаления доменов. Каждый домен должен быть на отдельной строке. Комментарии начинаются с `#`.

## Благодарности

Особая благодарность ❤️ <br>
1. [Spotify-AdsList от Isaaker](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [spotify-adblock от AnanthVivekanand](https://github.com/AnanthVivekanand/spotify-adblock)

за предоставление списка блокировки для Spotify
## ⭐️ Поддержите проект

Если вы находите eBAF полезным, пожалуйста, поставьте звезду репозиторию на GitHub! Ваша поддержка помогает повысить видимость и стимулирует дальнейшую разработку.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---