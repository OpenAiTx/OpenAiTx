# <p align="center">Fire Tools</p>

[![GitHub Download Stats)](https://img.shields.io/github/downloads/mrhaydendp/Fire-Tools/total?style=for-the-badge)](https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip) [![Latest Release](https://img.shields.io/github/v/release/mrhaydendp/Fire-Tools?style=for-the-badge
)](https://github.com/mrhaydendp/fire-tools/releases/latest)

Fire Tools는 Fire 태블릿에서 구글 서비스를 디블로트하고 설치하여 더 빠르고 사용성을 향상시키는 강력한 도구 모음입니다. 또한 Nova, Lawnchair 또는 모든 `.apk(m)`와 같은 맞춤 런처를 지원합니다. 여러 앱을 빠르게 설치해야 한다면 배치 설치 프로그램이 있습니다. 모든 `.apk(m)` 파일을 Batch 폴더에 넣고 Batch Install 버튼을 클릭하는 것만큼 쉽습니다! 루트 권한이 필요 없습니다!

![Fire Tools Screenshot](https://raw.githubusercontent.com/mrhaydendp/Fire-Tools/main/Screenshot.png)

**기능:**
* 크로스 플랫폼 (Linux, macOS, & Windows)
* 강력한 디블로트 도구
* 아마존 추적 및 광고 제한
* 구글 플레이 설치기 (Android 8+/Fire OS 7+)
* 맞춤 런처 지원 (신형 Fire OS 버전에서 LauncherHijack)
* OTA 업데이트 비활성화
* Apk 추출기
* 배치 설치기 (.apk 및 .apkm 파일)
* 맞춤 DNS 선택기 (AdGuard, Cloudflare 등)

**설치 지침 (Python):**

먼저 [Setup-Instructions.md](/Setup-Instructions.md)에 설명된 단계를 따라 진행하세요! 그 후 설치 지침을 진행합니다. 설치 후 최신 스크립트 버전을 받으려면 업데이트 도구를 실행하세요!

**Linux/macOS:**

``` shell
# Download Latest Release & Extract, Then Run
curl -LO https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip
unzip Fire-Tools.zip && rm Fire-Tools.zip
cd Fire-Tools
chmod +x Scripts/Posix/*.sh
pip3 install -r requirements.txt
python3 main.py
```

**윈도우 파워셸:**

``` powershell
# Download Latest Release & Extract, Then Run
Start-BitsTransfer "https://github.com/mrhaydendp/fire-tools/releases/latest/download/Fire-Tools.zip"
Expand-Archive .\Fire-Tools.zip .\; Remove-Item .\Fire-Tools.zip
Set-Location Fire-Tools
pip install -r requirements.txt
python main.py
```
**중요 참고 사항:**

* 이 프로젝트는 유사한 목표를 가지고 있지만 Datastream33의 Amazon Fire Toolbox와는 관련이 없습니다.
* Fire Tools의 일부 기능은 Fire OS 업데이트로 인해 작동하지 않을 수 있지만 가능한 한 유지하려고 노력할 것입니다.
* 디블로트 전에 시간대 설정을 하세요! (날짜 및 시간 설정을 변경하려면 `com.amazon.kindle.otter.oobe`를 다시 활성화하세요)
* Google 앱은 [ApkMirror](https://www.apkmirror.com/)에서 다운로드되며 편의를 위해 릴리스에 포함되어 있습니다. 자세한 내용은 [약관](https://github.com/mrhaydendp/Fire-Tools/blob/main/Fire-Tools/Gapps/README.md)을 참조하세요. APK 이름 및 해당 URL은 Fire-Tools/Gapps/README.md에서 확인할 수 있습니다.
* 디블로트는 대부분의 아마존 앱을 비활성화하지만 `Calculator`, `Camera`, `Clock`, `Files`, `Fire Launcher`, `Silk Browser`, `Settings`는 제외됩니다.
* 보증 및 초기화: Fire Tools 사용은 보증을 무효화하지 않으며 모든 변경사항은 공장 초기화로 되돌릴 수 있습니다.
* 면책 조항: 이 도구를 개발했지만 사용 중 발생하는 문제에 대해 책임을 지지 않습니다.

**감사의 말:** Fire Tools는 다음 프로젝트에 감사를 표하며 편의를 위해 포함하고 있습니다:

* [Google](https://www.android.com/) (GApps)
* [TeslaCoil Software](https://novalauncher.com/) (Nova Launcher)
* [Lawnchair](https://github.com/LawnchairLauncher/Lawnchair) (Lawnchair)
* [BaronKiko](https://github.com/BaronKiko/LauncherHijack) (LauncherHijack)
* [D0k3](https://github.com/d0k3/OneClick-for-Amazon-Fire) (OneClick-for-Amazon-Fire 도구에서 영감을 받음)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-16

---