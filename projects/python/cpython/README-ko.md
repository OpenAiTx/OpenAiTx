이것은 Python 버전 3.15.0 알파 0입니다
=====================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: GitHub Actions에서의 CPython 빌드 상태
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: Azure DevOps에서의 CPython 빌드 상태
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Python Discourse 채팅
   :target: https://discuss.python.org/


저작권 © 2001 Python Software Foundation.  모든 권리 보유.

추가적인 저작권 및 라이선스 정보는 이 파일의 끝을 참조하십시오.

.. contents::

일반 정보
-------------------

- 웹사이트: https://www.python.org
- 소스 코드: https://github.com/python/cpython
- 이슈 트래커: https://github.com/python/cpython/issues
- 문서: https://docs.python.org
- 개발자 가이드: https://devguide.python.org/

CPython에 기여하기
-----------------------

CPython 개발에 기여하는 보다 완전한 안내는
`개발자 가이드`_를 참조하십시오.

.. _개발자 가이드: https://devguide.python.org/

Python 사용하기
------------

설치 가능한 Python 키트와 Python 사용에 관한 정보는
`python.org`_에서 확인할 수 있습니다.

.. _python.org: https://www.python.org/

빌드 안내
------------------

Unix, Linux, BSD, macOS, Cygwin에서::

    ./configure
    make
    make test
    sudo make install

이렇게 하면 Python이 ``python3``로 설치됩니다.

configure 스크립트에 다양한 옵션을 전달할 수 있습니다; ``./configure --help``를 실행하여 더 많은 정보를 확인하십시오.  macOS의 대소문자 구분 없는 파일 시스템과 Cygwin에서는 실행 파일이 ``python.exe``로 불리며, 그 외에는 단순히 ``python``입니다.

완전한 Python 설치를 빌드하려면 빌드 플랫폼과 configure 옵션에 따라 다양한 추가 서드파티 라이브러리의 사용이 필요합니다. 모든 표준 라이브러리 모듈이 모든 플랫폼에서 빌드되거나 사용 가능한 것은 아닙니다.  다양한 Linux 배포판 및 macOS의 의존성에 대한 최신 자세한 정보는 `개발자 가이드`_의 `Install dependencies <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_ 섹션을 참조하십시오.

macOS에서는 macOS 프레임워크 및 유니버설 빌드와 관련된 추가적인 configure 및 빌드 옵션이 있습니다.  자세한 내용은 `Mac/README.rst <https://raw.githubusercontent.com/python/cpython/main/Mac/README.rst>`_를 참조하십시오.

Windows에서는 `PCbuild/readme.txt <https://raw.githubusercontent.com/python/cpython/main/PCbuild/readme.txt>`_를 참조하십시오.

Windows 설치 관리자를 빌드하려면 `Tools/msi/README.txt <https://raw.githubusercontent.com/python/cpython/main/Tools/msi/README.txt>`_를 참조하십시오.

원한다면 하위 디렉터리를 만들고 그곳에서 configure를 실행할 수 있습니다.
예시::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

(이 작업은 *최상위* 디렉터리에서도 빌드했다면 실패할 수 있습니다. 먼저 최상위에서 ``make clean``을 해야 합니다.)

Python의 최적화 빌드를 얻으려면 ``make``를 실행하기 전에 ``configure --enable-optimizations``를 사용하십시오.  이는 기본 make 타겟을 Profile Guided Optimization(PGO)을 활성화하도록 설정하며, 일부 플랫폼에서는 Link Time Optimization(LTO)을 자동 활성화할 수도 있습니다. 자세한 내용은 아래 섹션을 참조하십시오.

프로파일 기반 최적화
^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO는 최신 버전의 GCC 또는 Clang 컴파일러를 활용합니다. 사용 시,
``configure --enable-optimizations``를 통해서나, configure 플래그와 무관하게 ``make profile-opt``를 수동으로 실행함으로써 최적화된 빌드 프로세스가 다음 단계를 수행합니다:

이전 컴파일에서 생성된 임시 파일을 포함하여 Python 디렉터리 전체가 정리됩니다.

각 환경에 맞는 컴파일러 플래그를 사용해 계측된(interstrumented) 인터프리터 버전을 빌드합니다. 이 단계는 중간 단계일 뿐입니다.  이 단계에서 생성된 바이너리는 실제 워크로드에 적합하지 않으며 프로파일링 명령이 내장되어 있습니다.

계측된 인터프리터가 빌드된 후, Makefile은 트레이닝 워크로드를 실행합니다.  이는 인터프리터의 실행을 프로파일링하기 위해 필요합니다. 이 단계에서 나타날 수 있는 모든 출력(stdout 및 stderr)은 억제됩니다.

마지막 단계는 계측된 인터프리터에서 수집한 정보를 사용하여 실제 인터프리터를 빌드하는 것입니다.  최종 결과물은 최적화된 Python 바이너리가 되며, 배포나 운영 환경 설치에 적합합니다.


링크 시간 최적화
^^^^^^^^^^^^^^^^^^^^^^

