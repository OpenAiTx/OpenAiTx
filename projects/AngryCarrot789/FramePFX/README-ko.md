# FramePFX

FramePFX는 C#으로 작성되었으며 UI에 Avalonia를 사용한 오픈 소스 비선형 비디오 편집기입니다.

## 리메이크
현재 완전한 리메이크 작업을 진행 중입니다 (remake 브랜치). 주요 차이점은 새로운 오디오 엔진, 비디오가 아닌 오디오 기반 재생, 그리고 프레임이 아닌 TimeSpan 기반 위치 지정입니다.

# 문서

프론트엔드와 백엔드에 대해 더 알고 싶다면 아래 문서 파일 링크를 참조하세요

[플러그인 시스템 + FramePFX API](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Plugins.md)

[자동화/애니메이션 시스템](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Automation.md)

[명령어 시스템, 컨텍스트 메뉴 시스템, 단축키](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Command%20System%20and%20Shortcuts.md)

[렌더링 시스템](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Rendering.md)

[단축키 시스템 개요](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Shortcuts.md)

[UI 개요](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/TheUI.md)

# 미리보기

다음은 Avalonia를 사용한 최신 버전입니다:
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-06_17.33.20.png)

다음은 내보내기 과정의 미리보기입니다. 내보내기 버튼은 파일>내보내기에 있으며, 경로를 지정한 후 내보내기를 클릭합니다.
렌더링을 취소하려면 내보내기 진행 창 뒤의 대화상자에서 취소를 클릭하면 됩니다.

"Exporter: FFmpeg" 아래의 회색 패널은 인코더별 세부 정보입니다
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-07_00.13.06.png)

## 사용자 정의 가능한 GUI!
테마는 사용자의 취향에 맞게 사용자 정의할 수 있습니다. 디스크에 저장하고 앱 내에서 수정할 수 있습니다. 내장된 
테마(Dark와 Light)는 변경 사항이 저장되지 않으므로 수정하지 않는 것이 좋습니다. 대신 복사본을 만들어 수정하세요.
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-29_08.30.49.png)

# 빌드하기
FramePFX는 모든 것이 64비트라고 가정합니다 --- x86/32비트/AnyCPU는 제대로 작동하지 않습니다!

네이티브 프로젝트는 C# 프로젝트를 처음 빌드할 때 자동으로 다운로드되고 컴파일되지만, 
미디어 클립과 내보내기를 사용하려면 FFmpeg를 별도로 다운로드해야 합니다. 
현재 작동하는 특정 버전(윈도우 전용)은 다음과 같습니다:
https://github.com/BtbN/FFmpeg-Builds/releases/download/autobuild-2024-09-30-15-36/ffmpeg-N-117275-g04182b5549-win64-gpl-shared.zip

## 다운로드
프로젝트를 재귀적으로 클론하세요:

`git clone --recursive https://github.com/AngryCarrot789/FramePFX`

비디오 미디어 클립과 FFmpeg 내보내기를 사용하려면 FFmpeg를 설치하세요:
- 솔루션 내에 ffmpeg 폴더 생성: `cd FramePFX && mkdir ffmpeg`
- 다운로드한 ffmpeg 압축 파일에서 4개의 디렉터리와 LICENCE.txt를 새로 만든 ffmpeg 폴더에 복사하세요

>`\FramePFX\ffmpeg\bin`에는 8개의 DLL 파일이 있어야 하며, 그 중 하나는 avcodec-61.dll이어야 합니다. 61이 아니면 잘못된 FFmpeg 버전을 사용한 것입니다.
사용하지 않는 EXE 파일은 삭제해도 됩니다.

## 프로젝트 빌드
- FramePFX.sln을 엽니다. `portaudio` 프로젝트가 로드되지 않았다는 오류가 발생할 수 있습니다; 무시하고, `Build` 메뉴에서 `Build Solution`을 클릭하여 솔루션을 빌드하세요.

