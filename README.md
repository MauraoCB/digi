# Procedimentos para execução dos testes

## Tecnologias
- A aplcação foi dividida em uma API escrita rm .Net Core, e a interface web escrita em Blazorç
- Para ambas foi usada a versão 7.0 do .Net.

## Requisitos
- A API pode ser publicada em um servidor com IIS e versão 7.0 do .Net Framework.
- Se for executar pelo Visual Studio, deve configurar a solution para inciar em múltiplos projetos
- Em qualquer uma das situações, no front end deve ser configurada a URL onde a API estiver sendo executada, a chave/seção ProdutosApi/urlApi foi criada no arquivo appsettings.json para esse fim
- No arquivo appsettings.json da API foi criada uma chave para infomar o caminho físico onde o arquivo products.json está gravado, exemplo: "jsonPath": "C:\\Testes\\Digi\\products.json"

*Obs.: Onde houver o caracter "\" este deve ser ducplicado, como no exemplo acima.
