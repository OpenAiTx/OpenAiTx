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
## Dołącz do Vintage LLM Discord

Jeśli interesują Cię **historyczne modele językowe**, **zbiory danych z określonych epok** lub przyszłość projektów takich jak **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox**, dołącz do naszej społeczności.

Używamy serwera do dyskusji nad pomysłami, dzielenia się postępami i nawiązywania kontaktów z innymi twórcami w tej dziedzinie.

[Dołącz do Discorda](https://discord.gg/JeWkk4z5)

##  Zachowanie modelu i ograniczenia

### **v0**  

Wczesne polecenia pokazują, że model odpowiada językiem i zachowaniem z XIX wieku.
Przykład: Polecenie: "Who art Henry?" i odpowiedź: "I know that man, I have did not a black, the storm."

![TimeCapsuleLLM Przykładowe Wyjście](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Brak wzmianki o współczesnych pojęciach  
- Przeważnie słownictwo zgodne z epoką  
- Zdania w większości niespójne (oczekiwane dla ~187MB danych treningowych)

### **v0.5-london** 

Znacząca poprawa względem v0.
- Wiktoriański styl pisania, poprawna interpunkcja, w większości poprawne gramatycznie zdania  
- Nadal wysoki poziom halucynacji faktów  
- Szumy OCR („Digitized by Google”) nadal obecne w wyjściach

![TimeCapsuleLLM Przykładowe Wyjście](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Pierwszy model, który potrafi przywołać i połączyć prawdziwe wydarzenie historyczne z rzeczywistą postacią ze zbioru danych.

Przykład: Polecenie: "It was the year of our Lord 1834"

Wynik: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

Początkowo zakładałem, że protest mógłby się przypadkowo odbyć w tym samym roku, ale spójrz na to: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### **v2mini-eval1-london**

Wytrenowano przy użyciu 15 GB próbki z 90 GB zbioru danych v2.
Model trenowany tylko do 10 000 kroków.

Wystąpił problem z tokenizacją, który powoduje, że wyjście wygląda tak:

ZAPYTANIE:
Kim jest Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Poprawiono:

"Kim jest Charles Dickens? Czy to dzieło bardziej jego znakomitego wzruszenia, w jego sztukach, na farmie Wielkiej Kompanii? Co mam jeszcze zacytować z Jacka Picketta? Czy nie wiesz, że byli oni gatunkiem galopujących, lub piłujących swoje piersi, albo co miało być zrobione w czasie, gdy Jackson patrzył przez okno? Jaki jest sukces Anglika i który jego syn nie odkrył mi jeszcze, jak osiągnąć taki ciężar? Czy kiedykolwiek przeszliście na starą drogę, lub do kotwicznego wietrzyka u stóp naszej łodzi, którą musicie nas opuścić? Faktem jest, że bez względu na to, czy wiatr wzniesie się z równiny w sobotnią noc czy w południe, czy na północ, czy inaczej, będziemy zmuszeni opisać potężną barierę, z tymi samymi skutkami co obecnie. W tej sytuacji, przynajmniej, nie jest zbyt wiele powiedzieć, że opuściliśmy to pomieszczenie. Wierzę, że istnieją trzy kopie w 'Pięćsetkrotnym', do których można się odwołać, jako pierwszy numer naszych czytelników, którzy chcą t[o]..."

### **v2mini-eval2-london**

Wytrenowany na tej samej 15GB próbce użytej do treningu eval1.
Model ponownie wytrenowany tylko do 10K kroków.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Proszę Pana, — Następujący przypadek jest dla mnie interesujący: — Przebywałem w Londynie dwa tygodnie i mocno odczułem atak reumatyzmu. Pierwszy atak reumatyzmu nastąpił tydzień przed spotkaniem z Panem, drugi podczas spotkania z Panem, a trzeci także wtedy, podczas tego samego czasu. Drugi atak dny nie był jednak związany z gorączką, lecz towarzyszyło mu zwiększone wydzielanie moczu oraz obfitszy jego wypływ. Trzeci atak nastąpił godzinę po spotkaniu z Panem, po czym nastąpił powrót napadu dny oraz szybszy nawrót dny. Czwarty atak także wiązał się z gorączką, ale nie zawsze występowały objawy gorączkowe. Trzeci atak dny miał miejsce dwa tygodnie po chorobie, a czwarty zakończył się napadem dny. Czwarty atak wystąpił dwa tygodnie po pierwszym ataku i towarzyszyło mu uczucie

### **v2-london**

Wytrenowano na 90GB (112GB po tokenizacji) danych
Trenowano do 182 tys. kroków

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **Co dalej?**

- Rozpoczęto prace nad TimeCapsuleLLM v3
- Skalowanie rozmiaru zbioru danych i zasięgu geograficznego
- Rozszerzenie poza Londyn na kolejne miasta

Prace prowadzone są we współpracy z naukowcami z University College London (UCL), a udział kolejnych instytucji jest omawiany.


##  Zbiory danych

### **v2**

- 90GB(surowych) tekstów londyńskich z lat 1800-1875
- 136 344 dokumenty
- Pełny zbiór tokenizowany dostępny tutaj: https://huggingface.co/datasets/postgrammar/london-llm-1800


 ### Statystyki Uprzedzeń
  ![Uprzedzenie zaimków](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Uprzedzenie geograficzne](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Uprzedzenie czasowe](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Zobacz [raport uprzedzeń v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) po więcej informacji.


- 


## Jak korzystać

Ten projekt skupia się głównie na kuracji danych historycznych, przygotowaniu ich do treningu i budowaniu tokenizera. Nie będę omawiał pełnego procesu treningu LLM, w tym celu zobacz nanoGPT Andreja Karpathy.

### Krok 1: Zbierz i przygotuj teksty historyczne

- Zbierz pliki .txt książek, dokumentów, itp. z domeny publicznej z wybranego okresu (np. Londyn 1800-1875)
- Zachowaj je w wybranym oknie czasowym/miejscowym
- Wyczyść pliki tekstowe za pomocą skryptu lub ręcznie usuń nagłówki/stopki z Project Gutenberg, nowoczesne adnotacje lub błędy OCR.

### Krok 2: Zbuduj własny tokenizator

- Uruchom train_tokenizer.py lub train_tokenizer_hf.py na wyczyszczonych danych.
- Otrzymasz vocab.json i merges.txt
- Te pliki definiują słownik i zasady scalania dla Twojego modelu

### Krok 3: Wytrenuj swój model

- Zobacz [nanoGPT Andreja Karpathy](https://github.com/karpathy/nanoGPT) dla procesu treningowego lub dokumentacji wybranej architektury.

# FAQ

## Czym jest Selektive Temporal Training?

Selective Temporal Training (STT) to metodologia uczenia maszynowego, w której wszystkie dane treningowe są specjalnie kuratowane, aby mieściły się w określonym historycznym okresie. Robi się to, by modelować język i wiedzę tamtej epoki bez wpływu współczesnych koncepcji. Na przykład obecny model, który posiadam (v0.5), jest wytrenowany wyłącznie na danych z lat 1800-1875, nie jest fine-tuningowany, lecz trenowany od zera, co skutkuje wyjściem odzwierciedlającym styl językowy i kontekst historyczny tego okresu.

## Dlaczego nie użyć po prostu fine-tuningu lub LoRA?
W tym projekcie staram się stworzyć model językowy wolny od współczesnych uprzedzeń. Jeśli dokonam fine-tuningu czegoś takiego jak GPT-2, to już jest ono wytrenowane i tych informacji nie da się usunąć. Jeśli wytrenuję model językowy od zera, nie będzie on udawał starego — po prostu taki będzie. Celem tego projektu jest stworzenie czegoś, co potrafi rozumować wyłącznie na podstawie wiedzy z londyńskich książek wydanych między 1800 a 1875 rokiem.

## Jakich danych użyto do trenowania?

Używam książek, dokumentów prawnych, gazet i innych tekstów z Londynu z lat 1800–1875. Lista, którą podlinkowałem (dla v0), zawiera około 200 pozycji, ale do pierwszego treningu użyłem tylko 50 plików o łącznym rozmiarze ok. 187 MB. Listę dokumentów można zobaczyć tutaj:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Rozmiary zbiorów danych:
- v0: ~187MB
- v0.5: ~435MB
- v1: ~6,25GB
- v2mini-eval1: 15GB (próbka z v2 o rozmiarze 90GB)
- v2: 90GB

## Jak duże są modele?

v0: 16M parametrów

v0.5: 123M parametrów

v1: 700M parametrów

v2mini-eval1: 300M parametrów

v2mini-eval2: 200M parametrów

v2: 1,2B parametrów

## Specyfikacja treningu?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.

### v1
GPU: A100 SXM wynajmowany

### v2mini-eval1/eval2

GPU: A100 SXM wynajęty

### v2
GPU: H100 SXM wynajęty

## Prace Powiązane

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  LLM z 13 miliardami parametrów, wytrenowany na 260 miliardach tokenów tekstów sprzed 1930 roku z Q&A. Dostępna jest także [wersja bazowa](https://huggingface.co/talkie-lm/talkie-1930-13b-base).
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  LLM z 1,4 miliarda parametrów, wytrenowany na tekstach z lat 1800-1899 z Q&A. Dostępna jest także [wersja 160M](https://huggingface.co/zakarth/violet-160m-chat).
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  LLM z 340 milionami parametrów, wytrenowany na ponad 28 000 tekstów z lat 1837-1899 z Q&A. 

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - rodzina LLM z 4 miliardami parametrów opartych na architekturze Qwen3, wytrenowanych od podstaw na 80 miliardach tokenów danych historycznych do daty wiedzy 1913,1929,1933,1939,1946.

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT to finetune Mistral-Hermes 2 na 11 000 wczesnonowożytnych tekstów w języku angielskim, francuskim i łacińskim, głównie pochodzących z EEBO i Gallica.

## Podziękowania

Chciałbym podziękować [Dr. Hamedowi Yaghoobianowi](https://hamedyaghoobian.com) za nadzór akademicki, wsparcie w zakresie ram badawczych i oceny, a także za pomoc w treningu tokenizera i przygotowaniu zbioru danych do wydania v2. Jego opinie i doświadczenie były kluczowe w udoskonaleniu prezentacji tej pracy.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---