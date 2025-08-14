# 간단한 Apple Health XML을 CSV로 변환

Apple Health의 export.xml 파일을 사용하기 쉬운 csv로 변환하는 간단한 스크립트입니다.



## 실행 방법 

### 1. 컴퓨터나 환경에 Python 3 및 Pandas가 설치되어 있는지 확인하세요

`python --version` 명령어는 _Python 3.x.x_ (x는 임의의 숫자)를 반환해야 합니다. 

Python 2.x.x가 설치되어 있다면, 여기에서 Python 3으로 업그레이드하세요: https://www.python.org/downloads/ (또는 환경의 Python 버전을 지정하세요)

`python3 -c "import pandas"` 명령어는 커맨드 라인에서 아무 출력 없이 종료되어야 합니다.

_**ModuleNotFoundError: No module named 'pandas'**_ 오류가 발생하면, pandas를 설치하고 다시 시도하세요:

`pip3 install pandas`


### 2. Apple Health 데이터 내보내기

| 건강 홈 | ➡️ | 데이터 내보내기 |
|--|--|--|
|<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/health_home.jpg" width=300>||<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/export_data_button.jpg" width = 300 >|

데이터가 준비되면 export.zip 파일을 컴퓨터로 전송할 수 있습니다.

### 3. 압축을 풀면 다음 파일들이 포함되어 있습니다:

   * apple_health_export
     * export.xml (변환하려는 데이터가 들어있는 파일입니다)
     
     * export_cda.xml
     
       

### 4. 이 저장소의 "apple_health_xml_convert.py" 파일을 해당 폴더에 위치시키고 스크립트를 실행하세요

`python3 apple_health_xml_convert.py`



내보내기는 다음 형식으로 작성됩니다:

* **apple_health_export_YYYY-MM-DD.csv**

  

Excel에서 출력은 다음과 같이 보일 것입니다:

<img style="float: left;" src="https://raw.githubusercontent.com/jameno/Simple-Apple-Health-XML-to-CSV/master/img/example_output.jpg">

참고: 이 스크립트는 가독성을 높이기 위해 Apple Health 데이터 접두사인 `HKQuantityTypeIdentifier`, `HKCategoryTypeIdentifier`, 그리고 `HKCharacteristicTypeIdentifier`를 제거합니다. CSV 출력에 접두사를 유지하려면 코드에서 해당 줄을 `#`으로 주석 처리하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-14

---