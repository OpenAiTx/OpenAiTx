<head><meta name="google-site-verification" content="YTr2AYTpsxIQk7KIOlVTOfKr11dqkzZP-gOUiyhPU5s" />
<body>

<h1>KOMB: Klipper의 궁극적인 브러싱 매크로</h1>

KOMB에 오신 것을 환영합니다, Klipper 최적화 브러싱 매크로! 이 다용도 매크로는 베드 및 갠트리 장착 브러시에 맞춤화된 브러싱 시퀀스를 간소화합니다. 기존 매크로를 수정하거나 새로 만드는 번거로움을 없애고, 이제 3차원에서 브러시의 모든 잠재력을 활용하세요!

<h3> 설치: </h3>

KAMP를 시작하는 가장 깔끔하고 쉬운 방법은 Moonraker의 업데이트 관리자 유틸리티를 사용하는 것입니다. 이를 통해 쉽게 설치할 수 있고, 향후 더 많은 기능이 추가될 때 업데이트도 지원합니다!

1. Klipper 장치에 `ssh`로 접속한 후 다음 명령어를 실행하세요:
   ```bash
    cd
    
    git clone https://github.com/TmRxJD/KOMB    

    ln -s ~/KOMB printer_data/config/KOMB

    cp ~/KOMB/_KOMB_Variables.cfg ~/printer_data/config/KOMB_Variables.cfg

    ```
2. `moonraker.conf` 파일을 열고 다음 구성을 추가하세요:

   ```yaml
   [update_manager KOMB]
   type: git_repo
   channel: dev
   path: ~/KOMB
   origin: https://github.com/TmRxJD/KOMB
   managed_services: klipper
   primary_branch: main
    ```

    > **참고:**
    > Moonraker 설정이 변경될 때마다 변경 사항이 적용되려면 반드시 재시작해야 합니다. 앞으로 KAMP 업데이트 알림을 받고 싶지 않다면 이 단계를 건너뛰어도 됩니다.

3. 선택적으로 KOMB_Purge.cfg를 KOMB_Variables.cfg에 포함시켜 해당 매크로를 사용할 수 있습니다. 

<h3>기능 및 작동 방식</h3>

유연한 움직임: KOMB의 기본 동작은 왼쪽 하단 모서리에서 오른쪽으로 스윕하지만, 다양한 축과 방향으로 손쉽게 움직임을 사용자화할 수 있습니다. 프린터와 브러시 위치에 따라 인쇄 중간에도 사용할 수 있습니다.

다양한 패턴: 현재는 대각선 및 원형 스윕(사용하려면 gcode_arcs 활성화 필요)을 지원하며, 곧 더 많은 패턴이 추가될 예정입니다.

3차원 브러싱: 브러시가 닿을 수 있는 전체 영역과 깊이를 활용해 노즐을 더 깨끗하게 유지하고 성능을 일관되게 유지할 수 있습니다. 노즐은 단계별로 브러시 안으로 내려가 더 넓은 노즐 표면이 브러시에 닿도록 할 수 있습니다.

인쇄 중간 사용: KOMB 트리거를 사용하면 인쇄 과정 동안 원하는 만큼 매크로를 실행해 노즐을 항상 깨끗하게 유지할 수 있습니다.

<h3>조정 가능한 브러시 매개변수: 정밀 제어를 위한 변수 조정</h3>
* (X, Y, Z) 위치뿐만 아니라 밀리미터 단위의 크기와 깊이를 지정합니다. <br>
* 스텝 크기: 대각선 또는 원형 스트로크 간 거리 <br>
* Z-스텝: 반복 시 각 반복 후 하강 거리, 0으로 설정하면 비활성화 <br>
* 오프셋: 브러시 경계 밖에서 움직임을 시작하거나 종료할 수 있으며, 내부에 더 제한하려면 음수 값 사용 <br>
* 반복 횟수: 패턴 반복 횟수 지정 <br>
* 역방향: 다음 반복 전에 패턴을 역순으로 반복하도록 활성화. 비활성 시 노즐이 패턴 후 직선으로 시작점으로 이동 <br>
* 반대 및/또는 인접 측 시작: 반대 측 활성화 시 노즐이 오른쪽에서 왼쪽으로 이동. 인접 측 활성화 시 노즐이 반대 축을 따라 아래에서 위로 이동. 둘 다 활성화 시 노즐이 위에서 아래로 이동. <br>
* 가변 속도: mm/s 단위 속도 지정 및 반복마다 속도 증가 또는 감소 가능. 브러시 이동 속도도 제어 가능 <br>
* 패턴: 다양한 브러싱 패턴 중 선택, 현재 대각선과 원형 지원. (고전적인 수평 패턴을 원하면 반대 축 브러시 크기를 0으로 설정, 단계 이동 가능하게 하려면 각도를 0으로 설정) <br>
* 각도: 패턴 1 사용 시 대각선 스트로크 각도 지정, 기본 권장 각도는 45 <br>
* 자동 가열: 활성화하고 브러싱 허용 최소 온도 지정, 브러싱 전에 자동 예열 <br>
* 자동 홈: 필요 시 자동으로 프린트 헤드 홈 위치로 이동, 이미 홈 위치면 동작하지 않음 <br>
* 리트랙션: 브러싱 전, 중, 후 리트랙션 구성 <br>
* Z 홉: 브러시 위치 이동 전 노즐을 올릴 높이 지정, 0으로 설정하면 비활성화.<br>
* 상세 피드백: 축 값, 계산, 위치 포인트 등 브러싱 과정에 대한 자세한 콘솔 출력을 활성화 <br>

<h4>KOMB 트리거</h4>

