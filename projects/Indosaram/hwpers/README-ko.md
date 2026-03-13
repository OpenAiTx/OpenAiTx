# hwpers

[![Crates.io](https://img.shields.io/crates/v/hwpers.svg)](https://crates.io/crates/hwpers)
[![Documentation](https://docs.rs/hwpers/badge.svg)](https://docs.rs/hwpers)
[![CI](https://github.com/Indosaram/hwpers/workflows/CI/badge.svg)](https://github.com/Indosaram/hwpers/actions)
[![License](https://img.shields.io/badge/license-MIT%2FApache--2.0-blue.svg)](LICENSE-MIT)

전체 레이아웃 렌더링 지원을 갖춘 한국어 한글 워드 프로세서(HWP) 파일 파싱을 위한 Rust 라이브러리입니다.

## 기능

### 파서 (HWP 파일 읽기)
- **완전한 HWP 5.0 포맷 지원**: 텍스트, 서식, 표, 임베디드 객체 등 모든 문서 구성 요소 파싱
- **시각적 레이아웃 렌더링**: 레이아웃 데이터가 있을 경우 픽셀 단위 정확도로 문서 재구성
- **폰트 및 스타일 보존**: 원본 폰트, 크기, 색상 및 텍스트 서식 추출 및 적용
- **고급 레이아웃 엔진**: 다단 레이아웃, 행별 위치 지정, 문자 단위 서식 지원
- **SVG 내보내기**: 문서를 확장 가능한 벡터 그래픽으로 렌더링
- **제로 카피 파싱**: 최소한의 메모리 할당으로 효율적인 파싱
- **안전한 Rust**: 포괄적인 오류 처리와 메모리 안전 구현

### 작성기 (HWP 파일 생성) - v0.3.0 이상
- **문서 생성**: 완전한 HWP 문서 작성 지원
- **리치 텍스트 서식**: 굵게, 기울임, 색상, 폰트, 크기
- **표**: 생성, 스타일링, 셀 병합
- **목록**: 글머리 기호, 번호 매기기, 한글/알파벳/로마자 형식
- **이미지**: PNG/JPEG/BMP/GIF 및 캡션
- **텍스트 박스**: 위치 지정 및 스타일 텍스트 박스
- **하이퍼링크**: URL, 이메일, 파일, 북마크 링크
- **머리말/바닥말**: 페이지 번호 및 사용자 정의 내용
- **페이지 레이아웃**: 크기, 여백, 방향, 단, 배경

## 빠른 시작

`Cargo.toml`에 다음을 추가하세요:

```toml
[dependencies]
hwpers = "0.3"
```

### 기본 사용법

```rust
use hwpers::HwpReader;

// Parse an HWP file
let document = HwpReader::from_file("document.hwp")?;

// Extract text content
let text = document.extract_text();
println!("{}", text);

// Access document properties
if let Some(props) = document.get_properties() {
    println!("Pages: {}", props.total_page_count);
}

// Iterate through sections and paragraphs
for (i, section) in document.sections().enumerate() {
    println!("Section {}: {} paragraphs", i, section.paragraphs.len());
    
    for paragraph in &section.paragraphs {
        if let Some(text) = &paragraph.text {
            println!("  {}", text.content);
        }
    }
}
```

### 시각적 레이아웃 렌더링

```rust
use hwpers::{HwpReader, render::{HwpRenderer, RenderOptions}};

let document = HwpReader::from_file("document.hwp")?;

// Create renderer with custom options
let options = RenderOptions {
    dpi: 96,
    scale: 1.0,
    show_margins: false,
    show_baselines: false,
};

let renderer = HwpRenderer::new(&document, options);
let result = renderer.render();

// Export first page to SVG
if let Some(svg) = result.to_svg(0) {
    std::fs::write("page1.svg", svg)?;
}

println!("Rendered {} pages", result.pages.len());
```

### 문서 생성 (v0.3.0+)

```rust
use hwpers::writer::HwpWriter;
use hwpers::model::hyperlink::Hyperlink;

// Create a new document
let mut writer = HwpWriter::new();

// Add formatted text
writer.add_aligned_paragraph(
    "제목",
    hwpers::writer::style::ParagraphAlignment::Center
)?;

// Add hyperlinks
let link = Hyperlink::new_url("Rust", "https://rust-lang.org");
writer.add_paragraph_with_hyperlinks(
    "Visit Rust website",
    vec![link]
)?;

// Configure page layout
writer.set_custom_page_size(210.0, 297.0, // A4 size
    hwpers::model::page_layout::PageOrientation::Portrait)?;
writer.set_page_margins_mm(20.0, 20.0, 20.0, 20.0);

// Add header and footer
writer.add_header("Document Header");
writer.add_footer_with_page_number("Page ", 
    hwpers::model::header_footer::PageNumberFormat::Numeric);

// Save the document
writer.save_to_file("output.hwp")?;
```
### 고급 서식 접근 권한


```rust
// Access character and paragraph formatting
for section in document.sections() {
    for paragraph in &section.paragraphs {
        // Get paragraph formatting
        if let Some(para_shape) = document.get_para_shape(paragraph.para_shape_id as usize) {
            println!("Indent: {}, Alignment: {}", 
                para_shape.indent, 
                para_shape.get_alignment()
            );
        }
        
        // Get character formatting runs
        if let Some(char_shapes) = &paragraph.char_shapes {
            for pos_shape in &char_shapes.char_positions {
                if let Some(char_shape) = document.get_char_shape(pos_shape.char_shape_id as usize) {
                    println!("Position {}: Size {}, Bold: {}", 
                        pos_shape.position,
                        char_shape.base_size / 100,
                        char_shape.is_bold()
                    );
                }
            }
        }
    }
}
```
## 지원 기능

### 문서 구조
- ✅ 파일 헤더 및 버전 감지
- ✅ 문서 속성 및 메타데이터
- ✅ 섹션 정의 및 페이지 레이아웃
- ✅ 단락 및 문자 서식
- ✅ 글꼴 정의 (FaceName)
- ✅ 스타일 및 템플릿

### 콘텐츠 유형
- ✅ 전체 유니코드 지원 텍스트 콘텐츠
- ✅ 표 및 구조화된 데이터
- ✅ 컨트롤 객체 (이미지, OLE 객체)
- ✅ 번호 매기기 및 글머리 기호 목록
- ✅ 탭 정지 및 정렬

### 레이아웃 및 렌더링
- ✅ 페이지 크기 및 여백
- ✅ 다중 열 레이아웃
- ✅ 행별 위치 지정 (가능한 경우)
- ✅ 문자별 위치 지정 (가능한 경우)
- ✅ 테두리 및 채우기 패턴
- ✅ 정확한 위치 지정이 가능한 SVG 내보내기

### 고급 기능
- ✅ 압축 문서 지원
- ✅ CFB(복합 파일 바이너리) 형식 처리
- ✅ 다중 인코딩 지원 (UTF-16LE)
- ✅ 오류 복구 및 부분 파싱

## 명령줄 도구

라이브러리에는 HWP 파일을 검사하기 위한 명령줄 도구가 포함되어 있습니다:


```bash
# Install the tool
cargo install hwpers

# Inspect an HWP file
hwp_info document.hwp
```
## 형식 지원

이 라이브러리는 HWP 5.0 형식 파일을 지원합니다. 이전 HWP 형식의 경우, 먼저 형식 변환 도구 사용을 고려하세요.

## 작성기 기능 (v0.3.0+)

HWP 작성기 기능이 크게 개선되어 포괄적인 기능 지원을 제공합니다:

### ✅ 완전 구현
- **하이퍼링크**: 적절한 직렬화와 함께 완전한 하이퍼링크 지원
  - URL 링크, 이메일 링크, 파일 링크, 북마크
  - 단락당 여러 하이퍼링크
  - 사용자 지정 스타일 (색상, 밑줄, 방문 상태)
- **머리말/바닥글**: 완전한 머리말 및 바닥글 구현
  - 사용자 지정 머리말/바닥글 텍스트
  - 여러 형식의 페이지 번호 (숫자, 로마자 등)
  - 문서당 여러 머리말/바닥글
- **페이지 레이아웃**: 포괄적인 페이지 레이아웃 제어
  - 사용자 지정 페이지 크기 및 표준 크기 (A4, 레터 등)
  - 세로/가로 방향
  - 사용자 지정 여백 (좁게, 보통, 넓게, 사용자 지정)
  - 조정 가능한 간격의 다중 열 레이아웃
  - 페이지 배경 색상
- **표**: 완전한 표 생성 및 서식 지정
  - 셀 테두리 및 스타일링
  - 셀 병합 (가로 및 세로)
  - 사용자 지정 셀 내용
- **목록/번호 매기기**: 완전한 목록 지원
  - 수준별 다양한 기호의 글머리 기호 목록
  - 번호 매기기 목록 (1., 2., 3., ...)
  - 알파벳 목록 (a), b), c), ...)
  - 로마 숫자 목록 (i., ii., iii., ...)
  - 한글 목록 (가., 나., 다., ...)
  - 적절한 들여쓰기가 있는 중첩 목록
- **텍스트 상자**: 완전한 텍스트 상자 구현
  - 위치 지정된 텍스트 상자
  - 스타일된 텍스트 상자 (강조, 경고, 정보 등)
  - 사용자 지정 스타일 (테두리, 배경, 정렬)
  - 회전 및 투명도가 있는 플로팅 텍스트 상자

- **이미지**: 완전한 이미지 삽입
  - PNG, JPEG, BMP, GIF 지원
  - 사용자 지정 크기 및 위치 지정
  - 이미지 캡션
  - 적절한 BinData 통합
- **스타일 텍스트**: 리치 텍스트 서식 지정
  - 굵게, 기울임, 밑줄, 취소선
  - 사용자 지정 글꼴 및 크기
  - 텍스트 색상 및 배경 색상
  - 단일 단락 내 여러 스타일
- **고급 서식**:
  - 단락 정렬 (왼쪽, 가운데, 오른쪽, 양쪽 맞춤)
  - 줄 간격 조절
  - 단락 간격 (이전/이후)
  - 자동 크기 조절 머리글
  - 문자 및 단락 스타일
- **문서 속성**: 전체 메타데이터 지원
  - 제목, 저자, 주제, 키워드
  - 문서 통계 (문자 수, 단어 수 등)
  - 자동 통계 업데이트

### ❌ 아직 구현되지 않음
- **도형/그리기**: 기하학적 도형 및 그리기 객체
  - 사각형, 원, 타원
  - 선, 화살표, 다각형
  - 스타일이 적용된 사용자 지정 도형
  - 텍스트가 포함된 도형
  - 도형 그룹화
  - *(사용 예는 examples/shape_document.rs.disabled 참조)*
- **차트/그래프**: 데이터 시각화 객체
- **수학 방정식**: MathML 지원
- **폼**: 입력 필드 및 폼 컨트롤
- **주석/코멘트**: 검토 및 코멘트 기능
- **변경 내용 추적**: 수정 기록
- **메일 병합**: 변수 필드 삽입

### 🔧 알려진 문제
- 작성기에는 압축 지원 없음 (읽기기는 압축 및 비압축 모두 지원)
- 일부 고급 표 기능은 구버전 한워드와 호환성 문제 있을 수 있음

## 기여하기

기여는 언제나 환영합니다! 자유롭게 Pull Request를 제출해 주세요. 주요 변경 사항의 경우, 먼저 변경하고자 하는 내용을 논의하기 위해 이슈를 열어 주세요.

## 라이선스

이 프로젝트는 다음 중 하나의 라이선스 하에 있습니다.

- Apache License, Version 2.0, ([LICENSE-APACHE](LICENSE-APACHE) 또는 http://www.apache.org/licenses/LICENSE-2.0)
- MIT 라이선스 ([LICENSE-MIT](LICENSE-MIT) 또는 http://opensource.org/licenses/MIT)

선택에 따라 적용됩니다.

## 감사의 글

- 한컴 주식회사의 HWP 파일 형식 명세
- 한국어 텍스트 처리 커뮤니티
- Rust 파싱 및 문서 처리 생태계

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-13

---