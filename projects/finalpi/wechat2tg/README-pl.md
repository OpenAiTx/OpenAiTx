# wechat2tg-mac

Na podstawie protokołu WeChat Mac, umożliwia wysyłanie i odbieranie wiadomości WeChat w Telegramie. Usługa wx2tg-server nie jest open source ze względów bezpieczeństwa.

## Grupa TG: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## Główne funkcje

1. Odbiór wiadomości prywatnych WeChat, wiadomości z grup WeChat, wiadomości oficjalnych kont oraz wiadomości z WeChat Work.
2. Wysyłanie wiadomości z Telegrama do określonych użytkowników WeChat, grup WeChat lub oficjalnych kont.
3. Blokowanie wiadomości z wybranych grup.

## Obsługiwane typy wiadomości

### Lista obsługiwanych typów wiadomości WeChat

+ [x] Wiadomości tekstowe
+ [x] Wiadomości z WeChat Work
+ [x] Naklejki WeChat (emotikony)
+ [x] Wiadomości obrazkowe
+ [x] Wiadomości wideo
+ [x] Połączenia audio/wideo (tylko powiadomienia)
+ [x] Wiadomości plikowe
+ [x] Wiadomości z linkami
+ [x] Wiadomości grupowe
+ [x] Wiadomości @ w grupie (zarówno @wszyscy jak i @ty będą konwertowane na Telegramowe @ty)
+ [x] Wiadomości z oficjalnych kont
+ [x] emoji
+ [x] Wiadomości lokalizacyjne
+ [x] Cofnięcie wiadomości
+ [x] Wiadomości głosowe
+ [ ] Wiadomości o czerwonej kopercie (tylko powiadomienie, brak treści koperty)
+ [ ] Wiadomości z mini-programów

### Lista obsługiwanych typów wiadomości Telegram

+ [x] Wiadomości tekstowe
+ [x] Naklejki/Emotikony
+ [x] Wiadomości obrazkowe
+ [x] Wiadomości wideo
+ [x] Wiadomości plikowe
+ [x] Wiadomości głosowe

## Uwagi

1. Projekt przeznaczony wyłącznie do badań technicznych i nauki. Nie używać do celów niezgodnych z prawem.
2. W razie jakichkolwiek problemów zachęcamy do zgłaszania issue.

## Instalacja i wdrożenie

Najpierw skopiuj `.env.example` jako plik `.env`, a następnie skonfiguruj zmienne środowiskowe w pliku `.env`.

Skopiuj `app.conf.example` jako plik `app.conf` do katalogu `conf` i ustaw adres Redis na adres Twojego serwera Redis.

### docker-compose

Utwórz plik `docker-compose.yml`:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # Po zamontowaniu folderu plików nie trzeba ponownie konwertować naklejek
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # Pobierz obraz
    container_name: wx2tg-server
    ports:
      - "8058:8058"
    volumes:
      - ./conf:/usr/wic-go/conf
    restart: unless-stopped

  wx2tg-redis:
    image: redis:7.2
    container_name: wx2tg-redis
    ports:
      - "16379:6379"
    volumes:
      - ./redis-data:/data
    command: ["redis-server", "--appendonly", "yes"]
    restart: unless-stopped
