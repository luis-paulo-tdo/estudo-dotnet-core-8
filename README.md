# Curso Web API ASP .NET Core Essencial (.NET 8)

Curso lecionado pelo professor Jose Carlos Macoratti que apresenta conceitos essenciais para criação de Web APIs na plataforma .NET.

## 1. Conceitos Gerais

Apresentação dos conceitos gerais em torno das APIs, Web Services e das tecnologias ASP.NET para a construção de Web APIs.

### 1.1. Introdução
- Visão geral do ecossistema de desenvolvimento das APIs .Net Core.
- As APIs eram usadas para acessar aplicações via sistemas desktop.
- As Redes fizeram com que um dispositivo fosse acessado por muitos:
	- O acesso deste dispositivo era concedido por APIs mais uniformes.
- A Internet originou os Web Services: APIs fornecidas via Internet:
	- Elas integraram sistemas implementados em diversas tecnologias.
- REST API é um Web Service mais ágil e flexível em construção e uso:
	- Usam Protocolo HTTP, aquele que é mais usado na Internet atualmente.
- Web APIs são APIs na Internet acessíveis por muitas tecnologias:
	- Podem usar o Protocolo SOAP ou seguir a arquitetura REST.
- API RESTful é uma Web API que segue os princípios do REST.
- As Web APIs .Net Core são as criadas com o framework da Microsoft.
	- O framework favorece a construção e execução de APIs RESTful.
	- É feita a utilização estensa do Protocolo de comuniação HTTP.
	- Provê muitas outras funcionalidades como depuração e portabilidade.

### 1.2. Conceitos: API, Web Services e Web API
- API: Sigla para Application Programming Interface
	- Conjunto de rotinas e padrões estabelecidos.
	- São documentados para uso de outras aplicações.
	- Através delas, não é necessário conhecer a implementação.
	- O seu uso apresenta uma série de vantagens no desenvolvimento:
		1. Permitem a integração de sistemas através da padronização.
		2. Facilitam o intercâmbio de informações com a integração.
		3. Oferecem maior segurança dos dados via autenticação.
		4. Permitem fazer controle de acessos via autorização.
		5. Fáceis de implementar e usar por conta da padronização.
	- Eram usadas para integrar aplicações na mesma máquina.
	- E depois usadas para integrar aplicações na mesma rede.
	- Com a Internet, são usadas para integrar aplicações globalmente.
	- As APIs podem ser ter uma classificação de dois tipos:
		1. Públicas: De acesso geral (Facebook, PayPal, NasaAPI).
		2. Privadas: Escopo de acesso restrito. Usadas pela aplicação.
- Web Services: A popularização das APIs dentro da Internet:
	- Conjunto de métodos invocados por outras aplicações Web.
	- Solução utilizada para integrar aplicações a nível global.
	- Foi a forma de popularizar APIs com foco na Internet.
	- Apresenta as principais características a seguir:
		1. São apoiadas no código XML e no Protocolo SOAP.
		2. É usada para permitir a integração de sistemas.
		3. Sua abordagem permite a reutilização de código.
		4. Seu desenvolvimento tem uma redução de tempo.
		5. Apresentam maior segurança que o uso das APIs.
- Análise comparativa entre o uso de APIs x Web Service:
	- As APIs não são necessariamente feitas como Web Services:
		- Elas podem fazer uso de qualquer meio de comunicação.
		- Geralmente as APIs possuem seu código aberto.
		- Podem ser utilizadas de qualquer lugar e sistema.
		- Realizam todas as operações de um Web Service.
		- Podem ter arquitetura leve para bandas curtas.
		- Não necessita de uma rede para funcionar.
		- Tendem a serem abertas para qualquer um.
	- Web Services sempre são tratadas como APIs:
		- Usam três comunicações: SOAP, REST e XML-RPC.
		- São autocontidas e autodescritivas em suas funções.
		- São publicadas, localizadas e invocadas via Web.
		- Não realizam todas as operações que uma API realiza.
		- Requerem um Protocolo SOAP para fazer troca de dados.
		- Não têm arquitetura leve e funcionam apenas em rede.
		- Tendem a oferecer funções para usuários específicos.
- Web API: A evolução dos Web Services com novas possibilidades:
	- Conjunto de serviços na Web para integrar diversos clientes.
	- Características que compõem a arquitetura das Web APIs:
		1. Podem ser desenvolvidas usando diversas tecnologias.
		2. Respondem em formatos específicos: XML, JSON e TXT.
		3. Podem ser acessadas através do uso do Protocolo HTTP.
		4. Podem responder com diversos conteúdos multimídia.
	- Exemplos: Google APIs, Instagram, Twitter, YouTube.
	- Podem ser implementadas com SOAP ou seguindo o REST.
		
### 1.3. Conceitos: SOAP, REST, ASP.NET Core Web API
- SOAP: Simple Object Access Protocol
	- Protocolo mantido pela W3C em XML.
	- Usado para trocar dados entre aplicações.
	- As aplicações podem ser de sistemas diferentes.
	- As principais características do protocolo são:
		- Todas as mensagens seguindo o mesmo formato.
		- É independente de protocolo e retornam XML.
		- Os retornos não podem ser postos em cache.
- REST: Representational State Transfer Protocol
	- Estilo arquitetural stateless (sem estado).
	- Conjunto coordenado de restrições arquiteturais.
	- Aplicado a componentes e conectores de sistemas.
	- Opera sobre dentro de sistemas de hipermídia distribuídos.
	- São princípios que atendem a necessidade de performance.
	- As principais características do protocolo são:
		- Cada entidade é vista como um recurso acessível.
		- O acesso a estes recursos é via interface.
		- A comunicação é feita via Protocolo HTTP.
		- Métodos com Verbos GET, POST, PUT e DELETE.
	- Pode usar outros Protocolos no lugar do HTTP.
