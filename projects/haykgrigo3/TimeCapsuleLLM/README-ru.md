<div align="right">
  <details>
<summary>🌐 Язык</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Языковая модель, обученная **с нуля** исключительно на данных из определённых мест и временных периодов, чтобы снизить влияние современных предубеждений и воссоздать стиль, лексику и мировоззрение той эпохи.*

Представьте, если бы ИИ-модель не просто изображала историческую личность, а действительно была ею.

v0 и v0.5 построены на [nanoGPT Андрея Карпаты](https://github.com/karpathy/nanoGPT). Основные обучающие скрипты и архитектура модели — его работа.

v1 построена на [Phi 1.5 от Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 построена на llamaforcausallm

[Ссылка на Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Статус исследования
Этот проект был инициирован и разработан независимо.

В настоящее время он проводится под академическим руководством, с участием в исследовательском сотрудничестве с колледжем Мюленберг.

## Цитирование

Если вы используете этот датасет или модель в академической работе, пожалуйста, цитируйте:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## Присоединяйтесь к Vintage LLM Discord

Если вам интересны **исторические языковые модели**, **датасеты, привязанные ко времени**, или будущее таких проектов, как **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox**, присоединяйтесь к нашему сообществу.

Мы используем сервер для обсуждения идей, обмена прогрессом и общения с другими участниками в этой области.

[Присоединиться к Discord](https://discord.gg/JeWkk4z5)

## Поведение модели и ограничения

### **v0**  

Ранние подсказки показывают, что модель отвечает на языке и с манерами 1800-х годов.  
Пример: Подсказка: "Who art Henry?" и ответ: "I know that man, I have did not a black, the storm." 

![TimeCapsuleLLM Пример вывода](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Нет упоминаний современных понятий  
- В основном аутентичная лексика эпохи  
- Предложения в основном бессвязны (ожидаемо для ~187МБ обучающих данных)

### **v0.5-london** 

Значительное улучшение по сравнению с v0.  
- Викторианский стиль письма, правильная пунктуация, в основном грамматически правильные предложения  
- Всё ещё высокий уровень фактических галлюцинаций  
- Шум OCR («Digitized by Google») всё ещё встречается в выводах

![TimeCapsuleLLM Пример вывода](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Первая модель, способная вспомнить и связать реальное историческое событие с реальной фигурой из датасета.

Пример: Подсказка: "It was the year of our Lord 1834" 

Вывод: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Сначала я подумал, что протест в этот год мог произойти случайно, но взгляните на это: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

Обучена на 15 ГБ выборке из 90 ГБ датасета v2.
Модель обучалась только до 10 000 шагов.

Была проблема с токенизацией, из-за которой вывод выглядит так:

ЗАПРОС:
Кто такой Чарльз Диккенс?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

Исправлено:

«Кто такой Чарльз Диккенс? Является ли это работой, более отличающейся своим воодушевлением, в его пьесах, на ферме Великой Компании? Что мне еще нужно процитировать из Джека Пикетта? Разве вы не знаете, что они были чем-то вроде галопа или пиления своих грудей, или что нужно было делать в то время, когда Джексон смотрел в окно? В чем заключается успех англичанина, и чего его сын еще не открыл мне, чтобы достичь такого веса? Вы когда-нибудь проходили по старой дороге или к якорной пристани у подножия нашей лодки, которую вы должны покинуть? Дело в том, что поднимется ли ветер с равнины в субботу вечером или в полдень, или к северу, или иначе, мы будем вынуждены описать грозный барьер с теми же последствиями, что и сейчас. По крайней мере, в этой ситуации нельзя не сказать, что мы покинули ту комнату. Я полагаю, есть три экземпляра в «Пятистахкратном», к которым следует обратиться, как к первым номерам наших читателей, желающих т[o]…»

### **v2mini-eval2-london**

Обучена на том же 15ГБ сэмпле, что использовался для тренировки eval1.
Модель снова обучалась только до 10К шагов.

ПРОМПТ: Charles Darwin

Charles DarwinECCEMACY. Сэр, — Следующий случай интересен для меня: — Я был в Лондоне две недели и сильно пострадал от приступа ревматизма. Первый приступ ревматизма был за неделю до встречи с вами, второй — когда я увиделся с вами, третий — когда я увиделся с вами, и третий — в то же самое время. Второй приступ подагры, однако, не сопровождался какими-либо лихорадочными симптомами, но сопровождался увеличением потока мочи и более обильным выделением мочи. Третий приступ был через час после встречи с вами и сопровождался возвращением приступа подагры и более быстрым возвращением подагры. Четвертый приступ также сопровождался лихорадкой, но не всегда сопровождался лихорадочными симптомами. Третий приступ подагры был через две недели после болезни, а четвертый сопровождался приступом подагры. Четвертый приступ был через две недели после вашего заболевания и сопровождался ощущением

### **v2-london**

Обучена на датасете размером 90ГБ (112ГБ токенизированных данных)
Обучена до 182К шагов 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **Что дальше?**

- Начата разработка TimeCapsuleLLM v3
- Масштабирование объема датасета и географического охвата
- Расширение за пределы Лондона на другие города

Работа ведется в сотрудничестве с исследователями из Университетского колледжа Лондона (UCL), обсуждается привлечение дополнительных организаций.


##  Датасеты

### **v2**

- 90ГБ (сырых) текстов Лондона 1800–1875 годов
- 136 344 документа
- Весь токенизированный датасет теперь доступен здесь: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### Статистика предвзятости 
  ![Склонность к местоимениям](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Географическая предвзятость](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Временная предвзятость](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

См. [отчёт о предвзятости v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) для получения дополнительной информации.


- 


## Как использовать

Этот проект в основном посвящён сбору исторических данных, их подготовке к обучению и созданию токенизатора. Я не буду рассматривать полный процесс обучения LLM, для этого обратитесь к nanoGPT Андрея Карпаты.

### Шаг 1: Сбор и подготовка исторических текстов 

- Соберите .txt-файлы книг, документов и т.д. из общественного достояния выбранного вами периода (например, Лондон 1800–1875)
- Держите их в рамках выбранного временного/географического окна  
- Очистите текстовые файлы с помощью скрипта или вручную удалите заголовки/подвалы с Project Gutenberg, современные аннотации или такие вещи, как ошибки OCR.

### Шаг 2: Создание пользовательского токенизатора

- Запустите train_tokenizer.py или train_tokenizer_hf.py на очищенных данных.
- Это даст вам vocab.json и merges.txt
- Эти файлы определяют словарь и правила объединения для вашей модели

### Шаг 3: Обучение вашей модели 

- Для процесса обучения обратитесь к [nanoGPT от Андрея Карпаты](https://github.com/karpathy/nanoGPT) или к документации выбранной вами архитектуры.

# FAQ

## Что такое выборочное временное обучение?

Выборочное временное обучение (Selective Temporal Training, STT) — это методика машинного обучения, при которой все данные для обучения специально отбираются так, чтобы соответствовать определённому историческому периоду. Это делается для моделирования языка и знаний той эпохи без влияния современных концепций. Например, текущая модель (v0.5) обучена только на данных 1800–1875 годов, она не дообучалась, а обучена с нуля, что приводит к результатам, отражающим языковой стиль и исторический контекст того времени.

## Почему бы просто не использовать дообучение или LoRA?

Для этого проекта я пытаюсь создать языковую модель, свободную от современных предубеждений. Если я дообучу что-то вроде GPT-2, она уже предварительно обучена, и эта информация никуда не денется. Если я обучаю модель с нуля, она не будет притворяться старой, она просто будет таковой. Цель этого проекта сейчас — создать что-то, что способно рассуждать исключительно на основе знаний из лондонских книг, опубликованных между 1800 и 1875 годами.

## Какой тип данных вы использовали для обучения?

Я использую книги, юридические документы, газеты и другие произведения Лондона 1800–1875 годов. Список, который я привёл (для v0), содержит около 200 документов, но для первого обучения я использовал только 50 файлов примерно на ~187 МБ. Вы можете посмотреть список документов:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Размеры датасетов:
- v0: ~187МБ
- v0.5: ~435МБ 
- v1: ~6,25ГБ 
- v2mini-eval1: 15ГБ (выборка из 90ГБ v2)
- v2: 90ГБ

## Насколько большие модели?

v0: 16М параметров

v0.5: 123М параметров

v1: 700М параметров

v2mini-eval1: 300М параметров

v2mini-eval2: 200М параметров

v2: 1,2B параметров

## Характеристики обучения?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Оперативная память: 16ГБ DDR5.

### v1
GPU: A100 SXM арендованный

### v2mini-eval1/eval2
GPU: A100 SXM арендован

### v2
GPU: H100 SXM арендован

## Связанные работы

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  - LLM с 13 млрд. параметров, обученная на 260 млрд. токенов текста до 1930 года с вопросами и ответами. Также есть [базовая](https://huggingface.co/talkie-lm/talkie-1930-13b-base) версия.
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  - LLM с 1,4 млрд. параметров, обученная на текстах 1800-1899 годов с вопросами и ответами. Также есть версия на [160M](https://huggingface.co/zakarth/violet-160m-chat).
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  - LLM с 340 млн. параметров, обученная на более чем 28 000 текстах 1837-1899 годов с вопросами и ответами.

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - семейство LLM на 4 млрд. параметров на архитектуре Qwen3, обученные с нуля на 80 млрд. токенов исторических данных до среза знаний 1913,1929,1933,1939,1946 гг.

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT — дообучение Mistral-Hermes 2 на 11 000 текстах раннего Нового времени на английском, французском и латинском языках, преимущественно из EEBO и Gallica.

## Благодарности

Я хотел бы поблагодарить [д-ра Хамеда Ягхубиана](https://hamedyaghoobian.com) за научное руководство, помощь в формулировке и оценке исследования, а также поддержку в обучении токенизатора и подготовке датасета для релиза v2. Его обратная связь и опыт были крайне важны для улучшения представления этой работы.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---