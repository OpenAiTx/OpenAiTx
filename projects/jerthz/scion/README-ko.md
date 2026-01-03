<img src="https://raw.githubusercontent.com/jerthz/scion/main/banner.png" alt="Scion" />

Scion은 러스트로 만들어진 2D 게임 라이브러리입니다.

> 이 프로젝트는 초기 마일스톤 단계에 있으며 편의성 요구와 큰 기능 추가에 따라 변경될 수 있음을 알려드립니다.
> 
> Scion은 자유롭게 사용하실 수 있지만, 현재 러스트 게임 엔진 생태계의 경쟁자가 되기보다는 커뮤니티에 기여하고자 오픈 소스로 공개한 것입니다.

## 왜 이 프로젝트인가? 
우선 게임 개발의 다양한 측면을 내부적으로 배우는 좋은 방법이기 때문입니다. 
그리고 사용의 용이성에 초점을 맞추고 명확한 원칙 목록으로 가이드라인 역할을 하는 겸손한 목표를 가진 무언가를 만들고 싶었기 때문입니다.

Scion은 다른 엔진에서 '영감을 받은' 것이 아니라 실제 게임 프로젝트의 필요에서 영감을 받았습니다. 이는 다른 곳에서 봤다고 기능을 구현하는 것이 아니라 Scion을 사용하는 다음 프로젝트에 필요해서 구현한다는 뜻입니다.

### 목표
- 오직 **2D**에 강력히 집중.
- **쉽고** **재미있게** 사용 가능. 
- 깔끔하고 읽기 쉬운 소스 코드 (필요 시 재작성 시도)
- 에디터가 없는 라이브러리로 항상 유지

### 비목표
- 극한/과도하게 최적화된 코드와 성능. 이 부분은 다른 엔진을 시도하거나 직접 만드세요!
- 3D

## 문서, 튜토리얼?
예, 계획되어 작업 중입니다. 지금은 Scion을 직접 보고 싶다면 예제들을 확인해 보세요.

## 왜 ECS인가?
오늘날 ECS는 게임, 게임 라이브러리, 게임 엔진에서 '마법' 같은 단어입니다. 하지만 ECS는 만능 해답이 아니며 그렇게 간주되어서는 안 됩니다.
ECS는 강점과 약점이 있다고 믿습니다. 
여기서 ECS를 선택한 이유는 이 라이브러리의 초기 대상 게임들이 다음과 같았기 때문입니다: 
- 복잡한 도시 건설 게임.
- 실시간 트레이너 진행과 야생 포켓몬이 있는 포켓몬 팬 게임.
- 세밀한 네트워크 패킷 표현과 점 시뮬레이션 게임.

## 주요 의존성
이 프로젝트가 의존하는 라이브러리들입니다. 이 멋진 커뮤니티 덕분에 이런 작은 프로젝트를 만들 수 있었습니다. 

- <a href="https://github.com/rust-windowing/winit" target="blank">winit</a> 및 <a href="https://github.com/gfx-rs/wgpu/tree/master/wgpu" target="blank">wgpu</a> (윈도잉 및 다중 백엔드 렌더링)
- <a href="https://github.com/Ralith/hecs" target="blank">hecs</a> (엔티티 컴포넌트 시스템)
- <a href="https://github.com/termhn/ultraviolet" target="blank">ultraviolet</a> (수학)

## 사전 요구사항
Scion을 빌드하려면 시스템에 필요한 패키지를 설치해야 합니다: 
### Debian, Ubuntu, PopOS...
```sh
sudo apt install gcc cmake build-essential libx11-dev libxi-dev libgl1-mesa-dev libasound2-dev
```

### 페도라
```sh
sudo dnf install gcc cmake make automake gcc gcc-c++ kernel-devel libX11-devel libXi-devel mesa-libGL-devel alsa-lib-devel
```
### 아치, 만자로...

```sh
sudo pacman -S gcc cmake make automake linux-headers libx11 libxi mesa alsa-lib
```

### 예제 실행
그런 다음, 예제를 실행할 수 있습니다:
```sh
cargo run --example bomberman --release
```
## 쇼케이스

| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/taquin/taquin_2.gif" alt="Taquin" style="width:300px; border: 2px solid black;"/>  | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/tetris/tetris.gif" alt="Tetris" style="width:300px" />             | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/pixel-adventures/pixel-adventures.gif" alt="Pixel-adventures" style="width:300px" /> |
|---------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------|
| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/bomberman/bomberman.gif" alt="Bomberman" style="width:300px" />                    | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/jezzball/jezzball.gif" alt="Jezzball" style="width:300px" />       | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/new-bark-town/new-bark-town.gif" alt="New bark town" style="width:300px" />          |
| <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/starlight-1961/starlight.gif" alt="Starlight" style="width:300px" />               | <img src="https://raw.githubusercontent.com/jerthz/scion/main/./examples/klondike.gif" alt="Starlight" style="width:300px" /> | |




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---