# BeamerQt
BeamerQT는 슬라이드와 관련된 LaTeX 코드를 수동으로 편집하지 않고도 Beamer 프레젠테이션을 쉽게 만들 수 있도록 설계된 사용자 친화적인 그래픽 인터페이스입니다. 레이아웃 정의, 내용 삽입(텍스트, 블록, 이미지 포함), 그리고 테마의 일부 고급 설정 구성을 가능하게 하는 포괄적인 기능 세트를 제공합니다. BeamerQT는 초보자와 고급 LaTeX 사용자 모두가 놀라운 프레젠테이션을 만들고 코드가 아닌 내용에 집중할 수 있도록 합니다.

### 라이브러리 요구 사항:
* PyQt6

* PyMuPDF

<img src="https://github.com/user-attachments/assets/b123f050-dff5-4584-b40d-c2fd581c2f16" width="600">


# 기능
BeamerQT는 LaTeX 코드를 추가하지 않고도 가장 원하는 Beamer/LaTeX 기능에 쉽게 접근할 수 있는 그래픽 사용자 인터페이스를 제공합니다.

## 테마 편집기 (신규 기능!)
템플릿의 소스 코드를 편집합니다.

* 포함된 파일 첨부 지원.
* LaTeX 생성 시 첨부 파일 추출.
* 사용자 지정 .xml 파일 손쉬운 공유.
* 가까운 미래에 추가 기능 예정.

## 레이아웃 선택
BeamerQT는 PowerPoint나 LibreOffice Impress 같은 일반 프레젠테이션 도구에서 영감을 받은 다양한 사전 정의된 레이아웃 스킴을 제공합니다. 사용자는 열과 블록에 대한 LaTeX 코드를 수동으로 작성하는 대신 레이아웃을 선택하기만 하면 BeamerQT가 자동으로 필요한 Beamer 열과 블록을 삽입하고 관리합니다.

주요 기능은 다음과 같습니다:

* 선택한 레이아웃에 따른 열과 블록의 자동 생성.
* 수동 코드 편집 없이 슬라이더 조절로 열 너비 동적 조정.
* 최소한의 사용자 개입으로 슬라이드 레이아웃 원활한 재구성.

<img src="https://github.com/user-attachments/assets/1c313ed2-337c-4925-aaef-b18aa718bd0e" width="600">

<img src="https://github.com/user-attachments/assets/305af2c5-7726-43bd-b457-fe68d8ff3fd9" width="600">


## 슬라이드

각 슬라이드는 제목, 부제목, 그리고 내용용 블록 세트를 포함할 수 있습니다. 또한 슬라이드는 새 섹션 또는 하위 섹션으로 구성할 수 있어, 해당 섹션 또는 하위 섹션 제목이 자동으로 프레젠테이션에 삽입되도록 설정할 수 있습니다.

주요 기능: 

* 슬라이드 제목과 부제목의 간편한 입력. 
* 슬라이드를 섹션 또는 하위 섹션으로 표시하여 프레젠테이션 구조화. 
* 슬라이드 수준 서식 옵션의 자동 조정.

## 슬라이드 목록

슬라이드 목록은 전체 프레젠테이션의 개요를 제공하며, 각 슬라이드의 위치, 번호 및 제목을 표시합니다. 섹션과 하위 섹션이 명확하게 표시되어 탐색 및 구성에 도움을 줍니다. 사용자는 필요에 따라 슬라이드의 순서를 변경하거나, 복제, 복사 또는 삭제하여 효율적인 슬라이드 관리를 할 수 있습니다.

## 블록

블록은 BeamerQT에서 콘텐츠의 기본 단위입니다. 이 도구는 블록, 알림, 예제 또는 일반 텍스트 블록 등 다양한 블록 유형을 간단한 라디오 버튼 인터페이스를 통해 지원합니다. 이 방식은 LaTeX 명령어를 수동으로 작성할 필요를 없애줍니다.

블록의 핵심 기능은 다음과 같습니다: 

* 블록 유형 선택 (블록, 알림, 예제 또는 일반 텍스트). 
* 레이아웃 내 블록 재배치를 위한 위치 제어. 
* 슬라이드에서 블록을 제거하는 전용 버튼. 
* 각 블록에 대한 제목 필드와 다중 행 입력이 가능한 텍스트 입력 영역. 
* 사용자 입력에 따라 자동 줄 바꿈 또는 수동 줄 바꿈 유지.
* 다중 하위 블록
<img src="https://github.com/user-attachments/assets/5b914c96-e691-4fdf-af42-faba89b2c8f4" width="600">


## 하위 블록

하위 블록은 블록 내에서 더 세밀한 콘텐츠 구성을 가능하게 합니다. 각 블록은 최소 하나의 하위 블록(일반적으로 텍스트 기반)을 포함하며, 사용자는 필요에 따라 여러 개의 하위 블록을 추가할 수 있습니다.

하위 블록 기능: 

