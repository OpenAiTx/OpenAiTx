<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (coming soon)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (coming soon)</a> |
        | <a href="#" title="Coming soon">ไทย (coming soon)</a> |
        | <a href="#" title="Coming soon">Français (coming soon)</a>
        | <a href="#" title="Coming soon">Deutsch (coming soon)</a>
        | <a href="#" title="Coming soon">Español (coming soon)</a>
        | <a href="#" title="Coming soon">Italiano (coming soon)</a>
        | <a href="#" title="Coming soon">Русский (coming soon)</a>
        | <a href="#" title="Coming soon">Português (coming soon)</a>
        | <a href="#" title="Coming soon">Nederlands (coming soon)</a>
        | <a href="#" title="Coming soon">Polski (coming soon)</a>
        | <a href="#" title="Coming soon">العربية (coming soon)</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="#" title="Coming soon">Türkçe (coming soon)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (coming soon)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
LLM trenowany wyłącznie na danych z określonych okresów historycznych w celu ograniczenia współczesnych uprzedzeń.

Wyobraź sobie, że model AI nie tylko udaje historyczny, ale rzeczywiście nim jest.

Zbudowany na [nanoGPT autorstwa Andreja Karpathy](https://github.com/karpathy/nanoGPT). Podstawowe skrypty treningowe i architektura modelu są jego dziełem.

# Cele projektu

TimeCapsule LLM to eksperymentalny projekt trenowany wyłącznie na tekstach napisanych w określonych epokach. Celem jest symulacja światopoglądu i języka konkretnych okresów historycznych.

# Dlaczego samo dostrajanie nie wystarczy

Jeśli tylko dostroisz wytrenowany już model, Twój LLM nadal będzie znał współczesne pojęcia. Oczywiście osiągnięcie zupełnie zerowego współczesnego uprzedzenia jest trudne, ale chcę się do tego jak najbardziej zbliżyć. Brak współczesnych uprzedzeń wymaga trenowania modelu od zera.

# Oczekiwane rezultaty

Mam nadzieję, że po zakończeniu model nie będzie znał współczesnych pojęć i nie będzie w stanie rozumować poza tym, na czym został wytrenowany. Nie powinien rozpoznawać współczesnych pojęć/słów i mam nadzieję, że nie będzie halucynował współczesnej wiedzy.

# Aktualizacje postępów

## 9 lipca 2025

Wybrałem okres 1800-1850 oraz region: Londyn

Zebrałem listę tekstów, książek, dokumentów

Jak dotąd mam 50 plików txt i wkrótce rozpocznę trening NanoGPT

Będę aktualizować ten wpis, o ile będą postępy

## 13 lipca 2025

Wytrenowałem nanoGPT na 187MB historycznych danych tekstowych.

## 15 lipca 2025

Zacząłem pobierać teksty do drugiego treningu. Wszystko biorę z Internet Archive i rozszerzyłem okres do 1800-1875. Aby uzyskać zróżnicowane teksty, można używać filtrów tematycznych i wyszukiwania według miejsca publikacji, okresu i tematów na Internet Archive.

![Filtry wyszukiwania](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 lipca 2025

Pobrałem około 500 plików txt z Internet Archive i po ich oczyszczeniu (usunięcie białych znaków, nagłówków Gutenberga itp.) mam około 500MB danych. To mały zbiór danych, ale ostatnio trenowałem na 187MB, więc powinno być przynajmniej zauważalne ulepszenie w wynikach po wytrenowaniu drugiego modelu. Mam nadzieję, że ten model przynajmniej wygeneruje bardziej spójne zdania, które mają sens. Oczywiście nie jest to gwarantowane, bo to nadal bardzo mały zbiór, ale większy niż ostatnio.

Powinno się to dać zrobić na moim sprzęcie, co jest dobre, bo będę mógł zobaczyć pewne ulepszenia zanim przejdę do większego zbioru danych, co wymagałoby wynajmu GPU. Ale nie martw się, planuję wkrótce wynająć GPU, ale zanim to zrobię, chcę mieć pewność, że mój zbiór danych jest jak najbardziej uporządkowany i czysty. Jednym z problemów jest czyszczenie, wiele plików txt ma w sobie bełkot. Skrypty, których używam, działają, ale nie są w 100% skuteczne.

Dzisiaj wytrenuję ten zbiór, powinno to zająć około 4-5 godzin. Po zakończeniu i przetestowaniu dam znać. Dziękuję wszystkim, którzy śledzą mój projekt, niektórzy nawet podsyłali mi linki do zasobów OCR, więc dziękuję! Mam nadzieję, że więcej osób spróbuje tego i poeksperymentuje z własnymi zbiorami danych.

### Aktualizacja treningu

Rozpocząłem trening na korpusie 435MB (108 mln tokenów), na razie idzie całkiem gładko. Strata treningowa spadła z 10,9 do 4,9 w pierwszych 2800 iteracjach. Myślę, że całość potrwa około 8-9 godzin. Dam znać, gdy będzie gotowe.

## 17 lipca 2025 2:13AM

Trening drugiego modelu zakończony, mój 4060 potrzebował ok. 8 godzin i 40 minut (3 900 iteracji/godz.) na 33 000 iteracji (5 epok). Ostateczna strata treningowa wyniosła 3,73. Wyniki były zaskakująco dobre, model rzeczywiście generuje teraz spójne zdania w stylu XIX wieku.

# Zachowanie i ograniczenia modelu V0

Pierwsze zapytania pokazują, że model odpowiada językiem i zachowaniem z XIX wieku. Na przykład zapytałem "Who art Henry?" i odpowiedział "I know that man, I have did not a black, the storm." i tak, to zdanie nie ma sensu, ale LLM rozpoznaje, że pytam o osobę.

![Przykładowy wynik TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Nie ma żadnych odniesień do współczesnych koncepcji, wyniki zawierają głównie słowa i zwroty z XIX wieku.

Model wciąż wymaga dużo pracy, trenowanie na 187MB nie da modelu generującego tekst złożony pod względem rozumowania.

Obecnie generuje zdania bez pełnej struktury zdaniowej i ogólnie są bez sensu, ale to normalne przy takim rozmiarze zbioru.

# Zachowanie i ograniczenia modelu V0.5

To znaczna poprawa w porównaniu do poprzedniego modelu. Styl pisania i słownictwo są wiktoriańskie, a niemal każde zdanie jest poprawne gramatycznie i ma prawidłową interpunkcję. I ponownie, model był trenowany od zera, więc trzyma się tematów z XIX wieku.

![Przykładowy wynik TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Występuje wiele halucynacji faktów. Wiele (praktycznie 100%) szczegółów (daty, wydarzenia, postacie historyczne) jest zmyślonych. Zdania często nie są ze sobą powiązane, czasem może dwa się odnoszą do siebie, ale poza tym już nie. Kolejnym problemem jest pojawiający się czasami przypadkowy „Digitized by Google” w stopce, więc następnym razem muszę lepiej oczyścić teksty przed trenowaniem. Ogólnie jestem bardzo zadowolony z efektów – to jeszcze nie jest LLM, ale zdecydowanie generator zdań.

Dużo się uczę i w najbliższych tygodniach zacznę analizować, co mogę zrobić lepiej. Wkrótce wrzucę pliki!

# Nadchodzące plany

(Zrealizowane) Zamierzam rozpocząć prace nad wersją 0.5 – zamiast trenować na 50 książkach, użyję idealnie 500-600. Aktualnie trenuję nanoGPT na książkach z lat 1800-1850, konkretnie z Londynu. Są pewne wyzwania, jak upewnienie się, że znalezione książki nie są zaktualizowane ani nie mają współczesnych interpretacji, tylko są oryginalnymi wydaniami z wybranego okresu.

Chcę wytrenować nowy model (v1) na znacznie większym korpusie, może 5-10 razy większym niż dla v0.5. Moim celem jest sprawdzenie, czy sama Selektywna Trening Temporalny pozwoli wyłonić umiejętności rozumowania – to trudniejsze zadanie i nie mam pewności, czy to możliwe, ze względu na ograniczenia historycznych danych. W najbliższych tygodniach spróbuję zebrać wystarczająco danych, by mieć korpus 5-10GB. Wierzę, że jeśli zdobędę czyste, wysokiej jakości dane i wynajmę GPU, nastąpi postęp.

# Jak korzystać z tego projektu

Projekt skupia się głównie na zbieraniu danych historycznych, przygotowaniu ich do treningu oraz budowie tokenizera. Nie będę opisywać pełnego procesu trenowania LLM – w tym celu odsyłam do nanoGPT autorstwa Andreja Karpathy'ego.

# Krok 1: Zbierz i przygotuj teksty historyczne

Zbierz pliki .txt książek, dokumentów itp. z domeny publicznej z wybranego okresu (np. Londyn 1800-1850).

Możesz użyć download_texts_improved.py, aby pobrać książki, jeśli potrzebujesz.

Oczyść pliki tekstowe przy pomocy skryptu lub ręcznie usuń nagłówki/stopki z Project Gutenberg, nowoczesne adnotacje czy błędy OCR.

prepare_dataset.py powinien działać poprawnie.

# Krok 2: Zbuduj własny tokenizer

Uruchom train_tokenizer.py lub train_tokenizer_hf.py na oczyszczonych danych.
Otrzymasz pliki vocab.json i merges.txt

Te pliki definiują słownik i reguły łączenia dla Twojego modelu.

# Krok 3: Trenuj swój model (nanoGPT)

Odnieś się do [nanoGPT autorstwa Andreja Karpathy'ego](https://github.com/karpathy/nanoGPT) po opis procesu trenowania.

Możesz trenować inny LLM, jeśli chcesz, ale ja użyłem nanoGPT.

# FAQ

## Czym jest Selektywny Trening Temporalny?

Selektywny Trening Temporalny (STT) to metoda uczenia maszynowego, gdzie wszystkie dane treningowe są starannie dobrane tak, by pochodziły z określonego okresu historycznego. Robi się to, aby odtworzyć język i wiedzę tej epoki bez wpływu współczesnych pojęć. Na przykład aktualny model (v0.5) był trenowany wyłącznie na danych z lat 1800-1875; nie był dostrajany, tylko uczony od zera, co skutkuje wyjściem odzwierciedlającym styl językowy i kontekst historyczny tamtego czasu.

## Dlaczego nie użyć po prostu fine-tuningu albo LoRA?

W tym projekcie próbuję stworzyć model językowy wolny od współczesnych uprzedzeń. Jeśli zrobię fine-tuning np. na GPT-2, to model już jest wstępnie wytrenowany i tej wiedzy nie da się usunąć. Jeśli natomiast trenuję od zera, model językowy nie będzie udawał starego – on taki po prostu będzie. Celem projektu jest stworzenie czegoś, co potrafi rozumować wyłącznie na bazie wiedzy z londyńskich książek wydanych w latach 1800–1850.

## Jakie dane wykorzystałeś do treningu?

Używam książek, dokumentów prawnych, gazet i innych tekstów z Londynu z lat 1800–1850. Lista, którą podlinkowałem, zawiera około 200 pozycji, ale do pierwszego treningu użyłem tylko 50 plików (~187 MB). Możesz zobaczyć listę dokumentów:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Jak duży jest model w wersji 0?

Ten model jest obecnie bardzo mały – robię to dla zabawy i trzymam się zasady braku współczesnych źródeł. Ma prawie 16 milionów parametrów, ale zamierzam zebrać więcej starych tekstów i rozpocząć kolejny trening. Będę informować o postępach.

## Parametry trenowania?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---