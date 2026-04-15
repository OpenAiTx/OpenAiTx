ZenCad
======
정의로운 젠 프로그래머를 위한 CAD 시스템  

무엇인가?
-----------
ZenCad - openscad의 스크립트 스타일로 기하학 코어를 사용하는 시스템입니다.
즉, openscad 아이디어, 파이썬 언어, 그리고 opencascade의 강력함이 하나로 합쳐진 것입니다.  

매뉴얼 및 정보
----------------------
- 매뉴얼: [여기](https://mirmik.github.io/zencad/).

- 기사:  
	- habr: [스크립트 3D 모델링 시스템 ZenCad](https://habr.com/ru/post/443140/)

- 커뮤니티 채팅 (텔레그램): [https://t.me/zencad](https://t.me/zencad)

설치
------------
### xcb 설치
```
apt install libxcb*
```
### 공통:
Zencad는 *pythonocc*와 *opencascade core*(OCCT)가 필요합니다. 첫 실행 후
(`zencad` 또는 `python3 -m zencad` 명령어 입력)
라이브러리 설치 유틸리티가 시작됩니다. 이 유틸리티를 사용하여 *pythonocc*와 *OCCT*를 설치할 수 있습니다. 또한 라이브러리를 수동으로 설치할 수도 있습니다.

```
apt install qt5-default
python3 -m pip install zencad[gui]
zencad 
# On first launch, Zenсad will ask you to download the required libraries. 
# After completing the necessary operations, close the installation utility and run the program again. 
zencad
```

### 그래픽 부분 없는 설치:
gui 부분 없이 라이브러리로 zencad 설치:
```python3 -m pip install zencad```
```python3 -m zencad --install-occt-force```  
```python3 -m zencad --install-pythonocc-force```

### Windows용:  
Windows 버전의 ZenCad는 `vcredist`(Microsoft 재배포 패키지)가 필요합니다.  
Python3.7용으로 `vcredist 2015`를, Python3.8 이상용으로는 `vcredist 2019`를 설치해 주세요.

독립 실행형 배포
-----------------------
ZenCad는 Windows용 독립 실행형 버전을 제공합니다.  
Windows 프리릴리스 버전은 [릴리스](https://github.com/mirmik/zencad/releases)에서 확인할 수 있습니다.

소스 코드
---------------
메인 프로젝트 저장소:  
	[https://github.com/mirmik/zencad](https://github.com/mirmik/zencad)  
관련 저장소:  
	[https://github.com/mirmik/zenframe](https://github.com/mirmik/zenframe)  
	[https://github.com/mirmik/evalcache](https://github.com/mirmik/evalcache)  

HelloWorld
----------
```python
#!/usr/bin/env python3
#coding: utf-8

from zencad import *

model = box(200, center = True) - sphere(120) + sphere(60)

display(m)
show()
```
Result:  
![result.png](https://mirmik.github.io/zencad/images/generic/zencad-logo.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-15

---