```

#### Uruchomienie

```shell
docker-compose up -d
```

#### Wyłączenie trybu prywatności bota

Wyłącz tryb prywatności bota: otwórz BotFather, wpisz `/mybots`, wybierz swojego bota. Kliknij `Bot Settings` - `Group Privacy` - `Turn off`.
Jeśli pojawi się komunikat `Privacy mode is disabled for xxx` to znaczy, że tryb został wyłączony.

## Instrukcja użytkowania

### Komendy BOT-a

- `/login`: Pobierz kod QR do logowania; pierwsza osoba, która wyśle tę komendę po uruchomieniu, zostaje właścicielem `BOT-a`.

- `/flogin`: Pobierz kod QR logowania do Asystenta przesyłania plików, obsługuje odbiór wideo i plików.

- `/update`: Aktualizuj zdjęcia profilowe i informacje o nazwach grup.

- `/message`: Włącz/wyłącz odbiór wiadomości z grupy.

- `/forward`: Włącz/wyłącz przekazywanie wiadomości innych użytkowników lub bota w grupie.

- `/user`: Pobierz listę użytkowników WeChat; kliknij przycisk, aby utworzyć nową grupę lub powiązać użytkownika (możesz szukać po imieniu lub notatce, np. `/user 张` znajdzie użytkowników WeChat zawierających „张”).

- `/room`: Pobierz listę grup WeChat; kliknij przycisk, aby utworzyć nową grupę lub powiązać grupę WeChat (możesz szukać po nazwie lub notatce, np. `/room 外卖` znajdzie grupy WeChat zawierające „外卖”).

- `/settings`: Ustawienia programu.

- `/unbind`: Odwiąż grupę WeChat lub użytkownika WeChat (działa tylko w grupach).

### Opis zmiennych środowiskowych

|Nazwa| Wymagane | Opis                                                             |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| Tak    | Token Telegram Bota, uzyskany przez [BotFather](https://t.me/BotFather) |
|`API_ID`| Tak    | API ID Telegrama                                              |
|`API_HASH`| Tak    | API HASH Telegrama                                            |
|`BASE_API`| Tak    | Adres API kontenera wx2tg-server, wymaga pełnej ścieżki                | |
|`PROXY_PROTOCOL`| Nie    | Typ proxy (opcjonalnie: socks5, http, https)                             |
|`PROXY_HOST`| Nie    | URL proxy                                                       |
|`PROXY_PORT`| Nie    | Port proxy                                                        |
|`PROXY_USERNAME`| Nie    | Nazwa użytkownika proxy                                              |
|`PROXY_PASSWORD`| Nie    | Hasło proxy                                                        |
|`ROOM_MESSAGE`| Nie    | Format wyświetlania wiadomości z grup WeChat w bocie                   |
|`OFFICIAL_MESSAGE`| Nie    | Format wyświetlania wiadomości z oficjalnych kont w bocie                 |
|`CONTACT_MESSAGE`| Nie    | Format wyświetlania wiadomości od użytkowników WeChat w bocie              |
|`ROOM_MESSAGE_GROUP`| Nie    | Format wyświetlania wiadomości z grup WeChat w grupach                     |
|`CONTACT_MESSAGE_GROUP`| Nie    | Format wyświetlania wiadomości od użytkowników WeChat w grupach                |
|`OFFICIAL_MESSAGE_GROUP`| Nie    | Format wyświetlania wiadomości z oficjalnych kont w grupach                   |
|`CREATE_ROOM_NAME`| Nie    | Format nazwy grupy przy automatycznym tworzeniu grupy WeChat                |
|`CREATE_CONTACT_NAME`| Nie    | Format nazwy grupy przy automatycznym tworzeniu grupy kontaktów WeChat         |
|`MESSAGE_DISPLAY`| Nie    | Format wyświetlania wiadomości tekstowych                                 |

---

### Wyjaśnienie ustawień komendy `/settings`

1. Czy emoji WeChat mają być wyświetlane jako linki do obrazków: po włączeniu, emotikony od znajomych będą wyświetlane jako linki do obrazków.

2. Synchronizuj informacje o grupach przy starcie: po włączeniu, program zsynchronizuje wszystkie informacje o grupach i zaktualizuje zdjęcia oraz nazwy grup przy starcie.

---

### Konwersja głosu na tekst

1. Skonfiguruj `TENCENT_SECRET_ID` oraz `TENCENT_SECRET_KEY`, możesz to zrobić w konsoli [rozpoznawania mowy Tencent](https://console.cloud.tencent.com/asr). Dostępny jest darmowy limit.
2. Włącz automatyczną konwersję głosu na tekst w `/settings`.

---

### Uzyskanie `API_ID` i `API_HASH`

1. Zaloguj się na [konto telegram](https://my.telegram.org/)

2. Kliknij „API development tools” i wypełnij dane aplikacji (wystarczy tytuł i skrót).

3. Na końcu kliknij „Create application”.

---

### Szablony wiadomości

Jeśli chcesz zmienić format nadawcy wiadomości, możesz edytować zmienne środowiskowe w dockerze lub plik `.env`.

Dostępne znaczniki szablonu:

`#[alias]`: notatka kontaktu

`#[name]`: nazwa kontaktu

`#[topic]`: nazwa grupy

`#[alias_first]`: notatka kontaktu jeśli istnieje, w przeciwnym wypadku nazwa kontaktu

`#[identity]`: tekst informacji o tożsamości

`#[body]`: treść wiadomości

`#[br]`: nowa linia

### Jak oznaczyć @wszyscy

Wiadomość zaczynająca się od `@all` oznaczy wszystkich w grupie. Obsługiwane tylko dla wiadomości tekstowych.

---

## FAQ

## Współtworzenie

1. Forkuj projekt, przejdź na branch `wx2tg-mac-dev` lub utwórz nowy branch. Nie przesyłaj kodu bezpośrednio do głównego branchu.
2. Zgłoś Pull Request do branchu `wx2tg-mac-dev`.

## Licencja

[MIT](LICENSE)

## Podziękowania

Dziękujemy Jetbrains za wsparcie projektu

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---