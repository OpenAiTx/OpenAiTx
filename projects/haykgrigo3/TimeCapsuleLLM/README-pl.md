<div align="right">
  <details>
<summary>🌐 Język</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Model językowy wytrenowany **od podstaw** wyłącznie na danych z określonych miejsc i okresów czasu, aby ograniczyć współczesne uprzedzenia i oddać głos, słownictwo oraz światopogląd danej epoki.*

Wyobraź sobie, że model AI nie tylko udaje historyczny, ale naprawdę nim jest.

v0 oraz v0.5 zbudowane na [nanoGPT autorstwa Andreja Karpathy’ego](https://github.com/karpathy/nanoGPT) Główne skrypty treningowe i architektura modelu to jego praca.

v1 zbudowana na [Phi 1.5 od Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 zbudowana na llamaforcausallm

[Link do Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Status badań
Projekt został zainicjowany i rozwijany niezależnie.

Obecnie prowadzony jest pod nadzorem akademickim, we współpracy badawczej z Muhlenberg College.

## Cytowanie

Jeśli korzystasz z tego zbioru danych lub modelu w pracy naukowej, proszę cytować:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

##  Zachowanie Modelu i Ograniczenia

### **v0**  

Wczesne zapytania pokazują, że model odpowiada językiem i zachowaniem z XIX wieku.  
Przykład: Zapytanie: "Kim jest Henry?" i odpowiedź: "Znam tego człowieka, nie mam czarnego, burza." 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Brak wzmianki o współczesnych koncepcjach  
- Głównie słownictwo zgodne z epoką  
- Zdania są w większości niespójne (oczekiwane przy ~187MB danych treningowych)

### **v0.5** 

Znacząca poprawa względem v0.  
- Wiktoriański styl pisania, poprawna interpunkcja, głównie gramatyczne zdania  
- Nadal wysoki wskaźnik halucynacji faktów  
- Szum OCR („Digitized by Google”) nadal obecny w wynikach

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Pierwszy model, który potrafił przywołać i połączyć prawdziwe wydarzenie historyczne z faktyczną postacią z zestawu danych.

Przykład: Zapytanie: "To był rok naszego Pana 1834" 

Odpowiedź: "To był rok naszego Pana 1834 i ulice Londynu były pełne protestów i petycji. Przyczyna, jak wielu relacjonowało, nie była związana z prywatnym, lecz podjęta tego samego dnia w dniu Lorda Palmerstona, społeczeństwo otrzyma krótkie oświadczenie o trudnościach, w których dzień prawa nas dosięgnął. To kwestia głębokiego żalu, że obecne wydarzenia w historii świata są jasne i w konsekwencji będą znane. Nieprawda, że ci sami ludzie, którzy pierwsi osiedlili się w Ewangelii w Jerozolimie, powinni mieć tak obszerne i interesujące zapisy pomyślności i pomyślności" 

Na początku założyłem, że protest mógł przypadkowo mieć miejsce w tym samym roku, ale spójrz na to: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Trenowany na próbce 15GB z 90GB zestawu danych v2.  
Model trenowany tylko do 10K kroków.

Wystąpił problem z tokenizacją, który powoduje, że wynik wygląda tak:

Kim jest Charles Dickens?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Poprawione:

"Kim jest Charles Dickens? Czy to dzieło jest bardziej z jego znakomitych, poruszających utworów, w jego sztukach, na farmie Wielkiej Kompanii? Co mam jeszcze zacytować z Jacka Picketta? Czy nie wiesz, że byli oni rodzajem galopujących, albo piłujących swoje piersi, lub co należało zrobić w czasie, gdy Jackson wyglądał przez okno? Czym jest sukces Anglika i czym jego syn nie odkrył mi jeszcze, by móc osiągnąć taki ciężar? Czy kiedykolwiek przedarłeś się na starą drogę lub do bryzy kotwicznej u stóp naszej łodzi, którą musisz nas opuścić? Faktem jest, że niezależnie od tego, czy wiatr wstanie z równiny w sobotnią noc, w południe, czy do północy, czy też nie, będziemy zmuszeni opisać poważną przeszkodę, z tymi samymi skutkami co obecnie. W tej sytuacji przynajmniej nie można powiedzieć, że opuściliśmy to pomieszczenie. Wierzę, że są trzy egzemplarze w 'Pięćsetkrotnym', do których należy się odwołać, jako pierwsza liczba naszych czytelników, którzy chcą t[o]..."

### **v2mini-eval2**

Wytrenowany na tej samej 15GB próbce, która była użyta do treningu eval1.
Model ponownie wytrenowany tylko do 10K kroków.

PROMPT: Charles Darwin

Charles DarwinECCEMACY. Panie, — Następujący przypadek jest dla mnie interesujący: — Byłem w Londynie przez dwa tygodnie i bardzo dotknął mnie atak reumatyzmu. Pierwszy atak reumatyzmu nastąpił tydzień przed tym, jak się z Panem widziałem, drugi, gdy się spotkaliśmy, a trzeci, gdy znów się widzieliśmy, i trzeci w tym samym czasie. Drugi atak dny jednak nie był związany z objawami gorączkowymi, lecz z nasilonym wydalaniem moczu i obfitszym jego oddawaniem. Trzeci atak nastąpił godzinę po spotkaniu z Panem i został poprzedzony powrotem napadu dny oraz szybszym jej nawrotem. Czwarty atak również był związany z gorączką, ale nie zawsze towarzyszyły mu objawy gorączkowe. Trzeci atak dny nastąpił dwa tygodnie po chorobie, a czwarty po napadzie dny. Czwarty atak miał miejsce dwa tygodnie po wystąpieniu objawów i towarzyszyło mu uczucie

### **v2**

Wytrenowany na zbiorze danych o wielkości 90GB (112GB po tokenizacji)
Wytrenowany do 182K kroków

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  Zbiory danych

### **v2**

- 90GB (surowe) tekstów z Londynu z lat 1800-1875
- 136 344 dokumenty
- Pełny zbiór tokenizowany dostępny tutaj: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### Statystyki uprzedzeń 
  ![Bias zaimków](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Bias geograficzny](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Bias czasowy](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Zobacz [raport o uprzedzeniach v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) po więcej informacji.



## Jak używać

Ten projekt skupia się głównie na kuracji danych historycznych, przygotowaniu ich do treningu oraz budowie tokenizera. Nie będę tu omawiać pełnego procesu trenowania LLM, w tym celu odsyłam do nanoGPT autorstwa Andreja Karpathy.

### Krok 1: Zbierz i przygotuj teksty historyczne

- Zbierz pliki .txt z książkami, dokumentami itp. należącymi do domeny publicznej z wybranego okresu (np. Londyn 1800-1850)
- Upewnij się, że pochodzą z wybranego okna czasowego/miejsca
- Wyczyść pliki tekstowe za pomocą skryptu lub ręcznie usuń nagłówki/stopki z Projektu Gutenberg, nowoczesne przypisy czy błędy OCR.

### Krok 2: Zbuduj własny tokenizer

- Uruchom train_tokenizer.py lub train_tokenizer_hf.py na wyczyszczonych danych.
- Otrzymasz vocab.json i merges.txt
- Te pliki definiują słownik i reguły łączenia tokenów dla Twojego modelu

### Krok 3: Wytrenuj swój model

- Zapoznaj się z [nanoGPT autorstwa Andreja Karpathy](https://github.com/karpathy/nanoGPT) w celu poznania procesu treningu lub dokumentacji wybranej architektury.

# FAQ

## Czym jest Selective Temporal Training?

Selective Temporal Training (STT) to metodologia uczenia maszynowego, w której wszystkie dane treningowe są starannie wyselekcjonowane, aby pochodziły z konkretnego okresu historycznego. Robi się to, aby odwzorować język i wiedzę z tej epoki bez wpływu współczesnych pojęć. Na przykład, obecny model (v0.5) wytrenowałem wyłącznie na danych z lat 1800-1875, nie był on dostrajany, lecz trenowany od zera, co skutkuje odpowiedziami odzwierciedlającymi styl językowy i kontekst historyczny tamtego okresu.

## Dlaczego nie użyć po prostu fine-tuningu lub LoRA?

W tym projekcie staram się stworzyć model językowy wolny od współczesnych uprzedzeń. Jeśli dostroję coś takiego jak GPT-2, to już jest ono wytrenowane i tej wiedzy nie da się usunąć. Jeśli wytrenuję od zera, model językowy nie będzie udawał starości — po prostu taki będzie. Celem projektu jest stworzenie czegoś, co potrafi rozumować wyłącznie na podstawie wiedzy z londyńskich książek opublikowanych między 1800 a 1875 rokiem.

## Jakiego rodzaju danych użyłeś do treningu?

Używam książek, dokumentów prawnych, gazet i innych tekstów z Londynu z lat 1800–1875. Lista, którą podlinkowałem (dla v0), zawiera około 200 pozycji, ale do pierwszego treningu użyłem tylko 50 plików o wadze ~187 MB. Listę dokumentów możesz zobaczyć tutaj:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Rozmiary zbiorów danych:
- v0: ~187MB
- v0.5: ~435MB
- v1: ~6.25GB
- v2mini-eval1: 15GB (próbka z 90GB v2)
- v2: 90GB

## Jak duże są modele?

v0: 16M parametrów

v0.5: 123M parametrów

v1: 700M parametrów

v2mini-eval1: 300M parametrów

v2mini-eval2: 200M parametrów

v2: 1,2B parametrów

## Specyfikacje treningu? 

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM wynajęta

### v2mini-eval1/eval2
GPU: A100 SXM wynajęta

### v2
GPU: H100 SXM wynajęta

## Podziękowania

Chciałbym podziękować [Dr. Hamedowi Yaghoobianowi](https://hamedyaghoobian.com) za nadzór naukowy, wskazówki dotyczące formułowania badań i oceny, a także za pomoc przy trenowaniu tokenizera i przygotowaniu zbioru danych do wydania v2. Jego uwagi i doświadczenie były kluczowe w dopracowaniu prezentacji tej pracy.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---