- Diferenças entre os Protocolos SOAP x REST:
	- SOAP é uma comunicação Cliente x Provedor:
		- Usa a Web Services Description Language.
		- Precisa de mais largura de banda.
		- Se comunica com oformato XML.
		- É independente de protocolo.
		- Invoca oserviços usando RPC.
	- REST é um estilo arquitetural:
		- Usa JSON e XML para trocar dados.
		- Dispensa tanta largura de banda.
		- Trabalha com mais formatos de resposta.
		- Verbos GET, POST, PUT e DELETE para acesso.
		- Invoca os serviços através de uma URI.
- Web API Framework Microsoft ASP.NET Core
	- Usado na criação de Web APIs RESTful.
	- Serviços criados com a linguagem C#.
	- Usa Controladores para tratar as solicitações.
	- Podem Minimal APIs para tratar as solicitações.
		- APIs criadas em um único arquivo mais leve.
- APIs RESTful são as aderentes ao estilo REST:
	- Possuem uma arquitetura Cliente-Servidor.
	- São arquiteturas que não possuem estado.
	- Têm uma interface uniforme de comunicação.
- ASP.NET Core Web API são criadas em .NET Core:
	- Construídas para sistemas Windows, Linux e MacOS.
	- Montadas com IDEs Visual Studio 2022/Code e NET CLI.
	- Utiliza Verbos HTTP GET, POST, PUT e DELETE para CRUD.
	- As Web APIs RESTful criadas são robustas e de alto desempenho.

### 1.4. REST
- É um estilo arquitetural para a concepção de sistemas distribuídos.
- Não é um padrão ou tecnologia, mas sim um conjunto de regras e restrições.
- Possuem algumas restrições, como o relacionamento Cliente/Servidor:
	- Não possuem um mecanismo para a monitoração de status.
	- Possuem, porém, uma interface de comunicação uniforme:
		- Representações URI (Uniform Resource Identifiers).
		- Suas mensagens costumam ser auto-descritivas.
		- Hipermídia (hiperlinks e hipertexto).
	- Suportam o cache de dados e respostas.
	- Suportam um sistema em camadas.
- Arquitetura Cliente/Servidor:
	- Recurso: Abstraído pela URI.
	- Representação: Resposta obtida.
	- Stateless: Apenas dados necessários.
	- Mensagens: Verbos autodescritivos.
- Uma API RESTful adere ao REST.
- Os recursos são definidos na criação:
	- Obter todos os livros cadastrados.
	- Obter apenas um livro cadastrado.
	- Obter todos os livros de um autor.
- Recursos mapeados via URI:
	- GET api/biblioteca/livros
	- GET api/biblioteca/livros/1
	- GET api/biblioteca/autor/1/livros
- Recursos requisitados via verbos HTTP.
- Requisições respondidas com um código status.
- Com o status de uma operação, sabe-se seu sucesso:
	- 1XX para códigos que transmitem informativos.
	- 2XX para códigos que indicam sucesso.
	- 3XX para códigos de redirecionamento.
	- 4XX para erros ocorridos no cliente.
	- 5XX para erros ocorridos no servidor.

### 1.5. HTTP
- O Protocolo HTTP é usado na comunicação entre os Clientes e as Web APIs.
- O Cliente abre um Web Socket e envia requisições que serão respondidas.
- As requisições servem para acessar e manipular recursos da Web API.
- As requisições são enviadas via Uniform Resource Identifier (URI).
- Uma requisição HTTP é dividida em três partes ainda que distintas:
	- Request Line: Método HTTP + Mapeamento URI + Protocolo HTTP:
		- Método: Ação realizada. URI: Recursos. Protocolo: Versão.
	- Headers: Metadados contendo mais informações adicionais.
		- Host, Cache-Control, Accept, Authorization, Bearer.
	- Body: Informação adicional e opcional que é enviada:
		- Representações via formatos Texto, HTML, JSON, etc.
- Uma resposta HTTP também é dividida em três partes:
	- Status Line: O código do status da requisição.
	- Headers: Metadados contendo informações.
	- Body: Dados opcionais enviados pelo servidor.
		
### 1.6. Métodos HTTP
- Usados para consumir os recursos de uma Web API RESTful.
- GET: Usado para recuperar informações inerentes ao recurso:
	- É um método seguro, pois não altera o estado do recurso.
	- É idempotente, produzindo o mesmo resultado se repetido.
	- Possíveis códigos de retorno: 200 OK, 404 NOT FOUND.
- POST: Usado para criar um novo recurso com informações:
	- Não é um método seguro, pois altera o estado do recurso.
	- Não é idempotente, repetido não produz mesmo resultado.
	- Possíveis retornos: 201 CREATED, 400 BAD REQUEST.
- PUT: Atualizar informações ou atualizar o recurso:
	- Não é seguro, pois altera o estado do recurso.
	- É idempotente, produz mesmo resultado se repetido.
	- Retornos: 200 OK ou 204 NO CONTENT, 404 NOT FOUND.
- DELETE: Usado para excluir algum recurso referido.
	- Não é seguro, pois altera o estado do recurso.
	- É idempotente, repetido produz mesmo resultado.
	- Possíveis retornos: 200 OK, 404 NOT FOUND.

### 1.7. HTTPS e HSTS
- HyperText Transfer Protocol Secure é uma extensão segura do HTTP.
- É implementado sobre a Transport Layer Security, uma camada segura:
	- É um protocolo que substitui o Protocolo SSL - Secure Sockets Layer.
	- Permite a comunicação criptografada entre um site e um navegador.
- Os sites que configurarem o certificado TLS podem usar o HTTPS.
- Seu objetivo é tornar segura a tranmissão de informações sensíves:
	- Dados pessoais, dados de pagamento, endereço e logins de entrada.
