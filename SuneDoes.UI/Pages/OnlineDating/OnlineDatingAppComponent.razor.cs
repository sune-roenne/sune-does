﻿using Microsoft.AspNetCore.Components;
using SuneDoes.UI.Components;
using SuneDoes.UI.Session;

namespace SuneDoes.UI.Pages.OnlineDating;

public partial class OnlineDatingAppComponent
{
    private const int NumberOfImagePositions = 6;

    [CascadingParameter]
    public SessionState SessionState { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment Text { get; set; }

    [Parameter]
    public RenderFragment AppLogo { get; set; }

    [Parameter]
    public IReadOnlyCollection<ImageShowComponent.ShowImage> Images { get; set; }

    private void OnImagesClick() => SessionState.ShowImages(
        curremtShowImagesTitle: $"{Title}",
        images: [.. Images]
        );


}