이후 FramePFX 프로젝트를 문제 없이 실행하고 수정할 수 있을 것입니다. 이 프로젝트는 Avalonia 11.2.2와 .NET 8 (C# 12)을 사용합니다.

>`portaudio` 프로젝트는 cmake에 의해 자동 생성되므로 수정하지 마세요. 변경 사항이 덮어써질 수 있습니다.

### 윈도우 전용 명령어

솔루션 내 프로젝트들은 mkdir, xcopy 같은 윈도우 명령어를 사용하므로 다른 플랫폼에서는 작동하지 않을 수 있습니다.
더 크로스 플랫폼적인 해결책에 대해 풀 리퀘스트를 자유롭게 제출하세요!

### 빌드 문제 가능성
가끔 SkiaSharp nuget 라이브러리가 이 저장소를 클론하고 빌드할 때 skia 라이브러리 파일을 bin 폴더로 복사하지 않는 문제가 있습니다. 제가 찾은 두 가지 해결책은:
- `\packages\SkiaSharp.2.88.7\runtimes\win-x64\native\libSkiaSharp.dll` 파일을 편집기 bin 폴더로 복사하세요.
- 또는 솔루션 디렉터리에서 `packages` 폴더를 삭제한 후, 비주얼 스튜디오에서 솔루션을 우클릭하여 "Clean Solution"을 실행하고, Nuget 패키지 복원을 클릭한 다음 전체를 다시 빌드하세요.
  이 방법들이 모두 안 되면 nuget 관리자에서 SkiaSharp를 제거 후 재설치해 보세요. 그래도 안 되면 정말 무슨 문제가 있는지 모르겠습니다...

# 플러그인!
FramePFX는 이제 플러그인을 지원합니다! 플러그인 API는 아직 진행 중이지만 플러그인을 로드할 수 있습니다.
현재 플러그인은 FramePFX가 사용하는 동일한 종속성 버전으로 컴파일되어야 합니다. AssemblyLoadContext를 사용하지 않기 때문입니다.
여기에서 더 많은 정보를 찾을 수 있습니다: [플러그인 시스템 + FramePFX API](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Plugins.md) 

### 예제
`AnotherTestPlugin` 플러그인은 테스트 설정 페이지(`파일 > 편집기 설정 열기`에서 찾을 수 있음)를 추가하며, 내보내기 대화 상자에 쓸모없는 테스트 내보내기기도 추가합니다.

페이지를 추가하는 것은 매우 간단하며, 플러그인의 `OnApplicationLoaded` 핸들러에서 수행할 수 있습니다:


```cs
public override async Task OnApplicationLoaded() {
    ApplicationConfigurationManager.Instance.RootEntry.AddEntry(new ConfigurationEntry() {
        DisplayName = "Test Plugin Settings", 
        Id = "config.testplugineditorsettings",
        
        // This page is just a PropertyEditor page. 
        // Completely custom xaml pages are a bit wonky at the moment, 
        // only user controls will work properly due to resource dictionaries
        Page = new TestPluginConfigurationPage()
    });
}
```
이 결과는 다음과 같습니다:  
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-27_03.33.53.png)  
  
# TODO  
### Avalonia 리메이크:  
- 클립/트랙에 드롭할 수 있는 효과 목록 UI 구현  
### 렌더링 엔진  
- port-audio에 접근할 수 있긴 하지만, 전체 렌더링 엔진을 전면 재구성해야 할 것 같습니다.  
  이전에는 프로젝트 프레임 속도에 따라 클립에서 정확한 바이트 수를 추출하여 오디오를 렌더링했습니다.  
  하지만 이는 재생 FPS가 정확하지 않아 많은 잡음이 발생합니다.  
  
  비디오 렌더링도 다시 해야 합니다. 뷰포트는 보통 꽤 작지만, 각 클립의 풀사이즈 비디오 프레임을 렌더링한 후 축소하기 때문입니다.  
  직사각형이나 기본 도형에는 그리 나쁘지 않습니다.  
  하지만 MP4 파일에서 4K 비디오 프레임을 렌더링한 후 1080p(또는 클립의 MediaScale)로 축소하고  
  마지막으로 뷰포트(보통 약 500x300 크기)로 축소하는 것은 엄청나게 비효율적입니다. 따라서 RenderFull과  
  RenderPreview 메서드를 별도로 두거나 새로운 렌더링 시스템이 필요합니다. 현재의 비동기 렌더링 방식은 나쁘지 않은 것 같습니다.  
