<translate-content># 《네가 놓친 그 컴퓨터 과목》 오픈소스 PDF 버전

> [!important]
> 《네가 놓친 그 컴퓨터 과목》 오픈소스 PDF 버전은 [웹버전](https://www.criwits.top/missing)에서 자동 생성된 것이 아니라 수작업으로 편집 제작되었습니다. 따라서 오픈소스 PDF 버전은 내용 면에서 웹버전보다 뒤처질 수 있으며 누락이나 오류가 있을 수 있습니다.

이것은 《네가 놓친 그 컴퓨터 과목》의 오픈소스 PDF 버전 LaTeX 소스 코드이며, 최신 발행 PDF는 TeX Live 2025로 조판되었습니다. PDF를 생성하려면 다음 단계를 따라주세요:

> [!warning]
> 반드시 로컬 TeX 환경에서 컴파일하세요. Overleaf 사용을 금합니다.

0. 다음 글꼴을 정확히 설치하세요(가변 글꼴 사용 금지), 그리고 XeLaTeX가 이 글꼴들을 찾을 수 있도록 하세요:
   1. [Inter](https://rsms.me/inter/)；
   2. [Source Han Sans(思源黑体)](https://github.com/adobe-fonts/source-han-sans/)（「Noto Sans SC」가 아니며 「思源黑体 CN」도 아님）；
   3. [Sarasa Gothic Slab SC(등거리 更纱黑体 Slab SC)](https://github.com/be5invis/Sarasa-Gothic)；
   4. [Noto Serif Tibetan](https://fonts.google.com/noto/specimen/Noto+Serif+Tibetan)。
1. 이 저장소를 원하는 위치에 클론하세요；
2. `resource/quote.zip` 안의 두 개의 문장 부호 매핑 파일을 **사용자 TEXMF 트리**의 `fonts/misc/xetex/fontmapping/xecjk` 디렉터리에 넣으세요；
3. TeX 배포판의 파일명 데이터베이스를 갱신하세요, TeX Live 사용자는 다음을 실행하세요</translate-content>
   ```shell
   mktexlsr
   ```
   MiKTeX 사용자 실행
   ```shell
   initexmf --update-fndb
   ```
4. 두 번 반복 실행하기
   ```shell
   xelatex --shell-escape -output-driver="xdvipdfmx -i dvipdfmx-unsafe.cfg -q -E" missing.tex
   ```
Windows 사용자는 `make.bat`를 직접 더블 클릭하여 PDF 파일을 생성할 수도 있습니다. 전체 빌드 스크립트는 약 4분 정도 걸립니다 ~~그 동안 노래를 들어도 좋습니다~~.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---