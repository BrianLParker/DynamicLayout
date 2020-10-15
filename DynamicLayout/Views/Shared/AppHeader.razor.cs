// ---------------------------------------------------------------
// Copyright (c) Brian Parker. All rights reserved.
// Licensed under the MIT License.
// ---------------------------------------------------------------

namespace DynamicLayout.Views.Shared
{
    using DynamicLayout.Services;
    using Microsoft.AspNetCore.Components;

    public partial class AppHeader
    {
    [Inject]
    public ILayoutService LayoutService { get; set; }

    protected override void OnInitialized()
    {
        LayoutService.PropertyChanged += LayoutService_PropertyChanged;
        base.OnInitialized();
    }

    private void LayoutService_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(ILayoutService.Header))
        {
            StateHasChanged();
        }
    }
    }
}