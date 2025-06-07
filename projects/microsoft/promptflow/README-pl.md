# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> Zapraszamy do współtworzenia prompt flow poprzez udział w [dyskusjach](https://github.com/microsoft/promptflow/discussions),
> zgłaszanie [problemów](https://github.com/microsoft/promptflow/issues/new/choose),
> przesyłanie [PR-ów](https://github.com/microsoft/promptflow/pulls).

**Prompt flow** to zestaw narzędzi deweloperskich zaprojektowanych do usprawnienia pełnego cyklu rozwoju aplikacji AI opartych na LLM, od ideacji, prototypowania, testowania, ewaluacji po wdrożenie produkcyjne i monitorowanie. Ułatwia inżynierię promptów i umożliwia budowanie aplikacji LLM o jakości produkcyjnej.

Dzięki prompt flow będziesz mógł/mogła:

- **Tworzyć i iteracyjnie rozwijać flow**
    - Tworzyć wykonywalne [flowy](https://microsoft.github.io/promptflow/concepts/concept-flows.html), które łączą LLM-y, prompty, kod Pythona i inne [narzędzia](https://microsoft.github.io/promptflow/concepts/concept-tools.html).
    - Debugować i rozwijać swoje flowy, szczególnie [śledząc interakcje z LLM](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) w prosty sposób.
- **Ewaluować jakość i wydajność flow**
    - Ewaluować jakość i wydajność flow na większych zbiorach danych.
    - Zintegrować testowanie i ewaluację z systemem CI/CD, aby zapewnić jakość flow.
- **Usprawniony cykl rozwoju do produkcji**
    - Wdrażać flow na wybraną platformę serwującą lub łatwo integrować go z kodem swojej aplikacji.
    - (Opcjonalnie, ale wysoce zalecane) Współpracować z zespołem, korzystając z wersji chmurowej [Prompt flow w Azure AI](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2).

------

## Instalacja

Aby szybko rozpocząć pracę, możesz skorzystać z gotowego środowiska deweloperskiego. **Kliknij poniższy przycisk**, aby otworzyć repozytorium w GitHub Codespaces, a następnie kontynuuj czytanie readme!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

Jeśli chcesz zacząć w swoim lokalnym środowisku, najpierw zainstaluj pakiety:

Upewnij się, że masz środowisko python, zalecana wersja to `python>=3.9, <=3.11`.

```sh
pip install promptflow promptflow-tools
```

## Szybki start ⚡

**Stwórz chatbota z prompt flow**

Uruchom polecenie, aby zainicjować prompt flow z szablonu czatu — utworzy to folder o nazwie `my_chatbot` i wygeneruje wymagane pliki w jego obrębie:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**Ustaw połączenie dla klucza API**

Dla klucza OpenAI ustanów połączenie, uruchamiając polecenie i korzystając z pliku `openai.yaml` w folderze `my_chatbot`, który przechowuje Twój klucz OpenAI (przepisz klucze i nazwę za pomocą --set, aby uniknąć zmian w pliku yaml):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Dla klucza Azure OpenAI ustanów połączenie, uruchamiając polecenie i korzystając z pliku `azure_openai.yaml`:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**Rozmawiaj ze swoim flow**

W folderze `my_chatbot` znajduje się plik `flow.dag.yaml`, który określa flow, w tym wejścia/wyjścia, węzły, połączenie oraz model LLM itd.

> Zwróć uwagę, że w węźle `chat` używamy połączenia o nazwie `open_ai_connection` (określonego w polu `connection`) i modelu `gpt-35-turbo` (określonego w polu `deployment_name`). Pole deployment_name służy do wskazania modelu OpenAI lub zasobu wdrożenia Azure OpenAI.

Interakcja z chatbotem odbywa się poprzez uruchomienie: (naciśnij `Ctrl + C`, aby zakończyć sesję)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**Kluczowa wartość: zapewnienie "Wysokiej Jakości" od prototypu do produkcji**

Przejdź nasz [**15-minutowy tutorial**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md), który prowadzi przez strojenie promptów ➡ testy wsadowe ➡ ewaluację, wszystko po to, by zapewnić gotowość do produkcji na najwyższym poziomie.

Kolejny krok! Przejdź do sekcji **Tutorial**  👇, aby zagłębić się w prompt flow.

## Tutorial 🏃‍♂️

Prompt flow to narzędzie stworzone do **budowy wysokiej jakości aplikacji LLM**, a proces rozwoju w prompt flow przebiega według następujących kroków: rozwijanie flow, poprawa jakości flow, wdrożenie flow do produkcji.

### Tworzenie własnych aplikacji LLM

#### Rozszerzenie VS Code

Oferujemy także rozszerzenie VS Code (projektant flow) dla interaktywnego rozwoju flow z poziomu UI.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

Możesz je zainstalować z <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">visualstudio marketplace</a>.

#### Głębsze poznanie rozwoju flow

[Jak zacząć z prompt flow](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): Krok po kroku jak uruchomić swój pierwszy flow.

### Ucz się na przykładach użycia

[Tutorial: Chat z PDF](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): Kompleksowy tutorial jak zbudować wysokiej jakości aplikację chatową z prompt flow, w tym rozwój flow oraz ewaluację z metrykami.
> Więcej przykładów znajdziesz [tutaj](https://microsoft.github.io/promptflow/tutorials/index.html#samples). Chętnie przyjmiemy nowe przypadki użycia!

### Konfiguracja dla kontrybutorów

Jeśli chcesz współtworzyć projekt, zacznij od naszego przewodnika developerskiego: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

Kolejny krok! Przejdź do sekcji **Contributing**  👇, aby dołączyć do rozwoju prompt flow.

## Współtworzenie (Contributing)

Ten projekt zachęca do współtworzenia oraz zgłaszania sugestii. Większość kontrybucji wymaga zaakceptowania
Contributor License Agreement (CLA), potwierdzającego, że masz prawo i faktycznie udzielasz nam praw do użycia swojego wkładu. Szczegóły: https://cla.opensource.microsoft.com.

Przy przesłaniu pull requesta, bot CLA automatycznie sprawdzi, czy musisz zaakceptować CLA i odpowiednio oznaczy PR (np. status check, komentarz). Po prostu postępuj zgodnie z instrukcjami bota. Wystarczy zrobić to raz, niezależnie od repozytorium korzystającego z naszego CLA.

Projekt przyjął [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Więcej informacji w [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) lub kontaktując się z [opencode@microsoft.com](mailto:opencode@microsoft.com).

## Znaki towarowe

Projekt może zawierać znaki towarowe lub logotypy projektów, produktów lub usług. Dozwolone użycie znaków towarowych lub logotypów Microsoft podlega i musi być zgodne z
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general).
Użycie znaków lub logotypów Microsoft w zmodyfikowanych wersjach projektu nie może powodować mylącego wrażenia lub sugerować sponsorowania przez Microsoft.
Każde użycie znaków towarowych lub logotypów stron trzecich podlega polityce tych stron.

## Kodeks postępowania

Projekt przyjął
[Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Więcej informacji w
[Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/)
lub kontaktując się z [opencode@microsoft.com](mailto:opencode@microsoft.com)
w przypadku dodatkowych pytań lub uwag.

## Zbieranie danych

Oprogramowanie może zbierać informacje o Tobie i Twoim korzystaniu z oprogramowania oraz
wysyłać je do Microsoft, jeśli skonfigurowano telemetrię.
Microsoft może wykorzystywać te informacje do świadczenia usług i ulepszania produktów i usług.
Możesz włączyć telemetrię zgodnie z opisem w repozytorium.
W oprogramowaniu mogą znajdować się również funkcje umożliwiające Tobie i Microsoft
zbieranie danych od użytkowników Twoich aplikacji. Jeśli korzystasz z tych funkcji,
musisz przestrzegać obowiązującego prawa, w tym dostarczyć odpowiednie powiadomienia
użytkownikom oraz przekazać im oświadczenie o prywatności Microsoft.
Nasze oświadczenie o prywatności znajduje się pod adresem
https://go.microsoft.com/fwlink/?LinkID=824704. Więcej informacji o zbieraniu i wykorzystaniu danych znajdziesz w dokumentacji pomocy i naszym oświadczeniu o prywatności. Korzystanie z oprogramowania oznacza zgodę na te praktyki.

### Konfiguracja telemetrii

Zbieranie telemetrii jest domyślnie włączone.

Aby zrezygnować, uruchom `pf config set telemetry.enabled=false`, aby ją wyłączyć.

## Licencja

Copyright (c) Microsoft Corporation. Wszelkie prawa zastrzeżone.

Licencjonowane na zasadach licencji [MIT](LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---