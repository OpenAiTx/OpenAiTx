# suppress-eslint-errors

![Release](https://github.com/amanda-mitchell/suppress-eslint-errors/workflows/Release/badge.svg)

새로운 eslint 규칙을 켜려다 기존 코드베이스에서 수백 또는 수천 개의 오류에 좌절한 적이 있나요?
저희도 그렇습니다.

때로는 특히 크고 오래된 코드베이스에서 기존(작동하는!) 코드를 모두 업데이트하는 데 좋은 비즈니스 이유가 없을 수 있습니다.
그럴 때를 위해 `suppress-eslint-errors`가 도와드립니다.

## 작동 방식

`suppress-eslint-errors`는 [jscodeshift](https://github.com/facebook/jscodeshift)를 위한 코드모드로, 기존 코드에 대해 eslint를 실행합니다.
eslint 오류를 찾을 때마다 작은 스니펫을 추가합니다:

```javascript
// TODO: Fix this the next time the file is edited.
// eslint-disable-next-line cool-new-rule
```
이렇게 하면 즉시 방대한 백로그를 처리하지 않고도 새 코드에서 규칙의 이점을 얻을 수 있습니다.

## 사용법

`suppress-eslint-errors`는 추가 설치 없이 직접 호출할 수 있도록 래퍼 스크립트와 함께 제공됩니다:


```bash
npx suppress-eslint-errors [jscodeshift options] PATH...
```
래퍼는 변환기와 전달된 다른 인수를 사용하여 `jscodeshift`를 호출합니다.  
로컬 디렉터리에 `.gitignore`가 감지되면, 이를 `--ignore-config`로 지정합니다.  

`suppress-eslint-errors`는 로컬에 설치된 `eslint` 복사본과 함께 사용해야 합니다.  
복사본을 찾지 못하면 조기 종료합니다.  

_참고:_ `jscodeshift`는 `.gitignore` 파일 처리와 관련하여 일부 버그가 있어 때때로 모든 파일을 무시하게 됩니다.  
이 도구가 `.gitignore`에 문제가 되는 패턴이 포함된 것을 감지하면 `--ignore-config` 옵션을 건너뜁니다.  

경우에 따라 이 코드모드가 생성한 코드는 부적절한 들여쓰기를 할 수 있습니다.  
커밋 전에 사용하는 코드 포맷팅 도구를 반드시 다시 실행하세요!  

## 옵션  

**--message**: eslint-disable-next-line 주석 위에 추가할 주석을 설정합니다.  

**--rules**: 비활성화할 ESLint 규칙 ID를 쉼표로 구분한 목록입니다. 지정하면 이 목록에 없는 규칙 위반은 그대로 둡니다.  

## 예시  

`index.js` 파일의 모든 오류를 사용자 정의 주석과 함께 억제:


```bash
npx suppress-eslint-errors ./index.js --message="TODO: Issue #123"
```

`src` 디렉토리 내 .ts 및 .tsx 파일에서 `eqeqeq` 및 `@typescript-eslint/no-explicit-any` 규칙 위반을 억제합니다:

```bash
npx suppress-eslint-errors ./src --extensions=ts,tsx --parser=tsx --rules=eqeqeq,@typescript-eslint/no-explicit-any
```

## 뉘앙스

도구 이름에서 알 수 있듯이, 이것은 eslint _오류_만 억제합니다.
억제하고 싶은 경고가 있다면 도구를 실행하기 전에 eslint 설정을 변경하여 경고를 오류로 바꾸거나 `--rules` 플래그를 사용해 규칙을 지정하세요.

## 완벽한가요?

절대 아닙니다. 겪는 모든 예외적인 경우에 대한 PR은 환영합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-21

---