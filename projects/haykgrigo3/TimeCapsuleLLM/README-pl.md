
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (wkrótce)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (wkrótce)</a> |
        | <a href="#" title="Coming soon">ไทย (wkrótce)</a> |
        | <a href="#" title="Coming soon">Français (wkrótce)</a>
        | <a href="#" title="Coming soon">Deutsch (wkrótce)</a>
        | <a href="#" title="Coming soon">Español (wkrótce)</a>
        | <a href="#" title="Coming soon">Italiano (wkrótce)</a>
        | <a href="#" title="Coming soon">Русский (wkrótce)</a>
        | <a href="#" title="Coming soon">Português (wkrótce)</a>
        | <a href="#" title="Coming soon">Nederlands (wkrótce)</a>
        | <a href="#" title="Coming soon">Polski (wkrótce)</a>
        | <a href="#" title="Coming soon">العربية (wkrótce)</a>
        | <a href="#" title="Coming soon">فارسی (wkrótce)</a>
        | <a href="#" title="Coming soon">Türkçe (wkrótce)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (wkrótce)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (wkrótce)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
LLM wytrenowany wyłącznie na danych z określonych okresów, aby ograniczyć współczesne uprzedzenia.

Wyobraź sobie, że model AI nie tylko udaje historyczny, ale faktycznie nim jest.

