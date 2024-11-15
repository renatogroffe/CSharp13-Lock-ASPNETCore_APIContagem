# CSharp13-Lock-ASPNETCore_APIContagem
Exemplo em .NET 9 + ASP.NET Core + C#13 de API REST de contagem de acessos e que faz uso da classe Lock (namespace System.Threading).

Para testes de carga utilizei o package loadtest: 

Exemplo: https://www.npmjs.com/package/loadtest

```bash
loadtest -n 1200 -c 30 -k http://localhost:5251/contador
```