You can use KOMB at a specified frequency throughout the print to ensure your nozzle stays clean for the entire duration. Include `KOMB_trigger` in the 'at layer change' section of your slicer configuration to effortlessly trigger the macro at your preferred frequency. Additionally, integrate this macro name into your start print routine to use the macro before starting printing. This feature is not intended for per-object printing and is tailored for use with gantry and frame-mounted brushes. While functional with bed-mounted brushes, cautious use is advised, as attention to your printer's clearances is essential to prevent potential collisions. If utilizing Z hop, the nozzle will ascend before maneuvering over the brush, descend for brushing, and subsequently reascend to its initial height before resuming printing. Configure Z hop settings to provide added clearance during elevation and descent. It is strongly recommended not to set the Z hop value below 2. Additionally, ensure that your axis limits are accurately defined for the macro's effective operation. For guidance on setting axis limits, refer to the guide provided at the end of this readme.
<h4>KOMB 퍼지</h4>

KOMB의 퍼징 옵션은 브러싱 시퀀스에 들어가기 전에 제어된 재료 퍼지를 시작할 수 있는 기능을 제공합니다. 이 기능은 Z-오프셋 보정 또는 기타 측정 의존 작업 중과 같이 정밀도가 중요한 경우, 추가 퍼지 라인을 그릴 필요 없이 특히 유용합니다. 이 기능을 사용하면 퍼지 용기의 위치, 원하는 필라멘트 압출량, 그리고 브러싱 시퀀스로 전환하기 전 대기 시간을 쉽게 정의할 수 있습니다. 퍼징 옵션은 매크로의 나머지 부분과 독립적으로도 활성화할 수 있어, 특정 요구 사항에 맞게 인쇄 프로세스를 유연하게 조정할 수 있습니다. 시작 인쇄 시 매크로를 사용하려면 설정에 "KOMB_purge"를 추가하세요.

<h3>KOMB의 차별성</h3>

KOMB는 다양한 프린터 설정에 원활하게 적응하도록 설계되어, 다양한 브러시 크기와 위치를 수용합니다. 특정 위치로 노즐을 강제로 이동시키는 기존 매크로와 달리, KOMB는 변수에 따라 프린터 한계 내에서 사전 조정된 좌표 시퀀스를 생성합니다. 이러한 사전 대응 방식은 사용자 실수에도 불구하고 성공적인 브러싱을 보장하는 오류 위험을 거의 제거합니다. 프린터 경계를 초과하는 모든 생성된 점은 자동으로 경계 내로 조정되어 원활한 실행을 보장합니다. 리스트가 즉시 생성되면, KOMB는 노즐을 미리 정해진 좌표를 따라 쉽게 안내합니다.

<h3>KOMB 시작하기</h3>

3D 프린터에 Klipper 펌웨어가 설치되어 있는지 확인하세요.

공급된 KOMB 매크로 코드 `KOMB.cfg`를 Klipper 구성 파일 "printer.cfg"에 다른 매크로와 함께 통합하세요. 사용 편의성을 높이기 위해 KOMB 변수를 별도의 파일에 유지하고 `[include _KOMB_Variables.cfg]`로 포함하는 것을 권장합니다. 또는 더 편리하다면 메인 구성과 병합할 수도 있습니다.

브러싱 요구 사항에 맞게 KOMB_Variables 섹션에서 변수를 지정하세요.

프린터 UI를 통해 정확한 XY 브러시 위치를 결정하세요. 시작점은 왼쪽 하단 모서리이며, 원하는 경우 0.1mm 정확도로 조정하세요.

브러시 크기를 측정하거나 오른쪽 상단 모서리로 이동한 후 왼쪽 하단 위치를 X 및 Y 축에서 각각 빼서 계산하세요.
Z 위치에 대해서도 유사한 과정을 반복하며, 각 반복마다 노즐을 점진적으로 낮추는 옵션(z_step)을 고려하세요.

구성 파일을 저장하고 Klipper를 다시 로드하여 변경 사항을 적용하세요.

콘솔, UI 매크로 버튼을 통해 KOMB를 실행하거나 시작 인쇄 매크로에 `KOMB`를 추가하세요. 실행 전에 변수가 정확히 설정되었는지 확인하세요.

자세한 출력이 활성화된 경우 콘솔 출력을 통해 진행 상황을 모니터링하세요.

KOMB와 함께 향상된 브러싱을 즐기세요!

<h3>중요 참고 사항</h3>

이 매크로는 다양한 변수와 매개변수를 사용하도록 설계되었습니다. 프린터 사양과 브러싱 요구 사항에 맞게 조정해야 합니다. 각 변수가 무엇을 하는지, 그리고 어떻게 사용하는지 반드시 이해하세요.

매크로가 올바르게 작동하려면 축 한계가 제대로 설정되어야 합니다. 확실하지 않은 경우 이 가이드를 따르세요: https://github.com/rootiest/zippy_guides/blob/main/guides/axis_limits.md

이 매크로는 프린터 노즐을 이동시키므로, 브러싱 과정 중 충돌을 방지하기 위해 주의하고 모든 값이 올바른지 확인하세요. 노즐을 위치에 내리기 전에 브러시 위 낮은 속도에서 매크로를 테스트하는 것을 권장합니다.

앞으로 업데이트와 더 많은 패턴을 위해 꼭 다시 확인하세요!


KOMB는 진행 중인 작업이며 모든 변수 조합이 철저하게 테스트된 것은 아닙니다. 매크로 개선을 위한 여러분의 피드백과 기여를 환영합니다.

문제가 발생하거나 개선 제안이 있거나 KOMB 개발에 기여하고 싶다면 언제든지 메시지를 보내거나 GitHub 저장소에 이슈를 열거나 풀 리퀘스트를 제출해 주세요.

즐거운 KOMB 사용 되세요!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-14

---