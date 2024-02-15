var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/clientes/{id}/transacoes", (int id) => {
  return $"Transações do cliente {id}";
});
app.MapGet("/clientes/{id}/extrato", (int id) => {
  return $"Extrato do cliente {id}";
});

app.Run();
