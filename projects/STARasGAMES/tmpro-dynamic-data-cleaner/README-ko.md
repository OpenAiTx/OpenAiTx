## 소개
TextMeshPro 동적 폰트 에셋은 동적으로 생성된 이진 데이터를 구성 데이터와 동일한 텍스트 파일에 저장하는 매우 성가신 습관이 있습니다.  
이는 버전 관리에 큰 골칫거리를 야기합니다.

이 패키지의 스크립트는 위 문제를 해결합니다. 프로젝트 내 어떤 에셋이 저장되려 할 때마다 실행됩니다.  
그 중 TMP 동적 폰트 에셋이 있다면, 저장 전에 동적으로 생성된 데이터가 삭제되어  
버전 관리에 데이터가 오염되는 것을 방지합니다.

이 훌륭한 해결책을 제시한 @cxode에게 크레딧을 드립니다:<br>
`https://forum.unity.com/threads/tmpro-dynamic-font-asset-constantly-changes-in-source-control.1227831/#post-8934711`

저의 기여는 이 스크립트를 쉽게 설치할 수 있는 upm 호환 패키지로 만든 것입니다.<br>
성능 개선과 엣지 케이스에 대한 추가 검사도 포함되었습니다.<br>
또한, 프로젝트/유니티 버전에서 스크립트가 제대로 작동하는지 빠르게 테스트할 수 있는 테스트도 만들었습니다.<br>

## 설치
git URL을 통해 설치하세요:  
`https://github.com/STARasGAMES/tmpro-dynamic-data-cleaner.git#upm`

또는 **`manifest.json`** 에 새 항목을 추가하여 설치할 수 있습니다.
```json
{
  "dependencies": {
    "com.starasgames.tmpro-dynamic-data-cleaner": "https://github.com/STARasGAMES/tmpro-dynamic-data-cleaner.git#upm",
    ...
  },
  "testables" : ["com.starasgames.tmpro-dynamic-data-cleaner"]
}
```
통합 테스트를 TestRunner 창에 표시하려면 `"testables"` 속성을 추가해야 하지만, 이는 선택 사항입니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---