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
		-> APIs:
			- Não são necessariamente Web Services;
			- Usam qualquer meio de comunicação;
			- São de código aberto;
			- São utilizadas de qualquer lugar;
			- Realizam todas as operações de um Web Service;
			- Podem ter arquitetura leve para bandas curtas;
			- Não necessita de uma rede para funcionar;
			- Tendem a serem abertas para qualquer um.
	=> Web API: A evolução dos Web Services
		-> Conjunto de serviços na Web para integrar diversos clientes;
		-> Características:
			1) Podem ser criadas com diversas tecnologias;
			2) Respondem em formatos específicos: XML, JSON e TXT;
			3) Podem ser acessadas usando o Protocolo HTTP;
			4) Podem responder com multimídia.
		-> Exemplos: Google APIs, Instagram, Twitter, YouTube;
		-> Podem ser implementadas com SOAP ou seguindo o REST.
