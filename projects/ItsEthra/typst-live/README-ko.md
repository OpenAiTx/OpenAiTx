# Typst-live
이것은 [typst](https://github.com/typst/typst) 파일의 변경 사항을 감지하고 자동으로
다시 컴파일하여 실시간 피드백을 제공하는 간단한 유틸리티입니다. `typst-live`는 브라우저에서 typst로 생성된 pdf를 열고
소스 `.typ` 파일이 변경될 때마다 자동으로 새로 고침할 수 있게 해줍니다.

## `--watch` 플래그와의 차이점
`typst-live`는 웹서버를 호스팅하여 페이지를 자동으로 새로 고침하므로 `typst --watch`처럼 수동으로 다시 로드할 필요가 없습니다.

## 설치
[rust](https://www.rust-lang.org)이 설정되어 있다면 다음 명령어를 사용하세요:
```
cargo install typst-live
```
Nix를 사용하는 경우 다음 명령어로 GitHub 저장소에서 typst-live를 직접 실행할 수 있습니다:

```
nix run github:ItsEthra/typst-live
```

## 사용법
### 1. 자동 재컴파일 사용
* 터미널에서 `typst-live`를 실행하세요:
```
$ typst-live <file.typ>
Server is listening on http://127.0.0.1:5599/
```
* 브라우저에서 `http://127.0.0.1:5599/`로 이동하세요.  
* 이제 `file.typ`를 편집하면 브라우저 탭에서 변경 사항이 나타납니다.

### 2. 수동 재컴파일 사용  
`typst-live`를 사용하여 소스 파일을 재컴파일하지 않고 pdf 파일을 다시 로드할 수 있습니다.  
이를 위해 `--no-recompile` 옵션을 사용하여 재컴파일을 비활성화하고  
pdf 파일을 브라우저 탭에서 호스팅할 수 있으며, 소스 `.typ` 파일 대신 pdf `filename`을 지정해야 합니다.  
pdf 파일이 변경될 때마다 브라우저 탭이 새로 고쳐집니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-01

---