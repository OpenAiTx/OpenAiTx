# 핸드 제스처 아르페지에이터

손으로 제어하는 아르페지에이터, 드럼 머신, 오디오 반응형 비주얼라이저입니다. 손을 들어 올려 분위기를 띄워보세요!

threejs, mediapipe 컴퓨터 비전, rosebud AI, tone.js로 구축된 인터랙티브 웹 앱입니다.

- 손 #1은 아르페지오를 제어합니다 (손을 들어 올리면 음이 올라가고, 집으면 볼륨이 변경됩니다)
- 손 #2는 드럼을 제어합니다 (다른 손가락을 들어 올리면 패턴이 바뀝니다)

[비디오](https://youtu.be/JepIs-DTBgk?si=4Y-FrQDF6KNy662C) | [라이브 데모](https://collidingscopes.github.io/arpeggiator/) | [더 많은 코드 & 튜토리얼](https://funwithcomputervision.com/)

<img src="https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/assets/demo.png">

## 요구 사항

- WebGL을 지원하는 최신 웹 브라우저
- 손 추적을 위한 카메라 접근 권한

## 사용 기술

- **MediaPipe**: 손 추적 및 제스처 인식
- **Three.js**: 오디오 반응형 시각화 렌더링
- **Tone.js**: 신디사이저 사운드
- **HTML5 Canvas**: 시각적 피드백
- **JavaScript**: 실시간 상호작용
## 개발 환경 설정

```bash
# 이 저장소를 클론합니다
git clone https://github.com/collidingScopes/arpeggiator

# 프로젝트 디렉토리로 이동합니다
cd arpeggiator

# 원하는 방식으로 서버를 실행합니다 (예: Python 사용)
python -m http.server
```

그런 다음 브라우저에서 `http://localhost:8000` 으로 이동합니다.

## 라이선스

MIT 라이선스

## 크레딧
- Three.js - https://threejs.org/
- MediaPipe - https://mediapipe.dev/
- Rosebud AI - https://rosebud.ai/
- Tone.js - https://tonejs.github.io/

## 관련 프로젝트

제가 여러 컴퓨터 비전 프로젝트(코드 + 튜토리얼 포함)를 여기에서 공개했습니다:
[Fun With Computer Vision](https://www.funwithcomputervision.com/)

평생 이용권을 구매하시면 전체 프로젝트 파일과 튜토리얼을 받아보실 수 있습니다. 저는 정기적으로 더 많은 콘텐츠를 추가하고 있습니다 🪬

다른 오픈 소스 프로젝트들도 마음에 드실 수 있습니다:

- [3D Model Playground](https://collidingScopes.github.io/3d-model-playground) - 음성 및 손 제스처로 3D 모델 제어
- [Threejs hand tracking tutorial](https://collidingScopes.github.io/threejs-handtracking-101) - threejs와 MediaPipe 컴퓨터 비전으로 기본 손 추적 설정
- [Particular Drift](https://collidingScopes.github.io/particular-drift) - 사진을 흐르는 파티클 애니메이션으로 변환
- [Video-to-ASCII](https://collidingScopes.github.io/ascii) - 비디오를 ASCII 픽셀 아트로 변환
## 연락처

- 인스타그램: [@stereo.drift](https://www.instagram.com/stereo.drift/)
- 트위터/X: [@measure_plan](https://x.com/measure_plan)
- 이메일: [stereodriftvisuals@gmail.com](https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/mailto:stereodriftvisuals@gmail.com)
- GitHub: [collidingScopes](https://github.com/collidingScopes)

## 후원

이 도구가 유용했다면 커피 한 잔을 사주셔도 좋습니다.

저는 Alan이라고 하며, 컴퓨터 비전, 게임 등 다양한 오픈 소스 소프트웨어를 개발하는 것을 즐깁니다. 늦은 밤 코딩 세션에 큰 힘이 됩니다!

[![Buy Me A Coffee](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/stereoDrift)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---