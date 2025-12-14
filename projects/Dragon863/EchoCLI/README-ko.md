> [!IMPORTANT]
> 만약 당신이 에코를 루팅하려는 경우, 이 프로젝트는 이제 구식입니다; 대신에 [여기](https://xdaforums.com/t/unlock-root-twrp-unbrick-amazon-echo-dot-2nd-gen-2016-biscuit.4761416/)에 문서화된 솔루션을 사용하세요. 이 프로젝트를 가능하게 해 주신 모든 분들께 정말 감사드리며, 이 작업을 하면서 정말 즐거웠습니다! :)

# EchoCLI
에코 닷 2세대를 위한 테더드 루트 솔루션입니다.
시작하려면 `main.py`를 실행하세요.
<br>

[<kbd> <br> 이것이 어떻게 작동하나요? <br> </kbd>](https://dragon863.github.io/blog/echoroot.html)

## 공지
- 소프트웨어 업데이트가 지속적으로 푸시되므로, 이 방법이 당신의 에코에서 작동한다고 보장할 수 없습니다. 문제가 발생하면 언제든지 연락해 주세요, 버그를 발견하면 풀 리퀘스트도 환영합니다.
- 윈도우에서는 테스트할 수 없으며 윈도우 특정 버그가 있을 수 있으므로, 이 프로그램은 **강력히** 리눅스에서 실행할 것을 권장합니다.

> **경고**
> 
> **이것은 테더드 루트 솔루션입니다** 아마존 OTA 서버(https://d1s31zyz7dcc2d.cloudfront.net 및 https://d1s31zyz7dcc2d.cloudfront.prod.ota-cloudfront.net)를 차단하여 업데이트가 루트를 손상시키거나 제거하는 것을 방지하는 것이 _권장_됩니다. 기기에 발생하는 손상에 대해 저는 책임을 지지 않습니다.

## 기능
- USB 또는 Wi-Fi를 통한 루팅된 ADB 셸
- 기기에서 오디오 녹음
- 인터넷 없이도 Home Assistant를 위한 에코 인디케이터로 사용
- 기기를 공장 초기 설정으로 복원

## 설치
- 이 프로젝트는 파이썬 3을 필요로 합니다.
- 이 프로그램 실행에는 리눅스를 사용하는 것을 권장합니다. 설치되어 있다면 ModemManager를 비활성화했는지 확인하세요.
`pip`를 사용하여 요구 사항을 설치하세요:
```sh
pip install -r requirements.txt
```
- 또한 fastboot와 ADB가 필요하며, 설치 방법에 대한 좋은 가이드는 [여기](https://wiki.lineageos.org/adb_fastboot_guide)에 있습니다. 이들을 다운로드한 후에는 config.json 파일에서 실행 경로를 설정할 수 있습니다.  
- echo dot을 연결할 때 사용하는 마이크로 USB 케이블이 데이터 전송용 케이블인지, 단순 전원 공급용이 아닌지 반드시 확인하세요.  

## 문서  
이 도구가 어떻게 작동하는지에 대해서는 [제 웹사이트](https://dragon863.github.io/blog/echoroot.html)에서 확인할 수 있습니다.  

기기를 루팅하면 `preloader_no_hdr.bin`이라는 파일이 생성됩니다. 기기를 부팅하려면 [mtkclient](https://github.com/bkerler/mtkclient)를 설치하고, 해당 파일을 mtkclient 디렉터리에 복사한 뒤 `python mtk plstage --ptype=kamakiri2 --preloader=preloader_no_hdr.bin` 명령어를 실행해야 합니다. 설치된 파이썬 버전에 따라 `python`을 `python3`로 대체하세요.  

## 홈 어시스턴트 인디케이터  
홈 어시스턴트 인디케이터 기능을 사용할 때는 라즈베리 파이 제로 W 또는 다른 작은 SBC를 이용해 파이썬 Flask 서버를 실행하고 기기를 부팅하는 것을 권장합니다. crontab을 사용하여 부팅 시 자동으로 mtkclient를 실행할 수 있습니다.  

## 에코 기기가 벽돌이 되었나요?  
루팅되었거나 부분적으로 루팅된 에코를 언브릭하기 위해 mtkclient를 사용하는 방법은 [여기](https://github.com/Dragon863/EchoCLI/blob/main/debrick.md) 가이드를 참고하세요.  

## 감사의 말씀  

이 프로젝트는 다음 분들 없이는 불가능했을 것입니다:  
- [j10hx40r](https://forum.xda-developers.com/m/j10hx40r.11878441/) - 초기 루팅 지원, 패치 시스템 재설계, fos_flags 조합 사용법 안내 및 전반적인 리소스 탐색 방향 제시  
- [xyzz의 Amonet](https://github.com/xyzz/amonet) - 본 기기에 적용한 부트롬 익스플로잇을 포함한 익스플로잇 소스  
- [chaosmaster](https://github.com/chaosmaster) - GPT 수정 등에서 사용한 유용한 amonet 코드 다수 작성  

## 연락처  
- 이메일: dragon863.dev@gmail.com  
- XDA 포럼 대화 시작: [여기](https://forum.xda-developers.com/m/lemon86.12487447/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---