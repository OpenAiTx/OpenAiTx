# Memvid - 영상 기반 AI 메모리 🧠📹

**AI 메모리를 대규모로 구현하는 경량 혁신 솔루션**

[![PyPI version](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Code style: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid는 텍스트 데이터를 비디오로 인코딩하여, **수백만 개의 텍스트 청크에 대한 번개같이 빠른 의미론적 검색**과 **1초 미만의 검색 시간**을 가능하게 하며 AI 메모리 관리 방식을 혁신합니다. 기존의 벡터 데이터베이스가 대량의 RAM과 저장 공간을 소모하는 것과 달리, Memvid는 지식 베이스를 컴팩트한 비디오 파일로 압축하면서도 언제든지 즉시 정보에 접근할 수 있습니다.

## 🎥 데모

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e

## ✨ 주요 기능

- 🎥 **비디오 기반 데이터베이스**: 수백만 개의 텍스트 청크를 하나의 MP4 파일에 저장
- 🔍 **의미론적 검색**: 자연어 쿼리를 통한 관련 콘텐츠 검색
- 💬 **내장 챗봇**: 문맥을 이해하는 대화형 인터페이스
- 📚 **PDF 지원**: PDF 문서의 직접 가져오기 및 인덱싱
- 🚀 **빠른 검색**: 대규모 데이터셋에서도 1초 미만의 검색 속도
- 💾 **효율적 저장**: 기존 데이터베이스 대비 10배 압축률
- 🔌 **플러그인 LLM 지원**: OpenAI, Anthropic 또는 로컬 모델과 연동
- 🌐 **오프라인 우선**: 비디오 생성 후 인터넷 불필요
- 🔧 **간단한 API**: 단 3줄 코드로 시작 가능

## 🎯 활용 사례

- **📖 디지털 라이브러리**: 수천 권의 책을 하나의 비디오 파일로 색인화
- **🎓 교육 자료**: 강의자료의 검색 가능한 비디오 메모리 생성
- **📰 뉴스 아카이브**: 수년치 기사를 관리 가능한 비디오 데이터베이스로 압축
- **💼 기업 지식 관리**: 회사 전체의 지식 베이스를 검색 가능하게 구축
- **🔬 연구 논문**: 과학 문헌에 대한 신속한 의미론적 검색
- **📝 개인 노트**: 개인 노트를 검색 가능한 AI 어시스턴트로 변환

## 🚀 왜 Memvid인가?

### 혁신적인 차별성
- **비디오 기반 데이터베이스**: 수백만 개 텍스트 청크를 하나의 MP4 파일에 저장
- **즉시 검색**: 대규모 데이터셋에서도 1초 미만의 의미론적 검색
- **10배 저장 효율**: 비디오 압축으로 메모리 사용량 획기적 절감
- **인프라 불필요**: 데이터베이스 서버 없이 파일만 복사하면 됨
- **오프라인 우선**: 비디오 생성 후 완전 오프라인 동작

### 경량 아키텍처
- **최소 의존성**: 핵심 기능이 약 1000줄의 Python 코드로 구현
- **CPU 친화적**: GPU 없이도 효율적으로 실행
- **휴대성**: 단일 비디오 파일에 전체 지식 베이스 저장
- **스트리밍 가능**: 클라우드 저장소에서 비디오 스트리밍 지원

## 📦 설치

### 빠른 설치
```bash
pip install memvid
```

### PDF 지원 설치
```bash
pip install memvid PyPDF2
```

### 권장 환경 (가상환경)
```bash
# 새 프로젝트 디렉터리 생성
mkdir my-memvid-project
cd my-memvid-project

# 가상환경 생성
python -m venv venv

# 활성화
# macOS/Linux:
source venv/bin/activate
# Windows:
venv\Scripts\activate

# memvid 설치
pip install memvid

# PDF 지원 추가:
pip install PyPDF2
```

## 🎯 빠른 시작

### 기본 사용법
```python
from memvid import MemvidEncoder, MemvidChat

# 텍스트 청크로 비디오 메모리 생성
chunks = ["중요 사실 1", "중요 사실 2", "역사적 사건 상세"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# 메모리와 대화
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("역사적 사건에 대해 무엇을 알고 있나요?")
print(response)
```

### 문서에서 메모리 구축
```python
from memvid import MemvidEncoder
import os

# 문서 로드
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# 텍스트 파일 추가
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# 최적화된 비디오 생성
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # FPS가 높을수록 초당 더 많은 청크 저장
    frame_size=512  # 프레임 크기가 클수록 프레임당 데이터 증가
)
```

### 고급 검색 및 검색
```python
from memvid import MemvidRetriever

# 리트리버 초기화
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# 의미론적 검색
results = retriever.search("머신러닝 알고리즘", top_k=5)
for chunk, score in results:
    print(f"Score: {score:.3f} | {chunk[:100]}...")

# 컨텍스트 윈도우 가져오기
context = retriever.get_context("신경망 설명", max_tokens=2000)
print(context)
```

### 인터랙티브 챗 인터페이스
```python
from memvid import MemvidInteractive

# 인터랙티브 챗 UI 실행
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # http://localhost:7860 웹 인터페이스 오픈
```

### file_chat.py로 테스트하기
`examples/file_chat.py` 스크립트는 본인 문서로 Memvid를 종합적으로 테스트할 수 있는 방법을 제공합니다:

```bash
# 문서 디렉토리 처리
python examples/file_chat.py --input-dir /path/to/documents --provider google

# 특정 파일 처리
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# H.265 압축 사용 (Docker 필요)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# 대용량 문서용 커스텀 청킹
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# 기존 메모리 로드
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### 전체 예제: PDF 책과 챗하기
```bash
# 1. 새 디렉터리 생성 및 환경 설정
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Windows: venv\Scripts\activate

# 2. 의존성 설치
pip install memvid PyPDF2

# 3. book_chat.py 생성
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# PDF 파일 지정
book_pdf = "book.pdf"  # PDF 경로로 교체

# 비디오 메모리 구축
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# 책과 대화
api_key = os.getenv("OPENAI_API_KEY")  # AI 응답을 위한 옵션
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. 실행하기
export OPENAI_API_KEY="your-api-key"  # 선택 사항
python book_chat.py
```

## 🛠️ 고급 설정

### 커스텀 임베딩
```python
from sentence_transformers import SentenceTransformer

# 커스텀 임베딩 모델 사용
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### 비디오 최적화
```python
# 최대 압축을 위해
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # 초당 프레임 수 증가
    frame_size=256,  # 더 작은 프레임
    video_codec='h265',  # 더 나은 압축
    crf=28  # 압축 품질 (낮을수록 더 좋은 품질)
)
```

### 분산 처리
```python
# 대용량 데이터셋 병렬 처리
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 문제 해결

### 일반적인 문제

**ModuleNotFoundError: No module named 'memvid'**
```bash
# 올바른 Python을 사용 중인지 확인
which python  # 가상환경 경로가 출력되어야 함
# 그렇지 않다면, 가상환경 활성화:
source venv/bin/activate  # Windows에서는: venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**LLM API 키 문제**
```bash
# API 키 설정 (https://platform.openai.com 에서 발급)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# 또는 Windows에서:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**대용량 PDF 처리**
```python
# 매우 큰 PDF의 경우 더 작은 청크 크기 사용
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 기여하기

기여를 환영합니다! 자세한 내용은 [기여 가이드](https://raw.githubusercontent.com/Olow304/memvid/main/CONTRIBUTING.md)를 참고해 주세요.

```bash
# 테스트 실행
pytest tests/

# 커버리지와 함께 실행
pytest --cov=memvid tests/

# 코드 포맷팅
black memvid/
```

## 🆚 기존 솔루션과의 비교

| 기능 | Memvid | 벡터 DB | 전통적 DB |
|------|--------|---------|-----------|
| 저장 효율성 | ⭐⭐⭐⭐⭐ | ⭐⭐ | ⭐⭐⭐ |
| 구축 복잡성 | 간단 | 복잡 | 복잡 |
| 의미 기반 검색 | ✅ | ✅ | ❌ |
| 오프라인 사용 | ✅ | ❌ | ✅ |
| 이식성 | 파일 기반 | 서버 기반 | 서버 기반 |
| 확장성 | 수백만 | 수백만 | 수십억 |
| 비용 | 무료 | $$$$ | $$$ |

## 📚 예제

[examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) 디렉터리에서 확인할 수 있습니다:
- 위키피디아 덤프에서 메모리 구축
- 개인 지식 베이스 생성
- 다국어 지원
- 실시간 메모리 업데이트
- 인기 LLM과의 통합

## 🆘 도움 받기

- 📖 [문서](https://github.com/olow304/memvid/wiki) - 종합 안내서
- 💬 [토론](https://github.com/olow304/memvid/discussions) - 질문하기
- 🐛 [이슈 트래커](https://github.com/olow304/memvid/issues) - 버그 신고
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - 프로젝트 공유

## 🔗 링크

- [GitHub 저장소](https://github.com/olow304/memvid)
- [PyPI 패키지](https://pypi.org/project/memvid)
- [Changelog](https://github.com/olow304/memvid/releases)

## 📄 라이선스

MIT 라이선스 - 자세한 내용은 [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) 파일을 참조하세요.

## 🙏 감사의 말

[Olow304](https://github.com/olow304) 및 Memvid 커뮤니티에 의해 제작되었습니다.

다음과 같은 오픈소스 도구로 만들어졌습니다:
- [sentence-transformers](https://www.sbert.net/) - 의미 기반 검색용 최신 임베딩
- [OpenCV](https://opencv.org/) - 컴퓨터 비전 및 비디오 처리
- [qrcode](https://github.com/lincolnloop/python-qrcode) - QR 코드 생성
- [FAISS](https://github.com/facebookresearch/faiss) - 효율적인 유사도 검색
- [PyPDF2](https://github.com/py-pdf/pypdf) - PDF 텍스트 추출

Memvid를 더 좋게 만들어 주신 모든 기여자분들께 특별히 감사드립니다!

---

**AI 메모리 관리의 혁신을 시작할 준비가 되셨나요? Memvid를 설치하고 바로 시작하세요!** 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---