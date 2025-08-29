# Turbodrone
Amazon에서 판매되는 약 $50짜리 인기 "장난감" 드론들을 닫힌 소스의 모바일 앱 대신 컴퓨터에서 제어할 수 있도록 리버스 엔지니어링한 API 및 클라이언트입니다.

![S20 Drone Short Clip](https://raw.githubusercontent.com/marshallrichards/turbodrone/master/docs/images/s20-drone-short-clip-small.gif)

## 소개
요즘 Amazon에서는 기본적으로 초기 DJI 매빅을 축소한 형태의 믿을 수 없을 만큼 저렴한 "장난감" 드론들이 있습니다. 단지 약 $50에 FPV 및 녹화를 위한 1080p 카메라, 위치 및 고도 유지를 위한 작은 하향 광학 흐름 센서, 그리고 기본적으로 잘 조율된 비행 프로필을 제공합니다. 이런 드론들의 유일한 문제는 폐쇄형 펌웨어를 사용하며 맞춤형 모바일 앱으로만 제어가 가능하다는 점입니다. 저는 이런 드론들을 "감옥"에서 해방시키고, 모바일 앱이 작동하는 방식을 리버스 엔지니어링하여 비디오 피드에 접근하고 드론에 제어 명령을 전달할 수 있는 API와 클라이언트를 작성하는 것이 멋질 것 같다고 생각했습니다. 이렇게 하면 매우 강력한 $50짜리 "장난감" 드론을 프로그래밍 방식으로 제어할 수 있어 다양한 응용 및 실험에 사용할 수 있습니다.

## 하드웨어
* WiFi 카메라 드론 (추천 순서대로):

    | 브랜드      | 모델 번호       | 호환성       | 구매 링크                                                  | 비고 |
    |------------|-----------------|-------------|------------------------------------------------------------|-------|
    | Karuisrc   | K417            | 테스트 완료 | [Amazon](https://www.amazon.com/Electric-Adjustable-AIdrones-Quadcopter-Beginners/dp/B0CYPSJ34H/) | 현재 가장 좋아하는 모델. 이 목록에서 유일하게 브러시리스 모터 탑재! 빌드 품질이 환상적입니다. |
    | Loiley     | S29             | 테스트 완료 | [Amazon](https://www.amazon.com/Beginners-Altitude-Gestures-Adjustable-Batteries/dp/B0CFDVKJKC)        | 최고 빌드 품질, 카메라 틸트를 위한 서보 있음(_API에는 아직 구현 안 됨_) |
    | Hiturbo    | S20             | 테스트 완료 | [Amazon](https://www.amazon.com/dp/B0BBVZ849G), [대체 Amazon 링크](https://www.amazon.com/Beginners-Foldable-Quadcopter-Gestures-Batteries/dp/B0D8LK1KJ3) | 원래 테스트 플랫폼, 훌륭한 빌드 품질 |
    | FlyVista   | V88             | 테스트 완료 | [Amazon](https://www.amazon.com/dp/B0D5CXY6X8)                                         |       |
    | ?          | D16/GT3/V66     | 테스트 완료 | 가장 저렴한 제품 [Aliexpress](https://www.aliexpress.us/item/3256808590663347.html), [Amazon](https://www.amazon.com/THOAML-Batteries-Altitude-Headless-360%C2%B0Flip/dp/B0F1D6F62J/) | DJI Neo 클론의 20% 크기. 실내 비행에만 적합. |
    | 여러 브랜드 | E58             | 테스트 완료 | [Amazon](https://www.amazon.com/Foldable-Quadcopter-Beginners-Batteries-Waypoints/dp/B09KV8L7WN/)     |       |
    | 여러 브랜드 | E88/E88 Pro     | 추정       | [Amazon](https://www.amazon.com/Foldable-Camera-Quadcopter-Altitude-Beginner/dp/B0DZCLFQXN)            |       |
    | 여러 브랜드 | E99/E99 Pro     | 추정       | [Amazon](https://www.amazon.com/LJN53-Foldable-Drone-Dual-Cameras/dp/B0DRH9C6RF)                      |       |
    | Swifsen    | A35             | 추정       | [Amazon](https://a.co/d/bqKvloz)                                                        | 매우 작은 "장난감" 드론 |
    | 알 수 없음 | LSRC-S1S        | 추정       |                                                            | WiFi UAV 앱 리버스 엔지니어링 작업에서 언급됨 |
    | Velcase   | S101            | TODO       | [Amazon](https://www.amazon.com/Foldable-Beginners-Quadcopter-Carrying-Positioning/dp/B0CH341G5F/)    | S29 및 S20보다 낮은 품질의 빌드, 배터리 및 프로펠러가 더 작음 |
    | Redrie    | X29             | TODO       | [Amazon](https://www.amazon.com/Adults-1080P-Foldable-Altitude-Auto-Follow-Batteries/dp/B0CZQKNYL5)    | 현재 작업 중 |

    _**테스트 완료**란 드론이 실제로 turbodrone으로 실행되어 호환성이 확인된 것을 의미합니다._

    _**추정**은 드론 APK가 테스트된 드론과 동일한 패키지 및 라이브러리를 사용하는 것으로 보이는 경우입니다._

    _**TODO**는 APK가 다른 바이트 패킷 및 프로토콜을 사용하여 API에 새로운 구현으로 추가해야 함을 의미합니다._

* WiFi 동글 ([ALFA Network AWUS036ACM 추천](https://www.amazon.com/Network-AWUS036ACM-Long-Range-Wide-Coverage-High-Sensitivity/dp/B08BJS8FXD) 또는 유사 제품) 
  * 드론이 자체 WiFi 네트워크를 방송하므로 컴퓨터가 해당 네트워크에 연결해야 합니다.
  * 컴퓨터 내장 WiFi 라디오를 사용해도 되나, 이렇게 하면 드론을 조종하면서 인터넷 연결을 유지할 수 있어 편리합니다.

## 설치
`backend` 디렉터리로 이동하세요

```
cd backend
```
venv 추가

```
python -m venv venv
source venv/bin/activate
```

종속 항목 설치
```
pip install -r requirements.txt
```
_만약_ 윈도우를 사용 중이라면, `curses` 라이브러리를 수동으로 설치해야 합니다.

```
pip install windows-curses
```
새 터미널 창을 열고 프런트엔드에 필요한 종속성을 설치합니다.  
_Node.js 20 이상이 설치되어 있는지 확인하세요._

```
cd frontend
npm install
```
WiFi 동글이 꽂혀 있고, 드론이 켜져 있으며, 진행하기 전에 "BRAND-MODEL-XXXXXX" 네트워크에 연결되어 있는지 확인하세요.

`backend` 디렉토리에 `.env` 파일을 만드세요. 가지고 있는 드론에 따라 DRONE_TYPE을 추가하세요:

```
# For "com.vison.macrochip" (s2x) based drones like S20 and S29:
DRONE_TYPE=s2x
# For WiFi UAV-based drones like V88 and D16:
# DRONE_TYPE=wifi_uav 
```

백엔드 실행: 
```
uvicorn web_server:app
```
별도의 터미널에서 프론트엔드 웹 클라이언트를 실행합니다:

```
npm run dev
```
웹 클라이언트를 열면 `http://localhost:5173`에서 드론 비디오 피드를 볼 수 있으며 제어할 수 있습니다.

게임 컨트롤러로 제어하려면 연결 후 스틱을 움직여 인식시키고 토글 버튼을 눌러 키보드와 컨트롤러 제어를 전환하세요.

안전한 장소에서 비행하세요. 바람이 적은 야외가 좋습니다. "착륙" 버튼은 _현재_ 드론 모터를 즉시 멈추는 비상 정지 버튼입니다.


## 상태
재접속 로직이 최근 해결되었습니다.

비디오 피드: 안정적입니다.

제어: 웹 클라이언트를 통해 크게 개선되었습니다. WiFi UAV 기반 드론 구현은 다소 조정이 필요합니다.

웹 클라이언트: 키보드, 게임패드 컨트롤러, ThinkPad 트랙포인트 마우스(ㅋㅋ) 등 다양한 입력을 지원합니다.

[아마존 베스트셀러 드론 목록](https://www.amazon.com/best-selling-drones/s?k=best+selling+drones)에서 더 많은 드론 지원을 추가 중입니다.


## 기여하기
새로운 "장난감" 드론 지원을 기여하려면, 드론이 사용하는 APK를 미러 사이트에서 다운로드하고 [jadx](https://github.com/skylot/jadx)로 자바 파일로 디컴파일해 역공학을 시작하세요.
그 후 `AndroidManifest.xml`을 살펴보고 앱의 진입점인 클래스를 찾으세요. TCP 또는 UDP 같은 포트 사용이나 프로토콜 사용이 명시되어 있는지 확인하세요. 대부분의 앱은 실제 통신과 비디오 피드 처리를 APK 내부에 포함된 네이티브 C++ 라이브러리에서 수행합니다. Ghidra 같은 도구로 네이티브 라이브러리를 디컴파일하여 유용한 정보를 찾을 수 있습니다. 비디오 피드 처리에서는 JPEG, YUV 등의 포맷과 압축 사용 여부, 패킷에서 이미지 프레임 재구성 시 바이트 구조를 파악하세요.
또한 Wireshark는 앱이 송수신하는 원시 데이터 패킷을 이해하는 데 매우 유용합니다. Hiturbo S20 드론 지원 추가를 위한 역공학 과정을 보여주는 [영상](https://x.com/marshallrichrds/status/1923165437698670818)을 참고하세요.

RC와 비디오 프로토콜 및 처리를 파악한 후에는 작은 테스트 프로그램을 만들어 `experimental` 디렉터리에 추가하여 다른 사람들이 시도할 수 있게 하세요.
그 후 기존 백엔드 아키텍처와 호환되는 구현 작업을 진행할 수 있습니다. 예로 `s2x`와 `wifi_uav` 역공학 구현이 있습니다.


## 실험적 지원
제한된 지원을 받는 드론과 앱으로 Turbodrone에 완전히 통합되지 않은 경우 `experimental` 디렉터리를 참고하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---