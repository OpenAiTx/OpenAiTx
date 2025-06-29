<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

 Solidna, lokalnie wdrażana platforma zaprojektowana do bezproblemowego wykrywania SQL i audytu zapytań, dostosowana specjalnie dla administratorów baz danych (DBA) i programistów. Skoncentrowana na prywatności i wydajności, zapewnia intuicyjne i bezpieczne środowisko do audytu MYSQL.

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ Funkcje

- **Asystent AI**: Nasz asystent AI oferuje sugestie optymalizacji SQL w czasie rzeczywistym, poprawiając wydajność SQL. Wspiera również konwersję tekstu na SQL, umożliwiając użytkownikom wprowadzanie języka naturalnego i otrzymywanie zoptymalizowanych instrukcji SQL.
  
- **Audyt SQL**: Twórz zgłoszenia audytu SQL z obiegiem zatwierdzania i automatyczną kontrolą składni. Waliduj instrukcje SQL pod kątem poprawności, bezpieczeństwa i zgodności. Instrukcje wycofania są generowane automatycznie dla operacji DDL/DML, a pełna historia zmian zapewnia możliwość śledzenia.

- **Audyt zapytań**: Audytuj zapytania użytkowników, ograniczaj źródła danych i bazy danych, a także anonimizuj wrażliwe pola. Rejestry zapytań są zapisywane do późniejszego wglądu.

- **Reguły sprawdzania**: Nasz automatyczny sprawdzacz składni obsługuje szeroki zakres reguł sprawdzania, odpowiednich dla większości scenariuszy automatycznej weryfikacji.

- **Prywatność na pierwszym miejscu**: Yearning to lokalnie wdrażane, otwarte rozwiązanie, które zapewnia bezpieczeństwo Twojej bazy danych i instrukcji SQL. Zawiera mechanizmy szyfrowania chroniące dane wrażliwe, zapewniając ich bezpieczeństwo nawet w przypadku nieautoryzowanego dostępu.

- **RBAC (Kontrola dostępu oparta na rolach)**: Twórz i zarządzaj rolami z określonymi uprawnieniami, ograniczając dostęp do zleceń zapytań, funkcji audytu i innych wrażliwych operacji w zależności od ról użytkowników.

> \[!TIP]
> Więcej szczegółowych informacji znajdziesz w naszym [Przewodniku Yearning](https://next.yearning.io)


## ⚙️ Instalacja

Pobierz [najnowsze wydanie](https://github.com/cookieY/Yearning/releases/latest) i rozpakuj je. Przed kontynuacją upewnij się, że skonfigurowano `./config.toml`.

### Instalacja ręczna

```bash
## Inicjalizacja bazy danych
./Yearning install

## Uruchomienie Yearning
./Yearning run

## Pomoc
./Yearning --help
```

### 🚀 Wdrażanie z Dockerem
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## Inicjalizacja bazy danych
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Uruchomienie Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 Wsparcie AI

Nasz Asystent AI wykorzystuje duży model językowy do udzielania sugestii optymalizacji SQL oraz konwersji tekstu na SQL. Niezależnie od tego, czy używasz domyślnych, czy własnych promptów, Asystent AI zwiększa wydajność SQL poprzez optymalizację instrukcji i konwersję poleceń w języku naturalnym na zapytania SQL.

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 Automatyczny sprawdzacz SQL

Automatyczny sprawdzacz SQL ocenia instrukcje SQL względem zdefiniowanych reguł i składni. Zapewnia, że instrukcje spełniają określone standardy kodowania, najlepsze praktyki i wymagania bezpieczeństwa, oferując solidną warstwę weryfikacji.

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 Podświetlanie składni SQL i autouzupełnianie

Zwiększ efektywność pisania zapytań dzięki podświetlaniu składni SQL i funkcji autouzupełniania. Te funkcje pomagają użytkownikom wizualnie rozróżniać różne składniki zapytania SQL, takie jak słowa kluczowe, nazwy tabel, kolumn i operatory, co ułatwia czytanie i rozumienie struktury zapytania.

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ Rejestr zleceń/zapytań

Nasza platforma obsługuje audytowanie zleceń użytkownika oraz zapytań. Funkcja ta umożliwia śledzenie i rejestrowanie wszystkich operacji zapytań, w tym źródeł danych, baz danych oraz obsługi wrażliwych pól, zapewniając zgodność z przepisami oraz możliwość śledzenia historii zapytań.

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

Koncentrując się na tych kluczowych funkcjach, Yearning podnosi komfort użytkowania, optymalizuje wydajność SQL oraz zapewnia solidną zgodność i możliwość śledzenia operacji w bazie danych.

## 🛠️ Rekomendowane narzędzia

- [Spug - Otwarta, lekka platforma do automatyzacji operacji](https://github.com/openspug/spug)

## ☎️ Kontakt

W przypadku pytań prosimy o kontakt mailowy: henry@yearning.io
## 📋 Licencja

Yearning jest licencjonowany na podstawie licencji AGPL. Zobacz [LICENSE](LICENSE) po szczegóły.

2024 © Henry Yee

---

Z Yearning doświadcz uproszczonego, bezpiecznego i wydajnego podejścia do audytu oraz optymalizacji SQL.


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---