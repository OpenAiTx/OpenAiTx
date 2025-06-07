![Imagem do Banner](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n - Automação de Workflows Segura para Equipes Técnicas

n8n é uma plataforma de automação de workflows que oferece às equipes técnicas a flexibilidade do código com a velocidade do no-code. Com mais de 400 integrações, capacidades nativas de IA e uma licença fair-code, o n8n permite criar automações poderosas mantendo controle total sobre seus dados e implantações.

![n8n.io - Captura de Tela](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## Principais Capacidades

- **Código Quando Precisar**: Escreva em JavaScript/Python, adicione pacotes npm ou use a interface visual
- **Plataforma Nativa em IA**: Construa workflows de agentes de IA baseados em LangChain com seus próprios dados e modelos
- **Controle Total**: Faça self-hosting com nossa licença fair-code ou utilize nossa [oferta em nuvem](https://app.n8n.cloud/login)
- **Pronto para Empresas**: Permissões avançadas, SSO e implantações isoladas (air-gapped)
- **Comunidade Ativa**: Mais de 400 integrações e mais de 900 [templates](https://n8n.io/workflows) prontos para uso

## Início Rápido

Experimente o n8n instantaneamente com [npx](https://docs.n8n.io/hosting/installation/npm/) (requer [Node.js](https://nodejs.org/en/)):

```
npx n8n
```

Ou implante com [Docker](https://docs.n8n.io/hosting/installation/docker/):

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

Acesse o editor em http://localhost:5678

## Recursos

- 📚 [Documentação](https://docs.n8n.io)
- 🔧 [400+ Integrações](https://n8n.io/integrations)
- 💡 [Workflows de Exemplo](https://n8n.io/workflows)
- 🤖 [Guia de IA & LangChain](https://docs.n8n.io/langchain/)
- 👥 [Fórum da Comunidade](https://community.n8n.io)
- 📖 [Tutoriais da Comunidade](https://community.n8n.io/c/tutorials/28)

## Suporte

Precisa de ajuda? Nosso fórum da comunidade é o local para obter suporte e se conectar com outros usuários:
[community.n8n.io](https://community.n8n.io)

## Licença

n8n é [fair-code](https://faircode.io) distribuído sob a [Licença de Uso Sustentável](https://github.com/n8n-io/n8n/blob/master/LICENSE.md) e [Licença Enterprise do n8n](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md).

- **Código Fonte Disponível**: Código sempre visível
- **Self-Host**: Implemente em qualquer lugar
- **Extensível**: Adicione seus próprios nós e funcionalidades

[Licenças Enterprise](mailto:license@n8n.io) disponíveis para recursos e suporte adicionais.

Informações adicionais sobre o modelo de licença podem ser encontradas na [documentação](https://docs.n8n.io/reference/license/).

## Contribuindo

Encontrou um bug 🐛 ou tem uma ideia de funcionalidade ✨? Confira nosso [Guia de Contribuição](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md) para começar.

## Junte-se ao Time

Quer moldar o futuro da automação? Confira nossas [vagas de emprego](https://n8n.io/careers) e junte-se ao nosso time!

## O que significa n8n?

**Resposta curta:** Significa "nodemation" e pronuncia-se n-eight-n.

**Resposta longa:** "Recebo essa pergunta com bastante frequência (mais do que eu esperava), então decidi que era melhor respondê-la aqui. Ao procurar um bom nome para o projeto com domínio livre, percebi rapidamente que todos os bons já estavam ocupados. Então, no final, escolhi nodemation. 'node-' no sentido de que utiliza uma Visualização de Nós (Node-View) e porque usa Node.js, e '-mation' de 'automation', que é o objetivo do projeto. No entanto, não gostei do tamanho do nome e não conseguia imaginar escrever algo tão longo sempre no CLI. Foi aí que cheguei ao 'n8n'." - **Jan Oberhauser, Fundador e CEO, n8n.io**

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---