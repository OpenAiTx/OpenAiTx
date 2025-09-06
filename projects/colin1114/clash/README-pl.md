
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=colin1114&project=clash&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

Przyspieszenie CDN i ochrona bezpieczeństwa dla tego projektu są sponsorowane przez Tencent EdgeOne.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

Autorem tego projektu jest colin1114.

# 🚀 Konwerter subskrypcji Clash

Estetyczne i potężne narzędzie online do konwersji różnych linków subskrypcji proxy na format konfiguracji Clash. Obsługuje automatyczne wdrażanie przez Cloudflare Workers & Pages, zapewniając szybkie i niezawodne usługi konwersji subskrypcji.

## ✨ Cechy funkcjonalne

- 🎨 **Estetyczny, nowoczesny interfejs** - Zastosowanie gradientowego tła i projektu opartego na kartach
- 🔄 **Obsługa wielu protokołów** - Wsparcie dla V2Ray, VLESS, Shadowsocks, Trojan i innych popularnych protokołów
- ☁️ **Wdrażanie w chmurze** - Przyspieszenie globalne CDN za pomocą Cloudflare Workers
- 📱 **Responsywny design** - Doskonałe dopasowanie do komputerów stacjonarnych i urządzeń mobilnych
- ⚡ **Szybka konwersja** - Natychmiastowa konwersja linków subskrypcyjnych na konfigurację Clash
- 📋 **Inteligentne kopiowanie** - Obsługa kopiowania wygenerowanej konfiguracji YAML jednym kliknięciem, kompatybilność z różnymi przeglądarkami
- 📡 **Generowanie linków subskrypcyjnych** - Automatyczne generowanie linków subskrypcyjnych do bezpośredniego importu w Clash
- 🌐 **Dostęp online do YAML** - Zapewnienie różnych sposobów dostępu do plików YAML:
  - 📡 Link subskrypcyjny: wsparcie automatycznej aktualizacji klienta Clash
  - 🔗 Podgląd online: bezpośrednie wyświetlanie konfiguracji w przeglądarce
  - 💾 Pobieranie pliku: pobierz plik .yaml na dysk lokalny
  - ⚡ Szybki dostęp: uproszczone linki do pobierania
- 🔧 **Wsparcie UTF-8** - Pełna obsługa chińskich nazw węzłów i konfiguracji
- 🆓 **Całkowicie darmowe** - Oparte na bezpłatnych usługach Cloudflare, bez ograniczeń użytkowania

## 📁 Struktura projektu

```
clash/
├── index.html              # 前端页面
├── worker.js               # Cloudflare Worker 后端代码
├── wrangler.jsonc          # Wrangler 配置文件
├── _headers                # Cloudflare Pages HTTP头配置
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 部署配置
├── README.md              # 项目说明文档
└── package.json           # 项目配置文件
```

## 🚀 Szybki start

### Metoda 1: Uruchomienie lokalne

1. **Sklonuj projekt**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **Uruchom lokalny serwer**
   ```bash
   # 使用 Python
   python -m http.server 8000
   
   # 或使用 Node.js
   npx serve .
   ```

3. **Dostęp do aplikacji**
   - Otwórz przeglądarkę i przejdź do `http://localhost:8000`
   - W środowisku lokalnym wyświetli się przykładowa konfiguracja

### Metoda druga: Wdrożenie na Cloudflare Workers

#### Krok 1: Utwórz Worker

