# Projektowanie języka C#

[![Dołącz do czatu na https://gitter.im/dotnet/csharplang](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Czat na Discordzie](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

Witamy w oficjalnym repozytorium dotyczącym projektowania języka C#. To tutaj opracowywane, przyjmowane i specyfikowane są nowe funkcje języka C#.

C# jest projektowany przez Zespół ds. Projektowania Języka C# (LDT) w ścisłej współpracy z projektem [Roslyn](https://github.com/dotnet/roslyn), który implementuje ten język.

Możesz znaleźć:

- Aktywne propozycje funkcji języka C# w [folderze proposals](proposals)
- Notatki z posiedzeń zespołu projektującego język C# w [folderze meetings](meetings)
- Podsumowanie [historii wersji języka tutaj](Language-Version-History.md).

Jeśli odkryjesz błędy lub braki w powyższych zasobach, prosimy o zgłoszenie problemu, lub jeszcze lepiej: pull request z poprawką.

Jednakże, w przypadku *propozycji nowych funkcji*, prosimy o zgłaszanie ich do [dyskusji](https://github.com/dotnet/csharplang/labels/Discussion), i *tylko* przesyłanie propozycji jako issue lub pull request, jeśli zostaniesz do tego zaproszony przez członka Zespołu ds. Projektowania Języka (czyli "championa").

Pełny proces projektowania jest opisany [tutaj](Design-Process.md). Skrócony przegląd znajduje się poniżej.

## Dyskusje

Debaty dotyczące funkcji języka odbywają się w formie [Dyskusji](https://github.com/dotnet/csharplang/discussions) w tym repozytorium.

Jeśli chcesz zasugerować funkcję, omówić bieżące notatki projektowe lub propozycje itd., prosimy [otworzyć nowy temat Dyskusji](https://github.com/dotnet/csharplang/discussions/new).

Dyskusje, które są krótkie i na temat, mają znacznie większą szansę na przeczytanie. Jeśli zostawisz komentarz numer pięćdziesiąty, istnieje duża szansa, że przeczyta go tylko kilka osób. Aby ułatwić nawigację i korzystanie z dyskusji, prosimy przestrzegać kilku zasad:

- Dyskusja powinna dotyczyć projektowania języka C#. Jeśli nie, zostanie zamknięta bez uprzedzenia.
- Wybierz opisowy temat, który jasno określa zakres dyskusji.
- Trzymaj się tematu dyskusji. Jeśli komentarz jest poboczny lub wchodzi w szczegóły dotyczące podtematu, rozpocznij nową dyskusję i podlinkuj ją.
- Czy Twój komentarz jest użyteczny dla innych, czy można go wyrazić za pomocą reakcji emoji na istniejący komentarz?

Propozycje językowe, które uniemożliwiają pojawienie się określonej składni, można osiągnąć za pomocą [analizatora Roslyn](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers). Propozycje, które jedynie sprawiają, że istniejąca składnia staje się opcjonalnie nielegalna, zostaną odrzucone przez komitet projektujący język, aby zapobiec zwiększaniu złożoności języka.

## Propozycje

Gdy członek C# LDM uzna, że propozycja zasługuje na rozpatrzenie przez szerszy zespół, może ją [championować](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22), co oznacza, że przedstawi ją na posiedzeniu Zespołu ds. Projektowania Języka C#. Propozycje są zawsze omawiane w powiązanych dyskusjach, a nie w issue championa. Nie zawsze stosowaliśmy tę zasadę, więc wiele issue championów zawiera dyskusje; teraz blokujemy te issue, aby zapobiec nowym dyskusjom. Każdy issue championa będzie miał link do dyskusji.

## Proces projektowania

[Propozycje](proposals) ewoluują w wyniku decyzji podejmowanych podczas [Posiedzeń Zespołu Projektującego Język](meetings), które są informowane przez [dyskusje](https://github.com/dotnet/csharplang/discussions), eksperymenty i pracę projektową offline.

W wielu przypadkach konieczne będzie zaimplementowanie i udostępnienie prototypu funkcji, aby wybrać właściwy projekt i ostatecznie zdecydować, czy funkcja zostanie przyjęta. Prototypy pomagają odkryć zarówno problemy implementacyjne, jak i użyteczności danej funkcji. Prototyp powinien być zaimplementowany w forku [repozytorium Roslyn](https://github.com/dotnet/roslyn) i spełniać następujące warunki:

- Parsowanie (jeśli dotyczy) powinno być odporne na eksperymenty: wpisywanie nie powinno powodować awarii.
- Dołącz minimalne testy demonstrujące działanie funkcji end-to-end.
- Dołącz minimalne wsparcie dla IDE (kolorowanie słów kluczowych, formatowanie, podpowiedzi).

Po zatwierdzeniu funkcja powinna być w pełni zaimplementowana w [Roslyn](https://github.com/dotnet/roslyn) i w pełni opisana w [specyfikacji języka](spec), po czym propozycja zostaje przeniesiona do odpowiedniego folderu dla ukończonej funkcji, np. [Propozycje C# 7.1](proposals/csharp-7.1).

**ZASTRZEŻENIE**: Aktywna propozycja jest aktualnie rozważana do włączenia w przyszłej wersji języka programowania C#, ale nie ma żadnej gwarancji, że ostatecznie zostanie ona włączona do następnej lub jakiejkolwiek wersji języka. Propozycja może zostać odroczona lub odrzucona na każdym etapie powyższego procesu na podstawie opinii zespołu projektowego, społeczności, recenzentów kodu lub testów.

### Kamienie milowe

Mamy kilka różnych kamieni milowych dla zgłoszeń w repozytorium:
* [Working Set](https://github.com/dotnet/csharplang/milestone/19) to zestaw championowanych propozycji, nad którymi obecnie aktywnie pracujemy. Nie wszystko z tego kamienia milowego trafi do następnej wersji C#, ale otrzyma czas projektowy podczas nadchodzącego wydania.
* [Backlog](https://github.com/dotnet/csharplang/milestone/10) to zestaw championowanych propozycji, które zostały przejrzane, ale nie są obecnie aktywnie rozwijane. Dyskusje i pomysły ze strony społeczności są mile widziane, ale koszt pracy projektowej i przeglądu wdrożenia tych funkcji jest zbyt wysoki, by rozważać ich wdrożenie przez społeczność, dopóki nie będziemy na to gotowi.
* [Any Time](https://github.com/dotnet/csharplang/milestone/14) to zestaw championowanych propozycji, które zostały przejrzane, ale nie są obecnie aktywnie rozwijane i są otwarte na implementację przez społeczność. Zgłoszenia mogą być w jednym z dwóch stanów: wymagają zatwierdzonej specyfikacji lub wymagają wdrożenia. Te, które wymagają specyfikacji, muszą zostać przedstawione podczas LDM w celu zatwierdzenia specyfikacji, ale jesteśmy gotowi poświęcić na to czas, gdy tylko będzie to możliwe.
* [Likely Never](https://github.com/dotnet/csharplang/milestone/13) to zestaw propozycji, które LDM odrzucił z języka. Bez silnej potrzeby lub opinii społeczności, te propozycje nie będą rozważane w przyszłości.
* Kamienie milowe o numerach to zestaw funkcji, które zostały zaimplementowane dla danej wersji języka. Dla zamkniętych kamieni milowych są to rzeczy, które zostały wydane z tym wydaniem. Dla otwartych kamieni milowych funkcje mogą zostać wycofane, jeśli w miarę zbliżania się wydania odkryjemy problemy ze zgodnością lub inne.

## Posiedzenia Zespołu Projektującego Język

Posiedzenia Zespołu Projektującego Język (LDM) są prowadzone przez LDT oraz zaproszonych gości i są dokumentowane w Notatkach z Posiedzeń Projektowych w [folderze meetings](meetings), uporządkowanym według lat. Cykl życia notatki z posiedzenia projektowego opisano w [meetings/README.md](meetings/README.md). To na LDM zapadają decyzje dotyczące przyszłych wersji C#, w tym, nad którymi propozycjami pracować, jak je rozwijać oraz czy i kiedy je przyjąć.

## Specyfikacja języka

Aktualną specyfikację ECMA-334 można znaleźć w formie markdown w repozytorium [C# Language Standard](https://github.com/dotnet/csharpstandard/).

## Implementacja

Referencyjna implementacja języka C# znajduje się w [repozytorium Roslyn](https://github.com/dotnet/roslyn). To repozytorium śledzi również [status implementacji funkcji języka](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md). Do niedawna tam również były śledzone artefakty projektowe języka. Prosimy o cierpliwość podczas przenoszenia aktywnych propozycji.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---