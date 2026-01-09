
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  Коллекция модификаций, улучшений и ресурсов обратного инжиниринга для Creation Kit от Bethesda.
</p>

# Описание
**CKPE** — это мощная платформа с открытым исходным кодом, которая вносит множество исправлений и улучшений в редактор Creation Kit от **Bethesda**, включает поддержку редактора для таких игр, как **Skyrim Special Edition**, **Fallout 4**, **Starfield**, является преемником проектов [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test), а также [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test), с которого все началось для автора **perchik71**.  

Страница [Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki)  

# Зависимости
[toml11](https://github.com/ToruNiina/toml11) от `ToruNiina` и других  
[Zydis](https://github.com/zyantific/zydis.git) от `zyantifi` и других  
[zipper](https://github.com/kuba--/zip.git) от `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) от `ebiggers` и других  
[xbyak](https://github.com/herumi/xbyak.git) от `herumi` и других    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) от `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) от `perchik71` *(рекурсивно)*

# Установка
### Чистая установка
Скачайте любую [поддерживаемую игру](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) и установите Creation Kit.  
Скачайте [последний релиз](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) **CKPE** для вашей игры.  
Распакуйте все файлы в директорию игры, чтобы **ckpe_loader.exe** находился в одной папке с **CreationKit.exe**.
### Обновление
Скачайте [последний релиз](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) **CKPE** для вашей игры.  
Распакуйте все файлы в директорию игры, чтобы **ckpe_loader.exe** находился в одной папке с **CreationKit.exe**.  
Согласитесь на замену всех файлов.
### Компиляция
Обычным пользователям этот способ нужен только для доступа к новейшим функциям, которые еще не были выпущены.  
Откройте проект в **`Visual Studio 2022`** или новее. Соберите проект в режиме **`Release`** или **`Release-NoAVX2`**.  
Затем переместите скомпилированные файлы в директорию игры, чтобы **ckpe_loader.exe** находился в одной папке с **CreationKit.exe**.  
Если будет предложено заменить старые файлы, согласитесь на замену всех.
### Автоматизация сборок (Beta)
Скачайте [сборку последнего коммита](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) **CKPE** для вашей игры.  
Распакуйте все файлы в директорию игры, чтобы **ckpe_loader.exe** находился в одной папке с **CreationKit.exe**.  
Возможны ошибки.

# Благодарности
[Nukem9](https://github.com/Nukem9) (за экспериментальные функции, хэши и многое другое, очень полезно)  
[adzm](https://github.com/adzm) (очень ценю вашу работу, вы [сделали](https://github.com/adzm/win32-custom-menubar-aero-theme) то, что я давно хотел сделать сам)  
[yak3d](https://github.com/yak3d) (за вклад и развитие рабочего процесса, а также поддержку новейшего Starfield)  
[Dio-Kyrie](https://github.com/Dio-Kyrie) (за оформление readme)  

# Лицензия
Начиная с версии v0.6 (коммит [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) проект лицензируется по [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Ранние версии лицензированы по [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Copyright © 2023-2025 aka perchik71. Все права защищены. <br />
Файл `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` содержит проприетарные и нелицензированные файлы; то же относится к файлам в `d3dcompiler\*.*`. <br />
Зависимости распространяются на условиях их соответствующих лицензий. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---