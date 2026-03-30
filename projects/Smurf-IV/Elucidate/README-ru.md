
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [Описание проекта](#project-description)
- [Системные требования:](#os-requirements)
- [Часто задаваемые вопросы](#faqs)
- [Дорожная карта](#roadmap)
- [Скриншоты](#screenshots)

## Описание проекта

Elucidate — это графический интерфейс для Windows, работающий с командной строкой приложения SnapRAID.

*Этот проект продолжает объединение отличной работы, выполненной мной и другими участниками.

## Системные требования

- Операционная система Windows
- .Net Runtime 4.8.0
- SnapRaid версии 11.5 или ниже
- 10MB свободного места на целевом диске

## Часто задаваемые вопросы

**В**: Что такое SnapRAID?<br/>
**О**: SnapRAID — это программный движок snapshot-паритета для операционных систем Windows и Linux. На базовом уровне он обеспечивает защиту содержимого файловой системы под своим управлением, вычисляя хэши ее компонентов и сохраняя результаты в паритетном файле. В случае полного сбоя жесткого диска этот паритетный файл может быть использован для восстановления утраченных данных. Для подробной информации посетите [официальное сравнение двигателей защиты данных SnapRAID.](http://snapraid.sourceforge.net/compare.html)

**В**: Зачем нужен графический интерфейс, ведь командная строка работает!<br/>
**О**: Основная цель — создать полноценный графический интерфейс с дополнительными функциями управления, призванными помочь пользователю поддерживать рабочую среду SnapRAID. Иногда “точка и клик” проще для новичка, чтобы начать работу. Техническая документация SnapRAID и его гибкая настройка могут отпугнуть тех, кто хочет попробовать!

**В**: Я все еще не уверен, есть ли что-то еще?<br/>
**О**: Да, ознакомьтесь с [документацией](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) с изображениями и прочим.

**В**: Какие же “большие цели”?<br/>
**О**: Смотрите __Дорожную карту__ ниже для полного описания.

## Дорожная карта

- [x] Фаза I
  - [x] Стараться поддерживать минимально необходимую совместимость с последними версиями SnapRAID. - __Продолжается.__
  - [x] Удобство использования
  - [x] У SnapRAID три команды, поэтому сделаем их простыми для доступа новичкам 
  - [x] Индикаторы прогресса 
  - [x] Логирование "Интерактивное" и напрямую в журнал. 
  - [x] Автоматический запуск при входе пользователя 
  - [x] Подсказки для навигации •	

- [x] Фаза II Запросы функций для Фазы II
  - [x] Пауза, изменение приоритета, остановка.
  - [x] Расширение команд – "Разрешить дополнительные параметры к используемым по умолчанию."
  - [x] Планирование 
    - Удалено, используйте CommandLine
  - [x] Графическое отображение защищённых данных.

- [ ] Фаза III (Перезапуск с 2017-03 и далее)
  - [x] Новый компилятор и .Net 4.7.x	
  - [x] Интерфейс командной строки
  - [ ] Новый макет через Krypton Toolkit / Navigator / и т.д. 
    - В процессе
  - [ ] Переводы 
  - [x] Новые команды
  - [ ] Почтовая рассылка со статусом отчетов
  - [ ] Документирование шагов тестирования
    - В процессе
  - [ ] Добавить в документацию / обновить изображения
    - В процессе
  - [ ] Добавить отчеты об ошибках в _Windows EventLog_
  - [x] Добавить _ExceptionLess_ для онлайн-отчётности об исключениях
  - [x] Показать, что можно восстановить. 

- [ ] Фаза IV (новые команды SnapRAID?) 
  - [ ] Расширенная справка с восстановлением дисков – интерактивные инструкции и др.
  - [ ] Уведомлять пользователя, если версия SnapRAID устарела
  - [ ] Интерпретировать логи SnapRAID (используются для изменений ниже)
  - [ ] Предоставлять статус массива после выполнения команды
  - [ ] Изменить команду sync для включения начального diff
  - [ ] Изменить команду sync для вывода предупреждения, если diff обнаружил проблемы выше порога
  - [ ] Добавить пользовательские настройки для требований по порогу синхронизации


## Скриншоты

![Начальный вид](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Форма настроек](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## Можете помочь? 
- Ищем тестировщиков (все платформы .Net)
- Может помочь с переводом
- Помощь / Руководства по пользовательскому интерфейсу
- Любые другие идеи :-)
- Разработчики для идей


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---