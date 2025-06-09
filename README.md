Explicarei aqui o uso do SOLID:
S - Single Responsibility Principle: foi aplicado nas classes, já que uma classe deve ter apenas um motivo para mudar, ou seja, uma única responsabilidade

O - Open/Closed Principle: foi aplicado nos componentes IDescontoStrategy e IRepository
IDescontoStrategy	Permite criar novas estratégias de desconto (por categoria, por quantidade) sem modificar o código existente, já o IRepository faz com que cada repositório (ClienteRepository, ProdutoRepository, etc.) implementa sua própria versão sem alterar a interface.

L — Liskov Substitution Principle: foi aplicado nas classes DescontoPorCategoria e DescontoPorQuantidade que substituem IDescontoStrategy sem quebrar funcionalidade, também os repositórios implementam IRepository corretamente.

I — Interface Segregation Principle: foi aplicado em IDescontoStrategy que	apenas define CalcularDesconto, IRepository que apenas define os métodos necessários para acesso básico (Adicionar, ObterPorId, ObterTodos) e ILogService que	define só LogInfo, sem forçar
logging desnecessário.

D — Dependency Inversion Principle: foi aplicado em PedidoService que	recebe IDescontoStrategy e ILogService por injeção, e o Main (Program.cs)	que instancia e injeta concretamente as dependências no início da aplicação.



