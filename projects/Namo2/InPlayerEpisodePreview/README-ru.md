<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <p>Следующие переводы были автоматически сгенерированы с помощью ИИ. Пожалуйста, обратите внимание, что они могут содержать неточности или ссылаться на более старые версии данного readme.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

Предварительный просмотр эпизодов в плеере
====================
## 📄 Описание
Этот плагин добавляет список эпизодов в видеоплеер, что позволяет вам просматривать каждый эпизод сериала, не покидая плеер.

Это модификация поддерживает следующие клиенты:
* [Веб-клиент Jellyfin](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin Media Player](https://github.com/jellyfin/jellyfin-media-player) (JMP) Десктопный клиент

## ✨ Возможности
* Список всех эпизодов сезона
* Переключение между сезонами
* Отображение названия эпизода, описания, миниатюры и прогресса воспроизведения
* Отображение информации об эпизоде, такой как рейтинг сообщества
* Отметить эпизоды как просмотренные или избранные
* Начать новый эпизод
* Совместимость с пользовательскими темами

## 📸 Превью
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Используемая тема: (SkinManager) Kaleidochromic
<br>
На этом превью отсутствуют новые кнопки для отметки эпизода как завершенного или избранного.

## 🔧 Установка

### Веб-клиент Jellyfin (сервер)

> [!ПРИМЕЧАНИЕ]
> Настоятельно рекомендуется установить [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) как минимум версии v2.2.1.0. Это помогает избежать проблем с правами доступа при изменении index.html на любом типе установки!
<details open>
<summary> Смотреть инструкции... </summary>

1. Добавьте манифест `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` как репозиторий плагинов Jellyfin на ваш сервер.
2. Установите плагин `InPlayerEpisodePreview` из репозитория.
3. Перезапустите сервер Jellyfin.
</details>

### Jellyfin Media Player (JMP) Desktop Client (Устаревший)
<details>
<summary> Смотреть инструкции... </summary>

**Устарело с версией JMP [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)**

Поскольку новый клиент JMP использует текущий веб-плеер непосредственно с сервера, больше не требуется напрямую изменять код клиента.

Это рекомендуемый способ установки скрипта на настольный клиент.
Если вы не чувствуете себя уверенно при редактировании файла nativeshell.js самостоятельно (шаги 3-6), вы можете вместо этого скачать полный релиз, в котором скрипт уже добавлен в файл nativeshell.js.
Пока неясно, могут ли возникнуть потенциальные проблемы при замене файла nativeshell.js на версию из релиза, поэтому рекомендуется выполнить все шаги ниже.

1. Скачайте последнюю версию [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) или [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (скрипт уже добавлен в файл nativeshell.js)
2. Извлеките содержимое zip-файла в вашу директорию Jellyfin (например, C:\Program Files\Jellyfin\Jellyfin Media Player)
3. Внутри директории Jellyfin перейдите по пути "web-client\extension"
4. Откройте файл "nativeshell.js" в текстовом редакторе.
5. Внутри файла найдите раздел `const plugins = [];`. Добавьте новую строку в начало списка и вставьте туда `'inPlayerEpisodePreviewPlugin',`. Теперь раздел должен выглядеть примерно так:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. Сохраните файл и перезапустите клиент JMP.
</details>

## 💡 Устранение неполадок

### 1. Кнопка предварительного просмотра не отображается
Это, скорее всего, связано с неправильными правами доступа к файлу `index.html`.

<details>
<summary> Смотрите список возможных решений... </summary>

#### 1.1 Избегайте этой проблемы с помощью плагина [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation).

#### 1.2 Измените владельца внутри контейнера docker
Если вы запускаете jellyfin в контейнере docker, вы можете изменить владельца с помощью следующей команды
(замените jellyfin на имя вашего контейнера, user и group — на пользователя и группу вашего контейнера):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Вы можете запустить это как задачу cron при запуске системы.
(Спасибо [muisje](https://github.com/muisje) за помощь с [этим](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) решением)

#### 1.3 Изменение прав собственности на установке Windows
1. Перейдите в: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. Щелкните правой кнопкой мыши по `index.html` → `Свойства` → вкладка `Безопасность` → нажмите `Изменить`
3. Выберите вашего пользователя из списка и отметьте поле разрешения `Запись`.
4. Перезапустите и сервер, и клиент.
   (Спасибо [xeuc](https://github.com/xeuc) за [это](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) решение)

Если ни одно из вышеуказанных решений не помогло, ознакомьтесь со старыми проблемами. Например, [здесь](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) или [здесь](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
Если вы столкнулись с ошибкой, которую не можете решить самостоятельно, не стесняйтесь открывать новую проблему.
<br/>Пожалуйста, имейте в виду, что каждая система уникальна, что может привести к неожиданному поведению, поэтому добавляйте как можно больше информации о вашей системе.
<br/>Логи Jellyfin и консольные логи из браузера (с префиксом [InPlayerEpisodePreview]) всегда полезны.

## Благодарности
Структура плагина основана и вдохновлена плагином [Jellyscrub](https://github.com/nicknsy/jellyscrub) от [NickNSY](https://github.com/nicknsy).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---