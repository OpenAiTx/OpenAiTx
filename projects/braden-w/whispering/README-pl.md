<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">Bezproblemowa dyktanda zasilana modelem Whisper od OpenAI</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## O aplikacji

Whispering to otwartoźródłowa aplikacja do transkrypcji, która zapewnia globalną funkcjonalność zamiany mowy na tekst, z opcjami takimi jak skróty klawiaturowe oraz automatyczne kopiowanie i wklejanie, aby dyktowanie było jak najbardziej płynne.

Wewnątrz aplikacji działa model Whisper od OpenAI, co sprawia, że jest ona znacznie dokładniejsza niż wbudowane funkcje dyktowania.

> **Ważna uwaga**: Whispering została zaprojektowana głównie jako narzędzie do transkrypcji, a nie do nagrywania. W przypadku dłuższych nagrań, gdzie niezawodność jest kluczowa, zalecam użycie dedykowanej aplikacji nagrywającej na telefonie lub innym urządzeniu korzystającym z natywnych API nagrywania. Zapewnia to optymalną jakość dźwięku oraz stabilność nagrania.

## Dema

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## Kluczowe funkcje

1. **Globalna transkrypcja**: Dostęp do funkcji zamiany mowy na tekst modelu Whisper w dowolnym miejscu za pomocą globalnego skrótu klawiaturowego lub w dwóch kliknięciach.
2. **Doświadczenie wieloplatformowe**:
   - Aplikacja desktopowa: Umożliwia globalną transkrypcję we wszystkich aplikacjach.
   - Rozszerzenie przeglądarki: Zapewnia globalną transkrypcję w przeglądarce, komunikując się z aplikacją webową.
3. **Integracja z czatem**: Rozszerzenie przeglądarki dodaje przycisk nagrywania na stronach ChatGPT i Claude, umożliwiając bezpośrednie wprowadzanie głosu i transkrypcję w interfejsie czatu.
4. **Zarządzanie transkrypcjami**: Przeglądaj i edytuj transkrypcje w aplikacji Whispering, aby zapewnić ich dokładność i przejrzystość.
5. **Automatyczna integracja ze schowkiem**: Po zakończeniu transkrypcji tekst jest automatycznie kopiowany do schowka. Dostępna jest również opcja automatycznego wklejania.

## Jak są przechowywane moje dane?

Whispering przechowuje możliwie najwięcej danych lokalnie na Twoim urządzeniu, w tym nagrania i transkrypcje tekstowe. Takie podejście zapewnia maksymalną prywatność i bezpieczeństwo danych. Oto przegląd sposobu zarządzania danymi:

1. **Lokalne przechowywanie**: Nagrania głosowe i transkrypcje są przechowywane w IndexedDB, która służy jako magazyn blobów oraz miejsce przechowywania wszystkich danych, takich jak teksty i transkrypcje.

2. **Usługa transkrypcji**: Jedynymi danymi wysyłanymi gdzie indziej jest Twoje nagranie do zewnętrznej usługi transkrypcji—jeśli taką wybierzesz. Masz do wyboru:
   - Usługi zewnętrzne, takie jak OpenAI lub Groq
   - Lokalną usługę transkrypcji, np. `faster-whisper-server`, która zapewnia, że wszystko pozostaje na urządzeniu

3. **Konfigurowalne ustawienia**: Możesz zmienić usługę transkrypcji w ustawieniach, aby zapewnić maksymalnie lokalne działanie.


## Instalacja

### Aplikacja webowa

