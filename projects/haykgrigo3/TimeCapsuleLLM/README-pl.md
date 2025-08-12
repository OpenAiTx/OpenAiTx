
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
LLM trenowany wyłącznie na danych z wybranych okresów czasu, aby ograniczyć współczesne uprzedzenia.

Wyobraź sobie, że model AI nie tylko udaje historyczny, lecz rzeczywiście nim jest.

Zbudowany na [nanoGPT Andreja Karpathy](https://github.com/karpathy/nanoGPT) Główne skrypty treningowe oraz architektura modelu to jego dzieło. 

# Cele projektu
TimeCapsule LLM to eksperymentalny projekt, który będzie trenowany wyłącznie na tekstach napisanych w określonych okresach historycznych. Celem jest zasymulowanie światopoglądu i języka charakterystycznego dla konkretnych epok.

# Dlaczego samo fine-tuning nie wystarczy

Jeśli tylko dostroisz wcześniej wytrenowany model, Twój LLM nadal będzie znał współczesne pojęcia. Oczywiście osiągnięcie całkowitego braku współczesnych naleciałości jest trudne, ale chcę się do tego maksymalnie zbliżyć. Brak współczesnych naleciałości wymaga trenowania modelu od zera.

# Oczekiwane rezultaty

Mam nadzieję, że gdy model będzie gotowy, nie będzie znał współczesnych pojęć i nie będzie potrafił wykraczać poza wiedzę, na której został wytrenowany. Nie powinien rozpoznawać współczesnego słownictwa/pojęć ani halucynować współczesnej wiedzy.

# Aktualizacje postępów

## 9 lipca 2025

Wybrałem okres czasowy 1800-1850 oraz region: Londyn

Zebrałem listę tekstów, książek, dokumentów

Jak dotąd zebrałem 50 plików txt i wkrótce rozpocznę trening NanoGPT

Będę aktualizował ten wpis w miarę postępu prac

## 13 lipca 2025

Wytrenowałem nanoGPT na 187 MB danych historycznych.

## 15 lipca 2025

Rozpocząłem pobieranie tekstów do drugiego treningu. Wszystko pobieram z Internet Archive i poszerzyłem okres do 1800-1875. Aby uzyskać różnorodne teksty, można używać filtrów tematycznych i wyszukiwania według miejsca publikacji, okresu i tematów w Internet Archive.

![Filtry wyszukiwania](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 lipca 2025

Pobrałem około 500 plików txt z Internet Archive, a po oczyszczeniu ich (usunięciu białych znaków, nagłówków Gutenberga itd.) mam około 500 MB danych. To niewielki zbiór, ale ostatnio trenowałem na 187 MB, więc powinny być przynajmniej jakieś zauważalne różnice w wynikach po wytrenowaniu drugiego modelu. Mam nadzieję, że ten model będzie w stanie generować bardziej spójne zdania, które mają sens. Oczywiście nie ma na to gwarancji, bo to wciąż bardzo mały zbiór, ale więcej niż miałem ostatnio.

To powinno być wykonalne na moim sprzęcie, co jest dobre, bo mam nadzieję zauważyć jakieś postępy zanim przejdę do większego zbioru danych, co wymagałoby wynajęcia GPU. Ale nie martwcie się, wciąż planuję wkrótce wynająć GPU, ale zanim to zrobię chcę się upewnić, że mój zbiór danych jest jak najlepiej wyselekcjonowany i oczyszczony. Jednym z problemów jest właśnie czyszczenie — wiele z tych plików txt ma pomieszane śmieci. Skrypty, których używałem do czyszczenia, działają, ale nie są w 100% skuteczne.

Zamierzam wytrenować ten zbiór dzisiaj i powinno to potrwać około 4-5 godzin. Po zakończeniu i przetestowaniu dam znać o postępach. Jeszcze raz dziękuję wszystkim, którzy śledzą mój projekt, nawet dostałem linki do zasobów OCR, więc dziękuję! Mam nadzieję, że więcej osób spróbuje tego podejścia i poeksperymentuje z własnymi zbiorami danych.


## 12 sierpnia 2025

Wersja 1 jest ukończona, ta wersja wykorzystuje Phi 1.5 (700M parametrów) i została wytrenowana na zbiorze danych zawierającym prawie 7000 tekstów. Główne ulepszenia tego modelu to jego zdolność do czasami odnoszenia się do prawdziwych nazwisk i wydarzeń historycznych. Wersje 0 i 0.5 nie potrafiły tego, gdy podawałem tym modelom coś jak "W roku 1821", wynik to były tylko halucynacje, rzeczy, które nigdy się nie wydarzyły. Przykład tego z Wersji 1:

Mój prompt: Był to rok Pański 1834, 

Wynik: "Był to rok Pański 1834, a ulice Londynu były pełne protestów i petycji. Powód, jak wielu wspominało, nie był związany z prywatnymi sprawami, lecz został podjęty tego samego dnia w dniu lorda Palmerstona, społeczeństwo otrzyma krótkie oświadczenie o trudnościach, z jakimi dzień prawa nas dotknął. To sprawa głębokiego żalu, że obecne wydarzenia w historii świata są jasne i w związku z tym będą znane. Nie jest prawdą, że ludzie, którzy pierwsi osiedlili się w Ewangelii w Jerozolimie, powinni mieć tak rozległy i interesujący zapis dobrobytu i dobrobytu" 

Na początku sądziłem, że to może być przypadek, ale spójrzcie na to: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### Aktualizacja treningu 

Rozpocząłem trening na korpusie 435MB (108 mln tokenów), idzie całkiem płynnie. Strata treningowa spadła z 10,9 do 4,9 w pierwszych 2800 iteracjach. Przewiduję, że zajmie to około 8 lub 9 godzin. Opublikuję kolejną aktualizację, gdy będzie gotowe.

## 17 lipca 2025

Trening drugiego modelu zakończony, mój 4060 potrzebował około 8 godzin i 40 minut (3900 iteracji/godz.) na 33 000 iteracji (5 epok). Końcowa strata treningowa wyniosła 3,73. Wyniki były zaskakująco dobre, model rzeczywiście generuje spójne zdania w stylu XIX wieku.

## 28 lipca 2025 

Wgrałem wersję v0.5 na Hugging Face, [Sprawdź tutaj](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) jeśli chcesz. Możesz teraz pobrać moje repozytorium i uruchomić je lokalnie. Niestety nanoGPT nie działa natywnie z HuggingFace, więc musisz pobrać i uruchomić model lokalnie.

Zaczynam także zbierać dane do kolejnego treningu, sądzę, że będę potrzebował 5-10x więcej danych, aby uzyskać zdolność rozumowania.

## 2 sierpnia 2025

Wkrótce zacznę pracę nad Wersją 1. Będę musiał przejść z architektury nanoGPT na coś bardziej nowoczesnego. Mam na uwadze kilka architektur LLM open-source, w tym: OpenLLaMA v3, Phi-2 i Qwen 1.5B. Aby wesprzeć przejście do V1, będę musiał starannie wyselekcjonować znacznie większy i bardziej zróżnicowany zbiór danych. Potrzebuję przynajmniej 5GB czystych danych treningowych.

# Zachowanie modelu V0 i ograniczenia 

Wczesne prompty pokazują, że model odpowiada językiem i zachowaniem z XIX wieku. Na przykład zapytałem go "Who art Henry?" i odpowiedział "Znam tego człowieka, nie jestem czarny, burza." i tak, to zdanie nie ma sensu, ale LLM rozpoznaje, że pytam o osobę.

![Przykładowy wynik TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Nie ma wzmianki o nowoczesnych koncepcjach, wyniki zawierają głównie słowa i zwroty z XIX wieku.

Wciąż wymaga dużo pracy, trenowanie na 187MB nie pozwoli uzyskać modelu generującego tekst o złożonym rozumowaniu. 

Obecnie generuje zdania, które nie mają pełnej struktury i ogólnie nie mają sensu, ale to normalne przy takim rozmiarze treningowym.

# Zachowanie i ograniczenia modelu V0.5

To wyraźna poprawa w porównaniu z poprzednim modelem. Styl pisania i słownictwo są wiktoriańskie, a prawie każde zdanie jest poprawne gramatycznie z właściwą interpunkcją. Ponownie, model trenowany jest od zera, więc trzyma się tematów z XIX wieku.

![Przykładowy wynik TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Jest dużo halucynacji faktów. Wiele (jak 100%) szczegółów (daty, wydarzenia, postacie historyczne) jest zmyślonych. Dodatkowo zdania nie są ze sobą powiązane, czasem może dwa zdania się odnosić do siebie, ale poza tym nie. Kolejnym problemem jest czasami pojawiający się nagłówek „Digitized by Google”, więc przy następnym trenowaniu muszę naprawdę upewnić się, że teksty są dobrze oczyszczone. Ogólnie jestem bardzo zadowolony z rezultatów, to jeszcze nie LLM, ale na pewno generator zdań.

Dużo się uczę i w nadchodzących tygodniach zacznę rozumieć, co muszę robić lepiej. Wkrótce wrzucę pliki!

# Zachowanie i ograniczenia modelu V1

Wkrótce wrzucę przykładowy wynik i dokonam porównań między trzema modelami z tym samym promptem. Wrzucę też V1 na huggingface, tak jak poprzednią wersję, mój profil huggingface znajdziesz tutaj: https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# Nadchodzące plany

(Zrealizowane) Zacznę pracę nad wersją 0.5, zamiast trenować na 50 książkach, będę trenować na 500-600. Obecnie trenuję nanoGPT na książkach z lat 1800-1850, szczególnie z Londynu. Są pewne wyzwania, np. upewnienie się, że książki nie są aktualizowane ani mają nowoczesnych interpretacji, tylko oryginalne publikacje z wybranego okresu.

Chcę wytrenować nowy model (v1) na znacznie większym korpusie, może 5-10 razy większym niż ten użyty w v0.5. Moim celem jest sprawdzenie, czy dzięki selektywnemu treningowi czasowemu pojawią się zdolności rozumowania; to trudniejsze zadanie i nie jestem pewien, czy to możliwe ze względu na ograniczenia danych historycznych. W najbliższych tygodniach spróbuję zebrać wystarczająco dużo danych na korpus 5-10GB. Wierzę, że jeśli zdobędę czyste, wysokiej jakości dane i wynajmę GPU, będą postępy.

# Jak korzystać z tego projektu

Projekt skupia się głównie na kuracji danych historycznych, ich przygotowaniu do treningu i budowie tokenizera. Nie będę tu omawiać pełnego procesu treningu LLM, do tego odsyłam do nanoGPT Andreja Karpathy.

# Krok 1: Zbierz i przygotuj teksty historyczne

Zbierz pliki .txt książek, dokumentów itd. z wybranego okresu (np. Londyn 1800-1850)

Możesz użyć download_texts_improved.py do pobrania książek, jeśli potrzebujesz.

Wyczyść pliki tekstowe za pomocą skryptu lub ręcznie usuń nagłówki/stopki z Project Gutenberg, nowoczesne adnotacje czy błędy OCR.

prepare_dataset.py powinien działać poprawnie.

# Krok 2: Zbuduj własny tokenizer

Uruchom train_tokenizer.py lub train_tokenizer_hf.py na oczyszczonych danych.
To wygeneruje vocab.json i merges.txt
Te pliki definiują słownictwo i zasady scalania dla Twojego modelu

# Krok 3: Trenuj swój model (nanoGPT)

Zapoznaj się z [nanoGPT autorstwa Andreja Karpathy’ego](https://github.com/karpathy/nanoGPT) w celu poznania procesu treningowego.

Możesz trenować inny LLM, jeśli chcesz, ale ja użyłem nanoGPT

# FAQ

## Czym jest Selektywne Trening Czasowy?

Selektywny Trening Czasowy (STT) to metodologia uczenia maszynowego, w której wszystkie dane treningowe są starannie wyselekcjonowane, aby mieściły się w określonym okresie historycznym. Robi się to w celu modelowania języka i wiedzy z tamtej epoki, bez wpływu współczesnych koncepcji. Na przykład, obecny model, który mam (v0.5), został wytrenowany wyłącznie na danych z lat 1800–1875, nie został dostrojony, lecz wytrenowany od zera, dzięki czemu wynik odzwierciedla styl językowy i kontekst historyczny tamtego okresu.

## Dlaczego nie użyć po prostu fine-tuningu lub LoRA?

W tym projekcie próbuję stworzyć model językowy wolny od współczesnych uprzedzeń. Jeśli dostroję coś takiego jak GPT-2, to już jest ono wstępnie wytrenowane i te informacje nie znikną. Jeśli wytrenuję model od zera, nie będzie on udawał „starego” — po prostu taki będzie. Celem projektu jest obecnie stworzenie czegoś, co potrafi rozumować wyłącznie na podstawie wiedzy z londyńskich książek wydanych między 1800 a 1850 rokiem.

## Jakich danych użyłeś do trenowania?

Używam książek, dokumentów prawnych, gazet i innych tekstów z Londynu z lat 1800–1850. Lista, którą podlinkowałem, zawiera około 200 pozycji, ale do pierwszego treningu użyłem tylko 50 plików (~187 MB). Możesz zobaczyć listę dokumentów:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Jak duże są modele?

V0: 16M parametrów

V0.5: 123M parametrów

V1: 700M parametrów

# Specyfikacja treningu?

#V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.

#V1

GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---