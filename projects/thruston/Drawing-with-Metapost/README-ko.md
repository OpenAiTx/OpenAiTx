# Drawing-with-Metapost

Toby Thurston -- 2025년 1월 28일

이 프로젝트는 John Hobby의 Metapost 언어로 기술 도면을 그리는 방법에 대해 논의하는 문서를 제공합니다.  
200개 이상의 Metapost로 작성된 삽화가 포함되어 있으며, 영감과 예제로서 소스 코드도 함께 제공됩니다.  
대상 수준은 초보자보다는 중급자에서 고급 사용자입니다.  
Metapost에 대한 소개, 튜토리얼 및 기타 기사들은 http://www.tug.org/metapost.html 을 참조하세요.

최상위 디렉토리에서 `Drawing-with-Metapost.pdf`로 시작하세요.

`src` 디렉토리에는  
- 본 문서의 TeX 소스  
- Metapost 소스 코드를 마크업하는 데 사용된 스타일 파일  
- 본 문서에 사용된 각 삽화의 Metapost 소스  
- 각 MP 소스 파일로부터 생성된 해당 PDF 파일들  

텍스트에는 삽화를 그리는 데 사용된 기법에 대한 논의가 포함되어 있으며, 대부분의 삽화에 대해 완전하거나 부분적인 소스 코드 목록이 포함되어 있습니다.  
이 목록들은 사용된 소스 코드에서 직접 포함되었으므로, 모든 경우에 출력은 페이지에 보이는 것과 정확히 일치해야 합니다.

먼저 본 문서를 읽어보는 것이 좋지만, `src` 디렉토리의 PDF를 둘러보고 관심 있는 파일을 찾으면 해당 MP 소스 파일을 확인해보는 것도 좋습니다.  
PDF 이름과 MP 소스 이름은 일대일로 대응하므로, 예를 들어 `geometry-apollonius.pdf`는 `geometry-apollonius.mp`에서 생성됩니다.  
`src` 디렉토리에는 본 문서에 포함되지 않은 몇몇 도면도 있습니다.

오류를 발견하거나 개선 제안이 있으면 Github에서 이슈를 제기하거나 풀 리퀘스트를 제출해 주세요.

저작권 (c) 2025 Toby Thurston. 이 자료는 Open Publication License v1.0 이상에 명시된 조건에 따라 배포될 수 있습니다.  
최신 버전은 https://opencontent.org/openpub/ 에서 확인할 수 있습니다.

이 문서의 실질적으로 수정된 버전의 배포는 금지됩니다.










저작권자의 명시적 허가 없이.  
작품 또는 작품의 파생물을 표준(종이) 도서 형태로 배포하는 것은  
저작권자로부터 사전 허가를 받지 않는 한 금지됩니다.  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---