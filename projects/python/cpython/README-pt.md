Esta é a versão 3.15.0 alpha 0 do Python
========================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: Status de compilação do CPython no GitHub Actions
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: Status de compilação do CPython no Azure DevOps
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Chat do Python Discourse
   :target: https://discuss.python.org/


Copyright © 2001 Python Software Foundation.  Todos os direitos reservados.

Veja o final deste arquivo para mais informações sobre direitos autorais e licença.

.. contents::

Informações Gerais
------------------

- Website: https://www.python.org
- Código fonte: https://github.com/python/cpython
- Rastreador de issues: https://github.com/python/cpython/issues
- Documentação: https://docs.python.org
- Guia do Desenvolvedor: https://devguide.python.org/

Contribuindo para o CPython
---------------------------

Para instruções mais completas sobre como contribuir para o desenvolvimento do CPython,
veja o `Guia do Desenvolvedor`_.

.. _Guia do Desenvolvedor: https://devguide.python.org/

Usando o Python
---------------

Kits instaláveis do Python, e informações sobre como usar o Python, estão disponíveis em
`python.org`_.

.. _python.org: https://www.python.org/

Instruções de Compilação
------------------------

Em Unix, Linux, BSD, macOS e Cygwin::

    ./configure
    make
    make test
    sudo make install

Isto irá instalar o Python como ``python3``.

Você pode passar várias opções para o script configure; execute ``./configure --help``
para saber mais. Em sistemas de arquivos case-insensitive do macOS e no Cygwin,
o executável é chamado de ``python.exe``; em outros lugares é apenas ``python``.

Compilar uma instalação completa do Python requer o uso de várias
bibliotecas de terceiros adicionais, dependendo da sua plataforma de compilação e
opções de configuração. Nem todos os módulos da biblioteca padrão podem ser compilados ou
usados em todas as plataformas. Consulte a seção
`Instalar dependências <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
do `Guia do Desenvolvedor`_ para informações detalhadas e atualizadas sobre
dependências para várias distribuições Linux e macOS.

No macOS, há opções adicionais de configuração e compilação relacionadas
ao framework do macOS e builds universais. Consulte `Mac/README.rst
<https://github.com/python/cpython/blob/main/Mac/README.rst>`_.

No Windows, veja `PCbuild/readme.txt
<https://github.com/python/cpython/blob/main/PCbuild/readme.txt>`_.

Para construir o instalador do Windows, veja `Tools/msi/README.txt
<https://github.com/python/cpython/blob/main/Tools/msi/README.txt>`_.

Se desejar, você pode criar um subdiretório e invocar o configure a partir dele.
Por exemplo::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

(Isto irá falhar se você *também* compilou no diretório de nível superior. Você deve fazer
um ``make clean`` no diretório de nível superior primeiro.)

Para obter uma compilação otimizada do Python, use ``configure --enable-optimizations``
antes de executar o ``make``. Isso configura os alvos padrão do make para ativar
a Otimização Guiada por Perfil (PGO) e pode ser usado para ativar automaticamente a
Otimização em Tempo de Linkagem (LTO) em algumas plataformas. Para mais detalhes, veja as seções
abaixo.

Otimização Guiada por Perfil (PGO)
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO aproveita as versões recentes dos compiladores GCC ou Clang. Se usada,
seja via ``configure --enable-optimizations`` ou executando manualmente
``make profile-opt`` independentemente das flags de configuração, o processo de compilação otimizada
executará as seguintes etapas:

Todo o diretório do Python é limpo de arquivos temporários que podem ter sido
gerados por uma compilação anterior.

Uma versão instrumentada do interpretador é construída, usando flags de compilador
adequadas para cada variante. Note que esta é apenas uma etapa intermediária.
O binário gerado nesta etapa não é adequado para cargas de trabalho reais, pois possui
instruções de perfilamento embutidas.

Após a construção do interpretador instrumentado, o Makefile executará uma carga de trabalho de treinamento.
Isso é necessário para perfilar a execução do interpretador.
Note também que qualquer saída, tanto stdout quanto stderr, que possa aparecer nesta etapa
é suprimida.

A etapa final é compilar o interpretador real, usando as informações
coletadas da versão instrumentada. O resultado final será um binário do Python
otimizado; adequado para distribuição ou instalação em produção.


Otimização em Tempo de Linkagem (LTO)
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Ativada via flag ``--with-lto`` do configure. O LTO aproveita
a capacidade das toolchains de compiladores recentes de otimizar através da
fronteira arbitrária de arquivos ``.o`` ao compilar executáveis finais ou bibliotecas
compartilhadas para ganhos adicionais de desempenho.


