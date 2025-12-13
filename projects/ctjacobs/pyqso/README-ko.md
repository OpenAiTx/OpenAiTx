    Copyright (C) 2013-2018 Christian Thomas Jacobs.

    이 파일은 PyQSO의 일부입니다.

    PyQSO는 자유 소프트웨어입니다: GNU 일반 공중 사용 허가서에 명시된 조건에 따라
    자유 소프트웨어 재단이 발표한 라이선스 버전 3 또는
    (선택에 따라) 이후 버전으로 재배포 및/또는 수정할 수 있습니다.

    PyQSO는 유용하게 사용되기를 바라며 배포되지만,
    상업성이나 특정 목적 적합성에 대한 묵시적 보증 없이 제공됩니다.
    자세한 내용은 GNU 일반 공중 사용 허가서를 참조하십시오.

    PyQSO와 함께 GNU 일반 공중 사용 허가서 사본을 받았어야 합니다.
    받지 못했다면 <http://www.gnu.org/licenses/>를 참조하십시오.

# PyQSO

PyQSO는 아마추어 무선 운영자를 위한 교신 기록 도구입니다.

[![Documentation Status](https://readthedocs.org/projects/pyqso/badge/?version=latest)](https://readthedocs.org/projects/pyqso/?badge=latest)

## 의존성

이름에서 알 수 있듯이, PyQSO는 주로 [Python](https://www.python.org/) 프로그래밍 언어(버전 3.x)로 작성되었습니다. 그래픽 사용자 인터페이스는 [PyGObject 바인딩](https://pygobject.readthedocs.io)을 통해 [GTK+ 라이브러리](https://www.gtk.org/)를 사용하여 개발되었습니다. 따라서 PyQSO를 실행하려면 시스템에 Python 인터프리터와 GTK+ 지원이 설치되어 있어야 합니다. 많은 리눅스 기반 시스템에서는 다음 데비안 패키지를 설치하여 이를 달성할 수 있습니다:

* python3
* gir1.2-gtk-3.0
* python3-gi-cairo

PyQSO의 모든 기능을 활성화하려면 여러 추가 패키지가 필요합니다. 이들 중 다수는 `requirements.txt` 파일에 명시되어 있으며, 다음 터미널 명령어를 사용하여 시스템 전역에 쉽게 설치할 수 있습니다:

    sudo pip3 install -U -r requirements.txt

하지만 전체 목록은 아래와 같습니다:

* python3-matplotlib (버전 1.3.0 이상)
* python3-numpy
* libxcb-render0-dev


* [cartopy](http://scitools.org.uk/cartopy/), 세계 지도를 그리기 위한 패키지입니다. 이 패키지는 python3-scipy, python3-cairocffi, cython, libproj-dev(버전 4.9.0 이상), libgeos-dev(버전 3.3.3 이상)에 의존합니다.  
* [geocoder](https://pypi.python.org/pypi/geocoder), QTH 조회용입니다.  
* python3-sphinx, 문서 빌드용입니다.  
* python3-hamlib, Hamlib 지원용입니다.  

### Hamlib 지원  

현재 Python 3과 호환되는 Debian용 [Hamlib](http://www.hamlib.org) 패키지가 존재하지 않습니다. Hamlib 지원을 위해서는 이 라이브러리를 수동으로 빌드해야 합니다. [Hamlib 메일링 리스트](https://sourceforge.net/p/hamlib/mailman/message/35692744/)의 지침에 따라 Hamlib 루트 디렉터리에서 다음 명령어를 실행하십시오(사전에 `sudo apt-get install build-essential autoconf automake libtool` 명령어를 실행해야 할 수도 있습니다):  

    export PYTHON=/usr/bin/python3  
    autoreconf --install  
    ./configure --with-python-binding  
    make  
    sudo make install  

또한 Hamlib `bindings` 및 `bindings/.libs` 디렉터리를 `PYTHONPATH`에 추가해야 합니다:  

    export PYTHONPATH=$PYTHONPATH:/path/to/hamlib/bindings:/path/to/hamlib/bindings/.libs  

## 설치 및 실행  

현재 작업 디렉터리가 PyQSO의 기본 디렉터리(`Makefile`이 있는 디렉터리)라고 가정하면, 터미널에서 다음 명령어로 PyQSO를 설치 없이 실행할 수 있습니다:  

    python3 bin/pyqso  

시스템에 Python 패키지 관리자 `pip3`가 설치되어 있다면 다음 명령어로 PyQSO를 시스템 전체에 설치할 수 있습니다:  

    sudo make install  

설치 후에는 다음 명령어로 PyQSO를 실행할 수 있습니다:  

    pyqso  

## 문서  

PyQSO 사용법에 대한 안내는 [Read the Docs](http://pyqso.readthedocs.io/)에서 확인할 수 있으며, 아래 스크린캐스트도 참고하십시오.  

[![PyQSO: 아마추어 무선 사용자를 위한 로깅 도구](https://img.youtube.com/vi/sVdZl9KnDsk/0.jpg)](https://www.youtube.com/watch?v=sVdZl9KnDsk)  

문서는 다음 명령어로 로컬에서 빌드할 수도 있습니다:
    make docs

이 명령은 `docs/build/html`에 문서의 HTML 버전을 생성하며, 웹 브라우저에서 열 수 있습니다.

## 연락처

PyQSO에 관한 기술 문제나 기능 제안은 GitHub 이슈 트래커에 올려주시기 바랍니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-13

---