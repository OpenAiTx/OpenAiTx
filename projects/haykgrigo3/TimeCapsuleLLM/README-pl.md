<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Coming soon">فارسی (wkrótce)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (wkrótce)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*Model językowy wytrenowany **od podstaw** wyłącznie na danych z określonych miejsc i epok, aby ograniczyć współczesne uprzedzenia i odwzorować język, słownictwo oraz światopogląd danej ery.*

Wyobraź sobie, że model AI nie tylko udaje historyczny, ale faktycznie nim jest.

Wersje v0 oraz v0.5 zbudowane na [nanoGPT autorstwa Andreja Karpathy'ego](https://github.com/karpathy/nanoGPT) Podstawowe skrypty treningowe i architektura modelu to jego dzieło. 

v1 zbudowany na [Phi 1.5 firmy Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Link do Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)


##  Zachowanie modelu i ograniczenia

### **v0**  

Wczesne zapytania pokazują, że model odpowiada językiem i zachowaniem z XIX wieku. 
Przykład: Zapytanie: "Who art Henry?" i odpowiedź: "I know that man, I have did not a black, the storm." 

![Przykładowe wyjście TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Brak wzmianki o współczesnych koncepcjach  
- Głównie słownictwo zgodne z epoką  
- Zdania przeważnie niespójne (oczekiwane przy ~187MB danych treningowych)

### **v0.5** 

Znacząca poprawa względem v0.  
- Wiktoriański styl pisania, poprawna interpunkcja, przeważnie gramatyczne zdania  
- Nadal wysoki poziom halucynacji faktów  
- Szumy OCR („Digitized by Google”) nadal obecne w odpowiedziach

![Przykładowe wyjście TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Pierwszy model, który przywołuje i łączy prawdziwe wydarzenie historyczne z rzeczywistą postacią z zestawu danych.

Przykład: Zapytanie: "It was the year of our Lord 1834" 

Odpowiedź: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Na początku założyłem, że protest mógł przypadkowo mieć miejsce w tym samym roku, ale zobaczcie to: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Wytrenowany przy użyciu 15GB próbki z 90GB zestawu danych v2.
Model wytrenowany tylko do 10 000 kroków.

Wystąpił problem z tokenizacją, który powoduje, że wynik wygląda tak:

ZAPYTANIE:
Kim jest Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Poprawione:

„Kim jest Charles Dickens? Czy to dzieło bardziej jego doskonałego poruszania, w jego sztukach, na farmie Wielkiej Spółki? Co mam jeszcze zacytować od Jacka Picketta? Czy nie wiesz, że byli gatunkiem galopujących, albo piłujących swoje piersi, albo co należało zrobić w czasie, gdy Jackson patrzył przez okno? Czym jest sukces Anglika i co jego syn nie odkrył przede mną, aby osiągnąć taki ciężar? Czy kiedykolwiek przebyłeś starą drogę, albo do bryzy kotwicznej u stóp naszej łodzi, którą musisz nas opuścić? Faktem jest, że czy wiatr powstanie z równiny w sobotnią noc, czy w południe, czy aż do północy, czy inaczej, będziemy zmuszeni opisać potężną barierę, z tymi samymi skutkami co obecnie. W tej sytuacji, przynajmniej, nie jest przesadą powiedzieć, że opuściliśmy tamten pokój. Wierzę, że są trzy egzemplarze w „Pięćsetkrotnym”, do których można się odwołać, jako pierwszy numer naszych czytelników, którzy chcą t[o]...”

### **v2mini-eval2**

Wytrenowany na tej samej próbce 15GB użytej do trenowania eval1.
Model ponownie wytrenowany tylko do 10K kroków.

PROMPT: Charles Darwin

Charles Darwin ECCEMACY. Proszę pana, — Następujący przypadek jest dla mnie interesujący: — Byłem w Londynie przez dwa tygodnie i bardzo dotknął mnie atak reumatyzmu. Pierwszy atak reumatyzmu nastąpił tydzień przed tym, jak się z panem zobaczyłem, drugi gdy się spotkaliśmy, trzeci gdy się zobaczyliśmy, i trzeci w tym samym czasie. Drugi atak dny nie był jednak związany z objawami gorączkowymi, lecz towarzyszył mu zwiększony przepływ moczu i obfitszy jego wypływ. Trzeci atak nastąpił godzinę po naszym spotkaniu i zakończył się powrotem napadu dny oraz szybszym nawrotem dny. Czwarty atak również był związany z gorączką, ale nie zawsze z objawami gorączkowymi. Trzeci atak dny był dwa tygodnie po tym, jak był pan chory, a czwarty nastąpił po napadzie dny. Czwarty atak nastąpił dwa tygodnie po tym, jak został pan zaatakowany, i towarzyszyło mu uczucie


##  Zbiory danych

### **v2**

- 90GB tekstów londyńskich z lat 1800-1875
- 136 344 dokumentów
- Całe 90GB nie jest jeszcze dostępne, ponieważ nie zostało ztokenizowane, ale próbkę 15GB można znaleźć tutaj: https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### Statystyki uprzedzeń 
  ![Uprzedzenie zaimkowe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Uprzedzenie geograficzne](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Uprzedzenie czasowe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Więcej informacji znajdziesz w [raporcie o uprzedzeniach v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json).


## Jak używać

Ten projekt koncentruje się głównie na gromadzeniu danych historycznych, przygotowaniu ich do treningu i budowie tokenizera. Nie będę omawiać pełnego procesu treningu LLM, w tym celu odsyłam do nanoGPT autorstwa Andreja Karpathy.

### Krok 1: Zbierz i przygotuj historyczne teksty 

- Zbierz pliki .txt z książkami, dokumentami itp. będącymi w domenie publicznej z wybranego okresu (np. Londyn 1800-1850)
- Trzymaj je w wybranym przez siebie oknie czasowym/miejscu  
- Oczyść pliki tekstowe za pomocą skryptu lub ręcznie usuń nagłówki/stopki z Project Gutenberg, nowoczesne adnotacje lub błędy OCR.

### Krok 2: Zbuduj własny tokenizator

- Uruchom train_tokenizer.py lub train_tokenizer_hf.py na oczyszczonych danych.
- To da ci pliki vocab.json i merges.txt
- Te pliki definiują słownik oraz zasady łączenia dla twojego modelu

### Krok 3: Wytrenuj swój model 

- Odnieś się do [nanoGPT Andreja Karpathy’ego](https://github.com/karpathy/nanoGPT) w celu procesu treningu lub dokumentacji wybranej architektury.

# FAQ

## Czym jest Selektywne Szkolenie Czasowe?

Selektywne Szkolenie Czasowe (STT) to metodologia uczenia maszynowego, w której wszystkie dane treningowe są starannie wyselekcjonowane tak, by pochodziły z określonego okresu historycznego. Ma to na celu modelowanie języka i wiedzy tamtej epoki bez wpływu współczesnych koncepcji. Przykładowo, obecny model (v0.5) został wytrenowany wyłącznie na danych z lat 1800-1875, nie został dostrojony, lecz wytrenowany od zera, dzięki czemu jego wyniki odzwierciedlają styl językowy i kontekst historyczny tamtego czasu.

## Dlaczego nie użyć po prostu fine-tuningu lub LoRA?

W tym projekcie próbuję stworzyć model językowy wolny od współczesnych uprzedzeń. Jeśli zrobię fine-tuning np. GPT-2, to już jest wstępnie wytrenowany i tej wiedzy nie da się usunąć. Jeśli wytrenuję od zera, model językowy nie będzie udawał starego – po prostu taki będzie. Celem projektu na teraz jest stworzenie czegoś, co potrafi rozumować wyłącznie na podstawie wiedzy z londyńskich książek wydanych między 1800 a 1875 rokiem.

## Na jakich danych trenowałeś model?

Używam książek, dokumentów prawnych, gazet i innych tekstów z Londynu z lat 1800–1875. Lista, którą podlinkowałem (dla v0), zawiera około 200 pozycji, ale do pierwszego treningu użyłem tylko 50 plików o łącznej wielkości ~187 MB. Listę dokumentów możesz zobaczyć tutaj:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Rozmiary zbiorów danych:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB

## Jak duże są modele?

v0: 16M parametrów

v0.5 123M parametrów

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented





























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---