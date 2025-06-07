# Windows 10 & 11 즉시 활성화: 40초 솔루션

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> 이 저장소에는 Windows 10 및 11을 40초 이내에 활성화할 수 있는 방법이 포함되어 있습니다. 두 방법 모두 Home, Home N, Home Single Language, Home Country Specific, Professional, Education, Enterprise 버전의 Windows와 호환됩니다.

## 방법 1 (추천)  
### (PowerShell)을 이용한 즉시 Windows 활성화  
> [!TIP]
> Windows 10 & 11에서 PowerShell을 실행하는 다양한 방법이 있습니다. [^1]

Windows에서 PowerShell을 여는 가장 빠른 방법 중 하나는 시작 메뉴 검색을 이용하는 것입니다. 아래 단계를 따라 하세요:

<br>

### 1단계  
시작 또는 검색 아이콘을 클릭한 후, 검색창에 "PowerShell"을 입력하세요.  
> 또 다른 쉬운 방법: [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### 2단계  
그 다음, `관리자 권한으로 실행(Run as Administrator)`을 클릭해 PowerShell을 실행하세요. 이 경우 **관리자 권한**으로 실행해야 합니다.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### 3단계  
이제 잠깐 대기한 뒤, 아래의 명령어를 `복사`하세요:

```CSS
irm https://get.activated.win | iex
```

---
<br>

### 4단계  
복사한 명령어를 (마우스 오른쪽 클릭으로) 붙여넣고 엔터 키를 누르세요. 새로 열린 창에서 여러 옵션이 제공되며, 여기서 `1`번 옵션을 선택하고 몇 초간 기다리면 완료됩니다.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### 축하합니다,
Windows가 활성화되었습니다.  
이제 엔터 키를 눌러 CMD를 종료하고 PowerShell을 닫은 후, Windows 활성화 메뉴를 확인하세요 [^3]

<br><br><br><br><br><br><br><br>

## 방법 2  
### CMD(명령 프롬프트)를 이용한 즉시 Windows 활성화

<br>

> [!NOTE]
> 반드시 **인터넷**에 **연결**되어 있어야 합니다.
>
> VPN은 **필요하지 않습니다**

<br>

### 1단계  
먼저, 시작 또는 검색 아이콘을 클릭한 후, 검색창에 "CMD"를 입력하세요. 명령 프롬프트 옵션이 나타나면 **관리자 권한**으로 실행하세요.  
> 또 다른 쉬운 방법: [^2].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### 다음은 라이선스 키 목록입니다

|            **키**            |    **버전**    |
| :--------------------------: | :------------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 |      Home      |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM |     Home N     |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH |  Home sl [^4]  |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR |  Home cs [^5]  |
| W269N-WFGWX-YVC9B-4J6C9-T83GX |  Professional  |
| MH37W-N47XK-V7XM9-C7227-GCQG9 | Professional N |
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 |   Education    |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ |  Education N   |
| NPPR9-FWDCX-D2C8J-H872K-2YT43 |   Enterprise   |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 |  Enterprise N  |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### 2단계  
KMS 클라이언트 키를 설치하세요.

다음 명령어를 사용하세요:

```CSS
slmgr /ipk yourlicensekey
```

> [!NOTE]
> 위 목록에서 **자신의 Windows 버전에 맞는 라이선스 키**를 선택한 후, 명령어의 `yourlicencekey` 부분에 해당 키로 교체해 입력하세요.

> [!TIP]
> Windows 버전 확인 방법 [^3].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### 3단계  
KMS 서버 주소를 설정하세요.

다음 명령어를 사용하세요:

```CSS
slmgr /skms kms8.msguides.com
```

내 KMS 서버에 연결합니다.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-8742-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### 4단계  
Windows를 활성화하세요.  
마지막 단계로, 아래 명령어를 입력해 Windows를 활성화합니다:

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

### 5단계  
이제 다시 한 번 활성화 상태를 확인하세요 [^6].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### 완료 ✅  
Windows가 성공적으로 활성화되었습니다.

<br>

**항상 궁금해하세요 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Shows an illustrated sun in light mode and a moon with stars in dark mode." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [Windows에서 PowerShell 실행하는 10가지 방법](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: PowerShell을 실행하는 또 다른 가장 쉬운 방법: **시작 메뉴를 마우스 오른쪽 클릭**하여 빠른 링크 메뉴를 호출한 뒤, Windows 11에서는 **Windows Terminal(관리자)**, Windows 10에서는 **Windows PowerShell(관리자)** 를 선택하세요.
[^3]: Windows 버전을 확인하려면: **시작 메뉴를 마우스 오른쪽 클릭** 후 **시스템** 옵션을 선택하세요. Windows 버전은 **에디션** 항목에서 확인할 수 있습니다. 또한 방법 2의 단계를 **복사/붙여넣기**로 따라 할 수 있습니다. 명령어를 복사한 후 **cmd 또는 powershell** 창에서 **마우스 오른쪽 클릭**으로 붙여넣으세요.
[^4]: Home Single Language 버전.
[^5]: Home Country Specific 버전.
[^6]: Windows 활성화 상태를 확인하려면:  
***설정 → 업데이트 및 보안 → 활성화 메뉴.***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---