- O uso do HTTPS pode ser definido no projeto .NET Core via Middlewares:
	- O método UseHttpsRedirection redireciona as requisições HTTP para HTTPS.
- A API pode orientar os navegadores a utilizarem o HTTPS para acessá-las:
	- O método UseHsts envia a instrução no Header com a chave Strict-Transport-Security.
- Em aplicações MVC, o atributo RequireHttps é usado, mas não deve ser usado em Web APIs:
	- Ele é usado para redirecionar HTTP para HTTPS, mas não protege a informação enviada.
- As Web APIs seguras costumam rejeitar requisições HTTP, utilizando somente HTTPS.

### 1.8. JSON (JavaScript Object Notation)
- É um formato de troca de dados simples e rápida entre sistemas.
- É compacto, leve, legível e de pradrão aberto independente.
- A utilização de seu formato se baseia em chave-valor.
- O seu formato lembra muito o formato em XML:
	- É hierárquico: Valores dentro de valores.
	- Pode ser analisado pelo JavaScript.
	- É auto-descritivo e legível.
	- É texto em formato simples.
- Mas ele é diferente do XML:
	- Não usa tag de fechamento.
	- É mais curto e simples.
	- Leitura e escrita rápidas.
	- Faz o uso de arrays.
	- Não tem palavras reservadas.
	- Têm parsers nas linguagens.
- Possui suas prórias regras de sintaxe:
	- É definido por pares Chave:Valor.
	- Dados separados por vírgulas.
	- As chaves contém objetos.
	- Os colchetes expressam arrays.
- Valores que podem ser usados:
	- Números inteiros e pontos flutuantes.
	- Strings, bool, arrays, objetos e nulo.
- É o formato mais usado nas Web APIs.
- Ferramentas para trabalhar com JSON:
	- JSON Editor Online: Validar JSONs.
	- JSON 2 Csharp: Classe C# de um JSON.
- Uso do JSON nas APIs ASP .NET Core:
	- Classe HttpClient com HTTP Requests.
	- A classe interage recuros via métodos:
		- GetAsync, PostAsync, PutAsync e DeleteAsync.
	- Respostas em buffer do servidor antes de retorná-las.
	- Dentro das respostas, o corpo é lido pela aplicação.
	- Os métodos são thread safe, evitando problemas de concorrência.
	- A HttpClient tem métodos de extensão para receber e enviar JSON.
	- Principais métodos: GetFromJsonAsync, PostAsJsonAsync, PutAsJsonAsync.
	- O código fica mais legível tendo com operações usando JSON.
- A .NET Core contém classes para serialização de dados JSON:
	- Elas convertem objetos em strings que representam JSON.
	- Elas também desserializam os dados JSON em objetos C#.

### 1.9. Níveis de Maturidade de Richardson
- O REST para o acesso e a manipulação de dados remotos.
- As Web APIs RESTful são consideradas mais maduras:
	- Oferecem facilidade, flexibilidade e ineroperabilidade.
- Os desenvolvedores mais puristas seguem o REST à risca.
- Os pragmáticos ignoram algumas regrase implementam outras.
- O modelo de Richardson ajuda a classificar este nível de maturidade.
- As APIs são classificadas em quatro níveis de aderência ao REST.
- A maturidade é baseada em: Recursos/URI, Verbos HTTP e Hipermídia.
- Nível 0 - Plain Old XML Swamp: Menor nível de conformidade:
	- Protocolo HTTP usado apenas para transportar dados.
	- Expõe apenas um único endpoint para todo o aplicativo.
	- Os Verbos HTTP não são utilizados corretamente.
	- Não existe retorno com código de status.
- Nível 1 - URI (Uniform Resource Identifier)
	- Recursos baseados em múltiplas URI.
	- Os Verbos HTTP ainda são usados incorretamente.
	- O corpo da requisição usado para carregar as informações.
- Nível 2 - Utilização dos Verbos HTTP com Resource URI:
	- Os códigos de status são utilizados de forma correta.
	- O corpo da requisição não faz carga de metadados.
- HATEOAS (HyperText As The Engine Of Application State):
	- Diz o que é possível fazer após uma requisição no recurso.

### 1.10. Injeção de Dependência - Introdução
- Técnica para tornar uma classe independente de suas dependências.
- É um padrão para implementar a Inversão de Controle (IoC);
- Seu objetivo é a redução do acoplamento entre os objetos.
- Sua aplicação faz um objeto fornecer as dependências de outro.
- Exemplo ilustrando uma classe Cliente com forte acomplamento:
	- Ela depende da classe Pedido e precisa saber como criá-la.
	- Dependendo da classe Pedido, acaba dependendo de suas dependências.
	- Qualquer mudança na classe Pedido afeta a classe Cliente.
	- Isso viola o Princípio SOLID da Responsabilidade Unica:
		- Ela não só tem que obter os pedidos, mas criará sua instância.
	- Testes unitários em classes muito acopladas são problemáticos.
- Deve-se retirar de uma classe a responsabilidade de criar outras.
- O controle na classe dependente é invertido para esta retirada.
- Outra classe torna-se responsável por criar esta instância.
- A criação de novas instâncias sempre deve ser delegada.
- Através de uma abstração, a criação das instâncias é feita.
- As demais classes passam a depender apenas desta instância. 
- O Princípio da Inversão de controle prega as seguintes premissas:
	- Delegar a tarefa de criação de um objeto a uma outra entidade.
	- Reduzir o acoplamento e minimizar as dependências entre objetos.
- Uma classe não deve depender da implementação de outra classe.
- Em vez disso, uma abstração deve ser criada para esta classe.
- As classes deverão depender apenas desta abstração criada.
- Esta abstração poderá ser uma outra classe ou interface.
- Na plataforma .NET Core possui um Container DI nativo:
	- Ele fornece a instância da classe através das interfaces.
	- Basta configurar a classe neste container para tanto.
		
