using System.ComponentModel.DataAnnotations.Schema;

namespace TarefasApi.Data;

[Table("Tarefas")]
public record Tarefa(int Id, string Atividade, string Status);


// Record é um novo recurso que foi introduzido no C# 9, ele é um tipo de dados leves e imutavel que tem propriedade somente leitura;
// ele é seguro para threads e não pode sofrer alteração apos sua criação, ele só pode ser inicializado atraves de um construtor;
// eles são tipo por referencia, que se comportam como tipos por valores no quesito comparação de igualdade