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

##  Поведение модели и ограничения

### **v0**  

Ранние запросы показывают, что модель отвечает на языке и с поведением XIX века.  
Пример: Запрос: "Who art Henry?" и ответ: "I know that man, I have did not a black, the storm."  

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Нет упоминаний современных понятий  
- В основном лексика, соответствующая эпохе  
- Предложения в основном несвязные (ожидаемо для ~187МБ обучающих данных)

### **v0.5** 

Значительное улучшение по сравнению с v0.  
- Викторианский стиль письма, корректная пунктуация, в основном грамматически правильные предложения  
- Все еще высокий уровень галлюцинаций фактов  
- Шум от OCR («Digitized by Google») все еще присутствует в выводе

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Первая модель, которая вспомнила и связала реальное историческое событие с реальной фигурой из датасета.

Пример: Запрос: "It was the year of our Lord 1834"  

Результат: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"  

Сначала я предполагал, что протест мог случайно произойти в тот же год, но посмотрите на это: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Обучена на 15ГБ выборке из 90ГБ датасета v2.  
Модель обучалась только до 10К шагов.

Была проблема с токенизацией, из-за которой вывод выглядит так:

Кто такой Чарльз Диккенс?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Исправлено:

«Кто такой Чарльз Диккенс? Является ли это еще одним примером его превосходной волнующей работы, в его пьесах, на ферме Великой Компании? Что мне еще привести из Джека Пикетта? Разве вы не знаете, что они были чем-то вроде скачки, или пиления своих грудей, или что нужно было делать в то время, когда Джексон смотрел в окно? Каков успех англичанина, и что его сын еще не открыл мне, чтобы достичь такой тяжести? Приходилось ли вам когда-либо проходить по старой дороге или к якорной бухте у подножия нашей лодки, которую вы должны покинуть нас? Дело в том, что поднимется ли ветер с равнины в субботу ночью или в полдень, или на север, или иначе, мы будем вынуждены описывать внушительный барьер, с теми же последствиями, что и сейчас. По крайней мере, в этой ситуации нельзя не сказать, что мы покинули ту комнату. Я полагаю, что существует три экземпляра в «Пятисоткратном», к которым можно обратиться, как к первому номеру наших читателей, которые хотят [...”

### **v2mini-eval2**

Обучалась на том же 15ГБ сэмпле, что и eval1.
Модель снова обучалась только до 10К шагов.

ПРОМПТ: Чарльз Дарвин

Чарльз ДарвинECCEMACY. Сэр, — Следующий случай представляется мне интересным: — Я был в Лондоне две недели, и сильно пострадал от приступа ревматизма. Первый приступ ревматизма был за неделю до того, как я вас увидел, второй — когда я вас увидел, и третий — когда я вас увидел, и третий — в то же время. Второй приступ подагры, однако, не сопровождался лихорадочными симптомами, но сопровождался учащенным мочеиспусканием и более обильным выделением мочи. Третий приступ случился через час после встречи с вами и сопровождался возвращением пароксизма подагры и более быстрым возвращением подагры. Четвертый приступ также сопровождался лихорадкой, но не всегда сопровождался лихорадочными симптомами. Третий приступ подагры был через две недели после вашего недомогания, а четвертый сопровождался пароксизмом подагры. Четвертый приступ был через две недели после вашего приступа и сопровождался ощущением

### **v2**

Обучалась на 90ГБ (112ГБ после токенизации) датасете
Обучена до 182К шагов 

![TimeCapsuleLLM Пример вывода](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Пример вывода](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  Датасеты

### **v2**

- 90ГБ (сырых) текстов Лондона 1800-1875 годов
- 136 344 документа
- Полный токенизированный датасет доступен здесь: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### Статистика по предвзятости 
  ![Склонность к местоимениям](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Географическая предвзятость](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Временная предвзятость](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Подробнее см. в [отчете о предвзятости v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json).



## Как использовать

Этот проект в основном посвящён сбору исторических данных, их подготовке для обучения и созданию токенизатора. Я не буду описывать полный процесс обучения LLM, для этого обратитесь к nanoGPT Андрея Карпати.

### Шаг 1: Сбор и подготовка исторических текстов

- Соберите .txt-файлы книг, документов и т.д. из общественного достояния за выбранный вами период (например, Лондон 1800-1850)
- Оставляйте их только в рамках выбранного временного/местного окна
- Очистите текстовые файлы с помощью скрипта или вручную удалите заголовки/подвалы из Project Gutenberg, современные аннотации или такие вещи как ошибки OCR.

### Шаг 2: Построение кастомного токенизатора

- Запустите train_tokenizer.py или train_tokenizer_hf.py на очищенных данных.
- Это даст вам vocab.json и merges.txt
- Эти файлы определяют словарь и правила слияния для вашей модели

### Шаг 3: Обучение вашей модели

- Для процесса обучения обратитесь к [nanoGPT Андрея Карпати](https://github.com/karpathy/nanoGPT) или документации выбранной архитектуры.

# FAQ

## Что такое Selective Temporal Training?

Selective Temporal Training (STT) — это методология машинного обучения, при которой все обучающие данные специально подбираются для соответствия определённому историческому периоду. Это делается, чтобы моделировать язык и знания той эпохи без влияния современных концепций. Например, текущая модель (v0.5) обучена исключительно на данных 1800-1875 годов, она не дообучалась, а обучалась с нуля, поэтому результат отражает языковой стиль и исторический контекст того времени.

## Почему не просто использовать fine-tuning или LoRA?

В этом проекте я стараюсь создать языковую модель, свободную от современных предубеждений. Если я дообучу, например, GPT-2, она уже предварительно обучена, и эта информация никуда не денется. Если я обучу модель с нуля, она не будет "притворяться" старой — она такой и будет. Цель проекта сейчас — создать что-то, что может рассуждать исключительно на основе знаний из лондонских книг, опубликованных между 1800 и 1875 годами.

## Какие данные использовались для обучения?

Я использую книги, юридические документы, газеты и другие тексты из Лондона 1800–1875 годов. Список, который я привёл (для v0), содержит около 200 файлов, но для первого обучения я использовал всего 50 файлов объёмом примерно ~187 МБ. Вы можете посмотреть список документов:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Размеры датасетов:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15ГБ (выборка из 90ГБ v2)
- v2: 90ГБ

## Какой размер моделей?

v0: 16М параметров

v0.5: 123М параметров

v1: 700М параметров

v2mini-eval1: 300М параметров

v2mini-eval2: 200М параметров

v2: 1.2М параметров

## Характеристики обучения?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
ОЗУ: 16ГБ DDR5.

### v1
GPU: A100 SXM (арендовано)

### v2mini-eval1/eval2
GPU: A100 SXM (арендовано)

### v2
GPU: H100 SXM (арендовано)

## Благодарности

Я хотел бы поблагодарить [Др. Хамеда Ягхубиана](https://hamedyaghoobian.com) за академическое руководство, помощь в формулировке и оценке исследования, а также за содействие в обучении токенизатора и подготовке датасета для релиза v2. Его отзывы и опыт были крайне важны для улучшения представления этой работы.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---