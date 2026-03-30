![image](https://user-images.githubusercontent.com/693717/210183526-1708c821-172e-4c71-9b02-2a9885654505.svg)

# QuickLook.Plugin.WebViewPlus

[QuickLook](https://github.com/QL-Win/QuickLook) 플러그인으로 [WebViewPlus](https://github.com/mooflu/WebViewPlus)를 사용하여 다양한 파일 형식을 미리 볼 수 있습니다.

## 사용해보기

1. [릴리스 페이지](https://github.com/mooflu/QuickLook.Plugin.WebViewPlus/releases)로 이동하여 최신 버전을 다운로드하세요.
2. QuickLook이 백그라운드에서 실행 중인지 확인하세요. 다운로드 폴더로 가서 다운로드한 `.qlplugin` 파일에서 <key>Spacebar</key> 키를 누르세요.
3. 팝업 창에서 “설치” 버튼을 클릭하세요.
4. QuickLook을 재시작하세요.
5. WebViewPlus를 통해 미리 볼 파일 유형을 구성하려면, html 파일을 열고 오른쪽 아래의 톱니바퀴 버튼을 클릭하세요.

## 개발

 1. 이 프로젝트를 클론하세요. 서브모듈 업데이트를 잊지 마세요.
 2. WebViewPlus 웹 앱을 `webApp`으로 복사하거나 플러그인 설정 `WebAppUrl`을 설정하세요 - `WebpagePanel.cs` 참조
 3. `Debug` 구성에서 `Output path`를 `..\QuickLook.upstream\Build\Debug\QuickLook.Plugin\QuickLook.Plugin.WebViewPlus\` 같은 경로로 설정하세요.
 4. `Debug` 프로필로 플러그인 프로젝트를 빌드하세요.
 5. `Debug` 프로필로 상위 QuickLook을 빌드하고 실행하세요.

 # 릴리스
 1. `Release` 프로필로 프로젝트를 빌드하세요.
 2. `Scripts\pack-zip.ps1`을 실행하세요.
 3. 프로젝트 디렉터리에서 `QuickLook.Plugin.WebViewPlus.qlplugin` 파일을 찾을 수 있습니다.

## 라이선스

MIT 라이선스.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---