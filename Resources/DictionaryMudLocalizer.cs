using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Extensions.Localization;
using MudBlazor;

internal class DictionaryMudLocalizer : MudLocalizer
{
    private readonly Dictionary<string, string> _localization;

    public DictionaryMudLocalizer()
    {
        _localization = new Dictionary<string, string>
        {
            { "MudDataGrid.!=", "!=" },
            { "MudDataGrid.<", "<" },
            { "MudDataGrid.<=", "<=" },
            { "MudDataGrid.=", "=" },
            { "MudDataGrid.>", ">" },
            { "MudDataGrid.>=", ">=" },
            { "MudDataGrid.AddFilter", "Adicionar filtro" },
            { "MudDataGrid.Apply", "Aplicar" },
            { "MudDataGrid.Cancel", "Cancelar" },
            { "MudDataGrid.Clear", "Claro" },
            { "MudDataGrid.CollapseAllGroups", "Recolher todos os grupos" },
            { "MudDataGrid.Column", "Coluna" },
            { "MudDataGrid.Columns", "Colunas" },
            { "MudDataGrid.contains", "Contém" },
            { "MudDataGrid.ends with", "termina com" },
            { "MudDataGrid.equals", "Equals" },
            { "MudDataGrid.ExpandAllGroups", "Expandir todos os grupos" },
            { "MudDataGrid.False", "falso" },
            { "MudDataGrid.Filter", "Filtro" },
            { "MudDataGrid.FilterValue", "Valor do filtro" },
            { "MudDataGrid.Group", "Grupo" },
            { "MudDataGrid.Hide", "Esconder" },
            { "MudDataGrid.HideAll", "Ocultar tudo" },
            { "MudDataGrid.is", "é" },
            { "MudDataGrid.is after", "é depois" },
            { "MudDataGrid.is before", "é antes" },
            { "MudDataGrid.is empty", "está vazio" },
            { "MudDataGrid.is not", "não é" },
            { "MudDataGrid.is not empty", "não está vazio" },
            { "MudDataGrid.is on or after", "está em ou depois" },
            { "MudDataGrid.is on or before", "está em ou antes" },
            { "MudDataGrid.MoveDown", "Mover para baixo" },
            { "MudDataGrid.MoveUp", "Mover para cima" },
            { "MudDataGrid.not contains", "não contém" },
            { "MudDataGrid.not equals", "não é igual" },
            { "MudDataGrid.Operator", "Operador" },
            { "MudDataGrid.RefreshData", "Atualizar dados" },
            { "MudDataGrid.Save", "Salvar" },
            { "MudDataGrid.ShowAll", "Mostrar tudo" },
            { "MudDataGrid.Sort", "Ordenar" },
            { "MudDataGrid.starts with", "começa com" },
            { "MudDataGrid.True", "verdadeiro" },
            { "MudDataGrid.Ungroup", "Desagrupar" },
            { "MudDataGrid.Unsort", "Desordenar" },
            { "MudDataGrid.Value", "Valor" }
        };
    }

    public override LocalizedString this[string key]
    {
        get
        {
            var currentCulture = Thread.CurrentThread.CurrentUICulture.Parent.TwoLetterISOLanguageName;
            if (currentCulture.Equals("pt", StringComparison.InvariantCultureIgnoreCase)
                && _localization.TryGetValue(key, out var res))
            {
                return new LocalizedString(key, res);
            }
            else
            {
                return new LocalizedString(key, key, true);
            }
        }
    }
}