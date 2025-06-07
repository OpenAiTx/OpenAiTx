![배너 이미지](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n - 기술팀을 위한 안전한 워크플로 자동화

n8n은 기술팀에게 코드의 유연성과 노코드의 속도를 모두 제공하는 워크플로 자동화 플랫폼입니다. 400개 이상의 통합, 네이티브 AI 기능, 공정한 코드(fair-code) 라이선스를 제공하며, 데이터와 배포에 대한 완전한 제어를 유지하면서 강력한 자동화를 구축할 수 있습니다.

![n8n.io - 스크린샷](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## 주요 기능

- **필요할 때 코드 작성**: JavaScript/Python 작성, npm 패키지 추가, 또는 시각적 인터페이스 사용
- **AI 네이티브 플랫폼**: LangChain을 기반으로 자체 데이터 및 모델로 AI 에이전트 워크플로 구축
- **완전한 제어**: 공정한 코드 라이선스로 자체 호스팅 또는 [클라우드 서비스](https://app.n8n.cloud/login) 이용
- **엔터프라이즈 지원**: 고급 권한, SSO, 에어갭 배포 지원
- **활발한 커뮤니티**: 400개+ 통합, 900개+ 바로 사용 가능한 [템플릿](https://n8n.io/workflows)

## 빠른 시작

[npx](https://docs.n8n.io/hosting/installation/npm/)로 즉시 n8n을 사용해보세요 ([Node.js](https://nodejs.org/en/) 필요):

```
npx n8n
```

또는 [Docker](https://docs.n8n.io/hosting/installation/docker/)로 배포:

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

http://localhost:5678 에서 에디터에 접속하세요

## 리소스

- 📚 [문서](https://docs.n8n.io)
- 🔧 [400+ 통합](https://n8n.io/integrations)
- 💡 [예제 워크플로](https://n8n.io/workflows)
- 🤖 [AI & LangChain 가이드](https://docs.n8n.io/langchain/)
- 👥 [커뮤니티 포럼](https://community.n8n.io)
- 📖 [커뮤니티 튜토리얼](https://community.n8n.io/c/tutorials/28)

## 지원

도움이 필요하신가요? 커뮤니티 포럼에서 지원을 받고 다른 사용자와 교류할 수 있습니다:  
[community.n8n.io](https://community.n8n.io)

## 라이선스

n8n은 [공정한 코드](https://faircode.io)로 [Sustainable Use License](https://github.com/n8n-io/n8n/blob/master/LICENSE.md) 및 [n8n Enterprise License](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md)에 따라 배포됩니다.

- **소스 공개**: 항상 볼 수 있는 소스 코드
- **자체 호스팅 가능**: 어디서나 배포 가능
- **확장성**: 직접 노드 및 기능 추가 가능

추가 기능 및 지원이 필요한 경우 [엔터프라이즈 라이선스](mailto:license@n8n.io)가 제공됩니다.

라이선스 모델에 대한 추가 정보는 [문서](https://docs.n8n.io/reference/license/)에서 확인할 수 있습니다.

## 기여하기

버그 🐛를 발견했거나 새로운 기능 아이디어 ✨가 있으신가요? [기여 가이드](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md)를 확인하고 시작해 보세요.

## 팀에 합류하세요

자동화의 미래를 함께 만들어가고 싶으신가요? [채용 공고](https://n8n.io/careers)를 확인하고 저희 팀에 합류하세요!

## n8n은 무슨 뜻인가요?

**짧은 답변:** "nodemation"의 의미이며, n-에잇-n으로 발음합니다.

**긴 답변:** "이 질문을 꽤 자주(생각보다 훨씬 자주) 받아서 여기서 답하는 것이 좋겠다고 생각했습니다. 무료 도메인으로 좋은 프로젝트명을 찾으려 했는데, 생각나는 좋은 이름은 이미 다 등록되어 있더군요. 그래서 결국 nodemation을 선택했습니다. 'node-'는 Node-View를 사용하고 Node.js를 기반으로 한다는 의미이고, '-mation'은 'automation'에서 따왔습니다. 하지만 이름이 너무 길어서 CLI에서 매번 입력하는 것이 상상되지 않았습니다. 그래서 결국 'n8n'이라는 이름으로 정하게 되었습니다." - **Jan Oberhauser, n8n.io 창립자 및 CEO**

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---