Zbudowany na [nanoGPT autorstwa Andreja Karpathy'ego](https://github.com/karpathy/nanoGPT). Podstawowe skrypty treningowe i architektura modelu to jego praca.

# Cele projektu

TimeCapsule LLM to eksperymentalny projekt, który będzie trenowany wyłącznie na tekstach napisanych w określonych epokach. Celem jest symulacja światopoglądu i języka konkretnych historycznych okresów.

# Dlaczego samo dostrajanie nie wystarczy

Jeśli tylko dostroisz już wytrenowany model, Twój LLM nadal będzie znał współczesne pojęcia. Oczywiście osiągnięcie całkowitego braku współczesnych uprzedzeń jest trudne, ale chcę być jak najbliżej tego celu. Brak współczesnych uprzedzeń wymaga trenowania modelu od podstaw.

# Oczekiwane rezultaty

Mam nadzieję, że po ukończeniu model nie będzie znał współczesnych pojęć i nie będzie w stanie wykraczać poza to, na czym był trenowany. Nie powinien rozpoznawać nowoczesnego słownictwa/pojęć i mam nadzieję, że nie będzie halucynował współczesnej wiedzy.

# Aktualizacje postępów

## 9 lipca 2025

Wybrałem okres czasowy: 1800-1850 oraz region: Londyn

Zebrałem listę tekstów, książek, dokumentów

Jak dotąd mam 50 plików txt i wkrótce rozpocznę trenowanie NanoGPT

Będę aktualizować ten wpis tak długo, jak będą postępy

## 13 lipca 2025

Wytrenowałem nanoGPT na 187MB historycznych danych tekstowych.

## 15 lipca 2025

Zacząłem pobierać teksty do drugiego cyklu treningowego. Wszystko biorę z Internet Archive i rozszerzyłem okres do 1800-1875. Aby uzyskać różnorodność tekstów, można używać filtrów tematycznych i wyszukiwania wg miejsca publikacji, okresu i tematów na Internet Archive.

![Filtry wyszukiwania](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 lipca 2025

Pobrałem około 500 plików txt z Internet Archive i po ich oczyszczeniu (usuwanie białych znaków, nagłówków Gutenberg itd.) mam około 500MB danych. To mały zbiór, ale poprzednio trenowałem na 187MB, więc po treningu drugiego modelu powinien być zauważalny efekt. Mam nadzieję, że ten model będzie przynajmniej generował bardziej spójne zdania mające sens. Oczywiście nie ma gwarancji, bo to wciąż bardzo mały zbiór, ale większy niż poprzednio.

Powinno się to udać na moim sprzęcie, co jest dobre, bo będę mógł zobaczyć postępy zanim przejdę do większego zbioru, który wymagałby wynajmu GPU. Nie martwcie się – planuję wynająć GPU wkrótce, ale najpierw chcę mieć jak najlepiej przygotowany i czysty zbiór. Jednym z problemów jest czyszczenie – wiele plików txt zawiera bzdury. Skrypty do czyszczenia działają, ale nie są w 100% skuteczne.

Dzisiaj wytrenuję ten zbiór, powinno to zająć ok. 4-5 godzin. Po zakończeniu i testach dam znać. Dziękuję wszystkim, którzy zaglądają na mój projekt – niektórzy nawet podesłali mi linki do zasobów OCR, więc dzięki! Mam nadzieję, że więcej osób spróbuje i poeksperymentuje ze swoimi zbiorami.

### Aktualizacja treningu

Rozpocząłem trening na korpusie 435MB (108 mln tokenów), idzie całkiem sprawnie. Strata treningowa spadła z 10,9 do 4,9 w pierwszych 2800 iteracjach. Przewiduję, że zakończy się za 8-9 godzin. Dam znać po zakończeniu.

## 17 lipca 2025

Trening drugiego modelu zakończony, moja 4060 potrzebowała ok. 8 godzin i 40 minut (3900 iteracji/godz.) na 33 000 iteracji (5 epok). Ostateczna strata treningowa wyniosła 3,73. Wyniki są zaskakująco dobre – model generuje już naprawdę spójne zdania w stylu XIX wieku.

## 28 lipca 2025

Udostępniłem wersję v0.5 na Hugging Face, [sprawdź tutaj](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) jeśli chcesz. Można pobrać repozytorium i uruchomić lokalnie. Niestety nanoGPT nie działa natywnie z HuggingFace, więc trzeba pobrać i uruchomić model lokalnie.

Zacznę też zbierać dane do kolejnego treningu, sądzę, że będę potrzebował 5-10 razy więcej danych, aby osiągnąć zdolność do wnioskowania.

## 2 sierpnia 2025

Wkrótce zacznę pracę nad wersją 1. Będę musiał przejść z architektury nanoGPT na coś nowszego. Mam na oku kilka otwartych architektur LLM, m.in.: OpenLLaMA v3, Phi-2 i Qwen 1.5B. Do przejścia na V1 będę musiał skrupulatnie przygotować znacznie większy i bardziej zróżnicowany zbiór. Potrzebuję przynajmniej 5GB czystych danych treningowych.


# Zachowanie i ograniczenia modelu V0

Wczesne promptowania pokazują, że model odpowiada językiem i zachowaniem z lat 1800-tych. Na przykład, zapytałem "Who art Henry?" i odpowiedział "I know that man, I have did not a black, the storm." i tak, to zdanie nie ma sensu, ale LLM rozpoznaje, że pytam o osobę.

![Przykładowy wynik TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Nie ma żadnej wzmianki o nowoczesnych koncepcjach, odpowiedzi zawierają głównie słowa i zwroty z XIX wieku.

Wciąż wymaga dużo pracy, trenowanie na 187MB nie da modelu, który produkuje teksty złożonego rozumowania.

Obecnie generuje zdania bez pełnej struktury i generalnie nie mają one sensu, ale to normalne przy tak małym zbiorze treningowym.

# Zachowanie i ograniczenia modelu V0.5

To znaczna poprawa w porównaniu do poprzedniego modelu. Styl pisania i słownictwo są wiktoriańskie, niemal każde zdanie jest gramatycznie poprawne i posiada właściwą interpunkcję. I znów, model trenowany jest od zera, więc trzyma się tematów z XIX wieku.

![Przykładowy wynik TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Jest wiele halucynacji faktów. Wiele (praktycznie 100%) szczegółów (daty, wydarzenia, postacie historyczne) jest zmyślonych. Zdania też nie są ze sobą powiązane, czasem dwa się łączą, ale rzadko więcej. Dodatkowy problem to pojawiający się czasem przypadkowy “Digitized by Google” w stopce, więc przy kolejnym treningu muszę lepiej oczyścić teksty. Ogólnie jestem bardzo zadowolony z efektów, to jeszcze nie LLM, ale już generator zdań.

Dużo się uczę i w najbliższych tygodniach będę się starał poprawić proces. Wkrótce wrzucę pliki!

# Nadchodzące plany

(Zrobione) Zamierzam zacząć pracę nad wersją 0.5, zamiast trenować na 50 książkach, będę trenował na 500-600. Obecnie trenuję nanoGPT na książkach z lat 1800-1850, szczególnie z Londynu. Wyzwania to upewnienie się, że książki nie są zaktualizowane lub z nowoczesnymi interpretacjami, tylko oryginalne publikacje z wybranego okresu.

Chcę wytrenować nowy model (v1) na znacznie większym korpusie, może 5-10x większym niż dla v0.5. Moim celem jest sprawdzenie, czy same Selektywne Treningi Czasowe pozwolą uzyskać zdolności rozumowania — to będzie trudniejsze i nie mam pewności, czy się uda ze względu na ograniczenia danych historycznych. W nadchodzących tygodniach postaram się zebrać dane na korpus 5-10GB. Wierzę, że jeśli znajdę czyste, wysokiej jakości dane i wynajmę GPU, będzie postęp.

# Jak korzystać z projektu

Projekt skupia się głównie na zbieraniu danych historycznych, przygotowaniu ich do treningu i budowie tokenizera. Nie będę tutaj opisywać pełnego procesu treningu LLM — do tego odsyłam do nanoGPT autorstwa Andreja Karpathy’ego.

# Krok 1: Zbierz i przygotuj teksty historyczne

Zbierz pliki .txt z książkami, dokumentami itp. z wybranego okresu (np. Londyn 1800-1850).

Możesz użyć download_texts_improved.py, aby pobrać książki jeśli potrzebujesz.

Oczyść pliki tekstowe skryptem lub ręcznie usuń nagłówki/stopki z Project Gutenberg, nowoczesne adnotacje lub błędy OCR.

prepare_dataset.py powinien działać poprawnie.

# Krok 2: Zbuduj własny tokenizer

Uruchom train_tokenizer.py lub train_tokenizer_hf.py na oczyszczonych danych.
Otrzymasz vocab.json oraz merges.txt

Te pliki definiują słownik i reguły scalania dla twojego modelu

# Krok 3: Trenuj swój model (nanoGPT)

Szczegóły procesu treningowego znajdziesz w [nanoGPT Andreja Karpathy’ego](https://github.com/karpathy/nanoGPT).

Możesz trenować inny LLM, jeśli chcesz, ale ja użyłem nanoGPT

# FAQ

## Czym jest Selektywne Treningi Czasowe?

Selective Temporal Training (STT) to metoda uczenia maszynowego, w której wszystkie dane treningowe są starannie dobrane, by pochodziły z określonego okresu historycznego. Robi się to, by odwzorować język i wiedzę tej epoki bez wpływów nowoczesnych koncepcji. Na przykład, obecny model (v0.5) został wytrenowany wyłącznie na danych z lat 1800-1875, nie jest dostrajany, tylko trenowany od podstaw, co daje wyjście odzwierciedlające styl językowy i kontekst historyczny tamtego czasu.

## Dlaczego nie użyć fine-tuningu lub LoRA?

W tym projekcie próbuję stworzyć model językowy wolny od współczesnych uprzedzeń. Jeśli dostroję coś jak GPT-2, to i tak będzie już wytrenowany i tej wiedzy nie da się usunąć. Jeśli trenuję od zera, model nie będzie udawał starożytnego — po prostu nim będzie. Celem projektu jest stworzenie czegoś, co potrafi rozumować wyłącznie na podstawie wiedzy z książek londyńskich wydanych między 1800 a 1850 rokiem.

## Jakie dane były użyte do treningu?

Używam książek, dokumentów prawnych, gazet i innych pism z Londynu z lat 1800–1850. Lista, którą podlinkowałem, zawiera około 200 pozycji, ale do pierwszego treningu użyłem 50 plików o wadze ~187 MB. Listę dokumentów znajdziesz pod adresem:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Jak duży jest model w wersji 0?

Ten model jest teraz bardzo mały, robię to hobbystycznie i trzymam się zasady braku współczesnych źródeł. Ma prawie 16 milionów parametrów, ale zamierzam zebrać więcej starych tekstów, by rozpocząć kolejny trening. Będę na bieżąco informował o postępach.

## Specyfikacja treningu?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---