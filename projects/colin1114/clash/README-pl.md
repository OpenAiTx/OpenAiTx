CDN przyspieszenie i ochrona bezpieczeństwa dla tego projektu są sponsorowane przez Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

Autorem tego projektu jest colin1114.

# 🚀 Konwerter subskrypcji Clash

Estetyczne i zaawansowane narzędzie online do konwersji różnych linków subskrypcyjnych proxy na format konfiguracji Clash. Obsługuje automatyczne wdrażanie przez Cloudflare Workers & Pages, zapewnia szybkie i niezawodne usługi konwersji subskrypcji.

## ✨ Funkcje

- 🎨 **Estetyczny, nowoczesny interfejs** - gradientowe tło i projekt z kartami
- 🔄 **Obsługa wielu protokołów** - obsługa głównych protokołów takich jak V2Ray, VLESS, Shadowsocks, Trojan i innych
- ☁️ **Wdrażanie w chmurze** - globalne przyspieszenie CDN przez Cloudflare Workers
- 📱 **Responsywny design** - pełna kompatybilność z komputerami i urządzeniami mobilnymi
- ⚡ **Szybka konwersja** - natychmiastowa konwersja linków subskrypcyjnych na konfigurację Clash
- 📋 **Inteligentne kopiowanie** - obsługa kopiowania wygenerowanego pliku YAML jednym kliknięciem, kompatybilność z różnymi przeglądarkami
- 📡 **Generowanie linku subskrypcyjnego** - automatyczne generowanie linku subskrypcyjnego do bezpośredniego importu do Clash
- 🌐 **Dostęp do YAML online** - różne metody dostępu do plików YAML:
  - 📡 Link subskrypcyjny: obsługa automatycznej aktualizacji w kliencie Clash
  - 🔗 Podgląd online: bezpośrednie przeglądanie konfiguracji w przeglądarce
  - 💾 Pobieranie pliku: pobierz plik .yaml na komputer
  - ⚡ Szybki dostęp: uproszczony link do pobrania
- 🔧 **Obsługa UTF-8** - pełna obsługa chińskich nazw węzłów i konfiguracji
- 🆓 **Całkowicie za darmo** - oparte na darmowych usługach Cloudflare, bez ograniczeń użycia

## 📁 Struktura projektu

```
clash/
├── index.html              # Strona front-endowa
├── worker.js               # Kod back-endowy Cloudflare Worker
├── wrangler.jsonc          # Plik konfiguracyjny Wrangler
├── _headers                # Konfiguracja nagłówków HTTP dla Cloudflare Pages
├── .github/
│   └── workflows/
│       └── deploy.yml      # Konfiguracja wdrożenia GitHub Actions
├── README.md              # Dokumentacja projektu
└── package.json           # Plik konfiguracyjny projektu
```

## 🚀 Szybki start

### Metoda 1: Uruchomienie lokalne

1. **Klonowanie projektu**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Uruchomienie lokalnego serwera**
   ```bash
   # Z użyciem Pythona
   python -m http.server 8000
   
   # Lub z użyciem Node.js
   npx serve .
   ```

3. **Dostęp do aplikacji**
   - Otwórz przeglądarkę i przejdź do `http://localhost:8000`
   - W środowisku lokalnym wyświetlane będą przykładowe konfiguracje

### Metoda 2: Wdrażanie przez Cloudflare Workers

#### Krok 1: Utwórz Worker

