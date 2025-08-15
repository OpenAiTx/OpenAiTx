# NES 게임 분해

각 소스 코드는 원본 ROM과 동일하며, 컴파일 및 편집이 가능합니다.

모두 제 [BZK 6502 디스어셈블러](https://github.com/cyneprepou4uk/BZK-6502-Disassembler) 스크립트로 제작되었습니다.

문의는 [RHDN](https://www.romhacking.net/forum/index.php?topic=32220.0) 게시판에서 가능합니다.



## 분해 빌드 방법

### 윈도우

특별한 요구사항 없습니다. `assemble.bat` 파일을 실행하고 완료될 때까지 기다리면 됩니다.

### 기타 OS

터미널에서 `sh assemble.sh` 명령어를 사용해 보세요. 모든 공로는 [gb-2312](https://github.com/gb-2312)에게 있습니다.

`_scripts` 및 `_install_packages` 폴더는 어떻게 작동하는지 모르면 삭제하거나 수정하지 마세요.



## 문법 강조

[Notepad++](https://notepad-plus-plus.org/)에서 코드를 강조하려면 `syntax_6502.xml` 파일을 사용하세요.

Language -> User Defined Language -> Define your language -> Import 경로로 이동하세요.



## 분해 편집 방법

중요 주석은 `bzk` 텍스트로 표시됩니다. 공간 확보를 위해 불필요한 부분을 먼저 삭제하세요.

`C - - - - - 0x00009C 00:C08C: A9 00     LDA #$00` 같은 내용은 신경 쓰지 마세요.

`preparations.lua` 스크립트가 컴파일 전에 처리합니다. 평소처럼 `LDA #$00` 같은 새 코드를 작성하면 됩니다.

필요한 경우 `.\s.\s.\s.\s.\s.\s0x0........:....:\s..\s..\s..\s\s` 정규식으로 이 텍스트를 수동으로 삭제할 수 있습니다.



## 게임 목록 (GoodNES) + CRC32

### 분해된 게임
* 어드벤처 아일랜드 (U) [!] `B78C09A2`
* 배틀 시티 (J) [!] `F599A07E`
* 벅스 버니 크레이지 캐슬, 더 (U) [!] `DB0C3656`
* 캐슬배니아 III - 드라큘라의 저주 (U) [!] `7CC9C669`
* 콘트라 포스 (U) [!] `83D69922`
* 대니 설리반의 인디 히트 (U) [!] `311B5A58`
* 더블 드래곤 II - 복수 (J) `8CF69E4B`
* 닥터 마리오 (JU) (PRG0) [!] `B1F7E3E9`
* 엑사이트바이크 (JU) [!] `2BB33C69`
* 펠릭스 더 캣 (U) [!] `0639E88E`
* 아이스 클라이머 (J) [!] `80C41616`
* 쿠니오군의 열혈 축구 리그 (J) [!] `61C27F7B`
* 젤다의 전설, 더 (U) (PRG0) [!] `D7AE93DF`
* 인어공주, 더 (U) [!] `08EB97DB`
* 매피 (J) [!] `3F0E8E0A`
* 넛츠 & 밀크 (J) [!] `11879FE8`
* 팩맨 (J) (V1.1) [!] `D747B639`
* 로보캅 3 (U) [!] `FBBB58A6`
* 솔스티스 - 데모노스의 지팡이 탐색 (U) [!] `1D60732E`
* 손 손 (J) [!] `F7C8F42D`
* 스트리트 파이터 III (9 파이터) (Unl) `22CDD2F6`
* 슈퍼 C (U) [!] `1AC846F0`
* 테크모 월드컵 축구 (J) [!] `19F24980`
* 테니스 (JU) [!] `5F457C00`
* 예이 아 쿵푸 (J) (V1.4) [!] `0D526208`



### 작업 중
* 배틀토드 & 더블 드래곤 - 얼티밋 팀 (U) [!] `53B02F3D`
* 캡틴 아메리카와 어벤져스 (U) [!].nes `7254D53D`
* 갈라가 - 데몬즈 오브 데스 (U) [!] `E36D5991`
* 닌자 가이덴 III - 고대의 죽음의 배 (U) [!] `BABD39FA`
* R.C. Pro-Am II (U) [!] `03DB5562`
* River City Ransom (U) [!] `C3508F7E`
* Super Mario Bros. (W) [!] `3337EC46`
* Urban Champion (W) [!] `0770CDAA`



### 계획
* Balloon Fight (J) [!] `A0DABE0A`
* Bubble Bobble (U) [!] `D3A91B41`
* Ghosts 'N Goblins (U) [!] `87ED54AA`
* Kid Icarus (UE) [!] `0B30E036`
* Kinnikuman - Muscle Tag Match (J) (PRG0) [!] `C296C8CE`
* Mighty Final Fight (U) [!] `15EB0BEE`
* Mitsume ga Tooru (J) [!] `E27EC1EC`
* Popeye (JU) (PRG0) [!] `DE1D762F`
* Tetris (Tengen) [!] `88F071C3`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-15

---