Novidades
---------

Temos uma visão geral abrangente das mudanças no documento `O que há de novo no Python
3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_. Para um log de mudanças mais
detalhado, leia `Misc/NEWS
<https://github.com/python/cpython/tree/main/Misc/NEWS.d>`_, mas um relato
completo das mudanças só pode ser obtido a partir do `histórico de commits
<https://github.com/python/cpython/commits/main>`_.

Se você deseja instalar múltiplas versões do Python, veja a seção abaixo
intitulada "Instalando múltiplas versões".


Documentação
------------

`Documentação para o Python 3.15 <https://docs.python.org/3.15/>`_ está online,
atualizada diariamente.

Ela também pode ser baixada em vários formatos para acesso mais rápido. A documentação
pode ser baixada nos formatos HTML, PDF e reStructuredText; esta última versão
é voltada principalmente para autores de documentação, tradutores e pessoas com necessidades
especiais de formatação.

Para informações sobre como compilar a documentação do Python, consulte `Doc/README.rst
<https://github.com/python/cpython/blob/main/Doc/README.rst>`_.


Testes
------

Para testar o interpretador, digite ``make test`` no diretório de nível superior. O
conjunto de testes produz alguma saída. Geralmente, você pode ignorar as mensagens sobre
testes pulados devido a recursos opcionais que não podem ser importados. Se uma mensagem
for impressa sobre um teste falhado, ou se for gerado um traceback ou core dump,
há algo errado.

Por padrão, os testes são impedidos de usar excessivamente recursos como espaço em disco e
memória. Para habilitar esses testes, execute ``make buildbottest``.

Se algum teste falhar, você pode rodar novamente o(s) teste(s) com falha em modo verboso. Por
exemplo, se ``test_os`` e ``test_gdb`` falharam, você pode executar::

    make test TESTOPTS="-v test_os test_gdb"

Se a falha persistir e parecer ser um problema do Python em vez do
seu ambiente, você pode `abrir um relatório de bug
<https://github.com/python/cpython/issues>`_ e incluir a saída relevante desse
comando para mostrar o problema.

Veja `Executando & Escrevendo Testes <https://devguide.python.org/testing/run-write-tests.html>`_
para mais informações sobre como executar testes.

Instalando múltiplas versões
----------------------------

Em sistemas Unix e Mac, se você pretende instalar múltiplas versões do Python
usando o mesmo prefixo de instalação (argumento ``--prefix`` para o script configure)
você deve se certificar de que seu executável python principal não será
sobrescrito pela instalação de uma versão diferente. Todos os arquivos e
diretórios instalados usando ``make altinstall`` contêm a versão principal e secundária e, portanto,
podem coexistir. ``make install`` também cria
``${prefix}/bin/python3``, que se refere a ``${prefix}/bin/python3.X``. Se você
pretende instalar múltiplas versões usando o mesmo prefixo, deve decidir qual
versão (se houver) será sua versão "principal". Instale essa versão usando
``make install``.  Instale todas as outras versões usando ``make altinstall``.

Por exemplo, se você deseja instalar Python 2.7, 3.6 e 3.15, sendo 3.15 a
versão principal, você deve executar ``make install`` no diretório de build do 3.15
e ``make altinstall`` nos outros.


Cronograma de Lançamento
------------------------

Veja `PEP 790 <https://peps.python.org/pep-0790/>`__ para detalhes do lançamento do Python 3.15.


Informações de Direitos Autorais e Licença
------------------------------------------


Copyright © 2001 Python Software Foundation. Todos os direitos reservados.

Copyright © 2000 BeOpen.com. Todos os direitos reservados.

Copyright © 1995-2001 Corporation for National Research Initiatives. Todos
os direitos reservados.

Copyright © 1991-1995 Stichting Mathematisch Centrum. Todos os direitos reservados.

Consulte o `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_ para
informações sobre o histórico deste software, termos e condições de uso, e um
AVISO DE ISENÇÃO DE TODAS AS GARANTIAS.

Esta distribuição do Python não contém *nenhum* código sob a Licença Pública Geral GNU (GPL),
portanto pode ser usada em projetos proprietários. Existem interfaces para algum código GNU,
mas estas são totalmente opcionais.

Todas as marcas comerciais aqui referenciadas são propriedade de seus respectivos detentores.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---