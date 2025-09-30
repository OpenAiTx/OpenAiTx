
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

*Model językowy wytrenowany **od podstaw** wyłącznie na danych z wybranych miejsc i okresów, aby ograniczyć współczesne uprzedzenia i odtworzyć styl, słownictwo oraz światopogląd epoki.*

Wyobraź sobie, że model AI nie tylko udaje, że jest historyczny, ale faktycznie taki jest.

v0 i v0.5 oparte na [nanoGPT Andreja Karpathy](https://github.com/karpathy/nanoGPT). Główne skrypty treningowe oraz architektura modelu to jego dzieło. 

v1 zbudowany na [Phi 1.5 od Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Link do Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Zachowanie modelu i ograniczenia

### **v0**  

Wczesne zapytania pokazują, że model odpowiada językiem i zachowaniem z XIX wieku. 
Przykład: Zapytanie: "Who art Henry?" a odpowiedź: "I know that man, I have did not a black, the storm." 

![Przykładowy wynik TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Brak wzmianki o nowoczesnych koncepcjach  
- Przeważnie słownictwo zgodne z epoką  
- Zdania głównie niespójne (oczekiwane dla ~187MB danych treningowych)

### **v0.5** 

Znaczna poprawa względem v0.  
- Wiktoriański styl pisania, poprawna interpunkcja, przeważnie poprawne gramatycznie zdania  
- Nadal wysoki poziom halucynacji faktów  
- Szumy OCR („Digitized by Google”) nadal obecne w wynikach

![Przykładowy wynik TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Pierwszy model, który przypomina sobie i łączy prawdziwe wydarzenie historyczne z rzeczywistą postacią z zestawu danych.

Przykład: Zapytanie: "It was the year of our Lord 1834" 

Wynik: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Na początku założyłem, że protest mógł przypadkowo mieć miejsce w tym samym roku, ale spójrz na to: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Dlaczego to ma znaczenie:

To pierwszy przykład, gdy jeden z moich modeli połączył rok zarówno z prawdziwym wydarzeniem historycznym, jak i z rzeczywistą osobą powiązaną z tym wydarzeniem (Lord Palmerston). Wcześniejsze modele (v0 i v0.5) potrafiły naśladować styl pisania XIX wieku, ale zawsze wymyślały wydarzenia, osoby i fakty. Pokazuje to, że model zaczyna zapamiętywać rzeczy z zestawu danych


## Nadchodzące plany

- Na Internet Archive opublikowano prawie 175 000 tekstów wydanych w Londynie w latach 1800-1875
- Planuję rozszerzyć korpus i dokładniej go oczyścić, aby poprawić zdolności rozumowania
- Rozszerzenie na inne regiony i okresy historyczne w celu budowy bardziej zróżnicowanych modeli historycznych

## Jak używać

Ten projekt koncentruje się głównie na gromadzeniu danych historycznych, ich przygotowaniu do treningu oraz budowie tokenizera. Nie będę omawiać pełnego procesu treningu LLM, w tym celu odsyłam do nanoGPT Andreja Karpathy'ego.

### Krok 1: Zbierz i przygotuj teksty historyczne

- Zbierz pliki .txt książek, dokumentów itd. z domeny publicznej z wybranego okresu (np. Londyn 1800-1850)
- Trzymaj je w wybranym przez siebie oknie czasowo-miejscowym
- Oczyść pliki tekstowe za pomocą skryptu lub ręcznie usuń nagłówki/stopki z Project Gutenberg, nowoczesne adnotacje czy błędy OCR

### Krok 2: Zbuduj własny tokenizer

- Uruchom train_tokenizer.py lub train_tokenizer_hf.py na oczyszczonych danych.
- Otrzymasz vocab.json oraz merges.txt
- Te pliki definiują słownictwo i zasady łączenia dla Twojego modelu

### Krok 3: Wytrenuj swój model

- W celu przeprowadzenia treningu odsyłam do [nanoGPT Andreja Karpathy'ego](https://github.com/karpathy/nanoGPT) lub dokumentacji wybranej architektury.

# FAQ

## Czym jest Selective Temporal Training?

Selective Temporal Training (STT) to metodologia uczenia maszynowego, w której wszystkie dane treningowe są starannie wyselekcjonowane, aby pochodziły z określonego okresu historycznego. Ma to na celu modelowanie języka i wiedzy tamtej epoki bez wpływu nowoczesnych koncepcji. Na przykład, obecny model (v0.5) został wytrenowany wyłącznie na danych z lat 1800-1875, nie był dostrajany, lecz trenowany od zera, co skutkuje wyjściem odzwierciedlającym styl językowy i kontekst historyczny tamtego okresu.

## Dlaczego nie użyć po prostu fine-tuningu lub LoRA?

W tym projekcie próbuję stworzyć model językowy wolny od współczesnych uprzedzeń. Jeśli dostroję coś takiego jak GPT-2, jest już wstępnie wytrenowany i ta informacja nie zniknie. Jeśli wytrenuję od zera, model językowy nie będzie udawał "starego" – po prostu nim będzie. Celem projektu na ten moment jest stworzenie czegoś, co potrafi rozumować wyłącznie na podstawie wiedzy z londyńskich książek wydanych w latach 1800-1875.

## Jakich danych używałeś do treningu?


Używam książek, dokumentów prawnych, gazet i innych tekstów z Londynu z lat 1800–1875. Lista, do której podałem link (dla v0), zawiera około 200 pozycji, ale do pierwszego treningu użyłem tylko 50 plików o łącznej wielkości ok. 187 MB. Możesz zobaczyć listę dokumentów:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Rozmiary zbiorów danych:
v0: ~187MB
v0.5: ~435MB 
v1: ~6,25GB 

## Jak duże są modele?

V0: 16M parametrów

V0.5 123M parametrów

V1: 700M parametrów

# Specyfikacja treningu?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: A100 wynajęta















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---