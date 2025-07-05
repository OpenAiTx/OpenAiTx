# TeamSpeak 6 Server - Beta Release README

Witamy w wersji Beta serwera TeamSpeak 6! Cieszymy się, że dołączasz do nas, by odkrywać nową generację TeamSpeak. Ten dokument pomoże Ci rozpocząć pracę oraz wskaże ważne szczegóły dotyczące obecnej wersji Beta.

Ponieważ jest to wersja Beta, niektóre funkcje są nadal w fazie rozwoju i możesz natrafić na błędy. Twoja opinia jest dla nas bardzo ważna i pomoże nam stworzyć stabilniejszą i pełniejszą wersję finalną.

<h2><img width="24" src="/icons/teamspeak_blue.svg">&nbsp;O TeamSpeak</h2>

Sprawdzony od prawie 25 lat, mamy rozwiązanie, które odpowiada potrzebom każdego. TeamSpeak oferuje idealną komunikację głosową dla graczy, edukacji i szkoleń, komunikacji biznesowej oraz kontaktu z przyjaciółmi i rodziną. Naszym głównym celem jest dostarczenie rozwiązania łatwego w użyciu, o wysokim poziomie bezpieczeństwa, doskonałej jakości dźwięku oraz niskim zużyciu zasobów systemowych i pasma.

## ℹ️ Status Beta & Znane Problemy
**To jest wydanie beta. Głównym celem jest zebranie różnorodnych opinii i identyfikacja potencjalnych problemów przed wydaniem wersji stabilnej.**

**Pliki serwera do samodzielnego hostowania:** Dedykowane oprogramowanie serwera TeamSpeak 6 jest nadal aktywnie rozwijane i nie posiada jeszcze pełnej funkcjonalności. Zobowiązujemy się do dostarczenia pełnego doświadczenia TS6 dla serwerów samodzielnie hostowanych.

**Niestabilność funkcji:** Niektóre z nowych funkcji mogą być niestabilne lub ulegać zmianom w miarę ich dalszego dopracowywania.