Odwiedź [whispering.bradenwong.com](https://whispering.bradenwong.com/), gdzie znajduje się najnowsza wersja folderu `apps/app` hostowana na Vercel.

### Rozszerzenie Chrome

Zainstaluj rozszerzenie Chrome ze sklepu Chrome Web Store [tutaj](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo).

### Aplikacja desktopowa

Aby pobrać i zainstalować aplikację desktopową Whispering, wykonaj kroki odpowiednie dla Twojego systemu operacyjnego:

#### Windows

1. Pobierz pakiet instalacyjny z końcówką `.msi` ze [strony najnowszych wydań](https://github.com/braden-w/whispering/releases).
2. Otwórz pobrany plik `.msi`, aby uruchomić instalator.
3. Jeśli pojawi się ostrzeżenie o niebezpiecznym pliku, kliknij `Więcej informacji` -> `Uruchom mimo to`, aby kontynuować instalację.
4. Postępuj zgodnie z instrukcjami wyświetlanymi na ekranie, aby zakończyć instalację.

#### macOS

Dla macOS wykonaj następujące kroki, aby zainstalować Whispering:

1. **Pobierz pakiet instalacyjny**:
   - Odwiedź [stronę najnowszych wydań](https://github.com/braden-w/whispering/releases).
   - Wybierz odpowiedni pakiet:
     - Dla Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - Dla Intel: `Whispering_x.x.x_x64.dmg`

2. **Zainstaluj aplikację**:
   - Otwórz pobrany plik `.dmg`.
   - Przeciągnij aplikację Whispering do folderu Aplikacje.

3. **Uruchom Whispering**:
   - Otwórz Whispering z folderu Aplikacje.
   - Jeśli pojawi się ostrzeżenie o niezweryfikowanym deweloperze:
     - Kliknij `Anuluj`
     - Kliknij prawym przyciskiem myszy na aplikacji w Finderze i wybierz `Otwórz`

4. **Rozwiązywanie problemów** (tylko Apple Silicon):
   Jeśli pojawi się błąd `"Whispering" jest uszkodzona i nie może zostać otwarta`:
   - Otwórz Terminal
   - Wpisz następujące polecenie:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - Spróbuj ponownie otworzyć aplikację

Po wykonaniu tych kroków Whispering powinna być gotowa do użycia na Twoim systemie macOS.

#### Linux

Dla systemu Linux dostępnych jest kilka opcji instalacji. Wybierz odpowiednią dla swojego środowiska:

1. **AppImage**:

   - Pobierz plik `.AppImage` ze [strony najnowszych wydań](https://github.com/braden-w/whispering/releases).
   - Ustaw plik jako wykonywalny:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - Uruchom AppImage:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **Paczka DEB (Debian/Ubuntu)**:
   - Pobierz plik `.deb` ze [strony najnowszych wydań](https://github.com/braden-w/whispering/releases).
   - Zainstaluj paczkę za pomocą `dpkg`:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - Rozwiąż ewentualne problemy z zależnościami:
     ```bash
     sudo apt-get install -f
     ```

Po instalacji aplikacja będzie gotowa do użycia.

## Użytkowanie

### Rozszerzenie Chrome

Po zainstalowaniu rozszerzenia Chrome znajdziesz ikonę Whispering na pasku rozszerzeń Chrome. Kliknij tę ikonę, aby otworzyć rozszerzenie. Kliknij przycisk mikrofonu, aby nagrać głos, a następnie kliknij przycisk kwadratu, gdy zakończysz. Twoja transkrypcja pojawi się w polu tekstowym poniżej.

Aby uzyskać dostęp do funkcji ChatGPT lub Claude, przejdź na stronę ChatGPT lub Claude. W interfejsie czatu pojawi się nowy przycisk nagrywania. Kliknij ten przycisk, aby rozpocząć i zakończyć nagrywanie, a przepisany tekst zostanie automatycznie wstawiony do pola wprowadzania czatu.

Aby skorzystać ze skrótu, naciśnij <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> lub <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (później konfigurowalne przez skróty rozszerzenia Chrome), aby rozpocząć nagrywanie z dowolnej strony internetowej. Transkrypcja zostanie automatycznie skopiowana do schowka i wklejona do bieżącego pola tekstowego.

Rozszerzenie Chrome komunikuje się z [whispering.bradenwong.com](https://whispering.bradenwong.com) i automatycznie spróbuje utworzyć kartę w tle, jeśli jej nie znajdzie. Większość błędów wynika z niepowodzenia tej komunikacji, np. w rzadkich przypadkach, gdy karta przechodzi w stan uśpienia.

### Aplikacja webowa

Aplikacja webowa jest dostępna pod adresem [whispering.bradenwong.com](https://whispering.bradenwong.com). Kliknij przycisk mikrofonu, aby nagrać głos, a następnie kliknij przycisk kwadratu, gdy zakończysz. Twoja transkrypcja pojawi się w polu tekstowym.

### Aplikacja desktopowa

Po zainstalowaniu aplikacji desktopowej Whispering naciśnij <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (konfigurowalne w ustawieniach), aby rozpocząć nagrywanie z dowolnego miejsca na pulpicie. Transkrypcja zostanie automatycznie skopiowana do schowka i wklejona, choć obie funkcje można przełączać w ustawieniach.

## Zbudowano przy użyciu

#### Web i Desktop

Aplikacja Whispering została zbudowana przy użyciu następujących technologii i bibliotek:

- [Svelte 5](https://svelte.dev): Biblioteka reaktywności UI.
- [SvelteKit](https://kit.svelte.dev/docs): Do routingu i generowania statycznych stron, używany zarówno do tworzenia strony internetowej, jak i statycznego frontendu dla aplikacji Tauri.
- [Tauri](https://tauri.studio/en/docs/intro/): Framework aplikacji desktopowych.
- [Effect-TS](https://github.com/Effect-TS/effect): Do wprowadzenia programowania funkcyjnego i pisania ekstremalnie bezpiecznych typowo funkcji, gdzie błędy są częścią sygnatury zwracanej przez funkcję.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Prosta, konfigurowalna biblioteka powiadomień typu toast dla aplikacji Svelte. Używana do wyświetlania błędów przekazanych przez Effect-TS za pomocą funkcji `renderAsToast`.
- [TanStack Table](https://tanstack.com/table): Do obsługi wszystkich tabel danych.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): Niskopoziomowe API do przechowywania dużych ilości danych strukturalnych w przeglądarce. Synchronizowane z Tanstack Table.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): Wybrana biblioteka komponentów UI.
- [TailwindCSS](https://tailwindcss.com/docs): Framework CSS typu utility-first do szybkiego tworzenia niestandardowych interfejsów użytkownika.
- [Turborepo](https://turborepo.org/): Do zarządzania monorepo, dzięki czemu `apps/app` i `apps/extension` mogą współdzielić ten sam kod, znacząco redukując duplikację kodu i, co ważniejsze, utrzymując jedno źródło prawdy.
- [Rust](https://www.rust-lang.org): Do rozbudowy funkcji aplikacji desktopowej, np. użycie crate `enigo` do obsługi automatycznego wklejania.
- [Vercel](https://vercel.com/): Hosting odpowiedni do projektów hobbystycznych z dobrą integracją z Turborepo.
- [Zapsplat.com](https://www.zapsplat.com/): Biblioteka efektów dźwiękowych wolnych od tantiem.

#### Rozszerzenie

Rozszerzenie Chrome Whispering zostało zbudowane przy użyciu:

- [Plasmo](https://docs.plasmo.com/): Framework do tworzenia rozszerzeń Chrome. Używamy [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) do komunikacji ze stroną Whispering.
- [Effect-TS](https://github.com/Effect-TS/effect): Do wprowadzenia programowania funkcyjnego i pisania ekstremalnie bezpiecznych typowo funkcji, gdzie błędy są częścią sygnatury zwracanej przez funkcję.
- [React](https://reactjs.org): Biblioteka reaktywności UI dla rozszerzenia Chrome, ponieważ Plasmo niestety nie obsługuje Svelte 5.
- [ShadCN](https://github.com/shadcn): Biblioteka komponentów UI dla rozszerzenia Chrome.
- [TailwindCSS](https://tailwindcss.com/docs): Framework CSS oparty na narzędziach, umożliwiający szybkie tworzenie niestandardowych interfejsów użytkownika.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): API rozszerzeń Chrome.
- [Zapsplat.com](https://www.zapsplat.com/): Biblioteka darmowych efektów dźwiękowych.

## Uruchamianie Whispering w trybie lokalnym (deweloperskim)

Aby skonfigurować projekt na swoim komputerze, wykonaj następujące kroki:

1. Sklonuj repozytorium: `git clone https://github.com/braden-w/whispering.git`
2. Przejdź do katalogu projektu: `cd whispering`
3. Zainstaluj wymagane zależności: `pnpm i`

Aby uruchomić aplikację desktopową i stronę internetową Whispering w trybie deweloperskim:

4. Przejdź do katalogu aplikacji: `cd apps/app`
5. Uruchom serwer deweloperski: `pnpm tauri dev`

Aplikacja desktopowa powinna automatycznie się otworzyć do lokalnego rozwoju. Aby rozwijać aplikację webową, otwórz przeglądarkę i przejdź do `http://localhost:5173`.

Aby uruchomić rozszerzenie Chrome Whispering w trybie deweloperskim:

4. Przejdź do katalogu rozszerzenia: `cd apps/extension`
5. Uruchom serwer deweloperski: `pnpm dev --target=chrome-mv3`

Aby rozwijać rozszerzenie Chrome, załaduj je do Chrome, przechodząc do `chrome://extensions`, włącz tryb deweloperski i załaduj folder `apps/extension/build/{platform}-{manifest-version}-dev` jako rozszerzenie niepakowane.

## Zbuduj plik wykonywalny samodzielnie

Jeśli masz wątpliwości co do zaufania do instalatorów lub chcesz mieć większą kontrolę, zawsze możesz zbudować plik wykonywalny samodzielnie. Wymaga to dodatkowej konfiguracji, ale masz wtedy pewność, że uruchamiasz kod, którego oczekujesz. Taka jest zaleta oprogramowania open-source!

### Chrome

1. Przejdź do katalogu rozszerzenia: `cd apps/extension`
2. Zainstaluj wymagane zależności: `pnpm i`
3. Uruchom budowanie Plasmo: `pnpm plasmo build --target=chrome-mv3`
4. Wynik powinien znaleźć się w `apps/extension/build/chrome-mv3-prod`, który można załadować do Chrome jako rozszerzenie niepakowane.
5. Alternatywnie, możesz zbudować rozszerzenie do Chrome Web Store: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. Przejdź do katalogu rozszerzenia: `cd apps/extension`
2. Zainstaluj wymagane zależności: `pnpm i`
3. Uruchom budowanie Plasmo: `pnpm plasmo build --target=firefox-mv3`
4. Wynik powinien znaleźć się w `apps/extension/build/firefox-mv3-prod`, który można załadować do Chrome jako rozszerzenie niepakowane.
5. Alternatywnie, możesz zbudować rozszerzenie do Chrome Web Store: `pnpm plasmo build --target=firefox-mv3 --release`

### Desktop

1. Przejdź do katalogu aplikacji: `cd apps/app`
2. Zainstaluj wymagane zależności: `pnpm i`
3. Uruchom kompilację Tauri: `pnpm tauri build`
4. Plik wykonywalny znajdziesz w katalogu `apps/app/target/release`.

## Współtworzenie

Zapraszamy do współtworzenia projektu! Jeśli chcesz wnieść swój wkład do Whispering, wykonaj następujące kroki:

1. Forkuj repozytorium.
2. Utwórz nową gałąź dla swojej funkcji lub poprawki: `git checkout -b feature/twoja-funkcja` lub `git checkout -b fix/twoja-poprawka`
3. Wprowadź zmiany i zatwierdź je z opisowym komunikatem.
4. Wypchnij swoją gałąź do swojego repozytorium: `git push origin twoja-gałąź`
5. Utwórz pull request z forka do oryginalnego repozytorium.

Upewnij się, że Twój kod jest zgodny z ustalonymi konwencjami i jest dobrze udokumentowany.

## Licencja

Whispering jest wydawany na licencji [MIT License](https://opensource.org/licenses/MIT).

## Sponsorzy

Projekt wspierają następujący wspaniali ludzie i organizacje:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## Wsparcie i opinie

Jeśli napotkasz jakiekolwiek problemy lub masz sugestie dotyczące ulepszeń, otwórz zgłoszenie na [zakładce Issues na GitHub](https://github.com/braden-w/whispering/issues) lub skontaktuj się ze mną przez [whispering@bradenwong.com](mailto:whispering@bradenwong.com). Bardzo doceniam Twoją opinię!

Dziękuję za korzystanie z Whispering i życzę miłego pisania!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---