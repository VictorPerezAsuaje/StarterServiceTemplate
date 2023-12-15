﻿using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace StarterService.UI.Extensions;

public static class ModelStateExtensions
{
    public static string GetErrorsAsString(this ModelStateDictionary modelState)
        => modelState.ErrorCount > 0 ?
            $"- {string.Join("\n- ", modelState.Select(x => x.Value?.Errors))}" : "";
}