1. Wejdź na [Cloudflare Workers](https://workers.cloudflare.com/)
2. Zarejestruj się/zaloguj na konto Cloudflare
3. Kliknij "Create a Worker"
4. Skopiuj cały kod z `worker.js` do edytora
5. Kliknij "Save and Deploy"

#### Krok 2: Wdrażanie za pomocą Wrangler CLI

```bash
# Instalacja Wrangler CLI
npm install -g wrangler

# Logowanie do Cloudflare
wrangler login

# Wdrożenie Workera
npm run deploy:worker
```

#### Krok 3: Konfiguracja domeny (opcjonalnie)

1. Dodaj własną domenę w ustawieniach Workera
2. Lub użyj domyślnej domeny oferowanej przez Cloudflare

### Metoda 3: Wdrażanie przez Cloudflare Pages

#### Opcja A: Integracja z GitHub (zalecane)

1. **Przygotowanie repozytorium**
   - Wgraj kod do repozytorium GitHub
   - Upewnij się, że zawiera wszystkie niezbędne pliki
2. **Utwórz projekt Pages**
   - Odwiedź [Cloudflare Pages](https://pages.cloudflare.com/)
   - Połącz swoje repozytorium GitHub
   - Wybierz repozytorium projektu

3. **Ustawienia budowania**
   - Komenda budowania: pozostaw puste lub `echo "No build required"`
   - Katalog wyjściowy budowania: `/` (katalog główny)
   - Zmienne środowiskowe: nie wymagają ustawienia

#### Opcja B: Bezpośrednie przesyłanie

```bash
# Wdrażanie za pomocą Wrangler Pages
npm run deploy:pages
```

## 🛠️ Architektura techniczna

### Stos technologiczny frontendu
- **HTML5** - nowoczesny język znaczników
- **CSS3** - responsywny design i efekty animacji
- **Vanilla JavaScript** - lekka interakcja frontendowa

### Stos technologiczny backendu
- **Cloudflare Workers** - platforma obliczeń brzegowych
- **Web APIs** - standardowe Fetch API i obsługa odpowiedzi

### Obsługiwane formaty protokołów
- **VMess** - standardowy protokół V2Ray
- **VLESS** - lekki protokół V2Ray (obsługa Reality)
- **Shadowsocks** - klasyczny protokół proxy
- **Trojan** - nowoczesny protokół proxy

### Punkty końcowe API
- `GET /` - strona główna
- `POST /convert` - API konwersji subskrypcji
- `GET /clash/{config-id}` - pobierz plik konfiguracyjny YAML (link subskrypcji)
- `GET /yaml/{config-id}` - pobierz plik konfiguracyjny YAML
- `OPTIONS /*` - zapytania wstępne CORS

## 📖 Instrukcja użytkowania

### Podstawowe użycie

1. **Wprowadź link subskrypcji**
   - Wklej swój link subskrypcji proxy do pola wejściowego
   - Obsługa linków subskrypcji zakodowanych Base64

2. **Ustaw nazwę konfiguracji**
   - Opcjonalnie ustaw własną nazwę pliku konfiguracyjnego
   - Domyślnie "My Clash Config"

3. **Konwertuj konfigurację**
   - Kliknij przycisk "Konwertuj subskrypcję"
   - Poczekaj na zakończenie konwersji

4. **Użyj konfiguracji**
   - Skopiuj wygenerowaną konfigurację YAML
   - Zaimportuj do klienta Clash

5. **Użyj linku subskrypcji (zalecane)**
   - Skopiuj wygenerowany link subskrypcji
   - Dodaj subskrypcję w kliencie Clash
   - Konfiguracja będzie synchronizowana automatycznie, bez ręcznej aktualizacji

### Zaawansowana konfiguracja

Wygenerowana konfiguracja Clash zawiera następujące funkcje:

- **Polityka grup proxy**
  - 🚀 Wybór węzła - ręczny wybór proxy
  - ♻️ Automatyczny wybór - automatyczny wybór na podstawie testu opóźnień
  - 🎯 Globalne połączenie bezpośrednie - połączenie bezpośrednie

- **Konfiguracja DNS**
  - Włączona obsługa rozwiązywania DNS
  - Obsługa trybu fake-ip
  - Rozdzielenie DNS krajowego i zagranicznego

- **Zasady routingu**
  - Bezpośrednie połączenie z adresami lokalnymi
  - Bezpośrednie połączenie z krajowymi adresami IP
  - Pozostały ruch przez proxy

## 🔧 Rozwiązywanie problemów z wdrożeniem

### Najczęstsze problemy

#### 1. Wrangler nie znajduje punktu wejścia
**Komunikat o błędzie**: `Missing entry-point to Worker script`

**Rozwiązanie**: 
- Upewnij się, że w katalogu głównym projektu znajduje się plik `wrangler.jsonc`
- Sprawdź, czy pole `main` w `wrangler.jsonc` wskazuje na `worker.js`

#### 2. Niepowodzenie wdrożenia przez GitHub Actions
**Rozwiązanie**:
- Dodaj następujące sekrety w ustawieniach repozytorium GitHub:
  - `CLOUDFLARE_API_TOKEN`: Token API Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: ID konta Cloudflare

#### 3. Błąd budowania Pages
**Rozwiązanie**:
- Ustaw polecenie budowania jako puste lub `echo "No build required"`
- Upewnij się, że katalog wyjściowy budowania to `/`

### Opis plików konfiguracyjnych wdrożenia

- **`wrangler.jsonc`**: Konfiguracja Wrangler CLI do wdrażania Workerów
- **`_headers`**: Konfiguracja nagłówków HTTP dla Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Konfiguracja automatycznego wdrażania przez GitHub Actions

## 🔧 Konfiguracja niestandardowa

### Modyfikacja grup proxy

Możesz edytować funkcję `convertToClash` w pliku `worker.js`, aby dostosować grupy proxy:

```javascript
'proxy-groups': [
  {
    name: '🚀 Wybór węzła',
    type: 'select',
    proxies: ['♻️ Automatyczny wybór', '🎯 Połączenie globalne', ...proxyNames]
  },
  // Dodaj więcej grup proxy...
]
```

### Niestandardowe reguły routingu

Edytuj tablicę `rules`, aby dodać własne reguły routingu:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 Wybór węzła',
  'DOMAIN-SUFFIX,local,DIRECT',
  // Dodaj więcej reguł...
]
```

## 📊 Cechy wydajnościowe

- **Globalny CDN** - globalna sieć brzegowa Cloudflare
- **Szybka odpowiedź** - średni czas odpowiedzi < 100 ms
- **Wysoka dostępność** - 99,9% dostępności usług
- **Darmowy limit** - 100 000 żądań dziennie

## 🔒 Informacje o bezpieczeństwie

- **Prywatność danych** - dane subskrypcji są używane wyłącznie podczas konwersji i nie są przechowywane
- **Szyfrowanie HTTPS** - cała komunikacja jest szyfrowana przez HTTPS
- **Otwartość i transparentność** - kompletny kod źródłowy jest publiczny, możesz go samodzielnie sprawdzić

## 🤝 Wskazówki dotyczące współpracy

Zachęcamy do zgłaszania Issue i Pull Requestów!

1. Forknij to repozytorium
2. Utwórz gałąź funkcjonalności (`git checkout -b feature/AmazingFeature`)
3. Zatwierdź zmiany (`git commit -m 'Add some AmazingFeature'`)
4. Wypchnij na gałąź (`git push origin feature/AmazingFeature`)
5. Otwórz Pull Request

## 📝 Dziennik zmian

### v1.1.0
- ✅ Dodano wsparcie dla protokołu VLESS (w tym bezpieczny transport Reality)
- ✅ Ulepszona kompatybilność protokołów

### v1.0.0
- ✅ Podstawowa funkcja konwersji subskrypcji
- ✅ Estetyczny interfejs użytkownika
- ✅ Wsparcie dla Cloudflare Workers
- ✅ Obsługa wielu protokołów (VMess, Shadowsocks, Trojan)
- ✅ Projekt responsywny
- ✅ Funkcja kopiowania jednym kliknięciem

## 📞 Wsparcie i opinie

Jeśli napotkasz problemy lub masz sugestie:

1. Przeczytaj ten plik README
2. Zgłoś [Issue](../../issues)
3. Rozpocznij [Dyskusję](../../discussions)

## 📄 Licencja

Projekt jest objęty licencją MIT – szczegóły w pliku [LICENSE](LICENSE)

## 🙏 Podziękowania

- [Cloudflare Workers](https://workers.cloudflare.com/) – platforma edge computing
- [Clash](https://github.com/Dreamacro/clash) – znakomity klient proxy
- Wszyscy współtwórcy i użytkownicy za wsparcie

---
⭐ Jeśli ten projekt okazał się dla Ciebie pomocny, daj mu gwiazdkę (Star)!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---