configure의 ``--with-lto`` 플래그를 통해 활성화됩니다.  LTO는 최근의 컴파일러 도구 체인이 최종 실행 파일이나 공유 라이브러리 빌드 시 기존의 ``.o`` 파일 경계를 넘어 성능을 향상시키기 위해 최적화할 수 있는 기능을 활용합니다.


새로운 기능
----------

`What's new in Python 3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_ 문서에서 변경 사항의 종합적인 개요를 확인할 수 있습니다.  더 자세한 변경 로그는 `Misc/NEWS <https://raw.githubusercontent.com/python/cpython/main/Misc/NEWS.d>`_에서 읽을 수 있지만, 모든 변경 내역을 완전히 파악하려면 `커밋 히스토리 <https://github.com/python/cpython/commits/main>`_를 확인해야 합니다.

여러 버전의 Python을 설치하려면 아래 "여러 버전 설치하기" 섹션을 참조하십시오.


문서
-------------

`Python 3.15 문서 <https://docs.python.org/3.15/>`_는 온라인에서 확인할 수 있으며, 매일 업데이트됩니다.

더 빠른 접근을 위해 다양한 형식으로 다운로드할 수도 있습니다.  문서는 HTML, PDF, reStructuredText 형식으로 다운로드할 수 있습니다. reStructuredText 버전은 주로 문서 저자, 번역가 및 특별한 형식 요구가 있는 사람들을 위한 것입니다.

Python 문서 빌드에 대한 정보는 `Doc/README.rst <https://raw.githubusercontent.com/python/cpython/main/Doc/README.rst>`_를 참조하십시오.


테스트
-------

인터프리터를 테스트하려면 최상위 디렉터리에서 ``make test``를 입력하십시오.  테스트 세트는 일부 출력을 생성합니다.  불러올 수 없는 선택적 기능 때문에 발생하는 스킵된 테스트 메시지는 일반적으로 무시해도 됩니다.  실패한 테스트, 트레이스백 또는 코어 덤프가 출력되면 문제가 있는 것입니다.

기본적으로 테스트는 디스크 공간 및 메모리와 같은 리소스를 과도하게 사용하는 것을 방지합니다.  이러한 테스트를 활성화하려면 ``make buildbottest``를 실행하십시오.

테스트가 실패하면, 실패한 테스트를 자세히(Verbose) 모드로 다시 실행할 수 있습니다. 예를 들어 ``test_os``와 ``test_gdb``가 실패했다면 다음과 같이 실행할 수 있습니다::

    make test TESTOPTS="-v test_os test_gdb"

실패가 계속되고 Python 자체의 문제로 보인다면, `버그 리포트 제출 <https://github.com/python/cpython/issues>`_를 하고 문제를 보여주는 관련 명령어 출력을 첨부하십시오.

테스트 실행 및 작성에 대한 더 많은 정보는 `Running & Writing Tests <https://devguide.python.org/testing/run-write-tests.html>`_를 참조하십시오.

여러 버전 설치하기
----------------------------

Unix 및 Mac 시스템에서 동일한 설치 프리픽스(``--prefix`` 인자)로 여러 버전의 Python을 설치하려는 경우, 주 Python 실행 파일이 다른 버전 설치로 인해 덮어써지지 않도록 주의해야 합니다.  ``make altinstall``로 설치되는 모든 파일과 디렉터리는 주요 및 부 버전 정보를 포함하고 있으므로 나란히 존재할 수 있습니다.  ``make install``은 ``${prefix}/bin/python3``도 생성하며, 이는 ``${prefix}/bin/python3.X``를 참조합니다.  동일한 프리픽스로 여러 버전을 설치하려면 어떤 버전을(있다면) "주" 버전으로 할지 결정해야 합니다.  해당 버전을 사용하여 설치하십시오.
``make install``. 다른 모든 버전은 ``make altinstall``을 사용하여 설치하십시오.

예를 들어, Python 2.7, 3.6, 그리고 3.15를 설치하고 3.15를 기본 버전으로 설정하려면, 3.15 빌드 디렉터리에서 ``make install``을 실행하고, 다른 버전에서는 ``make altinstall``을 실행하면 됩니다.


릴리스 일정
-----------

Python 3.15 릴리스에 대한 자세한 내용은 `PEP 790 <https://peps.python.org/pep-0790/>`__를 참조하십시오.


저작권 및 라이선스 정보
-----------------------

Copyright © 2001 Python Software Foundation. 모든 권리 보유.

Copyright © 2000 BeOpen.com. 모든 권리 보유.

Copyright © 1995-2001 Corporation for National Research Initiatives. 모든 권리 보유.

Copyright © 1991-1995 Stichting Mathematisch Centrum. 모든 권리 보유.

이 소프트웨어의 이력, 사용 조건, 그리고 모든 보증의 부인에 대한 정보는 `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_를 참조하십시오.

이 Python 배포판에는 *GNU 일반 공중 사용 허가서(GPL)* 코드가 *포함되어 있지 않으므로*, 독점 프로젝트에서도 사용할 수 있습니다. 일부 GNU 코드에 대한 인터페이스가 있지만, 이는 전적으로 선택 사항입니다.

여기에서 언급된 모든 상표는 각 소유자의 자산입니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---