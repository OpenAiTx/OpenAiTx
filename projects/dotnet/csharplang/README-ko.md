# C# 언어 디자인

[![https://gitter.im/dotnet/csharplang에서 채팅 참여하기](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Discord에서 채팅하기](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

C# 언어 디자인의 공식 저장소에 오신 것을 환영합니다. 이곳은 새로운 C# 언어 기능이 개발, 채택 및 명세되는 공간입니다.

C#은 언어를 구현하는 [Roslyn](https://github.com/dotnet/roslyn) 프로젝트와 긴밀히 협력하는 C# 언어 디자인 팀(LDT)에 의해 설계됩니다.

여기에서 다음을 찾을 수 있습니다:

- [proposals 폴더](https://raw.githubusercontent.com/dotnet/csharplang/main/proposals)에 있는 활성 C# 언어 기능 제안서
- [meetings 폴더](https://raw.githubusercontent.com/dotnet/csharplang/main/meetings)에 있는 C# 언어 디자인 회의 노트
- [언어 버전 히스토리 요약](https://raw.githubusercontent.com/dotnet/csharplang/main/Language-Version-History.md)

위의 내용에서 버그나 부족한 점을 발견하시면, 이슈를 남겨 제기해 주시거나, 더 나은 방법으로는 이를 수정하는 풀 리퀘스트를 보내주세요.

단, *새로운 기능 제안*은 [Discussion](https://github.com/dotnet/csharplang/labels/Discussion)에서 먼저 논의해 주시고, 언어 디자인 팀의 멤버(“챔피언”)가 요청하는 경우에만 이슈나 풀 리퀘스트로 제안서를 제출해 주시기 바랍니다.

전체 디자인 프로세스는 [여기](https://raw.githubusercontent.com/dotnet/csharplang/main/Design-Process.md)에 설명되어 있습니다. 간단한 개요는 아래에 있습니다.

## Discussions

언어 기능에 대한 논의는 이 저장소의 [Discussions](https://github.com/dotnet/csharplang/discussions)에서 이루어집니다.

기능을 제안하거나, 현재의 디자인 노트나 제안에 대해 토론하고 싶으시면 [새 Discussion 주제 열기](https://github.com/dotnet/csharplang/discussions/new)를 이용하세요.

짧고 주제에 집중된 논의가 훨씬 더 많이 읽힙니다. 댓글이 50개쯤 달리면, 몇몇 사람만 읽게 될 가능성이 높습니다. 논의를 더 쉽게 탐색하고 모두에게 유익하게 하기 위해 다음의 몇 가지 규칙을 지켜주세요:

- 논의는 C# 언어 디자인과 관련이 있어야 합니다. 그렇지 않으면 즉시 닫힙니다.
- 논의의 범위를 명확히 전달하는 설명적인 주제를 선택하세요.
- 논의의 주제에 집중하세요. 댓글이 주제를 벗어나거나 하위 주제로 들어가면, 새로운 논의를 시작하고 링크를 남기세요.
- 여러분의 댓글이 다른 사람들에게 유용한가요, 아니면 기존 댓글에 이모지 반응만으로 충분히 표현될 수 있나요?

특정 구문이 발생하지 못하도록 하는 언어 제안은 [Roslyn 분석기](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers)로 달성할 수 있습니다. 기존 구문을 선택적으로 불법으로 만드는 제안은 언어 복잡성 증가를 방지하기 위해 언어 디자인 위원회에서 거절됩니다.

## Proposals

C# LDM(언어 디자인 미팅) 멤버가 제안이 팀 전체의 검토 가치가 있다고 판단하면, 해당 제안을 [챔피언](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22)할 수 있습니다. 이는 그들이 제안을 C# 언어 디자인 미팅에 가져온다는 의미입니다. 제안은 항상 연결된 Discussion에서 논의되며, 챔피언 이슈에서 논의하지 않습니다. 이전에는 이 정책을 항상 따르지 않았기 때문에 많은 챔피언 이슈에 논의가 남아 있습니다. 현재는 챔피언 이슈에 새로운 논의가 발생하지 않도록 이슈를 잠급니다. 각 챔피언 이슈에는 논의 링크가 포함되어 있습니다.

## Design Process

[Proposals](https://raw.githubusercontent.com/dotnet/csharplang/main/proposals)은 [Language Design Meetings](https://raw.githubusercontent.com/dotnet/csharplang/main/meetings)의 결정, [discussions](https://github.com/dotnet/csharplang/discussions), 실험, 오프라인 디자인 작업의 결과로 발전합니다.

올바른 디자인에 도달하고 기능 채택 여부를 결정하기 위해 기능의 프로토타입을 구현하고 공유해야 하는 경우가 많습니다. 프로토타입은 기능의 구현 및 사용성 이슈를 모두 발견하는 데 도움이 됩니다. 프로토타입은 [Roslyn 저장소](https://github.com/dotnet/roslyn)의 포크에서 구현되어야 하며 다음 조건을 충족해야 합니다:

- (해당되는 경우) 파싱은 실험에 견고해야 하며, 입력 시 충돌이 발생하지 않아야 합니다.
- 최소한의 테스트를 포함해 기능이 실제로 동작함을 보여주어야 합니다.
- 최소한의 IDE 지원(키워드 색상, 포매팅, 완성 기능)을 포함해야 합니다.

승인되면, 기능은 [Roslyn](https://github.com/dotnet/roslyn)에 완전히 구현되고, [language specification](https://raw.githubusercontent.com/dotnet/csharplang/main/spec)에 완전히 명세되며, 제안서는 완료된 기능에 해당하는 폴더(예: [C# 7.1 proposals](https://raw.githubusercontent.com/dotnet/csharplang/main/proposals/csharp-7.1))로 이동됩니다.

**면책 조항**: 활성 제안은 향후 C# 프로그래밍 언어 버전에 포함될 가능성이 있는 것으로 적극적으로 검토 중이지만, 차기 또는 향후 어떤 버전에 최종적으로 포함된다는 보장은 없습니다. 디자인 팀, 커뮤니티, 코드 리뷰어, 테스트 등의 피드백에 따라 어떤 단계에서든 제안이 보류되거나 거절될 수 있습니다.

### 마일스톤

저장소의 이슈에는 몇 가지 마일스톤이 있습니다:
* [Working Set](https://github.com/dotnet/csharplang/milestone/19)은 현재 활발히 작업 중인 챔피언 제안 집합입니다. 이 마일스톤의 모든 내용이 다음 C# 버전에 포함되는 것은 아니지만, 차기 릴리스 동안 디자인 시간이 할당됩니다.
* [Backlog](https://github.com/dotnet/csharplang/milestone/10)은 챔피언 제안 중 선별은 되었으나 현재 활발히 작업 중이 아닌 집합입니다. 커뮤니티의 논의와 아이디어는 환영하지만, 디자인 작업 및 구현 검토 비용이 높아 준비가 될 때까지 커뮤니티 구현은 고려하지 않습니다.
* [Any Time](https://github.com/dotnet/csharplang/milestone/14)은 챔피언 제안 중 선별은 되었으나 현재 작업 중이 아니며 커뮤니티 구현이 열려 있는 집합입니다. 이 안에는 승인된 명세가 필요한 것과 구현이 필요한 것 두 가지 상태가 있습니다. 명세가 필요한 경우 LDM에서 명세 승인 프레젠테이션이 필요하지만, 가능한 한 빨리 시간을 내어 진행할 의사가 있습니다.
* [Likely Never](https://github.com/dotnet/csharplang/milestone/13)은 LDM에서 언어에 대해 거절한 제안의 집합입니다. 강한 필요성이나 커뮤니티 피드백이 없는 한, 이 제안들은 앞으로 고려되지 않습니다.
* 번호가 붙은 마일스톤은 해당 언어 버전에 구현된 기능 집합입니다. 마감된 마일스톤은 해당 릴리스에 포함된 기능 집합입니다. 열린 마일스톤은 릴리스가 가까워질 때 호환성 문제나 기타 이슈가 발견되면 나중에 기능이 제외될 수도 있습니다.

## 언어 디자인 회의

언어 디자인 회의(LDM)는 LDT와 가끔 초대된 게스트에 의해 개최되며, [meetings](https://raw.githubusercontent.com/dotnet/csharplang/main/meetings) 폴더에 연도별로 정리된 Design Meeting Notes로 문서화됩니다. 디자인 미팅 노트의 수명 주기는 [meetings/README.md](https://raw.githubusercontent.com/dotnet/csharplang/main/meetings/README.md)에 설명되어 있습니다. LDM에서는 향후 C# 버전에 대해 어떤 제안을 작업할지, 제안을 어떻게 발전시킬지, 채택 여부 및 시기를 결정합니다.

## 언어 명세

최신 ECMA-334 명세는 [C# Language Standard](https://github.com/dotnet/csharpstandard/) 저장소의 마크다운 형식으로 확인할 수 있습니다.

## 구현

C# 언어의 참조 구현은 [Roslyn 저장소](https://github.com/dotnet/roslyn)에서 확인할 수 있습니다. 이 저장소는 또한 [언어 기능의 구현 상태](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md)도 추적합니다. 최근까지 언어 디자인 산출물도 이곳에서 관리되었습니다. 활성 제안을 옮기는 동안 조금만 기다려 주세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---