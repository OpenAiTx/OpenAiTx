# 인터넷에서 책 표지를 가져오는 API입니다.

이것은 Goodreads에서 책 표지 이미지를 가져오는 간단한 API입니다. 책의 제목과 저자 또는 ISBN 번호를 사용하여 표지를 검색할 수 있습니다. 애플리케이션에서 사용할 수 있는 표지 이미지의 직접 URL을 반환합니다.

## 문서

### GET /bookcover

책 제목과 저자 이름을 사용하여 책 표지를 검색합니다.

**필수 매개변수:**
- `book_title` (문자열): 책 제목
- `author_name` (문자열): 책 저자 이름

**요청 예시:**
```bash
curl -X GET "https://bookcover.longitood.com/bookcover?book_title=The+Pale+Blue+Dot&author_name=Carl+Sagan"
```
**예시 응답:**

```json
{
  "url": "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1388620656i/55030.jpg"
}
```
### GET /bookcover/:isbn

ISBN-13 번호를 사용하여 책 표지를 검색합니다.

**예제 요청:**

```bash
curl -X GET "https://bookcover.longitood.com/bookcover/978-0345376596"
```
**예시 응답:**

```json
{
  "url": "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1500191671i/61663.jpg"
}
```
## 작동 원리

이 API는 Goodreads에서 책 표지 이미지를 두 가지 방법으로 가져옵니다:

1. **제목 및 저자명으로 검색**
   - 책 제목과 저자명을 입력받음
   - Goodreads에서 검색하여 일치하는 책을 찾음
   - 고화질 표지 이미지 URL을 추출함
   - 빠른 요청을 위해 결과를 캐시함

2. **ISBN-13으로 검색**
   - 13자리 ISBN 번호를 받음
   - Goodreads에서 직접 조회 수행
   - 책 표지 URL을 반환함
   - 성공한 결과도 캐시함


API는 명확한 오류 메시지를 JSON 형식으로 제공합니다:
- 400 잘못된 요청: 누락된 매개변수 또는 잘못된 ISBN
- 404 찾을 수 없음: 일치하는 책 표지가 없음
- 모든 응답에 적절한 CORS 헤더 포함



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-19

---