## FanImeTsf

Это TSF-реализация для [FanImeServer](https://github.com/fanlumaster/FanImeServer).

Внимание: в настоящее время поддерживаются только 64-битные приложения.

## Как собрать

### Необходимые компоненты

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

Убедитесь, что vcpkg и gsudo установлены через **Scoop**.

## Шаги сборки

### Сборка

Сначала клонируйте репозиторий,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

Затем подготовьте окружение,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

Далее, соберите проект,

```powershell
.\scripts\lcompile.ps1
```

### Установка

Запустите PowerShell от имени администратора, убедитесь, что у вас включена системная опция `Enable sudo`.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

Затем создайте папку `FanImeTsf` в `C:\Program Files\` и скопируйте в неё файл `FanImeTsf.dll`,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

После этого установите его,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### Удаление

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## Скриншоты

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## План развития

В настоящее время поддерживается только Сяохэ Шуанпинь.

### Китайский язык

- Сяохэ Шуанпинь
- Цюаньпинь (полная раскладка)
- Помощь по использованию иероглифических компонентов
- Пользовательский словарь
- Настраиваемый движок IME
- Настраиваемые темы оформления
- Переключение между упрощённым и традиционным китайским
- Автодополнение на английском
- Открытый API облачного IME
- Переключение интерфейса окна кандидатов между вертикальным и горизонтальным режимами
- Переключатели функций: большинство возможностей должны свободно настраиваться пользователями

### Поддержка японского

Возможно, будет реализовано в другом проекте.

Также возможно добавление поддержки других языков.

### Ссылки

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---