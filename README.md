# estudo-dotnet-core-8

Seção #1: Conceitos Gerais

1.1. Introdução
	=> Visão geral do ecossistema de desenvolvimento das APIs .Net Core;
	=> As APIs eram usadas para acessar aplicações via sistemas desktop;
	=> As Redes fizeram com que um dispositivo fosse acessado por muitos:
		-> O acesso era concedido por APIs de maneira uniforme.
	=> A Internet originou os Web Services: APIs fornecidas via Internet:
		-> Elas integraram sistemas de diversas tecnologias.
	=> REST API é um Web Service mais ágil e flexível em construção e uso:
		-> Usam Protocolo HTTP, o mais usado na Internet atualmente.
	=> Web APIs são APIs na Internet acessíveis por muitas tecnologias:
		-> Podem usar o Protocolo SOAP ou seguir a arquitetura REST.
	=> API RESTful é uma Web API que segue os princípios do padrão REST;
	=> As Web APIs .Net Core são as criadas com o framework da Microsoft;
		-> Favorece a construção de APIs RESTful;
		-> Utiliza Protocolo de comuniação HTTP;
		-> Provê muitas outras funcionalidades.

1.2. Conceitos: API, Web Services e Web API
	=> API: Application Programming Interface
		-> Conjunto de rotinas e padrões estabelecidos para o uso de uma aplicação;
		-> São documentados para que possam ser usados por outras aplicações;
		-> Através delas, não é necessário conhecer detalhes de implementação.
		-> Vantagens:
			1) Permitem a integração de sistemas;
			2) Facilitam o intercâmbio de informações;
			3) Oferecem maior segurança dos dados;
			4) Permitem fazer controle de acesso;
			5) Fáceis de implementar e usar.
		-> Eram utilizadas localmente para integrar aplicações numa mesma máquina;
		-> Depois foram utilizadas para integrar aplicações numa mesma rede;
		-> Com a Internet, é utilizada para integrar aplicações a nível global.
		-> Podem ser classificadas em dois tipos:
			1) Públicas: De acesso geral (Facebook, PayPal, NasaAPI);
			2) Privadas: Escopo de acesso restrito.
	=> Web Services: A popularização das APIs
		-> Conjunto de métodos invocados por outras aplicações via Web;
		-> Solução utilizada para integrar aplicações a nível global;
		-> Foi a forma de popularizar APIs com foco na Internet;
		-> Características:
			1) Apoiados no XML e no Protocolo SOAP;
			2) Permitem a integração de sistemas;
			3) Permitem a reutilização de código;
			4) Desenvolvidos em tempo reduzido;
			5) Apresentam maior segurança.
	=> API x Web Service
		-> APIs:
			- Não são necessariamente Web Services;
			- Usam qualquer meio de comunicação;
			- São de código aberto;
			- São utilizadas de qualquer lugar;
			- Realizam todas as operações de um Web Service;
			- Podem ter arquitetura leve para bandas curtas;
			- Não necessita de uma rede para funcionar;
			- Tendem a serem abertas para qualquer um.
		-> Web Services:
			- São APIs;
			- Usam apenas três meios de comunicação: SOAP, REST e XML-RPC;
			- São autocontidas e autodescritivas em suas funcionalidades;
			- São publicadas, localizadas e invocadas via Web;
			- Não realiza todas as operações de uma API;
			- Requerem um Protocolo SOAP trocar dados;
			- Não têm arquitetura leve;
			- Necessita de uma rede para seu funcionamento;
			- Tendem a oferecer funcionalidades para usuários específicos.
	=> Web API: A evolução dos Web Services
		-> Conjunto de serviços na Web para integrar diversos clientes;
		-> Características:
			1) Podem ser criadas com diversas tecnologias;
			2) Respondem em formatos específicos: XML, JSON e TXT;
			3) Podem ser acessadas usando o Protocolo HTTP;
			4) Podem responder com multimídia.
		-> Exemplos: Google APIs, Instagram, Twitter, YouTube;
		-> Podem ser implementadas com SOAP ou seguindo o REST.
		
