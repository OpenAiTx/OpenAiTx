<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />

  <p>
    <strong>모든 용도를 위한 빠르고 모듈식 라이트닝 네트워크 구현체, Rust로 작성되었습니다.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">프로젝트 홈페이지</a>
  </h4>
</div>

## 크레이트

현재 지원되는 크레이트의 전체 목록입니다:

| 크레이트     | 설명                                          | 버전        |
|:------------|:---------------------------------------------:|------------:|
| lampod-cli  | 데몬을 실행하기 위한 Lampo Daemon 명령줄 인터페이스 | _unrelated_ |
| lampo-cli   | 데몬과 상호작용하기 위한 간단한 Lampo 명령줄 인터페이스 | _unrelated_ |

## 설치 방법

모든 요구 사항과 Lampo 바이너리를 설치하려면 rust가 설치되어 있어야 하며, 다음 명령어를 실행해야 합니다:

```
make install
```

`lampod-cli`와 `lampo-cli`가 준비되면, 다음 명령어로 Lampo를 signet 모드로 실행할 수 있습니다:

```
➜  ~ lampod-cli --network signet
✓ 지갑이 생성되었습니다. 아래 단어들을 안전하게 보관하세요.
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
지갑 단어를 안전하게 보관하고, `--restore-wallet` 옵션으로 지갑을 복원할 때 재사용하세요.  
단어를 어디에도 저장하지 않으면, Lampo를 다음에 시작할 때 자금이 사라집니다!

`~/.lampo/signet` 경로에 `lampo.conf` 파일이 필요합니다.  
예시 설정 파일을 사용하려면 다음 명령어를 실행하세요:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

이후 다음 명령어로 노드를 쿼리할 수 있습니다:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### core lightning과 통합 테스트를 실행하려면:

core-lightning을 개발자 모드로 컴파일했는지 확인하세요. 설치 가이드는 [여기](https://docs.corelightning.org/docs/installation)에서 확인할 수 있습니다.

통합 테스트는 아래 명령어로 실행할 수 있습니다:

```
make integration
```

## 기여 가이드라인

[기여 가이드](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md)를 읽어주세요.

## 커뮤니티

명확한 소통을 위해 특정 채널을 선정했습니다:
- 개발자는 [Zulip](https://lampo-dev.zulipchat.com/)에 참여하세요.
- 커뮤니티 멤버는 [Twitter 커뮤니티](https://twitter.com/i/communities/1736414802849706087)에서 의견을 남겨주세요.
- 기술적 질문 및 기능 요청은 GitHub Discussions에서 자유롭게 남겨주세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---