**Opinie są kluczowe:** Twoje doświadczenia są dla nas bezcenne, a Twoje uwagi niezwykle ważne. Prosimy o zgłaszanie wszelkich problemów lub sugestii na naszym [Forum Społeczności](https://community.teamspeak.com/c/teamspeak-6-server/45) lub bezpośrednio tutaj na [GitHub](https://github.com/teamspeak/teamspeak6-server/issues).

**Ograniczenia:** Zwróć uwagę, że **licencje serwera TeamSpeak 3 nie są kompatybilne** z serwerami TeamSpeak 6 i obecnie **nie ma dostępnej ścieżki migracji między tymi wersjami**.

**Licencja podglądowa:** W odpowiedzi na Wasze opinie serwer wyposażony jest obecnie w **tymczasową** licencję podglądową na 32 sloty, zapewniając większą elastyczność podczas okresu testowego. Należy pamiętać, że ta licencja jest **ważna tylko przez dwa miesiące**.

Dodatkowo, **nie jest jeszcze możliwe uzyskanie lub rozszerzenie licencji na większą dla TeamSpeak 6**.

Bardzo doceniamy Twoją cierpliwość i zrozumienie, gdy nadal pracujemy nad rozwiązaniami, które lepiej wesprą Twoje potrzeby w przyszłości.

## 👇 Pierwsze kroki z TS6
Aby rozpocząć korzystanie z klienta TeamSpeak 6, odwiedź naszą stronę [Pobierz](https://teamspeak.com/en/downloads/).

Informacje o samodzielnym hostowaniu znajdziesz w skróconym przewodniku poniżej. Najnowsze aktualizacje, ogłoszenia oraz możliwość udziału w społeczności TeamSpeak znajdziesz na naszym [Forum Społeczności](https://community.teamspeak.com/) oraz śledząc nas na [Twitterze](https://x.com/teamspeak).

Nie chcesz samodzielnie hostować lub po prostu potrzebujesz łatwiejszego sposobu na rozpoczęcie pracy z TeamSpeak 6? Możesz wynająć niezawodne i Oficjalne Serwery TeamSpeak 6 bezpośrednio u nas na stronie [TeamSpeak Communities](https://www.myteamspeak.com/communities).
## ⚙️ Konfiguracja
### Możesz skonfigurować swój serwer na trzy główne sposoby:

1. **Argumenty wiersza poleceń:** Przekaż opcje bezpośrednio podczas uruchamiania serwera (np. ./tsserver --default-voice-port 9987). Jest to przydatne dla tymczasowych zmian lub automatyzacji.

2. **Zmienne środowiskowe:** Ustaw zmienne środowiskowe przed uruchomieniem serwera. Jest to przydatne w Dockerze lub gdy chcesz uniknąć bałaganu w wierszu poleceń.

3. **Plik konfiguracyjny YAML:** Dla trwałej konfiguracji zalecamy użycie pliku tsserver.yaml. Domyślny plik konfiguracyjny możesz wygenerować przy użyciu flagi --write-config-file.

Kluczowe ustawienia, które możesz kontrolować, obejmują porty sieciowe (głosowe, transfer plików), połączenia z bazą danych (obsługa SQLite i MariaDB), powiązania IP oraz opcje logowania.

Pełną listę dostępnych opcji znajdziesz, uruchamiając serwer z flagą `--help` lub w pliku [CONFIG.md](https://raw.githubusercontent.com/teamspeak/teamspeak6-server/main/CONFIG.md).

### Uruchamianie serwera z plików binarnych
Jeśli nie korzystasz z Dockera, możesz uruchomić serwer bezpośrednio w swoim systemie operacyjnym.

<h2><img width="22" src="/icons/linux.svg">&nbsp;Na Linuksie:</h2>

Nadaj plikowi binarnemu serwera uprawnienia do wykonywania:
```sh
chmod +x tsserver
```

Uruchom serwer w terminalu, pamiętając o zaakceptowaniu licencji:

```sh
./tsserver --accept-license
```

<h2><img width="22" src="/icons/windows.svg">&nbsp;Na Windows:</h2>

Otwórz Wiersz polecenia lub PowerShell i przejdź do katalogu, w którym rozpakowałeś pliki serwera.

Uruchom plik wykonywalny serwera, pamiętając o zaakceptowaniu licencji:
```powershell
tsserver.exe
```

<h2><img width="32" src="/icons/docker.svg">&nbsp;Uruchamianie serwera w Dockerze (zalecane):</h2>
Docker to najłatwiejszy sposób na uruchomienie serwera TeamSpeak 6 w odizolowanym i łatwym do zarządzania środowisku.

### 1. Prosta komenda docker run:

Aby szybko rozpocząć, możesz użyć polecenia docker run.

```sh
docker run -it --rm \
  -p 9987:9987/udp \
  -p 30033:30033 \
  -e TSSERVER_LICENSE_ACCEPTED=accept \
  teamspeaksystems/teamspeak6-server:latest
```

### 2. Użycie docker-compose.yaml (dla konfiguracji trwałych):
To najlepsza praktyka, jeśli zamierzasz utrzymywać serwer przez dłuższy czas. Utwórz plik docker-compose.yaml:

```yaml
services:
  teamspeak:
    image: teamspeaksystems/teamspeak6-server:latest
    container_name: teamspeak-server
    restart: unless-stopped
    ports:
      - "9987:9987/udp"   # Port głosowy
      - "30033:30033/tcp" # Transfer plików
      # - "10080:10080/tcp" # Web Query
    environment:
```
      - TSSERVER_LICENSE_ACCEPTED=accept
    volumes:
      - teamspeak-data:/var/tsserver/

volumes:
  teamspeak-data:
```

## 🔗 Przydatne linki
[Oficjalna strona](https://teamspeak.com/en/)<br>
[Forum społeczności](https://community.teamspeak.com)<br>
[Zgłoszenia na GitHub](https://github.com/teamspeak/teamspeak6-server/issues)<br>

Twój udział i opinia pomogą nam kształtować przyszłość TeamSpeak! 💙<br>
Dziękujemy, że jesteś częścią programu TeamSpeak 6 Beta i przyczyniasz się do jego rozwoju! 🫡

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---