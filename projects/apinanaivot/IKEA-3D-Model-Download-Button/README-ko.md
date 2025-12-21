# IKEA 3D 모델 다운로더

이 Tampermonkey 스크립트는 IKEA 제품 페이지에 3D 모델 다운로드 버튼을 추가하여 IKEA 가구 및 장식품의 .GLB 파일을 쉽게 저장할 수 있도록 합니다. IKEA 웹사이트의 다양한 언어 버전에서 작동하며, 다운로드된 파일 이름을 제품명과 색상에 따라 자동으로 지정합니다. 이 파일들은 Blender 같은 3D 소프트웨어에서 열 수 있습니다. 이를 통해 구매 결정을 내리기 전에 자신의 3D 홈 플래닝 소프트웨어에서 가구를 미리 배치해 볼 수 있습니다.

업데이트: 2025.11.28 - 최신 IKEA 웹사이트에서 작동

<p align="left">
  <img src="https://raw.githubusercontent.com/apinanaivot/IKEA-3D-Model-Download-Button/main/sample.jpg" width="550" title="IKEA 3D Model Downloader">
</p>

## 기능

- IKEA 제품 페이지의 "3D 보기" 버튼 옆에 "3D 다운로드" 버튼 추가
- IKEA 웹사이트의 모든 언어 버전에서 작동
- 다운로드된 파일명을 제품명과 색상을 사용해 자동으로 지정

## 설치 방법

1. 브라우저용 [Tampermonkey](https://www.tampermonkey.net/) 확장 프로그램을 설치합니다.
2. [이 링크](https://github.com/apinanaivot/IKEA-3D-Model-Download-Button/raw/refs/heads/main/ikea-3d-model-downloader.user.js)를 클릭하여 이 스크립트를 설치하거나 업데이트하거나, 또는 Tampermonkey에서 새 스크립트를 생성 후 `ikea-3d-model-downloader.user.js` 내용을 붙여넣기 합니다.
3. 스크립트를 저장하고 Tampermonkey에서 활성화되어 있는지 확인합니다.

## 사용 방법

1. "3D 보기" 버튼이 있는 IKEA 제품 페이지로 이동합니다.
2. "3D 보기" 버튼 옆에 새로 생긴 "3D 다운로드" 버튼이 보입니다.
3. "3D 다운로드" 버튼을 클릭하여 3D 모델의 GLB 파일을 다운로드합니다.
4. 파일은 `[제품명] - [색상].glb` 형식의 이름으로 저장됩니다.

## 문제 해결

- 다운로드 버튼이 보이지 않으면 3D 모델이 있는 제품 페이지인지 확인하고 페이지를 새로 고침하세요.
- 크롬을 사용하는 경우 개발자 모드를 켜 보세요.
- 그래도 해결되지 않으면 [버그 리포트 작성](https://github.com/apinanaivot/IKEA-3D-Model-Download-Button/issues) 부탁드리며 가능한 빨리 수정하겠습니다.

## 면책 조항

이 도구는 개인 홈 플래닝 및 시각화를 위해 설계되었습니다. 항상 IKEA의 서비스 약관을 준수하며 저장된 모델은 개인 홈 디자인 프로젝트에만 사용하세요. 저작자는 오용이나 약관 위반에 대한 책임을 지지 않습니다.

## 
<a href="https://www.star-history.com/#apinanaivot/IKEA-3D-Model-Download-Button&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=apinanaivot/IKEA-3D-Model-Download-Button&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=apinanaivot/IKEA-3D-Model-Download-Button&type=Date" />
   <img alt="스타 히스토리 차트" src="https://api.star-history.com/svg?repos=apinanaivot/IKEA-3D-Model-Download-Button&type=Date" />
 </picture>
</a>




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-21

---