1. Odwiedź [Cloudflare Workers](https://workers.cloudflare.com/)
2. Zarejestruj się/zaloguj na konto Cloudflare
3. Kliknij "Create a Worker"
4. Skopiuj cały kod z `worker.js` do edytora
5. Kliknij "Save and Deploy"

#### Krok 2: Wdróż za pomocą Wrangler CLI

```bash
# 安装 Wrangler CLI
npm install -g wrangler

# 登录到 Cloudflare
wrangler login

# 部署 Worker
npm run deploy:worker
```

#### Krok 3: Konfiguracja domeny (opcjonalnie)

1. Dodaj własną domenę w ustawieniach Worker
2. Lub użyj domyślnej domeny udostępnionej przez Cloudflare

### Metoda trzecia: Wdrażanie przez Cloudflare Pages

#### Opcja A: Integracja z GitHub (zalecana)

1. **Przygotowanie repozytorium**
   - Wypchnij kod do repozytorium GitHub
   - Upewnij się, że zawiera wszystkie niezbędne pliki

2. **Utwórz projekt Pages**
   - Przejdź do [Cloudflare Pages](https://pages.cloudflare.com/)
   - Połącz swoje repozytorium GitHub
   - Wybierz repozytorium projektu

3. **Ustawienia budowania**
   - Komenda budowania: pozostaw puste lub `echo "No build required"`
   - Katalog wyjściowy: `/` (katalog główny)
   - Zmienne środowiskowe: nie trzeba ustawiać

#### Opcja B: Bezpośrednie przesłanie

```bash
# 使用 Wrangler Pages 部署
npm run deploy:pages
```

## 🛠️ Architektura techniczna

### Stos technologiczny frontendu
- **HTML5** - Nowoczesny język znaczników
- **CSS3** - Responsywny design i efekty animacji
- **Vanilla JavaScript** - Lekka interakcja po stronie klienta

### Stos technologiczny backendu
- **Cloudflare Workers** - Platforma obliczeń brzegowych
- **Web APIs** - Standardowy Fetch API i obsługa odpowiedzi

### Obsługiwane formaty protokołów
- **VMess** - Standardowy protokół V2Ray
- **VLESS** - Lekki protokół V2Ray (obsługuje Reality)
- **Shadowsocks** - Klasyczny protokół proxy
- **Trojan** - Nowoczesny protokół proxy

### Endpointy API
- `GET /` - Strona główna
- `POST /convert` - API do konwersji subskrypcji
- `GET /clash/{config-id}` - Pobierz plik konfiguracyjny YAML (link subskrypcji)
- `GET /yaml/{config-id}` - Pobierz plik YAML
- `OPTIONS /*` - Preflight CORS

## 📖 Instrukcja obsługi

### Podstawowe użycie

1. **Wprowadź link subskrypcji**
   - Wklej swój link subskrypcji proxy do pola wejściowego
   - Obsługuje linki subskrypcji kodowane Base64

2. **Ustaw nazwę konfiguracji**
   - Opcjonalnie ustaw własną nazwę pliku konfiguracyjnego
   - Domyślnie: "My Clash Config"

3. **Konwertuj konfigurację**
   - Kliknij przycisk "Konwertuj subskrypcję"
   - Poczekaj na zakończenie konwersji

4. **Użycie konfiguracji**
   - Skopiuj wygenerowaną konfigurację YAML
   - Zaimportuj ją do klienta Clash

5. **Użycie linku subskrypcji (zalecane)**
   - Skopiuj wygenerowany link subskrypcji
   - Dodaj subskrypcję w kliencie Clash
   - Konfiguracja będzie synchronizowana automatycznie, bez potrzeby ręcznej aktualizacji

### Konfiguracja zaawansowana

Wygenerowana konfiguracja Clash zawiera następujące funkcje:

- **Polityka grup proxy**
  - 🚀 Wybór węzła - ręczny wybór proxy
  - ♻️ Wybór automatyczny - wybór automatyczny na podstawie testu opóźnienia
  - 🎯 Połączenie globalne - bezpośrednie połączenie

- **Konfiguracja DNS**
  - Włączone rozwiązywanie DNS
  - Obsługa trybu fake-ip
  - Rozdzielanie DNS krajowy/zagraniczny

- **Zasady routingu**
  - Połączenie lokalnych adresów bezpośrednio
  - Połączenie krajowych IP bezpośrednio
  - Pozostały ruch przez proxy

## 🔧 Rozwiązywanie problemów z wdrożeniem

### Najczęstsze problemy

#### 1. Wrangler nie może znaleźć punktu wejścia
**Komunikat błędu**: `Missing entry-point to Worker script`

**Rozwiązanie**: 
- Upewnij się, że w katalogu głównym projektu znajduje się plik `wrangler.jsonc`
- Sprawdź, czy pole `main` w pliku `wrangler.jsonc` wskazuje na `worker.js`

#### 2. GitHub Actions - nieudane wdrożenie
**Rozwiązanie**:
- Dodaj poniższe sekrety w ustawieniach repozytorium GitHub:
  - `CLOUDFLARE_API_TOKEN`: Token API Cloudflare
  - `CLOUDFLARE_ACCOUNT_ID`: Identyfikator konta Cloudflare

#### 3. Nieudane budowanie Pages
**Rozwiązanie**:
- Ustaw polecenie budowania jako puste lub `echo "No build required"`
- Upewnij się, że katalog wyjściowy budowania jest ustawiony na `/`

### Opis plików konfiguracyjnych wdrożenia

- **`wrangler.jsonc`**: Konfiguracja CLI Wrangler, używana do wdrażania Worker
- **`_headers`**: Konfiguracja nagłówków HTTP dla Cloudflare Pages
- **`.github/workflows/deploy.yml`**: Konfiguracja automatycznego wdrażania przez GitHub Actions

## 🔧 Konfiguracja własna

### Modyfikacja grupy proxy

Możesz edytować funkcję `convertToClash` w pliku `worker.js`, aby dostosować grupy proxy:

```javascript
'proxy-groups': [
  {
    name: '🚀 节点选择',
    type: 'select',
    proxies: ['♻️ 自动选择', '🎯 全球直连', ...proxyNames]
  },
  // 添加更多代理组...
]
```

### Niestandardowe zasady routingu

Zmodyfikuj tablicę `rules`, aby dodać własne zasady routingu:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 节点选择',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 添加更多规则...
]
```

## 📊 Cechy wydajności

- **Globalne CDN** - Cloudflare obejmuje globalne węzły brzegowe
- **Szybka odpowiedź** - Średni czas odpowiedzi < 100ms
- **Wysoka dostępność** - 99,9% dostępności usług
- **Darmowy limit** - 100 000 żądań dziennie

## 🔒 Informacje o bezpieczeństwie

- **Prywatność danych** - Dane subskrypcji wykorzystywane są tylko podczas konwersji, nie są przechowywane
- **Szyfrowanie HTTPS** - Cała komunikacja szyfrowana jest przez HTTPS
- **Otwartość i przejrzystość** - Pełny kod źródłowy udostępniony do samodzielnej weryfikacji

## 🤝 Wskazówki dotyczące współpracy

Zapraszamy do zgłaszania Issue i Pull Requestów!

1. Sforkuj to repozytorium
2. Utwórz gałąź funkcji (`git checkout -b feature/AmazingFeature`)
3. Zatwierdź zmiany (`git commit -m 'Add some AmazingFeature'`)
4. Wypchnij na gałąź (`git push origin feature/AmazingFeature`)
5. Utwórz Pull Request

## 📝 Dziennik zmian

### v1.1.0
- ✅ Dodano wsparcie protokołu VLESS (w tym Reality Secure Transport)
- ✅ Ulepszona kompatybilność protokołów

### v1.0.0
- ✅ Podstawowa funkcja konwersji subskrypcji
- ✅ Estetyczny interfejs użytkownika
- ✅ Wsparcie dla Cloudflare Workers
- ✅ Obsługa wielu protokołów (VMess, Shadowsocks, Trojan)
- ✅ Projekt responsywny
- ✅ Funkcja kopiowania jednym kliknięciem

## 📞 Wsparcie i opinie

Jeśli napotkasz problemy podczas użytkowania lub masz sugestie, proszę:

1. Zapoznaj się z dokumentacją README
2. Zgłoś [Issue](../../issues)
3. Rozpocznij [Discussion](../../discussions)

## 📄 Licencja

Ten projekt korzysta z licencji MIT – szczegóły w pliku [LICENSE](LICENSE)

## 🙏 Podziękowania

- [Cloudflare Workers](https://workers.cloudflare.com/) – zapewnienie platformy obliczeniowej na brzegu sieci
- [Clash](https://github.com/Dreamacro/clash) – znakomity klient proxy
- Wsparcie wszystkich współtwórców i użytkowników

---

⭐ Jeśli ten projekt był dla Ciebie pomocny, daj mu gwiazdkę! 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---