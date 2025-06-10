# Cheating Daddy

> [!NOTE]  
> 최신 MacOS 및 Windows 버전을 사용하세요. 구버전은 지원이 제한됩니다.

> [!NOTE]  
> 테스트 중에는 질문을 해도 답변하지 않습니다. 면접관이 질문하는 상황을 시뮬레이션해야 답변합니다.

실시간 AI 어시스턴트로, 화면 캡처와 오디오 분석을 통해 화상 통화, 면접, 프레젠테이션, 회의 중에 맥락에 맞는 도움을 제공합니다.

## 주요 기능

- **실시간 AI 지원**: Google Gemini 2.0 Flash Live 기반의 실시간 지원
- **화면 및 오디오 캡처**: 보고 듣는 내용을 분석하여 맥락에 맞는 답변 제공
- **다중 프로필**: 면접, 영업 통화, 비즈니스 회의, 프레젠테이션, 협상
- **투명 오버레이**: 어디에나 위치시킬 수 있는 항상-위 창
- **클릭-스루 모드**: 필요시 창을 마우스 클릭에 투명하게 전환
- **크로스플랫폼 지원**: macOS, Windows, Linux(일부 지원, 테스트용으로만 사용 권장)

## 설치 방법

1. **Gemini API 키 받기**: [Google AI Studio](https://aistudio.google.com/apikey) 방문
2. **의존성 설치**: `npm install`
3. **앱 실행**: `npm start`

## 사용법

1. 메인 창에 Gemini API 키 입력
2. 설정에서 프로필과 언어 선택
3. "Start Session" 클릭하여 시작
4. 단축키로 창 위치 이동
5. 화면과 면접관의 질문을 기반으로 AI가 실시간 지원 제공

## 키보드 단축키

- **창 이동**: `Ctrl/Cmd + 방향키` - 창 이동
- **클릭-스루**: `Ctrl/Cmd + M` - 마우스 이벤트 토글
- **닫기/뒤로**: `Ctrl/Cmd + \` - 창 닫기 또는 뒤로 가기
- **메시지 전송**: `Enter` - AI에게 텍스트 전송

## 오디오 캡처

- **macOS**: 시스템 오디오는 [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) 사용
- **Windows**: 루프백 오디오 캡처
- **Linux**: 마이크 입력

## 요구 사항

- Electron 호환 OS(macOS, Windows, Linux)
- Gemini API 키
- 화면 녹화 권한
- 마이크/오디오 권한

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---