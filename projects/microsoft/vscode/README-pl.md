# Visual Studio Code - Open Source ("Code - OSS")

[![Prośby o funkcje](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Błędy](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## Repozytorium

To repozytorium ("`Code - OSS`") jest miejscem, w którym my (Microsoft) rozwijamy produkt [Visual Studio Code](https://code.visualstudio.com) wspólnie ze społecznością. Nie tylko pracujemy tutaj nad kodem i zgłoszeniami, ale również publikujemy naszą [mapę drogową](https://github.com/microsoft/vscode/wiki/Roadmap), [miesięczne plany iteracji](https://github.com/microsoft/vscode/wiki/Iteration-Plans) oraz [plany końcowe](https://github.com/microsoft/vscode/wiki/Running-the-Endgame). Ten kod źródłowy jest dostępny dla wszystkich na standardowej [licencji MIT](https://github.com/microsoft/vscode/blob/main/LICENSE.txt).

## Visual Studio Code

<p align="center">
  <img alt="VS Code w akcji" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com) to dystrybucja repozytorium `Code - OSS` z dodatkowymi, specyficznymi dla Microsoftu modyfikacjami wydawana na podstawie tradycyjnej [licencji produktu Microsoft](https://code.visualstudio.com/License/).

[Visual Studio Code](https://code.visualstudio.com) łączy prostotę edytora kodu z tym, czego programiści potrzebują do podstawowego cyklu edycji, kompilacji i debugowania. Zapewnia kompleksową edycję, nawigację i wsparcie zrozumienia kodu wraz z lekkim debugowaniem, bogatym modelem rozszerzalności oraz łatwą integracją z istniejącymi narzędziami.

Visual Studio Code jest aktualizowany co miesiąc o nowe funkcje i poprawki błędów. Możesz pobrać go dla Windows, macOS i Linux na [stronie Visual Studio Code](https://code.visualstudio.com/Download). Aby codziennie otrzymywać najnowsze wydania, zainstaluj [wersję Insiders](https://code.visualstudio.com/insiders).

## Współtworzenie

Istnieje wiele sposobów, w jakie możesz uczestniczyć w tym projekcie, na przykład:

* [Zgłaszanie błędów i propozycji nowych funkcji](https://github.com/microsoft/vscode/issues) oraz pomoc w ich weryfikacji podczas sprawdzania
* Przeglądanie [zmian w kodzie źródłowym](https://github.com/microsoft/vscode/pulls)
* Przeglądanie [dokumentacji](https://github.com/microsoft/vscode-docs) i zgłaszanie pull requestów dotyczących wszystkiego – od literówek po nową i dodatkową treść

Jeśli jesteś zainteresowany naprawą błędów i bezpośrednim wkładem do kodu źródłowego,
zapoznaj się z dokumentem [Jak współtworzyć](https://github.com/microsoft/vscode/wiki/How-to-Contribute), który obejmuje następujące tematy:

* [Jak zbudować i uruchomić projekt ze źródeł](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [Przebieg pracy deweloperskiej, w tym debugowanie i uruchamianie testów](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [Wytyczne dotyczące kodowania](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [Zgłaszanie pull requestów](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [Znajdowanie problemów do pracy](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [Współtworzenie tłumaczeń](https://aka.ms/vscodeloc)

## Opinie

* Zadawaj pytania na [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode)
* [Zgłoś nową funkcję](CONTRIBUTING.md)
* Głosuj na [popularne prośby o funkcje](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [Zgłoś problem](https://github.com/microsoft/vscode/issues)
* Dołącz do społeczności twórców rozszerzeń na [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) lub [Slacku](https://aka.ms/vscode-dev-community)
* Obserwuj [@code](https://twitter.com/code) i daj nam znać, co myślisz!

Zobacz nasze [wiki](https://github.com/microsoft/vscode/wiki/Feedback-Channels) po opis każdego z tych kanałów oraz informacje o innych dostępnych kanałach prowadzonych przez społeczność.

## Powiązane projekty

Wiele kluczowych komponentów i rozszerzeń do VS Code znajduje się w osobnych repozytoriach na GitHubie. Na przykład repozytoria [node debug adapter](https://github.com/microsoft/vscode-node-debug) oraz [mono debug adapter](https://github.com/microsoft/vscode-mono-debug) są od siebie oddzielone. Pełną listę znajdziesz na stronie [Powiązane projekty](https://github.com/microsoft/vscode/wiki/Related-Projects) w naszym [wiki](https://github.com/microsoft/vscode/wiki).

## Wbudowane rozszerzenia

VS Code zawiera zestaw wbudowanych rozszerzeń znajdujących się w folderze [extensions](extensions), obejmujących gramatyki i fragmenty kodu dla wielu języków. Rozszerzenia zapewniające zaawansowaną obsługę języka (podpowiedzi kodu, przejście do definicji) mają sufiks `language-features`. Na przykład rozszerzenie `json` zapewnia kolorowanie dla `JSON`, a rozszerzenie `json-language-features` zapewnia bogate wsparcie językowe dla `JSON`.

## Kontener developerski

To repozytorium zawiera kontener developerski Visual Studio Code Dev Containers / GitHub Codespaces.

* W przypadku [Dev Containers](https://aka.ms/vscode-remote/download/containers) użyj polecenia **Dev Containers: Clone Repository in Container Volume...**, które tworzy wolumin Dockera dla lepszej wydajności dysku na macOS i Windows.
  * Jeśli masz już zainstalowane VS Code i Dockera, możesz również kliknąć [tutaj](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode), aby rozpocząć. Spowoduje to automatyczną instalację rozszerzenia Dev Containers (jeśli jest potrzebne), sklonowanie kodu źródłowego do woluminu kontenera oraz uruchomienie kontenera developerskiego do użycia.

* W przypadku Codespaces zainstaluj rozszerzenie [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) w VS Code i użyj polecenia **Codespaces: Create New Codespace**.

Docker / Codespace powinien mieć co najmniej **4 rdzenie CPU i 6 GB RAM (zalecane 8 GB)** do pełnej kompilacji. Więcej informacji znajdziesz w [README kontenera developerskiego](.devcontainer/README.md).

## Kodeks postępowania

Ten projekt przyjął [Kodeks postępowania Microsoft Open Source](https://opensource.microsoft.com/codeofconduct/). Więcej informacji znajdziesz w [FAQ dotyczących Kodeksu postępowania](https://opensource.microsoft.com/codeofconduct/faq/) lub kontaktując się pod adresem [opencode@microsoft.com](mailto:opencode@microsoft.com) w przypadku dodatkowych pytań lub uwag.

## Licencja

Copyright (c) Microsoft Corporation. Wszelkie prawa zastrzeżone.

Licencjonowane na podstawie [licencji MIT](LICENSE.txt).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---