<div align="center">  
  <a href="https://irokaru.github.io/pixel-scaler/">
    <img src="https://raw.githubusercontent.com/irokaru/pixel-scaler/master/./public/logo.png" width="33%" alt="Pixel Scaler Logo"/>
  </a>
  <p><b>픽셀 아트 업스케일링 도구</b></p>

  <!-- Badges -->
  <p>
    <a href="https://github.com/irokaru/pixel-scaler/releases/latest"><img src="https://img.shields.io/github/v/release/irokaru/pixel-scaler.svg?style=for-the-badge" alt="Latest Release"/></a>
    <img src="https://img.shields.io/github/downloads/irokaru/pixel-scaler/total?style=for-the-badge" alt="Downloads"/>
    <a href="https://app.codecov.io/gh/irokaru/pixel-scaler/tree/master"><img src="https://img.shields.io/codecov/c/github/irokaru/pixel-scaler?style=for-the-badge" alt="Coverage"/></a>
    <a href="https://x.com/IroKaru"><img src="https://img.shields.io/twitter/follow/irokaru?style=for-the-badge" alt="Follow on X"/></a>
  </p>
</div>

## 개발 환경

* node (>= 22.x)
* rust (>=1.85.0)
  * (Tauri 개발에 필요)

## 개발용 설정 (WSL)

의존성 설치:

```sh
npm ci
```
(선택 사항) Tauri를 사용하려면:


```sh
cargo install tauri-cli
sudo apt install -y libsoup2.4-dev javascriptcoregtk-4.1 libsoup-3.0 webkit2gtk-4.1 \
                    libjavascriptcoregtk-4.0-dev libwebkit2gtk-4.0-dev librsvg2-dev
```
## 사용 가능한 명령어

| 명령어                   | 설명                                                        |
|-------------------------|------------------------------------------------------------|
| `npm run dev`           | Vite를 사용하여 개발 서버 시작                              |
| `npm run dev:tauri`     | Tauri 개발 서버 시작                                        |
| `npm run build`         | 프로덕션용 프로젝트 빌드                                   |
| `npm run build:tauri`   | tauri로 프로젝트 빌드                                      |
| `npm run preview`       | 빌드된 프로젝트 미리보기 (`npm run build` 선행 필요)       |
| `npm run test`          | 테스트 실행                                               |
| `npm run test:watch`    | 감시 모드로 테스트 실행                                    |
| `npm run test:coverage` | 커버리지와 함께 테스트 실행                                |
| `npm run test:e2e`      | playwright로 테스트 실행                                  |
| `npm run clean`         | 생성된 파일 제거                                          |
| `npm run lint-staged`   | 스테이징된 파일에 린팅 실행                               |
| `npm run prepare`       | Git 훅을 위한 Husky 설정                                  |

## 스케일링 라이브러리

* xBRjs (저작권 2020 Josep del Rio)
  * https://github.com/joseprio/xBRjs



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-27

---