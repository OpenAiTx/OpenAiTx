# Gantt

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
Suporta redimensionamento
Suporta percentual
Suporta intervalos de tempo: dia, semana, mês
Atualmente, apenas agrupamento de primeiro nível foi implementado. Para evitar demandas futuras por agrupamentos de segundo ou múltiplos níveis, parte do código foi refatorada na última submissão para suportar agrupamento em múltiplos níveis, mas essa versão ainda não foi desenvolvida.

Vantagens: Ao arrastar, redimensionar e modificar o progresso, os dados não são atualizados em tempo real, mas apenas após a operação, reduzindo o consumo de desempenho.
            Ao editar, excluir ou adicionar, não há uma modificação recursiva de toda a instância, apenas as partes alteradas são modificadas.

Está sendo preparado para reorganização visando a componentização. Atualmente, para usar no projeto, basta importar o `gant.vue` deste projeto.
Os métodos de importação e exportação em lote de dados já foram implementados, basta copiar!~
```

### Notas de Atualização

- Suporta edição
- Suporta exclusão
- Corrigido o bug de rolagem vertical não funcionar (adicionada também rolagem bidirecional) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Corrigido bug causado pelo elementUI
- Sobre o problema do intervalo de tempo [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Atualmente não é possível implementar outros intervalos apenas alterando a configuração, como adicionar horas, etc. Porque algumas configurações são fixadas na inicialização, isso será alterado futuramente e disponibilizado como API.

### Ver Exemplo

Veja [demo](https://ggbeng1.github.io/Gantt/#/)

### Imagem de Exibição

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---