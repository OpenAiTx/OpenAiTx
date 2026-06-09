# ESPHome용 Hornet Nest 알람 패널

이 저장소는 **Technology Automation Consulting LLC**에서 개발한 **Hornet Nest 알람 패널**용 공식 지원 **ESPHome** 펌웨어 구성 파일을 보관합니다. Hornet Nest 알람 패널은 전통적인 유선 알람 시스템을 **Home Assistant**를 사용하여 스마트 홈에 통합하도록 설계된 확장 가능하고 맞춤형 IoT 솔루션입니다. 42개의 옵토아이솔레이션 구역, 3개의 릴레이 출력, 유연한 PoE 또는 12V 전원 옵션을 갖추어 유연성과 신뢰성을 제공합니다.

<div style="display: flex; justify-content: space-between;">
  <img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/3D_AlarmPanel_2024-10-06.png" alt="3D Model" width="400"/>
  <img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/hornet-nest-operational.jpg" alt="Installed" width="400"/>
</div>

## 빠른 시작

최신 ESPHome 펌웨어로 Hornet Nest 알람 패널을 신속하게 채택하고 플래싱하여 시작하세요:

1. Hornet Nest 알람 패널에 PoE 전원 이더넷 케이블을 연결합니다.
2. **ESPHome 대시보드**를 열고 "hornet-nest-XXXXXX"(여기서 XXXXXX는 고유한 16진수 식별자) 장치를 찾습니다.
3. 장치에서 **Adopt** 옵션을 클릭합니다.
4. **장치 채택** 대화 상자가 열립니다. 원하면 장치 이름을 변경한 후 다시 **Adopt** 옵션을 클릭합니다.
5. **구성 생성됨** 대화 상자가 열리고 새 구성을 장치에 설치해야 함을 알립니다. **설치** 버튼을 클릭합니다.
6. ESPHome이 새 펌웨어 컴파일을 시작합니다. **"INFO Sucessfully uploaded program."** 문구가 표시되면 **중지**를 클릭하여 창을 닫습니다.
4. **Home Assistant** > **설정** > **장치 및 서비스**에서 Hornet Nest 알람 패널을 찾습니다.
5. 새 장치에서 **구성**을 클릭하여 Home Assistant에 추가합니다.

## 변경 사항 및 릴리스 노트

릴리스 노트 및 다운로드 가능한 사전 빌드 펌웨어 이미지는 **릴리스**를 참조하세요.

## ESPHome용 제작

**Hornet Nest 알람 패널**은 **wESP32 PoE** 마이크로컨트롤러를 사용하며 **ESPHome** 펌웨어와 완벽하게 호환됩니다. 이는 오픈 소스 제품으로 사용자 맞춤화가 용이하도록 설계되어, 확장 가능하고 유연한 알람 솔루션이 필요한 Home Assistant 사용자에게 이상적입니다. 포함된 **ESPHome YAML 구성 파일**은 완전히 문서화되어 있어 고급 사용자가 간단한 수정만으로 장치를 쉽게 맞춤화, 빌드 및 업데이트할 수 있습니다.

## Home Assistant와 연동

이러한 **ESPHome** 펌웨어 구성은 **Home Assistant** 내에서 간단하고 플러그 앤 플레이 설정을 가능하게 합니다. 통합은 로컬이며 빠르고 완전히 사용자 정의할 수 있어 사용자가 홈 보안 시스템을 완벽하게 제어할 수 있습니다.
<img src="https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/images/esphome-integrated.png" alt="ESPHome Device" width="600">

## 이 저장소에 포함된 내용

이 저장소는 최상위에 **Hornet Nest 알람 패널**용 **완전한 펌웨어 구성 YAML 템플릿**을 포함합니다. 이 템플릿들은 **ESPHome 대시보드**를 통해 가져와 맞춤화하고 배포할 수 있도록 준비되어 있습니다.

## 사용자 매뉴얼
자세한 지침은 공식 사용자 설명서 [여기](https://raw.githubusercontent.com/taconsultingllc/hornet-nest-alarm-panel/main/hnap-user-manual.pdf)를 참조하십시오.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-09

---