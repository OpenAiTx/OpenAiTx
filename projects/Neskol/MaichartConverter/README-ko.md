# MaichartConverter

## Simai와 Ma2 간의 maimai 차트를 변환하는 기능을 제공하는 간단한 프로그램입니다.

> 원본 지원 클래스들은 현재 이 저장소에서 분리되어 있습니다. 자세한 정보는
> [MaiLib](https://github.com/Neskol/MaiLib)를 참고하세요.

### 빌드

    git clone
    git submodule update --init --recursive
    dotnet build

### 사용법 및 사용 가능한 명령어

> 각 명령어에 대한 자세한 설명은 'MaichartConverter help'를 입력하세요.

- `CompileDatabase`([영문](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileDatabase.md)/[중문](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileDatabase_CN.md)): 전체 ma2 데이터베이스를 simai로 구성
- `CompileMa2`([영문](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileMa2.md)/[중문](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileMa2_CN.md)): 지정된 Ma2 차트를 지정된 형식으로 컴파일
- `CompileMa2ID`([영문](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileMa2ID.md)/[중문](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileMa2ID_CN.md)): ID로 인덱싱된 지정된 Ma2 차트를 지정된 형식으로 컴파일
- `CompileSimai`([영문](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileSimai.md)/[중문](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileSimai_CN.md)): 지정된 simai 차트를 지정된 형식으로 컴파일
-
`ReverseMa2FromSimaiDatabase`([영문](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/ReverseMa2FromSimaiDatabase.md)/[중문](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/ReverseMa2FromSimaiDatabase_CN.md)):
지정된 폴더에서 Simai 데이터베이스를 역변환하여 MaiAnalysis 폴더로 컴파일

### 파라미터 주의사항

- 음악 파일은 각 a000 폴더 내 music.xml에 명시된 음악 ID와 일치하는 musicxxxxxx.mp3 형식이어야 하며, ID는 6자리로 앞에 0을 채워야 합니다.
- bga 파일은 각 a000 폴더 내 music.xml에 명시된 음악 ID와 일치하는 xxxxxx.mp4 형식이어야 하며, ID는 6자리로 앞에 0을 채워야 합니다.
- 이미지 폴더는 image/Texture2D/ 구조를 가져야 하며, 파일명은 각 a000 폴더 내 music.xml에 명시된 음악 ID와 일치하는 UI_Jacket_xxxxxx.jpg 형식이어야 하며, ID는 6자리로 앞에 0을 채워야 합니다.
- 위에서 명시한 모든 규칙은 데이터를 적절한 경로에서 직접 사용할 때의 편의를 위한 것입니다.
- 난이도 파라미터는 Basic에서 Re:Master까지 0-4로 나열되어 있습니다. MaiLib에서는 Easy와 Utage에 대한 규칙도 지정했으나, 이는








  이해하는 데 시간이 걸리거나 MaiLib 코드를 참고하여 직접 구현할 수도 있습니다.
- 모든 경로는 "/" 또는 "\"와 같은 경로 구분자로 끝나야 합니다. 경로에 따옴표를 포함할 수 없습니다.
- 명령어 사용에 어려움이 있다면, 여러 예제가 포함된 VSCode launch.json을 참조하세요.
- 전체 프로그램은 처음에 ma2에서 simai로 변환하기 위해 계획되었고, 이후에 다른 기능들이 개발되었기 때문에
  코드 설계에 많은 타협이 있어 읽기 어려울 수 있지만(지금까지는 작동함), 
  수정하는 데 도움을 주신다면 매우 감사하겠습니다.

### 면책 조항

- 저작권은 각 권리자에게 있으며, 이 도구는 순수하게 비상업적이고 학습 목적으로 사용됩니다.
  사용되는 모든 자원에 대해서는 사용자가 직접 확인하고 책임을 지고 적절히 사용해야 합니다.
- 파서를 프로젝트에 사용하고자 한다면 [MaiLib](https://github.com/Neskol/MaiLib)를 참고하시기 바랍니다.
  도움이 되길 바랍니다!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---