<details align="right">
<summary>🌐 Język</summary>

[English](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=th) | [Français](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=de) | [Español](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=it) | [Русский](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ru) | [Português](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=as)
</details>

# OnionHoster v2.2

> **Najlepsze narzędzie do hostowania ukrytych usług Tor** – Wdrażaj swoje projekty webowe w dark webie w kilka minut!
> 
[![Wersja](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Platforma](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Licencja](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

<img width="1023" height="551" alt="ChatGPT Image Aug 27, 2025, 03_32_08 PM (1)-modified" src="https://github.com/user-attachments/assets/92b6e834-2d4f-4cc7-8f77-82b9bafba8a5" />


---

## 🚀 Czym jest OnionHoster?

OnionHoster to potężny, wieloplatformowy skrypt bash, który zmienia każdy projekt webowy w ukrytą usługę Tor za pomocą jednej komendy. Niezależnie czy hostujesz aplikację Next.js, backend Flask czy stronę statyczną, OnionHoster automatycznie zajmuje się całą konfiguracją Tor.

### ✨ Dlaczego warto wybrać OnionHoster?

- **🔧 Zero konfiguracji** – Działa od razu z każdym projektem webowym
- **🌍 Wieloplatformowość** – Obsługuje Linux, macOS i główne dystrybucje
- **⚡ Szybka instalacja** – Od zera do ukrytej usługi w mniej niż 2 minuty
- **🔄 Automatyczne aktualizacje** – Wbudowany mechanizm sprawdzania aktualizacji
- **💾 Backup & Przywracanie** – Nigdy nie stracisz swoich adresów onion
- **🎯 Profesjonalny interfejs** – Piękny kolorowy UI z intuicyjnym menu

---
## Podgląd

[![IMAGE ALT TEXT HERE](https://github.com/user-attachments/assets/4b35dfb0-0059-4cc5-99c7-a5b9467a385d)](https://www.youtube.com/watch?v=oPvhA54Tp8w)


# ⚠️ Ostrzeżenie: OnionHoster NIE jest magicznym narzędziem anonimowości — stosuj dobre praktyki, inaczej ryzykujesz deanonymizację

**Wzmocnienie systemu**

* Uruchamiaj usługę wewnątrz maszyny wirtualnej lub kontenera dla izolacji.

* Aktualizuj system operacyjny i pakiety.
* Wyłącz niepotrzebne usługi/porty, aby tylko ruch Tor był przesyłany.

**Praktyki OpSec**

* Nie używaj tego samego komputera do kont osobistych lub prywatnych aktywności.
* Unikaj ujawniania identyfikujących metadanych (nazwy plików, nagłówki, komunikaty o błędach).
* Zwracaj uwagę na logi — co logujesz, jak długo je przechowujesz i czy nie ujawniają informacji.

**Higiena Sieciowa**

* Nie łącz swojej ukrytej usługi z tożsamością lub domeną w clearnet.
* Użyj firewalla, aby zapobiec przypadkowym wyciekom poza Tor.
* Rozważ reverse proxy dla dodatkowej izolacji.

**Testowanie i Monitorowanie**

* Użyj torsocks lub przeglądarki Tor, aby potwierdzić, że usługa jest dostępna tylko przez adres `.onion`.
* Regularnie testuj pod kątem wycieków (np. czy aplikacja próbuje łączyć się z clearnet).

**Świadomość Zastosowań**

* Do użytku hobbystycznego/testowego/edukacyjnego: powyższe zwykle wystarcza.
* W przypadku wysokiego ryzyka, rzeczywistej anonimowości (dziennikarze, sygnaliści, aktywiści): wymaga to głębszej ochrony operacyjnej i modelowania zagrożeń, ponieważ jeden błąd może zdeanonimizować użytkownika.


---
## 🎯 Idealne dla

- **Programistów** testujących swoje aplikacje na Torze
- **Obrońców prywatności** hostujących anonimowe usługi (
- **Badaczy** analizujących technologie dark webu
- **Firm** wymagających anonimowego hostingu
- **Hobbystów** eksplorujących sieć Tor

---

## 🚀 Szybki Start

### Wymagania wstępne
- Dostęp root/sudo
- Połączenie z Internetem
- Dowolny projekt webowy (HTML, Next.js, Flask, itp.)

### Instalacja i użycie

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```

**To wszystko!** 🎉

Otrzymasz kompletny projekt OnionHoster, w tym:
- Główny skrypt `onionhoster.sh`
- Profesjonalny szablon `index.html` do hostowania
- Całą dokumentację i przykłady

Skrypt automatycznie:
- Wykryje Twój system operacyjny
- Zainstaluje wszystkie wymagane zależności (Tor, Apache itd.)
- Skonfiguruje usługi Tor
- Przedstawi intuicyjne menu

---

## 🎮 Przegląd funkcji

### 🌐 Opcje hostowania
- **Statyczny HTML** - Hostuj dowolny plik `index.html`
- **Przekierowanie portu** - Przekieruj do dowolnego lokalnego portu aplikacji
- **Aplikacje dynamiczne** - Obsługa Next.js, Flask, Node.js i innych

### 🛠️ Narzędzia zarządzania
- **Kontrola usług** - Uruchamianie, zatrzymywanie i zarządzanie ukrytą usługą
- **Kopia zapasowa i przywracanie** - Bezpieczne kopie i przywracanie domen onion
- **Odświeżanie URL** - Generowanie nowych adresów onion w razie potrzeby
- **Monitorowanie statusu** - Sprawdzanie zdrowia i statusu usług

### 🔄 Inteligentne aktualizacje
- **Automatyczne wykrywanie** - Samoczynnie znajduje najnowszą wersję
- **Jedno kliknięcie** - Aktualizuj jednym wyborem z menu
- **Bezpieczne aktualizacje** - Bez ryzyka utraty konfiguracji

---

## 📱 Obsługiwane systemy operacyjne

| OS | Menedżer pakietów | Status |
|----|-------------------|--------|
| **Ubuntu/Debian** | `apt-get` | ✅ Pełne wsparcie |
| **CentOS/RHEL** | `yum` | ✅ Pełne wsparcie |
| **Fedora** | `dnf` | ✅ Pełne wsparcie |
| **Arch Linux** | `pacman` | ✅ Pełne wsparcie |
| **macOS** | `brew` | ✅ Pełne wsparcie |

---

## 🎯 Przykłady użycia

### 🏠 Projekty prywatne
- Hostowanie portfolio anonimowo
- Prywatne testowanie aplikacji webowych
- Udostępnianie treści bez ujawniania tożsamości

### 🏢 Zastosowania biznesowe
- Anonimowe portale wsparcia klienta
- Bezpieczne systemy komunikacji wewnętrznej
- Biznesowe strony internetowe z naciskiem na prywatność

### 🔬 Badania i rozwój
- Badania technologii dark web
- Rozwój narzędzi prywatności
- Testowanie anonimowych usług

---

## 📖 Szczegółowe użycie

### Opcje menu głównego

1. **Hostuj index.html** - Serwuj statyczny plik HTML
2. **Przekieruj do portu aplikacji** - Proxy do lokalnej usługi
3. **Kopia zapasowa domeny tor** - Zapisz konfigurację onion
4. **Przywróć domenę tor** - Przywróć z kopii zapasowej
5. **Wyświetl bieżącą domenę tor** - Zobacz aktywny adres onion
6. **Odśwież domenę tor** - Wygeneruj nowy adres onion
7. **Sprawdź aktualizacje** - Aktualizuj do najnowszej wersji
8. **Status serwera WWW** - Monitoruj stan usługi
9. **O OnionHoster** - Informacje o wersji i funkcjach

### Przykładowy przepływ pracy

```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 Zaawansowana konfiguracja

### Niestandardowe przekierowywanie portów
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### Zarządzanie kopiami zapasowymi
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```

---

## 🛡️ Funkcje bezpieczeństwa

- **Automatyczna konfiguracja Tor** – Bezpieczne ustawienia domyślne od razu po instalacji
- **Właściwe uprawnienia plików** – Bezpieczna własność i dostęp do plików
- **Izolacja usług** – Każda ukryta usługa działa niezależnie
- **Brak logowania danych** – Twoja aktywność pozostaje prywatna

---

## 🚨 Ważne uwagi

- **Wymagany dostęp root** – Usługi Tor wymagają konfiguracji na poziomie systemowym
- **Sieć Tor** – Twoja usługa będzie dostępna przez przeglądarkę Tor
- **Adresy Onion** – Każda usługa otrzymuje unikalny adres `.onion`
- **Regularna kopia zapasowa** – Adresy Onion zmieniają się przy odświeżeniu

---

## 🤝 Współpraca

Zapraszamy do współpracy! Dotyczy to:
- 🐛 Zgłaszania błędów
- 💡 Propozycji nowych funkcji
- 📝 Ulepszania dokumentacji
- 🔧 Kontrybucji do kodu

**Aby zacząć:**
1. Rozgałęź repozytorium (fork)
2. Utwórz gałąź funkcjonalności
3. Wprowadź zmiany
4. Złóż pull request

---

## 📄 Licencja

Projekt jest licencjonowany na licencji MIT – szczegóły w pliku [LICENSE](LICENSE).

---

## 🙏 Podziękowania

- **Tor Project** - Za niesamowitą sieć anonimowości
- **Społeczność Open Source** - Za ciągłe ulepszanie
- **Użytkownicy i Współtwórcy** - Za opinie i sugestie

---

## 🔗 Linki

- **GitHub**: [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)
- **Problemy**: [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)
- **Dyskusje**: [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)

---

## ⭐ Oznacz ten projekt gwiazdką

Jeśli OnionHoster Ci pomaga, prosimy o gwiazdkę! Motywuje nas to do dalszego rozwoju i pomaga innym odkryć to narzędzie.

---

**Gotowy na anonimowość?** 🕵️‍♂️

```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```

*Twoja podróż do anonimowego hostingu zaczyna się teraz!* 🚀


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---