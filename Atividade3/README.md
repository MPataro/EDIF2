# Atividade 3

ATIVIDADE REALIZADA POR:

    - MIGUEL DA SILVA PATARO
    - JOÃO VITOR PEDRAL


UTILIZE O DIAGRAMA DE CLASSES APRESENTADO À SEGUIR PARA DESENVOLVER UMA APLICAÇÃO COM AS OPÇÕES ABAIXO:

***

### Diagrama de classes


| Data                                       |
|--------------------------------------------|
| - dia: int                                 |
| - mes: int                                 |
| - ano: int                                 |
|--------------------------------------------|
| + setData(int dia, int mes, int ano): void |
| + ToString(): String (override)</br>-> retornando "dd/mm/aaaa" |


| Telefone                                   |
|--------------------------------------------|
| - tipo: string                             |
| - numero: string                           |
| - principal: bool                          |


| Contato                               |
|---------------------------------------|
| - email: string                       |
| - nome: string                        |
| - dtNasc: Data                        |
| - telefones: List<Telefone>           |
|---------------------------------------|
| + getIdate(): int                     |
| + adicionarTelefone(Telefone t): void |
| + getTelefonePrincipal(): string      |
| + ToString(): String (override) </br> -> retornando uma string com </br>todos os dados do contato </br>(considerando o telefone         principal)                       |
| + Equals(object obj): bool (override) |


| Contatos                              |
|---------------------------------------|
| - agenda: List<Contato> (readOnly)    |
|---------------------------------------|
| + adicionar(Contato c): bool          |
| + pesquisar(Contato c): Contato       |
| + alterar(Contato c): bool            |
| + remover(Contato c): bool            |

***

### Opções no seletor:
 
Implementar construtores, getter's e setter's (ou as respectivas Propriedades).
OBSERVAÇÕES:

O PROJETO DEVERÁ SER DESENVOLVIDO EM C# CONSOLE APPLICATION, OFERECENDO AS SEGUINTES OPÇÕES PARA O USUÁRIO:

0. Sair             
1. Adicionar contato
2. Pesquisar contato
3. Alterar contato  
4. Remover contato  
5. Listar contatos  