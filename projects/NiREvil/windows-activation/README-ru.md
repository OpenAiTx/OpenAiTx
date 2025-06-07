# Мгновенная активация Windows 10 и 11: решение за 40 секунд.

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> Этот репозиторий содержит способ активации Windows 10 и 11 менее чем за 40 секунд. Оба метода совместимы с версиями Home, Home N, Home single lang, Home country specific, Professional, Education и Enterprise для Windows.

## Метод 1 (рекомендуется)  
### Мгновенная активация Windows с помощью PowerShell  
> [!TIP]
> Существует множество способов запустить PowerShell в Windows 10 и 11. [^1]

Один из самых быстрых способов открыть PowerShell в Windows — использовать поиск в меню «Пуск». Следуйте инструкциям ниже:

<br>

### Шаг 1  
Всё, что вам нужно сделать — нажать значок «Пуск» или поиска и ввести «PowerShell» в строку поиска.  
> Ещё один простой способ: [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### Шаг 2  
Далее необходимо кликнуть по «Запуск от имени администратора», чтобы открыть PowerShell с **административными правами**.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### Шаг 3  
Теперь, после короткой паузы для выполнения, пожалуйста, `скопируйте` эту строку:

```CSS
irm https://get.activated.win | iex
```

---
<br>

### Шаг 4  
Вставьте её (правой кнопкой мыши) и нажмите клавишу Enter. В появившемся окне будет несколько опций, из которых нужно выбрать вариант `1` и подождать несколько секунд до завершения.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### Поздравляем,
ваша Windows активирована.  
Теперь вы можете нажать клавишу Enter для выхода из CMD, закрыть PowerShell и проверить меню активации Windows [^3]

<br><br><br><br><br><br><br><br>

## Метод 2  
### Мгновенная активация Windows через CMD (Командная строка)

<br>

> [!NOTE]
> Не забудьте **подключиться** к **Интернету**
>
> VPN **не требуется**

<br>

### Шаг 1  
Сначала нажмите значок «Пуск» или поиска и введите «CMD» в строке поиска. После появления опции командной строки запустите её от **имени администратора**  
> другие простые способы: [^2].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### Ниже приведён список ЛИЦЕНЗИОННЫХ КЛЮЧЕЙ  

|            **Ключ**            |   **Версия**   |
| :----------------------------: | :------------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 |      Home      |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM |     Home N     |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH | Home sl [^4]   |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR | Home cs [^5]   |
| W269N-WFGWX-YVC9B-4J6C9-T83GX | Professional   |
| MH37W-N47XK-V7XM9-C7227-GCQG9 | Professional N |
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 |   Education    |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ |  Education N   |
| NPPR9-FWDCX-D2C8J-H872K-2YT43 |   Enterprise   |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 |  Enterprise N  |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### Шаг 2  
Установите клиентский ключ KMS.

Используйте команду:

```CSS
slmgr /ipk yourlicensekey
```

> [!NOTE]
> Пожалуйста, выберите один из **лицензионных ключей** из списка, который **соответствует вашей версии Windows**, и замените фразу `yourlicencekey` в команде на выбранный ключ.

> [!TIP]
> Как узнать версию Windows [^3].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### Шаг 3  
Установите адрес KMS-сервера.

Используйте команду:

```CSS
slmgr /skms kms8.msguides.com
```

для подключения к моему KMS-серверу.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### Шаг 4  
Активируйте вашу Windows.
Последний шаг — активировать Windows с помощью команды:

```CSS
slmgr /ato
```

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5e495d42-6ce5-4884-9de2-96a56efb4343" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/aecd9cfd-8c09-4433-b410-a62205a8d692" width="240px">
</p>  

---
<br>

### Шаг 5  
Теперь снова проверьте статус активации [^6].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### Готово ✅  
ваша Windows успешно активирована.

<br>

**Будьте любознательны 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [10 способов запустить PowerShell в Windows](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: Еще один самый простой способ запустить PowerShell: **кликните правой кнопкой мыши** по меню «Пуск» для вызова меню быстрого доступа и выберите **Windows Terminal (admin)** в Windows 11 или **Windows PowerShell (admin)** в Windows 10 из списка меню.
[^3]: Чтобы узнать версию вашей Windows: **кликните правой кнопкой мыши** по меню «Пуск» и выберите пункт **Система**. Версия вашей Windows будет отображаться во втором разделе под **Выпуск**. Также вы можете воспользоваться шагами метода 2, просто скопировав и вставив команды. Скопируйте команды и затем нажмите **правую кнопку мыши** в **cmd или powershell** для вставки.
[^4]: Версия Home Single language.
[^5]: Версия Home Country Specific.
[^6]: Чтобы узнать статус активации Windows, перейдите по пути:  
***Параметры → Обновление и безопасность → меню активации.***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---