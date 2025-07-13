# Terminal Płatniczy NFC

Wielosieciowy terminal płatniczy NFC, który obsługuje płatności kryptowalutowe na 5 sieciach blockchain z monitorowaniem transakcji w czasie rzeczywistym oraz kompleksowym śledzeniem historii.

## 🌐 Obsługiwane Sieci

- **Ethereum**
- **Base**
- **Arbitrum**
- **Optimism**
- **Polygon**

### 🎯 **Priorytet Inteligentnych Płatności**

Zamiast negocjować z akceptantem kombinację sieci / tokena, terminal płatniczy obsługuje to automatycznie. Najpierw znajduje sieć, którą obsługuje akceptant i na której masz środki, a następnie wysyła transakcję w ETH lub tokenie ERC-20 zgodnie z następującym priorytetem:

```
L2 Stablecoin > L2 Inne > L2 ETH > L1 Stablecoin > L1 Inne > L1 ETH
```
## 🚀 Szybki start

1. **Zainstaluj zależności:**
   ```bash
   npm install
   ```

2. **Konfiguracja środowiska:**
   ```bash
   echo "ALCHEMY_API_KEY=twoj_klucz_api_alchemy_tutaj" > .env
   ```

3. **Uruchom terminal:**
   ```bash
   npm start
   ```

4. **Otwórz interfejs:**
   Przejdź do `http://localhost:3000`

## 🏗️ Architektura

```
src/
├── server.ts                   # Serwer Express & obsługa WebSocket
├── app.ts                      # Główny orkiestrator aplikacji
├── web/index.html              # Interfejs terminala płatniczego
├── config/index.ts             # Konfiguracja multi-chain
└── services/
    ├── nfcService.ts           # Czytnik NFC & skanowanie portfela
    ├── alchemyService.ts       # Saldo multi-chain & monitorowanie
    ├── paymentService.ts       # Wybór płatności & generowanie EIP-681
    ├── ethereumService.ts      # Narzędzia do walidacji adresów
    └── addressProcessor.ts     # Zapobieganie duplikowanemu przetwarzaniu
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # Instalacja zależności do budowy obrazu Raspberry Pi
    └── build-pi-image-osx.sh       # Budowanie obrazu Raspberry Pi
```
## 💡 Użytkowanie

### **Przetwarzanie płatności**
1. Wprowadź kwotę za pomocą klawiatury (w centach: "150" = 1,50 USD)
2. Naciśnij "Obciąż" aby rozpocząć płatność
3. Klient przykłada urządzenie NFC, aby przesłać płatność
4. Monitorowanie w czasie rzeczywistym potwierdza transakcję
5. Komunikat "Zatwierdzono" z linkiem do eksploratora bloków

### **Historia transakcji**
1. Naciśnij przycisk 📜 historii na klawiaturze
2. Przeglądaj wszystkie transakcje lub zeskanuj portfel, aby zobaczyć konkretną historię
3. Naciśnij "📱 Skanuj portfel po historię" i poproś klienta o przyłożenie urządzenia
4. Przeglądaj przefiltrowane transakcje dla tego konkretnego portfela


## 🔄 Przepływ płatności

1. **Wykrycie NFC** → Klient przykłada urządzenie
2. **Pobieranie Multi-Chain** → Analiza portfela na wszystkich 6 łańcuchach
3. **Inteligentny wybór** → Optymalny token płatności na podstawie systemu priorytetów
4. **Generowanie EIP-681** → Żądanie płatności z ID łańcucha
5. **Monitorowanie w czasie rzeczywistym** → WebSocket/polling dla potwierdzenia transakcji
6. **Rejestrowanie historii** → Transakcja zapisana z pełnymi metadanymi
## 🛡️ Monitorowanie transakcji

- **Monitorowanie WebSocket** dla Ethereum, Base, Arbitrum, Optimism, Polygon
- **Monitorowanie oparte na polling** jako alternatywa
- **Automatyczny timeout** po 5 minutach
- **Integracja z eksploratorem bloków** do weryfikacji transakcji
- **Śledzenie statusu**: wykryto → potwierdzono → niepowodzenie

## 🍓 Wdrażanie na Raspberry Pi

Ten terminal płatności NFC może być wdrożony jako **kiosk plug-and-play** na sprzęcie Raspberry Pi do zastosowań produkcyjnych.

### **Wymagania sprzętowe**
- Raspberry Pi 4B (zalecane 4GB+ RAM)
- 7" Oficjalny ekran dotykowy Raspberry Pi 
- **Czytnik NFC ACR1252U-M1** (obsługiwany specjalnie)
- Karta MicroSD 32GB lub większa

### **Funkcje wdrożeniowe**
- **Budowa jednym poleceniem** tworzy rozruchowy obraz karty SD
- **Wstępnie skonfigurowane WiFi** i dane uwierzytelniające API
- **Automatyczny start** w trybie pełnoekranowego kiosku
- **Weryfikacja bezpieczeństwa** uniemożliwia wdrożenie z adresami testowymi
- Wsparcie budowania dla **macOS i Linux**
### **Szybkie wdrożenie**
```bash
# Przejdź do skryptów wdrożeniowych
cd scripts/rpi-deploy

# Skonfiguruj swoje wdrożenie
cp build-config.env.template build-config.env
# Edytuj build-config.env, wpisując swoje dane WiFi, klucz API i adres punktu handlowego

# Zbuduj obraz startowy (macOS)
./build-pi-image-osx.sh

# Wgraj wygenerowany plik nfc-terminal-<date>.img.gz na kartę SD za pomocą Raspberry Pi Imager i uruchom!
```

📖 **[Kompletny przewodnik wdrożeniowy](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---