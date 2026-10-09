# Site de código C#

Recursos publicados: operadores e condições, seleção e ciclos, métodos e parâmetros.

- `index.html`: índice pesquisável com 29 recursos.
- `solucoes/`: páginas dos exemplos e exercícios com soluções.
- `codigo/`: programas completos nas versões `_manual.cs` e `_online.cs`.
- `assets/`: apresentação e JavaScript partilhados.

## Utilizar os programas

No Visual Studio, usar a versão do manual num projeto de consola moderno com instruções de nível superior. Em métodos e parâmetros, as funções locais são `static`.

No site, selecionar a versão online e clicar em **Copiar versão online**. Depois clicar em **Abrir no OnlineGDB**, em https://www.onlinegdb.com/online_csharp_compiler. Manter **C# (mono)**, substituir todo o conteúdo inicial de `main.cs` pelo código copiado e clicar em **Run**. Abrir o editor não transfere o código automaticamente.

Em **Interactive Console**, escrever cada resposta e premir Enter. Em **Text**, fornecer previamente todos os dados, um por linha. Nos menus, incluir a opção `0` no fim. Nas leituras repetidas, depois de entradas inválidas, fornecer um valor válido; caso contrário, o programa continua a pedir dados.

A versão online usa `Program`, `Main` e métodos `static` da classe, preservando o comportamento da versão do manual.

## Testar localmente

Servir esta pasta por HTTP local e abrir `index.html`. Verificar pesquisa, mudança de versão, cópia, descarregamentos e ligações.

## Publicar no GitHub Pages

Repositório: https://github.com/AndresFerrerPestana/csharp-recursos

Publicação a partir de `main`, pasta `/ (root)`, em **Settings > Pages**. Antes de publicar, verificar `git status`, obter alterações com `git fetch origin` e integrá-las sem eliminar trabalho local. Adicionar ao commit apenas os ficheiros ativos necessários de `index.html`, `assets/`, `solucoes/`, `codigo/` e esta documentação. Não usar `git add .`: pastas históricas, ZIPs, DOCX e temporários não pertencem à publicação. Não usar `push --force`.

Os projetos locais da Sessão 4 ficam em `03_Sessoes/Sessao_04_Metodos_Parametros`, fora deste repositório: exemplos em `05_Exemplos_Codigo`, enunciados em `06_Exercicios` e soluções em `07_Solucoes_Formador`.

## Endereço público

https://andresferrerpestana.github.io/csharp-recursos/
