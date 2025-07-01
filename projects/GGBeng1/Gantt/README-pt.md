# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## Instalação

```
yarn install
```

### Execução

```
yarn run serve
```

### Descrição

```
Gráfico de Gantt desenvolvido com base em Vue, pode ser usado para colaboração em equipe, divisão de tarefas e outros cenários ágeis.

Suporta agrupamento
Suporta arrastar e soltar
Suporta esticamento
Suporta percentual
Suporta intervalo de tempo: dia, semana, mês
No momento, apenas o agrupamento de primeiro nível foi implementado; para evitar futuras necessidades de agrupamento de segundo ou múltiplos níveis, parte do código foi reestruturada na última submissão para suportar múltiplos níveis de agrupamento, mas esta versão ainda não implementou esse recurso.

Vantagens: Ao arrastar, esticar, modificar o progresso, etc., os dados não são atualizados em tempo real, mas apenas após a operação, reduzindo o consumo de desempenho.
           Ao editar, excluir ou adicionar, não é feita uma modificação recursiva completa da instância, mas apenas as partes modificadas são alteradas.

Está sendo preparado para reestruturação, visando a componentização. Atualmente, para usar no projeto, basta importar o `gant.vue` deste projeto.
Os métodos para importação e exportação em lote de dados já estão prontos, basta copiar!~

```

### Notas de Atualização

- Suporta edição
- Suporta exclusão
- Corrigido o bug que impedia a rolagem vertical (adicionada rolagem bidirecional simultânea) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Corrigido o bug causado pelo elementUI
- Sobre a questão do intervalo de tempo [#5](https://github.com/GGBeng1/Gantt/issues/5)
- No momento, não é possível implementar outros intervalos alterando a configuração, como adicionar horas, etc. Pois algumas configurações são fixadas diretamente na inicialização, mas isso será alterado futuramente e disponibilizado como API.

### Ver Exemplo

Veja [demo](https://ggbeng1.github.io/Gantt/#/)

### Imagem de Exibição

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---