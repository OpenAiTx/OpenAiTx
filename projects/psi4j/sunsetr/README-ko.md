# sunsetr

<p align="center">
    <img src="https://raw.githubusercontent.com/psi4j/sunsetr/main/.github/assets/logo.png" alt="sunsetr logo" width="144" />
</p>
<p align="center">
    Hyprland, Niri 및 모든 Wayland용 자동 블루라이트 필터
</p>

<p align="center">
  <a href="https://psi4j.github.io/sunsetr/"><img src="https://img.shields.io/badge/Documentation-mdBook-blue" alt="Documentation"></a>
  <a href="https://github.com/psi4j/sunsetr/blob/main/LICENSE"><img src="https://img.shields.io/github/license/psi4j/sunsetr" alt="License"></a>
  <a href="https://github.com/psi4j/sunsetr/releases"><img src="https://img.shields.io/github/v/release/psi4j/sunsetr" alt="Release"></a>
</p>

<p align="center">
  <a href="https://psi4j.github.io/sunsetr/installation.html">설치</a> | <a href="https://psi4j.github.io/sunsetr/quick-start.html">빠른 시작</a> | <a href="https://psi4j.github.io/sunsetr/configuration/">설정</a> | <a href="https://psi4j.github.io/sunsetr/commands/">명령어</a>
</p>

![이 이미지는 sunsetr 효과를 시뮬레이션하기 위해 셰이더를 사용하여 촬영되었습니다](https://raw.githubusercontent.com/psi4j/sunsetr/main/.github/assets/sunsetr.png)

Sunsetr는 Wayland 컴포지터용 자동 블루라이트 필터입니다. 중립적인 색 온도에서 더 따뜻한 톤으로 부드러운 색 온도 전환을 자동화하여 눈의 피로를 줄이고 수면을 개선하도록 설계되었습니다. Sunsetr는 지리 위치 또는 수동 시간 설정을 기반으로 디스플레이를 자동으로 조정합니다. 또한 동일한 색 온도와 감마를 무기한 유지하거나 여러 사용자 정의 프리셋 간 전환에도 사용할 수 있습니다. 컨트롤러는 IPC를 통해 셸이나 UI 애플리케이션과 통합하여 변경사항을 자동화할 수 있습니다.

## 기능

- **멀티 컴포지터 지원**: Hyprland, Niri, Sway, River, Wayfire 및 기타 Wayland 컴포지터와 작동
- **네이티브 Hyprland CTM 백엔드**: Hyprland용 직접 색상 변환 행렬 지원
- **스마트한 hyprsunset 관리**: hyprsunset(Hyprland)에 더 길고 깔끔하며 정밀한 일몰/일출 전환 추가
- **부드러운 전환**: 적응형 알고리즘을 갖춘 구성 가능한 페이드 효과
- **프리셋 관리**: 설정 프로필(예: 낮, 게임, 주말) 간 빠른 전환
- **핫 리로딩**: 설정 파일 변경 시 실시간 업데이트 - 재시작 불필요
- **자동화를 위한 IPC**: 스크립팅 및 외부 통합용 유닉스 소켓 기반 IPC
- **지리 위치 기반 전환**: 위치에 따른 자동 일출/일몰 계산
- **대화형 도시 선택**: 전 세계 10,000개 이상의 도시 중 정확한 좌표 선택 가능
- **자동 시간대 감지**: 위치 근사화를 위해 시스템 시간대 사용
- **범용 Wayland 지원**: Wayland 컴포지터에 직접 프로토콜 통신
- **스마트 기본값**: 신중하게 조정된 설정으로 즉시 훌륭하게 작동
- **유연한 구성**: 고급 사용자를 위한 광범위한 사용자 정의 옵션

## TODO
- [x] AUR 패키지 설정
- [x] Nix 설치 가능하게 만들기
- [x] 점진적 전환 구현
- [x] 다중 컴포지터 Wayland 지원
- [x] 지리 위치 기반 전환
- [x] Hyprland 네이티브 CTM 백엔드 구현
- [x] 스크립팅 및 외부 통합을 위한 IPC 구현
- [ ] Fedora Copr 설치 가능하게 만들기
- [ ] Debian/Ubuntu 설치 가능하게 만들기

## 💛 감사

- 영감을 준 wlsunset, hyprsunset, 그리고 redshift에
- Hyprland를 가능하게 한 Hyprwm 팀에
- 최고의 Rust 기반 Wayland 컴포지터를 만든 niri 팀에
- 강력한 프로토콜 생태계를 제공하는 Wayland 커뮤니티에



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-03

---