# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## Czym jest .NET Aspire?

.NET Aspire to opiniowana, gotowa do pracy w chmurze platforma do budowania obserwowalnych, gotowych do produkcji, rozproszonych aplikacji. .NET Aspire jest dostarczany jako zestaw pakietów NuGet, które obsługują określone zagadnienia związane z architekturą cloud-native. Aplikacje cloud-native często składają się z małych, połączonych ze sobą komponentów lub mikrousług, zamiast jednej, monolitycznej bazy kodu. Takie aplikacje zazwyczaj korzystają z wielu usług, takich jak bazy danych, systemy komunikatów czy cache’owanie.

.NET Aspire pomaga w:

[Orkiestracji](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire udostępnia funkcje do uruchamiania i łączenia aplikacji wieloprojektowych oraz ich zależności.

[Integracjach](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): Integracje .NET Aspire to pakiety NuGet dla popularnych usług, takich jak Redis czy Postgres, ze standaryzowanymi interfejsami, które zapewniają spójne i bezproblemowe połączenie z Twoją aplikacją.

[Narzędziach](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire oferuje szablony projektów oraz narzędzia dla Visual Studio i dotnet CLI, które pomagają tworzyć i obsługiwać aplikacje .NET Aspire.

Aby dowiedzieć się więcej, przeczytaj pełny [przegląd i dokumentację .NET Aspire](https://learn.microsoft.com/dotnet/aspire/). Przykłady dostępne są w [repozytorium przykładów .NET Aspire](https://github.com/dotnet/aspire-samples). Przykład [eShop znajdziesz tutaj](https://github.com/dotnet/eshop), a [wersję Azure tutaj](https://github.com/Azure-Samples/eShopOnAzure).

## Co znajduje się w tym repozytorium?

Host aplikacji .NET Aspire, dashboard, infrastruktura wykrywania usług oraz wszystkie integracje .NET Aspire. Zawiera również szablony projektów.

## Korzystanie z najnowszych wersji dziennych

Postępuj zgodnie z instrukcjami w [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md), aby rozpocząć korzystanie z .NET Aspire z najnowszą wersją dzienną.

## Jak mogę wnieść swój wkład?

Chętnie przyjmujemy Twoje wkłady! Wiele osób z całego świata przyczyniło się do rozwoju .NET.

Postępuj zgodnie z instrukcjami w [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md), aby pracować z kodem w tym repozytorium.

## Zgłaszanie problemów i błędów związanych z bezpieczeństwem

Problemy i błędy związane z bezpieczeństwem powinny być zgłaszane prywatnie, poprzez e-mail, do Microsoft Security Response Center (MSRC) <secure@microsoft.com>. Powinieneś otrzymać odpowiedź w ciągu 24 godzin. Jeśli z jakiegoś powodu jej nie otrzymasz, napisz ponownie, aby upewnić się, że Twoja wiadomość dotarła. Dalsze informacje, w tym klucz PGP MSRC, znajdziesz w [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue). Instrukcje te znajdziesz również w [dokumencie dotyczącym bezpieczeństwa](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md) tego repozytorium.

Zobacz także informacje o [Programie nagród za błędy w Microsoft .NET Core i ASP.NET Core](https://www.microsoft.com/msrc/bounty-dot-net-core).

### Uwaga dotycząca kontenerów używanych przez integracje zasobów i klientów .NET Aspire

Zespół .NET nie jest w stanie ocenić przydatności zewnętrznych kontenerów, dla których zapewniamy wsparcie API, pod kątem indywidualnych wymagań klienta.

Powinieneś samodzielnie ocenić wybrane przez siebie kontenery, które zamierzasz komponować i automatyzować z Aspire, by upewnić się, że spełniają wymagania Twoje, Twojego pracodawcy lub rządu w zakresie bezpieczeństwa, ochrony oraz przepisów kryptograficznych i innych standardów regulacyjnych czy korporacyjnych dotyczących użycia kontenera.

## .NET Foundation

.NET Aspire jest projektem [.NET Foundation](https://www.dotnetfoundation.org/projects).

Na GitHubie znajduje się wiele projektów związanych z .NET.

* [Repozytorium główne .NET](https://github.com/Microsoft/dotnet) – linki do setek projektów .NET, zarówno od Microsoftu, jak i społeczności.
* [Strona główna ASP.NET Core](https://docs.microsoft.com/aspnet/core) – najlepsze miejsce, aby rozpocząć naukę o ASP.NET Core.

Ten projekt przyjął kodeks postępowania zdefiniowany przez [Contributor Covenant](https://contributor-covenant.org), aby wyjaśnić oczekiwane zachowania w naszej społeczności. Więcej informacji znajdziesz w [Kodeksie Postępowania .NET Foundation](https://www.dotnetfoundation.org/code-of-conduct).

## Licencja

Kod w tym repozytorium jest objęty licencją [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---