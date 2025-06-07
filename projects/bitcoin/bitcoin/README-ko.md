Bitcoin Core 통합/스테이징 트리
=================================

https://bitcoincore.org

즉시 사용 가능한 바이너리 버전의 Bitcoin Core 소프트웨어는  
https://bitcoincore.org/en/download/ 을 참조하세요.

Bitcoin Core란 무엇인가?
------------------------

Bitcoin Core는 비트코인 P2P 네트워크에 연결하여 블록과 트랜잭션을 다운로드하고  
완전히 검증합니다. 또한 옵션으로 빌드할 수 있는 지갑 및 그래픽 사용자 인터페이스(GUI)도 포함되어 있습니다.

Bitcoin Core에 대한 추가 정보는 [doc 폴더](/doc)에서 확인할 수 있습니다.

라이선스
-------

Bitcoin Core는 MIT 라이선스 조건에 따라 배포됩니다. 자세한 정보는 [COPYING](COPYING) 또는  
https://opensource.org/license/MIT 를 참조하세요.

개발 프로세스
-------------

`master` 브랜치는 정기적으로 빌드(빌드 방법은 `doc/build-*.md` 참고) 및 테스트되지만  
완전히 안정적임을 보장하지는 않습니다. [태그](https://github.com/bitcoin/bitcoin/tags)는  
공식적이고 안정적인 새로운 릴리스 버전을 표시하기 위해 릴리스 브랜치에서 정기적으로 생성됩니다.

https://github.com/bitcoin-core/gui 저장소는 GUI 개발에만 사용됩니다.  
그 마스터 브랜치는 모든 모노트리 저장소에서 동일합니다. 릴리스 브랜치와 태그는 존재하지 않으니,  
개발 목적이 아니라면 해당 저장소를 포크하지 마세요.

기여 워크플로우는 [CONTRIBUTING.md](CONTRIBUTING.md)에서 설명되어 있으며,  
개발자를 위한 유용한 힌트는 [doc/developer-notes.md](doc/developer-notes.md)에서 확인할 수 있습니다.

테스트
------

테스트 및 코드 리뷰는 개발의 병목입니다. 저희는 단기간에 검토하고 테스트할 수 있는 것보다  
더 많은 풀 리퀘스트를 받고 있습니다. 인내심을 갖고 다른 사람의 풀 리퀘스트를 테스트하는 데 도움을 주시기 바라며,  
이 프로젝트는 보안에 매우 중요한 프로젝트이므로 실수 하나가 많은 사람들에게  
큰 금전적 손실을 야기할 수 있음을 명심해 주십시오.

### 자동화 테스트

개발자는 새로운 코드에 대해 [단위 테스트](src/test/README.md) 작성을 적극 권장하며,  
기존 코드에 대한 새로운 단위 테스트도 제출해 주시기 바랍니다.  
단위 테스트는(빌드 시스템 생성 시 비활성화되지 않았다면) `ctest`로 컴파일 및 실행할 수 있습니다.  
단위 테스트 실행 및 확장에 대한 자세한 내용은 [/src/test/README.md](/src/test/README.md)에서 확인할 수 있습니다.

또한 파이썬으로 작성된 [회귀 및 통합 테스트](/test)도 있습니다.  
이 테스트는 [테스트 의존성](/test)이 설치된 경우 `build/test/functional/test_runner.py`로  
(여기서 `build`는 빌드 디렉터리임) 실행할 수 있습니다.

CI(지속적 통합) 시스템은 모든 풀 리퀘스트가 Windows, Linux, macOS에서 빌드되도록 하고,  
단위/정합성 테스트가 자동으로 실행되도록 보장합니다.

### 수동 품질 보증(QA) 테스트

변경 사항은 해당 코드를 작성한 개발자가 아닌 다른 사람이 테스트해야 합니다.  
이는 특히 크거나 위험도가 높은 변경의 경우 매우 중요합니다.  
변경 사항 테스트가 간단하지 않은 경우 풀 리퀘스트 설명에 테스트 계획을 추가하는 것이 유용합니다.

번역
----

번역의 변경 사항이나 새로운 번역은  
[Bitcoin Core의 Transifex 페이지](https://www.transifex.com/bitcoin/bitcoin/)에 제출할 수 있습니다.

번역본은 주기적으로 Transifex에서 가져와 Git 저장소에 병합됩니다.  
작동 방식에 대한 자세한 내용은 [번역 프로세스](doc/translation_process.md)를 참조하세요.

**중요**: 번역 변경 사항은 GitHub 풀 리퀘스트로 받지 않습니다.  
다음 Transifex에서의 가져오기 시 자동으로 덮어써지기 때문입니다.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---