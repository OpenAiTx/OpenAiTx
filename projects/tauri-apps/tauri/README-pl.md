<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stabilny-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![Licencja](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Serwer czatu](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![strona internetowa](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![wsparcie](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## Wprowadzenie

Tauri to framework do budowania małych, niezwykle szybkich plików wykonywalnych na wszystkie główne platformy desktopowe. Programiści mogą zintegrować dowolny framework frontendowy, który kompiluje się do HTML, JS i CSS do budowy interfejsu użytkownika. Backend aplikacji to plik binarny oparty na Rust z API, z którym interfejs frontendowy może się komunikować.

Interfejs użytkownika w aplikacjach Tauri obecnie wykorzystuje [`tao`](https://docs.rs/tao) jako bibliotekę do obsługi okien na macOS, Windows, Linux, Android oraz iOS. Do renderowania aplikacji Tauri wykorzystuje [WRY](https://github.com/tauri-apps/wry), bibliotekę zapewniającą zunifikowany interfejs do systemowego webview, używając WKWebView na macOS i iOS, WebView2 na Windows, WebKitGTK na Linux oraz Android System WebView na Androidzie.

Aby dowiedzieć się więcej o szczegółach integracji wszystkich tych komponentów, zapoznaj się z dokumentem [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md).

## Pierwsze kroki

Jeśli jesteś zainteresowany tworzeniem aplikacji tauri, odwiedź [stronę dokumentacji](https://tauri.app).

Najszybszym sposobem rozpoczęcia jest zainstalowanie [wymagań wstępnych](https://v2.tauri.app/start/prerequisites/) dla swojego systemu i utworzenie nowego projektu za pomocą [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage). Przykładowo za pomocą `npm`:

```sh
npm create tauri-app@latest
```

## Funkcje

Lista funkcji Tauri obejmuje, ale nie ogranicza się do:

- Wbudowany bundler aplikacji do tworzenia paczek aplikacji w formatach takich jak `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` oraz instalatorów Windows takich jak `.exe` (przez NSIS) i `.msi` (przez WiX).
- Wbudowany automatyczny updater (tylko desktop)
- Ikony w zasobniku systemowym
- Nattywne powiadomienia
- Nattywny protokół WebView (tauri nie tworzy lokalnego serwera http(s) do obsługi treści WebView)
- GitHub Action do usprawnionej integracji CI
- Rozszerzenie do VS Code

### Platformy

Tauri obecnie wspiera rozwój i dystrybucję na następujących platformach:

| Platforma   | Wersje                                                                                                         |
| :---------- | :------------------------------------------------------------------------------------------------------------- |
| Windows     | 7 i wyższe                                                                                                     |
| macOS       | 10.15 i wyższe                                                                                                 |
| Linux       | webkit2gtk 4.0 dla Tauri v1 (np. Ubuntu 18.04). webkit2gtk 4.1 dla Tauri v2 (np. Ubuntu 22.04).                |
| iOS/iPadOS  | 9 i wyższe                                                                                                     |
| Android     | 7 i wyższe (obecnie 8 i wyższe)                                                                                |

## Współtworzenie

Zanim zaczniesz pracować nad czymś, najlepiej sprawdzić, czy nie istnieje już odpowiednie zgłoszenie. Warto również zajrzeć na serwer Discord i potwierdzić z zespołem, czy ma to sens lub czy ktoś inny już nad tym pracuje.

Przed wysłaniem pull requesta upewnij się, że przeczytałeś [Przewodnik dla współtwórców](./.github/CONTRIBUTING.md).

Dziękujemy wszystkim, którzy przyczyniają się do rozwoju Tauri!

### Dokumentacja

Dokumentacja w systemie wielojęzycznym to trudne zagadnienie. W związku z tym preferujemy używanie dokumentacji wbudowanej bezpośrednio w kod źródłowy Rust i JS, gdzie to tylko możliwe. Zajrzyj do repozytorium hostującego stronę dokumentacji, aby uzyskać więcej informacji: <https://github.com/tauri-apps/tauri-docs>

## Partnerzy

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

Pełną listę sponsorów znajdziesz na naszej [stronie internetowej](https://tauri.app#sponsors) oraz [Open Collective](https://opencollective.com/tauri).

## Organizacja

Tauri ma na celu być zrównoważonym kolektywem opartym na zasadach, które kierują [zrównoważonymi społecznościami wolnego i otwartego oprogramowania](https://sfosc.org). W tym celu stało się Programem w ramach [Commons Conservancy](https://commonsconservancy.org/), a możesz wesprzeć projekt finansowo przez [Open Collective](https://opencollective.com/tauri).

## Licencje

Kod: (c) 2015 - obecnie - Program Tauri w ramach The Commons Conservancy.

MIT lub MIT/Apache 2.0, gdzie ma to zastosowanie.

Logo: CC-BY-NC-ND

- Oryginalne projekty logo Tauri: [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) oraz [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---