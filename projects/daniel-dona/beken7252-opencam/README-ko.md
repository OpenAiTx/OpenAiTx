# Beken7252 OpenCam
A9 카메라용 RT-Thread 대체 프로젝트

# 업데이트
## 25/09/25
저는 석사 과정을 마쳤고 이제 시간이 좀 더 생겼습니다. 이 카메라들이 아직 많이 남아 있어서 이 프로젝트의 첫 정식 릴리스를 계획할 때입니다. 몇 주 동안 작업해 왔고 현재는 부팅, Wi-Fi 연결, SD 카드 읽기 및 쓰기, MQTT 지원, 그리고 가장 중요한 세 가지 이상의 카메라 센서(GC0311, HI704, GC0328)와 작동하는 초기 버전을 가지고 있습니다. 여기에는 사진 저장 및 HTTP(multipart/x-mixed-replace)를 사용한 스트리밍도 포함됩니다.

안정성 테스트와 SDK 및 프로젝트의 전반적인 상태 개선이 추가로 필요합니다.

버전 1.0.0에 대한 자세한 계획은 [이 티켓](https://github.com/daniel-dona/beken7252-opencam/issues/21)을 확인하세요.

## 20/11/2023
지난달에는 A9 카메라가 하나뿐이라 추가 카메라가 도착하기를 기다리고 있었고, 테스트용 전선 납땜과 탈착을 반복하면서 PCB를 망칠까 걱정했습니다.
하지만 예상과는 달리, 알리익스프레스에서 3유로 정도에 12대 정도의 다양한 카메라를 받았습니다.

~6대는 Beken 칩이 장착된 것

~3대는 미확인 칩으로, XRadio/Allwinner 커스텀 같음

~1대는 기억나지 않는 다른 제조사 칩

~1대는 마킹 없는 칩

네, 숫자가 정확히 맞지 않지만 중요한 것은 Beken 칩이 달린 카메라가 더 많다는 점입니다... 아니, 그럴까요?

칩에는 BK7252라고 표시되어 있지만 핀 배열이 다릅니다. 우리가 문서화하고 데이터시트를 가진 칩은 68핀인데, 이 칩은 48핀이고 참조는 BK7252UQN48입니다.

자세한 내용은 여기를 참고하세요: https://github.com/daniel-dona/beken7252-opencam/wiki/BK7252-SoC-variations

현재 이 칩으로 작업하지 않을 예정입니다. 이 칩에 작동하는 코드를 업로드해 보았지만 예상대로 작동하지 않습니다. 확실히 일부 기능이 제거되었거나 핀 다중화가 다르게 설정되었을 수 있습니다. 메모리 영역이 다르거나, 아니면 제가 바보라서 코드를 잘못 업로드했을 수도 있고요...

어쨌든, 알려진 칩에서 우선 작동하는 것을 만드는 것이 낫다고 생각하며, 이후에 이 새로운 칩을 탐구할 수 있습니다.

# 알려진 SDK들
- FreeRTOS: https://github.com/YanMinge/beken_freertos_sdk_release
- RT-Thread: https://github.com/YangAlex66/bdk_rtt 와 https://github.com/biemster/bdk_rtt_v3

# 관련 소스 및 게시물:
- [TODO]


# TODO

- PCB 및 센서 변종 문서화
- 카메라 변종의 핀배열 문서화
- 플래싱 절차 문서화 (및 언브릭킹)
- Beken SDK 정리
- SDK 코드를 최신 GCC 및 Scons로 마이그레이션
- 기타 (?)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-29

---