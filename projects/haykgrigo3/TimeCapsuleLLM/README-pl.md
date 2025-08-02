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
LLM trenowany wyłącznie na danych z określonych okresów historycznych, by zredukować współczesne uprzedzenia.

Wyobraź sobie, że model AI nie tylko udaje historyczny, ale rzeczywiście nim jest.

Zbudowany na [nanoGPT autorstwa Andreja Karpathy’ego](https://github.com/karpathy/nanoGPT). Podstawowe skrypty treningowe i architektura modelu to jego praca.

# Cele projektu

TimeCapsule LLM to eksperymentalny projekt, który będzie trenowany wyłącznie na tekstach napisanych w określonych okresach historycznych. Celem jest symulacja światopoglądu i języka charakterystycznych dla wybranych epok.

# Dlaczego samo dostrajanie nie wystarcza

Jeśli tylko dostroisz wstępnie wytrenowany model, twój LLM i tak będzie znał współczesne pojęcia. Oczywiście osiągnięcie całkowitego braku współczesnych uprzedzeń jest trudne, ale chcę być jak najbliżej tego ideału. Brak współczesnych wpływów wymaga trenowania modelu od zera.

# Oczekiwane rezultaty

Mam nadzieję, że po zakończeniu ten model nie będzie znał współczesnych pojęć i nie będzie w stanie rozumować poza tym, na czym był trenowany. Nie powinien rozpoznawać współczesnych pojęć/słownictwa i mam nadzieję, że nie będzie halucynował współczesnej wiedzy.

# Aktualizacje postępów

## 9 lipca 2025

Wybrałem okres: 1800-1850 oraz region: Londyn

Zebrałem listę tekstów, książek, dokumentów

Jak dotąd mam 50 plików txt i wkrótce rozpocznę trening NanoGPT

Będę aktualizować ten wpis wraz z postępami

## 13 lipca 2025

Wytrenowałem nanoGPT na 187MB historycznych danych tekstowych.

## 15 lipca 2025

Rozpocząłem pobieranie tekstów do drugiego treningu. Wszystko ściągam z Internet Archive i poszerzyłem okres do 1800-1875. Aby uzyskać zróżnicowany zestaw tekstów, można używać filtrów tematycznych i wyszukiwania według miejsca publikacji, okresu i tematów na Internet Archive.

![Filtry wyszukiwania](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 lipca 2025

Pobrałem około 500 plików txt z Internet Archive i po ich oczyszczeniu (usuwanie białych znaków, nagłówków Gutenberg itp.) mam około 500MB danych. To wciąż mały zbiór, ale poprzednio trenowałem na 187MB, więc powinno być przynajmniej trochę zauważalnej różnicy w wynikach po treningu drugiego modelu. Mam nadzieję, że ten model będzie przynajmniej generował bardziej spójne zdania, które mają sens. Oczywiście nie jest to gwarantowane, bo to nadal bardzo mały zbiór, ale większy niż poprzednio.

Powinienem być w stanie zrobić to na własnym sprzęcie, co jest dobre, bo mam szansę zobaczyć jakieś ulepszenia zanim przejdę do większego zbioru, który wymagałby wynajęcia GPU. Ale nie martw się, planuję niedługo wynająć GPU, ale zanim to zrobię, chcę mieć możliwie najlepiej przygotowany i oczyszczony zbiór. Jednym z problemów jest czyszczenie, wiele tych plików txt zawiera bełkot. Skrypty, których użyłem do czyszczenia, działają, ale nie są w 100% skuteczne.

Dzisiaj wytrenuję ten zbiór i powinno to zająć około 4-5 godzin. Gdy skończę i przetestuję, dam znać o efektach. Dziękuję wszystkim, którzy śledzą mój projekt, dostałem nawet kilka linków do zasobów OCR, więc dziękuję! Mam nadzieję, że więcej osób spróbuje tego podejścia i poeksperymentuje z własnymi zbiorami danych.


### Aktualizacja treningu

Rozpocząłem trening na korpusie 435MB (108 mln tokenów), na razie idzie całkiem gładko. Strata trenowania spadła z 10.9 do 4.9 w pierwszych 2800 iteracjach. Przewiduję, że całość zajmie 8-9 godzin. Po zakończeniu wrzucę kolejną aktualizację.

## 17 lipca 2025, 2:13

Trening drugiego modelu zakończony, moja 4060 potrzebowała około 8 godzin i 40 minut (3900 iteracji/godz.) na 33 000 iteracji (5 epok). Końcowa strata treningowa wyniosła 3.73. Wyniki były zaskakująco dobre – model autentycznie generuje spójne zdania w stylu XIX wieku.

## 28 lipca 2025

Wrzuciłem v0.5 na Hugging Face, [sprawdź tutaj](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) jeśli chcesz. Możesz teraz pobrać moje repo i uruchomić lokalnie. Niestety nanoGPT nie działa natywnie z HuggingFace, więc trzeba pobrać i uruchomić model lokalnie.

Wkrótce zacznę kuratorować dane do kolejnego treningu, myślę że będę potrzebował 5-10x więcej danych, by uzyskać możliwości rozumowania.


# Zachowanie modelu V0 i ograniczenia

Wstępne podpowiedzi pokazują, że model odpowiada językiem i zachowaniem z XIX wieku. Na przykład, zapytałem "Who art Henry?" i odpowiedział "I know that man, I have did not a black, the storm." – i tak, to zdanie nie ma sensu, ale LLM rozpoznaje, że pytam o osobę.


![Przykładowe wyjście TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Nie ma tu wzmianki o nowoczesnych pojęciach, wyniki zawierają głównie słowa i zwroty z XIX wieku.

Nadal wymaga to dużo pracy, trenowanie na 187 MB nie da modelu, który generuje tekst o złożonym rozumowaniu.

Obecnie generuje zdania, które nie mają pełnej struktury zdaniowej i ogólnie nie mają sensu, ale to normalne przy takiej wielkości zbioru treningowego.

# Zachowanie modelu V0.5 i ograniczenia

To duży postęp w porównaniu do poprzedniego modelu. Styl pisania i słownictwo są wiktoriańskie, a prawie każde zdanie jest gramatycznie poprawne i posiada właściwą interpunkcję. Model ten został wytrenowany od zera, więc trzyma się tematów z XIX wieku.

![Przykładowe wyjście TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Jest dużo halucynacji faktów. Bardzo dużo (praktycznie 100%) szczegółów (daty, wydarzenia, postaci historyczne) jest zmyślonych. Zdania nie są ze sobą powiązane, czasem może dwa zdania się łączą, ale poza tym już nie. Kolejnym problemem jest czasem pojawiający się losowy podpis „Digitized by Google”, więc przy następnym treningu muszę lepiej oczyścić teksty. Ogólnie jestem bardzo zadowolony z efektów, do LLM to jeszcze daleko, ale na pewno to już generator zdań.

Dużo się uczę i w najbliższych tygodniach zacznę analizować, co muszę zrobić lepiej. Wkrótce wrzucę pliki!

# Nadchodzące plany

(Zakończone) Zaczynam pracę nad wersją 0.5, zamiast trenować na 50 książkach, będę trenował na 500-600. Obecnie trenuję nanoGPT na książkach z lat 1800-1850, szczególnie z Londynu. Są wyzwania, jak upewnić się, że książki nie są zaktualizowane czy mają nowoczesne interpretacje, ale tylko oryginalne wydania z wybranego okresu.

Chcę wytrenować nowy model (v1) na znacznie większym korpusie, może 5-10x większym niż użyty dla v0.5. Moim celem jest sprawdzić, czy umiejętności rozumowania mogą się pojawić tylko dzięki Selektywnemu Treningowi Czasowemu, to będzie trudniejsze zadanie i nie mam pewności, czy to możliwe z powodu ograniczeń historycznych danych. W nadchodzących tygodniach postaram się zebrać dane na korpus 5-10 GB. Wierzę, że jeśli zdobędę czyste, wysokiej jakości dane i wynajmę GPU, będzie postęp.

# Jak korzystać z tego projektu

Projekt skupia się głównie na gromadzeniu historycznych danych, przygotowaniu ich do treningu i budowie tokenizera. Nie opisuję całego procesu trenowania LLM, do tego odsyłam do nanoGPT Andreja Karpathy.

# Krok 1: Zbierz i przygotuj historyczne teksty

Zbierz pliki .txt książek, dokumentów itp. z wybranego okresu historycznego (np. Londyn 1800-1850)

Możesz użyć download_texts_improved.py do pobrania książek, jeśli chcesz.

Oczyść pliki tekstowe używając skryptu lub ręcznie usuń nagłówki/stopki z Project Gutenberg, nowoczesne adnotacje lub błędy OCR.

prepare_dataset.py powinien działać dobrze.

# Krok 2: Zbuduj własny tokenizer

Uruchom train_tokenizer.py lub train_tokenizer_hf.py na oczyszczonych danych.
Dostaniesz vocab.json i merges.txt

Te pliki definiują słownictwo i reguły łączenia dla twojego modelu

# Krok 3: Trenuj swój model (nanoGPT)

Zapoznaj się z [nanoGPT by Andrej Karpathy](https://github.com/karpathy/nanoGPT) w celu przeprowadzenia treningu.

Możesz trenować inny LLM, jeśli chcesz, ale ja użyłem nanoGPT

# FAQ

## Czym jest Selektywny Trening Czasowy?

Selective Temporal Training (STT) to metodologia uczenia maszynowego, w której wszystkie dane treningowe są specjalnie kuratorowane, by pochodziły z określonego okresu historycznego. Robi się to, aby modelować język i wiedzę tej epoki bez wpływu współczesnych pojęć. Na przykład obecny model (v0.5) jest trenowany wyłącznie na danych z lat 1800-1875, nie jest to fine-tuning, tylko trening od zera, dzięki czemu wynik odzwierciedla styl językowy i kontekst historyczny tego okresu.

## Dlaczego nie po prostu fine-tuning lub LoRA?

W tym projekcie próbuję stworzyć model językowy pozbawiony współczesnych uprzedzeń. Jeśli zrobię fine-tuning np. GPT-2, to już jest wytrenowany i tych informacji nie da się usunąć. Jeśli wytrenuję od zera, model językowy nie będzie udawał starego, tylko taki będzie. Celem projektu jest stworzenie czegoś, co rozumuje wyłącznie na podstawie wiedzy z londyńskich książek z lat 1800-1850.

## Jakie dane wykorzystałeś do treningu?

Używam książek, dokumentów prawnych, gazet i innych pism z Londynu z lat 1800–1850. Lista, którą podlinkowałem, zawiera ok. 200 pozycji, ale do pierwszego treningu użyłem tylko 50 plików o łącznej wielkości ~187 MB. Możesz zobaczyć listę dokumentów:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Jak duży jest model w wersji 0?

Model jest teraz bardzo mały, robię to dla zabawy, trzymając się zasady braku współczesnych źródeł. Ma prawie 16 milionów parametrów, ale zaczynam zbierać więcej starych tekstów, by rozpocząć nowy trening modelu. Będę informować na bieżąco.

## Specyfikacja treningu?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---