# Componente Web de Imagem Fluida

Imagens que se ajustam de forma inteligente a qualquer tamanho desejado (dentro de limites razoáveis).

![Imagens Fluidas](https://raw.githubusercontent.com/VoiceNGO/fluid-img/refs/heads/main/resources/images/responsive-images.jpg)

**Minúsculo!:** 7kb minificado & compactado (gzip)

## Uso

```html
<script src="fluid-img.js"></script>
<fluid-img src="image.jpg"></fluid-img>
```

É isso. Redimensione as imagens como quiser, e elas simplesmente funcionarão.

## Demonstração

[Veja a Demonstração Aqui](https://voicengo.github.io/fluid-img/public/fluid-demo.html)

Um playground também está disponível para [experimentar com suas próprias imagens](https://voicengo.github.io/fluid-img/public).
## Instalação

### Biblioteca Cliente

```sh
npm install fluid-img
```

Em seguida, importe o `fluid-img` em seu projeto, que fornece e registra o web-component:

```ts
import 'fluid-img';
```

Ou inclua o script do jsdelivr ou unpkg:

```html
<script src="https://cdn.jsdelivr.net/npm/fluid-img@latest/dist/fluid-img.js" />

<!-- ou -->

<script src="https://unpkg.com/fluid-img@latest/dist/fluid-img.js" />
```
### Avisos

O componente de imagem fluida funciona melhor para imagens que precisam ser redimensionadas horizontal ou verticalmente dentro de uma faixa de aproximadamente 0,5x a 1,5x do seu tamanho original. Embora consiga lidar com escalas maiores ou menores, a qualidade visual pode se degradar rapidamente. Não é recomendado para imagens onde a integridade de pixels precisa ser precisa, como retratos, gráficos ou desenhos técnicos detalhados, pois o seam carving introduz distorções. É altamente recomendável testar suas imagens em vários tamanhos para garantir que atendam às suas expectativas visuais.

#### CORS

Devido a restrições de segurança dos navegadores, imagens carregadas de uma origem diferente (domínio, protocolo ou porta) daquela da página web irão gerar um erro de Cross-Origin Resource Sharing (CORS). Este componente requer acesso aos dados brutos de pixels da imagem, o que é restrito pelo CORS.

Para usar imagens de uma origem diferente, o servidor que hospeda as imagens deve estar configurado para enviar os cabeçalhos CORS apropriados (ex.: `Access-Control-Allow-Origin: *` ou `Access-Control-Allow-Origin: seu-dominio.com`). Sem esses cabeçalhos, o componente não conseguirá processar a imagem.

(Para sua informação, para fins de teste, qualquer imagem do imgur possui os cabeçalhos CORS necessários)

#### Fallback

Se o componente falhar ao carregar ou processar a imagem, ou lançar um erro interno, ele irá degradar de forma graciosa para injetar uma tag padrão `<img>` dentro do componente `<fluid-img>`, com largura e altura de 100%, garantindo que a imagem ainda seja exibida.

## Opções

Uso: `<fluid-img src="image.jpg" generator="random" max-carve-up-scale="5"></fluid-img>`

Por padrão, o gerador `random` é usado, pois é o mais rápido.

| Opção                          | Valores                          | Padrão       | Descrição                                                                                                              |
| ------------------------------ | -------------------------------- | ------------ | ---------------------------------------------------------------------------------------------------------------------- |
| `src`                          | URL                              |              | A URL da imagem a ser processada.                                                                                      |
| `generator`                    | `random`, `predictive`           | `predictive` | O gerador de seam carving a ser usado. `random` é mais rápido, porém com qualidade inferior.                           |
| `scaling-axis`                 | `horizontal`, `vertical`, `auto` | `horizontal` | O eixo para redimensionamento. `auto` escala horizontal ou verticalmente com base nas mudanças de proporção.           |
| `mask`                         | URL                              |              | A URL de uma imagem de máscara. Áreas pretas da máscara têm menor energia e são mais propensas a serem preservadas.    |
| `carving-priority`             | Número (0-1, ex.: `0.5`)         | `1`          | A porcentagem do redimensionamento a ser feita por seam carving vs. redimensionamento tradicional de imagem.           |
| `max-carve-up-seam-percentage` | Número (0-1, ex.: `0.5`)         | `0.6`        | A porcentagem máxima de seams a serem inseridas ao ampliar. Limita a criação de novas seams para preservar a qualidade.|
| `max-carve-up-scale`           | Número (ex.: `3`)                | `3`          | O fator máximo de ampliação usando seam carving. Acima disso, é usado o redimensionamento tradicional.                 |
| `max-carve-down-scale`         | Número (0-1, ex.: `0.7`)         | `0.7`        | A porcentagem máxima da imagem a ser removida por seam carving ao reduzir.                                             |
### Opções específicas do gerador

Opções específicas do gerador são adicionadas ao componente `<fluid-img>`, mas só são válidas quando o atributo
`generator` correspondente também está definido.

#### Opções do Gerador Aleatório & Preditivo

| Opção               | Valores                | Padrão  | Descrição                                          |
| ------------------- | ---------------------- | ------- | -------------------------------------------------- |
| `batch-percentage`  | Número (0-1, ex: 0.1)  | 0.1     | A porcentagem de seams a gerar por lote            |
| `min-batch-size`    | Número (ex: `10`)      | 10      | O número mínimo de seams a gerar por lote          |

## Como funciona

Seam carving é uma técnica de redimensionamento de imagem sensível ao conteúdo que remove ou adiciona pixels de forma inteligente, permitindo que uma imagem seja redimensionada sem distorcer o conteúdo importante. Para mais informações, consulte o [artigo da Wikipédia](https://en.wikipedia.org/wiki/Seam_carving) sobre o tema.

Historicamente, o seam carving era computacionalmente intensivo demais para uso em tempo real em navegadores web. No entanto, essa limitação pode ser superada usando algoritmos alternativos que são menos exigentes e funcionam bem em muitos cenários.

Existem duas implementações do gerador de seam carving:
### Entalhe Aleatório

A abordagem de entalhe de costura aleatória abandona o algoritmo tradicional de entalhe de costura, que é muito lento para execução em tempo real no navegador.

Em vez disso, ela gera um conjunto de costuras aleatórias que fornecem 100% de cobertura da imagem, conectando cada pixel em uma linha a um pixel vizinho na próxima. Em seguida, itera por cada costura, calcula sua energia e descarta um lote das costuras de menor energia. Este processo se repete até que o número desejado de costuras seja alcançado. Este método produz resultados surpreendentemente bons para muitas imagens.

### Entalhe Preditivo

Semelhante ao entalhe aleatório, este método gera um mapa de energia e cria costuras em lotes. Ele também gera um mapa de energia mínima para cada lote. A ideia central é criar tanto costuras “boas” quanto “ruins”. As costuras boas possuem baixa energia e são mantidas. As costuras ruins incorporam pixels de alta energia, permitindo que sejam filtradas posteriormente.

A partir da primeira linha, ele conecta pares de pixels a pares correspondentes na linha seguinte. A costura de menor energia do cálculo corrente é conectada à costura de menor energia do mapa de energia mínima.

O resultado é uma costura verdadeiramente ótima, muitas costuras “muito boas”, muitas costuras “muito ruins” e várias medianas. Selecionamos um lote das costuras “boas”, descartamos o restante e repetimos o processo.

##

## A FAZER

### Alta Prioridade

- [x] Componente web
- [x] Renderizador que recebe dados dos geradores e dimensiona para qualquer tamanho
- [x] Gerador aleatório
- [x] Entalhe vertical
- [x] Gerador preditivo
- [ ] Web workers para todos os geradores
### Baixa Prioridade

- [x] Mascaramento
- [ ] Reconhecimento facial

### Sonho Distante

- [ ] Entalhe 2D

## Licenciamento

Este software está licenciado sob a Licença Fluid-Img com Limite de Receita.

**Uso gratuito** para indivíduos e organizações com receita bruta anual inferior a $10.000.000 USD.

**Licença comercial obrigatória** para organizações com receita anual de $10M ou mais. Contate [licensing@voice.ngo] para termos de licenciamento comercial.

Veja o arquivo [LICENSE](./LICENSE) para os termos completos.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---