### 1.11. Injeção de Dependência - Tempo de Vida
- Inversão de Controle é um princípio que promove o baixo acoplamento.
- Inversão de Dependência é um princípio para minimizar dependências.
- Injeção de Dependência é um padrão de projeto que aplica a IoC.
- IoC Container é um framework que gerencia as injeções de dependências.
- Os princípios fornecem diretrizes para o objetivo, sem detalhes.
- Os padrões fornecem soluções de baixo nível para as implementações.
- Os frameworks realizam a solução dentro da implementação do projeto.
- A plataforma .NET Core possui um framework de Injeção de Dependência.
	- A interface IServiceCollection registra as dependências usadas.
- Existe, porém, outros containeres que não sejam nativos da plataforma.
- Quem usa Injeção de Dependência precisa conhecer sobre tempo de vida.
- Cada serviço injetado tem o seu próprio tempo de vida na aplicação.
- Este tempo de vida controla a existência da dependência no container.
	- Este tempo de vida gera impactos no desempenho da aplicação.
- O tempo de vida dos serviços pode ser registrado em três segmentos:
	- Transient: Os serviços criados cada vez que são solicitados:
		- Toda vez que for injetado, sua instância será diferente.
		- Ideal para serviços mais leves e que não tenham estado.
	- Scoped: Os serviços são criados para cada request solicitada:
		- Indicado para aplicações Web. A instância muda a cada request.
		- Bom quando a instância é usada em muitos lugares na request.
		- A mesma alocação de memória será usada para esta instância.
	- Singleton: Duram o mesmo tempo de vida útil de toda aplicação.

## Seção #2: Ambiente e Recursos

Apresentação dos ambientes e recursos usados no desenvolvimento das Web APIs .NET 8 ao longo do curso.

### 2.1. Apresentação
- Atualizações da plataforma .NET Core
	- O curso foi dado com .Net Core 3.1.
	- O .NET 5 unificou a plataforma .NET.
	- Depois vieram o .NET 6, .NET 7 e .NET 8.
- Houveram alterações nos templates e na estrutura.
- Mas não houve grandes alterações na forma de construir.
- A partir do .NET 5, uma nova versão passou a ser anual.
- O curso terá uma segmentação com base nos tópicos abaixo:
	- .NET 8, a nova atualização da plataforma unificada.
	- ASP .NET Core 8 para a criação de Web APIs.
	- Instalação das IDEs Visual Studio 2022 e Code.
	- Instalação das ferramentas MySQL e do MySQL Workbench.
	- Apresentação de template para montar Web APIs .NET.
	- Conceito e criação das Minimals APIs em .NET Core.
	- Migração de versões anteriores para a versão .NET 8.

### 2.2. Ambiente
- Para sistemas Windows:
	- A plataforma .NET 8.
	- Editor VS 2022 Community.
	- MySQL como banco de dados.
	- MySQL Workbench para gerenciamento.
- Ambiente .NET 8 instalado:
	- Suporte ao .NET 8.
	- Suporte ao EF Core 7.
	- Suporte à linguagem C#;
	- Framework Web MVC e APIs.
	- Swagger de documentação.
	- Postman para consultas.

## 2.3. NET 8 - Instalação
- A SDK do .NET 8 encontra-se no site da Microsoft.
- Ela dá suporte ao C#, ao ASP.NET Core e ao EF Core.

### 2.4. Visual Studio - Instalação
- O Visual Studio Community 2022 é uma versão gratuíta do Visual Studio.
- Feita para estudantes e desenvolvedores individuais e de código aberto.
- O download é feito no site da Microsoft, que tem materiais de estudo.
	- Uso da IDE para machine learning, ciências de dados, jogos, etc.
- Primeiro é baixado o instalador e através dele é feita a instalação.
- Selecionar a carga de trabalho ASP.NET e Desenvolvimento Web.

### 2.5. VS Code - Instalação
- Versão alternativa do editor Visual Studio Community.
- Mais leve, flexível e personalizável através de plugins.
- Multiplataforma: Funciona no Windows, MacOS e Linux.
- Oferece os mesmos recursos e templates do Community.
- O download é feito no site do Visual Studio Code.
- Ao instalar, é preciso obter o C# Dev Kit Extension:
	- Fornece suporte à linguagem de programação C#;
	- Contém as bases do Visual Studio para as soluções.
	- Gerenciamento de testes, machine learning, etc.
	- A extensão Intellicode para desenvolver com IA.

### 2.6. MySQL - Instalação
- MySQL Community é a versão gratuíta e de código aberto.
- Multiplataforma, rodando em Windows, Linux e MacOS.
- O instalador do MySQL instala os seguintes recursos:
	- O próprio servidor de banco de dados do MySQL.
	- Os conectores necessários para a plataforma .NET.
	- MySQL Workebench para administrar os bancos de dados.
	- MySQL Notifier para monitorar as instâncias MySQL.
	- Ferramentas para Excel e para o Visual Studio.
	- Exemplos de bancos de dados usando o MySQL.
	- Todas as documentações que integram o MySQL.

### 2.7. Criando a primeira Web API
- No Visual Studio, há um template padrão ASP.NET Core Web API:
	- Ele permite que sejam criadas Web APIs usando Controllers.
	- Ele permite também a criação de Web APIs com Minimal APIs.
- Os templates padrão do .NET 8 não usam mais a classe Startup.
- A configuração dos serviços e request pipeline é no Program.
- A classe Program faz o uso dos seguintes recursos do C#:
	- Top Level Statements, que não faz uso do método Main.
	- Global Usings, que usa a diretiva using implicitamente.