### 자동화 엔진  
- 부드러운 보간 지원 추가(예: 두 키 프레임 사이의 곡선). 시도는 해봤지만 수학적으로 보간을 구현하는 것과 UI의 히트 테스트를  
  처리하는 데 어려움을 겪었습니다.  
### 클립  
- AVMediaVideoClip은 고해상도 비디오에 매우 느립니다(예: 4K는 디코딩 및 화면 출력에 약 40ms 소요).  
  그리고 몇 가지 비디오 코덱만 제대로 작동하는 것 같습니다. 많은 일반적인 파일 형식은 "디코딩 중 잘못된 데이터 발견" 오류를 발생시킵니다.  
  FFmpeg에 대해 잘 알지는 못하지만 언젠가는 이 문제를 해결하고 싶습니다.  
- 두 클립 사이 페이딩 구현  
### 히스토리 시스템  
- 아직 실행 취소 기능이 없습니다. 오디오나 하드웨어 가속 최종 프레임 조립 기능 같은 다른 기능들을 구현한 후 시도해볼 예정입니다.  
### 수정할 버그  
- 특정 비디오 파일을 가져올 때 렌더링이 실패하는 문제("디코딩 중 잘못된 데이터 발견" 오류)  
### 멀티스레드 동기화  
- 애플리케이션 상태에 대한 접근 및 수정을 더 안전하게 하기 위해 락을 만들어야 합니다. 특히 활동 시스템이 동작 중이므로 더욱 필요합니다.  
  
  모델 상태에 쓰기 작업을 위한 애플리케이션 전체 락 같은 게 필요할까요? IntelliJ IDEA 방식과 비슷하게, 주로 읽기용이고 읽기-쓰기 락이 있습니다.  
  쓰기 락은 메인 스레드에서만 획득 가능하며(디스패처를 통해 접근), 모든 스레드는 읽기 락을 얻을 수 있습니다.  
  읽기 락을 얻으려면 쓰기 작업이 없을 때까지 대기해야 하고, 쓰기 락을 얻으려면 모든 읽기 작업이 끝날 때까지 대기해야 합니다.  
  또한 쓰기 락 획득 시 이벤트가 발생해 읽기 작업을 취소하여 UI 정지를 방지합니다.  
  
## 기여하기  
기여는 언제나 환영합니다! 그냥 풀 리퀘스트를 만들거나, 이슈 후 PR도 좋습니다.  
앱을 컴파일하고 실행/디버깅하는 방법은 위로 조금 스크롤하면 정보를 찾을 수 있습니다.  
TODO 목록은 위에 있지만, 코드베이스에서 `// TODO:`를 검색해도 됩니다.

자세한 설명은 docs 폴더에서 확인할 수 있으며, 편집기의 핵심 부분(명령어, 자동화 등)을 설명합니다.  
아직 문서화할 내용이 많아 모든 내용을 다루고 있지는 않습니다.  

코드 베이스가 완벽하지 않으니, 표준화 작업에 기여해 주셔도 좋습니다!  

# 라이선스  
FramePFX의 모든 소스 파일은 GNU 일반 공중 사용 허가서 버전 3.0 이상(GPL v3.0+)에 따라 배포됩니다.  
FramePFX는 MIT/LGPL 라이선스 등 다른 라이선스를 가진 라이브러리를 사용합니다.  

저작권 고지가 누락된 소스 파일은 FramePFX와 동일한 라이선스 하에 있다고 간주합니다.  

현재 사용 중인 LGPL 부분은 다음과 같습니다:  
- FFmpeg.AutoGen, GNU 약소 일반 공중 사용 허가서 버전 3.0(LGPL v3.0) 하에 라이선스됨  
- FFmpeg  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---