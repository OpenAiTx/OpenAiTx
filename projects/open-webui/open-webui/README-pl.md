# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI to [rozszerzalna](https://docs.openwebui.com/features/plugin/), bogata w funkcje i przyjazna dla użytkownika, samodzielnie hostowana platforma AI zaprojektowana do pracy całkowicie offline.** Obsługuje różne silniki LLM, takie jak **Ollama** i **API zgodne z OpenAI**, z **wbudowanym silnikiem inferencyjnym** do RAG, czyniąc ją **potężnym rozwiązaniem do wdrażania AI**.

![Open WebUI Demo](./demo.gif)

> [!TIP]  
> **Szukasz [Planu dla Firm](https://docs.openwebui.com/enterprise)?** – **[Porozmawiaj z naszym zespołem sprzedaży już dziś!](mailto:sales@openwebui.com)**
>
> Uzyskaj **rozszerzone możliwości**, w tym **dostosowywanie motywów i brandingu**, **wsparcie SLA**, **wersje LTS** i **więcej!**

Więcej informacji znajdziesz w naszej [Dokumentacji Open WebUI](https://docs.openwebui.com/).

## Kluczowe funkcje Open WebUI ⭐

- 🚀 **Bezproblemowa instalacja**: Łatwa instalacja z użyciem Dockera lub Kubernetesa (kubectl, kustomize lub helm) dla bezproblemowego doświadczenia z obsługą obrazów z tagami `:ollama` i `:cuda`.

- 🤝 **Integracja API Ollama/OpenAI**: Bezproblemowa integracja API zgodnych z OpenAI dla wszechstronnych rozmów obok modeli Ollama. Dostosuj URL API OpenAI, aby połączyć się z **LMStudio, GroqCloud, Mistral, OpenRouter i innymi**.

- 🛡️ **Granularne uprawnienia i grupy użytkowników**: Administratorzy mogą tworzyć szczegółowe role i uprawnienia użytkowników, zapewniając bezpieczne środowisko. Ta szczegółowość zwiększa bezpieczeństwo i pozwala na personalizację doświadczeń użytkowników, budując poczucie odpowiedzialności.

- 📱 **Responsywny design**: Ciesz się płynną obsługą na komputerach, laptopach i urządzeniach mobilnych.

- 📱 **Progresywna aplikacja webowa (PWA) na urządzenia mobilne**: Doświadcz wrażeń podobnych do natywnej aplikacji dzięki PWA, zapewniającej dostęp offline na localhost i intuicyjny interfejs.

- ✒️🔢 **Pełna obsługa Markdown i LaTeX**: Wznieś swoje doświadczenia z LLM dzięki obszernej obsłudze Markdown i LaTeX dla bogatszej interakcji.

- 🎤📹 **Rozmowy głosowe/wideo bez użycia rąk**: Prowadź rozmowy zintegrowane z funkcjami głosowymi i wideo, dla bardziej dynamicznego i interaktywnego środowiska czatu.

- 🛠️ **Kreator modeli**: Łatwo twórz modele Ollama przez Web UI. Twórz i dodawaj własne postacie/agentów, dostosowuj elementy czatu i importuj modele dzięki integracji ze [Społecznością Open WebUI](https://openwebui.com/).

- 🐍 **Natywne narzędzie wywołań funkcji Pythona**: Wzbogacaj LLM o wbudowany edytor kodu w przestrzeni narzędzi. Dodaj własne funkcje Pythona (BYOF), umożliwiając łatwą integrację z LLM.

- 📚 **Lokalna integracja RAG**: Przyszłość czatów dzięki przełomowemu wsparciu Retrieval Augmented Generation (RAG). Funkcja ta płynnie integruje interakcje z dokumentami w czacie. Możesz ładować dokumenty bezpośrednio do czatu lub dodawać pliki do biblioteki i korzystać z nich przez komendę `#` przed zapytaniem.

- 🔍 **Wyszukiwanie w sieci dla RAG**: Przeprowadzaj wyszukiwania w sieci korzystając z dostawców takich jak `SearXNG`, `Google PSE`, `Brave Search`, `serpstack`, `serper`, `Serply`, `DuckDuckGo`, `TavilySearch`, `SearchApi` i `Bing` i wstawiaj wyniki bezpośrednio do czatu.

- 🌐 **Możliwość przeglądania stron www**: Integruj strony internetowe w czacie za pomocą komendy `#` i adresu URL. Ta funkcja pozwala włączać treści internetowe bezpośrednio do rozmów.

- 🎨 **Integracja generowania obrazów**: Bezproblemowo korzystaj z generowania obrazów przy użyciu takich opcji jak AUTOMATIC1111 API, ComfyUI (lokalnie) oraz DALL-E od OpenAI (zewnętrznie), wzbogacając czat o dynamiczne treści wizualne.

- ⚙️ **Rozmowy z wieloma modelami**: Korzystaj jednocześnie z różnych modeli, wykorzystując ich mocne strony dla optymalnych odpowiedzi. Zwiększ efektywność dzięki pracy kilku modeli równolegle.

- 🔐 **Kontrola dostępu oparta na rolach (RBAC)**: Zapewnij bezpieczny dostęp z ograniczonymi uprawnieniami; tylko upoważnione osoby mają dostęp do Ollama, a prawa do tworzenia/pobierania modeli są zarezerwowane dla administratorów.

- 🌐🌍 **Obsługa wielu języków**: Korzystaj z Open WebUI w wybranym języku dzięki wsparciu i18n. Pomóż nam rozszerzać liczbę obsługiwanych języków! Aktywnie szukamy współtwórców!

- 🧩 **Pipelines, wsparcie wtyczek Open WebUI**: Integruj własną logikę i biblioteki Pythona w Open WebUI przez [Pipelines Plugin Framework](https://github.com/open-webui/pipelines). Uruchom swoją instancję Pipelines, ustaw URL OpenAI na URL Pipelines i odkrywaj nieograniczone możliwości. [Przykłady](https://github.com/open-webui/pipelines/tree/main/examples) to **Wywoływanie funkcji**, **Ograniczanie liczby użytkowników**, **Monitorowanie użycia** narzędziami jak Langfuse, **Tłumaczenie na żywo z LibreTranslate**, **Filtrowanie toksycznych wiadomości** i wiele więcej.

- 🌟 **Ciągłe aktualizacje**: Regularnie ulepszamy Open WebUI, wdrażając nowe funkcje i poprawki.

Chcesz dowiedzieć się więcej o funkcjach Open WebUI? Zobacz nasze [dokumentacje funkcji Open WebUI](https://docs.openwebui.com/features) dla pełnego przeglądu!

## Sponsorzy 🙌

#### Szmaragd

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • Czy twoja aplikacja ma już backend?<br>Wypróbuj <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • Inteligentny terminal dla deweloperów
    </td>
  </tr>
</table>

---

Jesteśmy ogromnie wdzięczni naszym sponsorom za ich wsparcie. Ich wkład pomaga nam utrzymywać i rozwijać projekt, byśmy mogli nadal dostarczać wysoką jakość społeczności. Dziękujemy!

## Jak zainstalować 🚀

### Instalacja przez Python pip 🐍

Open WebUI można zainstalować za pomocą pip, instalatora pakietów Pythona. Przed rozpoczęciem upewnij się, że używasz **Pythona 3.11**, aby uniknąć problemów ze zgodnością.

1. **Instalacja Open WebUI**:
   Otwórz terminal i uruchom poniższe polecenie, aby zainstalować Open WebUI:

   ```bash
   pip install open-webui
   ```

2. **Uruchamianie Open WebUI**:
   Po instalacji uruchom Open WebUI poleceniem:

   ```bash
   open-webui serve
   ```

To uruchomi serwer Open WebUI, dostępny pod adresem [http://localhost:8080](http://localhost:8080)

### Szybki start z Dockerem 🐳

> [!NOTE]  
> W niektórych środowiskach Docker może być wymagane dodatkowe skonfigurowanie. W przypadku problemów z połączeniem zapoznaj się z naszym przewodnikiem w [Dokumentacji Open WebUI](https://docs.openwebui.com/).

> [!WARNING]
> Instalując Open WebUI przez Dockera, pamiętaj o dodaniu `-v open-webui:/app/backend/data` do polecenia Docker. To kluczowe, by baza danych została poprawnie zamontowana i nie doszło do utraty danych.

> [!TIP]  
> Jeśli chcesz korzystać z Open WebUI z dołączonym Ollama lub akceleracją CUDA, zalecamy użycie oficjalnych obrazów z tagiem `:cuda` lub `:ollama`. Aby uruchomić CUDA, zainstaluj [Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/) na swoim systemie Linux/WSL.

### Instalacja z domyślną konfiguracją

- **Jeśli Ollama jest na twoim komputerze**, użyj tego polecenia:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Jeśli Ollama jest na innym serwerze**, użyj tego polecenia:

  Aby połączyć się z Ollama na innym serwerze, zmień `OLLAMA_BASE_URL` na URL tego serwera:

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Aby uruchomić Open WebUI z obsługą GPU Nvidia**, użyj tego polecenia:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### Instalacja tylko do użytku z API OpenAI

- **Jeśli korzystasz wyłącznie z API OpenAI**, użyj tego polecenia:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### Instalacja Open WebUI z dołączonym wsparciem Ollama

Ta metoda instalacji wykorzystuje pojedynczy obraz kontenera, który zawiera Open WebUI wraz z Ollama, umożliwiając szybkie uruchomienie jednym poleceniem. Wybierz odpowiednie polecenie w zależności od sprzętu:

- **Z obsługą GPU**:
  Wykorzystaj zasoby GPU, uruchamiając poniższe polecenie:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **Tylko CPU**:
  Jeśli nie używasz GPU, użyj tego polecenia:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

Oba polecenia umożliwiają bezproblemową instalację zarówno Open WebUI, jak i Ollama, zapewniając szybkie uruchomienie.

Po instalacji uzyskasz dostęp do Open WebUI pod adresem [http://localhost:3000](http://localhost:3000). Miłego korzystania! 😄

### Inne metody instalacji

Oferujemy różne alternatywy instalacyjne, w tym natywną instalację bez Dockera, Docker Compose, Kustomize oraz Helm. Odwiedź naszą [Dokumentację Open WebUI](https://docs.openwebui.com/getting-started/) lub dołącz do naszej [społeczności Discord](https://discord.gg/5rJgQTnV4s) po szczegółowe wskazówki.

### Rozwiązywanie problemów

Masz problemy z połączeniem? Sprawdź naszą [Dokumentację Open WebUI](https://docs.openwebui.com/troubleshooting/). Po dalszą pomoc i by dołączyć do naszej społeczności, odwiedź [Open WebUI Discord](https://discord.gg/5rJgQTnV4s).

#### Open WebUI: Błąd połączenia z serwerem

Jeśli masz problemy z połączeniem, często wynika to z tego, że kontener WebUI nie może połączyć się z serwerem Ollama na 127.0.0.1:11434 (host.docker.internal:11434) wewnątrz kontenera. Użyj flagi `--network=host` w poleceniu docker, aby to rozwiązać. Zauważ, że port zmienia się z 3000 na 8080, więc adres to: `http://localhost:8080`.

**Przykładowe polecenie Docker**:

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Aktualizacja Dockera do najnowszej wersji

Aby zaktualizować lokalną instalację Dockera do najnowszej wersji, możesz użyć [Watchtower](https://containrrr.dev/watchtower/):

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

W ostatniej części polecenia zamień `open-webui` na nazwę swojego kontenera, jeśli jest inna.

Sprawdź nasz przewodnik aktualizacji w [Dokumentacji Open WebUI](https://docs.openwebui.com/getting-started/updating).

### Używanie gałęzi deweloperskiej 🌙

> [!WARNING]
> Gałąź `:dev` zawiera najnowsze, niestabilne funkcje i zmiany. Używasz jej na własne ryzyko – mogą wystąpić błędy lub niepełne funkcje.

Aby wypróbować najnowsze funkcje i nie przeszkadza ci niestabilność, użyj tagu `:dev`:

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### Tryb offline

Jeśli uruchamiasz Open WebUI w środowisku offline, ustaw zmienną środowiskową `HF_HUB_OFFLINE` na `1`, aby zapobiec próbom pobierania modeli z Internetu.

```bash
export HF_HUB_OFFLINE=1
```

## Co dalej? 🌟

Odkryj nadchodzące funkcje na naszej mapie drogowej w [Dokumentacji Open WebUI](https://docs.openwebui.com/roadmap/).

## Licencja 📜

Ten projekt jest licencjonowany na [Licencji Open WebUI](LICENSE), zmodyfikowanej licencji BSD-3-Clause. Otrzymujesz wszystkie prawa klasycznej licencji BSD-3: możesz używać, modyfikować i dystrybuować oprogramowanie, także w produktach komercyjnych i zamkniętych, z minimalnymi ograniczeniami. Jedynym dodatkowym wymogiem jest zachowanie brandingu "Open WebUI", zgodnie z plikiem LICENSE. Pełne warunki znajdziesz w [dokumencie LICENSE](LICENSE). 📄

## Wsparcie 💬

Masz pytania, sugestie lub potrzebujesz pomocy? Otwórz zgłoszenie lub dołącz do naszej
[społeczności Discord Open WebUI](https://discord.gg/5rJgQTnV4s), aby się z nami skontaktować! 🤝

## Historia gwiazdek

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

Utworzone przez [Timothy Jaeryang Baek](https://github.com/tjbck) – sprawmy, by Open WebUI było jeszcze lepsze, razem! 💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---