- O Visual Studio cria a seguinte estrutura de Web API:
	- Connected Services: Qualquer serviço que esteja conectado.
	- Dependencies: Bibliotecas e pacotes que rodam o projeto.
		- Analyzers: Ajudam na melhoria da qualidade do projeto.
		- Frameworks: Estruturas para desenvolver em .NET.
		- Pacotes: Acrescentam funcionalidades adicionais.
	- Properties: Configurações do ambiente de execução.
	- Controllers: Detem os controladores da Web API.
	- appsettings.json: Tem configurações específicas.
	- Program.cs: Ponto de partida do projeto.
		
### 2.8. Primeira Web API - Estrutura
- O arquivo de projeto tem a extensão .csproj:
	- Define estrutura, configurações e dependências:
		- Suporte a nullables e implicit usings.
		- Suporte à internacionalização e globalização.
	- Contém informações de tipo, nome e linguagem.
	- Define a SDK que será usada para a compilação.
- A pasta /bin e /obj são usadas para os compilados.
- A pasta /Controller serve aos Controllers da aplicação.
- A pasta /Properties está o launchSettings.json:
	- Define como a aplicação será lançado e executado.
	- Define quais configurações serão usadas no lançamento.
	- Define as configurações do IIS caso o projeto o use:
		- URL, porta, habilitação de autenticação do Windows.
	- Contém por padrão três perfis de lançamento da aplicação:
		- Uso do HTTP, uso do HTTPS e uso do IIS Express.
		- Cada uma define o comando usado no seus lançamentos.
		- Define se o console exibirá mensagens de execução.
		- Define se o navegador será aberto e a URL acessada.
		- Indica qual URL será usada para acessar a aplicação.
		- Indica as variáveis de ambiente que serão usadas.
		- As variáveis definem se o ambiente é dev ou prod.
		- O HTTPS define duas URLs, uma HTTP e outra HTTPS.
		- IIS Express define a execução em cima do IIS.
		- O servidor padrão embutido chama-se Kestrel.
- É possível escolher o navegador que inicia o projeto.
- O appsettings.json armazena configurações do aplicativo:
	- Ajuda a separar configurações do código-fonte.
	- Favorece configurações dinâmicas sem recompilação.
- O Program.cs também é importante para a inicialização:
	- No .NET 8, a classe Startup.cs não é criada.
	- Dentro dela, o aplicativo Web é construído.
	- Os serviços usados são configurados.
	- A instância do aplicativo é iniciada.
	- Configura serviços para modos de desenvolvimento.
	- Configura o pipeline com HTTPS, Autenticação, etc.
		
## 2.9. Primeira Web API - Controlador
- Controller é uma classe responsável por lidar com requisições HTTP.
- Intermedia entre as requisições feitas por clientes e a lógica.
- Ele faz o mapeamento dos verbos HTTP para ações específicas.
- Todo controlador no .NET Core tem o sufixo "Controller";
- O prefixo antes de "Controller" é parte da rota base.
- Todo Controller terá o atributo de Route e da ApiController.
	- Dá acesso a recursos que facilitam a construção das APIs.
	- Ajuda a distribuir e distinguir um Controlador API de MVC.
	- Favorece bind e validação automáticas, respostas padrão.
	- Favorece também a geração de documentação do sistema.

## 2.10. Criando a Primeira Minimal API
- O conceito foi introduzido a partir do .NET 6.
- É uma nova abordagem de APIs simples e concisas.
- Visa facilitar a criação de APIs básicas.
- Reduz a complexidade das configurações.
- Diminui a quantidade de código desnecessário.
- As APIs são criadas com poucas linhas de código.
- Elimina controladores tradicionais e rotas complexas.
- Os endpoints são definidos dentro do código de Program.cs.
- Isto é feito com os métodos Extension MapGet, MapPost, etc.;
- Estes métodos são disponibilizados pela interface IApplicationBuilder.
- Cada método corresponde a um Verbo HTTP específico com uma lógica.
- Ao ser criado no Visual Studio, o projeto não tem Controllers.
- Todo código está concentrado dentro da classe Program.
- Através dos métodos Map, as rotas são parametrizadas.
- Os métodos Map recebem funções callback com a lógica.
- A classe de retorno foi substituída por um record.
- Record é uma classe otimizada para dados imutáveis.
	
### 2.11. Criando APIs com VS Code e o .NET CLI
- VS Code é uma IDE mais leve e com suporte à multi-plataforma.
- É gratuíto, open source e utiliza a .NET CLI para os projetos.
- .NET CLI permite criar, construir, executar e publicar aplicativos.
- Todos os comandos estão bem documentados no site da Microsoft.
- Todos os comandos do .NET CLI iniciam com a palavra 'dotnet';
- O .NET CLI é usado em uma ferramenta de prompt, como o 'cmd';
- Ao rodar o comando 'dotnet new', são dadas sugestões de templates.
- Ao rodar o 'dotnet new list', uma lista mais completa é exibida.
- Ao criar o projeto, basta abrir o VS Code no diretório dele.
- O VS Code tem um terminal próprio que permite executar comandos.
- Através do 'dotnew new -minimal', é possível criar Minimal APIs.
- As estruturas dos projetos são as mesmas do Visual Studio 2022.
- É possível criar um projeto Web API dentro do próprio VS Code:
	- Pressionar Ctrl + Shift + P e selecionar '.NET New Project';
	- Selecionar uma pasta onde o projeto deverá ser criado.
	- Escolher um nome para o projeto e aguardar a criação.
- Para criar projetos como solução, baixar o Dev Kit C#.
	
## Seção #3: Criando uma Web API usando o Visual Studio

Partimos agora para a criação de Web APIs com a IDE Visual Studio Community 2022, apresentando os principais conceitos e recursos oferecidos pela plataforma .NET 8.

