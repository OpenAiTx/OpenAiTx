## ***AVISO DE RESPONSABILIDADE***

Eu **não sou responsável** por qualquer uso indevido, abuso ou ações antiéticas realizadas com as ferramentas ou métodos listados aqui. **OSINT é uma técnica neutra**—qualquer pessoa pode utilizá-la, e qualquer pessoa pode ser alvo.

Nota: Alguns domínios (por exemplo, `exposed.lol`) podem estar expirados. Consulte a lista curada ou links alternativos fornecidos.

## Sugestões

Abra uma [issue](https://github.com/airborne-commando/OPSEC-OSINT-Tools/issues) para sugestões ou feedback.

## Por quê?

As pessoas confiam demais na internet. No mundo de hoje, online e offline são praticamente a mesma coisa—verdade e ficção se confundem. Este README existe para aumentar a conscientização. Clone, faça fork, remixe ou até transforme em uma página [Rentry](https://rentry.co/). Espalhe o conhecimento como quiser.

Você pode prever o comportamento de alguém com isso? Não exatamente; pessoas são imprevisíveis às vezes.

# Ferramentas de OSINT/OPSEC

Uma lista de ferramentas de OSINT/OPSEC que eu criei, fiz fork e/ou utilizo. Primeiro, vamos falar das definições.

## Índice
1. [OPSEC](#operations-security-is-a-systematic-process-for)
   - [Como fazer OPSEC](#how-to-opsec)
      - [Cortina de fumaça e desinformação](#Smoke-Screen-and-misinfo) 
2. [Inteligência de Fonte Aberta (OSINT)](#open-source-intelligence-osint)
3. [Quem usa Inteligência de Fonte Aberta (OSINT)?](#who-uses-open-source-intelligence-osint)
4. [Fontes de OSINT](#sources-of-osint)
5. [Perfilamento OSINT](#digital-profiling-osint-profiling)
6. [Código fechado](#closed-sourced-info)
7. [Exemplos reais de OSINT](#real-world-examples-of-osint)
   - [Coordenação de ataque aéreo em 2016](#in-the-year-2016-a-basket-weaving-image-board-used-osint-to-pay-some-supposed-terrorist-a-vist-from-a-govt-in-russia-resulting-in-airstrikes)
   - [Protesto de Shia LaBeouf em 2017](#in-2017-shia-labeouf-had-a-protest-due-to-trumps-election-this-resulted-in-a-basket-weaving-image-board-using-osint-and-sky-patterns-to-figure-out-where-a-flag-is)
8. [Ferramentas](#tools)
      - [Recomendações de Toolchain](#toolchain-recommendations)
9. [Ferramentas de busca de pessoas (nos EUA)](#people-search-tools-in-the-states)
10. [Literatura cinzenta](#grey-literature)
11. [Dados vazados](#breached-data)
12. [Mídias Sociais](#social-media)
13. [Self OSINT](#toolchain-self-osint)
14. [Listas curadas](#curated-lists)
16. [Ferramentas de arquivamento](#archive-tools-that-ive-made)

## (OPSEC - Segurança de Operações) é um processo sistemático para:
1. Identificar
2. Proteger e controlar informações críticas

É uma disciplina de segurança e uma função operacional que envolve um ciclo contínuo de:
* Identificar informações e indicadores críticos (CII)
  * Informações e indicadores críticos são componentes essenciais da Segurança de Operações, visando proteger dados sensíveis que podem ser explorados por adversários. Informações críticas incluem informações não classificadas ou controladas sobre atividades, intenções, capacidades ou limitações que adversários podem usar para obter vantagem. Indicadores são ações observáveis ou pedaços de informação que revelam detalhes críticos sobre operações, como mudanças repentinas em procedimentos ou aumento de medidas de segurança. Proteger essas informações envolve identificar vulnerabilidades e implementar contramedidas para evitar divulgação não autorizada.
* Analisar ameaças e vulnerabilidades potenciais
* Avaliar riscos
* Desenvolver contramedidas para proteger o CII

É usada para proteger informações e atividades de adversários. Ajuda a identificar e proteger informações sensíveis que poderiam dar vantagem a um adversário. Os princípios de OPSEC podem ser aplicados no dia a dia, como não compartilhar informações pessoais como data de nascimento, endereço, e-mail, número de telefone.

**Exemplos de erros de OPSEC incluem:**
* Compartilhar informações pessoais demais online
   * [Chris Chan](https://www.youtube.com/playlist?list=PLABqEYq6H3vpCmsmyUnHnfMOeAnjBdSNm)
   * [suspectAGB](https://opsecfail.github.io/blog.html?filecase=suspectAGB)

* Deixar mídias sociais não utilizadas online
* Interagir com um alvo nas redes sociais
   * [w0rmer](https://opsecfail.github.io/blog.html?filecase=w0rmer)
   * [darknetdiaries](https://darknetdiaries.com/transcript/63/)

* [Exemplos de boas e más práticas de OPSEC e um pouco de OSINT.](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/examples.md)

OPSEC complementa outras disciplinas de segurança ao invés de substituí-las.

### Como fazer OPSEC:

* **Use serviços que possam ocultar sua identidade:**
---

| **Categoria**               | **Ferramenta/Técnica**     | **Descrição**                                                                | **Prós**                                    | **Contras/Limitações**                       |
|----------------------------|----------------------------|-----------------------------------------------------------------------------|---------------------------------------------|----------------------------------------------|
| **Mensagens Criptografadas** | [Telegram](https://telegram.org/)               | Mensagens em nuvem com E2E opcional ("Conversas Secretas")                  | Muito adotado, muitos recursos              | Não é E2E por padrão; armazena dados nos servidores; requer número de telefone |
|                             | [Simplex](https://simplex.chat/)                | Sem identificadores de usuário (nem mesmo números aleatórios)               | Máxima privacidade de metadados             | Menos amigável; rede menor                   |
|                             | [Signal](https://signal.org/download/)                 | Criptografia E2E por padrão; retenção mínima de metadados                   | Padrão ouro em privacidade; resistente a tribunais | Requer número de telefone               |
| **Redes de Anonimato**      | [Tor](https://www.torproject.org/)                    | Tráfego roteado por nós criptografados para esconder IP                      | Gratuito; robusto contra rastreamento       | Lento; CAPTCHAs frequentes                   |
|                             | [Mullvad VPN](https://mullvad.net/en)            | VPN sem logs aceitando pagamentos em Monero (XMR)                            | Forte privacidade; opções de pagamento anônimas | VPNs não corrigem maus hábitos de OPSEC  |
| **Criptomoeda**             | [Monero (XMR)](https://www.getmonero.org/)           | Criptomoeda não rastreável                                                   | Transações privadas                         | Requer mineração/nó local para anonimato total + tempo |
| **Gestão de Identidade**    | Usuários Únicos           | Use credenciais diferentes por site                                         | Evita ataques de correlação                 | Difícil de gerenciar sem gerenciador de senhas |
|                             | Word Spinners             | Parafraseie textos para evitar detecção                                      | Evita plágio/vinculação de identidade       | Pode soar artificial                         |
|                             | Rostos Gerados por IA     | Fotos falsas de perfil (ex: ThisPersonDoesNotExist.com)                      | Esconde a identidade real                   | Pode parecer artificial                      |
| **Self-OSINT**              | Guias de Opt-Out          | Remova dados pessoais de sites de busca de pessoas                           | Reduz pegada digital                        | Demorado; nem todos os sites atendem sem pagamento |
| **Recursos de OPSEC**       | Exemplos de OPSEC Ruim    | [Lista de falhas](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/badopsec.md) | Aprenda com erros de outros                 | N/A                                         |
|                             | Boas Práticas de OPSEC    | [Diretrizes](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/good-opsec.md) | Dicas práticas                              | Requer disciplina                            |
| **Listas de Ferramentas**   | Ferramentas OPSEC         | [Lista curada](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md) | Recurso abrangente                          | Pode precisar de atualizações                |

---

### **Principais Lições**  
1. **Mensagens**:  
   - **Signal** OU **Simplex** > **Telegram** em privacidade.  
   - Lembre-se: E2E ≠ anonimato total (vazamentos de metadados/hábitos importam).

2. **Anonimato**:  
   - **Tor** + **Mullvad VPN** + **XMR** = proteção em camadas.  
   - Evite logar em contas pessoais ao usar essas ferramentas.
   - Atenção: Use TOR e Mullvad separadamente para máximo anonimato; use uma [Máquina Virtual](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md#virtualization) para VPNs e TOR em outra (ou no host).

3. **Identidade**:  
   - **Usuários únicos** + **Rostos IA** + **Word Spinning** = mais difícil de rastrear.  

4. **Autoavaliação**:  
   - Regularmente **faça opt-out** de brokers de dados e **faça OSINT em si mesmo**.  

5. **Mentalidade OPSEC**:  
   - Siga as **[boas práticas de OPSEC](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/good-opsec.md)** e evite **[maus hábitos](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/badopsec.md)**.

**Nota**:

Por TOR entenda Tor Browser, VPN como Rede Privada Virtual (Mullvad; mas pode ser outro tipo desde que seja seguro e validado por especialistas em privacidade); XMR é Monero Coin ou apenas Monero, uma moeda privada.

Consulte a Wikipédia se estiver confuso:
1. [VPN](https://en.wikipedia.org/wiki/Virtual_private_network)
   - [Serviço VPN](https://en.wikipedia.org/wiki/VPN_service)
2. [TOR](https://en.wikipedia.org/wiki/Tor_(network))
3. [XMR](https://en.wikipedia.org/wiki/Monero)

---

### **Dicas Profissionais**  
- **Signal Alternativo**: Use número descartável (ex: Google Voice) para registro.  
- **Mineração Monero**: Rode um nó local para evitar rastreamento por exchanges centralizadas.  

Para detalhes completos das ferramentas, veja a **[Lista de Ferramentas OPSEC](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md)**.

## Cortina de fumaça e desinformação

Uma operação de cortina de fumaça no contexto de OSINT (Open Source Intelligence) refere-se a ações deliberadas para obscurecer, enganar ou mascarar as verdadeiras atividades, intenções ou identidades de indivíduos ou organizações diante daqueles que realizam coleta de inteligência de fonte aberta. O termo vem da tática militar de usar fumaça para esconder movimentos ou posições do inimigo. Em contexto cibernético e de inteligência, o conceito é adaptado para ambientes digitais e informacionais. Leia mais [aqui](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/smokescreen-misinfo.md).

## Inteligência de Fonte Aberta (OSINT)

**<div align="center">O que é, como é usada e por que é importante:</div>**

- OSINT é a prática de coletar e analisar informações de fontes públicas para atender necessidades específicas de inteligência. É usada por órgãos governamentais e empresas para diversos fins, incluindo:

  - Reconhecimento
  - Investigações de crimes cibernéticos
  - Análise de tendências de mercado
  - Análise de posicionamento de marca
  - Medição de riscos para uma organização
  - Compreensão do agente, táticas e alvos
  - Obtenção de informações em tempo real
  - Tomada de decisões informadas
  - Receber alertas antecipados de ameaças potenciais

## Quem usa Inteligência de Fonte Aberta (OSINT)?

- Órgãos de Segurança Nacional e Inteligência, Forças Policiais, Empresas, Grupos de Segurança/Cibercrime, Pessoas preocupadas com privacidade, ONGs

  - A CIA, Defense Intelligence Agency (DIA) e Office of the Director of National Intelligence (ODNI) usam OSINT.
  - OSINT pode proteger cidadãos (privados ou não) contra roubo de identidade, violência sexual e abuso.
  - OSINT pode monitorar concorrentes, investigar novos mercados e planejar atividades de marketing.
  - OSINT pode coletar inteligência sobre alvos específicos online.
  - OSINT pode verificar como invasores podem acessar dispositivos de computação.
  - OSINT pode ser usado em si mesmo para proteger a privacidade.
  - Bellingcat, Center for Information Resilience e Oryx usam OSINT.
  - E você! Sim, você pode usar OSINT.

## Fontes de OSINT
OSINT pode coletar informações de várias fontes, incluindo:
- [Dados públicos do governo](https://www.opendatasoft.com/en/glossary/public-data/)

  - Dados públicos referem-se a todas as informações disponibilizadas gratuitamente por órgãos públicos ou coletividades locais. Estes dados estão em domínio público. Diferem de dados abertos, que são um subconjunto dos dados públicos. Dados abertos são estruturados e bem mantidos, sendo mais fáceis de entender, acessar e consumir. Por outro lado, dados públicos podem ser difíceis de encontrar, ou (no caso de órgãos públicos), exigir pedido via Lei de Acesso à Informação.

- [Publicações profissionais e acadêmicas](https://www.lawinsider.com/dictionary/academic-publication)

  - Publicação acadêmica significa publicação de resumo, artigo ou paper em periódico ou repositório eletrônico, ou apresentação em conferência ou seminário.

- [Dados comerciais](https://www.lawinsider.com/dictionary/commercial-data)

  - Dados Comerciais significam todos os dados e informações relacionados a uma Pessoa identificada ou identificável (seja a informação exata ou não), isoladamente ou em combinação com outras informações, que seja ou foi cliente real ou potencial, ou consumidor de produtos oferecidos pelo negócio.

- [Literatura cinzenta](https://browse.welch.jhmi.edu/c.php?g=1195274)

  - Literatura cinzenta é "Informação produzida em todos os níveis de governo, acadêmico, negócios e indústria em formatos eletrônicos e impressos não controlados por editoras comerciais, ou seja, onde publicação não é a atividade principal do órgão produtor."

  - Pode ser útil para sua pesquisa, mas encontrar recursos exige táticas diferentes das usadas em materiais publicados comercialmente.

### Exemplos reais de OSINT

## Em 2016, um imageboard usou OSINT para que um suposto terrorista recebesse uma visita de um [governo russo, resultando em ataques aéreos.](https://imgur.com/pol-helps-coordinate-airstrike-on-moderate-syrian-rebels-N7DwWP1)

- [Vídeo detalhando os eventos](https://www.youtube.com/watch?v=OR6epSP_Xlw)

  - Em 2016, durante a complexa Guerra Civil Síria, vários grupos rebeldes—alguns bem-intencionados, outros não—tentaram derrubar o presidente Assad. O caos permitiu o crescimento de grupos terroristas, levando à intervenção dos EUA (apoiando rebeldes) e Rússia (apoiando Assad). Um usuário anônimo no fórum Syria General (SG) do 4chan afirmou que um grupo rebelde sírio, Jaysh al-Izza, postou um vídeo no YouTube revelando seu acampamento secreto. O grupo, associado à Al-Qaeda, foi visto pelos usuários do 4chan como alvo. Ivan Sirenko, usuário notável do 4chan com ligações ao exército russo, recebeu as coordenadas e as enviou ao Ministério da Defesa russo, resultando em um ataque aéreo. Dois meses depois, o mesmo grupo postou outro vídeo mostrando novo campo de treinamento. Usuários do 4chan novamente localizaram usando referências visuais, e Ivan encaminhou para novo ataque.

ATUALIZAÇÃO: Era um conflito extremamente complexo no qual o 4chan se envolveu, mas fica como exemplo-chave; o erro principal foi expor locais de treinamento na internet.
Ou seja, má OPSEC.

## Em 2017, Shia LaBeouf protestou contra a eleição de Trump; isso resultou em um imageboard usando OSINT e [padrões do céu para encontrar uma bandeira.](https://www.vice.com/en/article/4chan-does-first-good-thing-pulls-off-the-heist-of-the-century1/)

- Em 2017, usuários do 4chan conseguiram rastrear e substituir a bandeira "He Will Not Divide Us" de Shia LaBeouf. Usando apenas as imagens ao vivo, analisaram padrões de voo, posições das estrelas e um tweet para localizar a bandeira em Greeneville, Tennessee. Um troll local buzinou até o som ser captado pela live, localizando o ponto exato. A bandeira foi trocada por um boné do Trump, encerrando a operação.

## Perfilamento digital (OSINT profiling) 

O perfilamento digital e análise comportamental são técnicas poderosas para entender indivíduos com base em suas atividades e pegadas digitais. Embora normalmente usadas por profissionais, você pode aplicar muitos dos mesmos princípios seguindo uma abordagem estruturada.

Leia mais neste readme em [OSINT profiling](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/OSINT-profiling.md)

## Informação de código fechado

- [HUMINT](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/HUMINT.md)

**HUMINT pode ser coletada de forma aberta (ex: entrevistas, relatórios diplomáticos) ou encoberta (ex: espionagem, vigilância clandestina).**

**Comprar de brokers de dados pode ser código fechado se a informação não estiver disponível livremente, a menos que seja cruzada com as [Listas Curadas](#curated-lists) ou [Toolchain](#toolchain-self-osint) para self OSINT**

## Ferramentas

---

| **Categoria**               | **Ferramenta**             | **Link**                                                                 | **Funcionalidade**                                                            | **Limitações/Notas**                                                              |
|-----------------------------|----------------------------|-------------------------------------------------------------------------|-------------------------------------------------------------------------------|-----------------------------------------------------------------------------------|
| **Consultas Google**        | Google-FU                  | [GitHub](https://github.com/airborne-commando/GoogleFU-improved)        | Dorking avançado para buscas direcionadas                                      | Limite de taxa; pode ativar CAPTCHAs                                               |
| **Análise biométrica**      | Facecheck.ID               | [GitHub](https://github.com/vin3110/facecheck.id-results-extractor)     | Busca reversa de imagens, burlando paywalls                                    | Requer Tampermonkey; só extrai links                                               |
| **Busca de usuário/e-mail** | Blackbird                  | [GitHub](https://github.com/p1ngul1n0/blackbird)                       | Busca rápida de usuário/e-mail em várias plataformas                           | Apenas CLI; leve                                                                   |
|                             | Crow (GUI para Blackbird)  | [GitHub](https://github.com/airborne-commando/crow)                     | Versão GUI do Blackbird                                                        | Mesma funcionalidade do CLI                                                        |
|                             | Sherlock                   | [GitHub](https://github.com/sherlock-project/sherlock)                  | Busca abrangente de usuários em 300+ sites                                     | Falsos positivos (ex: Imgur); baseada em CLI                                       |
|                             | No-Shit-Sherlock (GUI)     | [GitHub](https://github.com/airborne-commando/no-shit-sherlock)         | GUI para Sherlock                                                              | Herda limitações do Sherlock                                                       |
|                             | Maigret                    | [GitHub](https://github.com/soxoj/maigret)                              | Busca de conexões de usuário (fork do Sherlock)                                | Foca em vinculação de perfis                                                       |
|                             | Maigret-Night (GUI)        | [GitHub](https://github.com/airborne-commando/maigret-night)            | GUI para Maigret                                                               | Idêntico ao Maigret CLI                                                            |
|                             | Holehe                     | [GitHub](https://github.com/megadose/holehe)                            | Checa uso do e-mail em sites                                                   | Falsos positivos Imgur; baseada em CLI                                             |
| **Comprometimento de e-mail**| Hudson Rock Extractor     | [GitHub](https://github.com/airborne-commando/hudsonrock-search-extractor)| Verificador manual de vazamentos de e-mail (Flask)                            | Não automatizado; requer input manual                                              |
| **Geolocalização**          | Google Maps                | [maps.google.com](https://maps.google.com/)                             | Localização precisa/comparação de pontos                                        | Apenas dados públicos; sem recursos avançados de OSINT                             |
| **OSINT generalizado**      | OSINT Rocks                | [osint.rocks](https://osint.rocks/)                                     | Multi-ferramenta: Hudson Rock, Holehe, GHunt, buscas de telefone/domínio/usuário | Web; combina várias ferramentas em uma interface                                   |

---

### **Principais Insights & Dicas**

1. **Falsos Positivos**:  
   - **Sherlock/Holehe**: Imgur retorna muitos resultados enganosos—verifique manualmente.  
   - **Facecheck.ID**: Extrai links, mas não analisa imagens; compare com [Pimeyes (10 buscas)](https://pimeyes.com/en) ou outros da etapa 6.

2. **GUI vs CLI**:  
   - **CLI (Blackbird, Sherlock, Maigret)**: Mais rápido, mas exige conhecimento técnico.  
   - **GUI (Crow, No-Shit-Sherlock)**: Mais fácil para iniciantes; mesma lógica de backend.  

3. **Investigação de e-mail**:  
   - Combine **Holehe** (detecção de conta) + **Hudson Rock Extractor** (dados de vazamento) para checagem completa; veja [**Recomendações de Toolchain**](#Toolchain-Recommendations).  
   - Para Gmail, use **GHunt** (via OSINT Rocks).

4. **Geolocalização**:  
   - Use **Google Maps Street View** para verificar endereços de outras ferramentas (ex: ClustrMaps).

5. **OPSEC**:  
   - **Limites de taxa**: Ferramentas como Google-FU podem ser bloqueadas—use proxies/VPNs.
   - **Legalidade**: Não faça scraping de dados privados sem consentimento.

6. **Análise biométrica**: Você pode complementar sua análise biométrica com:
 - faceonlive.com (limite de 3 ou 4 buscas, pode precisar de TOR)
 - lenso.ai 

Depois, abra a imagem em nova aba e salve ou arraste para o facecheck.id e compare (como dito na etapa 1).

---

### **Recomendações de Toolchain**
- **Busca rápida de usuário**: Crow (GUI para aprofundado) → Maigret (GUI) → Sherlock (CLI).
- **Vazamentos de e-mail**: Have I Been Pwned → Pentester (quase grátis) → OSINT Rocks (Hudson Rock/Holehe) → LOLArchiver.
- **Imagens**: Facecheck.ID → Pimeyes → lenso.ai → faceonlive
- **Arquivos**: Discos criptografados (LUKS) → veracrypt → keepassxc

Nota sobre Pentester: Dá resultados grátis, mas com limite de tempo; não compensa pagar se você for organizado.

Nota: Para keepassxc, use senha forte ou YubiKey (hardware). Você pode criar um banco de dados adicional: um com senha memorizável, outro só para arquivos sensíveis.

Para ferramentas de nicho, consulte a seção [Listas Curadas](#curated-lists).

Pipeline discutido [aqui](https://github.com/airborne-commando/OPSEC-OSINT-Tools/blob/main/opsec.md#opsec-pipeline-for-secure-files)

## Ferramentas de busca de pessoas (nos EUA):

**AVISO: A maioria das informações de e-mail nesses sites vem de vazamentos antigos; pessoas raramente trocam de e-mail por causa de autenticação em dois fatores + gerenciadores de senha, a menos que tenham sido comprometidas ou devido a assédio, spam, etc.**

---

| **Ferramenta**            | **Busca por**         | **Retorna**                              | **Notas**                                                                 |
|---------------------------|----------------------|------------------------------------------|---------------------------------------------------------------------------|
| **[FastPeopleSearch](https://www.fastpeoplesearch.com/)**   | Nome, Telefone, Endereço        | Idade, Endereço, Telefone, Email               | Grátis; dados podem estar desatualizados.                               |
| **[That's Them](https://thatsthem.com/)**        | Nome, Email, IP, VIN, Telefone | IP, Endereços, Telefone, Email                | Agrega dados do Intelius/Spokeo; alguns resultados pagos.               |
| **[Nuwber](https://nuwber.com/)**            | Nome, Telefone, Email, Endereço | Data de Nasc., Endereço, Email, Telefone       | Relatórios detalhados podem ser pagos.                                  |
| **[IDCrawl](https://idcrawl.com/)**           | Nome, Usuário, Telefone, Email | Nomes, Usuários, Telefone, Email               | Foco em usernames/mídia social.                                         |
| **[PeekYou](https://www.peekyou.com/)**           | Nome, Usuário, Estado           | Idade, Redes Sociais, Emails, Endereços        | Forte para perfis sociais.                                              |
| **[Webmii](https://webmii.com/)**            | Nome completo               | Redes Sociais, Resultados de busca             | Leve; busca web pública/perfis sociais.                                 |
| **[PublicRecords](https://www.publicrecords.onlinesearches.com/)**     | Nome, Endereço, Estado        | Nome, Endereço, Telefone parcial               | Diretório grátis; redireciona para Intelius para detalhes pagos.        |
| **[ClustrMaps](https://clustrmaps.com/)**        | Nome, Endereço               | Endereços, Residentes, Propriedade, Dados IP   | Foco em geolocalização/demografia; pode incluir histórico de posse.     |
| **[fastbackgroundcheck](https://www.fastbackgroundcheck.com)** | Nome, Endereço, Telefone | Nome, Endereço, Telefone, Emails | Vasculha bilhões de registros, conforme descrito no [site](https://www.fastbackgroundcheck.com/about) |

---

### **Observações**
1. **Grátis vs Pago**: Ferramentas oferecem infos básicas grátis e vendem relatórios (ex: PublicRecords → Intelius).
2. **Fontes de dados**: Muitos usam os mesmos vazamentos/registros públicos (emails/telefones antigos, mas ainda em uso).
3. **Especializações**:  
   - *Redes Sociais*: PeekYou, IDCrawl.  
   - *Geolocalização*: ClustrMaps.  
   - *Completo*: FastPeopleSearch, Nuwber, fastbackgroundcheck.  

**Aviso**: A precisão varia; usuários raramente mudam de e-mail a menos que sejam comprometidos. Use eticamente!

- Para mais ferramentas, veja [Listas curadas](#curated-lists)

## Literatura cinzenta

Use este site; [não se registre](https://vote.gov/register), apenas verifique o registro de eleitor. Pode precisar de mais infos em alguns estados.

Ferramenta automática que criei para [pa voter services](https://github.com/airborne-commando/voter-reg-status). Faça fork para outros estados se quiser.

## Dados vazados:
---

| **Ferramenta**            | **Busca por**       | **Retorna**                              | **Limitações/Custos**                         | **Notas**                                                                 |
|---------------------------|---------------------|------------------------------------------|-----------------------------------------------|---------------------------------------------------------------------------|
| **[Have I Been Pwned](https://haveibeenpwned.com/)**  | Email, Telefone      | Vazamentos, datas, dados comprometidos    | Grátis; sem senhas/dados brutos               | Fonte confiável; alerta para novos vazamentos.                            |
| **[BreachDirectory](https://breachdirectory.org/)**    | Email, Usuário       | Hashes parciais de senha (SHA-1, 4 chars), tamanho | Grátis; sem senhas completas         | Útil para checagem de stuffing de credenciais.                            |
| **[Breach.vip](https://Breach.vip)**         | Email, Usuário       | Vazamentos focados em Minecraft           | Grátis; requer login                          | Niche para contas de jogos; funcional.                                    |
| **[LeakPeek](https://leakpeek.com/)**           | Email, Usuário       | Trechos parciais de vazamento             | 5 buscas grátis; possível burlar com Tor       | Planos pagos para dados completos; resultados ofuscados.                  |
| **[LOLArchiver](https://osint.lolarchiver.com/)**        | Email, Usuário       | Bancos de dados completos (ex: emails, senhas) | Apenas pago                             | Para profissionais de OSINT; vazamentos valiosos.                         |
| **[Icebreaker](https://github.com/airborne-commando/ice-breaker)**         | Arquivos locais      | Analisa grandes datasets de vazamento      | Python/EXE; melhor para arquivos <1000GB       | Script demo disponível; use com cautela (ex: [Facebook 533M](https://github.com/davidfegyver/facebook-533m)).   |
| **[hashes.com](https://hashes.com/)**         | Hash (MD5, SHA-1, etc.) | Senhas descriptografadas (se quebradas)   | Ferramentas grátis/pagas                      | Útil para reverter hashes de vazamentos.                                  |
| **[pentester.com](https://pentester.com/)**          | Email, Usuário       | Detalhes completos de vazamentos           | Grátis; sem necessidade de Tor                 | Extenso, mas pode incluir dados sensíveis.                                |

---

### **Resumo**:  
1. **Grátis vs Pago**:  
   - *Grátis*: HIBP, BreachDirectory, Pentester, Hashes.com.  
   - *Grátis limitado*: LeakPeek (5 buscas), Breach.vip (login).  
   - *Pago*: LOLArchiver, LeakPeek premium.  

2. **Especializações**:  
   - *Recuperação de senha*: Hashes.com (quebra hash), BreachDirectory (hash parcial).  
   - *Vazamentos de jogos*: Breach.vip (Minecraft).  
   - *Análise local*: Icebreaker (Python para grandes datasets).  

3. **Notas éticas/legais**:  
   - Muitas ferramentas fornecem **dados parciais** (ex: 4 chars de senha) por ética.  
   - Use **Tor** com LeakPeek para burlar limites de busca.  
   - Evite uso indevido: Algumas (ex: Pentester) expõem dados sensíveis.  

4. **Para grandes datasets**:  
   - [Icebreaker](https://github.com/airborne-commando/ice-breaker) + [Facebook 533M](https://github.com/davidfegyver/facebook-533m) (sem senhas) para análise em massa.  

---

### **Recursos adicionais**:  
- **Listas curadas**: Veja [Listas Curadas](#curated-lists) para mais ferramentas.  
- **Scripts demo**: [Icebreaker](https://github.com/airborne-commando/ice-breaker) inclui demo para testes.  

## mídias sociais
---

| **Plataforma** | **Ferramenta**        | **URL**                                      | **Funcionalidade**                          | **Limitações/Notas**                  |
|----------------|----------------------|----------------------------------------------|---------------------------------------------|---------------------------------------|
| **Geral**      | Social Searcher      | [social-searcher.com](https://www.social-searcher.com/) | Busca em várias plataformas ao mesmo tempo  | Grátis limitado                      |
| **Snapchat**   | Snapchat Map         | [map.snapchat.com](https://map.snapchat.com/) | Visualizar histórias públicas do Snapchat   | Requer conta Snapchat                |
| **Instagram**  | Dumpor               | [dumpor.com](https://dumpor.com/)            | Ver perfis/histórias anonimamente           | Pode ter limites de uso              |
| **Twitter**    | Sotwe                | [sotwe.com](https://www.sotwe.com/)          | Navegação anônima no Twitter                | Não precisa login                    |
|                | Xcancel              | [xcancel.com](https://xcancel.com/)          | Visualizador alternativo para Twitter        | Interface leve                       |
|                | Nitter               | [nitter.net](https://nitter.net/)            | Front-end do Twitter focado em privacidade   | Evita rastreamento                   |
| **Facebook**   | Facebook Search      | [facebook.com/search](https://www.facebook.com/search/) | Ferramenta nativa de busca                 | Limitado sem login                   |
|                | WhoPostedWhat        | [whopostedwhat.com](https://www.whopostedwhat.com/) | Buscar posts por data/palavra-chave         | Requer consultas precisas, contas públicas |
| **reddit**     | r00m101.com          | [r00m101](https://r00m101.com/)              | Informações de contas ativas ou deletadas    | Possível cobrança para uso completo  |

---

### **Dicas & Alternativas**

1. **Contas privadas do Facebook**:
   - Método 1: Crie conta fake (difícil pela verificação do Facebook)
   - Método 2: Use *Inspecionar Elemento* do navegador → *Simulador de dispositivo* (ou celular) + URL direto
   - Tente sempre logado fora ou em modo privado primeiro

2. **Limitações do LinkedIn**:
   - Se não carregar perfis:
     - Espere 1-2 minutos (gire cookies/IP)
     - Crie conta básica (evite parecer suspeito)
   - Rastreamento HWID/IP pode bloquear buscas repetidas

3. **Alternativas do Twitter**:
   - Use **Nitter**/**Xcancel** para evitar limites/rastreamento
   - **Sotwe** funciona sem login

4. **Instagram**:
   - **Dumpor** burla algumas configurações de privacidade
   - **Uso rápido** https://dumpor.io/v/USERNAME substitua ``USERNAME`` pelo usuário desejado
   - **Não funciona com contas privadas**

---

### **Resumo**
- **Anonimato**: Ferramentas como Nitter/Dumpor evitam rastreamento da plataforma
- **Dicas Mobile**: Simular dispositivo mobile costuma funcionar melhor para conteúdo restrito
- **Persistência**: Algumas plataformas (LinkedIn/Facebook) exigem paciência ou criação de conta

- Para mais ferramentas, veja Listas Curadas abaixo.

## Listas curadas

- [Awesome OSINT](https://github.com/jivoi/awesome-osint) - lista curada de ferramentas, blogs e vídeos de OSINT

- [OSINT Framework](https://osintframework.com/) - lista maior de ferramentas
  
- [OSINT Resources](https://sizeof.cat/post/osint-resources/) - Coleção de recursos OSINT atualizados (inclui NSFW)

  - [Arquivo](https://archive.ph/rZZf0) 

- Wiki do reddit da [comunidade OSINT](https://www.reddit.com/r/OSINT/wiki/index/)

- Lista de mídias sociais, mapas, domínios etc. também listados na [coleção OSINT do cipher387](https://github.com/cipher387/osint_stuff_tool_collection). 

**OPT OUT**

- Uma [lista gigantesca](https://github.com/yaelwrites/Big-Ass-Data-Broker-Opt-Out-List) para sair e comparar info.

- [inteltechniques opt out workbook](https://inteltechniques.com/workbook.html)

- [Resultados sobre você (índice Google)](https://myactivity.google.com/results-about-you) - Veja o que o Google te envia; visite o site e tente sair do índice.

## Toolchain (self-OSINT):

Google dorks: `https://www.google.com/search?q= "first+last" "Street Address" "City state" "age"` -> [Resultados sobre você (índice Google)](https://myactivity.google.com/results-about-you) -> [big ass list](https://github.com/yaelwrites/Big-Ass-Data-Broker-Opt-Out-List) -> [inteltechniques opt out workbook](https://inteltechniques.com/workbook.html) -> [Ferramentas de busca de pessoas](https://github.com/airborne-commando/OPSEC-OSINT-Tools/tree/main?tab=readme-ov-file#people-search-tools-in-the-states)

**Aviso** 

[Resultados sobre você (índice Google)](https://myactivity.google.com/results-about-you) também pode ser enviado por e-mail, então fique atento ao comparar informações. Ou seja: o Google encontra sites com seu nome/endereço e pergunta se quer remover do índice. Antes de pedir a remoção, tente excluir do site de origem. Usar Google Dorks manualmente é mais rápido e evita ser marcado como bot.

## Ferramentas de arquivamento que criei
 
- [link extractor and archive](https://github.com/airborne-commando/link-extractor-and-archive) usa archive.ph – útil em páginas básicas. Requer intervenção manual (edição de texto LOCALIZAR+SUBSTITUIR).

Ferramentas adicionais:

- Para mais ferramentas, consulte as listas curadas acima

Doações:

Se achou útil, doe para este endereço Monero:

![mon](https://github.com/user-attachments/assets/f77ce530-5a5d-479d-bb47-481674c93f4c)

    8BPdcsLtA5iWLNTWvYzUVyTWtQkM62e8r7xqAuwjXTSC4RcoSWqpmtyLsMYvz3QNZtT1rbgPUnmVpMAudhxTn6zkRxUFcZN

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---