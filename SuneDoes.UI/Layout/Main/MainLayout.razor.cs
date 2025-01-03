﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SuneDoes.UI.Session;

namespace SuneDoes.UI.Layout.Main;

public partial class MainLayout
{
    [Inject]
    public IServiceScopeFactory ScopeFactory { get; set; }

    [Inject]
    public IJSRuntime Js { get; set; }

    private SessionState? _sessionState;
    

    protected override Task OnParametersSetAsync()
    {
        _sessionState = new SessionState(() => InvokeAsync(StateHasChanged), ScopeFactory);
        return base.OnParametersSetAsync();
    }
}