### 3.1. Apresentação
- O intuito desta seção é criar uma Web API REST.
- O projeto será criado na platafroma ASP.NET Core.
- O banco de dados MySQL usado para armazenamento.
- O ORM usado será o Entity Framework com Code First.
- Tudo isso será feito na IDE Visual Studio 2022.
- As ferramentas e abordagens usadas serão as seguintes:
	- .NET 8.0 SDK para prover recursos de desenvolvimento.
	- ASP.NET Core 8.0 para facilitar o desenvolvimento.
	- Entity Framework Core na abordagem Code First.
	- Banco de dados MySQL e MySQL Workbench para acesso.
	- Operações CRUD - Create, Read, Update e Delete.
	- Criação de endpoints usando os Verbos HTTP.
	- Uso de Controllers integrados ao Swagger.
	- Configuração e inicialização da Program.cs.
	- Uso da IDE Visual Studio 2022 Community.
- Serão criadas as Entidades Categoria e Produto.
- Será definido o relacionamento destas Entidades.
- Será criado o arquivo de contexto DbContext.
- Será definida a string de conexão para o MySQL.
- Serão registrados serviços no container DI.
- Será aplicado o Migrations para gerar o banco.
- Serão usadas as Data Annotations para validação.
- Serão populadas as tabelas com os dados iniciais.
- Serão criados os Controladores de Categoria e Produto.
- Serão definidos os endpoints com os Verbos HTTP.
- Serão realizados os tratamentos de erros com Try-Catch.
- Serão acessados os endpoints usando Swagger e Postman.
- Será usado o Scaffolding do VS 2022 para gerar Controladores.

### 3.2. Visão Geral: Projeto, Escopo e Nomenclatura
- O Escopo nada mais é que o objetivo final do projeto que é criado.
	- Exemplo: Criar uma Web API para um catálogo de produtos categorizados.
	- Esta Web API deve atender a uma rede de lojas ou de supermercados.
	- Deve ser um serviço RESTful que permitam o gerenciamento do catálogo.
	- Deve expor endpoints para criar, ler, editar e excluir produtos.
	- Deve também expor endpoints para consultar um ou mais produtos.
	- Deve expor endpoints também para estas operações dentro de categoria.
	- Para as categorias, devem ser armazenados os nomes e caminhos de imagem.
	- Para produtos: nome, descrição, valor, imagem, estoque, data e categoria.
- O Escopo ajuda a definir o que é preciso fazer e criar para a Web API.
- Com o Escopo definido, define-se os Recursos, Endpoints e Mapeamentos.
	- Endpoint da API que servirá de base para produtos: /v1/api/produtos
		- Obtenção de todos os produtos registrados: GET /v1/api/produtos
		- Obtenção de apenas um produto pelo ID: GET /v1/api/produtos/1
		- Cadastro de um produto no sistema: POST /v1/api/produtos
		- Atualização de um produto: PUT /v1/api/produtos
		- Remoção de um produto: DELETE /v1/api/produtos
	- Endpoint da API que servirá para categorias: /v1/api/categorias
		- Obtenção de todas as categorias: GET /v1/api/categorias
		- Obtenção de uma categoria: GET /v1/api/categorias
		- Obtenção de categorias de um produto: GET /v1/api/categorias/1/produtos
		- Cadastro de categoria: POST /v1/api/categorias
		- Atualização de categoria: PUT /v1/api/categorias
		- Remoção de categorias: DELETE /v1/api/categorias
- Os Endpoints são URLs de acesso aos serviços.
- Uma URL é uma URI que identifica um recurso.
- Deve-se definir as respostas dadas pelos recursos.
- Depois das respostas, define-se o esquema de segurança:
	- Permissão de acesso à API somente a usuários autenticados.
	- Política de autorização de acesso aos usuários.
	- Isso envolve um serviço para gerenciar os usuários.
	- Logo, Endpoints para ler, criar, editar e excluir usuários.
	- Para usuários, devem ser armazenados nome, e-mail e senha.
	- Dentro da política, define-se os endpoints para os recursos:
		- Obtenção de lista de usuários do sistema: GET /v1/api/usuarios
		- Obtenção de apenas um usuário pelo ID: GET /v1/api/usuarios/1
		- Criação de novo usuário: POST /v1/api/usuarios
		- Atualização de um usuário: PUT /v1/api/usuarios
		- Remoção de usuário: DELETE /v1/api/usuarios
- Quais códigos HTTP devem ser usados nos responses?
	- 200 - OK: Quando a requisição foi bem-sucedida.
	- 201 - CREATED: Quando algo foi criado.
	- 202 - ACCEPTED: Solicitação aceita.
	- 204 - NO CONTENT: Resposta sem conteúdo.
	- 304 - NOT MODIFIED: Recurso não alterado.
	- 400 - BAD REQUEST: Erro na requisição.
	- 401 - UNAUTHORIZED: Requer autenticação.
	- 403 - FORBIDDEN: Requer autorização.
	- 404 - NOT FOUND: Recurso não encontrado.
	- 409 - CONFLIT: Conflito de requisições.
	- 500 - INTERNAL SERVER ERROR: Erro no servidor.
- Uma API também precisa de uma persistência:
	- A maioria trabalha com bancos de dados relacionais:
		- MySQL, SQL Server, PostgreSQL, SQLite, Oracle, etc.
	- Define-se também o provedor de acesso e a tecnologia:
		- Entity Framework Core, Dapper ou outras formas.
	- Por fim, define-se a abordagem para criar o banco:
		- Code First: Parte das entidades a criação das tabelas.
	- O padrão Repository ajuda a isolar o acesso dos dados.
- Deve-se definir claramente as nomenclaturas para o projeto:
	- Deve-se usar o bom senso e seguir o que foi decidido.
	- O nome do projeto resume o que ele provê: CatalogoApi.
	- O nome dos Controllers será definido no plural.
	- Nome de Actions já são pré-descritos pelos Verbos:
		- Acessos via atributos HttpGet, HttpPost, etc.
	- Endpoints definidos com substantivos no plural.