1.3. Conceitos: SOAP, REST, ASP.NET Core Web API
	=> SOAP: Simple Object Access Protocol
		-> Protocolo mantido pela W3C baseado em XML;
		-> Usado para trocar informações entre aplicações;
		-> As aplicações podem ser do mesmo ou de sistemas diferentes;
		-> Características:
			- Todas as mensagens seguem o mesmo formato;
			- É independente de protocolo e devem retornar XML;
			- Os retornos das requisições não podem ser postos em cache.
	=> REST: Representational State Transfer Protocol
		-> Estilo arquitetural sem estado;
		-> Conjunto coordenado de restrições arquiteturais;
		-> Aplicado a componentes, conectores e elementos de sistemas;
		-> Opera sobre dentro de sistemas de hipermídia distribuídos;
		-> São princípios que atendem a necessidade de performance;
		-> Características:
			- Cada entidade é vista como um recurso acessível;
			- O acesso a estes recursos é via interface;
			- A comunicação é feita via Protocolo HTTP;
			- Métodos GET, POST, PUT e DELETE.
		-> Pode usar outros Protocolos no lugar do HTTP.
	=> SOAP x REST:
		-> SOAP:
			- É um protocolo de comunicação entre cliente e provedor;
			- Usa a linguagem WSDL (Web Services Description Language);
			- Geralmente, precisa de mais largura de banda para seu uso;
			- Trabalha praticamente com o formato XML para se comunicar;
			- É independente de protocolo (HTTP, SMTP, TCP, IMS, etc.);
			- Invoca os serviços usando Remote Procedure Call.
		-> REST:
			- É um estilo arquitetural;
			- Usa JSON e XML para trocar dados;
			- Não necessita de tanta largura de banda;
			- Trabalha com diferentes formatos de resposta;
			- Verbos GET, POST, PUT e DELETE para acessar serviços;
			- Invoca os serviços através de uma URI.
	=> ASP.NET Core
		-> Framework da Microsoft para criar Web APIs:
		-> As Web APIs criadas são aderentes ao estilo REST;
		-> Permite a criação de seus serviços com a linguagem C#;
		-> Utiliza Controladores para tratar as solicitações;
		-> Podem usar as Minimal APIs para tratar as solicitações;
		-> As APIs podem ser criadas em um único arquivo para leveza.
	=> API RESTful
		-> APIs quesão aderentes ao estilo arquitetural REST:
			- Possui arquitetura Cliente-Servidor;
			- Não possuir estado;
			- Ter uma interface uniforme.
	=> ASP.NET Core Web API
		-> Web APIs RESTful criadas na Plataforma .NET Core;
		-> Construídas para sistemas Windows, Linux e MacOS;
		-> Montadas com as IDEs Visual Studio 2022/Code e NET CLI;
		-> Utilizando verbos HTTP GET, POST, PUT e DELETE para CRUD;
		-> As Web APIs RESTful criadas são robustas e de alto desempenho.

1.4. REST
	=> É um estilo arquitetural para a concepção de sistemas distribuídos;
	=> Não é um padrão ou tecnologia, mas sim um conjunto de regras e restrições;
	=> Principais restrições:
		-> Ter um relacionamento cliente/servidor;
		-> Não possuir monitoração de status;
		-> Possuir uma interface que seja uniforme:
			- Representações URI (Uniform Resource Identifiers);
			- Mensagens que sejam auto-descritivas;
			- Hipermídia (hiperlinks e hipertexto).
		-> Suportar o cache de dados e respostas;
		-> Suportar um sistema em camadas.
	=> Arquitetura Cliente/Servidor:
		-> Recurso: Abstrai por meio da URI o que uma API dispõe;
		-> Representação: É a resposta obtida através do Recurso;
		-> Stateless: A comunicação sempre contém os dados necessários;
		-> Mensagens: Autodescritivas, por meio dos verbos GET, POST, etc.
	=> Uma API RESTful adere ao REST;
	=> Os recursos são definidos na criação:
		-> Todos os livros cadastrados;
		-> Um livro cadastrado;
		-> Todos os livros de um autor.
	=> Os recursos definidos são mapeados via URI:
		-> api/biblioteca/livros
		-> api/biblioteca/livros/1
		-> api/biblioteca/autor/1/livros
	=> Recursos são requisitados via verbos HTTP;
	=> As requisições são respondidas com um código status;
	=> Com o status de uma operação, é possível saber o seu sucesso:
		-> 1XX para códigos informativos;
		-> 2XX para códigos de sucesso;
		-> 3XX para redirecionamento;
		-> 4XX para erros do cliente;
		-> 5XX para erros no servidor.

