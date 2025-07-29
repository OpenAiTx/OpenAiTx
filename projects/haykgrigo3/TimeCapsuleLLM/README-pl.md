
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
LLM wytrenowany wyłącznie na danych z określonych okresów czasu, aby ograniczyć współczesne uprzedzenia.

Wyobraź sobie, że model AI nie tylko udaje historyczny — on faktycznie taki jest.

Zbudowano na [nanoGPT Andreja Karpathy'ego](https://github.com/karpathy/nanoGPT). Podstawowe skrypty treningowe i architektura modelu to jego dzieło.

# Cele projektu

TimeCapsule LLM to eksperymentalny projekt, który będzie trenowany wyłącznie na tekstach napisanych w określonych epokach. Celem jest symulacja światopoglądu i języka wybranych okresów historycznych.

# Dlaczego samo dostrajanie nie wystarcza

Jeśli tylko dostroisz wstępnie wytrenowany model, Twój LLM nadal będzie znał współczesne pojęcia. Oczywiście osiągnięcie całkowitego braku współczesnych uprzedzeń jest trudne, ale chcę zbliżyć się do tego jak najbardziej. Brak współczesnych odniesień wymaga trenowania modelu od zera.

# Oczekiwane rezultaty

Mam nadzieję, że po ukończeniu model nie będzie znał współczesnych pojęć i nie będzie potrafił rozumować poza tym, na czym był trenowany. Nie powinien rozpoznawać współczesnych koncepcji/słownictwa i liczę, że nie będzie halucynował współczesnej wiedzy.

# Aktualizacje postępów

## 9 lipca 2025

Ustaliłem okres treningowy na lata 1800-1850 oraz region: Londyn

Zebrałem listę tekstów, książek, dokumentów

Do tej pory mam 50 plików txt i wkrótce rozpocznę trening NanoGPT

Będę aktualizować ten wpis wraz z postępami

## 13 lipca 2025

Wytrenowałem nanoGPT na 187MB historycznych danych tekstowych.

## 15 lipca 2025

Zacząłem pobierać teksty do drugiej sesji treningowej. Wszystko pobieram z Internet Archive i rozszerzyłem okres do 1800-1875. Aby uzyskać różnorodne teksty, można użyć filtrów tematycznych i wyszukiwania według miejsca publikacji, okresu oraz tematów na Internet Archive.

![Filtry wyszukiwania](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 lipca 2025

Pobrałem około 500 plików txt z Internet Archive i po ich oczyszczeniu (usunięcie białych znaków, nagłówków Gutenberga itp.) mam około 500MB danych. To bardzo mały zbiór, ale ostatnim razem trenowałem na 187MB, więc powinno być zauważalnie lepiej po treningu drugiego modelu. Mam nadzieję, że ten model będzie przynajmniej generować bardziej spójne zdania, które mają sens. Oczywiście nie jest to gwarantowane, bo to wciąż mikroskopijny zbiór danych, ale większy niż poprzedni.

To powinno być wykonalne na moim sprzęcie, co jest dobre, bo będę mógł zobaczyć jakieś ulepszenia zanim przejdę do większego zbioru, co wymagałoby wynajęcia GPU. Ale nie martwcie się, wkrótce planuję wynająć GPU, ale zanim to zrobię, chcę mieć jak najbardziej wyselekcjonowany i czysty zbiór danych. Jednym z problemów jest czyszczenie — wiele z tych plików txt ma wtrącone bzdury. Skrypty do czyszczenia działają, ale nie są w 100% skuteczne.

Ten zbiór danych wytrenuję dzisiaj i powinno to potrwać około 4-5 godzin. Po zakończeniu i przetestowaniu dam znać. Dziękuję wszystkim, którzy śledzą mój projekt, niektórzy nawet przesłali mi linki do zasobów OCR, więc dziękuję! Mam nadzieję, że więcej osób spróbuje czegoś podobnego i poeksperymentuje z własnymi zbiorami danych.

## 28 lipca 2025

Wrzuciłem wersję v0.5 na Hugging Face, [zobacz tutaj](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) jeśli chcesz. Możesz teraz pobrać moje repo i uruchomić je lokalnie. Niestety nanoGPT nie działa natywnie z HuggingFace, więc musisz pobrać i uruchomić model lokalnie.

Rozpocznę także selekcjonowanie danych do kolejnego treningu — sądzę, że będę potrzebował 5-10x więcej danych, aby osiągnąć zdolność rozumowania.

### Aktualizacja treningu

Rozpocząłem trening na korpusie 435MB (108 mln tokenów), na razie idzie bardzo gładko. Strata treningowa spadła z 10,9 do 4,9 w pierwszych 2800 iteracjach. Myślę, że całość potrwa około 8-9 godzin. Zamieszczę kolejną aktualizację po zakończeniu.

## 17 lipca 2025, 2:13

Trening drugiego modelu zakończony, mojej 4060 zajęło to około 8 godzin i 40 minut (3 900 iteracji/godz.) przez 33 000 iteracji (5 epok). Finalna strata treningowa wyniosła 3,73. Wyniki były zaskakująco dobre — model naprawdę generuje spójne zdania w stylu XIX wieku.

# Zachowanie i ograniczenia modelu v0

Pierwsze promptowania pokazują, że model odpowiada językiem i stylem XIX wieku. Na przykład zapytałem "Who art Henry?" i odpowiedział "I know that man, I have did not a black, the storm." i jasne, to zdanie nie ma sensu, ale LLM rozpoznaje, że pytam o osobę.

![Przykładowe wyjście TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Nie ma wzmianki o nowoczesnych koncepcjach, wyniki zawierają głównie słowa i sformułowania z XIX wieku.

Nadal wymaga to dużo pracy, trenowanie na 187 MB nie da modelu produkującego tekst złożony pod względem rozumowania.

Obecnie generowane zdania nie mają pełnej struktury i ogólnie po prostu nie mają sensu, ale jest to normalne przy takiej wielkości zbioru treningowego.

# Zachowanie i ograniczenia modelu V0.5

To miła poprawa w porównaniu do poprzedniego modelu. Styl pisania i słownictwo jest wiktoriańskie i prawie każde zdanie jest gramatycznie poprawne z odpowiednią interpunkcją. Ponownie, model trenowany jest od zera, więc trzyma się tematów z XIX wieku.

![Przykładowy wynik TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Jest dużo halucynacji faktów. Wiele (praktycznie 100%) szczegółów (daty, wydarzenia, postaci historyczne) jest zmyślonych. Również zdania nie mają ze sobą powiązań, czasem może dwa się łączą, ale poza tym już nie. Kolejnym problemem jest czasem pojawiająca się stopka „Digitized by Google”, więc następnym razem muszę lepiej wyczyścić teksty. Ogólnie jestem bardzo zadowolony z rezultatów, to jeszcze nie jest LLM, ale na pewno generator zdań.

Dużo się uczę i w najbliższych tygodniach będę analizować, co mogę zrobić lepiej. Wkrótce udostępnię pliki!

# Nadchodzące plany

(Zakończone) Zacznę pracę nad wersją 0.5, zamiast trenować na 50 książkach, użyję najlepiej 500–600. Obecnie trenuję nanoGPT na książkach z lat 1800–1850, konkretnie z Londynu. Są pewne wyzwania, np. upewnienie się, że znalezione książki nie mają nowoczesnych interpretacji, ale są nienaruszone i wydane w wybranym okresie.

Chcę wytrenować nowy model (v1) na znacznie większym korpusie, może 5–10 razy większym niż użyty do v0.5. Moim celem jest sprawdzić, czy zdolności rozumowania pojawią się tylko na podstawie Selektywnego Treningu Czasowego, to trudniejsze zadanie i nie mam pewności, czy jest możliwe ze względu na ograniczenia danych historycznych. W nadchodzących tygodniach postaram się zebrać dane na 5–10 GB korpus. Wierzę, że jeśli zdobędę czyste i wysokiej jakości dane oraz wynajmę GPU, będą postępy.

# Jak korzystać z tego projektu

Projekt koncentruje się głównie na gromadzeniu danych historycznych, ich przygotowaniu do treningu i budowie tokenizera. Nie opisuję tutaj pełnego procesu treningu LLM, do tego odsyłam do nanoGPT Andreja Karpathy'ego.

# Krok 1: Zbierz i przygotuj teksty historyczne

Zbierz pliki .txt książek, dokumentów itp. z domeny publicznej z wybranego okresu (np. Londyn 1800–1850)

Możesz użyć download_texts_improved.py, by pobrać książki automatycznie, jeśli potrzebujesz.

Wyczyść pliki tekstowe skryptem lub ręcznie usuń nagłówki/stopki z Project Gutenberg, nowoczesne adnotacje lub błędy OCR.

prepare_dataset.py powinien działać dobrze.

# Krok 2: Zbuduj własny tokenizer

Uruchom train_tokenizer.py lub train_tokenizer_hf.py na wyczyszczonych danych.
Dostaniesz vocab.json i merges.txt

Te pliki definiują słownik i reguły scalania tokenów dla twojego modelu.

# Krok 3: Trenuj swój model (nanoGPT)

Zapoznaj się z [nanoGPT Andreja Karpathy'ego](https://github.com/karpathy/nanoGPT) w celu poznania procesu treningu.

Możesz trenować inny LLM, jeśli chcesz, ale ja użyłem nanoGPT.

# FAQ

## Czym jest Selektywny Trening Czasowy?

Selective Temporal Training (STT) to metodologia uczenia maszynowego, gdzie wszystkie dane treningowe są starannie dobrane tak, by pochodziły z konkretnego okresu historycznego. Ma to na celu modelowanie języka i wiedzy z danej epoki bez wpływu nowoczesnych koncepcji. Na przykład obecny model (v0.5) trenowany jest wyłącznie na danych z lat 1800–1875, nie jest dostrajany, ale trenowany od zera, przez co odzwierciedla styl językowy i kontekst historyczny tamtego okresu.

## Dlaczego nie po prostu fine-tuning lub LoRA?

W tym projekcie staram się stworzyć model językowy pozbawiony współczesnych naleciałości. Jeśli dostroję coś jak GPT-2, jest już wstępnie wytrenowane i tej wiedzy nie da się usunąć. Jeśli trenuję od zera, model językowy nie będzie udawał, że jest stary — po prostu taki będzie. Celem jest stworzenie czegoś, co rozumuje wyłącznie na podstawie wiedzy z książek londyńskich wydanych między 1800 a 1850 rokiem.

## Jakiego rodzaju dane wykorzystałeś do treningu?

Używam książek, dokumentów prawnych, gazet i innych tekstów z Londynu z lat 1800–1850. Lista, którą podlinkowałem, ma około 200 pozycji, ale do pierwszego treningu użyłem tylko 50 plików, ok. 187 MB. Listę dokumentów możesz zobaczyć tu:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Jak duży jest model w wersji 0?

Model jest obecnie bardzo mały, robię to hobbystycznie i trzymam się zasady braku nowoczesnych źródeł. Ma prawie 16 milionów parametrów, ale zacznę zbierać więcej starych tekstów do kolejnego treningu. Będę informować na bieżąco.

## Specyfikacja treningu?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---