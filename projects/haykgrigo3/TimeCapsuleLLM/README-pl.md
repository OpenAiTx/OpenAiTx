
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

v1 zbudowany na [Phi 1.5 by Microsoft](https://huggingface.co/microsoft/phi-1_5)

##  Zachowanie modelu i ograniczenia

### **v0**  

Wczesne podpowiedzi pokazują, że model odpowiada językiem i zachowaniem z XIX wieku.  
Przykład: Podpowiedź: "Who art Henry?" i odpowiedź: "I know that man, I have did not a black, the storm." 

![Przykładowy wynik TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Brak wzmianki o nowoczesnych konceptach  
- W większości słownictwo zgodne z epoką  
- Zdania są w większości niespójne (oczekiwane dla ~187MB danych treningowych)

### **v0.5** 

Znacząca poprawa w stosunku do v0.  
- Wiktoriański styl pisania, poprawna interpunkcja, w większości gramatyczne zdania  
- Nadal wysoki poziom halucynacji faktów  
- Szum OCR („Digitized by Google”) nadal obecny w wynikach

![Przykładowy wynik TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Pierwszy model, który przypomina sobie i łączy prawdziwe wydarzenie historyczne z rzeczywistą postacią z zestawu danych.

Przykład: Podpowiedź: "It was the year of our Lord 1834" 

Odpowiedź: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Na początku założyłem, że protest mógł przypadkowo mieć miejsce w tym samym roku, ale spójrz na to: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Dlaczego to jest ważne:

To pierwszy przykład, gdy jeden z moich modeli połączył rok z prawdziwym wydarzeniem historycznym i rzeczywistą osobą związaną z tym wydarzeniem (Lord Palmerston). Wcześniejsze modele (v0 i v0.5) potrafiły naśladować style pisania z XIX wieku, ale zawsze wymyślały wydarzenia, osoby i fakty. To pokazuje, że model zaczyna zapamiętywać informacje z zestawu danych 

## Nadchodzące plany 

- Na Internet Archive znajduje się prawie 175 000 tekstów opublikowanych w Londynie w latach 1800-1875
- Planuję rozszerzyć korpus i bardziej go oczyścić, aby uzyskać lepsze zdolności rozumowania
- Rozszerzenie na różne regiony i okresy czasu w celu stworzenia bardziej historycznych modeli


## Jak korzystać

Ten projekt koncentruje się głównie na kuracji danych historycznych, przygotowaniu ich do treningu i budowie tokenizera. Nie będę omawiać pełnego procesu treningu LLM, w tym celu odsyłam do nanoGPT Andreja Karpathy.

### Krok 1: Zbierz i przygotuj teksty historyczne

- Zbierz pliki .txt książek, dokumentów itd. z domeny publicznej z wybranego okresu (np. Londyn 1800-1850)
- Trzymaj się wybranego okna czasowego/miejsca  
- Oczyść pliki tekstowe za pomocą skryptu lub ręcznie usuń nagłówki/stopki z Project Gutenberg, nowoczesne adnotacje oraz błędy OCR.

### Krok 2: Zbuduj własny tokenizer

- Uruchom train_tokenizer.py lub train_tokenizer_hf.py na oczyszczonych danych.
- To wygeneruje vocab.json i merges.txt
- Te pliki definiują słownik i reguły łączenia dla Twojego modelu

### Krok 3: Wytrenuj swój model

- Zapoznaj się z [nanoGPT Andreja Karpathy](https://github.com/karpathy/nanoGPT) w celu poznania procesu treningu lub dokumentacją wybranej architektury.

# FAQ

## Czym jest Selektywne Trening Temporalny?

Selektywne Trening Temporalny (STT) to metodologia uczenia maszynowego, w której wszystkie dane treningowe są specjalnie dobrane, aby mieściły się w określonym okresie historycznym. Robi się to, aby modelować język i wiedzę z danej epoki bez wpływu nowoczesnych koncepcji. Na przykład, obecny model (v0.5) jest wytrenowany wyłącznie na danych z lat 1800-1875, nie jest dostrajany, lecz trenowany od zera, co skutkuje wynikami odzwierciedlającymi styl językowy i kontekst historyczny tamtego okresu.

## Dlaczego nie użyć po prostu fine-tuningu lub LoRA?

W tym projekcie staram się stworzyć model językowy wolny od współczesnych uprzedzeń. Jeśli dostroję coś takiego jak GPT-2, to jest już wstępnie wytrenowane i tych informacji nie da się usunąć. Jeśli wytrenuję od zera, model językowy nie będzie udawał starego, po prostu nim będzie. Celem projektu jest obecnie stworzenie czegoś, co potrafi rozumować wyłącznie na podstawie wiedzy z londyńskich książek wydanych w latach 1800-1875.

## Jakie dane wykorzystałeś do treningu?

Korzystam z książek, dokumentów prawnych, gazet i innych pism z Londynu z lat 1800–1875. Lista, którą podlinkowałem (dla v0), zawiera około 200 pozycji, ale do pierwszego treningu użyłem tylko 50 plików o łącznej wielkości ~187 MB. Możesz zobaczyć listę dokumentów:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt


Rozmiary zbiorów danych:
v0: ~187MB
v0.5: ~435MB 
v1: ~6,25GB 

## Jak duże są modele?

V0: 16M parametrów

V0.5 123M parametrów

V1: 700M parametrów

# Specyfikacje treningu?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: A100 wynajęty














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---