1.5. HTTP
	=> O Protocolo HTTP é usado na comunicação entre os Clientes e as Web APIs;
	=> O Cliente abre um Web Socket e envia requisições que serão respondidas;
	=> As requisições servem para acessar e manipular os recursos da Web API;
	=> As requisições são enviadas via Uniform Resource Identifier (URI);
	=> Uma requisição HTTP é dividida em três partes que distintas:
		-> Request Line: Método HTTP + URI + Protocolo HTTP;
			- Método: Ação;
			- URI: Recurso;
			- Protocolo: Versão.
		-> Headers: Metadados contendo informações;
			- Host, Cache-Control, Accept, Authorization.
		-> Body: Informação adicional e opcional enviada:
			- Texto, HTML, JSON, etc.
	=> Uma resposta HTTP também é dividida em três partes:
		-> Status Line: O código do status da requisição;
		-> Headers: Metadados contendo informações;
		-> Body: Dados opcionais enviados pelo servidor.
		
1.6. Métodos HTTP
	=> Usados para consumir os recursos de uma Web API RESTful;
	=> GET: Usado para recuperar informações inerentes ao recurso:
		-> É um método seguro, pois não altera o estado do recurso;
		-> É idempotente, produzindo o mesmo resultado se repetido;
		-> Possíveis códigos de retorno: 200 OK, 404 NOT FOUND.
	=> POST: Usado para criar um novo recurso contendo suas informações:
		-> Não é um método seguro, pois altera o estado do recurso;
		-> Não é idempotente, não produzindo o mesmo resultado se repetido;
		-> Possíveis retornos: 201 CREATED, 400 BAD REQUEST.
	=> PUT: Usado par atualizar uma informação e atualizar o recurso:
		-> Não é um método seguro, pois altera o estado do recurso;
		-> É idempotente, não produzindo o mesmo resultado se repetido;
		-> Possíveis retornos: 200 OK ou 204 NO CONTENT, 404 NOT FOUND.
	=> DELETE: Usado para uma informação e excluir o recurso referido;
		-> Não é um método seguro, pois altera o estado do recurso;
		-> É idempotente, produzindo o mesmo resultado de repetido;
		-> Possíveis retornos: 200 OK, 404 NOT FOUND.

1.7. HTTPS e HSTS
	=> HyperText Transfer Protocol Secure é uma extensão segura do HTTP;
	=> É implementado sobre a Transport Layer Security, uma camada segura:
		-> É um protocolo que substitui o Protocolo SSL - Secure Sockets Layer;
		-> Permite a comunicação criptografada entre um site e um navegador;
	=> Os sites que configurarem o certificado TLS podem usar o HTTPS;
	=> Seu objetivo é tornar segura a tranmissão de informações sensíves:
		-> Dados pessoais, dados de pagamento e logins de entrada.
	=> O uso do HTTPS pode ser definido no projeto .NET Core via Middlewares:
		-> O método UseHttpsRedirection redireciona as requisições HTTP para HTTPS.
	=> A API pode orientar os navegadores a utilizarem o HTTPS para acessá-las:
		-> O método UseHsts envia a instrução no Header com a chave Strict-Transport-Security.
	=> Em aplicações MVC, o atributo RequireHttps é usado, mas não deve ser usado em Web APIs:
		-> Ele é usado para redirecionar HTTP para HTTPS, mas não protege a informação enviada.
	=> As Web APIs seguras rejeitam requisições HTTP, utilizando somente HTTPS.

