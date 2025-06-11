# Visage: UI 라이브러리와 크리에이티브 코딩의 만남

**Visage**는 GPU 가속, 크로스 플랫폼 C++ 라이브러리로, 네이티브 UI와 2D 그래픽을 지원합니다. UI 프레임워크의 구조와 크리에이티브 그래픽 라이브러리의 기능을 결합했습니다.

## 전체 기본 예제
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // 800 x 600 픽셀 창으로 열기
  app.runEventLoop(); // 창 이벤트 실행. 창이 닫히면 반환.
  return 0;
}
```

## 데모
- [Showcase](https://visage.dev/examples/Showcase/)
- [Blend Modes](https://visage.dev/examples/BlendModes/)
- [Bloom](https://visage.dev/examples/Bloom/)
- [Gradients](https://visage.dev/examples/Gradients/)
- [Post Shader Effects](https://visage.dev/examples/PostEffects/)
- [Live Shader Editing](https://visage.dev/examples/LiveShaderEditing/)
- [Layout Flexing](https://visage.dev/examples/Layout/)

## UI 기능

- **이벤트 표준화**  
&nbsp;&nbsp;&nbsp;키보드 및 마우스 입력 표준화를 위한 크로스 플랫폼 지원.

- **창 표준화**  
&nbsp;&nbsp;&nbsp;창 열기 및 처리에 대한 크로스 플랫폼 지원.

- **텍스트 입력**  
&nbsp;&nbsp;&nbsp;유니코드 텍스트 입력 및 멀티라인 텍스트 편집 지원.

- **✨ 이모지 ✨**  
&nbsp;&nbsp;&nbsp;이런 거 좋아한다면 🤷

- **부분 렌더링**  
&nbsp;&nbsp;&nbsp;최적의 성능을 위한 더티 영역만 다시 그리기.

## 그래픽 기능

- **부드러운 움직임**  
&nbsp;&nbsp;&nbsp;모니터 주사율에 맞춰 새 프레임 표시, 애니메이션이 부드럽게 동작.

- **자동 도형 배칭**  
&nbsp;&nbsp;&nbsp;효율적인 GPU 렌더링을 위한 도형 자동 그룹화.

- **블렌드 모드**  
&nbsp;&nbsp;&nbsp;UI 통과용 커스텀 마스크를 그리거나 덧셈, 뺄셈 방식으로 레이어 블렌딩 지원.

- **쉐이더**  
&nbsp;&nbsp;&nbsp;한 번 작성한 쉐이더를 Direct3D, Metal, OpenGL용으로 트랜스파일.

- **포함된 이펙트**  
&nbsp;&nbsp;&nbsp;대형 블러 및 블룸 같은 실시간 이펙트 제공.

- **픽셀 정확도**  
&nbsp;&nbsp;&nbsp;디바이스 픽셀 크기 접근으로 블러 현상 없는 정밀 렌더링 보장.

## 지원 플랫폼
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---