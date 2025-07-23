<translate-content># 클래스 인포머
원본 classinformer를 사용하세요 (아래 URL 참조).  
https://github.com/kweatherman/IDA_ClassInformer_PlugIn

원저자 Kevin Weatherman, 별명 "Sirmabus"가 위 URL에서 IDA 9용 플러그인을 공개했습니다.
따라서 이 저장소의 목적은 이제 종료되었습니다!
이 저장소를 아카이브할 때입니다.
---------------------------------

IDA Pro 9 및 8용 IDA Class Informer 플러그인입니다. 이는 [원본 classinformer](https://sourceforge.net/projects/classinformer/)를 IDA 8 및 9에서 작동하도록 포팅한 버전입니다. 따라서 적극적인 개발은 하지 않을 것입니다. 개선을 원하시면 PR을 보내주세요. 개선 요청을 위한 이슈는 열지 마십시오.

 - 이 플러그인은 IDA Pro `9.1`, `9.0 SP1`, `9.0`, `8.4 SP2`, `8.2 SP1` 및 `8.0`의 32비트 및 64비트 버전에서 테스트되었습니다.
   - ***중요!!!*** IDA Pro 9.0 ***베타***는 지원되지 않습니다. 정식 버전을 사용하세요.
   - IDA Pro 7.x는 이 플러그인을 로드할 수 없습니다. [원본 플러그인](https://sourceforge.net/projects/classinformer/)을 사용하세요.
 - **이 플러그인은 Windows용 x86, x64, ARM, ARM64 PE 포맷 바이너리에서 MSVC++의 RTTI 파싱만 지원합니다.** GCC의 RTTI 및 기타 아키텍처는 지원하지 않습니다.
 - IDA 9용은 `ClassInformer64.dll`만 설치하면 됩니다.
 - IDA 8용은 `ClassInformer_IDA8x64.dll`와 `ClassInformer_IDA8x.dll` 두 개를 모두 설치해야 합니다.
 - 만약 IDA 8과 9가 모두 설치되어 있다면, 버전에 맞게 각각 IDA 디렉터리에 복사하거나 모든 dll을 `%IDAUSR%\plugins`에 복사하세요.
   - IDAUSR가 무엇인지 모른다면 [이 블로그 글](https://hex-rays.com/blog/igors-tip-of-the-week-33-idas-user-directory-idausr)을 참고하세요.

## 다운로드
- 컴파일된 바이너리는 [Releases](../../releases) 섹션에서 다운로드할 수 있습니다.
</translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---