1.8. JSON (JavaScript Object Notation)
	=> É um formato de troca de dados simples e rápida entre sistemas;
	=> É compacto, leve, legível e de pradrão aberto independente;
	=> A utilização de seu formato se baseia em chave-valor;
	=> O seu formato lembra muito o formato em XML:
		-> É hierárquico: Valores dentro de valores;
		-> Pode ser analisado pelo JavaScript;
		-> É auto-descritivo e legível;
		-> É texto em formato simples.
	=> Mas ele é diferente do XML:
		-> Não usa tag de fechamento;
		-> É mais curto e simples;
		-> Leitura e escrita rápidas;
		-> Faz o uso de arrays;
		-> Não tem palavras reservadas;
		-> Possuem parsers nas principais linguagens.
	=> Possui suas prórias regras de sintaxe:
		-> É definido por pares Chave:Valor;
		-> Dados separados por vírgulas;
		-> As chaves contém objetos;
		-> Os colchetes expressam arrays.
	=> Valores que podem ser usados:
		-> Números inteiros ou pontos flutuantes;
		-> Strings, booleanos, arrays, objetos e nulo.
	=> Em suma, é o formato mais utilizado pelas Web APIs;
	=> Ferramentas para trabalhar com a notação JSON:
		-> JSON Editor Online: Permite editar e validar JSONs;
		-> JSON 2 Csharp: Obter uma classe C# a partir de um JSON.
	=> Utilizando a notação JSON dentro das Web APIs ASP .NET Core:
		-> Com a classe HttpClient, são enviadas as requisições HTTP;
		-> A classe interage com os recuros através dos métodos HTTP;
		-> Principais métodos: GetAsync, PostAsync, PutAsync e DeleteAsync;
		-> Eles armazenam em buffer as respostas do servidor antes de retorná-las;
		-> Dentro destas respostas, todo o corpo da resposta é lido pela aplicação;
		-> Os métodos são thread safe, não gerando assim problemas de concorrência;
		-> A HttpClient tem métodos de extensão para receber e enviar JSON;
		-> Principais métodos: GetFromJsonAsync, PostAsJsonAsync, PutAsJsonAsync;
		-> O código fica mais legível tendo com operações usando JSON;
	=> A .NET Core contém classes para serialização de JSON:
		-> Elas convertem objetos em strings representando JSON;
		-> Elas também desserializam JSON em objetos C#.

1.9. Níveis de Maturidade de Richardson
	=> O REST para o acesso e a manipulação de dados remotos;
	=> As Web APIs RESTful são consideradas mais maduras;
		-> Oferecem facilidade, flexibilidade e ineroperabilidade.
	=> Os desenvolvedores mais puristas seguem o REST à risca;
	=> Os pragmáticos ignoram algumas regrase implementam outras;
	=> O modelo de Richardson ajuda a classificar este nível de maturidade;
	=> As APIs são classificadas em quatro níveis de aderência ao REST;
	=> A maturidade é baseada em: Recursos/URI, Verbos HTTP e Hipermídia;
	=> Nível 0 - Plain Old XML Swamp: Menor nível de conformidade:
		-> Protocolo HTTP usado apenas para transportar dados;
		-> Expõe apenas um único endpoint para todo o aplicativo;
		-> Os Verbos HTTP não são utilizados corretamente;
		-> Não existe retorno com código de status.
	=> Nível 1 - URI (Uniform Resource Identifier)
		-> Recursos baseados em múltiplas URI;
		-> Os Verbos HTTP ainda são usados incorretamente;
		-> O corpo da requisição usado para carregar as informações.
	=> Nível 2 - Utilização dos Verbos HTTP com Resource URI:
		-> Os códigos de status são usados de forma correta;
		-> O corpo da requisição não carrega metadados.
	=> HATEOAS (HyperText As The Engine Of Application State):
		-> Diz o que é possível fazer após uma requisição no recurso.

1.10. Injeção de Dependência - Introdução
	=> Técnica para tornar uma classe independente de suas dependências;
	=> É um padrão para implementar a Inversão de Controle (IoC);
	=> Seu objetivo é a redução do acoplamento entre os objetos;
	=> Sua aplicação faz um objeto fornecer as dependências de outro;
	=> Exemplo ilustrando uma classe Cliente com forte acomplamento:
		-> Ela depende da classe Pedido e precisa saber como criá-la;
		-> Dependendo da classe Pedido, acaba dependendo de suas dependências;
		-> Qualquer mudança na classe Pedido afeta a classe Cliente;
		-> Isso viola o Princípio SOLID da Responsabilidade Unica:
			- Ela não só tem que obter os pedidos, mas criara  sua instância.
		-> Testes unitários em classes muito acopladas são problemáticos.
	=> Deve-se retirar de uma classe a responsabilidade de criar outras;
	=> O controle na classe dependente é invertido para esta retirada;
	=> Outra classe torna-se responsável por criar esta instância;
	=> A criação de novas instâncias sempre deve ser delegada;
	=> Através de uma abstração, a criação das instâncias é feita;
	=> As demais classes passam a depender apenas desta instância; 
	=> O Princípio da Inversão de controle prega as seguintes premissas:
		-> Delegar a tarefa de criação de um objeto a uma outra entidade;
		-> Reduzir o acoplamento e minimizar as dependências entre objetos.
	=> Uma classe não deve depender da implementação de outra classe;
	=> Em vez disso, uma abstração deve ser criada para esta classe;
	=> As classes deverão depender apenas desta abstração criada;
	=> Esta abstração poderá ser outra classe ou interface;
	=> Na plataforma .NET Core possui um Container DI nativo:
		-> Ele fornece a instância da classe através das interfaces;
		-> Basta configurar a classe neste container para tanto.
		
