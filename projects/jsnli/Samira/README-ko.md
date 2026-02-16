# Samira

리눅스용 Steam 업적 관리자

![example](https://raw.githubusercontent.com/jsnli/Samira/master/./assets/screenshot.png)

## 설명
Samira는 업적을 해제하고 통계를 설정할 수 있는 데스크탑 애플리케이션입니다.  

## 설치 및 사용법
릴리스는 [여기](https://github.com/jsnli/Samira/releases)에서 확인할 수 있습니다.

Steam이 실행 중이어야 하며 사용자가 로그인되어 있어야 합니다.

Flatpak은 지원되지 않습니다. Steam은 배포판의 패키지 관리자를 통해 설치하거나 공식 [steam 페이지](https://store.steampowered.com/about/)의 설치 프로그램을 통해 설치해야 합니다.

## 빌드

이 프로젝트를 빌드하려면 Tauri의 [필수 조건](https://tauri.app/start/prerequisites/)과 Rust, Node, npm이 필요합니다.

리포지토리를 클론하고 설치하세요:
```
cd Samira && npm install
```
Tauri는 라이브러리 검색 경로를 자동으로 설정하지 않습니다. 이것은 Tauri에서 알려진 문제이며 공식 수정이 제공될 때까지 직접 설정해야 합니다:  

```
export LD_LIBRARY_PATH=$LD_LIBRARY_PATH:/usr/lib/libsteam_api.so
```

The `libsteam_api.so` file is available in `/assets/`.

**Dev**
```
npm run tauri dev
```

**빌드**
```
npm run tauri build
```
아치 기반 배포판에서는 Tauri와 linuxdeploy가 잘못된 `strip` 바이너리를 사용하여 번들링 오류가 발생할 수 있습니다. 해결 방법은 다음과 같습니다:

```
NO_STRIP=true npm run tauri build
```

## 기여하기
이전 버전들과 마찬가지로, Samira는 오픈 소스이며 기여를 환영합니다. 질문이 있으면 자유롭게 문의하고, 풀 리퀘스트를 열고, 이슈를 제기해 주세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---