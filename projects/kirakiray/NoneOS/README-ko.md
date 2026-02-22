# NoneOS - 브라우저 기반 경량 가상 운영체제

[中文](https://raw.githubusercontent.com/kirakiray/NoneOS/main/./md/README_CN.md) | [日本語](https://raw.githubusercontent.com/kirakiray/NoneOS/main/./md/README_JP.md)

## 프로젝트 소개

NoneOS는 순수 정적 파일 아키텍처를 채택하고 백엔드 서버 지원 없이 실행할 수 있는 혁신적인 브라우저 기반 가상 운영체제 솔루션입니다.

단기 목표: 브라우저 기반 경량 NAS 시스템을 만들어 장치 간 원활한 연결과 협업을 실현하는 것.

- [x] 브라우저 기반 파일 관리 지원
- [x] 북마크 동기화 애플리케이션
- [x] 노트 동기화 애플리케이션 (Notion 유사)
- [x] 파일 전송 애플리케이션 (LocalSend 유사)
- [ ] 노트 동기화 애플리케이션 재구축

## 빠른 시작

공식 사이트 바로 방문: [https://os.noneos.com/](https://os.noneos.com/)

### 로컬 실행
1. 프로젝트를 클론하거나 다운로드하고 로컬에 nodejs가 설치되어 있는지 확인합니다.
2. 의존성 설치:
```bash
npm install
```
3. 서버 시작:
```bash
npm run static
```
1. 방문: `http://localhost:5559/`

## 애플리케이션 생성 방법?

NoneOS는 고급 웹 마이크로 애플리케이션 아키텍처를 채택하고 있으며, 각 애플리케이션은 강력한 ofa.js 프레임워크를 기반으로 구축됩니다. 개발자는 애플리케이션 디렉토리(예: 예제 애플리케이션 `others/hello-world.napp`)를 시스템의 "Apps" 폴더에 간단히 가져오기만 하면 빠르게 배포하고 실행할 수 있습니다.

현재 더 자세한 개발 문서를 작성 중입니다. 그동안 개발자는:
- 공식 ofa.js 문서를 참조하여 프레임워크 기능을 이해할 수 있습니다.
- `packages/apps` 디렉토리 내 예제 애플리케이션을 개발 참고용으로 확인할 수 있습니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---