* 최대 4개 열로 배열 가능하며, 하위 블록을 재배치할 수 있는 수평 탐색 버튼 포함. 
* 열 너비를 조절할 수 있는 슬라이더로 유연한 레이아웃 커스터마이징 제공. 
* 각 하위 블록의 정렬 제어 (왼쪽, 가운데, 오른쪽 또는 기본).

## 이미지 하위 블록

이미지 하위 블록은 이미지를 삽입하기 위한 특수 하위 블록 유형입니다. BeamerQT는 비트맵 파일(.jpg, .png 등), 벡터 이미지(.svg), 그리고 .pdf 파일을 지원합니다. .svg 이미지의 경우 BeamerQT는 Inkscape를 사용하여 .pdf 형식으로 변환함으로써 최종 프레젠테이션에 원활하게 통합되도록 합니다 (테스트된 시스템은 Linux에 한함).

이미지 하위 블록 기능: 
* 서브 블록 너비의 백분율로 조정 가능한 이미지 크기.  
* 일관된 크기 조정을 위한 레이아웃 변경에 대한 자동 적응.  
* 다양한 이미지 형식과 호환되어 프레젠테이션 디자인의 유연성 보장.  

## 전면 설정

전면 설정 섹션은 프레젠테이션 전체 설정을 쉽게 구성할 수 있도록 합니다. 사용자는 프레젠테이션 제목, 작성자 이름을 정의하고 LaTeX 프리앰블을 사용자화할 수 있습니다. 또한 다음과 같은 전체적인 프레젠테이션의 모양과 구조를 더욱 세밀하게 조정할 수 있는 고급 기능도 활성화할 수 있습니다:  

* 가로 세로 비율 변경 (4:3에서 16:9로).  
* 각 섹션별 제목 프레임 생성.  
* 각 섹션에 대한 개요 프레임 자동 생성.  
<img src="https://github.com/user-attachments/assets/07629d96-ba38-4e5b-87ff-c1648598ad9f" width="600">  


<img src="https://github.com/user-attachments/assets/bb47ffe5-7d92-408e-a42d-1cd734f53d51" width="600">  

<img src="https://github.com/user-attachments/assets/9149eb46-020a-4f02-b3fe-9959fb231fd3" width="600">  


## LaTeX 생성

사용자가 내용과 레이아웃에 만족하면, **Generate LaTeX** 버튼을 클릭하여 프레젠테이션을 LaTeX 형식으로 내보내고 pdflatex를 실행하여 PDF를 컴파일합니다. 생성된 PDF는 즉시 표시되어 바로 검토할 수 있습니다.  

**LaTeX 폴더** 버튼은 출력 디렉터리를 열어 추가 사용자화나 다른 도구와의 통합을 가능하게 합니다. 각 LaTeX 생성 시 출력 폴더 내 파일이 덮어쓰기 됨을 유의하세요.  


## 파일 형식

BeamerQT는 .bqt 파일 형식을 사용하며, 이는 기본적으로 필요한 모든 메타데이터를 포함하는 압축된 디렉터리입니다. 예를 들면:  

* 프레젠테이션 세부 정보가 담긴 XML 파일.  
* 슬라이드 미리보기 이미지.  
* (미래 기능) 임베디드 이미지 및 사용자 정의 테마로 휴대성 보장.  

이 방식은 .bqt 파일을 쉽게 공유, 백업, 그리고 다양한 시스템에서 필수 데이터를 잃지 않고 편집할 수 있게 합니다.  


## 설치


* Windows

  MikTex 설치:
  
  https://miktex.org/download

  BeamerQT 설치:
  
  https://sourceforge.net/projects/beamerqt/

* Linux
  배포판에 따라 python3, TexLive, Inkscape를 설치하세요:
  

  Debian 기반:

  ```
  apt-get install python3 texlive-beamer inkscape 
  ```
  PyQt6 및 PyMuPDF 설치:
  ```
  pip install pyqt6 pymupdf
  ```
  

  BeamerQT 실행:

  이 저장소에서 BeamerQT의 소스 코드를 다운로드합니다.
  
  main.py 파일이 있는 디렉터리에서 터미널을 엽니다.
  ```
  python3 main.py
  ```
## 예제 비디오:

https://www.youtube.com/watch?v=XQKJbuT8q1g

## 스크린샷:
### BeamerQT GUI
<img src="https://github.com/user-attachments/assets/cf332d4e-9962-4251-9619-67e146af9851" width="600">

### PDF 출력
<img src="https://github.com/user-attachments/assets/be7b2e0c-20a4-41f0-b09d-93131973c4d4" width="600">


## 기부
이 소프트웨어 개발을 위해 기부해 주세요. 페이팔 기부 링크:

https://www.paypal.com/donate/?business=2PP5H8Z8L5E8E&no_recurring=0&item_name=Support+the+development+of+BeamerQT&currency_code=USD


## 공상과학 책
이것을 즐기셨다면, 제 공상과학 책인 Synapses: The Chaos of Order도 좋아하실 겁니다.

http://synapsesbook.wordpress.com/

Jorge Guerrero




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-22

---