<translate-content># FoundationChat

Apple의 Foundation Models 프레임워크로 구축된 SwiftUI 채팅 애플리케이션으로, 온디바이스 AI 기능과 지속적인 대화 저장을 보여줍니다.

![Preview](https://raw.githubusercontent.com/Dimillian/FoundationChat/main/Images/image.png)

## 요구 사항

- **iOS 26.0+** / iPadOS 26.0+ / macOS 26.0+ / visionOS 26.0+
- **Xcode 26.0+** (iOS 26 SDK 포함)
- Apple Intelligence를 지원하는 기기
- 설정에서 Apple Intelligence가 활성화되어야 함

## 특징

- ✅ **다중 대화**: 여러 채팅 대화 생성 및 관리
- ✅ **지속 저장소**: 대화 기록을 위한 SwiftData 통합
- ✅ **실시간 스트리밍**: 구조화된 출력과 라이브 스트리밍 응답
- ✅ **스마트 요약**: 자동 대화 요약 기능
- ✅ **도구 통합**: 메타데이터 추출과 함께 웹 페이지 분석
- ✅ **풍부한 메시지 표시**: 썸네일 및 설명이 포함된 첨부 파일 지원
- ✅ **가용성 확인**: Foundation Models의 적절한 가용성 처리
- ✅ **모던 SwiftUI**: 네비게이션 스택과 스와이프 액션을 갖춘 깔끔한 인터페이스
- ✅ **온디바이스 AI**: 인터넷 불필요, 완전한 프라이버시 보장
- ✅ **오류 처리**: UI 내에서 우아한 오류 표시

## 아키텍처

### 핵심 구성 요소

- **`ChatEngine`**: Foundation Models 세션 및 스트리밍 응답 관리
- **`Conversation`** & **`Message`**: 지속 저장을 위한 SwiftData 모델
- **`MessageGenerable`**: 웹 메타데이터와 함께 구조화된 AI 응답을 위한 @Generable 구조체
- **`ConversationsListView`**: 대화 관리용 메인 인터페이스
- **`ConversationDetailView`**: 스트리밍 메시지 지원 채팅 인터페이스
- **`WebAnalyserTool`**: 웹 페이지에서 구조화된 데이터 추출 도구

### 데이터 흐름

1. **대화 목록**: 마지막 메시지 타임스탬프 기준으로 정렬된 모든 대화 표시
2. **채팅 인터페이스**: SwiftData 지속성과 실시간 스트리밍
3. **메시지 스트리밍**: 구조화된 AI 응답을 위한 `@Generable` 사용
4. **자동 요약**: 각 교환 후 대화 요약 업데이트

## 시작하기

1. Xcode에서 `FoundationChat.xcodeproj` 열기
2. 개발 기기에 Apple Intelligence가 활성화되어 있는지 확인
3. 지원되는 기기에서 빌드 및 실행 (성능상 시뮬레이터 권장하지 않음)
4. "+" 버튼으로 새 대화 생성
5. 온디바이스 AI와 채팅 시작

## 주요 구현 세부 사항

### Foundation Models 통합</translate-content>
```swift
@Observable
class ChatEngine {
    private let model = SystemLanguageModel.default
    private let session: LanguageModelSession
    
    var isAvailable: Bool {
        switch model.availability {
        case .available: return true
        default: return false
        }
    }
}
```
### 구조화된 스트리밍 응답

```swift
func respondTo() async -> LanguageModelSession.ResponseStream<MessageGenerable>? {
    session.streamResponse(generating: MessageGenerable.self) {
        // Conversation context with full history
    }
}
```
### 도구 통합

```swift
struct WebAnalyserTool: Tool {
    let name = "WebAnalyser"
    let description = "Analyse a website and return structured content"
    
    func call(arguments: Arguments) async throws -> ToolOutput {
        // Extracts title, thumbnail, and description
    }
}
```
### SwiftData 지속성

```swift
@Model
class Conversation {
    @Relationship(deleteRule: .cascade)
    var messages: [Message]
    var summary: String?
}
```
<translate-content>
## 문서

- **[CLAUDE.md](https://raw.githubusercontent.com/Dimillian/FoundationChat/main/CLAUDE.md)** - 개발 지침 및 프레임워크 개요
- **[Examples](EXAMPLES/)** - 포괄적인 구현 예제:
  - 기본 사용법
  - 구조화된 출력
  - 스트리밍 응답
  - 도구 호출
  - 성능 및 안전성
  - 완전한 채팅 앱

## 프로젝트 구조
</translate-content>
```
FoundationChat/
├── Models/
│   ├── SwiftData/          # Data persistence models
│   └── Generable/          # Foundation Models structures
├── Views/
│   ├── ConversationsList/  # Main conversation list
│   └── ConversationDetail/ # Chat interface with message views
├── Tools/
│   └── WebAnalyserTool.swift # Web content extraction tool
├── Env/
│   └── ChatEngine.swift    # Foundation Models integration
└── FoundationChatApp.swift # App entry point
```
<translate-content>
## 기여하기

이 프로젝트는 Apple의 Foundation Models 프레임워크를 시연하는 데모 프로젝트입니다. 자유롭게:
- 포크하여 다양한 AI 프롬프트를 실험해 보세요
- 추가 Foundation Models 기능을 확장하세요
- 새로운 UI 구성 요소와 상호작용을 추가하세요
- 개선 사항과 버그 수정을 기여하세요

## 라이선스

MIT 라이선스 - 자세한 내용은 LICENSE 파일을 참조하세요</translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---