
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (скоро)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (скоро)</a> |
        | <a href="#" title="Coming soon">ไทย (скоро)</a> |
        | <a href="#" title="Coming soon">Français (скоро)</a>
        | <a href="#" title="Coming soon">Deutsch (скоро)</a>
        | <a href="#" title="Coming soon">Español (скоро)</a>
        | <a href="#" title="Coming soon">Italiano (скоро)</a>
        | <a href="#" title="Coming soon">Русский (скоро)</a>
        | <a href="#" title="Coming soon">Português (скоро)</a>
        | <a href="#" title="Coming soon">Nederlands (скоро)</a>
        | <a href="#" title="Coming soon">Polski (скоро)</a>
        | <a href="#" title="Coming soon">العربية (скоро)</a>
        | <a href="#" title="Coming soon">فارسی (скоро)</a>
        | <a href="#" title="Coming soon">Türkçe (скоро)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (скоро)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (скоро)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM

*Языковая модель, обученная **с нуля** исключительно на данных из определённых мест и временных периодов, чтобы уменьшить влияние современных предубеждений и воссоздать голос, лексику и мировоззрение той эпохи.*

Представьте, что ИИ-модель не просто притворяется исторической, а действительно таковой является.

v0 и v0.5 построены на [nanoGPT от Andrej Karpathy](https://github.com/karpathy/nanoGPT). Основные обучающие скрипты и архитектура модели — его работа. 

v1 создан на базе [Phi 1.5 от Microsoft](https://huggingface.co/microsoft/phi-1_5)

[Ссылка на Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)


##  Поведение модели и ограничения

### **v0**  

Ранние подсказки показывают, что модель отвечает языком и манерой поведения XIX века.
Пример: Запрос: "Who art Henry?" и ответ: "I know that man, I have did not a black, the storm."

![Пример вывода TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Нет упоминаний современных концепций  
- В основном словарь соответствует эпохе  
- Предложения в основном бессвязны (ожидаемо для ~187МБ обучающих данных)

### **v0.5** 

Значительное улучшение по сравнению с v0.  
- Викторианский стиль письма, правильная пунктуация, в основном грамматически верные предложения  
- Все еще высокий уровень галлюцинаций фактов  
- Шум OCR (“Digitized by Google”) все еще присутствует в выводе

![Пример вывода TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Первая модель, способная вспомнить и связать реальное историческое событие с реальной личностью из датасета.

Пример: Запрос: "It was the year of our Lord 1834" 

Ответ: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

Сначала я предположил, что протест мог случайно произойти в тот же год, но взгляните на это: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Почему это важно:

Это первый пример того, как одна из моих моделей связывает год с реальным историческим событием и реальным человеком, связанным с этим событием (Лорд Пальмерстон). Более ранние модели (v0 и v0.5) могли имитировать стиль письма XIX века, но всегда придумывали события, людей и факты. Это показывает, что модель начинает запоминать данные из датасета.

## Предстоящие планы 

- В Лондоне опубликовано почти 175 000 текстов за период 1800–1875 годов, доступных на Internet Archive 
- Я планирую расширить корпус и дополнительно очистить его для повышения способностей к рассуждению
- Расширение на другие регионы и временные периоды для создания более исторических моделей


## Как использовать

Этот проект главным образом фокусируется на сборе исторических данных, их подготовке для обучения и построении токенизатора. Я не буду освещать полный процесс обучения LLM, для этого обратитесь к nanoGPT от Андрея Карпати.

### Шаг 1: Сбор и подготовка исторических текстов 

- Соберите .txt файлы книг, документов и др. из общественного достояния за выбранный вами период (например, Лондон 1800–1850) 
- Держите их в рамках выбранного временного/географического окна  
- Очистите текстовые файлы с помощью скрипта или вручную удалите заголовки/футеры из Project Gutenberg, современные аннотации и ошибки OCR.

### Шаг 2: Создание кастомного токенизатора

- Запустите train_tokenizer.py или train_tokenizer_hf.py на очищенных данных.
- Это даст вам vocab.json и merges.txt
- Эти файлы определяют словарь и правила объединения для вашей модели

### Шаг 3: Обучение вашей модели 

- Для процесса обучения обратитесь к [nanoGPT от Андрея Карпати](https://github.com/karpathy/nanoGPT) или документации по выбранной архитектуре.

# FAQ

## Что такое селективное временное обучение?

Селективное временное обучение (STT) — это методология машинного обучения, при которой все обучающие данные специально отбираются для попадания в определённый исторический период. Это делается для моделирования языка и знаний той эпохи без влияния современных концепций. Например, текущая модель (v0.5) обучена исключительно на данных с 1800 по 1875 годы, она не дообучалась, а была обучена с нуля, поэтому результат отражает лингвистический стиль и исторический контекст того времени.

## Почему не использовать просто дообучение или LoRA?

В этом проекте я стараюсь создать языковую модель, не затронутую современными предубеждениями. Если я дообучу, например, GPT-2, она уже предварительно обучена, и эта информация не исчезнет. Если же обучить модель с нуля, она не будет "притворяться" старой — она просто будет такой. Цель этого проекта сейчас — создать что-то, что может рассуждать исключительно на основе знаний из лондонских книг, опубликованных с 1800 по 1875 годы.

## Какие данные вы использовали для обучения?

Я использую книги, юридические документы, газеты и другие тексты из Лондона 1800–1875 годов. Список, который я привёл (для v0), содержит около 200 документов, но для первого обучения я использовал только 50 файлов, примерно ~187 МБ. Вы можете посмотреть список документов:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Размеры датасетов:
v0: ~187МБ
v0.5: ~435МБ 
v1: ~6.25ГБ 

## Какого размера модели?

V0: 16М параметров

V0.5 123М параметров

V1: 700М параметров

# Спецификации обучения? 

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
ОЗУ: 16ГБ DDR5.

# V1
GPU: A100 в аренде















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---