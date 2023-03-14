using Dapper.Contrib.Extensions;

namespace TarefasApi.Data;


[Table("tsrefas")]
public record Tarefa(int Id, string Atividade, String Status);