- Define-se também a estrutura do projeto em questão:
	- A Arquitetura em Camadas é a mais utilizada:
		- Elas separam bem as responsabilidades:
			1. Camada de Apresentação: Interfaces.
			2. Camada de Negócios: Processamentos.
			3. Camada de Acesso aos Dados: Armazenamento.
	- Existem termos usados na arquitetura de software:
		- Layers: Separação lógica, do código e dos dados.
		- Tiers: Separação física, distribuição do código.
		- Os serviços são repartidos em projetos ou em pastas?
			- Aplicações complexas e distribuídas separam em Tiers.
			- Aplicações mais simples separam o código em Layers.
	- Exemplo #1 de utilização da Arquitetura em Camadas:
		1. Presentation Layer: Angular, Views, Mobile, Desktop.
		2. Business Logic: Domínios, Serviços e Repositórios.
		3. Data Access: Entity Framework Core e MySQL.
	- Exemplo #2 do uso da Arquitetura em Camadas:
		1. Presentation: Angular, Views, Mobile, Desktop.
		2. Service: Criação de Classes de acesso a Serviços.
		3. Application Core: Domínios, Serviços e Repositórios.
		4. Data Access: Entity Framework Core e MySQL.

### 3.3. Criando o Projeto Web API
- O objetivo será criar uma Web API para um catálogo de produtos/categorias.
- O catálogo poderá atender a uma rede de lojas, supermercados ou consumidores.
- Haverá um serviço RESTful para prover acesso e gerenciamento dos catálogos.
- A API terá endpoints de operações CRUD e consultas aos produtos e categorias.
- Estas APIs irão utilizar os Verbos HTTP e retornarão códigos de status.
- Para iniciar a criação desta Web API, o projeto ApiCatalogo será criado:
	- A IDE utilizada para o projeto será o Visual Studio 2022 Community.
	- O projeto terá habilitada a opção Open API e usará os Controllers.
	- Será criada a modelagem das entidades Produto e Categoria.
	- O projeto será configurado para usar o Entity Framework Core.
	- O banco de dados utilizado será o MySQL com o MySQL Workbench.
	- Será definida uma classe de Contexto AppDbContex para o EF Core.
	- Será definido o mapeamento das entidades para as tabelas com DbSet<T>.
	- O Contexto será registrado como um serviço na classe Program.cs
	- A string de conexão com o MySQL será definida no appsettings.json
	- O Pomelo será usado como provedor do banco e da string de conexão.
	- Será aplicado o Migrations para criar o banco de dados e as tabelas.
	- Serão criados os controladores ProdutosController e CategoriasController.
	- Serão definidos os endpoints ou métodos Action para realizar os CRUDs.
- Quando estiver pronta, a Web API atenderá solicitações de vários clientes.
- A Web API se comunicará com o MySQL via EF Core para obter os dados.
- Ao habilitar o Open API, o projeto já habilitará as APIs no Swagger.
- O projeto criado tem dois perfis de execução: ApiCatalogo e IIS Express:
	- O ApiCatalogo usa configurações pré-definidas e roda no Kestrel.
	- O IIS Express roda em um servidor IIS com configurações próprias.
- No .NET 8, as configurações de serviços não são mais feitas na Startup.cs

### 3.4. Criando Modelo de Domínio
- Uma vez criado o projeto, o modelo e o controlador de exemplo são removidos.
- É criada a pasta Model que comportará as classes Categoria.cs e Produto.cs.
- Para definir a propriedade de chave primária, pode-se fazer de duas formas:
	- Ou nomeando apenas de Id, ou nomeando Id prefixado pelo nome da classe.
	- Estas duas formas de nomear são melhor entendidas pelo Entity Framework.
- As classes criadas até o momento, só têm propriedades e não comportamentos.
	- As classes deste tipo são comumente chamadas de Classes Anêmicas.
- São a partir destas classes que as tabelas serão criadas com o EF Core.

### 3.5. Configurando o projeto para usar o EF Core
- A configuração usará a abordagem Code First, por meio das Classes Anêmicas.
- Nesta abordagem o banco é gerado através do mapeamento destas Classes.
- Ou seja, as Entidades são geradas primeiro, e depos as Tabelas referentes.
- O mapeamento é realizado pelo EF Core com base em convenções adotadas.
- Através das convenções, são criadas as Tabelas Categoria e Produto.
- Este mecanismo utiliza do recurso Migrations para que seja realizado.
- Os pacotes do EF Core e do provedor Pomelo devem ser baixados.
- O download dos pacotes podem ser feitos via linha de comando:
	- Deve ser acessado o diretório onde se encontra o csproj.
- Além disso, será preciso baixar a ferramente EF Core Tools:
	- Utilizada para a aplicação do Migrations nas Entidades.
- A instalação dos pacotes pode ser feita também graficamente.
	- Ele já apresenta os pacotes instalados e disponíveis.
- Assim que os pacotes instalarem, o csproj irá atualizar.

### 3.6. Criando a Classe de Contexto do EF Core
- Ela é uma Classe que herda da Classe DbContext do EF Core.
- É ela que definirá o mapeamento das Entidades e Tabelas.
- DbContext representa uma sessão com o Banco de Dados.
- Ela recebe o provedor do Banco e a string de conexão.
- A DbContext é composta por Classes representativas DbSet<T>:
	- Representam coleções de dados que podem ser consultadas.
	- As entidades também são manipuladas através dela.
	- Para cada Entidade, uma Classe DbSet é meapeada.
	- A Classe pode ser nullable caso seja opcional.
- A DbContext oferece diversos recursos de Banco de Dados:
	- Acesso, persistência e comunicação com as Tabelas.
- A AppDbContext recebe como dependência a DbContextOptions:
	- Ela contém um conjunto de configurações do Banco de Dados.
	- Contém também informações sobre a string de conexão de Banco.

