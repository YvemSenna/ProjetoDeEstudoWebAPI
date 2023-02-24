using System.ComponentModel;

namespace SistemaDeTarefas.Enums;

public enum StatusTarefa
{
    [Description("A fazer")]
    AFazer = 1,
    [Description("Em Andamenti")]
    EmAndamento = 2,
    [Description("Concluido")]
    Concluido = 3,
}
