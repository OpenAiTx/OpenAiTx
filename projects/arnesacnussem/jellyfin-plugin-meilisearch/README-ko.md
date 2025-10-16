# Jellyfin용 Meilisearch 플러그인

Meilisearch를 검색 엔진으로 활용하여 검색 속도와 결과를 향상시키려는 Jellyfin용 플러그인입니다.

이 플러그인은 검색 로직을 Meilisearch로 오프로드하고 Jellyfin의 응답을 수정합니다.

클라이언트가 `/Items` 엔드포인트를 검색에 사용하는 한 원활하게 지원될 것이라고 생각합니다.

[JellySearch](https://gitlab.com/DomiStyle/jellysearch)에서 영감을 받았습니다.

---

### 사용법

1. Meilisearch 인스턴스를 설정합니다(클라우드에 호스팅된 인스턴스도 작동할 수 있지만 추천하지 않습니다).
2. 다음 저장소를 추가하고 Meilisearch 플러그인을 설치합니다.
    ```
    https://raw.githubusercontent.com/arnesacnussem/jellyfin-plugin-meilisearch/refs/heads/master/manifest.json
    ```
3. 플러그인 설정에서 Meilisearch 인스턴스의 URL을 입력하세요. Meilisearch 설정에 따라 API 키도 필요할 수 있습니다.  
4. 여러 Jellyfin 인스턴스에서 하나의 Meilisearch 인스턴스를 공유하려면 `Meilisearch Index Name`을 입력하세요. 비워두면 서버 이름을 사용합니다.  
5. `저장` 버튼을 클릭하고 상태가 `ok`로 표시되는지 확인하세요.  
6. 검색 페이지에서 무언가를 입력해 보세요.  

    ---  

인덱스는 다음 이벤트에서 업데이트됩니다:  
- 서버 시작  
- 설정 변경  
- 라이브러리 스캔 완료  
- 인덱스 업데이트 작업 트리거  

---  

### 작동 방식  

검색 요청을 변형하는 핵심 기능은 [`ActionFilter`](https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-8.0#action-filters)를 주입하여 구현됩니다.  
따라서 Jellyfin의 몇몇 버전만 지원할 수 있습니다. 현재는 `Jellyfin 10.10.0`을 사용 중이며,  
`/Items` 엔드포인트의 필수 파라미터 이름이 변경되지 않는 한 다른 버전에서도 작동할 것입니다.  

---  
###  

저는 JellySearch라는 훌륭한 프로젝트를 봤지만, 리버스 프록시 설정이나 그런 번거로운 작업은 별로 좋아하지 않습니다.  

그래서 이 플러그인을 작성했지만, 여전히 Meilisearch 인스턴스가 필요합니다.  

현재 이 플러그인은 `/Items` 엔드포인트에만 영향을 미치지만, 20만 개 항목의 라이브러리에서 상당한 개선을 이뤘습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---