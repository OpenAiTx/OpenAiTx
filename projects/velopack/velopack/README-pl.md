<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-white.svg">
  <img alt="Logo Velopack" src="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-black.svg" width="400">
</picture>

---

[![Nuget](https://img.shields.io/nuget/v/Velopack?style=flat-square&logo=nuget&logoColor=white)](https://www.nuget.org/packages/Velopack/)
[![Discord](https://img.shields.io/badge/chat-Discord-5865F2?style=flat-square&logo=discord&logoColor=white)](https://discord.gg/M6he8ZPAAJ)
[![Build](https://img.shields.io/github/actions/workflow/status/velopack/velopack/build.yml?branch=develop&style=flat-square&logo=github&logoColor=white)](https://github.com/velopack/velopack/actions)
[![Codecov](https://img.shields.io/codecov/c/github/velopack/velopack?style=flat-square&logo=codecov&logoColor=white)](https://app.codecov.io/gh/velopack/velopack)
[![License](https://img.shields.io/github/license/velopack/velopack?style=flat-square)](https://github.com/velopack/velopack/blob/develop/LICENSE)


Velopack to framework do instalacji i automatycznych aktualizacji aplikacji wieloplatformowych. Jest opiniotwórczy, niezwykle łatwy w użyciu i nie wymaga żadnej konfiguracji. Za pomocą jednego polecenia możesz mieć gotową aplikację do instalacji, a dla użytkowników wszystko działa błyskawicznie.

## Funkcje

- 😍 **Zero konfiguracji** – Velopack przyjmuje wynik kompilatora i generuje instalator, aktualizacje, paczki delta oraz samodzielnie aktualizującą się paczkę przenośną w jednym poleceniu.
- 🎯 **Wieloplatformowość** – Velopack umożliwia budowanie paczek na **Windows**, **OSX** i **Linux**, więc możesz korzystać z jednego rozwiązania dla każdego celu.
- 🚀 **Automatyczne migracje** - Jeśli korzystasz z innych popularnych frameworków (np. [Squirrel](https://github.com/Squirrel/Squirrel.Windows)), Velopack może automatycznie zmigrować Twoją aplikację.
- ⚡️ **Błyskawiczna prędkość** – Velopack został napisany w Rust, aby zapewnić natywną wydajność. Paczki delta oznaczają, że użytkownik pobiera tylko to, co zmieniło się między wersjami.
- 📔 **Niezależność od języka programowania** - Obsługuje C#, C++, JS, Rust i inne. Wykorzystaj znane API do aktualizacji niezależnie od języka projektu.

https://github.com/velopack/velopack/assets/1287295/0ff1bea7-15ed-42ae-8bdd-9519f1033432

## Dokumentacja
- 📖 [Przeczytaj dokumentację](https://docs.velopack.io/)
- ⚡ [Przewodniki szybkiego startu](https://docs.velopack.io/category/quick-start)
- 🕶️ [Zobacz przykładowe aplikacje](https://docs.velopack.io/category/sample-apps)
- 📺 [Strona internetowa i demo](https://velopack.io/)

## Społeczność
- ❓ Zadawaj pytania, uzyskaj wsparcie lub podyskutuj na [Discordzie](https://discord.gg/CjrCrNzd3F)
- 🗣️ Zgłaszaj błędy lub prośby o nowe funkcje na [GitHub Issues](https://github.com/velopack/velopack/issues)

## Współtworzenie
- 💬 Dołącz do nas na [Discordzie](https://discord.gg/CjrCrNzd3F), aby brać udział w dyskusjach deweloperskich
- 🚦 Przeczytaj nasz [przewodnik współtworzenia](https://docs.velopack.io/category/contributing)

## Opinie użytkowników 
Mam już swoją aplikację skierowaną na zewnątrz, która korzysta z velopack. Jestem pod ogromnym wrażeniem. Wszystko działa znakomicie i jest znacznie szybsze zarówno podczas początkowego budowania, jak i aktualizacji oprogramowania na komputerze użytkownika końcowego niż w przypadku Squirrela. To niesamowite i najlepszy instalator, jakiego używałem przez ponad 30 lat programowania. Dziękuję bardzo! Robicie świetną robotę!
[- Stefan (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1195642674078830613)

Chciałem tylko bardzo podziękować. Korzystałem z Clowd.Squirrel przez kilka lat, odkąd Squirrel.Windows przestał mi działać. Wszedłem dziś do tamtego repozytorium, żeby poszukać dokumentacji, i zauważyłem wydanie Velopack. Jakie zaskoczenie! Działa fantastycznie i jest o wiele szybszy, wow! Jeszcze raz dziękuję, ilość pracy włożonej zarówno w Clowd.Squirrel, jak i Velopack jest ogromna. Bardzo to doceniam.
[- Kizari (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1200837489640878180)

Korzystałem z wielu frameworków instalatorów, ale Velopack jest zdecydowanie najlepszy. Wszystko działa jak magia: uruchamiasz instalator i aplikacja po prostu się otwiera, gotowa do użycia. Aktualizacje są stosowane i uruchamiane ponownie w ~2 sekundy, bez okien UAC. Proces tworzenia instalatora jest bezbolesny i łatwo integruje się z podpisywaniem kodu, a narzędzie wiersza poleceń umożliwia łatwe przesyłanie plików aktualizatora. Nie musisz bawić się osobnymi skryptami instalatora w jakimś dziwnym języku; możesz zbudować wszystkie te haki w głównej aplikacji! Wsparcie również jest fenomenalne; każde moje zastrzeżenie zostało rozwiązane. To przyszłość instalatorów desktopowych.
[- RandomEngy (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1200897478036299861)

Jestem bardzo pod wrażeniem wydajności Velopacka przy tworzeniu wydań, a także przy sprawdzaniu i stosowaniu aktualizacji. Jest zdecydowanie szybszy niż inne narzędzia. CLI vpk jest intuicyjne i łatwe do wdrożenia, nawet w moim złożonym pipeline'ie budowania. Dzięki Velopack udało mi się usprawnić workflow i zaoszczędzić cenny czas. To fantastyczne narzędzie, które bardzo polecam!
[- khdc (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1216460920696344576)


---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---