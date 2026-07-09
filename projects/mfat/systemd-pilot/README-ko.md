# systemd Pilot

systemd Pilot은 GNU/linux 시스템에서 systemd 서비스를 관리하기 위한 데스크톱 애플리케이션입니다. systemctrl의 GUI로 설명할 수 있습니다.

![image](https://github.com/user-attachments/assets/85ee68be-aa3e-4291-8435-ef9ee7b8b72f)


![Screenshot From 2024-12-31 11-26-27](https://github.com/user-attachments/assets/09a58f8c-7d2b-4bc3-87db-561221295b18)


![Screenshot From 2024-12-31 11-28-58](https://github.com/user-attachments/assets/1c5653ab-31bc-4fd1-b607-1240dd85f831)


![Screenshot From 2024-12-31 11-29-24](https://github.com/user-attachments/assets/b9eb7194-b3dc-4c17-8ecc-8946374a2ca1)

![Screenshot From 2024-12-31 11-29-41](https://github.com/user-attachments/assets/2715e99c-2a96-406b-9d55-4f3512bbc345)


## 기능
- 로컬 머신 또는 원격 호스트에서 시스템 서비스 목록 보기
- 템플릿을 사용하여 새 서비스 빠르게 배포
- 서비스 시작, 중지, 재시작 및 상태 표시
- 간편한 검색. 입력만 시작하면 앱이 관련 서비스를 찾아줌
- 가볍고 시스템 자원 소모 적음 (단일 Python 스크립트)
  
## 다운로드
- 배포판에 맞는 패키지를 [릴리즈](https://github.com/mfat/systemd-pilot/releases) 섹션에서 다운로드하세요.
  
## 요구사항
Python 스크립트를 직접 실행하려면 다음 요구사항이 필요합니다:

Python 모듈:
- PyGObject>=3.42.0
- paramiko>=3.0.0
- keyring>=24.0.0
- rich>=13.0.0
- PyYAML

Debian 의존성:
- `sudo apt install 
    python3-gi 
    python3-gi-cairo 
    gir1.2-gtk-3.0 
    gir1.2-gtksource-4 
    python3-paramiko 
    python3-yaml 
    python3-keyring`
  
Fedora/RHEL 종속성:
- `sudo dnf install python3
      python3-gobject
      python3-paramiko
      python3-keyring
      python3-rich
      python3-cairo
      python3-gobject
      python3-dbus
      python3-secretstorage
      gtk4
      libadwaita
      gtksourceview4
      systemd`
  


## 개발 지원
비트코인:`bc1qqtsyf0ft85zshsnw25jgsxnqy45rfa867zqk4t`

도지코인:`DRzNb8DycFD65H6oHNLuzyTzY1S5avPHHx`

  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-09

---