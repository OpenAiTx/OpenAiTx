# Kolekcja szablonów `.gitignore`

To jest kolekcja szablonów plików [`.gitignore`][man] GitHub’a.
Używamy tej listy do wypełniania wyboru szablonów `.gitignore` dostępnych
w interfejsie GitHub.com podczas tworzenia nowych repozytoriów i plików.

Więcej informacji o tym, jak działają pliki `.gitignore` i jak ich używać,
znajdziesz w następujących zasobach:

- Rozdział [Ignoring Files][chapter] z książki [Pro Git][progit].
- Artykuł [Ignoring Files][help] w Pomocy GitHub.
- Strona podręcznika [gitignore(5)][man].

[man]: https://git-scm.com/docs/gitignore
[help]: https://help.github.com/articles/ignoring-files
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring
[progit]: https://git-scm.com/book

## Struktura folderów

Obsługujemy kolekcję szablonów zorganizowanych w następujący sposób:

- Katalog główny zawiera najczęściej używane szablony, aby pomóc użytkownikom rozpocząć pracę
  z popularnymi językami programowania i technologiami. Definiują one zestaw
  znaczących reguł na start oraz zapewniają, że nie zapisujesz nieistotnych plików
  do swojego repozytorium.
- [`Global`](./Global) zawiera szablony dla różnych edytorów, narzędzi i
  systemów operacyjnych, które mogą być używane w różnych sytuacjach. Zaleca się,
  aby [dodać je do swojego globalnego szablonu](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer)
  lub połączyć te reguły ze swoimi szablonami projektowymi, jeśli chcesz
  używać ich na stałe.
- [`community`](./community) zawiera wyspecjalizowane szablony dla innych popularnych
  języków, narzędzi i projektów, które obecnie nie należą do głównych szablonów.
  Powinny być one dodawane do szablonów projektowych, kiedy zdecydujesz się wdrożyć
  odpowiedni framework lub narzędzie.

## Co wyróżnia dobry szablon?

Szablon powinien zawierać zestaw reguł pomagających repozytoriom Git pracować
z określonym językiem programowania, frameworkiem, narzędziem lub środowiskiem.

Jeśli nie da się przygotować niewielkiego zestawu przydatnych reguł dla tej sytuacji,
szablon nie jest odpowiedni dla tej kolekcji.