### 3.7. Registrando os Serviços no Container DI
- É necessário informar a string de conexão com o Banco de Dados MySQL.
- Esta informação será colocada no arquivo `appsettings.json` do Projeto.
- A propriedade da string de conexão é definida por `ConnectionStrings`.
- A string de conexão define o servidor, o schema usado, o login e senha.
- A string de conexão permite o registro do Contexto como um Serviço.
- Este código de configuração é incluído na Classe Program no .NET 8.
	- Através do `builder`, é possível obter a string do `appsettings.json`.
	- Com a string, o `builder` é usado para adicionar o Context criado.

### 3.8. Definindo o Relacionamento entre as Entidades
- Cada Categoria vai ter um valor único que é chamado de Chave Primária:
	- Com ele, todas as Categorias são identificadas de forma única.
- Além das informações descricionais, os Produtos também têm Chave Primária.
	- Além da Chave Primária, os Produtos também terão Chaves Estrangeiras.
	- A Chave Estrangeira de um Produto aponta para Chave Primária de Categoria.
- Uma Categoria pode ter um ou mais Produtos associados a ela: Relação Um-Para-Muitos.
- Dentro de um Banco de Dados, os Relacionamentos são definidos por Chaves Estrangeiras.
	- Elas estabelecem um vínculo ou link que conecta uma tabela com a outra tabela.
- Este Relacionamento deve ser expressado nas Entidades para que o EF possa entender.
- A forma mais simples de definir este Relacionamento é por meio das convenções:
	- A convenção do EF Core é usar as propriedades de navegação para Relacionamentos.
	- Dentro da Classe Categoria, haverá uma Collection de Produtos indicando o Relacionamento.
		- É uma boa prática sempre inicializar uma Collection dentro de uma Classe.
	- Já a Classe Produto pode referenciar um único Id apontado para a Classe Categoria.
	- Além disso, a Classe Produto pode referenciar a instância de sua Categoria.

### 3.9. Apresentando o EF Core Migrations
- O Migrations é uma maneira de atualizar um banco de dados de forma incremental.
- Seu objetivo principal é manter sincronia com o modelo de dados da aplicação.
- O seu uso também é responsável por preservar os dados existentes no banco.
- É uma forma de versionar o esquema do banco de dados sincronizado ao modelo.
- A partir de um Modelo de Entidades, é criado um Modelo do Entity Framework.
	- Através do Modelo EF Core, o Migrations irá criar o Banco de Dados.
- Ao alterar as Classes de Domínio, o Migrations deverá ser executado.
- Para realizar todo este processo de atualização, são usadas as EF Tools.
- As EF Tools são comandos executados no cmd para realizar as seguintes operações:
	- Criação do script que será usado para fazer as migrações necessárias.
	- Remoção de algum script de migração que foi criado anteriormente.
	- Geração de banco de dados e das tabelas com base no script.
- Uma alternativa ao Migrations no cmd é o Package Manager Console.
	- Os comandos são diferentes, mas as funções são as mesmas.
	- É necessário baixar um pacote pelo gerenciador NuGet.
	
### 3.10. Aplicando os Migrations
- É preciso ter configurada a classe Program e o arquivo appsettings para se conectar.
- Todas as propriedades das classes são mapeadas, excetos as de navegação.
- Usar prompt de comando ou o NuGet Package Manager para executar o Migrations.
	- Comando: `dotnet ef migrations add <nome-da-migracao>`.
- Quando o migrations é adicionado, dois arquivos são criados:
	- Timestamp para registrar o tempo em que a migração foi feita.
		- O nome da classe é o mesmo do nome da migração.
		- É composto por um builder que especifica todas as tabelas geradas.
		- Para cada tabela, são especificadas as propriedades e seus tipos.
		- Alguns tipos são setados automaticamente e devem ser reconfigurados.
		- Ajustes são fundamentais para questões de armazenamento e performance.
		- Esta classe também define os relacionamentos e foreign keys.
		- Também são definidas constraints, como exclusão em cascata.
		- O método `Up()` constrói a base o `Down()` reverte o que foi feito. 
	- Snapshot do modelo de dados no momento em que a aplicação foi criada.
- Após fazer todas as alterações necessárias no Timestamp, é hora de criar a base.
	- Comando: `dotnet ef database update`.
- No MySQL, todas as tabelas são criadas incluindo as alterações feitas no Timestamp.

### 3.11. Apresentando o Data Annotations
- São atributos que podem ser aplicados às Classes e aos seus membros.
- Fornecem metadados sobre como eles devem ser tratados no sistema.
- Geralmente são usados para validações de entrada de dados.
- Também são usados para definir como a Classe ou os membros se comportam.
- Outros usos: Formatação de dados e geração de código.
- Também podem ser usados para a sobrescrita de convenções do EF:
	- Estas convenções são um conjunto de regras para tratar o schema de banco de dados.
	- A exemplo: Strings em longtext e decimais com precisão de 65 dígitos e 30 casas decimais.
	- Estas convenções podem ser sobrescritas para regular colunas:
		- Tamanho, formato ou obrigatoriedade das colunas.
- Alguns dos atributos de Data Annotation:
	- Key: Identifica uma propriedade como chave primária de tabela.
	- Table: Define o nome da tabela para a qual a Classe será mapeada.
	- Column: Define a coluna para qual a propriedade será mapeada.
	- DataType: Associa um tipo de dados adicional a uma propriedade.
	- ForeignKey: Especifica que a propriedade é usada como uma chave estrangeira.
	- NotMapped: Exclui a propriedade do mapeamento.
	- StringLength: Define o tamanho mínimo e máximo permitido para a string.
	- Required: Especifica que o valor do campo é obrigatório: NOT NULL.
- O atributo ErrorMessage retorna uma mensagem de erro para as validações.