1.11. Injeção de Dependência - Tempo de Vida
	=> Inversão de Controle é um princípio que promove o baixo acoplamento;
	=> Inversão de Dependência é um princípio para minimizar dependências;
	=> Injeção de Dependência é um padrão de projeto que aplica a IoC;
	=> IoC Container é um framework que gerencia as injeções de dependências;
	=> Os princípios fornecem diretrizes para o objetivo, sem detalhes;
	=> Os padrões fornecem soluções de baixo nível para as implementações;
	=> Os frameworks realizam a solução dentro da implementação do projeto;
	=> A plataforma .NET Core possui um framework de Injeção de Dependência;
		-> A interface IServiceCollection registra as dependências usadas;
	=> Existe, porém, outros containeres que não sejam nativos da plataforma;
	=> Quem usa Injeção de Dependência precisa conhecer sobre tempo de vida;
	=> Cada serviço injetado tem o seu próprio tempo de vida na aplicação;
	=> Este tempo de vida controla a existência da dependência no container;
		-> Este tempo de vida gera impactos no desempenho da aplicação.
	=> O tempo de vida dos serviços pode ser registrado em três segmentos:
		-> Transient: Os serviços criados cada vez que são solicitados:
			- Toda vez que for injetado, sua instância será diferente;
			- Ideal para serviços mais leves e que não tenham estado.
		-> Scoped: Os serviços são criados para cada request solicitada:
			- Indicado para aplicações Web. A instância muda a cada request;
			- Bom quando a instância é usada em muitos lugares na request;
			- A mesma alocação de memória será usada para esta instância.
		-> Singleton: Duram o mesmo tempo de vida útil de toda aplicação.

-----

Seção #2: Ambiente e Recursos

2.1. Apresentação
	=> Atualizações da plataforma .NET Core
		-> O curso foi dado com .Net Core 3.1;
		-> O .NET 5 unificou a plataforma .NET;
		-> Depois vieram o .NET 6, .NET 7 e .NET 8.
	=> Houveram alterações nos templates e na estrutura;
	=> Mas não houve grandes alterações na forma de construir;
	=> A partir do .NET 5, uma nova versão passou a ser anual;
	=> O curso terá uma segmentação com base nos tópicos abaixo:
		-> .NET 8, a nova atualização da plataforma unificada;
		-> ASP .NET Core 8 para a criação de Web APIs;
		-> Instalação das IDEs Visual Studio 2022 e Code;
		-> Instalação das ferramentas MySQL e do MySQL Workbench;
		-> Apresentação de template para montar Web APIs .NET;
		-> Conceito e criação das Minimals APIs em .NET Core;
		-> Migração de versões anteriores para a versão .NET 8.

2.2. Ambiente
	=> Para sistemas Windows:
		-> A plataforma .NET 8;
		-> Editor VS 2022 Community;
		-> MySQL como banco de dados;
		-> MySQL Workbench para gerenciamento.
	=> Ambiente do .NET 8 instalado:
		-> Suporte ao .NET 8;
		-> Suporte ao EF Core 7;
		-> Suporte à linguagem C#;
		-> Framework Web MVC e APIs;
		-> Swagger de documentação;
		-> Postman para consultas.

2.3. NET 8 - Instalação
	=> A SDK do .NET 8 encontra-se no site da Microsoft;
	=> Ela dá suporte ao C#, ao ASP.NET Core e ao EF Core;