Jeśli szablon to głównie lista plików instalowanych przez konkretną wersję
jakiegoś oprogramowania (np. frameworka PHP), może on znaleźć się w katalogu `community`.
Więcej szczegółów w sekcji [szablony wersjonowane](#versioned-templates).

Jeśli masz niewielki zestaw reguł lub chcesz wspierać technologię, która nie jest
powszechnie używana, ale nadal uważasz, że będzie to pomocne dla innych, zapoznaj się
z sekcją [szablony wyspecjalizowane](#specialized-templates).

Podaj szczegóły przy otwieraniu pull requesta, jeśli szablon jest ważny i widoczny. Być może
nie zaakceptujemy go od razu, ale możemy przenieść go do katalogu głównego w przyszłości,
zależnie od zainteresowania.

Prosimy o zrozumienie, że nie możemy wymienić każdego narzędzia, które kiedykolwiek powstało.
Naszym celem jest stworzenie _najczęściej używanych i najbardziej pomocnych_ szablonów,
a nie zapewnienie wsparcia dla każdego możliwego projektu. Jeśli zdecydujemy się nie
dodać Twojego języka, narzędzia lub projektu, to nie dlatego, że nie jest on wartościowy.

## Wytyczne dotyczące współtworzenia

Chętnie przyjmiemy Twoją pomoc w ulepszaniu tego projektu. Aby utrzymać wysoką jakość tej kolekcji,
prosimy, aby zgłoszenia spełniały następujące wytyczne:

- **Podaj link do strony domowej aplikacji lub projektu**. O ile nie jest
  to niezwykle popularny projekt, istnieje szansa, że maintainerzy nie znają lub nie używają
  języka, frameworka, edytora, aplikacji czy projektu, do którego odnosi się Twoja zmiana.

- **Podaj linki do dokumentacji** wspierającej wprowadzaną przez Ciebie zmianę.
  Najlepiej, jeśli jest to aktualna, oficjalna dokumentacja, która wymienia pliki ignorowane.
  Jeśli taka dokumentacja nie jest dostępna, postaraj się jak najlepiej wyjaśnić,
  do czego służą ignorowane pliki.

- **Wyjaśnij powód zmiany**. Nawet jeśli wydaje się to oczywiste, poświęć jedno lub dwa zdania,
  by wyjaśnić, dlaczego Twoja zmiana lub dodatek powinny zostać wprowadzone.
  Szczególnie pomocne jest wskazanie, dlaczego ta zmiana dotyczy _wszystkich_
  pracujących z daną technologią, a nie tylko Ciebie czy Twojego zespołu.

- **Przemyśl zakres swojej zmiany**. Jeśli Twoja zmiana dotyczy konkretnego języka lub frameworka,
  upewnij się, że została wprowadzona do szablonu dla tego języka lub frameworka, a nie
  do szablonu dla edytora, narzędzia lub systemu operacyjnego.

- **Modyfikuj tylko _jeden szablon_ na każde zgłoszenie pull request**.
  Dzięki temu łatwiej skupić się na konkretnym projekcie lub technologii.

Im więcej zrobisz, by pomóc nam zrozumieć Twoje zmiany,
tym szybciej będziemy mogli zaakceptować Twoje zgłoszenie.

## Szablony wersjonowane

Niektóre szablony mogą znacznie się różnić między wersjami, więc jeśli chcesz dodać coś do tego repozytorium,
należy zastosować następujące zasady:

- szablon w katalogu głównym powinien być aktualnie wspieraną wersją
- szablon w katalogu głównym nie powinien mieć wersji w nazwie pliku (czyli być "evergreen")
- poprzednie wersje szablonów powinny znajdować się w `community/`
- poprzednie wersje szablonu powinny mieć wersję w nazwie pliku, dla czytelności

To pomaga zapewnić, że użytkownicy korzystają z najnowszej wersji (ponieważ użyją tej z katalogu głównego),
ale pozwala też maintainerom wspierać starsze wersje, które są jeszcze w użyciu.

## Szablony wyspecjalizowane

Jeśli masz szablon, który chciałbyś dodać, ale nie jest on jeszcze powszechny,
rozważ dodanie go do katalogu `community` w folderze, który najlepiej odpowiada jego przeznaczeniu.

Reguły w Twoim szablonie powinny być specyficzne dla frameworka lub narzędzia,
a wszelkie dodatkowe szablony powinny być wymienione w komentarzu w nagłówku szablonu.

Na przykład, taki szablon może znajdować się w `community/DotNet/InforCRM.gitignore`:

```
# szablon gitignore dla InforCRM (dawniej SalesLogix)
# strona: https://www.infor.com/product-summary/cx/infor-crm/
#
# Zalecane: VisualStudio.gitignore

# Ignorowanie plików modelu generowanych automatycznie
ModelIndex.xml
ExportedFiles.xml

# Ignorowanie plików wdrożeniowych
[Mm]odel/[Dd]eployment

# Wymuszone dołączenie portalowych SupportFiles
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## Przebieg współtworzenia

Oto jak sugerujemy zgłaszać zmiany do tego projektu:

1. [Forkuj ten projekt][fork] na swoje konto.
2. [Utwórz branch][branch] dla planowanej zmiany.
3. Wprowadź zmiany na swoim forku.
4. [Wyślij pull request][pr] z brancha swojego forka do naszego brancha `main`.

Możesz również korzystać z interfejsu webowego do wprowadzania zmian — projekt zostanie zforkowany automatycznie i zostaniesz poproszony o wysłanie pull requesta.

[fork]: https://help.github.com/articles/fork-a-repo/
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository
[pr]: https://help.github.com/articles/using-pull-requests/

## Licencja

[CC0-1.0](./LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---